Imports System.DirectoryServices
Imports System.Runtime.CompilerServices

Module Extensions

	<Extension>
	Public Function TryGetStr(search As SearchResult, prop As String) As String
		Return If(search.Properties(prop).Count > 0, search.Properties(prop)(0).ToString, "")
	End Function

	<Extension>
	Public Function TryGetLong(search As SearchResult, prop As String) As Long
		Return If(search.Properties(prop).Count > 0, CLng(search.Properties(prop)(0)), 0)
	End Function

End Module