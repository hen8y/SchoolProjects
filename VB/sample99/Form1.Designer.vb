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
        txtJAMB = New TextBox()
        Button1 = New Button()
        txtUTMESCORE = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtJAMB
        ' 
        txtJAMB.Location = New Point(62, 54)
        txtJAMB.Margin = New Padding(2, 1, 2, 1)
        txtJAMB.Name = "txtJAMB"
        txtJAMB.PlaceholderText = "Enter UTME Result"
        txtJAMB.Size = New Size(205, 23)
        txtJAMB.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(62, 158)
        Button1.Margin = New Padding(2, 1, 2, 1)
        Button1.Name = "Button1"
        Button1.Size = New Size(205, 43)
        Button1.TabIndex = 1
        Button1.Text = "CHECK STATUS"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtUTMESCORE
        ' 
        txtUTMESCORE.Location = New Point(62, 95)
        txtUTMESCORE.Name = "txtUTMESCORE"
        txtUTMESCORE.PlaceholderText = "Enter UTME Result"
        txtUTMESCORE.Size = New Size(205, 23)
        txtUTMESCORE.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(62, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(180, 25)
        Label1.TabIndex = 4
        Label1.Text = "Admission Checker"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(431, 211)
        Controls.Add(Label1)
        Controls.Add(txtUTMESCORE)
        Controls.Add(Button1)
        Controls.Add(txtJAMB)
        Margin = New Padding(2, 1, 2, 1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtJAMB As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtUTMESCORE As TextBox
    Friend WithEvents Label1 As Label

End Class
