Public Class Form1
    Dim first_num As Double
    Dim second_num As Double
    Dim result As Double
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        first_num = TextBox1.Text
        second_num = TextBox2.Text
        result = first_num * second_num
        TextBox3.Text = result
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        first_num = TextBox1.Text
        second_num = TextBox2.Text
        result = first_num / second_num
        TextBox3.Text = result
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        first_num = TextBox1.Text
        second_num = TextBox2.Text
        result = first_num - second_num
        TextBox3.Text = result
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        first_num = TextBox1.Text
        second_num = TextBox2.Text
        result = first_num + second_num
        TextBox3.Text = result
    End Sub
End Class