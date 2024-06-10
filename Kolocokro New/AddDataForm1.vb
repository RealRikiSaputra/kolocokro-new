Partial Public Class AddDataForm1
    Inherits Form
    ' Membuat properti untuk menyimpan data input
    Public Property DataCommand As String
    Public Property DataTarget As String
    Public Property DataValue As String

    Public Sub New()
        InitializeComponent()
        cbCommand.Items.AddRange(New String() {"All Clear", "AddCokies", "Back", "Click", "Click All Delete", "ClickUpload", "ClearCokies", "Close", "CloseFrame", "Copy Paste", "Double Click", "Down", "Enter", "Hide Browser", "Left", "Maximize", "Minimize", "New Tab", "New Window", "Open", "OpenFrame", "Pause", "Profile", "Proxy No Profile", "Proxy Profile", "Read CSV", "Read EXCEL", "Refresh", "Right", "Set Window Size", "Scroll Down", "Scroll Up", "Select by text", "sendKeys", "Set Window Position", "Type", "TypeBackspace", "Up", "Upload", "Wait Element Clickable", "Wait Element Exists"})
    End Sub

    Private Sub btnAddComand_Click(sender As Object, e As EventArgs) Handles btnAddComand.Click
        ' Mengambil data dari TextBox untuk masing-masing kolom
        DataCommand = cbCommand.Text
        DataTarget = tbTarget.Text
        DataValue = tbValue.Text

        ' Set DialogResult menjadi OK sehingga form utama mengetahui data telah diisi dan dapat ditambahkan ke DataGridView.
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancelAdd_Click(sender As Object, e As EventArgs) Handles btnCancelAdd.Click
        ' Set DialogResult menjadi Cancel sehingga form utama mengetahui operasi telah dibatalkan.
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cbCommand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCommand.SelectedIndexChanged

    End Sub

    Private Sub AddDataForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
