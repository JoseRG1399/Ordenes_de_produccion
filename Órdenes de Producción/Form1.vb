Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class Form1
    Dim conexion As New OleDbConnection
    Dim conexion1 As New OleDbConnection
    Dim conexion2 As New OleDbConnection
    Dim conexion3 As New OleDbConnection
    Dim conexion4 As New OleDbConnection
    Dim conexion5 As New OleDbConnection
    Dim conexion6 As New OleDbConnection
    Dim conexionSQL As New SqlConnection("Data Source=192.168.100.5;Initial Catalog=Produccion;Persist Security Info=True;User ID=Giuseppe1;Password=123456")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
        'Button12.Visible = False
        TextBox97.Visible = False
        DataGridView1.Visible = False
        DataGridView2.Visible = False
        DataGridView3.Visible = False
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        GroupBox5.Visible = False
        GroupBox6.Visible = False
        GroupBox7.Visible = False
        GroupBox8.Visible = False
        TextBox103.Enabled = False
        Panel2.Visible = True
        DateTimePicker1.Value = DateTime.Today

#Region "Codigo de conexion"

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
#End Region

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Entrada As String
        Entrada = InputBox("Ingrese la Contraseña para continuar", MsgBoxStyle.Information)
        If Entrada = "1548" Then


            TextBox103.Text = "Pastelería 1"
            GroupBox1.Visible = True
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            GroupBox4.Visible = False
            GroupBox5.Visible = False
            GroupBox6.Visible = False
            GroupBox7.Visible = False
            GroupBox8.Visible = False
            GroupBox9.Visible = False

            Try
                Try
                    Dim adaptador As New OleDbDataAdapter
                    Dim tabla As New DataTable
                    Dim buscar As String

                    buscar = ("select *from Orden_producción where Fecha='" & Label3.Text & "' ORDER by Producto")
                    adaptador = New OleDbDataAdapter(buscar, conexion2)
                    tabla = New DataTable
                    adaptador.Fill(tabla)
                    DataGridView2.DataSource = tabla

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Catch ex As Exception

            End Try

            Try

                Try
                    Dim adaptador As New OleDbDataAdapter
                    Dim tabla As New DataTable
                    Dim buscar As String

                    buscar = ("select *from Orden_producción where Fecha='" & Label3.Text & "' ORDER by Producto")
                    adaptador = New OleDbDataAdapter(buscar, conexion6)
                    tabla = New DataTable
                    adaptador.Fill(tabla)
                    DataGridView3.DataSource = tabla

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Catch ex As Exception

            End Try

            Try
                Dim adaptador As New OleDbDataAdapter
                Dim tabla As New DataTable
                Dim buscar As String

                buscar = ("select *from Orden_producción where Fecha='" & Label3.Text & "' ORDER by Producto")
                adaptador = New OleDbDataAdapter(buscar, conexion)
                tabla = New DataTable
                adaptador.Fill(tabla)
                DataGridView1.DataSource = tabla

                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.AllowUserToResizeColumns = False
                DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                DataGridView1.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.DefaultCellStyle.Font = New Font("Arial", 10)

                DataGridView1.Columns(0).Width = 60
                DataGridView1.Columns(1).Width = 300
                DataGridView1.Columns(2).Width = 70

                'añado cada producto a un text box para hacer concentrado

                Dim linea As DataGridViewRow

                For Each linea In DataGridView1.Rows
                    TextBox97.Text = linea.Cells(1).Value

                    'nuevos agregados Giuseppe 5 feb 2023 (4)
                    If TextBox97.Text = "Amante tentacion G" Then
                        TextBox421.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Amante tentacion I" Then
                        TextBox420.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Matilda G" Then
                        TextBox419.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Matilda I" Then
                        TextBox422.Text = linea.Cells(2).Value
                    End If


                    'fin nuevos (4)
                    If TextBox97.Text = "3 L. rompope G" Then
                        TextBox66.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. rompope M" Then
                        TextBox65.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. rompope R" Then
                        TextBox64.Text = linea.Cells(2).Value
                    End If

                    If TextBox97.Text = "Duendes" Then
                        TextBox100.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Marqués" Then
                        TextBox99.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Tronco Navideño" Then
                        TextBox374.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Bipolar G" Then
                        TextBox1.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Bipolar M" Then
                        TextBox2.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Bipolar R" Then
                        TextBox3.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Cajetoso G" Then
                        TextBox6.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Cajetoso M" Then
                        TextBox5.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Cajetoso R" Then
                        TextBox4.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Capuchino G" Then
                        TextBox9.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Capuchino M" Then
                        TextBox8.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Capuchino R" Then
                        TextBox7.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Tricolor G" Then
                        TextBox12.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Tricolor M" Then
                        TextBox11.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Tricolor R" Then
                        TextBox10.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Choconuez G" Then
                        TextBox15.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Choconuez M" Then
                        TextBox14.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Choconuez R" Then
                        TextBox13.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Chocoqueso G" Then
                        TextBox18.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Chocoqueso M" Then
                        TextBox17.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Chocoqueso R" Then
                        TextBox16.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Dominó G" Then
                        TextBox21.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Dominó M" Then
                        TextBox20.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Dominó R" Then
                        TextBox19.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Durazno G" Then
                        TextBox24.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Durazno M" Then
                        TextBox23.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Durazno R" Then
                        TextBox22.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Emperador G" Then
                        TextBox27.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Emperador M" Then
                        TextBox26.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Emperador R" Then
                        TextBox25.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Entremés G" Then
                        TextBox30.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Entremés M" Then
                        TextBox29.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Entremés R" Then
                        TextBox28.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Fresas G" Then
                        TextBox33.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Fresas M" Then
                        TextBox32.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Fresas R" Then
                        TextBox31.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Queso fresa G" Then
                        TextBox36.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Queso fresa M" Then
                        TextBox35.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Queso fresa R" Then
                        TextBox34.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Queso piña G" Then
                        TextBox39.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Queso piña M" Then
                        TextBox38.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Queso piña R" Then
                        TextBox37.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Selva blanca G" Then
                        TextBox42.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Selva blanca M" Then
                        TextBox41.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Selva blanca R" Then
                        TextBox40.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Selva negra G" Then
                        TextBox45.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Selva negra M" Then
                        TextBox44.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Selva negra R" Then
                        TextBox43.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Supremo G" Then
                        TextBox48.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Supremo M" Then
                        TextBox47.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Supremo R" Then
                        TextBox46.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. café G" Then
                        TextBox51.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. café M" Then
                        TextBox50.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. café R" Then
                        TextBox49.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. cajeta G" Then
                        TextBox54.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. cajeta M" Then
                        TextBox53.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. cajeta R" Then
                        TextBox52.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. choco G" Then
                        TextBox57.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. choco M" Then
                        TextBox56.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. choco R" Then
                        TextBox55.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. durazno G" Then
                        TextBox60.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. durazno M" Then
                        TextBox59.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. durazno R" Then
                        TextBox58.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. fresa G" Then
                        TextBox63.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. fresa M" Then
                        TextBox62.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. fresa R" Then
                        TextBox61.Text = linea.Cells(2).Value
                    End If
                    'Mango
                    If TextBox97.Text = "3 L. mango G" Then
                        TextBox1072.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. mango M" Then
                        TextBox1071.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. mango R" Then
                        TextBox1070.Text = linea.Cells(2).Value
                    End If
                    'Fin
                    If TextBox97.Text = "3 L. natural G" Then
                        TextBox66.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. natural M" Then
                        TextBox65.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. natural R" Then
                        TextBox64.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. tequila G" Then
                        TextBox69.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. tequila M" Then
                        TextBox68.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. tequila R" Then
                        TextBox67.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. coco G" Then
                        TextBox72.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. coco M" Then
                        TextBox71.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. coco R" Then
                        TextBox70.Text = linea.Cells(2).Value
                    End If
                    '3 L Bailays
                    If TextBox97.Text = "3 L. Crema Irlan G" Then
                        TextBox405.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "3 L. Crema Irlan M" Then
                        TextBox404.Text = linea.Cells(2).Value
                    End If
                    'Pastel conejo
                    If TextBox97.Text = "Chocolate de leche G" Then
                        TextBox169.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Chocolate de leche M" Then
                        TextBox160.Text = linea.Cells(2).Value
                    End If


                    If TextBox97.Text = "Tartaleta de frutas" Then
                        TextBox77.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Tartaleta de fresa" Then
                        TextBox76.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Multi" Then
                        TextBox92.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Pay queso chocolate" Then
                        TextBox75.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Pay queso fresa" Then
                        TextBox74.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Pay queso zarza" Then
                        TextBox73.Text = linea.Cells(2).Value
                    End If

                    If TextBox97.Text = "Pay queso frutos rojos" Then
                        TextBox779.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Pay queso con uvas" Then
                        TextBox778.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Pay queso zarza G." Then
                        TextBox78.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Pay queso fresa G." Then
                        TextBox79.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Barquillos" Then
                        TextBox91.Text = linea.Cells(2).Value
                        TextBox283.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Truffas" Then
                        TextBox96.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Mil hojas" Then
                        TextBox95.Text = linea.Cells(2).Value
                        TextBox292.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Tarta fresa G." Then
                        TextBox82.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Tarta fruta G." Then
                        TextBox81.Text = linea.Cells(2).Value
                    End If
                Next

                Dim linea2 As DataGridViewRow

                For Each linea2 In DataGridView2.Rows
                    TextBox97.Text = linea2.Cells(1).Value

                    'duendes y marques y Panqué choco ciruclar

                    If TextBox97.Text = "Panqué choco circular" Then
                        TextBox1006.Text = linea2.Cells(2).Value
                    End If

                    If TextBox97.Text = "Panqué de chocolate multi" Then
                        TextBox89.Text = linea2.Cells(2).Value

                    End If
                    If TextBox97.Text = "Panqué de chabacano barra" Then
                        TextBox90.Text = linea2.Cells(2).Value

                    End If
                Next





                'saco totales de 25's
                If TextBox421.Text = "" Then
                    TextBox421.Text = "0"
                End If
                If TextBox422.Text = "" Then
                    TextBox422.Text = "0"
                End If
                If TextBox420.Text = "" Then
                    TextBox420.Text = "0"
                End If
                If TextBox419.Text = "" Then
                    TextBox419.Text = "0"
                End If
                If TextBox1006.Text = "" Then
                    TextBox1006.Text = "0"
                End If
                If TextBox374.Text = "" Then
                    TextBox374.Text = "0"
                End If
                If TextBox1.Text = "" Then
                    TextBox1.Text = "0"
                End If
                If TextBox2.Text = "" Then
                    TextBox2.Text = "0"
                End If
                If TextBox3.Text = "" Then
                    TextBox3.Text = "0"
                End If
                If TextBox4.Text = "" Then
                    TextBox4.Text = "0"
                End If
                If TextBox5.Text = "" Then
                    TextBox5.Text = "0"
                End If
                If TextBox6.Text = "" Then
                    TextBox6.Text = "0"
                End If
                If TextBox7.Text = "" Then
                    TextBox7.Text = "0"
                End If
                If TextBox8.Text = "" Then
                    TextBox8.Text = "0"
                End If
                If TextBox9.Text = "" Then
                    TextBox9.Text = "0"
                End If
                If TextBox10.Text = "" Then
                    TextBox10.Text = "0"
                End If
                If TextBox11.Text = "" Then
                    TextBox11.Text = "0"
                End If
                If TextBox12.Text = "" Then
                    TextBox12.Text = "0"
                End If
                If TextBox13.Text = "" Then
                    TextBox13.Text = "0"
                End If
                If TextBox14.Text = "" Then
                    TextBox14.Text = "0"
                End If
                If TextBox15.Text = "" Then
                    TextBox15.Text = "0"
                End If
                If TextBox16.Text = "" Then
                    TextBox16.Text = "0"
                End If
                If TextBox17.Text = "" Then
                    TextBox17.Text = "0"
                End If
                If TextBox18.Text = "" Then
                    TextBox18.Text = "0"
                End If
                If TextBox19.Text = "" Then
                    TextBox19.Text = "0"
                End If
                If TextBox20.Text = "" Then
                    TextBox20.Text = "0"
                End If
                If TextBox21.Text = "" Then
                    TextBox21.Text = "0"
                End If
                If TextBox22.Text = "" Then
                    TextBox22.Text = "0"
                End If
                If TextBox23.Text = "" Then
                    TextBox23.Text = "0"
                End If
                If TextBox24.Text = "" Then
                    TextBox24.Text = "0"
                End If
                If TextBox25.Text = "" Then
                    TextBox25.Text = "0"
                End If
                If TextBox26.Text = "" Then
                    TextBox26.Text = "0"
                End If
                If TextBox27.Text = "" Then
                    TextBox27.Text = "0"
                End If
                If TextBox28.Text = "" Then
                    TextBox28.Text = "0"
                End If
                If TextBox29.Text = "" Then
                    TextBox29.Text = "0"
                End If
                If TextBox30.Text = "" Then
                    TextBox30.Text = "0"
                End If
                If TextBox31.Text = "" Then
                    TextBox31.Text = "0"
                End If
                If TextBox32.Text = "" Then
                    TextBox32.Text = "0"
                End If
                If TextBox33.Text = "" Then
                    TextBox33.Text = "0"
                End If
                If TextBox34.Text = "" Then
                    TextBox34.Text = "0"
                End If
                If TextBox35.Text = "" Then
                    TextBox35.Text = "0"
                End If
                If TextBox36.Text = "" Then
                    TextBox36.Text = "0"
                End If
                If TextBox37.Text = "" Then
                    TextBox37.Text = "0"
                End If
                If TextBox38.Text = "" Then
                    TextBox38.Text = "0"
                End If
                If TextBox39.Text = "" Then
                    TextBox39.Text = "0"
                End If
                If TextBox40.Text = "" Then
                    TextBox40.Text = "0"
                End If
                If TextBox41.Text = "" Then
                    TextBox41.Text = "0"
                End If
                If TextBox42.Text = "" Then
                    TextBox42.Text = "0"
                End If
                If TextBox43.Text = "" Then
                    TextBox43.Text = "0"
                End If
                If TextBox44.Text = "" Then
                    TextBox44.Text = "0"
                End If
                If TextBox45.Text = "" Then
                    TextBox45.Text = "0"
                End If
                If TextBox46.Text = "" Then
                    TextBox46.Text = "0"
                End If
                If TextBox47.Text = "" Then
                    TextBox47.Text = "0"
                End If
                If TextBox48.Text = "" Then
                    TextBox48.Text = "0"
                End If
                If TextBox49.Text = "" Then
                    TextBox49.Text = "0"
                End If
                If TextBox50.Text = "" Then
                    TextBox50.Text = "0"
                End If
                If TextBox51.Text = "" Then
                    TextBox51.Text = "0"
                End If
                If TextBox52.Text = "" Then
                    TextBox52.Text = "0"
                End If
                If TextBox53.Text = "" Then
                    TextBox53.Text = "0"
                End If
                If TextBox54.Text = "" Then
                    TextBox54.Text = "0"
                End If
                If TextBox55.Text = "" Then
                    TextBox55.Text = "0"
                End If
                If TextBox56.Text = "" Then
                    TextBox56.Text = "0"
                End If
                If TextBox57.Text = "" Then
                    TextBox57.Text = "0"
                End If
                If TextBox58.Text = "" Then
                    TextBox58.Text = "0"
                End If
                If TextBox59.Text = "" Then
                    TextBox59.Text = "0"
                End If
                If TextBox60.Text = "" Then
                    TextBox60.Text = "0"
                End If
                If TextBox61.Text = "" Then
                    TextBox61.Text = "0"
                End If
                If TextBox62.Text = "" Then
                    TextBox62.Text = "0"
                End If
                If TextBox63.Text = "" Then
                    TextBox63.Text = "0"
                End If
                If TextBox64.Text = "" Then
                    TextBox64.Text = "0"
                End If
                If TextBox65.Text = "" Then
                    TextBox65.Text = "0"
                End If
                If TextBox66.Text = "" Then
                    TextBox66.Text = "0"
                End If
                If TextBox67.Text = "" Then
                    TextBox67.Text = "0"
                End If
                If TextBox68.Text = "" Then
                    TextBox68.Text = "0"
                End If
                If TextBox69.Text = "" Then
                    TextBox69.Text = "0"
                End If
                If TextBox70.Text = "" Then
                    TextBox70.Text = "0"
                End If
                If TextBox71.Text = "" Then
                    TextBox71.Text = "0"
                End If
                If TextBox72.Text = "" Then
                    TextBox72.Text = "0"
                End If
                If TextBox76.Text = "" Then
                    TextBox76.Text = "0"
                End If
                If TextBox77.Text = "" Then
                    TextBox77.Text = "0"
                End If
                If TextBox92.Text = "" Then
                    TextBox92.Text = "0"
                End If
                If TextBox75.Text = "" Then
                    TextBox75.Text = "0"
                End If
                If TextBox74.Text = "" Then
                    TextBox74.Text = "0"
                End If
                If TextBox73.Text = "" Then
                    TextBox73.Text = "0"
                End If
                If TextBox79.Text = "" Then
                    TextBox79.Text = "0"
                End If
                If TextBox78.Text = "" Then
                    TextBox78.Text = "0"
                End If
                If TextBox91.Text = "" Then
                    TextBox91.Text = "0"
                End If
                If TextBox96.Text = "" Then
                    TextBox96.Text = "0"
                End If
                If TextBox95.Text = "" Then
                    TextBox95.Text = "0"
                End If

                If TextBox89.Text = "" Then
                    TextBox89.Text = "0"
                End If
                If TextBox90.Text = "" Then
                    TextBox90.Text = "0"
                End If
                If TextBox99.Text = "" Then
                    TextBox99.Text = "0"
                End If
                If TextBox100.Text = "" Then
                    TextBox100.Text = "0"
                End If
                If TextBox82.Text = "" Then
                    TextBox82.Text = "0"
                End If
                If TextBox81.Text = "" Then
                    TextBox81.Text = "0"
                End If

                If TextBox1070.Text = "" Then
                    TextBox1070.Text = "0"
                End If
                If TextBox1071.Text = "" Then
                    TextBox1071.Text = "0"
                End If
                Try
                    TextBox102.Text = CDec(TextBox1.Text) + CDec(TextBox6.Text) + CDec(TextBox9.Text) + CDec(TextBox12.Text) + CDec(TextBox15.Text) + CDec(TextBox18.Text) + CDec(TextBox21.Text) + CDec(TextBox24.Text) + CDec(TextBox27.Text) + CDec(TextBox30.Text) + CDec(TextBox33.Text) + CDec(TextBox36.Text) + CDec(TextBox39.Text) + CDec(TextBox42.Text) + CDec(TextBox45.Text) + CDec(TextBox48.Text) + CDec(TextBox51.Text) + CDec(TextBox54.Text) + CDec(TextBox57.Text) + CDec(TextBox60.Text) + CDec(TextBox63.Text) + CDec(TextBox1072.Text) + CDec(TextBox66.Text) + CDec(TextBox69.Text) + CDec(TextBox72.Text) + CDec(TextBox405.Text)
                Catch ex As Exception

                End Try

                Try
                    TextBox101.Text = CDec(TextBox2.Text) + CDec(TextBox5.Text) + CDec(TextBox8.Text) + CDec(TextBox11.Text) + CDec(TextBox14.Text) + CDec(TextBox17.Text) + CDec(TextBox20.Text) + CDec(TextBox23.Text) + CDec(TextBox26.Text) + CDec(TextBox29.Text) + CDec(TextBox32.Text) + CDec(TextBox35.Text) + CDec(TextBox38.Text) + CDec(TextBox41.Text) + CDec(TextBox44.Text) + CDec(TextBox47.Text) + CDec(TextBox50.Text) + CDec(TextBox53.Text) + CDec(TextBox56.Text) + CDec(TextBox59.Text) + CDec(TextBox62.Text) + CDec(TextBox1071.Text) + CDec(TextBox65.Text) + CDec(TextBox68.Text) + CDec(TextBox71.Text) + CDec(TextBox404.Text)
                Catch ex As Exception

                End Try

                Try
                    TextBox98.Text = CDec(TextBox3.Text) + CDec(TextBox4.Text) + CDec(TextBox7.Text) + CDec(TextBox10.Text) + CDec(TextBox13.Text) + CDec(TextBox16.Text) + CDec(TextBox19.Text) + CDec(TextBox22.Text) + CDec(TextBox25.Text) + CDec(TextBox28.Text) + CDec(TextBox31.Text) + CDec(TextBox34.Text) + CDec(TextBox37.Text) + CDec(TextBox40.Text) + CDec(TextBox43.Text) + CDec(TextBox46.Text) + CDec(TextBox49.Text) + CDec(TextBox52.Text) + CDec(TextBox55.Text) + CDec(TextBox58.Text) + CDec(TextBox61.Text) + CDec(TextBox1070.Text) + CDec(TextBox64.Text) + CDec(TextBox67.Text) + CDec(TextBox70.Text) + CDec(TextBox403.Text)
                Catch ex As Exception

                End Try
                GroupBox1.Visible = True
                GroupBox3.Visible = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Acceso Denegado", MsgBoxStyle.Information, "CLAVE INCORRECTA")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = DateTime.Today
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label4.Text = TimeString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Entrada As String
        Entrada = InputBox("Ingrese la Contraseña para continuar", MsgBoxStyle.Information)
        If Entrada = "1144" Then


            TextBox103.Text = "Pastelería 2"
            GroupBox1.Visible = False
            GroupBox2.Visible = False
            GroupBox3.Visible = True
            GroupBox4.Visible = False
            GroupBox5.Visible = False
            GroupBox6.Visible = False
            GroupBox7.Visible = False
            GroupBox8.Visible = False
            GroupBox9.Visible = False
            Try
                Dim adaptador As New OleDbDataAdapter
                Dim tabla As New DataTable
                Dim buscar As String

                buscar = ("select *from Orden_producción where Fecha='" & Label3.Text & "' ORDER by Producto")
                adaptador = New OleDbDataAdapter(buscar, conexion)
                tabla = New DataTable
                adaptador.Fill(tabla)
                DataGridView1.DataSource = tabla

                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.AllowUserToResizeColumns = False
                DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                DataGridView1.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.DefaultCellStyle.Font = New Font("Arial", 10)

                DataGridView1.Columns(0).Width = 60
                DataGridView1.Columns(1).Width = 300
                DataGridView1.Columns(2).Width = 70

                'añado cada producto a un text box para hacer concentrado

                Dim linea As DataGridViewRow

                For Each linea In DataGridView1.Rows
                    TextBox97.Text = linea.Cells(1).Value

                    If TextBox97.Text = "Opera G" Then
                        TextBox373.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Opera I" Then
                        TextBox372.Text = linea.Cells(2).Value

                    End If

                Next

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                Dim adaptador As New OleDbDataAdapter
                Dim tabla As New DataTable
                Dim buscar As String

                buscar = ("select *from Orden_producción where Fecha='" & Label3.Text & "' ORDER by Producto")
                adaptador = New OleDbDataAdapter(buscar, conexion1)
                tabla = New DataTable
                adaptador.Fill(tabla)
                DataGridView1.DataSource = tabla

                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.AllowUserToResizeColumns = False
                DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                DataGridView1.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.DefaultCellStyle.Font = New Font("Arial", 10)

                DataGridView1.Columns(0).Width = 60
                DataGridView1.Columns(1).Width = 300
                DataGridView1.Columns(2).Width = 70

                'añado cada producto a un text box para hacer concentrado

                Dim linea As DataGridViewRow

                For Each linea In DataGridView1.Rows
                    TextBox97.Text = linea.Cells(1).Value

                    If TextBox97.Text = "Carlota G" Then
                        TextBox197.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Coco coco G" Then
                        TextBox194.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Chocomenta G" Then
                        TextBox191.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Exótico G" Then
                        TextBox188.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Sol y sombra G" Then
                        TextBox185.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Truffé G" Then
                        TextBox182.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Zucotto G" Then
                        TextBox179.Text = linea.Cells(2).Value

                    End If


                    If TextBox97.Text = "Carlota M" Then
                        TextBox196.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Coco-coco M" Then
                        TextBox193.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Chocomenta M" Then
                        TextBox190.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Exótico M" Then
                        TextBox187.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Sol y sombra M" Then
                        TextBox184.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Truffé M" Then
                        TextBox181.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Zucotto M" Then
                        TextBox178.Text = linea.Cells(2).Value

                    End If


                    If TextBox97.Text = "Carlota R" Then
                        TextBox195.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Coco-coco R" Then
                        TextBox192.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Chocomenta R" Then
                        TextBox189.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Exótico R" Then
                        TextBox186.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Sol y sombra R" Then
                        TextBox183.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Truffé R" Then
                        TextBox180.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Zucotto R" Then
                        TextBox177.Text = linea.Cells(2).Value

                    End If


                    If TextBox97.Text = "Durazno CL" Then
                        TextBox142.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Fresas CL" Then
                        TextBox139.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Capuchino CL" Then
                        TextBox136.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Dominó CL" Then
                        TextBox133.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Chocoqueso CE" Then
                        TextBox131.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Emperador CE" Then
                        TextBox130.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Supremo CE" Then
                        TextBox128.Text = linea.Cells(2).Value

                    End If

                    'linea de minis
                    'Se agrega Tricolor I - 24/10/2019
                    If TextBox97.Text = "Tricolor I" Then
                        TextBox1037.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Cajetoso I" Then
                        TextBox173.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Capuchino I" Then
                        TextBox170.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Carlota I" Then
                        TextBox167.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Choconuez I" Then
                        TextBox164.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Chocoqueso I" Then
                        TextBox161.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Chocomenta I" Then
                        TextBox158.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Coco-coco I" Then
                        TextBox155.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Dominó I" Then
                        TextBox152.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Duraznos I" Then
                        TextBox149.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Emperador I" Then
                        TextBox146.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Entremés I" Then
                        TextBox143.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Exótico I" Then
                        TextBox140.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Fresas I" Then
                        TextBox137.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Queso fresa I" Then
                        TextBox134.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Queso piña I" Then
                        TextBox174.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Selva blanca I" Then
                        TextBox171.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Selva negra I" Then
                        TextBox168.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Sol y sombra I" Then
                        TextBox165.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Supremo I" Then
                        TextBox162.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "3 L. café I" Then
                        TextBox159.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "3 L. cajeta I" Then
                        TextBox156.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "3 L. choco I" Then
                        TextBox153.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "3 L. durazno I" Then
                        TextBox150.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "3 L. fresa I" Then
                        TextBox147.Text = linea.Cells(2).Value

                    End If
                    'Mango
                    If TextBox97.Text = "3 L. mango I" Then
                        TextBox1075.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "3 L. rompope I" Then
                        TextBox144.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "3 L. tequila I" Then
                        TextBox141.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Truffé I" Then
                        TextBox135.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Zucotto I" Then
                        TextBox132.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "3 L. Crema Irlan I" Then
                        TextBox396.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Chocolate de leche I" Then
                        TextBox206.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "3 L. coco I" Then
                        TextBox138.Text = linea.Cells(2).Value

                    End If

                Next
                'saco totales

                If TextBox197.Text = "" Then
                    TextBox197.Text = "0"
                End If
                If TextBox194.Text = "" Then
                    TextBox194.Text = "0"
                End If
                If TextBox191.Text = "" Then
                    TextBox191.Text = "0"
                End If
                If TextBox188.Text = "" Then
                    TextBox188.Text = "0"
                End If
                If TextBox185.Text = "" Then
                    TextBox185.Text = "0"
                End If
                If TextBox182.Text = "" Then
                    TextBox182.Text = "0"
                End If
                If TextBox179.Text = "" Then
                    TextBox179.Text = "0"
                End If


                If TextBox196.Text = "" Then
                    TextBox196.Text = "0"
                End If
                If TextBox193.Text = "" Then
                    TextBox193.Text = "0"
                End If
                If TextBox190.Text = "" Then
                    TextBox190.Text = "0"
                End If
                If TextBox187.Text = "" Then
                    TextBox187.Text = "0"
                End If
                If TextBox184.Text = "" Then
                    TextBox184.Text = "0"
                End If
                If TextBox181.Text = "" Then
                    TextBox181.Text = "0"
                End If
                If TextBox178.Text = "" Then
                    TextBox178.Text = "0"
                End If


                If TextBox195.Text = "" Then
                    TextBox195.Text = "0"
                End If
                If TextBox192.Text = "" Then
                    TextBox192.Text = "0"
                End If
                If TextBox189.Text = "" Then
                    TextBox189.Text = "0"
                End If
                If TextBox186.Text = "" Then
                    TextBox186.Text = "0"
                End If
                If TextBox183.Text = "" Then
                    TextBox183.Text = "0"
                End If
                If TextBox180.Text = "" Then
                    TextBox180.Text = "0"
                End If
                If TextBox177.Text = "" Then
                    TextBox177.Text = "0"
                End If


                If TextBox142.Text = "" Then
                    TextBox142.Text = "0"
                End If
                If TextBox139.Text = "" Then
                    TextBox139.Text = "0"
                End If
                If TextBox136.Text = "" Then
                    TextBox136.Text = "0"
                End If
                If TextBox133.Text = "" Then
                    TextBox133.Text = "0"
                End If
                If TextBox131.Text = "" Then
                    TextBox131.Text = "0"
                End If
                If TextBox130.Text = "" Then
                    TextBox130.Text = "0"
                End If
                If TextBox128.Text = "" Then
                    TextBox128.Text = "0"
                End If

                If TextBox173.Text = "" Then
                    TextBox173.Text = "0"
                End If
                If TextBox170.Text = "" Then
                    TextBox170.Text = "0"
                End If
                If TextBox167.Text = "" Then
                    TextBox167.Text = "0"
                End If
                If TextBox164.Text = "" Then
                    TextBox164.Text = "0"
                End If
                If TextBox161.Text = "" Then
                    TextBox161.Text = "0"
                End If
                If TextBox158.Text = "" Then
                    TextBox158.Text = "0"
                End If
                If TextBox155.Text = "" Then
                    TextBox155.Text = "0"
                End If
                If TextBox152.Text = "" Then
                    TextBox152.Text = "0"
                End If
                If TextBox149.Text = "" Then
                    TextBox149.Text = "0"
                End If
                If TextBox146.Text = "" Then
                    TextBox146.Text = "0"
                End If
                If TextBox143.Text = "" Then
                    TextBox143.Text = "0"
                End If
                If TextBox140.Text = "" Then
                    TextBox140.Text = "0"
                End If
                If TextBox137.Text = "" Then
                    TextBox137.Text = "0"
                End If
                If TextBox134.Text = "" Then
                    TextBox134.Text = "0"
                End If
                If TextBox174.Text = "" Then
                    TextBox174.Text = "0"
                End If
                If TextBox171.Text = "" Then
                    TextBox171.Text = "0"
                End If
                If TextBox168.Text = "" Then
                    TextBox168.Text = "0"
                End If
                If TextBox165.Text = "" Then
                    TextBox165.Text = "0"
                End If
                If TextBox162.Text = "" Then
                    TextBox162.Text = "0"
                End If
                If TextBox159.Text = "" Then
                    TextBox159.Text = "0"
                End If
                If TextBox156.Text = "" Then
                    TextBox156.Text = "0"
                End If
                If TextBox153.Text = "" Then
                    TextBox153.Text = "0"
                End If
                If TextBox150.Text = "" Then
                    TextBox150.Text = "0"
                End If
                If TextBox147.Text = "" Then
                    TextBox147.Text = "0"
                End If
                If TextBox144.Text = "" Then
                    TextBox144.Text = "0"
                End If
                If TextBox141.Text = "" Then
                    TextBox141.Text = "0"
                End If
                If TextBox138.Text = "" Then
                    TextBox138.Text = "0"
                End If
                If TextBox135.Text = "" Then
                    TextBox135.Text = "0"
                End If
                If TextBox132.Text = "" Then
                    TextBox132.Text = "0"
                End If

                'total por columnas

                Try
                    TextBox106.Text = CDec(TextBox197.Text) + CDec(TextBox194.Text) + CDec(TextBox191.Text) + CDec(TextBox188.Text) + CDec(TextBox185.Text) + CDec(TextBox182.Text) + CDec(TextBox179.Text)

                Catch ex As Exception

                End Try

                Try
                    TextBox105.Text = CDec(TextBox196.Text) + CDec(TextBox193.Text) + CDec(TextBox190.Text) + CDec(TextBox187.Text) + CDec(TextBox184.Text) + CDec(TextBox181.Text) + CDec(TextBox178.Text)

                Catch ex As Exception

                End Try

                Try
                    TextBox104.Text = CDec(TextBox195.Text) + CDec(TextBox192.Text) + CDec(TextBox189.Text) + CDec(TextBox186.Text) + CDec(TextBox183.Text) + CDec(TextBox180.Text) + CDec(TextBox177.Text)

                Catch ex As Exception

                End Try

                Try
                    TextBox127.Text = CDec(TextBox142.Text) + CDec(TextBox139.Text) + CDec(TextBox136.Text) + CDec(TextBox133.Text) + CDec(TextBox131.Text) + CDec(TextBox130.Text) + CDec(TextBox128.Text)

                Catch ex As Exception

                End Try

                Try
                    TextBox129.Text = CDec(TextBox173.Text) + CDec(TextBox170.Text) + CDec(TextBox167.Text) + CDec(TextBox164.Text) + CDec(TextBox161.Text) + CDec(TextBox158.Text) + CDec(TextBox155.Text) + CDec(TextBox152.Text) + CDec(TextBox149.Text) + CDec(TextBox146.Text) + CDec(TextBox140.Text) + CDec(TextBox137.Text) + CDec(TextBox134.Text) + CDec(TextBox1037.Text)

                Catch ex As Exception

                End Try


                Try
                    TextBox800.Text = CDec(TextBox174.Text) + CDec(TextBox171.Text) + CDec(TextBox168.Text) + CDec(TextBox165.Text) + CDec(TextBox162.Text) + CDec(TextBox159.Text) + CDec(TextBox156.Text) + CDec(TextBox153.Text) + CDec(TextBox150.Text) + CDec(TextBox147.Text) + CDec(TextBox1075.Text) + CDec(TextBox144.Text) + CDec(TextBox141.Text) + CDec(TextBox138.Text) + CDec(TextBox135.Text) + CDec(TextBox132.Text) + CDec(TextBox396.Text)

                Catch ex As Exception

                End Try

                Try
                    TextBox127.Text = CDec(TextBox142.Text) + CDec(TextBox139.Text) + CDec(TextBox136.Text) + CDec(TextBox133.Text) + CDec(TextBox131.Text) + CDec(TextBox130.Text) + CDec(TextBox128.Text)
                Catch ex As Exception

                End Try

                Try
                    TextBox375.Text = CDec(TextBox243.Text) + CDec(TextBox239.Text) + CDec(TextBox214.Text) + CDec(TextBox211.Text)
                Catch ex As Exception

                End Try

            Catch ex As Exception

            End Try

            Try
                Dim adaptador As New OleDbDataAdapter
                Dim tabla As New DataTable
                Dim buscar As String

                buscar = ("select *from Orden_producción where Fecha='" & Label3.Text & "' ORDER by Producto")
                adaptador = New OleDbDataAdapter(buscar, conexion)
                tabla = New DataTable
                adaptador.Fill(tabla)
                DataGridView1.DataSource = tabla

                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.AllowUserToResizeColumns = False
                DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                DataGridView1.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.DefaultCellStyle.Font = New Font("Arial", 10)

                DataGridView1.Columns(0).Width = 60
                DataGridView1.Columns(1).Width = 300
                DataGridView1.Columns(2).Width = 70

                'añado cada producto a un text box para hacer concentrado

                Dim linea As DataGridViewRow

                For Each linea In DataGridView1.Rows
                    TextBox97.Text = linea.Cells(1).Value

                    If TextBox97.Text = "Durazno CL R" Then
                        TextBox243.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Fresas CL R" Then
                        TextBox239.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Capuchino CL R" Then
                        TextBox214.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Dominó CL R" Then
                        TextBox211.Text = linea.Cells(2).Value

                    End If
                Next
                'saco totales
                If TextBox243.Text = "" Then
                    TextBox243.Text = "0"
                End If
                If TextBox239.Text = "" Then
                    TextBox239.Text = "0"
                End If
                If TextBox214.Text = "" Then
                    TextBox214.Text = "0"
                End If
                If TextBox211.Text = "" Then
                    TextBox211.Text = "0"
                End If

                'totales por columna

                Try
                    TextBox375.Text = CDec(TextBox243.Text) + CDec(TextBox239.Text) + CDec(TextBox214.Text) + CDec(TextBox211.Text)
                Catch ex As Exception

                End Try

            Catch ex As Exception

            End Try

        Else
            MsgBox("Acceso Denegado", MsgBoxStyle.Information, "CLAVE INCORRECTA")

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim Entrada As String
        Entrada = InputBox("Ingrese la Contraseña para continuar", MsgBoxStyle.Information)
        If Entrada = "1122" Then

            TextBox103.Text = "Batidos"
            GroupBox1.Visible = False
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            GroupBox4.Visible = True
            GroupBox5.Visible = False
            GroupBox6.Visible = False
            GroupBox7.Visible = False
            GroupBox8.Visible = False
            GroupBox9.Visible = False

            Try
                Dim adaptador As New OleDbDataAdapter
                Dim tabla As New DataTable
                Dim buscar As String

                buscar = ("select *from Orden_producción where Fecha='" & Label3.Text & "' ORDER by Producto")
                adaptador = New OleDbDataAdapter(buscar, conexion4)
                tabla = New DataTable
                adaptador.Fill(tabla)
                DataGridView1.DataSource = tabla

                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.AllowUserToResizeColumns = False
                DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                DataGridView1.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.DefaultCellStyle.Font = New Font("Arial", 10)

                DataGridView1.Columns(0).Width = 60
                DataGridView1.Columns(1).Width = 300
                DataGridView1.Columns(2).Width = 70

                'añado cada producto a un text box para hacer concentrado

                Dim linea As DataGridViewRow

                For Each linea In DataGridView1.Rows
                    TextBox97.Text = linea.Cells(1).Value

                    If TextBox97.Text = "Brownie" Then
                        TextBox108.Text = linea.Cells(2).Value

                    End If
                    'Aquí agregamos 3 panqués nuevos: Tamarindo, blueberry y manzana

                    If TextBox97.Text = "Panqué blueberry" Then
                        txtPanqueBlueberry.Text = linea.Cells(2).Value
                    End If

                    'Aquí termina 

                Next

            Catch ex As Exception

            End Try

            Try

                Dim adaptador As New OleDbDataAdapter
                Dim tabla As New DataTable
                Dim buscar As String

                buscar = ("select *from Orden_producción where Fecha='" & Label3.Text & "' ORDER by Producto")
                adaptador = New OleDbDataAdapter(buscar, conexion2)
                tabla = New DataTable
                adaptador.Fill(tabla)
                DataGridView1.DataSource = tabla

                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.AllowUserToResizeColumns = False
                DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                DataGridView1.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.DefaultCellStyle.Font = New Font("Arial", 10)


                DataGridView1.Columns(0).Width = 60
                DataGridView1.Columns(1).Width = 300
                DataGridView1.Columns(2).Width = 70

                'añado cada producto a un text box para hacer concentrado

                Dim linea As DataGridViewRow

                For Each linea In DataGridView1.Rows
                    TextBox97.Text = linea.Cells(1).Value
                    'Nuevos

                    If TextBox97.Text = "Panqué coco individual" Then
                        txtCocoIndividual.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Panqué choco circular" Then
                        TextBox985.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Panqué limón circular" Then
                        TextBox991.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Panqué coco circular" Then
                        TextBox988.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Panqué plátano circular" Then
                        TextBox1078.Text = linea.Cells(2).Value

                    End If
                    'Aqui agregamos el pedido del panque de blueberry   Panqué blueberry

                    If TextBox97.Text = "Panqué blueberry" Then
                        txtPanqueBlueberry.Text = linea.Cells(2).Value

                    End If



                    '******
                    If TextBox97.Text = "Chino" Then
                        TextBox231.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Minirosquita Janeth" Then
                        TextBox225.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Minirosquita nuez" Then
                        TextBox222.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Panque de higo circular" Then
                        TextBox109.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Panqué de naranja circular" Then
                        TextBox114.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Panqué de nuez circular" Then
                        TextBox113.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Volteado circular" Then
                        TextBox112.Text = linea.Cells(2).Value

                    End If


                    If TextBox97.Text = "Panqué de nata circular" Then
                        TextBox120.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Panqué elote individual" Then
                        TextBox124.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Panqué de zanahoria" Then
                        TextBox123.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Panqué elote circular" Then
                        TextBox151.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Panqué de zanahoria circular" Then
                        TextBox148.Text = linea.Cells(2).Value

                    End If
                    '****** Nuevos panques individuales
                    If TextBox97.Text = "Panqué limón individual" Then
                        TextBox1087.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Panqué naranja individual" Then
                        TextBox1090.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Panqué plátano individual" Then
                        TextBox1093.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Panqué nata individual" Then
                        TextBox1096.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Panqué blueberry ind" Then
                        txtBlueberryInd.Text = linea.Cells(2).Value

                    End If
                Next

                'totales
                If txtCocoIndividual.Text = "" Then
                    txtCocoIndividual.Text = "0"
                End If
                If txtPanqueBlueberry.Text = "" Then
                    txtPanqueBlueberry.Text = "0"
                End If
                If TextBox231.Text = "" Then
                    TextBox231.Text = "0"
                End If
                If TextBox225.Text = "" Then
                    TextBox225.Text = "0"
                End If

                If TextBox222.Text = "" Then
                    TextBox222.Text = "0"
                End If

                If TextBox109.Text = "" Then
                    TextBox109.Text = "0"
                End If

                If TextBox114.Text = "" Then
                    TextBox114.Text = "0"
                End If

                If TextBox113.Text = "" Then
                    TextBox113.Text = "0"
                End If

                If TextBox112.Text = "" Then
                    TextBox112.Text = "0"
                End If

                If TextBox120.Text = "" Then
                    TextBox120.Text = "0"
                End If

                If TextBox124.Text = "" Then
                    TextBox124.Text = "0"
                End If
                If TextBox123.Text = "" Then
                    TextBox123.Text = "0"
                End If
                If TextBox151.Text = "" Then
                    TextBox151.Text = "0"
                End If
                If TextBox148.Text = "" Then
                    TextBox148.Text = "0"
                End If
                'Panque individual
                If TextBox1087.Text = "" Then
                    TextBox1087.Text = "0"
                End If
                If TextBox1090.Text = "" Then
                    TextBox1090.Text = "0"
                End If
                If TextBox1093.Text = "" Then
                    TextBox1093.Text = "0"
                End If
                If TextBox1096.Text = "" Then
                    TextBox1096.Text = "0"
                End If
                If txtBlueberryInd.Text = "" Then
                    txtBlueberryInd.Text = "0"
                End If

                'total por columnas

                Try
                    TextBox325.Text = CDec(TextBox120.Text) + CDec(TextBox985.Text) + CDec(TextBox991.Text) + CDec(TextBox988.Text) + CDec(TextBox1078.Text) + CDec(TextBox114.Text) + CDec(TextBox113.Text) + CDec(TextBox151.Text) + CDec(TextBox148.Text) + CDec(TextBox109.Text) + CDec(TextBox112.Text)

                Catch ex As Exception

                End Try

                Try
                    TextBox349.Text = CDec(TextBox124.Text) + CDec(TextBox123.Text) + CDec(TextBox1087.Text) + CDec(TextBox1090.Text) + CDec(TextBox1093.Text) + CDec(TextBox1096.Text) + CDec(txtCocoIndividual.Text)

                Catch ex As Exception

                End Try

            Catch ex As Exception
            End Try
        Else
            MsgBox("Acceso Denegado", MsgBoxStyle.Information, "CLAVE INCORRECTA")

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Entrada As String
        Entrada = InputBox("Ingrese la Contraseña para continuar", MsgBoxStyle.Information)
        If Entrada = "87103" Then

            'If TextBox367.Text <> "Panaderia" Then
            '    MsgBox("Primero da clic en el departamento de Panadería, para traer los datos de las empanadas.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
            '    Exit Sub
            'End If

            TextBox103.Text = "Cremosos"
            GroupBox1.Visible = False
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            GroupBox4.Visible = False
            GroupBox5.Visible = True
            GroupBox6.Visible = False
            GroupBox7.Visible = False
            GroupBox8.Visible = False
            GroupBox9.Visible = False

            Try
                TextBox209.Text = TextBox282.Text
                TextBox207.Text = TextBox281.Text
                TextBox200.Text = TextBox280.Text
                TextBox198.Text = TextBox279.Text

            Catch ex As Exception

            End Try

            Try
                Dim adaptador As New OleDbDataAdapter
                Dim tabla As New DataTable
                Dim buscar As String

                buscar = ("select *from Orden_producción where Fecha='" & Label3.Text & "' ORDER by Producto")
                adaptador = New OleDbDataAdapter(buscar, conexion)
                tabla = New DataTable
                adaptador.Fill(tabla)
                DataGridView1.DataSource = tabla

                'añado cada producto a un text box para hacer concentrado

                Dim linea As DataGridViewRow

                For Each linea In DataGridView1.Rows
                    TextBox97.Text = linea.Cells(1).Value

                    If TextBox97.Text = "Pay limon G." Then
                        TextBox117.Text = linea.Cells(2).Value
                    End If

                Next

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                Dim adaptador As New OleDbDataAdapter
                Dim tabla As New DataTable
                Dim buscar As String

                buscar = ("select *from Orden_producción where Fecha='" & Label3.Text & "' ORDER by Producto")
                adaptador = New OleDbDataAdapter(buscar, conexion4)
                tabla = New DataTable
                adaptador.Fill(tabla)
                DataGridView1.DataSource = tabla

                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.AllowUserToResizeColumns = False
                DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                DataGridView1.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.DefaultCellStyle.Font = New Font("Arial", 10)

                DataGridView1.Columns(0).Width = 60
                DataGridView1.Columns(1).Width = 300
                DataGridView1.Columns(2).Width = 70

                For Each linea In DataGridView1.Rows
                    TextBox97.Text = linea.Cells(1).Value

                    If TextBox97.Text = "Flan individual" Then
                        txtFlanIndividual.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Arroz con leche" Then
                        txtArrozConLeche.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Buñuelos 3 piezas" Then
                        txtBunuelos.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Brownie" Then
                        TextBox108.Text = linea.Cells(2).Value

                    End If
                Next


            Catch ex As Exception
                MsgBox(ex.Message & "Errror al obtener el pedido de flanes")
            End Try



            Try
                Dim adaptador As New OleDbDataAdapter
                Dim tabla As New DataTable
                Dim buscar As String

                buscar = ("select *from Orden_producción where Fecha='" & Label3.Text & "' ORDER by Producto")
                adaptador = New OleDbDataAdapter(buscar, conexion3)
                tabla = New DataTable
                adaptador.Fill(tabla)
                DataGridView1.DataSource = tabla

                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.AllowUserToResizeColumns = False
                DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                DataGridView1.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.DefaultCellStyle.Font = New Font("Arial", 10)

                DataGridView1.Columns(0).Width = 60
                DataGridView1.Columns(1).Width = 300
                DataGridView1.Columns(2).Width = 70

                'añado cada producto a un text box para hacer concentrado

                Dim linea As DataGridViewRow

                For Each linea In DataGridView1.Rows
                    TextBox97.Text = linea.Cells(1).Value
                    'Aqui agregamosal chessecake blueberry
                    If TextBox97.Text = "Chessecake Blueberry" Then
                        txtChesscakeBlueberry.Text = linea.Cells(2).Value

                    End If


                    If TextBox97.Text = "Guayaba G" Then
                        TextBox217.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Guayaba M" Then
                        TextBox163.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Guayaba I" Then
                        TextBox175.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Guayaba R" Then
                        TextBox218.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Emp. de atún" Then
                        TextBox209.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Emp. de jamón" Then
                        TextBox207.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Emp. de rajas" Then
                        TextBox200.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Emp. de tinga" Then
                        TextBox198.Text = linea.Cells(2).Value

                    End If



                Next

                'totales
                'Chesecake blueberry
                If txtChesscakeBlueberry.Text = "" Then
                    txtChesscakeBlueberry.Text = "0"
                End If
                'Zanahoria grande
                If TextBox1051.Text = "" Then
                    TextBox1051.Text = "0"
                End If

                If TextBox447.Text = "" Then
                    TextBox447.Text = "0"
                End If
                If TextBox445.Text = "" Then
                    TextBox445.Text = "0"
                End If
                If TextBox444.Text = "" Then
                    TextBox444.Text = "0"
                End If
                If TextBox217.Text = "" Then
                    TextBox217.Text = "0"
                End If
                If TextBox163.Text = "" Then
                    TextBox163.Text = "0"
                End If
                If TextBox154.Text = "" Then
                    TextBox154.Text = "0"
                End If
                If TextBox175.Text = "" Then
                    TextBox175.Text = "0"
                End If
                If TextBox218.Text = "" Then
                    TextBox218.Text = "0"
                End If
                If TextBox209.Text = "" Then
                    TextBox209.Text = "0"
                End If
                If TextBox207.Text = "" Then
                    TextBox207.Text = "0"
                End If
                If TextBox200.Text = "" Then
                    TextBox200.Text = "0"
                End If

                If TextBox198.Text = "" Then
                    TextBox198.Text = "0"
                End If

                '------------Napolitanos dados de baja
                'If TextBox352.Text = "" Then
                '    TextBox352.Text = "0"
                'End If
                'If TextBox351.Text = "" Then
                '    TextBox351.Text = "0"
                'End If



                'total por columnas

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Acceso Denegado", MsgBoxStyle.Information, "CLAVE INCORRECTA")

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Entrada As String
        Entrada = InputBox("Ingrese la Contraseña para continuar", MsgBoxStyle.Information)
        If Entrada = "49215" Then


            TextBox103.Text = "Flanes y arroz"
            GroupBox1.Visible = False
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            GroupBox4.Visible = False
            GroupBox5.Visible = False
            GroupBox6.Visible = False
            GroupBox7.Visible = True
            GroupBox8.Visible = False
            GroupBox9.Visible = False


            Try
                Dim adaptador As New OleDbDataAdapter
                Dim tabla As New DataTable
                Dim buscar As String

                buscar = ("select *from Orden_producción where Fecha='" & Label3.Text & "' ORDER by Producto")
                adaptador = New OleDbDataAdapter(buscar, conexion3)
                tabla = New DataTable
                adaptador.Fill(tabla)
                DataGridView1.DataSource = tabla

                'añado cada producto a un text box para hacer concentrado

                Dim linea As DataGridViewRow

                For Each linea In DataGridView1.Rows
                    TextBox97.Text = linea.Cells(1).Value


                    '3 nuevos de giuseppe 28 enero 2023
                    If TextBox97.Text = "Fresas frambuesa I" Then
                        TextBox416.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Frambuesa fresa G " Then
                        TextBox417.Text = linea.Cells(2).Value
                    End If
                    If TextBox97.Text = "Tarta manzana Teq G." Then
                        TextBox418.Text = linea.Cells(2).Value
                    End If

                    If TextBox97.Text = "Chessecake Blueberry" Then
                        txtChesscakeBlueberry.Text = linea.Cells(2).Value
                    End If

                Next

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            If TextBox416.Text = "" Then
                TextBox416.Text = "0"
            End If
            If TextBox417.Text = "" Then
                TextBox417.Text = "0"
            End If
            If TextBox418.Text = "" Then
                TextBox418.Text = "0"
            End If



        Else
            MsgBox("Acceso Denegado", MsgBoxStyle.Information, "CLAVE INCORRECTA")

        End If

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim Entrada As String
        Entrada = InputBox("Ingrese la Contraseña para continuar", MsgBoxStyle.Information)
        If Entrada = "9977" Then



            TextBox103.Text = "Gelatinas"
            GroupBox1.Visible = False
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            GroupBox4.Visible = False
            GroupBox5.Visible = False
            GroupBox6.Visible = True
            GroupBox7.Visible = False
            GroupBox8.Visible = False
            GroupBox9.Visible = False
            Try
                Dim adaptador As New OleDbDataAdapter
                Dim tabla As New DataTable
                Dim buscar As String

                buscar = ("select *from Orden_producción where Fecha='" & Label3.Text & "' ORDER by Producto")
                adaptador = New OleDbDataAdapter(buscar, conexion5)
                tabla = New DataTable
                adaptador.Fill(tabla)
                DataGridView1.DataSource = tabla

                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.AllowUserToResizeColumns = False
                DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                DataGridView1.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.DefaultCellStyle.Font = New Font("Arial", 10)

                DataGridView1.Columns(0).Width = 60
                DataGridView1.Columns(1).Width = 300
                DataGridView1.Columns(2).Width = 70

                'añado cada producto a un text box para hacer concentrado

                Dim linea As DataGridViewRow

                For Each linea In DataGridView1.Rows
                    TextBox97.Text = linea.Cells(1).Value

                    If TextBox97.Text = "Gel Gde D.E Piña" Then
                        TextBox230.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel Med D.E Piña" Then
                        TextBox220.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Gel Med D.E Durazno" Then
                        TextBox210.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Gel Med D.E Fresa" Then
                        TextBox284.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Gel Med D.E Mango" Then
                        TextBox382.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Gel Med D.E Manzana" Then
                        TextBox385.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Gel Med D.E Naranja" Then
                        TextBox386.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Gel Med D.E Uva" Then
                        TextBox387.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel Gde D.E Durazno" Then
                        TextBox393.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel Gde D.E Fresa" Then
                        TextBox392.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel Gde D.E Mango" Then
                        TextBox391.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel Gde D.E Manzana" Then
                        TextBox390.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Gel Gde D.E Naranja" Then
                        TextBox389.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel Gde D.E Uva" Then
                        TextBox388.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Gel. Agua fruta" Then
                        TextBox250.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Gel. Med. Agua fruta" Then
                        TextBox246.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Gde. Agua fruta" Then
                        TextBox242.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Betabel" Then
                        TextBox249.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Med. Betabel" Then
                        TextBox245.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Gde. Betabel" Then
                        TextBox241.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Bombón" Then
                        TextBox248.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Med. Bombón" Then
                        TextBox244.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Gde. Bombón" Then
                        TextBox240.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Gel. Cajeta" Then
                        TextBox237.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Med. Cajeta" Then
                        TextBox233.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Gde. Cajeta" Then
                        TextBox227.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Dominó" Then
                        TextBox236.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Med. Dominó" Then
                        TextBox232.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Gde. Dominó" Then
                        TextBox226.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Dominó especial" Then
                        TextBox235.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Jugos" Then
                        TextBox234.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Med. Jugos" Then
                        TextBox229.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Gde. Jugos" Then
                        TextBox219.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Queso uva" Then
                        TextBox261.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Med. Queso uva" Then
                        TextBox257.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Gde. Queso uva" Then
                        TextBox253.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Rompope fruta" Then
                        TextBox260.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Med. Rompope" Then
                        TextBox256.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Gde. Rompope" Then
                        TextBox252.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Tuti fruti" Then
                        TextBox259.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Med. Tuti fruti" Then
                        TextBox255.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Gde. Tuti fruti" Then
                        TextBox251.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. 3 chocolates" Then
                        TextBox258.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Med. 3 chocolates" Then
                        TextBox254.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Gde. 3 chocolates" Then
                        TextBox238.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. 3 leches" Then
                        TextBox273.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Med. 3 leches" Then
                        TextBox269.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Gde. 3 leches" Then
                        TextBox265.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Zanahoria" Then
                        TextBox272.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Med. Zanahoria" Then
                        TextBox268.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Gde. Zanahoria" Then
                        TextBox264.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Panna cotta" Then
                        TextBox464.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Gel. Panna cotta ciruela" Then
                        TextBox786.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Gel. Rompope liquido" Then
                        TextBox792.Text = linea.Cells(2).Value

                    End If

                Next

                'totales

                If TextBox250.Text = "" Then
                    TextBox250.Text = "0"
                End If
                If TextBox249.Text = "" Then
                    TextBox249.Text = "0"
                End If
                If TextBox248.Text = "" Then
                    TextBox248.Text = "0"
                End If

                If TextBox237.Text = "" Then
                    TextBox237.Text = "0"
                End If
                If TextBox236.Text = "" Then
                    TextBox236.Text = "0"
                End If

                If TextBox235.Text = "" Then
                    TextBox235.Text = "0"
                End If
                If TextBox234.Text = "" Then
                    TextBox234.Text = "0"
                End If

                If TextBox261.Text = "" Then
                    TextBox261.Text = "0"
                End If
                If TextBox260.Text = "" Then
                    TextBox260.Text = "0"
                End If

                If TextBox259.Text = "" Then
                    TextBox259.Text = "0"
                End If
                If TextBox258.Text = "" Then
                    TextBox258.Text = "0"
                End If

                If TextBox273.Text = "" Then
                    TextBox273.Text = "0"
                End If
                If TextBox272.Text = "" Then
                    TextBox272.Text = "0"
                End If

                If TextBox246.Text = "" Then
                    TextBox246.Text = "0"
                End If
                If TextBox245.Text = "" Then
                    TextBox245.Text = "0"
                End If

                If TextBox244.Text = "" Then
                    TextBox244.Text = "0"
                End If

                If TextBox233.Text = "" Then
                    TextBox233.Text = "0"
                End If
                If TextBox232.Text = "" Then
                    TextBox232.Text = "0"
                End If
                If TextBox229.Text = "" Then
                    TextBox229.Text = "0"
                End If

                If TextBox257.Text = "" Then
                    TextBox257.Text = "0"
                End If
                If TextBox256.Text = "" Then
                    TextBox256.Text = "0"
                End If

                If TextBox255.Text = "" Then
                    TextBox255.Text = "0"
                End If
                If TextBox254.Text = "" Then
                    TextBox254.Text = "0"
                End If

                If TextBox269.Text = "" Then
                    TextBox269.Text = "0"
                End If
                If TextBox268.Text = "" Then
                    TextBox268.Text = "0"
                End If

                If TextBox242.Text = "" Then
                    TextBox242.Text = "0"
                End If
                If TextBox241.Text = "" Then
                    TextBox241.Text = "0"
                End If

                If TextBox240.Text = "" Then
                    TextBox240.Text = "0"
                End If


                If TextBox227.Text = "" Then
                    TextBox227.Text = "0"
                End If
                If TextBox226.Text = "" Then
                    TextBox226.Text = "0"
                End If
                If TextBox219.Text = "" Then
                    TextBox219.Text = "0"
                End If

                If TextBox253.Text = "" Then
                    TextBox253.Text = "0"
                End If
                If TextBox252.Text = "" Then
                    TextBox252.Text = "0"
                End If
                If TextBox251.Text = "" Then
                    TextBox251.Text = "0"
                End If
                If TextBox238.Text = "" Then
                    TextBox238.Text = "0"
                End If
                If TextBox265.Text = "" Then
                    TextBox265.Text = "0"
                End If
                If TextBox264.Text = "" Then
                    TextBox264.Text = "0"
                End If

                'total por columnas
                TextBox224.Text = CDec(TextBox250.Text) + CDec(TextBox249.Text) + CDec(TextBox248.Text) + CDec(TextBox237.Text) + CDec(TextBox236.Text) + CDec(TextBox235.Text) + CDec(TextBox234.Text) + CDec(TextBox261.Text) + CDec(TextBox260.Text) + CDec(TextBox259.Text) + CDec(TextBox258.Text) + CDec(TextBox273.Text) + CDec(TextBox272.Text) + CDec(TextBox464.Text) + CDec(TextBox786.Text) + CDec(TextBox792.Text)
                TextBox223.Text = CDec(TextBox246.Text) + CDec(TextBox245.Text) + CDec(TextBox244.Text) + CDec(TextBox233.Text) + CDec(TextBox232.Text) + CDec(TextBox229.Text) + CDec(TextBox257.Text) + CDec(TextBox256.Text) + CDec(TextBox255.Text) + CDec(TextBox254.Text) + CDec(TextBox269.Text) + CDec(TextBox268.Text)
                TextBox221.Text = CDec(TextBox242.Text) + CDec(TextBox241.Text) + CDec(TextBox240.Text) + CDec(TextBox227.Text) + CDec(TextBox226.Text) + CDec(TextBox219.Text) + CDec(TextBox253.Text) + CDec(TextBox252.Text) + CDec(TextBox251.Text) + CDec(TextBox238.Text) + CDec(TextBox265.Text) + CDec(TextBox264.Text)

                TextBox88.Text = CDec(TextBox210.Text) + CDec(TextBox284.Text) + CDec(TextBox382.Text) + CDec(TextBox385.Text) + CDec(TextBox386.Text) + CDec(TextBox387.Text) + CDec(TextBox220.Text)
                TextBox111.Text = CDec(TextBox393.Text) + CDec(TextBox392.Text) + CDec(TextBox391.Text) + CDec(TextBox390.Text) + CDec(TextBox389.Text) + CDec(TextBox388.Text) + CDec(TextBox230.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("Acceso Denegado", MsgBoxStyle.Information, "CLAVE INCORRECTA")

        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim Entrada As String
        Entrada = InputBox("Ingrese la Contraseña para continuar", MsgBoxStyle.Information)
        If Entrada = "1199" Then
            'MsgBox("No disponible.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
            ' Exit Sub
            TextBox367.Text = "Panaderia"
            TextBox103.Text = "Panadería"
            GroupBox1.Visible = False
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            GroupBox4.Visible = False
            GroupBox5.Visible = False
            GroupBox6.Visible = False
            GroupBox7.Visible = False
            GroupBox8.Visible = True
            GroupBox9.Visible = False
            Try
                Dim adaptador As New OleDbDataAdapter
                Dim tabla As New DataTable
                Dim buscar As String

                buscar = ("select *from Orden_producción where Fecha='" & Label3.Text & "' ORDER by Producto")
                adaptador = New OleDbDataAdapter(buscar, conexion6)
                tabla = New DataTable
                adaptador.Fill(tabla)
                DataGridView1.DataSource = tabla

                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.AllowUserToResizeColumns = False
                DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                DataGridView1.DefaultCellStyle.BackColor = Color.LightGoldenrodYellow
                DataGridView1.AllowUserToResizeRows = False
                DataGridView1.DefaultCellStyle.Font = New Font("Arial", 10)

                DataGridView1.Columns(0).Width = 60
                DataGridView1.Columns(1).Width = 300
                DataGridView1.Columns(2).Width = 70

                'añado cada producto a un text box para hacer concentrado

                Dim linea As DataGridViewRow

                For Each linea In DataGridView1.Rows
                    TextBox97.Text = linea.Cells(1).Value
                    'Mantecada

                    If TextBox97.Text = "Mantecada" Then
                        TextBox427.Text = linea.Cells(2).Value
                    End If
                    'Mantecada

                    'Conde

                    If TextBox97.Text = "Campechana" Then
                        TextBox409.Text = linea.Cells(2).Value
                    End If
                    'Conde

                    If TextBox97.Text = "Conde" Then
                        TextBox365.Text = linea.Cells(2).Value
                    End If
                    'bolita de queso

                    If TextBox97.Text = "Bolita de queso" Then
                        TextBox371.Text = linea.Cells(2).Value
                    End If



                    'Bola berlin surtida
                    If TextBox97.Text = "Bola berlin surtida" Then
                        TextBox425.Text = linea.Cells(2).Value

                    End If

                    'Bocadillos area de panaderia
                    If TextBox97.Text = "Cuernito jamon y queso" Then
                        TextBox1048.Text = linea.Cells(2).Value

                    End If

                    'Rollos del area de panaderia
                    If TextBox97.Text = "Rollo Sal Q/Ama" Then
                        TextBox1045.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Rollo Jámón Q/Phi" Then
                        TextBox1044.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Bolsita galletas 100 gr" Then
                        TextBox996.Text = linea.Cells(2).Value

                    End If

                    '******
                    If TextBox97.Text = "Castaña" Then
                        TextBox323.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Cuerno choco" Then
                        TextBox321.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Cuerno higo" Then
                        TextBox312.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Cuerno mantequilla" Then
                        TextBox311.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Peinetas" Then
                        TextBox310.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Taco danés" Then
                        TextBox309.Text = linea.Cells(2).Value

                    End If




                    If TextBox97.Text = "Budín" Then
                        TextBox300.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Dona azúcar" Then
                        TextBox299.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Dona blanca" Then
                        TextBox298.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Dona choco" Then
                        TextBox287.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Dona fresa" Then
                        TextBox297.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Dona café" Then
                        TextBox275.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Dona Maple" Then
                        TextBox288.Text = linea.Cells(2).Value

                    End If
                    'Dona nuez
                    If TextBox97.Text = "Dona nuez" Then
                        TextBox408.Text = linea.Cells(2).Value

                    End If
                    'Dona oreo

                    If TextBox97.Text = "Dona oreo" Then
                        TextBox407.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Banderilla" Then
                        TextBox285.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Barquillos" Then
                        TextBox283.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Emp. de atún" Then
                        TextBox282.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Emp. de jamón" Then
                        TextBox281.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Emp. de rajas" Then
                        TextBox280.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Emp. de tinga" Then
                        TextBox279.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Ojo de buey" Then
                        TextBox278.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Orejas" Then
                        TextBox291.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Pastel de azúcar" Then
                        TextBox290.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Rollo de piña" Then
                        TextBox289.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Mil hojas" Then
                        TextBox292.Text = linea.Cells(2).Value

                    End If




                    If TextBox97.Text = "Elote" Then
                        TextBox296.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Lovable" Then
                        TextBox295.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Rosca canela" Then
                        TextBox294.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Rosca níquel" Then
                        TextBox293.Text = linea.Cells(2).Value

                    End If




                    If TextBox97.Text = "Alfajores" Then
                        TextBox305.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "G. americana" Then
                        TextBox304.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "G. deliciosa" Then
                        TextBox303.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Veinte limón" Then
                        TextBox308.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Veinte naranja" Then
                        TextBox307.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Piedra" Then
                        TextBox410.Text = linea.Cells(2).Value

                    End If





                    If TextBox97.Text = "Baguetita Int." Then
                        TextBox318.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Bisquet int." Then
                        TextBox317.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Cemita Int." Then
                        TextBox316.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Concha blanca int." Then
                        TextBox315.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Concha negra int." Then
                        TextBox314.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Cuerno int." Then
                        TextBox319.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Taco bisquet int." Then
                        TextBox313.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Telera Int." Then
                        TextBox320.Text = linea.Cells(2).Value

                    End If





                    If TextBox97.Text = "Carioca" Then
                        TextBox335.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Concha blanca" Then
                        TextBox334.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Concha negra" Then
                        TextBox333.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Flores fam." Then
                        TextBox332.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Limas" Then
                        TextBox331.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Rebanada" Then
                        TextBox330.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Tortuga" Then
                        TextBox329.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Trenza de nuez" Then
                        TextBox328.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Concha unicornio" Then
                        TextBox336.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Roles de canela" Then
                        TextBox780.Text = linea.Cells(2).Value

                    End If


                    If TextBox97.Text = "Integral chico" Then
                        TextBox341.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Integral grande" Then
                        TextBox340.Text = linea.Cells(2).Value

                    End If



                    If TextBox97.Text = "Besos" Then
                        TextBox343.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Bisquet" Then
                        TextBox342.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Taco bisquet" Then
                        TextBox338.Text = linea.Cells(2).Value

                    End If



                    If TextBox97.Text = "Pay de nuez" Then
                        TextBox344.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Pay de queso" Then
                        TextBox286.Text = linea.Cells(2).Value

                    End If




                    If TextBox97.Text = "Panqué Budín" Then
                        TextBox348.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Emp. Piña" Then
                        TextBox166.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Emp. Guayaba" Then
                        TextBox80.Text = linea.Cells(2).Value

                    End If

                    If TextBox97.Text = "Hojaldra Ind." Then
                        TextBox801.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Hojaldra Med." Then
                        TextBox998.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Hojaldra Gde." Then
                        TextBox1001.Text = linea.Cells(2).Value

                    End If

                    '4 productos nuevos de giuseppe 28 de enero 2023
                    If TextBox97.Text = "Cacahuate" Then
                        TextBox415.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Almeja" Then
                        TextBox414.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Galleta blue berry" Then
                        TextBox413.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Galleta chispas choco." Then
                        TextBox412.Text = linea.Cells(2).Value

                    End If

                    'fin de esos 4

                    '2 productos nuevos de giuseppe 20 de marzo 2023
                    If TextBox97.Text = "Puerquito" Then
                        TextBox424.Text = linea.Cells(2).Value

                    End If
                    If TextBox97.Text = "Rosca de bolsa" Then
                        TextBox423.Text = linea.Cells(2).Value

                    End If

                    'fin de esos 2
                Next

                'totales
                If TextBox427.Text = "" Then
                    TextBox427.Text = "0"
                End If

                If TextBox425.Text = "" Then
                    TextBox425.Text = "0"
                End If
                If TextBox424.Text = "" Then
                    TextBox424.Text = "0"
                End If
                If TextBox423.Text = "" Then
                    TextBox423.Text = "0"
                End If

                If TextBox415.Text = "" Then
                    TextBox415.Text = "0"
                End If
                If TextBox414.Text = "" Then
                    TextBox414.Text = "0"
                End If
                If TextBox413.Text = "" Then
                    TextBox413.Text = "0"
                End If
                If TextBox412.Text = "" Then
                    TextBox412.Text = "0"
                End If

                If TextBox323.Text = "" Then
                    TextBox323.Text = "0"
                End If
                If TextBox321.Text = "" Then
                    TextBox321.Text = "0"
                End If
                If TextBox312.Text = "" Then
                    TextBox312.Text = "0"
                End If
                If TextBox311.Text = "" Then
                    TextBox311.Text = "0"
                End If
                If TextBox310.Text = "" Then
                    TextBox310.Text = "0"
                End If
                If TextBox309.Text = "" Then
                    TextBox309.Text = "0"
                End If
                If TextBox300.Text = "" Then
                    TextBox300.Text = "0"
                End If
                If TextBox299.Text = "" Then
                    TextBox299.Text = "0"
                End If
                If TextBox298.Text = "" Then
                    TextBox298.Text = "0"
                End If
                If TextBox287.Text = "" Then
                    TextBox287.Text = "0"
                End If
                If TextBox297.Text = "" Then
                    TextBox297.Text = "0"
                End If
                If TextBox275.Text = "" Then
                    TextBox275.Text = "0"
                End If
                If TextBox288.Text = "" Then
                    TextBox288.Text = "0"
                End If
                If TextBox285.Text = "" Then
                    TextBox285.Text = "0"
                End If
                If TextBox283.Text = "" Then
                    TextBox283.Text = "0"
                End If
                If TextBox282.Text = "" Then
                    TextBox282.Text = "0"
                End If
                If TextBox281.Text = "" Then
                    TextBox281.Text = "0"
                End If
                If TextBox280.Text = "" Then
                    TextBox280.Text = "0"
                End If
                If TextBox279.Text = "" Then
                    TextBox279.Text = "0"
                End If
                If TextBox278.Text = "" Then
                    TextBox278.Text = "0"
                End If
                If TextBox291.Text = "" Then
                    TextBox291.Text = "0"
                End If
                If TextBox290.Text = "" Then
                    TextBox290.Text = "0"
                End If
                If TextBox289.Text = "" Then
                    TextBox289.Text = "0"
                End If
                If TextBox292.Text = "" Then
                    TextBox292.Text = "0"
                End If
                If TextBox296.Text = "" Then
                    TextBox296.Text = "0"
                End If
                If TextBox295.Text = "" Then
                    TextBox295.Text = "0"
                End If
                If TextBox294.Text = "" Then
                    TextBox294.Text = "0"
                End If
                If TextBox293.Text = "" Then
                    TextBox293.Text = "0"
                End If
                If TextBox305.Text = "" Then
                    TextBox305.Text = "0"
                End If
                If TextBox304.Text = "" Then
                    TextBox304.Text = "0"
                End If
                If TextBox303.Text = "" Then
                    TextBox303.Text = "0"
                End If
                If TextBox308.Text = "" Then
                    TextBox308.Text = "0"
                End If
                If TextBox307.Text = "" Then
                    TextBox307.Text = "0"
                End If
                If TextBox318.Text = "" Then
                    TextBox318.Text = "0"
                End If
                If TextBox317.Text = "" Then
                    TextBox317.Text = "0"
                End If
                If TextBox316.Text = "" Then
                    TextBox316.Text = "0"
                End If
                If TextBox315.Text = "" Then
                    TextBox315.Text = "0"
                End If
                If TextBox314.Text = "" Then
                    TextBox314.Text = "0"
                End If
                If TextBox319.Text = "" Then
                    TextBox319.Text = "0"
                End If
                If TextBox313.Text = "" Then
                    TextBox313.Text = "0"
                End If
                If TextBox320.Text = "" Then
                    TextBox320.Text = "0"
                End If
                If TextBox335.Text = "" Then
                    TextBox335.Text = "0"
                End If
                If TextBox334.Text = "" Then
                    TextBox334.Text = "0"
                End If
                If TextBox333.Text = "" Then
                    TextBox333.Text = "0"
                End If
                If TextBox332.Text = "" Then
                    TextBox332.Text = "0"
                End If
                If TextBox997.Text = "" Then
                    TextBox997.Text = "0"
                End If
                If TextBox802.Text = "" Then
                    TextBox802.Text = "0"
                End If
                If TextBox801.Text = "" Then
                    TextBox801.Text = "0"
                End If
                If TextBox1000.Text = "" Then
                    TextBox1000.Text = "0"
                End If
                If TextBox999.Text = "" Then
                    TextBox999.Text = "0"
                End If
                If TextBox998.Text = "" Then
                    TextBox998.Text = "0"
                End If
                If TextBox1003.Text = "" Then
                    TextBox1003.Text = "0"
                End If
                If TextBox1002.Text = "" Then
                    TextBox1002.Text = "0"
                End If
                If TextBox1001.Text = "" Then
                    TextBox1001.Text = "0"
                End If

                If TextBox331.Text = "" Then
                    TextBox331.Text = "0"
                End If
                If TextBox330.Text = "" Then
                    TextBox330.Text = "0"
                End If
                If TextBox329.Text = "" Then
                    TextBox329.Text = "0"
                End If
                If TextBox328.Text = "" Then
                    TextBox328.Text = "0"
                End If
                If TextBox336.Text = "" Then
                    TextBox336.Text = "0"
                End If
                If TextBox341.Text = "" Then
                    TextBox341.Text = "0"
                End If
                If TextBox340.Text = "" Then
                    TextBox340.Text = "0"
                End If
                If TextBox343.Text = "" Then
                    TextBox343.Text = "0"
                End If
                If TextBox342.Text = "" Then
                    TextBox342.Text = "0"
                End If
                If TextBox338.Text = "" Then
                    TextBox338.Text = "0"
                End If
                If TextBox344.Text = "" Then
                    TextBox344.Text = "0"
                End If
                If TextBox286.Text = "" Then
                    TextBox286.Text = "0"
                End If
                If TextBox348.Text = "" Then
                    TextBox348.Text = "0"
                End If
                If TextBox166.Text = "" Then
                    TextBox166.Text = "0"
                End If
                If TextBox80.Text = "" Then
                    TextBox80.Text = "0"
                End If

                'total por columnas

                Try
                    TextBox274.Text = CDec(TextBox323.Text) + CDec(TextBox321.Text) + CDec(TextBox312.Text) + CDec(TextBox311.Text) + CDec(TextBox310.Text) + CDec(TextBox309.Text)

                Catch ex As Exception

                End Try
                Try
                    TextBox276.Text = CDec(TextBox300.Text) + CDec(TextBox299.Text) + CDec(TextBox298.Text) + CDec(TextBox287.Text) + CDec(TextBox297.Text) + CDec(TextBox275.Text) + CDec(TextBox288.Text) + CDec(TextBox408.Text) + CDec(TextBox407.Text)

                Catch ex As Exception

                End Try

                Try
                    TextBox277.Text = CDec(TextBox291.Text) + CDec(TextBox290.Text) + CDec(TextBox289.Text) + CDec(TextBox292.Text)
                Catch ex As Exception

                End Try
                Try
                    TextBox301.Text = CDec(TextBox296.Text) + CDec(TextBox295.Text) + CDec(TextBox294.Text) + CDec(TextBox293.Text)

                Catch ex As Exception

                End Try
                Try
                    TextBox306.Text = CDec(TextBox305.Text) + CDec(TextBox304.Text) + CDec(TextBox303.Text) + CDec(TextBox308.Text) + CDec(TextBox307.Text)

                Catch ex As Exception

                End Try
                Try
                    TextBox326.Text = CDec(TextBox319.Text) + CDec(TextBox313.Text) + CDec(TextBox320.Text)

                Catch ex As Exception

                End Try
                Try
                    TextBox327.Text = CDec(TextBox335.Text) + CDec(TextBox334.Text) + CDec(TextBox333.Text) + CDec(TextBox332.Text) + CDec(TextBox331.Text) + CDec(TextBox330.Text) + CDec(TextBox329.Text) + CDec(TextBox328.Text) + CDec(TextBox336.Text)

                Catch ex As Exception

                End Try
                Try
                    TextBox337.Text = CDec(TextBox341.Text) + CDec(TextBox340.Text)

                Catch ex As Exception

                End Try
                Try
                    TextBox339.Text = CDec(TextBox343.Text) + CDec(TextBox342.Text) + CDec(TextBox338.Text)

                Catch ex As Exception

                End Try
                Try
                    TextBox345.Text = CDec(TextBox344.Text) + CDec(TextBox286.Text)

                Catch ex As Exception

                End Try
                Try
                    TextBox346.Text = CDec(TextBox348.Text)

                Catch ex As Exception

                End Try
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try



        Else
            MsgBox("Acceso Denegado", MsgBoxStyle.Information, "CLAVE INCORRECTA")

        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'PONGO CANDADO PARA QUE NO ABRAN NADA MIENTRAS SE JALA EL PEDIDO
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Pedido_Jala where Fecha='" & Label3.Text & "'")
            adaptador = New OleDbDataAdapter(buscar, conexion2)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView4.DataSource = tabla
            Dim row As DataGridViewRow = DataGridView4.CurrentRow


            If row.Cells(1).Value <> "" Then
                MsgBox("Hemos detectado que el pedido está siendo concentrado. IMPOSIBLE USAR EL SISTEMA, HASTA QUE EL PEDIDO ESTÉ LISTO.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
                Exit Sub
            End If
        Catch ex As Exception
        End Try
        Form2.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox103.Text = "" Then
            MsgBox("No puedes pedir materia prima sin tener un departamento consultado.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
            Exit Sub
        End If

        If TextBox103.Text = "Pastelería 2" Then
            MsgBox("Pastelería 2 pide junto el departamento de Pastelería 1.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
            Exit Sub
        End If

        'PONGO CANDADO PARA QUE NO ABRAN NADA MIENTRAS SE JALA EL PEDIDO
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Pedido_Jala where Fecha='" & Label3.Text & "'")
            adaptador = New OleDbDataAdapter(buscar, conexion2)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView4.DataSource = tabla
            Dim row As DataGridViewRow = DataGridView4.CurrentRow

            If row.Cells(1).Value <> "" Then
                MsgBox("Hemos detectado que el pedido está siendo concentrado. IMPOSIBLE USAR EL SISTEMA, HASTA QUE EL PEDIDO ESTÉ LISTO.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
                Exit Sub
            End If
        Catch ex As Exception
        End Try


        Form3.ComboBox1.Text = TextBox103.Text
        Form3.Show()

        'If TextBox103.Text = "Batidos" Then
        '    Form7.ComboBox1.Text = TextBox103.Text
        '    Form7.Show()

        'End If
        'If TextBox103.Text = "Cremosos" Then
        '    Form8.ComboBox1.Text = TextBox103.Text
        '    Form8.Show()

        'End If
        'If TextBox103.Text = "Flanes y arroz" Then
        '    Form9.ComboBox1.Text = TextBox103.Text
        '    Form9.Show()

        'End If
        'If TextBox103.Text = "Gelatinas" Then
        '    Form10.ComboBox1.Text = TextBox103.Text
        '    Form10.Show()

        'End If
        'If TextBox103.Text = "Panadería" Then
        '    Form11.ComboBox1.Text = TextBox103.Text
        '    Form11.Show()

        'End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'MsgBox("Aún no está disponible.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
        ' Exit Sub
        If TextBox103.Text = "" Then
            MsgBox("No hay ningún reporte por enviar.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
            Exit Sub
        End If
        If MsgBox("¿Deseas enviar el reporte? Hazlo solo si ya verificaste la información.  ********************Nota: RECUERDA REALIZAR LAS SUMAS CUANDO SON FECHAS ESPECIALES, FINES DE SEMANA O CUANDO HAYAN REALIZADO LA PRODUCCION EN PARTES.**************************", MsgBoxStyle.YesNo, "Rosa de Sarón Pastelerías") = MsgBoxResult.Yes Then
            Form4.TextBox103.Text = TextBox103.Text
            Form4.ShowDialog()
        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Shell("C:\Program Files\TeamViewer\TeamViewer.exe", AppWinStyle.NormalFocus)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Form17.ShowDialog()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If MsgBox("¿Deseas instalar la actualizacion?", MsgBoxStyle.YesNo, "Rosa de Sarón Pastelerías") = MsgBoxResult.Yes Then
            Process.Start("\\192.168.100.5\Users\Public\Documents\INSTALADORES\ORDENES DE PRODUCCION\Órdenes de Producción.application")
            Me.Close()
        End If
    End Sub

    Private Sub Button13_Click_1(sender As Object, e As EventArgs) Handles Button13.Click

        If TextBox353.Text = "" Or TextBox361.Text = "" Or TextBox364.Text = "" Or TextBox354.Text = "" Or TextBox357.Text = "" Or TextBox363.Text = "" Or TextBox355.Text = "" Or TextBox356.Text = "" Or TextBox362.Text = "" Then
            MsgBox("No puede haber ningún cuadro vacío. FAVOR DE VERIFICAR.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
            Exit Sub
        End If

        If MsgBox("¿Deseas enviar el reporte de panes?", MsgBoxStyle.YesNo, "Rosa de Sarón Pastelerías") = MsgBoxResult.Yes Then
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción_Panes(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label310.Text & "','" & CDec(TextBox353.Text) & "','" & Label3.Text & "','25 cm.')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción_Panes(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label310.Text & "','" & CDec(TextBox361.Text) & "','" & Label3.Text & "','18 cm.')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción_Panes(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label310.Text & "','" & CDec(TextBox364.Text) & "','" & Label3.Text & "','Minis')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción_Panes(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label314.Text & "','" & CDec(TextBox354.Text) & "','" & Label3.Text & "','25 cm.')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción_Panes(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label314.Text & "','" & CDec(TextBox357.Text) & "','" & Label3.Text & "','18 cm.')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción_Panes(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label314.Text & "','" & CDec(TextBox363.Text) & "','" & Label3.Text & "','Minis')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción_Panes(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label315.Text & "','" & CDec(TextBox355.Text) & "','" & Label3.Text & "','25 cm.')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción_Panes(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label315.Text & "','" & CDec(TextBox356.Text) & "','" & Label3.Text & "','18 cm.')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción_Panes(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label315.Text & "','" & CDec(TextBox362.Text) & "','" & Label3.Text & "','Minis')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            MsgBox("Reporte enviado. Gracias.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")

        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Try
            Dim cmd15 As New OleDbCommand
            cmd15 = New OleDbCommand("delete from Reporte_Producción where Fecha='" & Label3.Text & "' AND Categoría='Reyes'", conexion6)
            conexion6.Open()
            cmd15.ExecuteNonQuery()
            conexion6.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            Dim cmd As New OleDbCommand
            Dim r1 As Integer

            cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & lblRoscaReyesGrande.Text & "','" & CDec(txtRoscaReyesGrande.Text) & "','" & Label3.Text & "','Reyes')", conexion6)
            conexion6.Open()
            r1 = cmd.ExecuteNonQuery
            conexion6.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        Try
            Dim cmd As New OleDbCommand
            Dim r1 As Integer

            cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & lblRoscaReyesMediana.Text & "','" & CDec(txtRoscaReyesMediana.Text) & "','" & Label3.Text & "','Reyes')", conexion6)
            conexion6.Open()
            r1 = cmd.ExecuteNonQuery
            conexion6.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        Try
            Dim cmd As New OleDbCommand
            Dim r1 As Integer

            cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & lblRoscaReyesChica.Text & "','" & CDec(txtRoscaReyesChica.Text) & "','" & Label3.Text & "','Reyes')", conexion6)
            conexion6.Open()
            r1 = cmd.ExecuteNonQuery
            conexion6.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        Try
            Dim cmd As New OleDbCommand
            Dim r1 As Integer

            cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & lblRoscaReyesIndividual.Text & "','" & CDec(txtRoscaReyesInd.Text) & "','" & Label3.Text & "','Reyes')", conexion6)
            conexion6.Open()
            r1 = cmd.ExecuteNonQuery
            conexion6.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        PrintDocument7.Print()
        MsgBox("Información de ROSCAS DE REYES enviada correctamente a Cuentas por Cobrar. Gracias.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If TextBox103.Text = "" Then
            MsgBox("Debes elegir un departamento primero.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
            Exit Sub
        End If
        Form20.Show()
        Form20.TextBox103.Text = TextBox103.Text
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If MsgBox("¿Deseas enviar el reporte de producción de quesos y flanes a Cuentas por Cobrar? VERIFICA QUE LA FECHA SEA CORRECTA, SEGÚN EL DÍA DE PRODUCCIÓN.", MsgBoxStyle.YesNo, "Rosa de Sarón Pastelerías") = MsgBoxResult.Yes Then
            'emvio reporte de quesos en todos sdus tamaños
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción_QuesosFlanes(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label345.Text & "','" & CDec(TextBox384.Text) & "','" & DateTimePicker1.Value & "','Quesos 25 cm.')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción_QuesosFlanes(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label345.Text & "','" & CDec(TextBox381.Text) & "','" & DateTimePicker1.Value & "','Quesos 18 cm.')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción_QuesosFlanes(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label345.Text & "','" & CDec(TextBox378.Text) & "','" & DateTimePicker1.Value & "','Quesos Minis')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción_QuesosFlanes(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label345.Text & "','" & CDec(TextBox379.Text) & "','" & DateTimePicker1.Value & "','Quesos 1/4P')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
                Exit Sub
            End Try
            'envio reporte de gflanes en todo sus tamaños
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción_QuesosFlanes(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label344.Text & "','" & CDec(TextBox383.Text) & "','" & DateTimePicker1.Value & "','Flanes 25 cm.')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción_QuesosFlanes(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label344.Text & "','" & CDec(TextBox380.Text) & "','" & DateTimePicker1.Value & "','Flanes 18 cm.')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción_QuesosFlanes(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label344.Text & "','" & CDec(TextBox37.Text) & "','" & DateTimePicker1.Value & "','Flanes Minis')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción_QuesosFlanes(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label344.Text & "','" & CDec(TextBox376.Text) & "','" & DateTimePicker1.Value & "','Flanes 1/4P')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                conexion.Close()
                Exit Sub
            End Try

            MsgBox("Listo, todo ha sido enviado. Gracias.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim i As Integer = 0
        Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
        Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
        Dim prFont2 As New Font("Arial", 8, GraphicsUnit.Point)
        Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
        Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
        Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
        e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 65, 65)
        e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 69, 75)
        e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 10, 90)
        e.Graphics.DrawString("S.A. de C.V.", prFont2, Brushes.Black, 60, 105)
        e.Graphics.DrawString("RFC CSS1512219U3", prFont2, Brushes.Black, 37, 120)
        e.Graphics.DrawString("Departartamento: QUESOS/FLANES FELIPE", prFont2, Brushes.Black, 0, 135)
        e.Graphics.DrawString("REPORTE ENVIADO A CXC", prFont2, Brushes.Black, 10, 150)

        e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 10, 165)
        e.Graphics.DrawString(DateTimePicker1.Value, prFont2, Brushes.Black, 50, 165)

        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Reporte_Producción_QuesosFlanes where Fecha='" & DateTimePicker1.Value & "'")
            adaptador = New OleDbDataAdapter(buscar, conexion)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla
        Catch ex As Exception
            MsgBox(ex.Message & " No hay ningún reporte enviado aún.")
            conexion.Close()

            Exit Sub
        End Try

        While i < DataGridView1.RowCount

            e.Graphics.DrawString(DataGridView1.Item(0, i).Value, prFont2, Brushes.Black, 0, i * 15 + 190)
            e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont2, Brushes.Black, 125, i * 15 + 190)
            e.Graphics.DrawString(DataGridView1.Item(3, i).Value, prFont2, Brushes.Black, 155, i * 15 + 190)

            i += 1
        End While
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        If TextBox103.Text = "" Then
            MsgBox("Debes seleccionar algun departamento primero", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
            Exit Sub
        End If
        If TextBox103.Text = "Pastelería 1" Then
            Try
                ' Primera fila
                TextBox1.Text = CDec(TextBox1.Text) + CDec(TextBox502.Text) + CDec(TextBox582.Text)
                TextBox6.Text = CDec(TextBox6.Text) + CDec(TextBox501.Text) + CDec(TextBox581.Text)
                TextBox9.Text = CDec(TextBox9.Text) + CDec(TextBox500.Text) + CDec(TextBox580.Text)
                TextBox12.Text = CDec(TextBox12.Text) + CDec(TextBox499.Text) + CDec(TextBox579.Text)
                TextBox15.Text = CDec(TextBox15.Text) + CDec(TextBox498.Text) + CDec(TextBox578.Text)
                TextBox18.Text = CDec(TextBox18.Text) + CDec(TextBox497.Text) + CDec(TextBox577.Text)
                TextBox21.Text = CDec(TextBox21.Text) + CDec(TextBox496.Text) + CDec(TextBox576.Text)
                TextBox24.Text = CDec(TextBox24.Text) + CDec(TextBox495.Text) + CDec(TextBox575.Text)
                TextBox27.Text = CDec(TextBox27.Text) + CDec(TextBox494.Text) + CDec(TextBox574.Text)
                TextBox30.Text = CDec(TextBox30.Text) + CDec(TextBox493.Text) + CDec(TextBox573.Text)
                TextBox33.Text = CDec(TextBox33.Text) + CDec(TextBox492.Text) + CDec(TextBox572.Text)
                TextBox36.Text = CDec(TextBox36.Text) + CDec(TextBox491.Text) + CDec(TextBox571.Text)
                TextBox39.Text = CDec(TextBox39.Text) + CDec(TextBox490.Text) + CDec(TextBox570.Text)
                TextBox42.Text = CDec(TextBox42.Text) + CDec(TextBox489.Text) + CDec(TextBox569.Text)
                TextBox45.Text = CDec(TextBox45.Text) + CDec(TextBox488.Text) + CDec(TextBox568.Text)
                TextBox48.Text = CDec(TextBox48.Text) + CDec(TextBox487.Text) + CDec(TextBox567.Text)
                TextBox51.Text = CDec(TextBox51.Text) + CDec(TextBox486.Text) + CDec(TextBox566.Text)
                TextBox54.Text = CDec(TextBox54.Text) + CDec(TextBox485.Text) + CDec(TextBox565.Text)
                TextBox57.Text = CDec(TextBox57.Text) + CDec(TextBox484.Text) + CDec(TextBox564.Text)
                TextBox60.Text = CDec(TextBox60.Text) + CDec(TextBox483.Text) + CDec(TextBox563.Text)
                TextBox63.Text = CDec(TextBox63.Text) + CDec(TextBox482.Text) + CDec(TextBox562.Text)
                TextBox66.Text = CDec(TextBox66.Text) + CDec(TextBox481.Text) + CDec(TextBox561.Text)
                TextBox69.Text = CDec(TextBox69.Text) + CDec(TextBox480.Text) + CDec(TextBox560.Text)
                TextBox72.Text = CDec(TextBox72.Text) + CDec(TextBox479.Text) + CDec(TextBox559.Text)
                ' Segunda fila
                TextBox2.Text = CDec(TextBox2.Text) + CDec(TextBox526.Text) + CDec(TextBox606.Text)
                TextBox5.Text = CDec(TextBox5.Text) + CDec(TextBox525.Text) + CDec(TextBox605.Text)
                TextBox8.Text = CDec(TextBox8.Text) + CDec(TextBox524.Text) + CDec(TextBox604.Text)
                TextBox11.Text = CDec(TextBox11.Text) + CDec(TextBox523.Text) + CDec(TextBox603.Text)
                TextBox14.Text = CDec(TextBox14.Text) + CDec(TextBox522.Text) + CDec(TextBox602.Text)
                TextBox17.Text = CDec(TextBox17.Text) + CDec(TextBox521.Text) + CDec(TextBox601.Text)
                TextBox20.Text = CDec(TextBox20.Text) + CDec(TextBox502.Text) + CDec(TextBox600.Text)
                TextBox23.Text = CDec(TextBox23.Text) + CDec(TextBox519.Text) + CDec(TextBox599.Text)
                TextBox26.Text = CDec(TextBox26.Text) + CDec(TextBox518.Text) + CDec(TextBox598.Text)
                TextBox29.Text = CDec(TextBox29.Text) + CDec(TextBox517.Text) + CDec(TextBox597.Text)
                TextBox32.Text = CDec(TextBox32.Text) + CDec(TextBox516.Text) + CDec(TextBox596.Text)
                TextBox35.Text = CDec(TextBox35.Text) + CDec(TextBox515.Text) + CDec(TextBox595.Text)
                TextBox38.Text = CDec(TextBox38.Text) + CDec(TextBox514.Text) + CDec(TextBox594.Text)
                TextBox41.Text = CDec(TextBox41.Text) + CDec(TextBox513.Text) + CDec(TextBox593.Text)
                TextBox44.Text = CDec(TextBox44.Text) + CDec(TextBox512.Text) + CDec(TextBox592.Text)
                TextBox47.Text = CDec(TextBox47.Text) + CDec(TextBox511.Text) + CDec(TextBox591.Text)
                TextBox50.Text = CDec(TextBox50.Text) + CDec(TextBox510.Text) + CDec(TextBox590.Text)
                TextBox53.Text = CDec(TextBox53.Text) + CDec(TextBox509.Text) + CDec(TextBox589.Text)
                TextBox56.Text = CDec(TextBox56.Text) + CDec(TextBox508.Text) + CDec(TextBox588.Text)
                TextBox59.Text = CDec(TextBox59.Text) + CDec(TextBox507.Text) + CDec(TextBox507.Text)
                TextBox62.Text = CDec(TextBox62.Text) + CDec(TextBox506.Text) + CDec(TextBox586.Text)
                TextBox65.Text = CDec(TextBox65.Text) + CDec(TextBox505.Text) + CDec(TextBox585.Text)
                TextBox68.Text = CDec(TextBox68.Text) + CDec(TextBox504.Text) + CDec(TextBox584.Text)
                TextBox71.Text = CDec(TextBox71.Text) + CDec(TextBox503.Text) + CDec(TextBox583.Text)
                ' Tercera fila
                TextBox3.Text = CDec(TextBox3.Text) + CDec(TextBox550.Text) + CDec(TextBox638.Text)
                TextBox4.Text = CDec(TextBox4.Text) + CDec(TextBox549.Text) + CDec(TextBox637.Text)
                TextBox7.Text = CDec(TextBox7.Text) + CDec(TextBox548.Text) + CDec(TextBox636.Text)
                TextBox10.Text = CDec(TextBox10.Text) + CDec(TextBox547.Text) + CDec(TextBox635.Text)
                TextBox13.Text = CDec(TextBox13.Text) + CDec(TextBox546.Text) + CDec(TextBox634.Text)
                TextBox16.Text = CDec(TextBox16.Text) + CDec(TextBox545.Text) + CDec(TextBox633.Text)
                TextBox19.Text = CDec(TextBox19.Text) + CDec(TextBox544.Text) + CDec(TextBox632.Text)
                TextBox22.Text = CDec(TextBox22.Text) + CDec(TextBox543.Text) + CDec(TextBox631.Text)
                TextBox25.Text = CDec(TextBox25.Text) + CDec(TextBox542.Text) + CDec(TextBox630.Text)
                TextBox28.Text = CDec(TextBox28.Text) + CDec(TextBox541.Text) + CDec(TextBox629.Text)
                TextBox31.Text = CDec(TextBox31.Text) + CDec(TextBox540.Text) + CDec(TextBox628.Text)
                TextBox34.Text = CDec(TextBox34.Text) + CDec(TextBox539.Text) + CDec(TextBox627.Text)
                TextBox37.Text = CDec(TextBox37.Text) + CDec(TextBox538.Text) + CDec(TextBox626.Text)
                TextBox40.Text = CDec(TextBox40.Text) + CDec(TextBox537.Text) + CDec(TextBox625.Text)
                TextBox43.Text = CDec(TextBox43.Text) + CDec(TextBox536.Text) + CDec(TextBox624.Text)
                TextBox46.Text = CDec(TextBox46.Text) + CDec(TextBox535.Text) + CDec(TextBox623.Text)
                TextBox49.Text = CDec(TextBox49.Text) + CDec(TextBox534.Text) + CDec(TextBox622.Text)
                TextBox52.Text = CDec(TextBox52.Text) + CDec(TextBox533.Text) + CDec(TextBox621.Text)
                TextBox55.Text = CDec(TextBox55.Text) + CDec(TextBox532.Text) + CDec(TextBox620.Text)
                TextBox58.Text = CDec(TextBox58.Text) + CDec(TextBox531.Text) + CDec(TextBox619.Text)
                TextBox61.Text = CDec(TextBox61.Text) + CDec(TextBox530.Text) + CDec(TextBox618.Text)
                TextBox64.Text = CDec(TextBox64.Text) + CDec(TextBox529.Text) + CDec(TextBox617.Text)
                TextBox67.Text = CDec(TextBox67.Text) + CDec(TextBox528.Text) + CDec(TextBox616.Text)
                TextBox70.Text = CDec(TextBox70.Text) + CDec(TextBox527.Text) + CDec(TextBox615.Text)
                ' Seccion tartas y pays
                TextBox77.Text = CDec(TextBox77.Text) + CDec(TextBox639.Text) + CDec(TextBox648.Text)
                TextBox76.Text = CDec(TextBox76.Text) + CDec(TextBox640.Text) + CDec(TextBox647.Text)
                TextBox75.Text = CDec(TextBox75.Text) + CDec(TextBox641.Text) + CDec(TextBox646.Text)
                TextBox74.Text = CDec(TextBox74.Text) + CDec(TextBox642.Text) + CDec(TextBox645.Text)
                TextBox73.Text = CDec(TextBox73.Text) + CDec(TextBox643.Text) + CDec(TextBox644.Text)
                TextBox82.Text = CDec(TextBox82.Text) + CDec(TextBox650.Text) + CDec(TextBox656.Text)
                TextBox81.Text = CDec(TextBox81.Text) + CDec(TextBox649.Text) + CDec(TextBox655.Text)
                TextBox79.Text = CDec(TextBox79.Text) + CDec(TextBox652.Text) + CDec(TextBox654.Text)
                TextBox78.Text = CDec(TextBox78.Text) + CDec(TextBox651.Text) + CDec(TextBox653.Text)

                ' Reporte quesos y flanes
                TextBox384.Text = CDec(TextBox384.Text) + CDec(TextBox558.Text) + CDec(TextBox614.Text)
                TextBox383.Text = CDec(TextBox383.Text) + CDec(TextBox557.Text) + CDec(TextBox613.Text)
                TextBox381.Text = CDec(TextBox381.Text) + CDec(TextBox556.Text) + CDec(TextBox612.Text)
                TextBox380.Text = CDec(TextBox380.Text) + CDec(TextBox555.Text) + CDec(TextBox611.Text)
                TextBox378.Text = CDec(TextBox378.Text) + CDec(TextBox554.Text) + CDec(TextBox610.Text)
                TextBox377.Text = CDec(TextBox377.Text) + CDec(TextBox553.Text) + CDec(TextBox609.Text)
                TextBox379.Text = CDec(TextBox379.Text) + CDec(TextBox552.Text) + CDec(TextBox608.Text)
                TextBox376.Text = CDec(TextBox376.Text) + CDec(TextBox551.Text) + CDec(TextBox607.Text)
                'Totales por fila
                'Primera fila
                TextBox102.Text = CDec(TextBox1.Text) + CDec(TextBox6.Text) + CDec(TextBox9.Text) + CDec(TextBox12.Text) + CDec(TextBox15.Text) + CDec(TextBox18.Text) + CDec(TextBox21.Text) + CDec(TextBox24.Text) + CDec(TextBox27.Text) + CDec(TextBox30.Text) + CDec(TextBox33.Text) + CDec(TextBox36.Text) + CDec(TextBox39.Text) + CDec(TextBox42.Text) + CDec(TextBox45.Text) + CDec(TextBox48.Text) + CDec(TextBox51.Text) + CDec(TextBox54.Text) + CDec(TextBox57.Text) + CDec(TextBox60.Text) + CDec(TextBox63.Text) + CDec(TextBox66.Text) + CDec(TextBox69.Text) + CDec(TextBox72.Text)
                TextBox860.Text = CDec(TextBox502.Text) + CDec(TextBox501.Text) + CDec(TextBox500.Text) + CDec(TextBox499.Text) + CDec(TextBox498.Text) + CDec(TextBox497.Text) + CDec(TextBox496.Text) + CDec(TextBox495.Text) + CDec(TextBox494.Text) + CDec(TextBox493.Text) + CDec(TextBox492.Text) + CDec(TextBox491.Text) + CDec(TextBox490.Text) + CDec(TextBox489.Text) + CDec(TextBox488.Text) + CDec(TextBox487.Text) + CDec(TextBox486.Text) + CDec(TextBox485.Text) + CDec(TextBox484.Text) + CDec(TextBox483.Text) + CDec(TextBox482.Text) + CDec(TextBox481.Text) + CDec(TextBox480.Text) + CDec(TextBox479.Text)
                TextBox859.Text = CDec(TextBox582.Text) + CDec(TextBox581.Text) + CDec(TextBox580.Text) + CDec(TextBox579.Text) + CDec(TextBox578.Text) + CDec(TextBox577.Text) + CDec(TextBox576.Text) + CDec(TextBox575.Text) + CDec(TextBox574.Text) + CDec(TextBox573.Text) + CDec(TextBox572.Text) + CDec(TextBox571.Text) + CDec(TextBox570.Text) + CDec(TextBox569.Text) + CDec(TextBox568.Text) + CDec(TextBox567.Text) + CDec(TextBox566.Text) + CDec(TextBox565.Text) + CDec(TextBox564.Text) + CDec(TextBox563.Text) + CDec(TextBox562.Text) + CDec(TextBox561.Text) + CDec(TextBox560.Text) + CDec(TextBox559.Text)
                'Segunda fila
                TextBox101.Text = CDec(TextBox2.Text) + CDec(TextBox5.Text) + CDec(TextBox8.Text) + CDec(TextBox11.Text) + CDec(TextBox14.Text) + CDec(TextBox17.Text) + CDec(TextBox20.Text) + CDec(TextBox23.Text) + CDec(TextBox26.Text) + CDec(TextBox29.Text) + CDec(TextBox32.Text) + CDec(TextBox35.Text) + CDec(TextBox38.Text) + CDec(TextBox41.Text) + CDec(TextBox44.Text) + CDec(TextBox47.Text) + CDec(TextBox50.Text) + CDec(TextBox53.Text) + CDec(TextBox56.Text) + CDec(TextBox59.Text) + CDec(TextBox62.Text) + CDec(TextBox65.Text) + CDec(TextBox68.Text) + CDec(TextBox71.Text)
                TextBox972.Text = CDec(TextBox526.Text) + CDec(TextBox525.Text) + CDec(TextBox524.Text) + CDec(TextBox523.Text) + CDec(TextBox522.Text) + CDec(TextBox521.Text) + CDec(TextBox520.Text) + CDec(TextBox519.Text) + CDec(TextBox518.Text) + CDec(TextBox517.Text) + CDec(TextBox516.Text) + CDec(TextBox515.Text) + CDec(TextBox514.Text) + CDec(TextBox513.Text) + CDec(TextBox512.Text) + CDec(TextBox511.Text) + CDec(TextBox510.Text) + CDec(TextBox509.Text) + CDec(TextBox508.Text) + CDec(TextBox507.Text) + CDec(TextBox506.Text) + CDec(TextBox505.Text) + CDec(TextBox504.Text) + CDec(TextBox503.Text)
                TextBox971.Text = CDec(TextBox606.Text) + CDec(TextBox605.Text) + CDec(TextBox604.Text) + CDec(TextBox603.Text) + CDec(TextBox602.Text) + CDec(TextBox601.Text) + CDec(TextBox600.Text) + CDec(TextBox599.Text) + CDec(TextBox598.Text) + CDec(TextBox597.Text) + CDec(TextBox596.Text) + CDec(TextBox595.Text) + CDec(TextBox594.Text) + CDec(TextBox593.Text) + CDec(TextBox592.Text) + CDec(TextBox591.Text) + CDec(TextBox590.Text) + CDec(TextBox589.Text) + CDec(TextBox588.Text) + CDec(TextBox587.Text) + CDec(TextBox586.Text) + CDec(TextBox585.Text) + CDec(TextBox584.Text) + CDec(TextBox583.Text)
                'Tercera fila
                TextBox98.Text = CDec(TextBox3.Text) + CDec(TextBox4.Text) + CDec(TextBox7.Text) + CDec(TextBox10.Text) + CDec(TextBox13.Text) + CDec(TextBox16.Text) + CDec(TextBox19.Text) + CDec(TextBox22.Text) + CDec(TextBox25.Text) + CDec(TextBox28.Text) + CDec(TextBox31.Text) + CDec(TextBox34.Text) + CDec(TextBox37.Text) + CDec(TextBox40.Text) + CDec(TextBox43.Text) + CDec(TextBox46.Text) + CDec(TextBox49.Text) + CDec(TextBox52.Text) + CDec(TextBox55.Text) + CDec(TextBox58.Text) + CDec(TextBox61.Text) + CDec(TextBox64.Text) + CDec(TextBox67.Text) + CDec(TextBox70.Text)
                TextBox974.Text = CDec(TextBox550.Text) + CDec(TextBox549.Text) + CDec(TextBox548.Text) + CDec(TextBox547.Text) + CDec(TextBox546.Text) + CDec(TextBox545.Text) + CDec(TextBox544.Text) + CDec(TextBox543.Text) + CDec(TextBox542.Text) + CDec(TextBox541.Text) + CDec(TextBox540.Text) + CDec(TextBox539.Text) + CDec(TextBox538.Text) + CDec(TextBox537.Text) + CDec(TextBox536.Text) + CDec(TextBox535.Text) + CDec(TextBox534.Text) + CDec(TextBox533.Text) + CDec(TextBox532.Text) + CDec(TextBox531.Text) + CDec(TextBox530.Text) + CDec(TextBox529.Text) + CDec(TextBox528.Text) + CDec(TextBox527.Text)
                TextBox973.Text = CDec(TextBox638.Text) + CDec(TextBox637.Text) + CDec(TextBox636.Text) + CDec(TextBox635.Text) + CDec(TextBox634.Text) + CDec(TextBox633.Text) + CDec(TextBox632.Text) + CDec(TextBox631.Text) + CDec(TextBox630.Text) + CDec(TextBox629.Text) + CDec(TextBox628.Text) + CDec(TextBox627.Text) + CDec(TextBox626.Text) + CDec(TextBox625.Text) + CDec(TextBox624.Text) + CDec(TextBox623.Text) + CDec(TextBox622.Text) + CDec(TextBox621.Text) + CDec(TextBox620.Text) + CDec(TextBox619.Text) + CDec(TextBox618.Text) + CDec(TextBox617.Text) + CDec(TextBox616.Text) + CDec(TextBox615.Text)
                MsgBox("SUMAS REALIZADAS", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
            Catch ex As Exception
                MsgBox("Error, favor de verificar las cifras ingresadas", MsgBoxStyle.Critical, "Error de captura")
            End Try
        End If
        If TextBox103.Text = "Pastelería 2" Then
            Try
                ' 1° fila
                TextBox197.Text = CDec(TextBox197.Text) + CDec(TextBox964.Text) + CDec(TextBox957.Text)
                TextBox194.Text = CDec(TextBox194.Text) + CDec(TextBox963.Text) + CDec(TextBox956.Text)
                TextBox191.Text = CDec(TextBox191.Text) + CDec(TextBox962.Text) + CDec(TextBox955.Text)
                TextBox188.Text = CDec(TextBox188.Text) + CDec(TextBox961.Text) + CDec(TextBox954.Text)
                TextBox185.Text = CDec(TextBox185.Text) + CDec(TextBox960.Text) + CDec(TextBox953.Text)
                TextBox182.Text = CDec(TextBox182.Text) + CDec(TextBox959.Text) + CDec(TextBox952.Text)
                TextBox179.Text = CDec(TextBox179.Text) + CDec(TextBox958.Text) + CDec(TextBox951.Text)
                ' 2° fila
                TextBox196.Text = CDec(TextBox196.Text) + CDec(TextBox950.Text) + CDec(TextBox943.Text)
                TextBox193.Text = CDec(TextBox193.Text) + CDec(TextBox949.Text) + CDec(TextBox942.Text)
                TextBox190.Text = CDec(TextBox190.Text) + CDec(TextBox948.Text) + CDec(TextBox941.Text)
                TextBox187.Text = CDec(TextBox187.Text) + CDec(TextBox947.Text) + CDec(TextBox940.Text)
                TextBox184.Text = CDec(TextBox184.Text) + CDec(TextBox946.Text) + CDec(TextBox939.Text)
                TextBox181.Text = CDec(TextBox181.Text) + CDec(TextBox945.Text) + CDec(TextBox938.Text)
                TextBox178.Text = CDec(TextBox178.Text) + CDec(TextBox944.Text) + CDec(TextBox937.Text)
                ' 3° fila
                TextBox195.Text = CDec(TextBox195.Text) + CDec(TextBox936.Text) + CDec(TextBox929.Text)
                TextBox192.Text = CDec(TextBox192.Text) + CDec(TextBox935.Text) + CDec(TextBox928.Text)
                TextBox189.Text = CDec(TextBox189.Text) + CDec(TextBox934.Text) + CDec(TextBox927.Text)
                TextBox186.Text = CDec(TextBox186.Text) + CDec(TextBox933.Text) + CDec(TextBox926.Text)
                TextBox183.Text = CDec(TextBox183.Text) + CDec(TextBox932.Text) + CDec(TextBox925.Text)
                TextBox180.Text = CDec(TextBox180.Text) + CDec(TextBox931.Text) + CDec(TextBox924.Text)
                TextBox177.Text = CDec(TextBox177.Text) + CDec(TextBox930.Text) + CDec(TextBox923.Text)
                ' 4° fila
                TextBox173.Text = CDec(TextBox173.Text) + CDec(TextBox921.Text) + CDec(TextBox906.Text)
                TextBox170.Text = CDec(TextBox170.Text) + CDec(TextBox920.Text) + CDec(TextBox905.Text)
                TextBox167.Text = CDec(TextBox167.Text) + CDec(TextBox919.Text) + CDec(TextBox904.Text)
                TextBox164.Text = CDec(TextBox164.Text) + CDec(TextBox918.Text) + CDec(TextBox903.Text)
                TextBox161.Text = CDec(TextBox161.Text) + CDec(TextBox917.Text) + CDec(TextBox902.Text)
                TextBox158.Text = CDec(TextBox158.Text) + CDec(TextBox916.Text) + CDec(TextBox901.Text)
                TextBox155.Text = CDec(TextBox155.Text) + CDec(TextBox915.Text) + CDec(TextBox900.Text)
                TextBox152.Text = CDec(TextBox152.Text) + CDec(TextBox914.Text) + CDec(TextBox899.Text)
                TextBox149.Text = CDec(TextBox149.Text) + CDec(TextBox913.Text) + CDec(TextBox898.Text)
                TextBox146.Text = CDec(TextBox146.Text) + CDec(TextBox912.Text) + CDec(TextBox897.Text)
                TextBox140.Text = CDec(TextBox140.Text) + CDec(TextBox911.Text) + CDec(TextBox896.Text)
                TextBox137.Text = CDec(TextBox137.Text) + CDec(TextBox910.Text) + CDec(TextBox895.Text)
                TextBox134.Text = CDec(TextBox134.Text) + CDec(TextBox909.Text) + CDec(TextBox894.Text)
                TextBox1037.Text = CDec(TextBox1037.Text) + CDec(TextBox1030.Text) + CDec(TextBox1029.Text)
                ' 5° fila
                TextBox174.Text = CDec(TextBox174.Text) + CDec(TextBox863.Text) + CDec(TextBox892.Text)
                TextBox171.Text = CDec(TextBox171.Text) + CDec(TextBox864.Text) + CDec(TextBox891.Text)
                TextBox168.Text = CDec(TextBox168.Text) + CDec(TextBox866.Text) + CDec(TextBox890.Text)
                TextBox165.Text = CDec(TextBox165.Text) + CDec(TextBox865.Text) + CDec(TextBox889.Text)
                TextBox162.Text = CDec(TextBox162.Text) + CDec(TextBox870.Text) + CDec(TextBox888.Text)
                TextBox159.Text = CDec(TextBox159.Text) + CDec(TextBox869.Text) + CDec(TextBox887.Text)
                TextBox156.Text = CDec(TextBox156.Text) + CDec(TextBox868.Text) + CDec(TextBox886.Text)
                TextBox153.Text = CDec(TextBox153.Text) + CDec(TextBox867.Text) + CDec(TextBox885.Text)
                TextBox150.Text = CDec(TextBox150.Text) + CDec(TextBox878.Text) + CDec(TextBox884.Text)
                TextBox147.Text = CDec(TextBox147.Text) + CDec(TextBox877.Text) + CDec(TextBox883.Text)
                TextBox144.Text = CDec(TextBox144.Text) + CDec(TextBox876.Text) + CDec(TextBox882.Text)
                TextBox141.Text = CDec(TextBox141.Text) + CDec(TextBox875.Text) + CDec(TextBox881.Text)
                TextBox138.Text = CDec(TextBox138.Text) + CDec(TextBox874.Text) + CDec(TextBox880.Text)
                TextBox135.Text = CDec(TextBox135.Text) + CDec(TextBox873.Text) + CDec(TextBox879.Text)
                TextBox132.Text = CDec(TextBox132.Text) + CDec(TextBox872.Text) + CDec(TextBox871.Text)
                ' 6° fila
                TextBox142.Text = CDec(TextBox142.Text) + CDec(TextBox477.Text) + CDec(TextBox847.Text)
                TextBox139.Text = CDec(TextBox139.Text) + CDec(TextBox474.Text) + CDec(TextBox846.Text)
                TextBox136.Text = CDec(TextBox136.Text) + CDec(TextBox475.Text) + CDec(TextBox845.Text)
                TextBox133.Text = CDec(TextBox133.Text) + CDec(TextBox476.Text) + CDec(TextBox844.Text)
                TextBox131.Text = CDec(TextBox131.Text) + CDec(TextBox840.Text) + CDec(TextBox843.Text)
                TextBox130.Text = CDec(TextBox130.Text) + CDec(TextBox839.Text) + CDec(TextBox842.Text)
                TextBox128.Text = CDec(TextBox128.Text) + CDec(TextBox838.Text) + CDec(TextBox841.Text)
                ' 7° fila
                TextBox243.Text = CDec(TextBox243.Text) + CDec(TextBox856.Text) + CDec(TextBox852.Text)
                TextBox239.Text = CDec(TextBox239.Text) + CDec(TextBox855.Text) + CDec(TextBox851.Text)
                TextBox214.Text = CDec(TextBox214.Text) + CDec(TextBox854.Text) + CDec(TextBox850.Text)
                TextBox211.Text = CDec(TextBox211.Text) + CDec(TextBox853.Text) + CDec(TextBox849.Text)
                ' 8° fila
                TextBox143.Text = CDec(TextBox143.Text) + CDec(TextBox862.Text) + CDec(TextBox861.Text)
                'Totales por fila
                '1° fila
                TextBox106.Text = CDec(TextBox197.Text) + CDec(TextBox194.Text) + CDec(TextBox191.Text) + CDec(TextBox188.Text) + CDec(TextBox185.Text) + CDec(TextBox182.Text) + CDec(TextBox179.Text)
                TextBox965.Text = CDec(TextBox964.Text) + CDec(TextBox963.Text) + CDec(TextBox962.Text) + CDec(TextBox961.Text) + CDec(TextBox960.Text) + CDec(TextBox959.Text) + CDec(TextBox958.Text)
                TextBox966.Text = CDec(TextBox957.Text) + CDec(TextBox956.Text) + CDec(TextBox955.Text) + CDec(TextBox954.Text) + CDec(TextBox953.Text) + CDec(TextBox952.Text) + CDec(TextBox951.Text)
                '2° fila
                TextBox105.Text = CDec(TextBox196.Text) + CDec(TextBox193.Text) + CDec(TextBox190.Text) + CDec(TextBox187.Text) + CDec(TextBox184.Text) + CDec(TextBox181.Text) + CDec(TextBox178.Text)
                TextBox967.Text = CDec(TextBox950.Text) + CDec(TextBox949.Text) + CDec(TextBox948.Text) + CDec(TextBox947.Text) + CDec(TextBox946.Text) + CDec(TextBox945.Text) + CDec(TextBox944.Text)
                TextBox968.Text = CDec(TextBox943.Text) + CDec(TextBox942.Text) + CDec(TextBox941.Text) + CDec(TextBox940.Text) + CDec(TextBox939.Text) + CDec(TextBox938.Text) + CDec(TextBox937.Text)
                '3° fila
                TextBox104.Text = CDec(TextBox195.Text) + CDec(TextBox192.Text) + CDec(TextBox189.Text) + CDec(TextBox186.Text) + CDec(TextBox183.Text) + CDec(TextBox180.Text) + CDec(TextBox177.Text)
                TextBox969.Text = CDec(TextBox936.Text) + CDec(TextBox935.Text) + CDec(TextBox934.Text) + CDec(TextBox933.Text) + CDec(TextBox932.Text) + CDec(TextBox931.Text) + CDec(TextBox930.Text)
                TextBox970.Text = CDec(TextBox929.Text) + CDec(TextBox928.Text) + CDec(TextBox927.Text) + CDec(TextBox926.Text) + CDec(TextBox925.Text) + CDec(TextBox924.Text) + CDec(TextBox923.Text)
                '4° fila
                TextBox127.Text = CDec(TextBox142.Text) + CDec(TextBox139.Text) + CDec(TextBox136.Text) + CDec(TextBox133.Text) + CDec(TextBox131.Text) + CDec(TextBox130.Text) + CDec(TextBox128.Text)
                TextBox478.Text = CDec(TextBox477.Text) + CDec(TextBox474.Text) + CDec(TextBox475.Text) + CDec(TextBox476.Text) + CDec(TextBox840.Text) + CDec(TextBox839.Text) + CDec(TextBox838.Text)
                TextBox848.Text = CDec(TextBox847.Text) + CDec(TextBox846.Text) + CDec(TextBox845.Text) + CDec(TextBox844.Text) + CDec(TextBox843.Text) + CDec(TextBox842.Text) + CDec(TextBox841.Text)
                '5° fila
                '6° fila
                TextBox800.Text = CDec(TextBox174.Text) + CDec(TextBox171.Text) + CDec(TextBox168.Text) + CDec(TextBox165.Text) + CDec(TextBox162.Text) + CDec(TextBox159.Text) + CDec(TextBox156.Text) + CDec(TextBox153.Text) + CDec(TextBox150.Text) + CDec(TextBox147.Text) + CDec(TextBox144.Text) + CDec(TextBox141.Text) + CDec(TextBox138.Text) + CDec(TextBox132.Text)
                TextBox976.Text = CDec(TextBox863.Text) + CDec(TextBox864.Text) + CDec(TextBox866.Text) + CDec(TextBox865.Text) + CDec(TextBox870.Text) + CDec(TextBox869.Text) + CDec(TextBox868.Text) + CDec(TextBox867.Text) + CDec(TextBox878.Text) + CDec(TextBox877.Text) + CDec(TextBox876.Text) + CDec(TextBox875.Text) + CDec(TextBox874.Text) + CDec(TextBox873.Text)
                TextBox975.Text = CDec(TextBox892.Text) + CDec(TextBox891.Text) + CDec(TextBox890.Text) + CDec(TextBox889.Text) + CDec(TextBox888.Text) + CDec(TextBox887.Text) + CDec(TextBox886.Text) + CDec(TextBox885.Text) + CDec(TextBox884.Text) + CDec(TextBox883.Text) + CDec(TextBox882.Text) + CDec(TextBox881.Text) + CDec(TextBox880.Text) + CDec(TextBox879.Text)
                '7° fila
                TextBox375.Text = CDec(TextBox243.Text) + CDec(TextBox239.Text) + CDec(TextBox214.Text) + CDec(TextBox211.Text)
                TextBox858.Text = CDec(TextBox856.Text) + CDec(TextBox855.Text) + CDec(TextBox854.Text) + CDec(TextBox853.Text)
                TextBox857.Text = CDec(TextBox852.Text) + CDec(TextBox851.Text) + CDec(TextBox850.Text) + CDec(TextBox849.Text)
                MsgBox("SUMAS REALIZADAS", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
            Catch ex As Exception
                MsgBox("Error, favor de verificar las cifras ingresadas", MsgBoxStyle.Critical, "Error de captura")
            End Try
        End If
        If TextBox103.Text = "Gelatinas" Then
            Try

            Catch ex As Exception
                MsgBox("Error, favor de verificar las cifras ingresadas", MsgBoxStyle.Critical, "Error de captura")
            End Try
        End If
        'If TextBox103.Text = "Flanes y arroz" Then
        '    Try

        '        MsgBox("SUMAS REALIZADAS", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
        '    Catch ex As Exception
        '        MsgBox("Error, favor de verificar las cifras ingresadas", MsgBoxStyle.Critical, "Error de captura")
        '    End Try
        'End If
        If TextBox103.Text = "Cremosos" Then
            Try
                '-----------------------------------------Primera fila--------------------------------------------------------
                TextBox217.Text = CDec(TextBox217.Text) + CDec(TextBox446.Text) + CDec(TextBox748.Text) '25 guayaba

                '-----------------------------------------Segunda fila--------------------------------------------------------
                TextBox163.Text = CDec(TextBox163.Text) + CDec(TextBox449.Text) + CDec(TextBox745.Text) '18 guayaba
                TextBox447.Text = CDec(TextBox447.Text) + CDec(TextBox440.Text) + CDec(TextBox432.Text) '18 blueberry

                TextBox154.Text = CDec(TextBox154.Text) + CDec(TextBox456.Text) + CDec(TextBox742.Text) 'Zanahoria

                '-------------------------------------- Tercera fila--------------------------------------------------------
                TextBox175.Text = CDec(TextBox175.Text) + CDec(TextBox452.Text) + CDec(TextBox741.Text) 'minis guayaba
                TextBox445.Text = CDec(TextBox445.Text) + CDec(TextBox439.Text) + CDec(TextBox433.Text) 'minis blueberry


                ' -------------------------------------------Cuarta fila--------------------------------------------------------
                TextBox218.Text = CDec(TextBox218.Text) + CDec(TextBox455.Text) + CDec(TextBox738.Text) ' 1/4 guayaba
                TextBox444.Text = CDec(TextBox444.Text) + CDec(TextBox438.Text) + CDec(TextBox437.Text) ' 1/4 blueberry


                '------------------------------------------Quinta fila--------------------------------------------------------
                'TextBox352.Text = CDec(TextBox352.Text) + CDec(TextBox442.Text) + CDec(TextBox735.Text)
                'TextBox351.Text = CDec(TextBox351.Text) + CDec(TextBox441.Text) + CDec(TextBox734.Text)
                '------------------------------- Sexta fila--------------------------------------------------------
                TextBox209.Text = CDec(TextBox209.Text) + CDec(TextBox759.Text) + CDec(TextBox772.Text)
                TextBox207.Text = CDec(TextBox207.Text) + CDec(TextBox761.Text) + CDec(TextBox770.Text)
                TextBox200.Text = CDec(TextBox200.Text) + CDec(TextBox763.Text) + CDec(TextBox768.Text)

                TextBox198.Text = CDec(TextBox198.Text) + CDec(TextBox765.Text) + CDec(TextBox766.Text)
                '-------------------------------- Septima fila--------------------------------------------------------


                ' Suma de totales

                MsgBox("SUMAS REALIZADAS", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
            Catch ex As Exception
                MsgBox("Error, favor de verificar las cifras ingresadas", MsgBoxStyle.Critical, "Error de captura")
            End Try
        End If
        If TextBox103.Text = "Batidos" Then
            Try
                'Primera fila
                TextBox231.Text = CDec(TextBox231.Text) + CDec(TextBox797.Text) + CDec(TextBox793.Text)
                TextBox225.Text = CDec(TextBox225.Text) + CDec(TextBox795.Text) + CDec(TextBox791.Text)
                TextBox222.Text = CDec(TextBox222.Text) + CDec(TextBox794.Text) + CDec(TextBox790.Text)
                'Segunda fila
                TextBox109.Text = CDec(TextBox109.Text) + CDec(TextBox436.Text) + CDec(TextBox787.Text)
                'Tercera fila
                TextBox114.Text = CDec(TextBox114.Text) + CDec(TextBox463.Text) + CDec(TextBox783.Text)
                TextBox113.Text = CDec(TextBox113.Text) + CDec(TextBox462.Text) + CDec(TextBox782.Text)
                TextBox112.Text = CDec(TextBox112.Text) + CDec(TextBox461.Text) + CDec(TextBox781.Text)
                'Cuarta fila
                TextBox120.Text = CDec(TextBox120.Text) + CDec(TextBox809.Text) + CDec(TextBox820.Text)
                TextBox991.Text = CDec(TextBox991.Text) + CDec(TextBox990.Text) + CDec(TextBox989.Text)
                TextBox988.Text = CDec(TextBox988.Text) + CDec(TextBox987.Text) + CDec(TextBox986.Text)
                'Quinta fila
                TextBox985.Text = CDec(TextBox985.Text) + CDec(TextBox984.Text) + CDec(TextBox983.Text)
                'Sexta fila
                TextBox124.Text = CDec(TextBox124.Text) + CDec(TextBox811.Text) + CDec(TextBox815.Text)
                TextBox123.Text = CDec(TextBox123.Text) + CDec(TextBox810.Text) + CDec(TextBox814.Text)
                TextBox151.Text = CDec(TextBox151.Text) + CDec(TextBox804.Text) + CDec(TextBox806.Text)
                TextBox148.Text = CDec(TextBox148.Text) + CDec(TextBox803.Text) + CDec(TextBox805.Text)
                'Septima fila
                TextBox353.Text = CDec(TextBox353.Text) + CDec(TextBox467.Text) + CDec(TextBox837.Text)
                TextBox354.Text = CDec(TextBox354.Text) + CDec(TextBox466.Text) + CDec(TextBox836.Text)
                TextBox355.Text = CDec(TextBox355.Text) + CDec(TextBox465.Text) + CDec(TextBox835.Text)
                'Octava fila 
                TextBox361.Text = CDec(TextBox361.Text) + CDec(TextBox470.Text) + CDec(TextBox834.Text)
                TextBox357.Text = CDec(TextBox357.Text) + CDec(TextBox469.Text) + CDec(TextBox833.Text)
                TextBox356.Text = CDec(TextBox356.Text) + CDec(TextBox468.Text) + CDec(TextBox832.Text)
                'novena fila
                TextBox364.Text = CDec(TextBox364.Text) + CDec(TextBox473.Text) + CDec(TextBox831.Text)
                TextBox363.Text = CDec(TextBox363.Text) + CDec(TextBox472.Text) + CDec(TextBox830.Text)
                TextBox362.Text = CDec(TextBox362.Text) + CDec(TextBox471.Text) + CDec(TextBox829.Text)
                'Suma totales
                'Priemra fila
                'TextBox210.Text = CDec(TextBox231.Text) + CDec(TextBox228.Text) + CDec(TextBox225.Text) + CDec(TextBox222.Text)
                'TextBox799.Text = CDec(TextBox797.Text) + CDec(TextBox796.Text) + CDec(TextBox795.Text) + CDec(TextBox794.Text)
                'TextBox798.Text = CDec(TextBox793.Text) + CDec(TextBox792.Text) + CDec(TextBox791.Text) + CDec(TextBox790.Text)
                'Segunda fila
                'TextBox107.Text = CDec(TextBox111.Text) + CDec(TextBox110.Text) + CDec(TextBox109.Text) + CDec(TextBox108.Text) + CDec(TextBox115.Text) + CDec(TextBox114.Text) + CDec(TextBox113.Text) + CDec(TextBox112.Text)
                'TextBox434.Text = CDec(TextBox438.Text) + CDec(TextBox437.Text) + CDec(TextBox436.Text) + CDec(TextBox435.Text) + CDec(TextBox464.Text) + CDec(TextBox463.Text) + CDec(TextBox462.Text) + CDec(TextBox461.Text)
                'TextBox785.Text = CDec(TextBox789.Text) + CDec(TextBox788.Text) + CDec(TextBox787.Text) + CDec(TextBox786.Text) + CDec(TextBox784.Text) + CDec(TextBox783.Text) + CDec(TextBox782.Text) + CDec(TextBox781.Text)

                MsgBox("SUMAS REALIZADAS", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
            Catch ex As Exception
                MsgBox("Error, favor de verificar las cifras ingresadas", MsgBoxStyle.Critical, "Error de captura")
            End Try
        End If
    End Sub

    Private Sub Button18_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub GroupBox8_Enter(sender As Object, e As EventArgs) Handles GroupBox8.Enter

    End Sub

    Private Sub Button18_GotFocus(sender As Object, e As EventArgs)
        Me.TextBox18.BackColor = Color.SkyBlue
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If TextBox103.Text = "" Then
            MsgBox("Debes seleccionar algun departamento primero", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
            Exit Sub
        Else
            GroupBox1.Visible = False
            GroupBox2.Visible = False
            GroupBox3.Visible = False
            GroupBox4.Visible = False
            GroupBox5.Visible = False
            GroupBox6.Visible = False
            GroupBox7.Visible = False
            GroupBox8.Visible = False
            GroupBox9.Visible = True
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
    'Se agrega la primera ronda de bases de madera
    Private Sub Llenar_base_madera(base As String, cantidad As Integer)
        Try
            Dim cmd As New OleDbCommand
            Dim r1 As Integer

            cmd = New OleDbCommand("INSERT INTO Bases_Madera(Fecha,Departamento,Base,Cantidad) 
                    VALUES('" & Label3.Text & "','" & TextBox103.Text & "','" & base & "','" & cantidad & "')", conexion)
            conexion.Open()
            r1 = cmd.ExecuteNonQuery
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub Base_Madera()
        'Solo envia la informacion de los texbox que sean diferentes a 0
        If TextBox1014.Text <> 0 Then
            Llenar_base_madera(Label612.Text, TextBox1014.Text)
        End If
        If TextBox1007.Text <> 0 Then
            Llenar_base_madera(Label611.Text, TextBox1007.Text)
        End If
        If TextBox1008.Text <> 0 Then
            Llenar_base_madera(Label610.Text, TextBox1008.Text)
        End If
        If TextBox1009.Text <> 0 Then
            Llenar_base_madera(Label609.Text, TextBox1009.Text)
        End If
        If TextBox1013.Text <> 0 Then
            Llenar_base_madera(Label608.Text, TextBox1013.Text)
        End If
        If TextBox1012.Text <> 0 Then
            Llenar_base_madera(Label607.Text, TextBox1012.Text)
        End If
        If TextBox1011.Text <> 0 Then
            Llenar_base_madera(Label606.Text, TextBox1011.Text)
        End If
        If TextBox1010.Text <> 0 Then
            Llenar_base_madera(Label605.Text, TextBox1010.Text)
        End If
        If TextBox1017.Text <> 0 Then
            Llenar_base_madera(Label604.Text, TextBox1017.Text)
        End If
        If TextBox1016.Text <> 0 Then
            Llenar_base_madera(Label603.Text, TextBox1016.Text)
        End If
        If TextBox1015.Text <> 0 Then
            Llenar_base_madera(Label602.Text, TextBox1015.Text)
        End If
        If TextBox1028.Text <> 0 Then
            Llenar_base_madera(Label601.Text, TextBox1028.Text)
        End If
        If TextBox1027.Text <> 0 Then
            Llenar_base_madera(Label600.Text, TextBox1027.Text)
        End If
        If TextBox1026.Text <> 0 Then
            Llenar_base_madera(Label599.Text, TextBox1026.Text)
        End If
        If TextBox1025.Text <> 0 Then
            Llenar_base_madera(Label598.Text, TextBox1025.Text)
        End If
        If TextBox1024.Text <> 0 Then
            Llenar_base_madera(Label597.Text, TextBox1024.Text)
        End If
        If TextBox1023.Text <> 0 Then
            Llenar_base_madera(Label596.Text, TextBox1023.Text)
        End If
        If TextBox1022.Text <> 0 Then
            Llenar_base_madera(Label595.Text, TextBox1022.Text)
        End If
        If TextBox1021.Text <> 0 Then
            Llenar_base_madera(Label594.Text, TextBox1021.Text)
        End If
        If TextBox1036.Text <> 0 Then
            Llenar_base_madera(Label523.Text, TextBox1036.Text)
        End If
        If TextBox1035.Text <> 0 Then
            Llenar_base_madera(Label522.Text, TextBox1035.Text)
        End If
        If TextBox1034.Text <> 0 Then
            Llenar_base_madera(Label521.Text, TextBox1034.Text)
        End If
        If TextBox1033.Text <> 0 Then
            Llenar_base_madera(Label519.Text, TextBox1033.Text)
        End If
        If TextBox1032.Text <> 0 Then
            Llenar_base_madera(Label518.Text, TextBox1032.Text)
        End If
        If TextBox1031.Text <> 0 Then
            Llenar_base_madera(Label516.Text, TextBox1031.Text)
        End If

    End Sub
    Private Sub Insertar_Bases_Madera()
        Try

            If TextBox103.Text = "Pastelería 1" Then
                Base_Madera()
            End If

            If TextBox103.Text = "Pastelería 2" Then
                Base_Madera()
            End If

            If TextBox103.Text = "Batidos" Then
                Base_Madera()
            End If

            If TextBox103.Text = "Cremosos" Then
                Base_Madera()
            End If

            If TextBox103.Text = "Flanes y arroz" Then
                Base_Madera()
            End If

            If TextBox103.Text = "Gelatinas" Then
                Base_Madera()
            End If

            If TextBox103.Text = "Panadería" Then
                Base_Madera()
            End If
            MsgBox("Información de Bases de Madera enviada correctamente. Gracias.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
            PrintDocument2.Print()
            'Deja en 0 todos los textbox del formulario de bases
            Try
                TextBox1014.Text = 0
                TextBox1007.Text = 0
                TextBox1008.Text = 0
                TextBox1009.Text = 0
                TextBox1013.Text = 0
                TextBox1012.Text = 0
                TextBox1011.Text = 0
                TextBox1010.Text = 0
                TextBox1017.Text = 0
                TextBox1016.Text = 0
                TextBox1015.Text = 0
                TextBox1028.Text = 0
                TextBox1027.Text = 0
                TextBox1026.Text = 0
                TextBox1025.Text = 0
                TextBox1024.Text = 0
                TextBox1023.Text = 0
                TextBox1022.Text = 0
                TextBox1021.Text = 0
                TextBox1036.Text = 0
                TextBox1035.Text = 0
                TextBox1034.Text = 0
                TextBox1033.Text = 0
                TextBox1032.Text = 0
                TextBox1031.Text = 0
            Catch ex As Exception

            End Try
            'Despues de enviar limpia el recuadro del departamento
            TextBox103.Text = ""
            'Esconde el formulario
            GroupBox9.Visible = False
        Catch ex As Exception
            MsgBox("Error, favor de verificar que seleccionaste algún departamento", MsgBoxStyle.Critical, "Error de captura")
        End Try
    End Sub

    'Si se llegara a agregar mas bases de madera
    Private Sub Llenar_base_madera2(base As String, cantidad As Integer)
        Try
            Dim cmd As New OleDbCommand
            Dim r1 As Integer

            cmd = New OleDbCommand("INSERT INTO Bases_Madera(Fecha,Departamento,Base,Cantidad,Ronda) 
                    VALUES('" & Label3.Text & "','" & TextBox103.Text & "','" & base & "','" & cantidad & "','Segunda')", conexion)
            conexion.Open()
            r1 = cmd.ExecuteNonQuery
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub Base_Madera2()
        'Solo envia la informacion de los texbox que sean diferentes a 0
        If TextBox1014.Text <> 0 Then
            Llenar_base_madera2(Label612.Text, TextBox1014.Text)
        End If
        If TextBox1007.Text <> 0 Then
            Llenar_base_madera2(Label611.Text, TextBox1007.Text)
        End If
        If TextBox1008.Text <> 0 Then
            Llenar_base_madera2(Label610.Text, TextBox1008.Text)
        End If
        If TextBox1009.Text <> 0 Then
            Llenar_base_madera2(Label609.Text, TextBox1009.Text)
        End If
        If TextBox1013.Text <> 0 Then
            Llenar_base_madera2(Label608.Text, TextBox1013.Text)
        End If
        If TextBox1012.Text <> 0 Then
            Llenar_base_madera2(Label607.Text, TextBox1012.Text)
        End If
        If TextBox1011.Text <> 0 Then
            Llenar_base_madera2(Label606.Text, TextBox1011.Text)
        End If
        If TextBox1010.Text <> 0 Then
            Llenar_base_madera2(Label605.Text, TextBox1010.Text)
        End If
        If TextBox1017.Text <> 0 Then
            Llenar_base_madera2(Label604.Text, TextBox1017.Text)
        End If
        If TextBox1016.Text <> 0 Then
            Llenar_base_madera2(Label603.Text, TextBox1016.Text)
        End If
        If TextBox1015.Text <> 0 Then
            Llenar_base_madera2(Label602.Text, TextBox1015.Text)
        End If
        If TextBox1028.Text <> 0 Then
            Llenar_base_madera2(Label601.Text, TextBox1028.Text)
        End If
        If TextBox1027.Text <> 0 Then
            Llenar_base_madera2(Label600.Text, TextBox1027.Text)
        End If
        If TextBox1026.Text <> 0 Then
            Llenar_base_madera2(Label599.Text, TextBox1026.Text)
        End If
        If TextBox1025.Text <> 0 Then
            Llenar_base_madera2(Label598.Text, TextBox1025.Text)
        End If
        If TextBox1024.Text <> 0 Then
            Llenar_base_madera2(Label597.Text, TextBox1024.Text)
        End If
        If TextBox1023.Text <> 0 Then
            Llenar_base_madera2(Label596.Text, TextBox1023.Text)
        End If
        If TextBox1022.Text <> 0 Then
            Llenar_base_madera2(Label595.Text, TextBox1022.Text)
        End If
        If TextBox1021.Text <> 0 Then
            Llenar_base_madera2(Label594.Text, TextBox1021.Text)
        End If
        If TextBox1036.Text <> 0 Then
            Llenar_base_madera2(Label523.Text, TextBox1036.Text)
        End If
        If TextBox1035.Text <> 0 Then
            Llenar_base_madera2(Label522.Text, TextBox1035.Text)
        End If
        If TextBox1034.Text <> 0 Then
            Llenar_base_madera2(Label521.Text, TextBox1034.Text)
        End If
        If TextBox1033.Text <> 0 Then
            Llenar_base_madera2(Label519.Text, TextBox1033.Text)
        End If
        If TextBox1032.Text <> 0 Then
            Llenar_base_madera2(Label518.Text, TextBox1032.Text)
        End If
        If TextBox1031.Text <> 0 Then
            Llenar_base_madera2(Label516.Text, TextBox1031.Text)
        End If

    End Sub
    Private Sub Insertar_Bases_Madera2()
        Try

            If TextBox103.Text = "Pastelería 1" Then
                Base_Madera2()
            End If

            If TextBox103.Text = "Pastelería 2" Then
                Base_Madera2()
            End If

            If TextBox103.Text = "Batidos" Then
                Base_Madera2()
            End If

            If TextBox103.Text = "Cremosos" Then
                Base_Madera2()
            End If

            If TextBox103.Text = "Flanes y arroz" Then
                Base_Madera2()
            End If

            If TextBox103.Text = "Gelatinas" Then
                Base_Madera2()
            End If

            If TextBox103.Text = "Panadería" Then
                Base_Madera2()
            End If
            MsgBox("Información de Bases de Madera enviada correctamente. Gracias.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
            PrintDocument2.Print()
            'Deja en 0 todos los textbox del formulario de bases
            Try
                TextBox1014.Text = 0
                TextBox1007.Text = 0
                TextBox1008.Text = 0
                TextBox1009.Text = 0
                TextBox1013.Text = 0
                TextBox1012.Text = 0
                TextBox1011.Text = 0
                TextBox1010.Text = 0
                TextBox1017.Text = 0
                TextBox1016.Text = 0
                TextBox1015.Text = 0
                TextBox1028.Text = 0
                TextBox1027.Text = 0
                TextBox1026.Text = 0
                TextBox1025.Text = 0
                TextBox1024.Text = 0
                TextBox1023.Text = 0
                TextBox1022.Text = 0
                TextBox1021.Text = 0
                TextBox1036.Text = 0
                TextBox1035.Text = 0
                TextBox1034.Text = 0
                TextBox1033.Text = 0
                TextBox1032.Text = 0
                TextBox1031.Text = 0
            Catch ex As Exception

            End Try
            'Despues de enviar limpia el recuadro del departamento
            TextBox103.Text = ""
            'Esconde el formulario
            GroupBox9.Visible = False
        Catch ex As Exception
            MsgBox("Error, favor de verificar que seleccionaste algún departamento", MsgBoxStyle.Critical, "Error de captura")
        End Try
    End Sub

    'Boton guardar bases de madera
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        Try
            Dim cmd As New OleDbCommand
            Dim r1 As String

            cmd = New OleDbCommand("SELECT Fecha From Bases_Madera where Fecha = '" & Label3.Text & "'", conexion)
            conexion.Open()
            r1 = cmd.ExecuteScalar()
            conexion.Close()
            If r1 = Label3.Text Then
                Dim resultado As Integer = MessageBox.Show("Ya existe información guardada. ¿Deseas agregar mas tablas?", "caption", MessageBoxButtons.YesNoCancel)
                If resultado = DialogResult.Cancel Then
                ElseIf resultado = DialogResult.No Then
                ElseIf resultado = DialogResult.Yes Then
                    Insertar_Bases_Madera2()
                End If
            Else
                Insertar_Bases_Madera()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub




    Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage
        Dim adaptador As New OleDbDataAdapter
        Dim tabla As New DataTable
        Dim buscar As String
        Dim cmd As New OleDbCommand
        Dim r1 As String = ""

        Try


            'Consulta si ya hay informacion ya agregada a la tabla de bases de madera
            cmd = New OleDbCommand("SELECT Ronda From Bases_Madera where Fecha = '" & Label3.Text & "' and  Ronda = 'Segunda'", conexion)
            conexion.Open()
            r1 = cmd.ExecuteScalar()
            conexion.Close()

            'Si se agrego mas informacion imprimir la informacion adicional 
            If r1 = "Segunda" Then
                buscar = ("select * from Bases_Madera where Fecha='" & DateTimePicker1.Value & "' and Departamento='" & TextBox103.Text & "' and Ronda='Segunda'")
            Else
                buscar = ("select * from Bases_Madera where Fecha='" & DateTimePicker1.Value & "' and Departamento='" & TextBox103.Text & "'")
            End If

            adaptador = New OleDbDataAdapter(buscar, conexion)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView5.DataSource = tabla
        Catch ex As Exception
            MsgBox(ex.Message & " No hay ningún reporte enviado aún.")
            conexion.Close()

            Exit Sub
        End Try


        Dim i As Integer = 0
        Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
        Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
        Dim prFont2 As New Font("Arial", 8, GraphicsUnit.Point)
        Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
        Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
        Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
        e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 65, 65)
        e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 69, 75)
        e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 10, 90)
        e.Graphics.DrawString("S.A. de C.V.", prFont2, Brushes.Black, 60, 105)
        e.Graphics.DrawString("RFC CSS1512219U3", prFont2, Brushes.Black, 37, 120)
        e.Graphics.DrawString("Departartamento: " & TextBox103.Text, prFont2, Brushes.Black, 10, 135)
        e.Graphics.DrawString("REPORTE ENVIADO A CXC", prFont2, Brushes.Black, 10, 150)

        e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 10, 165)
        e.Graphics.DrawString(DateTimePicker1.Value, prFont2, Brushes.Black, 50, 165)
        If r1 = "Segunda" Then
            e.Graphics.DrawString("Bases Anexadas", prFont1, Brushes.Black, 25, 185)
        Else
            e.Graphics.DrawString("Bases de Madera", prFont1, Brushes.Black, 25, 185)
        End If


        While i < DataGridView5.RowCount

            e.Graphics.DrawString(DataGridView5.Item(3, i).Value, prFont2, Brushes.Black, 0, i * 15 + 210)
            e.Graphics.DrawString(DataGridView5.Item(4, i).Value, prFont2, Brushes.Black, 160, i * 15 + 210)

            i += 1
        End While

    End Sub

#Region "Evento que al dar click limpia el recuadro para ingresar numero"

    Private Sub TextBox1014_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1014.MouseClick
        TextBox1014.Text = ""
    End Sub
    Private Sub TextBox1007_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1007.MouseClick
        TextBox1007.Text = ""
    End Sub
    Private Sub TextBox1008_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1008.MouseClick
        TextBox1008.Text = ""
    End Sub
    Private Sub TextBox1009_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1009.MouseClick
        TextBox1009.Text = ""
    End Sub
    Private Sub TextBox1013_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1013.MouseClick
        TextBox1013.Text = ""
    End Sub
    Private Sub TextBox1012_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1012.MouseClick
        TextBox1012.Text = ""
    End Sub
    Private Sub TextBox1011_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1011.MouseClick
        TextBox1011.Text = ""
    End Sub
    Private Sub TextBox1010_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1010.MouseClick
        TextBox1010.Text = ""
    End Sub
    Private Sub TextBox1017_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1017.MouseClick
        TextBox1017.Text = ""
    End Sub
    Private Sub TextBox1016_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1016.MouseClick
        TextBox1016.Text = ""
    End Sub
    Private Sub TextBox1015_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1015.MouseClick
        TextBox1015.Text = ""
    End Sub
    Private Sub TextBox1028_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1028.MouseClick
        TextBox1028.Text = ""
    End Sub
    Private Sub TextBox1027_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1027.MouseClick
        TextBox1027.Text = ""
    End Sub
    Private Sub TextBox1026_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1026.MouseClick
        TextBox1026.Text = ""
    End Sub
    Private Sub TextBox1025_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1025.MouseClick
        TextBox1025.Text = ""
    End Sub
    Private Sub TextBox1024_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1024.MouseClick
        TextBox1024.Text = ""
    End Sub
    Private Sub TextBox1023_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1023.MouseClick
        TextBox1023.Text = ""
    End Sub
    Private Sub TextBox1022_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1022.MouseClick
        TextBox1022.Text = ""
    End Sub
    Private Sub TextBox1021_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1021.MouseClick
        TextBox1021.Text = ""
    End Sub
    Private Sub TextBox1036_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1036.MouseClick
        TextBox1036.Text = ""
    End Sub
    Private Sub TextBox1035_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1035.MouseClick
        TextBox1035.Text = ""
    End Sub
    Private Sub TextBox1034_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1034.MouseClick
        TextBox1034.Text = ""
    End Sub
    Private Sub TextBox1033_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1033.MouseClick
        TextBox1033.Text = ""
    End Sub
    Private Sub TextBox1032_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1032.MouseClick
        TextBox1032.Text = ""
    End Sub
    Private Sub TextBox1031_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1031.MouseClick
        TextBox1031.Text = ""
    End Sub
    Dim validar As String
    Private Sub Button21_Click_1(sender As Object, e As EventArgs)

        validar = "Si"
        Try
            Dim cmd15 As New OleDbCommand
            cmd15 = New OleDbCommand("delete from Reporte_Producción where Producto in ('Pizza reb','Cuernito jamon y queso','Hojaldra mole verde','Marina mole rojo','Rollo Sal Q/Ama','Rollo Jámón Q/Phi') 
            and Fecha='" & Label3.Text & "'", conexion3)
            conexion3.Open()
            cmd15.ExecuteNonQuery()
            conexion3.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs)

        'Brawnie
        Try
            Dim cmd15 As New OleDbCommand
            cmd15 = New OleDbCommand("delete from Reporte_Producción where Fecha='" & Label3.Text & "' and Categoría='Brownie'", conexion4)
            conexion4.Open()
            cmd15.ExecuteNonQuery()
            conexion4.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Brownie
        Try
            Dim cmd As New OleDbCommand
            Dim r1 As Integer

            cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label59.Text & "','" & CDec(TextBox108.Text) & "','" & Label3.Text & "','Brownie')", conexion4)
            conexion4.Open()
            r1 = cmd.ExecuteNonQuery
            conexion4.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        PrintDocument3.Print()
    End Sub

    Private Sub PrintDocument3_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument3.PrintPage

        Dim i As Integer = 0
        Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
        Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
        Dim prFont2 As New Font("Arial", 8, GraphicsUnit.Point)
        Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
        Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
        Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
        e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 65, 65)
        e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 69, 75)
        e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 10, 90)
        e.Graphics.DrawString("S.A. de C.V.", prFont2, Brushes.Black, 60, 105)
        e.Graphics.DrawString("RFC CSS1512219U3", prFont2, Brushes.Black, 37, 120)
        e.Graphics.DrawString("Departartamento: " & TextBox103.Text, prFont2, Brushes.Black, 0, 135)
        e.Graphics.DrawString("REPORTE ENVIADO A CXC", prFont2, Brushes.Black, 10, 150)


        e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 10, 165)
        e.Graphics.DrawString(Label3.Text, prFont2, Brushes.Black, 50, 165)

        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Reporte_Producción where Fecha='" & Label3.Text & "' and  Categoría BETWEEN 'Brazo' AND 'Brownie'")
            adaptador = New OleDbDataAdapter(buscar, conexion4)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla
        Catch ex As Exception
            MsgBox(ex.Message & " No hay ningún reporte enviado aún.")
            conexion.Close()

            Exit Sub
        End Try

        While i < DataGridView1.RowCount

            e.Graphics.DrawString(DataGridView1.Item(0, i).Value, prFont2, Brushes.Black, 0, i * 15 + 190)
            e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont2, Brushes.Black, 125, i * 15 + 190)
            e.Graphics.DrawString(DataGridView1.Item(3, i).Value, prFont2, Brushes.Black, 155, i * 15 + 190)

            i += 1
        End While
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub PrintDocument4_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument4.PrintPage
        Dim i1 As Integer = 0
        Dim prFont12 As New Font("Arial", 14, GraphicsUnit.Point)
        Dim prFont11 As New Font("Arial", 10, GraphicsUnit.Point)
        Dim prFont21 As New Font("Arial", 8, GraphicsUnit.Point)
        Dim prFont31 As New Font("Arial", 12, GraphicsUnit.Point)
        Dim prFont71 As New Font("Fontastique", 7, GraphicsUnit.Point)
        Dim prFont81 As New Font("Arial", 7, GraphicsUnit.Point)
        e.Graphics.DrawString("Rosa de Sarón", prFont71, Brushes.Black, 65, 65)
        e.Graphics.DrawString("Pastelerías", prFont71, Brushes.Black, 69, 75)
        e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont21, Brushes.Black, 10, 90)
        e.Graphics.DrawString("S.A. de C.V.", prFont21, Brushes.Black, 60, 105)
        e.Graphics.DrawString("RFC CSS1512219U3", prFont21, Brushes.Black, 37, 120)
        e.Graphics.DrawString("Departartamento: " & TextBox103.Text, prFont21, Brushes.Black, 0, 135)
        e.Graphics.DrawString("REPORTE ENVIADO A CXC", prFont21, Brushes.Black, 10, 150)


        e.Graphics.DrawString("Fecha:", prFont21, Brushes.Black, 10, 165)
        e.Graphics.DrawString(Label3.Text, prFont21, Brushes.Black, 50, 165)

        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Reporte_Producción where Fecha='" & Label3.Text & "' and  Producto IN ('Pizza reb','Cuernito jamon y queso','Hojaldra mole verde','Marina mole rojo','Rollo Sal Q/Ama','Rollo Jámón Q/Phi')")
            adaptador = New OleDbDataAdapter(buscar, conexion3)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla
        Catch ex As Exception
            MsgBox(ex.Message & " No hay ningún reporte enviado aún.")
            conexion3.Close()

            Exit Sub
        End Try

        While i1 < DataGridView1.RowCount

            e.Graphics.DrawString(DataGridView1.Item(0, i1).Value, prFont21, Brushes.Black, 0, i1 * 15 + 190)
            e.Graphics.DrawString(DataGridView1.Item(1, i1).Value, prFont21, Brushes.Black, 125, i1 * 15 + 190)
            e.Graphics.DrawString(DataGridView1.Item(3, i1).Value, prFont21, Brushes.Black, 155, i1 * 15 + 190)

            i1 += 1
        End While
        Try

            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Reporte_Producción where Fecha='" & Label3.Text & "' and  Producto='Galleta decorada'")
            adaptador = New OleDbDataAdapter(buscar, conexion6)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView2.DataSource = tabla
        Catch ex As Exception
            MsgBox(ex.Message & " No hay ningún reporte enviado aún.")
            conexion6.Close()

            Exit Sub
        End Try

        While i1 < DataGridView2.RowCount

            e.Graphics.DrawString(DataGridView2.Item(0, i1).Value, prFont21, Brushes.Black, 0, i1 * 15 + 190)
            e.Graphics.DrawString(DataGridView2.Item(1, i1).Value, prFont21, Brushes.Black, 125, i1 * 15 + 190)
            e.Graphics.DrawString(DataGridView2.Item(3, i1).Value, prFont21, Brushes.Black, 155, i1 * 15 + 190)

            i1 += 1
        End While
    End Sub


    Private Sub TextBox197_Click(sender As Object, e As EventArgs) Handles TextBox197.Click
        TextBox197.Text = ""
    End Sub

    Private Sub TextBox197_TextChanged(sender As Object, e As EventArgs) Handles TextBox197.TextChanged

    End Sub

    Private Sub TextBox194_TextChanged(sender As Object, e As EventArgs) Handles TextBox194.TextChanged

    End Sub

    Private Sub Button18_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox7_Enter(sender As Object, e As EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub PrintDocument5_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument5.PrintPage
        TextBox103.Text = "Especialidades"
        Dim i As Integer = 0


        Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
        Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
        Dim prFont2 As New Font("Arial", 8, GraphicsUnit.Point)
        Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
        Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
        Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
        e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 65, 65)
        e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 69, 75)
        e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 10, 90)
        e.Graphics.DrawString("S.A. de C.V.", prFont2, Brushes.Black, 60, 105)
        e.Graphics.DrawString("RFC CSS1512219U3", prFont2, Brushes.Black, 37, 120)
        e.Graphics.DrawString("Departartamento: " & TextBox103.Text, prFont2, Brushes.Black, 0, 135)
        e.Graphics.DrawString("REPORTE ENVIADO A CXC", prFont2, Brushes.Black, 10, 150)


        e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 10, 165)
        e.Graphics.DrawString(Label3.Text, prFont2, Brushes.Black, 50, 165)

        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Reporte_Producción where Fecha='" & Label3.Text & "' and Producto in('Pay maracuya G.','Pay maracuya individual')")
            adaptador = New OleDbDataAdapter(buscar, conexion)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla
        Catch ex As Exception
            MsgBox(ex.Message & " No hay ningún reporte enviado aún.")
            conexion.Close()

            Exit Sub
        End Try


        While i < DataGridView1.RowCount

            e.Graphics.DrawString(DataGridView1.Item(0, i).Value, prFont2, Brushes.Black, 0, i * 15 + 190)
            e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont2, Brushes.Black, 125, i * 15 + 190)
            e.Graphics.DrawString(DataGridView1.Item(3, i).Value, prFont2, Brushes.Black, 155, i * 15 + 190)

            i += 1
        End While
        Dim i2 As Integer = 0


        While i2 < DataGridView3.RowCount

            e.Graphics.DrawString(DataGridView3.Item(0, i2).Value, prFont2, Brushes.Black, 0, i2 * 15 + 220)
            e.Graphics.DrawString(DataGridView3.Item(1, i2).Value, prFont2, Brushes.Black, 125, i2 * 15 + 220)
            e.Graphics.DrawString(DataGridView3.Item(3, i2).Value, prFont2, Brushes.Black, 155, i2 * 15 + 220)

            i2 += 1
        End While


        Dim i1 As Integer = 0

        Dim prFont10 As New Font("Arial", 8, GraphicsUnit.Point)
        Try
            Dim adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from Reporte_Producción where Fecha='" & Label3.Text & "' and Producto in('Manzana Chamoy','Manzana Gourmet')")
            adaptador1 = New OleDbDataAdapter(buscar1, conexion4)
            tabla1 = New DataTable
            adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1
        Catch ex As Exception
            MsgBox(ex.Message & " No hay ningún reporte enviado aún.")
            conexion4.Close()

            Exit Sub
        End Try


        While i1 < DataGridView2.RowCount

            e.Graphics.DrawString(DataGridView2.Item(0, i1).Value, prFont10, Brushes.Black, 0, i1 * 15 + 300)
            e.Graphics.DrawString(DataGridView2.Item(1, i1).Value, prFont10, Brushes.Black, 125, i1 * 15 + 300)
            e.Graphics.DrawString(DataGridView2.Item(3, i1).Value, prFont10, Brushes.Black, 155, i1 * 15 + 300)

            i1 += 1
        End While

    End Sub

    Private Sub Button18_Click_3(sender As Object, e As EventArgs)
        PrintDocument6.Print()

    End Sub

    Private Sub PrintDocument6_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument6.PrintPage
        Dim i1 As Integer = 0

        Dim prFont10 As New Font("Arial", 8, GraphicsUnit.Point)
        Try
            Dim adaptador1 As New OleDbDataAdapter
            Dim tabla1 As New DataTable
            Dim buscar1 As String

            buscar1 = ("select *from Reporte_Producción where Fecha='" & Label3.Text & "' and Producto in('Manzana Chamoy','Manzana Gourmet')")
            adaptador1 = New OleDbDataAdapter(buscar1, conexion4)
            tabla1 = New DataTable
            adaptador1.Fill(tabla1)
            DataGridView2.DataSource = tabla1
        Catch ex As Exception
            MsgBox(ex.Message & " No hay ningún reporte enviado aún.")
            conexion4.Close()

            Exit Sub
        End Try


        While i1 < DataGridView2.RowCount

            e.Graphics.DrawString(DataGridView2.Item(0, i1).Value, prFont10, Brushes.Black, 0, i1 * 15 + 0)
            e.Graphics.DrawString(DataGridView2.Item(1, i1).Value, prFont10, Brushes.Black, 125, i1 * 15 + 0)
            e.Graphics.DrawString(DataGridView2.Item(3, i1).Value, prFont10, Brushes.Black, 155, i1 * 15 + 0)

            i1 += 1
        End While
    End Sub

    Private Sub GroupBox6_Enter(sender As Object, e As EventArgs) Handles GroupBox6.Enter

    End Sub

    Private Sub TextBox827_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PrintDocument7_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument7.PrintPage
        Dim i As Integer = 0
        Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
        Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
        Dim prFont2 As New Font("Arial", 8, GraphicsUnit.Point)
        Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
        Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
        Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
        e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 65, 65)
        e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 69, 75)
        e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 10, 90)
        e.Graphics.DrawString("S.A. de C.V.", prFont2, Brushes.Black, 60, 105)
        e.Graphics.DrawString("RFC CSS1512219U3", prFont2, Brushes.Black, 37, 120)
        e.Graphics.DrawString("Departartamento: " & TextBox103.Text, prFont2, Brushes.Black, 0, 135)
        e.Graphics.DrawString("REPORTE ENVIADO A CXC", prFont2, Brushes.Black, 10, 150)

        e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 10, 165)
        e.Graphics.DrawString(Label3.Text, prFont2, Brushes.Black, 50, 165)

        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Reporte_Producción where Fecha='" & Label3.Text & "' AND Categoría='Reyes'")
            adaptador = New OleDbDataAdapter(buscar, conexion6)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla
        Catch ex As Exception
            MsgBox(ex.Message & " No hay ningún reporte enviado aún.")
            conexion6.Close()

            Exit Sub
        End Try

        While i < DataGridView1.RowCount

            e.Graphics.DrawString(DataGridView1.Item(0, i).Value, prFont2, Brushes.Black, 0, i * 15 + 190)
            e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont2, Brushes.Black, 125, i * 15 + 190)
            e.Graphics.DrawString(DataGridView1.Item(3, i).Value, prFont2, Brushes.Black, 155, i * 15 + 190)

            i += 1
        End While
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button18_Click_4(sender As Object, e As EventArgs)

    End Sub

    Private Sub PrintDocument8_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument8.PrintPage
        Dim i As Integer = 0
        Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
        Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
        Dim prFont2 As New Font("Arial", 8, GraphicsUnit.Point)
        Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
        Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
        Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
        e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 65, 65)
        e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 69, 75)
        e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 10, 90)
        e.Graphics.DrawString("S.A. de C.V.", prFont2, Brushes.Black, 60, 105)
        e.Graphics.DrawString("RFC CSS1512219U3", prFont2, Brushes.Black, 37, 120)
        e.Graphics.DrawString("Departartamento: " & TextBox103.Text, prFont2, Brushes.Black, 0, 135)
        e.Graphics.DrawString("REPORTE ENVIADO A CXC", prFont2, Brushes.Black, 10, 150)


        e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 10, 165)
        e.Graphics.DrawString(Label3.Text, prFont2, Brushes.Black, 50, 165)

        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Reporte_Producción where Fecha='" & Label3.Text & "'")
            adaptador = New OleDbDataAdapter(buscar, conexion2)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla
        Catch ex As Exception
            MsgBox(ex.Message & " No hay ningún reporte enviado aún.")
            conexion.Close()

            Exit Sub
        End Try

        '////// CICLO FOR EACH //////


        While i < DataGridView1.RowCount

            e.Graphics.DrawString(DataGridView1.Item(0, i).Value, prFont2, Brushes.Black, 0, i * 15 + 190)
            e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont2, Brushes.Black, 125, i * 15 + 190)
            e.Graphics.DrawString(DataGridView1.Item(3, i).Value, prFont2, Brushes.Black, 155, i * 15 + 190)

            i += 1
        End While
    End Sub

    Private Sub Button18_Click_5(sender As Object, e As EventArgs) Handles Button18.Click
        PrintDocument8.Print()


    End Sub

    Private Sub TextBox103_TextChanged(sender As Object, e As EventArgs) Handles TextBox103.TextChanged

    End Sub

    Private Sub Button22_Click_1(sender As Object, e As EventArgs) Handles Button22.Click
        Try
            Dim cmd15 As New OleDbCommand
            cmd15 = New OleDbCommand("delete from Reporte_Producción where Fecha='" & Label3.Text & "' and Producto in('Opera G','Opera I')", conexion)
            conexion.Open()
            cmd15.ExecuteNonQuery()
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Se anexa Opera G y Opera I
        Try
            Dim cmd As New OleDbCommand
            Dim r1 As Integer

            cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label171.Text & "','" & CDec(TextBox373.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
            conexion.Open()
            r1 = cmd.ExecuteNonQuery
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        Try
            Dim cmd As New OleDbCommand
            Dim r1 As Integer

            cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label156.Text & "','" & CDec(TextBox372.Text) & "','" & Label3.Text & "','Minis')", conexion)
            conexion.Open()
            r1 = cmd.ExecuteNonQuery
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim password As String
        password = InputBox("Ingrese la contraseña:", "Rosa de saron pastelerias")

        If password = "49215" Then

            Try
                Dim cmd15 As New OleDbCommand
                cmd15 = New OleDbCommand("delete from Reporte_Producción where Fecha='" & Label3.Text & "' AND Producto IN ('Tarta manzana Teq G.', 'Frambuesa fresa G', 'Fresas frambuesa I') ", conexion3)
                conexion3.Open()
                cmd15.ExecuteNonQuery()
                conexion3.Close()
            Catch ex As Exception
                MsgBox("Error el borrar para sobreescribir. Reportar a Giuseppe." & ex.Message)
                Exit Sub
            End Try


            'nuevos giuseppe 28 enero 2023
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label301.Text & "','" & CDec(TextBox416.Text) & "','" & Label3.Text & "','Cre. Ind.')", conexion3)
                conexion3.Open()
                r1 = cmd.ExecuteNonQuery
                conexion3.Close()
            Catch ex As Exception
                MsgBox("Error 1. Reportar a Giuseppe." & ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label311.Text & "','" & CDec(TextBox417.Text) & "','" & Label3.Text & "','P1 25´s')", conexion3)
                conexion3.Open()
                r1 = cmd.ExecuteNonQuery
                conexion3.Close()
            Catch ex As Exception
                MsgBox("Error 2. Reportar a Giuseppe." & ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Label312.Text & "','" & CDec(TextBox418.Text) & "','" & Label3.Text & "','P1 25´s')", conexion3)
                conexion3.Open()
                r1 = cmd.ExecuteNonQuery
                conexion3.Close()
            Catch ex As Exception
                MsgBox("Error 3. Reportar a Giuseppe." & ex.Message)
                Exit Sub
            End Try
            'fin nuevos

            MsgBox("Listo, reporte de productos de altas nuevas enviado a cuentas por cobrar.")
            pdBlueberry.Print()
        End If
    End Sub


    Private Sub pdBlueberry_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdBlueberry.PrintPage
        Dim i As Integer = 0
        Dim prFont As New Font("Arial", 14, GraphicsUnit.Point)
        Dim prFont1 As New Font("Arial", 10, GraphicsUnit.Point)
        Dim prFont2 As New Font("Arial", 8, GraphicsUnit.Point)
        Dim prFont3 As New Font("Arial", 12, GraphicsUnit.Point)
        Dim prFont7 As New Font("Fontastique", 7, GraphicsUnit.Point)
        Dim prFont8 As New Font("Arial", 7, GraphicsUnit.Point)
        e.Graphics.DrawString("Rosa de Sarón", prFont7, Brushes.Black, 65, 65)
        e.Graphics.DrawString("Pastelerías", prFont7, Brushes.Black, 69, 75)
        e.Graphics.DrawString("Comercializadora Sarón Shekina", prFont2, Brushes.Black, 10, 90)
        e.Graphics.DrawString("S.A. de C.V.", prFont2, Brushes.Black, 60, 105)
        e.Graphics.DrawString("RFC CSS1512219U3", prFont2, Brushes.Black, 37, 120)
        e.Graphics.DrawString("Departartamento: " & TextBox103.Text, prFont2, Brushes.Black, 0, 135)
        e.Graphics.DrawString("REPORTE ENVIADO A CXC", prFont2, Brushes.Black, 10, 150)


        e.Graphics.DrawString("Fecha:", prFont2, Brushes.Black, 0, 165)
        e.Graphics.DrawString(Label3.Text, prFont2, Brushes.Black, 50, 165)
        e.Graphics.DrawString("Hora:", prFont2, Brushes.Black, 0, 180)
        e.Graphics.DrawString(Label4.Text, prFont2, Brushes.Black, 50, 180)

        Try
            Dim adaptador As New OleDbDataAdapter
            Dim tabla As New DataTable
            Dim buscar As String

            buscar = ("select *from Reporte_Producción where Fecha='" & Label3.Text & "'")
            adaptador = New OleDbDataAdapter(buscar, conexion3)
            tabla = New DataTable
            adaptador.Fill(tabla)
            DataGridView1.DataSource = tabla
        Catch ex As Exception
            MsgBox(ex.Message & " No hay ningún reporte enviado aún.")
            conexion.Close()

            Exit Sub
        End Try


        While i < DataGridView1.RowCount



            e.Graphics.DrawString(DataGridView1.Item(0, i).Value, prFont2, Brushes.Black, 0, i * 15 + 195)
            e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont2, Brushes.Black, 125, i * 15 + 195)
            e.Graphics.DrawString(DataGridView1.Item(3, i).Value, prFont2, Brushes.Black, 155, i * 15 + 195)





            i += 1
        End While


    End Sub

    Private Sub btnEnviarBluebery_Click_1(sender As Object, e As EventArgs) Handles btnEnviarBluebery.Click
        Dim password As String
        password = InputBox("Ingrese la contraseña:", "Rosa de saron pastelerias")

        If password = "49215" Then

            'Borramos para no sobre escribir
            Try
                Dim cmd15 As New OleDbCommand
                cmd15 = New OleDbCommand("DELETE FROM Reporte_Producción WHERE Fecha='" & Label3.Text & "' AND Producto='Chessecake Blueberry'", conexion3)
                conexion3.Open()
                cmd15.ExecuteNonQuery()
                conexion3.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            '25 de blueberry
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & lblChesscakeBlueberry.Text & "','" & CDec(txtChesscakeBlueberry.Text) & "','" & Label3.Text & "','Cre. Gde.')", conexion3)
                conexion3.Open()
                r1 = cmd.ExecuteNonQuery
                conexion3.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try


            pdBlueberry.Print()

        Else
            MsgBox("Contraseña incorrecta. Intenta de nuevo.", MsgBoxStyle.Exclamation, "Error")
        End If


    End Sub





#End Region


End Class

