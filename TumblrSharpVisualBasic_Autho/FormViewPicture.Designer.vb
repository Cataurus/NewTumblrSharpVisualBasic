﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViewPicture
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
        Me.PanelPicture = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'PanelPicture
        '
        Me.PanelPicture.AutoScroll = True
        Me.PanelPicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPicture.Location = New System.Drawing.Point(0, 0)
        Me.PanelPicture.Name = "PanelPicture"
        Me.PanelPicture.Size = New System.Drawing.Size(800, 511)
        Me.PanelPicture.TabIndex = 0
        '
        'FormViewPicture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 511)
        Me.Controls.Add(Me.PanelPicture)
        Me.Name = "FormViewPicture"
        Me.Text = "View picture"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelPicture As FlowLayoutPanel
End Class
