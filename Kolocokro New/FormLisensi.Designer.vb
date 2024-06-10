<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLisensi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLisensi))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbMacAddress = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbAktif = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.tbUsernameLisensi = New System.Windows.Forms.TextBox()
        Me.iconApp = New System.Windows.Forms.PictureBox()
        CType(Me.iconApp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(82, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Serial Number"
        '
        'tbMacAddress
        '
        Me.tbMacAddress.Location = New System.Drawing.Point(12, 259)
        Me.tbMacAddress.Name = "tbMacAddress"
        Me.tbMacAddress.ReadOnly = True
        Me.tbMacAddress.Size = New System.Drawing.Size(226, 20)
        Me.tbMacAddress.TabIndex = 23
        Me.tbMacAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 297)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Created By "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Masa Akhir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(95, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(94, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Username"
        '
        'tbAktif
        '
        Me.tbAktif.Location = New System.Drawing.Point(12, 210)
        Me.tbAktif.Name = "tbAktif"
        Me.tbAktif.ReadOnly = True
        Me.tbAktif.Size = New System.Drawing.Size(226, 20)
        Me.tbAktif.TabIndex = 16
        Me.tbAktif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbPassword
        '
        Me.tbPassword.Location = New System.Drawing.Point(12, 162)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.ReadOnly = True
        Me.tbPassword.Size = New System.Drawing.Size(226, 20)
        Me.tbPassword.TabIndex = 17
        Me.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbUsernameLisensi
        '
        Me.tbUsernameLisensi.Location = New System.Drawing.Point(12, 117)
        Me.tbUsernameLisensi.Name = "tbUsernameLisensi"
        Me.tbUsernameLisensi.ReadOnly = True
        Me.tbUsernameLisensi.Size = New System.Drawing.Size(226, 20)
        Me.tbUsernameLisensi.TabIndex = 18
        Me.tbUsernameLisensi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'iconApp
        '
        Me.iconApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.iconApp.Image = Global.Kolocokro.My.Resources.Resources.kolocokro
        Me.iconApp.Location = New System.Drawing.Point(89, 11)
        Me.iconApp.Name = "iconApp"
        Me.iconApp.Size = New System.Drawing.Size(73, 78)
        Me.iconApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconApp.TabIndex = 15
        Me.iconApp.TabStop = False
        '
        'FormLisensi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 320)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbMacAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbAktif)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUsernameLisensi)
        Me.Controls.Add(Me.iconApp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormLisensi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLisensi"
        CType(Me.iconApp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents tbMacAddress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbAktif As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents tbUsernameLisensi As TextBox
    Private WithEvents iconApp As PictureBox
End Class
