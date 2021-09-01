<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbConsumerKey = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbConsumerSecret = New System.Windows.Forms.TextBox()
        Me.BtnAuthorization = New System.Windows.Forms.Button()
        Me.BtnViewDrashboard = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ConsumerKey"
        '
        'TbConsumerKey
        '
        Me.TbConsumerKey.Location = New System.Drawing.Point(12, 27)
        Me.TbConsumerKey.Name = "TbConsumerKey"
        Me.TbConsumerKey.Size = New System.Drawing.Size(301, 23)
        Me.TbConsumerKey.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ConsumerSecret"
        '
        'TbConsumerSecret
        '
        Me.TbConsumerSecret.Location = New System.Drawing.Point(12, 90)
        Me.TbConsumerSecret.Name = "TbConsumerSecret"
        Me.TbConsumerSecret.Size = New System.Drawing.Size(301, 23)
        Me.TbConsumerSecret.TabIndex = 3
        '
        'BtnAuthorization
        '
        Me.BtnAuthorization.Location = New System.Drawing.Point(16, 157)
        Me.BtnAuthorization.Name = "BtnAuthorization"
        Me.BtnAuthorization.Size = New System.Drawing.Size(111, 23)
        Me.BtnAuthorization.TabIndex = 4
        Me.BtnAuthorization.Text = "Authorization"
        Me.BtnAuthorization.UseVisualStyleBackColor = True
        '
        'BtnViewDrashboard
        '
        Me.BtnViewDrashboard.Enabled = False
        Me.BtnViewDrashboard.Location = New System.Drawing.Point(179, 157)
        Me.BtnViewDrashboard.Name = "BtnViewDrashboard"
        Me.BtnViewDrashboard.Size = New System.Drawing.Size(134, 23)
        Me.BtnViewDrashboard.TabIndex = 5
        Me.BtnViewDrashboard.Text = "View Picture"
        Me.BtnViewDrashboard.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 214)
        Me.Controls.Add(Me.BtnViewDrashboard)
        Me.Controls.Add(Me.BtnAuthorization)
        Me.Controls.Add(Me.TbConsumerSecret)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbConsumerKey)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TbConsumerKey As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbConsumerSecret As TextBox
    Friend WithEvents BtnAuthorization As Button
    Friend WithEvents BtnViewDrashboard As Button
End Class
