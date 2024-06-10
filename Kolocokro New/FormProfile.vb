Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports OpenQA.Selenium.Chrome
Imports SeleniumUndetectedChromeDriver

Public Class FormProfile

    Dim document As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments

    Private Sub FormProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProfile()
        bwAddProfile.WorkerSupportsCancellation = True
        showProfile()
    End Sub

    Private Sub btnBackProfile_Click(sender As Object, e As EventArgs) Handles btnBackProfile.Click
        Dim form1 As FormMenu = DirectCast(Application.OpenForms("FormMenu"), FormMenu)
        form1.Show()
        Close()
    End Sub

    Private Sub btnProfileCopyClip_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub addTask_Click(sender As Object, e As EventArgs) Handles addTask.Click

    End Sub

    Private Sub btnAddProfile_Click(sender As Object, e As EventArgs) Handles btnAddProfile.Click
        If btnAddProfile.Text = "Add Profile" Then

            If tbNameProfile.Text = "" Then
                MsgBox("Nama Profile Tidak Boleh Kosong")
                Exit Sub
            End If

            Dim path = document + "\Kolocokro\Profile\" + tbNameProfile.Text ' Kumpulan Profile Combobox Disave Disini

            If My.Computer.FileSystem.DirectoryExists(path) Then
                MsgBox("Nama Profile Sudah Ada")
                Exit Sub
            End If
            btnAddProfile.Text = "Close Profile"
            bwAddProfile.RunWorkerAsync(argument:=path) ' agar mengakses function dibackground worker | kesalahan sebelumnya adalah (argument:=TempatProfileDokumen) Akibatnya Profile yg Baru di input Tidak Membuat Directory baru dan Seluruh  File Dari Profile Baru berada di dalam Profile Dokumen, tanpa Membuat directory baru untuk Profilenya
            'ElseIf btnAddProfile.Text = "Close Profile" Then
            '    btnAddProfile.Text = "Wait For Profile"
        End If
    End Sub

    Private Sub bwAddProfile_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwAddProfile.DoWork
        Dim chromePath As String = FindChromePath()
        Dim path = e.Argument 'deklarasi argument (Run Worker Async)

        Dim driver As UndetectedChromeDriver
        Dim options = New ChromeOptions

        options.AddArgument("--user-data-dir=" + path)
        driver = UndetectedChromeDriver.Create(hideCommandPromptWindow:=True, browserExecutablePath:="C:\Program Files\Google\Chrome\Application\chrome.exe", driverExecutablePath:=document + "\Kolocokro\Driver\chromedriver.exe", options:=options)
        driver.GoToUrl("https://google.com")
        driver.Quit()
        showProfile() 'Function untuk  Menampilkan Seluruh Profile Yang Sudah Dibuat
        btnAddProfile.Invoke(Sub() btnAddProfile.Text = "Add Profile")
    End Sub

    Private Function FindChromePath() As String
        Dim win10LocalPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\Google\Chrome\Application\chrome.exe"
        Dim possiblePaths() As String = {
        "C:\Program Files\Google\Chrome\Application\chrome.exe",
        win10LocalPath,
        "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"}

        For Each path As String In possiblePaths
            If File.Exists(path) Then

                Return path
            End If
        Next
        MessageBox.Show("Chrome tidak ditemukan.")
        Return Nothing
    End Function

    Private Sub LoadProfile()
        Dim path = document + "\Kolocokro\Profile\"
        Dim profileFolders = My.Computer.FileSystem.GetDirectories(path)

        ' Menghapus item sebelumnya dari ComboBox
        cbProfile.Items.Clear()

        ' Menambahkan folder ke dalam ComboBox
        For Each folder As String In profileFolders
            ' Menggunakan Path.GetFileName untuk mendapatkan nama folder saja
            cbProfile.Items.Add(IO.Path.GetFileName(folder))
        Next

        ' Menetapkan indeks ComboBox ke 0 jika ada item dalam daftar
        If cbProfile.Items.Count > 0 Then
            cbProfile.SelectedIndex = 0
        End If
    End Sub



    Function showProfile()
        Dim path = document + "\Kolocokro\Profile\"
        ' Menampilkan Seluruh Profile Di Textbox
        Dim profile = My.Computer.FileSystem.GetDirectories(path) ' proses Scan Directories

        tbDaftarProfile.Invoke(Sub() tbDaftarProfile.Clear()) ' Mengganti ComboBox1.Items.Clear() menjadi tbNameProfile.Clear()
        For Each ProfileDokumen In profile
            Dim nombresdeperfil = Split(ProfileDokumen, "\").Last ' Menampilkan Direktori Folder terakhir
            tbDaftarProfile.Invoke(Sub() tbDaftarProfile.AppendText(nombresdeperfil & Environment.NewLine)) ' Mengganti ComboBox1.Invoke(...) menjadi tbNameProfile.AppendText(...)
        Next
    End Function

    Private Sub deleteTask_Click(sender As Object, e As EventArgs) Handles deleteTask.Click
        ' Memastikan ada item yang dipilih di ComboBox
        If cbProfile.SelectedIndex >= 0 Then
            ' Mendapatkan nama folder yang akan dihapus dari ComboBox
            Dim profileToDelete As String = cbProfile.SelectedItem.ToString()

            ' Mendapatkan path lengkap dari folder
            Dim pathToDelete As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Kolocokro\Profile\" & profileToDelete

            Try
                ' Menghapus folder
                My.Computer.FileSystem.DeleteDirectory(pathToDelete, FileIO.DeleteDirectoryOption.DeleteAllContents)

                ' Memuat ulang daftar profile setelah penghapusan
                LoadProfile()

                MessageBox.Show("Profile '" & profileToDelete & "' berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Gagal menghapus profile. Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Pilih sebuah profile untuk dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        showProfile()
    End Sub

End Class