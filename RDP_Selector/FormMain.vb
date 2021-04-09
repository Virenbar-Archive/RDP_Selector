Imports RDP_Selector.Models
Imports RDP_Selector.VLibrary

Public Class FormMain
	Private WithEvents PP As Progress(Of String)
	Private ReadOnly CTR As List(Of Control)
	Private SessionID As Integer

	Public Sub New()

		' Этот вызов является обязательным для конструктора.
		InitializeComponent()
		' Добавить код инициализации после вызова InitializeComponent().
		CTR = New List(Of Control)({B_Domain, B_Refresh, TB_Search, B_Clear, TV_Users, TLP_Info})
		TB_Log.Visible = My.Application.IsDebug
	End Sub

#Region "UI Handlers"

	Private Sub B_Clear_Click(sender As Object, e As EventArgs) Handles B_Clear.Click
		TB_Search.Clear()
	End Sub

	Private Sub B_Connect_Click(sender As Object, e As EventArgs) Handles B_Connect.Click
		Connect()
	End Sub

	Private Async Sub B_Domain_Click(sender As Object, e As EventArgs) Handles B_Domain.Click
		SetStatus("Подключение к домену")
		SetUIState(False)
		If AD.SetDomain(TB_Domain.Text) Then
			SetUIState(True)
			Await RefreshList()
		Else
			SetStatus("Не удалось подключиться к домену")
			SetUIState(False)
		End If
		B_Domain.Enabled = True
	End Sub

	Private Async Sub B_Refresh_Click(sender As Object, e As EventArgs) Handles B_Refresh.Click
		Await RefreshList()
	End Sub

	Private Sub FormMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		My.Settings.Shadow = CB_Shadow.Checked
		My.Settings.Control = CB_Control.Checked
		My.Settings.FullScreen = CB_FullScreen.Checked
	End Sub

	Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		AD.Init()
		TB_Domain.Text = AD.DomainName
		CB_Shadow.Checked = My.Settings.Shadow
		CB_Control.Checked = My.Settings.Control
		CB_FullScreen.Checked = My.Settings.FullScreen
	End Sub

	Private Async Sub FormMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
		Await RefreshList()
	End Sub

	Private Async Sub LB_Logins_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Logins.SelectedIndexChanged
		Dim Login = DirectCast(LB_Logins.SelectedItem, LoginEvent)
		Dim Computer = AD.Computers.Where(Function(C) C.IPs.Contains(Login.PCIP)).FirstOrDefault
		If Computer Is Nothing Then
			B_Connect.Enabled = False
		Else
			Await Computer.FindSessions(PP)
			BS_Computer.DataSource = Computer
			If Computer.Sessions Is Nothing Then
				CB_UseSession.Checked = False
				CB_UseSession.Enabled = False
			Else
				LB_Sessions.SelectedIndex = 0
				CB_UseSession.Enabled = True
			End If
			B_Connect.Enabled = True
		End If
	End Sub

	Private Sub TB_Search_TextChanged(sender As Object, e As EventArgs) Handles TB_Search.TextChanged
		UpdateTree()
	End Sub

	Private Async Sub TSMI_Refresh_Click(sender As Object, e As EventArgs) Handles TSMI_Refresh.Click
		Await RefreshList()
	End Sub

	Private Sub TV_Users_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TV_Users.AfterSelect
		If TV_Users.SelectedNode.Tag Is Nothing Then Exit Sub
		Dim User = DirectCast(TV_Users.SelectedNode.Tag, ADUser)
		BS_User.DataSource = User
		Dim Logins = AD.Logins.Where(Function(L) L.Username.ToLower.Contains(User.Login.ToLower)).Reverse.ToList()
		LB_Logins.DataSource = Logins
		If Logins.Count = 0 Then
			GB_Computer.Enabled = False
			BS_Computer.DataSource = GetType(ADComputer)
		Else
			GB_Computer.Enabled = True
		End If
	End Sub

	Private Sub LB_Sessions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Sessions.SelectedIndexChanged
		If LB_Sessions.SelectedItem Is Nothing Then Exit Sub
		Dim Session = DirectCast(LB_Sessions.SelectedItem, Session)
		SessionID = Session.ID

	End Sub

#End Region

	Private Sub Connect()
		Dim PC = DirectCast(BS_Computer.DataSource, ADComputer)
		Dim ID = DirectCast(BS_Sessions.Current, Session)
		Dim rdp = New ProcessStartInfo("mstsc.exe")
		Dim Args = New List(Of String) From {$"/v:{PC.Name}"}
		If CB_Promt.Checked Then Args.Add("/prompt")
		If CB_UseSession.Checked Then Args.Add($"/shadow:{SessionID}")
		If CB_Control.Checked Then Args.Add("/control")
		If CB_FullScreen.Checked Then Args.Add("/f")
		rdp.Arguments = String.Join(" ", Args)
		Process.Start(rdp)
		' Process.Start($"Mstsc.exe /shadow:1 /v:{computer} /prompt /Control")
	End Sub

	Private Sub PP_ProgressChanged(sender As Object, e As String) Handles PP.ProgressChanged
		SetStatus(e)
	End Sub

	Private Async Function RefreshList() As Task
		Try
			SetUIState(False)
			PP = New Progress(Of String)()
			Await AD.Refresh(PP)
			UpdateTree()
			Enabled = True
		Catch ex As Exception
			Msgs.ShowError(ex)
		Finally
			SetUIState(True)
			SetStatus("")
		End Try
	End Function

	Private Sub SetStatus(text As String)
		L_Status.Text = text
	End Sub

	Private Sub SetUIState(State As Boolean)
		CTR.ForEach(Sub(c) c.Enabled = State)
	End Sub

	Private Sub UpdateTree()
		SetStatus("Постройка дерева")
		Dim S = TB_Search.Text.ToLower
		TV_Users.BeginUpdate()
		TV_Users.Nodes.Clear()
		Dim Root = TV_Users.Nodes.Add("Root", AD.DomainName)
		For Each user In AD.Users.Where(Function(u) S = "" OrElse u.Login.ToLower.Contains(S) OrElse u.Name.ToLower.Contains(S))
			Dim T = Root
			For Each P In user.Path
				If T.Nodes.ContainsKey(P) Then
					T = T.Nodes.Item(P)
				Else
					T = T.Nodes.Add(P, P)
				End If
			Next
			T.Nodes.Add(New TreeNode($"{user.Name} ({user.Login})") With {.Tag = user})
			'T.Nodes.Add(user.Login, user.Name).Tag = user
		Next
		If TB_Search.Text.Length > 2 Then
			TV_Users.ExpandAll()
		Else
			Root.Expand()
		End If
		TV_Users.EndUpdate()
		SetStatus("")
	End Sub

	Public Sub Log(str As String)
		TB_Log.AppendText(str + vbNewLine)
	End Sub

End Class