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
		Public IsDebug As Boolean

		Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
			IsDebug = e.CommandLine.Contains("-debug")
			If IsDebug Then
				PP = New Progress(Of String)(
				Sub(str)
					DirectCast(OpenForms(0), FormMain).Log(str)
				End Sub)
			Else
				PP = New Progress(Of String)()
			End If
		End Sub

		Private Sub MyApplication_NetworkAvailabilityChanged(sender As Object, e As NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged
			If Not e.IsNetworkAvailable Then
				Msgs.ShowError("Ваша сеть сдохла")
			End If
		End Sub

		Public Sub LogText(str As String)
			PP.Report(str)
		End Sub

	End Class
End Namespace