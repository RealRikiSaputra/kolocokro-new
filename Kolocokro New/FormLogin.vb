Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation
Imports Newtonsoft.Json

Public Class FormLogin
    Public Structure UserData
        Public Property username As String
        Public Property password As String
        Public Property expire_date As Date
        Public Property mac_address As String
    End Structure

    Private Sub cbLihat_CheckedChanged(sender As Object, e As EventArgs) Handles cbLihat.CheckedChanged
        If cbLihat.Checked = True Then
            tbPassword.PasswordChar = ""
        Else
            tbPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbMACAddress.Text = getMacAddress()
        bwLogin.WorkerSupportsCancellation = True
        ' Memuat pengaturan "Remember Me" saat form dimuat
        cbRemember.Checked = My.Settings.remember
        If My.Settings.remember = True Then
            tbUsername.Text = My.Settings.username
            tbPassword.Text = My.Settings.password
        Else
            tbUsername.Text = ""
            tbPassword.Text = ""
        End If
        Try
            ' Mendapatkan path ke direktori Dokumen
            Dim dokumentPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            Dim kolocokroPath As String = Path.Combine(dokumentPath, "Kolocokro")

            If Not Directory.Exists(kolocokroPath) Then
                Directory.CreateDirectory(kolocokroPath)

                CreateSubfolder(kolocokroPath, "Command")
                CreateSubfolder(kolocokroPath, "Cookie")
                CreateSubfolder(kolocokroPath, "CSV")
                CreateSubfolder(kolocokroPath, "Driver")
                CreateSubfolder(kolocokroPath, "Proxy")
                CreateSubfolder(kolocokroPath, "Profile")
            Else
                CreateSubfolder(kolocokroPath, "Command")
                CreateSubfolder(kolocokroPath, "Cookie")
                CreateSubfolder(kolocokroPath, "CSV")
                CreateSubfolder(kolocokroPath, "Driver")
                CreateSubfolder(kolocokroPath, "Proxy")
                CreateSubfolder(kolocokroPath, "Profile")
            End If
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    ' Fungsi untuk membuat folder di dalam path tertentu
    Function CreateSubfolder(parentPath As String, folderName As String)
        Dim subfolderPath As String = Path.Combine(parentPath, folderName)
        If Not Directory.Exists(subfolderPath) Then
            Directory.CreateDirectory(subfolderPath)
        Else
        End If
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If cbRemember.Checked Then
            My.Settings.remember = True
            My.Settings.username = tbUsername.Text
            My.Settings.password = tbPassword.Text
            My.Settings.Save()
        Else
            My.Settings.remember = False
            My.Settings.username = ""
            My.Settings.password = ""
            My.Settings.Save()
        End If
        btnLogin.Enabled = False

        bwLogin.RunWorkerAsync()
    End Sub

    Private Sub bwLogin_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLogin.DoWork
        Dim jsonText As String = ""

        Try
            Dim webClient As New WebClient()
            Dim timeResponse As String = webClient.DownloadString("http://just-the-time.appspot.com/")
            Dim internetTime As Date = DateTime.Parse(timeResponse)
            jsonText = webClient.DownloadString("https://json.link/mO1Tz9rQZH.json")
            Dim userDataArray As UserData() = JsonConvert.DeserializeObject(Of UserData())(jsonText)

            Dim enteredUsername As String = tbUsername.Text
            Dim enteredPassword As String = tbPassword.Text
            Dim enteredMACAddress As String = tbMACAddress.Text

            Dim loginSuccess As Boolean = False

            For Each userData In userDataArray
                If userData.username = enteredUsername AndAlso userData.password = enteredPassword AndAlso userData.mac_address = enteredMACAddress Then
                    If userData.expire_date > internetTime Then
                        MessageBox.Show("Login berhasil!")
                        loginSuccess = True
                        Exit For
                    Else
                        MessageBox.Show("Maaf, akun Anda telah kedaluwarsa.")
                        Application.Exit()
                        Exit For
                    End If
                End If
            Next

            If Not loginSuccess Then
                MessageBox.Show("Username atau password salah.")
                Application.Exit()
            End If

            If loginSuccess Then
                e.Result = True
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: Periksa Koneksi Internet anda")
            Application.Exit()
        End Try
    End Sub

    Private Sub bwLogin_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLogin.RunWorkerCompleted
        If e.Result IsNot Nothing AndAlso CBool(e.Result) = True Then
            Me.Hide()
            Dim mainForm As New FormMenu()
            mainForm.Show()
        End If
    End Sub

    Public Function getMacAddress()
        'Imports System.Net.NetworkInformation
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Dim mac = nics(0).GetPhysicalAddress.ToString
        Return mac
    End Function
End Class
