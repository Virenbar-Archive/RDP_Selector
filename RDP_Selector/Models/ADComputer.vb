Imports System.DirectoryServices

Namespace Models

	Public Class ADComputer
		Implements IComparable(Of ADComputer)

		Public Sub New(PC As SearchResult)
			Name = PC.TryGetStr("name")
			HostName = PC.TryGetStr("dNSHostName")
			LastLogon = Date.FromFileTime(PC.TryGetLong("lastlogon"))
			IPs = TryGetIP(HostName)
		End Sub

		Public Property HostName As String
		Public Property IPs As List(Of String)
		Public Property LastLogon As Date
		Public Property Name As String
		Public Property Sessions As List(Of Session)

		Public Shared Function FindComputers(entry As DirectoryEntry) As List(Of ADComputer)
			Dim Computers = New List(Of ADComputer)
			Using mySearcher = New DirectorySearcher(entry)
				mySearcher.Filter = ("(objectClass=computer)")
				mySearcher.SizeLimit = 0 ' No size limit, reads all objects
				mySearcher.PageSize = 250 ' Read data in pages of 250 objects. Make sure this value Is below the limit configured in your AD domain (if there Is a limit)

				' Let searcher know which properties are going to be used, And only load those
				mySearcher.PropertiesToLoad.Add("name")
				mySearcher.PropertiesToLoad.Add("dNSHostName")
				mySearcher.PropertiesToLoad.Add("lastlogon")
				Dim Result = mySearcher.FindAll()
				Computers = Result.Cast(Of SearchResult).AsParallel.Where(Function(R) R.Properties("name").Count > 0).Select(Function(R) New ADComputer(R)).ToList()
			End Using
			Return Computers
		End Function

		Public Shared Function TryGetIP(host As String) As List(Of String)
			Try
				Dim IPs = Net.Dns.GetHostAddresses(host)
				If IPs.Count > 0 Then Return IPs.Select(Function(IP) IP.ToString).ToList()
				Return New List(Of String)({"IP не найден"})
			Catch ex As Exception
				Return New List(Of String)({"IP не найден"})
			End Try
		End Function

		Public Function CompareTo(other As ADComputer) As Integer Implements IComparable(Of ADComputer).CompareTo
			If IsNothing(other) Then
				Return 1
			Else
				Return Name.CompareTo(other.Name)
			End If
		End Function

		Public Async Function FindSessions(PP As IProgress(Of String)) As Task
			Sessions = Nothing
			Try
				PP.Report("Поиск сессий")
				Sessions = Await Task.Run(Function() Session.FindSessions(HostName).Where(Function(s) s.ID < 65000).ToList)
				PP.Report($"Найдено сессий: {Sessions.Count}")
			Catch ex As UnauthorizedAccessException
				PP.Report("Отказано в доступе")
			Catch ex As Exception
				PP.Report(ex.Message)
			End Try

		End Function

	End Class
End Namespace