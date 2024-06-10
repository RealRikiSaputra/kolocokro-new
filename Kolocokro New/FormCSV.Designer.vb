<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCSV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCSV))
        Me.btnBackCSV = New System.Windows.Forms.Button()
        Me.CSVproxyData = New System.Windows.Forms.PictureBox()
        Me.CSVgenerateData = New System.Windows.Forms.PictureBox()
        Me.dgvCSV = New System.Windows.Forms.DataGridView()
        Me.Column0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CSVspintaxData = New System.Windows.Forms.PictureBox()
        Me.CSVprofileData = New System.Windows.Forms.PictureBox()
        Me.gbInsertData = New System.Windows.Forms.GroupBox()
        Me.CSVfileData = New System.Windows.Forms.PictureBox()
        Me.CSVtext = New System.Windows.Forms.PictureBox()
        Me.CSVsave = New System.Windows.Forms.PictureBox()
        Me.CSVimport = New System.Windows.Forms.PictureBox()
        Me.CSVdelete = New System.Windows.Forms.PictureBox()
        Me.CSVadd = New System.Windows.Forms.PictureBox()
        Me.pbFolderCSV = New System.Windows.Forms.PictureBox()
        Me.gbMainCSV = New System.Windows.Forms.GroupBox()
        Me.CSVSelect = New System.Windows.Forms.ComboBox()
        Me.CSVmoveColl = New System.Windows.Forms.PictureBox()
        Me.CSVdeleteColl = New System.Windows.Forms.PictureBox()
        Me.CSVaddColl = New System.Windows.Forms.PictureBox()
        Me.gbCollCSV = New System.Windows.Forms.GroupBox()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.CSVproxyData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSVgenerateData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCSV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSVspintaxData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSVprofileData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInsertData.SuspendLayout()
        CType(Me.CSVfileData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSVtext, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSVsave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSVimport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSVdelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSVadd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFolderCSV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMainCSV.SuspendLayout()
        CType(Me.CSVmoveColl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSVdeleteColl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CSVaddColl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCollCSV.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBackCSV
        '
        Me.btnBackCSV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBackCSV.Location = New System.Drawing.Point(983, 8)
        Me.btnBackCSV.Name = "btnBackCSV"
        Me.btnBackCSV.Size = New System.Drawing.Size(103, 24)
        Me.btnBackCSV.TabIndex = 18
        Me.btnBackCSV.Text = "Back to Home"
        Me.btnBackCSV.UseVisualStyleBackColor = True
        '
        'CSVproxyData
        '
        Me.CSVproxyData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CSVproxyData.Location = New System.Drawing.Point(42, 16)
        Me.CSVproxyData.Name = "CSVproxyData"
        Me.CSVproxyData.Size = New System.Drawing.Size(21, 22)
        Me.CSVproxyData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CSVproxyData.TabIndex = 9
        Me.CSVproxyData.TabStop = False
        '
        'CSVgenerateData
        '
        Me.CSVgenerateData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CSVgenerateData.Location = New System.Drawing.Point(147, 16)
        Me.CSVgenerateData.Name = "CSVgenerateData"
        Me.CSVgenerateData.Size = New System.Drawing.Size(21, 22)
        Me.CSVgenerateData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CSVgenerateData.TabIndex = 9
        Me.CSVgenerateData.TabStop = False
        '
        'dgvCSV
        '
        Me.dgvCSV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCSV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column0, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13})
        Me.dgvCSV.Location = New System.Drawing.Point(-1, 91)
        Me.dgvCSV.Name = "dgvCSV"
        Me.dgvCSV.RowTemplate.Height = 25
        Me.dgvCSV.Size = New System.Drawing.Size(1100, 484)
        Me.dgvCSV.TabIndex = 23
        '
        'Column0
        '
        Me.Column0.HeaderText = "Column0"
        Me.Column0.Name = "Column0"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 81
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 81
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 81
        '
        'Column4
        '
        Me.Column4.HeaderText = "Column4"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 81
        '
        'Column5
        '
        Me.Column5.HeaderText = "Column5"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 81
        '
        'Column6
        '
        Me.Column6.HeaderText = "Column6"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 81
        '
        'Column7
        '
        Me.Column7.HeaderText = "Column7"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 81
        '
        'Column8
        '
        Me.Column8.HeaderText = "Column8"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 81
        '
        'Column9
        '
        Me.Column9.HeaderText = "Column9"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 81
        '
        'Column10
        '
        Me.Column10.HeaderText = "Column10"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 87
        '
        'Column11
        '
        Me.Column11.HeaderText = "Column11"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "Column12"
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.HeaderText = "Column13"
        Me.Column13.Name = "Column13"
        '
        'CSVspintaxData
        '
        Me.CSVspintaxData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CSVspintaxData.Location = New System.Drawing.Point(111, 16)
        Me.CSVspintaxData.Name = "CSVspintaxData"
        Me.CSVspintaxData.Size = New System.Drawing.Size(21, 22)
        Me.CSVspintaxData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CSVspintaxData.TabIndex = 9
        Me.CSVspintaxData.TabStop = False
        '
        'CSVprofileData
        '
        Me.CSVprofileData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CSVprofileData.Location = New System.Drawing.Point(76, 16)
        Me.CSVprofileData.Name = "CSVprofileData"
        Me.CSVprofileData.Size = New System.Drawing.Size(21, 22)
        Me.CSVprofileData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CSVprofileData.TabIndex = 9
        Me.CSVprofileData.TabStop = False
        '
        'gbInsertData
        '
        Me.gbInsertData.Controls.Add(Me.CSVproxyData)
        Me.gbInsertData.Controls.Add(Me.CSVgenerateData)
        Me.gbInsertData.Controls.Add(Me.CSVspintaxData)
        Me.gbInsertData.Controls.Add(Me.CSVprofileData)
        Me.gbInsertData.Controls.Add(Me.CSVfileData)
        Me.gbInsertData.Location = New System.Drawing.Point(528, 36)
        Me.gbInsertData.Name = "gbInsertData"
        Me.gbInsertData.Size = New System.Drawing.Size(177, 45)
        Me.gbInsertData.TabIndex = 20
        Me.gbInsertData.TabStop = False
        Me.gbInsertData.Text = "Insert Data"
        '
        'CSVfileData
        '
        Me.CSVfileData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CSVfileData.Location = New System.Drawing.Point(5, 16)
        Me.CSVfileData.Name = "CSVfileData"
        Me.CSVfileData.Size = New System.Drawing.Size(21, 22)
        Me.CSVfileData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CSVfileData.TabIndex = 9
        Me.CSVfileData.TabStop = False
        '
        'CSVtext
        '
        Me.CSVtext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CSVtext.Location = New System.Drawing.Point(318, 16)
        Me.CSVtext.Name = "CSVtext"
        Me.CSVtext.Size = New System.Drawing.Size(21, 22)
        Me.CSVtext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CSVtext.TabIndex = 9
        Me.CSVtext.TabStop = False
        '
        'CSVsave
        '
        Me.CSVsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CSVsave.Location = New System.Drawing.Point(284, 16)
        Me.CSVsave.Name = "CSVsave"
        Me.CSVsave.Size = New System.Drawing.Size(21, 22)
        Me.CSVsave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CSVsave.TabIndex = 9
        Me.CSVsave.TabStop = False
        '
        'CSVimport
        '
        Me.CSVimport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CSVimport.Image = Global.Kolocokro.My.Resources.Resources._5
        Me.CSVimport.Location = New System.Drawing.Point(249, 16)
        Me.CSVimport.Name = "CSVimport"
        Me.CSVimport.Size = New System.Drawing.Size(21, 22)
        Me.CSVimport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CSVimport.TabIndex = 9
        Me.CSVimport.TabStop = False
        '
        'CSVdelete
        '
        Me.CSVdelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CSVdelete.Image = Global.Kolocokro.My.Resources.Resources._3
        Me.CSVdelete.Location = New System.Drawing.Point(214, 16)
        Me.CSVdelete.Name = "CSVdelete"
        Me.CSVdelete.Size = New System.Drawing.Size(21, 22)
        Me.CSVdelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CSVdelete.TabIndex = 9
        Me.CSVdelete.TabStop = False
        '
        'CSVadd
        '
        Me.CSVadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CSVadd.Image = Global.Kolocokro.My.Resources.Resources.plus
        Me.CSVadd.Location = New System.Drawing.Point(180, 16)
        Me.CSVadd.Name = "CSVadd"
        Me.CSVadd.Size = New System.Drawing.Size(21, 22)
        Me.CSVadd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CSVadd.TabIndex = 9
        Me.CSVadd.TabStop = False
        '
        'pbFolderCSV
        '
        Me.pbFolderCSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbFolderCSV.Location = New System.Drawing.Point(5, 15)
        Me.pbFolderCSV.Name = "pbFolderCSV"
        Me.pbFolderCSV.Size = New System.Drawing.Size(22, 25)
        Me.pbFolderCSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFolderCSV.TabIndex = 0
        Me.pbFolderCSV.TabStop = False
        '
        'gbMainCSV
        '
        Me.gbMainCSV.Controls.Add(Me.CSVtext)
        Me.gbMainCSV.Controls.Add(Me.CSVsave)
        Me.gbMainCSV.Controls.Add(Me.CSVimport)
        Me.gbMainCSV.Controls.Add(Me.CSVdelete)
        Me.gbMainCSV.Controls.Add(Me.CSVadd)
        Me.gbMainCSV.Controls.Add(Me.CSVSelect)
        Me.gbMainCSV.Controls.Add(Me.pbFolderCSV)
        Me.gbMainCSV.Location = New System.Drawing.Point(20, 36)
        Me.gbMainCSV.Name = "gbMainCSV"
        Me.gbMainCSV.Size = New System.Drawing.Size(352, 45)
        Me.gbMainCSV.TabIndex = 21
        Me.gbMainCSV.TabStop = False
        Me.gbMainCSV.Text = "Main"
        '
        'CSVSelect
        '
        Me.CSVSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CSVSelect.FormattingEnabled = True
        Me.CSVSelect.Location = New System.Drawing.Point(33, 17)
        Me.CSVSelect.Name = "CSVSelect"
        Me.CSVSelect.Size = New System.Drawing.Size(143, 21)
        Me.CSVSelect.TabIndex = 8
        '
        'CSVmoveColl
        '
        Me.CSVmoveColl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CSVmoveColl.Location = New System.Drawing.Point(42, 16)
        Me.CSVmoveColl.Name = "CSVmoveColl"
        Me.CSVmoveColl.Size = New System.Drawing.Size(21, 22)
        Me.CSVmoveColl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CSVmoveColl.TabIndex = 9
        Me.CSVmoveColl.TabStop = False
        '
        'CSVdeleteColl
        '
        Me.CSVdeleteColl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CSVdeleteColl.Image = Global.Kolocokro.My.Resources.Resources._3
        Me.CSVdeleteColl.Location = New System.Drawing.Point(76, 16)
        Me.CSVdeleteColl.Name = "CSVdeleteColl"
        Me.CSVdeleteColl.Size = New System.Drawing.Size(21, 22)
        Me.CSVdeleteColl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CSVdeleteColl.TabIndex = 9
        Me.CSVdeleteColl.TabStop = False
        '
        'CSVaddColl
        '
        Me.CSVaddColl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CSVaddColl.Image = Global.Kolocokro.My.Resources.Resources.plus
        Me.CSVaddColl.Location = New System.Drawing.Point(5, 16)
        Me.CSVaddColl.Name = "CSVaddColl"
        Me.CSVaddColl.Size = New System.Drawing.Size(21, 22)
        Me.CSVaddColl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CSVaddColl.TabIndex = 9
        Me.CSVaddColl.TabStop = False
        '
        'gbCollCSV
        '
        Me.gbCollCSV.Controls.Add(Me.CSVmoveColl)
        Me.gbCollCSV.Controls.Add(Me.CSVdeleteColl)
        Me.gbCollCSV.Controls.Add(Me.CSVaddColl)
        Me.gbCollCSV.Location = New System.Drawing.Point(398, 36)
        Me.gbCollCSV.Name = "gbCollCSV"
        Me.gbCollCSV.Size = New System.Drawing.Size(105, 45)
        Me.gbCollCSV.TabIndex = 22
        Me.gbCollCSV.TabStop = False
        Me.gbCollCSV.Text = "Colomn"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Impact", 20.0!)
        Me.label1.Location = New System.Drawing.Point(18, 3)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(166, 34)
        Me.label1.TabIndex = 19
        Me.label1.Text = "CSV MANAGER"
        '
        'FormCSV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(99, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1099, 578)
        Me.Controls.Add(Me.btnBackCSV)
        Me.Controls.Add(Me.dgvCSV)
        Me.Controls.Add(Me.gbInsertData)
        Me.Controls.Add(Me.gbMainCSV)
        Me.Controls.Add(Me.gbCollCSV)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormCSV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCSV"
        CType(Me.CSVproxyData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSVgenerateData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCSV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSVspintaxData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSVprofileData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInsertData.ResumeLayout(False)
        CType(Me.CSVfileData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSVtext, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSVsave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSVimport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSVdelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSVadd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFolderCSV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMainCSV.ResumeLayout(False)
        CType(Me.CSVmoveColl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSVdeleteColl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CSVaddColl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCollCSV.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnBackCSV As Button
    Private WithEvents CSVproxyData As PictureBox
    Private WithEvents CSVgenerateData As PictureBox
    Private WithEvents dgvCSV As DataGridView
    Friend WithEvents Column0 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Private WithEvents CSVspintaxData As PictureBox
    Private WithEvents CSVprofileData As PictureBox
    Private WithEvents gbInsertData As GroupBox
    Private WithEvents CSVfileData As PictureBox
    Private WithEvents CSVtext As PictureBox
    Private WithEvents CSVsave As PictureBox
    Private WithEvents CSVimport As PictureBox
    Private WithEvents CSVdelete As PictureBox
    Private WithEvents CSVadd As PictureBox
    Private WithEvents pbFolderCSV As PictureBox
    Private WithEvents gbMainCSV As GroupBox
    Private WithEvents CSVSelect As ComboBox
    Private WithEvents CSVmoveColl As PictureBox
    Private WithEvents CSVdeleteColl As PictureBox
    Private WithEvents CSVaddColl As PictureBox
    Private WithEvents gbCollCSV As GroupBox
    Private WithEvents label1 As Label
End Class
