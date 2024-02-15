Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btndivide.Click

        If txt1stNum.Text = "" Or txt2ndNum.Text = "" Then
            MessageBox.Show("Please complete the entry first!")
        End If
        Try
            Dim a, b As Integer
            a = txt1stNum.Text
            b = txt2ndNum.Text
            lblResult.Text = a / b
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


End Class
