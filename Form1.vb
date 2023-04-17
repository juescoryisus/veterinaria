Public Class Form1

    Dim nombre(5) As String
    Dim Nombree(5) As String
    Dim FechadeNacimiento(5) As DateTime?
    Dim FechadeNacimientoo(5) As DateTime?

    Dim i As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        nombre(i) = TextBox1.Text
        Nombree(i) = TextBox2.Text
        FechadeNacimiento(i) = dtmp.Value
        FechadeNacimientoo(i) = dtm2.Value

        MsgBox("arreglo" & (i) & "registrado")

        If i = 5 Then
            MsgBox("esta lleno")
        Else
            i = i + 1
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Rows.Add(TextBox1.Text, dtmp.Value, TextBox2.Text, dtm2.Value)

        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
