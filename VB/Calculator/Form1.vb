Public Class Form1
    Dim Number1 As Single
    Dim Number2 As Single
    Dim Result As Single

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Addition
        Number1 = Single.Parse(TextBox1.Text)
        Number2 = Single.Parse(TextBox2.Text)
        Result = Number1 + Number2
        MessageBox.Show("Result: " & Result)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Subtraction
        Number1 = Single.Parse(TextBox1.Text)
        Number2 = Single.Parse(TextBox2.Text)
        Result = Number1 - Number2
        MessageBox.Show("Result: " & Result)
    End Sub
End Class
