Imports System.Diagnostics.Eventing.Reader

Namespace Models

	Public Class LoginEvent

		Public Sub New(Record As EventRecord)
			'Message = Record.FormatDescription ' Тормозная хрень (50ms VS 100s)
			Username = Record.Properties(Props.Username).Value.ToString
			PCName = Record.Properties(Props.PCName).Value.ToString
			PCIP = Record.Properties(Props.PCIP).Value.ToString
			LoginDate = Record.TimeCreated
		End Sub

		Public Property Message As String
		Public Property Username As String
		Public Property PCName As String
		Public Property PCIP As String
		Public Property LoginDate As Date?

		Private Enum Props As Integer
			Username = 5
			Domain = 6
			PCName = 17
			PCIP = 18
		End Enum

		Public Overrides Function ToString() As String
			'User: {Username}
			Return $"Date:{LoginDate:dd.MM.yyyy HH:mm} - {PCIP} {PCName}"
		End Function

	End Class
End Namespace