'Imports System.Management.Automation
Imports System.Diagnostics.Eventing.Reader
Imports System.DirectoryServices
Imports RDP_Selector.Models
Imports RDP_Selector.VLibrary

Public Class AD
	Private Const LoginEvent = "*[System/EventID=4624]"
	Private Shared AD As DirectoryEntry
	Private Shared ADHostname As String

	Private Shared ComputerList As List(Of ADComputer)
	Private Shared LoginList As List(Of LoginEvent)
	Private Shared UserList As List(Of ADUser)

#Region "Properties"

	Public Shared ReadOnly Property Computers As List(Of ADComputer)
		Get
			Return ComputerList
		End Get
	End Property

	Public Shared ReadOnly Property DomainName As String
		Get
			Return AD.Name.Replace("DC=", "")
		End Get
	End Property

	Public Shared ReadOnly Property Logins As List(Of LoginEvent)
		Get
			Return LoginList
		End Get
	End Property

	Public Shared ReadOnly Property Users As List(Of ADUser)
		Get
			Return UserList
		End Get
	End Property

#End Region

	Public Shared Sub Init()
		Try
			AD = ActiveDirectory.Domain.GetCurrentDomain().GetDirectoryEntry
			ADHostname = AD.Options.GetCurrentServerName()
		Catch ex As Exception
			Msgs.ShowError("Компьютер не состоит в доменной сети.")
			Application.Exit()
		End Try
	End Sub

	Public Shared Async Function Refresh(PP As IProgress(Of String)) As Task
		PP.Report("Обновление списка пользователей")
		Await Task.Run(AddressOf RefreshUserList)
		PP.Report("Обновление истории входов")
		Await Task.Run(AddressOf RefreshLoginList)
		PP.Report("Обновление списка компьютеров")
		Await Task.Run(AddressOf RefreshComputerList)
		ComputerList.Sort()
	End Function

	Public Shared Function SetDomain(domain As String) As Boolean
		Try
			Dim ADTest = New DirectoryEntry($"LDAP://{domain}")
			Dim ADHost = ADTest.Options.GetCurrentServerName()

			AD.Dispose()
			AD = ADTest
			ADHostname = ADHost
			Return True
		Catch ex As Exception
			Return False
		End Try
	End Function

	Private Shared Sub RefreshComputerList()
		ComputerList = ADComputer.FindComputers(AD)
		ComputerList.Sort()
		'Dim t1 = ComputerList.Where(Function(C) C.HostName.ToLower.Contains("ryba"))
		'Dim t2 = ComputerList.Where(Function(C) C.HostName.ToLower.Contains("tyut"))
	End Sub

	Private Shared Sub RefreshLoginList()
		Dim EventsQuery = New EventLogQuery("Security", PathType.LogName, LoginEvent) With {.Session = New EventLogSession(ADHostname)}
		Dim LogReader = New EventLogReader(EventsQuery)

		Dim Records As New List(Of EventRecord)
		Dim ER = LogReader.ReadEvent()
		While ER IsNot Nothing
			Records.Add(ER)
			ER = LogReader.ReadEvent()
		End While
		LoginList = Records.AsParallel.Select(Function(R) New LoginEvent(R)).ToList()
		'Dim t = LoginList.Where(Function(E) E.Username.ToLower.Contains("ryba"))
	End Sub

	Private Shared Sub RefreshUserList()
		UserList = ADUser.FindComputers(AD)
		UserList.Sort()
		'Dim Mt = UserList.Where(Function(u) u.Login = "AVRybakov").ToList()
	End Sub

End Class