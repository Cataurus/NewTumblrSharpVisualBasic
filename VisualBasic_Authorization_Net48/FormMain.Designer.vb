<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TBConsumerKey = New System.Windows.Forms.TextBox()
        Me.TBConsumerSecret = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnViewPicture = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TBConsumerKey
        '
        Me.TBConsumerKey.Location = New System.Drawing.Point(22, 30)
        Me.TBConsumerKey.Name = "TBConsumerKey"
        Me.TBConsumerKey.Size = New System.Drawing.Size(361, 20)
        Me.TBConsumerKey.TabIndex = 0
        '
        'TBConsumerSecret
        '
        Me.TBConsumerSecret.Location = New System.Drawing.Point(22, 73)
        Me.TBConsumerSecret.Name = "TBConsumerSecret"
        Me.TBConsumerSecret.Size = New System.Drawing.Size(361, 20)
        Me.TBConsumerSecret.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Authorization"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnViewPicture
        '
        Me.BtnViewPicture.Enabled = False
        Me.BtnViewPicture.Location = New System.Drawing.Point(281, 121)
        Me.BtnViewPicture.Name = "BtnViewPicture"
        Me.BtnViewPicture.Size = New System.Drawing.Size(102, 23)
        Me.BtnViewPicture.TabIndex = 3
        Me.BtnViewPicture.Text = "view picture"
        Me.BtnViewPicture.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "ConsumerKey"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ConsumerSecret"
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 172)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnViewPicture)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TBConsumerSecret)
        Me.Controls.Add(Me.TBConsumerKey)
        Me.Name = "FormMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBConsumerKey As TextBox
    Friend WithEvents TBConsumerSecret As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnViewPicture As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
