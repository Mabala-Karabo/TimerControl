<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Timer1 = New Timer(components)
        Button1 = New Button()
        Button2 = New Button()
        txtText = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(374, 233)
        Button1.Name = "Button1"
        Button1.Size = New Size(253, 68)
        Button1.TabIndex = 0
        Button1.Text = "Stop timer"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(150, 233)
        Button2.Name = "Button2"
        Button2.Size = New Size(164, 68)
        Button2.TabIndex = 1
        Button2.Text = "Start timer"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' txtText
        ' 
        txtText.Font = New Font("Segoe UI", 14F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        txtText.Location = New Point(334, 74)
        txtText.Name = "txtText"
        txtText.Size = New Size(331, 45)
        txtText.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(66, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(262, 25)
        Label1.TabIndex = 3
        Label1.Text = "Enter your start second number"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(txtText)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtText As TextBox
    Friend WithEvents Label1 As Label
End Class
