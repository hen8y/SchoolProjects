<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class photoAlbumForm
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
        BrowseFolderButton = New Button()
        PreviousButton = New Button()
        NextButton = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BrowseFolderButton
        ' 
        BrowseFolderButton.Location = New Point(303, 303)
        BrowseFolderButton.Name = "BrowseFolderButton"
        BrowseFolderButton.Size = New Size(147, 36)
        BrowseFolderButton.TabIndex = 1
        BrowseFolderButton.Text = "Browse Folder"
        BrowseFolderButton.UseVisualStyleBackColor = True
        ' 
        ' PreviousButton
        ' 
        PreviousButton.Location = New Point(123, 378)
        PreviousButton.Name = "PreviousButton"
        PreviousButton.Size = New Size(79, 42)
        PreviousButton.TabIndex = 2
        PreviousButton.Text = "Previous"
        PreviousButton.UseVisualStyleBackColor = True
        ' 
        ' NextButton
        ' 
        NextButton.Location = New Point(525, 378)
        NextButton.Name = "NextButton"
        NextButton.Size = New Size(92, 42)
        NextButton.TabIndex = 3
        NextButton.Text = "Next"
        NextButton.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.HighlightText
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(171, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(397, 259)
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' photoAlbumForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(NextButton)
        Controls.Add(PreviousButton)
        Controls.Add(BrowseFolderButton)
        Name = "photoAlbumForm"
        Text = "Photo Album Form"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents BrowseFolderButton As Button
    Friend WithEvents PreviousButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
