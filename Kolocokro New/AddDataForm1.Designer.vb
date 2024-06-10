<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddDataForm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddDataForm1))
        Me.cbCommand = New System.Windows.Forms.ComboBox()
        Me.btnCancelAdd = New System.Windows.Forms.Button()
        Me.btnAddComand = New System.Windows.Forms.Button()
        Me.Value = New System.Windows.Forms.Label()
        Me.Target = New System.Windows.Forms.Label()
        Me.Comand = New System.Windows.Forms.Label()
        Me.tbValue = New System.Windows.Forms.TextBox()
        Me.tbTarget = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cbCommand
        '
        Me.cbCommand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCommand.FormattingEnabled = True
        Me.cbCommand.Location = New System.Drawing.Point(10, 32)
        Me.cbCommand.Name = "cbCommand"
        Me.cbCommand.Size = New System.Drawing.Size(270, 21)
        Me.cbCommand.TabIndex = 28
        '
        'btnCancelAdd
        '
        Me.btnCancelAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelAdd.Location = New System.Drawing.Point(10, 159)
        Me.btnCancelAdd.Name = "btnCancelAdd"
        Me.btnCancelAdd.Size = New System.Drawing.Size(64, 27)
        Me.btnCancelAdd.TabIndex = 26
        Me.btnCancelAdd.Text = "Cancel"
        Me.btnCancelAdd.UseVisualStyleBackColor = True
        '
        'btnAddComand
        '
        Me.btnAddComand.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddComand.Location = New System.Drawing.Point(215, 159)
        Me.btnAddComand.Name = "btnAddComand"
        Me.btnAddComand.Size = New System.Drawing.Size(64, 27)
        Me.btnAddComand.TabIndex = 27
        Me.btnAddComand.Text = "OK"
        Me.btnAddComand.UseVisualStyleBackColor = True
        '
        'Value
        '
        Me.Value.AutoSize = True
        Me.Value.Location = New System.Drawing.Point(10, 110)
        Me.Value.Name = "Value"
        Me.Value.Size = New System.Drawing.Size(34, 13)
        Me.Value.TabIndex = 23
        Me.Value.Text = "Value"
        '
        'Target
        '
        Me.Target.AutoSize = True
        Me.Target.Location = New System.Drawing.Point(10, 63)
        Me.Target.Name = "Target"
        Me.Target.Size = New System.Drawing.Size(38, 13)
        Me.Target.TabIndex = 24
        Me.Target.Text = "Target"
        '
        'Comand
        '
        Me.Comand.AutoSize = True
        Me.Comand.Location = New System.Drawing.Point(10, 10)
        Me.Comand.Name = "Comand"
        Me.Comand.Size = New System.Drawing.Size(46, 13)
        Me.Comand.TabIndex = 25
        Me.Comand.Text = "Comand"
        '
        'tbValue
        '
        Me.tbValue.Location = New System.Drawing.Point(10, 126)
        Me.tbValue.Name = "tbValue"
        Me.tbValue.Size = New System.Drawing.Size(270, 20)
        Me.tbValue.TabIndex = 21
        '
        'tbTarget
        '
        Me.tbTarget.Location = New System.Drawing.Point(10, 79)
        Me.tbTarget.Name = "tbTarget"
        Me.tbTarget.Size = New System.Drawing.Size(270, 20)
        Me.tbTarget.TabIndex = 22
        '
        'AddDataForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 250)
        Me.Controls.Add(Me.cbCommand)
        Me.Controls.Add(Me.btnCancelAdd)
        Me.Controls.Add(Me.btnAddComand)
        Me.Controls.Add(Me.Value)
        Me.Controls.Add(Me.Target)
        Me.Controls.Add(Me.Comand)
        Me.Controls.Add(Me.tbValue)
        Me.Controls.Add(Me.tbTarget)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AddDataForm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Command"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cbCommand As ComboBox
    Private WithEvents btnCancelAdd As Button
    Private WithEvents btnAddComand As Button
    Private WithEvents Value As Label
    Private WithEvents Target As Label
    Private WithEvents Comand As Label
    Private WithEvents tbValue As TextBox
    Private WithEvents tbTarget As TextBox
End Class
