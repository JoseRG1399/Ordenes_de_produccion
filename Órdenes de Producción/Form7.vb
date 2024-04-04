Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms
Public Class Form7
    Dim conexion As New OleDbConnection
    Dim conexion1 As New OleDbConnection
    Dim conexion2 As New OleDbConnection
    Dim conexion3 As New OleDbConnection
    Dim conexion4 As New OleDbConnection
    Dim conexion5 As New OleDbConnection
    Dim conexion6 As New OleDbConnection

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True

        ComboBox1.Enabled = False
        TextBox1.Focus()
        TextBox2.Enabled = True
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\O. PASTELERIA 1.accdb"
        Catch ex As Exception
            MsgBox("La conexión falló. Favor de Verificar con Sistemas.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
        End Try
        Try
            conexion1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\O. PASTELERIA 2.accdb"
        Catch ex As Exception
            MsgBox("La conexión falló. Favor de Verificar con Sistemas.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
        End Try
        Try
            conexion2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\O. BATIDOS.accdb"
        Catch ex As Exception
            MsgBox("La conexión falló. Favor de Verificar con Sistemas.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
        End Try
        Try
            conexion3.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\O. CREMOSOS.accdb"
        Catch ex As Exception
            MsgBox("La conexión falló. Favor de Verificar con Sistemas.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
        End Try
        Try
            conexion4.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\O. FLANES.accdb"
        Catch ex As Exception
            MsgBox("La conexión falló. Favor de Verificar con Sistemas.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
        End Try
        Try
            conexion5.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\O. GELATINAS.accdb"
        Catch ex As Exception
            MsgBox("La conexión falló. Favor de Verificar con Sistemas.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
        End Try
        Try
            conexion6.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\O. PANADERIA.accdb"
        Catch ex As Exception
            MsgBox("La conexión falló. Favor de Verificar con Sistemas.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
        End Try
        Llenar_combo()
    End Sub
    Private Sub Llenar_combo()
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim dt As New DataTable

            adaptador = New OleDbDataAdapter("select DISTINCT  Receta from Recetas", conexion2)
            adaptador.Fill(dt)
            ComboBox3.DataSource = dt
            ComboBox3.DisplayMember = "Receta"
            ComboBox3.Text = ""

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("¿Deseas salir?", MsgBoxStyle.YesNo, "Rosa de Sarón Pastelerías") = MsgBoxResult.Yes Then
            Me.Close()
        Else

        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox2.Text = "" Then
            MsgBox("No has seleccionado ningún producto para pedir.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
            Exit Sub
        End If

        If ComboBox1.Text = "Batidos" Then
            Try
                Dim Adaptador1 As New OleDbDataAdapter
                Dim tabla1 As New DataTable
                Dim buscar1 As String

                buscar1 = ("select *from Lista_Productos where Producto='" & ComboBox2.Text & "'")
                Adaptador1 = New OleDbDataAdapter(buscar1, conexion2)
                tabla1 = New DataTable
                Adaptador1.Fill(tabla1)
                DataGridView2.DataSource = tabla1


                If DataGridView2.Rows.Count = "0" Then
                    MsgBox("El producto que intentas pedir NO EXISTE. Favor de verificar.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
                    ComboBox2.Text = ""
                    TextBox2.Text = ""
                    ComboBox2.Focus()
                    Exit Sub
                End If

                Try
                    Dim row As DataGridViewRow = DataGridView2.CurrentRow
                    TextBox2.Text = row.Cells(1).Value
                Catch ex As Exception

                End Try

                Dim Var1 As Decimal
                If TextBox1.Text < 1 And TextBox2.Text = "Kg" Then
                    Var1 = 0
                    TextBox2.Text = "g"
                    Var1 = TextBox1.Text * 1000
                    TextBox1.Text = Var1
                End If


                If TextBox1.Text < 1 And TextBox2.Text = "Lt" Then
                    Var1 = 0
                    TextBox2.Text = "ml"
                    Var1 = TextBox1.Text * 1000
                    TextBox1.Text = Var1
                End If



                Try
                    Dim cmd As New OleDbCommand
                    Dim r1 As Integer

                    cmd = New OleDbCommand("INSERT INTO Pedido_MateriaPrima(Fecha,Departamento,Producto,Cantidad,Unidad) VALUES('" & Label8.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & CDec(TextBox1.Text) & "','" & TextBox2.Text & "')", conexion2)
                    conexion2.Open()
                    r1 = cmd.ExecuteNonQuery
                    conexion2.Close()


                    ComboBox2.Text = ""
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox1.Focus()
                    Form5.ShowDialog()

                Catch ex As Exception
                    MsgBox("No se pudo agregar al pedido el producto.", MsgBoxStyle.Critical, "Rosa de Sárón Pastelerías")
                    Exit Sub
                End Try




                Try
                    Dim Adaptador11 As New OleDbDataAdapter
                    Dim tabla11 As New DataTable
                    Dim buscar11 As String

                    buscar11 = ("select *from Pedido_MateriaPrima where Fecha='" & Label8.Text & "'")
                    Adaptador11 = New OleDbDataAdapter(buscar11, conexion2)
                    tabla11 = New DataTable
                    Adaptador11.Fill(tabla11)
                    DataGridView1.DataSource = tabla11


                    Dim row As DataGridViewRow
                    For Each row In DataGridView1.Rows
                        row.Height = 30

                    Next

                    DataGridView1.Columns(0).Visible = False
                    DataGridView1.Columns(1).Visible = False
                    DataGridView1.Columns(2).Width = 400
                    DataGridView1.Columns(3).Width = 75
                    DataGridView1.Columns(4).Width = 80


                    DataGridView1.AllowUserToResizeRows = False
                    DataGridView1.AllowUserToResizeColumns = False
                    DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                    DataGridView1.DefaultCellStyle.BackColor = Color.NavajoWhite
                    DataGridView1.Rows.Item(0).Selected = False
                    DataGridView1.DefaultCellStyle.Font = New Font("Arial", 14)
                Catch ex As Exception

                End Try

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox2.Focus()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub ComboBox2_TextChanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged
        If ComboBox1.Text = "Batidos" Then
            Try
                Dim Adaptador1 As New OleDbDataAdapter
                Dim tabla1 As New DataTable
                Dim buscar1 As String

                buscar1 = ("select *from Lista_Productos where Producto='" & ComboBox2.Text & "'")
                Adaptador1 = New OleDbDataAdapter(buscar1, conexion)
                tabla1 = New DataTable
                Adaptador1.Fill(tabla1)
                DataGridView2.DataSource = tabla1




                Try
                    Dim row As DataGridViewRow = DataGridView2.CurrentRow
                    TextBox2.Text = row.Cells(1).Value
                    TextBox2.Focus()
                Catch ex As Exception

                End Try

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label8.Text = DateTime.Today

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label9.Text = TimeString

    End Sub

    Private Sub ComboBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ComboBox2.KeyDown


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then

            If ComboBox2.Text = "" Then
                MsgBox("No has seleccionado ningún producto para pedir.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
                Exit Sub
            End If

            If ComboBox1.Text = "Batidos" Then
                Try
                    Dim Adaptador1 As New OleDbDataAdapter
                    Dim tabla1 As New DataTable
                    Dim buscar1 As String

                    buscar1 = ("select *from Lista_Productos where Producto='" & ComboBox2.Text & "'")
                    Adaptador1 = New OleDbDataAdapter(buscar1, conexion2)
                    tabla1 = New DataTable
                    Adaptador1.Fill(tabla1)
                    DataGridView2.DataSource = tabla1


                    If DataGridView2.Rows.Count = "0" Then
                        MsgBox("El producto que intentas pedir NO EXISTE. Favor de verificar.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
                        ComboBox2.Text = ""
                        TextBox2.Text = ""
                        ComboBox2.Focus()
                        Exit Sub
                    End If

                    Try
                        Dim row As DataGridViewRow = DataGridView2.CurrentRow
                        TextBox2.Text = row.Cells(1).Value
                    Catch ex As Exception

                    End Try




                    Try
                        Dim cmd As New OleDbCommand
                        Dim r1 As Integer

                        cmd = New OleDbCommand("INSERT INTO Pedido_MateriaPrima(Fecha,Departamento,Producto,Cantidad,Unidad) VALUES('" & Label8.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & CDec(TextBox1.Text) & "','" & TextBox2.Text & "')", conexion2)
                        conexion2.Open()
                        r1 = cmd.ExecuteNonQuery
                        conexion2.Close()


                        ComboBox2.Text = ""
                        TextBox1.Text = ""
                        TextBox2.Text = ""
                        TextBox1.Focus()
                        Form5.ShowDialog()

                    Catch ex As Exception
                        MsgBox("No se pudo agregar al pedido el producto.", MsgBoxStyle.Critical, "Rosa de Sárón Pastelerías")
                        Exit Sub
                    End Try




                    Try
                        Dim Adaptador11 As New OleDbDataAdapter
                        Dim tabla11 As New DataTable
                        Dim buscar11 As String

                        buscar11 = ("select *from Pedido_MateriaPrima where Fecha='" & Label8.Text & "'")
                        Adaptador11 = New OleDbDataAdapter(buscar11, conexion2)
                        tabla11 = New DataTable
                        Adaptador11.Fill(tabla11)
                        DataGridView1.DataSource = tabla11


                        Dim row As DataGridViewRow
                        For Each row In DataGridView1.Rows
                            row.Height = 30

                        Next

                        DataGridView1.Columns(0).Visible = False
                        DataGridView1.Columns(1).Visible = False
                        DataGridView1.Columns(2).Width = 400
                        DataGridView1.Columns(3).Width = 75
                        DataGridView1.Columns(4).Width = 80


                        DataGridView1.AllowUserToResizeRows = False
                        DataGridView1.AllowUserToResizeColumns = False
                        DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                        DataGridView1.DefaultCellStyle.BackColor = Color.NavajoWhite
                        DataGridView1.Rows.Item(0).Selected = False
                        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 14)
                    Catch ex As Exception

                    End Try

                Catch ex As Exception

                End Try
            End If


        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox4.Text &= "1"
        TextBox4.Focus()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox4.Text &= "2"
        TextBox4.Focus()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox4.Text &= "3"
        TextBox4.Focus()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox4.Text &= "4"
        TextBox4.Focus()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox4.Text &= "5"
        TextBox4.Focus()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox4.Text &= "6"
        TextBox4.Focus()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TextBox4.Text &= "7"
        TextBox4.Focus()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox4.Text &= "8"
        TextBox4.Focus()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox4.Text &= "9"
        TextBox4.Focus()
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        TextBox4.Text &= "0"
        TextBox4.Focus()
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        TextBox4.Text &= "."
        TextBox4.Focus()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        TextBox4.Text = TextBox4.Text.Substring(0, TextBox4.Text.Length - 1)
        TextBox4.Focus()
    End Sub


    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If TextBox3.Text = "" Then
            MsgBox("No has seleccionado ningún producto para pedir.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
            Exit Sub
        End If
        If TextBox4.Text = "" Then
            MsgBox("No has seleccionado ninguna cantidad.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
            Exit Sub
        End If

        If ComboBox1.Text = "Batidos" Then

            'nuevo tramo de codigo pRA DESGLOSAR RECETAS, falta llevarlo al boton pedir

            Try
                Dim Adaptador11 As New OleDbDataAdapter
                Dim tabla11 As New DataTable
                Dim buscar11 As String
                Dim Var1 As Decimal
                buscar11 = ("select *from Recetas where Receta='" & TextBox3.Text & "'")
                Adaptador11 = New OleDbDataAdapter(buscar11, conexion2)
                tabla11 = New DataTable
                Adaptador11.Fill(tabla11)
                DataGridView2.DataSource = tabla11

                Dim row11 As DataGridViewRow
                For Each row11 In DataGridView2.Rows
                    row11.Height = 30

                    TextBox15.Text = row11.Cells(0).Value 'producto
                    TextBox16.Text = row11.Cells(1).Value 'cantidad dec
                    TextBox17.Text = row11.Cells(2).Value 'receta
                    TextBox18.Text = row11.Cells(3).Value 'total dec
                    TextBox19.Text = row11.Cells(4).Value 'unidad

                    TextBox20.Text = CDec(TextBox16.Text) * CDec(TextBox4.Text)
                    row11.Cells(3).Value = CDec(TextBox16.Text) * CDec(TextBox4.Text)

                    If TextBox20.Text >= 1000 And TextBox19.Text = "g" Then
                        Var1 = 0
                        TextBox19.Text = "Kg"
                        Var1 = TextBox20.Text / 1000
                        TextBox20.Text = Var1
                    End If

                    If TextBox20.Text >= 1000 And TextBox19.Text = "ml" Then
                        Var1 = 0
                        TextBox19.Text = "Lt"
                        Var1 = TextBox20.Text / 1000
                        TextBox20.Text = Var1
                    End If

                    Dim cmd As New OleDbCommand
                    Dim r1 As Integer

                    cmd = New OleDbCommand("INSERT INTO Pedido_MateriaPrima(Fecha,Departamento,Producto,Cantidad,Unidad) VALUES('" & Label8.Text & "','" & ComboBox1.Text & "','" & TextBox15.Text & "','" & CDec(TextBox20.Text) & "','" & TextBox19.Text & "')", conexion2)
                    conexion2.Open()
                    r1 = cmd.ExecuteNonQuery
                    conexion2.Close()

                Next

            Catch ex As Exception

            End Try


            'hasta aqui el nuevo codigo, lo de abjo se deja normal

            Try
                Dim Adaptador11 As New OleDbDataAdapter
                Dim tabla11 As New DataTable
                Dim buscar11 As String

                buscar11 = ("select *from Pedido_MateriaPrima where Fecha='" & Label8.Text & "'")
                Adaptador11 = New OleDbDataAdapter(buscar11, conexion2)
                tabla11 = New DataTable
                Adaptador11.Fill(tabla11)
                DataGridView1.DataSource = tabla11
            Catch ex As Exception

            End Try

            Dim row As DataGridViewRow
            For Each row In DataGridView1.Rows
                row.Height = 30

            Next

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = False
            DataGridView1.Columns(2).Width = 400
            DataGridView1.Columns(3).Width = 75
            DataGridView1.Columns(4).Width = 80


            DataGridView1.AllowUserToResizeRows = False
            DataGridView1.AllowUserToResizeColumns = False
            DataGridView1.DefaultCellStyle.ForeColor = Color.Black
            DataGridView1.DefaultCellStyle.BackColor = Color.NavajoWhite
            DataGridView1.Rows.Item(0).Selected = False
            DataGridView1.DefaultCellStyle.Font = New Font("Arial", 14)


            TextBox3.Text = ""
            TextBox4.Text = ""
            Form6.ShowDialog()
        End If

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            If TextBox3.Text = "" Then
                MsgBox("No has seleccionado ningún producto para pedir.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
                Exit Sub
            End If
            If TextBox4.Text = "" Then
                MsgBox("No has seleccionado ninguna cantidad.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
                Exit Sub
            End If

            If ComboBox1.Text = "Batidos" Then

                'nuevo tramo de codigo pRA DESGLOSAR RECETAS, falta llevarlo al boton pedir

                Try
                    Dim Adaptador11 As New OleDbDataAdapter
                    Dim tabla11 As New DataTable
                    Dim buscar11 As String
                    buscar11 = ("select *from Recetas where Receta='" & TextBox3.Text & "'")
                    Adaptador11 = New OleDbDataAdapter(buscar11, conexion2)
                    tabla11 = New DataTable
                    Adaptador11.Fill(tabla11)
                    DataGridView2.DataSource = tabla11

                    Dim row11 As DataGridViewRow
                    For Each row11 In DataGridView2.Rows
                        row11.Height = 30

                        TextBox15.Text = row11.Cells(0).Value 'producto
                        TextBox16.Text = row11.Cells(1).Value 'cantidad dec
                        TextBox17.Text = row11.Cells(2).Value 'receta
                        TextBox18.Text = row11.Cells(3).Value 'total dec
                        TextBox19.Text = row11.Cells(4).Value 'unidad

                        TextBox20.Text = CDec(TextBox16.Text) * CDec(TextBox4.Text)
                        row11.Cells(3).Value = CDec(TextBox16.Text) * CDec(TextBox4.Text)

                        Dim cmd As New OleDbCommand
                        Dim r1 As Integer

                        cmd = New OleDbCommand("INSERT INTO Pedido_MateriaPrima(Fecha,Departamento,Producto,Cantidad,Unidad) VALUES('" & Label8.Text & "','" & ComboBox1.Text & "','" & TextBox15.Text & "','" & CDec(TextBox20.Text) & "','" & TextBox19.Text & "')", conexion2)
                        conexion2.Open()
                        r1 = cmd.ExecuteNonQuery
                        conexion2.Close()

                    Next

                Catch ex As Exception

                End Try


                'hasta aqui el nuevo codigo, lo de abjo se deja normal

                Try
                    Dim Adaptador11 As New OleDbDataAdapter
                    Dim tabla11 As New DataTable
                    Dim buscar11 As String

                    buscar11 = ("select *from Pedido_MateriaPrima where Fecha='" & Label8.Text & "'")
                    Adaptador11 = New OleDbDataAdapter(buscar11, conexion2)
                    tabla11 = New DataTable
                    Adaptador11.Fill(tabla11)
                    DataGridView1.DataSource = tabla11
                Catch ex As Exception

                End Try

                Dim row As DataGridViewRow
                For Each row In DataGridView1.Rows
                    row.Height = 30

                Next

                DataGridView1.Columns(0).Visible = False
                DataGridView1.Columns(1).Visible = False
                DataGridView1.Columns(2).Width = 400
                DataGridView1.Columns(3).Width = 75
                DataGridView1.Columns(4).Width = 80


                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.AllowUserToResizeColumns = False
                DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                DataGridView1.DefaultCellStyle.BackColor = Color.NavajoWhite
                DataGridView1.Rows.Item(0).Selected = False
                DataGridView1.DefaultCellStyle.Font = New Font("Arial", 14)


                TextBox3.Text = ""
                TextBox4.Text = ""
                Form6.ShowDialog()
            End If



        End If
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        MsgBox("No disponible.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
        Exit Sub
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        If MsgBox("¿Deseas imprimir este pedido?", MsgBoxStyle.YesNo, "Rosa de Sarón Pastelerías") = MsgBoxResult.Yes Then
            PrintDocument1.Print()
        End If

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        If TextBox5.Text = "" Then
            MsgBox("No has seleccionado ningún producto para eliminar.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
            Exit Sub
        End If

        If MsgBox("¿Deseas borrar el producto seleccionado?", MsgBoxStyle.YesNo, "Rosa de Sarón Pastelerías") = MsgBoxResult.Yes Then



            Try
                Dim cmd15 As New OleDbCommand
                cmd15 = New OleDbCommand("delete from Pedido_MateriaPrima where Producto='" & TextBox5.Text & "'", conexion2)
                conexion2.Open()
                cmd15.ExecuteNonQuery()
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                Try
                    Dim Adaptador11 As New OleDbDataAdapter
                    Dim tabla11 As New DataTable
                    Dim buscar11 As String

                    buscar11 = ("select *from Pedido_MateriaPrima where Fecha='" & Label8.Text & "'")
                    Adaptador11 = New OleDbDataAdapter(buscar11, conexion2)
                    tabla11 = New DataTable
                    Adaptador11.Fill(tabla11)
                    DataGridView1.DataSource = tabla11
                Catch ex As Exception

                End Try




                Dim row As DataGridViewRow
                For Each row In DataGridView1.Rows
                    row.Height = 30

                Next

                DataGridView1.Columns(0).Visible = False
                DataGridView1.Columns(1).Visible = False
                DataGridView1.Columns(2).Width = 400
                DataGridView1.Columns(3).Width = 75
                DataGridView1.Columns(4).Width = 80


                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.AllowUserToResizeColumns = False
                DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                DataGridView1.DefaultCellStyle.BackColor = Color.NavajoWhite
                DataGridView1.Rows.Item(0).Selected = False
                DataGridView1.DefaultCellStyle.Font = New Font("Arial", 14)
            Catch ex As Exception

            End Try
            TextBox5.Text = ""
            MsgBox("Hecho.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row = DataGridView1.CurrentRow
        TextBox5.Text = row.Cells(2).Value
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click

        If MsgBox("¿Deseas borrar todo el pedido hecho y realizar uno nuevo?", MsgBoxStyle.YesNo, "Rosa de Sarón Pastelerías") = MsgBoxResult.Yes Then



            Try
                Dim cmd15 As New OleDbCommand
                cmd15 = New OleDbCommand("delete from Pedido_MateriaPrima", conexion2)
                conexion2.Open()
                cmd15.ExecuteNonQuery()
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                Try
                    Dim Adaptador11 As New OleDbDataAdapter
                    Dim tabla11 As New DataTable
                    Dim buscar11 As String

                    buscar11 = ("select *from Pedido_MateriaPrima where Fecha='" & Label8.Text & "'")
                    Adaptador11 = New OleDbDataAdapter(buscar11, conexion2)
                    tabla11 = New DataTable
                    Adaptador11.Fill(tabla11)
                    DataGridView1.DataSource = tabla11
                Catch ex As Exception

                End Try




                Dim row As DataGridViewRow
                For Each row In DataGridView1.Rows
                    row.Height = 30

                Next

                DataGridView1.Columns(0).Visible = False
                DataGridView1.Columns(1).Visible = False
                DataGridView1.Columns(2).Width = 400
                DataGridView1.Columns(3).Width = 75
                DataGridView1.Columns(4).Width = 80


                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.AllowUserToResizeColumns = False
                DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                DataGridView1.DefaultCellStyle.BackColor = Color.NavajoWhite
                DataGridView1.Rows.Item(0).Selected = False
                DataGridView1.DefaultCellStyle.Font = New Font("Arial", 14)
            Catch ex As Exception

            End Try
            MsgBox("Hecho.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")

        End If

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Shell("C:\Program Files\TeamViewer\TeamViewer.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
        PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
        e.Graphics.DrawImage(bm, 65, 0)
        Dim i As Integer = 0
        Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
        Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
        Dim prFont2 As New Font("Arial", 8, GraphicsUnit.Point)
        Dim prFont9 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
        Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
        Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
        Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
        e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 65, 65)
        e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 69, 75)
        e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 10, 90)
        e.Graphics.DrawString("S.A. de C.V.", prFont2, Brushes.Black, 60, 105)
        e.Graphics.DrawString("REQUISICIÓN DE", prFont1, Brushes.Black, 37, 120)
        e.Graphics.DrawString("MATERIA PRIMA", prFont1, Brushes.Black, 37, 135)
        e.Graphics.DrawString("BATIDOS", prFont3, Brushes.Black, 32, 150)
        e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 10, 170)
        e.Graphics.DrawString(Label8.Text, prFont2, Brushes.Black, 50, 170)
        e.Graphics.DrawString("Hora:", prFont2, Brushes.Black, 10, 185)
        e.Graphics.DrawString(Label9.Text, prFont2, Brushes.Black, 50, 185)

        e.Graphics.DrawString("Producto.", prFont9, Brushes.Black, 0, 210)
        e.Graphics.DrawString("Cant.", prFont9, Brushes.Black, 110, 210)
        e.Graphics.DrawString("Unidad", prFont9, Brushes.Black, 160, 210)



        While i < DataGridView1.RowCount



            e.Graphics.DrawString(DataGridView1.Item(2, i).Value, prFont2, Brushes.Black, 0, i * 15 + 225)
            e.Graphics.DrawString(DataGridView1.Item(3, i).Value, prFont2, Brushes.Black, 110, i * 15 + 225)
            e.Graphics.DrawString(DataGridView1.Item(4, i).Value, prFont2, Brushes.Black, 160, i * 15 + 225)
            i += 1

        End While

        'GUARDO DATOS SOLICITADOS A ALMACEN EN BASE DE DATOS Pedido_MateriaPrima_Definitiva


        If ComboBox1.Text = "Batidos" Then



            Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows

                TextBox6.Text = linea.Cells(0).Value
                TextBox7.Text = linea.Cells(1).Value
                TextBox8.Text = linea.Cells(2).Value
                TextBox9.Text = linea.Cells(3).Value
                TextBox10.Text = linea.Cells(4).Value

                Try
                    Dim cmd As New OleDbCommand
                    Dim r1 As Integer

                    cmd = New OleDbCommand("INSERT INTO Pedido_MateriaPrima_Definitiva(Fecha,Departamento,Producto,Cantidad,Unidad) VALUES('" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & CDec(TextBox9.Text) & "','" & TextBox10.Text & "')", conexion2)
                    conexion2.Open()
                    r1 = cmd.ExecuteNonQuery
                    conexion2.Close()



                Catch ex As Exception
                    MsgBox("No se pudo agregar al pedido el registro definitivo.", MsgBoxStyle.Critical, "Rosa de Sárón Pastelerías")
                    Exit Sub
                End Try

            Next




            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""
            TextBox9.Text = ""
            TextBox10.Text = ""
        End If


        'borro todo


        Try
            Dim cmd15 As New OleDbCommand
            cmd15 = New OleDbCommand("delete from Pedido_MateriaPrima", conexion2)
            conexion2.Open()
            cmd15.ExecuteNonQuery()
            conexion2.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            Try
                Dim Adaptador11 As New OleDbDataAdapter
                Dim tabla11 As New DataTable
                Dim buscar11 As String

                buscar11 = ("select *from Pedido_MateriaPrima where Fecha='" & Label8.Text & "'")
                Adaptador11 = New OleDbDataAdapter(buscar11, conexion2)
                tabla11 = New DataTable
                Adaptador11.Fill(tabla11)
                DataGridView1.DataSource = tabla11
            Catch ex As Exception

            End Try




            Dim row As DataGridViewRow
            For Each row In DataGridView1.Rows
                row.Height = 30

            Next

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = False
            DataGridView1.Columns(2).Width = 400
            DataGridView1.Columns(3).Width = 75
            DataGridView1.Columns(4).Width = 80


            DataGridView1.AllowUserToResizeRows = False
            DataGridView1.AllowUserToResizeColumns = False
            DataGridView1.DefaultCellStyle.ForeColor = Color.Black
            DataGridView1.DefaultCellStyle.BackColor = Color.NavajoWhite
            DataGridView1.Rows.Item(0).Selected = False
            DataGridView1.DefaultCellStyle.Font = New Font("Arial", 14)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        TextBox3.Text = ComboBox3.Text
        TextBox4.Focus()
        TextBox4.Text = ""
    End Sub
End Class