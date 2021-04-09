Imports System.DirectoryServices
Imports System.Text.RegularExpressions

Namespace Models

	Public Class ADUser
		Implements IComparable(Of ADUser)
		Private Shared R As New Regex("OU=(?<name>.*?),|CN=(?<name>.*?),")

		Private Sub New(User As SearchResult)
			Name = User.TryGetStr("displayName")
			Login = User.TryGetStr("sAMAccountName")
			DistinguishedName = User.TryGetStr("distinguishedName")
			LastLogon = Date.FromFileTime(User.TryGetLong("lastlogon"))
			Path = R.Matches(DistinguishedName).Cast(Of Match).Skip(1).Select(Function(m) m.Groups("name").Value).Reverse.ToList()
		End Sub

		Public Property DistinguishedName As String
		Public Property LastComputer As String
		Public Property LastLogon As Date
		Public Property Login As String
		Public Property Name As String
		Public Property Path As List(Of String)

		Public Shared Function FindComputers(entry As DirectoryEntry) As List(Of ADUser)
			Dim Users As New List(Of ADUser)
			Using mySearcher = New DirectorySearcher(entry)
				mySearcher.Filter = ("(&(objectClass=user)(objectClass=person)(!(objectClass=computer)))") 'Напоминает (((Lisp)))
				mySearcher.SizeLimit = 0 ' No size limit, reads all objects
				mySearcher.PageSize = 250 ' Read data in pages of 250 objects. Make sure this value Is below the limit configured in your AD domain (if there Is a limit)

				' Let searcher know which properties are going to be used, And only load those
				mySearcher.PropertiesToLoad.Add("displayName")
				mySearcher.PropertiesToLoad.Add("sAMAccountName")
				mySearcher.PropertiesToLoad.Add("distinguishedName")
				mySearcher.PropertiesToLoad.Add("lastlogon")
				Dim Result = mySearcher.FindAll()
				Users = Result.Cast(Of SearchResult).AsParallel.Where(Function(R) R.Properties("displayName").Count > 0).Select(Function(R) New ADUser(R)).ToList()
			End Using
			Return Users
		End Function

		Public Function CompareTo(other As ADUser) As Integer Implements IComparable(Of ADUser).CompareTo
			If IsNothing(other) Then
				Return 1
			Else
				Return Name.CompareTo(other.Name)
			End If
		End Function

	End Class
End Namespace