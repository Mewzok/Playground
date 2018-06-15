Imports System.Net.Mail
Imports System.Security.AccessControl

'General notes
'When creating file paths, using the methods within My.Computer will be able to easily find the path for the user's mydocuments, mypictures, desktop, etc.
'                - ex: Dim filePath as String, filePath = My.Computer.FileSystem.SpecialDirectories.Desktop

Public Class Form1

    Dim greetmsg As String = "Kill me, father"

    Dim number3 As Integer = 5
    Dim number1 As Integer = 5

    Sub addnumber(ByVal number2 As Integer)
        number2 = number2 + 1
        MessageBox.Show(number2)
    End Sub

    Sub addnumber2(ByRef number4 As Integer)

        number4 = number4 + 1

    End Sub

    Dim labeltext As String = "I'll kill ya"

    Private Function changelabeltext()

        Return labeltext
    End Function

    Sub givemessage()
        MessageBox.Show("I want to die")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Value = ProgressBar1.Value + 10
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox2.Items.Add(TextBox1.Text)
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton1.Checked = True Then
            MessageBox.Show("You are under 16.")
        ElseIf RadioButton2.Checked = True Then
            MessageBox.Show("You are over 16.")

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If CheckBox1.Checked = True Then
            MessageBox.Show("Movie1")
        End If
        If CheckBox2.Checked = True Then
            MessageBox.Show("Movie2")
        End If
        If CheckBox3.Checked = True Then
            MessageBox.Show("Movie3")
        End If
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MessageBox.Show("This is the help form")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form2.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox2.Text = "password123" Then
            data.Show()
        Else
            MessageBox.Show("Wrong Password")
        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")

        SAPI.Speak(TextBox3.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim i As Integer = 0

        For i = 0 To 10
            MessageBox.Show("The value of i is: " & i)
        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        Dim num1 As Integer = 1

        Do While num1 < 10

            MessageBox.Show("The value of num1 is: " & num1)
            num1 = num1 + 1
        Loop
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim num As Integer = 1

        Do Until num = 5

            MessageBox.Show("The value of num is: " & num)
            num = num + 1

        Loop

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Call givemessage()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Label2.Text = changelabeltext()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        Call addnumber(number1)

        MessageBox.Show(number1)

        Call addnumber2(number3)
        MessageBox.Show(number3)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

        If MessageBox.Show("whatever", "whatever", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            MessageBox.Show("You clicked yes.")
        Else
            MessageBox.Show("You clicked no.")
        End If



    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim num As Integer = 0

        If num <= 0 Then
            MessageBox.Show("True")
        Else

        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

        If TextBox4.Text <> "death" Then
            MessageBox.Show("no")
        End If

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        If TextBox5.Text = "" Or TextBox6.Text = "" Then
            MessageBox.Show("You didn't fill in the fields.")
        End If

        If TextBox5.Text = "thepassword" And TextBox6.Text = "thesecondpassword" Then
            Form3.Show()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox7.Text = TextBox7.Text + 1
        'Timer1.Interval = TextBox2.text
        'Timer1.Interval = 2000
        'Every 1000 is 1 second
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Timer1.Start()
        'Timer1.Enabled = True

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Timer1.Stop()
        'Timer1.Enabled = false
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim Mail As New MailMessage
        Mail.Subject = "test email"
        Mail.To.Add("youremail@googlemail.com")
        Mail.From = New MailAddress("youremail@googlemail.com")
        Mail.Body = "test"

        Dim SMTP As New SmtpClient("smtp.settings")
        SMTP.EnableSsl = True
        SMTP.Credentials = New System.Net.NetworkCredential("username", "password")
        SMTP.Port = "port"
        SMTP.Send(Mail)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim Mail As New MailMessage
        Mail.Subject = TextBox11.Text
        Mail.To.Add(TextBox9.Text)
        Mail.From = New MailAddress(TextBox9.Text)
        Mail.Body = TextBox8.Text

        Dim SMTP As New SmtpClient("smtp.gmail.com")
        SMTP.EnableSsl = True
        SMTP.Credentials = New System.Net.NetworkCredential(TextBox9.Text, TextBox10.Text)
        SMTP.Port = "587"
        SMTP.Send(Mail)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click

        Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://ftp.drivehq.com/file.txt"), System.Net.FtpWebRequest)
        request.Credentials = New System.Net.NetworkCredential("user", "password")
        request.Method = System.Net.WebRequestMethods.Ftp.UploadFile

        Dim file() As Byte = System.IO.File.ReadAllBytes("c:\file.txt")

        Dim strz As System.IO.Stream = request.GetRequestStream()
        strz.Write(file, 0, file.Length)
        strz.Close()
        strz.Dispose()

    End Sub

    Private Sub button23_click(sender As Object, e As EventArgs) Handles Button23.Click

        Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://ftp.drivehq.com/file.txt"), System.Net.FtpWebRequest)
        request.Credentials = New System.Net.NetworkCredential(TextBox12.Text, TextBox13.Text)
        request.Method = System.Net.WebRequestMethods.Ftp.UploadFile

        Dim file() As Byte = System.IO.File.ReadAllBytes(TextBox14.Text)

        Dim strz As System.IO.Stream = request.GetRequestStream()
        strz.Write(file, 0, file.Length)
        strz.Close()
        strz.Dispose()

    End Sub

    '================================================
    '=This button will message the user with "Hello"=
    '================================================
    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        MessageBox.Show("Hello")
    End Sub

    'This could be used for updating your application
    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        My.Computer.Network.DownloadFile("http://www.mywebsite.com/file.exe", "C:\downloadedfile.exe")
        Process.Start("C:\downloadedfile.exe")
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Form4.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        WebBrowser2.Navigate("http://login.facebook.com/login.php")

        Me.Top = 0
        Me.Left = 0

        Me.AutoScroll = True


        Dim startWidthHeight As String = My.Computer.Screen.WorkingArea.ToString
        Dim startWidthAndHeight2(1) As String

        For i = 0 To startWidthAndHeight2.Length - 1
            'somestring2 = TextBox19.Text.Split(" ")
            startWidthAndHeight2(i) = startWidthHeight.Split(",").ToString
        Next

        Me.Size = New Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 39) ' startWidthAndHeight2(0)


        Label11.Text = My.Settings.greettext
        Label12.Text = "Hello and welcome to the application, " & My.Settings.username
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        My.Settings.what = TextBox15.Text
        Label11.Text = My.Settings.greettext
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        changename.Show()
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If TextBox16.Text = My.Settings.password Then
            changename.Show()
            My.Settings.Save()
        Else
            MessageBox.Show("Incorrect Password")
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        MessageBox.Show(My.Settings.password)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        SendKeys.Send(TextBox17.Text)
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Timer2.Interval = TextBox18.Text * 1000

        Timer2.Start()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Timer2.Stop()
    End Sub

    Private Sub TextBox18_TextChanged(sender As Object, e As EventArgs) Handles TextBox18.TextChanged

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    'ARRAYS
    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click

        Dim tvshows(4) As String
        tvshows(0) = "tvshow1"
        tvshows(1) = "tvshow2"
        tvshows(2) = "tvshow3"
        tvshows(3) = "tvshow4"
        tvshows(4) = "tvshow5"

        For i = 0 To tvshows.Length - 1

            MessageBox.Show(tvshows(i))

        Next

    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click

        'Dim somestring As String = "one two three four"

        Dim somestring2() As String
        'somestring2 = TextBox19.Text.Split(" ")
        somestring2 = TextBox19.Text.Split(TextBox20.Text)

        For i = 0 To somestring2.Length - 1
            MessageBox.Show(somestring2(i))
        Next

    End Sub
    'split(textbox1.text, textbox2.text)

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click

        TextBox21.Text = My.Computer.Name
        TextBox22.Text = My.User.Name
        TextBox23.Text = My.Computer.Info.OSFullName
        TextBox24.Text = My.Computer.Keyboard.CapsLock
        TextBox25.Text = My.Computer.Mouse.WheelExists
        TextBox26.Text = My.Computer.Screen.WorkingArea.ToString


    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        TextBox21.Clear()
        TextBox22.Clear()
        TextBox23.Clear()
        TextBox24.Clear()
        TextBox25.Clear()
        TextBox26.Clear()

    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click

        Try
            'Dim one As Integer
            'Dim two As Integer
            'two = one / 0
            Process.Start(TextBox27.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click

        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(TextBox29.Text)
        Dim response As System.Net.HttpWebResponse = request.GetResponse()

        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

        Dim sourcecode As String = sr.ReadToEnd()

        TextBox28.Text = sourcecode

    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click

        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://h1.ripway.com/TeachMeComputer/update.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()

        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion

        If newestversion.Contains(currentversion) Then
            MessageBox.Show("You have the current version")
        Else
            MessageBox.Show("Newer version available")

        End If

    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        Form5.Show()
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        If System.IO.File.Exists(TextBox30.Text) = True Then
            Dim objreader As New System.IO.StreamReader(TextBox30.Text)
            TextBox31.Text = objreader.ReadToEnd
            objreader.Close()
        Else
            MessageBox.Show("That file does not exist")
        End If
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        TextBox31.Clear()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click

        'Dim UserAccount As String = My.User.Name
        'Dim FolderInfo As IO.DirectoryInfo = New IO.DirectoryInfo(TextBox32.Text)
        'Dim FolderAcl As New DirectorySecurity
        'FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.Modify, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow))
        'FolderAcl.SetAccessRuleProtection(False, False)
        'FolderInfo.SetAccessControl(FolderAcl)

        'My.Computer.FileSystem.WriteAllText(FolderInfo, TextBox33.Text, False)

        'Use UAC Application Manifest File. Right click the project name, hover add, click add new item, click Application Manifest File. Follow instructions loaded within it.

        If System.IO.File.Exists(TextBox32.Text) Then
            MessageBox.Show("Sorry, that file already exists.")
        Else
            Dim objwriter As New System.IO.StreamWriter(TextBox32.Text)
            objwriter.Write(TextBox33.Text)
            objwriter.Close()
        End If
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Process.Start(TextBox32.Text)
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        OpenFileDialog1.RestoreDirectory = True
        OpenFileDialog1.InitialDirectory = Application.StartupPath
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk_1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk



        TextBox34.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        Form2.Show()
        Me.Close()

    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim FileToSaveAs As String = SaveFileDialog1.FileName

        Dim objwriter As New System.IO.StreamWriter(FileToSaveAs)
        objwriter.Write(TextBox35.Text)
        objwriter.Close()
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click

        Dim thepath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        Process.Start(thepath & "\,oOOO22FD.png")

    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        WebBrowser1.Navigate(TextBox36.Text)
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

        Dim PageElements As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("img")

        For Each curElement As HtmlElement In PageElements

            TextBox37.Text = TextBox37.Text & curElement.GetAttribute("src") & Environment.NewLine

        Next


    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click

        Dim allElements As HtmlElementCollection = WebBrowser2.Document.All

        For Each webpageelement As HtmlElement In allElements

            'ListBox1.Items.Add(webpageelement.GetAttribute("src"))

            If webpageelement.GetAttribute("value") = "Log in" Then
                webpageelement.InvokeMember("click")
            End If

        Next

    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click

        Dim allElements As HtmlElementCollection = WebBrowser2.Document.All

        For Each webpageelement As HtmlElement In allElements
            'value="Log in"
            'id="loginbutton"

            'If webpageelement.GetAttribute("value") = "Log In" Then
            If webpageelement.GetAttribute("id") = "loginbutton" Then

                webpageelement.InvokeMember("click")

            End If

        Next

    End Sub
End Class
