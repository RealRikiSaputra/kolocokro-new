Imports System.IO
Imports OpenQA.Selenium.DevTools.V117.Page

Public Class FormCSV
    Public Shared DataList As List(Of String())
    Dim document As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments

    Public Sub New()
        InitializeComponent()
        LoadAvailableFiles()
        'LoadData()
    End Sub

    Private Sub FormCSV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAvailableFiles()
        'LoadData()
    End Sub

    Private Sub LoadAvailableFiles()
        Dim folderPath As String = document + "\Kolocokro\CSV"
        Dim csvFiles As String() = Directory.GetFiles(folderPath, "*.csv")
        CSVSelect.Items.Clear()

        For Each filePath As String In csvFiles
            Dim fileName As String = Path.GetFileName(filePath)
            ' Atau, jika Anda ingin tanpa ekstensi, gunakan:
            ' Dim fileName As String = Path.GetFileNameWithoutExtension(filePath)
            CSVSelect.Items.Add(fileName)
        Next

        If csvFiles.Length > 0 Then
            CSVSelect.SelectedIndex = 0
        End If
    End Sub


    Private Function SaveData()
        If CSVSelect.SelectedItem IsNot Nothing Then
            Dim selectedFile As String = CSVSelect.SelectedItem.ToString()
            Dim path = document + "\Kolocokro\CSV\" + selectedFile

            Using sw As New StreamWriter(path)
                If dgvCSV.Rows.Count > 0 Then
                    For Each row As DataGridViewRow In dgvCSV.Rows
                        If Not row.IsNewRow Then
                            Dim rowData As String = ""
                            For colIndex As Integer = 0 To dgvCSV.ColumnCount - 1
                                Dim cellValue As String = If(row.Cells(colIndex).Value IsNot Nothing, row.Cells(colIndex).Value.ToString(), "")
                                rowData += cellValue & ","
                            Next
                            rowData = rowData.TrimEnd(",")
                            sw.WriteLine(rowData)
                        End If
                    Next
                    MsgBox("Data Berhasil Di Simpan")
                Else
                    sw.WriteLine("Tidak ada data yang tersimpan.")
                End If
            End Using
        Else
            MessageBox.Show("Pilih file untuk menyimpan data.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Function

    'Private Sub LoadData()
    'If CSVSelect.SelectedItem IsNot Nothing Then
    '    Dim selectedFile As String = CSVSelect.SelectedItem.ToString()

    '    If File.Exists(selectedFile) Then
    '        ' Bersihkan DataGridView sebelum menambahkan data baru
    '        dgvCSV.Rows.Clear()
    '        dgvCSV.Refresh()

    '        Using sr As New StreamReader(selectedFile)
    '            Dim line As String = sr.ReadLine()
    '            While line IsNot Nothing
    '                If Not line.Contains("#") Then
    '                    Dim strSplit As String() = line.Split(","c)
    '                    ' Tambahkan baris baru ke DataGridView dengan nilai-nilai kolom dari CSV
    '                    dgvCSV.Rows.Add(strSplit)
    '                End If
    '                line = sr.ReadLine()
    '            End While
    '        End Using
    '    End If
    'End If
    'End Sub


    Private Sub btnBackCSV_Click(sender As Object, e As EventArgs) Handles btnBackCSV.Click
        Dim form1 As FormMenu = DirectCast(Application.OpenForms("FormMenu"), FormMenu)
        form1.Show()
        Close()
    End Sub
    Private Sub pbFolderCSV_Click(sender As Object, e As EventArgs) Handles pbFolderCSV.Click
        'Dim openFileDialog As New OpenFileDialog()
        'openFileDialog.Filter = "CSV Files|*.csv"

        'If openFileDialog.ShowDialog() = DialogResult.OK Then
        '    Dim filePath As String = openFileDialog.FileName
        '    Dim fileName As String = Path.GetFileName(filePath)

        '    CSVSelect.Items.Add(fileName)

        '    Dim data As List(Of String()) = ReadCsvFile(filePath)

        '    dgvCSV.Rows.Clear()
        '    dgvCSV.Columns.Clear()

        '    For i As Integer = 0 To data(0).Length - 1
        '        dgvCSV.Columns.Add("Column" & i, "Column" & i)
        '    Next

        '    For Each row As String() In data
        '        dgvCSV.Rows.Add(row)
        '    Next

        '    dgvCSV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells)
        'End If
    End Sub

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

    Private Sub CSVSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CSVSelect.SelectedIndexChanged
        If CSVSelect.SelectedIndex <> -1 Then
            Dim selectedFileName As String = CSVSelect.SelectedItem.ToString()
            Dim filePath As String = Path.Combine(document + "\Kolocokro\CSV", selectedFileName)
            Dim data As List(Of String()) = ReadCsvFile(filePath)
            DataList = data

            dgvCSV.Rows.Clear()

            For Each row As String() In data
                dgvCSV.Rows.Add(row)
            Next
        End If
    End Sub


    Private Sub CSVadd_Click(sender As Object, e As EventArgs) Handles CSVadd.Click
        Dim saveFileDialog As New SaveFileDialog()

        saveFileDialog.InitialDirectory = document + "\Kolocokro\CSV"

        saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
        saveFileDialog.FilterIndex = 1
        saveFileDialog.RestoreDirectory = True

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Using sw As New StreamWriter(saveFileDialog.FileName)
                End Using

                MessageBox.Show("File CSV berhasil dibuat di " & saveFileDialog.FileName, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                CSVSelect.Items.Add(Path.GetFileName(saveFileDialog.FileName))

                CSVSelect.SelectedItem = Path.GetFileName(saveFileDialog.FileName)
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub CSVdelete_Click(sender As Object, e As EventArgs) Handles CSVdelete.Click
        If CSVSelect.SelectedIndex <> -1 Then
            Dim selectedFileName As String = CSVSelect.SelectedItem.ToString()
            Dim folderPath As String = document + "\Kolocokro\CSV\"
            Dim filePath As String = Path.Combine(folderPath, selectedFileName)

            If File.Exists(filePath) Then
                Try
                    File.Delete(filePath)

                    CSVSelect.Items.Remove(selectedFileName)

                    dgvCSV.Rows.Clear()

                    MessageBox.Show("File CSV berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
    Private Sub CSVimport_Click(sender As Object, e As EventArgs) Handles CSVimport.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "CSV Files|*.csv|All Files|*.*"
        openFileDialog.Title = "Pilih File CSV untuk Diimpor"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                Dim selectedFilePath As String = openFileDialog.FileName
                Dim selectedFileName As String = Path.GetFileName(selectedFilePath)
                Dim destinationPath As String = Path.Combine(document, "Kolocokro\CSV\", selectedFileName)

                If Not File.Exists(destinationPath) Then
                    File.Copy(selectedFilePath, destinationPath)

                    CSVSelect.Items.Add(selectedFileName)

                    MessageBox.Show("File CSV berhasil diimpor.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("File dengan nama yang sama sudah ada di folder tujuan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat mengimpor file CSV: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub CSVsave_Click(sender As Object, e As EventArgs) Handles CSVsave.Click
        SaveData()
    End Sub
    Private Sub CSVtext_Click(sender As Object, e As EventArgs) Handles CSVtext.Click

    End Sub
    Private Sub CSVaddColl_Click(sender As Object, e As EventArgs) Handles CSVaddColl.Click
        ' Menambahkan kolom baru ke DataGridView
        Dim newColumnIndex As Integer = dgvCSV.Columns.Add(New DataGridViewTextBoxColumn())

        ' Mengatur nama dan header teks kolom baru
        dgvCSV.Columns(newColumnIndex).Name = "Column" & newColumnIndex
        dgvCSV.Columns(newColumnIndex).HeaderText = "Column " & newColumnIndex

        ' Mengatur lebar kolom agar sesuai dengan kontennya
        dgvCSV.AutoResizeColumn(newColumnIndex, DataGridViewAutoSizeColumnMode.DisplayedCells)
    End Sub

    Private Sub CSVmoveColl_Click(sender As Object, e As EventArgs) Handles CSVmoveColl.Click

    End Sub
    Private Sub CSVdeleteColl_Click(sender As Object, e As EventArgs) Handles CSVdeleteColl.Click
        ' Memeriksa apakah ada kolom yang dipilih
        If dgvCSV.SelectedCells.Count > 0 Then
            ' Mendapatkan indeks kolom dari sel yang dipilih
            Dim selectedColumnIndex As Integer = dgvCSV.SelectedCells(0).ColumnIndex

            ' Memastikan indeks kolom valid
            If selectedColumnIndex >= 0 And selectedColumnIndex < dgvCSV.Columns.Count Then
                ' Menghapus kolom dari DataGridView
                dgvCSV.Columns.RemoveAt(selectedColumnIndex)

                ' Mengupdate nama dan header teks kolom
                For i As Integer = selectedColumnIndex To dgvCSV.Columns.Count - 1
                    dgvCSV.Columns(i).Name = "Column" & i
                    dgvCSV.Columns(i).HeaderText = "Column " & i
                Next i
            Else
                MessageBox.Show("Indeks kolom tidak valid.")
            End If
        Else
            MessageBox.Show("Pilih sel dalam kolom yang ingin dihapus.")
        End If
    End Sub
    Private Sub CSVfileData_Click(sender As Object, e As EventArgs) Handles CSVfileData.Click

    End Sub

    Private Sub CSVproxyData_Click(sender As Object, e As EventArgs) Handles CSVproxyData.Click

    End Sub

    Private Sub CSVprofileData_Click(sender As Object, e As EventArgs) Handles CSVprofileData.Click

    End Sub

    Private Sub CSVspintaxData_Click(sender As Object, e As EventArgs) Handles CSVspintaxData.Click

    End Sub

    Private Sub CSVgenerateData_Click(sender As Object, e As EventArgs) Handles CSVgenerateData.Click

    End Sub
End Class