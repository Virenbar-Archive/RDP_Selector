Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.Devices
Imports RDP_Selector.VLibrary

Namespace My

	' Для MyApplication имеются следующие события:
	' Startup: возникает при запуске приложения перед созданием начальной формы.
	' Shutdown: возникает после закрытия всех форм приложения.  Это событие не создается, если происходит аварийное завершение работы приложения.
	' UnhandledException: возникает, если в приложении обнаруживается необработанное исключение.
	' StartupNextInstance: возникает при запуске приложения, допускающего одновременное выполнение только одного экземпляра, если это приложение уже активно.
	' NetworkAvailabilityChanged: возникает при изменении состояния подключения — при подключении или отключении.
	Partial Friend Class MyApplication
		Private Shared PP As IProgress(Of String)

		Private Params As New Dictionary(Of String, (NeedArg As Boolean, Action As Action(Of String))) From {
			{"-debug", (False, AddressOf Debug)},
			{"-username", (True, AddressOf SetUsername)},
			{"-password", (True, AddressOf SetPassword)}}

		Public Sub LogText(str As String)
			PP.Report(str)
		End Sub

		Private Sub MyApplication_NetworkAvailabilityChanged(sender As Object, e As NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged
			If Not e.IsNetworkAvailable Then
				Msgs.ShowError("Ваша сеть сдохла")
			End If
		End Sub

		Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
			PP = New Progress(Of String)()
			Try
				For Each Arg In e.CommandLine
					Dim S = Arg.Split(":"c)
					Dim Key = S(0).ToLower
					If Params.Keys.Contains(Key) Then
						Dim Param = Params(Key)
						Param.Action(If(Param.NeedArg, S(1), Nothing))
					End If
				Next
			Catch ex As ArgumentException
				Msgs.ShowError(ex.Message)
				e.Cancel = True
			Catch ex As Exception
				Msgs.ShowError("Invalid arguments")
				e.Cancel = True
			End Try
		End Sub

#Region "Properties"
		Private _isDebug As Boolean
		Private _password As String
		Private _username As String

		Public Property IsDebug As Boolean
			Get
				Return _isDebug
			End Get
			Private Set(value As Boolean)
				_isDebug = value
			End Set
		End Property

		Public Property Password As String
			Get
				Return _password
			End Get
			Private Set(value As String)
				_password = value
			End Set
		End Property

		Public Property Username As String
			Get
				Return _username
			End Get
			Private Set(value As String)
				_username = value
			End Set
		End Property

#End Region

#Region "Parameters"

		Private Sub Debug(arg As String)
			IsDebug = True
			PP = New Progress(Of String)(
			Sub(str)
				DirectCast(Application.OpenForms(0), FormMain).Log(str)
			End Sub)
		End Sub

		Private Sub SetPassword(arg As String)
			If arg = "" Then Throw New ArgumentException("Password is empty")
			Password = arg
		End Sub

		Private Sub SetUsername(arg As String)
			If arg = "" Then Throw New ArgumentException("Username is empty")
			Username = arg
		End Sub

#End Region

	End Class
End Namespace