Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class groupForm
    Private Sub submitButton_click(o As Object, e As EventArgs) Handles submitButton.Click
        Dim input As String = textBox.Text()
        Dim array() As String = input.Split(","c)

        If array.Length = 5 Then
            Dim greatestNumber As Integer = array(0)
            For i As Integer = 0 To array.Length - 1
                Dim number As Integer
                If Integer.TryParse(array(i), number) Then
                    If number > greatestNumber Then
                        greatestNumber = number
                    End If
                Else
                    MessageBox.Show("Invalid Input " & array(i))
                    Exit Sub
                End If
            Next
            MessageBox.Show("Greatest number is " & greatestNumber)
        Else
            MessageBox.Show("input must be 5 values separated by comma (,)")
        End If
    End Sub
End Class
