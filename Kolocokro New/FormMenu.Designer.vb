<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.pilihanTask = New System.Windows.Forms.ComboBox()
        Me.tbLogs = New System.Windows.Forms.TextBox()
        Me.cbProfile = New System.Windows.Forms.CheckBox()
        Me.gbTask = New System.Windows.Forms.GroupBox()
        Me.addTask = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.editTask = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.salinTask = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.deleteTask = New System.Windows.Forms.PictureBox()
        Me.exportTask = New System.Windows.Forms.PictureBox()
        Me.importTask = New System.Windows.Forms.PictureBox()
        Me.nameApp = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnAddProxy = New System.Windows.Forms.Button()
        Me.tbProxy = New System.Windows.Forms.TextBox()
        Me.btnBackProxy = New System.Windows.Forms.Button()
        Me.btnDriver = New System.Windows.Forms.Button()
        Me.cbProxy = New System.Windows.Forms.ComboBox()
        Me.dgvStatus = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeleniumCommand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValueOrURL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdditionalValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OnError = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bwMain = New System.ComponentModel.BackgroundWorker()
        Me.bwCleanDriver = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tcMain = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cbLoop = New System.Windows.Forms.CheckBox()
        Me.btnCleanDriver = New System.Windows.Forms.Button()
        Me.numericLoop = New System.Windows.Forms.NumericUpDown()
        Me.gbProcessLogs = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.picUp = New System.Windows.Forms.PictureBox()
        Me.picAdd = New System.Windows.Forms.PictureBox()
        Me.picEdit = New System.Windows.Forms.PictureBox()
        Me.picDown = New System.Windows.Forms.PictureBox()
        Me.picDelete = New System.Windows.Forms.PictureBox()
        Me.picSalin = New System.Windows.Forms.PictureBox()
        Me.btnClearLogs = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.btnOption = New System.Windows.Forms.Button()
        Me.btnExtention = New System.Windows.Forms.Button()
        Me.btnCSV = New System.Windows.Forms.Button()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.btnProxy = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.iconApp = New System.Windows.Forms.PictureBox()
        Me.bwAddProxy = New System.ComponentModel.BackgroundWorker()
        Me.tbLoop = New System.Windows.Forms.TextBox()
        Me.gbTask.SuspendLayout()
        CType(Me.addTask, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editTask, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.salinTask, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deleteTask, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exportTask, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.importTask, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcMain.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.numericLoop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbProcessLogs.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picUp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSalin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.iconApp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pilihanTask
        '
        Me.pilihanTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pilihanTask.FormattingEnabled = True
        Me.pilihanTask.Location = New System.Drawing.Point(504, 10)
        Me.pilihanTask.Name = "pilihanTask"
        Me.pilihanTask.Size = New System.Drawing.Size(201, 21)
        Me.pilihanTask.TabIndex = 45
        '
        'tbLogs
        '
        Me.tbLogs.Location = New System.Drawing.Point(6, 19)
        Me.tbLogs.Multiline = True
        Me.tbLogs.Name = "tbLogs"
        Me.tbLogs.ReadOnly = True
        Me.tbLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbLogs.Size = New System.Drawing.Size(860, 167)
        Me.tbLogs.TabIndex = 0
        Me.tbLogs.WordWrap = False
        '
        'cbProfile
        '
        Me.cbProfile.AutoSize = True
        Me.cbProfile.Location = New System.Drawing.Point(637, 61)
        Me.cbProfile.Name = "cbProfile"
        Me.cbProfile.Size = New System.Drawing.Size(55, 17)
        Me.cbProfile.TabIndex = 55
        Me.cbProfile.Text = "Profile"
        Me.cbProfile.UseVisualStyleBackColor = True
        '
        'gbTask
        '
        Me.gbTask.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbTask.Controls.Add(Me.addTask)
        Me.gbTask.Controls.Add(Me.Label7)
        Me.gbTask.Controls.Add(Me.Label2)
        Me.gbTask.Controls.Add(Me.Label6)
        Me.gbTask.Controls.Add(Me.PictureBox1)
        Me.gbTask.Controls.Add(Me.Label5)
        Me.gbTask.Controls.Add(Me.editTask)
        Me.gbTask.Controls.Add(Me.Label4)
        Me.gbTask.Controls.Add(Me.salinTask)
        Me.gbTask.Controls.Add(Me.Label3)
        Me.gbTask.Controls.Add(Me.deleteTask)
        Me.gbTask.Controls.Add(Me.exportTask)
        Me.gbTask.Controls.Add(Me.importTask)
        Me.gbTask.Location = New System.Drawing.Point(154, 4)
        Me.gbTask.Name = "gbTask"
        Me.gbTask.Size = New System.Drawing.Size(344, 79)
        Me.gbTask.TabIndex = 53
        Me.gbTask.TabStop = False
        Me.gbTask.Text = "Task"
        '
        'addTask
        '
        Me.addTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.addTask.Image = Global.Kolocokro.My.Resources.Resources.plus
        Me.addTask.Location = New System.Drawing.Point(6, 18)
        Me.addTask.Name = "addTask"
        Me.addTask.Size = New System.Drawing.Size(40, 40)
        Me.addTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.addTask.TabIndex = 40
        Me.addTask.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(256, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Import"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Add"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(206, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Export"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(298, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(151, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Remove"
        '
        'editTask
        '
        Me.editTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.editTask.Image = Global.Kolocokro.My.Resources.Resources._1
        Me.editTask.Location = New System.Drawing.Point(54, 18)
        Me.editTask.Name = "editTask"
        Me.editTask.Size = New System.Drawing.Size(40, 40)
        Me.editTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.editTask.TabIndex = 39
        Me.editTask.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(109, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Copy"
        '
        'salinTask
        '
        Me.salinTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.salinTask.Image = Global.Kolocokro.My.Resources.Resources._2
        Me.salinTask.Location = New System.Drawing.Point(104, 18)
        Me.salinTask.Name = "salinTask"
        Me.salinTask.Size = New System.Drawing.Size(40, 40)
        Me.salinTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.salinTask.TabIndex = 38
        Me.salinTask.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Edit"
        '
        'deleteTask
        '
        Me.deleteTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.deleteTask.Image = Global.Kolocokro.My.Resources.Resources._3
        Me.deleteTask.Location = New System.Drawing.Point(154, 18)
        Me.deleteTask.Name = "deleteTask"
        Me.deleteTask.Size = New System.Drawing.Size(40, 40)
        Me.deleteTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.deleteTask.TabIndex = 37
        Me.deleteTask.TabStop = False
        '
        'exportTask
        '
        Me.exportTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.exportTask.Image = Global.Kolocokro.My.Resources.Resources._4
        Me.exportTask.Location = New System.Drawing.Point(204, 18)
        Me.exportTask.Name = "exportTask"
        Me.exportTask.Size = New System.Drawing.Size(40, 40)
        Me.exportTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.exportTask.TabIndex = 36
        Me.exportTask.TabStop = False
        '
        'importTask
        '
        Me.importTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.importTask.Image = Global.Kolocokro.My.Resources.Resources._5
        Me.importTask.Location = New System.Drawing.Point(254, 18)
        Me.importTask.Name = "importTask"
        Me.importTask.Size = New System.Drawing.Size(40, 40)
        Me.importTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.importTask.TabIndex = 35
        Me.importTask.TabStop = False
        '
        'nameApp
        '
        Me.nameApp.AutoSize = True
        Me.nameApp.BackColor = System.Drawing.Color.Transparent
        Me.nameApp.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameApp.Location = New System.Drawing.Point(4, 148)
        Me.nameApp.Name = "nameApp"
        Me.nameApp.Size = New System.Drawing.Size(135, 31)
        Me.nameApp.TabIndex = 2
        Me.nameApp.Text = "Kolocokro"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.btnAddProxy)
        Me.TabPage2.Controls.Add(Me.tbProxy)
        Me.TabPage2.Controls.Add(Me.btnBackProxy)
        Me.TabPage2.Location = New System.Drawing.Point(4, 4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1028, 604)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'btnAddProxy
        '
        Me.btnAddProxy.Location = New System.Drawing.Point(8, 540)
        Me.btnAddProxy.Name = "btnAddProxy"
        Me.btnAddProxy.Size = New System.Drawing.Size(75, 23)
        Me.btnAddProxy.TabIndex = 2
        Me.btnAddProxy.Text = "Add Proxy"
        Me.btnAddProxy.UseVisualStyleBackColor = True
        '
        'tbProxy
        '
        Me.tbProxy.Location = New System.Drawing.Point(6, 38)
        Me.tbProxy.Multiline = True
        Me.tbProxy.Name = "tbProxy"
        Me.tbProxy.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbProxy.Size = New System.Drawing.Size(1012, 485)
        Me.tbProxy.TabIndex = 1
        '
        'btnBackProxy
        '
        Me.btnBackProxy.Location = New System.Drawing.Point(943, 9)
        Me.btnBackProxy.Name = "btnBackProxy"
        Me.btnBackProxy.Size = New System.Drawing.Size(75, 23)
        Me.btnBackProxy.TabIndex = 0
        Me.btnBackProxy.Text = "Back"
        Me.btnBackProxy.UseVisualStyleBackColor = True
        '
        'btnDriver
        '
        Me.btnDriver.Location = New System.Drawing.Point(922, 556)
        Me.btnDriver.Name = "btnDriver"
        Me.btnDriver.Size = New System.Drawing.Size(96, 33)
        Me.btnDriver.TabIndex = 58
        Me.btnDriver.Text = "Download Driver"
        Me.btnDriver.UseVisualStyleBackColor = True
        '
        'cbProxy
        '
        Me.cbProxy.FormattingEnabled = True
        Me.cbProxy.Location = New System.Drawing.Point(504, 63)
        Me.cbProxy.Name = "cbProxy"
        Me.cbProxy.Size = New System.Drawing.Size(114, 21)
        Me.cbProxy.TabIndex = 57
        '
        'dgvStatus
        '
        Me.dgvStatus.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvStatus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvStatus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStatus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.SeleniumCommand, Me.ValueOrURL, Me.AdditionalValue, Me.Status, Me.OnError})
        Me.dgvStatus.Location = New System.Drawing.Point(154, 97)
        Me.dgvStatus.Name = "dgvStatus"
        Me.dgvStatus.RowHeadersVisible = False
        Me.dgvStatus.RowTemplate.Height = 25
        Me.dgvStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStatus.Size = New System.Drawing.Size(864, 251)
        Me.dgvStatus.TabIndex = 47
        '
        'No
        '
        Me.No.HeaderText = "No"
        Me.No.Name = "No"
        Me.No.Width = 40
        '
        'SeleniumCommand
        '
        Me.SeleniumCommand.HeaderText = "Command"
        Me.SeleniumCommand.Name = "SeleniumCommand"
        Me.SeleniumCommand.Width = 300
        '
        'ValueOrURL
        '
        Me.ValueOrURL.HeaderText = "Target"
        Me.ValueOrURL.Name = "ValueOrURL"
        Me.ValueOrURL.Width = 300
        '
        'AdditionalValue
        '
        Me.AdditionalValue.HeaderText = "Value"
        Me.AdditionalValue.Name = "AdditionalValue"
        Me.AdditionalValue.Width = 80
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.Width = 60
        '
        'OnError
        '
        Me.OnError.HeaderText = "OnError"
        Me.OnError.Name = "OnError"
        '
        'bwMain
        '
        '
        'bwCleanDriver
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(500, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Loop"
        '
        'tcMain
        '
        Me.tcMain.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.tcMain.Controls.Add(Me.TabPage1)
        Me.tcMain.Controls.Add(Me.TabPage2)
        Me.tcMain.Location = New System.Drawing.Point(-1, -2)
        Me.tcMain.Name = "tcMain"
        Me.tcMain.SelectedIndex = 0
        Me.tcMain.Size = New System.Drawing.Size(1036, 630)
        Me.tcMain.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.tbLoop)
        Me.TabPage1.Controls.Add(Me.cbLoop)
        Me.TabPage1.Controls.Add(Me.btnCleanDriver)
        Me.TabPage1.Controls.Add(Me.btnDriver)
        Me.TabPage1.Controls.Add(Me.cbProxy)
        Me.TabPage1.Controls.Add(Me.dgvStatus)
        Me.TabPage1.Controls.Add(Me.gbTask)
        Me.TabPage1.Controls.Add(Me.cbProfile)
        Me.TabPage1.Controls.Add(Me.pilihanTask)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.numericLoop)
        Me.TabPage1.Controls.Add(Me.gbProcessLogs)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.btnClearLogs)
        Me.TabPage1.Controls.Add(Me.btnPlay)
        Me.TabPage1.Controls.Add(Me.panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1028, 604)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'cbLoop
        '
        Me.cbLoop.AutoSize = True
        Me.cbLoop.Location = New System.Drawing.Point(616, 38)
        Me.cbLoop.Name = "cbLoop"
        Me.cbLoop.Size = New System.Drawing.Size(15, 14)
        Me.cbLoop.TabIndex = 60
        Me.cbLoop.UseVisualStyleBackColor = True
        '
        'btnCleanDriver
        '
        Me.btnCleanDriver.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCleanDriver.Location = New System.Drawing.Point(232, 556)
        Me.btnCleanDriver.Name = "btnCleanDriver"
        Me.btnCleanDriver.Size = New System.Drawing.Size(83, 33)
        Me.btnCleanDriver.TabIndex = 59
        Me.btnCleanDriver.Text = "Clean Driver"
        Me.btnCleanDriver.UseVisualStyleBackColor = True
        '
        'numericLoop
        '
        Me.numericLoop.Location = New System.Drawing.Point(537, 37)
        Me.numericLoop.Name = "numericLoop"
        Me.numericLoop.Size = New System.Drawing.Size(44, 20)
        Me.numericLoop.TabIndex = 51
        '
        'gbProcessLogs
        '
        Me.gbProcessLogs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbProcessLogs.Controls.Add(Me.tbLogs)
        Me.gbProcessLogs.Location = New System.Drawing.Point(154, 358)
        Me.gbProcessLogs.Name = "gbProcessLogs"
        Me.gbProcessLogs.Size = New System.Drawing.Size(876, 192)
        Me.gbProcessLogs.TabIndex = 49
        Me.gbProcessLogs.TabStop = False
        Me.gbProcessLogs.Text = "Process Logs"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.Controls.Add(Me.picUp)
        Me.GroupBox1.Controls.Add(Me.picAdd)
        Me.GroupBox1.Controls.Add(Me.picEdit)
        Me.GroupBox1.Controls.Add(Me.picDown)
        Me.GroupBox1.Controls.Add(Me.picDelete)
        Me.GroupBox1.Controls.Add(Me.picSalin)
        Me.GroupBox1.Location = New System.Drawing.Point(711, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 79)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Command"
        '
        'picUp
        '
        Me.picUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picUp.Location = New System.Drawing.Point(199, 21)
        Me.picUp.Margin = New System.Windows.Forms.Padding(4)
        Me.picUp.Name = "picUp"
        Me.picUp.Size = New System.Drawing.Size(40, 40)
        Me.picUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picUp.TabIndex = 24
        Me.picUp.TabStop = False
        '
        'picAdd
        '
        Me.picAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picAdd.Image = Global.Kolocokro.My.Resources.Resources.plus
        Me.picAdd.Location = New System.Drawing.Point(7, 23)
        Me.picAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.picAdd.Name = "picAdd"
        Me.picAdd.Size = New System.Drawing.Size(40, 40)
        Me.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picAdd.TabIndex = 26
        Me.picAdd.TabStop = False
        '
        'picEdit
        '
        Me.picEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picEdit.Image = Global.Kolocokro.My.Resources.Resources._1
        Me.picEdit.Location = New System.Drawing.Point(55, 23)
        Me.picEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.picEdit.Name = "picEdit"
        Me.picEdit.Size = New System.Drawing.Size(40, 40)
        Me.picEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picEdit.TabIndex = 27
        Me.picEdit.TabStop = False
        '
        'picDown
        '
        Me.picDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picDown.Location = New System.Drawing.Point(247, 21)
        Me.picDown.Margin = New System.Windows.Forms.Padding(4)
        Me.picDown.Name = "picDown"
        Me.picDown.Size = New System.Drawing.Size(40, 40)
        Me.picDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDown.TabIndex = 25
        Me.picDown.TabStop = False
        '
        'picDelete
        '
        Me.picDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picDelete.Image = Global.Kolocokro.My.Resources.Resources._3
        Me.picDelete.Location = New System.Drawing.Point(103, 23)
        Me.picDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.picDelete.Name = "picDelete"
        Me.picDelete.Size = New System.Drawing.Size(40, 40)
        Me.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDelete.TabIndex = 23
        Me.picDelete.TabStop = False
        '
        'picSalin
        '
        Me.picSalin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picSalin.Image = Global.Kolocokro.My.Resources.Resources._2
        Me.picSalin.Location = New System.Drawing.Point(151, 21)
        Me.picSalin.Margin = New System.Windows.Forms.Padding(4)
        Me.picSalin.Name = "picSalin"
        Me.picSalin.Size = New System.Drawing.Size(40, 40)
        Me.picSalin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSalin.TabIndex = 22
        Me.picSalin.TabStop = False
        '
        'btnClearLogs
        '
        Me.btnClearLogs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnClearLogs.Location = New System.Drawing.Point(154, 556)
        Me.btnClearLogs.Name = "btnClearLogs"
        Me.btnClearLogs.Size = New System.Drawing.Size(72, 33)
        Me.btnClearLogs.TabIndex = 50
        Me.btnClearLogs.Text = "Clear Logs"
        Me.btnClearLogs.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(637, 35)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(64, 20)
        Me.btnPlay.TabIndex = 48
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'panel1
        '
        Me.panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.btnOption)
        Me.panel1.Controls.Add(Me.btnExtention)
        Me.panel1.Controls.Add(Me.btnCSV)
        Me.panel1.Controls.Add(Me.btnSchedule)
        Me.panel1.Controls.Add(Me.btnProxy)
        Me.panel1.Controls.Add(Me.btnProfile)
        Me.panel1.Controls.Add(Me.nameApp)
        Me.panel1.Controls.Add(Me.iconApp)
        Me.panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.panel1.Location = New System.Drawing.Point(-2, -11)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(150, 627)
        Me.panel1.TabIndex = 46
        '
        'btnOption
        '
        Me.btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOption.Image = Global.Kolocokro.My.Resources.Resources._option
        Me.btnOption.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOption.Location = New System.Drawing.Point(80, 347)
        Me.btnOption.Name = "btnOption"
        Me.btnOption.Size = New System.Drawing.Size(60, 61)
        Me.btnOption.TabIndex = 0
        Me.btnOption.Text = "Option"
        Me.btnOption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnOption.UseVisualStyleBackColor = True
        '
        'btnExtention
        '
        Me.btnExtention.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExtention.Image = Global.Kolocokro.My.Resources.Resources.extention
        Me.btnExtention.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExtention.Location = New System.Drawing.Point(10, 347)
        Me.btnExtention.Name = "btnExtention"
        Me.btnExtention.Size = New System.Drawing.Size(60, 61)
        Me.btnExtention.TabIndex = 0
        Me.btnExtention.Text = "Extention"
        Me.btnExtention.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExtention.UseVisualStyleBackColor = True
        '
        'btnCSV
        '
        Me.btnCSV.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCSV.Image = Global.Kolocokro.My.Resources.Resources.csv
        Me.btnCSV.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCSV.Location = New System.Drawing.Point(10, 280)
        Me.btnCSV.Name = "btnCSV"
        Me.btnCSV.Size = New System.Drawing.Size(60, 61)
        Me.btnCSV.TabIndex = 0
        Me.btnCSV.Text = "CSV"
        Me.btnCSV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCSV.UseVisualStyleBackColor = True
        '
        'btnSchedule
        '
        Me.btnSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSchedule.Image = Global.Kolocokro.My.Resources.Resources.scedule
        Me.btnSchedule.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSchedule.Location = New System.Drawing.Point(80, 280)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(60, 61)
        Me.btnSchedule.TabIndex = 0
        Me.btnSchedule.Text = "Schedule"
        Me.btnSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnSchedule.UseVisualStyleBackColor = True
        '
        'btnProxy
        '
        Me.btnProxy.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProxy.Image = Global.Kolocokro.My.Resources.Resources.proxy
        Me.btnProxy.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProxy.Location = New System.Drawing.Point(80, 214)
        Me.btnProxy.Name = "btnProxy"
        Me.btnProxy.Size = New System.Drawing.Size(60, 60)
        Me.btnProxy.TabIndex = 0
        Me.btnProxy.Text = "Proxy"
        Me.btnProxy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProxy.UseVisualStyleBackColor = True
        '
        'btnProfile
        '
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProfile.Image = Global.Kolocokro.My.Resources.Resources.profile
        Me.btnProfile.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProfile.Location = New System.Drawing.Point(10, 214)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(60, 60)
        Me.btnProfile.TabIndex = 0
        Me.btnProfile.Text = "Profile"
        Me.btnProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'iconApp
        '
        Me.iconApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.iconApp.Image = Global.Kolocokro.My.Resources.Resources.kolocokro
        Me.iconApp.Location = New System.Drawing.Point(3, 13)
        Me.iconApp.Name = "iconApp"
        Me.iconApp.Size = New System.Drawing.Size(142, 128)
        Me.iconApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconApp.TabIndex = 0
        Me.iconApp.TabStop = False
        '
        'bwAddProxy
        '
        '
        'tbLoop
        '
        Me.tbLoop.Location = New System.Drawing.Point(585, 36)
        Me.tbLoop.Name = "tbLoop"
        Me.tbLoop.ReadOnly = True
        Me.tbLoop.Size = New System.Drawing.Size(26, 20)
        Me.tbLoop.TabIndex = 61
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 627)
        Me.Controls.Add(Me.tcMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kolocokro"
        Me.gbTask.ResumeLayout(False)
        Me.gbTask.PerformLayout()
        CType(Me.addTask, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editTask, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.salinTask, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deleteTask, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exportTask, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.importTask, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcMain.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.numericLoop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbProcessLogs.ResumeLayout(False)
        Me.gbProcessLogs.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.picUp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSalin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.iconApp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pilihanTask As ComboBox
    Friend WithEvents tbLogs As TextBox
    Private WithEvents picUp As PictureBox
    Private WithEvents picAdd As PictureBox
    Private WithEvents picEdit As PictureBox
    Private WithEvents picDown As PictureBox
    Private WithEvents picDelete As PictureBox
    Private WithEvents picSalin As PictureBox
    Private WithEvents btnOption As Button
    Private WithEvents btnExtention As Button
    Private WithEvents btnCSV As Button
    Private WithEvents btnSchedule As Button
    Friend WithEvents cbProfile As CheckBox
    Private WithEvents btnProxy As Button
    Friend WithEvents gbTask As GroupBox
    Private WithEvents addTask As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Private WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Private WithEvents editTask As PictureBox
    Friend WithEvents Label4 As Label
    Private WithEvents salinTask As PictureBox
    Friend WithEvents Label3 As Label
    Private WithEvents deleteTask As PictureBox
    Private WithEvents exportTask As PictureBox
    Private WithEvents importTask As PictureBox
    Private WithEvents nameApp As Label
    Private WithEvents iconApp As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnAddProxy As Button
    Friend WithEvents tbProxy As TextBox
    Friend WithEvents btnBackProxy As Button
    Friend WithEvents btnDriver As Button
    Friend WithEvents cbProxy As ComboBox
    Private WithEvents dgvStatus As DataGridView
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents SeleniumCommand As DataGridViewTextBoxColumn
    Friend WithEvents ValueOrURL As DataGridViewTextBoxColumn
    Friend WithEvents AdditionalValue As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents OnError As DataGridViewTextBoxColumn
    Friend WithEvents bwMain As System.ComponentModel.BackgroundWorker
    Private WithEvents btnProfile As Button
    Friend WithEvents bwCleanDriver As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents tcMain As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents numericLoop As NumericUpDown
    Private WithEvents gbProcessLogs As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Private WithEvents btnClearLogs As Button
    Private WithEvents btnPlay As Button
    Private WithEvents panel1 As Panel
    Friend WithEvents bwAddProxy As System.ComponentModel.BackgroundWorker
    Private WithEvents btnCleanDriver As Button
    Friend WithEvents cbLoop As CheckBox
    Friend WithEvents tbLoop As TextBox
End Class
