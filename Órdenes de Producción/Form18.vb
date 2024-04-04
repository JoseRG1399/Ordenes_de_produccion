Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms
Public Class Form18
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
    Dim conexion20 As New OleDbConnection
    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
        DateTimePicker1.Value = DateTime.Today
        DateTimePicker2.Value = DateTime.Today
        Button20.Visible = False

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
            conexion18.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\SANTIN.accdb"

        Catch ex As Exception
            MsgBox("Lo siento, algo salió mal.")
        End Try

        Try
            conexion19.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\DISTRIBUCION ROSA DE SARON PASTEL.accdb"
        Catch ex As Exception
            MsgBox("La conexión falló. Favor de Verificar con Sistemas.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
        End Try


        Try
            conexion20.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\SERVER\Users\Public\Documents\DISTRIBUCION ROSA DE SARON PAN.accdb"
        Catch ex As Exception
            MsgBox("La conexión falló. Favor de Verificar con Sistemas.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Button1.Text

        Try
                Dim adaptador As New OleDbDataAdapter
                Dim tabla As New DataTable
                Dim buscar As String

                buscar = ("select *from Distribución ORDER by Precio")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
                adaptador.Fill(tabla)
                DataGridView1.DataSource = tabla

                DataGridView1.Visible = True


            DataGridView1.Columns(1).Width = 200
                DataGridView1.Columns(2).Width = 100
                DataGridView1.Columns(23).Width = 100

                DataGridView1.Columns(23).DefaultCellStyle.Format = "C"

                DataGridView1.Columns(0).Visible = False
                DataGridView1.Columns(1).Visible = True
                DataGridView1.Columns(2).Visible = True
                DataGridView1.Columns(3).Visible = False
                DataGridView1.Columns(4).Visible = False
                DataGridView1.Columns(5).Visible = False
                DataGridView1.Columns(6).Visible = False
                DataGridView1.Columns(7).Visible = False
                DataGridView1.Columns(8).Visible = False
                DataGridView1.Columns(9).Visible = False
                DataGridView1.Columns(10).Visible = False
                DataGridView1.Columns(11).Visible = False
                DataGridView1.Columns(12).Visible = False
                DataGridView1.Columns(13).Visible = False
                DataGridView1.Columns(14).Visible = False
                DataGridView1.Columns(15).Visible = False
                DataGridView1.Columns(16).Visible = False
                DataGridView1.Columns(17).Visible = False
                DataGridView1.Columns(18).Visible = False
                DataGridView1.Columns(19).Visible = False
                DataGridView1.Columns(20).Visible = False
                DataGridView1.Columns(21).Visible = False
                DataGridView1.Columns(22).Visible = False
                DataGridView1.Columns(23).Visible = True
                DataGridView1.Columns(24).Visible = False
                DataGridView1.Columns(25).Visible = False

            PrintDocument1.Print()

        Catch ex As Exception
                MsgBox(ex.Message)
            End Try




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = DateTime.Today

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label3.Text = TimeString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = Button3.Text
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Distribución ORDER by Precio")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla

            DataGridView1.Visible = True


            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(7).Width = 100
            DataGridView1.Columns(23).Width = 100

            DataGridView1.Columns(23).DefaultCellStyle.Format = "C"

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = True
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = True
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False


            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = Button4.Text
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Distribución ORDER by Precio")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla

            DataGridView1.Visible = True


            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(13).Width = 100
            DataGridView1.Columns(23).Width = 100

            DataGridView1.Columns(23).DefaultCellStyle.Format = "C"

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = True
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = True
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False

            PrintDocument1.Print()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = Button5.Text
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Distribución ORDER by Precio")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla

            DataGridView1.Visible = True


            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(14).Width = 100
            DataGridView1.Columns(23).Width = 100

            DataGridView1.Columns(23).DefaultCellStyle.Format = "C"

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = True
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = True
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False

            PrintDocument1.Print()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = Button6.Text
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Distribución ORDER by Precio")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla

            DataGridView1.Visible = True


            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(3).Width = 100
            DataGridView1.Columns(23).Width = 100

            DataGridView1.Columns(23).DefaultCellStyle.Format = "C"

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = True
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = True
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False


            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = Button7.Text
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Distribución ORDER by Precio")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla

            DataGridView1.Visible = True


            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(5).Width = 100
            DataGridView1.Columns(23).Width = 100

            DataGridView1.Columns(23).DefaultCellStyle.Format = "C"

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = True
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = True
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False

            PrintDocument1.Print()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = Button8.Text
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Distribución ORDER by Precio")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla

            DataGridView1.Visible = True


            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(8).Width = 100
            DataGridView1.Columns(23).Width = 100

            DataGridView1.Columns(23).DefaultCellStyle.Format = "C"

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = True
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = True
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False


            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = Button9.Text
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Distribución ORDER by Precio")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla

            DataGridView1.Visible = True


            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(4).Width = 100
            DataGridView1.Columns(23).Width = 100

            DataGridView1.Columns(23).DefaultCellStyle.Format = "C"

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = True
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = True
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False

            PrintDocument1.Print()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = Button10.Text
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Distribución ORDER by Precio")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla

            DataGridView1.Visible = True


            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(12).Width = 100
            DataGridView1.Columns(23).Width = 100

            DataGridView1.Columns(23).DefaultCellStyle.Format = "C"

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = True
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = True
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False


            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = Button11.Text
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Distribución ORDER by Precio")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla

            DataGridView1.Visible = True


            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(9).Width = 100
            DataGridView1.Columns(23).Width = 100

            DataGridView1.Columns(23).DefaultCellStyle.Format = "C"

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = True
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = True
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False


            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = Button12.Text
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Distribución ORDER by Precio")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla

            DataGridView1.Visible = True


            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(10).Width = 100
            DataGridView1.Columns(23).Width = 100

            DataGridView1.Columns(23).DefaultCellStyle.Format = "C"

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = True
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = True
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False


            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = Button13.Text
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Distribución ORDER by Precio")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla

            DataGridView1.Visible = True


            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(11).Width = 100
            DataGridView1.Columns(23).Width = 100

            DataGridView1.Columns(23).DefaultCellStyle.Format = "C"

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = True
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = True
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False

            PrintDocument1.Print()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text = Button14.Text
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Distribución ORDER by Precio")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla

            DataGridView1.Visible = True


            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(16).Width = 100
            DataGridView1.Columns(23).Width = 100

            DataGridView1.Columns(23).DefaultCellStyle.Format = "C"

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = True
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = True
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False

            PrintDocument1.Print()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = Button15.Text
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Distribución ORDER by Precio")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla

            DataGridView1.Visible = True


            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(17).Width = 100
            DataGridView1.Columns(23).Width = 100

            DataGridView1.Columns(23).DefaultCellStyle.Format = "C"

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = True
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = True
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False


            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text = Button16.Text
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Distribución ORDER by Precio")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla

            DataGridView1.Visible = True


            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(15).Width = 100
            DataGridView1.Columns(23).Width = 100

            DataGridView1.Columns(23).DefaultCellStyle.Format = "C"

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = True
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = True
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False


            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = Button17.Text
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Distribución ORDER by Precio")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla

            DataGridView1.Visible = True


            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(18).Width = 100
            DataGridView1.Columns(23).Width = 100

            DataGridView1.Columns(23).DefaultCellStyle.Format = "C"

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = True
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = True
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False

            PrintDocument1.Print()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Text = Button18.Text
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Distribución ORDER by Precio")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla

            DataGridView1.Visible = True


            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(19).Width = 100
            DataGridView1.Columns(23).Width = 100

            DataGridView1.Columns(23).DefaultCellStyle.Format = "C"

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = True
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = True
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False


            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox1.Text = Button19.Text
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Distribución ORDER by Precio")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla

            DataGridView1.Visible = True


            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(20).Width = 100
            DataGridView1.Columns(23).Width = 100

            DataGridView1.Columns(23).DefaultCellStyle.Format = "C"

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = True
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = True
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False


            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If TextBox1.Text = "" Then
            MsgBox("No hay nada que imprimir. Lista vacía.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
            Exit Sub
        End If


        Dim linea As DataGridViewRow
        Dim valor As Double

        For Each linea In DataGridView1.Rows
            valor = valor + linea.Cells(5).Value
        Next
        TextBox2.Text = "$" & FormatNumber(valor, 2)




        PrintDocument1.Print()
        'PrintDocument2.Print()


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        If TextBox1.Text = "Acrópolis" Then



            Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
            PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            e.Graphics.DrawImage(bm, 600, 1050)
            Dim i As Integer = 0
            Dim i1 As Integer = 0
            Dim i11 As Integer = 0
            Dim line As String = Nothing
            Dim myPen = New Pen(Color.Black, 1)
            Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
            Dim prFont2 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
            Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
            Dim prFont9 As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
            Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
            e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 600, 1120) '65
            e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 610, 1130) '75
            e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 600, 1145) '90
            e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 600, 1160) '105
            e.Graphics.DrawString(DateTimePicker2.Value, prFont2, Brushes.Black, 650, 1160) '105
            e.Graphics.DrawString("HOJA DE CHOFER DE SISTEMA.", prFont2, Brushes.Black, 600, 1185) '130
            e.Graphics.DrawString("Sucursal:", prFont2, Brushes.Black, 600, 1200) '145
            e.Graphics.DrawString(TextBox1.Text, prFont9, Brushes.Black, 660, 1200) '145
            e.Graphics.DrawString("Chofer:", prFont2, Brushes.Black, 600, 1220)
            ' e.Graphics.DrawString(TextBox156.Text, prFont9, Brushes.Black, 660, 1220)
            ' e.Graphics.DrawString("ANOTACIONES:", prFont9, Brushes.Black, 600, 185)

            Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows
                If linea.Cells(1).Value = "Concha blanca int." Then
                    linea.Cells(1).Value = "Concha bca. int."
                End If
                If linea.Cells(1).Value = "Minirosquita Janeth" Then
                    linea.Cells(1).Value = "Rosquita Janeth"
                End If
                If linea.Cells(1).Value = "Cuerno mantequilla" Then
                    linea.Cells(1).Value = "Cuerno mante"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria" Then
                    linea.Cells(1).Value = "Panqué de zana"
                End If
                If linea.Cells(1).Value = "Gel. Dominó especial" Then
                    linea.Cells(1).Value = "Gel. Dom. esp."
                End If
                If linea.Cells(1).Value = "Gel. Rompope fruta" Then
                    linea.Cells(1).Value = "Gel. Rompope"
                End If
                If linea.Cells(1).Value = "Leche deslactosada 1l" Then
                    linea.Cells(1).Value = "L. deslac. 1l"
                End If
                If linea.Cells(1).Value = "Pay queso chocolate" Then
                    linea.Cells(1).Value = "P. queso choco"
                End If
                If linea.Cells(1).Value = "Feliz Cumple con base" Then
                    linea.Cells(1).Value = "F.C. base"
                End If
                If linea.Cells(1).Value = "Caja Galletas .250 Kg" Then
                    linea.Cells(1).Value = "C. Galle. .250"
                End If
                If linea.Cells(1).Value = "Panqué de chocolate" Then
                    linea.Cells(1).Value = "Panqué de choco"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria barra" Then
                    linea.Cells(1).Value = "P. zana barra"
                End If
                If linea.Cells(1).Value = "Panqué de chabacano" Then
                    linea.Cells(1).Value = "Panqué chaba"
                End If
                If linea.Cells(1).Value = "Bolsa cafe ame 500gr" Then
                    linea.Cells(1).Value = "B. café a. 500"
                End If
                If linea.Cells(1).Value = "Bolsa cafe des 500gr" Then
                    linea.Cells(1).Value = "B. café d. 500gr"
                End If
                If linea.Cells(1).Value = "Gel. Med. Bombón" Then
                    linea.Cells(1).Value = "G.M. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó" Then
                    linea.Cells(1).Value = "G.M. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó esp." Then
                    linea.Cells(1).Value = "G.M. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Med. Betabel" Then
                    linea.Cells(1).Value = "G.M. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Med. Queso uva" Then
                    linea.Cells(1).Value = "G.M. Queso u"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tricolor" Then
                    linea.Cells(1).Value = "G.M. Tricolor"
                End If
                If linea.Cells(1).Value = "Caja Galletas .5 Kg" Then
                    linea.Cells(1).Value = "C. Galle .5"
                End If
                If linea.Cells(1).Value = "Gel. Med. Agua fruta" Then
                    linea.Cells(1).Value = "G.M. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Med. Rompope" Then
                    linea.Cells(1).Value = "G.M. Romp."
                End If
                If linea.Cells(1).Value = "Panqué elote barra" Then
                    linea.Cells(1).Value = "P. elote barra"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tuti fruti" Then
                    linea.Cells(1).Value = "G.M. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Med. Zanahoria" Then
                    linea.Cells(1).Value = "G.M. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Flores Arándanos" Then
                    linea.Cells(1).Value = "G. Flores A."
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 leches" Then
                    linea.Cells(1).Value = "G.M. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Agua fruta" Then
                    linea.Cells(1).Value = "G.G. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó esp." Then
                    linea.Cells(1).Value = "G.G. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Betabel" Then
                    linea.Cells(1).Value = "G.G. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Tuti fruti" Then
                    linea.Cells(1).Value = "G.G. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Rompope" Then
                    linea.Cells(1).Value = "G.G. Rompope"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 leches" Then
                    linea.Cells(1).Value = "G.G. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Zanahoria" Then
                    linea.Cells(1).Value = "G.G. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 chocolates" Then
                    linea.Cells(1).Value = "G.G. 3 choco"
                End If
                If linea.Cells(1).Value = "Caja Galletas 1 Kg" Then
                    linea.Cells(1).Value = "C. Galle 1"
                End If
                If linea.Cells(1).Value = "Pay queso zarza G." Then
                    linea.Cells(1).Value = "Pay q.zarza G."
                End If
                If linea.Cells(1).Value = "Gel. Vino tinto 22 cm" Then
                    linea.Cells(1).Value = "Gel. vino 22cm"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó" Then
                    linea.Cells(1).Value = "G.G. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Bombón" Then
                    linea.Cells(1).Value = "G.G. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 chocolates" Then
                    linea.Cells(1).Value = "G.M. 3 choco"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Queso uva" Then
                    linea.Cells(1).Value = "G.G. Queso u"
                End If
                If linea.Cells(1).Value = "Pay queso frutas G." Then
                    linea.Cells(1).Value = "Pay q.frutas G."
                End If
                If linea.Cells(1).Value = "Pay queso fresa G." Then
                    linea.Cells(1).Value = "Pay q.fresa G."
                End If
            Next


            'dibujar linea
            e.Graphics.DrawLine(myPen, 0, 21, 770, 21) '+12
            e.Graphics.DrawLine(myPen, 0, 33, 770, 33)
            e.Graphics.DrawLine(myPen, 0, 45, 770, 45)
            e.Graphics.DrawLine(myPen, 0, 57, 770, 57)
            e.Graphics.DrawLine(myPen, 0, 69, 770, 69)
            e.Graphics.DrawLine(myPen, 0, 81, 770, 81)
            e.Graphics.DrawLine(myPen, 0, 93, 770, 93)
            e.Graphics.DrawLine(myPen, 0, 105, 770, 105)
            e.Graphics.DrawLine(myPen, 0, 117, 770, 117)
            e.Graphics.DrawLine(myPen, 0, 129, 770, 129)
            e.Graphics.DrawLine(myPen, 0, 141, 770, 141)
            e.Graphics.DrawLine(myPen, 0, 153, 770, 153)
            e.Graphics.DrawLine(myPen, 0, 165, 770, 165)
            e.Graphics.DrawLine(myPen, 0, 177, 770, 177)
            e.Graphics.DrawLine(myPen, 0, 189, 770, 189)
            e.Graphics.DrawLine(myPen, 0, 201, 770, 201)
            e.Graphics.DrawLine(myPen, 0, 213, 770, 213)
            e.Graphics.DrawLine(myPen, 0, 225, 770, 225)
            e.Graphics.DrawLine(myPen, 0, 237, 770, 237)
            e.Graphics.DrawLine(myPen, 0, 249, 770, 249)
            e.Graphics.DrawLine(myPen, 0, 261, 770, 261)
            e.Graphics.DrawLine(myPen, 0, 273, 770, 273)
            e.Graphics.DrawLine(myPen, 0, 285, 770, 285) 'hasta 31
            e.Graphics.DrawLine(myPen, 0, 297, 770, 297)
            e.Graphics.DrawLine(myPen, 0, 309, 770, 309)
            e.Graphics.DrawLine(myPen, 0, 321, 770, 321)
            e.Graphics.DrawLine(myPen, 0, 333, 770, 333)
            e.Graphics.DrawLine(myPen, 0, 345, 770, 345)
            e.Graphics.DrawLine(myPen, 0, 357, 770, 357)
            e.Graphics.DrawLine(myPen, 0, 369, 770, 369)
            e.Graphics.DrawLine(myPen, 0, 381, 770, 381)


            'aqui inician livbres las lineas
            e.Graphics.DrawLine(myPen, 0, 393, 560, 393)
            e.Graphics.DrawLine(myPen, 0, 405, 560, 405)
            e.Graphics.DrawLine(myPen, 0, 417, 560, 417)
            e.Graphics.DrawLine(myPen, 0, 429, 560, 429)
            e.Graphics.DrawLine(myPen, 0, 441, 560, 441)
            e.Graphics.DrawLine(myPen, 0, 453, 560, 453)
            e.Graphics.DrawLine(myPen, 0, 465, 560, 465)
            e.Graphics.DrawLine(myPen, 0, 477, 560, 477)
            e.Graphics.DrawLine(myPen, 0, 489, 560, 489)
            e.Graphics.DrawLine(myPen, 0, 501, 560, 501)
            e.Graphics.DrawLine(myPen, 0, 513, 560, 513)
            e.Graphics.DrawLine(myPen, 0, 525, 560, 525)
            e.Graphics.DrawLine(myPen, 0, 537, 560, 537)
            e.Graphics.DrawLine(myPen, 0, 549, 560, 549)
            e.Graphics.DrawLine(myPen, 0, 561, 560, 561)
            e.Graphics.DrawLine(myPen, 0, 573, 560, 573)
            e.Graphics.DrawLine(myPen, 0, 585, 560, 585)
            e.Graphics.DrawLine(myPen, 0, 597, 560, 597)
            e.Graphics.DrawLine(myPen, 0, 609, 560, 609)
            e.Graphics.DrawLine(myPen, 0, 621, 560, 621)
            e.Graphics.DrawLine(myPen, 0, 633, 560, 633)
            e.Graphics.DrawLine(myPen, 0, 645, 560, 645)
            e.Graphics.DrawLine(myPen, 0, 657, 560, 657)
            e.Graphics.DrawLine(myPen, 0, 669, 560, 669)
            e.Graphics.DrawLine(myPen, 0, 681, 560, 681)
            e.Graphics.DrawLine(myPen, 0, 693, 560, 693)
            e.Graphics.DrawLine(myPen, 0, 705, 560, 705)
            e.Graphics.DrawLine(myPen, 0, 717, 560, 717)
            e.Graphics.DrawLine(myPen, 0, 729, 560, 729)
            e.Graphics.DrawLine(myPen, 0, 741, 560, 741)
            e.Graphics.DrawLine(myPen, 0, 753, 560, 753)
            e.Graphics.DrawLine(myPen, 0, 765, 560, 765)
            e.Graphics.DrawLine(myPen, 0, 777, 560, 777)
            e.Graphics.DrawLine(myPen, 0, 789, 560, 789)
            e.Graphics.DrawLine(myPen, 0, 801, 560, 801)
            e.Graphics.DrawLine(myPen, 0, 813, 560, 813)
            e.Graphics.DrawLine(myPen, 0, 825, 560, 825)
            e.Graphics.DrawLine(myPen, 0, 837, 560, 837)
            e.Graphics.DrawLine(myPen, 0, 849, 560, 849)
            e.Graphics.DrawLine(myPen, 0, 861, 560, 861)
            e.Graphics.DrawLine(myPen, 0, 873, 560, 873)
            e.Graphics.DrawLine(myPen, 0, 885, 560, 885)
            e.Graphics.DrawLine(myPen, 0, 897, 560, 897)
            e.Graphics.DrawLine(myPen, 0, 909, 560, 909)
            e.Graphics.DrawLine(myPen, 0, 921, 560, 921)
            e.Graphics.DrawLine(myPen, 0, 933, 560, 933)
            e.Graphics.DrawLine(myPen, 0, 945, 560, 945)
            e.Graphics.DrawLine(myPen, 0, 957, 560, 957)
            e.Graphics.DrawLine(myPen, 0, 969, 560, 969)
            e.Graphics.DrawLine(myPen, 0, 981, 560, 981)
            e.Graphics.DrawLine(myPen, 0, 993, 560, 993)
            e.Graphics.DrawLine(myPen, 0, 1005, 560, 1005)
            e.Graphics.DrawLine(myPen, 0, 1017, 560, 1017)
            e.Graphics.DrawLine(myPen, 0, 1029, 560, 1029)
            e.Graphics.DrawLine(myPen, 0, 1041, 560, 1041)
            e.Graphics.DrawLine(myPen, 0, 1053, 560, 1053)
            e.Graphics.DrawLine(myPen, 0, 1065, 560, 1065)
            e.Graphics.DrawLine(myPen, 0, 1077, 560, 1077)
            e.Graphics.DrawLine(myPen, 0, 1089, 560, 1089)
            e.Graphics.DrawLine(myPen, 0, 1101, 560, 1101)
            e.Graphics.DrawLine(myPen, 0, 1113, 560, 1113)
            e.Graphics.DrawLine(myPen, 0, 1125, 560, 1125)
            e.Graphics.DrawLine(myPen, 0, 1137, 560, 1137)
            e.Graphics.DrawLine(myPen, 0, 1149, 560, 1149)
            e.Graphics.DrawLine(myPen, 0, 1161, 560, 1161)
            e.Graphics.DrawLine(myPen, 0, 1173, 560, 1173)
            e.Graphics.DrawLine(myPen, 0, 1185, 560, 1185)
            e.Graphics.DrawLine(myPen, 0, 1197, 560, 1197)
            e.Graphics.DrawLine(myPen, 0, 1209, 560, 1209)
            e.Graphics.DrawLine(myPen, 0, 1221, 560, 1221)
            e.Graphics.DrawLine(myPen, 0, 1233, 560, 1233)
            e.Graphics.DrawLine(myPen, 0, 1245, 560, 1245)
            e.Graphics.DrawLine(myPen, 0, 1257, 560, 1257)
            e.Graphics.DrawLine(myPen, 0, 1269, 560, 1269)

            e.Graphics.DrawLine(myPen, 0, 1281, 560, 1281)
            e.Graphics.DrawLine(myPen, 0, 1293, 560, 1293)
            e.Graphics.DrawLine(myPen, 0, 1305, 560, 1305)
            e.Graphics.DrawLine(myPen, 0, 1317, 560, 1317)
            e.Graphics.DrawLine(myPen, 0, 1329, 560, 1329)
            e.Graphics.DrawLine(myPen, 0, 1341, 560, 1341)






            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 0, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 100, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 135, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 190, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 290, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 325, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 380, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 480, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 515, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 570, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 670, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 705, 6)


            If DataGridView1.Rows.Count > 180 Then

                While i < 110

                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 0, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(2, i).Value, prFont1, Brushes.Black, 110, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 140, i * 12 + 20)
                    i += 1


                End While


                While i < 220
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 190, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(2, i).Value, prFont1, Brushes.Black, 300, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 330, i * 12 - 1300)
                    i += 1


                End While

                While i < 330
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 380, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(2, i).Value, prFont1, Brushes.Black, 490, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 520, i * 12 - 2620)
                    i += 1


                End While

                While i < DataGridView1.Rows.Count
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 570, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(2, i).Value, prFont1, Brushes.Black, 680, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 710, i * 12 - 3940)
                    i += 1


                End While


            End If

        End If


        If TextBox1.Text = "5 de Mayo" Then





            Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
            PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            e.Graphics.DrawImage(bm, 600, 1050)
            Dim i As Integer = 0
            Dim i1 As Integer = 0
            Dim i11 As Integer = 0
            Dim line As String = Nothing
            Dim myPen = New Pen(Color.Black, 1)
            Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
            Dim prFont2 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
            Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
            Dim prFont9 As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
            Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
            e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 600, 1120) '65
            e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 610, 1130) '75
            e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 600, 1145) '90
            e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 600, 1160) '105
            e.Graphics.DrawString(DateTimePicker2.Value, prFont2, Brushes.Black, 650, 1160) '105
            e.Graphics.DrawString("HOJA DE CHOFER DE SISTEMA.", prFont2, Brushes.Black, 600, 1185) '130
            e.Graphics.DrawString("Sucursal:", prFont2, Brushes.Black, 600, 1200) '145
            e.Graphics.DrawString(TextBox1.Text, prFont9, Brushes.Black, 660, 1200) '145
            e.Graphics.DrawString("Chofer:", prFont2, Brushes.Black, 600, 1220)
            ' e.Graphics.DrawString(TextBox156.Text, prFont9, Brushes.Black, 660, 1220)
            ' e.Graphics.DrawString("ANOTACIONES:", prFont9, Brushes.Black, 600, 185)

            Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows
                If linea.Cells(1).Value = "Concha blanca int." Then
                    linea.Cells(1).Value = "Concha bca. int."
                End If
                If linea.Cells(1).Value = "Minirosquita Janeth" Then
                    linea.Cells(1).Value = "Rosquita Janeth"
                End If
                If linea.Cells(1).Value = "Cuerno mantequilla" Then
                    linea.Cells(1).Value = "Cuerno mante"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria" Then
                    linea.Cells(1).Value = "Panqué de zana"
                End If
                If linea.Cells(1).Value = "Gel. Dominó especial" Then
                    linea.Cells(1).Value = "Gel. Dom. esp."
                End If
                If linea.Cells(1).Value = "Gel. Rompope fruta" Then
                    linea.Cells(1).Value = "Gel. Rompope"
                End If
                If linea.Cells(1).Value = "Leche deslactosada 1l" Then
                    linea.Cells(1).Value = "L. deslac. 1l"
                End If
                If linea.Cells(1).Value = "Pay queso chocolate" Then
                    linea.Cells(1).Value = "P. queso choco"
                End If
                If linea.Cells(1).Value = "Feliz Cumple con base" Then
                    linea.Cells(1).Value = "F.C. base"
                End If
                If linea.Cells(1).Value = "Caja Galletas .250 Kg" Then
                    linea.Cells(1).Value = "C. Galle. .250"
                End If
                If linea.Cells(1).Value = "Panqué de chocolate" Then
                    linea.Cells(1).Value = "Panqué de choco"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria barra" Then
                    linea.Cells(1).Value = "P. zana barra"
                End If
                If linea.Cells(1).Value = "Panqué de chabacano" Then
                    linea.Cells(1).Value = "Panqué chaba"
                End If
                If linea.Cells(1).Value = "Bolsa cafe ame 500gr" Then
                    linea.Cells(1).Value = "B. café a. 500"
                End If
                If linea.Cells(1).Value = "Bolsa cafe des 500gr" Then
                    linea.Cells(1).Value = "B. café d. 500gr"
                End If
                If linea.Cells(1).Value = "Gel. Med. Bombón" Then
                    linea.Cells(1).Value = "G.M. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó" Then
                    linea.Cells(1).Value = "G.M. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó esp." Then
                    linea.Cells(1).Value = "G.M. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Med. Betabel" Then
                    linea.Cells(1).Value = "G.M. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Med. Queso uva" Then
                    linea.Cells(1).Value = "G.M. Queso u"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tricolor" Then
                    linea.Cells(1).Value = "G.M. Tricolor"
                End If
                If linea.Cells(1).Value = "Caja Galletas .5 Kg" Then
                    linea.Cells(1).Value = "C. Galle .5"
                End If
                If linea.Cells(1).Value = "Gel. Med. Agua fruta" Then
                    linea.Cells(1).Value = "G.M. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Med. Rompope" Then
                    linea.Cells(1).Value = "G.M. Romp."
                End If
                If linea.Cells(1).Value = "Panqué elote barra" Then
                    linea.Cells(1).Value = "P. elote barra"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tuti fruti" Then
                    linea.Cells(1).Value = "G.M. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Med. Zanahoria" Then
                    linea.Cells(1).Value = "G.M. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Flores Arándanos" Then
                    linea.Cells(1).Value = "G. Flores A."
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 leches" Then
                    linea.Cells(1).Value = "G.M. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Agua fruta" Then
                    linea.Cells(1).Value = "G.G. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó esp." Then
                    linea.Cells(1).Value = "G.G. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Betabel" Then
                    linea.Cells(1).Value = "G.G. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Tuti fruti" Then
                    linea.Cells(1).Value = "G.G. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Rompope" Then
                    linea.Cells(1).Value = "G.G. Rompope"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 leches" Then
                    linea.Cells(1).Value = "G.G. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Zanahoria" Then
                    linea.Cells(1).Value = "G.G. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 chocolates" Then
                    linea.Cells(1).Value = "G.G. 3 choco"
                End If
                If linea.Cells(1).Value = "Caja Galletas 1 Kg" Then
                    linea.Cells(1).Value = "C. Galle 1"
                End If
                If linea.Cells(1).Value = "Pay queso zarza G." Then
                    linea.Cells(1).Value = "Pay q.zarza G."
                End If
                If linea.Cells(1).Value = "Gel. Vino tinto 22 cm" Then
                    linea.Cells(1).Value = "Gel. vino 22cm"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó" Then
                    linea.Cells(1).Value = "G.G. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Bombón" Then
                    linea.Cells(1).Value = "G.G. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 chocolates" Then
                    linea.Cells(1).Value = "G.M. 3 choco"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Queso uva" Then
                    linea.Cells(1).Value = "G.G. Queso u"
                End If
                If linea.Cells(1).Value = "Pay queso frutas G." Then
                    linea.Cells(1).Value = "Pay q.frutas G."
                End If
                If linea.Cells(1).Value = "Pay queso fresa G." Then
                    linea.Cells(1).Value = "Pay q.fresa G."
                End If
            Next


            'dibujar linea
            'dibujar linea
            e.Graphics.DrawLine(myPen, 0, 21, 770, 21) '+12
            e.Graphics.DrawLine(myPen, 0, 33, 770, 33)
            e.Graphics.DrawLine(myPen, 0, 45, 770, 45)
            e.Graphics.DrawLine(myPen, 0, 57, 770, 57)
            e.Graphics.DrawLine(myPen, 0, 69, 770, 69)
            e.Graphics.DrawLine(myPen, 0, 81, 770, 81)
            e.Graphics.DrawLine(myPen, 0, 93, 770, 93)
            e.Graphics.DrawLine(myPen, 0, 105, 770, 105)
            e.Graphics.DrawLine(myPen, 0, 117, 770, 117)
            e.Graphics.DrawLine(myPen, 0, 129, 770, 129)
            e.Graphics.DrawLine(myPen, 0, 141, 770, 141)
            e.Graphics.DrawLine(myPen, 0, 153, 770, 153)
            e.Graphics.DrawLine(myPen, 0, 165, 770, 165)
            e.Graphics.DrawLine(myPen, 0, 177, 770, 177)
            e.Graphics.DrawLine(myPen, 0, 189, 770, 189)
            e.Graphics.DrawLine(myPen, 0, 201, 770, 201)
            e.Graphics.DrawLine(myPen, 0, 213, 770, 213)
            e.Graphics.DrawLine(myPen, 0, 225, 770, 225)
            e.Graphics.DrawLine(myPen, 0, 237, 770, 237)
            e.Graphics.DrawLine(myPen, 0, 249, 770, 249)
            e.Graphics.DrawLine(myPen, 0, 261, 770, 261)
            e.Graphics.DrawLine(myPen, 0, 273, 770, 273)
            e.Graphics.DrawLine(myPen, 0, 285, 770, 285) 'hasta 31
            e.Graphics.DrawLine(myPen, 0, 297, 770, 297)
            e.Graphics.DrawLine(myPen, 0, 309, 770, 309)
            e.Graphics.DrawLine(myPen, 0, 321, 770, 321)
            e.Graphics.DrawLine(myPen, 0, 333, 770, 333)
            e.Graphics.DrawLine(myPen, 0, 345, 770, 345)
            e.Graphics.DrawLine(myPen, 0, 357, 770, 357)
            e.Graphics.DrawLine(myPen, 0, 369, 770, 369)
            e.Graphics.DrawLine(myPen, 0, 381, 770, 381)


            'aqui inician livbres las lineas
            e.Graphics.DrawLine(myPen, 0, 393, 560, 393)
            e.Graphics.DrawLine(myPen, 0, 405, 560, 405)
            e.Graphics.DrawLine(myPen, 0, 417, 560, 417)
            e.Graphics.DrawLine(myPen, 0, 429, 560, 429)
            e.Graphics.DrawLine(myPen, 0, 441, 560, 441)
            e.Graphics.DrawLine(myPen, 0, 453, 560, 453)
            e.Graphics.DrawLine(myPen, 0, 465, 560, 465)
            e.Graphics.DrawLine(myPen, 0, 477, 560, 477)
            e.Graphics.DrawLine(myPen, 0, 489, 560, 489)
            e.Graphics.DrawLine(myPen, 0, 501, 560, 501)
            e.Graphics.DrawLine(myPen, 0, 513, 560, 513)
            e.Graphics.DrawLine(myPen, 0, 525, 560, 525)
            e.Graphics.DrawLine(myPen, 0, 537, 560, 537)
            e.Graphics.DrawLine(myPen, 0, 549, 560, 549)
            e.Graphics.DrawLine(myPen, 0, 561, 560, 561)
            e.Graphics.DrawLine(myPen, 0, 573, 560, 573)
            e.Graphics.DrawLine(myPen, 0, 585, 560, 585)
            e.Graphics.DrawLine(myPen, 0, 597, 560, 597)
            e.Graphics.DrawLine(myPen, 0, 609, 560, 609)
            e.Graphics.DrawLine(myPen, 0, 621, 560, 621)
            e.Graphics.DrawLine(myPen, 0, 633, 560, 633)
            e.Graphics.DrawLine(myPen, 0, 645, 560, 645)
            e.Graphics.DrawLine(myPen, 0, 657, 560, 657)
            e.Graphics.DrawLine(myPen, 0, 669, 560, 669)
            e.Graphics.DrawLine(myPen, 0, 681, 560, 681)
            e.Graphics.DrawLine(myPen, 0, 693, 560, 693)
            e.Graphics.DrawLine(myPen, 0, 705, 560, 705)
            e.Graphics.DrawLine(myPen, 0, 717, 560, 717)
            e.Graphics.DrawLine(myPen, 0, 729, 560, 729)
            e.Graphics.DrawLine(myPen, 0, 741, 560, 741)
            e.Graphics.DrawLine(myPen, 0, 753, 560, 753)
            e.Graphics.DrawLine(myPen, 0, 765, 560, 765)
            e.Graphics.DrawLine(myPen, 0, 777, 560, 777)
            e.Graphics.DrawLine(myPen, 0, 789, 560, 789)
            e.Graphics.DrawLine(myPen, 0, 801, 560, 801)
            e.Graphics.DrawLine(myPen, 0, 813, 560, 813)
            e.Graphics.DrawLine(myPen, 0, 825, 560, 825)
            e.Graphics.DrawLine(myPen, 0, 837, 560, 837)
            e.Graphics.DrawLine(myPen, 0, 849, 560, 849)
            e.Graphics.DrawLine(myPen, 0, 861, 560, 861)
            e.Graphics.DrawLine(myPen, 0, 873, 560, 873)
            e.Graphics.DrawLine(myPen, 0, 885, 560, 885)
            e.Graphics.DrawLine(myPen, 0, 897, 560, 897)
            e.Graphics.DrawLine(myPen, 0, 909, 560, 909)
            e.Graphics.DrawLine(myPen, 0, 921, 560, 921)
            e.Graphics.DrawLine(myPen, 0, 933, 560, 933)
            e.Graphics.DrawLine(myPen, 0, 945, 560, 945)
            e.Graphics.DrawLine(myPen, 0, 957, 560, 957)
            e.Graphics.DrawLine(myPen, 0, 969, 560, 969)
            e.Graphics.DrawLine(myPen, 0, 981, 560, 981)
            e.Graphics.DrawLine(myPen, 0, 993, 560, 993)
            e.Graphics.DrawLine(myPen, 0, 1005, 560, 1005)
            e.Graphics.DrawLine(myPen, 0, 1017, 560, 1017)
            e.Graphics.DrawLine(myPen, 0, 1029, 560, 1029)
            e.Graphics.DrawLine(myPen, 0, 1041, 560, 1041)
            e.Graphics.DrawLine(myPen, 0, 1053, 560, 1053)
            e.Graphics.DrawLine(myPen, 0, 1065, 560, 1065)
            e.Graphics.DrawLine(myPen, 0, 1077, 560, 1077)
            e.Graphics.DrawLine(myPen, 0, 1089, 560, 1089)
            e.Graphics.DrawLine(myPen, 0, 1101, 560, 1101)
            e.Graphics.DrawLine(myPen, 0, 1113, 560, 1113)
            e.Graphics.DrawLine(myPen, 0, 1125, 560, 1125)
            e.Graphics.DrawLine(myPen, 0, 1137, 560, 1137)
            e.Graphics.DrawLine(myPen, 0, 1149, 560, 1149)
            e.Graphics.DrawLine(myPen, 0, 1161, 560, 1161)
            e.Graphics.DrawLine(myPen, 0, 1173, 560, 1173)
            e.Graphics.DrawLine(myPen, 0, 1185, 560, 1185)
            e.Graphics.DrawLine(myPen, 0, 1197, 560, 1197)
            e.Graphics.DrawLine(myPen, 0, 1209, 560, 1209)
            e.Graphics.DrawLine(myPen, 0, 1221, 560, 1221)
            e.Graphics.DrawLine(myPen, 0, 1233, 560, 1233)
            e.Graphics.DrawLine(myPen, 0, 1245, 560, 1245)
            e.Graphics.DrawLine(myPen, 0, 1257, 560, 1257)
            e.Graphics.DrawLine(myPen, 0, 1269, 560, 1269)

            e.Graphics.DrawLine(myPen, 0, 1281, 560, 1281)
            e.Graphics.DrawLine(myPen, 0, 1293, 560, 1293)
            e.Graphics.DrawLine(myPen, 0, 1305, 560, 1305)
            e.Graphics.DrawLine(myPen, 0, 1317, 560, 1317)
            e.Graphics.DrawLine(myPen, 0, 1329, 560, 1329)
            e.Graphics.DrawLine(myPen, 0, 1341, 560, 1341)



            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 0, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 100, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 135, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 190, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 290, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 325, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 380, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 480, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 515, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 570, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 670, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 705, 6)


            If DataGridView1.Rows.Count > 180 Then

                While i < 110

                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 0, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(16, i).Value, prFont1, Brushes.Black, 110, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 140, i * 12 + 20)
                    i += 1


                End While


                While i < 220
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 190, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(16, i).Value, prFont1, Brushes.Black, 300, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 330, i * 12 - 1300)
                    i += 1


                End While

                While i < 330
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 380, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(16, i).Value, prFont1, Brushes.Black, 490, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 520, i * 12 - 2620)
                    i += 1


                End While

                While i < DataGridView1.Rows.Count
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 570, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(16, i).Value, prFont1, Brushes.Black, 680, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 710, i * 12 - 3940)
                    i += 1


                End While


            End If

        End If


        If TextBox1.Text = "Xona" Then



            Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
            PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            e.Graphics.DrawImage(bm, 600, 1050)
            Dim i As Integer = 0
            Dim i1 As Integer = 0
            Dim i11 As Integer = 0
            Dim line As String = Nothing
            Dim myPen = New Pen(Color.Black, 1)
            Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
            Dim prFont2 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
            Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
            Dim prFont9 As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
            Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
            e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 600, 1120) '65
            e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 610, 1130) '75
            e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 600, 1145) '90
            e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 600, 1160) '105
            e.Graphics.DrawString(DateTimePicker2.Value, prFont2, Brushes.Black, 650, 1160) '105
            e.Graphics.DrawString("HOJA DE CHOFER DE SISTEMA.", prFont2, Brushes.Black, 600, 1185) '130
            e.Graphics.DrawString("Sucursal:", prFont2, Brushes.Black, 600, 1200) '145
            e.Graphics.DrawString(TextBox1.Text, prFont9, Brushes.Black, 660, 1200) '145
            e.Graphics.DrawString("Chofer:", prFont2, Brushes.Black, 600, 1220)
            ' e.Graphics.DrawString(TextBox156.Text, prFont9, Brushes.Black, 660, 1220)
            ' e.Graphics.DrawString("ANOTACIONES:", prFont9, Brushes.Black, 600, 185)

            Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows
                If linea.Cells(1).Value = "Concha blanca int." Then
                    linea.Cells(1).Value = "Concha bca. int."
                End If
                If linea.Cells(1).Value = "Minirosquita Janeth" Then
                    linea.Cells(1).Value = "Rosquita Janeth"
                End If
                If linea.Cells(1).Value = "Cuerno mantequilla" Then
                    linea.Cells(1).Value = "Cuerno mante"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria" Then
                    linea.Cells(1).Value = "Panqué de zana"
                End If
                If linea.Cells(1).Value = "Gel. Dominó especial" Then
                    linea.Cells(1).Value = "Gel. Dom. esp."
                End If
                If linea.Cells(1).Value = "Gel. Rompope fruta" Then
                    linea.Cells(1).Value = "Gel. Rompope"
                End If
                If linea.Cells(1).Value = "Leche deslactosada 1l" Then
                    linea.Cells(1).Value = "L. deslac. 1l"
                End If
                If linea.Cells(1).Value = "Pay queso chocolate" Then
                    linea.Cells(1).Value = "P. queso choco"
                End If
                If linea.Cells(1).Value = "Feliz Cumple con base" Then
                    linea.Cells(1).Value = "F.C. base"
                End If
                If linea.Cells(1).Value = "Caja Galletas .250 Kg" Then
                    linea.Cells(1).Value = "C. Galle. .250"
                End If
                If linea.Cells(1).Value = "Panqué de chocolate" Then
                    linea.Cells(1).Value = "Panqué de choco"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria barra" Then
                    linea.Cells(1).Value = "P. zana barra"
                End If
                If linea.Cells(1).Value = "Panqué de chabacano" Then
                    linea.Cells(1).Value = "Panqué chaba"
                End If
                If linea.Cells(1).Value = "Bolsa cafe ame 500gr" Then
                    linea.Cells(1).Value = "B. café a. 500"
                End If
                If linea.Cells(1).Value = "Bolsa cafe des 500gr" Then
                    linea.Cells(1).Value = "B. café d. 500gr"
                End If
                If linea.Cells(1).Value = "Gel. Med. Bombón" Then
                    linea.Cells(1).Value = "G.M. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó" Then
                    linea.Cells(1).Value = "G.M. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó esp." Then
                    linea.Cells(1).Value = "G.M. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Med. Betabel" Then
                    linea.Cells(1).Value = "G.M. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Med. Queso uva" Then
                    linea.Cells(1).Value = "G.M. Queso u"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tricolor" Then
                    linea.Cells(1).Value = "G.M. Tricolor"
                End If
                If linea.Cells(1).Value = "Caja Galletas .5 Kg" Then
                    linea.Cells(1).Value = "C. Galle .5"
                End If
                If linea.Cells(1).Value = "Gel. Med. Agua fruta" Then
                    linea.Cells(1).Value = "G.M. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Med. Rompope" Then
                    linea.Cells(1).Value = "G.M. Romp."
                End If
                If linea.Cells(1).Value = "Panqué elote barra" Then
                    linea.Cells(1).Value = "P. elote barra"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tuti fruti" Then
                    linea.Cells(1).Value = "G.M. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Med. Zanahoria" Then
                    linea.Cells(1).Value = "G.M. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Flores Arándanos" Then
                    linea.Cells(1).Value = "G. Flores A."
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 leches" Then
                    linea.Cells(1).Value = "G.M. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Agua fruta" Then
                    linea.Cells(1).Value = "G.G. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó esp." Then
                    linea.Cells(1).Value = "G.G. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Betabel" Then
                    linea.Cells(1).Value = "G.G. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Tuti fruti" Then
                    linea.Cells(1).Value = "G.G. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Rompope" Then
                    linea.Cells(1).Value = "G.G. Rompope"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 leches" Then
                    linea.Cells(1).Value = "G.G. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Zanahoria" Then
                    linea.Cells(1).Value = "G.G. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 chocolates" Then
                    linea.Cells(1).Value = "G.G. 3 choco"
                End If
                If linea.Cells(1).Value = "Caja Galletas 1 Kg" Then
                    linea.Cells(1).Value = "C. Galle 1"
                End If
                If linea.Cells(1).Value = "Pay queso zarza G." Then
                    linea.Cells(1).Value = "Pay q.zarza G."
                End If
                If linea.Cells(1).Value = "Gel. Vino tinto 22 cm" Then
                    linea.Cells(1).Value = "Gel. vino 22cm"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó" Then
                    linea.Cells(1).Value = "G.G. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Bombón" Then
                    linea.Cells(1).Value = "G.G. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 chocolates" Then
                    linea.Cells(1).Value = "G.M. 3 choco"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Queso uva" Then
                    linea.Cells(1).Value = "G.G. Queso u"
                End If
                If linea.Cells(1).Value = "Pay queso frutas G." Then
                    linea.Cells(1).Value = "Pay q.frutas G."
                End If
                If linea.Cells(1).Value = "Pay queso fresa G." Then
                    linea.Cells(1).Value = "Pay q.fresa G."
                End If
            Next


            'dibujar linea
            'dibujar linea
            e.Graphics.DrawLine(myPen, 0, 21, 770, 21) '+12
            e.Graphics.DrawLine(myPen, 0, 33, 770, 33)
            e.Graphics.DrawLine(myPen, 0, 45, 770, 45)
            e.Graphics.DrawLine(myPen, 0, 57, 770, 57)
            e.Graphics.DrawLine(myPen, 0, 69, 770, 69)
            e.Graphics.DrawLine(myPen, 0, 81, 770, 81)
            e.Graphics.DrawLine(myPen, 0, 93, 770, 93)
            e.Graphics.DrawLine(myPen, 0, 105, 770, 105)
            e.Graphics.DrawLine(myPen, 0, 117, 770, 117)
            e.Graphics.DrawLine(myPen, 0, 129, 770, 129)
            e.Graphics.DrawLine(myPen, 0, 141, 770, 141)
            e.Graphics.DrawLine(myPen, 0, 153, 770, 153)
            e.Graphics.DrawLine(myPen, 0, 165, 770, 165)
            e.Graphics.DrawLine(myPen, 0, 177, 770, 177)
            e.Graphics.DrawLine(myPen, 0, 189, 770, 189)
            e.Graphics.DrawLine(myPen, 0, 201, 770, 201)
            e.Graphics.DrawLine(myPen, 0, 213, 770, 213)
            e.Graphics.DrawLine(myPen, 0, 225, 770, 225)
            e.Graphics.DrawLine(myPen, 0, 237, 770, 237)
            e.Graphics.DrawLine(myPen, 0, 249, 770, 249)
            e.Graphics.DrawLine(myPen, 0, 261, 770, 261)
            e.Graphics.DrawLine(myPen, 0, 273, 770, 273)
            e.Graphics.DrawLine(myPen, 0, 285, 770, 285) 'hasta 31
            e.Graphics.DrawLine(myPen, 0, 297, 770, 297)
            e.Graphics.DrawLine(myPen, 0, 309, 770, 309)
            e.Graphics.DrawLine(myPen, 0, 321, 770, 321)
            e.Graphics.DrawLine(myPen, 0, 333, 770, 333)
            e.Graphics.DrawLine(myPen, 0, 345, 770, 345)
            e.Graphics.DrawLine(myPen, 0, 357, 770, 357)
            e.Graphics.DrawLine(myPen, 0, 369, 770, 369)
            e.Graphics.DrawLine(myPen, 0, 381, 770, 381)


            'aqui inician livbres las lineas
            e.Graphics.DrawLine(myPen, 0, 393, 560, 393)
            e.Graphics.DrawLine(myPen, 0, 405, 560, 405)
            e.Graphics.DrawLine(myPen, 0, 417, 560, 417)
            e.Graphics.DrawLine(myPen, 0, 429, 560, 429)
            e.Graphics.DrawLine(myPen, 0, 441, 560, 441)
            e.Graphics.DrawLine(myPen, 0, 453, 560, 453)
            e.Graphics.DrawLine(myPen, 0, 465, 560, 465)
            e.Graphics.DrawLine(myPen, 0, 477, 560, 477)
            e.Graphics.DrawLine(myPen, 0, 489, 560, 489)
            e.Graphics.DrawLine(myPen, 0, 501, 560, 501)
            e.Graphics.DrawLine(myPen, 0, 513, 560, 513)
            e.Graphics.DrawLine(myPen, 0, 525, 560, 525)
            e.Graphics.DrawLine(myPen, 0, 537, 560, 537)
            e.Graphics.DrawLine(myPen, 0, 549, 560, 549)
            e.Graphics.DrawLine(myPen, 0, 561, 560, 561)
            e.Graphics.DrawLine(myPen, 0, 573, 560, 573)
            e.Graphics.DrawLine(myPen, 0, 585, 560, 585)
            e.Graphics.DrawLine(myPen, 0, 597, 560, 597)
            e.Graphics.DrawLine(myPen, 0, 609, 560, 609)
            e.Graphics.DrawLine(myPen, 0, 621, 560, 621)
            e.Graphics.DrawLine(myPen, 0, 633, 560, 633)
            e.Graphics.DrawLine(myPen, 0, 645, 560, 645)
            e.Graphics.DrawLine(myPen, 0, 657, 560, 657)
            e.Graphics.DrawLine(myPen, 0, 669, 560, 669)
            e.Graphics.DrawLine(myPen, 0, 681, 560, 681)
            e.Graphics.DrawLine(myPen, 0, 693, 560, 693)
            e.Graphics.DrawLine(myPen, 0, 705, 560, 705)
            e.Graphics.DrawLine(myPen, 0, 717, 560, 717)
            e.Graphics.DrawLine(myPen, 0, 729, 560, 729)
            e.Graphics.DrawLine(myPen, 0, 741, 560, 741)
            e.Graphics.DrawLine(myPen, 0, 753, 560, 753)
            e.Graphics.DrawLine(myPen, 0, 765, 560, 765)
            e.Graphics.DrawLine(myPen, 0, 777, 560, 777)
            e.Graphics.DrawLine(myPen, 0, 789, 560, 789)
            e.Graphics.DrawLine(myPen, 0, 801, 560, 801)
            e.Graphics.DrawLine(myPen, 0, 813, 560, 813)
            e.Graphics.DrawLine(myPen, 0, 825, 560, 825)
            e.Graphics.DrawLine(myPen, 0, 837, 560, 837)
            e.Graphics.DrawLine(myPen, 0, 849, 560, 849)
            e.Graphics.DrawLine(myPen, 0, 861, 560, 861)
            e.Graphics.DrawLine(myPen, 0, 873, 560, 873)
            e.Graphics.DrawLine(myPen, 0, 885, 560, 885)
            e.Graphics.DrawLine(myPen, 0, 897, 560, 897)
            e.Graphics.DrawLine(myPen, 0, 909, 560, 909)
            e.Graphics.DrawLine(myPen, 0, 921, 560, 921)
            e.Graphics.DrawLine(myPen, 0, 933, 560, 933)
            e.Graphics.DrawLine(myPen, 0, 945, 560, 945)
            e.Graphics.DrawLine(myPen, 0, 957, 560, 957)
            e.Graphics.DrawLine(myPen, 0, 969, 560, 969)
            e.Graphics.DrawLine(myPen, 0, 981, 560, 981)
            e.Graphics.DrawLine(myPen, 0, 993, 560, 993)
            e.Graphics.DrawLine(myPen, 0, 1005, 560, 1005)
            e.Graphics.DrawLine(myPen, 0, 1017, 560, 1017)
            e.Graphics.DrawLine(myPen, 0, 1029, 560, 1029)
            e.Graphics.DrawLine(myPen, 0, 1041, 560, 1041)
            e.Graphics.DrawLine(myPen, 0, 1053, 560, 1053)
            e.Graphics.DrawLine(myPen, 0, 1065, 560, 1065)
            e.Graphics.DrawLine(myPen, 0, 1077, 560, 1077)
            e.Graphics.DrawLine(myPen, 0, 1089, 560, 1089)
            e.Graphics.DrawLine(myPen, 0, 1101, 560, 1101)
            e.Graphics.DrawLine(myPen, 0, 1113, 560, 1113)
            e.Graphics.DrawLine(myPen, 0, 1125, 560, 1125)
            e.Graphics.DrawLine(myPen, 0, 1137, 560, 1137)
            e.Graphics.DrawLine(myPen, 0, 1149, 560, 1149)
            e.Graphics.DrawLine(myPen, 0, 1161, 560, 1161)
            e.Graphics.DrawLine(myPen, 0, 1173, 560, 1173)
            e.Graphics.DrawLine(myPen, 0, 1185, 560, 1185)
            e.Graphics.DrawLine(myPen, 0, 1197, 560, 1197)
            e.Graphics.DrawLine(myPen, 0, 1209, 560, 1209)
            e.Graphics.DrawLine(myPen, 0, 1221, 560, 1221)
            e.Graphics.DrawLine(myPen, 0, 1233, 560, 1233)
            e.Graphics.DrawLine(myPen, 0, 1245, 560, 1245)
            e.Graphics.DrawLine(myPen, 0, 1257, 560, 1257)
            e.Graphics.DrawLine(myPen, 0, 1269, 560, 1269)

            e.Graphics.DrawLine(myPen, 0, 1281, 560, 1281)
            e.Graphics.DrawLine(myPen, 0, 1293, 560, 1293)
            e.Graphics.DrawLine(myPen, 0, 1305, 560, 1305)
            e.Graphics.DrawLine(myPen, 0, 1317, 560, 1317)
            e.Graphics.DrawLine(myPen, 0, 1329, 560, 1329)
            e.Graphics.DrawLine(myPen, 0, 1341, 560, 1341)



            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 0, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 100, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 135, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 190, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 290, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 325, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 380, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 480, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 515, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 570, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 670, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 705, 6)


            If DataGridView1.Rows.Count > 180 Then

                While i < 110

                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 0, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(15, i).Value, prFont1, Brushes.Black, 110, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 140, i * 12 + 20)
                    i += 1


                End While


                While i < 220
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 190, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(15, i).Value, prFont1, Brushes.Black, 300, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 330, i * 12 - 1300)
                    i += 1


                End While

                While i < 330
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 380, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(15, i).Value, prFont1, Brushes.Black, 490, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 520, i * 12 - 2620)
                    i += 1


                End While

                While i < DataGridView1.Rows.Count
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 570, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(15, i).Value, prFont1, Brushes.Black, 680, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 710, i * 12 - 3940)
                    i += 1


                End While


            End If

        End If



        If TextBox1.Text = "Torres" Then

            Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
            PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            e.Graphics.DrawImage(bm, 600, 1050)
            Dim i As Integer = 0
            Dim i1 As Integer = 0
            Dim i11 As Integer = 0
            Dim line As String = Nothing
            Dim myPen = New Pen(Color.Black, 1)
            Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
            Dim prFont2 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
            Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
            Dim prFont9 As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
            Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
            e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 600, 1120) '65
            e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 610, 1130) '75
            e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 600, 1145) '90
            e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 600, 1160) '105
            e.Graphics.DrawString(DateTimePicker2.Value, prFont2, Brushes.Black, 650, 1160) '105
            e.Graphics.DrawString("HOJA DE CHOFER DE SISTEMA.", prFont2, Brushes.Black, 600, 1185) '130
            e.Graphics.DrawString("Sucursal:", prFont2, Brushes.Black, 600, 1200) '145
            e.Graphics.DrawString(TextBox1.Text, prFont9, Brushes.Black, 660, 1200) '145
            e.Graphics.DrawString("Chofer:", prFont2, Brushes.Black, 600, 1220)
            'e.Graphics.DrawString(TextBox156.Text, prFont9, Brushes.Black, 660, 1220)
            ' e.Graphics.DrawString("ANOTACIONES:", prFont9, Brushes.Black, 600, 185)

            Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows
                If linea.Cells(1).Value = "Concha blanca int." Then
                    linea.Cells(1).Value = "Concha bca. int."
                End If
                If linea.Cells(1).Value = "Minirosquita Janeth" Then
                    linea.Cells(1).Value = "Rosquita Janeth"
                End If
                If linea.Cells(1).Value = "Cuerno mantequilla" Then
                    linea.Cells(1).Value = "Cuerno mante"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria" Then
                    linea.Cells(1).Value = "Panqué de zana"
                End If
                If linea.Cells(1).Value = "Gel. Dominó especial" Then
                    linea.Cells(1).Value = "Gel. Dom. esp."
                End If
                If linea.Cells(1).Value = "Gel. Rompope fruta" Then
                    linea.Cells(1).Value = "Gel. Rompope"
                End If
                If linea.Cells(1).Value = "Leche deslactosada 1l" Then
                    linea.Cells(1).Value = "L. deslac. 1l"
                End If
                If linea.Cells(1).Value = "Pay queso chocolate" Then
                    linea.Cells(1).Value = "P. queso choco"
                End If
                If linea.Cells(1).Value = "Feliz Cumple con base" Then
                    linea.Cells(1).Value = "F.C. base"
                End If
                If linea.Cells(1).Value = "Caja Galletas .250 Kg" Then
                    linea.Cells(1).Value = "C. Galle. .250"
                End If
                If linea.Cells(1).Value = "Panqué de chocolate" Then
                    linea.Cells(1).Value = "Panqué de choco"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria barra" Then
                    linea.Cells(1).Value = "P. zana barra"
                End If
                If linea.Cells(1).Value = "Panqué de chabacano" Then
                    linea.Cells(1).Value = "Panqué chaba"
                End If
                If linea.Cells(1).Value = "Bolsa cafe ame 500gr" Then
                    linea.Cells(1).Value = "B. café a. 500"
                End If
                If linea.Cells(1).Value = "Bolsa cafe des 500gr" Then
                    linea.Cells(1).Value = "B. café d. 500gr"
                End If
                If linea.Cells(1).Value = "Gel. Med. Bombón" Then
                    linea.Cells(1).Value = "G.M. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó" Then
                    linea.Cells(1).Value = "G.M. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó esp." Then
                    linea.Cells(1).Value = "G.M. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Med. Betabel" Then
                    linea.Cells(1).Value = "G.M. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Med. Queso uva" Then
                    linea.Cells(1).Value = "G.M. Queso u"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tricolor" Then
                    linea.Cells(1).Value = "G.M. Tricolor"
                End If
                If linea.Cells(1).Value = "Caja Galletas .5 Kg" Then
                    linea.Cells(1).Value = "C. Galle .5"
                End If
                If linea.Cells(1).Value = "Gel. Med. Agua fruta" Then
                    linea.Cells(1).Value = "G.M. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Med. Rompope" Then
                    linea.Cells(1).Value = "G.M. Romp."
                End If
                If linea.Cells(1).Value = "Panqué elote barra" Then
                    linea.Cells(1).Value = "P. elote barra"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tuti fruti" Then
                    linea.Cells(1).Value = "G.M. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Med. Zanahoria" Then
                    linea.Cells(1).Value = "G.M. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Flores Arándanos" Then
                    linea.Cells(1).Value = "G. Flores A."
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 leches" Then
                    linea.Cells(1).Value = "G.M. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Agua fruta" Then
                    linea.Cells(1).Value = "G.G. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó esp." Then
                    linea.Cells(1).Value = "G.G. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Betabel" Then
                    linea.Cells(1).Value = "G.G. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Tuti fruti" Then
                    linea.Cells(1).Value = "G.G. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Rompope" Then
                    linea.Cells(1).Value = "G.G. Rompope"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 leches" Then
                    linea.Cells(1).Value = "G.G. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Zanahoria" Then
                    linea.Cells(1).Value = "G.G. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 chocolates" Then
                    linea.Cells(1).Value = "G.G. 3 choco"
                End If
                If linea.Cells(1).Value = "Caja Galletas 1 Kg" Then
                    linea.Cells(1).Value = "C. Galle 1"
                End If
                If linea.Cells(1).Value = "Pay queso zarza G." Then
                    linea.Cells(1).Value = "Pay q.zarza G."
                End If
                If linea.Cells(1).Value = "Gel. Vino tinto 22 cm" Then
                    linea.Cells(1).Value = "Gel. vino 22cm"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó" Then
                    linea.Cells(1).Value = "G.G. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Bombón" Then
                    linea.Cells(1).Value = "G.G. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 chocolates" Then
                    linea.Cells(1).Value = "G.M. 3 choco"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Queso uva" Then
                    linea.Cells(1).Value = "G.G. Queso u"
                End If
                If linea.Cells(1).Value = "Pay queso frutas G." Then
                    linea.Cells(1).Value = "Pay q.frutas G."
                End If
                If linea.Cells(1).Value = "Pay queso fresa G." Then
                    linea.Cells(1).Value = "Pay q.fresa G."
                End If
            Next


            'dibujar linea
            e.Graphics.DrawLine(myPen, 0, 21, 770, 21) '+12
            e.Graphics.DrawLine(myPen, 0, 33, 770, 33)
            e.Graphics.DrawLine(myPen, 0, 45, 770, 45)
            e.Graphics.DrawLine(myPen, 0, 57, 770, 57)
            e.Graphics.DrawLine(myPen, 0, 69, 770, 69)
            e.Graphics.DrawLine(myPen, 0, 81, 770, 81)
            e.Graphics.DrawLine(myPen, 0, 93, 770, 93)
            e.Graphics.DrawLine(myPen, 0, 105, 770, 105)
            e.Graphics.DrawLine(myPen, 0, 117, 770, 117)
            e.Graphics.DrawLine(myPen, 0, 129, 770, 129)
            e.Graphics.DrawLine(myPen, 0, 141, 770, 141)
            e.Graphics.DrawLine(myPen, 0, 153, 770, 153)
            e.Graphics.DrawLine(myPen, 0, 165, 770, 165)
            e.Graphics.DrawLine(myPen, 0, 177, 770, 177)
            e.Graphics.DrawLine(myPen, 0, 189, 770, 189)
            e.Graphics.DrawLine(myPen, 0, 201, 770, 201)
            e.Graphics.DrawLine(myPen, 0, 213, 770, 213)
            e.Graphics.DrawLine(myPen, 0, 225, 770, 225)
            e.Graphics.DrawLine(myPen, 0, 237, 770, 237)
            e.Graphics.DrawLine(myPen, 0, 249, 770, 249)
            e.Graphics.DrawLine(myPen, 0, 261, 770, 261)
            e.Graphics.DrawLine(myPen, 0, 273, 770, 273)
            e.Graphics.DrawLine(myPen, 0, 285, 770, 285) 'hasta 31
            e.Graphics.DrawLine(myPen, 0, 297, 770, 297)
            e.Graphics.DrawLine(myPen, 0, 309, 770, 309)
            e.Graphics.DrawLine(myPen, 0, 321, 770, 321)
            e.Graphics.DrawLine(myPen, 0, 333, 770, 333)
            e.Graphics.DrawLine(myPen, 0, 345, 770, 345)
            e.Graphics.DrawLine(myPen, 0, 357, 770, 357)
            e.Graphics.DrawLine(myPen, 0, 369, 770, 369)
            e.Graphics.DrawLine(myPen, 0, 381, 770, 381)


            'aqui inician livbres las lineas
            e.Graphics.DrawLine(myPen, 0, 393, 560, 393)
            e.Graphics.DrawLine(myPen, 0, 405, 560, 405)
            e.Graphics.DrawLine(myPen, 0, 417, 560, 417)
            e.Graphics.DrawLine(myPen, 0, 429, 560, 429)
            e.Graphics.DrawLine(myPen, 0, 441, 560, 441)
            e.Graphics.DrawLine(myPen, 0, 453, 560, 453)
            e.Graphics.DrawLine(myPen, 0, 465, 560, 465)
            e.Graphics.DrawLine(myPen, 0, 477, 560, 477)
            e.Graphics.DrawLine(myPen, 0, 489, 560, 489)
            e.Graphics.DrawLine(myPen, 0, 501, 560, 501)
            e.Graphics.DrawLine(myPen, 0, 513, 560, 513)
            e.Graphics.DrawLine(myPen, 0, 525, 560, 525)
            e.Graphics.DrawLine(myPen, 0, 537, 560, 537)
            e.Graphics.DrawLine(myPen, 0, 549, 560, 549)
            e.Graphics.DrawLine(myPen, 0, 561, 560, 561)
            e.Graphics.DrawLine(myPen, 0, 573, 560, 573)
            e.Graphics.DrawLine(myPen, 0, 585, 560, 585)
            e.Graphics.DrawLine(myPen, 0, 597, 560, 597)
            e.Graphics.DrawLine(myPen, 0, 609, 560, 609)
            e.Graphics.DrawLine(myPen, 0, 621, 560, 621)
            e.Graphics.DrawLine(myPen, 0, 633, 560, 633)
            e.Graphics.DrawLine(myPen, 0, 645, 560, 645)
            e.Graphics.DrawLine(myPen, 0, 657, 560, 657)
            e.Graphics.DrawLine(myPen, 0, 669, 560, 669)
            e.Graphics.DrawLine(myPen, 0, 681, 560, 681)
            e.Graphics.DrawLine(myPen, 0, 693, 560, 693)
            e.Graphics.DrawLine(myPen, 0, 705, 560, 705)
            e.Graphics.DrawLine(myPen, 0, 717, 560, 717)
            e.Graphics.DrawLine(myPen, 0, 729, 560, 729)
            e.Graphics.DrawLine(myPen, 0, 741, 560, 741)
            e.Graphics.DrawLine(myPen, 0, 753, 560, 753)
            e.Graphics.DrawLine(myPen, 0, 765, 560, 765)
            e.Graphics.DrawLine(myPen, 0, 777, 560, 777)
            e.Graphics.DrawLine(myPen, 0, 789, 560, 789)
            e.Graphics.DrawLine(myPen, 0, 801, 560, 801)
            e.Graphics.DrawLine(myPen, 0, 813, 560, 813)
            e.Graphics.DrawLine(myPen, 0, 825, 560, 825)
            e.Graphics.DrawLine(myPen, 0, 837, 560, 837)
            e.Graphics.DrawLine(myPen, 0, 849, 560, 849)
            e.Graphics.DrawLine(myPen, 0, 861, 560, 861)
            e.Graphics.DrawLine(myPen, 0, 873, 560, 873)
            e.Graphics.DrawLine(myPen, 0, 885, 560, 885)
            e.Graphics.DrawLine(myPen, 0, 897, 560, 897)
            e.Graphics.DrawLine(myPen, 0, 909, 560, 909)
            e.Graphics.DrawLine(myPen, 0, 921, 560, 921)
            e.Graphics.DrawLine(myPen, 0, 933, 560, 933)
            e.Graphics.DrawLine(myPen, 0, 945, 560, 945)
            e.Graphics.DrawLine(myPen, 0, 957, 560, 957)
            e.Graphics.DrawLine(myPen, 0, 969, 560, 969)
            e.Graphics.DrawLine(myPen, 0, 981, 560, 981)
            e.Graphics.DrawLine(myPen, 0, 993, 560, 993)
            e.Graphics.DrawLine(myPen, 0, 1005, 560, 1005)
            e.Graphics.DrawLine(myPen, 0, 1017, 560, 1017)
            e.Graphics.DrawLine(myPen, 0, 1029, 560, 1029)
            e.Graphics.DrawLine(myPen, 0, 1041, 560, 1041)
            e.Graphics.DrawLine(myPen, 0, 1053, 560, 1053)
            e.Graphics.DrawLine(myPen, 0, 1065, 560, 1065)
            e.Graphics.DrawLine(myPen, 0, 1077, 560, 1077)
            e.Graphics.DrawLine(myPen, 0, 1089, 560, 1089)
            e.Graphics.DrawLine(myPen, 0, 1101, 560, 1101)
            e.Graphics.DrawLine(myPen, 0, 1113, 560, 1113)
            e.Graphics.DrawLine(myPen, 0, 1125, 560, 1125)
            e.Graphics.DrawLine(myPen, 0, 1137, 560, 1137)
            e.Graphics.DrawLine(myPen, 0, 1149, 560, 1149)
            e.Graphics.DrawLine(myPen, 0, 1161, 560, 1161)
            e.Graphics.DrawLine(myPen, 0, 1173, 560, 1173)
            e.Graphics.DrawLine(myPen, 0, 1185, 560, 1185)
            e.Graphics.DrawLine(myPen, 0, 1197, 560, 1197)
            e.Graphics.DrawLine(myPen, 0, 1209, 560, 1209)
            e.Graphics.DrawLine(myPen, 0, 1221, 560, 1221)
            e.Graphics.DrawLine(myPen, 0, 1233, 560, 1233)
            e.Graphics.DrawLine(myPen, 0, 1245, 560, 1245)
            e.Graphics.DrawLine(myPen, 0, 1257, 560, 1257)
            e.Graphics.DrawLine(myPen, 0, 1269, 560, 1269)

            e.Graphics.DrawLine(myPen, 0, 1281, 560, 1281)
            e.Graphics.DrawLine(myPen, 0, 1293, 560, 1293)
            e.Graphics.DrawLine(myPen, 0, 1305, 560, 1305)
            e.Graphics.DrawLine(myPen, 0, 1317, 560, 1317)
            e.Graphics.DrawLine(myPen, 0, 1329, 560, 1329)
            e.Graphics.DrawLine(myPen, 0, 1341, 560, 1341)



            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 0, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 100, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 135, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 190, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 290, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 325, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 380, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 480, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 515, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 570, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 670, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 705, 6)


            If DataGridView1.Rows.Count > 180 Then

                While i < 110

                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 0, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(13, i).Value, prFont1, Brushes.Black, 110, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 140, i * 12 + 20)
                    i += 1


                End While


                While i < 220
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 190, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(13, i).Value, prFont1, Brushes.Black, 300, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 330, i * 12 - 1300)
                    i += 1


                End While

                While i < 330
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 380, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(13, i).Value, prFont1, Brushes.Black, 490, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 520, i * 12 - 2620)
                    i += 1


                End While

                While i < DataGridView1.Rows.Count
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 570, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(13, i).Value, prFont1, Brushes.Black, 680, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 710, i * 12 - 3940)
                    i += 1


                End While


            End If

        End If



        If TextBox1.Text = "Lerma" Then

            Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
            PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            e.Graphics.DrawImage(bm, 600, 1050)
            Dim i As Integer = 0
            Dim i1 As Integer = 0
            Dim i11 As Integer = 0
            Dim line As String = Nothing
            Dim myPen = New Pen(Color.Black, 1)
            Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
            Dim prFont2 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
            Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
            Dim prFont9 As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
            Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
            e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 600, 1120) '65
            e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 610, 1130) '75
            e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 600, 1145) '90
            e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 600, 1160) '105
            e.Graphics.DrawString(DateTimePicker2.Value, prFont2, Brushes.Black, 650, 1160) '105
            e.Graphics.DrawString("HOJA DE CHOFER DE SISTEMA.", prFont2, Brushes.Black, 600, 1185) '130
            e.Graphics.DrawString("Sucursal:", prFont2, Brushes.Black, 600, 1200) '145
            e.Graphics.DrawString(TextBox1.Text, prFont9, Brushes.Black, 660, 1200) '145
            e.Graphics.DrawString("Chofer:", prFont2, Brushes.Black, 600, 1220)
            '  e.Graphics.DrawString(TextBox156.Text, prFont9, Brushes.Black, 660, 1220)
            ' e.Graphics.DrawString("ANOTACIONES:", prFont9, Brushes.Black, 600, 185)

            Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows
                If linea.Cells(1).Value = "Concha blanca int." Then
                    linea.Cells(1).Value = "Concha bca. int."
                End If
                If linea.Cells(1).Value = "Minirosquita Janeth" Then
                    linea.Cells(1).Value = "Rosquita Janeth"
                End If
                If linea.Cells(1).Value = "Cuerno mantequilla" Then
                    linea.Cells(1).Value = "Cuerno mante"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria" Then
                    linea.Cells(1).Value = "Panqué de zana"
                End If
                If linea.Cells(1).Value = "Gel. Dominó especial" Then
                    linea.Cells(1).Value = "Gel. Dom. esp."
                End If
                If linea.Cells(1).Value = "Gel. Rompope fruta" Then
                    linea.Cells(1).Value = "Gel. Rompope"
                End If
                If linea.Cells(1).Value = "Leche deslactosada 1l" Then
                    linea.Cells(1).Value = "L. deslac. 1l"
                End If
                If linea.Cells(1).Value = "Pay queso chocolate" Then
                    linea.Cells(1).Value = "P. queso choco"
                End If
                If linea.Cells(1).Value = "Feliz Cumple con base" Then
                    linea.Cells(1).Value = "F.C. base"
                End If
                If linea.Cells(1).Value = "Caja Galletas .250 Kg" Then
                    linea.Cells(1).Value = "C. Galle. .250"
                End If
                If linea.Cells(1).Value = "Panqué de chocolate" Then
                    linea.Cells(1).Value = "Panqué de choco"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria barra" Then
                    linea.Cells(1).Value = "P. zana barra"
                End If
                If linea.Cells(1).Value = "Panqué de chabacano" Then
                    linea.Cells(1).Value = "Panqué chaba"
                End If
                If linea.Cells(1).Value = "Bolsa cafe ame 500gr" Then
                    linea.Cells(1).Value = "B. café a. 500"
                End If
                If linea.Cells(1).Value = "Bolsa cafe des 500gr" Then
                    linea.Cells(1).Value = "B. café d. 500gr"
                End If
                If linea.Cells(1).Value = "Gel. Med. Bombón" Then
                    linea.Cells(1).Value = "G.M. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó" Then
                    linea.Cells(1).Value = "G.M. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó esp." Then
                    linea.Cells(1).Value = "G.M. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Med. Betabel" Then
                    linea.Cells(1).Value = "G.M. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Med. Queso uva" Then
                    linea.Cells(1).Value = "G.M. Queso u"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tricolor" Then
                    linea.Cells(1).Value = "G.M. Tricolor"
                End If
                If linea.Cells(1).Value = "Caja Galletas .5 Kg" Then
                    linea.Cells(1).Value = "C. Galle .5"
                End If
                If linea.Cells(1).Value = "Gel. Med. Agua fruta" Then
                    linea.Cells(1).Value = "G.M. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Med. Rompope" Then
                    linea.Cells(1).Value = "G.M. Romp."
                End If
                If linea.Cells(1).Value = "Panqué elote barra" Then
                    linea.Cells(1).Value = "P. elote barra"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tuti fruti" Then
                    linea.Cells(1).Value = "G.M. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Med. Zanahoria" Then
                    linea.Cells(1).Value = "G.M. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Flores Arándanos" Then
                    linea.Cells(1).Value = "G. Flores A."
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 leches" Then
                    linea.Cells(1).Value = "G.M. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Agua fruta" Then
                    linea.Cells(1).Value = "G.G. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó esp." Then
                    linea.Cells(1).Value = "G.G. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Betabel" Then
                    linea.Cells(1).Value = "G.G. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Tuti fruti" Then
                    linea.Cells(1).Value = "G.G. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Rompope" Then
                    linea.Cells(1).Value = "G.G. Rompope"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 leches" Then
                    linea.Cells(1).Value = "G.G. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Zanahoria" Then
                    linea.Cells(1).Value = "G.G. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 chocolates" Then
                    linea.Cells(1).Value = "G.G. 3 choco"
                End If
                If linea.Cells(1).Value = "Caja Galletas 1 Kg" Then
                    linea.Cells(1).Value = "C. Galle 1"
                End If
                If linea.Cells(1).Value = "Pay queso zarza G." Then
                    linea.Cells(1).Value = "Pay q.zarza G."
                End If
                If linea.Cells(1).Value = "Gel. Vino tinto 22 cm" Then
                    linea.Cells(1).Value = "Gel. vino 22cm"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó" Then
                    linea.Cells(1).Value = "G.G. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Bombón" Then
                    linea.Cells(1).Value = "G.G. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 chocolates" Then
                    linea.Cells(1).Value = "G.M. 3 choco"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Queso uva" Then
                    linea.Cells(1).Value = "G.G. Queso u"
                End If
                If linea.Cells(1).Value = "Pay queso frutas G." Then
                    linea.Cells(1).Value = "Pay q.frutas G."
                End If
                If linea.Cells(1).Value = "Pay queso fresa G." Then
                    linea.Cells(1).Value = "Pay q.fresa G."
                End If
            Next


            'dibujar linea
            'dibujar linea
            e.Graphics.DrawLine(myPen, 0, 21, 770, 21) '+12
            e.Graphics.DrawLine(myPen, 0, 33, 770, 33)
            e.Graphics.DrawLine(myPen, 0, 45, 770, 45)
            e.Graphics.DrawLine(myPen, 0, 57, 770, 57)
            e.Graphics.DrawLine(myPen, 0, 69, 770, 69)
            e.Graphics.DrawLine(myPen, 0, 81, 770, 81)
            e.Graphics.DrawLine(myPen, 0, 93, 770, 93)
            e.Graphics.DrawLine(myPen, 0, 105, 770, 105)
            e.Graphics.DrawLine(myPen, 0, 117, 770, 117)
            e.Graphics.DrawLine(myPen, 0, 129, 770, 129)
            e.Graphics.DrawLine(myPen, 0, 141, 770, 141)
            e.Graphics.DrawLine(myPen, 0, 153, 770, 153)
            e.Graphics.DrawLine(myPen, 0, 165, 770, 165)
            e.Graphics.DrawLine(myPen, 0, 177, 770, 177)
            e.Graphics.DrawLine(myPen, 0, 189, 770, 189)
            e.Graphics.DrawLine(myPen, 0, 201, 770, 201)
            e.Graphics.DrawLine(myPen, 0, 213, 770, 213)
            e.Graphics.DrawLine(myPen, 0, 225, 770, 225)
            e.Graphics.DrawLine(myPen, 0, 237, 770, 237)
            e.Graphics.DrawLine(myPen, 0, 249, 770, 249)
            e.Graphics.DrawLine(myPen, 0, 261, 770, 261)
            e.Graphics.DrawLine(myPen, 0, 273, 770, 273)
            e.Graphics.DrawLine(myPen, 0, 285, 770, 285) 'hasta 31
            e.Graphics.DrawLine(myPen, 0, 297, 770, 297)
            e.Graphics.DrawLine(myPen, 0, 309, 770, 309)
            e.Graphics.DrawLine(myPen, 0, 321, 770, 321)
            e.Graphics.DrawLine(myPen, 0, 333, 770, 333)
            e.Graphics.DrawLine(myPen, 0, 345, 770, 345)
            e.Graphics.DrawLine(myPen, 0, 357, 770, 357)
            e.Graphics.DrawLine(myPen, 0, 369, 770, 369)
            e.Graphics.DrawLine(myPen, 0, 381, 770, 381)


            'aqui inician livbres las lineas
            e.Graphics.DrawLine(myPen, 0, 393, 560, 393)
            e.Graphics.DrawLine(myPen, 0, 405, 560, 405)
            e.Graphics.DrawLine(myPen, 0, 417, 560, 417)
            e.Graphics.DrawLine(myPen, 0, 429, 560, 429)
            e.Graphics.DrawLine(myPen, 0, 441, 560, 441)
            e.Graphics.DrawLine(myPen, 0, 453, 560, 453)
            e.Graphics.DrawLine(myPen, 0, 465, 560, 465)
            e.Graphics.DrawLine(myPen, 0, 477, 560, 477)
            e.Graphics.DrawLine(myPen, 0, 489, 560, 489)
            e.Graphics.DrawLine(myPen, 0, 501, 560, 501)
            e.Graphics.DrawLine(myPen, 0, 513, 560, 513)
            e.Graphics.DrawLine(myPen, 0, 525, 560, 525)
            e.Graphics.DrawLine(myPen, 0, 537, 560, 537)
            e.Graphics.DrawLine(myPen, 0, 549, 560, 549)
            e.Graphics.DrawLine(myPen, 0, 561, 560, 561)
            e.Graphics.DrawLine(myPen, 0, 573, 560, 573)
            e.Graphics.DrawLine(myPen, 0, 585, 560, 585)
            e.Graphics.DrawLine(myPen, 0, 597, 560, 597)
            e.Graphics.DrawLine(myPen, 0, 609, 560, 609)
            e.Graphics.DrawLine(myPen, 0, 621, 560, 621)
            e.Graphics.DrawLine(myPen, 0, 633, 560, 633)
            e.Graphics.DrawLine(myPen, 0, 645, 560, 645)
            e.Graphics.DrawLine(myPen, 0, 657, 560, 657)
            e.Graphics.DrawLine(myPen, 0, 669, 560, 669)
            e.Graphics.DrawLine(myPen, 0, 681, 560, 681)
            e.Graphics.DrawLine(myPen, 0, 693, 560, 693)
            e.Graphics.DrawLine(myPen, 0, 705, 560, 705)
            e.Graphics.DrawLine(myPen, 0, 717, 560, 717)
            e.Graphics.DrawLine(myPen, 0, 729, 560, 729)
            e.Graphics.DrawLine(myPen, 0, 741, 560, 741)
            e.Graphics.DrawLine(myPen, 0, 753, 560, 753)
            e.Graphics.DrawLine(myPen, 0, 765, 560, 765)
            e.Graphics.DrawLine(myPen, 0, 777, 560, 777)
            e.Graphics.DrawLine(myPen, 0, 789, 560, 789)
            e.Graphics.DrawLine(myPen, 0, 801, 560, 801)
            e.Graphics.DrawLine(myPen, 0, 813, 560, 813)
            e.Graphics.DrawLine(myPen, 0, 825, 560, 825)
            e.Graphics.DrawLine(myPen, 0, 837, 560, 837)
            e.Graphics.DrawLine(myPen, 0, 849, 560, 849)
            e.Graphics.DrawLine(myPen, 0, 861, 560, 861)
            e.Graphics.DrawLine(myPen, 0, 873, 560, 873)
            e.Graphics.DrawLine(myPen, 0, 885, 560, 885)
            e.Graphics.DrawLine(myPen, 0, 897, 560, 897)
            e.Graphics.DrawLine(myPen, 0, 909, 560, 909)
            e.Graphics.DrawLine(myPen, 0, 921, 560, 921)
            e.Graphics.DrawLine(myPen, 0, 933, 560, 933)
            e.Graphics.DrawLine(myPen, 0, 945, 560, 945)
            e.Graphics.DrawLine(myPen, 0, 957, 560, 957)
            e.Graphics.DrawLine(myPen, 0, 969, 560, 969)
            e.Graphics.DrawLine(myPen, 0, 981, 560, 981)
            e.Graphics.DrawLine(myPen, 0, 993, 560, 993)
            e.Graphics.DrawLine(myPen, 0, 1005, 560, 1005)
            e.Graphics.DrawLine(myPen, 0, 1017, 560, 1017)
            e.Graphics.DrawLine(myPen, 0, 1029, 560, 1029)
            e.Graphics.DrawLine(myPen, 0, 1041, 560, 1041)
            e.Graphics.DrawLine(myPen, 0, 1053, 560, 1053)
            e.Graphics.DrawLine(myPen, 0, 1065, 560, 1065)
            e.Graphics.DrawLine(myPen, 0, 1077, 560, 1077)
            e.Graphics.DrawLine(myPen, 0, 1089, 560, 1089)
            e.Graphics.DrawLine(myPen, 0, 1101, 560, 1101)
            e.Graphics.DrawLine(myPen, 0, 1113, 560, 1113)
            e.Graphics.DrawLine(myPen, 0, 1125, 560, 1125)
            e.Graphics.DrawLine(myPen, 0, 1137, 560, 1137)
            e.Graphics.DrawLine(myPen, 0, 1149, 560, 1149)
            e.Graphics.DrawLine(myPen, 0, 1161, 560, 1161)
            e.Graphics.DrawLine(myPen, 0, 1173, 560, 1173)
            e.Graphics.DrawLine(myPen, 0, 1185, 560, 1185)
            e.Graphics.DrawLine(myPen, 0, 1197, 560, 1197)
            e.Graphics.DrawLine(myPen, 0, 1209, 560, 1209)
            e.Graphics.DrawLine(myPen, 0, 1221, 560, 1221)
            e.Graphics.DrawLine(myPen, 0, 1233, 560, 1233)
            e.Graphics.DrawLine(myPen, 0, 1245, 560, 1245)
            e.Graphics.DrawLine(myPen, 0, 1257, 560, 1257)
            e.Graphics.DrawLine(myPen, 0, 1269, 560, 1269)

            e.Graphics.DrawLine(myPen, 0, 1281, 560, 1281)
            e.Graphics.DrawLine(myPen, 0, 1293, 560, 1293)
            e.Graphics.DrawLine(myPen, 0, 1305, 560, 1305)
            e.Graphics.DrawLine(myPen, 0, 1317, 560, 1317)
            e.Graphics.DrawLine(myPen, 0, 1329, 560, 1329)
            e.Graphics.DrawLine(myPen, 0, 1341, 560, 1341)



            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 0, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 100, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 135, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 190, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 290, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 325, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 380, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 480, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 515, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 570, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 670, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 705, 6)


            If DataGridView1.Rows.Count > 180 Then

                While i < 110

                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 0, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(8, i).Value, prFont1, Brushes.Black, 110, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 140, i * 12 + 20)
                    i += 1


                End While


                While i < 220
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 190, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(8, i).Value, prFont1, Brushes.Black, 300, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 330, i * 12 - 1300)
                    i += 1


                End While

                While i < 330
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 380, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(8, i).Value, prFont1, Brushes.Black, 490, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 520, i * 12 - 2620)
                    i += 1


                End While

                While i < DataGridView1.Rows.Count
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 570, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(8, i).Value, prFont1, Brushes.Black, 680, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 710, i * 12 - 3940)
                    i += 1


                End While


            End If

        End If




        If TextBox1.Text = "Suárez" Then

            Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
            PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            e.Graphics.DrawImage(bm, 600, 1050)
            Dim i As Integer = 0
            Dim i1 As Integer = 0
            Dim i11 As Integer = 0
            Dim line As String = Nothing
            Dim myPen = New Pen(Color.Black, 1)
            Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
            Dim prFont2 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
            Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
            Dim prFont9 As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
            Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
            e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 600, 1120) '65
            e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 610, 1130) '75
            e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 600, 1145) '90
            e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 600, 1160) '105
            e.Graphics.DrawString(DateTimePicker2.Value, prFont2, Brushes.Black, 650, 1160) '105
            e.Graphics.DrawString("HOJA DE CHOFER DE SISTEMA.", prFont2, Brushes.Black, 600, 1185) '130
            e.Graphics.DrawString("Sucursal:", prFont2, Brushes.Black, 600, 1200) '145
            e.Graphics.DrawString(TextBox1.Text, prFont9, Brushes.Black, 660, 1200) '145
            e.Graphics.DrawString("Chofer:", prFont2, Brushes.Black, 600, 1220)
            'e.Graphics.DrawString(TextBox156.Text, prFont9, Brushes.Black, 660, 1220)
            ' e.Graphics.DrawString("ANOTACIONES:", prFont9, Brushes.Black, 600, 185)

            Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows
                If linea.Cells(1).Value = "Concha blanca int." Then
                    linea.Cells(1).Value = "Concha bca. int."
                End If
                If linea.Cells(1).Value = "Minirosquita Janeth" Then
                    linea.Cells(1).Value = "Rosquita Janeth"
                End If
                If linea.Cells(1).Value = "Cuerno mantequilla" Then
                    linea.Cells(1).Value = "Cuerno mante"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria" Then
                    linea.Cells(1).Value = "Panqué de zana"
                End If
                If linea.Cells(1).Value = "Gel. Dominó especial" Then
                    linea.Cells(1).Value = "Gel. Dom. esp."
                End If
                If linea.Cells(1).Value = "Gel. Rompope fruta" Then
                    linea.Cells(1).Value = "Gel. Rompope"
                End If
                If linea.Cells(1).Value = "Leche deslactosada 1l" Then
                    linea.Cells(1).Value = "L. deslac. 1l"
                End If
                If linea.Cells(1).Value = "Pay queso chocolate" Then
                    linea.Cells(1).Value = "P. queso choco"
                End If
                If linea.Cells(1).Value = "Feliz Cumple con base" Then
                    linea.Cells(1).Value = "F.C. base"
                End If
                If linea.Cells(1).Value = "Caja Galletas .250 Kg" Then
                    linea.Cells(1).Value = "C. Galle. .250"
                End If
                If linea.Cells(1).Value = "Panqué de chocolate" Then
                    linea.Cells(1).Value = "Panqué de choco"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria barra" Then
                    linea.Cells(1).Value = "P. zana barra"
                End If
                If linea.Cells(1).Value = "Panqué de chabacano" Then
                    linea.Cells(1).Value = "Panqué chaba"
                End If
                If linea.Cells(1).Value = "Bolsa cafe ame 500gr" Then
                    linea.Cells(1).Value = "B. café a. 500"
                End If
                If linea.Cells(1).Value = "Bolsa cafe des 500gr" Then
                    linea.Cells(1).Value = "B. café d. 500gr"
                End If
                If linea.Cells(1).Value = "Gel. Med. Bombón" Then
                    linea.Cells(1).Value = "G.M. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó" Then
                    linea.Cells(1).Value = "G.M. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó esp." Then
                    linea.Cells(1).Value = "G.M. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Med. Betabel" Then
                    linea.Cells(1).Value = "G.M. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Med. Queso uva" Then
                    linea.Cells(1).Value = "G.M. Queso u"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tricolor" Then
                    linea.Cells(1).Value = "G.M. Tricolor"
                End If
                If linea.Cells(1).Value = "Caja Galletas .5 Kg" Then
                    linea.Cells(1).Value = "C. Galle .5"
                End If
                If linea.Cells(1).Value = "Gel. Med. Agua fruta" Then
                    linea.Cells(1).Value = "G.M. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Med. Rompope" Then
                    linea.Cells(1).Value = "G.M. Romp."
                End If
                If linea.Cells(1).Value = "Panqué elote barra" Then
                    linea.Cells(1).Value = "P. elote barra"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tuti fruti" Then
                    linea.Cells(1).Value = "G.M. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Med. Zanahoria" Then
                    linea.Cells(1).Value = "G.M. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Flores Arándanos" Then
                    linea.Cells(1).Value = "G. Flores A."
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 leches" Then
                    linea.Cells(1).Value = "G.M. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Agua fruta" Then
                    linea.Cells(1).Value = "G.G. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó esp." Then
                    linea.Cells(1).Value = "G.G. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Betabel" Then
                    linea.Cells(1).Value = "G.G. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Tuti fruti" Then
                    linea.Cells(1).Value = "G.G. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Rompope" Then
                    linea.Cells(1).Value = "G.G. Rompope"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 leches" Then
                    linea.Cells(1).Value = "G.G. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Zanahoria" Then
                    linea.Cells(1).Value = "G.G. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 chocolates" Then
                    linea.Cells(1).Value = "G.G. 3 choco"
                End If
                If linea.Cells(1).Value = "Caja Galletas 1 Kg" Then
                    linea.Cells(1).Value = "C. Galle 1"
                End If
                If linea.Cells(1).Value = "Pay queso zarza G." Then
                    linea.Cells(1).Value = "Pay q.zarza G."
                End If
                If linea.Cells(1).Value = "Gel. Vino tinto 22 cm" Then
                    linea.Cells(1).Value = "Gel. vino 22cm"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó" Then
                    linea.Cells(1).Value = "G.G. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Bombón" Then
                    linea.Cells(1).Value = "G.G. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 chocolates" Then
                    linea.Cells(1).Value = "G.M. 3 choco"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Queso uva" Then
                    linea.Cells(1).Value = "G.G. Queso u"
                End If
                If linea.Cells(1).Value = "Pay queso frutas G." Then
                    linea.Cells(1).Value = "Pay q.frutas G."
                End If
                If linea.Cells(1).Value = "Pay queso fresa G." Then
                    linea.Cells(1).Value = "Pay q.fresa G."
                End If
            Next


            'dibujar linea
            'dibujar linea
            e.Graphics.DrawLine(myPen, 0, 21, 770, 21) '+12
            e.Graphics.DrawLine(myPen, 0, 33, 770, 33)
            e.Graphics.DrawLine(myPen, 0, 45, 770, 45)
            e.Graphics.DrawLine(myPen, 0, 57, 770, 57)
            e.Graphics.DrawLine(myPen, 0, 69, 770, 69)
            e.Graphics.DrawLine(myPen, 0, 81, 770, 81)
            e.Graphics.DrawLine(myPen, 0, 93, 770, 93)
            e.Graphics.DrawLine(myPen, 0, 105, 770, 105)
            e.Graphics.DrawLine(myPen, 0, 117, 770, 117)
            e.Graphics.DrawLine(myPen, 0, 129, 770, 129)
            e.Graphics.DrawLine(myPen, 0, 141, 770, 141)
            e.Graphics.DrawLine(myPen, 0, 153, 770, 153)
            e.Graphics.DrawLine(myPen, 0, 165, 770, 165)
            e.Graphics.DrawLine(myPen, 0, 177, 770, 177)
            e.Graphics.DrawLine(myPen, 0, 189, 770, 189)
            e.Graphics.DrawLine(myPen, 0, 201, 770, 201)
            e.Graphics.DrawLine(myPen, 0, 213, 770, 213)
            e.Graphics.DrawLine(myPen, 0, 225, 770, 225)
            e.Graphics.DrawLine(myPen, 0, 237, 770, 237)
            e.Graphics.DrawLine(myPen, 0, 249, 770, 249)
            e.Graphics.DrawLine(myPen, 0, 261, 770, 261)
            e.Graphics.DrawLine(myPen, 0, 273, 770, 273)
            e.Graphics.DrawLine(myPen, 0, 285, 770, 285) 'hasta 31
            e.Graphics.DrawLine(myPen, 0, 297, 770, 297)
            e.Graphics.DrawLine(myPen, 0, 309, 770, 309)
            e.Graphics.DrawLine(myPen, 0, 321, 770, 321)
            e.Graphics.DrawLine(myPen, 0, 333, 770, 333)
            e.Graphics.DrawLine(myPen, 0, 345, 770, 345)
            e.Graphics.DrawLine(myPen, 0, 357, 770, 357)
            e.Graphics.DrawLine(myPen, 0, 369, 770, 369)
            e.Graphics.DrawLine(myPen, 0, 381, 770, 381)


            'aqui inician livbres las lineas
            e.Graphics.DrawLine(myPen, 0, 393, 560, 393)
            e.Graphics.DrawLine(myPen, 0, 405, 560, 405)
            e.Graphics.DrawLine(myPen, 0, 417, 560, 417)
            e.Graphics.DrawLine(myPen, 0, 429, 560, 429)
            e.Graphics.DrawLine(myPen, 0, 441, 560, 441)
            e.Graphics.DrawLine(myPen, 0, 453, 560, 453)
            e.Graphics.DrawLine(myPen, 0, 465, 560, 465)
            e.Graphics.DrawLine(myPen, 0, 477, 560, 477)
            e.Graphics.DrawLine(myPen, 0, 489, 560, 489)
            e.Graphics.DrawLine(myPen, 0, 501, 560, 501)
            e.Graphics.DrawLine(myPen, 0, 513, 560, 513)
            e.Graphics.DrawLine(myPen, 0, 525, 560, 525)
            e.Graphics.DrawLine(myPen, 0, 537, 560, 537)
            e.Graphics.DrawLine(myPen, 0, 549, 560, 549)
            e.Graphics.DrawLine(myPen, 0, 561, 560, 561)
            e.Graphics.DrawLine(myPen, 0, 573, 560, 573)
            e.Graphics.DrawLine(myPen, 0, 585, 560, 585)
            e.Graphics.DrawLine(myPen, 0, 597, 560, 597)
            e.Graphics.DrawLine(myPen, 0, 609, 560, 609)
            e.Graphics.DrawLine(myPen, 0, 621, 560, 621)
            e.Graphics.DrawLine(myPen, 0, 633, 560, 633)
            e.Graphics.DrawLine(myPen, 0, 645, 560, 645)
            e.Graphics.DrawLine(myPen, 0, 657, 560, 657)
            e.Graphics.DrawLine(myPen, 0, 669, 560, 669)
            e.Graphics.DrawLine(myPen, 0, 681, 560, 681)
            e.Graphics.DrawLine(myPen, 0, 693, 560, 693)
            e.Graphics.DrawLine(myPen, 0, 705, 560, 705)
            e.Graphics.DrawLine(myPen, 0, 717, 560, 717)
            e.Graphics.DrawLine(myPen, 0, 729, 560, 729)
            e.Graphics.DrawLine(myPen, 0, 741, 560, 741)
            e.Graphics.DrawLine(myPen, 0, 753, 560, 753)
            e.Graphics.DrawLine(myPen, 0, 765, 560, 765)
            e.Graphics.DrawLine(myPen, 0, 777, 560, 777)
            e.Graphics.DrawLine(myPen, 0, 789, 560, 789)
            e.Graphics.DrawLine(myPen, 0, 801, 560, 801)
            e.Graphics.DrawLine(myPen, 0, 813, 560, 813)
            e.Graphics.DrawLine(myPen, 0, 825, 560, 825)
            e.Graphics.DrawLine(myPen, 0, 837, 560, 837)
            e.Graphics.DrawLine(myPen, 0, 849, 560, 849)
            e.Graphics.DrawLine(myPen, 0, 861, 560, 861)
            e.Graphics.DrawLine(myPen, 0, 873, 560, 873)
            e.Graphics.DrawLine(myPen, 0, 885, 560, 885)
            e.Graphics.DrawLine(myPen, 0, 897, 560, 897)
            e.Graphics.DrawLine(myPen, 0, 909, 560, 909)
            e.Graphics.DrawLine(myPen, 0, 921, 560, 921)
            e.Graphics.DrawLine(myPen, 0, 933, 560, 933)
            e.Graphics.DrawLine(myPen, 0, 945, 560, 945)
            e.Graphics.DrawLine(myPen, 0, 957, 560, 957)
            e.Graphics.DrawLine(myPen, 0, 969, 560, 969)
            e.Graphics.DrawLine(myPen, 0, 981, 560, 981)
            e.Graphics.DrawLine(myPen, 0, 993, 560, 993)
            e.Graphics.DrawLine(myPen, 0, 1005, 560, 1005)
            e.Graphics.DrawLine(myPen, 0, 1017, 560, 1017)
            e.Graphics.DrawLine(myPen, 0, 1029, 560, 1029)
            e.Graphics.DrawLine(myPen, 0, 1041, 560, 1041)
            e.Graphics.DrawLine(myPen, 0, 1053, 560, 1053)
            e.Graphics.DrawLine(myPen, 0, 1065, 560, 1065)
            e.Graphics.DrawLine(myPen, 0, 1077, 560, 1077)
            e.Graphics.DrawLine(myPen, 0, 1089, 560, 1089)
            e.Graphics.DrawLine(myPen, 0, 1101, 560, 1101)
            e.Graphics.DrawLine(myPen, 0, 1113, 560, 1113)
            e.Graphics.DrawLine(myPen, 0, 1125, 560, 1125)
            e.Graphics.DrawLine(myPen, 0, 1137, 560, 1137)
            e.Graphics.DrawLine(myPen, 0, 1149, 560, 1149)
            e.Graphics.DrawLine(myPen, 0, 1161, 560, 1161)
            e.Graphics.DrawLine(myPen, 0, 1173, 560, 1173)
            e.Graphics.DrawLine(myPen, 0, 1185, 560, 1185)
            e.Graphics.DrawLine(myPen, 0, 1197, 560, 1197)
            e.Graphics.DrawLine(myPen, 0, 1209, 560, 1209)
            e.Graphics.DrawLine(myPen, 0, 1221, 560, 1221)
            e.Graphics.DrawLine(myPen, 0, 1233, 560, 1233)
            e.Graphics.DrawLine(myPen, 0, 1245, 560, 1245)
            e.Graphics.DrawLine(myPen, 0, 1257, 560, 1257)
            e.Graphics.DrawLine(myPen, 0, 1269, 560, 1269)

            e.Graphics.DrawLine(myPen, 0, 1281, 560, 1281)
            e.Graphics.DrawLine(myPen, 0, 1293, 560, 1293)
            e.Graphics.DrawLine(myPen, 0, 1305, 560, 1305)
            e.Graphics.DrawLine(myPen, 0, 1317, 560, 1317)
            e.Graphics.DrawLine(myPen, 0, 1329, 560, 1329)
            e.Graphics.DrawLine(myPen, 0, 1341, 560, 1341)



            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 0, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 100, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 135, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 190, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 290, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 325, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 380, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 480, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 515, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 570, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 670, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 705, 6)


            If DataGridView1.Rows.Count > 180 Then

                While i < 110

                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 0, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(11, i).Value, prFont1, Brushes.Black, 110, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 140, i * 12 + 20)
                    i += 1


                End While


                While i < 220
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 190, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(11, i).Value, prFont1, Brushes.Black, 300, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 330, i * 12 - 1300)
                    i += 1


                End While

                While i < 330
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 380, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(11, i).Value, prFont1, Brushes.Black, 490, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 520, i * 12 - 2620)
                    i += 1


                End While

                While i < DataGridView1.Rows.Count
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 570, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(11, i).Value, prFont1, Brushes.Black, 680, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 710, i * 12 - 3940)
                    i += 1


                End While


            End If

        End If




        If TextBox1.Text = "Adolfo" Then

            Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
            PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            e.Graphics.DrawImage(bm, 600, 1050)
            Dim i As Integer = 0
            Dim i1 As Integer = 0
            Dim i11 As Integer = 0
            Dim line As String = Nothing
            Dim myPen = New Pen(Color.Black, 1)
            Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
            Dim prFont2 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
            Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
            Dim prFont9 As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
            Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
            e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 600, 1120) '65
            e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 610, 1130) '75
            e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 600, 1145) '90
            e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 600, 1160) '105
            e.Graphics.DrawString(DateTimePicker2.Value, prFont2, Brushes.Black, 650, 1160) '105
            e.Graphics.DrawString("HOJA DE CHOFER DE SISTEMA.", prFont2, Brushes.Black, 600, 1185) '130
            e.Graphics.DrawString("Sucursal:", prFont2, Brushes.Black, 600, 1200) '145
            e.Graphics.DrawString(TextBox1.Text, prFont9, Brushes.Black, 660, 1200) '145
            e.Graphics.DrawString("Chofer:", prFont2, Brushes.Black, 600, 1220)
            ' e.Graphics.DrawString(TextBox156.Text, prFont9, Brushes.Black, 660, 1220)
            ' e.Graphics.DrawString("ANOTACIONES:", prFont9, Brushes.Black, 600, 185)

            Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows
                If linea.Cells(1).Value = "Concha blanca int." Then
                    linea.Cells(1).Value = "Concha bca. int."
                End If
                If linea.Cells(1).Value = "Minirosquita Janeth" Then
                    linea.Cells(1).Value = "Rosquita Janeth"
                End If
                If linea.Cells(1).Value = "Cuerno mantequilla" Then
                    linea.Cells(1).Value = "Cuerno mante"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria" Then
                    linea.Cells(1).Value = "Panqué de zana"
                End If
                If linea.Cells(1).Value = "Gel. Dominó especial" Then
                    linea.Cells(1).Value = "Gel. Dom. esp."
                End If
                If linea.Cells(1).Value = "Gel. Rompope fruta" Then
                    linea.Cells(1).Value = "Gel. Rompope"
                End If
                If linea.Cells(1).Value = "Leche deslactosada 1l" Then
                    linea.Cells(1).Value = "L. deslac. 1l"
                End If
                If linea.Cells(1).Value = "Pay queso chocolate" Then
                    linea.Cells(1).Value = "P. queso choco"
                End If
                If linea.Cells(1).Value = "Feliz Cumple con base" Then
                    linea.Cells(1).Value = "F.C. base"
                End If
                If linea.Cells(1).Value = "Caja Galletas .250 Kg" Then
                    linea.Cells(1).Value = "C. Galle. .250"
                End If
                If linea.Cells(1).Value = "Panqué de chocolate" Then
                    linea.Cells(1).Value = "Panqué de choco"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria barra" Then
                    linea.Cells(1).Value = "P. zana barra"
                End If
                If linea.Cells(1).Value = "Panqué de chabacano" Then
                    linea.Cells(1).Value = "Panqué chaba"
                End If
                If linea.Cells(1).Value = "Bolsa cafe ame 500gr" Then
                    linea.Cells(1).Value = "B. café a. 500"
                End If
                If linea.Cells(1).Value = "Bolsa cafe des 500gr" Then
                    linea.Cells(1).Value = "B. café d. 500gr"
                End If
                If linea.Cells(1).Value = "Gel. Med. Bombón" Then
                    linea.Cells(1).Value = "G.M. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó" Then
                    linea.Cells(1).Value = "G.M. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó esp." Then
                    linea.Cells(1).Value = "G.M. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Med. Betabel" Then
                    linea.Cells(1).Value = "G.M. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Med. Queso uva" Then
                    linea.Cells(1).Value = "G.M. Queso u"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tricolor" Then
                    linea.Cells(1).Value = "G.M. Tricolor"
                End If
                If linea.Cells(1).Value = "Caja Galletas .5 Kg" Then
                    linea.Cells(1).Value = "C. Galle .5"
                End If
                If linea.Cells(1).Value = "Gel. Med. Agua fruta" Then
                    linea.Cells(1).Value = "G.M. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Med. Rompope" Then
                    linea.Cells(1).Value = "G.M. Romp."
                End If
                If linea.Cells(1).Value = "Panqué elote barra" Then
                    linea.Cells(1).Value = "P. elote barra"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tuti fruti" Then
                    linea.Cells(1).Value = "G.M. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Med. Zanahoria" Then
                    linea.Cells(1).Value = "G.M. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Flores Arándanos" Then
                    linea.Cells(1).Value = "G. Flores A."
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 leches" Then
                    linea.Cells(1).Value = "G.M. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Agua fruta" Then
                    linea.Cells(1).Value = "G.G. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó esp." Then
                    linea.Cells(1).Value = "G.G. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Betabel" Then
                    linea.Cells(1).Value = "G.G. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Tuti fruti" Then
                    linea.Cells(1).Value = "G.G. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Rompope" Then
                    linea.Cells(1).Value = "G.G. Rompope"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 leches" Then
                    linea.Cells(1).Value = "G.G. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Zanahoria" Then
                    linea.Cells(1).Value = "G.G. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 chocolates" Then
                    linea.Cells(1).Value = "G.G. 3 choco"
                End If
                If linea.Cells(1).Value = "Caja Galletas 1 Kg" Then
                    linea.Cells(1).Value = "C. Galle 1"
                End If
                If linea.Cells(1).Value = "Pay queso zarza G." Then
                    linea.Cells(1).Value = "Pay q.zarza G."
                End If
                If linea.Cells(1).Value = "Gel. Vino tinto 22 cm" Then
                    linea.Cells(1).Value = "Gel. vino 22cm"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó" Then
                    linea.Cells(1).Value = "G.G. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Bombón" Then
                    linea.Cells(1).Value = "G.G. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 chocolates" Then
                    linea.Cells(1).Value = "G.M. 3 choco"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Queso uva" Then
                    linea.Cells(1).Value = "G.G. Queso u"
                End If
                If linea.Cells(1).Value = "Pay queso frutas G." Then
                    linea.Cells(1).Value = "Pay q.frutas G."
                End If
                If linea.Cells(1).Value = "Pay queso fresa G." Then
                    linea.Cells(1).Value = "Pay q.fresa G."
                End If
            Next


            'dibujar linea
            'dibujar linea
            e.Graphics.DrawLine(myPen, 0, 21, 770, 21) '+12
            e.Graphics.DrawLine(myPen, 0, 33, 770, 33)
            e.Graphics.DrawLine(myPen, 0, 45, 770, 45)
            e.Graphics.DrawLine(myPen, 0, 57, 770, 57)
            e.Graphics.DrawLine(myPen, 0, 69, 770, 69)
            e.Graphics.DrawLine(myPen, 0, 81, 770, 81)
            e.Graphics.DrawLine(myPen, 0, 93, 770, 93)
            e.Graphics.DrawLine(myPen, 0, 105, 770, 105)
            e.Graphics.DrawLine(myPen, 0, 117, 770, 117)
            e.Graphics.DrawLine(myPen, 0, 129, 770, 129)
            e.Graphics.DrawLine(myPen, 0, 141, 770, 141)
            e.Graphics.DrawLine(myPen, 0, 153, 770, 153)
            e.Graphics.DrawLine(myPen, 0, 165, 770, 165)
            e.Graphics.DrawLine(myPen, 0, 177, 770, 177)
            e.Graphics.DrawLine(myPen, 0, 189, 770, 189)
            e.Graphics.DrawLine(myPen, 0, 201, 770, 201)
            e.Graphics.DrawLine(myPen, 0, 213, 770, 213)
            e.Graphics.DrawLine(myPen, 0, 225, 770, 225)
            e.Graphics.DrawLine(myPen, 0, 237, 770, 237)
            e.Graphics.DrawLine(myPen, 0, 249, 770, 249)
            e.Graphics.DrawLine(myPen, 0, 261, 770, 261)
            e.Graphics.DrawLine(myPen, 0, 273, 770, 273)
            e.Graphics.DrawLine(myPen, 0, 285, 770, 285) 'hasta 31
            e.Graphics.DrawLine(myPen, 0, 297, 770, 297)
            e.Graphics.DrawLine(myPen, 0, 309, 770, 309)
            e.Graphics.DrawLine(myPen, 0, 321, 770, 321)
            e.Graphics.DrawLine(myPen, 0, 333, 770, 333)
            e.Graphics.DrawLine(myPen, 0, 345, 770, 345)
            e.Graphics.DrawLine(myPen, 0, 357, 770, 357)
            e.Graphics.DrawLine(myPen, 0, 369, 770, 369)
            e.Graphics.DrawLine(myPen, 0, 381, 770, 381)


            'aqui inician livbres las lineas
            e.Graphics.DrawLine(myPen, 0, 393, 560, 393)
            e.Graphics.DrawLine(myPen, 0, 405, 560, 405)
            e.Graphics.DrawLine(myPen, 0, 417, 560, 417)
            e.Graphics.DrawLine(myPen, 0, 429, 560, 429)
            e.Graphics.DrawLine(myPen, 0, 441, 560, 441)
            e.Graphics.DrawLine(myPen, 0, 453, 560, 453)
            e.Graphics.DrawLine(myPen, 0, 465, 560, 465)
            e.Graphics.DrawLine(myPen, 0, 477, 560, 477)
            e.Graphics.DrawLine(myPen, 0, 489, 560, 489)
            e.Graphics.DrawLine(myPen, 0, 501, 560, 501)
            e.Graphics.DrawLine(myPen, 0, 513, 560, 513)
            e.Graphics.DrawLine(myPen, 0, 525, 560, 525)
            e.Graphics.DrawLine(myPen, 0, 537, 560, 537)
            e.Graphics.DrawLine(myPen, 0, 549, 560, 549)
            e.Graphics.DrawLine(myPen, 0, 561, 560, 561)
            e.Graphics.DrawLine(myPen, 0, 573, 560, 573)
            e.Graphics.DrawLine(myPen, 0, 585, 560, 585)
            e.Graphics.DrawLine(myPen, 0, 597, 560, 597)
            e.Graphics.DrawLine(myPen, 0, 609, 560, 609)
            e.Graphics.DrawLine(myPen, 0, 621, 560, 621)
            e.Graphics.DrawLine(myPen, 0, 633, 560, 633)
            e.Graphics.DrawLine(myPen, 0, 645, 560, 645)
            e.Graphics.DrawLine(myPen, 0, 657, 560, 657)
            e.Graphics.DrawLine(myPen, 0, 669, 560, 669)
            e.Graphics.DrawLine(myPen, 0, 681, 560, 681)
            e.Graphics.DrawLine(myPen, 0, 693, 560, 693)
            e.Graphics.DrawLine(myPen, 0, 705, 560, 705)
            e.Graphics.DrawLine(myPen, 0, 717, 560, 717)
            e.Graphics.DrawLine(myPen, 0, 729, 560, 729)
            e.Graphics.DrawLine(myPen, 0, 741, 560, 741)
            e.Graphics.DrawLine(myPen, 0, 753, 560, 753)
            e.Graphics.DrawLine(myPen, 0, 765, 560, 765)
            e.Graphics.DrawLine(myPen, 0, 777, 560, 777)
            e.Graphics.DrawLine(myPen, 0, 789, 560, 789)
            e.Graphics.DrawLine(myPen, 0, 801, 560, 801)
            e.Graphics.DrawLine(myPen, 0, 813, 560, 813)
            e.Graphics.DrawLine(myPen, 0, 825, 560, 825)
            e.Graphics.DrawLine(myPen, 0, 837, 560, 837)
            e.Graphics.DrawLine(myPen, 0, 849, 560, 849)
            e.Graphics.DrawLine(myPen, 0, 861, 560, 861)
            e.Graphics.DrawLine(myPen, 0, 873, 560, 873)
            e.Graphics.DrawLine(myPen, 0, 885, 560, 885)
            e.Graphics.DrawLine(myPen, 0, 897, 560, 897)
            e.Graphics.DrawLine(myPen, 0, 909, 560, 909)
            e.Graphics.DrawLine(myPen, 0, 921, 560, 921)
            e.Graphics.DrawLine(myPen, 0, 933, 560, 933)
            e.Graphics.DrawLine(myPen, 0, 945, 560, 945)
            e.Graphics.DrawLine(myPen, 0, 957, 560, 957)
            e.Graphics.DrawLine(myPen, 0, 969, 560, 969)
            e.Graphics.DrawLine(myPen, 0, 981, 560, 981)
            e.Graphics.DrawLine(myPen, 0, 993, 560, 993)
            e.Graphics.DrawLine(myPen, 0, 1005, 560, 1005)
            e.Graphics.DrawLine(myPen, 0, 1017, 560, 1017)
            e.Graphics.DrawLine(myPen, 0, 1029, 560, 1029)
            e.Graphics.DrawLine(myPen, 0, 1041, 560, 1041)
            e.Graphics.DrawLine(myPen, 0, 1053, 560, 1053)
            e.Graphics.DrawLine(myPen, 0, 1065, 560, 1065)
            e.Graphics.DrawLine(myPen, 0, 1077, 560, 1077)
            e.Graphics.DrawLine(myPen, 0, 1089, 560, 1089)
            e.Graphics.DrawLine(myPen, 0, 1101, 560, 1101)
            e.Graphics.DrawLine(myPen, 0, 1113, 560, 1113)
            e.Graphics.DrawLine(myPen, 0, 1125, 560, 1125)
            e.Graphics.DrawLine(myPen, 0, 1137, 560, 1137)
            e.Graphics.DrawLine(myPen, 0, 1149, 560, 1149)
            e.Graphics.DrawLine(myPen, 0, 1161, 560, 1161)
            e.Graphics.DrawLine(myPen, 0, 1173, 560, 1173)
            e.Graphics.DrawLine(myPen, 0, 1185, 560, 1185)
            e.Graphics.DrawLine(myPen, 0, 1197, 560, 1197)
            e.Graphics.DrawLine(myPen, 0, 1209, 560, 1209)
            e.Graphics.DrawLine(myPen, 0, 1221, 560, 1221)
            e.Graphics.DrawLine(myPen, 0, 1233, 560, 1233)
            e.Graphics.DrawLine(myPen, 0, 1245, 560, 1245)
            e.Graphics.DrawLine(myPen, 0, 1257, 560, 1257)
            e.Graphics.DrawLine(myPen, 0, 1269, 560, 1269)

            e.Graphics.DrawLine(myPen, 0, 1281, 560, 1281)
            e.Graphics.DrawLine(myPen, 0, 1293, 560, 1293)
            e.Graphics.DrawLine(myPen, 0, 1305, 560, 1305)
            e.Graphics.DrawLine(myPen, 0, 1317, 560, 1317)
            e.Graphics.DrawLine(myPen, 0, 1329, 560, 1329)
            e.Graphics.DrawLine(myPen, 0, 1341, 560, 1341)


            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 0, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 100, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 135, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 190, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 290, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 325, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 380, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 480, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 515, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 570, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 670, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 705, 6)


            If DataGridView1.Rows.Count > 180 Then

                While i < 110

                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 0, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(3, i).Value, prFont1, Brushes.Black, 110, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 140, i * 12 + 20)
                    i += 1


                End While


                While i < 220
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 190, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(3, i).Value, prFont1, Brushes.Black, 300, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 330, i * 12 - 1300)
                    i += 1


                End While

                While i < 330
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 380, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(3, i).Value, prFont1, Brushes.Black, 490, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 520, i * 12 - 2620)
                    i += 1


                End While

                While i < DataGridView1.Rows.Count
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 570, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(3, i).Value, prFont1, Brushes.Black, 680, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 710, i * 12 - 3940)
                    i += 1


                End While


            End If

        End If




        If TextBox1.Text = "T Chicas" Then

            Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
            PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            e.Graphics.DrawImage(bm, 600, 1050)
            Dim i As Integer = 0
            Dim i1 As Integer = 0
            Dim i11 As Integer = 0
            Dim line As String = Nothing
            Dim myPen = New Pen(Color.Black, 1)
            Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
            Dim prFont2 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
            Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
            Dim prFont9 As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
            Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
            e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 600, 1120) '65
            e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 610, 1130) '75
            e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 600, 1145) '90
            e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 600, 1160) '105
            e.Graphics.DrawString(DateTimePicker2.Value, prFont2, Brushes.Black, 650, 1160) '105
            e.Graphics.DrawString("HOJA DE CHOFER DE SISTEMA.", prFont2, Brushes.Black, 600, 1185) '130
            e.Graphics.DrawString("Sucursal:", prFont2, Brushes.Black, 600, 1200) '145
            e.Graphics.DrawString(TextBox1.Text, prFont9, Brushes.Black, 660, 1200) '145
            e.Graphics.DrawString("Chofer:", prFont2, Brushes.Black, 600, 1220)
            ' e.Graphics.DrawString(TextBox156.Text, prFont9, Brushes.Black, 660, 1220)
            ' e.Graphics.DrawString("ANOTACIONES:", prFont9, Brushes.Black, 600, 185)

            Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows
                If linea.Cells(1).Value = "Concha blanca int." Then
                    linea.Cells(1).Value = "Concha bca. int."
                End If
                If linea.Cells(1).Value = "Minirosquita Janeth" Then
                    linea.Cells(1).Value = "Rosquita Janeth"
                End If
                If linea.Cells(1).Value = "Cuerno mantequilla" Then
                    linea.Cells(1).Value = "Cuerno mante"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria" Then
                    linea.Cells(1).Value = "Panqué de zana"
                End If
                If linea.Cells(1).Value = "Gel. Dominó especial" Then
                    linea.Cells(1).Value = "Gel. Dom. esp."
                End If
                If linea.Cells(1).Value = "Gel. Rompope fruta" Then
                    linea.Cells(1).Value = "Gel. Rompope"
                End If
                If linea.Cells(1).Value = "Leche deslactosada 1l" Then
                    linea.Cells(1).Value = "L. deslac. 1l"
                End If
                If linea.Cells(1).Value = "Pay queso chocolate" Then
                    linea.Cells(1).Value = "P. queso choco"
                End If
                If linea.Cells(1).Value = "Feliz Cumple con base" Then
                    linea.Cells(1).Value = "F.C. base"
                End If
                If linea.Cells(1).Value = "Caja Galletas .250 Kg" Then
                    linea.Cells(1).Value = "C. Galle. .250"
                End If
                If linea.Cells(1).Value = "Panqué de chocolate" Then
                    linea.Cells(1).Value = "Panqué de choco"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria barra" Then
                    linea.Cells(1).Value = "P. zana barra"
                End If
                If linea.Cells(1).Value = "Panqué de chabacano" Then
                    linea.Cells(1).Value = "Panqué chaba"
                End If
                If linea.Cells(1).Value = "Bolsa cafe ame 500gr" Then
                    linea.Cells(1).Value = "B. café a. 500"
                End If
                If linea.Cells(1).Value = "Bolsa cafe des 500gr" Then
                    linea.Cells(1).Value = "B. café d. 500gr"
                End If
                If linea.Cells(1).Value = "Gel. Med. Bombón" Then
                    linea.Cells(1).Value = "G.M. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó" Then
                    linea.Cells(1).Value = "G.M. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó esp." Then
                    linea.Cells(1).Value = "G.M. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Med. Betabel" Then
                    linea.Cells(1).Value = "G.M. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Med. Queso uva" Then
                    linea.Cells(1).Value = "G.M. Queso u"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tricolor" Then
                    linea.Cells(1).Value = "G.M. Tricolor"
                End If
                If linea.Cells(1).Value = "Caja Galletas .5 Kg" Then
                    linea.Cells(1).Value = "C. Galle .5"
                End If
                If linea.Cells(1).Value = "Gel. Med. Agua fruta" Then
                    linea.Cells(1).Value = "G.M. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Med. Rompope" Then
                    linea.Cells(1).Value = "G.M. Romp."
                End If
                If linea.Cells(1).Value = "Panqué elote barra" Then
                    linea.Cells(1).Value = "P. elote barra"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tuti fruti" Then
                    linea.Cells(1).Value = "G.M. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Med. Zanahoria" Then
                    linea.Cells(1).Value = "G.M. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Flores Arándanos" Then
                    linea.Cells(1).Value = "G. Flores A."
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 leches" Then
                    linea.Cells(1).Value = "G.M. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Agua fruta" Then
                    linea.Cells(1).Value = "G.G. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó esp." Then
                    linea.Cells(1).Value = "G.G. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Betabel" Then
                    linea.Cells(1).Value = "G.G. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Tuti fruti" Then
                    linea.Cells(1).Value = "G.G. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Rompope" Then
                    linea.Cells(1).Value = "G.G. Rompope"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 leches" Then
                    linea.Cells(1).Value = "G.G. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Zanahoria" Then
                    linea.Cells(1).Value = "G.G. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 chocolates" Then
                    linea.Cells(1).Value = "G.G. 3 choco"
                End If
                If linea.Cells(1).Value = "Caja Galletas 1 Kg" Then
                    linea.Cells(1).Value = "C. Galle 1"
                End If
                If linea.Cells(1).Value = "Pay queso zarza G." Then
                    linea.Cells(1).Value = "Pay q.zarza G."
                End If
                If linea.Cells(1).Value = "Gel. Vino tinto 22 cm" Then
                    linea.Cells(1).Value = "Gel. vino 22cm"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó" Then
                    linea.Cells(1).Value = "G.G. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Bombón" Then
                    linea.Cells(1).Value = "G.G. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 chocolates" Then
                    linea.Cells(1).Value = "G.M. 3 choco"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Queso uva" Then
                    linea.Cells(1).Value = "G.G. Queso u"
                End If
                If linea.Cells(1).Value = "Pay queso frutas G." Then
                    linea.Cells(1).Value = "Pay q.frutas G."
                End If
                If linea.Cells(1).Value = "Pay queso fresa G." Then
                    linea.Cells(1).Value = "Pay q.fresa G."
                End If
            Next


            'dibujar linea
            e.Graphics.DrawLine(myPen, 0, 21, 770, 21) '+12
            e.Graphics.DrawLine(myPen, 0, 33, 770, 33)
            e.Graphics.DrawLine(myPen, 0, 45, 770, 45)
            e.Graphics.DrawLine(myPen, 0, 57, 770, 57)
            e.Graphics.DrawLine(myPen, 0, 69, 770, 69)
            e.Graphics.DrawLine(myPen, 0, 81, 770, 81)
            e.Graphics.DrawLine(myPen, 0, 93, 770, 93)
            e.Graphics.DrawLine(myPen, 0, 105, 770, 105)
            e.Graphics.DrawLine(myPen, 0, 117, 770, 117)
            e.Graphics.DrawLine(myPen, 0, 129, 770, 129)
            e.Graphics.DrawLine(myPen, 0, 141, 770, 141)
            e.Graphics.DrawLine(myPen, 0, 153, 770, 153)
            e.Graphics.DrawLine(myPen, 0, 165, 770, 165)
            e.Graphics.DrawLine(myPen, 0, 177, 770, 177)
            e.Graphics.DrawLine(myPen, 0, 189, 770, 189)
            e.Graphics.DrawLine(myPen, 0, 201, 770, 201)
            e.Graphics.DrawLine(myPen, 0, 213, 770, 213)
            e.Graphics.DrawLine(myPen, 0, 225, 770, 225)
            e.Graphics.DrawLine(myPen, 0, 237, 770, 237)
            e.Graphics.DrawLine(myPen, 0, 249, 770, 249)
            e.Graphics.DrawLine(myPen, 0, 261, 770, 261)
            e.Graphics.DrawLine(myPen, 0, 273, 770, 273)
            e.Graphics.DrawLine(myPen, 0, 285, 770, 285) 'hasta 31
            e.Graphics.DrawLine(myPen, 0, 297, 770, 297)
            e.Graphics.DrawLine(myPen, 0, 309, 770, 309)
            e.Graphics.DrawLine(myPen, 0, 321, 770, 321)
            e.Graphics.DrawLine(myPen, 0, 333, 770, 333)
            e.Graphics.DrawLine(myPen, 0, 345, 770, 345)
            e.Graphics.DrawLine(myPen, 0, 357, 770, 357)
            e.Graphics.DrawLine(myPen, 0, 369, 770, 369)
            e.Graphics.DrawLine(myPen, 0, 381, 770, 381)


            'aqui inician livbres las lineas
            e.Graphics.DrawLine(myPen, 0, 393, 560, 393)
            e.Graphics.DrawLine(myPen, 0, 405, 560, 405)
            e.Graphics.DrawLine(myPen, 0, 417, 560, 417)
            e.Graphics.DrawLine(myPen, 0, 429, 560, 429)
            e.Graphics.DrawLine(myPen, 0, 441, 560, 441)
            e.Graphics.DrawLine(myPen, 0, 453, 560, 453)
            e.Graphics.DrawLine(myPen, 0, 465, 560, 465)
            e.Graphics.DrawLine(myPen, 0, 477, 560, 477)
            e.Graphics.DrawLine(myPen, 0, 489, 560, 489)
            e.Graphics.DrawLine(myPen, 0, 501, 560, 501)
            e.Graphics.DrawLine(myPen, 0, 513, 560, 513)
            e.Graphics.DrawLine(myPen, 0, 525, 560, 525)
            e.Graphics.DrawLine(myPen, 0, 537, 560, 537)
            e.Graphics.DrawLine(myPen, 0, 549, 560, 549)
            e.Graphics.DrawLine(myPen, 0, 561, 560, 561)
            e.Graphics.DrawLine(myPen, 0, 573, 560, 573)
            e.Graphics.DrawLine(myPen, 0, 585, 560, 585)
            e.Graphics.DrawLine(myPen, 0, 597, 560, 597)
            e.Graphics.DrawLine(myPen, 0, 609, 560, 609)
            e.Graphics.DrawLine(myPen, 0, 621, 560, 621)
            e.Graphics.DrawLine(myPen, 0, 633, 560, 633)
            e.Graphics.DrawLine(myPen, 0, 645, 560, 645)
            e.Graphics.DrawLine(myPen, 0, 657, 560, 657)
            e.Graphics.DrawLine(myPen, 0, 669, 560, 669)
            e.Graphics.DrawLine(myPen, 0, 681, 560, 681)
            e.Graphics.DrawLine(myPen, 0, 693, 560, 693)
            e.Graphics.DrawLine(myPen, 0, 705, 560, 705)
            e.Graphics.DrawLine(myPen, 0, 717, 560, 717)
            e.Graphics.DrawLine(myPen, 0, 729, 560, 729)
            e.Graphics.DrawLine(myPen, 0, 741, 560, 741)
            e.Graphics.DrawLine(myPen, 0, 753, 560, 753)
            e.Graphics.DrawLine(myPen, 0, 765, 560, 765)
            e.Graphics.DrawLine(myPen, 0, 777, 560, 777)
            e.Graphics.DrawLine(myPen, 0, 789, 560, 789)
            e.Graphics.DrawLine(myPen, 0, 801, 560, 801)
            e.Graphics.DrawLine(myPen, 0, 813, 560, 813)
            e.Graphics.DrawLine(myPen, 0, 825, 560, 825)
            e.Graphics.DrawLine(myPen, 0, 837, 560, 837)
            e.Graphics.DrawLine(myPen, 0, 849, 560, 849)
            e.Graphics.DrawLine(myPen, 0, 861, 560, 861)
            e.Graphics.DrawLine(myPen, 0, 873, 560, 873)
            e.Graphics.DrawLine(myPen, 0, 885, 560, 885)
            e.Graphics.DrawLine(myPen, 0, 897, 560, 897)
            e.Graphics.DrawLine(myPen, 0, 909, 560, 909)
            e.Graphics.DrawLine(myPen, 0, 921, 560, 921)
            e.Graphics.DrawLine(myPen, 0, 933, 560, 933)
            e.Graphics.DrawLine(myPen, 0, 945, 560, 945)
            e.Graphics.DrawLine(myPen, 0, 957, 560, 957)
            e.Graphics.DrawLine(myPen, 0, 969, 560, 969)
            e.Graphics.DrawLine(myPen, 0, 981, 560, 981)
            e.Graphics.DrawLine(myPen, 0, 993, 560, 993)
            e.Graphics.DrawLine(myPen, 0, 1005, 560, 1005)
            e.Graphics.DrawLine(myPen, 0, 1017, 560, 1017)
            e.Graphics.DrawLine(myPen, 0, 1029, 560, 1029)
            e.Graphics.DrawLine(myPen, 0, 1041, 560, 1041)
            e.Graphics.DrawLine(myPen, 0, 1053, 560, 1053)
            e.Graphics.DrawLine(myPen, 0, 1065, 560, 1065)
            e.Graphics.DrawLine(myPen, 0, 1077, 560, 1077)
            e.Graphics.DrawLine(myPen, 0, 1089, 560, 1089)
            e.Graphics.DrawLine(myPen, 0, 1101, 560, 1101)
            e.Graphics.DrawLine(myPen, 0, 1113, 560, 1113)
            e.Graphics.DrawLine(myPen, 0, 1125, 560, 1125)
            e.Graphics.DrawLine(myPen, 0, 1137, 560, 1137)
            e.Graphics.DrawLine(myPen, 0, 1149, 560, 1149)
            e.Graphics.DrawLine(myPen, 0, 1161, 560, 1161)
            e.Graphics.DrawLine(myPen, 0, 1173, 560, 1173)
            e.Graphics.DrawLine(myPen, 0, 1185, 560, 1185)
            e.Graphics.DrawLine(myPen, 0, 1197, 560, 1197)
            e.Graphics.DrawLine(myPen, 0, 1209, 560, 1209)
            e.Graphics.DrawLine(myPen, 0, 1221, 560, 1221)
            e.Graphics.DrawLine(myPen, 0, 1233, 560, 1233)
            e.Graphics.DrawLine(myPen, 0, 1245, 560, 1245)
            e.Graphics.DrawLine(myPen, 0, 1257, 560, 1257)
            e.Graphics.DrawLine(myPen, 0, 1269, 560, 1269)

            e.Graphics.DrawLine(myPen, 0, 1281, 560, 1281)
            e.Graphics.DrawLine(myPen, 0, 1293, 560, 1293)
            e.Graphics.DrawLine(myPen, 0, 1305, 560, 1305)
            e.Graphics.DrawLine(myPen, 0, 1317, 560, 1317)
            e.Graphics.DrawLine(myPen, 0, 1329, 560, 1329)
            e.Graphics.DrawLine(myPen, 0, 1341, 560, 1341)



            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 0, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 100, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 135, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 190, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 290, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 325, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 380, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 480, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 515, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 570, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 670, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 705, 6)


            If DataGridView1.Rows.Count > 180 Then

                While i < 110

                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 0, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(14, i).Value, prFont1, Brushes.Black, 110, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 140, i * 12 + 20)
                    i += 1


                End While


                While i < 220
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 190, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(14, i).Value, prFont1, Brushes.Black, 300, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 330, i * 12 - 1300)
                    i += 1


                End While

                While i < 330
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 380, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(14, i).Value, prFont1, Brushes.Black, 490, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 520, i * 12 - 2620)
                    i += 1


                End While

                While i < DataGridView1.Rows.Count
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 570, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(14, i).Value, prFont1, Brushes.Black, 680, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 710, i * 12 - 3940)
                    i += 1


                End While


            End If

        End If




        If TextBox1.Text = "Metepec" Then

            Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
            PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            e.Graphics.DrawImage(bm, 600, 1050)
            Dim i As Integer = 0
            Dim i1 As Integer = 0
            Dim i11 As Integer = 0
            Dim line As String = Nothing
            Dim myPen = New Pen(Color.Black, 1)
            Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
            Dim prFont2 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
            Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
            Dim prFont9 As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
            Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
            e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 600, 1120) '65
            e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 610, 1130) '75
            e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 600, 1145) '90
            e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 600, 1160) '105
            e.Graphics.DrawString(DateTimePicker2.Value, prFont2, Brushes.Black, 650, 1160) '105
            e.Graphics.DrawString("HOJA DE CHOFER DE SISTEMA.", prFont2, Brushes.Black, 600, 1185) '130
            e.Graphics.DrawString("Sucursal:", prFont2, Brushes.Black, 600, 1200) '145
            e.Graphics.DrawString(TextBox1.Text, prFont9, Brushes.Black, 660, 1200) '145
            e.Graphics.DrawString("Chofer:", prFont2, Brushes.Black, 600, 1220)
            'e.Graphics.DrawString(TextBox156.Text, prFont9, Brushes.Black, 660, 1220)
            ' e.Graphics.DrawString("ANOTACIONES:", prFont9, Brushes.Black, 600, 185)

            Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows
                If linea.Cells(1).Value = "Concha blanca int." Then
                    linea.Cells(1).Value = "Concha bca. int."
                End If
                If linea.Cells(1).Value = "Minirosquita Janeth" Then
                    linea.Cells(1).Value = "Rosquita Janeth"
                End If
                If linea.Cells(1).Value = "Cuerno mantequilla" Then
                    linea.Cells(1).Value = "Cuerno mante"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria" Then
                    linea.Cells(1).Value = "Panqué de zana"
                End If
                If linea.Cells(1).Value = "Gel. Dominó especial" Then
                    linea.Cells(1).Value = "Gel. Dom. esp."
                End If
                If linea.Cells(1).Value = "Gel. Rompope fruta" Then
                    linea.Cells(1).Value = "Gel. Rompope"
                End If
                If linea.Cells(1).Value = "Leche deslactosada 1l" Then
                    linea.Cells(1).Value = "L. deslac. 1l"
                End If
                If linea.Cells(1).Value = "Pay queso chocolate" Then
                    linea.Cells(1).Value = "P. queso choco"
                End If
                If linea.Cells(1).Value = "Feliz Cumple con base" Then
                    linea.Cells(1).Value = "F.C. base"
                End If
                If linea.Cells(1).Value = "Caja Galletas .250 Kg" Then
                    linea.Cells(1).Value = "C. Galle. .250"
                End If
                If linea.Cells(1).Value = "Panqué de chocolate" Then
                    linea.Cells(1).Value = "Panqué de choco"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria barra" Then
                    linea.Cells(1).Value = "P. zana barra"
                End If
                If linea.Cells(1).Value = "Panqué de chabacano" Then
                    linea.Cells(1).Value = "Panqué chaba"
                End If
                If linea.Cells(1).Value = "Bolsa cafe ame 500gr" Then
                    linea.Cells(1).Value = "B. café a. 500"
                End If
                If linea.Cells(1).Value = "Bolsa cafe des 500gr" Then
                    linea.Cells(1).Value = "B. café d. 500gr"
                End If
                If linea.Cells(1).Value = "Gel. Med. Bombón" Then
                    linea.Cells(1).Value = "G.M. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó" Then
                    linea.Cells(1).Value = "G.M. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó esp." Then
                    linea.Cells(1).Value = "G.M. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Med. Betabel" Then
                    linea.Cells(1).Value = "G.M. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Med. Queso uva" Then
                    linea.Cells(1).Value = "G.M. Queso u"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tricolor" Then
                    linea.Cells(1).Value = "G.M. Tricolor"
                End If
                If linea.Cells(1).Value = "Caja Galletas .5 Kg" Then
                    linea.Cells(1).Value = "C. Galle .5"
                End If
                If linea.Cells(1).Value = "Gel. Med. Agua fruta" Then
                    linea.Cells(1).Value = "G.M. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Med. Rompope" Then
                    linea.Cells(1).Value = "G.M. Romp."
                End If
                If linea.Cells(1).Value = "Panqué elote barra" Then
                    linea.Cells(1).Value = "P. elote barra"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tuti fruti" Then
                    linea.Cells(1).Value = "G.M. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Med. Zanahoria" Then
                    linea.Cells(1).Value = "G.M. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Flores Arándanos" Then
                    linea.Cells(1).Value = "G. Flores A."
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 leches" Then
                    linea.Cells(1).Value = "G.M. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Agua fruta" Then
                    linea.Cells(1).Value = "G.G. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó esp." Then
                    linea.Cells(1).Value = "G.G. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Betabel" Then
                    linea.Cells(1).Value = "G.G. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Tuti fruti" Then
                    linea.Cells(1).Value = "G.G. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Rompope" Then
                    linea.Cells(1).Value = "G.G. Rompope"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 leches" Then
                    linea.Cells(1).Value = "G.G. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Zanahoria" Then
                    linea.Cells(1).Value = "G.G. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 chocolates" Then
                    linea.Cells(1).Value = "G.G. 3 choco"
                End If
                If linea.Cells(1).Value = "Caja Galletas 1 Kg" Then
                    linea.Cells(1).Value = "C. Galle 1"
                End If
                If linea.Cells(1).Value = "Pay queso zarza G." Then
                    linea.Cells(1).Value = "Pay q.zarza G."
                End If
                If linea.Cells(1).Value = "Gel. Vino tinto 22 cm" Then
                    linea.Cells(1).Value = "Gel. vino 22cm"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó" Then
                    linea.Cells(1).Value = "G.G. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Bombón" Then
                    linea.Cells(1).Value = "G.G. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 chocolates" Then
                    linea.Cells(1).Value = "G.M. 3 choco"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Queso uva" Then
                    linea.Cells(1).Value = "G.G. Queso u"
                End If
                If linea.Cells(1).Value = "Pay queso frutas G." Then
                    linea.Cells(1).Value = "Pay q.frutas G."
                End If
                If linea.Cells(1).Value = "Pay queso fresa G." Then
                    linea.Cells(1).Value = "Pay q.fresa G."
                End If
            Next


            'dibujar linea
            e.Graphics.DrawLine(myPen, 0, 21, 770, 21) '+12
            e.Graphics.DrawLine(myPen, 0, 33, 770, 33)
            e.Graphics.DrawLine(myPen, 0, 45, 770, 45)
            e.Graphics.DrawLine(myPen, 0, 57, 770, 57)
            e.Graphics.DrawLine(myPen, 0, 69, 770, 69)
            e.Graphics.DrawLine(myPen, 0, 81, 770, 81)
            e.Graphics.DrawLine(myPen, 0, 93, 770, 93)
            e.Graphics.DrawLine(myPen, 0, 105, 770, 105)
            e.Graphics.DrawLine(myPen, 0, 117, 770, 117)
            e.Graphics.DrawLine(myPen, 0, 129, 770, 129)
            e.Graphics.DrawLine(myPen, 0, 141, 770, 141)
            e.Graphics.DrawLine(myPen, 0, 153, 770, 153)
            e.Graphics.DrawLine(myPen, 0, 165, 770, 165)
            e.Graphics.DrawLine(myPen, 0, 177, 770, 177)
            e.Graphics.DrawLine(myPen, 0, 189, 770, 189)
            e.Graphics.DrawLine(myPen, 0, 201, 770, 201)
            e.Graphics.DrawLine(myPen, 0, 213, 770, 213)
            e.Graphics.DrawLine(myPen, 0, 225, 770, 225)
            e.Graphics.DrawLine(myPen, 0, 237, 770, 237)
            e.Graphics.DrawLine(myPen, 0, 249, 770, 249)
            e.Graphics.DrawLine(myPen, 0, 261, 770, 261)
            e.Graphics.DrawLine(myPen, 0, 273, 770, 273)
            e.Graphics.DrawLine(myPen, 0, 285, 770, 285) 'hasta 31
            e.Graphics.DrawLine(myPen, 0, 297, 770, 297)
            e.Graphics.DrawLine(myPen, 0, 309, 770, 309)
            e.Graphics.DrawLine(myPen, 0, 321, 770, 321)
            e.Graphics.DrawLine(myPen, 0, 333, 770, 333)
            e.Graphics.DrawLine(myPen, 0, 345, 770, 345)
            e.Graphics.DrawLine(myPen, 0, 357, 770, 357)
            e.Graphics.DrawLine(myPen, 0, 369, 770, 369)
            e.Graphics.DrawLine(myPen, 0, 381, 770, 381)


            'aqui inician livbres las lineas
            e.Graphics.DrawLine(myPen, 0, 393, 560, 393)
            e.Graphics.DrawLine(myPen, 0, 405, 560, 405)
            e.Graphics.DrawLine(myPen, 0, 417, 560, 417)
            e.Graphics.DrawLine(myPen, 0, 429, 560, 429)
            e.Graphics.DrawLine(myPen, 0, 441, 560, 441)
            e.Graphics.DrawLine(myPen, 0, 453, 560, 453)
            e.Graphics.DrawLine(myPen, 0, 465, 560, 465)
            e.Graphics.DrawLine(myPen, 0, 477, 560, 477)
            e.Graphics.DrawLine(myPen, 0, 489, 560, 489)
            e.Graphics.DrawLine(myPen, 0, 501, 560, 501)
            e.Graphics.DrawLine(myPen, 0, 513, 560, 513)
            e.Graphics.DrawLine(myPen, 0, 525, 560, 525)
            e.Graphics.DrawLine(myPen, 0, 537, 560, 537)
            e.Graphics.DrawLine(myPen, 0, 549, 560, 549)
            e.Graphics.DrawLine(myPen, 0, 561, 560, 561)
            e.Graphics.DrawLine(myPen, 0, 573, 560, 573)
            e.Graphics.DrawLine(myPen, 0, 585, 560, 585)
            e.Graphics.DrawLine(myPen, 0, 597, 560, 597)
            e.Graphics.DrawLine(myPen, 0, 609, 560, 609)
            e.Graphics.DrawLine(myPen, 0, 621, 560, 621)
            e.Graphics.DrawLine(myPen, 0, 633, 560, 633)
            e.Graphics.DrawLine(myPen, 0, 645, 560, 645)
            e.Graphics.DrawLine(myPen, 0, 657, 560, 657)
            e.Graphics.DrawLine(myPen, 0, 669, 560, 669)
            e.Graphics.DrawLine(myPen, 0, 681, 560, 681)
            e.Graphics.DrawLine(myPen, 0, 693, 560, 693)
            e.Graphics.DrawLine(myPen, 0, 705, 560, 705)
            e.Graphics.DrawLine(myPen, 0, 717, 560, 717)
            e.Graphics.DrawLine(myPen, 0, 729, 560, 729)
            e.Graphics.DrawLine(myPen, 0, 741, 560, 741)
            e.Graphics.DrawLine(myPen, 0, 753, 560, 753)
            e.Graphics.DrawLine(myPen, 0, 765, 560, 765)
            e.Graphics.DrawLine(myPen, 0, 777, 560, 777)
            e.Graphics.DrawLine(myPen, 0, 789, 560, 789)
            e.Graphics.DrawLine(myPen, 0, 801, 560, 801)
            e.Graphics.DrawLine(myPen, 0, 813, 560, 813)
            e.Graphics.DrawLine(myPen, 0, 825, 560, 825)
            e.Graphics.DrawLine(myPen, 0, 837, 560, 837)
            e.Graphics.DrawLine(myPen, 0, 849, 560, 849)
            e.Graphics.DrawLine(myPen, 0, 861, 560, 861)
            e.Graphics.DrawLine(myPen, 0, 873, 560, 873)
            e.Graphics.DrawLine(myPen, 0, 885, 560, 885)
            e.Graphics.DrawLine(myPen, 0, 897, 560, 897)
            e.Graphics.DrawLine(myPen, 0, 909, 560, 909)
            e.Graphics.DrawLine(myPen, 0, 921, 560, 921)
            e.Graphics.DrawLine(myPen, 0, 933, 560, 933)
            e.Graphics.DrawLine(myPen, 0, 945, 560, 945)
            e.Graphics.DrawLine(myPen, 0, 957, 560, 957)
            e.Graphics.DrawLine(myPen, 0, 969, 560, 969)
            e.Graphics.DrawLine(myPen, 0, 981, 560, 981)
            e.Graphics.DrawLine(myPen, 0, 993, 560, 993)
            e.Graphics.DrawLine(myPen, 0, 1005, 560, 1005)
            e.Graphics.DrawLine(myPen, 0, 1017, 560, 1017)
            e.Graphics.DrawLine(myPen, 0, 1029, 560, 1029)
            e.Graphics.DrawLine(myPen, 0, 1041, 560, 1041)
            e.Graphics.DrawLine(myPen, 0, 1053, 560, 1053)
            e.Graphics.DrawLine(myPen, 0, 1065, 560, 1065)
            e.Graphics.DrawLine(myPen, 0, 1077, 560, 1077)
            e.Graphics.DrawLine(myPen, 0, 1089, 560, 1089)
            e.Graphics.DrawLine(myPen, 0, 1101, 560, 1101)
            e.Graphics.DrawLine(myPen, 0, 1113, 560, 1113)
            e.Graphics.DrawLine(myPen, 0, 1125, 560, 1125)
            e.Graphics.DrawLine(myPen, 0, 1137, 560, 1137)
            e.Graphics.DrawLine(myPen, 0, 1149, 560, 1149)
            e.Graphics.DrawLine(myPen, 0, 1161, 560, 1161)
            e.Graphics.DrawLine(myPen, 0, 1173, 560, 1173)
            e.Graphics.DrawLine(myPen, 0, 1185, 560, 1185)
            e.Graphics.DrawLine(myPen, 0, 1197, 560, 1197)
            e.Graphics.DrawLine(myPen, 0, 1209, 560, 1209)
            e.Graphics.DrawLine(myPen, 0, 1221, 560, 1221)
            e.Graphics.DrawLine(myPen, 0, 1233, 560, 1233)
            e.Graphics.DrawLine(myPen, 0, 1245, 560, 1245)
            e.Graphics.DrawLine(myPen, 0, 1257, 560, 1257)
            e.Graphics.DrawLine(myPen, 0, 1269, 560, 1269)

            e.Graphics.DrawLine(myPen, 0, 1281, 560, 1281)
            e.Graphics.DrawLine(myPen, 0, 1293, 560, 1293)
            e.Graphics.DrawLine(myPen, 0, 1305, 560, 1305)
            e.Graphics.DrawLine(myPen, 0, 1317, 560, 1317)
            e.Graphics.DrawLine(myPen, 0, 1329, 560, 1329)
            e.Graphics.DrawLine(myPen, 0, 1341, 560, 1341)


            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 0, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 100, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 135, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 190, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 290, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 325, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 380, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 480, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 515, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 570, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 670, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 705, 6)


            If DataGridView1.Rows.Count > 180 Then

                While i < 110

                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 0, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(9, i).Value, prFont1, Brushes.Black, 110, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 140, i * 12 + 20)
                    i += 1


                End While


                While i < 220
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 190, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(9, i).Value, prFont1, Brushes.Black, 300, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 330, i * 12 - 1300)
                    i += 1


                End While

                While i < 330
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 380, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(9, i).Value, prFont1, Brushes.Black, 490, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 520, i * 12 - 2620)
                    i += 1


                End While

                While i < DataGridView1.Rows.Count
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 570, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(9, i).Value, prFont1, Brushes.Black, 680, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 710, i * 12 - 3940)
                    i += 1


                End While


            End If

        End If




        If TextBox1.Text = "Mexi" Then

            Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
            PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            e.Graphics.DrawImage(bm, 600, 1050)
            Dim i As Integer = 0
            Dim i1 As Integer = 0
            Dim i11 As Integer = 0
            Dim line As String = Nothing
            Dim myPen = New Pen(Color.Black, 1)
            Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
            Dim prFont2 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
            Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
            Dim prFont9 As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
            Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
            e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 600, 1120) '65
            e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 610, 1130) '75
            e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 600, 1145) '90
            e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 600, 1160) '105
            e.Graphics.DrawString(DateTimePicker2.Value, prFont2, Brushes.Black, 650, 1160) '105
            e.Graphics.DrawString("HOJA DE CHOFER DE SISTEMA.", prFont2, Brushes.Black, 600, 1185) '130
            e.Graphics.DrawString("Sucursal:", prFont2, Brushes.Black, 600, 1200) '145
            e.Graphics.DrawString(TextBox1.Text, prFont9, Brushes.Black, 660, 1200) '145
            e.Graphics.DrawString("Chofer:", prFont2, Brushes.Black, 600, 1220)
            ' e.Graphics.DrawString(TextBox156.Text, prFont9, Brushes.Black, 660, 1220)
            ' e.Graphics.DrawString("ANOTACIONES:", prFont9, Brushes.Black, 600, 185)

            Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows
                If linea.Cells(1).Value = "Concha blanca int." Then
                    linea.Cells(1).Value = "Concha bca. int."
                End If
                If linea.Cells(1).Value = "Minirosquita Janeth" Then
                    linea.Cells(1).Value = "Rosquita Janeth"
                End If
                If linea.Cells(1).Value = "Cuerno mantequilla" Then
                    linea.Cells(1).Value = "Cuerno mante"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria" Then
                    linea.Cells(1).Value = "Panqué de zana"
                End If
                If linea.Cells(1).Value = "Gel. Dominó especial" Then
                    linea.Cells(1).Value = "Gel. Dom. esp."
                End If
                If linea.Cells(1).Value = "Gel. Rompope fruta" Then
                    linea.Cells(1).Value = "Gel. Rompope"
                End If
                If linea.Cells(1).Value = "Leche deslactosada 1l" Then
                    linea.Cells(1).Value = "L. deslac. 1l"
                End If
                If linea.Cells(1).Value = "Pay queso chocolate" Then
                    linea.Cells(1).Value = "P. queso choco"
                End If
                If linea.Cells(1).Value = "Feliz Cumple con base" Then
                    linea.Cells(1).Value = "F.C. base"
                End If
                If linea.Cells(1).Value = "Caja Galletas .250 Kg" Then
                    linea.Cells(1).Value = "C. Galle. .250"
                End If
                If linea.Cells(1).Value = "Panqué de chocolate" Then
                    linea.Cells(1).Value = "Panqué de choco"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria barra" Then
                    linea.Cells(1).Value = "P. zana barra"
                End If
                If linea.Cells(1).Value = "Panqué de chabacano" Then
                    linea.Cells(1).Value = "Panqué chaba"
                End If
                If linea.Cells(1).Value = "Bolsa cafe ame 500gr" Then
                    linea.Cells(1).Value = "B. café a. 500"
                End If
                If linea.Cells(1).Value = "Bolsa cafe des 500gr" Then
                    linea.Cells(1).Value = "B. café d. 500gr"
                End If
                If linea.Cells(1).Value = "Gel. Med. Bombón" Then
                    linea.Cells(1).Value = "G.M. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó" Then
                    linea.Cells(1).Value = "G.M. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó esp." Then
                    linea.Cells(1).Value = "G.M. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Med. Betabel" Then
                    linea.Cells(1).Value = "G.M. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Med. Queso uva" Then
                    linea.Cells(1).Value = "G.M. Queso u"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tricolor" Then
                    linea.Cells(1).Value = "G.M. Tricolor"
                End If
                If linea.Cells(1).Value = "Caja Galletas .5 Kg" Then
                    linea.Cells(1).Value = "C. Galle .5"
                End If
                If linea.Cells(1).Value = "Gel. Med. Agua fruta" Then
                    linea.Cells(1).Value = "G.M. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Med. Rompope" Then
                    linea.Cells(1).Value = "G.M. Romp."
                End If
                If linea.Cells(1).Value = "Panqué elote barra" Then
                    linea.Cells(1).Value = "P. elote barra"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tuti fruti" Then
                    linea.Cells(1).Value = "G.M. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Med. Zanahoria" Then
                    linea.Cells(1).Value = "G.M. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Flores Arándanos" Then
                    linea.Cells(1).Value = "G. Flores A."
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 leches" Then
                    linea.Cells(1).Value = "G.M. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Agua fruta" Then
                    linea.Cells(1).Value = "G.G. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó esp." Then
                    linea.Cells(1).Value = "G.G. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Betabel" Then
                    linea.Cells(1).Value = "G.G. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Tuti fruti" Then
                    linea.Cells(1).Value = "G.G. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Rompope" Then
                    linea.Cells(1).Value = "G.G. Rompope"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 leches" Then
                    linea.Cells(1).Value = "G.G. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Zanahoria" Then
                    linea.Cells(1).Value = "G.G. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 chocolates" Then
                    linea.Cells(1).Value = "G.G. 3 choco"
                End If
                If linea.Cells(1).Value = "Caja Galletas 1 Kg" Then
                    linea.Cells(1).Value = "C. Galle 1"
                End If
                If linea.Cells(1).Value = "Pay queso zarza G." Then
                    linea.Cells(1).Value = "Pay q.zarza G."
                End If
                If linea.Cells(1).Value = "Gel. Vino tinto 22 cm" Then
                    linea.Cells(1).Value = "Gel. vino 22cm"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó" Then
                    linea.Cells(1).Value = "G.G. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Bombón" Then
                    linea.Cells(1).Value = "G.G. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 chocolates" Then
                    linea.Cells(1).Value = "G.M. 3 choco"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Queso uva" Then
                    linea.Cells(1).Value = "G.G. Queso u"
                End If
                If linea.Cells(1).Value = "Pay queso frutas G." Then
                    linea.Cells(1).Value = "Pay q.frutas G."
                End If
                If linea.Cells(1).Value = "Pay queso fresa G." Then
                    linea.Cells(1).Value = "Pay q.fresa G."
                End If
            Next


            'dibujar linea
            e.Graphics.DrawLine(myPen, 0, 21, 770, 21) '+12
            e.Graphics.DrawLine(myPen, 0, 33, 770, 33)
            e.Graphics.DrawLine(myPen, 0, 45, 770, 45)
            e.Graphics.DrawLine(myPen, 0, 57, 770, 57)
            e.Graphics.DrawLine(myPen, 0, 69, 770, 69)
            e.Graphics.DrawLine(myPen, 0, 81, 770, 81)
            e.Graphics.DrawLine(myPen, 0, 93, 770, 93)
            e.Graphics.DrawLine(myPen, 0, 105, 770, 105)
            e.Graphics.DrawLine(myPen, 0, 117, 770, 117)
            e.Graphics.DrawLine(myPen, 0, 129, 770, 129)
            e.Graphics.DrawLine(myPen, 0, 141, 770, 141)
            e.Graphics.DrawLine(myPen, 0, 153, 770, 153)
            e.Graphics.DrawLine(myPen, 0, 165, 770, 165)
            e.Graphics.DrawLine(myPen, 0, 177, 770, 177)
            e.Graphics.DrawLine(myPen, 0, 189, 770, 189)
            e.Graphics.DrawLine(myPen, 0, 201, 770, 201)
            e.Graphics.DrawLine(myPen, 0, 213, 770, 213)
            e.Graphics.DrawLine(myPen, 0, 225, 770, 225)
            e.Graphics.DrawLine(myPen, 0, 237, 770, 237)
            e.Graphics.DrawLine(myPen, 0, 249, 770, 249)
            e.Graphics.DrawLine(myPen, 0, 261, 770, 261)
            e.Graphics.DrawLine(myPen, 0, 273, 770, 273)
            e.Graphics.DrawLine(myPen, 0, 285, 770, 285) 'hasta 31
            e.Graphics.DrawLine(myPen, 0, 297, 770, 297)
            e.Graphics.DrawLine(myPen, 0, 309, 770, 309)
            e.Graphics.DrawLine(myPen, 0, 321, 770, 321)
            e.Graphics.DrawLine(myPen, 0, 333, 770, 333)
            e.Graphics.DrawLine(myPen, 0, 345, 770, 345)
            e.Graphics.DrawLine(myPen, 0, 357, 770, 357)
            e.Graphics.DrawLine(myPen, 0, 369, 770, 369)
            e.Graphics.DrawLine(myPen, 0, 381, 770, 381)


            'aqui inician livbres las lineas
            e.Graphics.DrawLine(myPen, 0, 393, 560, 393)
            e.Graphics.DrawLine(myPen, 0, 405, 560, 405)
            e.Graphics.DrawLine(myPen, 0, 417, 560, 417)
            e.Graphics.DrawLine(myPen, 0, 429, 560, 429)
            e.Graphics.DrawLine(myPen, 0, 441, 560, 441)
            e.Graphics.DrawLine(myPen, 0, 453, 560, 453)
            e.Graphics.DrawLine(myPen, 0, 465, 560, 465)
            e.Graphics.DrawLine(myPen, 0, 477, 560, 477)
            e.Graphics.DrawLine(myPen, 0, 489, 560, 489)
            e.Graphics.DrawLine(myPen, 0, 501, 560, 501)
            e.Graphics.DrawLine(myPen, 0, 513, 560, 513)
            e.Graphics.DrawLine(myPen, 0, 525, 560, 525)
            e.Graphics.DrawLine(myPen, 0, 537, 560, 537)
            e.Graphics.DrawLine(myPen, 0, 549, 560, 549)
            e.Graphics.DrawLine(myPen, 0, 561, 560, 561)
            e.Graphics.DrawLine(myPen, 0, 573, 560, 573)
            e.Graphics.DrawLine(myPen, 0, 585, 560, 585)
            e.Graphics.DrawLine(myPen, 0, 597, 560, 597)
            e.Graphics.DrawLine(myPen, 0, 609, 560, 609)
            e.Graphics.DrawLine(myPen, 0, 621, 560, 621)
            e.Graphics.DrawLine(myPen, 0, 633, 560, 633)
            e.Graphics.DrawLine(myPen, 0, 645, 560, 645)
            e.Graphics.DrawLine(myPen, 0, 657, 560, 657)
            e.Graphics.DrawLine(myPen, 0, 669, 560, 669)
            e.Graphics.DrawLine(myPen, 0, 681, 560, 681)
            e.Graphics.DrawLine(myPen, 0, 693, 560, 693)
            e.Graphics.DrawLine(myPen, 0, 705, 560, 705)
            e.Graphics.DrawLine(myPen, 0, 717, 560, 717)
            e.Graphics.DrawLine(myPen, 0, 729, 560, 729)
            e.Graphics.DrawLine(myPen, 0, 741, 560, 741)
            e.Graphics.DrawLine(myPen, 0, 753, 560, 753)
            e.Graphics.DrawLine(myPen, 0, 765, 560, 765)
            e.Graphics.DrawLine(myPen, 0, 777, 560, 777)
            e.Graphics.DrawLine(myPen, 0, 789, 560, 789)
            e.Graphics.DrawLine(myPen, 0, 801, 560, 801)
            e.Graphics.DrawLine(myPen, 0, 813, 560, 813)
            e.Graphics.DrawLine(myPen, 0, 825, 560, 825)
            e.Graphics.DrawLine(myPen, 0, 837, 560, 837)
            e.Graphics.DrawLine(myPen, 0, 849, 560, 849)
            e.Graphics.DrawLine(myPen, 0, 861, 560, 861)
            e.Graphics.DrawLine(myPen, 0, 873, 560, 873)
            e.Graphics.DrawLine(myPen, 0, 885, 560, 885)
            e.Graphics.DrawLine(myPen, 0, 897, 560, 897)
            e.Graphics.DrawLine(myPen, 0, 909, 560, 909)
            e.Graphics.DrawLine(myPen, 0, 921, 560, 921)
            e.Graphics.DrawLine(myPen, 0, 933, 560, 933)
            e.Graphics.DrawLine(myPen, 0, 945, 560, 945)
            e.Graphics.DrawLine(myPen, 0, 957, 560, 957)
            e.Graphics.DrawLine(myPen, 0, 969, 560, 969)
            e.Graphics.DrawLine(myPen, 0, 981, 560, 981)
            e.Graphics.DrawLine(myPen, 0, 993, 560, 993)
            e.Graphics.DrawLine(myPen, 0, 1005, 560, 1005)
            e.Graphics.DrawLine(myPen, 0, 1017, 560, 1017)
            e.Graphics.DrawLine(myPen, 0, 1029, 560, 1029)
            e.Graphics.DrawLine(myPen, 0, 1041, 560, 1041)
            e.Graphics.DrawLine(myPen, 0, 1053, 560, 1053)
            e.Graphics.DrawLine(myPen, 0, 1065, 560, 1065)
            e.Graphics.DrawLine(myPen, 0, 1077, 560, 1077)
            e.Graphics.DrawLine(myPen, 0, 1089, 560, 1089)
            e.Graphics.DrawLine(myPen, 0, 1101, 560, 1101)
            e.Graphics.DrawLine(myPen, 0, 1113, 560, 1113)
            e.Graphics.DrawLine(myPen, 0, 1125, 560, 1125)
            e.Graphics.DrawLine(myPen, 0, 1137, 560, 1137)
            e.Graphics.DrawLine(myPen, 0, 1149, 560, 1149)
            e.Graphics.DrawLine(myPen, 0, 1161, 560, 1161)
            e.Graphics.DrawLine(myPen, 0, 1173, 560, 1173)
            e.Graphics.DrawLine(myPen, 0, 1185, 560, 1185)
            e.Graphics.DrawLine(myPen, 0, 1197, 560, 1197)
            e.Graphics.DrawLine(myPen, 0, 1209, 560, 1209)
            e.Graphics.DrawLine(myPen, 0, 1221, 560, 1221)
            e.Graphics.DrawLine(myPen, 0, 1233, 560, 1233)
            e.Graphics.DrawLine(myPen, 0, 1245, 560, 1245)
            e.Graphics.DrawLine(myPen, 0, 1257, 560, 1257)
            e.Graphics.DrawLine(myPen, 0, 1269, 560, 1269)

            e.Graphics.DrawLine(myPen, 0, 1281, 560, 1281)
            e.Graphics.DrawLine(myPen, 0, 1293, 560, 1293)
            e.Graphics.DrawLine(myPen, 0, 1305, 560, 1305)
            e.Graphics.DrawLine(myPen, 0, 1317, 560, 1317)
            e.Graphics.DrawLine(myPen, 0, 1329, 560, 1329)
            e.Graphics.DrawLine(myPen, 0, 1341, 560, 1341)



            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 0, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 100, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 135, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 190, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 290, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 325, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 380, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 480, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 515, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 570, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 670, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 705, 6)


            If DataGridView1.Rows.Count > 180 Then

                While i < 110

                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 0, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(10, i).Value, prFont1, Brushes.Black, 110, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 140, i * 12 + 20)
                    i += 1


                End While


                While i < 220
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 190, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(10, i).Value, prFont1, Brushes.Black, 300, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 330, i * 12 - 1300)
                    i += 1


                End While

                While i < 330
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 380, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(10, i).Value, prFont1, Brushes.Black, 490, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 520, i * 12 - 2620)
                    i += 1


                End While

                While i < DataGridView1.Rows.Count
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 570, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(10, i).Value, prFont1, Brushes.Black, 680, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 710, i * 12 - 3940)
                    i += 1


                End While


            End If

        End If



        If TextBox1.Text = "Colón" Then

            Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
            PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            e.Graphics.DrawImage(bm, 600, 1050)
            Dim i As Integer = 0
            Dim i1 As Integer = 0
            Dim i11 As Integer = 0
            Dim line As String = Nothing
            Dim myPen = New Pen(Color.Black, 1)
            Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
            Dim prFont2 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
            Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
            Dim prFont9 As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
            Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
            e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 600, 1120) '65
            e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 610, 1130) '75
            e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 600, 1145) '90
            e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 600, 1160) '105
            e.Graphics.DrawString(DateTimePicker2.Value, prFont2, Brushes.Black, 650, 1160) '105
            e.Graphics.DrawString("HOJA DE CHOFER DE SISTEMA.", prFont2, Brushes.Black, 600, 1185) '130
            e.Graphics.DrawString("Sucursal:", prFont2, Brushes.Black, 600, 1200) '145
            e.Graphics.DrawString(TextBox1.Text, prFont9, Brushes.Black, 660, 1200) '145
            e.Graphics.DrawString("Chofer:", prFont2, Brushes.Black, 600, 1220)
            '  e.Graphics.DrawString(TextBox156.Text, prFont9, Brushes.Black, 660, 1220)
            ' e.Graphics.DrawString("ANOTACIONES:", prFont9, Brushes.Black, 600, 185)

            Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows
                If linea.Cells(1).Value = "Concha blanca int." Then
                    linea.Cells(1).Value = "Concha bca. int."
                End If
                If linea.Cells(1).Value = "Minirosquita Janeth" Then
                    linea.Cells(1).Value = "Rosquita Janeth"
                End If
                If linea.Cells(1).Value = "Cuerno mantequilla" Then
                    linea.Cells(1).Value = "Cuerno mante"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria" Then
                    linea.Cells(1).Value = "Panqué de zana"
                End If
                If linea.Cells(1).Value = "Gel. Dominó especial" Then
                    linea.Cells(1).Value = "Gel. Dom. esp."
                End If
                If linea.Cells(1).Value = "Gel. Rompope fruta" Then
                    linea.Cells(1).Value = "Gel. Rompope"
                End If
                If linea.Cells(1).Value = "Leche deslactosada 1l" Then
                    linea.Cells(1).Value = "L. deslac. 1l"
                End If
                If linea.Cells(1).Value = "Pay queso chocolate" Then
                    linea.Cells(1).Value = "P. queso choco"
                End If
                If linea.Cells(1).Value = "Feliz Cumple con base" Then
                    linea.Cells(1).Value = "F.C. base"
                End If
                If linea.Cells(1).Value = "Caja Galletas .250 Kg" Then
                    linea.Cells(1).Value = "C. Galle. .250"
                End If
                If linea.Cells(1).Value = "Panqué de chocolate" Then
                    linea.Cells(1).Value = "Panqué de choco"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria barra" Then
                    linea.Cells(1).Value = "P. zana barra"
                End If
                If linea.Cells(1).Value = "Panqué de chabacano" Then
                    linea.Cells(1).Value = "Panqué chaba"
                End If
                If linea.Cells(1).Value = "Bolsa cafe ame 500gr" Then
                    linea.Cells(1).Value = "B. café a. 500"
                End If
                If linea.Cells(1).Value = "Bolsa cafe des 500gr" Then
                    linea.Cells(1).Value = "B. café d. 500gr"
                End If
                If linea.Cells(1).Value = "Gel. Med. Bombón" Then
                    linea.Cells(1).Value = "G.M. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó" Then
                    linea.Cells(1).Value = "G.M. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó esp." Then
                    linea.Cells(1).Value = "G.M. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Med. Betabel" Then
                    linea.Cells(1).Value = "G.M. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Med. Queso uva" Then
                    linea.Cells(1).Value = "G.M. Queso u"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tricolor" Then
                    linea.Cells(1).Value = "G.M. Tricolor"
                End If
                If linea.Cells(1).Value = "Caja Galletas .5 Kg" Then
                    linea.Cells(1).Value = "C. Galle .5"
                End If
                If linea.Cells(1).Value = "Gel. Med. Agua fruta" Then
                    linea.Cells(1).Value = "G.M. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Med. Rompope" Then
                    linea.Cells(1).Value = "G.M. Romp."
                End If
                If linea.Cells(1).Value = "Panqué elote barra" Then
                    linea.Cells(1).Value = "P. elote barra"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tuti fruti" Then
                    linea.Cells(1).Value = "G.M. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Med. Zanahoria" Then
                    linea.Cells(1).Value = "G.M. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Flores Arándanos" Then
                    linea.Cells(1).Value = "G. Flores A."
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 leches" Then
                    linea.Cells(1).Value = "G.M. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Agua fruta" Then
                    linea.Cells(1).Value = "G.G. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó esp." Then
                    linea.Cells(1).Value = "G.G. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Betabel" Then
                    linea.Cells(1).Value = "G.G. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Tuti fruti" Then
                    linea.Cells(1).Value = "G.G. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Rompope" Then
                    linea.Cells(1).Value = "G.G. Rompope"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 leches" Then
                    linea.Cells(1).Value = "G.G. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Zanahoria" Then
                    linea.Cells(1).Value = "G.G. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 chocolates" Then
                    linea.Cells(1).Value = "G.G. 3 choco"
                End If
                If linea.Cells(1).Value = "Caja Galletas 1 Kg" Then
                    linea.Cells(1).Value = "C. Galle 1"
                End If
                If linea.Cells(1).Value = "Pay queso zarza G." Then
                    linea.Cells(1).Value = "Pay q.zarza G."
                End If
                If linea.Cells(1).Value = "Gel. Vino tinto 22 cm" Then
                    linea.Cells(1).Value = "Gel. vino 22cm"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó" Then
                    linea.Cells(1).Value = "G.G. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Bombón" Then
                    linea.Cells(1).Value = "G.G. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 chocolates" Then
                    linea.Cells(1).Value = "G.M. 3 choco"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Queso uva" Then
                    linea.Cells(1).Value = "G.G. Queso u"
                End If
                If linea.Cells(1).Value = "Pay queso frutas G." Then
                    linea.Cells(1).Value = "Pay q.frutas G."
                End If
                If linea.Cells(1).Value = "Pay queso fresa G." Then
                    linea.Cells(1).Value = "Pay q.fresa G."
                End If
            Next


            'dibujar linea
            e.Graphics.DrawLine(myPen, 0, 21, 770, 21) '+12
            e.Graphics.DrawLine(myPen, 0, 33, 770, 33)
            e.Graphics.DrawLine(myPen, 0, 45, 770, 45)
            e.Graphics.DrawLine(myPen, 0, 57, 770, 57)
            e.Graphics.DrawLine(myPen, 0, 69, 770, 69)
            e.Graphics.DrawLine(myPen, 0, 81, 770, 81)
            e.Graphics.DrawLine(myPen, 0, 93, 770, 93)
            e.Graphics.DrawLine(myPen, 0, 105, 770, 105)
            e.Graphics.DrawLine(myPen, 0, 117, 770, 117)
            e.Graphics.DrawLine(myPen, 0, 129, 770, 129)
            e.Graphics.DrawLine(myPen, 0, 141, 770, 141)
            e.Graphics.DrawLine(myPen, 0, 153, 770, 153)
            e.Graphics.DrawLine(myPen, 0, 165, 770, 165)
            e.Graphics.DrawLine(myPen, 0, 177, 770, 177)
            e.Graphics.DrawLine(myPen, 0, 189, 770, 189)
            e.Graphics.DrawLine(myPen, 0, 201, 770, 201)
            e.Graphics.DrawLine(myPen, 0, 213, 770, 213)
            e.Graphics.DrawLine(myPen, 0, 225, 770, 225)
            e.Graphics.DrawLine(myPen, 0, 237, 770, 237)
            e.Graphics.DrawLine(myPen, 0, 249, 770, 249)
            e.Graphics.DrawLine(myPen, 0, 261, 770, 261)
            e.Graphics.DrawLine(myPen, 0, 273, 770, 273)
            e.Graphics.DrawLine(myPen, 0, 285, 770, 285) 'hasta 31
            e.Graphics.DrawLine(myPen, 0, 297, 770, 297)
            e.Graphics.DrawLine(myPen, 0, 309, 770, 309)
            e.Graphics.DrawLine(myPen, 0, 321, 770, 321)
            e.Graphics.DrawLine(myPen, 0, 333, 770, 333)
            e.Graphics.DrawLine(myPen, 0, 345, 770, 345)
            e.Graphics.DrawLine(myPen, 0, 357, 770, 357)
            e.Graphics.DrawLine(myPen, 0, 369, 770, 369)
            e.Graphics.DrawLine(myPen, 0, 381, 770, 381)


            'aqui inician livbres las lineas
            e.Graphics.DrawLine(myPen, 0, 393, 560, 393)
            e.Graphics.DrawLine(myPen, 0, 405, 560, 405)
            e.Graphics.DrawLine(myPen, 0, 417, 560, 417)
            e.Graphics.DrawLine(myPen, 0, 429, 560, 429)
            e.Graphics.DrawLine(myPen, 0, 441, 560, 441)
            e.Graphics.DrawLine(myPen, 0, 453, 560, 453)
            e.Graphics.DrawLine(myPen, 0, 465, 560, 465)
            e.Graphics.DrawLine(myPen, 0, 477, 560, 477)
            e.Graphics.DrawLine(myPen, 0, 489, 560, 489)
            e.Graphics.DrawLine(myPen, 0, 501, 560, 501)
            e.Graphics.DrawLine(myPen, 0, 513, 560, 513)
            e.Graphics.DrawLine(myPen, 0, 525, 560, 525)
            e.Graphics.DrawLine(myPen, 0, 537, 560, 537)
            e.Graphics.DrawLine(myPen, 0, 549, 560, 549)
            e.Graphics.DrawLine(myPen, 0, 561, 560, 561)
            e.Graphics.DrawLine(myPen, 0, 573, 560, 573)
            e.Graphics.DrawLine(myPen, 0, 585, 560, 585)
            e.Graphics.DrawLine(myPen, 0, 597, 560, 597)
            e.Graphics.DrawLine(myPen, 0, 609, 560, 609)
            e.Graphics.DrawLine(myPen, 0, 621, 560, 621)
            e.Graphics.DrawLine(myPen, 0, 633, 560, 633)
            e.Graphics.DrawLine(myPen, 0, 645, 560, 645)
            e.Graphics.DrawLine(myPen, 0, 657, 560, 657)
            e.Graphics.DrawLine(myPen, 0, 669, 560, 669)
            e.Graphics.DrawLine(myPen, 0, 681, 560, 681)
            e.Graphics.DrawLine(myPen, 0, 693, 560, 693)
            e.Graphics.DrawLine(myPen, 0, 705, 560, 705)
            e.Graphics.DrawLine(myPen, 0, 717, 560, 717)
            e.Graphics.DrawLine(myPen, 0, 729, 560, 729)
            e.Graphics.DrawLine(myPen, 0, 741, 560, 741)
            e.Graphics.DrawLine(myPen, 0, 753, 560, 753)
            e.Graphics.DrawLine(myPen, 0, 765, 560, 765)
            e.Graphics.DrawLine(myPen, 0, 777, 560, 777)
            e.Graphics.DrawLine(myPen, 0, 789, 560, 789)
            e.Graphics.DrawLine(myPen, 0, 801, 560, 801)
            e.Graphics.DrawLine(myPen, 0, 813, 560, 813)
            e.Graphics.DrawLine(myPen, 0, 825, 560, 825)
            e.Graphics.DrawLine(myPen, 0, 837, 560, 837)
            e.Graphics.DrawLine(myPen, 0, 849, 560, 849)
            e.Graphics.DrawLine(myPen, 0, 861, 560, 861)
            e.Graphics.DrawLine(myPen, 0, 873, 560, 873)
            e.Graphics.DrawLine(myPen, 0, 885, 560, 885)
            e.Graphics.DrawLine(myPen, 0, 897, 560, 897)
            e.Graphics.DrawLine(myPen, 0, 909, 560, 909)
            e.Graphics.DrawLine(myPen, 0, 921, 560, 921)
            e.Graphics.DrawLine(myPen, 0, 933, 560, 933)
            e.Graphics.DrawLine(myPen, 0, 945, 560, 945)
            e.Graphics.DrawLine(myPen, 0, 957, 560, 957)
            e.Graphics.DrawLine(myPen, 0, 969, 560, 969)
            e.Graphics.DrawLine(myPen, 0, 981, 560, 981)
            e.Graphics.DrawLine(myPen, 0, 993, 560, 993)
            e.Graphics.DrawLine(myPen, 0, 1005, 560, 1005)
            e.Graphics.DrawLine(myPen, 0, 1017, 560, 1017)
            e.Graphics.DrawLine(myPen, 0, 1029, 560, 1029)
            e.Graphics.DrawLine(myPen, 0, 1041, 560, 1041)
            e.Graphics.DrawLine(myPen, 0, 1053, 560, 1053)
            e.Graphics.DrawLine(myPen, 0, 1065, 560, 1065)
            e.Graphics.DrawLine(myPen, 0, 1077, 560, 1077)
            e.Graphics.DrawLine(myPen, 0, 1089, 560, 1089)
            e.Graphics.DrawLine(myPen, 0, 1101, 560, 1101)
            e.Graphics.DrawLine(myPen, 0, 1113, 560, 1113)
            e.Graphics.DrawLine(myPen, 0, 1125, 560, 1125)
            e.Graphics.DrawLine(myPen, 0, 1137, 560, 1137)
            e.Graphics.DrawLine(myPen, 0, 1149, 560, 1149)
            e.Graphics.DrawLine(myPen, 0, 1161, 560, 1161)
            e.Graphics.DrawLine(myPen, 0, 1173, 560, 1173)
            e.Graphics.DrawLine(myPen, 0, 1185, 560, 1185)
            e.Graphics.DrawLine(myPen, 0, 1197, 560, 1197)
            e.Graphics.DrawLine(myPen, 0, 1209, 560, 1209)
            e.Graphics.DrawLine(myPen, 0, 1221, 560, 1221)
            e.Graphics.DrawLine(myPen, 0, 1233, 560, 1233)
            e.Graphics.DrawLine(myPen, 0, 1245, 560, 1245)
            e.Graphics.DrawLine(myPen, 0, 1257, 560, 1257)
            e.Graphics.DrawLine(myPen, 0, 1269, 560, 1269)

            e.Graphics.DrawLine(myPen, 0, 1281, 560, 1281)
            e.Graphics.DrawLine(myPen, 0, 1293, 560, 1293)
            e.Graphics.DrawLine(myPen, 0, 1305, 560, 1305)
            e.Graphics.DrawLine(myPen, 0, 1317, 560, 1317)
            e.Graphics.DrawLine(myPen, 0, 1329, 560, 1329)
            e.Graphics.DrawLine(myPen, 0, 1341, 560, 1341)



            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 0, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 100, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 135, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 190, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 290, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 325, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 380, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 480, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 515, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 570, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 670, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 705, 6)


            If DataGridView1.Rows.Count > 180 Then

                While i < 110

                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 0, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(7, i).Value, prFont1, Brushes.Black, 110, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 140, i * 12 + 20)
                    i += 1


                End While


                While i < 220
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 190, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(7, i).Value, prFont1, Brushes.Black, 300, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 330, i * 12 - 1300)
                    i += 1


                End While

                While i < 330
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 380, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(7, i).Value, prFont1, Brushes.Black, 490, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 520, i * 12 - 2620)
                    i += 1


                End While

                While i < DataGridView1.Rows.Count
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 570, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(7, i).Value, prFont1, Brushes.Black, 680, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 710, i * 12 - 3940)
                    i += 1


                End While


            End If

        End If





        If TextBox1.Text = "Tec" Then

            Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
            PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            e.Graphics.DrawImage(bm, 600, 1050)
            Dim i As Integer = 0
            Dim i1 As Integer = 0
            Dim i11 As Integer = 0
            Dim line As String = Nothing
            Dim myPen = New Pen(Color.Black, 1)
            Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
            Dim prFont2 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
            Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
            Dim prFont9 As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
            Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
            e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 600, 1120) '65
            e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 610, 1130) '75
            e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 600, 1145) '90
            e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 600, 1160) '105
            e.Graphics.DrawString(DateTimePicker2.Value, prFont2, Brushes.Black, 650, 1160) '105
            e.Graphics.DrawString("HOJA DE CHOFER DE SISTEMA.", prFont2, Brushes.Black, 600, 1185) '130
            e.Graphics.DrawString("Sucursal:", prFont2, Brushes.Black, 600, 1200) '145
            e.Graphics.DrawString(TextBox1.Text, prFont9, Brushes.Black, 660, 1200) '145
            e.Graphics.DrawString("Chofer:", prFont2, Brushes.Black, 600, 1220)
            '   e.Graphics.DrawString(TextBox156.Text, prFont9, Brushes.Black, 660, 1220)
            ' e.Graphics.DrawString("ANOTACIONES:", prFont9, Brushes.Black, 600, 185)

            Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows
                If linea.Cells(1).Value = "Concha blanca int." Then
                    linea.Cells(1).Value = "Concha bca. int."
                End If
                If linea.Cells(1).Value = "Minirosquita Janeth" Then
                    linea.Cells(1).Value = "Rosquita Janeth"
                End If
                If linea.Cells(1).Value = "Cuerno mantequilla" Then
                    linea.Cells(1).Value = "Cuerno mante"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria" Then
                    linea.Cells(1).Value = "Panqué de zana"
                End If
                If linea.Cells(1).Value = "Gel. Dominó especial" Then
                    linea.Cells(1).Value = "Gel. Dom. esp."
                End If
                If linea.Cells(1).Value = "Gel. Rompope fruta" Then
                    linea.Cells(1).Value = "Gel. Rompope"
                End If
                If linea.Cells(1).Value = "Leche deslactosada 1l" Then
                    linea.Cells(1).Value = "L. deslac. 1l"
                End If
                If linea.Cells(1).Value = "Pay queso chocolate" Then
                    linea.Cells(1).Value = "P. queso choco"
                End If
                If linea.Cells(1).Value = "Feliz Cumple con base" Then
                    linea.Cells(1).Value = "F.C. base"
                End If
                If linea.Cells(1).Value = "Caja Galletas .250 Kg" Then
                    linea.Cells(1).Value = "C. Galle. .250"
                End If
                If linea.Cells(1).Value = "Panqué de chocolate" Then
                    linea.Cells(1).Value = "Panqué de choco"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria barra" Then
                    linea.Cells(1).Value = "P. zana barra"
                End If
                If linea.Cells(1).Value = "Panqué de chabacano" Then
                    linea.Cells(1).Value = "Panqué chaba"
                End If
                If linea.Cells(1).Value = "Bolsa cafe ame 500gr" Then
                    linea.Cells(1).Value = "B. café a. 500"
                End If
                If linea.Cells(1).Value = "Bolsa cafe des 500gr" Then
                    linea.Cells(1).Value = "B. café d. 500gr"
                End If
                If linea.Cells(1).Value = "Gel. Med. Bombón" Then
                    linea.Cells(1).Value = "G.M. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó" Then
                    linea.Cells(1).Value = "G.M. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó esp." Then
                    linea.Cells(1).Value = "G.M. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Med. Betabel" Then
                    linea.Cells(1).Value = "G.M. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Med. Queso uva" Then
                    linea.Cells(1).Value = "G.M. Queso u"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tricolor" Then
                    linea.Cells(1).Value = "G.M. Tricolor"
                End If
                If linea.Cells(1).Value = "Caja Galletas .5 Kg" Then
                    linea.Cells(1).Value = "C. Galle .5"
                End If
                If linea.Cells(1).Value = "Gel. Med. Agua fruta" Then
                    linea.Cells(1).Value = "G.M. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Med. Rompope" Then
                    linea.Cells(1).Value = "G.M. Romp."
                End If
                If linea.Cells(1).Value = "Panqué elote barra" Then
                    linea.Cells(1).Value = "P. elote barra"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tuti fruti" Then
                    linea.Cells(1).Value = "G.M. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Med. Zanahoria" Then
                    linea.Cells(1).Value = "G.M. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Flores Arándanos" Then
                    linea.Cells(1).Value = "G. Flores A."
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 leches" Then
                    linea.Cells(1).Value = "G.M. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Agua fruta" Then
                    linea.Cells(1).Value = "G.G. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó esp." Then
                    linea.Cells(1).Value = "G.G. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Betabel" Then
                    linea.Cells(1).Value = "G.G. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Tuti fruti" Then
                    linea.Cells(1).Value = "G.G. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Rompope" Then
                    linea.Cells(1).Value = "G.G. Rompope"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 leches" Then
                    linea.Cells(1).Value = "G.G. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Zanahoria" Then
                    linea.Cells(1).Value = "G.G. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 chocolates" Then
                    linea.Cells(1).Value = "G.G. 3 choco"
                End If
                If linea.Cells(1).Value = "Caja Galletas 1 Kg" Then
                    linea.Cells(1).Value = "C. Galle 1"
                End If
                If linea.Cells(1).Value = "Pay queso zarza G." Then
                    linea.Cells(1).Value = "Pay q.zarza G."
                End If
                If linea.Cells(1).Value = "Gel. Vino tinto 22 cm" Then
                    linea.Cells(1).Value = "Gel. vino 22cm"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó" Then
                    linea.Cells(1).Value = "G.G. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Bombón" Then
                    linea.Cells(1).Value = "G.G. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 chocolates" Then
                    linea.Cells(1).Value = "G.M. 3 choco"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Queso uva" Then
                    linea.Cells(1).Value = "G.G. Queso u"
                End If
                If linea.Cells(1).Value = "Pay queso frutas G." Then
                    linea.Cells(1).Value = "Pay q.frutas G."
                End If
                If linea.Cells(1).Value = "Pay queso fresa G." Then
                    linea.Cells(1).Value = "Pay q.fresa G."
                End If
            Next

            'dibujar linea
            e.Graphics.DrawLine(myPen, 0, 21, 770, 21) '+12
            e.Graphics.DrawLine(myPen, 0, 33, 770, 33)
            e.Graphics.DrawLine(myPen, 0, 45, 770, 45)
            e.Graphics.DrawLine(myPen, 0, 57, 770, 57)
            e.Graphics.DrawLine(myPen, 0, 69, 770, 69)
            e.Graphics.DrawLine(myPen, 0, 81, 770, 81)
            e.Graphics.DrawLine(myPen, 0, 93, 770, 93)
            e.Graphics.DrawLine(myPen, 0, 105, 770, 105)
            e.Graphics.DrawLine(myPen, 0, 117, 770, 117)
            e.Graphics.DrawLine(myPen, 0, 129, 770, 129)
            e.Graphics.DrawLine(myPen, 0, 141, 770, 141)
            e.Graphics.DrawLine(myPen, 0, 153, 770, 153)
            e.Graphics.DrawLine(myPen, 0, 165, 770, 165)
            e.Graphics.DrawLine(myPen, 0, 177, 770, 177)
            e.Graphics.DrawLine(myPen, 0, 189, 770, 189)
            e.Graphics.DrawLine(myPen, 0, 201, 770, 201)
            e.Graphics.DrawLine(myPen, 0, 213, 770, 213)
            e.Graphics.DrawLine(myPen, 0, 225, 770, 225)
            e.Graphics.DrawLine(myPen, 0, 237, 770, 237)
            e.Graphics.DrawLine(myPen, 0, 249, 770, 249)
            e.Graphics.DrawLine(myPen, 0, 261, 770, 261)
            e.Graphics.DrawLine(myPen, 0, 273, 770, 273)
            e.Graphics.DrawLine(myPen, 0, 285, 770, 285) 'hasta 31
            e.Graphics.DrawLine(myPen, 0, 297, 770, 297)
            e.Graphics.DrawLine(myPen, 0, 309, 770, 309)
            e.Graphics.DrawLine(myPen, 0, 321, 770, 321)
            e.Graphics.DrawLine(myPen, 0, 333, 770, 333)
            e.Graphics.DrawLine(myPen, 0, 345, 770, 345)
            e.Graphics.DrawLine(myPen, 0, 357, 770, 357)
            e.Graphics.DrawLine(myPen, 0, 369, 770, 369)
            e.Graphics.DrawLine(myPen, 0, 381, 770, 381)


            'aqui inician livbres las lineas
            e.Graphics.DrawLine(myPen, 0, 393, 560, 393)
            e.Graphics.DrawLine(myPen, 0, 405, 560, 405)
            e.Graphics.DrawLine(myPen, 0, 417, 560, 417)
            e.Graphics.DrawLine(myPen, 0, 429, 560, 429)
            e.Graphics.DrawLine(myPen, 0, 441, 560, 441)
            e.Graphics.DrawLine(myPen, 0, 453, 560, 453)
            e.Graphics.DrawLine(myPen, 0, 465, 560, 465)
            e.Graphics.DrawLine(myPen, 0, 477, 560, 477)
            e.Graphics.DrawLine(myPen, 0, 489, 560, 489)
            e.Graphics.DrawLine(myPen, 0, 501, 560, 501)
            e.Graphics.DrawLine(myPen, 0, 513, 560, 513)
            e.Graphics.DrawLine(myPen, 0, 525, 560, 525)
            e.Graphics.DrawLine(myPen, 0, 537, 560, 537)
            e.Graphics.DrawLine(myPen, 0, 549, 560, 549)
            e.Graphics.DrawLine(myPen, 0, 561, 560, 561)
            e.Graphics.DrawLine(myPen, 0, 573, 560, 573)
            e.Graphics.DrawLine(myPen, 0, 585, 560, 585)
            e.Graphics.DrawLine(myPen, 0, 597, 560, 597)
            e.Graphics.DrawLine(myPen, 0, 609, 560, 609)
            e.Graphics.DrawLine(myPen, 0, 621, 560, 621)
            e.Graphics.DrawLine(myPen, 0, 633, 560, 633)
            e.Graphics.DrawLine(myPen, 0, 645, 560, 645)
            e.Graphics.DrawLine(myPen, 0, 657, 560, 657)
            e.Graphics.DrawLine(myPen, 0, 669, 560, 669)
            e.Graphics.DrawLine(myPen, 0, 681, 560, 681)
            e.Graphics.DrawLine(myPen, 0, 693, 560, 693)
            e.Graphics.DrawLine(myPen, 0, 705, 560, 705)
            e.Graphics.DrawLine(myPen, 0, 717, 560, 717)
            e.Graphics.DrawLine(myPen, 0, 729, 560, 729)
            e.Graphics.DrawLine(myPen, 0, 741, 560, 741)
            e.Graphics.DrawLine(myPen, 0, 753, 560, 753)
            e.Graphics.DrawLine(myPen, 0, 765, 560, 765)
            e.Graphics.DrawLine(myPen, 0, 777, 560, 777)
            e.Graphics.DrawLine(myPen, 0, 789, 560, 789)
            e.Graphics.DrawLine(myPen, 0, 801, 560, 801)
            e.Graphics.DrawLine(myPen, 0, 813, 560, 813)
            e.Graphics.DrawLine(myPen, 0, 825, 560, 825)
            e.Graphics.DrawLine(myPen, 0, 837, 560, 837)
            e.Graphics.DrawLine(myPen, 0, 849, 560, 849)
            e.Graphics.DrawLine(myPen, 0, 861, 560, 861)
            e.Graphics.DrawLine(myPen, 0, 873, 560, 873)
            e.Graphics.DrawLine(myPen, 0, 885, 560, 885)
            e.Graphics.DrawLine(myPen, 0, 897, 560, 897)
            e.Graphics.DrawLine(myPen, 0, 909, 560, 909)
            e.Graphics.DrawLine(myPen, 0, 921, 560, 921)
            e.Graphics.DrawLine(myPen, 0, 933, 560, 933)
            e.Graphics.DrawLine(myPen, 0, 945, 560, 945)
            e.Graphics.DrawLine(myPen, 0, 957, 560, 957)
            e.Graphics.DrawLine(myPen, 0, 969, 560, 969)
            e.Graphics.DrawLine(myPen, 0, 981, 560, 981)
            e.Graphics.DrawLine(myPen, 0, 993, 560, 993)
            e.Graphics.DrawLine(myPen, 0, 1005, 560, 1005)
            e.Graphics.DrawLine(myPen, 0, 1017, 560, 1017)
            e.Graphics.DrawLine(myPen, 0, 1029, 560, 1029)
            e.Graphics.DrawLine(myPen, 0, 1041, 560, 1041)
            e.Graphics.DrawLine(myPen, 0, 1053, 560, 1053)
            e.Graphics.DrawLine(myPen, 0, 1065, 560, 1065)
            e.Graphics.DrawLine(myPen, 0, 1077, 560, 1077)
            e.Graphics.DrawLine(myPen, 0, 1089, 560, 1089)
            e.Graphics.DrawLine(myPen, 0, 1101, 560, 1101)
            e.Graphics.DrawLine(myPen, 0, 1113, 560, 1113)
            e.Graphics.DrawLine(myPen, 0, 1125, 560, 1125)
            e.Graphics.DrawLine(myPen, 0, 1137, 560, 1137)
            e.Graphics.DrawLine(myPen, 0, 1149, 560, 1149)
            e.Graphics.DrawLine(myPen, 0, 1161, 560, 1161)
            e.Graphics.DrawLine(myPen, 0, 1173, 560, 1173)
            e.Graphics.DrawLine(myPen, 0, 1185, 560, 1185)
            e.Graphics.DrawLine(myPen, 0, 1197, 560, 1197)
            e.Graphics.DrawLine(myPen, 0, 1209, 560, 1209)
            e.Graphics.DrawLine(myPen, 0, 1221, 560, 1221)
            e.Graphics.DrawLine(myPen, 0, 1233, 560, 1233)
            e.Graphics.DrawLine(myPen, 0, 1245, 560, 1245)
            e.Graphics.DrawLine(myPen, 0, 1257, 560, 1257)
            e.Graphics.DrawLine(myPen, 0, 1269, 560, 1269)

            e.Graphics.DrawLine(myPen, 0, 1281, 560, 1281)
            e.Graphics.DrawLine(myPen, 0, 1293, 560, 1293)
            e.Graphics.DrawLine(myPen, 0, 1305, 560, 1305)
            e.Graphics.DrawLine(myPen, 0, 1317, 560, 1317)
            e.Graphics.DrawLine(myPen, 0, 1329, 560, 1329)
            e.Graphics.DrawLine(myPen, 0, 1341, 560, 1341)



            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 0, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 100, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 135, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 190, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 290, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 325, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 380, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 480, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 515, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 570, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 670, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 705, 6)


            If DataGridView1.Rows.Count > 180 Then

                While i < 110

                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 0, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(12, i).Value, prFont1, Brushes.Black, 110, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 140, i * 12 + 20)
                    i += 1


                End While


                While i < 220
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 190, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(12, i).Value, prFont1, Brushes.Black, 300, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 330, i * 12 - 1300)
                    i += 1


                End While

                While i < 330
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 380, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(12, i).Value, prFont1, Brushes.Black, 490, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 520, i * 12 - 2620)
                    i += 1


                End While

                While i < DataGridView1.Rows.Count
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 570, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(12, i).Value, prFont1, Brushes.Black, 680, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 710, i * 12 - 3940)
                    i += 1


                End While


            End If

        End If



        If TextBox1.Text = "Aeropuerto" Then

            Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
            PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            e.Graphics.DrawImage(bm, 600, 1050)
            Dim i As Integer = 0
            Dim i1 As Integer = 0
            Dim i11 As Integer = 0
            Dim line As String = Nothing
            Dim myPen = New Pen(Color.Black, 1)
            Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
            Dim prFont2 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
            Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
            Dim prFont9 As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
            Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
            e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 600, 1120) '65
            e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 610, 1130) '75
            e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 600, 1145) '90
            e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 600, 1160) '105
            e.Graphics.DrawString(DateTimePicker2.Value, prFont2, Brushes.Black, 650, 1160) '105
            e.Graphics.DrawString("HOJA DE CHOFER DE SISTEMA.", prFont2, Brushes.Black, 600, 1185) '130
            e.Graphics.DrawString("Sucursal:", prFont2, Brushes.Black, 600, 1200) '145
            e.Graphics.DrawString(TextBox1.Text, prFont9, Brushes.Black, 660, 1200) '145
            e.Graphics.DrawString("Chofer:", prFont2, Brushes.Black, 600, 1220)
            '  e.Graphics.DrawString(TextBox156.Text, prFont9, Brushes.Black, 660, 1220)
            ' e.Graphics.DrawString("ANOTACIONES:", prFont9, Brushes.Black, 600, 185)

            Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows
                If linea.Cells(1).Value = "Concha blanca int." Then
                    linea.Cells(1).Value = "Concha bca. int."
                End If
                If linea.Cells(1).Value = "Minirosquita Janeth" Then
                    linea.Cells(1).Value = "Rosquita Janeth"
                End If
                If linea.Cells(1).Value = "Cuerno mantequilla" Then
                    linea.Cells(1).Value = "Cuerno mante"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria" Then
                    linea.Cells(1).Value = "Panqué de zana"
                End If
                If linea.Cells(1).Value = "Gel. Dominó especial" Then
                    linea.Cells(1).Value = "Gel. Dom. esp."
                End If
                If linea.Cells(1).Value = "Gel. Rompope fruta" Then
                    linea.Cells(1).Value = "Gel. Rompope"
                End If
                If linea.Cells(1).Value = "Leche deslactosada 1l" Then
                    linea.Cells(1).Value = "L. deslac. 1l"
                End If
                If linea.Cells(1).Value = "Pay queso chocolate" Then
                    linea.Cells(1).Value = "P. queso choco"
                End If
                If linea.Cells(1).Value = "Feliz Cumple con base" Then
                    linea.Cells(1).Value = "F.C. base"
                End If
                If linea.Cells(1).Value = "Caja Galletas .250 Kg" Then
                    linea.Cells(1).Value = "C. Galle. .250"
                End If
                If linea.Cells(1).Value = "Panqué de chocolate" Then
                    linea.Cells(1).Value = "Panqué de choco"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria barra" Then
                    linea.Cells(1).Value = "P. zana barra"
                End If
                If linea.Cells(1).Value = "Panqué de chabacano" Then
                    linea.Cells(1).Value = "Panqué chaba"
                End If
                If linea.Cells(1).Value = "Bolsa cafe ame 500gr" Then
                    linea.Cells(1).Value = "B. café a. 500"
                End If
                If linea.Cells(1).Value = "Bolsa cafe des 500gr" Then
                    linea.Cells(1).Value = "B. café d. 500gr"
                End If
                If linea.Cells(1).Value = "Gel. Med. Bombón" Then
                    linea.Cells(1).Value = "G.M. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó" Then
                    linea.Cells(1).Value = "G.M. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó esp." Then
                    linea.Cells(1).Value = "G.M. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Med. Betabel" Then
                    linea.Cells(1).Value = "G.M. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Med. Queso uva" Then
                    linea.Cells(1).Value = "G.M. Queso u"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tricolor" Then
                    linea.Cells(1).Value = "G.M. Tricolor"
                End If
                If linea.Cells(1).Value = "Caja Galletas .5 Kg" Then
                    linea.Cells(1).Value = "C. Galle .5"
                End If
                If linea.Cells(1).Value = "Gel. Med. Agua fruta" Then
                    linea.Cells(1).Value = "G.M. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Med. Rompope" Then
                    linea.Cells(1).Value = "G.M. Romp."
                End If
                If linea.Cells(1).Value = "Panqué elote barra" Then
                    linea.Cells(1).Value = "P. elote barra"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tuti fruti" Then
                    linea.Cells(1).Value = "G.M. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Med. Zanahoria" Then
                    linea.Cells(1).Value = "G.M. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Flores Arándanos" Then
                    linea.Cells(1).Value = "G. Flores A."
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 leches" Then
                    linea.Cells(1).Value = "G.M. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Agua fruta" Then
                    linea.Cells(1).Value = "G.G. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó esp." Then
                    linea.Cells(1).Value = "G.G. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Betabel" Then
                    linea.Cells(1).Value = "G.G. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Tuti fruti" Then
                    linea.Cells(1).Value = "G.G. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Rompope" Then
                    linea.Cells(1).Value = "G.G. Rompope"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 leches" Then
                    linea.Cells(1).Value = "G.G. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Zanahoria" Then
                    linea.Cells(1).Value = "G.G. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 chocolates" Then
                    linea.Cells(1).Value = "G.G. 3 choco"
                End If
                If linea.Cells(1).Value = "Caja Galletas 1 Kg" Then
                    linea.Cells(1).Value = "C. Galle 1"
                End If
                If linea.Cells(1).Value = "Pay queso zarza G." Then
                    linea.Cells(1).Value = "Pay q.zarza G."
                End If
                If linea.Cells(1).Value = "Gel. Vino tinto 22 cm" Then
                    linea.Cells(1).Value = "Gel. vino 22cm"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó" Then
                    linea.Cells(1).Value = "G.G. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Bombón" Then
                    linea.Cells(1).Value = "G.G. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 chocolates" Then
                    linea.Cells(1).Value = "G.M. 3 choco"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Queso uva" Then
                    linea.Cells(1).Value = "G.G. Queso u"
                End If
                If linea.Cells(1).Value = "Pay queso frutas G." Then
                    linea.Cells(1).Value = "Pay q.frutas G."
                End If
                If linea.Cells(1).Value = "Pay queso fresa G." Then
                    linea.Cells(1).Value = "Pay q.fresa G."
                End If
            Next


            'dibujar linea
            e.Graphics.DrawLine(myPen, 0, 21, 770, 21) '+12
            e.Graphics.DrawLine(myPen, 0, 33, 770, 33)
            e.Graphics.DrawLine(myPen, 0, 45, 770, 45)
            e.Graphics.DrawLine(myPen, 0, 57, 770, 57)
            e.Graphics.DrawLine(myPen, 0, 69, 770, 69)
            e.Graphics.DrawLine(myPen, 0, 81, 770, 81)
            e.Graphics.DrawLine(myPen, 0, 93, 770, 93)
            e.Graphics.DrawLine(myPen, 0, 105, 770, 105)
            e.Graphics.DrawLine(myPen, 0, 117, 770, 117)
            e.Graphics.DrawLine(myPen, 0, 129, 770, 129)
            e.Graphics.DrawLine(myPen, 0, 141, 770, 141)
            e.Graphics.DrawLine(myPen, 0, 153, 770, 153)
            e.Graphics.DrawLine(myPen, 0, 165, 770, 165)
            e.Graphics.DrawLine(myPen, 0, 177, 770, 177)
            e.Graphics.DrawLine(myPen, 0, 189, 770, 189)
            e.Graphics.DrawLine(myPen, 0, 201, 770, 201)
            e.Graphics.DrawLine(myPen, 0, 213, 770, 213)
            e.Graphics.DrawLine(myPen, 0, 225, 770, 225)
            e.Graphics.DrawLine(myPen, 0, 237, 770, 237)
            e.Graphics.DrawLine(myPen, 0, 249, 770, 249)
            e.Graphics.DrawLine(myPen, 0, 261, 770, 261)
            e.Graphics.DrawLine(myPen, 0, 273, 770, 273)
            e.Graphics.DrawLine(myPen, 0, 285, 770, 285) 'hasta 31
            e.Graphics.DrawLine(myPen, 0, 297, 770, 297)
            e.Graphics.DrawLine(myPen, 0, 309, 770, 309)
            e.Graphics.DrawLine(myPen, 0, 321, 770, 321)
            e.Graphics.DrawLine(myPen, 0, 333, 770, 333)
            e.Graphics.DrawLine(myPen, 0, 345, 770, 345)
            e.Graphics.DrawLine(myPen, 0, 357, 770, 357)
            e.Graphics.DrawLine(myPen, 0, 369, 770, 369)
            e.Graphics.DrawLine(myPen, 0, 381, 770, 381)


            'aqui inician livbres las lineas
            e.Graphics.DrawLine(myPen, 0, 393, 560, 393)
            e.Graphics.DrawLine(myPen, 0, 405, 560, 405)
            e.Graphics.DrawLine(myPen, 0, 417, 560, 417)
            e.Graphics.DrawLine(myPen, 0, 429, 560, 429)
            e.Graphics.DrawLine(myPen, 0, 441, 560, 441)
            e.Graphics.DrawLine(myPen, 0, 453, 560, 453)
            e.Graphics.DrawLine(myPen, 0, 465, 560, 465)
            e.Graphics.DrawLine(myPen, 0, 477, 560, 477)
            e.Graphics.DrawLine(myPen, 0, 489, 560, 489)
            e.Graphics.DrawLine(myPen, 0, 501, 560, 501)
            e.Graphics.DrawLine(myPen, 0, 513, 560, 513)
            e.Graphics.DrawLine(myPen, 0, 525, 560, 525)
            e.Graphics.DrawLine(myPen, 0, 537, 560, 537)
            e.Graphics.DrawLine(myPen, 0, 549, 560, 549)
            e.Graphics.DrawLine(myPen, 0, 561, 560, 561)
            e.Graphics.DrawLine(myPen, 0, 573, 560, 573)
            e.Graphics.DrawLine(myPen, 0, 585, 560, 585)
            e.Graphics.DrawLine(myPen, 0, 597, 560, 597)
            e.Graphics.DrawLine(myPen, 0, 609, 560, 609)
            e.Graphics.DrawLine(myPen, 0, 621, 560, 621)
            e.Graphics.DrawLine(myPen, 0, 633, 560, 633)
            e.Graphics.DrawLine(myPen, 0, 645, 560, 645)
            e.Graphics.DrawLine(myPen, 0, 657, 560, 657)
            e.Graphics.DrawLine(myPen, 0, 669, 560, 669)
            e.Graphics.DrawLine(myPen, 0, 681, 560, 681)
            e.Graphics.DrawLine(myPen, 0, 693, 560, 693)
            e.Graphics.DrawLine(myPen, 0, 705, 560, 705)
            e.Graphics.DrawLine(myPen, 0, 717, 560, 717)
            e.Graphics.DrawLine(myPen, 0, 729, 560, 729)
            e.Graphics.DrawLine(myPen, 0, 741, 560, 741)
            e.Graphics.DrawLine(myPen, 0, 753, 560, 753)
            e.Graphics.DrawLine(myPen, 0, 765, 560, 765)
            e.Graphics.DrawLine(myPen, 0, 777, 560, 777)
            e.Graphics.DrawLine(myPen, 0, 789, 560, 789)
            e.Graphics.DrawLine(myPen, 0, 801, 560, 801)
            e.Graphics.DrawLine(myPen, 0, 813, 560, 813)
            e.Graphics.DrawLine(myPen, 0, 825, 560, 825)
            e.Graphics.DrawLine(myPen, 0, 837, 560, 837)
            e.Graphics.DrawLine(myPen, 0, 849, 560, 849)
            e.Graphics.DrawLine(myPen, 0, 861, 560, 861)
            e.Graphics.DrawLine(myPen, 0, 873, 560, 873)
            e.Graphics.DrawLine(myPen, 0, 885, 560, 885)
            e.Graphics.DrawLine(myPen, 0, 897, 560, 897)
            e.Graphics.DrawLine(myPen, 0, 909, 560, 909)
            e.Graphics.DrawLine(myPen, 0, 921, 560, 921)
            e.Graphics.DrawLine(myPen, 0, 933, 560, 933)
            e.Graphics.DrawLine(myPen, 0, 945, 560, 945)
            e.Graphics.DrawLine(myPen, 0, 957, 560, 957)
            e.Graphics.DrawLine(myPen, 0, 969, 560, 969)
            e.Graphics.DrawLine(myPen, 0, 981, 560, 981)
            e.Graphics.DrawLine(myPen, 0, 993, 560, 993)
            e.Graphics.DrawLine(myPen, 0, 1005, 560, 1005)
            e.Graphics.DrawLine(myPen, 0, 1017, 560, 1017)
            e.Graphics.DrawLine(myPen, 0, 1029, 560, 1029)
            e.Graphics.DrawLine(myPen, 0, 1041, 560, 1041)
            e.Graphics.DrawLine(myPen, 0, 1053, 560, 1053)
            e.Graphics.DrawLine(myPen, 0, 1065, 560, 1065)
            e.Graphics.DrawLine(myPen, 0, 1077, 560, 1077)
            e.Graphics.DrawLine(myPen, 0, 1089, 560, 1089)
            e.Graphics.DrawLine(myPen, 0, 1101, 560, 1101)
            e.Graphics.DrawLine(myPen, 0, 1113, 560, 1113)
            e.Graphics.DrawLine(myPen, 0, 1125, 560, 1125)
            e.Graphics.DrawLine(myPen, 0, 1137, 560, 1137)
            e.Graphics.DrawLine(myPen, 0, 1149, 560, 1149)
            e.Graphics.DrawLine(myPen, 0, 1161, 560, 1161)
            e.Graphics.DrawLine(myPen, 0, 1173, 560, 1173)
            e.Graphics.DrawLine(myPen, 0, 1185, 560, 1185)
            e.Graphics.DrawLine(myPen, 0, 1197, 560, 1197)
            e.Graphics.DrawLine(myPen, 0, 1209, 560, 1209)
            e.Graphics.DrawLine(myPen, 0, 1221, 560, 1221)
            e.Graphics.DrawLine(myPen, 0, 1233, 560, 1233)
            e.Graphics.DrawLine(myPen, 0, 1245, 560, 1245)
            e.Graphics.DrawLine(myPen, 0, 1257, 560, 1257)
            e.Graphics.DrawLine(myPen, 0, 1269, 560, 1269)

            e.Graphics.DrawLine(myPen, 0, 1281, 560, 1281)
            e.Graphics.DrawLine(myPen, 0, 1293, 560, 1293)
            e.Graphics.DrawLine(myPen, 0, 1305, 560, 1305)
            e.Graphics.DrawLine(myPen, 0, 1317, 560, 1317)
            e.Graphics.DrawLine(myPen, 0, 1329, 560, 1329)
            e.Graphics.DrawLine(myPen, 0, 1341, 560, 1341)


            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 0, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 100, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 135, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 190, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 290, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 325, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 380, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 480, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 515, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 570, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 670, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 705, 6)


            If DataGridView1.Rows.Count > 180 Then

                While i < 110

                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 0, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(4, i).Value, prFont1, Brushes.Black, 110, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 140, i * 12 + 20)
                    i += 1


                End While


                While i < 220
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 190, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(4, i).Value, prFont1, Brushes.Black, 300, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 330, i * 12 - 1300)
                    i += 1


                End While

                While i < 330
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 380, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(4, i).Value, prFont1, Brushes.Black, 490, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 520, i * 12 - 2620)
                    i += 1


                End While

                While i < DataGridView1.Rows.Count
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 570, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(4, i).Value, prFont1, Brushes.Black, 680, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 710, i * 12 - 3940)
                    i += 1


                End While


            End If

        End If



        If TextBox1.Text = "Ocoyoacac" Then

            Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
            PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            e.Graphics.DrawImage(bm, 600, 1050)
            Dim i As Integer = 0
            Dim i1 As Integer = 0
            Dim i11 As Integer = 0
            Dim line As String = Nothing
            Dim myPen = New Pen(Color.Black, 1)
            Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
            Dim prFont2 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
            Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
            Dim prFont9 As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
            Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
            e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 600, 1120) '65
            e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 610, 1130) '75
            e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 600, 1145) '90
            e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 600, 1160) '105
            e.Graphics.DrawString(DateTimePicker2.Value, prFont2, Brushes.Black, 650, 1160) '105
            e.Graphics.DrawString("HOJA DE CHOFER DE SISTEMA.", prFont2, Brushes.Black, 600, 1185) '130
            e.Graphics.DrawString("Sucursal:", prFont2, Brushes.Black, 600, 1200) '145
            e.Graphics.DrawString(TextBox1.Text, prFont9, Brushes.Black, 660, 1200) '145
            e.Graphics.DrawString("Chofer:", prFont2, Brushes.Black, 600, 1220)
            'e.Graphics.DrawString(TextBox156.Text, prFont9, Brushes.Black, 660, 1220)
            ' e.Graphics.DrawString("ANOTACIONES:", prFont9, Brushes.Black, 600, 185)

            Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows
                If linea.Cells(1).Value = "Concha blanca int." Then
                    linea.Cells(1).Value = "Concha bca. int."
                End If
                If linea.Cells(1).Value = "Minirosquita Janeth" Then
                    linea.Cells(1).Value = "Rosquita Janeth"
                End If
                If linea.Cells(1).Value = "Cuerno mantequilla" Then
                    linea.Cells(1).Value = "Cuerno mante"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria" Then
                    linea.Cells(1).Value = "Panqué de zana"
                End If
                If linea.Cells(1).Value = "Gel. Dominó especial" Then
                    linea.Cells(1).Value = "Gel. Dom. esp."
                End If
                If linea.Cells(1).Value = "Gel. Rompope fruta" Then
                    linea.Cells(1).Value = "Gel. Rompope"
                End If
                If linea.Cells(1).Value = "Leche deslactosada 1l" Then
                    linea.Cells(1).Value = "L. deslac. 1l"
                End If
                If linea.Cells(1).Value = "Pay queso chocolate" Then
                    linea.Cells(1).Value = "P. queso choco"
                End If
                If linea.Cells(1).Value = "Feliz Cumple con base" Then
                    linea.Cells(1).Value = "F.C. base"
                End If
                If linea.Cells(1).Value = "Caja Galletas .250 Kg" Then
                    linea.Cells(1).Value = "C. Galle. .250"
                End If
                If linea.Cells(1).Value = "Panqué de chocolate" Then
                    linea.Cells(1).Value = "Panqué de choco"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria barra" Then
                    linea.Cells(1).Value = "P. zana barra"
                End If
                If linea.Cells(1).Value = "Panqué de chabacano" Then
                    linea.Cells(1).Value = "Panqué chaba"
                End If
                If linea.Cells(1).Value = "Bolsa cafe ame 500gr" Then
                    linea.Cells(1).Value = "B. café a. 500"
                End If
                If linea.Cells(1).Value = "Bolsa cafe des 500gr" Then
                    linea.Cells(1).Value = "B. café d. 500gr"
                End If
                If linea.Cells(1).Value = "Gel. Med. Bombón" Then
                    linea.Cells(1).Value = "G.M. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó" Then
                    linea.Cells(1).Value = "G.M. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó esp." Then
                    linea.Cells(1).Value = "G.M. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Med. Betabel" Then
                    linea.Cells(1).Value = "G.M. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Med. Queso uva" Then
                    linea.Cells(1).Value = "G.M. Queso u"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tricolor" Then
                    linea.Cells(1).Value = "G.M. Tricolor"
                End If
                If linea.Cells(1).Value = "Caja Galletas .5 Kg" Then
                    linea.Cells(1).Value = "C. Galle .5"
                End If
                If linea.Cells(1).Value = "Gel. Med. Agua fruta" Then
                    linea.Cells(1).Value = "G.M. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Med. Rompope" Then
                    linea.Cells(1).Value = "G.M. Romp."
                End If
                If linea.Cells(1).Value = "Panqué elote barra" Then
                    linea.Cells(1).Value = "P. elote barra"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tuti fruti" Then
                    linea.Cells(1).Value = "G.M. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Med. Zanahoria" Then
                    linea.Cells(1).Value = "G.M. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Flores Arándanos" Then
                    linea.Cells(1).Value = "G. Flores A."
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 leches" Then
                    linea.Cells(1).Value = "G.M. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Agua fruta" Then
                    linea.Cells(1).Value = "G.G. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó esp." Then
                    linea.Cells(1).Value = "G.G. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Betabel" Then
                    linea.Cells(1).Value = "G.G. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Tuti fruti" Then
                    linea.Cells(1).Value = "G.G. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Rompope" Then
                    linea.Cells(1).Value = "G.G. Rompope"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 leches" Then
                    linea.Cells(1).Value = "G.G. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Zanahoria" Then
                    linea.Cells(1).Value = "G.G. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 chocolates" Then
                    linea.Cells(1).Value = "G.G. 3 choco"
                End If
                If linea.Cells(1).Value = "Caja Galletas 1 Kg" Then
                    linea.Cells(1).Value = "C. Galle 1"
                End If
                If linea.Cells(1).Value = "Pay queso zarza G." Then
                    linea.Cells(1).Value = "Pay q.zarza G."
                End If
                If linea.Cells(1).Value = "Gel. Vino tinto 22 cm" Then
                    linea.Cells(1).Value = "Gel. vino 22cm"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó" Then
                    linea.Cells(1).Value = "G.G. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Bombón" Then
                    linea.Cells(1).Value = "G.G. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 chocolates" Then
                    linea.Cells(1).Value = "G.M. 3 choco"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Queso uva" Then
                    linea.Cells(1).Value = "G.G. Queso u"
                End If
                If linea.Cells(1).Value = "Pay queso frutas G." Then
                    linea.Cells(1).Value = "Pay q.frutas G."
                End If
                If linea.Cells(1).Value = "Pay queso fresa G." Then
                    linea.Cells(1).Value = "Pay q.fresa G."
                End If
            Next


            'dibujar linea
            e.Graphics.DrawLine(myPen, 0, 21, 770, 21) '+12
            e.Graphics.DrawLine(myPen, 0, 33, 770, 33)
            e.Graphics.DrawLine(myPen, 0, 45, 770, 45)
            e.Graphics.DrawLine(myPen, 0, 57, 770, 57)
            e.Graphics.DrawLine(myPen, 0, 69, 770, 69)
            e.Graphics.DrawLine(myPen, 0, 81, 770, 81)
            e.Graphics.DrawLine(myPen, 0, 93, 770, 93)
            e.Graphics.DrawLine(myPen, 0, 105, 770, 105)
            e.Graphics.DrawLine(myPen, 0, 117, 770, 117)
            e.Graphics.DrawLine(myPen, 0, 129, 770, 129)
            e.Graphics.DrawLine(myPen, 0, 141, 770, 141)
            e.Graphics.DrawLine(myPen, 0, 153, 770, 153)
            e.Graphics.DrawLine(myPen, 0, 165, 770, 165)
            e.Graphics.DrawLine(myPen, 0, 177, 770, 177)
            e.Graphics.DrawLine(myPen, 0, 189, 770, 189)
            e.Graphics.DrawLine(myPen, 0, 201, 770, 201)
            e.Graphics.DrawLine(myPen, 0, 213, 770, 213)
            e.Graphics.DrawLine(myPen, 0, 225, 770, 225)
            e.Graphics.DrawLine(myPen, 0, 237, 770, 237)
            e.Graphics.DrawLine(myPen, 0, 249, 770, 249)
            e.Graphics.DrawLine(myPen, 0, 261, 770, 261)
            e.Graphics.DrawLine(myPen, 0, 273, 770, 273)
            e.Graphics.DrawLine(myPen, 0, 285, 770, 285) 'hasta 31
            e.Graphics.DrawLine(myPen, 0, 297, 770, 297)
            e.Graphics.DrawLine(myPen, 0, 309, 770, 309)
            e.Graphics.DrawLine(myPen, 0, 321, 770, 321)
            e.Graphics.DrawLine(myPen, 0, 333, 770, 333)
            e.Graphics.DrawLine(myPen, 0, 345, 770, 345)
            e.Graphics.DrawLine(myPen, 0, 357, 770, 357)
            e.Graphics.DrawLine(myPen, 0, 369, 770, 369)
            e.Graphics.DrawLine(myPen, 0, 381, 770, 381)


            'aqui inician livbres las lineas
            e.Graphics.DrawLine(myPen, 0, 393, 560, 393)
            e.Graphics.DrawLine(myPen, 0, 405, 560, 405)
            e.Graphics.DrawLine(myPen, 0, 417, 560, 417)
            e.Graphics.DrawLine(myPen, 0, 429, 560, 429)
            e.Graphics.DrawLine(myPen, 0, 441, 560, 441)
            e.Graphics.DrawLine(myPen, 0, 453, 560, 453)
            e.Graphics.DrawLine(myPen, 0, 465, 560, 465)
            e.Graphics.DrawLine(myPen, 0, 477, 560, 477)
            e.Graphics.DrawLine(myPen, 0, 489, 560, 489)
            e.Graphics.DrawLine(myPen, 0, 501, 560, 501)
            e.Graphics.DrawLine(myPen, 0, 513, 560, 513)
            e.Graphics.DrawLine(myPen, 0, 525, 560, 525)
            e.Graphics.DrawLine(myPen, 0, 537, 560, 537)
            e.Graphics.DrawLine(myPen, 0, 549, 560, 549)
            e.Graphics.DrawLine(myPen, 0, 561, 560, 561)
            e.Graphics.DrawLine(myPen, 0, 573, 560, 573)
            e.Graphics.DrawLine(myPen, 0, 585, 560, 585)
            e.Graphics.DrawLine(myPen, 0, 597, 560, 597)
            e.Graphics.DrawLine(myPen, 0, 609, 560, 609)
            e.Graphics.DrawLine(myPen, 0, 621, 560, 621)
            e.Graphics.DrawLine(myPen, 0, 633, 560, 633)
            e.Graphics.DrawLine(myPen, 0, 645, 560, 645)
            e.Graphics.DrawLine(myPen, 0, 657, 560, 657)
            e.Graphics.DrawLine(myPen, 0, 669, 560, 669)
            e.Graphics.DrawLine(myPen, 0, 681, 560, 681)
            e.Graphics.DrawLine(myPen, 0, 693, 560, 693)
            e.Graphics.DrawLine(myPen, 0, 705, 560, 705)
            e.Graphics.DrawLine(myPen, 0, 717, 560, 717)
            e.Graphics.DrawLine(myPen, 0, 729, 560, 729)
            e.Graphics.DrawLine(myPen, 0, 741, 560, 741)
            e.Graphics.DrawLine(myPen, 0, 753, 560, 753)
            e.Graphics.DrawLine(myPen, 0, 765, 560, 765)
            e.Graphics.DrawLine(myPen, 0, 777, 560, 777)
            e.Graphics.DrawLine(myPen, 0, 789, 560, 789)
            e.Graphics.DrawLine(myPen, 0, 801, 560, 801)
            e.Graphics.DrawLine(myPen, 0, 813, 560, 813)
            e.Graphics.DrawLine(myPen, 0, 825, 560, 825)
            e.Graphics.DrawLine(myPen, 0, 837, 560, 837)
            e.Graphics.DrawLine(myPen, 0, 849, 560, 849)
            e.Graphics.DrawLine(myPen, 0, 861, 560, 861)
            e.Graphics.DrawLine(myPen, 0, 873, 560, 873)
            e.Graphics.DrawLine(myPen, 0, 885, 560, 885)
            e.Graphics.DrawLine(myPen, 0, 897, 560, 897)
            e.Graphics.DrawLine(myPen, 0, 909, 560, 909)
            e.Graphics.DrawLine(myPen, 0, 921, 560, 921)
            e.Graphics.DrawLine(myPen, 0, 933, 560, 933)
            e.Graphics.DrawLine(myPen, 0, 945, 560, 945)
            e.Graphics.DrawLine(myPen, 0, 957, 560, 957)
            e.Graphics.DrawLine(myPen, 0, 969, 560, 969)
            e.Graphics.DrawLine(myPen, 0, 981, 560, 981)
            e.Graphics.DrawLine(myPen, 0, 993, 560, 993)
            e.Graphics.DrawLine(myPen, 0, 1005, 560, 1005)
            e.Graphics.DrawLine(myPen, 0, 1017, 560, 1017)
            e.Graphics.DrawLine(myPen, 0, 1029, 560, 1029)
            e.Graphics.DrawLine(myPen, 0, 1041, 560, 1041)
            e.Graphics.DrawLine(myPen, 0, 1053, 560, 1053)
            e.Graphics.DrawLine(myPen, 0, 1065, 560, 1065)
            e.Graphics.DrawLine(myPen, 0, 1077, 560, 1077)
            e.Graphics.DrawLine(myPen, 0, 1089, 560, 1089)
            e.Graphics.DrawLine(myPen, 0, 1101, 560, 1101)
            e.Graphics.DrawLine(myPen, 0, 1113, 560, 1113)
            e.Graphics.DrawLine(myPen, 0, 1125, 560, 1125)
            e.Graphics.DrawLine(myPen, 0, 1137, 560, 1137)
            e.Graphics.DrawLine(myPen, 0, 1149, 560, 1149)
            e.Graphics.DrawLine(myPen, 0, 1161, 560, 1161)
            e.Graphics.DrawLine(myPen, 0, 1173, 560, 1173)
            e.Graphics.DrawLine(myPen, 0, 1185, 560, 1185)
            e.Graphics.DrawLine(myPen, 0, 1197, 560, 1197)
            e.Graphics.DrawLine(myPen, 0, 1209, 560, 1209)
            e.Graphics.DrawLine(myPen, 0, 1221, 560, 1221)
            e.Graphics.DrawLine(myPen, 0, 1233, 560, 1233)
            e.Graphics.DrawLine(myPen, 0, 1245, 560, 1245)
            e.Graphics.DrawLine(myPen, 0, 1257, 560, 1257)
            e.Graphics.DrawLine(myPen, 0, 1269, 560, 1269)

            e.Graphics.DrawLine(myPen, 0, 1281, 560, 1281)
            e.Graphics.DrawLine(myPen, 0, 1293, 560, 1293)
            e.Graphics.DrawLine(myPen, 0, 1305, 560, 1305)
            e.Graphics.DrawLine(myPen, 0, 1317, 560, 1317)
            e.Graphics.DrawLine(myPen, 0, 1329, 560, 1329)
            e.Graphics.DrawLine(myPen, 0, 1341, 560, 1341)



            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 0, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 100, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 135, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 190, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 290, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 325, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 380, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 480, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 515, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 570, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 670, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 705, 6)


            If DataGridView1.Rows.Count > 180 Then

                While i < 110

                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 0, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(19, i).Value, prFont1, Brushes.Black, 110, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 140, i * 12 + 20)
                    i += 1


                End While


                While i < 220
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 190, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(19, i).Value, prFont1, Brushes.Black, 300, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 330, i * 12 - 1300)
                    i += 1


                End While

                While i < 330
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 380, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(19, i).Value, prFont1, Brushes.Black, 490, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 520, i * 12 - 2620)
                    i += 1


                End While

                While i < DataGridView1.Rows.Count
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 570, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(19, i).Value, prFont1, Brushes.Black, 680, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 710, i * 12 - 3940)
                    i += 1


                End While


            End If

        End If



        If TextBox1.Text = "Carranza" Then

            Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
            PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            e.Graphics.DrawImage(bm, 600, 1050)
            Dim i As Integer = 0
            Dim i1 As Integer = 0
            Dim i11 As Integer = 0
            Dim line As String = Nothing
            Dim myPen = New Pen(Color.Black, 1)
            Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
            Dim prFont2 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
            Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
            Dim prFont9 As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
            Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
            e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 600, 1120) '65
            e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 610, 1130) '75
            e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 600, 1145) '90
            e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 600, 1160) '105
            e.Graphics.DrawString(DateTimePicker2.Value, prFont2, Brushes.Black, 650, 1160) '105
            e.Graphics.DrawString("HOJA DE CHOFER DE SISTEMA.", prFont2, Brushes.Black, 600, 1185) '130
            e.Graphics.DrawString("Sucursal:", prFont2, Brushes.Black, 600, 1200) '145
            e.Graphics.DrawString(TextBox1.Text, prFont9, Brushes.Black, 660, 1200) '145
            e.Graphics.DrawString("Chofer:", prFont2, Brushes.Black, 600, 1220)
            'e.Graphics.DrawString(TextBox156.Text, prFont9, Brushes.Black, 660, 1220)
            ' e.Graphics.DrawString("ANOTACIONES:", prFont9, Brushes.Black, 600, 185)

            Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows
                If linea.Cells(1).Value = "Concha blanca int." Then
                    linea.Cells(1).Value = "Concha bca. int."
                End If
                If linea.Cells(1).Value = "Minirosquita Janeth" Then
                    linea.Cells(1).Value = "Rosquita Janeth"
                End If
                If linea.Cells(1).Value = "Cuerno mantequilla" Then
                    linea.Cells(1).Value = "Cuerno mante"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria" Then
                    linea.Cells(1).Value = "Panqué de zana"
                End If
                If linea.Cells(1).Value = "Gel. Dominó especial" Then
                    linea.Cells(1).Value = "Gel. Dom. esp."
                End If
                If linea.Cells(1).Value = "Gel. Rompope fruta" Then
                    linea.Cells(1).Value = "Gel. Rompope"
                End If
                If linea.Cells(1).Value = "Leche deslactosada 1l" Then
                    linea.Cells(1).Value = "L. deslac. 1l"
                End If
                If linea.Cells(1).Value = "Pay queso chocolate" Then
                    linea.Cells(1).Value = "P. queso choco"
                End If
                If linea.Cells(1).Value = "Feliz Cumple con base" Then
                    linea.Cells(1).Value = "F.C. base"
                End If
                If linea.Cells(1).Value = "Caja Galletas .250 Kg" Then
                    linea.Cells(1).Value = "C. Galle. .250"
                End If
                If linea.Cells(1).Value = "Panqué de chocolate" Then
                    linea.Cells(1).Value = "Panqué de choco"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria barra" Then
                    linea.Cells(1).Value = "P. zana barra"
                End If
                If linea.Cells(1).Value = "Panqué de chabacano" Then
                    linea.Cells(1).Value = "Panqué chaba"
                End If
                If linea.Cells(1).Value = "Bolsa cafe ame 500gr" Then
                    linea.Cells(1).Value = "B. café a. 500"
                End If
                If linea.Cells(1).Value = "Bolsa cafe des 500gr" Then
                    linea.Cells(1).Value = "B. café d. 500gr"
                End If
                If linea.Cells(1).Value = "Gel. Med. Bombón" Then
                    linea.Cells(1).Value = "G.M. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó" Then
                    linea.Cells(1).Value = "G.M. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó esp." Then
                    linea.Cells(1).Value = "G.M. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Med. Betabel" Then
                    linea.Cells(1).Value = "G.M. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Med. Queso uva" Then
                    linea.Cells(1).Value = "G.M. Queso u"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tricolor" Then
                    linea.Cells(1).Value = "G.M. Tricolor"
                End If
                If linea.Cells(1).Value = "Caja Galletas .5 Kg" Then
                    linea.Cells(1).Value = "C. Galle .5"
                End If
                If linea.Cells(1).Value = "Gel. Med. Agua fruta" Then
                    linea.Cells(1).Value = "G.M. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Med. Rompope" Then
                    linea.Cells(1).Value = "G.M. Romp."
                End If
                If linea.Cells(1).Value = "Panqué elote barra" Then
                    linea.Cells(1).Value = "P. elote barra"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tuti fruti" Then
                    linea.Cells(1).Value = "G.M. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Med. Zanahoria" Then
                    linea.Cells(1).Value = "G.M. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Flores Arándanos" Then
                    linea.Cells(1).Value = "G. Flores A."
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 leches" Then
                    linea.Cells(1).Value = "G.M. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Agua fruta" Then
                    linea.Cells(1).Value = "G.G. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó esp." Then
                    linea.Cells(1).Value = "G.G. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Betabel" Then
                    linea.Cells(1).Value = "G.G. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Tuti fruti" Then
                    linea.Cells(1).Value = "G.G. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Rompope" Then
                    linea.Cells(1).Value = "G.G. Rompope"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 leches" Then
                    linea.Cells(1).Value = "G.G. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Zanahoria" Then
                    linea.Cells(1).Value = "G.G. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 chocolates" Then
                    linea.Cells(1).Value = "G.G. 3 choco"
                End If
                If linea.Cells(1).Value = "Caja Galletas 1 Kg" Then
                    linea.Cells(1).Value = "C. Galle 1"
                End If
                If linea.Cells(1).Value = "Pay queso zarza G." Then
                    linea.Cells(1).Value = "Pay q.zarza G."
                End If
                If linea.Cells(1).Value = "Gel. Vino tinto 22 cm" Then
                    linea.Cells(1).Value = "Gel. vino 22cm"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó" Then
                    linea.Cells(1).Value = "G.G. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Bombón" Then
                    linea.Cells(1).Value = "G.G. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 chocolates" Then
                    linea.Cells(1).Value = "G.M. 3 choco"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Queso uva" Then
                    linea.Cells(1).Value = "G.G. Queso u"
                End If
                If linea.Cells(1).Value = "Pay queso frutas G." Then
                    linea.Cells(1).Value = "Pay q.frutas G."
                End If
                If linea.Cells(1).Value = "Pay queso fresa G." Then
                    linea.Cells(1).Value = "Pay q.fresa G."
                End If
            Next


            'dibujar linea
            e.Graphics.DrawLine(myPen, 0, 21, 770, 21) '+12
            e.Graphics.DrawLine(myPen, 0, 33, 770, 33)
            e.Graphics.DrawLine(myPen, 0, 45, 770, 45)
            e.Graphics.DrawLine(myPen, 0, 57, 770, 57)
            e.Graphics.DrawLine(myPen, 0, 69, 770, 69)
            e.Graphics.DrawLine(myPen, 0, 81, 770, 81)
            e.Graphics.DrawLine(myPen, 0, 93, 770, 93)
            e.Graphics.DrawLine(myPen, 0, 105, 770, 105)
            e.Graphics.DrawLine(myPen, 0, 117, 770, 117)
            e.Graphics.DrawLine(myPen, 0, 129, 770, 129)
            e.Graphics.DrawLine(myPen, 0, 141, 770, 141)
            e.Graphics.DrawLine(myPen, 0, 153, 770, 153)
            e.Graphics.DrawLine(myPen, 0, 165, 770, 165)
            e.Graphics.DrawLine(myPen, 0, 177, 770, 177)
            e.Graphics.DrawLine(myPen, 0, 189, 770, 189)
            e.Graphics.DrawLine(myPen, 0, 201, 770, 201)
            e.Graphics.DrawLine(myPen, 0, 213, 770, 213)
            e.Graphics.DrawLine(myPen, 0, 225, 770, 225)
            e.Graphics.DrawLine(myPen, 0, 237, 770, 237)
            e.Graphics.DrawLine(myPen, 0, 249, 770, 249)
            e.Graphics.DrawLine(myPen, 0, 261, 770, 261)
            e.Graphics.DrawLine(myPen, 0, 273, 770, 273)
            e.Graphics.DrawLine(myPen, 0, 285, 770, 285) 'hasta 31
            e.Graphics.DrawLine(myPen, 0, 297, 770, 297)
            e.Graphics.DrawLine(myPen, 0, 309, 770, 309)
            e.Graphics.DrawLine(myPen, 0, 321, 770, 321)
            e.Graphics.DrawLine(myPen, 0, 333, 770, 333)
            e.Graphics.DrawLine(myPen, 0, 345, 770, 345)
            e.Graphics.DrawLine(myPen, 0, 357, 770, 357)
            e.Graphics.DrawLine(myPen, 0, 369, 770, 369)
            e.Graphics.DrawLine(myPen, 0, 381, 770, 381)


            'aqui inician livbres las lineas
            e.Graphics.DrawLine(myPen, 0, 393, 560, 393)
            e.Graphics.DrawLine(myPen, 0, 405, 560, 405)
            e.Graphics.DrawLine(myPen, 0, 417, 560, 417)
            e.Graphics.DrawLine(myPen, 0, 429, 560, 429)
            e.Graphics.DrawLine(myPen, 0, 441, 560, 441)
            e.Graphics.DrawLine(myPen, 0, 453, 560, 453)
            e.Graphics.DrawLine(myPen, 0, 465, 560, 465)
            e.Graphics.DrawLine(myPen, 0, 477, 560, 477)
            e.Graphics.DrawLine(myPen, 0, 489, 560, 489)
            e.Graphics.DrawLine(myPen, 0, 501, 560, 501)
            e.Graphics.DrawLine(myPen, 0, 513, 560, 513)
            e.Graphics.DrawLine(myPen, 0, 525, 560, 525)
            e.Graphics.DrawLine(myPen, 0, 537, 560, 537)
            e.Graphics.DrawLine(myPen, 0, 549, 560, 549)
            e.Graphics.DrawLine(myPen, 0, 561, 560, 561)
            e.Graphics.DrawLine(myPen, 0, 573, 560, 573)
            e.Graphics.DrawLine(myPen, 0, 585, 560, 585)
            e.Graphics.DrawLine(myPen, 0, 597, 560, 597)
            e.Graphics.DrawLine(myPen, 0, 609, 560, 609)
            e.Graphics.DrawLine(myPen, 0, 621, 560, 621)
            e.Graphics.DrawLine(myPen, 0, 633, 560, 633)
            e.Graphics.DrawLine(myPen, 0, 645, 560, 645)
            e.Graphics.DrawLine(myPen, 0, 657, 560, 657)
            e.Graphics.DrawLine(myPen, 0, 669, 560, 669)
            e.Graphics.DrawLine(myPen, 0, 681, 560, 681)
            e.Graphics.DrawLine(myPen, 0, 693, 560, 693)
            e.Graphics.DrawLine(myPen, 0, 705, 560, 705)
            e.Graphics.DrawLine(myPen, 0, 717, 560, 717)
            e.Graphics.DrawLine(myPen, 0, 729, 560, 729)
            e.Graphics.DrawLine(myPen, 0, 741, 560, 741)
            e.Graphics.DrawLine(myPen, 0, 753, 560, 753)
            e.Graphics.DrawLine(myPen, 0, 765, 560, 765)
            e.Graphics.DrawLine(myPen, 0, 777, 560, 777)
            e.Graphics.DrawLine(myPen, 0, 789, 560, 789)
            e.Graphics.DrawLine(myPen, 0, 801, 560, 801)
            e.Graphics.DrawLine(myPen, 0, 813, 560, 813)
            e.Graphics.DrawLine(myPen, 0, 825, 560, 825)
            e.Graphics.DrawLine(myPen, 0, 837, 560, 837)
            e.Graphics.DrawLine(myPen, 0, 849, 560, 849)
            e.Graphics.DrawLine(myPen, 0, 861, 560, 861)
            e.Graphics.DrawLine(myPen, 0, 873, 560, 873)
            e.Graphics.DrawLine(myPen, 0, 885, 560, 885)
            e.Graphics.DrawLine(myPen, 0, 897, 560, 897)
            e.Graphics.DrawLine(myPen, 0, 909, 560, 909)
            e.Graphics.DrawLine(myPen, 0, 921, 560, 921)
            e.Graphics.DrawLine(myPen, 0, 933, 560, 933)
            e.Graphics.DrawLine(myPen, 0, 945, 560, 945)
            e.Graphics.DrawLine(myPen, 0, 957, 560, 957)
            e.Graphics.DrawLine(myPen, 0, 969, 560, 969)
            e.Graphics.DrawLine(myPen, 0, 981, 560, 981)
            e.Graphics.DrawLine(myPen, 0, 993, 560, 993)
            e.Graphics.DrawLine(myPen, 0, 1005, 560, 1005)
            e.Graphics.DrawLine(myPen, 0, 1017, 560, 1017)
            e.Graphics.DrawLine(myPen, 0, 1029, 560, 1029)
            e.Graphics.DrawLine(myPen, 0, 1041, 560, 1041)
            e.Graphics.DrawLine(myPen, 0, 1053, 560, 1053)
            e.Graphics.DrawLine(myPen, 0, 1065, 560, 1065)
            e.Graphics.DrawLine(myPen, 0, 1077, 560, 1077)
            e.Graphics.DrawLine(myPen, 0, 1089, 560, 1089)
            e.Graphics.DrawLine(myPen, 0, 1101, 560, 1101)
            e.Graphics.DrawLine(myPen, 0, 1113, 560, 1113)
            e.Graphics.DrawLine(myPen, 0, 1125, 560, 1125)
            e.Graphics.DrawLine(myPen, 0, 1137, 560, 1137)
            e.Graphics.DrawLine(myPen, 0, 1149, 560, 1149)
            e.Graphics.DrawLine(myPen, 0, 1161, 560, 1161)
            e.Graphics.DrawLine(myPen, 0, 1173, 560, 1173)
            e.Graphics.DrawLine(myPen, 0, 1185, 560, 1185)
            e.Graphics.DrawLine(myPen, 0, 1197, 560, 1197)
            e.Graphics.DrawLine(myPen, 0, 1209, 560, 1209)
            e.Graphics.DrawLine(myPen, 0, 1221, 560, 1221)
            e.Graphics.DrawLine(myPen, 0, 1233, 560, 1233)
            e.Graphics.DrawLine(myPen, 0, 1245, 560, 1245)
            e.Graphics.DrawLine(myPen, 0, 1257, 560, 1257)
            e.Graphics.DrawLine(myPen, 0, 1269, 560, 1269)

            e.Graphics.DrawLine(myPen, 0, 1281, 560, 1281)
            e.Graphics.DrawLine(myPen, 0, 1293, 560, 1293)
            e.Graphics.DrawLine(myPen, 0, 1305, 560, 1305)
            e.Graphics.DrawLine(myPen, 0, 1317, 560, 1317)
            e.Graphics.DrawLine(myPen, 0, 1329, 560, 1329)
            e.Graphics.DrawLine(myPen, 0, 1341, 560, 1341)



            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 0, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 100, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 135, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 190, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 290, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 325, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 380, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 480, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 515, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 570, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 670, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 705, 6)


            If DataGridView1.Rows.Count > 180 Then

                While i < 110

                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 0, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(6, i).Value, prFont1, Brushes.Black, 110, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 140, i * 12 + 20)
                    i += 1


                End While


                While i < 220
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 190, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(6, i).Value, prFont1, Brushes.Black, 300, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 330, i * 12 - 1300)
                    i += 1


                End While

                While i < 330
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 380, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(6, i).Value, prFont1, Brushes.Black, 490, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 520, i * 12 - 2620)
                    i += 1


                End While

                While i < DataGridView1.Rows.Count
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 570, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(6, i).Value, prFont1, Brushes.Black, 680, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 710, i * 12 - 3940)
                    i += 1


                End While


            End If

        End If






        If TextBox1.Text = "Alfredo" Then



            Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
            PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            e.Graphics.DrawImage(bm, 600, 1050)
            Dim i As Integer = 0
            Dim i1 As Integer = 0
            Dim i11 As Integer = 0
            Dim line As String = Nothing
            Dim myPen = New Pen(Color.Black, 1)
            Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
            Dim prFont2 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
            Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
            Dim prFont9 As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
            Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
            e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 600, 1120) '65
            e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 610, 1130) '75
            e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 600, 1145) '90
            e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 600, 1160) '105
            e.Graphics.DrawString(DateTimePicker2.Value, prFont2, Brushes.Black, 650, 1160) '105
            e.Graphics.DrawString("HOJA DE CHOFER DE SISTEMA.", prFont2, Brushes.Black, 600, 1185) '130
            e.Graphics.DrawString("Sucursal:", prFont2, Brushes.Black, 600, 1200) '145
            e.Graphics.DrawString(TextBox1.Text, prFont9, Brushes.Black, 660, 1200) '145
            e.Graphics.DrawString("Chofer:", prFont2, Brushes.Black, 600, 1220)
            'e.Graphics.DrawString(TextBox156.Text, prFont9, Brushes.Black, 660, 1220)
            ' e.Graphics.DrawString("ANOTACIONES:", prFont9, Brushes.Black, 600, 185)

            Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows
                If linea.Cells(1).Value = "Concha blanca int." Then
                    linea.Cells(1).Value = "Concha bca. int."
                End If
                If linea.Cells(1).Value = "Minirosquita Janeth" Then
                    linea.Cells(1).Value = "Rosquita Janeth"
                End If
                If linea.Cells(1).Value = "Cuerno mantequilla" Then
                    linea.Cells(1).Value = "Cuerno mante"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria" Then
                    linea.Cells(1).Value = "Panqué de zana"
                End If
                If linea.Cells(1).Value = "Gel. Dominó especial" Then
                    linea.Cells(1).Value = "Gel. Dom. esp."
                End If
                If linea.Cells(1).Value = "Gel. Rompope fruta" Then
                    linea.Cells(1).Value = "Gel. Rompope"
                End If
                If linea.Cells(1).Value = "Leche deslactosada 1l" Then
                    linea.Cells(1).Value = "L. deslac. 1l"
                End If
                If linea.Cells(1).Value = "Pay queso chocolate" Then
                    linea.Cells(1).Value = "P. queso choco"
                End If
                If linea.Cells(1).Value = "Feliz Cumple con base" Then
                    linea.Cells(1).Value = "F.C. base"
                End If
                If linea.Cells(1).Value = "Caja Galletas .250 Kg" Then
                    linea.Cells(1).Value = "C. Galle. .250"
                End If
                If linea.Cells(1).Value = "Panqué de chocolate" Then
                    linea.Cells(1).Value = "Panqué de choco"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria barra" Then
                    linea.Cells(1).Value = "P. zana barra"
                End If
                If linea.Cells(1).Value = "Panqué de chabacano" Then
                    linea.Cells(1).Value = "Panqué chaba"
                End If
                If linea.Cells(1).Value = "Bolsa cafe ame 500gr" Then
                    linea.Cells(1).Value = "B. café a. 500"
                End If
                If linea.Cells(1).Value = "Bolsa cafe des 500gr" Then
                    linea.Cells(1).Value = "B. café d. 500gr"
                End If
                If linea.Cells(1).Value = "Gel. Med. Bombón" Then
                    linea.Cells(1).Value = "G.M. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó" Then
                    linea.Cells(1).Value = "G.M. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó esp." Then
                    linea.Cells(1).Value = "G.M. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Med. Betabel" Then
                    linea.Cells(1).Value = "G.M. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Med. Queso uva" Then
                    linea.Cells(1).Value = "G.M. Queso u"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tricolor" Then
                    linea.Cells(1).Value = "G.M. Tricolor"
                End If
                If linea.Cells(1).Value = "Caja Galletas .5 Kg" Then
                    linea.Cells(1).Value = "C. Galle .5"
                End If
                If linea.Cells(1).Value = "Gel. Med. Agua fruta" Then
                    linea.Cells(1).Value = "G.M. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Med. Rompope" Then
                    linea.Cells(1).Value = "G.M. Romp."
                End If
                If linea.Cells(1).Value = "Panqué elote barra" Then
                    linea.Cells(1).Value = "P. elote barra"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tuti fruti" Then
                    linea.Cells(1).Value = "G.M. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Med. Zanahoria" Then
                    linea.Cells(1).Value = "G.M. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Flores Arándanos" Then
                    linea.Cells(1).Value = "G. Flores A."
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 leches" Then
                    linea.Cells(1).Value = "G.M. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Agua fruta" Then
                    linea.Cells(1).Value = "G.G. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó esp." Then
                    linea.Cells(1).Value = "G.G. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Betabel" Then
                    linea.Cells(1).Value = "G.G. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Tuti fruti" Then
                    linea.Cells(1).Value = "G.G. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Rompope" Then
                    linea.Cells(1).Value = "G.G. Rompope"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 leches" Then
                    linea.Cells(1).Value = "G.G. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Zanahoria" Then
                    linea.Cells(1).Value = "G.G. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 chocolates" Then
                    linea.Cells(1).Value = "G.G. 3 choco"
                End If
                If linea.Cells(1).Value = "Caja Galletas 1 Kg" Then
                    linea.Cells(1).Value = "C. Galle 1"
                End If
                If linea.Cells(1).Value = "Pay queso zarza G." Then
                    linea.Cells(1).Value = "Pay q.zarza G."
                End If
                If linea.Cells(1).Value = "Gel. Vino tinto 22 cm" Then
                    linea.Cells(1).Value = "Gel. vino 22cm"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó" Then
                    linea.Cells(1).Value = "G.G. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Bombón" Then
                    linea.Cells(1).Value = "G.G. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 chocolates" Then
                    linea.Cells(1).Value = "G.M. 3 choco"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Queso uva" Then
                    linea.Cells(1).Value = "G.G. Queso u"
                End If
                If linea.Cells(1).Value = "Pay queso frutas G." Then
                    linea.Cells(1).Value = "Pay q.frutas G."
                End If
                If linea.Cells(1).Value = "Pay queso fresa G." Then
                    linea.Cells(1).Value = "Pay q.fresa G."
                End If
            Next


            'dibujar linea
            e.Graphics.DrawLine(myPen, 0, 21, 770, 21) '+12
            e.Graphics.DrawLine(myPen, 0, 33, 770, 33)
            e.Graphics.DrawLine(myPen, 0, 45, 770, 45)
            e.Graphics.DrawLine(myPen, 0, 57, 770, 57)
            e.Graphics.DrawLine(myPen, 0, 69, 770, 69)
            e.Graphics.DrawLine(myPen, 0, 81, 770, 81)
            e.Graphics.DrawLine(myPen, 0, 93, 770, 93)
            e.Graphics.DrawLine(myPen, 0, 105, 770, 105)
            e.Graphics.DrawLine(myPen, 0, 117, 770, 117)
            e.Graphics.DrawLine(myPen, 0, 129, 770, 129)
            e.Graphics.DrawLine(myPen, 0, 141, 770, 141)
            e.Graphics.DrawLine(myPen, 0, 153, 770, 153)
            e.Graphics.DrawLine(myPen, 0, 165, 770, 165)
            e.Graphics.DrawLine(myPen, 0, 177, 770, 177)
            e.Graphics.DrawLine(myPen, 0, 189, 770, 189)
            e.Graphics.DrawLine(myPen, 0, 201, 770, 201)
            e.Graphics.DrawLine(myPen, 0, 213, 770, 213)
            e.Graphics.DrawLine(myPen, 0, 225, 770, 225)
            e.Graphics.DrawLine(myPen, 0, 237, 770, 237)
            e.Graphics.DrawLine(myPen, 0, 249, 770, 249)
            e.Graphics.DrawLine(myPen, 0, 261, 770, 261)
            e.Graphics.DrawLine(myPen, 0, 273, 770, 273)
            e.Graphics.DrawLine(myPen, 0, 285, 770, 285) 'hasta 31
            e.Graphics.DrawLine(myPen, 0, 297, 770, 297)
            e.Graphics.DrawLine(myPen, 0, 309, 770, 309)
            e.Graphics.DrawLine(myPen, 0, 321, 770, 321)
            e.Graphics.DrawLine(myPen, 0, 333, 770, 333)
            e.Graphics.DrawLine(myPen, 0, 345, 770, 345)
            e.Graphics.DrawLine(myPen, 0, 357, 770, 357)
            e.Graphics.DrawLine(myPen, 0, 369, 770, 369)
            e.Graphics.DrawLine(myPen, 0, 381, 770, 381)


            'aqui inician livbres las lineas
            e.Graphics.DrawLine(myPen, 0, 393, 560, 393)
            e.Graphics.DrawLine(myPen, 0, 405, 560, 405)
            e.Graphics.DrawLine(myPen, 0, 417, 560, 417)
            e.Graphics.DrawLine(myPen, 0, 429, 560, 429)
            e.Graphics.DrawLine(myPen, 0, 441, 560, 441)
            e.Graphics.DrawLine(myPen, 0, 453, 560, 453)
            e.Graphics.DrawLine(myPen, 0, 465, 560, 465)
            e.Graphics.DrawLine(myPen, 0, 477, 560, 477)
            e.Graphics.DrawLine(myPen, 0, 489, 560, 489)
            e.Graphics.DrawLine(myPen, 0, 501, 560, 501)
            e.Graphics.DrawLine(myPen, 0, 513, 560, 513)
            e.Graphics.DrawLine(myPen, 0, 525, 560, 525)
            e.Graphics.DrawLine(myPen, 0, 537, 560, 537)
            e.Graphics.DrawLine(myPen, 0, 549, 560, 549)
            e.Graphics.DrawLine(myPen, 0, 561, 560, 561)
            e.Graphics.DrawLine(myPen, 0, 573, 560, 573)
            e.Graphics.DrawLine(myPen, 0, 585, 560, 585)
            e.Graphics.DrawLine(myPen, 0, 597, 560, 597)
            e.Graphics.DrawLine(myPen, 0, 609, 560, 609)
            e.Graphics.DrawLine(myPen, 0, 621, 560, 621)
            e.Graphics.DrawLine(myPen, 0, 633, 560, 633)
            e.Graphics.DrawLine(myPen, 0, 645, 560, 645)
            e.Graphics.DrawLine(myPen, 0, 657, 560, 657)
            e.Graphics.DrawLine(myPen, 0, 669, 560, 669)
            e.Graphics.DrawLine(myPen, 0, 681, 560, 681)
            e.Graphics.DrawLine(myPen, 0, 693, 560, 693)
            e.Graphics.DrawLine(myPen, 0, 705, 560, 705)
            e.Graphics.DrawLine(myPen, 0, 717, 560, 717)
            e.Graphics.DrawLine(myPen, 0, 729, 560, 729)
            e.Graphics.DrawLine(myPen, 0, 741, 560, 741)
            e.Graphics.DrawLine(myPen, 0, 753, 560, 753)
            e.Graphics.DrawLine(myPen, 0, 765, 560, 765)
            e.Graphics.DrawLine(myPen, 0, 777, 560, 777)
            e.Graphics.DrawLine(myPen, 0, 789, 560, 789)
            e.Graphics.DrawLine(myPen, 0, 801, 560, 801)
            e.Graphics.DrawLine(myPen, 0, 813, 560, 813)
            e.Graphics.DrawLine(myPen, 0, 825, 560, 825)
            e.Graphics.DrawLine(myPen, 0, 837, 560, 837)
            e.Graphics.DrawLine(myPen, 0, 849, 560, 849)
            e.Graphics.DrawLine(myPen, 0, 861, 560, 861)
            e.Graphics.DrawLine(myPen, 0, 873, 560, 873)
            e.Graphics.DrawLine(myPen, 0, 885, 560, 885)
            e.Graphics.DrawLine(myPen, 0, 897, 560, 897)
            e.Graphics.DrawLine(myPen, 0, 909, 560, 909)
            e.Graphics.DrawLine(myPen, 0, 921, 560, 921)
            e.Graphics.DrawLine(myPen, 0, 933, 560, 933)
            e.Graphics.DrawLine(myPen, 0, 945, 560, 945)
            e.Graphics.DrawLine(myPen, 0, 957, 560, 957)
            e.Graphics.DrawLine(myPen, 0, 969, 560, 969)
            e.Graphics.DrawLine(myPen, 0, 981, 560, 981)
            e.Graphics.DrawLine(myPen, 0, 993, 560, 993)
            e.Graphics.DrawLine(myPen, 0, 1005, 560, 1005)
            e.Graphics.DrawLine(myPen, 0, 1017, 560, 1017)
            e.Graphics.DrawLine(myPen, 0, 1029, 560, 1029)
            e.Graphics.DrawLine(myPen, 0, 1041, 560, 1041)
            e.Graphics.DrawLine(myPen, 0, 1053, 560, 1053)
            e.Graphics.DrawLine(myPen, 0, 1065, 560, 1065)
            e.Graphics.DrawLine(myPen, 0, 1077, 560, 1077)
            e.Graphics.DrawLine(myPen, 0, 1089, 560, 1089)
            e.Graphics.DrawLine(myPen, 0, 1101, 560, 1101)
            e.Graphics.DrawLine(myPen, 0, 1113, 560, 1113)
            e.Graphics.DrawLine(myPen, 0, 1125, 560, 1125)
            e.Graphics.DrawLine(myPen, 0, 1137, 560, 1137)
            e.Graphics.DrawLine(myPen, 0, 1149, 560, 1149)
            e.Graphics.DrawLine(myPen, 0, 1161, 560, 1161)
            e.Graphics.DrawLine(myPen, 0, 1173, 560, 1173)
            e.Graphics.DrawLine(myPen, 0, 1185, 560, 1185)
            e.Graphics.DrawLine(myPen, 0, 1197, 560, 1197)
            e.Graphics.DrawLine(myPen, 0, 1209, 560, 1209)
            e.Graphics.DrawLine(myPen, 0, 1221, 560, 1221)
            e.Graphics.DrawLine(myPen, 0, 1233, 560, 1233)
            e.Graphics.DrawLine(myPen, 0, 1245, 560, 1245)
            e.Graphics.DrawLine(myPen, 0, 1257, 560, 1257)
            e.Graphics.DrawLine(myPen, 0, 1269, 560, 1269)

            e.Graphics.DrawLine(myPen, 0, 1281, 560, 1281)
            e.Graphics.DrawLine(myPen, 0, 1293, 560, 1293)
            e.Graphics.DrawLine(myPen, 0, 1305, 560, 1305)
            e.Graphics.DrawLine(myPen, 0, 1317, 560, 1317)
            e.Graphics.DrawLine(myPen, 0, 1329, 560, 1329)
            e.Graphics.DrawLine(myPen, 0, 1341, 560, 1341)



            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 0, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 100, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 135, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 190, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 290, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 325, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 380, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 480, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 515, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 570, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 670, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 705, 6)


            If DataGridView1.Rows.Count > 180 Then

                While i < 110

                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 0, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(5, i).Value, prFont1, Brushes.Black, 110, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 140, i * 12 + 20)
                    i += 1


                End While


                While i < 220
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 190, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(5, i).Value, prFont1, Brushes.Black, 300, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 330, i * 12 - 1300)
                    i += 1


                End While

                While i < 330
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 380, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(5, i).Value, prFont1, Brushes.Black, 490, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 520, i * 12 - 2620)
                    i += 1


                End While

                While i < DataGridView1.Rows.Count
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 570, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(5, i).Value, prFont1, Brushes.Black, 680, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 710, i * 12 - 3940)
                    i += 1


                End While


            End If

        End If


        If TextBox1.Text = "Fabela" Then



            Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
            PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            e.Graphics.DrawImage(bm, 600, 1050)
            Dim i As Integer = 0
            Dim i1 As Integer = 0
            Dim i11 As Integer = 0
            Dim line As String = Nothing
            Dim myPen = New Pen(Color.Black, 1)
            Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
            Dim prFont2 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
            Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
            Dim prFont9 As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
            Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
            e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 600, 1120) '65
            e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 610, 1130) '75
            e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 600, 1145) '90
            e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 600, 1160) '105
            e.Graphics.DrawString(DateTimePicker2.Value, prFont2, Brushes.Black, 650, 1160) '105
            e.Graphics.DrawString("HOJA DE CHOFER DE SISTEMA.", prFont2, Brushes.Black, 600, 1185) '130
            e.Graphics.DrawString("Sucursal:", prFont2, Brushes.Black, 600, 1200) '145
            e.Graphics.DrawString(TextBox1.Text, prFont9, Brushes.Black, 660, 1200) '145
            e.Graphics.DrawString("Chofer:", prFont2, Brushes.Black, 600, 1220)
            ' e.Graphics.DrawString(TextBox156.Text, prFont9, Brushes.Black, 660, 1220)
            ' e.Graphics.DrawString("ANOTACIONES:", prFont9, Brushes.Black, 600, 185)

            Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows
                If linea.Cells(1).Value = "Concha blanca int." Then
                    linea.Cells(1).Value = "Concha bca. int."
                End If
                If linea.Cells(1).Value = "Minirosquita Janeth" Then
                    linea.Cells(1).Value = "Rosquita Janeth"
                End If
                If linea.Cells(1).Value = "Cuerno mantequilla" Then
                    linea.Cells(1).Value = "Cuerno mante"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria" Then
                    linea.Cells(1).Value = "Panqué de zana"
                End If
                If linea.Cells(1).Value = "Gel. Dominó especial" Then
                    linea.Cells(1).Value = "Gel. Dom. esp."
                End If
                If linea.Cells(1).Value = "Gel. Rompope fruta" Then
                    linea.Cells(1).Value = "Gel. Rompope"
                End If
                If linea.Cells(1).Value = "Leche deslactosada 1l" Then
                    linea.Cells(1).Value = "L. deslac. 1l"
                End If
                If linea.Cells(1).Value = "Pay queso chocolate" Then
                    linea.Cells(1).Value = "P. queso choco"
                End If
                If linea.Cells(1).Value = "Feliz Cumple con base" Then
                    linea.Cells(1).Value = "F.C. base"
                End If
                If linea.Cells(1).Value = "Caja Galletas .250 Kg" Then
                    linea.Cells(1).Value = "C. Galle. .250"
                End If
                If linea.Cells(1).Value = "Panqué de chocolate" Then
                    linea.Cells(1).Value = "Panqué de choco"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria barra" Then
                    linea.Cells(1).Value = "P. zana barra"
                End If
                If linea.Cells(1).Value = "Panqué de chabacano" Then
                    linea.Cells(1).Value = "Panqué chaba"
                End If
                If linea.Cells(1).Value = "Bolsa cafe ame 500gr" Then
                    linea.Cells(1).Value = "B. café a. 500"
                End If
                If linea.Cells(1).Value = "Bolsa cafe des 500gr" Then
                    linea.Cells(1).Value = "B. café d. 500gr"
                End If
                If linea.Cells(1).Value = "Gel. Med. Bombón" Then
                    linea.Cells(1).Value = "G.M. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó" Then
                    linea.Cells(1).Value = "G.M. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó esp." Then
                    linea.Cells(1).Value = "G.M. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Med. Betabel" Then
                    linea.Cells(1).Value = "G.M. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Med. Queso uva" Then
                    linea.Cells(1).Value = "G.M. Queso u"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tricolor" Then
                    linea.Cells(1).Value = "G.M. Tricolor"
                End If
                If linea.Cells(1).Value = "Caja Galletas .5 Kg" Then
                    linea.Cells(1).Value = "C. Galle .5"
                End If
                If linea.Cells(1).Value = "Gel. Med. Agua fruta" Then
                    linea.Cells(1).Value = "G.M. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Med. Rompope" Then
                    linea.Cells(1).Value = "G.M. Romp."
                End If
                If linea.Cells(1).Value = "Panqué elote barra" Then
                    linea.Cells(1).Value = "P. elote barra"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tuti fruti" Then
                    linea.Cells(1).Value = "G.M. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Med. Zanahoria" Then
                    linea.Cells(1).Value = "G.M. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Flores Arándanos" Then
                    linea.Cells(1).Value = "G. Flores A."
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 leches" Then
                    linea.Cells(1).Value = "G.M. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Agua fruta" Then
                    linea.Cells(1).Value = "G.G. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó esp." Then
                    linea.Cells(1).Value = "G.G. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Betabel" Then
                    linea.Cells(1).Value = "G.G. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Tuti fruti" Then
                    linea.Cells(1).Value = "G.G. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Rompope" Then
                    linea.Cells(1).Value = "G.G. Rompope"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 leches" Then
                    linea.Cells(1).Value = "G.G. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Zanahoria" Then
                    linea.Cells(1).Value = "G.G. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 chocolates" Then
                    linea.Cells(1).Value = "G.G. 3 choco"
                End If
                If linea.Cells(1).Value = "Caja Galletas 1 Kg" Then
                    linea.Cells(1).Value = "C. Galle 1"
                End If
                If linea.Cells(1).Value = "Pay queso zarza G." Then
                    linea.Cells(1).Value = "Pay q.zarza G."
                End If
                If linea.Cells(1).Value = "Gel. Vino tinto 22 cm" Then
                    linea.Cells(1).Value = "Gel. vino 22cm"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó" Then
                    linea.Cells(1).Value = "G.G. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Bombón" Then
                    linea.Cells(1).Value = "G.G. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 chocolates" Then
                    linea.Cells(1).Value = "G.M. 3 choco"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Queso uva" Then
                    linea.Cells(1).Value = "G.G. Queso u"
                End If
                If linea.Cells(1).Value = "Pay queso frutas G." Then
                    linea.Cells(1).Value = "Pay q.frutas G."
                End If
                If linea.Cells(1).Value = "Pay queso fresa G." Then
                    linea.Cells(1).Value = "Pay q.fresa G."
                End If
            Next


            'dibujar linea
            e.Graphics.DrawLine(myPen, 0, 21, 770, 21) '+12
            e.Graphics.DrawLine(myPen, 0, 33, 770, 33)
            e.Graphics.DrawLine(myPen, 0, 45, 770, 45)
            e.Graphics.DrawLine(myPen, 0, 57, 770, 57)
            e.Graphics.DrawLine(myPen, 0, 69, 770, 69)
            e.Graphics.DrawLine(myPen, 0, 81, 770, 81)
            e.Graphics.DrawLine(myPen, 0, 93, 770, 93)
            e.Graphics.DrawLine(myPen, 0, 105, 770, 105)
            e.Graphics.DrawLine(myPen, 0, 117, 770, 117)
            e.Graphics.DrawLine(myPen, 0, 129, 770, 129)
            e.Graphics.DrawLine(myPen, 0, 141, 770, 141)
            e.Graphics.DrawLine(myPen, 0, 153, 770, 153)
            e.Graphics.DrawLine(myPen, 0, 165, 770, 165)
            e.Graphics.DrawLine(myPen, 0, 177, 770, 177)
            e.Graphics.DrawLine(myPen, 0, 189, 770, 189)
            e.Graphics.DrawLine(myPen, 0, 201, 770, 201)
            e.Graphics.DrawLine(myPen, 0, 213, 770, 213)
            e.Graphics.DrawLine(myPen, 0, 225, 770, 225)
            e.Graphics.DrawLine(myPen, 0, 237, 770, 237)
            e.Graphics.DrawLine(myPen, 0, 249, 770, 249)
            e.Graphics.DrawLine(myPen, 0, 261, 770, 261)
            e.Graphics.DrawLine(myPen, 0, 273, 770, 273)
            e.Graphics.DrawLine(myPen, 0, 285, 770, 285) 'hasta 31
            e.Graphics.DrawLine(myPen, 0, 297, 770, 297)
            e.Graphics.DrawLine(myPen, 0, 309, 770, 309)
            e.Graphics.DrawLine(myPen, 0, 321, 770, 321)
            e.Graphics.DrawLine(myPen, 0, 333, 770, 333)
            e.Graphics.DrawLine(myPen, 0, 345, 770, 345)
            e.Graphics.DrawLine(myPen, 0, 357, 770, 357)
            e.Graphics.DrawLine(myPen, 0, 369, 770, 369)
            e.Graphics.DrawLine(myPen, 0, 381, 770, 381)


            'aqui inician livbres las lineas
            e.Graphics.DrawLine(myPen, 0, 393, 560, 393)
            e.Graphics.DrawLine(myPen, 0, 405, 560, 405)
            e.Graphics.DrawLine(myPen, 0, 417, 560, 417)
            e.Graphics.DrawLine(myPen, 0, 429, 560, 429)
            e.Graphics.DrawLine(myPen, 0, 441, 560, 441)
            e.Graphics.DrawLine(myPen, 0, 453, 560, 453)
            e.Graphics.DrawLine(myPen, 0, 465, 560, 465)
            e.Graphics.DrawLine(myPen, 0, 477, 560, 477)
            e.Graphics.DrawLine(myPen, 0, 489, 560, 489)
            e.Graphics.DrawLine(myPen, 0, 501, 560, 501)
            e.Graphics.DrawLine(myPen, 0, 513, 560, 513)
            e.Graphics.DrawLine(myPen, 0, 525, 560, 525)
            e.Graphics.DrawLine(myPen, 0, 537, 560, 537)
            e.Graphics.DrawLine(myPen, 0, 549, 560, 549)
            e.Graphics.DrawLine(myPen, 0, 561, 560, 561)
            e.Graphics.DrawLine(myPen, 0, 573, 560, 573)
            e.Graphics.DrawLine(myPen, 0, 585, 560, 585)
            e.Graphics.DrawLine(myPen, 0, 597, 560, 597)
            e.Graphics.DrawLine(myPen, 0, 609, 560, 609)
            e.Graphics.DrawLine(myPen, 0, 621, 560, 621)
            e.Graphics.DrawLine(myPen, 0, 633, 560, 633)
            e.Graphics.DrawLine(myPen, 0, 645, 560, 645)
            e.Graphics.DrawLine(myPen, 0, 657, 560, 657)
            e.Graphics.DrawLine(myPen, 0, 669, 560, 669)
            e.Graphics.DrawLine(myPen, 0, 681, 560, 681)
            e.Graphics.DrawLine(myPen, 0, 693, 560, 693)
            e.Graphics.DrawLine(myPen, 0, 705, 560, 705)
            e.Graphics.DrawLine(myPen, 0, 717, 560, 717)
            e.Graphics.DrawLine(myPen, 0, 729, 560, 729)
            e.Graphics.DrawLine(myPen, 0, 741, 560, 741)
            e.Graphics.DrawLine(myPen, 0, 753, 560, 753)
            e.Graphics.DrawLine(myPen, 0, 765, 560, 765)
            e.Graphics.DrawLine(myPen, 0, 777, 560, 777)
            e.Graphics.DrawLine(myPen, 0, 789, 560, 789)
            e.Graphics.DrawLine(myPen, 0, 801, 560, 801)
            e.Graphics.DrawLine(myPen, 0, 813, 560, 813)
            e.Graphics.DrawLine(myPen, 0, 825, 560, 825)
            e.Graphics.DrawLine(myPen, 0, 837, 560, 837)
            e.Graphics.DrawLine(myPen, 0, 849, 560, 849)
            e.Graphics.DrawLine(myPen, 0, 861, 560, 861)
            e.Graphics.DrawLine(myPen, 0, 873, 560, 873)
            e.Graphics.DrawLine(myPen, 0, 885, 560, 885)
            e.Graphics.DrawLine(myPen, 0, 897, 560, 897)
            e.Graphics.DrawLine(myPen, 0, 909, 560, 909)
            e.Graphics.DrawLine(myPen, 0, 921, 560, 921)
            e.Graphics.DrawLine(myPen, 0, 933, 560, 933)
            e.Graphics.DrawLine(myPen, 0, 945, 560, 945)
            e.Graphics.DrawLine(myPen, 0, 957, 560, 957)
            e.Graphics.DrawLine(myPen, 0, 969, 560, 969)
            e.Graphics.DrawLine(myPen, 0, 981, 560, 981)
            e.Graphics.DrawLine(myPen, 0, 993, 560, 993)
            e.Graphics.DrawLine(myPen, 0, 1005, 560, 1005)
            e.Graphics.DrawLine(myPen, 0, 1017, 560, 1017)
            e.Graphics.DrawLine(myPen, 0, 1029, 560, 1029)
            e.Graphics.DrawLine(myPen, 0, 1041, 560, 1041)
            e.Graphics.DrawLine(myPen, 0, 1053, 560, 1053)
            e.Graphics.DrawLine(myPen, 0, 1065, 560, 1065)
            e.Graphics.DrawLine(myPen, 0, 1077, 560, 1077)
            e.Graphics.DrawLine(myPen, 0, 1089, 560, 1089)
            e.Graphics.DrawLine(myPen, 0, 1101, 560, 1101)
            e.Graphics.DrawLine(myPen, 0, 1113, 560, 1113)
            e.Graphics.DrawLine(myPen, 0, 1125, 560, 1125)
            e.Graphics.DrawLine(myPen, 0, 1137, 560, 1137)
            e.Graphics.DrawLine(myPen, 0, 1149, 560, 1149)
            e.Graphics.DrawLine(myPen, 0, 1161, 560, 1161)
            e.Graphics.DrawLine(myPen, 0, 1173, 560, 1173)
            e.Graphics.DrawLine(myPen, 0, 1185, 560, 1185)
            e.Graphics.DrawLine(myPen, 0, 1197, 560, 1197)
            e.Graphics.DrawLine(myPen, 0, 1209, 560, 1209)
            e.Graphics.DrawLine(myPen, 0, 1221, 560, 1221)
            e.Graphics.DrawLine(myPen, 0, 1233, 560, 1233)
            e.Graphics.DrawLine(myPen, 0, 1245, 560, 1245)
            e.Graphics.DrawLine(myPen, 0, 1257, 560, 1257)
            e.Graphics.DrawLine(myPen, 0, 1269, 560, 1269)

            e.Graphics.DrawLine(myPen, 0, 1281, 560, 1281)
            e.Graphics.DrawLine(myPen, 0, 1293, 560, 1293)
            e.Graphics.DrawLine(myPen, 0, 1305, 560, 1305)
            e.Graphics.DrawLine(myPen, 0, 1317, 560, 1317)
            e.Graphics.DrawLine(myPen, 0, 1329, 560, 1329)
            e.Graphics.DrawLine(myPen, 0, 1341, 560, 1341)



            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 0, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 100, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 135, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 190, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 290, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 325, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 380, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 480, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 515, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 570, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 670, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 705, 6)


            If DataGridView1.Rows.Count > 180 Then

                While i < 110

                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 0, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(17, i).Value, prFont1, Brushes.Black, 110, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 140, i * 12 + 20)
                    i += 1


                End While


                While i < 220
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 190, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(17, i).Value, prFont1, Brushes.Black, 300, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 330, i * 12 - 1300)
                    i += 1


                End While

                While i < 330
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 380, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(17, i).Value, prFont1, Brushes.Black, 490, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 520, i * 12 - 2620)
                    i += 1


                End While

                While i < DataGridView1.Rows.Count
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 570, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(17, i).Value, prFont1, Brushes.Black, 680, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 710, i * 12 - 3940)
                    i += 1


                End While


            End If





        End If



        If TextBox1.Text = "Toto" Then



            Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
            PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            e.Graphics.DrawImage(bm, 600, 1050)
            Dim i As Integer = 0
            Dim i1 As Integer = 0
            Dim i11 As Integer = 0
            Dim line As String = Nothing
            Dim myPen = New Pen(Color.Black, 1)
            Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
            Dim prFont2 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
            Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
            Dim prFont9 As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
            Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
            e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 600, 1120) '65
            e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 610, 1130) '75
            e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 600, 1145) '90
            e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 600, 1160) '105
            e.Graphics.DrawString(DateTimePicker2.Value, prFont2, Brushes.Black, 650, 1160) '105
            e.Graphics.DrawString("HOJA DE CHOFER DE SISTEMA.", prFont2, Brushes.Black, 600, 1185) '130
            e.Graphics.DrawString("Sucursal:", prFont2, Brushes.Black, 600, 1200) '145
            e.Graphics.DrawString(TextBox1.Text, prFont9, Brushes.Black, 660, 1200) '145
            e.Graphics.DrawString("Chofer:", prFont2, Brushes.Black, 600, 1220)
            'e.Graphics.DrawString(TextBox156.Text, prFont9, Brushes.Black, 660, 1220)
            ' e.Graphics.DrawString("ANOTACIONES:", prFont9, Brushes.Black, 600, 185)

            Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows
                If linea.Cells(1).Value = "Concha blanca int." Then
                    linea.Cells(1).Value = "Concha bca. int."
                End If
                If linea.Cells(1).Value = "Minirosquita Janeth" Then
                    linea.Cells(1).Value = "Rosquita Janeth"
                End If
                If linea.Cells(1).Value = "Cuerno mantequilla" Then
                    linea.Cells(1).Value = "Cuerno mante"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria" Then
                    linea.Cells(1).Value = "Panqué de zana"
                End If
                If linea.Cells(1).Value = "Gel. Dominó especial" Then
                    linea.Cells(1).Value = "Gel. Dom. esp."
                End If
                If linea.Cells(1).Value = "Gel. Rompope fruta" Then
                    linea.Cells(1).Value = "Gel. Rompope"
                End If
                If linea.Cells(1).Value = "Leche deslactosada 1l" Then
                    linea.Cells(1).Value = "L. deslac. 1l"
                End If
                If linea.Cells(1).Value = "Pay queso chocolate" Then
                    linea.Cells(1).Value = "P. queso choco"
                End If
                If linea.Cells(1).Value = "Feliz Cumple con base" Then
                    linea.Cells(1).Value = "F.C. base"
                End If
                If linea.Cells(1).Value = "Caja Galletas .250 Kg" Then
                    linea.Cells(1).Value = "C. Galle. .250"
                End If
                If linea.Cells(1).Value = "Panqué de chocolate" Then
                    linea.Cells(1).Value = "Panqué de choco"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria barra" Then
                    linea.Cells(1).Value = "P. zana barra"
                End If
                If linea.Cells(1).Value = "Panqué de chabacano" Then
                    linea.Cells(1).Value = "Panqué chaba"
                End If
                If linea.Cells(1).Value = "Bolsa cafe ame 500gr" Then
                    linea.Cells(1).Value = "B. café a. 500"
                End If
                If linea.Cells(1).Value = "Bolsa cafe des 500gr" Then
                    linea.Cells(1).Value = "B. café d. 500gr"
                End If
                If linea.Cells(1).Value = "Gel. Med. Bombón" Then
                    linea.Cells(1).Value = "G.M. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó" Then
                    linea.Cells(1).Value = "G.M. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó esp." Then
                    linea.Cells(1).Value = "G.M. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Med. Betabel" Then
                    linea.Cells(1).Value = "G.M. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Med. Queso uva" Then
                    linea.Cells(1).Value = "G.M. Queso u"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tricolor" Then
                    linea.Cells(1).Value = "G.M. Tricolor"
                End If
                If linea.Cells(1).Value = "Caja Galletas .5 Kg" Then
                    linea.Cells(1).Value = "C. Galle .5"
                End If
                If linea.Cells(1).Value = "Gel. Med. Agua fruta" Then
                    linea.Cells(1).Value = "G.M. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Med. Rompope" Then
                    linea.Cells(1).Value = "G.M. Romp."
                End If
                If linea.Cells(1).Value = "Panqué elote barra" Then
                    linea.Cells(1).Value = "P. elote barra"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tuti fruti" Then
                    linea.Cells(1).Value = "G.M. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Med. Zanahoria" Then
                    linea.Cells(1).Value = "G.M. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Flores Arándanos" Then
                    linea.Cells(1).Value = "G. Flores A."
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 leches" Then
                    linea.Cells(1).Value = "G.M. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Agua fruta" Then
                    linea.Cells(1).Value = "G.G. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó esp." Then
                    linea.Cells(1).Value = "G.G. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Betabel" Then
                    linea.Cells(1).Value = "G.G. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Tuti fruti" Then
                    linea.Cells(1).Value = "G.G. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Rompope" Then
                    linea.Cells(1).Value = "G.G. Rompope"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 leches" Then
                    linea.Cells(1).Value = "G.G. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Zanahoria" Then
                    linea.Cells(1).Value = "G.G. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 chocolates" Then
                    linea.Cells(1).Value = "G.G. 3 choco"
                End If
                If linea.Cells(1).Value = "Caja Galletas 1 Kg" Then
                    linea.Cells(1).Value = "C. Galle 1"
                End If
                If linea.Cells(1).Value = "Pay queso zarza G." Then
                    linea.Cells(1).Value = "Pay q.zarza G."
                End If
                If linea.Cells(1).Value = "Gel. Vino tinto 22 cm" Then
                    linea.Cells(1).Value = "Gel. vino 22cm"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó" Then
                    linea.Cells(1).Value = "G.G. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Bombón" Then
                    linea.Cells(1).Value = "G.G. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 chocolates" Then
                    linea.Cells(1).Value = "G.M. 3 choco"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Queso uva" Then
                    linea.Cells(1).Value = "G.G. Queso u"
                End If
                If linea.Cells(1).Value = "Pay queso frutas G." Then
                    linea.Cells(1).Value = "Pay q.frutas G."
                End If
                If linea.Cells(1).Value = "Pay queso fresa G." Then
                    linea.Cells(1).Value = "Pay q.fresa G."
                End If
            Next


            'dibujar linea
            e.Graphics.DrawLine(myPen, 0, 21, 770, 21) '+12
            e.Graphics.DrawLine(myPen, 0, 33, 770, 33)
            e.Graphics.DrawLine(myPen, 0, 45, 770, 45)
            e.Graphics.DrawLine(myPen, 0, 57, 770, 57)
            e.Graphics.DrawLine(myPen, 0, 69, 770, 69)
            e.Graphics.DrawLine(myPen, 0, 81, 770, 81)
            e.Graphics.DrawLine(myPen, 0, 93, 770, 93)
            e.Graphics.DrawLine(myPen, 0, 105, 770, 105)
            e.Graphics.DrawLine(myPen, 0, 117, 770, 117)
            e.Graphics.DrawLine(myPen, 0, 129, 770, 129)
            e.Graphics.DrawLine(myPen, 0, 141, 770, 141)
            e.Graphics.DrawLine(myPen, 0, 153, 770, 153)
            e.Graphics.DrawLine(myPen, 0, 165, 770, 165)
            e.Graphics.DrawLine(myPen, 0, 177, 770, 177)
            e.Graphics.DrawLine(myPen, 0, 189, 770, 189)
            e.Graphics.DrawLine(myPen, 0, 201, 770, 201)
            e.Graphics.DrawLine(myPen, 0, 213, 770, 213)
            e.Graphics.DrawLine(myPen, 0, 225, 770, 225)
            e.Graphics.DrawLine(myPen, 0, 237, 770, 237)
            e.Graphics.DrawLine(myPen, 0, 249, 770, 249)
            e.Graphics.DrawLine(myPen, 0, 261, 770, 261)
            e.Graphics.DrawLine(myPen, 0, 273, 770, 273)
            e.Graphics.DrawLine(myPen, 0, 285, 770, 285) 'hasta 31
            e.Graphics.DrawLine(myPen, 0, 297, 770, 297)
            e.Graphics.DrawLine(myPen, 0, 309, 770, 309)
            e.Graphics.DrawLine(myPen, 0, 321, 770, 321)
            e.Graphics.DrawLine(myPen, 0, 333, 770, 333)
            e.Graphics.DrawLine(myPen, 0, 345, 770, 345)
            e.Graphics.DrawLine(myPen, 0, 357, 770, 357)
            e.Graphics.DrawLine(myPen, 0, 369, 770, 369)
            e.Graphics.DrawLine(myPen, 0, 381, 770, 381)


            'aqui inician livbres las lineas
            e.Graphics.DrawLine(myPen, 0, 393, 560, 393)
            e.Graphics.DrawLine(myPen, 0, 405, 560, 405)
            e.Graphics.DrawLine(myPen, 0, 417, 560, 417)
            e.Graphics.DrawLine(myPen, 0, 429, 560, 429)
            e.Graphics.DrawLine(myPen, 0, 441, 560, 441)
            e.Graphics.DrawLine(myPen, 0, 453, 560, 453)
            e.Graphics.DrawLine(myPen, 0, 465, 560, 465)
            e.Graphics.DrawLine(myPen, 0, 477, 560, 477)
            e.Graphics.DrawLine(myPen, 0, 489, 560, 489)
            e.Graphics.DrawLine(myPen, 0, 501, 560, 501)
            e.Graphics.DrawLine(myPen, 0, 513, 560, 513)
            e.Graphics.DrawLine(myPen, 0, 525, 560, 525)
            e.Graphics.DrawLine(myPen, 0, 537, 560, 537)
            e.Graphics.DrawLine(myPen, 0, 549, 560, 549)
            e.Graphics.DrawLine(myPen, 0, 561, 560, 561)
            e.Graphics.DrawLine(myPen, 0, 573, 560, 573)
            e.Graphics.DrawLine(myPen, 0, 585, 560, 585)
            e.Graphics.DrawLine(myPen, 0, 597, 560, 597)
            e.Graphics.DrawLine(myPen, 0, 609, 560, 609)
            e.Graphics.DrawLine(myPen, 0, 621, 560, 621)
            e.Graphics.DrawLine(myPen, 0, 633, 560, 633)
            e.Graphics.DrawLine(myPen, 0, 645, 560, 645)
            e.Graphics.DrawLine(myPen, 0, 657, 560, 657)
            e.Graphics.DrawLine(myPen, 0, 669, 560, 669)
            e.Graphics.DrawLine(myPen, 0, 681, 560, 681)
            e.Graphics.DrawLine(myPen, 0, 693, 560, 693)
            e.Graphics.DrawLine(myPen, 0, 705, 560, 705)
            e.Graphics.DrawLine(myPen, 0, 717, 560, 717)
            e.Graphics.DrawLine(myPen, 0, 729, 560, 729)
            e.Graphics.DrawLine(myPen, 0, 741, 560, 741)
            e.Graphics.DrawLine(myPen, 0, 753, 560, 753)
            e.Graphics.DrawLine(myPen, 0, 765, 560, 765)
            e.Graphics.DrawLine(myPen, 0, 777, 560, 777)
            e.Graphics.DrawLine(myPen, 0, 789, 560, 789)
            e.Graphics.DrawLine(myPen, 0, 801, 560, 801)
            e.Graphics.DrawLine(myPen, 0, 813, 560, 813)
            e.Graphics.DrawLine(myPen, 0, 825, 560, 825)
            e.Graphics.DrawLine(myPen, 0, 837, 560, 837)
            e.Graphics.DrawLine(myPen, 0, 849, 560, 849)
            e.Graphics.DrawLine(myPen, 0, 861, 560, 861)
            e.Graphics.DrawLine(myPen, 0, 873, 560, 873)
            e.Graphics.DrawLine(myPen, 0, 885, 560, 885)
            e.Graphics.DrawLine(myPen, 0, 897, 560, 897)
            e.Graphics.DrawLine(myPen, 0, 909, 560, 909)
            e.Graphics.DrawLine(myPen, 0, 921, 560, 921)
            e.Graphics.DrawLine(myPen, 0, 933, 560, 933)
            e.Graphics.DrawLine(myPen, 0, 945, 560, 945)
            e.Graphics.DrawLine(myPen, 0, 957, 560, 957)
            e.Graphics.DrawLine(myPen, 0, 969, 560, 969)
            e.Graphics.DrawLine(myPen, 0, 981, 560, 981)
            e.Graphics.DrawLine(myPen, 0, 993, 560, 993)
            e.Graphics.DrawLine(myPen, 0, 1005, 560, 1005)
            e.Graphics.DrawLine(myPen, 0, 1017, 560, 1017)
            e.Graphics.DrawLine(myPen, 0, 1029, 560, 1029)
            e.Graphics.DrawLine(myPen, 0, 1041, 560, 1041)
            e.Graphics.DrawLine(myPen, 0, 1053, 560, 1053)
            e.Graphics.DrawLine(myPen, 0, 1065, 560, 1065)
            e.Graphics.DrawLine(myPen, 0, 1077, 560, 1077)
            e.Graphics.DrawLine(myPen, 0, 1089, 560, 1089)
            e.Graphics.DrawLine(myPen, 0, 1101, 560, 1101)
            e.Graphics.DrawLine(myPen, 0, 1113, 560, 1113)
            e.Graphics.DrawLine(myPen, 0, 1125, 560, 1125)
            e.Graphics.DrawLine(myPen, 0, 1137, 560, 1137)
            e.Graphics.DrawLine(myPen, 0, 1149, 560, 1149)
            e.Graphics.DrawLine(myPen, 0, 1161, 560, 1161)
            e.Graphics.DrawLine(myPen, 0, 1173, 560, 1173)
            e.Graphics.DrawLine(myPen, 0, 1185, 560, 1185)
            e.Graphics.DrawLine(myPen, 0, 1197, 560, 1197)
            e.Graphics.DrawLine(myPen, 0, 1209, 560, 1209)
            e.Graphics.DrawLine(myPen, 0, 1221, 560, 1221)
            e.Graphics.DrawLine(myPen, 0, 1233, 560, 1233)
            e.Graphics.DrawLine(myPen, 0, 1245, 560, 1245)
            e.Graphics.DrawLine(myPen, 0, 1257, 560, 1257)
            e.Graphics.DrawLine(myPen, 0, 1269, 560, 1269)

            e.Graphics.DrawLine(myPen, 0, 1281, 560, 1281)
            e.Graphics.DrawLine(myPen, 0, 1293, 560, 1293)
            e.Graphics.DrawLine(myPen, 0, 1305, 560, 1305)
            e.Graphics.DrawLine(myPen, 0, 1317, 560, 1317)
            e.Graphics.DrawLine(myPen, 0, 1329, 560, 1329)
            e.Graphics.DrawLine(myPen, 0, 1341, 560, 1341)



            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 0, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 100, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 135, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 190, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 290, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 325, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 380, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 480, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 515, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 570, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 670, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 705, 6)


            If DataGridView1.Rows.Count > 180 Then

                While i < 110

                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 0, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(18, i).Value, prFont1, Brushes.Black, 110, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 140, i * 12 + 20)
                    i += 1


                End While


                While i < 220
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 190, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(18, i).Value, prFont1, Brushes.Black, 300, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 330, i * 12 - 1300)
                    i += 1


                End While

                While i < 330
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 380, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(18, i).Value, prFont1, Brushes.Black, 490, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 520, i * 12 - 2620)
                    i += 1


                End While

                While i < DataGridView1.Rows.Count
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 570, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(18, i).Value, prFont1, Brushes.Black, 680, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 710, i * 12 - 3940)
                    i += 1


                End While


            End If

        End If


        If TextBox1.Text = "Santín" Then

            Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
            PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            e.Graphics.DrawImage(bm, 600, 1050)
            Dim i As Integer = 0
            Dim i1 As Integer = 0
            Dim i11 As Integer = 0
            Dim line As String = Nothing
            Dim myPen = New Pen(Color.Black, 1)
            Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
            Dim prFont2 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
            Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
            Dim prFont9 As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
            Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
            e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 600, 1120) '65
            e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 610, 1130) '75
            e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 600, 1145) '90
            e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 600, 1160) '105
            e.Graphics.DrawString(DateTimePicker2.Value, prFont2, Brushes.Black, 650, 1160) '105
            e.Graphics.DrawString("HOJA DE CHOFER DE SISTEMA.", prFont2, Brushes.Black, 600, 1185) '130
            e.Graphics.DrawString("Sucursal:", prFont2, Brushes.Black, 600, 1200) '145
            e.Graphics.DrawString(TextBox1.Text, prFont9, Brushes.Black, 660, 1200) '145
            e.Graphics.DrawString("Chofer:", prFont2, Brushes.Black, 600, 1220)
            ' e.Graphics.DrawString(TextBox156.Text, prFont9, Brushes.Black, 660, 1220)
            ' e.Graphics.DrawString("ANOTACIONES:", prFont9, Brushes.Black, 600, 185)

            Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows
                If linea.Cells(1).Value = "Concha blanca int." Then
                    linea.Cells(1).Value = "Concha bca. int."
                End If
                If linea.Cells(1).Value = "Minirosquita Janeth" Then
                    linea.Cells(1).Value = "Rosquita Janeth"
                End If
                If linea.Cells(1).Value = "Cuerno mantequilla" Then
                    linea.Cells(1).Value = "Cuerno mante"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria" Then
                    linea.Cells(1).Value = "Panqué de zana"
                End If
                If linea.Cells(1).Value = "Gel. Dominó especial" Then
                    linea.Cells(1).Value = "Gel. Dom. esp."
                End If
                If linea.Cells(1).Value = "Gel. Rompope fruta" Then
                    linea.Cells(1).Value = "Gel. Rompope"
                End If
                If linea.Cells(1).Value = "Leche deslactosada 1l" Then
                    linea.Cells(1).Value = "L. deslac. 1l"
                End If
                If linea.Cells(1).Value = "Pay queso chocolate" Then
                    linea.Cells(1).Value = "P. queso choco"
                End If
                If linea.Cells(1).Value = "Feliz Cumple con base" Then
                    linea.Cells(1).Value = "F.C. base"
                End If
                If linea.Cells(1).Value = "Caja Galletas .250 Kg" Then
                    linea.Cells(1).Value = "C. Galle. .250"
                End If
                If linea.Cells(1).Value = "Panqué de chocolate" Then
                    linea.Cells(1).Value = "Panqué de choco"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria barra" Then
                    linea.Cells(1).Value = "P. zana barra"
                End If
                If linea.Cells(1).Value = "Panqué de chabacano" Then
                    linea.Cells(1).Value = "Panqué chaba"
                End If
                If linea.Cells(1).Value = "Bolsa cafe ame 500gr" Then
                    linea.Cells(1).Value = "B. café a. 500"
                End If
                If linea.Cells(1).Value = "Bolsa cafe des 500gr" Then
                    linea.Cells(1).Value = "B. café d. 500gr"
                End If
                If linea.Cells(1).Value = "Gel. Med. Bombón" Then
                    linea.Cells(1).Value = "G.M. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó" Then
                    linea.Cells(1).Value = "G.M. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó esp." Then
                    linea.Cells(1).Value = "G.M. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Med. Betabel" Then
                    linea.Cells(1).Value = "G.M. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Med. Queso uva" Then
                    linea.Cells(1).Value = "G.M. Queso u"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tricolor" Then
                    linea.Cells(1).Value = "G.M. Tricolor"
                End If
                If linea.Cells(1).Value = "Caja Galletas .5 Kg" Then
                    linea.Cells(1).Value = "C. Galle .5"
                End If
                If linea.Cells(1).Value = "Gel. Med. Agua fruta" Then
                    linea.Cells(1).Value = "G.M. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Med. Rompope" Then
                    linea.Cells(1).Value = "G.M. Romp."
                End If
                If linea.Cells(1).Value = "Panqué elote barra" Then
                    linea.Cells(1).Value = "P. elote barra"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tuti fruti" Then
                    linea.Cells(1).Value = "G.M. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Med. Zanahoria" Then
                    linea.Cells(1).Value = "G.M. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Flores Arándanos" Then
                    linea.Cells(1).Value = "G. Flores A."
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 leches" Then
                    linea.Cells(1).Value = "G.M. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Agua fruta" Then
                    linea.Cells(1).Value = "G.G. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó esp." Then
                    linea.Cells(1).Value = "G.G. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Betabel" Then
                    linea.Cells(1).Value = "G.G. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Tuti fruti" Then
                    linea.Cells(1).Value = "G.G. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Rompope" Then
                    linea.Cells(1).Value = "G.G. Rompope"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 leches" Then
                    linea.Cells(1).Value = "G.G. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Zanahoria" Then
                    linea.Cells(1).Value = "G.G. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 chocolates" Then
                    linea.Cells(1).Value = "G.G. 3 choco"
                End If
                If linea.Cells(1).Value = "Caja Galletas 1 Kg" Then
                    linea.Cells(1).Value = "C. Galle 1"
                End If
                If linea.Cells(1).Value = "Pay queso zarza G." Then
                    linea.Cells(1).Value = "Pay q.zarza G."
                End If
                If linea.Cells(1).Value = "Gel. Vino tinto 22 cm" Then
                    linea.Cells(1).Value = "Gel. vino 22cm"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó" Then
                    linea.Cells(1).Value = "G.G. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Bombón" Then
                    linea.Cells(1).Value = "G.G. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 chocolates" Then
                    linea.Cells(1).Value = "G.M. 3 choco"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Queso uva" Then
                    linea.Cells(1).Value = "G.G. Queso u"
                End If
                If linea.Cells(1).Value = "Pay queso frutas G." Then
                    linea.Cells(1).Value = "Pay q.frutas G."
                End If
                If linea.Cells(1).Value = "Pay queso fresa G." Then
                    linea.Cells(1).Value = "Pay q.fresa G."
                End If
            Next


            'dibujar linea
            e.Graphics.DrawLine(myPen, 0, 21, 770, 21) '+12
            e.Graphics.DrawLine(myPen, 0, 33, 770, 33)
            e.Graphics.DrawLine(myPen, 0, 45, 770, 45)
            e.Graphics.DrawLine(myPen, 0, 57, 770, 57)
            e.Graphics.DrawLine(myPen, 0, 69, 770, 69)
            e.Graphics.DrawLine(myPen, 0, 81, 770, 81)
            e.Graphics.DrawLine(myPen, 0, 93, 770, 93)
            e.Graphics.DrawLine(myPen, 0, 105, 770, 105)
            e.Graphics.DrawLine(myPen, 0, 117, 770, 117)
            e.Graphics.DrawLine(myPen, 0, 129, 770, 129)
            e.Graphics.DrawLine(myPen, 0, 141, 770, 141)
            e.Graphics.DrawLine(myPen, 0, 153, 770, 153)
            e.Graphics.DrawLine(myPen, 0, 165, 770, 165)
            e.Graphics.DrawLine(myPen, 0, 177, 770, 177)
            e.Graphics.DrawLine(myPen, 0, 189, 770, 189)
            e.Graphics.DrawLine(myPen, 0, 201, 770, 201)
            e.Graphics.DrawLine(myPen, 0, 213, 770, 213)
            e.Graphics.DrawLine(myPen, 0, 225, 770, 225)
            e.Graphics.DrawLine(myPen, 0, 237, 770, 237)
            e.Graphics.DrawLine(myPen, 0, 249, 770, 249)
            e.Graphics.DrawLine(myPen, 0, 261, 770, 261)
            e.Graphics.DrawLine(myPen, 0, 273, 770, 273)
            e.Graphics.DrawLine(myPen, 0, 285, 770, 285) 'hasta 31
            e.Graphics.DrawLine(myPen, 0, 297, 770, 297)
            e.Graphics.DrawLine(myPen, 0, 309, 770, 309)
            e.Graphics.DrawLine(myPen, 0, 321, 770, 321)
            e.Graphics.DrawLine(myPen, 0, 333, 770, 333)
            e.Graphics.DrawLine(myPen, 0, 345, 770, 345)
            e.Graphics.DrawLine(myPen, 0, 357, 770, 357)
            e.Graphics.DrawLine(myPen, 0, 369, 770, 369)
            e.Graphics.DrawLine(myPen, 0, 381, 770, 381)


            'aqui inician livbres las lineas
            e.Graphics.DrawLine(myPen, 0, 393, 560, 393)
            e.Graphics.DrawLine(myPen, 0, 405, 560, 405)
            e.Graphics.DrawLine(myPen, 0, 417, 560, 417)
            e.Graphics.DrawLine(myPen, 0, 429, 560, 429)
            e.Graphics.DrawLine(myPen, 0, 441, 560, 441)
            e.Graphics.DrawLine(myPen, 0, 453, 560, 453)
            e.Graphics.DrawLine(myPen, 0, 465, 560, 465)
            e.Graphics.DrawLine(myPen, 0, 477, 560, 477)
            e.Graphics.DrawLine(myPen, 0, 489, 560, 489)
            e.Graphics.DrawLine(myPen, 0, 501, 560, 501)
            e.Graphics.DrawLine(myPen, 0, 513, 560, 513)
            e.Graphics.DrawLine(myPen, 0, 525, 560, 525)
            e.Graphics.DrawLine(myPen, 0, 537, 560, 537)
            e.Graphics.DrawLine(myPen, 0, 549, 560, 549)
            e.Graphics.DrawLine(myPen, 0, 561, 560, 561)
            e.Graphics.DrawLine(myPen, 0, 573, 560, 573)
            e.Graphics.DrawLine(myPen, 0, 585, 560, 585)
            e.Graphics.DrawLine(myPen, 0, 597, 560, 597)
            e.Graphics.DrawLine(myPen, 0, 609, 560, 609)
            e.Graphics.DrawLine(myPen, 0, 621, 560, 621)
            e.Graphics.DrawLine(myPen, 0, 633, 560, 633)
            e.Graphics.DrawLine(myPen, 0, 645, 560, 645)
            e.Graphics.DrawLine(myPen, 0, 657, 560, 657)
            e.Graphics.DrawLine(myPen, 0, 669, 560, 669)
            e.Graphics.DrawLine(myPen, 0, 681, 560, 681)
            e.Graphics.DrawLine(myPen, 0, 693, 560, 693)
            e.Graphics.DrawLine(myPen, 0, 705, 560, 705)
            e.Graphics.DrawLine(myPen, 0, 717, 560, 717)
            e.Graphics.DrawLine(myPen, 0, 729, 560, 729)
            e.Graphics.DrawLine(myPen, 0, 741, 560, 741)
            e.Graphics.DrawLine(myPen, 0, 753, 560, 753)
            e.Graphics.DrawLine(myPen, 0, 765, 560, 765)
            e.Graphics.DrawLine(myPen, 0, 777, 560, 777)
            e.Graphics.DrawLine(myPen, 0, 789, 560, 789)
            e.Graphics.DrawLine(myPen, 0, 801, 560, 801)
            e.Graphics.DrawLine(myPen, 0, 813, 560, 813)
            e.Graphics.DrawLine(myPen, 0, 825, 560, 825)
            e.Graphics.DrawLine(myPen, 0, 837, 560, 837)
            e.Graphics.DrawLine(myPen, 0, 849, 560, 849)
            e.Graphics.DrawLine(myPen, 0, 861, 560, 861)
            e.Graphics.DrawLine(myPen, 0, 873, 560, 873)
            e.Graphics.DrawLine(myPen, 0, 885, 560, 885)
            e.Graphics.DrawLine(myPen, 0, 897, 560, 897)
            e.Graphics.DrawLine(myPen, 0, 909, 560, 909)
            e.Graphics.DrawLine(myPen, 0, 921, 560, 921)
            e.Graphics.DrawLine(myPen, 0, 933, 560, 933)
            e.Graphics.DrawLine(myPen, 0, 945, 560, 945)
            e.Graphics.DrawLine(myPen, 0, 957, 560, 957)
            e.Graphics.DrawLine(myPen, 0, 969, 560, 969)
            e.Graphics.DrawLine(myPen, 0, 981, 560, 981)
            e.Graphics.DrawLine(myPen, 0, 993, 560, 993)
            e.Graphics.DrawLine(myPen, 0, 1005, 560, 1005)
            e.Graphics.DrawLine(myPen, 0, 1017, 560, 1017)
            e.Graphics.DrawLine(myPen, 0, 1029, 560, 1029)
            e.Graphics.DrawLine(myPen, 0, 1041, 560, 1041)
            e.Graphics.DrawLine(myPen, 0, 1053, 560, 1053)
            e.Graphics.DrawLine(myPen, 0, 1065, 560, 1065)
            e.Graphics.DrawLine(myPen, 0, 1077, 560, 1077)
            e.Graphics.DrawLine(myPen, 0, 1089, 560, 1089)
            e.Graphics.DrawLine(myPen, 0, 1101, 560, 1101)
            e.Graphics.DrawLine(myPen, 0, 1113, 560, 1113)
            e.Graphics.DrawLine(myPen, 0, 1125, 560, 1125)
            e.Graphics.DrawLine(myPen, 0, 1137, 560, 1137)
            e.Graphics.DrawLine(myPen, 0, 1149, 560, 1149)
            e.Graphics.DrawLine(myPen, 0, 1161, 560, 1161)
            e.Graphics.DrawLine(myPen, 0, 1173, 560, 1173)
            e.Graphics.DrawLine(myPen, 0, 1185, 560, 1185)
            e.Graphics.DrawLine(myPen, 0, 1197, 560, 1197)
            e.Graphics.DrawLine(myPen, 0, 1209, 560, 1209)
            e.Graphics.DrawLine(myPen, 0, 1221, 560, 1221)
            e.Graphics.DrawLine(myPen, 0, 1233, 560, 1233)
            e.Graphics.DrawLine(myPen, 0, 1245, 560, 1245)
            e.Graphics.DrawLine(myPen, 0, 1257, 560, 1257)
            e.Graphics.DrawLine(myPen, 0, 1269, 560, 1269)

            e.Graphics.DrawLine(myPen, 0, 1281, 560, 1281)
            e.Graphics.DrawLine(myPen, 0, 1293, 560, 1293)
            e.Graphics.DrawLine(myPen, 0, 1305, 560, 1305)
            e.Graphics.DrawLine(myPen, 0, 1317, 560, 1317)
            e.Graphics.DrawLine(myPen, 0, 1329, 560, 1329)
            e.Graphics.DrawLine(myPen, 0, 1341, 560, 1341)



            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 0, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 100, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 135, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 190, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 290, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 325, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 380, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 480, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 515, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 570, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 670, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 705, 6)


            If DataGridView1.Rows.Count > 180 Then

                While i < 110

                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 0, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(20, i).Value, prFont1, Brushes.Black, 110, i * 12 + 20)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 140, i * 12 + 20)
                    i += 1


                End While


                While i < 220
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 190, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(20, i).Value, prFont1, Brushes.Black, 300, i * 12 - 1300)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 330, i * 12 - 1300)
                    i += 1


                End While

                While i < 330
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 380, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(20, i).Value, prFont1, Brushes.Black, 490, i * 12 - 2620)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 520, i * 12 - 2620)
                    i += 1


                End While

                While i < DataGridView1.Rows.Count
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 570, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(20, i).Value, prFont1, Brushes.Black, 680, i * 12 - 3940)
                    e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 710, i * 12 - 3940)
                    i += 1


                End While


            End If

        End If










    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)



    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button21_Click_1(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox1.Text = Button21.Text
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Distribución ORDER by Precio")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla

            DataGridView1.Visible = True


            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(6).Width = 100
            DataGridView1.Columns(23).Width = 100

            DataGridView1.Columns(23).DefaultCellStyle.Format = "C"

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = True
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = True
            DataGridView1.Columns(24).Visible = False
            DataGridView1.Columns(25).Visible = False


            PrintDocument1.Print()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click

        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Distribución where Categoría='Pastel 25' AND Categoría='Gel. Gde.'")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla


            DataGridView1.AllowUserToResizeRows = False
            DataGridView1.AllowUserToResizeColumns = False
            DataGridView1.DefaultCellStyle.ForeColor = Color.Black
            DataGridView1.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
            DataGridView1.AllowUserToResizeRows = False
            DataGridView1.DefaultCellStyle.Font = New Font("Arial", 10)

        Catch ex As Exception

        End Try




        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(2).Value
            Next
            TextBox3.Text = "" & FormatNumber(valor1, 0)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(3).Value
            Next
            TextBox4.Text = "" & FormatNumber(valor1, 0)


        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(4).Value
            Next

            TextBox5.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(5).Value
            Next

            TextBox6.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(6).Value
            Next

            TextBox7.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(7).Value
            Next

            TextBox8.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(8).Value
            Next
            TextBox9.Text = "" & FormatNumber(valor1, 0)


        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(9).Value
            Next
            TextBox10.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(10).Value
            Next
            TextBox11.Text = "" & FormatNumber(valor1, 0)


        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(11).Value
            Next

            TextBox12.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(12).Value
            Next

            TextBox13.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(13).Value
            Next
            TextBox14.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(14).Value
            Next

            TextBox15.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(15).Value
            Next

            TextBox16.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(16).Value
            Next
            TextBox17.Text = "" & FormatNumber(valor1, 0)


        Catch ex As Exception

        End Try

        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(17).Value
            Next

            TextBox18.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(18).Value
            Next

            TextBox19.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(19).Value
            Next
            TextBox20.Text = "" & FormatNumber(valor1, 0)


        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(20).Value
            Next
            TextBox21.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try






        Try
            Dim adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from Distribución where Categoría='Pastel 18' AND Categoría='Gel. Med.'")
            adaptador1 = New OleDbDataAdapter(buscar1, conexion19)
            tabla1 = New DataTable
            adaptador1.Fill(tabla1)
            DataGridView1.DataSource = tabla1


            DataGridView1.AllowUserToResizeRows = False
            DataGridView1.AllowUserToResizeColumns = False
            DataGridView1.DefaultCellStyle.ForeColor = Color.Black
            DataGridView1.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
            DataGridView1.AllowUserToResizeRows = False
            DataGridView1.DefaultCellStyle.Font = New Font("Arial", 10)










        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(2).Value
            Next
            TextBox38.Text = "" & FormatNumber(valor1, 0)


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(3).Value
            Next
            TextBox39.Text = "" & FormatNumber(valor1, 0)


        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(4).Value
            Next

            TextBox40.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(5).Value
            Next

            TextBox37.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(6).Value
            Next

            TextBox36.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(7).Value
            Next

            TextBox35.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(8).Value
            Next
            TextBox34.Text = "" & FormatNumber(valor1, 0)


        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(9).Value
            Next
            TextBox33.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(10).Value
            Next
            TextBox32.Text = "" & FormatNumber(valor1, 0)


        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(11).Value
            Next

            TextBox31.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(12).Value
            Next

            TextBox30.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(13).Value
            Next
            TextBox29.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(14).Value
            Next

            TextBox28.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(15).Value
            Next

            TextBox27.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(16).Value
            Next
            TextBox26.Text = "" & FormatNumber(valor1, 0)


        Catch ex As Exception

        End Try

        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(17).Value
            Next

            TextBox25.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(18).Value
            Next

            TextBox24.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(19).Value
            Next
            TextBox23.Text = "" & FormatNumber(valor1, 0)


        Catch ex As Exception

        End Try
        Try
            Dim linea1 As DataGridViewRow
            Dim valor1 As Double

            For Each linea1 In DataGridView1.Rows
                valor1 = valor1 + linea1.Cells(20).Value
            Next
            TextBox22.Text = "" & FormatNumber(valor1, 0)

        Catch ex As Exception

        End Try


















        '  PrintDocument2.Print()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub PrintDocument2_PrintPage_1(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click

        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Distribución ORDER by Precio")
            adaptador = New OleDbDataAdapter(buscar, conexion19)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla

            DataGridView1.Visible = True


            DataGridView1.Columns(1).Width = 160
            DataGridView1.Columns(6).Width = 100
            DataGridView1.Columns(23).Width = 80
            DataGridView1.Columns(23).Width = 80

            DataGridView1.Columns(23).DefaultCellStyle.Format = "C"

            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).Visible = True
            DataGridView1.Columns(2).Visible = False
            DataGridView1.Columns(3).Visible = False
            DataGridView1.Columns(4).Visible = False
            DataGridView1.Columns(5).Visible = False
            DataGridView1.Columns(6).Visible = False
            DataGridView1.Columns(7).Visible = False
            DataGridView1.Columns(8).Visible = False
            DataGridView1.Columns(9).Visible = False
            DataGridView1.Columns(10).Visible = False
            DataGridView1.Columns(11).Visible = False
            DataGridView1.Columns(12).Visible = False
            DataGridView1.Columns(13).Visible = False
            DataGridView1.Columns(14).Visible = False
            DataGridView1.Columns(15).Visible = False
            DataGridView1.Columns(16).Visible = False
            DataGridView1.Columns(17).Visible = False
            DataGridView1.Columns(18).Visible = False
            DataGridView1.Columns(19).Visible = False
            DataGridView1.Columns(20).Visible = False
            DataGridView1.Columns(21).Visible = False
            DataGridView1.Columns(22).Visible = False
            DataGridView1.Columns(23).Visible = True
            DataGridView1.Columns(24).Visible = True
            DataGridView1.Columns(25).Visible = False



            Try
                Dim linea As DataGridViewRow
                For Each linea In DataGridView1.Rows
                    TextBox42.Text = linea.Cells(2).Value
                    TextBox3.Text = linea.Cells(3).Value
                    TextBox4.Text = linea.Cells(4).Value
                    TextBox5.Text = linea.Cells(5).Value
                    TextBox6.Text = linea.Cells(6).Value
                    TextBox7.Text = linea.Cells(7).Value
                    TextBox8.Text = linea.Cells(8).Value
                    TextBox9.Text = linea.Cells(9).Value
                    TextBox10.Text = linea.Cells(10).Value
                    TextBox11.Text = linea.Cells(11).Value
                    TextBox12.Text = linea.Cells(12).Value
                    TextBox13.Text = linea.Cells(13).Value
                    TextBox14.Text = linea.Cells(14).Value
                    TextBox15.Text = linea.Cells(15).Value
                    TextBox16.Text = linea.Cells(16).Value
                    TextBox17.Text = linea.Cells(17).Value
                    TextBox18.Text = linea.Cells(18).Value
                    TextBox19.Text = linea.Cells(19).Value
                    TextBox41.Text = linea.Cells(20).Value


                    TextBox43.Text = CDec(TextBox42.Text) + CDec(TextBox3.Text) + CDec(TextBox4.Text) + CDec(TextBox5.Text) + CDec(TextBox6.Text) + CDec(TextBox7.Text) + CDec(TextBox8.Text) + CDec(TextBox9.Text) + CDec(TextBox10.Text) + CDec(TextBox11.Text) + CDec(TextBox12.Text) + CDec(TextBox13.Text) + CDec(TextBox14.Text) + CDec(TextBox15.Text) + CDec(TextBox16.Text) + CDec(TextBox17.Text) + CDec(TextBox18.Text) + CDec(TextBox19.Text) + CDec(TextBox41.Text)

                    linea.Cells(24).Value = CDec(TextBox43.Text)


                Next
            Catch ex As Exception

            End Try


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If MsgBox("¿Deseas imprimir todo el pedido de las sucursales?", MsgBoxStyle.YesNo, "Rosa de Sarón Pastelerías") = MsgBoxResult.Yes Then
            PrintDocument3.Print()

        End If
    End Sub

    Private Sub PrintDocument3_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument3.PrintPage




        Dim bm As New Bitmap(PictureBox4.Width, PictureBox4.Height)
        PictureBox4.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
        e.Graphics.DrawImage(bm, 600, 1050)
        Dim i As Integer = 0
        Dim i1 As Integer = 0
        Dim i11 As Integer = 0
        Dim line As String = Nothing
        Dim myPen = New Pen(Color.Black, 1)
            Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
            Dim prFont2 As New Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point)
            Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
            Dim prFont9 As New Font("Arial", 14, GraphicsUnit.Point)
            Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
            Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
            e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 600, 1120) '65
            e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 610, 1130) '75
            e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 600, 1145) '90
            e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 600, 1160) '105
            e.Graphics.DrawString(DateTimePicker2.Value, prFont2, Brushes.Black, 650, 1160) '105
        e.Graphics.DrawString("PEDIDO COMPLETO DE SUCURSALES.", prFont2, Brushes.Black, 600, 1185) '130


        Dim linea As DataGridViewRow
            For Each linea In DataGridView1.Rows
                If linea.Cells(1).Value = "Concha blanca int." Then
                    linea.Cells(1).Value = "Concha bca. int."
                End If
                If linea.Cells(1).Value = "Minirosquita Janeth" Then
                    linea.Cells(1).Value = "Rosquita Janeth"
                End If
                If linea.Cells(1).Value = "Cuerno mantequilla" Then
                    linea.Cells(1).Value = "Cuerno mante"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria" Then
                    linea.Cells(1).Value = "Panqué de zana"
                End If
                If linea.Cells(1).Value = "Gel. Dominó especial" Then
                    linea.Cells(1).Value = "Gel. Dom. esp."
                End If
                If linea.Cells(1).Value = "Gel. Rompope fruta" Then
                    linea.Cells(1).Value = "Gel. Rompope"
                End If
                If linea.Cells(1).Value = "Leche deslactosada 1l" Then
                    linea.Cells(1).Value = "L. deslac. 1l"
                End If
                If linea.Cells(1).Value = "Pay queso chocolate" Then
                    linea.Cells(1).Value = "P. queso choco"
                End If
                If linea.Cells(1).Value = "Feliz Cumple con base" Then
                    linea.Cells(1).Value = "F.C. base"
                End If
                If linea.Cells(1).Value = "Caja Galletas .250 Kg" Then
                    linea.Cells(1).Value = "C. Galle. .250"
                End If
                If linea.Cells(1).Value = "Panqué de chocolate" Then
                    linea.Cells(1).Value = "Panqué de choco"
                End If
                If linea.Cells(1).Value = "Panqué de zanahoria barra" Then
                    linea.Cells(1).Value = "P. zana barra"
                End If
                If linea.Cells(1).Value = "Panqué de chabacano" Then
                    linea.Cells(1).Value = "Panqué chaba"
                End If
                If linea.Cells(1).Value = "Bolsa cafe ame 500gr" Then
                    linea.Cells(1).Value = "B. café a. 500"
                End If
                If linea.Cells(1).Value = "Bolsa cafe des 500gr" Then
                    linea.Cells(1).Value = "B. café d. 500gr"
                End If
                If linea.Cells(1).Value = "Gel. Med. Bombón" Then
                    linea.Cells(1).Value = "G.M. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó" Then
                    linea.Cells(1).Value = "G.M. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Med. Dominó esp." Then
                    linea.Cells(1).Value = "G.M. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Med. Betabel" Then
                    linea.Cells(1).Value = "G.M. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Med. Queso uva" Then
                    linea.Cells(1).Value = "G.M. Queso u"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tricolor" Then
                    linea.Cells(1).Value = "G.M. Tricolor"
                End If
                If linea.Cells(1).Value = "Caja Galletas .5 Kg" Then
                    linea.Cells(1).Value = "C. Galle .5"
                End If
                If linea.Cells(1).Value = "Gel. Med. Agua fruta" Then
                    linea.Cells(1).Value = "G.M. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Med. Rompope" Then
                    linea.Cells(1).Value = "G.M. Romp."
                End If
                If linea.Cells(1).Value = "Panqué elote barra" Then
                    linea.Cells(1).Value = "P. elote barra"
                End If
                If linea.Cells(1).Value = "Gel. Med. Tuti fruti" Then
                    linea.Cells(1).Value = "G.M. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Med. Zanahoria" Then
                    linea.Cells(1).Value = "G.M. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Flores Arándanos" Then
                    linea.Cells(1).Value = "G. Flores A."
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 leches" Then
                    linea.Cells(1).Value = "G.M. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Agua fruta" Then
                    linea.Cells(1).Value = "G.G. Agua"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó esp." Then
                    linea.Cells(1).Value = "G.G. Dom esp"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Betabel" Then
                    linea.Cells(1).Value = "G.G. Betabel"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Tuti fruti" Then
                    linea.Cells(1).Value = "G.G. Tuti"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Rompope" Then
                    linea.Cells(1).Value = "G.G. Rompope"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 leches" Then
                    linea.Cells(1).Value = "G.G. 3 lech"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Zanahoria" Then
                    linea.Cells(1).Value = "G.G. Zana"
                End If
                If linea.Cells(1).Value = "Gel. Gde. 3 chocolates" Then
                    linea.Cells(1).Value = "G.G. 3 choco"
                End If
                If linea.Cells(1).Value = "Caja Galletas 1 Kg" Then
                    linea.Cells(1).Value = "C. Galle 1"
                End If
                If linea.Cells(1).Value = "Pay queso zarza G." Then
                    linea.Cells(1).Value = "Pay q.zarza G."
                End If
                If linea.Cells(1).Value = "Gel. Vino tinto 22 cm" Then
                    linea.Cells(1).Value = "Gel. vino 22cm"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Dominó" Then
                    linea.Cells(1).Value = "G.G. Dominó"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Bombón" Then
                    linea.Cells(1).Value = "G.G. Bombón"
                End If
                If linea.Cells(1).Value = "Gel. Med. 3 chocolates" Then
                    linea.Cells(1).Value = "G.M. 3 choco"
                End If
                If linea.Cells(1).Value = "Gel. Gde. Queso uva" Then
                    linea.Cells(1).Value = "G.G. Queso u"
                End If
                If linea.Cells(1).Value = "Pay queso frutas G." Then
                    linea.Cells(1).Value = "Pay q.frutas G."
                End If
                If linea.Cells(1).Value = "Pay queso fresa G." Then
                    linea.Cells(1).Value = "Pay q.fresa G."
                End If
            Next


            'dibujar linea
            e.Graphics.DrawLine(myPen, 0, 21, 770, 21) '+12
            e.Graphics.DrawLine(myPen, 0, 33, 770, 33)
            e.Graphics.DrawLine(myPen, 0, 45, 770, 45)
            e.Graphics.DrawLine(myPen, 0, 57, 770, 57)
            e.Graphics.DrawLine(myPen, 0, 69, 770, 69)
            e.Graphics.DrawLine(myPen, 0, 81, 770, 81)
            e.Graphics.DrawLine(myPen, 0, 93, 770, 93)
            e.Graphics.DrawLine(myPen, 0, 105, 770, 105)
            e.Graphics.DrawLine(myPen, 0, 117, 770, 117)
            e.Graphics.DrawLine(myPen, 0, 129, 770, 129)
            e.Graphics.DrawLine(myPen, 0, 141, 770, 141)
            e.Graphics.DrawLine(myPen, 0, 153, 770, 153)
            e.Graphics.DrawLine(myPen, 0, 165, 770, 165)
            e.Graphics.DrawLine(myPen, 0, 177, 770, 177)
            e.Graphics.DrawLine(myPen, 0, 189, 770, 189)
            e.Graphics.DrawLine(myPen, 0, 201, 770, 201)
            e.Graphics.DrawLine(myPen, 0, 213, 770, 213)
            e.Graphics.DrawLine(myPen, 0, 225, 770, 225)
            e.Graphics.DrawLine(myPen, 0, 237, 770, 237)
            e.Graphics.DrawLine(myPen, 0, 249, 770, 249)
            e.Graphics.DrawLine(myPen, 0, 261, 770, 261)
            e.Graphics.DrawLine(myPen, 0, 273, 770, 273)
            e.Graphics.DrawLine(myPen, 0, 285, 770, 285) 'hasta 31
            e.Graphics.DrawLine(myPen, 0, 297, 770, 297)
            e.Graphics.DrawLine(myPen, 0, 309, 770, 309)
            e.Graphics.DrawLine(myPen, 0, 321, 770, 321)
            e.Graphics.DrawLine(myPen, 0, 333, 770, 333)
            e.Graphics.DrawLine(myPen, 0, 345, 770, 345)
            e.Graphics.DrawLine(myPen, 0, 357, 770, 357)
            e.Graphics.DrawLine(myPen, 0, 369, 770, 369)
            e.Graphics.DrawLine(myPen, 0, 381, 770, 381)


            'aqui inician livbres las lineas
            e.Graphics.DrawLine(myPen, 0, 393, 560, 393)
            e.Graphics.DrawLine(myPen, 0, 405, 560, 405)
            e.Graphics.DrawLine(myPen, 0, 417, 560, 417)
            e.Graphics.DrawLine(myPen, 0, 429, 560, 429)
            e.Graphics.DrawLine(myPen, 0, 441, 560, 441)
            e.Graphics.DrawLine(myPen, 0, 453, 560, 453)
            e.Graphics.DrawLine(myPen, 0, 465, 560, 465)
            e.Graphics.DrawLine(myPen, 0, 477, 560, 477)
            e.Graphics.DrawLine(myPen, 0, 489, 560, 489)
            e.Graphics.DrawLine(myPen, 0, 501, 560, 501)
            e.Graphics.DrawLine(myPen, 0, 513, 560, 513)
            e.Graphics.DrawLine(myPen, 0, 525, 560, 525)
            e.Graphics.DrawLine(myPen, 0, 537, 560, 537)
            e.Graphics.DrawLine(myPen, 0, 549, 560, 549)
            e.Graphics.DrawLine(myPen, 0, 561, 560, 561)
            e.Graphics.DrawLine(myPen, 0, 573, 560, 573)
            e.Graphics.DrawLine(myPen, 0, 585, 560, 585)
            e.Graphics.DrawLine(myPen, 0, 597, 560, 597)
            e.Graphics.DrawLine(myPen, 0, 609, 560, 609)
            e.Graphics.DrawLine(myPen, 0, 621, 560, 621)
            e.Graphics.DrawLine(myPen, 0, 633, 560, 633)
            e.Graphics.DrawLine(myPen, 0, 645, 560, 645)
            e.Graphics.DrawLine(myPen, 0, 657, 560, 657)
            e.Graphics.DrawLine(myPen, 0, 669, 560, 669)
            e.Graphics.DrawLine(myPen, 0, 681, 560, 681)
            e.Graphics.DrawLine(myPen, 0, 693, 560, 693)
            e.Graphics.DrawLine(myPen, 0, 705, 560, 705)
            e.Graphics.DrawLine(myPen, 0, 717, 560, 717)
            e.Graphics.DrawLine(myPen, 0, 729, 560, 729)
            e.Graphics.DrawLine(myPen, 0, 741, 560, 741)
            e.Graphics.DrawLine(myPen, 0, 753, 560, 753)
            e.Graphics.DrawLine(myPen, 0, 765, 560, 765)
            e.Graphics.DrawLine(myPen, 0, 777, 560, 777)
            e.Graphics.DrawLine(myPen, 0, 789, 560, 789)
            e.Graphics.DrawLine(myPen, 0, 801, 560, 801)
            e.Graphics.DrawLine(myPen, 0, 813, 560, 813)
            e.Graphics.DrawLine(myPen, 0, 825, 560, 825)
            e.Graphics.DrawLine(myPen, 0, 837, 560, 837)
            e.Graphics.DrawLine(myPen, 0, 849, 560, 849)
            e.Graphics.DrawLine(myPen, 0, 861, 560, 861)
            e.Graphics.DrawLine(myPen, 0, 873, 560, 873)
            e.Graphics.DrawLine(myPen, 0, 885, 560, 885)
            e.Graphics.DrawLine(myPen, 0, 897, 560, 897)
            e.Graphics.DrawLine(myPen, 0, 909, 560, 909)
            e.Graphics.DrawLine(myPen, 0, 921, 560, 921)
            e.Graphics.DrawLine(myPen, 0, 933, 560, 933)
            e.Graphics.DrawLine(myPen, 0, 945, 560, 945)
            e.Graphics.DrawLine(myPen, 0, 957, 560, 957)
            e.Graphics.DrawLine(myPen, 0, 969, 560, 969)
            e.Graphics.DrawLine(myPen, 0, 981, 560, 981)
            e.Graphics.DrawLine(myPen, 0, 993, 560, 993)
            e.Graphics.DrawLine(myPen, 0, 1005, 560, 1005)
            e.Graphics.DrawLine(myPen, 0, 1017, 560, 1017)
            e.Graphics.DrawLine(myPen, 0, 1029, 560, 1029)
            e.Graphics.DrawLine(myPen, 0, 1041, 560, 1041)
            e.Graphics.DrawLine(myPen, 0, 1053, 560, 1053)
            e.Graphics.DrawLine(myPen, 0, 1065, 560, 1065)
            e.Graphics.DrawLine(myPen, 0, 1077, 560, 1077)
            e.Graphics.DrawLine(myPen, 0, 1089, 560, 1089)
            e.Graphics.DrawLine(myPen, 0, 1101, 560, 1101)
            e.Graphics.DrawLine(myPen, 0, 1113, 560, 1113)
            e.Graphics.DrawLine(myPen, 0, 1125, 560, 1125)
            e.Graphics.DrawLine(myPen, 0, 1137, 560, 1137)
            e.Graphics.DrawLine(myPen, 0, 1149, 560, 1149)
            e.Graphics.DrawLine(myPen, 0, 1161, 560, 1161)
            e.Graphics.DrawLine(myPen, 0, 1173, 560, 1173)
            e.Graphics.DrawLine(myPen, 0, 1185, 560, 1185)
            e.Graphics.DrawLine(myPen, 0, 1197, 560, 1197)
            e.Graphics.DrawLine(myPen, 0, 1209, 560, 1209)
            e.Graphics.DrawLine(myPen, 0, 1221, 560, 1221)
            e.Graphics.DrawLine(myPen, 0, 1233, 560, 1233)
            e.Graphics.DrawLine(myPen, 0, 1245, 560, 1245)
            e.Graphics.DrawLine(myPen, 0, 1257, 560, 1257)
            e.Graphics.DrawLine(myPen, 0, 1269, 560, 1269)

            e.Graphics.DrawLine(myPen, 0, 1281, 560, 1281)
            e.Graphics.DrawLine(myPen, 0, 1293, 560, 1293)
            e.Graphics.DrawLine(myPen, 0, 1305, 560, 1305)
            e.Graphics.DrawLine(myPen, 0, 1317, 560, 1317)
            e.Graphics.DrawLine(myPen, 0, 1329, 560, 1329)
            e.Graphics.DrawLine(myPen, 0, 1341, 560, 1341)






            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 0, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 100, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 135, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 190, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 290, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 325, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 380, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 480, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 515, 6)

            e.Graphics.DrawString("Producto:", prFont2, Brushes.Black, 570, 6)
            e.Graphics.DrawString("Cant:", prFont2, Brushes.Black, 670, 6)
            e.Graphics.DrawString("Precio:", prFont2, Brushes.Black, 705, 6)


            If DataGridView1.Rows.Count > 180 Then

                While i < 110

                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 0, i * 12 + 20)
                e.Graphics.DrawString(DataGridView1.Item(24, i).Value, prFont1, Brushes.Black, 110, i * 12 + 20)
                e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 140, i * 12 + 20)
                    i += 1


                End While


                While i < 220
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 190, i * 12 - 1300)
                e.Graphics.DrawString(DataGridView1.Item(24, i).Value, prFont1, Brushes.Black, 300, i * 12 - 1300)
                e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 330, i * 12 - 1300)
                    i += 1


                End While

                While i < 330
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 380, i * 12 - 2620)
                e.Graphics.DrawString(DataGridView1.Item(24, i).Value, prFont1, Brushes.Black, 490, i * 12 - 2620)
                e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 520, i * 12 - 2620)
                    i += 1


                End While

                While i < DataGridView1.Rows.Count
                    e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont1, Brushes.Black, 570, i * 12 - 3940)
                e.Graphics.DrawString(DataGridView1.Item(24, i).Value, prFont1, Brushes.Black, 680, i * 12 - 3940)
                e.Graphics.DrawString(DataGridView1.Item(23, i).Value, prFont1, Brushes.Black, 710, i * 12 - 3940)
                    i += 1


                End While


            End If


    End Sub
End Class