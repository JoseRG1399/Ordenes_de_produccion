Public Class Form17
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Faltan datos para poder ingresar.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
            Exit Sub

        End If

        If TextBox1.Text = "Giuseppe" And TextBox2.Text = "pepinos" Or TextBox1.Text = "Sistemas" And TextBox2.Text = "123456789" Or TextBox1.Text = "chaparro" And TextBox2.Text = "bola" Or TextBox1.Text = "Chaparro" And TextBox2.Text = "bola" Then
            Form18.Show()
            Me.Close()
            Form1.Close()

            TextBox1.Text = ""
            TextBox2.Text = ""
        Else
            MsgBox("Nombre de usuario o contraseña incorrectos.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Faltan datos para poder ingresar.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
                Exit Sub

            End If

            If TextBox1.Text = "Giuseppe" And TextBox2.Text = "pepinos" Or TextBox1.Text = "Sistemas" And TextBox2.Text = "123456789" Then
                Form18.Show()
                Me.Close()
                Form1.Close()

            Else
                MsgBox("Nombre de usuario o contraseña incorrectos.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
                Exit Sub
            End If
        End If
    End Sub
End Class