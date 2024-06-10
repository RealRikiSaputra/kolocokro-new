Imports System.IO
Imports System.Management

Public Class FormSchedule
    Private bot As Command
    Private bot1 As Command1
    Private bot2 As Command2
    Private bot3 As Command3
    Private bot4 As Command4
    Dim document As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    Private Sub btnScheduleBack_Click(sender As Object, e As EventArgs) Handles btnScheduleBack.Click
        Dim form1 As FormMenu = DirectCast(Application.OpenForms("FormMenu"), FormMenu)
        form1.Show()
        Close()
    End Sub

    Private Sub FormSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Periksa apakah BackgroundWorker sedang sibuk
        If Not bwCleanDriver.IsBusy Then
            bwCleanDriver.RunWorkerAsync()
        End If

        loadTask()
        'loadProfile()
        bwMain1.WorkerSupportsCancellation = True
        bwMain2.WorkerSupportsCancellation = True
        bwMain3.WorkerSupportsCancellation = True
        bwMain4.WorkerSupportsCancellation = True
        bwMain5.WorkerSupportsCancellation = True
    End Sub

    Private Sub btnStart1_Click(sender As Object, e As EventArgs) Handles btnStart1.Click
        If My.Computer.FileSystem.FileExists(document + "\Kolocokro\upload") Then
            My.Computer.FileSystem.DeleteFile(document + "\Kolocokro\upload")
        End If
        tbLogs1.Clear()
        If bwMain1.IsBusy Then
            bwMain1.CancelAsync()
            btnStart1.Text = "Play"
        Else
            bwMain1.RunWorkerAsync()
            btnStart1.Text = "Stop"
        End If
    End Sub

    Private Sub btnStart2_Click(sender As Object, e As EventArgs) Handles btnStart2.Click
        If My.Computer.FileSystem.FileExists(document + "\Kolocokro\upload") Then
            My.Computer.FileSystem.DeleteFile(document + "\Kolocokro\upload")
        End If
        tbLogs2.Clear()
        bwMain2.RunWorkerAsync()
    End Sub

    Private Sub btnStart3_Click(sender As Object, e As EventArgs) Handles btnStart3.Click
        If My.Computer.FileSystem.FileExists(document + "\Kolocokro\upload") Then
            My.Computer.FileSystem.DeleteFile(document + "\Kolocokro\upload")
        End If
        tbLogs3.Clear()
        bwMain3.RunWorkerAsync()
    End Sub

    Private Sub btnStart4_Click(sender As Object, e As EventArgs) Handles btnStart4.Click
        If My.Computer.FileSystem.FileExists(document + "\Kolocokro\upload") Then
            My.Computer.FileSystem.DeleteFile(document + "\Kolocokro\upload")
        End If
        tbLogs4.Clear()
        bwMain4.RunWorkerAsync()
    End Sub

    Private Sub btnStart5_Click(sender As Object, e As EventArgs) Handles btnStart5.Click
        If My.Computer.FileSystem.FileExists(document + "\Kolocokro\upload") Then
            My.Computer.FileSystem.DeleteFile(document + "\Kolocokro\upload")
        End If
        tbLogs5.Clear()
        bwMain5.RunWorkerAsync()
    End Sub
    Private Sub btnClearLogs1_Click(sender As Object, e As EventArgs) Handles btnClearLogs1.Click
        tbLogs1.Clear()
    End Sub

    Private Sub btnClearLogs2_Click(sender As Object, e As EventArgs) Handles btnClearLogs2.Click
        tbLogs2.Clear()
    End Sub

    Private Sub btnClearLogs3_Click(sender As Object, e As EventArgs) Handles btnClearLogs3.Click
        tbLogs3.Clear()
    End Sub

    Private Sub btnClearLogs4_Click(sender As Object, e As EventArgs) Handles btnClearLogs4.Click
        tbLogs4.Clear()
    End Sub

    Private Sub btnClearLogs5_Click(sender As Object, e As EventArgs) Handles btnClearLogs5.Click
        tbLogs5.Clear()
    End Sub

    Private Sub btnStartAll_Click(sender As Object, e As EventArgs) Handles btnStartAll.Click
        bwMain1.RunWorkerAsync()
        bwMain2.RunWorkerAsync()
        bwMain3.RunWorkerAsync()
        bwMain4.RunWorkerAsync()
        bwMain5.RunWorkerAsync()
        If My.Computer.FileSystem.FileExists(document + "\Kolocokro\upload") Then
            My.Computer.FileSystem.DeleteFile(document + "\Kolocokro\upload")
        End If
    End Sub
    Private Sub bwCleanDriver_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwCleanDriver.DoWork
        checkCleanProcessNewForMainFOrm("execute")
        CloseChromeDriver()
    End Sub

    Private Sub bwMain1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwMain1.DoWork
        bot = New Command()
        Dim selectedTask As Object = Nothing
        Dim txt As String

        ' Periksa apakah perlu menggunakan Invoke dan jalankan di thread UI jika diperlukan
        If cbTask1.InvokeRequired Then
            cbTask1.Invoke(Sub()
                               selectedTask = cbTask1.SelectedItem
                           End Sub)
        Else
            selectedTask = cbTask1.SelectedItem
        End If

        ' Sekarang Anda dapat menggunakan variabel 'selectedTask' sesuai kebutuhan.
        If selectedTask IsNot Nothing Then
            txt = selectedTask.ToString()
            Dim path = document + "\Kolocokro\Command\"

            ' Gunakan fungsi ReadTXT yang telah dimodifikasi
            Dim txtData As List(Of String()) = ReadTXT(path + txt)

            ' Periksa apakah data TXT tidak mengandung error
            If txtData IsNot Nothing AndAlso txtData.Count > 0 Then
                ' Sekarang Anda dapat mengulangi data TXT dan memprosesnya
                Dim loopCount As Integer = CInt(nlTask1.Value)

                For loopIndex As Integer = 0 To loopCount
                    For Each txtRow As String() In txtData
                        ' Ekstrak nilai dari baris TXT
                        Dim No As Integer = Convert.ToInt32(txtRow(0))
                        Dim seleniumCommand As String = txtRow(1).ToString()
                        Dim valueOrURL As String = If(txtRow.Length > 2 AndAlso Not String.IsNullOrEmpty(txtRow(2)), txtRow(2).ToString(), Nothing)
                        Dim value As String = If(txtRow.Length > 3, txtRow(3).ToString(), String.Empty)

                        tbLogs1.Invoke(Sub() tbLogs1.AppendText(No.ToString + " " + seleniumCommand.ToString + " " + valueOrURL.ToString + " " + value.ToString + vbNewLine))
                        Dim output
                        Dim dataCSV
                        Select Case seleniumCommand
                            Case "Read CSV"
                                dataCSV = bot.readCSV(valueOrURL, value, ",")
                                If dataCSV IsNot Nothing Then
                                    tbLogs1.Invoke(Sub() tbLogs1.AppendText("Read CSV Berhasil" + vbNewLine))
                                    output = "Selesai"
                                Else
                                    tbLogs1.Invoke(Sub() tbLogs1.AppendText("Read CSV Error" + vbNewLine))
                                    output = "Error"
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
                                Dim countdownTask = Task.Run(Async Function()
                                                                 For i As Integer = pauseDuration To 1 Step -1
                                                                     ' Membuat teks untuk hitung mundur
                                                                     Dim logText As String = "Hitung Mundur: " + i.ToString + vbNewLine
                                                                     tbLogs1.Invoke(Sub() tbLogs1.AppendText(logText))

                                                                     ' Tunggu selama 1 detik
                                                                     Await Task.Delay(1000)
                                                                 Next
                                                             End Function)

                                ' Menunggu hingga kedua tugas selesai
                                Task.WhenAll(pauseTask, countdownTask).Wait()

                                Exit Select

                            Case "Profile"
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
                            Case "Wait Element Clickable"
                                Dim wait As Integer = Convert.ToInt32(value)
                                output = bot.WaitElementClickable(valueOrURL, wait)
                                Exit Select
                            Case "Wait Element Exists"
                                Dim wait As Integer = Convert.ToInt32(value)
                                output = bot.WaitElementExists(valueOrURL, wait)
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
                            Case "Back"
                                output = bot.Back()
                                Exit Select
                        End Select
                        'END CASE
                        tbLogs1.Invoke(Sub() tbLogs1.AppendText(output + vbNewLine + vbNewLine))
                    Next
                    ' Periksa apakah BackgroundWorker sedang sibuk
                    If Not bwCleanDriver.IsBusy Then
                        bwCleanDriver.RunWorkerAsync()
                    End If
                Next
            Else
                ' Handle the error case
                tbLogs1.Invoke(Sub() tbLogs1.AppendText("Error Membaca Command" + vbNewLine))
            End If
        Else
            MsgBox("Tidak ada item yang dipilih dalam ComboBox.")
        End If
    End Sub

    Private Sub bwMain2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwMain2.DoWork
        bot1 = New Command1()
        Dim selectedTask As Object = Nothing
        Dim txt As String

        ' Periksa apakah perlu menggunakan Invoke dan jalankan di thread UI jika diperlukan
        If cbTask2.InvokeRequired Then
            cbTask2.Invoke(Sub()
                               selectedTask = cbTask2.SelectedItem
                           End Sub)
        Else
            selectedTask = cbTask2.SelectedItem
        End If

        ' Sekarang Anda dapat menggunakan variabel 'selectedTask' sesuai kebutuhan.
        If selectedTask IsNot Nothing Then
            txt = selectedTask.ToString()
            Dim path = document + "\Kolocokro\Command\"

            ' Gunakan fungsi ReadTXT yang telah dimodifikasi
            Dim txtData As List(Of String()) = ReadTXT(path + txt)

            ' Periksa apakah data CSV tidak mengandung error
            If txtData IsNot Nothing AndAlso txtData.Count > 0 Then
                ' Sekarang Anda dapat mengulangi data CSV dan memprosesnya
                Dim loopCount As Integer = CInt(nlTask2.Value)

                For loopIndex As Integer = 0 To loopCount
                    For Each txtRow As String() In txtData
                        ' Ekstrak nilai dari baris CSV
                        Dim No As Integer = Convert.ToInt32(txtRow(0))
                        Dim seleniumCommand As String = txtRow(1).ToString()
                        Dim valueOrURL As String = If(txtRow.Length > 2 AndAlso Not String.IsNullOrEmpty(txtRow(2)), txtRow(2).ToString(), Nothing)
                        Dim value As String = If(txtRow.Length > 3, txtRow(3).ToString(), String.Empty)

                        tbLogs2.Invoke(Sub() tbLogs2.AppendText(No.ToString + " " + seleniumCommand.ToString + " " + valueOrURL.ToString + " " + value.ToString + vbNewLine))

                        Dim output
                        Dim dataCSV
                        Select Case seleniumCommand
                            Case "Read CSV"
                                dataCSV = bot1.readCSV(valueOrURL, value, ",")
                                If dataCSV IsNot Nothing Then
                                    tbLogs2.Invoke(Sub() tbLogs2.AppendText("Read CSV Berhasil" + vbNewLine))
                                    output = "Selesai"
                                Else
                                    tbLogs2.Invoke(Sub() tbLogs2.AppendText("Read CSV Error" + vbNewLine))
                                    output = "Error"
                                End If
                                Exit Select
                            Case "Proxy No Profile"
                                If valueOrURL.Contains("DataCSV") Then
                                    Dim rowCSV = GetStringBetween(valueOrURL, "[", "]")
                                    Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                    Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                    output = bot1.ProxyNoProfile(outputCSV)
                                Else
                                    output = bot1.ProxyNoProfile(valueOrURL)
                                End If
                                Exit Select
                            Case "Proxy Profile"
                                output = bot1.ProxyProfile(valueOrURL, value)
                                Exit Select
                            'Error (DropDown)
                            Case "All Clear"
                                output = bot1.AllClear(valueOrURL)
                                Exit Select
                            Case "Select by text"
                                bot1.SelectbyText(valueOrURL, value)
                                Exit Select
                            Case "Open"
                                If valueOrURL.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot1.Open(outputCSV)
                                    ElseIf valueOrURL IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(valueOrURL, "[", "]")
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot1.Open(outputCSV)
                                    Else
                                    End If
                                Else
                                    output = bot1.Open(valueOrURL)
                                End If
                                Exit Select
                            Case "Refresh"
                                output = bot1.RefreshPage()
                                Exit Select
                            Case "Maximize"
                                output = bot1.MaximizeWindow()
                                Exit Select
                            Case "Minimize"
                                output = bot1.MinimizeWindow()
                                Exit Select
                            Case "New Tab"
                                output = bot1.OpenNewTab(valueOrURL)
                                Exit Select
                            Case "New Window"
                                output = bot1.OpenNewWindow(valueOrURL)
                                Exit Select
                            Case "Set Window Size"
                                Dim sizeValues As String() = valueOrURL.Split("x"c)
                                Dim newWidth As Integer = Convert.ToInt32(sizeValues(0).Trim())
                                Dim newHeight As Integer = Convert.ToInt32(sizeValues(1).Trim())
                                Dim newSize As New Size(newWidth, newHeight)
                                output = bot1.SizeWindow(newSize)
                                Exit Select
                            Case "Set Window Position"
                                Dim positionValues As String() = valueOrURL.Split("x"c)
                                Dim newXPosition As Integer = Convert.ToInt32(positionValues(0).Trim())
                                Dim newYPosition As Integer = Convert.ToInt32(positionValues(1).Trim())
                                Dim newPosition As New Point(newXPosition, newYPosition)
                                output = bot1.PositionWindow(newPosition)
                                Exit Select
                            Case "Click"
                                If valueOrURL.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot1.Click(outputCSV)
                                    ElseIf valueOrURL IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(valueOrURL, "[", "]")
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot1.Click(outputCSV)
                                    End If
                                Else
                                    output = bot1.Click(valueOrURL)
                                End If
                                Exit Select
                            Case "Click All Delete"
                                output = bot1.ClickAllDelete(valueOrURL)
                                Exit Select
                            Case "ClearCokies"
                                output = bot1.ClearAllCookies()
                                Exit Select
                            Case "AddCokies"
                                output = bot1.AddCookies(valueOrURL)
                                Exit Select
                            Case "sendKeys"
                                If value.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot1.sendKeys(valueOrURL, outputCSV)
                                    ElseIf value IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(value, "[", "]")
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot1.sendKeys(valueOrURL, outputCSV)
                                    Else
                                    End If
                                Else
                                    output = bot1.sendKeys(valueOrURL, value)
                                End If
                                Exit Select
                            Case "Type"
                                output = bot1.Type(valueOrURL, value)
                                Exit Select
                            Case "TypeBackspace"
                                Dim jumlah As Integer = Convert.ToInt32(value)
                                output = bot1.TypeBackspace(valueOrURL, jumlah)
                                Exit Select
                            Case "Double Click"
                                output = bot1.DoubleClick(valueOrURL)
                                Exit Select
                            Case "Upload"
                                If value.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot1.UploadFile(valueOrURL, outputCSV)
                                    ElseIf value IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(value, "[", "]")
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot1.UploadFile(valueOrURL, outputCSV)
                                    Else
                                    End If
                                Else
                                    output = bot1.UploadFile(valueOrURL, value)
                                End If
                                Exit Select
                            Case "ClickUpload"
                                If value.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot1.ClickUpload(valueOrURL, outputCSV)
                                    ElseIf value IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(value, "[", "]")
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot1.ClickUpload(valueOrURL, outputCSV)
                                    Else
                                    End If
                                Else
                                    output = bot1.ClickUpload(valueOrURL, value)
                                End If
                                Exit Select
                            Case "Copy Paste"
                                output = bot1.CopyPaste(valueOrURL, value)
                                Exit Select
                            Case "OpenFrame"
                                output = bot1.OpenFrame(valueOrURL)
                                Exit Select
                            Case "Close"
                                output = bot1.Close()
                                Exit Select
                            Case "CloseFrame"
                                output = bot1.CloseFrame()
                                Exit Select
                            Case "Pause"
                                Dim pauseDuration As Integer = Convert.ToInt32(valueOrURL)

                                ' Memulai tugas secara bersamaan
                                Dim pauseTask = Task.Run(Sub() bot1.Pause(pauseDuration))
                                Dim countdownTask = Task.Run(Async Function()
                                                                 For i As Integer = pauseDuration To 1 Step -1
                                                                     ' Membuat teks untuk hitung mundur
                                                                     Dim logText As String = "Hitung Mundur: " + i.ToString + vbNewLine
                                                                     tbLogs1.Invoke(Sub() tbLogs2.AppendText(logText))

                                                                     ' Tunggu selama 1 detik
                                                                     Await Task.Delay(1000)
                                                                 Next
                                                             End Function)

                                ' Menunggu hingga kedua tugas selesai
                                Task.WhenAll(pauseTask, countdownTask).Wait()

                                Exit Select

                            Case "Profile"
                                If valueOrURL.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot1.Profile(outputCSV)
                                    ElseIf valueOrURL IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(valueOrURL, "[", "]")
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot1.Profile(outputCSV)
                                    End If
                                Else
                                    output = bot1.Profile(valueOrURL)
                                End If
                                Exit Select
                            Case "Hide Browser"
                                Dim positionValues As String() = "10000.10000".Split("."c)
                                Dim newXPosition As Integer = Convert.ToInt32(positionValues(0).Trim())
                                Dim newYPosition As Integer = Convert.ToInt32(positionValues(1).Trim())
                                Dim newPosition As New Point(newXPosition, newYPosition)
                                output = bot1.HideBrowser(newPosition)
                                Exit Select
                            Case "Scroll Up"
                                Dim y As Integer = Convert.ToInt32(valueOrURL)
                                output = bot1.ScrollUp(y)
                                Exit Select
                            Case "Scroll Down"
                                Dim minY As Integer = Convert.ToInt32(valueOrURL)
                                output = bot1.ScrollDown(minY)
                                Exit Select
                            Case "Scroll Element"
                                Dim minY As Integer = Convert.ToInt32(value)
                                output = bot1.ScrollByElement(valueOrURL, minY)
                                Exit Select
                            Case "Wait Element Clickable"
                                Dim wait As Integer = Convert.ToInt32(value)
                                output = bot1.WaitElementClickable(valueOrURL, wait)
                                Exit Select
                            Case "Wait Element Exists"
                                Dim wait As Integer = Convert.ToInt32(value)
                                output = bot1.WaitElementExists(valueOrURL, wait)
                                Exit Select
                            Case "Down"
                                output = bot1.Down()
                                Exit Select
                            Case "Up"
                                output = bot1.Up()
                                Exit Select
                            Case "Left"
                                output = bot1.Left()
                                Exit Select
                            Case "Right"
                                output = bot1.Right()
                                Exit Select
                            Case "Enter"
                                output = bot1.Enter()
                                Exit Select
                            Case "Back"
                                output = bot1.Back()
                                Exit Select
                        End Select
                        'END CASE
                        tbLogs2.Invoke(Sub() tbLogs2.AppendText(output + vbNewLine + vbNewLine))
                    Next
                    ' Periksa apakah BackgroundWorker sedang sibuk
                    If Not bwCleanDriver.IsBusy Then
                        bwCleanDriver.RunWorkerAsync()
                    End If
                Next
            Else
                ' Handle the error case
                tbLogs2.Invoke(Sub() tbLogs2.AppendText("Error Membaca Command" + vbNewLine))
            End If
        Else
            MsgBox("Tidak ada item yang dipilih dalam ComboBox.")
        End If
    End Sub

    Private Sub bwMain3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwMain3.DoWork
        bot2 = New Command2()
        Dim selectedTask As Object = Nothing
        Dim txt As String

        ' Periksa apakah perlu menggunakan Invoke dan jalankan di thread UI jika diperlukan
        If cbTask3.InvokeRequired Then
            cbTask3.Invoke(Sub()
                               selectedTask = cbTask3.SelectedItem
                           End Sub)
        Else
            selectedTask = cbTask3.SelectedItem
        End If

        ' Sekarang Anda dapat menggunakan variabel 'selectedTask' sesuai kebutuhan.
        If selectedTask IsNot Nothing Then
            txt = selectedTask.ToString()
            Dim path = document + "\Kolocokro\Command\"

            ' Gunakan fungsi ReadTXT yang telah dimodifikasi
            Dim txtData As List(Of String()) = ReadTXT(path + txt)

            ' Periksa apakah data CSV tidak mengandung error
            If txtData IsNot Nothing AndAlso txtData.Count > 0 Then
                ' Sekarang Anda dapat mengulangi data CSV dan memprosesnya
                Dim loopCount As Integer = CInt(nlTask3.Value)

                For loopIndex As Integer = 0 To loopCount
                    For Each txtRow As String() In txtData
                        ' Ekstrak nilai dari baris CSV
                        Dim No As Integer = Convert.ToInt32(txtRow(0))
                        Dim seleniumCommand As String = txtRow(1).ToString()
                        Dim valueOrURL As String = If(txtRow.Length > 2 AndAlso Not String.IsNullOrEmpty(txtRow(2)), txtRow(2).ToString(), Nothing)
                        Dim value As String = If(txtRow.Length > 3, txtRow(3).ToString(), String.Empty)

                        tbLogs3.Invoke(Sub() tbLogs3.AppendText(No.ToString + " " + seleniumCommand.ToString + " " + valueOrURL.ToString + " " + value.ToString + vbNewLine))

                        Dim output
                        Dim dataCSV
                        Select Case seleniumCommand
                            Case "Read CSV"
                                dataCSV = bot2.readCSV(valueOrURL, value, ",")
                                If dataCSV IsNot Nothing Then
                                    tbLogs3.Invoke(Sub() tbLogs3.AppendText("Read CSV Berhasil" + vbNewLine))
                                    output = "Selesai"
                                Else
                                    tbLogs3.Invoke(Sub() tbLogs3.AppendText("Read CSV Error" + vbNewLine))
                                    output = "Error"
                                End If
                                Exit Select
                            Case "Proxy No Profile"
                                If valueOrURL.Contains("DataCSV") Then
                                    Dim rowCSV = GetStringBetween(valueOrURL, "[", "]")
                                    Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                    Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                    output = bot2.ProxyNoProfile(outputCSV)
                                Else
                                    output = bot2.ProxyNoProfile(valueOrURL)
                                End If
                                Exit Select
                            Case "Proxy Profile"
                                output = bot2.ProxyProfile(valueOrURL, value)
                                Exit Select
                            'Error (DropDown)
                            Case "All Clear"
                                output = bot2.AllClear(valueOrURL)
                                Exit Select
                            Case "Select by text"
                                bot2.SelectbyText(valueOrURL, value)
                                Exit Select
                            Case "Open"
                                If valueOrURL.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot2.Open(outputCSV)
                                    ElseIf valueOrURL IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(valueOrURL, "[", "]")
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot2.Open(outputCSV)
                                    Else
                                    End If
                                Else
                                    output = bot2.Open(valueOrURL)
                                End If
                                Exit Select
                            Case "Refresh"
                                output = bot2.RefreshPage()
                                Exit Select
                            Case "Maximize"
                                output = bot2.MaximizeWindow()
                                Exit Select
                            Case "Minimize"
                                output = bot2.MinimizeWindow()
                                Exit Select
                            Case "New Tab"
                                output = bot2.OpenNewTab(valueOrURL)
                                Exit Select
                            Case "New Window"
                                output = bot2.OpenNewWindow(valueOrURL)
                                Exit Select
                            Case "Set Window Size"
                                Dim sizeValues As String() = valueOrURL.Split("x"c)
                                Dim newWidth As Integer = Convert.ToInt32(sizeValues(0).Trim())
                                Dim newHeight As Integer = Convert.ToInt32(sizeValues(1).Trim())
                                Dim newSize As New Size(newWidth, newHeight)
                                output = bot2.SizeWindow(newSize)
                                Exit Select
                            Case "Set Window Position"
                                Dim positionValues As String() = valueOrURL.Split("x"c)
                                Dim newXPosition As Integer = Convert.ToInt32(positionValues(0).Trim())
                                Dim newYPosition As Integer = Convert.ToInt32(positionValues(1).Trim())
                                Dim newPosition As New Point(newXPosition, newYPosition)
                                output = bot2.PositionWindow(newPosition)
                                Exit Select
                            Case "Click"
                                If valueOrURL.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot2.Click(outputCSV)
                                    ElseIf valueOrURL IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(valueOrURL, "[", "]")
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot2.Click(outputCSV)
                                    End If
                                Else
                                    output = bot2.Click(valueOrURL)
                                End If
                                Exit Select
                            Case "Click All Delete"
                                output = bot2.ClickAllDelete(valueOrURL)
                                Exit Select
                            Case "ClearCokies"
                                output = bot2.ClearAllCookies()
                                Exit Select
                            Case "AddCokies"
                                output = bot2.AddCookies(valueOrURL)
                                Exit Select
                            Case "sendKeys"
                                If value.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot2.sendKeys(valueOrURL, outputCSV)
                                    ElseIf value IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(value, "[", "]")
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot2.sendKeys(valueOrURL, outputCSV)
                                    Else
                                    End If
                                Else
                                    output = bot2.sendKeys(valueOrURL, value)
                                End If
                                Exit Select
                            Case "Type"
                                output = bot2.Type(valueOrURL, value)
                                Exit Select
                            Case "TypeBackspace"
                                Dim jumlah As Integer = Convert.ToInt32(value)
                                output = bot2.TypeBackspace(valueOrURL, jumlah)
                                Exit Select
                            Case "Double Click"
                                output = bot2.DoubleClick(valueOrURL)
                                Exit Select
                            Case "Upload"
                                If value.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot2.UploadFile(valueOrURL, outputCSV)
                                    ElseIf value IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(value, "[", "]")
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot2.UploadFile(valueOrURL, outputCSV)
                                    Else
                                    End If
                                Else
                                    output = bot2.UploadFile(valueOrURL, value)
                                End If
                                Exit Select
                            Case "ClickUpload"
                                If value.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot2.ClickUpload(valueOrURL, outputCSV)
                                    ElseIf value IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(value, "[", "]")
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot2.ClickUpload(valueOrURL, outputCSV)
                                    Else
                                    End If
                                Else
                                    output = bot2.ClickUpload(valueOrURL, value)
                                End If
                                Exit Select
                            Case "Copy Paste"
                                output = bot2.CopyPaste(valueOrURL, value)
                                Exit Select
                            Case "OpenFrame"
                                output = bot2.OpenFrame(valueOrURL)
                                Exit Select
                            Case "Close"
                                output = bot2.Close()
                                Exit Select
                            Case "CloseFrame"
                                output = bot2.CloseFrame()
                                Exit Select
                            Case "Pause"
                                Dim pauseDuration As Integer = Convert.ToInt32(valueOrURL)

                                ' Memulai tugas secara bersamaan
                                Dim pauseTask = Task.Run(Sub() bot2.Pause(pauseDuration))
                                Dim countdownTask = Task.Run(Async Function()
                                                                 For i As Integer = pauseDuration To 1 Step -1
                                                                     ' Membuat teks untuk hitung mundur
                                                                     Dim logText As String = "Hitung Mundur: " + i.ToString + vbNewLine
                                                                     tbLogs3.Invoke(Sub() tbLogs3.AppendText(logText))

                                                                     ' Tunggu selama 1 detik
                                                                     Await Task.Delay(1000)
                                                                 Next
                                                             End Function)

                                ' Menunggu hingga kedua tugas selesai
                                Task.WhenAll(pauseTask, countdownTask).Wait()

                                Exit Select

                            Case "Profile"
                                If valueOrURL.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot2.Profile(outputCSV)
                                    ElseIf valueOrURL IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(valueOrURL, "[", "]")
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot2.Profile(outputCSV)
                                    End If
                                Else
                                    output = bot2.Profile(valueOrURL)
                                End If
                                Exit Select
                            Case "Hide Browser"
                                Dim positionValues As String() = "10000.10000".Split("."c)
                                Dim newXPosition As Integer = Convert.ToInt32(positionValues(0).Trim())
                                Dim newYPosition As Integer = Convert.ToInt32(positionValues(1).Trim())
                                Dim newPosition As New Point(newXPosition, newYPosition)
                                output = bot2.HideBrowser(newPosition)
                                Exit Select
                            Case "Scroll Up"
                                Dim y As Integer = Convert.ToInt32(valueOrURL)
                                output = bot2.ScrollUp(y)
                                Exit Select
                            Case "Scroll Down"
                                Dim minY As Integer = Convert.ToInt32(valueOrURL)
                                output = bot2.ScrollDown(minY)
                                Exit Select
                            Case "Scroll Element"
                                Dim minY As Integer = Convert.ToInt32(value)
                                output = bot2.ScrollByElement(valueOrURL, minY)
                                Exit Select
                            Case "Wait Element Clickable"
                                Dim wait As Integer = Convert.ToInt32(value)
                                output = bot2.WaitElementClickable(valueOrURL, wait)
                                Exit Select
                            Case "Wait Element Exists"
                                Dim wait As Integer = Convert.ToInt32(value)
                                output = bot2.WaitElementExists(valueOrURL, wait)
                                Exit Select
                            Case "Down"
                                output = bot2.Down()
                                Exit Select
                            Case "Up"
                                output = bot2.Up()
                                Exit Select
                            Case "Left"
                                output = bot2.Left()
                                Exit Select
                            Case "Right"
                                output = bot2.Right()
                                Exit Select
                            Case "Enter"
                                output = bot2.Enter()
                                Exit Select
                            Case "Back"
                                output = bot2.Back()
                                Exit Select
                        End Select
                        'END CASE
                        tbLogs3.Invoke(Sub() tbLogs3.AppendText(output + vbNewLine + vbNewLine))
                    Next
                    ' Periksa apakah BackgroundWorker sedang sibuk
                    If Not bwCleanDriver.IsBusy Then
                        bwCleanDriver.RunWorkerAsync()
                    End If
                Next
            Else
                ' Handle the error case
                tbLogs3.Invoke(Sub() tbLogs3.AppendText("Error Membaca Command" + vbNewLine))
            End If
        Else
            MsgBox("Tidak ada item yang dipilih dalam ComboBox.")
        End If
    End Sub

    Private Sub bwMain4_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwMain4.DoWork
        bot3 = New Command3()
        Dim selectedTask As Object = Nothing
        Dim txt As String

        ' Periksa apakah perlu menggunakan Invoke dan jalankan di thread UI jika diperlukan
        If cbTask4.InvokeRequired Then
            cbTask4.Invoke(Sub()
                               selectedTask = cbTask4.SelectedItem
                           End Sub)
        Else
            selectedTask = cbTask4.SelectedItem
        End If

        ' Sekarang Anda dapat menggunakan variabel 'selectedTask' sesuai kebutuhan.
        If selectedTask IsNot Nothing Then
            txt = selectedTask.ToString()
            Dim path = document + "\Kolocokro\Command\"

            ' Gunakan fungsi ReadTXT yang telah dimodifikasi
            Dim txtData As List(Of String()) = ReadTXT(path + txt)

            ' Periksa apakah data TXT tidak mengandung error
            If txtData IsNot Nothing AndAlso txtData.Count > 0 Then
                ' Sekarang Anda dapat mengulangi data TXT dan memprosesnya
                Dim loopCount As Integer = CInt(nlTask4.Value)

                For loopIndex As Integer = 0 To loopCount
                    For Each txtRow As String() In txtData
                        ' Ekstrak nilai dari baris TXT
                        Dim No As Integer = Convert.ToInt32(txtRow(0))
                        Dim seleniumCommand As String = txtRow(1).ToString()
                        Dim valueOrURL As String = If(txtRow.Length > 2 AndAlso Not String.IsNullOrEmpty(txtRow(2)), txtRow(2).ToString(), Nothing)
                        Dim value As String = If(txtRow.Length > 3, txtRow(3).ToString(), String.Empty)

                        tbLogs4.Invoke(Sub() tbLogs4.AppendText(No.ToString + " " + seleniumCommand.ToString + " " + valueOrURL.ToString + " " + value.ToString + vbNewLine))
                        Dim output
                        Dim dataCSV
                        Select Case seleniumCommand
                            Case "Read CSV"
                                dataCSV = bot.readCSV(valueOrURL, value, ",")
                                If dataCSV IsNot Nothing Then
                                    tbLogs4.Invoke(Sub() tbLogs4.AppendText("Read CSV Berhasil" + vbNewLine))
                                    output = "Selesai"
                                Else
                                    tbLogs4.Invoke(Sub() tbLogs4.AppendText("Read CSV Error" + vbNewLine))
                                    output = "Error"
                                End If
                                Exit Select
                            Case "Proxy No Profile"
                                If valueOrURL.Contains("DataCSV") Then
                                    Dim rowCSV = GetStringBetween(valueOrURL, "[", "]")
                                    Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                    Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                    output = bot3.ProxyNoProfile(outputCSV)
                                Else
                                    output = bot3.ProxyNoProfile(valueOrURL)
                                End If
                                Exit Select
                            Case "Proxy Profile"
                                output = bot3.ProxyProfile(valueOrURL, value)
                                Exit Select
                            'Error (DropDown)
                            Case "All Clear"
                                output = bot3.AllClear(valueOrURL)
                                Exit Select
                            Case "Select by text"
                                bot3.SelectbyText(valueOrURL, value)
                                Exit Select
                            Case "Open"
                                If valueOrURL.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot3.Open(outputCSV)
                                    ElseIf valueOrURL IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(valueOrURL, "[", "]")
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot3.Open(outputCSV)
                                    Else
                                    End If
                                Else
                                    output = bot3.Open(valueOrURL)
                                End If
                                Exit Select
                            Case "Refresh"
                                output = bot3.RefreshPage()
                                Exit Select
                            Case "Maximize"
                                output = bot3.MaximizeWindow()
                                Exit Select
                            Case "Minimize"
                                output = bot3.MinimizeWindow()
                                Exit Select
                            Case "New Tab"
                                output = bot3.OpenNewTab(valueOrURL)
                                Exit Select
                            Case "New Window"
                                output = bot3.OpenNewWindow(valueOrURL)
                                Exit Select
                            Case "Set Window Size"
                                Dim sizeValues As String() = valueOrURL.Split("x"c)
                                Dim newWidth As Integer = Convert.ToInt32(sizeValues(0).Trim())
                                Dim newHeight As Integer = Convert.ToInt32(sizeValues(1).Trim())
                                Dim newSize As New Size(newWidth, newHeight)
                                output = bot3.SizeWindow(newSize)
                                Exit Select
                            Case "Set Window Position"
                                Dim positionValues As String() = valueOrURL.Split("x"c)
                                Dim newXPosition As Integer = Convert.ToInt32(positionValues(0).Trim())
                                Dim newYPosition As Integer = Convert.ToInt32(positionValues(1).Trim())
                                Dim newPosition As New Point(newXPosition, newYPosition)
                                output = bot3.PositionWindow(newPosition)
                                Exit Select
                            Case "Click"
                                If valueOrURL.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot3.Click(outputCSV)
                                    ElseIf valueOrURL IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(valueOrURL, "[", "]")
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot3.Click(outputCSV)
                                    End If
                                Else
                                    output = bot3.Click(valueOrURL)
                                End If
                                Exit Select
                            Case "Click All Delete"
                                output = bot3.ClickAllDelete(valueOrURL)
                                Exit Select
                            Case "ClearCokies"
                                output = bot3.ClearAllCookies()
                                Exit Select
                            Case "AddCokies"
                                output = bot3.AddCookies(valueOrURL)
                                Exit Select
                            Case "sendKeys"
                                If value.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot3.sendKeys(valueOrURL, outputCSV)
                                    ElseIf value IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(value, "[", "]")
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot3.sendKeys(valueOrURL, outputCSV)
                                    Else
                                    End If
                                Else
                                    output = bot3.sendKeys(valueOrURL, value)
                                End If
                                Exit Select
                            Case "Type"
                                output = bot3.Type(valueOrURL, value)
                                Exit Select
                            Case "TypeBackspace"
                                Dim jumlah As Integer = Convert.ToInt32(value)
                                output = bot3.TypeBackspace(valueOrURL, jumlah)
                                Exit Select
                            Case "Double Click"
                                output = bot3.DoubleClick(valueOrURL)
                                Exit Select
                            Case "Upload"
                                If value.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot3.UploadFile(valueOrURL, outputCSV)
                                    ElseIf value IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(value, "[", "]")
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot3.UploadFile(valueOrURL, outputCSV)
                                    Else
                                    End If
                                Else
                                    output = bot3.UploadFile(valueOrURL, value)
                                End If
                                Exit Select
                            Case "ClickUpload"
                                If value.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot3.ClickUpload(valueOrURL, outputCSV)
                                    ElseIf value IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(value, "[", "]")
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot3.ClickUpload(valueOrURL, outputCSV)
                                    Else
                                    End If
                                Else
                                    output = bot3.ClickUpload(valueOrURL, value)
                                End If
                                Exit Select
                            Case "Copy Paste"
                                output = bot3.CopyPaste(valueOrURL, value)
                                Exit Select
                            Case "OpenFrame"
                                output = bot3.OpenFrame(valueOrURL)
                                Exit Select
                            Case "Close"
                                output = bot3.Close()
                                Exit Select
                            Case "CloseFrame"
                                output = bot3.CloseFrame()
                                Exit Select
                            Case "Pause"
                                Dim pauseDuration As Integer = Convert.ToInt32(valueOrURL)

                                ' Memulai tugas secara bersamaan
                                Dim pauseTask = Task.Run(Sub() bot3.Pause(pauseDuration))
                                Dim countdownTask = Task.Run(Async Function()
                                                                 For i As Integer = pauseDuration To 1 Step -1
                                                                     ' Membuat teks untuk hitung mundur
                                                                     Dim logText As String = "Hitung Mundur: " + i.ToString + vbNewLine
                                                                     tbLogs4.Invoke(Sub() tbLogs4.AppendText(logText))

                                                                     ' Tunggu selama 1 detik
                                                                     Await Task.Delay(1000)
                                                                 Next
                                                             End Function)

                                ' Menunggu hingga kedua tugas selesai
                                Task.WhenAll(pauseTask, countdownTask).Wait()

                                Exit Select

                            Case "Profile"
                                If valueOrURL.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot3.Profile(outputCSV)
                                    ElseIf valueOrURL IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(valueOrURL, "[", "]")
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot3.Profile(outputCSV)
                                    End If
                                Else
                                    output = bot3.Profile(valueOrURL)
                                End If
                                Exit Select
                            Case "Hide Browser"
                                Dim positionValues As String() = "10000.10000".Split("."c)
                                Dim newXPosition As Integer = Convert.ToInt32(positionValues(0).Trim())
                                Dim newYPosition As Integer = Convert.ToInt32(positionValues(1).Trim())
                                Dim newPosition As New Point(newXPosition, newYPosition)
                                output = bot3.HideBrowser(newPosition)
                                Exit Select
                            Case "Scroll Up"
                                Dim y As Integer = Convert.ToInt32(valueOrURL)
                                output = bot3.ScrollUp(y)
                                Exit Select
                            Case "Scroll Down"
                                Dim minY As Integer = Convert.ToInt32(valueOrURL)
                                output = bot3.ScrollDown(minY)
                                Exit Select
                            Case "Scroll Element"
                                Dim minY As Integer = Convert.ToInt32(value)
                                output = bot3.ScrollByElement(valueOrURL, minY)
                                Exit Select
                            Case "Wait Element Clickable"
                                Dim wait As Integer = Convert.ToInt32(value)
                                output = bot3.WaitElementClickable(valueOrURL, wait)
                                Exit Select
                            Case "Wait Element Exists"
                                Dim wait As Integer = Convert.ToInt32(value)
                                output = bot3.WaitElementExists(valueOrURL, wait)
                                Exit Select
                            Case "Down"
                                output = bot3.Down()
                                Exit Select
                            Case "Up"
                                output = bot3.Up()
                                Exit Select
                            Case "Left"
                                output = bot3.Left()
                                Exit Select
                            Case "Right"
                                output = bot3.Right()
                                Exit Select
                            Case "Enter"
                                output = bot3.Enter()
                                Exit Select
                            Case "Back"
                                output = bot3.Back()
                                Exit Select
                        End Select
                        'END CASE
                        tbLogs4.Invoke(Sub() tbLogs4.AppendText(output + vbNewLine + vbNewLine))
                    Next
                    ' Periksa apakah BackgroundWorker sedang sibuk
                    If Not bwCleanDriver.IsBusy Then
                        bwCleanDriver.RunWorkerAsync()
                    End If
                Next
            Else
                ' Handle the error case
                tbLogs4.Invoke(Sub() tbLogs4.AppendText("Error Membaca Command" + vbNewLine))
            End If
        Else
            MsgBox("Tidak ada item yang dipilih dalam ComboBox.")
        End If
    End Sub

    Private Sub bwMain5_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwMain5.DoWork
        bot4 = New Command4()
        Dim selectedTask As Object = Nothing
        Dim txt As String

        ' Periksa apakah perlu menggunakan Invoke dan jalankan di thread UI jika diperlukan
        If cbTask5.InvokeRequired Then
            cbTask5.Invoke(Sub()
                               selectedTask = cbTask5.SelectedItem
                           End Sub)
        Else
            selectedTask = cbTask5.SelectedItem
        End If

        ' Sekarang Anda dapat menggunakan variabel 'selectedTask' sesuai kebutuhan.
        If selectedTask IsNot Nothing Then
            txt = selectedTask.ToString()
            Dim path = document + "\Kolocokro\Command\"

            ' Gunakan fungsi ReadTXT yang telah dimodifikasi
            Dim txtData As List(Of String()) = ReadTXT(path + txt)

            ' Periksa apakah data TXT tidak mengandung error
            If txtData IsNot Nothing AndAlso txtData.Count > 0 Then
                ' Sekarang Anda dapat mengulangi data TXT dan memprosesnya
                Dim loopCount As Integer = CInt(nlTask5.Value)

                For loopIndex As Integer = 0 To loopCount
                    For Each txtRow As String() In txtData
                        ' Ekstrak nilai dari baris TXT
                        Dim No As Integer = Convert.ToInt32(txtRow(0))
                        Dim seleniumCommand As String = txtRow(1).ToString()
                        Dim valueOrURL As String = If(txtRow.Length > 2 AndAlso Not String.IsNullOrEmpty(txtRow(2)), txtRow(2).ToString(), Nothing)
                        Dim value As String = If(txtRow.Length > 3, txtRow(3).ToString(), String.Empty)

                        tbLogs5.Invoke(Sub() tbLogs5.AppendText(No.ToString + " " + seleniumCommand.ToString + " " + valueOrURL.ToString + " " + value.ToString + vbNewLine))
                        Dim output
                        Dim dataCSV
                        Select Case seleniumCommand
                            Case "Read CSV"
                                dataCSV = bot.readCSV(valueOrURL, value, ",")
                                If dataCSV IsNot Nothing Then
                                    tbLogs5.Invoke(Sub() tbLogs5.AppendText("Read CSV Berhasil" + vbNewLine))
                                    output = "Selesai"
                                Else
                                    tbLogs5.Invoke(Sub() tbLogs5.AppendText("Read CSV Error" + vbNewLine))
                                    output = "Error"
                                End If
                                Exit Select
                            Case "Proxy No Profile"
                                If valueOrURL.Contains("DataCSV") Then
                                    Dim rowCSV = GetStringBetween(valueOrURL, "[", "]")
                                    Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                    Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                    output = bot4.ProxyNoProfile(outputCSV)
                                Else
                                    output = bot4.ProxyNoProfile(valueOrURL)
                                End If
                                Exit Select
                            Case "Proxy Profile"
                                output = bot4.ProxyProfile(valueOrURL, value)
                                Exit Select
                            'Error (DropDown)
                            Case "All Clear"
                                output = bot4.AllClear(valueOrURL)
                                Exit Select
                            Case "Select by text"
                                bot4.SelectbyText(valueOrURL, value)
                                Exit Select
                            Case "Open"
                                If valueOrURL.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot4.Open(outputCSV)
                                    ElseIf valueOrURL IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(valueOrURL, "[", "]")
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot4.Open(outputCSV)
                                    Else
                                    End If
                                Else
                                    output = bot4.Open(valueOrURL)
                                End If
                                Exit Select
                            Case "Refresh"
                                output = bot4.RefreshPage()
                                Exit Select
                            Case "Maximize"
                                output = bot4.MaximizeWindow()
                                Exit Select
                            Case "Minimize"
                                output = bot4.MinimizeWindow()
                                Exit Select
                            Case "New Tab"
                                output = bot4.OpenNewTab(valueOrURL)
                                Exit Select
                            Case "New Window"
                                output = bot4.OpenNewWindow(valueOrURL)
                                Exit Select
                            Case "Set Window Size"
                                Dim sizeValues As String() = valueOrURL.Split("x"c)
                                Dim newWidth As Integer = Convert.ToInt32(sizeValues(0).Trim())
                                Dim newHeight As Integer = Convert.ToInt32(sizeValues(1).Trim())
                                Dim newSize As New Size(newWidth, newHeight)
                                output = bot4.SizeWindow(newSize)
                                Exit Select
                            Case "Set Window Position"
                                Dim positionValues As String() = valueOrURL.Split("x"c)
                                Dim newXPosition As Integer = Convert.ToInt32(positionValues(0).Trim())
                                Dim newYPosition As Integer = Convert.ToInt32(positionValues(1).Trim())
                                Dim newPosition As New Point(newXPosition, newYPosition)
                                output = bot4.PositionWindow(newPosition)
                                Exit Select
                            Case "Click"
                                If valueOrURL.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot4.Click(outputCSV)
                                    ElseIf valueOrURL IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(valueOrURL, "[", "]")
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot4.Click(outputCSV)
                                    End If
                                Else
                                    output = bot4.Click(valueOrURL)
                                End If
                                Exit Select
                            Case "Click All Delete"
                                output = bot4.ClickAllDelete(valueOrURL)
                                Exit Select
                            Case "ClearCokies"
                                output = bot4.ClearAllCookies()
                                Exit Select
                            Case "AddCokies"
                                output = bot4.AddCookies(valueOrURL)
                                Exit Select
                            Case "sendKeys"
                                If value.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot4.sendKeys(valueOrURL, outputCSV)
                                    ElseIf value IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(value, "[", "]")
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot4.sendKeys(valueOrURL, outputCSV)
                                    Else
                                    End If
                                Else
                                    output = bot4.sendKeys(valueOrURL, value)
                                End If
                                Exit Select
                            Case "Type"
                                output = bot4.Type(valueOrURL, value)
                                Exit Select
                            Case "TypeBackspace"
                                Dim jumlah As Integer = Convert.ToInt32(value)
                                output = bot4.TypeBackspace(valueOrURL, jumlah)
                                Exit Select
                            Case "Double Click"
                                output = bot4.DoubleClick(valueOrURL)
                                Exit Select
                            Case "Upload"
                                If value.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot4.UploadFile(valueOrURL, outputCSV)
                                    ElseIf value IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(value, "[", "]")
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot4.UploadFile(valueOrURL, outputCSV)
                                    Else
                                    End If
                                Else
                                    output = bot4.UploadFile(valueOrURL, value)
                                End If
                                Exit Select
                            Case "ClickUpload"
                                If value.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot4.ClickUpload(valueOrURL, outputCSV)
                                    ElseIf value IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(value, "[", "]")
                                        Dim colCSV = GetStringBetween(value, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot4.ClickUpload(valueOrURL, outputCSV)
                                    Else
                                    End If
                                Else
                                    output = bot4.ClickUpload(valueOrURL, value)
                                End If
                                Exit Select
                            Case "Copy Paste"
                                output = bot4.CopyPaste(valueOrURL, value)
                                Exit Select
                            Case "OpenFrame"
                                output = bot4.OpenFrame(valueOrURL)
                                Exit Select
                            Case "Close"
                                output = bot4.Close()
                                Exit Select
                            Case "CloseFrame"
                                output = bot4.CloseFrame()
                                Exit Select
                            Case "Pause"
                                Dim pauseDuration As Integer = Convert.ToInt32(valueOrURL)

                                ' Memulai tugas secara bersamaan
                                Dim pauseTask = Task.Run(Sub() bot4.Pause(pauseDuration))
                                Dim countdownTask = Task.Run(Async Function()
                                                                 For i As Integer = pauseDuration To 1 Step -1
                                                                     ' Membuat teks untuk hitung mundur
                                                                     Dim logText As String = "Hitung Mundur: " + i.ToString + vbNewLine
                                                                     tbLogs5.Invoke(Sub() tbLogs5.AppendText(logText))

                                                                     ' Tunggu selama 1 detik
                                                                     Await Task.Delay(1000)
                                                                 Next
                                                             End Function)

                                ' Menunggu hingga kedua tugas selesai
                                Task.WhenAll(pauseTask, countdownTask).Wait()

                                Exit Select

                            Case "Profile"
                                If valueOrURL.Contains("DataCSV") Then
                                    If loopIndex > 0 Then
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(loopIndex)(colCSV)
                                        output = bot4.Profile(outputCSV)
                                    ElseIf valueOrURL IsNot Nothing Then
                                        Dim rowCSV = GetStringBetween(valueOrURL, "[", "]")
                                        Dim colCSV = GetStringBetween(valueOrURL, "][", "]")
                                        Dim outputCSV = dataCSV(rowCSV)(colCSV)
                                        output = bot4.Profile(outputCSV)
                                    End If
                                Else
                                    output = bot4.Profile(valueOrURL)
                                End If
                                Exit Select
                            Case "Hide Browser"
                                Dim positionValues As String() = "10000.10000".Split("."c)
                                Dim newXPosition As Integer = Convert.ToInt32(positionValues(0).Trim())
                                Dim newYPosition As Integer = Convert.ToInt32(positionValues(1).Trim())
                                Dim newPosition As New Point(newXPosition, newYPosition)
                                output = bot4.HideBrowser(newPosition)
                                Exit Select
                            Case "Scroll Up"
                                Dim y As Integer = Convert.ToInt32(valueOrURL)
                                output = bot4.ScrollUp(y)
                                Exit Select
                            Case "Scroll Down"
                                Dim minY As Integer = Convert.ToInt32(valueOrURL)
                                output = bot4.ScrollDown(minY)
                                Exit Select
                            Case "Scroll Element"
                                Dim minY As Integer = Convert.ToInt32(value)
                                output = bot4.ScrollByElement(valueOrURL, minY)
                                Exit Select
                            Case "Wait Element Clickable"
                                Dim wait As Integer = Convert.ToInt32(value)
                                output = bot4.WaitElementClickable(valueOrURL, wait)
                                Exit Select
                            Case "Wait Element Exists"
                                Dim wait As Integer = Convert.ToInt32(value)
                                output = bot4.WaitElementExists(valueOrURL, wait)
                                Exit Select
                            Case "Down"
                                output = bot4.Down()
                                Exit Select
                            Case "Up"
                                output = bot4.Up()
                                Exit Select
                            Case "Left"
                                output = bot4.Left()
                                Exit Select
                            Case "Right"
                                output = bot4.Right()
                                Exit Select
                            Case "Enter"
                                output = bot4.Enter()
                                Exit Select
                            Case "Back"
                                output = bot4.Back()
                                Exit Select
                        End Select
                        'END CASE
                        tbLogs5.Invoke(Sub() tbLogs5.AppendText(output + vbNewLine + vbNewLine))
                    Next
                    ' Periksa apakah BackgroundWorker sedang sibuk
                    If Not bwCleanDriver.IsBusy Then
                        bwCleanDriver.RunWorkerAsync()
                    End If
                Next
            Else
                ' Handle the error case
                tbLogs5.Invoke(Sub() tbLogs5.AppendText("Error Membaca Command" + vbNewLine))
            End If
        Else
            MsgBox("Tidak ada item yang dipilih dalam ComboBox.")
        End If
    End Sub

    'FUNCTION
    Public Function GetStringBetween(ByVal InputText As String, ByVal starttext As String, ByVal endtext As String)
        Try
            Dim pc1 = Split(InputText, starttext)
            Dim pc2 = Split(pc1(1), endtext)
            Return pc2(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    'Function loadProfile()
    '    'PROFILE
    '    Dim folderPath As String = document + "\Kolocokro\Profile"
    '    Dim profileFolders As String() = Directory.GetDirectories(folderPath)
    '    cbProfile1.Items.Clear()
    '    cbProfile2.Items.Clear()

    '    For Each folderPathItem As String In profileFolders
    '        Dim folderName As String = New DirectoryInfo(folderPathItem).Name
    '        cbProfile1.Items.Add(folderName)
    '        cbProfile2.Items.Add(folderName)
    '    Next

    '    If cbProfile1.Items.Count > 0 Then
    '        cbProfile1.SelectedIndex = 0
    '    End If

    '    If cbProfile2.Items.Count > 0 Then
    '        cbProfile2.SelectedIndex = 0
    '    End If
    'End Function

    Function loadTask()
        'TASK
        Dim folderPath As String = document + "\Kolocokro\Command"
        Dim csvFiles As String() = Directory.GetFiles(folderPath, "*.txt")
        cbTask1.Items.Clear()
        cbTask2.Items.Clear()
        cbTask3.Items.Clear()
        cbTask4.Items.Clear()
        cbTask5.Items.Clear()

        For Each filePath As String In csvFiles
            Dim fileName As String = Path.GetFileName(filePath)
            cbTask1.Items.Add(fileName)
            cbTask2.Items.Add(fileName)
            cbTask3.Items.Add(fileName)
            cbTask4.Items.Add(fileName)
            cbTask5.Items.Add(fileName)
        Next

        For Each cb As ComboBox In {cbTask1, cbTask2, cbTask3, cbTask4, cbTask5}
            If cb.Items.Count > 0 Then
                cb.SelectedIndex = 0
            End If
        Next

    End Function

    Function ReadCSV(file As String, isUserHeader As Boolean, delimiter As String)
        Try
            Dim path = document + "\Kolocokro\Command\"
            Dim csv As FileIO.TextFieldParser = New FileIO.TextFieldParser(path + file)
            csv.TextFieldType = FileIO.FieldType.Delimited
            csv.Delimiters = New String() {delimiter}
            If isUserHeader = True Then csv.ReadLine()
            Dim allData As New List(Of List(Of Object))
            Do While csv.EndOfData = False
                Dim data As New List(Of Object)
                Try
                    Dim fields = csv.ReadFields()
                    For i = 0 To fields.Count - 1
                        data.Add(fields(i).ToString)
                    Next
                Catch ex As Exception
                End Try
                allData.Add(data)
            Loop
            Return allData
        Catch
            Return "Error"
        End Try
    End Function

    Private Function ReadTXT(filePath As String) As List(Of String())
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
                Catch ex As Exception
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
        'MessageBox.Show("Selesai", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Function

End Class