Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms
Public Class Form2
    Dim conexion As New OleDbConnection
    Dim conexion1 As New OleDbConnection
    Dim conexion2 As New OleDbConnection
    Dim conexion3 As New OleDbConnection
    Dim conexion4 As New OleDbConnection
    Dim conexion5 As New OleDbConnection
    Dim conexion6 As New OleDbConnection
    Dim conexion7 As New OleDbConnection
    Dim conexion8 As New OleDbConnection
    Dim conexion9 As New OleDbConnection
    Dim conexion10 As New OleDbConnection
    Dim conexion11 As New OleDbConnection
    Dim conexion12 As New OleDbConnection
    Dim conexion13 As New OleDbConnection
    Dim conexion14 As New OleDbConnection
    Dim conexion15 As New OleDbConnection
    Dim conexion16 As New OleDbConnection
    Dim conexion17 As New OleDbConnection
    Dim conexion18 As New OleDbConnection
    Dim conexion19 As New OleDbConnection
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
        GroupBox1.Visible = False
        DateTimePicker1.Value = DateTime.Today

        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\ACROPOLIS.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try
        Try
            conexion1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\5 DE MAYO.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try
        Try
            conexion2.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\XONA.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try
        Try
            conexion3.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\TORRES.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try
        Try
            conexion4.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\LERMA.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try
        Try
            conexion5.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\SUAREZ.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try
        Try
            conexion6.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\ADOLFO.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try
        Try
            conexion7.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\T CHICAS.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try
        Try
            conexion8.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\METEPEC.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try
        Try
            conexion9.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\MEXI.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try
        Try
            conexion10.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\COLON.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try
        Try
            conexion11.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\TEC.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try
        Try
            conexion12.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\AERO.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try
        Try
            conexion13.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\OCOYOACAC.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try
        Try
            conexion14.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\CARRANZA.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try
        Try
            conexion15.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\ALFREDO.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try
        Try
            conexion16.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\FABELA.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try
        Try
            conexion17.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\TOTO.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try
        Try
            conexion18.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\PRUEBAS.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try
        Try
            conexion19.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\CATA.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MsgBox("¿Deseas buscar un diseño en Internet?", MsgBoxStyle.YesNo, "Rosa de Sarón Pastelerías") = MsgBoxResult.Yes Then
            Process.Start("Chrome.exe")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("No disponible.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
        Exit Sub
        If MsgBox("¿Deseas Imprimir la Nota?", MsgBoxStyle.YesNo, "Rosa de Sarón Pastelerías") = MsgBoxResult.Yes Then
            PrintDocument1.Print()

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label42.Text = DateTime.Today
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox17.Text = ""
        TextBox19.Text = ""
        TextBox15.Text = ""
        TextBox32.Text = ""
        TextBox31.Text = ""
        TextBox30.Text = ""
        TextBox29.Text = ""
        TextBox28.Text = ""
        TextBox27.Text = ""
        TextBox26.Text = ""
        TextBox25.Text = ""
        TextBox24.Text = ""
        TextBox23.Text = ""
        TextBox22.Text = ""
        TextBox21.Text = ""
        TextBox20.Text = ""


        Dim cmd As New OleDbCommand

        cmd = New OleDbCommand("delete from NotasPedidos_Alfredo", conexion19)
        conexion19.Open()
        cmd.ExecuteNonQuery()
        conexion19.Close()

        Try
            Dim Adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from NotasPedidos_Alfredo where Entrega='" & DateTimePicker1.Value & "'")
            Adaptador1 = New OleDbDataAdapter(buscar1, conexion)
            tabla1 = New DataTable
            Adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1


            Dim linea As DataGridViewRow
            For Each linea In DataGridView2.Rows


                'se buscan las notas de la sucursal, se insertan en Lulu y al final de ahi se consultan
                'FALTAN LOS CAMPOS DEL INSERT INTO, Y LOS TEXT BOX QUE SEAN DECIMALES
                TextBox1.Text = linea.Cells(0).Value 'fecha
                TextBox2.Text = linea.Cells(1).Value 'hora
                TextBox3.Text = linea.Cells(2).Value 'suc
                TextBox4.Text = linea.Cells(3).Value 'vendedora
                TextBox5.Text = linea.Cells(4).Value 'No_Nota
                TextBox6.Text = linea.Cells(5).Value 'cantidad dec 
                TextBox7.Text = linea.Cells(6).Value 'producto 
                TextBox8.Text = linea.Cells(7).Value ' precio uni dec
                TextBox9.Text = linea.Cells(8).Value ' total dec
                TextBox10.Text = linea.Cells(9).Value 'fecha
                TextBox11.Text = linea.Cells(10).Value 'hora
                TextBox12.Text = linea.Cells(11).Value 'suc
                TextBox13.Text = linea.Cells(12).Value 'vendedora
                TextBox14.Text = linea.Cells(13).Value 'nombre
                TextBox15.Text = linea.Cells(14).Value 'cantidad dec 
                TextBox16.Text = linea.Cells(15).Value 'producto 
                TextBox17.Text = linea.Cells(16).Value ' precio uni dec
                TextBox18.Text = linea.Cells(17).Value ' total dec
                TextBox19.Text = linea.Cells(18).Value 'producto 
                TextBox20.Text = linea.Cells(20).Value ' precio uni dec


                Dim cmd1 As New OleDbCommand
                Dim r As Integer

                cmd1 = New OleDbCommand("INSERT INTO NotasPedidos_Alfredo(Fecha,Hora,Sucursal,Vendedora,No_Nota,Cliente,Teléfono,Cantidad,Medida,Relleno,Diseño,Observaciones,Texto,Precio,Entrega,Hora_Entrega,Formato,Domicilio_SiNo,Abono,Precio_fijo)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & CDec(TextBox8.Text) & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & CDec(TextBox14.Text) & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & CDec(TextBox19.Text) & "','" & TextBox20.Text & "')", conexion19)
                conexion19.Open()
                r = cmd1.ExecuteNonQuery
                conexion19.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion19.Close()

        End Try


        Try
            Dim Adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from NotasPedidos_Alfredo where Entrega='" & DateTimePicker1.Value & "'")
            Adaptador1 = New OleDbDataAdapter(buscar1, conexion1)
            tabla1 = New DataTable
            Adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1


            Dim linea As DataGridViewRow
            For Each linea In DataGridView2.Rows


                'se buscan las notas de la sucursal, se insertan en Lulu y al final de ahi se consultan
                'FALTAN LOS CAMPOS DEL INSERT INTO, Y LOS TEXT BOX QUE SEAN DECIMALES
                TextBox1.Text = linea.Cells(0).Value 'fecha
                TextBox2.Text = linea.Cells(1).Value 'hora
                TextBox3.Text = linea.Cells(2).Value 'suc
                TextBox4.Text = linea.Cells(3).Value 'vendedora
                TextBox5.Text = linea.Cells(4).Value 'No_Nota
                TextBox6.Text = linea.Cells(5).Value 'cantidad dec 
                TextBox7.Text = linea.Cells(6).Value 'producto 
                TextBox8.Text = linea.Cells(7).Value ' precio uni dec
                TextBox9.Text = linea.Cells(8).Value ' total dec
                TextBox10.Text = linea.Cells(9).Value 'fecha
                TextBox11.Text = linea.Cells(10).Value 'hora
                TextBox12.Text = linea.Cells(11).Value 'suc
                TextBox13.Text = linea.Cells(12).Value 'vendedora
                TextBox14.Text = linea.Cells(13).Value 'nombre
                TextBox15.Text = linea.Cells(14).Value 'cantidad dec 
                TextBox16.Text = linea.Cells(15).Value 'producto 
                TextBox17.Text = linea.Cells(16).Value ' precio uni dec
                TextBox18.Text = linea.Cells(17).Value ' total dec
                TextBox19.Text = linea.Cells(18).Value 'producto 
                TextBox20.Text = linea.Cells(20).Value ' precio uni dec


                Dim cmd1 As New OleDbCommand
                Dim r As Integer

                cmd1 = New OleDbCommand("INSERT INTO NotasPedidos_Alfredo(Fecha,Hora,Sucursal,Vendedora,No_Nota,Cliente,Teléfono,Cantidad,Medida,Relleno,Diseño,Observaciones,Texto,Precio,Entrega,Hora_Entrega,Formato,Domicilio_SiNo,Abono,Precio_fijo)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & CDec(TextBox8.Text) & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & CDec(TextBox14.Text) & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & CDec(TextBox19.Text) & "','" & TextBox20.Text & "')", conexion19)
                conexion19.Open()
                r = cmd1.ExecuteNonQuery
                conexion19.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion19.Close()

        End Try




        Try
            Dim Adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from NotasPedidos_Alfredo where Entrega='" & DateTimePicker1.Value & "'")
            Adaptador1 = New OleDbDataAdapter(buscar1, conexion2)
            tabla1 = New DataTable
            Adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1


            Dim linea As DataGridViewRow
            For Each linea In DataGridView2.Rows


                'se buscan las notas de la sucursal, se insertan en Lulu y al final de ahi se consultan
                'FALTAN LOS CAMPOS DEL INSERT INTO, Y LOS TEXT BOX QUE SEAN DECIMALES
                TextBox1.Text = linea.Cells(0).Value 'fecha
                TextBox2.Text = linea.Cells(1).Value 'hora
                TextBox3.Text = linea.Cells(2).Value 'suc
                TextBox4.Text = linea.Cells(3).Value 'vendedora
                TextBox5.Text = linea.Cells(4).Value 'No_Nota
                TextBox6.Text = linea.Cells(5).Value 'cantidad dec 
                TextBox7.Text = linea.Cells(6).Value 'producto 
                TextBox8.Text = linea.Cells(7).Value ' precio uni dec
                TextBox9.Text = linea.Cells(8).Value ' total dec
                TextBox10.Text = linea.Cells(9).Value 'fecha
                TextBox11.Text = linea.Cells(10).Value 'hora
                TextBox12.Text = linea.Cells(11).Value 'suc
                TextBox13.Text = linea.Cells(12).Value 'vendedora
                TextBox14.Text = linea.Cells(13).Value 'nombre
                TextBox15.Text = linea.Cells(14).Value 'cantidad dec 
                TextBox16.Text = linea.Cells(15).Value 'producto 
                TextBox17.Text = linea.Cells(16).Value ' precio uni dec
                TextBox18.Text = linea.Cells(17).Value ' total dec
                TextBox19.Text = linea.Cells(18).Value 'producto 
                TextBox20.Text = linea.Cells(20).Value ' precio uni dec


                Dim cmd1 As New OleDbCommand
                Dim r As Integer

                cmd1 = New OleDbCommand("INSERT INTO NotasPedidos_Alfredo(Fecha,Hora,Sucursal,Vendedora,No_Nota,Cliente,Teléfono,Cantidad,Medida,Relleno,Diseño,Observaciones,Texto,Precio,Entrega,Hora_Entrega,Formato,Domicilio_SiNo,Abono,Precio_fijo)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & CDec(TextBox8.Text) & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & CDec(TextBox14.Text) & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & CDec(TextBox19.Text) & "','" & TextBox20.Text & "')", conexion19)
                conexion19.Open()
                r = cmd1.ExecuteNonQuery
                conexion19.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion19.Close()

        End Try




        Try
            Dim Adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from NotasPedidos_Alfredo where Entrega='" & DateTimePicker1.Value & "'")
            Adaptador1 = New OleDbDataAdapter(buscar1, conexion3)
            tabla1 = New DataTable
            Adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1


            Dim linea As DataGridViewRow
            For Each linea In DataGridView2.Rows


                'se buscan las notas de la sucursal, se insertan en Lulu y al final de ahi se consultan
                'FALTAN LOS CAMPOS DEL INSERT INTO, Y LOS TEXT BOX QUE SEAN DECIMALES
                TextBox1.Text = linea.Cells(0).Value 'fecha
                TextBox2.Text = linea.Cells(1).Value 'hora
                TextBox3.Text = linea.Cells(2).Value 'suc
                TextBox4.Text = linea.Cells(3).Value 'vendedora
                TextBox5.Text = linea.Cells(4).Value 'No_Nota
                TextBox6.Text = linea.Cells(5).Value 'cantidad dec 
                TextBox7.Text = linea.Cells(6).Value 'producto 
                TextBox8.Text = linea.Cells(7).Value ' precio uni dec
                TextBox9.Text = linea.Cells(8).Value ' total dec
                TextBox10.Text = linea.Cells(9).Value 'fecha
                TextBox11.Text = linea.Cells(10).Value 'hora
                TextBox12.Text = linea.Cells(11).Value 'suc
                TextBox13.Text = linea.Cells(12).Value 'vendedora
                TextBox14.Text = linea.Cells(13).Value 'nombre
                TextBox15.Text = linea.Cells(14).Value 'cantidad dec 
                TextBox16.Text = linea.Cells(15).Value 'producto 
                TextBox17.Text = linea.Cells(16).Value ' precio uni dec
                TextBox18.Text = linea.Cells(17).Value ' total dec
                TextBox19.Text = linea.Cells(18).Value 'producto 
                TextBox20.Text = linea.Cells(20).Value ' precio uni dec


                Dim cmd1 As New OleDbCommand
                Dim r As Integer

                cmd1 = New OleDbCommand("INSERT INTO NotasPedidos_Alfredo(Fecha,Hora,Sucursal,Vendedora,No_Nota,Cliente,Teléfono,Cantidad,Medida,Relleno,Diseño,Observaciones,Texto,Precio,Entrega,Hora_Entrega,Formato,Domicilio_SiNo,Abono,Precio_fijo)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & CDec(TextBox8.Text) & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & CDec(TextBox14.Text) & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & CDec(TextBox19.Text) & "','" & TextBox20.Text & "')", conexion19)
                conexion19.Open()
                r = cmd1.ExecuteNonQuery
                conexion19.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion19.Close()

        End Try




        Try
            Dim Adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from NotasPedidos_Alfredo where Entrega='" & DateTimePicker1.Value & "'")
            Adaptador1 = New OleDbDataAdapter(buscar1, conexion4)
            tabla1 = New DataTable
            Adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1


            Dim linea As DataGridViewRow
            For Each linea In DataGridView2.Rows


                'se buscan las notas de la sucursal, se insertan en Lulu y al final de ahi se consultan
                'FALTAN LOS CAMPOS DEL INSERT INTO, Y LOS TEXT BOX QUE SEAN DECIMALES
                TextBox1.Text = linea.Cells(0).Value 'fecha
                TextBox2.Text = linea.Cells(1).Value 'hora
                TextBox3.Text = linea.Cells(2).Value 'suc
                TextBox4.Text = linea.Cells(3).Value 'vendedora
                TextBox5.Text = linea.Cells(4).Value 'No_Nota
                TextBox6.Text = linea.Cells(5).Value 'cantidad dec 
                TextBox7.Text = linea.Cells(6).Value 'producto 
                TextBox8.Text = linea.Cells(7).Value ' precio uni dec
                TextBox9.Text = linea.Cells(8).Value ' total dec
                TextBox10.Text = linea.Cells(9).Value 'fecha
                TextBox11.Text = linea.Cells(10).Value 'hora
                TextBox12.Text = linea.Cells(11).Value 'suc
                TextBox13.Text = linea.Cells(12).Value 'vendedora
                TextBox14.Text = linea.Cells(13).Value 'nombre
                TextBox15.Text = linea.Cells(14).Value 'cantidad dec 
                TextBox16.Text = linea.Cells(15).Value 'producto 
                TextBox17.Text = linea.Cells(16).Value ' precio uni dec
                TextBox18.Text = linea.Cells(17).Value ' total dec
                TextBox19.Text = linea.Cells(18).Value 'producto 
                TextBox20.Text = linea.Cells(20).Value ' precio uni dec


                Dim cmd1 As New OleDbCommand
                Dim r As Integer

                cmd1 = New OleDbCommand("INSERT INTO NotasPedidos_Alfredo(Fecha,Hora,Sucursal,Vendedora,No_Nota,Cliente,Teléfono,Cantidad,Medida,Relleno,Diseño,Observaciones,Texto,Precio,Entrega,Hora_Entrega,Formato,Domicilio_SiNo,Abono,Precio_fijo)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & CDec(TextBox8.Text) & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & CDec(TextBox14.Text) & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & CDec(TextBox19.Text) & "','" & TextBox20.Text & "')", conexion19)
                conexion19.Open()
                r = cmd1.ExecuteNonQuery
                conexion19.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion19.Close()

        End Try




        Try
            Dim Adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from NotasPedidos_Alfredo where Entrega='" & DateTimePicker1.Value & "'")
            Adaptador1 = New OleDbDataAdapter(buscar1, conexion5)
            tabla1 = New DataTable
            Adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1


            Dim linea As DataGridViewRow
            For Each linea In DataGridView2.Rows


                'se buscan las notas de la sucursal, se insertan en Lulu y al final de ahi se consultan
                'FALTAN LOS CAMPOS DEL INSERT INTO, Y LOS TEXT BOX QUE SEAN DECIMALES
                TextBox1.Text = linea.Cells(0).Value 'fecha
                TextBox2.Text = linea.Cells(1).Value 'hora
                TextBox3.Text = linea.Cells(2).Value 'suc
                TextBox4.Text = linea.Cells(3).Value 'vendedora
                TextBox5.Text = linea.Cells(4).Value 'No_Nota
                TextBox6.Text = linea.Cells(5).Value 'cantidad dec 
                TextBox7.Text = linea.Cells(6).Value 'producto 
                TextBox8.Text = linea.Cells(7).Value ' precio uni dec
                TextBox9.Text = linea.Cells(8).Value ' total dec
                TextBox10.Text = linea.Cells(9).Value 'fecha
                TextBox11.Text = linea.Cells(10).Value 'hora
                TextBox12.Text = linea.Cells(11).Value 'suc
                TextBox13.Text = linea.Cells(12).Value 'vendedora
                TextBox14.Text = linea.Cells(13).Value 'nombre
                TextBox15.Text = linea.Cells(14).Value 'cantidad dec 
                TextBox16.Text = linea.Cells(15).Value 'producto 
                TextBox17.Text = linea.Cells(16).Value ' precio uni dec
                TextBox18.Text = linea.Cells(17).Value ' total dec
                TextBox19.Text = linea.Cells(18).Value 'producto 
                TextBox20.Text = linea.Cells(20).Value ' precio uni dec


                Dim cmd1 As New OleDbCommand
                Dim r As Integer

                cmd1 = New OleDbCommand("INSERT INTO NotasPedidos_Alfredo(Fecha,Hora,Sucursal,Vendedora,No_Nota,Cliente,Teléfono,Cantidad,Medida,Relleno,Diseño,Observaciones,Texto,Precio,Entrega,Hora_Entrega,Formato,Domicilio_SiNo,Abono,Precio_fijo)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & CDec(TextBox8.Text) & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & CDec(TextBox14.Text) & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & CDec(TextBox19.Text) & "','" & TextBox20.Text & "')", conexion19)
                conexion19.Open()
                r = cmd1.ExecuteNonQuery
                conexion19.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion19.Close()

        End Try




        Try
            Dim Adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from NotasPedidos_Alfredo where Entrega='" & DateTimePicker1.Value & "'")
            Adaptador1 = New OleDbDataAdapter(buscar1, conexion6)
            tabla1 = New DataTable
            Adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1


            Dim linea As DataGridViewRow
            For Each linea In DataGridView2.Rows


                'se buscan las notas de la sucursal, se insertan en Lulu y al final de ahi se consultan
                'FALTAN LOS CAMPOS DEL INSERT INTO, Y LOS TEXT BOX QUE SEAN DECIMALES
                TextBox1.Text = linea.Cells(0).Value 'fecha
                TextBox2.Text = linea.Cells(1).Value 'hora
                TextBox3.Text = linea.Cells(2).Value 'suc
                TextBox4.Text = linea.Cells(3).Value 'vendedora
                TextBox5.Text = linea.Cells(4).Value 'No_Nota
                TextBox6.Text = linea.Cells(5).Value 'cantidad dec 
                TextBox7.Text = linea.Cells(6).Value 'producto 
                TextBox8.Text = linea.Cells(7).Value ' precio uni dec
                TextBox9.Text = linea.Cells(8).Value ' total dec
                TextBox10.Text = linea.Cells(9).Value 'fecha
                TextBox11.Text = linea.Cells(10).Value 'hora
                TextBox12.Text = linea.Cells(11).Value 'suc
                TextBox13.Text = linea.Cells(12).Value 'vendedora
                TextBox14.Text = linea.Cells(13).Value 'nombre
                TextBox15.Text = linea.Cells(14).Value 'cantidad dec 
                TextBox16.Text = linea.Cells(15).Value 'producto 
                TextBox17.Text = linea.Cells(16).Value ' precio uni dec
                TextBox18.Text = linea.Cells(17).Value ' total dec
                TextBox19.Text = linea.Cells(18).Value 'producto 
                TextBox20.Text = linea.Cells(20).Value ' precio uni dec


                Dim cmd1 As New OleDbCommand
                Dim r As Integer

                cmd1 = New OleDbCommand("INSERT INTO NotasPedidos_Alfredo(Fecha,Hora,Sucursal,Vendedora,No_Nota,Cliente,Teléfono,Cantidad,Medida,Relleno,Diseño,Observaciones,Texto,Precio,Entrega,Hora_Entrega,Formato,Domicilio_SiNo,Abono,Precio_fijo)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & CDec(TextBox8.Text) & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & CDec(TextBox14.Text) & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & CDec(TextBox19.Text) & "','" & TextBox20.Text & "')", conexion19)
                conexion19.Open()
                r = cmd1.ExecuteNonQuery
                conexion19.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion19.Close()

        End Try




        Try
            Dim Adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from NotasPedidos_Alfredo where Entrega='" & DateTimePicker1.Value & "'")
            Adaptador1 = New OleDbDataAdapter(buscar1, conexion7)
            tabla1 = New DataTable
            Adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1


            Dim linea As DataGridViewRow
            For Each linea In DataGridView2.Rows


                'se buscan las notas de la sucursal, se insertan en Lulu y al final de ahi se consultan
                'FALTAN LOS CAMPOS DEL INSERT INTO, Y LOS TEXT BOX QUE SEAN DECIMALES
                TextBox1.Text = linea.Cells(0).Value 'fecha
                TextBox2.Text = linea.Cells(1).Value 'hora
                TextBox3.Text = linea.Cells(2).Value 'suc
                TextBox4.Text = linea.Cells(3).Value 'vendedora
                TextBox5.Text = linea.Cells(4).Value 'No_Nota
                TextBox6.Text = linea.Cells(5).Value 'cantidad dec 
                TextBox7.Text = linea.Cells(6).Value 'producto 
                TextBox8.Text = linea.Cells(7).Value ' precio uni dec
                TextBox9.Text = linea.Cells(8).Value ' total dec
                TextBox10.Text = linea.Cells(9).Value 'fecha
                TextBox11.Text = linea.Cells(10).Value 'hora
                TextBox12.Text = linea.Cells(11).Value 'suc
                TextBox13.Text = linea.Cells(12).Value 'vendedora
                TextBox14.Text = linea.Cells(13).Value 'nombre
                TextBox15.Text = linea.Cells(14).Value 'cantidad dec 
                TextBox16.Text = linea.Cells(15).Value 'producto 
                TextBox17.Text = linea.Cells(16).Value ' precio uni dec
                TextBox18.Text = linea.Cells(17).Value ' total dec
                TextBox19.Text = linea.Cells(18).Value 'producto 
                TextBox20.Text = linea.Cells(20).Value ' precio uni dec


                Dim cmd1 As New OleDbCommand
                Dim r As Integer

                cmd1 = New OleDbCommand("INSERT INTO NotasPedidos_Alfredo(Fecha,Hora,Sucursal,Vendedora,No_Nota,Cliente,Teléfono,Cantidad,Medida,Relleno,Diseño,Observaciones,Texto,Precio,Entrega,Hora_Entrega,Formato,Domicilio_SiNo,Abono,Precio_fijo)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & CDec(TextBox8.Text) & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & CDec(TextBox14.Text) & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & CDec(TextBox19.Text) & "','" & TextBox20.Text & "')", conexion19)
                conexion19.Open()
                r = cmd1.ExecuteNonQuery
                conexion19.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion19.Close()

        End Try




        Try
            Dim Adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from NotasPedidos_Alfredo where Entrega='" & DateTimePicker1.Value & "'")
            Adaptador1 = New OleDbDataAdapter(buscar1, conexion8)
            tabla1 = New DataTable
            Adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1


            Dim linea As DataGridViewRow
            For Each linea In DataGridView2.Rows


                'se buscan las notas de la sucursal, se insertan en Lulu y al final de ahi se consultan
                'FALTAN LOS CAMPOS DEL INSERT INTO, Y LOS TEXT BOX QUE SEAN DECIMALES
                TextBox1.Text = linea.Cells(0).Value 'fecha
                TextBox2.Text = linea.Cells(1).Value 'hora
                TextBox3.Text = linea.Cells(2).Value 'suc
                TextBox4.Text = linea.Cells(3).Value 'vendedora
                TextBox5.Text = linea.Cells(4).Value 'No_Nota
                TextBox6.Text = linea.Cells(5).Value 'cantidad dec 
                TextBox7.Text = linea.Cells(6).Value 'producto 
                TextBox8.Text = linea.Cells(7).Value ' precio uni dec
                TextBox9.Text = linea.Cells(8).Value ' total dec
                TextBox10.Text = linea.Cells(9).Value 'fecha
                TextBox11.Text = linea.Cells(10).Value 'hora
                TextBox12.Text = linea.Cells(11).Value 'suc
                TextBox13.Text = linea.Cells(12).Value 'vendedora
                TextBox14.Text = linea.Cells(13).Value 'nombre
                TextBox15.Text = linea.Cells(14).Value 'cantidad dec 
                TextBox16.Text = linea.Cells(15).Value 'producto 
                TextBox17.Text = linea.Cells(16).Value ' precio uni dec
                TextBox18.Text = linea.Cells(17).Value ' total dec
                TextBox19.Text = linea.Cells(18).Value 'producto 
                TextBox20.Text = linea.Cells(20).Value ' precio uni dec


                Dim cmd1 As New OleDbCommand
                Dim r As Integer

                cmd1 = New OleDbCommand("INSERT INTO NotasPedidos_Alfredo(Fecha,Hora,Sucursal,Vendedora,No_Nota,Cliente,Teléfono,Cantidad,Medida,Relleno,Diseño,Observaciones,Texto,Precio,Entrega,Hora_Entrega,Formato,Domicilio_SiNo,Abono,Precio_fijo)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & CDec(TextBox8.Text) & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & CDec(TextBox14.Text) & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & CDec(TextBox19.Text) & "','" & TextBox20.Text & "')", conexion19)
                conexion19.Open()
                r = cmd1.ExecuteNonQuery
                conexion19.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion19.Close()

        End Try




        Try
            Dim Adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from NotasPedidos_Alfredo where Entrega='" & DateTimePicker1.Value & "'")
            Adaptador1 = New OleDbDataAdapter(buscar1, conexion9)
            tabla1 = New DataTable
            Adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1


            Dim linea As DataGridViewRow
            For Each linea In DataGridView2.Rows


                'se buscan las notas de la sucursal, se insertan en Lulu y al final de ahi se consultan
                'FALTAN LOS CAMPOS DEL INSERT INTO, Y LOS TEXT BOX QUE SEAN DECIMALES
                TextBox1.Text = linea.Cells(0).Value 'fecha
                TextBox2.Text = linea.Cells(1).Value 'hora
                TextBox3.Text = linea.Cells(2).Value 'suc
                TextBox4.Text = linea.Cells(3).Value 'vendedora
                TextBox5.Text = linea.Cells(4).Value 'No_Nota
                TextBox6.Text = linea.Cells(5).Value 'cantidad dec 
                TextBox7.Text = linea.Cells(6).Value 'producto 
                TextBox8.Text = linea.Cells(7).Value ' precio uni dec
                TextBox9.Text = linea.Cells(8).Value ' total dec
                TextBox10.Text = linea.Cells(9).Value 'fecha
                TextBox11.Text = linea.Cells(10).Value 'hora
                TextBox12.Text = linea.Cells(11).Value 'suc
                TextBox13.Text = linea.Cells(12).Value 'vendedora
                TextBox14.Text = linea.Cells(13).Value 'nombre
                TextBox15.Text = linea.Cells(14).Value 'cantidad dec 
                TextBox16.Text = linea.Cells(15).Value 'producto 
                TextBox17.Text = linea.Cells(16).Value ' precio uni dec
                TextBox18.Text = linea.Cells(17).Value ' total dec
                TextBox19.Text = linea.Cells(18).Value 'producto 
                TextBox20.Text = linea.Cells(20).Value ' precio uni dec


                Dim cmd1 As New OleDbCommand
                Dim r As Integer

                cmd1 = New OleDbCommand("INSERT INTO NotasPedidos_Alfredo(Fecha,Hora,Sucursal,Vendedora,No_Nota,Cliente,Teléfono,Cantidad,Medida,Relleno,Diseño,Observaciones,Texto,Precio,Entrega,Hora_Entrega,Formato,Domicilio_SiNo,Abono,Precio_fijo)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & CDec(TextBox8.Text) & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & CDec(TextBox14.Text) & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & CDec(TextBox19.Text) & "','" & TextBox20.Text & "')", conexion19)
                conexion19.Open()
                r = cmd1.ExecuteNonQuery
                conexion19.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion19.Close()

        End Try





        Try
            Dim Adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from NotasPedidos_Alfredo where Entrega='" & DateTimePicker1.Value & "'")
            Adaptador1 = New OleDbDataAdapter(buscar1, conexion10)
            tabla1 = New DataTable
            Adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1


            Dim linea As DataGridViewRow
            For Each linea In DataGridView2.Rows


                'se buscan las notas de la sucursal, se insertan en Lulu y al final de ahi se consultan
                'FALTAN LOS CAMPOS DEL INSERT INTO, Y LOS TEXT BOX QUE SEAN DECIMALES
                TextBox1.Text = linea.Cells(0).Value 'fecha
                TextBox2.Text = linea.Cells(1).Value 'hora
                TextBox3.Text = linea.Cells(2).Value 'suc
                TextBox4.Text = linea.Cells(3).Value 'vendedora
                TextBox5.Text = linea.Cells(4).Value 'No_Nota
                TextBox6.Text = linea.Cells(5).Value 'cantidad dec 
                TextBox7.Text = linea.Cells(6).Value 'producto 
                TextBox8.Text = linea.Cells(7).Value ' precio uni dec
                TextBox9.Text = linea.Cells(8).Value ' total dec
                TextBox10.Text = linea.Cells(9).Value 'fecha
                TextBox11.Text = linea.Cells(10).Value 'hora
                TextBox12.Text = linea.Cells(11).Value 'suc
                TextBox13.Text = linea.Cells(12).Value 'vendedora
                TextBox14.Text = linea.Cells(13).Value 'nombre
                TextBox15.Text = linea.Cells(14).Value 'cantidad dec 
                TextBox16.Text = linea.Cells(15).Value 'producto 
                TextBox17.Text = linea.Cells(16).Value ' precio uni dec
                TextBox18.Text = linea.Cells(17).Value ' total dec
                TextBox19.Text = linea.Cells(18).Value 'producto 
                TextBox20.Text = linea.Cells(20).Value ' precio uni dec


                Dim cmd1 As New OleDbCommand
                Dim r As Integer

                cmd1 = New OleDbCommand("INSERT INTO NotasPedidos_Alfredo(Fecha,Hora,Sucursal,Vendedora,No_Nota,Cliente,Teléfono,Cantidad,Medida,Relleno,Diseño,Observaciones,Texto,Precio,Entrega,Hora_Entrega,Formato,Domicilio_SiNo,Abono,Precio_fijo)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & CDec(TextBox8.Text) & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & CDec(TextBox14.Text) & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & CDec(TextBox19.Text) & "','" & TextBox20.Text & "')", conexion19)
                conexion19.Open()
                r = cmd1.ExecuteNonQuery
                conexion19.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion19.Close()

        End Try





        Try
            Dim Adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from NotasPedidos_Alfredo where Entrega='" & DateTimePicker1.Value & "'")
            Adaptador1 = New OleDbDataAdapter(buscar1, conexion11)
            tabla1 = New DataTable
            Adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1


            Dim linea As DataGridViewRow
            For Each linea In DataGridView2.Rows


                'se buscan las notas de la sucursal, se insertan en Lulu y al final de ahi se consultan
                'FALTAN LOS CAMPOS DEL INSERT INTO, Y LOS TEXT BOX QUE SEAN DECIMALES
                TextBox1.Text = linea.Cells(0).Value 'fecha
                TextBox2.Text = linea.Cells(1).Value 'hora
                TextBox3.Text = linea.Cells(2).Value 'suc
                TextBox4.Text = linea.Cells(3).Value 'vendedora
                TextBox5.Text = linea.Cells(4).Value 'No_Nota
                TextBox6.Text = linea.Cells(5).Value 'cantidad dec 
                TextBox7.Text = linea.Cells(6).Value 'producto 
                TextBox8.Text = linea.Cells(7).Value ' precio uni dec
                TextBox9.Text = linea.Cells(8).Value ' total dec
                TextBox10.Text = linea.Cells(9).Value 'fecha
                TextBox11.Text = linea.Cells(10).Value 'hora
                TextBox12.Text = linea.Cells(11).Value 'suc
                TextBox13.Text = linea.Cells(12).Value 'vendedora
                TextBox14.Text = linea.Cells(13).Value 'nombre
                TextBox15.Text = linea.Cells(14).Value 'cantidad dec 
                TextBox16.Text = linea.Cells(15).Value 'producto 
                TextBox17.Text = linea.Cells(16).Value ' precio uni dec
                TextBox18.Text = linea.Cells(17).Value ' total dec
                TextBox19.Text = linea.Cells(18).Value 'producto 
                TextBox20.Text = linea.Cells(20).Value ' precio uni dec


                Dim cmd1 As New OleDbCommand
                Dim r As Integer

                cmd1 = New OleDbCommand("INSERT INTO NotasPedidos_Alfredo(Fecha,Hora,Sucursal,Vendedora,No_Nota,Cliente,Teléfono,Cantidad,Medida,Relleno,Diseño,Observaciones,Texto,Precio,Entrega,Hora_Entrega,Formato,Domicilio_SiNo,Abono,Precio_fijo)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & CDec(TextBox8.Text) & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & CDec(TextBox14.Text) & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & CDec(TextBox19.Text) & "','" & TextBox20.Text & "')", conexion19)
                conexion19.Open()
                r = cmd1.ExecuteNonQuery
                conexion19.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion19.Close()

        End Try




        Try
            Dim Adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from NotasPedidos_Alfredo where Entrega='" & DateTimePicker1.Value & "'")
            Adaptador1 = New OleDbDataAdapter(buscar1, conexion12)
            tabla1 = New DataTable
            Adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1


            Dim linea As DataGridViewRow
            For Each linea In DataGridView2.Rows


                'se buscan las notas de la sucursal, se insertan en Lulu y al final de ahi se consultan
                'FALTAN LOS CAMPOS DEL INSERT INTO, Y LOS TEXT BOX QUE SEAN DECIMALES
                TextBox1.Text = linea.Cells(0).Value 'fecha
                TextBox2.Text = linea.Cells(1).Value 'hora
                TextBox3.Text = linea.Cells(2).Value 'suc
                TextBox4.Text = linea.Cells(3).Value 'vendedora
                TextBox5.Text = linea.Cells(4).Value 'No_Nota
                TextBox6.Text = linea.Cells(5).Value 'cantidad dec 
                TextBox7.Text = linea.Cells(6).Value 'producto 
                TextBox8.Text = linea.Cells(7).Value ' precio uni dec
                TextBox9.Text = linea.Cells(8).Value ' total dec
                TextBox10.Text = linea.Cells(9).Value 'fecha
                TextBox11.Text = linea.Cells(10).Value 'hora
                TextBox12.Text = linea.Cells(11).Value 'suc
                TextBox13.Text = linea.Cells(12).Value 'vendedora
                TextBox14.Text = linea.Cells(13).Value 'nombre
                TextBox15.Text = linea.Cells(14).Value 'cantidad dec 
                TextBox16.Text = linea.Cells(15).Value 'producto 
                TextBox17.Text = linea.Cells(16).Value ' precio uni dec
                TextBox18.Text = linea.Cells(17).Value ' total dec
                TextBox19.Text = linea.Cells(18).Value 'producto 
                TextBox20.Text = linea.Cells(20).Value ' precio uni dec


                Dim cmd1 As New OleDbCommand
                Dim r As Integer

                cmd1 = New OleDbCommand("INSERT INTO NotasPedidos_Alfredo(Fecha,Hora,Sucursal,Vendedora,No_Nota,Cliente,Teléfono,Cantidad,Medida,Relleno,Diseño,Observaciones,Texto,Precio,Entrega,Hora_Entrega,Formato,Domicilio_SiNo,Abono,Precio_fijo)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & CDec(TextBox8.Text) & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & CDec(TextBox14.Text) & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & CDec(TextBox19.Text) & "','" & TextBox20.Text & "')", conexion19)
                conexion19.Open()
                r = cmd1.ExecuteNonQuery
                conexion19.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion19.Close()

        End Try





        Try
            Dim Adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from NotasPedidos_Alfredo where Entrega='" & DateTimePicker1.Value & "'")
            Adaptador1 = New OleDbDataAdapter(buscar1, conexion13)
            tabla1 = New DataTable
            Adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1


            Dim linea As DataGridViewRow
            For Each linea In DataGridView2.Rows


                'se buscan las notas de la sucursal, se insertan en Lulu y al final de ahi se consultan
                'FALTAN LOS CAMPOS DEL INSERT INTO, Y LOS TEXT BOX QUE SEAN DECIMALES
                TextBox1.Text = linea.Cells(0).Value 'fecha
                TextBox2.Text = linea.Cells(1).Value 'hora
                TextBox3.Text = linea.Cells(2).Value 'suc
                TextBox4.Text = linea.Cells(3).Value 'vendedora
                TextBox5.Text = linea.Cells(4).Value 'No_Nota
                TextBox6.Text = linea.Cells(5).Value 'cantidad dec 
                TextBox7.Text = linea.Cells(6).Value 'producto 
                TextBox8.Text = linea.Cells(7).Value ' precio uni dec
                TextBox9.Text = linea.Cells(8).Value ' total dec
                TextBox10.Text = linea.Cells(9).Value 'fecha
                TextBox11.Text = linea.Cells(10).Value 'hora
                TextBox12.Text = linea.Cells(11).Value 'suc
                TextBox13.Text = linea.Cells(12).Value 'vendedora
                TextBox14.Text = linea.Cells(13).Value 'nombre
                TextBox15.Text = linea.Cells(14).Value 'cantidad dec 
                TextBox16.Text = linea.Cells(15).Value 'producto 
                TextBox17.Text = linea.Cells(16).Value ' precio uni dec
                TextBox18.Text = linea.Cells(17).Value ' total dec
                TextBox19.Text = linea.Cells(18).Value 'producto 
                TextBox20.Text = linea.Cells(20).Value ' precio uni dec


                Dim cmd1 As New OleDbCommand
                Dim r As Integer

                cmd1 = New OleDbCommand("INSERT INTO NotasPedidos_Alfredo(Fecha,Hora,Sucursal,Vendedora,No_Nota,Cliente,Teléfono,Cantidad,Medida,Relleno,Diseño,Observaciones,Texto,Precio,Entrega,Hora_Entrega,Formato,Domicilio_SiNo,Abono,Precio_fijo)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & CDec(TextBox8.Text) & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & CDec(TextBox14.Text) & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & CDec(TextBox19.Text) & "','" & TextBox20.Text & "')", conexion19)
                conexion19.Open()
                r = cmd1.ExecuteNonQuery
                conexion19.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion19.Close()

        End Try





        Try
            Dim Adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from NotasPedidos_Alfredo where Entrega='" & DateTimePicker1.Value & "'")
            Adaptador1 = New OleDbDataAdapter(buscar1, conexion14)
            tabla1 = New DataTable
            Adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1


            Dim linea As DataGridViewRow
            For Each linea In DataGridView2.Rows


                'se buscan las notas de la sucursal, se insertan en Lulu y al final de ahi se consultan
                'FALTAN LOS CAMPOS DEL INSERT INTO, Y LOS TEXT BOX QUE SEAN DECIMALES
                TextBox1.Text = linea.Cells(0).Value 'fecha
                TextBox2.Text = linea.Cells(1).Value 'hora
                TextBox3.Text = linea.Cells(2).Value 'suc
                TextBox4.Text = linea.Cells(3).Value 'vendedora
                TextBox5.Text = linea.Cells(4).Value 'No_Nota
                TextBox6.Text = linea.Cells(5).Value 'cantidad dec 
                TextBox7.Text = linea.Cells(6).Value 'producto 
                TextBox8.Text = linea.Cells(7).Value ' precio uni dec
                TextBox9.Text = linea.Cells(8).Value ' total dec
                TextBox10.Text = linea.Cells(9).Value 'fecha
                TextBox11.Text = linea.Cells(10).Value 'hora
                TextBox12.Text = linea.Cells(11).Value 'suc
                TextBox13.Text = linea.Cells(12).Value 'vendedora
                TextBox14.Text = linea.Cells(13).Value 'nombre
                TextBox15.Text = linea.Cells(14).Value 'cantidad dec 
                TextBox16.Text = linea.Cells(15).Value 'producto 
                TextBox17.Text = linea.Cells(16).Value ' precio uni dec
                TextBox18.Text = linea.Cells(17).Value ' total dec
                TextBox19.Text = linea.Cells(18).Value 'producto 
                TextBox20.Text = linea.Cells(20).Value ' precio uni dec


                Dim cmd1 As New OleDbCommand
                Dim r As Integer

                cmd1 = New OleDbCommand("INSERT INTO NotasPedidos_Alfredo(Fecha,Hora,Sucursal,Vendedora,No_Nota,Cliente,Teléfono,Cantidad,Medida,Relleno,Diseño,Observaciones,Texto,Precio,Entrega,Hora_Entrega,Formato,Domicilio_SiNo,Abono,Precio_fijo)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & CDec(TextBox8.Text) & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & CDec(TextBox14.Text) & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & CDec(TextBox19.Text) & "','" & TextBox20.Text & "')", conexion19)
                conexion19.Open()
                r = cmd1.ExecuteNonQuery
                conexion19.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion19.Close()

        End Try





        Try
            Dim Adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from NotasPedidos_Alfredo where Entrega='" & DateTimePicker1.Value & "'")
            Adaptador1 = New OleDbDataAdapter(buscar1, conexion15)
            tabla1 = New DataTable
            Adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1


            Dim linea As DataGridViewRow
            For Each linea In DataGridView2.Rows


                'se buscan las notas de la sucursal, se insertan en Lulu y al final de ahi se consultan
                'FALTAN LOS CAMPOS DEL INSERT INTO, Y LOS TEXT BOX QUE SEAN DECIMALES
                TextBox1.Text = linea.Cells(0).Value 'fecha
                TextBox2.Text = linea.Cells(1).Value 'hora
                TextBox3.Text = linea.Cells(2).Value 'suc
                TextBox4.Text = linea.Cells(3).Value 'vendedora
                TextBox5.Text = linea.Cells(4).Value 'No_Nota
                TextBox6.Text = linea.Cells(5).Value 'cantidad dec 
                TextBox7.Text = linea.Cells(6).Value 'producto 
                TextBox8.Text = linea.Cells(7).Value ' precio uni dec
                TextBox9.Text = linea.Cells(8).Value ' total dec
                TextBox10.Text = linea.Cells(9).Value 'fecha
                TextBox11.Text = linea.Cells(10).Value 'hora
                TextBox12.Text = linea.Cells(11).Value 'suc
                TextBox13.Text = linea.Cells(12).Value 'vendedora
                TextBox14.Text = linea.Cells(13).Value 'nombre
                TextBox15.Text = linea.Cells(14).Value 'cantidad dec 
                TextBox16.Text = linea.Cells(15).Value 'producto 
                TextBox17.Text = linea.Cells(16).Value ' precio uni dec
                TextBox18.Text = linea.Cells(17).Value ' total dec
                TextBox19.Text = linea.Cells(18).Value 'producto 
                TextBox20.Text = linea.Cells(20).Value ' precio uni dec


                Dim cmd1 As New OleDbCommand
                Dim r As Integer

                cmd1 = New OleDbCommand("INSERT INTO NotasPedidos_Alfredo(Fecha,Hora,Sucursal,Vendedora,No_Nota,Cliente,Teléfono,Cantidad,Medida,Relleno,Diseño,Observaciones,Texto,Precio,Entrega,Hora_Entrega,Formato,Domicilio_SiNo,Abono,Precio_fijo)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & CDec(TextBox8.Text) & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & CDec(TextBox14.Text) & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & CDec(TextBox19.Text) & "','" & TextBox20.Text & "')", conexion19)
                conexion19.Open()
                r = cmd1.ExecuteNonQuery
                conexion19.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion19.Close()

        End Try





        Try
            Dim Adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from NotasPedidos_Alfredo where Entrega='" & DateTimePicker1.Value & "'")
            Adaptador1 = New OleDbDataAdapter(buscar1, conexion16)
            tabla1 = New DataTable
            Adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1


            Dim linea As DataGridViewRow
            For Each linea In DataGridView2.Rows


                'se buscan las notas de la sucursal, se insertan en Lulu y al final de ahi se consultan
                'FALTAN LOS CAMPOS DEL INSERT INTO, Y LOS TEXT BOX QUE SEAN DECIMALES
                TextBox1.Text = linea.Cells(0).Value 'fecha
                TextBox2.Text = linea.Cells(1).Value 'hora
                TextBox3.Text = linea.Cells(2).Value 'suc
                TextBox4.Text = linea.Cells(3).Value 'vendedora
                TextBox5.Text = linea.Cells(4).Value 'No_Nota
                TextBox6.Text = linea.Cells(5).Value 'cantidad dec 
                TextBox7.Text = linea.Cells(6).Value 'producto 
                TextBox8.Text = linea.Cells(7).Value ' precio uni dec
                TextBox9.Text = linea.Cells(8).Value ' total dec
                TextBox10.Text = linea.Cells(9).Value 'fecha
                TextBox11.Text = linea.Cells(10).Value 'hora
                TextBox12.Text = linea.Cells(11).Value 'suc
                TextBox13.Text = linea.Cells(12).Value 'vendedora
                TextBox14.Text = linea.Cells(13).Value 'nombre
                TextBox15.Text = linea.Cells(14).Value 'cantidad dec 
                TextBox16.Text = linea.Cells(15).Value 'producto 
                TextBox17.Text = linea.Cells(16).Value ' precio uni dec
                TextBox18.Text = linea.Cells(17).Value ' total dec
                TextBox19.Text = linea.Cells(18).Value 'producto 
                TextBox20.Text = linea.Cells(20).Value ' precio uni dec


                Dim cmd1 As New OleDbCommand
                Dim r As Integer

                cmd1 = New OleDbCommand("INSERT INTO NotasPedidos_Alfredo(Fecha,Hora,Sucursal,Vendedora,No_Nota,Cliente,Teléfono,Cantidad,Medida,Relleno,Diseño,Observaciones,Texto,Precio,Entrega,Hora_Entrega,Formato,Domicilio_SiNo,Abono,Precio_fijo)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & CDec(TextBox8.Text) & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & CDec(TextBox14.Text) & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & CDec(TextBox19.Text) & "','" & TextBox20.Text & "')", conexion19)
                conexion19.Open()
                r = cmd1.ExecuteNonQuery
                conexion19.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion19.Close()

        End Try




        Try
            Dim Adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from NotasPedidos_Alfredo where Entrega='" & DateTimePicker1.Value & "'")
            Adaptador1 = New OleDbDataAdapter(buscar1, conexion17)
            tabla1 = New DataTable
            Adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1


            Dim linea As DataGridViewRow
            For Each linea In DataGridView2.Rows


                'se buscan las notas de la sucursal, se insertan en Lulu y al final de ahi se consultan
                'FALTAN LOS CAMPOS DEL INSERT INTO, Y LOS TEXT BOX QUE SEAN DECIMALES
                TextBox1.Text = linea.Cells(0).Value 'fecha
                TextBox2.Text = linea.Cells(1).Value 'hora
                TextBox3.Text = linea.Cells(2).Value 'suc
                TextBox4.Text = linea.Cells(3).Value 'vendedora
                TextBox5.Text = linea.Cells(4).Value 'No_Nota
                TextBox6.Text = linea.Cells(5).Value 'cantidad dec 
                TextBox7.Text = linea.Cells(6).Value 'producto 
                TextBox8.Text = linea.Cells(7).Value ' precio uni dec
                TextBox9.Text = linea.Cells(8).Value ' total dec
                TextBox10.Text = linea.Cells(9).Value 'fecha
                TextBox11.Text = linea.Cells(10).Value 'hora
                TextBox12.Text = linea.Cells(11).Value 'suc
                TextBox13.Text = linea.Cells(12).Value 'vendedora
                TextBox14.Text = linea.Cells(13).Value 'nombre
                TextBox15.Text = linea.Cells(14).Value 'cantidad dec 
                TextBox16.Text = linea.Cells(15).Value 'producto 
                TextBox17.Text = linea.Cells(16).Value ' precio uni dec
                TextBox18.Text = linea.Cells(17).Value ' total dec
                TextBox19.Text = linea.Cells(18).Value 'producto 
                TextBox20.Text = linea.Cells(20).Value ' precio uni dec


                Dim cmd1 As New OleDbCommand
                Dim r As Integer

                cmd1 = New OleDbCommand("INSERT INTO NotasPedidos_Alfredo(Fecha,Hora,Sucursal,Vendedora,No_Nota,Cliente,Teléfono,Cantidad,Medida,Relleno,Diseño,Observaciones,Texto,Precio,Entrega,Hora_Entrega,Formato,Domicilio_SiNo,Abono,Precio_fijo)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & CDec(TextBox8.Text) & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & CDec(TextBox14.Text) & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & CDec(TextBox19.Text) & "','" & TextBox20.Text & "')", conexion19)
                conexion19.Open()
                r = cmd1.ExecuteNonQuery
                conexion19.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion19.Close()

        End Try





        Try
            Dim Adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from NotasPedidos_Alfredo where Entrega='" & DateTimePicker1.Value & "'")
            Adaptador1 = New OleDbDataAdapter(buscar1, conexion18)
            tabla1 = New DataTable
            Adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1


            Dim linea As DataGridViewRow
            For Each linea In DataGridView2.Rows


                'se buscan las notas de la sucursal, se insertan en Lulu y al final de ahi se consultan
                'FALTAN LOS CAMPOS DEL INSERT INTO, Y LOS TEXT BOX QUE SEAN DECIMALES
                TextBox1.Text = linea.Cells(0).Value 'fecha
                TextBox2.Text = linea.Cells(1).Value 'hora
                TextBox3.Text = linea.Cells(2).Value 'suc
                TextBox4.Text = linea.Cells(3).Value 'vendedora
                TextBox5.Text = linea.Cells(4).Value 'No_Nota
                TextBox6.Text = linea.Cells(5).Value 'cantidad dec 
                TextBox7.Text = linea.Cells(6).Value 'producto 
                TextBox8.Text = linea.Cells(7).Value ' precio uni dec
                TextBox9.Text = linea.Cells(8).Value ' total dec
                TextBox10.Text = linea.Cells(9).Value 'fecha
                TextBox11.Text = linea.Cells(10).Value 'hora
                TextBox12.Text = linea.Cells(11).Value 'suc
                TextBox13.Text = linea.Cells(12).Value 'vendedora
                TextBox14.Text = linea.Cells(13).Value 'nombre
                TextBox15.Text = linea.Cells(14).Value 'cantidad dec 
                TextBox16.Text = linea.Cells(15).Value 'producto 
                TextBox17.Text = linea.Cells(16).Value ' precio uni dec
                TextBox18.Text = linea.Cells(17).Value ' total dec
                TextBox19.Text = linea.Cells(18).Value 'producto 
                TextBox20.Text = linea.Cells(20).Value ' precio uni dec


                Dim cmd1 As New OleDbCommand
                Dim r As Integer

                cmd1 = New OleDbCommand("INSERT INTO NotasPedidos_Alfredo(Fecha,Hora,Sucursal,Vendedora,No_Nota,Cliente,Teléfono,Cantidad,Medida,Relleno,Diseño,Observaciones,Texto,Precio,Entrega,Hora_Entrega,Formato,Domicilio_SiNo,Abono,Precio_fijo)VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & CDec(TextBox8.Text) & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox13.Text & "','" & CDec(TextBox14.Text) & "','" & TextBox15.Text & "','" & TextBox16.Text & "','" & TextBox17.Text & "','" & TextBox18.Text & "','" & CDec(TextBox19.Text) & "','" & TextBox20.Text & "')", conexion19)
                conexion19.Open()
                r = cmd1.ExecuteNonQuery
                conexion19.Close()

                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""
                TextBox11.Text = ""
                TextBox12.Text = ""
                TextBox13.Text = ""
                TextBox14.Text = ""
                TextBox15.Text = ""
                TextBox16.Text = ""
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
                TextBox20.Text = ""
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
            conexion19.Close()

        End Try






        Dim Adaptador As New OleDbDataAdapter
        Dim tabla As New DataTable
        Dim buscar As String

        buscar = ("select *from NotasPedidos_Alfredo where Entrega='" & DateTimePicker1.Value & "' Order By Sucursal")
        Adaptador = New OleDbDataAdapter(buscar, conexion19)
        tabla = New DataTable
        Adaptador.Fill(tabla)
        DataGridView1.DataSource = tabla
        Dim row As DataGridViewRow
        For Each row In DataGridView1.Rows
            row.Height = 30
        Next






    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim row As DataGridViewRow = DataGridView1.CurrentRow

            TextBox17.Text = row.Cells(2).Value
            TextBox19.Text = row.Cells(3).Value
            TextBox15.Text = row.Cells(4).Value
            TextBox32.Text = row.Cells(5).Value
            TextBox31.Text = row.Cells(6).Value
            TextBox30.Text = row.Cells(7).Value
            TextBox29.Text = row.Cells(8).Value
            TextBox28.Text = row.Cells(9).Value
            TextBox27.Text = row.Cells(10).Value
            TextBox26.Text = row.Cells(12).Value
            TextBox25.Text = row.Cells(11).Value
            TextBox24.Text = row.Cells(17).Value
            TextBox23.Text = row.Cells(14).Value
            TextBox22.Text = row.Cells(15).Value
            TextBox21.Text = row.Cells(16).Value
            TextBox20.Text = row.Cells(13).Value

            TextBox20.Text = "$" & FormatNumber(TextBox20.Text, 2)
        Catch ex As Exception
            Exit Sub
        End Try





    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label43.Text = TimeString
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim i As Integer = 0
        Dim i1 As Integer = 0
        Dim i2 As Integer = 0
        Dim i3 As Integer = 0
        Dim i4 As Integer = 0
        Dim i5 As Integer = 0
        Dim prFont As New Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Point)
        Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
        Dim prFont8 As New Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point)
        Dim prFont2 As New Font("Arial", 6, GraphicsUnit.Point)
        Dim prFont621 As New Font("Arial", 6, FontStyle.Bold, GraphicsUnit.Point)
        Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
        Dim prFont9 As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point)
        Dim prFont6 As New Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point)
        Dim prFont61 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
        Dim prFont62 As New Font("Arial", 8, GraphicsUnit.Point)
        Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
        e.Graphics.DrawString("COMERCIALIZADORA SARÓN SHEKINA S.A. de C.V.", prFont61, Brushes.Black, 65, 10)
        e.Graphics.DrawString("Rosa de Sarón Pastelerías", prFont61, Brushes.Black, 130, 30)
        e.Graphics.DrawString("Departamento de Producción: Notas de Pedido", prFont61, Brushes.Black, 70, 50)

        e.Graphics.DrawString("Sucursal:", prFont62, Brushes.Black, 10, 85)
        e.Graphics.DrawString(TextBox17.Text, prFont3, Brushes.Black, 90, 85)
        e.Graphics.DrawString("No. de Nota:", prFont62, Brushes.Black, 200, 85)
        e.Graphics.DrawString(TextBox15.Text, prFont3, Brushes.Black, 270, 85)
        e.Graphics.DrawString("Vendedor/a:", prFont62, Brushes.Black, 10, 105)
        e.Graphics.DrawString(TextBox19.Text, prFont3, Brushes.Black, 90, 105)
        e.Graphics.DrawString("Cliente:", prFont62, Brushes.Black, 10, 125)
        e.Graphics.DrawString(TextBox32.Text, prFont3, Brushes.Black, 90, 125)
        e.Graphics.DrawString("Teléfono:", prFont62, Brushes.Black, 10, 145)
        e.Graphics.DrawString(TextBox31.Text, prFont3, Brushes.Black, 90, 145)
        e.Graphics.DrawString("Cantidad:", prFont62, Brushes.Black, 10, 180)
        e.Graphics.DrawString(TextBox30.Text, prFont3, Brushes.Black, 80, 180)
        e.Graphics.DrawString("Medida:", prFont62, Brushes.Black, 200, 180)
        e.Graphics.DrawString(TextBox29.Text, prFont3, Brushes.Black, 280, 180)
        e.Graphics.DrawString("Relleno:", prFont62, Brushes.Black, 10, 200)
        e.Graphics.DrawString(TextBox28.Text, prFont3, Brushes.Black, 60, 200)
        e.Graphics.DrawString("Diseño:", prFont62, Brushes.Black, 230, 200)
        e.Graphics.DrawString(TextBox27.Text, prFont3, Brushes.Black, 300, 200)
        e.Graphics.DrawString("Texto:", prFont62, Brushes.Black, 10, 220)
        e.Graphics.DrawString(TextBox26.Text, prFont3, Brushes.Black, 110, 220)
        e.Graphics.DrawString("Observaciones:", prFont62, Brushes.Black, 10, 240)
        e.Graphics.DrawString(TextBox25.Text.Length = 40, prFont3, Brushes.Black, 10, 255)
        e.Graphics.DrawString("A domicilio:", prFont62, Brushes.Black, 10, 600)
        e.Graphics.DrawString(TextBox24.Text, prFont3, Brushes.Black, 90, 600)
        e.Graphics.DrawString("Fecha de entrega:", prFont62, Brushes.Black, 200, 600)
        e.Graphics.DrawString(TextBox23.Text, prFont3, Brushes.Black, 310, 600)
        e.Graphics.DrawString("Hora de entrega:", prFont62, Brushes.Black, 10, 620)
        e.Graphics.DrawString(TextBox22.Text, prFont3, Brushes.Black, 110, 620)
        e.Graphics.DrawString(TextBox21.Text, prFont3, Brushes.Black, 150, 620)

        e.Graphics.DrawString("Costo:", prFont62, Brushes.Black, 10, 670)
        e.Graphics.DrawString(TextBox20.Text, prFont3, Brushes.Black, 70, 670)




        Exit Sub

        e.Graphics.DrawString("Sub-Total:", prFont62, Brushes.Black, 265, 190)
        e.Graphics.DrawString(TextBox26.Text, prFont62, Brushes.Black, 320, 190)


        e.Graphics.DrawString("Total:", prFont62, Brushes.Black, 150, 190)
        e.Graphics.DrawString(TextBox14.Text, prFont62, Brushes.Black, 185, 190)

        e.Graphics.DrawString("Producto:", prFont62, Brushes.Black, 10, 205)
        e.Graphics.DrawString("Precio:", prFont62, Brushes.Black, 115, 205)
        e.Graphics.DrawString("Venta:", prFont62, Brushes.Black, 155, 205)
        e.Graphics.DrawString("Total:", prFont62, Brushes.Black, 185, 205)
        e.Graphics.DrawString("Tasa:", prFont62, Brushes.Black, 245, 205)
        e.Graphics.DrawString("Subtotal:", prFont62, Brushes.Black, 295, 205)
        e.Graphics.DrawString("¿Factura?:", prFont62, Brushes.Black, 395, 205)
        e.Graphics.DrawString("Pago:", prFont62, Brushes.Black, 455, 205)


        While i < DataGridView2.Rows.Count

            e.Graphics.DrawString(DataGridView2.Item(1, i).Value, prFont2, Brushes.Black, 10, i * 12 + 220)
            e.Graphics.DrawString(DataGridView2.Item(2, i).Value, prFont2, Brushes.Black, 120, i * 12 + 220)
            e.Graphics.DrawString(DataGridView2.Item(3, i).Value, prFont2, Brushes.Black, 160, i * 12 + 220)
            e.Graphics.DrawString(DataGridView2.Item(4, i).Value, prFont2, Brushes.Black, 190, i * 12 + 220)
            e.Graphics.DrawString(DataGridView2.Item(8, i).Value, prFont2, Brushes.Black, 250, i * 12 + 220)
            e.Graphics.DrawString(DataGridView2.Item(11, i).Value, prFont2, Brushes.Black, 300, i * 12 + 220)
            e.Graphics.DrawString(DataGridView2.Item(12, i).Value, prFont2, Brushes.Black, 400, i * 12 + 220)
            e.Graphics.DrawString(DataGridView2.Item(13, i).Value, prFont2, Brushes.Black, 460, i * 12 + 220)
            i += 1

        End While


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("No disponible.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
        Exit Sub
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("No hay nada que imprimir.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
            Exit Sub
        End If
        If MsgBox("¿Deseas imprimir el concentrado de notas de pedidos del día de hoy?", MsgBoxStyle.YesNo, "Rosa de Sarón Pastelerías") = MsgBoxResult.Yes Then
            PrintDocument2.Print()

        End If
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim i As Integer = 0
        Dim i1 As Integer = 0
        Dim i2 As Integer = 0
        Dim i3 As Integer = 0
        Dim i4 As Integer = 0
        Dim i5 As Integer = 0
        Dim prFont As New Font("Arial", 14, FontStyle.Bold, GraphicsUnit.Point)
        Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
        Dim prFont8 As New Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point)
        Dim prFont2 As New Font("Arial", 6, GraphicsUnit.Point)
        Dim prFont621 As New Font("Arial", 6, FontStyle.Bold, GraphicsUnit.Point)
        Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
        Dim prFont9 As New Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point)
        Dim prFont6 As New Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point)
        Dim prFont61 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
        Dim prFont62 As New Font("Arial", 8, GraphicsUnit.Point)
        Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
        e.Graphics.DrawString("COMERCIALIZADORA SARÓN SHEKINA S.A. de C.V.", prFont61, Brushes.Black, 250, 10)
        e.Graphics.DrawString("Rosa de Sarón Pastelerías", prFont61, Brushes.Black, 320, 30)
        e.Graphics.DrawString("Departamento de Producción: Notas de Pedido", prFont61, Brushes.Black, 260, 50)
        e.Graphics.DrawString("Concentrado General", prFont6, Brushes.Black, 260, 80)
        e.Graphics.DrawString(DateTimePicker1.Value, prFont6, Brushes.Black, 430, 80)

        e.Graphics.DrawString("Sucursal:", prFont62, Brushes.Black, 10, 110)

        e.Graphics.DrawString("No. Nota", prFont62, Brushes.Black, 100, 110)

        e.Graphics.DrawString("Cantidad", prFont62, Brushes.Black, 180, 110)

        e.Graphics.DrawString("Medida:", prFont62, Brushes.Black, 280, 110)

        e.Graphics.DrawString("Relleno:", prFont62, Brushes.Black, 420, 110)

        e.Graphics.DrawString("Diseño:", prFont62, Brushes.Black, 560, 110)

        e.Graphics.DrawString("Hora:", prFont62, Brushes.Black, 680, 110)

        e.Graphics.DrawString("Precio:", prFont62, Brushes.Black, 750, 110)

        While i < DataGridView1.Rows.Count

            e.Graphics.DrawString(DataGridView1.Item(2, i).Value, prFont2, Brushes.Black, 10, i * 12 + 130)
            e.Graphics.DrawString(DataGridView1.Item(4, i).Value, prFont2, Brushes.Black, 100, i * 12 + 130)
            e.Graphics.DrawString(DataGridView1.Item(7, i).Value, prFont2, Brushes.Black, 180, i * 12 + 130)
            e.Graphics.DrawString(DataGridView1.Item(8, i).Value, prFont2, Brushes.Black, 280, i * 12 + 130)
            e.Graphics.DrawString(DataGridView1.Item(9, i).Value, prFont2, Brushes.Black, 420, i * 12 + 130)
            e.Graphics.DrawString(DataGridView1.Item(10, i).Value, prFont2, Brushes.Black, 560, i * 12 + 130)
            e.Graphics.DrawString(DataGridView1.Item(15, i).Value, prFont2, Brushes.Black, 680, i * 12 + 130)
            e.Graphics.DrawString(DataGridView1.Item(16, i).Value, prFont2, Brushes.Black, 700, i * 12 + 130)
            e.Graphics.DrawString(DataGridView1.Item(20, i).Value, prFont2, Brushes.Black, 750, i * 12 + 130)
            i += 1

        End While
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Shell("C:\Program Files\TeamViewer\TeamViewer.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class