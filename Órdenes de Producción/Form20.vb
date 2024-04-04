Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class Form20
    Dim conexionSQL As New SqlConnection("Data Source=SERVER;Initial Catalog=Choferes;Persist Security Info=True;User ID=Giuseppe1;Password=123456")
    Dim conexion As New OleDbConnection
    Dim conexion1 As New OleDbConnection
    Dim conexion2 As New OleDbConnection
    Dim conexion3 As New OleDbConnection
    Dim conexion4 As New OleDbConnection
    Dim conexion5 As New OleDbConnection
    Dim conexion6 As New OleDbConnection
    Private Sub Form20_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
        TextBox103.Enabled = False


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
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = DateTime.Now.ToString("yyyy-MM-dd")

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label4.Text = TimeString

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If TextBox1.Text = "" Then
            MsgBox("No hay ningún mensaje escrito para enviar.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
            Exit Sub
        End If


        If TextBox103.Text = "Pastelería 1" Then
            TextBox1.Text = "BUZÓN DE PASTELERÍA 1   ********  " + TextBox1.Text
        End If
        If TextBox103.Text = "Pastelería 2" Then
            TextBox1.Text = "BUZÓN DE PASTELERÍA 2   ********  " + TextBox1.Text
        End If
        If TextBox103.Text = "Batidos" Then
            TextBox1.Text = "BUZÓN DE BATIDOS        ********  " + TextBox1.Text
        End If
        If TextBox103.Text = "Panadería" Then
            TextBox1.Text = "BUZÓN DE PANADERÍA      ********  " + TextBox1.Text
        End If
        If TextBox103.Text = "Gelatinas" Then
            TextBox1.Text = "BUZÓN DE GELATINAS      ********  " + TextBox1.Text
        End If
        If TextBox103.Text = "Flanes y arroz" Then
            TextBox1.Text = "BUZÓN DE FLANES Y ARROZ ********  " + TextBox1.Text
        End If
        If TextBox103.Text = "Cremosos" Then
            TextBox1.Text = "BUZÓN DE CHESSE CAKE    ********  " + TextBox1.Text
        End If


        If TextBox103.Text = "Pastelería 1" Then
            Try
                Dim cmd As New SqlCommand
                Dim r As Integer

                cmd = New SqlCommand("INSERT INTO Buzón (Fecha,Hora,Chofer,Mensaje)VALUES('" & Label3.Text & "','" & Label4.Text & "','Juan Carlos','" & TextBox1.Text & "')", conexionSQL)
                conexionSQL.Open()
                r = cmd.ExecuteNonQuery
                conexionSQL.Close()
                MsgBox("Buzón enviando correctamente.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")

            Catch ex As Exception
                MsgBox(ex.Message & " Mensaje NO ENVIADO. Favor de reportar a Sistemas.")
                conexion.Close()
                Exit Sub
            End Try
        End If
        If TextBox103.Text = "Pastelería 2" Then
            Try
                Dim cmd As New SqlCommand
                Dim r As Integer

                cmd = New SqlCommand("INSERT INTO Buzón (Fecha,Hora,Chofer,Mensaje)VALUES('" & Label3.Text & "','" & Label4.Text & "','Juan Carlos','" & TextBox1.Text & "')", conexionSQL)
                conexionSQL.Open()
                r = cmd.ExecuteNonQuery
                conexionSQL.Close()
                MsgBox("Buzón enviando correctamente.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")

            Catch ex As Exception
                MsgBox(ex.Message & " Mensaje NO ENVIADO. Favor de reportar a Sistemas.")
                conexion1.Close()
                Exit Sub
            End Try
        End If
        If TextBox103.Text = "Batidos" Then
            Try
                Dim cmd As New SqlCommand
                Dim r As Integer

                cmd = New SqlCommand("INSERT INTO Buzón (Fecha,Hora,Chofer,Mensaje)VALUES('" & Label3.Text & "','" & Label4.Text & "','Juan Pablo','" & TextBox1.Text & "')", conexionSQL)
                conexionSQL.Open()
                r = cmd.ExecuteNonQuery
                conexionSQL.Close()
                MsgBox("Buzón enviando correctamente.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")

            Catch ex As Exception
                MsgBox(ex.Message & " Mensaje NO ENVIADO. Favor de reportar a Sistemas.")
                conexion2.Close()
                Exit Sub
            End Try
        End If
        If TextBox103.Text = "Cremosos" Then
            Try
                Dim cmd As New SqlCommand
                Dim r As Integer

                cmd = New SqlCommand("INSERT INTO Buzón (Fecha,Hora,Chofer,Mensaje)VALUES('" & Label3.Text & "','" & Label4.Text & "','Daniel Ceballos ','" & TextBox1.Text & "')", conexionSQL)
                conexionSQL.Open()
                r = cmd.ExecuteNonQuery
                conexionSQL.Close()
                MsgBox("Buzón enviando correctamente.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")

            Catch ex As Exception
                MsgBox(ex.Message & " Mensaje NO ENVIADO. Favor de reportar a Sistemas.")
                conexion3.Close()
                Exit Sub
            End Try
        End If
        If TextBox103.Text = "Flanes y arroz" Then
            Try
                Dim cmd As New SqlCommand
                Dim r As Integer

                cmd = New SqlCommand("INSERT INTO Buzón (Fecha,Hora,Chofer,Mensaje)VALUES('" & Label3.Text & "','" & Label4.Text & "','Luz','" & TextBox1.Text & "')", conexionSQL)
                conexionSQL.Open()
                r = cmd.ExecuteNonQuery
                conexionSQL.Close()
                MsgBox("Buzón enviando correctamente.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")

            Catch ex As Exception
                MsgBox(ex.Message & " Mensaje NO ENVIADO. Favor de reportar a Sistemas.")
                conexion4.Close()
                Exit Sub
            End Try
        End If
        If TextBox103.Text = "Gelatinas" Then
            Try
                Dim cmd As New SqlCommand
                Dim r As Integer

                cmd = New SqlCommand("INSERT INTO Buzón (Fecha,Hora,Chofer,Mensaje)VALUES('" & Label3.Text & "','" & Label4.Text & "','Coco','" & TextBox1.Text & "')", conexionSQL)
                conexionSQL.Open()
                r = cmd.ExecuteNonQuery
                conexionSQL.Close()
                MsgBox("Buzón enviando correctamente.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")

            Catch ex As Exception
                MsgBox(ex.Message & " Mensaje NO ENVIADO. Favor de reportar a Sistemas.")
                conexion5.Close()
                Exit Sub
            End Try
        End If
        If TextBox103.Text = "Panadería" Then
            Try
                Dim cmd As New SqlCommand
                Dim r As Integer

                cmd = New SqlCommand("INSERT INTO Buzón (Fecha,Hora,Chofer,Mensaje)VALUES('" & Label3.Text & "','" & Label4.Text & "','Roberto','" & TextBox1.Text & "')", conexionSQL)
                conexionSQL.Open()
                r = cmd.ExecuteNonQuery
                conexionSQL.Close()
                MsgBox("Buzón enviando correctamente.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")

            Catch ex As Exception
                MsgBox(ex.Message & " Mensaje NO ENVIADO. Favor de reportar a Sistemas.")
                conexion6.Close()
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class