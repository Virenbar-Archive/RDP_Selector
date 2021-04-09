<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("8=====D")
		Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Тут могла быть ваша реклама", New System.Windows.Forms.TreeNode() {TreeNode1})
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
		Me.CB_Control = New System.Windows.Forms.CheckBox()
		Me.B_Connect = New System.Windows.Forms.Button()
		Me.CB_Shadow = New System.Windows.Forms.CheckBox()
		Me.NUD_ID = New System.Windows.Forms.NumericUpDown()
		Me.CB_FullScreen = New System.Windows.Forms.CheckBox()
		Me.TV_Users = New System.Windows.Forms.TreeView()
		Me.TB_Search = New System.Windows.Forms.TextBox()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.BS_User = New System.Windows.Forms.BindingSource(Me.components)
		Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TLP_Tree = New System.Windows.Forms.TableLayoutPanel()
		Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
		Me.B_Refresh = New System.Windows.Forms.Button()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.TB_Domain = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.B_Domain = New System.Windows.Forms.Button()
		Me.B_Clear = New System.Windows.Forms.Button()
		Me.SS = New System.Windows.Forms.StatusStrip()
		Me.L_Status = New System.Windows.Forms.ToolStripStatusLabel()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.TSMI_Refresh = New System.Windows.Forms.ToolStripMenuItem()
		Me.LB_Logins = New System.Windows.Forms.ListBox()
		Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.BS_Computer = New System.Windows.Forms.BindingSource(Me.components)
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.LB_IPs = New System.Windows.Forms.ListBox()
		Me.BS_IPs = New System.Windows.Forms.BindingSource(Me.components)
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.GB_User = New System.Windows.Forms.GroupBox()
		Me.GB_Computer = New System.Windows.Forms.GroupBox()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		Me.CB_UseSession = New System.Windows.Forms.CheckBox()
		Me.CB_Promt = New System.Windows.Forms.CheckBox()
		Me.GP_Sessions = New System.Windows.Forms.GroupBox()
		Me.LB_Sessions = New System.Windows.Forms.ListBox()
		Me.BS_Sessions = New System.Windows.Forms.BindingSource(Me.components)
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.TLP_Info = New System.Windows.Forms.TableLayoutPanel()
		Me.TB_Log = New System.Windows.Forms.TextBox()
		CType(Me.NUD_ID, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BS_User, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.TableLayoutPanel1.SuspendLayout()
		Me.TLP_Tree.SuspendLayout()
		Me.TableLayoutPanel2.SuspendLayout()
		Me.SS.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		Me.TableLayoutPanel3.SuspendLayout()
		CType(Me.BS_Computer, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BS_IPs, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.GB_User.SuspendLayout()
		Me.GB_Computer.SuspendLayout()
		Me.Panel1.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.GP_Sessions.SuspendLayout()
		CType(Me.BS_Sessions, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox3.SuspendLayout()
		Me.TLP_Info.SuspendLayout()
		Me.SuspendLayout()
		'
		'CB_Control
		'
		Me.CB_Control.AutoSize = True
		Me.CB_Control.Location = New System.Drawing.Point(3, 49)
		Me.CB_Control.Name = "CB_Control"
		Me.CB_Control.Size = New System.Drawing.Size(144, 17)
		Me.CB_Control.TabIndex = 0
		Me.CB_Control.Text = "Удаленное управление"
		Me.CB_Control.UseVisualStyleBackColor = True
		'
		'B_Connect
		'
		Me.B_Connect.Location = New System.Drawing.Point(3, 6)
		Me.B_Connect.Name = "B_Connect"
		Me.B_Connect.Size = New System.Drawing.Size(94, 23)
		Me.B_Connect.TabIndex = 1
		Me.B_Connect.Text = "Подключить"
		Me.B_Connect.UseVisualStyleBackColor = True
		'
		'CB_Shadow
		'
		Me.CB_Shadow.AutoSize = True
		Me.CB_Shadow.Location = New System.Drawing.Point(-5, 35)
		Me.CB_Shadow.Name = "CB_Shadow"
		Me.CB_Shadow.Size = New System.Drawing.Size(99, 17)
		Me.CB_Shadow.TabIndex = 8
		Me.CB_Shadow.Text = "Номер сессии"
		Me.CB_Shadow.UseVisualStyleBackColor = True
		Me.CB_Shadow.Visible = False
		'
		'NUD_ID
		'
		Me.NUD_ID.Location = New System.Drawing.Point(42, 58)
		Me.NUD_ID.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.NUD_ID.Name = "NUD_ID"
		Me.NUD_ID.Size = New System.Drawing.Size(42, 20)
		Me.NUD_ID.TabIndex = 9
		Me.NUD_ID.Value = New Decimal(New Integer() {1, 0, 0, 0})
		Me.NUD_ID.Visible = False
		'
		'CB_FullScreen
		'
		Me.CB_FullScreen.AutoSize = True
		Me.CB_FullScreen.Location = New System.Drawing.Point(3, 72)
		Me.CB_FullScreen.Name = "CB_FullScreen"
		Me.CB_FullScreen.Size = New System.Drawing.Size(145, 17)
		Me.CB_FullScreen.TabIndex = 10
		Me.CB_FullScreen.Text = "Полноэкранный режим"
		Me.CB_FullScreen.UseVisualStyleBackColor = True
		'
		'TV_Users
		'
		Me.TV_Users.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TV_Users.Location = New System.Drawing.Point(5, 69)
		Me.TV_Users.Name = "TV_Users"
		TreeNode1.Name = "Узел1"
		TreeNode1.Text = "8=====D"
		TreeNode2.Name = "Узел0"
		TreeNode2.Text = "Тут могла быть ваша реклама"
		Me.TV_Users.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2})
		Me.TV_Users.Size = New System.Drawing.Size(411, 285)
		Me.TV_Users.TabIndex = 11
		'
		'TB_Search
		'
		Me.TB_Search.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.TB_Search.Location = New System.Drawing.Point(51, 33)
		Me.TB_Search.Name = "TB_Search"
		Me.TB_Search.Size = New System.Drawing.Size(171, 20)
		Me.TB_Search.TabIndex = 12
		'
		'TextBox1
		'
		Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_User, "Login", True))
		Me.TextBox1.Location = New System.Drawing.Point(98, 29)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ReadOnly = True
		Me.TextBox1.Size = New System.Drawing.Size(274, 20)
		Me.TextBox1.TabIndex = 13
		'
		'BS_User
		'
		Me.BS_User.DataSource = GetType(RDP_Selector.Models.ADUser)
		'
		'TableLayoutPanel1
		'
		Me.TableLayoutPanel1.AutoSize = True
		Me.TableLayoutPanel1.ColumnCount = 2
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.TextBox4, 1, 0)
		Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 2)
		Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 1, 1)
		Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 1, 2)
		Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
		Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
		Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
		Me.TableLayoutPanel1.RowCount = 3
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel1.Size = New System.Drawing.Size(375, 78)
		Me.TableLayoutPanel1.TabIndex = 14
		'
		'Label6
		'
		Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(63, 6)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(29, 13)
		Me.Label6.TabIndex = 23
		Me.Label6.Text = "Имя"
		'
		'TextBox4
		'
		Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_User, "Name", True))
		Me.TextBox4.Location = New System.Drawing.Point(98, 3)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.ReadOnly = True
		Me.TextBox4.Size = New System.Drawing.Size(274, 20)
		Me.TextBox4.TabIndex = 23
		'
		'Label2
		'
		Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(3, 58)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(89, 13)
		Me.Label2.TabIndex = 16
		Me.Label2.Text = "Последний вход"
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(54, 32)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(38, 13)
		Me.Label1.TabIndex = 14
		Me.Label1.Text = "Логин"
		'
		'TextBox2
		'
		Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_User, "LastLogon", True))
		Me.TextBox2.Location = New System.Drawing.Point(98, 55)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.ReadOnly = True
		Me.TextBox2.Size = New System.Drawing.Size(274, 20)
		Me.TextBox2.TabIndex = 15
		'
		'TLP_Tree
		'
		Me.TLP_Tree.ColumnCount = 1
		Me.TLP_Tree.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLP_Tree.Controls.Add(Me.TableLayoutPanel2, 0, 0)
		Me.TLP_Tree.Controls.Add(Me.TV_Users, 0, 1)
		Me.TLP_Tree.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TLP_Tree.Location = New System.Drawing.Point(0, 0)
		Me.TLP_Tree.Name = "TLP_Tree"
		Me.TLP_Tree.Padding = New System.Windows.Forms.Padding(2)
		Me.TLP_Tree.RowCount = 2
		Me.TLP_Tree.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TLP_Tree.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLP_Tree.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
		Me.TLP_Tree.Size = New System.Drawing.Size(421, 359)
		Me.TLP_Tree.TabIndex = 15
		'
		'TableLayoutPanel2
		'
		Me.TableLayoutPanel2.AutoSize = True
		Me.TableLayoutPanel2.ColumnCount = 4
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel2.Controls.Add(Me.B_Refresh, 3, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.Label7, 0, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.TB_Search, 1, 1)
		Me.TableLayoutPanel2.Controls.Add(Me.TB_Domain, 1, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 1)
		Me.TableLayoutPanel2.Controls.Add(Me.B_Domain, 2, 0)
		Me.TableLayoutPanel2.Controls.Add(Me.B_Clear, 2, 1)
		Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 5)
		Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
		Me.TableLayoutPanel2.RowCount = 2
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel2.Size = New System.Drawing.Size(395, 58)
		Me.TableLayoutPanel2.TabIndex = 11
		'
		'B_Refresh
		'
		Me.B_Refresh.AutoSize = True
		Me.B_Refresh.Location = New System.Drawing.Point(313, 3)
		Me.B_Refresh.Name = "B_Refresh"
		Me.B_Refresh.Size = New System.Drawing.Size(79, 23)
		Me.B_Refresh.TabIndex = 26
		Me.B_Refresh.Text = "Обновить"
		Me.B_Refresh.UseVisualStyleBackColor = True
		'
		'Label7
		'
		Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(3, 8)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(42, 13)
		Me.Label7.TabIndex = 20
		Me.Label7.Text = "Домен"
		'
		'TB_Domain
		'
		Me.TB_Domain.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.TB_Domain.Location = New System.Drawing.Point(51, 4)
		Me.TB_Domain.Name = "TB_Domain"
		Me.TB_Domain.Size = New System.Drawing.Size(171, 20)
		Me.TB_Domain.TabIndex = 0
		'
		'Label3
		'
		Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(6, 37)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(39, 13)
		Me.Label3.TabIndex = 17
		Me.Label3.Text = "Поиск"
		'
		'B_Domain
		'
		Me.B_Domain.AutoSize = True
		Me.B_Domain.Location = New System.Drawing.Point(228, 3)
		Me.B_Domain.Name = "B_Domain"
		Me.B_Domain.Size = New System.Drawing.Size(79, 23)
		Me.B_Domain.TabIndex = 18
		Me.B_Domain.Text = "Подключить"
		Me.B_Domain.UseVisualStyleBackColor = True
		'
		'B_Clear
		'
		Me.B_Clear.Location = New System.Drawing.Point(228, 32)
		Me.B_Clear.Name = "B_Clear"
		Me.B_Clear.Size = New System.Drawing.Size(75, 23)
		Me.B_Clear.TabIndex = 19
		Me.B_Clear.Text = "Очистить"
		Me.B_Clear.UseVisualStyleBackColor = True
		'
		'SS
		'
		Me.SS.BackColor = System.Drawing.SystemColors.Control
		Me.SS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.L_Status})
		Me.SS.Location = New System.Drawing.Point(0, 540)
		Me.SS.Name = "SS"
		Me.SS.Size = New System.Drawing.Size(808, 22)
		Me.SS.TabIndex = 16
		Me.SS.Text = "StatusStrip1"
		'
		'L_Status
		'
		Me.L_Status.Name = "L_Status"
		Me.L_Status.Size = New System.Drawing.Size(16, 17)
		Me.L_Status.Text = "..."
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_Refresh})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(874, 24)
		Me.MenuStrip1.TabIndex = 17
		Me.MenuStrip1.Text = "MenuStrip1"
		Me.MenuStrip1.Visible = False
		'
		'TSMI_Refresh
		'
		Me.TSMI_Refresh.Name = "TSMI_Refresh"
		Me.TSMI_Refresh.Size = New System.Drawing.Size(73, 20)
		Me.TSMI_Refresh.Text = "Обновить"
		'
		'LB_Logins
		'
		Me.LB_Logins.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LB_Logins.FormattingEnabled = True
		Me.LB_Logins.Location = New System.Drawing.Point(3, 16)
		Me.LB_Logins.Name = "LB_Logins"
		Me.LB_Logins.Size = New System.Drawing.Size(369, 85)
		Me.LB_Logins.TabIndex = 18
		'
		'TableLayoutPanel3
		'
		Me.TableLayoutPanel3.AutoSize = True
		Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.TableLayoutPanel3.ColumnCount = 2
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.TextBox3, 1, 0)
		Me.TableLayoutPanel3.Controls.Add(Me.TextBox5, 1, 1)
		Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 1)
		Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
		Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
		Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
		Me.TableLayoutPanel3.RowCount = 2
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanel3.Size = New System.Drawing.Size(375, 52)
		Me.TableLayoutPanel3.TabIndex = 21
		'
		'Label5
		'
		Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(30, 6)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(29, 13)
		Me.Label5.TabIndex = 14
		Me.Label5.Text = "Имя"
		'
		'TextBox3
		'
		Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_Computer, "Name", True))
		Me.TextBox3.Location = New System.Drawing.Point(65, 3)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.ReadOnly = True
		Me.TextBox3.Size = New System.Drawing.Size(307, 20)
		Me.TextBox3.TabIndex = 13
		'
		'BS_Computer
		'
		Me.BS_Computer.DataSource = GetType(RDP_Selector.Models.ADComputer)
		'
		'TextBox5
		'
		Me.TextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_Computer, "HostName", True))
		Me.TextBox5.Location = New System.Drawing.Point(65, 29)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.ReadOnly = True
		Me.TextBox5.Size = New System.Drawing.Size(307, 20)
		Me.TextBox5.TabIndex = 17
		'
		'Label4
		'
		Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(3, 32)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(56, 13)
		Me.Label4.TabIndex = 16
		Me.Label4.Text = "Дом. имя"
		'
		'LB_IPs
		'
		Me.LB_IPs.DataSource = Me.BS_IPs
		Me.LB_IPs.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LB_IPs.FormattingEnabled = True
		Me.LB_IPs.Location = New System.Drawing.Point(3, 16)
		Me.LB_IPs.MultiColumn = True
		Me.LB_IPs.Name = "LB_IPs"
		Me.LB_IPs.Size = New System.Drawing.Size(369, 35)
		Me.LB_IPs.TabIndex = 22
		'
		'BS_IPs
		'
		Me.BS_IPs.DataMember = "IPs"
		Me.BS_IPs.DataSource = Me.BS_Computer
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.LB_Logins)
		Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.GroupBox1.Location = New System.Drawing.Point(3, 94)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(375, 104)
		Me.GroupBox1.TabIndex = 22
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "История входов"
		'
		'GB_User
		'
		Me.GB_User.Controls.Add(Me.GroupBox1)
		Me.GB_User.Controls.Add(Me.TableLayoutPanel1)
		Me.GB_User.Location = New System.Drawing.Point(3, 3)
		Me.GB_User.Name = "GB_User"
		Me.GB_User.Size = New System.Drawing.Size(381, 201)
		Me.GB_User.TabIndex = 23
		Me.GB_User.TabStop = False
		Me.GB_User.Text = "Пользователь"
		'
		'GB_Computer
		'
		Me.GB_Computer.Controls.Add(Me.Panel1)
		Me.GB_Computer.Controls.Add(Me.FlowLayoutPanel1)
		Me.GB_Computer.Controls.Add(Me.GP_Sessions)
		Me.GB_Computer.Controls.Add(Me.GroupBox3)
		Me.GB_Computer.Controls.Add(Me.TableLayoutPanel3)
		Me.GB_Computer.Dock = System.Windows.Forms.DockStyle.Top
		Me.GB_Computer.Location = New System.Drawing.Point(3, 210)
		Me.GB_Computer.Name = "GB_Computer"
		Me.GB_Computer.Size = New System.Drawing.Size(381, 306)
		Me.GB_Computer.TabIndex = 24
		Me.GB_Computer.TabStop = False
		Me.GB_Computer.Text = "Компьютер"
		'
		'Panel1
		'
		Me.Panel1.AutoSize = True
		Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.Panel1.Controls.Add(Me.CB_Shadow)
		Me.Panel1.Controls.Add(Me.B_Connect)
		Me.Panel1.Controls.Add(Me.NUD_ID)
		Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
		Me.Panel1.Location = New System.Drawing.Point(278, 210)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(100, 93)
		Me.Panel1.TabIndex = 26
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.AutoSize = True
		Me.FlowLayoutPanel1.Controls.Add(Me.CB_UseSession)
		Me.FlowLayoutPanel1.Controls.Add(Me.CB_Promt)
		Me.FlowLayoutPanel1.Controls.Add(Me.CB_Control)
		Me.FlowLayoutPanel1.Controls.Add(Me.CB_FullScreen)
		Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
		Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 210)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(213, 93)
		Me.FlowLayoutPanel1.TabIndex = 13
		Me.FlowLayoutPanel1.WrapContents = False
		'
		'CB_UseSession
		'
		Me.CB_UseSession.AutoSize = True
		Me.CB_UseSession.Location = New System.Drawing.Point(3, 3)
		Me.CB_UseSession.Name = "CB_UseSession"
		Me.CB_UseSession.Size = New System.Drawing.Size(207, 17)
		Me.CB_UseSession.TabIndex = 11
		Me.CB_UseSession.Text = "Подключиться к выбранной сессии"
		Me.CB_UseSession.UseVisualStyleBackColor = True
		'
		'CB_Promt
		'
		Me.CB_Promt.AutoSize = True
		Me.CB_Promt.Location = New System.Drawing.Point(3, 26)
		Me.CB_Promt.Name = "CB_Promt"
		Me.CB_Promt.Size = New System.Drawing.Size(149, 17)
		Me.CB_Promt.TabIndex = 12
		Me.CB_Promt.Text = "Указать логин и пароль"
		Me.CB_Promt.UseVisualStyleBackColor = True
		'
		'GP_Sessions
		'
		Me.GP_Sessions.Controls.Add(Me.LB_Sessions)
		Me.GP_Sessions.Dock = System.Windows.Forms.DockStyle.Top
		Me.GP_Sessions.Location = New System.Drawing.Point(3, 122)
		Me.GP_Sessions.Name = "GP_Sessions"
		Me.GP_Sessions.Size = New System.Drawing.Size(375, 88)
		Me.GP_Sessions.TabIndex = 11
		Me.GP_Sessions.TabStop = False
		Me.GP_Sessions.Text = "Сессии"
		'
		'LB_Sessions
		'
		Me.LB_Sessions.DataSource = Me.BS_Sessions
		Me.LB_Sessions.Dock = System.Windows.Forms.DockStyle.Fill
		Me.LB_Sessions.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
		Me.LB_Sessions.FormattingEnabled = True
		Me.LB_Sessions.Location = New System.Drawing.Point(3, 16)
		Me.LB_Sessions.Name = "LB_Sessions"
		Me.LB_Sessions.Size = New System.Drawing.Size(369, 69)
		Me.LB_Sessions.TabIndex = 0
		'
		'BS_Sessions
		'
		Me.BS_Sessions.DataMember = "Sessions"
		Me.BS_Sessions.DataSource = Me.BS_Computer
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.LB_IPs)
		Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
		Me.GroupBox3.Location = New System.Drawing.Point(3, 68)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(375, 54)
		Me.GroupBox3.TabIndex = 0
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Адреса"
		'
		'TLP_Info
		'
		Me.TLP_Info.AutoSize = True
		Me.TLP_Info.ColumnCount = 1
		Me.TLP_Info.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
		Me.TLP_Info.Controls.Add(Me.GB_Computer, 0, 1)
		Me.TLP_Info.Controls.Add(Me.GB_User, 0, 0)
		Me.TLP_Info.Dock = System.Windows.Forms.DockStyle.Right
		Me.TLP_Info.Location = New System.Drawing.Point(421, 0)
		Me.TLP_Info.Name = "TLP_Info"
		Me.TLP_Info.RowCount = 3
		Me.TLP_Info.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TLP_Info.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TLP_Info.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TLP_Info.Size = New System.Drawing.Size(387, 540)
		Me.TLP_Info.TabIndex = 25
		'
		'TB_Log
		'
		Me.TB_Log.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.TB_Log.Location = New System.Drawing.Point(0, 359)
		Me.TB_Log.Multiline = True
		Me.TB_Log.Name = "TB_Log"
		Me.TB_Log.ReadOnly = True
		Me.TB_Log.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.TB_Log.Size = New System.Drawing.Size(421, 181)
		Me.TB_Log.TabIndex = 14
		'
		'FormMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.ClientSize = New System.Drawing.Size(808, 562)
		Me.Controls.Add(Me.TLP_Tree)
		Me.Controls.Add(Me.TB_Log)
		Me.Controls.Add(Me.TLP_Info)
		Me.Controls.Add(Me.SS)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.MinimumSize = New System.Drawing.Size(760, 600)
		Me.Name = "FormMain"
		Me.Text = "Выбор компьютера"
		CType(Me.NUD_ID, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BS_User, System.ComponentModel.ISupportInitialize).EndInit()
		Me.TableLayoutPanel1.ResumeLayout(False)
		Me.TableLayoutPanel1.PerformLayout()
		Me.TLP_Tree.ResumeLayout(False)
		Me.TLP_Tree.PerformLayout()
		Me.TableLayoutPanel2.ResumeLayout(False)
		Me.TableLayoutPanel2.PerformLayout()
		Me.SS.ResumeLayout(False)
		Me.SS.PerformLayout()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.TableLayoutPanel3.ResumeLayout(False)
		Me.TableLayoutPanel3.PerformLayout()
		CType(Me.BS_Computer, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BS_IPs, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GB_User.ResumeLayout(False)
		Me.GB_User.PerformLayout()
		Me.GB_Computer.ResumeLayout(False)
		Me.GB_Computer.PerformLayout()
		Me.Panel1.ResumeLayout(False)
		Me.Panel1.PerformLayout()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.FlowLayoutPanel1.PerformLayout()
		Me.GP_Sessions.ResumeLayout(False)
		CType(Me.BS_Sessions, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox3.ResumeLayout(False)
		Me.TLP_Info.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents CB_Control As CheckBox
    Friend WithEvents B_Connect As Button
	Friend WithEvents CB_Shadow As CheckBox
	Friend WithEvents NUD_ID As NumericUpDown
	Friend WithEvents CB_FullScreen As CheckBox
	Friend WithEvents TV_Users As TreeView
	Friend WithEvents TB_Search As TextBox
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents BS_User As BindingSource
	Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TLP_Tree As TableLayoutPanel
	Friend WithEvents Label3 As Label
	Friend WithEvents SS As StatusStrip
	Friend WithEvents L_Status As ToolStripStatusLabel
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents TSMI_Refresh As ToolStripMenuItem
	Friend WithEvents LB_Logins As ListBox
	Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents BS_Computer As BindingSource
	Friend WithEvents LB_IPs As ListBox
	Friend WithEvents BS_IPs As BindingSource
	Friend WithEvents Label6 As Label
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GB_User As GroupBox
	Friend WithEvents GB_Computer As GroupBox
	Friend WithEvents TextBox5 As TextBox
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents TLP_Info As TableLayoutPanel
	Friend WithEvents Panel1 As Panel
	Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
	Friend WithEvents B_Refresh As Button
	Friend WithEvents Label7 As Label
	Friend WithEvents TB_Domain As TextBox
	Friend WithEvents B_Domain As Button
	Friend WithEvents B_Clear As Button
	Friend WithEvents GP_Sessions As GroupBox
	Friend WithEvents LB_Sessions As ListBox
	Friend WithEvents BS_Sessions As BindingSource
	Friend WithEvents CB_UseSession As CheckBox
	Friend WithEvents CB_Promt As CheckBox
	Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
	Friend WithEvents TB_Log As TextBox
End Class
