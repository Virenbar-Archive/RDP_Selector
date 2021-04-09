Imports System.Globalization
Imports System.Text
Imports System.Text.RegularExpressions

Namespace Models

	Public Class Session

		Private Shared ReadOnly R As New Regex("(?<name>\S+)\s+(?<user>\S*)\s+(?<id>\d+)\s+(?<state>\S+)")

		Private Sub New()

		End Sub

		Public Property ID As Integer
		Public Property Name As String
		Public Property State As String
		Public Property User As String

		Public Shared Function FindSessions(Hostname As String) As List(Of Session)
			Dim Sessions As List(Of Session)
			Dim Enc = Encoding.GetEncoding(CultureInfo.CurrentCulture.TextInfo.OEMCodePage) 'Encoding.GetEncoding(866)
			Dim StartInfo = New ProcessStartInfo With {
				.FileName = If(Environment.Is64BitProcess, "cmd.exe", Environment.ExpandEnvironmentVariables("%windir%\sysnative\cmd.exe")),
				.Arguments = $"/c qwinsta /server:{Hostname}",
				.UseShellExecute = False,
				.CreateNoWindow = True,
				.RedirectStandardOutput = True,
				.RedirectStandardError = True,
				.StandardOutputEncoding = Enc,
				.StandardErrorEncoding = Enc}

			Using qwinsta = Process.Start(StartInfo)
				Dim Err = qwinsta.StandardError.ReadToEnd()
				If Err.Count > 0 Then
					My.Application.LogText(Err)
					Throw New UnauthorizedAccessException(Err)
				End If

				Dim output = qwinsta.StandardOutput.ReadToEnd()
				Dim Lines = output.Split({vbNewLine}, StringSplitOptions.RemoveEmptyEntries).Skip(1)
				Sessions = Lines.Select(
				Function(x)
					Dim M = R.Match(x.Trim)
					Return New Session() With {
						.Name = M.Groups("name").Value,
						.User = M.Groups("user").Value,
						.ID = CInt(M.Groups("id").Value),
						.State = M.Groups("state").Value}
				End Function).ToList()
				qwinsta.WaitForExit()
			End Using
			Return Sessions
		End Function

		Public Overrides Function ToString() As String
			Return $"{ID.ToString.PadRight(5)} {Name.PadRight(15)} {User.PadRight(15)} {State.PadRight(10)}"
		End Function

	End Class
End Namespace