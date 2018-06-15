<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button41 = New System.Windows.Forms.Button()
        Me.Button40 = New System.Windows.Forms.Button()
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'Button41
        '
        Me.Button41.Location = New System.Drawing.Point(368, 12)
        Me.Button41.Name = "Button41"
        Me.Button41.Size = New System.Drawing.Size(97, 44)
        Me.Button41.TabIndex = 100
        Me.Button41.Text = "Login"
        Me.Button41.UseVisualStyleBackColor = True
        '
        'Button40
        '
        Me.Button40.Location = New System.Drawing.Point(257, 12)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(105, 44)
        Me.Button40.TabIndex = 99
        Me.Button40.Text = "Navigate"
        Me.Button40.UseVisualStyleBackColor = True
        '
        'TextBox31
        '
        Me.TextBox31.Location = New System.Drawing.Point(72, 36)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(179, 20)
        Me.TextBox31.TabIndex = 98
        Me.TextBox31.UseSystemPasswordChar = True
        '
        'TextBox30
        '
        Me.TextBox30.Location = New System.Drawing.Point(72, 12)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(179, 20)
        Me.TextBox30.TabIndex = 97
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 39)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 13)
        Me.Label25.TabIndex = 96
        Me.Label25.Text = "Password:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 12)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(58, 13)
        Me.Label24.TabIndex = 95
        Me.Label24.Text = "Username:"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(11, 62)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1204, 546)
        Me.WebBrowser1.TabIndex = 101
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1252, 633)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button41)
        Me.Controls.Add(Me.Button40)
        Me.Controls.Add(Me.TextBox31)
        Me.Controls.Add(Me.TextBox30)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button41 As Button
    Friend WithEvents Button40 As Button
    Friend WithEvents TextBox31 As TextBox
    Friend WithEvents TextBox30 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
