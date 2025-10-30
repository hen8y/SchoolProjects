Public Class Form1
    Dim JAMB As Integer
    Dim UTMESCORE As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim JAMB As Integer
        Dim UTMESCORE As Integer

        If Integer.TryParse(txtJAMB.Text, JAMB) AndAlso Integer.TryParse(txtUTMESCORE.Text, UTMESCORE) Then
            If JAMB >= 220 AndAlso UTMESCORE >= 80 Then
                MessageBox.Show("Congratulations! You are admitted to study Zoology.")
            Else
                MessageBox.Show("Sorry, you do not meet the admission criteria for Zoology.")
            End If
        Else
            MessageBox.Show("Please enter valid JAMB and UTME SCORE.")
        End If
    End Sub
End Class
