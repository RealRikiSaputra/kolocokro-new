Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Management
Imports System.Net
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Forms

Public Class FormMenu
    Inherits Form
    Public Shared DataCommand As List(Of String())
    Private counter As Integer = 1
    Private bot As Command
    Private isPlaying As Boolean = False ' Variabel untuk melacak status play/pause
    Dim document As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments

    Public Sub New()
        InitializeComponent()
        LoadAvailableFiles()
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Mohon Tunggu hingga proses selesai")
        bwCleanDriver.WorkerSupportsCancellation = True
        bwMain.WorkerSupportsCancellation = True
        bwAddProxy.WorkerSupportsCancellation = True
        For Each proxyDir In My.Computer.FileSystem.GetDirectories(document + "\Kolocokro\Proxy\")
            Dim namaProxy = Split(proxyDir, "\").Last
            cbProxy.Items.Add(namaProxy)
        Next
        Me.Height = 640
        tcMain.SelectedIndex = 0
        ' Periksa apakah BackgroundWorker sedang sibuk
        If Not bwCleanDriver.IsBusy Then
            bwCleanDriver.RunWorkerAsync()
        Else
            ' Jika sedang sibuk, Anda bisa menampilkan pesan atau menanganinya sesuai kebutuhan
            MessageBox.Show("Operasi sedang berlangsung. Harap tunggu hingga selesai.")
        End If
    End Sub
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Dim formProfile As New FormProfile()
        formProfile.ShowDialog()
    End Sub

    Private Sub btnProxy_Click(sender As Object, e As EventArgs) Handles btnProxy.Click
        tcMain.SelectedIndex = 1
    End Sub

    Private Sub btnSchedule_Click(sender As Object, e As EventArgs) Handles btnSchedule.Click
        Dim formSchedule As New FormSchedule()
        formSchedule.ShowDialog()
    End Sub

    Private Sub btnCSV_Click(sender As Object, e As EventArgs) Handles btnCSV.Click
        Dim formCSV As New FormCSV()
        formCSV.ShowDialog()
    End Sub

    Private Sub btnExtention_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAddon_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnStore_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnOption_Click(sender As Object, e As EventArgs) Handles btnOption.Click
        Dim formLisensi As New FormLisensi()
        formLisensi.ShowDialog()
    End Sub

    Private Sub addTask_Click(sender As Object, e As EventArgs) Handles addTask.Click
        Dim saveFileDialog As New SaveFileDialog()

        saveFileDialog.InitialDirectory = document + "\Kolocokro\Command"

        ' Mengubah filter untuk menampilkan hanya file teks
        saveFileDialog.Filter = "Text files (.txt)|.txt|All files (.)|."
        saveFileDialog.FilterIndex = 1
        saveFileDialog.RestoreDirectory = True

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Menggunakan StreamWriter untuk membuat dan menulis ke file teks
                Using sw As New StreamWriter(saveFileDialog.FileName)
                    ' Menulis data ke dalam file teks (Anda dapat menambahkan data yang sesuai di sini jika diperlukan)
                End Using

                MessageBox.Show("File TXT berhasil dibuat di " & saveFileDialog.FileName, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Menambahkan nama file ke dalam pilihanTask
                pilihanTask.Items.Add(Path.GetFileName(saveFileDialog.FileName))

                ' Mengatur item terpilih di pilihanTask
                pilihanTask.SelectedItem = Path.GetFileName(saveFileDialog.FileName)
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub editTask_Click(sender As Object, e As EventArgs) Handles editTask.Click
        If pilihanTask.SelectedIndex <> -1 Then
            Dim selectedFileName As String = pilihanTask.SelectedItem.ToString()
            Dim folderPath As String = document + "\Kolocokro\Command\"
            Dim sourceFilePath As String = Path.Combine(folderPath, selectedFileName)

            If File.Exists(sourceFilePath) Then
                Dim saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Text files (.txt)|.txt|All files (.)|."
                saveFileDialog.FilterIndex = 1
                saveFileDialog.RestoreDirectory = True
                saveFileDialog.InitialDirectory = folderPath
                saveFileDialog.FileName = Path.GetFileNameWithoutExtension(selectedFileName) ' Menggunakan nama file tanpa ekstensi

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Try
                        ' Mengubah ekstensi file menjadi ".txt" saat diubah nama
                        File.Move(sourceFilePath, Path.ChangeExtension(saveFileDialog.FileName, "txt"))

                        ' Mengganti nama file dalam pilihanTask dengan nama baru
                        pilihanTask.Items(pilihanTask.SelectedIndex) = Path.GetFileName(saveFileDialog.FileName)

                        MessageBox.Show("Nama file TXT berhasil diubah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            Else
                MessageBox.Show("File tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Pilih file yang akan diubah nama.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub salinTask_Click(sender As Object, e As EventArgs) Handles salinTask.Click
        If pilihanTask.SelectedIndex <> -1 Then
            Dim selectedFileName As String = pilihanTask.SelectedItem.ToString()
            Dim folderPath As String = document + "\Kolocokro\Command\"
            Dim sourceFilePath As String = Path.Combine(folderPath, selectedFileName)

            If File.Exists(sourceFilePath) Then
                Dim saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Text files (.txt)|.txt|All files (.)|."
                saveFileDialog.FilterIndex = 1
                saveFileDialog.RestoreDirectory = True
                saveFileDialog.InitialDirectory = document + "\Kolocokro\Command"

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    Try
                        ' Menggunakan ekstensi ".txt" saat menyalin file
                        File.Copy(sourceFilePath, Path.ChangeExtension(saveFileDialog.FileName, "txt"))

                        MessageBox.Show("File TXT berhasil disalin.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Menambahkan nama file baru ke dalam pilihanTask
                        pilihanTask.Items.Add(Path.GetFileName(saveFileDialog.FileName))

                        ' Mengatur item terpilih di pilihanTask
                        pilihanTask.SelectedItem = Path.GetFileName(saveFileDialog.FileName)
                    Catch ex As Exception
                        MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            Else
                MessageBox.Show("File tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Pilih file yang akan disalin.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub deleteTask_Click(sender As Object, e As EventArgs) Handles deleteTask.Click
        If pilihanTask.SelectedIndex <> -1 Then
            Dim selectedFileName As String = pilihanTask.SelectedItem.ToString()
            Dim folderPath As String = document + "\Kolocokro\Command\"
            Dim filePath As String = Path.Combine(folderPath, selectedFileName)

            If File.Exists(filePath) Then
                Try
                    ' Menambahkan pemeriksaan ekstensi file sebelum menghapus
                    If Path.GetExtension(filePath).ToLower() = ".txt" Then
                        File.Delete(filePath)

                        ' Menghapus nama file dari pilihanTask
                        pilihanTask.Items.Remove(selectedFileName)

                        ' Menghapus data dari DataGridView
                        dgvStatus.Rows.Clear()

                        MessageBox.Show("File TXT berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Hanya file dengan ekstensi .txt yang dapat dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("File tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Pilih file yang akan dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub importTask_Click(sender As Object, e As EventArgs) Handles importTask.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Text Files|.txt|All Files|.*" ' Mengubah filter agar hanya menampilkan file teks
        openFileDialog.Title = "Pilih File TXT untuk Diimpor"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim selectedFilePath As String = openFileDialog.FileName
                Dim selectedFileName As String = Path.GetFileName(selectedFilePath)
                Dim destinationPath As String = Path.Combine(document, "Kolocokro\Command\", selectedFileName)

                If Not File.Exists(destinationPath) Then
                    ' Menggunakan ekstensi ".txt" saat mengimpor file
                    File.Copy(selectedFilePath, destinationPath)

                    ' Menambahkan nama file baru ke dalam pilihanTask
                    pilihanTask.Items.Add(selectedFileName)

                    MessageBox.Show("File TXT berhasil diimpor.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("File dengan nama yang sama sudah ada di folder tujuan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat mengimpor file TXT: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub exportTask_Click(sender As Object, e As EventArgs) Handles exportTask.Click
        If pilihanTask.SelectedIndex <> -1 AndAlso pilihanTask.SelectedItem IsNot Nothing Then
            Dim selectedFileName As String = pilihanTask.SelectedItem.ToString()
            Dim sourcePath As String = Path.Combine(document, "Kolocokro\Command\", selectedFileName)

            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Text Files|.txt|All Files|.*" ' Mengubah filter agar hanya menampilkan file teks
            saveFileDialog.Title = "Pilih Lokasi untuk Menyimpan File TXT yang Diexport"
            saveFileDialog.FileName = selectedFileName

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Try
                    Dim destinationPath As String = saveFileDialog.FileName

                    If Not File.Exists(destinationPath) Then
                        ' Menggunakan ekstensi ".txt" saat mengekspor file
                        File.Copy(sourcePath, destinationPath)

                        MessageBox.Show("File TXT berhasil diexport.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("File dengan nama yang sama sudah ada di lokasi tujuan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Catch ex As Exception
                    MessageBox.Show("Terjadi kesalahan saat mengekspor file TXT: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Pilih file yang akan diexport.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub recordTask_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub picAdd_Click(sender As Object, e As EventArgs) Handles picAdd.Click
        Dim inputForm As New AddDataForm1()

        Dim result As DialogResult = inputForm.ShowDialog()

        If result = DialogResult.OK Then
            Dim data1 As String = inputForm.DataCommand
            Dim data2 As String = inputForm.DataTarget
            Dim data3 As String = inputForm.DataValue
            dgvStatus.Rows.Add(counter, data1, data2, data3)
            counter += 1
            UpdateRowNumbers()
        End If
        SaveData()
    End Sub

    Private Sub picEdit_Click(sender As Object, e As EventArgs) Handles picEdit.Click
        Try
            If dgvStatus.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = dgvStatus.SelectedRows(0)

                Dim inputForm As New AddDataForm1()
                inputForm.DataCommand = If(selectedRow.Cells(1).Value IsNot Nothing, selectedRow.Cells(1).Value.ToString(), Nothing)
                inputForm.DataTarget = If(selectedRow.Cells(2).Value IsNot Nothing, selectedRow.Cells(2).Value.ToString(), Nothing)
                inputForm.DataValue = If(selectedRow.Cells(3).Value IsNot Nothing, selectedRow.Cells(3).Value.ToString(), Nothing)

                Dim result As DialogResult = inputForm.ShowDialog()

                If result = DialogResult.OK Then
                    Dim newData1 As String = inputForm.DataCommand
                    Dim newData2 As String = inputForm.DataTarget
                    Dim newData3 As String = inputForm.DataValue

                    selectedRow.Cells(1).Value = newData1
                    selectedRow.Cells(2).Value = newData2
                    selectedRow.Cells(3).Value = newData3
                    UpdateRowNumbers()
                End If
            Else
                MessageBox.Show("Pilih baris yang akan diubah.")
            End If
        Catch

        End Try
        SaveData()
    End Sub
    Private Sub picSalin_Click(sender As Object, e As EventArgs) Handles picSalin.Click
        If dgvStatus.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvStatus.SelectedRows(0)

            Dim data1 As String = If(selectedRow.Cells(1).Value IsNot Nothing, selectedRow.Cells(1).Value.ToString(), Nothing)
            Dim data2 As String = If(selectedRow.Cells(2).Value IsNot Nothing, selectedRow.Cells(2).Value.ToString(), Nothing)
            Dim data3 As String = If(selectedRow.Cells(3).Value IsNot Nothing, selectedRow.Cells(3).Value.ToString(), Nothing)

            dgvStatus.Rows.Add(counter, data1, data2, data3)
            counter += 1
            UpdateRowNumbers()
        Else
            MessageBox.Show("Pilih baris yang akan disalin.")
        End If
        SaveData()
    End Sub

    Private Sub UpdateRowNumbers()
        For i As Integer = 0 To dgvStatus.Rows.Count - 1
            dgvStatus.Rows(i).Cells(0).Value = i + 1
        Next
    End Sub

    Private Sub picDelete_Click(sender As Object, e As EventArgs) Handles picDelete.Click
        If dgvStatus.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvStatus.SelectedRows(0)
            dgvStatus.Rows.Remove(selectedRow)
            UpdateRowNumbers()
        Else
            MessageBox.Show("Pilih baris yang akan dihapus.")
        End If
        SaveData()
    End Sub

    Private Sub picUp_Click(sender As Object, e As EventArgs) Handles picUp.Click
        MoveRow(True)
        SaveData()
    End Sub

    Private Sub picDown_Click(sender As Object, e As EventArgs) Handles picDown.Click
        MoveRow(False)
        SaveData()
    End Sub

    Private Sub MoveRow(moveUp As Boolean)
        Try
            If dgvStatus.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = dgvStatus.SelectedRows(0)
                Dim currentIndex As Integer = selectedRow.Index
                Dim newIndex As Integer = If(moveUp, currentIndex - 1, currentIndex + 1)

                If newIndex >= 0 AndAlso newIndex < dgvStatus.Rows.Count Then
                    dgvStatus.Rows.Remove(selectedRow)
                    dgvStatus.Rows.Insert(newIndex, selectedRow)

                    UpdateRowNumbers()
                    dgvStatus.Rows(newIndex).Selected = True
                End If
            Else
                MessageBox.Show("Pilih baris yang akan dipindahkan.")
            End If
        Catch
            MessageBox.Show("Lakukan pemindahan dengan benar")
        End Try
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        ' Periksa apakah BackgroundWorker sedang sibuk
        If Not bwMain.IsBusy Then
            ' Jika tidak sibuk, simpan data, hapus log, dan mulai BackgroundWorker
            SaveData()
            tbLogs.Clear()
            bwMain.RunWorkerAsync()
        Else
            ' Jika sibuk, hentikan BackgroundWorker dan perbarui UI
            If isPlaying Then
                ' Setel flag isPlaying ke False untuk memberi sinyal kepada background worker untuk berhenti
                isPlaying = False
                ' Anda mungkin perlu menambahkan mekanisme untuk memastikan bahwa background worker berhenti dengan mulus
                ' Misalnya, jika objek bot Anda memiliki metode untuk membatalkan atau menghentikan operasi yang sedang berlangsung
                ' Anda dapat memanggil metode tersebut di sini.

                ' Tunggu background worker untuk menyelesaikan atau membatalkan
                bwMain.CancelAsync()

                ' Perbarui UI untuk menampilkan "Play" dan beri tahu pengguna
                btnPlay.Text = "Play"
                MessageBox.Show("Operasi dihentikan.")
            Else
                ' Jika tidak sedang bermain, tampilkan pesan yang menunjukkan bahwa operasi sedang berlangsung
                MessageBox.Show("Operasi sedang berlangsung. Harap tunggu hingga selesai.")
            End If
        End If
    End Sub

    Private Sub listBoxTask_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub AddDataToDataGridView(data As String)
        Dim row As New DataGridViewRow()
        row.CreateCells(dgvStatus)
        row.Cells(0).Value = counter.ToString()
        row.Cells(1).Value = data
        dgvStatus.Rows.Add(row)

        counter += 1
    End Sub

    Private Sub dgvStatus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStatus.CellContentClick
        If e.ColumnIndex = 1 AndAlso e.RowIndex <> -1 Then
            Dim data As String = dgvStatus.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()

            AddDataToDataGridView(data)
        End If
    End Sub

    Private Sub btnClearLogs_Click(sender As Object, e As EventArgs) Handles btnClearLogs.Click
        tbLogs.Clear()
    End Sub

    Private Sub pilihanTask_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pilihanTask.SelectedIndexChanged
        If pilihanTask.SelectedIndex <> -1 Then
            Dim selectedFileName As String = pilihanTask.SelectedItem.ToString()
            Dim folderPath As String = document + "\Kolocokro\Command\"
            Dim filePath As String = Path.Combine(folderPath, selectedFileName)

            Dim data As List(Of String()) = ReadTxtFile(filePath)
            DataCommand = data

            dgvStatus.Rows.Clear()

            For Each row As String() In data
                dgvStatus.Rows.Add(row)
            Next
        End If
    End Sub
    'READ TXT FILTER |
    Private Function ReadTxtFile(filePath As String) As List(Of String())
        Dim dataList As New List(Of String())()

        Try
            Using reader As New StreamReader(filePath)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim values As String() = line.Split("|"c)
                    dataList.Add(values)
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error while reading the TXT file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dataList
    End Function

    Private Function ReadCsvFile(filePath As String) As List(Of String())
        Dim dataList As New List(Of String())()

        Try
            Using reader As New StreamReader(filePath)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    Dim values As String() = line.Split(","c)
                    dataList.Add(values)
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show("Error while reading the CSV file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dataList
    End Function
    Private Sub LoadAvailableFiles()
        Dim folderPath As String = document + "\Kolocokro\Command"
        Dim txtFiles As String() = Directory.GetFiles(folderPath, "*.txt")
        pilihanTask.Items.Clear()

        For Each filePath As String In txtFiles
            Dim fileName As String = Path.GetFileName(filePath)
            pilihanTask.Items.Add(fileName)
        Next

        If pilihanTask.Items.Count > 0 Then
            pilihanTask.SelectedIndex = 0
        End If
    End Sub

    Private Function SaveData()
        If pilihanTask.SelectedItem IsNot Nothing Then
            Dim selectedFile As String = pilihanTask.SelectedItem.ToString()
            Dim path = document + "\Kolocokro\Command\" + selectedFile

            Using sw As New StreamWriter(path)
                If dgvStatus.Rows.Count > 0 Then
                    For Each row As DataGridViewRow In dgvStatus.Rows
                        If Not row.IsNewRow Then
                            Dim rowData As String = ""
                            For colIndex As Integer = 0 To dgvStatus.ColumnCount - 1
                                Dim cellValue As String = If(row.Cells(colIndex).Value IsNot Nothing, row.Cells(colIndex).Value.ToString(), "")
                                rowData += cellValue & "|"
                            Next
                            rowData = rowData.TrimEnd("|")
                            sw.WriteLine(rowData)
                        End If
                    Next
                Else
                    sw.WriteLine("Tidak ada data yang tersimpan.")
                End If
            End Using
        Else
            MessageBox.Show("Pilih file untuk menyimpan data.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Function

    Private Sub bwMain_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwMain.DoWork
        Dim loopCompleted As Boolean = False
        bot = New Command(Me)

        If Not isPlaying Then
            isPlaying = True
            btnPlay.Invoke(Sub() btnPlay.Text = "Pause")

            Dim loopCount As Integer = CInt(numericLoop.Value)

            For loopIndex As Integer = 0 To loopCount


                Do While Not loopCompleted And isPlaying
                    For Each row As DataGridViewRow In dgvStatus.Rows
                        If Not isPlaying Then
                            Exit Do
                        End If
                        If row.Cells("SeleniumCommand").Value IsNot Nothing AndAlso row.Cells("ValueOrURL").Value IsNot Nothing Then
                            Dim No As Integer = row.Cells("No").Value.ToString()
                            Dim seleniumCommand As String = row.Cells("SeleniumCommand").Value.ToString()
                            Dim valueOrURL As String = If(row.Cells("ValueOrURL").Value IsNot Nothing, row.Cells("ValueOrURL").Value.ToString(), String.Empty)
                            Dim value As String = If(row.Cells("AdditionalValue").Value IsNot Nothing, row.Cells("AdditionalValue").Value.ToString(), String.Empty)

                            tbLogs.Invoke(Sub() tbLogs.AppendText(No.ToString + " " + seleniumCommand.ToString + " " + valueOrURL.ToString + " " + value.ToString + vbNewLine))

                            Dim output
                            Dim dataCSV
                            Select Case seleniumCommand
                                Case "Read CSV"
                                    dataCSV = bot.readCSV(valueOrURL, value, ",")
                                    If dataCSV IsNot Nothing Then
                                        tbLogs.Invoke(Sub() tbLogs.AppendText("Read CSV Berhasil" + vbNewLine))
                                    Else
                                        tbLogs.Invoke(Sub() tbLogs.AppendText("Read CSV Error" + vbNewLine))
                                    End If
                                    Exit Select
                                Case "Proxy No Profile"
                                    If valueOrURL.Contains("DataCSV") Then
                                        Dim rowCSV = GetStringBetween(valueOrURL, "[", "]")
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot.ProxyNoProfile(outputCSV)
                                    Else
                                        output = bot.ProxyNoProfile(valueOrURL)
                                    End If
                                    Exit Select
                                Case "Proxy Profile"
                                    output = bot.ProxyProfile(valueOrURL, value)
                                    Exit Select
                            'Error (DropDown)
                                Case "All Clear"
                                    output = bot.AllClear(valueOrURL)
                                    Exit Select
                                Case "Select by text"
                                    bot.SelectbyText(valueOrURL, value)
                                    Exit Select
                                Case "Open"
                                    If valueOrURL.Contains("DataCSV") Then
                                        If loopIndex > 0 Then
                                            Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                            Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                            output = bot.Open(outputCSV)
                                        ElseIf valueOrURL IsNot Nothing Then
                                            Dim rowCSV = GetStringBetween(valueOrURL, "[", "]")
                                            Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                            Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                            output = bot.Open(outputCSV)
                                        Else
                                        End If
                                    Else
                                        output = bot.Open(valueOrURL)
                                    End If
                                    Exit Select
                                Case "Refresh"
                                    output = bot.RefreshPage()
                                    Exit Select
                                Case "Maximize"
                                    output = bot.MaximizeWindow()
                                    Exit Select
                                Case "Minimize"
                                    output = bot.MinimizeWindow()
                                    Exit Select
                                Case "New Tab"
                                    output = bot.OpenNewTab(valueOrURL)
                                    Exit Select
                                Case "New Window"
                                    output = bot.OpenNewWindow(valueOrURL)
                                    Exit Select
                                Case "Set Window Size"
                                    Dim sizeValues As String() = valueOrURL.Split("x"c)
                                    Dim newWidth As Integer = Convert.ToInt32(sizeValues(0).Trim())
                                    Dim newHeight As Integer = Convert.ToInt32(sizeValues(1).Trim())
                                    Dim newSize As New Size(newWidth, newHeight)
                                    output = bot.SizeWindow(newSize)
                                    Exit Select
                                Case "Set Window Position"
                                    Dim positionValues As String() = valueOrURL.Split("x"c)
                                    Dim newXPosition As Integer = Convert.ToInt32(positionValues(0).Trim())
                                    Dim newYPosition As Integer = Convert.ToInt32(positionValues(1).Trim())
                                    Dim newPosition As New Point(newXPosition, newYPosition)
                                    output = bot.PositionWindow(newPosition)
                                    Exit Select
                                Case "Click"
                                    If valueOrURL.Contains("DataCSV") Then
                                        If loopIndex > 0 Then
                                            Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                            Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                            output = bot.Click(outputCSV)
                                        ElseIf valueOrURL IsNot Nothing Then
                                            Dim rowCSV = GetStringBetween(valueOrURL, "[", "]")
                                            Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                            Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                            output = bot.Click(outputCSV)
                                        End If
                                    Else
                                        output = bot.Click(valueOrURL)
                                    End If
                                    Exit Select
                                Case "Click All Delete"
                                    output = bot.ClickAllDelete(valueOrURL)
                                    Exit Select
                                Case "ClearCokies"
                                    output = bot.ClearAllCookies()
                                    Exit Select
                                Case "AddCokies"
                                    output = bot.AddCookies(valueOrURL)
                                    Exit Select
                                Case "sendKeys"
                                    If value.Contains("DataCSV") Then
                                        If loopIndex > 0 Then
                                            Dim colCSV = GetStringBetween(value, "][", "]")
                                            Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                            output = bot.sendKeys(valueOrURL, outputCSV)
                                        ElseIf value IsNot Nothing Then
                                            Dim rowCSV = GetStringBetween(value, "[", "]")
                                            Dim colCSV = GetStringBetween(value, "][", "]")
                                            Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                            output = bot.sendKeys(valueOrURL, outputCSV)
                                        Else
                                        End If
                                    Else
                                        output = bot.sendKeys(valueOrURL, value)
                                    End If
                                    Exit Select
                                Case "Type"
                                    output = bot.Type(valueOrURL, value)
                                    Exit Select
                                Case "TypeBackspace"
                                    Dim jumlah As Integer = Convert.ToInt32(value)
                                    output = bot.TypeBackspace(valueOrURL, jumlah)
                                    Exit Select
                                Case "Double Click"
                                    output = bot.DoubleClick(valueOrURL)
                                    Exit Select
                                Case "Upload"
                                    If value.Contains("DataCSV") Then
                                        If loopIndex > 0 Then
                                            Dim colCSV = GetStringBetween(value, "][", "]")
                                            Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                            output = bot.UploadFile(valueOrURL, outputCSV)
                                        ElseIf value IsNot Nothing Then
                                            Dim rowCSV = GetStringBetween(value, "[", "]")
                                            Dim colCSV = GetStringBetween(value, "][", "]")
                                            Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                            output = bot.UploadFile(valueOrURL, outputCSV)
                                        Else
                                        End If
                                    Else
                                        output = bot.UploadFile(valueOrURL, value)
                                    End If
                                    Exit Select
                                Case "ClickUpload"
                                    If value.Contains("DataCSV") Then
                                        If loopIndex > 0 Then
                                            Dim colCSV = GetStringBetween(value, "][", "]")
                                            Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                            output = bot.ClickUpload(valueOrURL, outputCSV)
                                        ElseIf value IsNot Nothing Then
                                            Dim rowCSV = GetStringBetween(value, "[", "]")
                                            Dim colCSV = GetStringBetween(value, "][", "]")
                                            Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                            output = bot.ClickUpload(valueOrURL, outputCSV)
                                        Else
                                        End If
                                    Else
                                        output = bot.ClickUpload(valueOrURL, value)
                                    End If
                                    Exit Select
                                Case "Copy Paste"
                                    output = bot.CopyPaste(valueOrURL, value)
                                    Exit Select
                                Case "OpenFrame"
                                    output = bot.OpenFrame(valueOrURL)
                                    Exit Select
                                Case "Close"
                                    output = bot.Close()
                                    Exit Select
                                Case "CloseFrame"
                                    output = bot.CloseFrame()
                                    Exit Select
                                Case "Pause"
                                    Dim pauseDuration As Integer = Convert.ToInt32(valueOrURL)

                                    ' Memulai tugas secara bersamaan
                                    Dim pauseTask = Task.Run(Sub() bot.Pause(pauseDuration))
                                    Dim countdownTask = Task.Run(Async Sub()
                                                                     For i As Integer = pauseDuration To 1 Step -1
                                                                         ' Membuat teks untuk hitung mundur
                                                                         Dim logText As String = i.ToString + " "
                                                                         tbLogs.Invoke(Sub() tbLogs.AppendText(logText))

                                                                         ' Tunggu selama 1 detik
                                                                         Await Task.Delay(1000)
                                                                     Next
                                                                 End Sub)

                                    ' Menunggu hingga kedua tugas selesai
                                    Task.WhenAll(pauseTask, countdownTask).Wait()

                                    Exit Select

                                Case "Profile"
                                    If cbProfile.Checked Then
                                        If valueOrURL.Contains("DataCSV") Then
                                            If loopIndex > 0 Then
                                                Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                                Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                                output = bot.Profile(outputCSV)
                                            ElseIf valueOrURL IsNot Nothing Then
                                                Dim rowCSV = GetStringBetween(valueOrURL, "[", "]")
                                                Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                                Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                                output = bot.Profile(outputCSV)
                                            End If
                                        Else
                                            output = bot.Profile(valueOrURL)
                                        End If
                                    Else
                                        output = bot.NoProfile()
                                    End If
                                    Exit Select
                                Case "Hide Browser"
                                    Dim positionValues As String() = "10000.10000".Split("."c)
                                    Dim newXPosition As Integer = Convert.ToInt32(positionValues(0).Trim())
                                    Dim newYPosition As Integer = Convert.ToInt32(positionValues(1).Trim())
                                    Dim newPosition As New Point(newXPosition, newYPosition)
                                    output = bot.HideBrowser(newPosition)
                                    Exit Select
                                Case "Scroll Up"
                                    Dim y As Integer = Convert.ToInt32(valueOrURL)
                                    output = bot.ScrollUp(y)
                                    Exit Select
                                Case "Scroll Down"
                                    Dim minY As Integer = Convert.ToInt32(valueOrURL)
                                    output = bot.ScrollDown(minY)
                                    Exit Select
                                Case "Scroll Element"
                                    Dim minY As Integer = Convert.ToInt32(value)
                                    output = bot.ScrollByElement(valueOrURL, minY)
                                    Exit Select
                                Case "Wait For Element"
                                    Dim wait As Integer = Convert.ToInt32(value)
                                    output = bot.WaitForElement(valueOrURL, wait)
                                    Exit Select
                                Case "Down"
                                    output = bot.Down()
                                    Exit Select
                                Case "Up"
                                    output = bot.Up()
                                    Exit Select
                                Case "Left"
                                    output = bot.Left()
                                    Exit Select
                                Case "Right"
                                    output = bot.Right()
                                    Exit Select
                                Case "Enter"
                                    output = bot.Enter()
                                    Exit Select
                            End Select
                            ' Check if the output contains an error
                            If output.ToString().Contains("Error") Then
                                ' Output contains an error, set loopCompleted to False to repeat the loop
                                loopCompleted = False

                                ' Optionally, add some delay before retrying the loop
                                Thread.Sleep(1000)
                            Else
                                ' Output is successful, set loopCompleted to True to move to the next iteration
                                loopCompleted = True
                            End If

                            tbLogs.Invoke(Sub() tbLogs.AppendText(output + vbNewLine + vbNewLine))
                        End If
                    Next
                Loop

                ' Check if the user has paused the operation
                If Not isPlaying Then
                    Exit For
                End If
            Next

            ' Menggunakan Invoke untuk mengakses kontrol UI
            isPlaying = False
            btnPlay.Invoke(Sub() btnPlay.Text = "Play") ' Mengganti teks tombol menjadi "Play" setelah selesai atau di-pause
        Else
            ' Menggunakan Invoke untuk mengakses kontrol UI
            isPlaying = False
            btnPlay.Invoke(Sub() btnPlay.Text = "Play") ' Mengganti teks tombol menjadi "Play" jika tombol pause ditekan
        End If
    End Sub

    Private Sub bwAddProxy_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwAddProxy.DoWork
        For Each proxy In tbProxy.Lines
            Dim pcproxy = Split(proxy, ":")
            Dim proxydir = document + "\Kolocokro\Proxy\" + pcproxy(0)

            If My.Computer.FileSystem.DirectoryExists(proxydir) Then
                MessageBox.Show("Proxy dengan nama " & pcproxy(0) & " sudah ada di folder!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim manifest = "
{
    ""version"": ""1.0.0"",
    ""manifest_version"": 2,
    ""name"": """ + Trim(pcproxy(0)) + """,
    ""permissions"": [
        ""proxy"",
        ""tabs"",
        ""unlimitedStorage"",
        ""storage"",
        ""<all_urls>"",
        ""webRequest"",
        ""webRequestBlocking""
    ],
    ""background"": {
        ""scripts"": [""background.js""]
    },
    ""minimum_chrome_version"":""22.0.0""
}"
                Dim backgrond = "var config = {
        mode: ""fixed_servers"",
        rules: {
          singleProxy: {
            scheme: ""http"",
            host: """ + Trim(pcproxy(0)) + """,
            port: parseInt(" + Trim(pcproxy(1)) + ")
          },
          bypassList: [""localhost""]
        }
      };

chrome.proxy.settings.set({value: config, scope: ""regular""}, function() {});

function callbackFn(details) {
    return {
        authCredentials: {
            username: """ + Trim(pcproxy(2)) + """,
            password: """ + Trim(pcproxy(3)) + """
        }
    };
}

chrome.webRequest.onAuthRequired.addListener(
            callbackFn,
            {urls: [""<all_urls>""]},
            ['blocking']
);"

                My.Computer.FileSystem.CreateDirectory(proxydir)
                My.Computer.FileSystem.WriteAllText(proxydir + "/manifest.json", manifest, False)
                My.Computer.FileSystem.WriteAllText(proxydir + "/background.js", backgrond, False)
                My.Computer.FileSystem.WriteAllText(proxydir + "/ip.conf", proxy, False)
            End If
        Next

        MessageBox.Show("Proses selesai!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub btnAddProxy_Click(sender As Object, e As EventArgs) Handles btnAddProxy.Click
        MsgBox("Tunggu Hingga ada pesan selesai")
        bwAddProxy.RunWorkerAsync()
    End Sub

    Private Sub btnBackProxy_Click(sender As Object, e As EventArgs) Handles btnBackProxy.Click
        cbProxy.Items.Clear()

        For Each proxyDir In My.Computer.FileSystem.GetDirectories(document + "\Kolocokro\Proxy\")
            Dim namaProxy = Split(proxyDir, "\").Last
            cbProxy.Items.Add(namaProxy)
        Next
        tcMain.SelectedIndex = 0
    End Sub

    Private Sub btnCleanDriver_Click(sender As Object, e As EventArgs) Handles btnCleanDriver.Click
        ' Periksa apakah BackgroundWorker sedang sibuk
        If Not bwCleanDriver.IsBusy Then
            bwCleanDriver.RunWorkerAsync()
        Else
            ' Jika sedang sibuk, Anda bisa menampilkan pesan atau menanganinya sesuai kebutuhan
            MessageBox.Show("Operasi sedang berlangsung. Harap tunggu hingga selesai.")
        End If
    End Sub

    Private Sub bwCleanDriver_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwCleanDriver.DoWork
        checkCleanProcessNewForMainFOrm("execute")
        CloseChromeDriver()
    End Sub

    'CLEAN DRIVER
    Function checkCleanProcessNewForMainFOrm(Type)
        Dim searcher As ManagementObjectSearcher = New ManagementObjectSearcher("Select * " & "FROM Win32_Process ")
        Dim allProcess As ManagementObjectCollection = searcher.[Get]()
        Dim unusedProcessFound = False
        For Each p In allProcess
            Dim pName As String = p.GetPropertyValue("Name")
            If pName.ToLower = "chrome" Or pName.ToLower = "chrome.exe" Then
                Dim pid As UInt32 = CType(p("ProcessId"), UInt32)
                Dim parId = GetParent(pid.ToString)
                'MsgBox(parId)
                Try
                    Dim xx As Process = Process.GetProcessById(CInt(parId))
                    'MsgBox("1")
                Catch ex As Exception
                    'MsgBox("2")
                    Try
                        Dim unusedprocess As Process = Process.GetProcessById(CInt(pid))
                        If Type = "execute" Then
                            unusedprocess.Kill()
                        ElseIf Type = "check" Then
                            unusedProcessFound = True
                        End If
                    Catch gege As Exception
                    End Try
                End Try
            End If
        Next
        Return unusedProcessFound
    End Function

    Public Shared Function GetParent(pid)
        Try
            Using query = New ManagementObjectSearcher("SELECT * " & "FROM Win32_Process " & "WHERE ProcessId=" & pid.ToString)
                Dim parent = query.[Get]().OfType(Of ManagementObject)().[Select](Function(p) Process.GetProcessById(CInt(CUInt(p("ParentProcessId"))))).FirstOrDefault()
                Try
                    Return parent.Id.ToString
                Catch ex As Exception
                    Return ""
                End Try
            End Using
        Catch
            Return ""
        End Try
    End Function
    'CLEAN DRIVER
    Public Function CloseChromeDriver()
        ' Nama proses untuk chromedriver.exe
        Dim processName As String = "chromedriver"

        ' Mengambil semua proses dengan nama yang sesuai
        Dim chromeDriverProcesses() As Process = Process.GetProcessesByName(processName)

        ' Menutup setiap instansi chromedriver.exe
        For Each chromeDriverProcess As Process In chromeDriverProcesses
            Try
                If Not chromeDriverProcess.HasExited Then
                    chromeDriverProcess.CloseMainWindow()

                    ' Menunggu maksimal 5 detik untuk keluar
                    If Not chromeDriverProcess.WaitForExit(5000) Then
                        chromeDriverProcess.Kill() ' Jika belum keluar dalam 5 detik, maka tutup paksa
                    End If
                End If
            Catch ex As Exception
                ' Tangani exception jika diperlukan
                Console.WriteLine($"Error closing {processName}: {ex.Message}")
            End Try
        Next

        ' Membersihkan objek proses
        For Each chromeDriverProcess As Process In chromeDriverProcesses
            Try
                If Not chromeDriverProcess.HasExited Then
                    ' Jika masih berjalan, tunggu hingga selesai
                    chromeDriverProcess.WaitForExit()
                End If
            Catch ex As Exception
                ' Tangani exception jika diperlukan
                Console.WriteLine($"Error waiting for exit {processName}: {ex.Message}")
            Finally
                ' Pastikan untuk memanggil Dispose untuk setiap objek proses
                chromeDriverProcess.Close()
                chromeDriverProcess.Dispose()
            End Try
        Next
        MessageBox.Show("Selesai", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Function

    Public Function GetStringBetween(ByVal InputText As String, ByVal starttext As String, ByVal endtext As String)
        Try
            Dim pc1 = Split(InputText, starttext)
            Dim pc2 = Split(pc1(1), endtext)
            Return pc2(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub btnDriver_Click(sender As Object, e As EventArgs) Handles btnDriver.Click
        ServicePointManager.Expect100Continue = True
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12

        Dim chromeversion = check_chrome()

        Dim client As New WebClient
        client.Headers.Set(HttpRequestHeader.UserAgent, "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/100.0.4896.60 Safari/537.36")
        Dim result = client.DownloadString("https://riffasoft.com/chrome/index.php?version=" + chromeversion + "&product=chromedriver&platform=win32&latest=true")
        Dim resultJson = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Object)(result)
        Dim cdUrl = resultJson(0)("url")

        Dim client2 As New WebClient
        client2.Headers.Set(HttpRequestHeader.UserAgent, "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/100.0.4896.60 Safari/537.36")
        client2.DownloadFile(cdUrl.ToString, document + "\Kolocokro\Driver\chromedriver.zip")
        MsgBox("Download Selesai")
    End Sub
    Function check_chrome()
        Try
            Dim command = ""
            Dim win10LocalPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\Google\Chrome\Application\chrome.exe"
            win10LocalPath = Replace(win10LocalPath, "\", "\\")
            Dim chromeurl = ""
            Dim type = "Default System Chrome"

            If My.Computer.FileSystem.FileExists("C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe") Then
                chromeurl = "C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe"
                command = "datafile where name=""C:\\Program Files (x86)\\Google\\Chrome\\Application\\chrome.exe"" Get Version /value"
            ElseIf My.Computer.FileSystem.FileExists("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe") Then
                chromeurl = "C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe"
                command = "datafile where name=""C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe"" Get Version /value"
            ElseIf My.Computer.FileSystem.FileExists(win10LocalPath) Then
                chromeurl = win10LocalPath
                command = "datafile where name=""" + win10LocalPath.ToString + """ Get Version /value"
            End If
            Dim p As Process = New Process()
            p.StartInfo.FileName = "wmic"
            p.StartInfo.Arguments = command
            p.StartInfo.UseShellExecute = False ' false
            p.StartInfo.CreateNoWindow = True
            p.StartInfo.RedirectStandardOutput = True
            Dim proc As Process = Process.Start(p.StartInfo)
            Dim d As StreamReader = proc.StandardOutput
            Dim version = Trim(d.ReadToEnd.ToString)
            proc.WaitForExit()
            proc.Close()

            Dim chromeVersion = GetStringBetween(version.ToLower, "version=", ".")
            Return chromeVersion
        Catch ex As Exception

            Return "No Chrome Installed|::||::|"
        End Try
    End Function

    Private Sub FormMenu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ' Periksa apakah BackgroundWorker sedang sibuk
        If Not bwCleanDriver.IsBusy Then
            ' Jika tidak sibuk, simpan data, hapus log, dan mulai BackgroundWorker
            bwCleanDriver.RunWorkerAsync()
        Else
            ' Jika sedang sibuk, Anda bisa menampilkan pesan atau menanganinya sesuai kebutuhan
            MessageBox.Show("Operasi sedang berlangsung. Harap tunggu hingga selesai.")
        End If
    End Sub
End Class