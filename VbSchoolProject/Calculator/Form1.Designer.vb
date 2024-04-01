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
        Label1 = New Label()
        Label2 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label1.Location = New Point(47, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(250, 50)
        Label1.TabIndex = 0
        Label1.Text = "first number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0)
        Label2.Location = New Point(47, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(301, 50)
        Label2.TabIndex = 1
        Label2.Text = "second number"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(47, 203)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(437, 39)
        TextBox2.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(47, 70)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(437, 39)
        TextBox1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(47, 293)
        Button1.Name = "Button1"
        Button1.Size = New Size(220, 65)
        Button1.TabIndex = 4
        Button1.Text = "Addition"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(311, 293)
        Button2.Name = "Button2"
        Button2.Size = New Size(173, 65)
        Button2.TabIndex = 5
        Button2.Text = "Subtraction"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 32.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
