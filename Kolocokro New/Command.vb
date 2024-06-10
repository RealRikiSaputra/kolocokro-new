Imports AutoItX3Lib
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Interactions
Imports OpenQA.Selenium.Support.UI
Imports SeleniumExtras.WaitHelpers
Imports System.Threading
Imports Keys = OpenQA.Selenium.Keys
Imports SeleniumUndetectedChromeDriver
Imports System.IO
Imports OfficeOpenXml

Public Class Command

    Private driver
    Private jsExecutor As IJavaScriptExecutor
    Dim document As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments

    Public Sub New(form As FormMenu)
        jsExecutor = DirectCast(driver, IJavaScriptExecutor)
    End Sub

    Public Sub New()
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


    Public Function ProxyNoProfile(proxy As String)
        Try
            Dim chromePath As String = FindChromePath()
            If driver IsNot Nothing Then
            Else
                Dim options As New ChromeOptions()
                options.AddArgument("--load-extension=" + document + "\Kolocokro\Proxy\" + proxy)
                driver = UndetectedChromeDriver.Create(
                hideCommandPromptWindow:=True,
                browserExecutablePath:=chromePath,
                driverExecutablePath:=document + "\Kolocokro\Driver\chromedriver.exe",
                options:=options)
            End If
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function
    Public Function ProxyProfile(profile As String, proxy As String)
        Try
            If driver IsNot Nothing Then
            Else
                Dim chromePath As String = FindChromePath()
                Dim options As New ChromeOptions()
                options.AddArgument("--user-data-dir=" + document + "\Kolocokro\Profile\" + profile)
                options.AddArgument("--load-extension=" + document + "\Kolocokro\Proxy\" + proxy)
                driver = UndetectedChromeDriver.Create(
                    hideCommandPromptWindow:=True,
                    browserExecutablePath:=chromePath,
                    driverExecutablePath:=document + "\Kolocokro\Driver\chromedriver.exe",
                    options:=options)
            End If
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Function readCSV(file As String, isUserHeader As Boolean, delimiter As String)
        Try
            Dim path = document + "\Kolocokro\CSV\"
            Dim csv As FileIO.TextFieldParser = New FileIO.TextFieldParser(path + file)
            csv.TextFieldType = FileIO.FieldType.Delimited
            csv.Delimiters = New String() {delimiter}
            If isUserHeader = True Then csv.ReadLine()
            Dim allData As New List(Of Object)
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

    Function ReadExcel(file As String, sheetName As String) As List(Of List(Of Object))
        Try
            Dim pathFile = document + "\Kolocokro\CSV\"
            Dim allData As New List(Of List(Of Object))

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial
            Using package As New ExcelPackage(New FileInfo(Path.Combine(pathFile, file)))
                Dim worksheet = package.Workbook.Worksheets(sheetName)
                Dim rowCount As Integer = 0
                If worksheet.Dimension IsNot Nothing Then
                    rowCount = worksheet.Dimension.Rows
                End If
                Dim columnCount As Integer = worksheet.Dimension.Columns

                For row = 1 To rowCount
                    Dim rowData As New List(Of Object)
                    For col = 1 To columnCount
                        rowData.Add(worksheet.Cells(row, col).Value)
                    Next
                    allData.Add(rowData)
                Next
            End Using

            Return allData
        Catch ex As Exception
            Console.WriteLine(ex)
            Return New List(Of List(Of Object)) ' Mengembalikan list kosong jika terjadi kesalahan
        End Try
    End Function

    Public Function AllClear(elementLocator As String) As String
        Try
            ' Membagi nilai parameter menjadi metode dan nilai elemen
            Dim parts() As String = elementLocator.Split(":")
            If parts.Length <> 2 Then
                Return "Format parameter tidak valid"
            End If

            Dim searchMethod As String = parts(0).ToLower()
            Dim elementName As String = parts(1)

            Dim dropdown As IWebElement

            Select Case searchMethod
                Case "xpath"
                    dropdown = driver.FindElement(By.XPath(elementName))
                Case "id"
                    dropdown = driver.FindElement(By.Id(elementName))
                Case "name"
                    dropdown = driver.FindElement(By.Name(elementName))
                Case "classname"
                    dropdown = driver.FindElement(By.ClassName(elementName))
                Case Else
                    Return "Metode pencarian tidak valid"
            End Select

            Dim SelectClear As New SelectElement(dropdown)
            SelectClear.DeselectAll()

            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function


    Public Function Click(elementLocator As String) As String
        Try
            ' Membagi nilai parameter menjadi metode dan nilai elemen
            Dim parts() As String = elementLocator.Split(":")
            If parts.Length <> 2 Then
                Return "Format parameter tidak valid"
            End If

            Dim searchMethod As String = parts(0).ToLower()
            Dim elementName As String = parts(1)

            Dim element As IWebElement

            Select Case searchMethod
                Case "xpath"
                    element = driver.FindElement(By.XPath(elementName))
                Case "id"
                    element = driver.FindElement(By.Id(elementName))
                Case "name"
                    element = driver.FindElement(By.Name(elementName))
                Case "classname"
                    element = driver.FindElement(By.ClassName(elementName))
                Case Else
                    Return "Metode pencarian tidak valid"
            End Select

            element.Click()
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function


    Public Function ClickAllDelete(elementLocator As String) As String
        Try
            ' Membagi nilai parameter menjadi metode dan nilai elemen
            Dim parts() As String = elementLocator.Split(":")
            If parts.Length <> 2 Then
                Return "Format parameter tidak valid"
            End If

            Dim searchMethod As String = parts(0).ToLower()
            Dim elementName As String = parts(1)

            Dim element As IWebElement

            Select Case searchMethod
                Case "xpath"
                    element = driver.FindElement(By.XPath(elementName))
                Case "id"
                    element = driver.FindElement(By.Id(elementName))
                Case "name"
                    element = driver.FindElement(By.Name(elementName))
                Case "classname"
                    element = driver.FindElement(By.ClassName(elementName))
                Case Else
                    Return "Metode pencarian tidak valid"
            End Select

            Thread.Sleep(1000)
            element.Click()
            element.SendKeys(Keys.Control & "a")
            element.SendKeys(Keys.Backspace)

            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function ClickUpload(elementLocator As String, file As String) As String
        Try
            Thread.Sleep(1000)
            ' Membagi nilai parameter menjadi metode dan nilai elemen
            Dim parts() As String = elementLocator.Split(":")
            If parts.Length <> 2 Then
                Return "Format parameter tidak valid"
            End If

            Dim searchMethod As String = parts(0).ToLower()
            Dim elementName As String = parts(1)

            ' Mendapatkan elemen berdasarkan metode pencarian
            Dim element As IWebElement

            Select Case searchMethod
                Case "xpath"
                    element = driver.FindElement(By.XPath(elementName))
                Case "id"
                    element = driver.FindElement(By.Id(elementName))
                Case "name"
                    element = driver.FindElement(By.Name(elementName))
                Case "classname"
                    element = driver.FindElement(By.ClassName(elementName))
                Case Else
                    Return "Metode pencarian tidak valid"
            End Select
            For i = 0 To 10000
                Pause(1)
                If My.Computer.FileSystem.FileExists(document + "\Kolocokro\upload") = False Then
                    My.Computer.FileSystem.WriteAllText(document + "\Kolocokro\upload", "", False)

                    element.Click()
                    Dim autoIt As New AutoItX3()
                    autoIt.WinActivate("Open")
                    Thread.Sleep(2000)
                    autoIt.Send(file)
                    Thread.Sleep(1000)
                    autoIt.Send("{ENTER}")

                    My.Computer.FileSystem.DeleteFile(document + "\Kolocokro\upload")
                    Exit For
                End If
            Next

            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function


    Public Function ClearAllCookies()
        Try
            driver.Manage().Cookies.DeleteAllCookies()
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function
    Public Function AddCookies(name As String)
        Try
            'Menambahkan COokie
            'Ambil Text
            Dim currentCookie = My.Computer.FileSystem.ReadAllText(document + "\Kolocokro\Cookie\" + name)
            'merubah " => '
            Dim cookietxt = Trim(Replace(currentCookie.ToString, """", "'"))
            'merubah ke json
            Dim jss = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Object)(cookietxt)
            For Each item In jss
                'merubah ke json
                Dim mycookies = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(item.ToString)
                'menghapus key samsite
                mycookies.Remove("sameSite")
                'merubah ke dictionary
                Dim cookie = OpenQA.Selenium.Cookie.FromDictionary(mycookies)
                'menambahkan cookie ke selenium
                driver.Manage().Cookies.AddCookie(cookie)
            Next
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function Close()
        Try
            driver.Quit()
            driver = Nothing
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function CloseFrame()
        Try
            driver.SwitchTo().DefaultContent()
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function CopyPaste(sourceLocator As String, targetLocator As String) As String
        Try
            ' Membagi nilai parameter menjadi metode dan nilai elemen
            Dim sourceParts() As String = sourceLocator.Split(":")
            Dim targetParts() As String = targetLocator.Split(":")
            If sourceParts.Length <> 2 Or targetParts.Length <> 2 Then
                Return "Format parameter tidak valid"
            End If

            Dim sourceSearchMethod As String = sourceParts(0).ToLower()
            Dim sourceElementName As String = sourceParts(1)

            Dim targetSearchMethod As String = targetParts(0).ToLower()
            Dim targetElementName As String = targetParts(1)

            ' Mendapatkan elemen berdasarkan metode pencarian
            Dim sourceElement As IWebElement
            Dim targetElement As IWebElement

            Select Case sourceSearchMethod
                Case "xpath"
                    sourceElement = driver.FindElement(By.XPath(sourceElementName))
                Case "id"
                    sourceElement = driver.FindElement(By.Id(sourceElementName))
                Case "name"
                    sourceElement = driver.FindElement(By.Name(sourceElementName))
                Case "classname"
                    sourceElement = driver.FindElement(By.ClassName(sourceElementName))
                Case Else
                    Return "Metode pencarian sumber tidak valid"
            End Select

            Select Case targetSearchMethod
                Case "xpath"
                    targetElement = driver.FindElement(By.XPath(targetElementName))
                Case "id"
                    targetElement = driver.FindElement(By.Id(targetElementName))
                Case "name"
                    targetElement = driver.FindElement(By.Name(targetElementName))
                Case "classname"
                    targetElement = driver.FindElement(By.ClassName(targetElementName))
                Case Else
                    Return "Metode pencarian target tidak valid"
            End Select

            ' Menyalin teks dari sumber dan menempelkannya ke target
            sourceElement.SendKeys(Keys.Control & "a")
            sourceElement.SendKeys(Keys.Control & "c")
            Thread.Sleep(2000)
            targetElement.SendKeys(Keys.Control & "v")

            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function


    Public Function DoubleClick(elementLocator As String) As String
        Try
            ' Membagi nilai parameter menjadi metode dan nilai elemen
            Dim parts() As String = elementLocator.Split(":")
            If parts.Length <> 2 Then
                Return "Format parameter tidak valid"
            End If

            Dim searchMethod As String = parts(0).ToLower()
            Dim elementName As String = parts(1)

            ' Mendapatkan elemen berdasarkan metode pencarian
            Dim element As IWebElement

            Select Case searchMethod
                Case "xpath"
                    element = driver.FindElement(By.XPath(elementName))
                Case "id"
                    element = driver.FindElement(By.Id(elementName))
                Case "name"
                    element = driver.FindElement(By.Name(elementName))
                Case "classname"
                    element = driver.FindElement(By.ClassName(elementName))
                Case Else
                    Return "Metode pencarian tidak valid"
            End Select

            ' Melakukan double-click pada elemen
            Dim actions As New Actions(driver)
            actions.DoubleClick(element).Perform()

            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function


    Public Function MaximizeWindow()
        Try
            driver.Manage().Window.Maximize()
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function MinimizeWindow()
        Try
            driver.Manage().Window.Minimize()
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function SizeWindow(size As Size)
        Try
            driver.Manage().Window.Size = size
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function PositionWindow(position As Point)
        Try
            driver.Manage().Window.Position = position
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function Open(url As String)
        Try
            driver.GoToUrl(url)
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function OpenFrame(elementLocator As String)
        Try
            ' Membagi nilai parameter menjadi metode dan nilai elemen
            Dim parts() As String = elementLocator.Split(":")
            If parts.Length <> 2 Then
                Return "Format parameter tidak valid"
            End If

            Dim searchMethod As String = parts(0).ToLower()
            Dim elementName As String = parts(1)

            ' Mendapatkan elemen berdasarkan metode pencarian
            Dim element As IWebElement

            Select Case searchMethod
                Case "xpath"
                    element = driver.FindElement(By.XPath(elementName))
                Case "id"
                    element = driver.FindElement(By.Id(elementName))
                Case "name"
                    element = driver.FindElement(By.Name(elementName))
                Case "classname"
                    element = driver.FindElement(By.ClassName(elementName))
                Case Else
                    Return "Metode pencarian tidak valid"
            End Select

            driver.SwitchTo().Frame(element)
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function OpenNewTab(url As String)
        Try
            Dim js As IJavaScriptExecutor = DirectCast(driver, IJavaScriptExecutor)
            jsExecutor.ExecuteScript($"window.open('{url}', '_blank');")
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function OpenNewWindow(url As String)
        Try
            driver.Navigate().GoToUrl(url)
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function Pause(milliseconds As Integer)
        Try
            Dim seconds As Integer = milliseconds * 1000
            Thread.Sleep(seconds)
        Catch
        End Try
    End Function

    Public Function Profile(name As String)
        Try
            Dim chromePath As String = FindChromePath()

            If driver IsNot Nothing Then
            Else
                Dim options As New ChromeOptions()
                options.AddArgument("--user-data-dir=" + document + "\Kolocokro\Profile\" + name)
                driver = UndetectedChromeDriver.Create(
                    hideCommandPromptWindow:=True,
                    browserExecutablePath:=chromePath,
                    driverExecutablePath:=document + "\Kolocokro\Driver\chromedriver.exe",
                    options:=options)
                Pause(2)
            End If
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function
    Public Function NoProfile()
        Try
            Dim chromePath As String = FindChromePath()

            If driver IsNot Nothing Then
            Else
                Dim options As New ChromeOptions()
                driver = UndetectedChromeDriver.Create(
                    hideCommandPromptWindow:=True,
                    browserExecutablePath:=chromePath,
                    driverExecutablePath:=document + "\Kolocokro\Driver\chromedriver.exe",
                    options:=options)
            End If

            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function RefreshPage()
        Try
            driver.Navigate().Refresh()
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function ScrollDown(pixels As Integer)
        Try
            jsExecutor.ExecuteScript($"window.scrollBy(0, {pixels});")
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function ScrollUp(pixels As Integer)
        Try
            jsExecutor.ExecuteScript($"window.scrollBy(0, -{pixels});")
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function ScrollByElement(elementName As String, pixels As Integer)
        Try
            ' Temukan elemen dengan nama yang diberikan
            Dim element As IWebElement = driver.FindElement(By.ClassName(elementName))

            ' Jalankan JavaScript untuk menggulir elemen sebanyak jumlah pixel yang diberikan
            Dim js As IJavaScriptExecutor = CType(driver, IJavaScriptExecutor)
            js.ExecuteScript("arguments[0].scrollTop += arguments[1];", element, pixels)
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function



    Public Function SelectbyText(elementLocator As String, text As String)
        Try
            ' Membagi nilai parameter menjadi metode dan nilai elemen
            Dim parts() As String = elementLocator.Split(":")
            If parts.Length <> 2 Then
                Return "Format parameter tidak valid"
            End If

            Dim searchMethod As String = parts(0).ToLower()
            Dim elementName As String = parts(1)

            ' Mendapatkan elemen berdasarkan metode pencarian
            Dim element As IWebElement

            Select Case searchMethod
                Case "xpath"
                    element = driver.FindElement(By.XPath(elementName))
                Case "id"
                    element = driver.FindElement(By.Id(elementName))
                Case "name"
                    element = driver.FindElement(By.Name(elementName))
                Case "classname"
                    element = driver.FindElement(By.ClassName(elementName))
                Case Else
                    Return "Metode pencarian tidak valid"
            End Select

            Dim SelectText As New SelectElement(element)
            SelectText.SelectByText(text)
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function sendKeys(elementLocator As String, text As String)
        Try
            ' Membagi nilai parameter menjadi metode dan nilai elemen
            Dim parts() As String = elementLocator.Split(":")
            If parts.Length <> 2 Then
                Return "Format parameter tidak valid"
            End If

            Dim searchMethod As String = parts(0).ToLower()
            Dim elementName As String = parts(1)

            ' Mendapatkan elemen berdasarkan metode pencarian
            Dim element As IWebElement

            Select Case searchMethod
                Case "xpath"
                    element = driver.FindElement(By.XPath(elementName))
                Case "id"
                    element = driver.FindElement(By.Id(elementName))
                Case "name"
                    element = driver.FindElement(By.Name(elementName))
                Case "classname"
                    element = driver.FindElement(By.ClassName(elementName))
                Case Else
                    Return "Metode pencarian tidak valid"
            End Select

            Thread.Sleep(1000)
            element.SendKeys(text)
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function Type(elementLocator As String, text As String)
        Try
            ' Membagi nilai parameter menjadi metode dan nilai elemen
            Dim parts() As String = elementLocator.Split(":")
            If parts.Length <> 2 Then
                Return "Format parameter tidak valid"
            End If

            Dim searchMethod As String = parts(0).ToLower()
            Dim elementName As String = parts(1)

            ' Mendapatkan elemen berdasarkan metode pencarian
            Dim element As IWebElement

            Select Case searchMethod
                Case "xpath"
                    element = driver.FindElement(By.XPath(elementName))
                Case "id"
                    element = driver.FindElement(By.Id(elementName))
                Case "name"
                    element = driver.FindElement(By.Name(elementName))
                Case "classname"
                    element = driver.FindElement(By.ClassName(elementName))
                Case Else
                    Return "Metode pencarian tidak valid"
            End Select

            For Each c As Char In text
                Thread.Sleep(200) ' efek animasi
                element.SendKeys(c.ToString())
            Next
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function TypeBackspace(elementLocator As String, count As Integer)
        Try
            ' Membagi nilai parameter menjadi metode dan nilai elemen
            Dim parts() As String = elementLocator.Split(":")
            If parts.Length <> 2 Then
                Return "Format parameter tidak valid"
            End If

            Dim searchMethod As String = parts(0).ToLower()
            Dim elementName As String = parts(1)

            ' Mendapatkan elemen berdasarkan metode pencarian
            Dim element As IWebElement

            Select Case searchMethod
                Case "xpath"
                    element = driver.FindElement(By.XPath(elementName))
                Case "id"
                    element = driver.FindElement(By.Id(elementName))
                Case "name"
                    element = driver.FindElement(By.Name(elementName))
                Case "classname"
                    element = driver.FindElement(By.ClassName(elementName))
                Case Else
                    Return "Metode pencarian tidak valid"
            End Select

            Dim actions As New Actions(driver)

            For i As Integer = 0 To count - 1
                actions.SendKeys(element, Keys.Backspace).Perform()
                Thread.Sleep(300)
            Next
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function UploadFile(elementLocator As String, filePath As String)
        Try
            ' Membagi nilai parameter menjadi metode dan nilai elemen
            Dim parts() As String = elementLocator.Split(":")
            If parts.Length <> 2 Then
                Return "Format parameter tidak valid"
            End If

            Dim searchMethod As String = parts(0).ToLower()
            Dim elementName As String = parts(1)

            ' Mendapatkan elemen berdasarkan metode pencarian
            Dim element As IWebElement

            Select Case searchMethod
                Case "xpath"
                    element = driver.FindElement(By.XPath(elementName))
                Case "id"
                    element = driver.FindElement(By.Id(elementName))
                Case "name"
                    element = driver.FindElement(By.Name(elementName))
                Case "classname"
                    element = driver.FindElement(By.ClassName(elementName))
                Case Else
                    Return "Metode pencarian tidak valid"
            End Select

            Thread.Sleep(1000)
            element.Click()
            Thread.Sleep(1000)
            element.SendKeys(filePath)
            Thread.Sleep(1000)
            element.SendKeys(Keys.Enter)
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function
    'KURANG YAKIN
    Public Function WaitElementClickable(elementLocator As String, seconds As Integer)
        Try
            ' Membagi nilai parameter menjadi metode dan nilai elemen
            Dim parts() As String = elementLocator.Split(":")
            If parts.Length <> 2 Then
                Return "Format parameter tidak valid"
            End If

            Dim searchMethod As String = parts(0).ToLower()
            Dim elementName As String = parts(1)

            ' Mendapatkan elemen berdasarkan metode pencarian
            Dim element As IWebElement

            Select Case searchMethod
                Case "xpath"
                    element = driver.FindElement(By.XPath(elementName))
                Case "id"
                    element = driver.FindElement(By.Id(elementName))
                Case "name"
                    element = driver.FindElement(By.Name(elementName))
                Case "classname"
                    element = driver.FindElement(By.ClassName(elementName))
                Case Else
                    Return "Metode pencarian tidak valid"
            End Select

            Dim Wait As WebDriverWait = New WebDriverWait(driver, TimeSpan.FromSeconds(seconds))
            Wait.Until(ExpectedConditions.ElementToBeClickable(element))

            Return "Selesai"
        Catch e As Exception
            Return e.ToString
        End Try
    End Function

    Public Function WaitElementExists(elementLocator As String, seconds As Integer)
        Try
            ' Membagi nilai parameter menjadi metode dan nilai elemen
            Dim parts() As String = elementLocator.Split(":")
            If parts.Length <> 2 Then
                Return "Format parameter tidak valid"
            End If

            Dim searchMethod As String = parts(0).ToLower()
            Dim elementName As String = parts(1)

            ' Mendapatkan elemen berdasarkan metode pencarian
            Dim element As IWebElement

            Select Case searchMethod
                Case "xpath"
                    element = driver.FindElement(By.XPath(elementName))
                Case "id"
                    element = driver.FindElement(By.Id(elementName))
                Case "name"
                    element = driver.FindElement(By.Name(elementName))
                Case "classname"
                    element = driver.FindElement(By.ClassName(elementName))
                Case Else
                    Return "Metode pencarian tidak valid"
            End Select

            Dim Wait As WebDriverWait = New WebDriverWait(driver, TimeSpan.FromSeconds(seconds))
            Wait.Until(ExpectedConditions.ElementExists(element))

            Return "Selesai"
        Catch e As Exception
            Return e.ToString
        End Try
    End Function
    'LOOP RISET ERROR
    Public Function LoopRiset(dgvStatus As DataGridView)
        Try
            For Each row As DataGridViewRow In dgvStatus.Rows
                ' Dapatkan data dari kolom yang sesuai dalam DGV
                Dim column1Value As String = row.Cells("ColumnName1").Value.ToString()
                Dim column2Value As String = row.Cells("ColumnName2").Value.ToString()
            Next
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function HideBrowser(position As Point)
        Try
            driver.Manage().Window.Position = position
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function Down()
        Try
            ' Inisialisasi objek Actions
            Dim actions As Actions = New Actions(driver)

            ' Tekan tombol "Down"
            actions.SendKeys(Keys.Down).Perform()
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function Up()
        Try
            ' Inisialisasi objek Actions
            Dim actions As Actions = New Actions(driver)

            actions.SendKeys(Keys.Up).Perform()
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function Left()
        Try
            ' Inisialisasi objek Actions
            Dim actions As Actions = New Actions(driver)

            actions.SendKeys(Keys.Left).Perform()
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function Right()
        Try
            ' Inisialisasi objek Actions
            Dim actions As Actions = New Actions(driver)

            actions.SendKeys(Keys.Right).Perform()
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function Enter()
        Try
            ' Inisialisasi objek Actions
            Dim actions As Actions = New Actions(driver)

            actions.SendKeys(Keys.Enter).Perform()
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function

    Public Function Back()
        Try
            driver.Navigate().Back()
            Return "Selesai"
        Catch
            Return "Error"
        End Try
    End Function
End Class