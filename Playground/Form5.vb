Public Class Form5
    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        WebBrowser1.Navigate("https://login.yahoo.com/config/login?.src=fpctx&.intl=us&.lang=en-US&.done=https%3A%2F%2Fwww.yahoo.com")
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        WebBrowser1.Document.GetElementById("username").SetAttribute("value", TextBox30.Text)
        WebBrowser1.Document.GetElementById("passwd").SetAttribute("value", TextBox31.Text)

        WebBrowser1.Document.GetElementById("signin").InvokeMember("click")
    End Sub
End Class