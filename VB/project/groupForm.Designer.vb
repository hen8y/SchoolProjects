<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class groupForm
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
        textBox = New TextBox()
        Label1 = New Label()
        submitButton = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' textBox
        ' 
        textBox.Font = New Font("Segoe UI Semibold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        textBox.Location = New Point(42, 118)
        textBox.Margin = New Padding(2, 1, 2, 1)
        textBox.Name = "textBox"
        textBox.Size = New Size(360, 25)
        textBox.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(34, 15)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(566, 25)
        Label1.TabIndex = 1
        Label1.Text = "Application to select the greatest number out of 5 numbers"
        ' 
        ' submitButton
        ' 
        submitButton.Location = New Point(40, 170)
        submitButton.Margin = New Padding(2, 1, 2, 1)
        submitButton.Name = "submitButton"
        submitButton.Size = New Size(198, 49)
        submitButton.TabIndex = 2
        submitButton.Text = "Proceed"
        submitButton.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 45)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(42, 45)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(352, 17)
        Label3.TabIndex = 4
        Label3.Text = "Enter 5 numbers and separate each input with a comma"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(42, 78)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 15)
        Label5.TabIndex = 6
        Label5.Text = "E.g 1,2,3,4,5"
        ' 
        ' groupForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(636, 271)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(submitButton)
        Controls.Add(Label1)
        Controls.Add(textBox)
        Margin = New Padding(2, 1, 2, 1)
        Name = "groupForm"
        Text = "CSC215 Group 37"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents textBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents submitButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label

End Class
