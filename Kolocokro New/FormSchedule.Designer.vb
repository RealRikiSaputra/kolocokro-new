<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSchedule
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSchedule))
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnScheduleBack = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nlTask1 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnStart1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbTask1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.nlTask2 = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnStart2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbTask2 = New System.Windows.Forms.ComboBox()
        Me.tbLogs1 = New System.Windows.Forms.TextBox()
        Me.tbLogs2 = New System.Windows.Forms.TextBox()
        Me.bwMain1 = New System.ComponentModel.BackgroundWorker()
        Me.btnClearLogs1 = New System.Windows.Forms.Button()
        Me.bwMain2 = New System.ComponentModel.BackgroundWorker()
        Me.btnClearLogs2 = New System.Windows.Forms.Button()
        Me.btnClearLogs3 = New System.Windows.Forms.Button()
        Me.tbLogs3 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.nlTask3 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnStart3 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbTask3 = New System.Windows.Forms.ComboBox()
        Me.btnClearLogs4 = New System.Windows.Forms.Button()
        Me.tbLogs4 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.nlTask4 = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnStart4 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbTask4 = New System.Windows.Forms.ComboBox()
        Me.btnClearLogs5 = New System.Windows.Forms.Button()
        Me.tbLogs5 = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.nlTask5 = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnStart5 = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbTask5 = New System.Windows.Forms.ComboBox()
        Me.bwMain3 = New System.ComponentModel.BackgroundWorker()
        Me.bwMain4 = New System.ComponentModel.BackgroundWorker()
        Me.bwMain5 = New System.ComponentModel.BackgroundWorker()
        Me.bwCleanDriver = New System.ComponentModel.BackgroundWorker()
        Me.btnStartAll = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nlTask1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nlTask2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nlTask3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.nlTask4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.nlTask5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Impact", 18.0!)
        Me.label1.Location = New System.Drawing.Point(12, 4)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(153, 29)
        Me.label1.TabIndex = 31
        Me.label1.Text = "Schedule Task"
        '
        'btnScheduleBack
        '
        Me.btnScheduleBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnScheduleBack.Location = New System.Drawing.Point(984, 9)
        Me.btnScheduleBack.Name = "btnScheduleBack"
        Me.btnScheduleBack.Size = New System.Drawing.Size(103, 24)
        Me.btnScheduleBack.TabIndex = 32
        Me.btnScheduleBack.Text = "Back to Home"
        Me.btnScheduleBack.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nlTask1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnStart1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbTask1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 81)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Worker 1"
        '
        'nlTask1
        '
        Me.nlTask1.Location = New System.Drawing.Point(217, 45)
        Me.nlTask1.Name = "nlTask1"
        Me.nlTask1.Size = New System.Drawing.Size(68, 20)
        Me.nlTask1.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(214, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Loop"
        '
        'btnStart1
        '
        Me.btnStart1.Location = New System.Drawing.Point(308, 43)
        Me.btnStart1.Name = "btnStart1"
        Me.btnStart1.Size = New System.Drawing.Size(62, 21)
        Me.btnStart1.TabIndex = 4
        Me.btnStart1.Text = "Start"
        Me.btnStart1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Task"
        '
        'cbTask1
        '
        Me.cbTask1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTask1.FormattingEnabled = True
        Me.cbTask1.Location = New System.Drawing.Point(11, 43)
        Me.cbTask1.Name = "cbTask1"
        Me.cbTask1.Size = New System.Drawing.Size(188, 21)
        Me.cbTask1.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.nlTask2)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnStart2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cbTask2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 166)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(388, 81)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Worker 2"
        '
        'nlTask2
        '
        Me.nlTask2.Location = New System.Drawing.Point(217, 44)
        Me.nlTask2.Name = "nlTask2"
        Me.nlTask2.Size = New System.Drawing.Size(68, 20)
        Me.nlTask2.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(214, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Loop"
        '
        'btnStart2
        '
        Me.btnStart2.Location = New System.Drawing.Point(308, 42)
        Me.btnStart2.Name = "btnStart2"
        Me.btnStart2.Size = New System.Drawing.Size(62, 21)
        Me.btnStart2.TabIndex = 5
        Me.btnStart2.Text = "Start"
        Me.btnStart2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Task"
        '
        'cbTask2
        '
        Me.cbTask2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTask2.FormattingEnabled = True
        Me.cbTask2.Location = New System.Drawing.Point(11, 42)
        Me.cbTask2.Name = "cbTask2"
        Me.cbTask2.Size = New System.Drawing.Size(188, 21)
        Me.cbTask2.TabIndex = 2
        '
        'tbLogs1
        '
        Me.tbLogs1.Location = New System.Drawing.Point(406, 41)
        Me.tbLogs1.Multiline = True
        Me.tbLogs1.Name = "tbLogs1"
        Me.tbLogs1.ReadOnly = True
        Me.tbLogs1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbLogs1.Size = New System.Drawing.Size(681, 81)
        Me.tbLogs1.TabIndex = 37
        Me.tbLogs1.WordWrap = False
        '
        'tbLogs2
        '
        Me.tbLogs2.Location = New System.Drawing.Point(406, 155)
        Me.tbLogs2.Multiline = True
        Me.tbLogs2.Name = "tbLogs2"
        Me.tbLogs2.ReadOnly = True
        Me.tbLogs2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbLogs2.Size = New System.Drawing.Size(681, 92)
        Me.tbLogs2.TabIndex = 38
        Me.tbLogs2.WordWrap = False
        '
        'bwMain1
        '
        '
        'btnClearLogs1
        '
        Me.btnClearLogs1.Location = New System.Drawing.Point(1012, 128)
        Me.btnClearLogs1.Name = "btnClearLogs1"
        Me.btnClearLogs1.Size = New System.Drawing.Size(75, 23)
        Me.btnClearLogs1.TabIndex = 39
        Me.btnClearLogs1.Text = "Clear Logs"
        Me.btnClearLogs1.UseVisualStyleBackColor = True
        '
        'bwMain2
        '
        '
        'btnClearLogs2
        '
        Me.btnClearLogs2.Location = New System.Drawing.Point(1012, 253)
        Me.btnClearLogs2.Name = "btnClearLogs2"
        Me.btnClearLogs2.Size = New System.Drawing.Size(75, 23)
        Me.btnClearLogs2.TabIndex = 40
        Me.btnClearLogs2.Text = "Clear Logs"
        Me.btnClearLogs2.UseVisualStyleBackColor = True
        '
        'btnClearLogs3
        '
        Me.btnClearLogs3.Location = New System.Drawing.Point(1012, 380)
        Me.btnClearLogs3.Name = "btnClearLogs3"
        Me.btnClearLogs3.Size = New System.Drawing.Size(75, 23)
        Me.btnClearLogs3.TabIndex = 57
        Me.btnClearLogs3.Text = "Clear Logs"
        Me.btnClearLogs3.UseVisualStyleBackColor = True
        '
        'tbLogs3
        '
        Me.tbLogs3.Location = New System.Drawing.Point(406, 282)
        Me.tbLogs3.Multiline = True
        Me.tbLogs3.Name = "tbLogs3"
        Me.tbLogs3.ReadOnly = True
        Me.tbLogs3.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbLogs3.Size = New System.Drawing.Size(681, 92)
        Me.tbLogs3.TabIndex = 56
        Me.tbLogs3.WordWrap = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.nlTask3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.btnStart3)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cbTask3)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 293)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(388, 81)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Worker 3"
        '
        'nlTask3
        '
        Me.nlTask3.Location = New System.Drawing.Point(217, 44)
        Me.nlTask3.Name = "nlTask3"
        Me.nlTask3.Size = New System.Drawing.Size(68, 20)
        Me.nlTask3.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(214, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Loop"
        '
        'btnStart3
        '
        Me.btnStart3.Location = New System.Drawing.Point(308, 42)
        Me.btnStart3.Name = "btnStart3"
        Me.btnStart3.Size = New System.Drawing.Size(62, 21)
        Me.btnStart3.TabIndex = 5
        Me.btnStart3.Text = "Start"
        Me.btnStart3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Task"
        '
        'cbTask3
        '
        Me.cbTask3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTask3.FormattingEnabled = True
        Me.cbTask3.Location = New System.Drawing.Point(11, 42)
        Me.cbTask3.Name = "cbTask3"
        Me.cbTask3.Size = New System.Drawing.Size(188, 21)
        Me.cbTask3.TabIndex = 2
        '
        'btnClearLogs4
        '
        Me.btnClearLogs4.Location = New System.Drawing.Point(1012, 507)
        Me.btnClearLogs4.Name = "btnClearLogs4"
        Me.btnClearLogs4.Size = New System.Drawing.Size(75, 23)
        Me.btnClearLogs4.TabIndex = 60
        Me.btnClearLogs4.Text = "Clear Logs"
        Me.btnClearLogs4.UseVisualStyleBackColor = True
        '
        'tbLogs4
        '
        Me.tbLogs4.Location = New System.Drawing.Point(406, 409)
        Me.tbLogs4.Multiline = True
        Me.tbLogs4.Name = "tbLogs4"
        Me.tbLogs4.ReadOnly = True
        Me.tbLogs4.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbLogs4.Size = New System.Drawing.Size(681, 92)
        Me.tbLogs4.TabIndex = 59
        Me.tbLogs4.WordWrap = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.nlTask4)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.btnStart4)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.cbTask4)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 420)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(388, 81)
        Me.GroupBox4.TabIndex = 58
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Worker 4"
        '
        'nlTask4
        '
        Me.nlTask4.Location = New System.Drawing.Point(217, 44)
        Me.nlTask4.Name = "nlTask4"
        Me.nlTask4.Size = New System.Drawing.Size(68, 20)
        Me.nlTask4.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(214, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Loop"
        '
        'btnStart4
        '
        Me.btnStart4.Location = New System.Drawing.Point(308, 42)
        Me.btnStart4.Name = "btnStart4"
        Me.btnStart4.Size = New System.Drawing.Size(62, 21)
        Me.btnStart4.TabIndex = 5
        Me.btnStart4.Text = "Start"
        Me.btnStart4.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Task"
        '
        'cbTask4
        '
        Me.cbTask4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTask4.FormattingEnabled = True
        Me.cbTask4.Location = New System.Drawing.Point(11, 42)
        Me.cbTask4.Name = "cbTask4"
        Me.cbTask4.Size = New System.Drawing.Size(188, 21)
        Me.cbTask4.TabIndex = 2
        '
        'btnClearLogs5
        '
        Me.btnClearLogs5.Location = New System.Drawing.Point(1012, 634)
        Me.btnClearLogs5.Name = "btnClearLogs5"
        Me.btnClearLogs5.Size = New System.Drawing.Size(75, 23)
        Me.btnClearLogs5.TabIndex = 63
        Me.btnClearLogs5.Text = "Clear Logs"
        Me.btnClearLogs5.UseVisualStyleBackColor = True
        '
        'tbLogs5
        '
        Me.tbLogs5.Location = New System.Drawing.Point(406, 536)
        Me.tbLogs5.Multiline = True
        Me.tbLogs5.Name = "tbLogs5"
        Me.tbLogs5.ReadOnly = True
        Me.tbLogs5.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbLogs5.Size = New System.Drawing.Size(681, 92)
        Me.tbLogs5.TabIndex = 62
        Me.tbLogs5.WordWrap = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.nlTask5)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.btnStart5)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.cbTask5)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 547)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(388, 81)
        Me.GroupBox5.TabIndex = 61
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Worker 5"
        '
        'nlTask5
        '
        Me.nlTask5.Location = New System.Drawing.Point(217, 44)
        Me.nlTask5.Name = "nlTask5"
        Me.nlTask5.Size = New System.Drawing.Size(68, 20)
        Me.nlTask5.TabIndex = 54
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(214, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Loop"
        '
        'btnStart5
        '
        Me.btnStart5.Location = New System.Drawing.Point(308, 42)
        Me.btnStart5.Name = "btnStart5"
        Me.btnStart5.Size = New System.Drawing.Size(62, 21)
        Me.btnStart5.TabIndex = 5
        Me.btnStart5.Text = "Start"
        Me.btnStart5.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Task"
        '
        'cbTask5
        '
        Me.cbTask5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTask5.FormattingEnabled = True
        Me.cbTask5.Location = New System.Drawing.Point(11, 42)
        Me.cbTask5.Name = "cbTask5"
        Me.cbTask5.Size = New System.Drawing.Size(188, 21)
        Me.cbTask5.TabIndex = 2
        '
        'bwMain3
        '
        '
        'bwMain4
        '
        '
        'bwMain5
        '
        '
        'bwCleanDriver
        '
        '
        'btnStartAll
        '
        Me.btnStartAll.Location = New System.Drawing.Point(334, 9)
        Me.btnStartAll.Name = "btnStartAll"
        Me.btnStartAll.Size = New System.Drawing.Size(66, 24)
        Me.btnStartAll.TabIndex = 53
        Me.btnStartAll.Text = "Start All"
        Me.btnStartAll.UseVisualStyleBackColor = True
        '
        'FormSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1099, 667)
        Me.Controls.Add(Me.btnStartAll)
        Me.Controls.Add(Me.btnClearLogs5)
        Me.Controls.Add(Me.tbLogs5)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnClearLogs4)
        Me.Controls.Add(Me.tbLogs4)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnClearLogs3)
        Me.Controls.Add(Me.btnClearLogs2)
        Me.Controls.Add(Me.tbLogs3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnClearLogs1)
        Me.Controls.Add(Me.tbLogs2)
        Me.Controls.Add(Me.tbLogs1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnScheduleBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schedule"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nlTask1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nlTask2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nlTask3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.nlTask4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.nlTask5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As Label
    Private WithEvents btnScheduleBack As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnStart1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents cbTask1 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnStart2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cbTask2 As ComboBox
    Friend WithEvents tbLogs1 As TextBox
    Friend WithEvents tbLogs2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents nlTask2 As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents bwMain1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnClearLogs1 As Button
    Friend WithEvents bwMain2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnClearLogs2 As Button
    Friend WithEvents nlTask1 As NumericUpDown
    Friend WithEvents btnClearLogs3 As Button
    Friend WithEvents tbLogs3 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents nlTask3 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents btnStart3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents cbTask3 As ComboBox
    Friend WithEvents btnClearLogs4 As Button
    Friend WithEvents tbLogs4 As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents nlTask4 As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents btnStart4 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cbTask4 As ComboBox
    Friend WithEvents btnClearLogs5 As Button
    Friend WithEvents tbLogs5 As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents nlTask5 As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents btnStart5 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents cbTask5 As ComboBox
    Friend WithEvents bwMain3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwMain4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwMain5 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwCleanDriver As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnStartAll As Button
End Class
