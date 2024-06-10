Imports System.Net
Imports Newtonsoft.Json

Public Class FormLisensi
    Public Structure UserData
        Public Property username As String
        Public Property password As String
        Public Property expire_date As Date
        Public Property mac_address As String
    End Structure

    Private Sub FormLisensi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Mengambil nama pengguna dari TextBox yang digunakan saat login
        Dim username As String = My.Settings.username ' Sesuaikan dengan username saat login

        ' Membuat HTTP request untuk mendapatkan data dari URL user.php
        Dim apiUrl As String = "http://103.154.53.147/Kolocokro/user.php"
        Dim webClient As New WebClient()

        Try
            Dim jsonData As String = webClient.DownloadString(apiUrl)

            ' Mengurai data JSON ke dalam array UserData
            Dim userDataArray As UserData() = JsonConvert.DeserializeObject(Of UserData())(jsonData)

            ' Mencari data pengguna berdasarkan username
            Dim foundUser As UserData = userDataArray.FirstOrDefault(Function(user) user.username = username)

            ' Memastikan bahwa data pengguna ditemukan
            If foundUser.username IsNot Nothing Then
                ' Mengisi TextBox dengan data dari respons JSON
                tbUsernameLisensi.Text = foundUser.username
                tbPassword.Text = foundUser.password
                ' Mengubah format tanggal kadaluwarsa menjadi nama bulan
                tbAktif.Text = foundUser.expire_date.ToString("MMMM dd, yyyy")
                tbMacAddress.Text = foundUser.mac_address
            Else
                MsgBox("Pengguna tidak ditemukan.")
            End If
        Catch ex As Exception
            MsgBox("Terjadi kesalahan saat mengambil data dari server: " & ex.Message)
        End Try
    End Sub
End Class
