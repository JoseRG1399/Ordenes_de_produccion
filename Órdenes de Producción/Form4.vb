Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms
Public Class Form4
    Dim conexion As New OleDbConnection
    Dim conexion1 As New OleDbConnection
    Dim conexion2 As New OleDbConnection
    Dim conexion3 As New OleDbConnection
    Dim conexion4 As New OleDbConnection
    Dim conexion5 As New OleDbConnection
    Dim conexion6 As New OleDbConnection
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox103.Enabled = False
        Timer1.Enabled = True
        Timer2.Enabled = True
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
        Label3.Text = DateTime.Today
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label4.Text = TimeString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Falta usuario o contraseña.", MsgBoxStyle.Critical, "Rosa de Sarón Pastelerías")
            Exit Sub
        End If

        If TextBox103.Text = "Pastelería 1" And TextBox1.Text = "1212" And TextBox2.Text = "1548" Then


            Try
                Dim cmd15 As New OleDbCommand
                cmd15 = New OleDbCommand("delete from Reporte_Producción where Fecha='" & Label3.Text & "'", conexion)
                conexion.Open()
                cmd15.ExecuteNonQuery()
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

#Region "Nuevos Panqués (Tamarindo, blueberry, manzana) - Sistemas - 26 08 2023"
            'Nuevos Panqués - Sistemas - 26 ag 2023

            'Try
            '    Dim cmd As New OleDbCommand
            '    Dim r1 As Integer

            '    cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label409.Text & "','" & CDec(Form1.TextBox429.Text) & "','" & Label3.Text & "','P1 varios')", conexion)
            '    conexion.Open()
            '    r1 = cmd.ExecuteNonQuery
            '    conexion.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Exit Sub
            'End Try

            'Fin nuevos panqués - Sistemas
#End Region


            'fin nuevo mostachon giuseppe
            'Se mueve Panqué Chocolate circular de Batidos a Pastelería 1
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label514.Text & "','" & CDec(Form1.TextBox1006.Text) & "','" & Label3.Text & "','P1 varios')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label5.Text + " G" & "','" & CDec(Form1.TextBox1.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'nuevos giuseppe 5 feb 2023 (4)
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label349.Text & "','" & CDec(Form1.TextBox421.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label332.Text & "','" & CDec(Form1.TextBox420.Text) & "','" & Label3.Text & "','Minis')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label329.Text & "','" & CDec(Form1.TextBox419.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label357.Text & "','" & CDec(Form1.TextBox422.Text) & "','" & Label3.Text & "','Minis')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            'fin nuevos (4)
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label6.Text + " G" & "','" & CDec(Form1.TextBox6.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label7.Text + " G" & "','" & CDec(Form1.TextBox9.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label10.Text + " G" & "','" & CDec(Form1.TextBox12.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label9.Text + " G" & "','" & CDec(Form1.TextBox15.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label8.Text + " G" & "','" & CDec(Form1.TextBox18.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label13.Text + " G" & "','" & CDec(Form1.TextBox21.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label12.Text + " G" & "','" & CDec(Form1.TextBox24.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label11.Text + " G" & "','" & CDec(Form1.TextBox27.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label16.Text + " G" & "','" & CDec(Form1.TextBox30.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label15.Text + " G" & "','" & CDec(Form1.TextBox33.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label14.Text + " G" & "','" & CDec(Form1.TextBox36.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label19.Text + " G" & "','" & CDec(Form1.TextBox39.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label18.Text + " G" & "','" & CDec(Form1.TextBox42.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label17.Text + " G" & "','" & CDec(Form1.TextBox45.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label22.Text + " G" & "','" & CDec(Form1.TextBox48.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label21.Text + " G" & "','" & CDec(Form1.TextBox51.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label20.Text + " G" & "','" & CDec(Form1.TextBox54.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label25.Text + " G" & "','" & CDec(Form1.TextBox57.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label24.Text + " G" & "','" & CDec(Form1.TextBox60.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label23.Text + " G" & "','" & CDec(Form1.TextBox63.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'Nuevo 3 L Mango
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label542.Text + " G" & "','" & CDec(Form1.TextBox1072.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'Fin
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label28.Text + " G" & "','" & CDec(Form1.TextBox66.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label27.Text + " G" & "','" & CDec(Form1.TextBox69.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label26.Text + " G" & "','" & CDec(Form1.TextBox72.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            '
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('3 L. Crema Irlan G','" & CDec(Form1.TextBox405.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Chocolate de leche G','" & CDec(Form1.TextBox169.Text) & "','" & Label3.Text & "','P1 25´s')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            '

            '18´s
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label5.Text + " M" & "','" & CDec(Form1.TextBox2.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label6.Text + " M" & "','" & CDec(Form1.TextBox5.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label7.Text + " M" & "','" & CDec(Form1.TextBox8.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label9.Text + " M" & "','" & CDec(Form1.TextBox14.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label8.Text + " M" & "','" & CDec(Form1.TextBox17.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label13.Text + " M" & "','" & CDec(Form1.TextBox20.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label12.Text + " M" & "','" & CDec(Form1.TextBox23.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label11.Text + " M" & "','" & CDec(Form1.TextBox26.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label16.Text + " M" & "','" & CDec(Form1.TextBox29.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label15.Text + " M" & "','" & CDec(Form1.TextBox32.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label14.Text + " M" & "','" & CDec(Form1.TextBox35.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label19.Text + " M" & "','" & CDec(Form1.TextBox38.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label18.Text + " M" & "','" & CDec(Form1.TextBox41.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label17.Text + " M" & "','" & CDec(Form1.TextBox44.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label22.Text + " M" & "','" & CDec(Form1.TextBox47.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label21.Text + " M" & "','" & CDec(Form1.TextBox50.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label20.Text + " M" & "','" & CDec(Form1.TextBox53.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label25.Text + " M" & "','" & CDec(Form1.TextBox56.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label24.Text + " M" & "','" & CDec(Form1.TextBox59.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label23.Text + " M" & "','" & CDec(Form1.TextBox62.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            'Nuevo 3 L Mango
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label542.Text + " M" & "','" & CDec(Form1.TextBox1071.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'Fin
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label28.Text + " M" & "','" & CDec(Form1.TextBox65.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label27.Text + " M" & "','" & CDec(Form1.TextBox68.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label26.Text + " M" & "','" & CDec(Form1.TextBox71.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            '
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('3 L. Crema Irlan M','" & CDec(Form1.TextBox404.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Chocolate de leche M','" & CDec(Form1.TextBox160.Text) & "','" & Label3.Text & "','P1 18´s')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            '
            '1/4 p
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label5.Text + " R" & "','" & CDec(Form1.TextBox3.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label6.Text + " R" & "','" & CDec(Form1.TextBox4.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label7.Text + " R" & "','" & CDec(Form1.TextBox7.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label9.Text + " R" & "','" & CDec(Form1.TextBox13.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label8.Text + " R" & "','" & CDec(Form1.TextBox16.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label13.Text + " R" & "','" & CDec(Form1.TextBox19.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label12.Text + " R" & "','" & CDec(Form1.TextBox22.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label11.Text + " R" & "','" & CDec(Form1.TextBox25.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label16.Text + " R" & "','" & CDec(Form1.TextBox28.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label15.Text + " R" & "','" & CDec(Form1.TextBox31.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label14.Text + " R" & "','" & CDec(Form1.TextBox34.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label19.Text + " R" & "','" & CDec(Form1.TextBox37.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label18.Text + " R" & "','" & CDec(Form1.TextBox40.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label17.Text + " R" & "','" & CDec(Form1.TextBox43.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label22.Text + " R" & "','" & CDec(Form1.TextBox46.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label21.Text + " R" & "','" & CDec(Form1.TextBox49.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label20.Text + " R" & "','" & CDec(Form1.TextBox52.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label25.Text + " R" & "','" & CDec(Form1.TextBox55.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label24.Text + " R" & "','" & CDec(Form1.TextBox58.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label23.Text + " R" & "','" & CDec(Form1.TextBox61.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'Nuevo 3 L Mango
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label542.Text + " R" & "','" & CDec(Form1.TextBox1070.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'Fin

            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label28.Text + " R" & "','" & CDec(Form1.TextBox64.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label27.Text + " R" & "','" & CDec(Form1.TextBox67.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label26.Text + " R" & "','" & CDec(Form1.TextBox70.Text) & "','" & Label3.Text & "','P1 1/4P')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'tartas y pays ins
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label36.Text & "','" & CDec(Form1.TextBox77.Text) & "','" & Label3.Text & "','Tartas y pays ind.')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label35.Text & "','" & CDec(Form1.TextBox76.Text) & "','" & Label3.Text & "','Tartas y pays ind.')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label34.Text & "','" & CDec(Form1.TextBox75.Text) & "','" & Label3.Text & "','Tartas y pays ind.')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label33.Text & "','" & CDec(Form1.TextBox74.Text) & "','" & Label3.Text & "','Tartas y pays ind.')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label32.Text & "','" & CDec(Form1.TextBox73.Text) & "','" & Label3.Text & "','Tartas y pays ind.')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'Pay nuevos
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label132.Text & "','" & CDec(Form1.TextBox779.Text) & "','" & Label3.Text & "','Tartas y pays ind.')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label131.Text & "','" & CDec(Form1.TextBox778.Text) & "','" & Label3.Text & "','Tartas y pays ind.')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Tarta fruta G.','" & CDec(Form1.TextBox82.Text) & "','" & Label3.Text & "','Tartas y pays gde.')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Tarta fresa G.','" & CDec(Form1.TextBox81.Text) & "','" & Label3.Text & "','Tartas y pays gde.')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label33.Text + " G." & "','" & CDec(Form1.TextBox79.Text) & "','" & Label3.Text & "','Tartas y pays gde.')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label32.Text + " G." & "','" & CDec(Form1.TextBox78.Text) & "','" & Label3.Text & "','Tartas y pays gde.')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'varios p1
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label48.Text & "','" & CDec(Form1.TextBox92.Text) & "','" & Label3.Text & "','P1 varios')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.lblBarquillos.Text & "','" & CDec(Form1.TextBox91.Text) & "','" & Label3.Text & "','P1 varios')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label46.Text & "','" & CDec(Form1.TextBox90.Text) & "','" & Label3.Text & "','P1 varios')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label45.Text & "','" & CDec(Form1.TextBox89.Text) & "','" & Label3.Text & "','P1 varios')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label50.Text & "','" & CDec(Form1.TextBox96.Text) & "','" & Label3.Text & "','P1 varios')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label49.Text & "','" & CDec(Form1.TextBox95.Text) & "','" & Label3.Text & "','P1 varios')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label55.Text & "','" & CDec(Form1.TextBox100.Text) & "','" & Label3.Text & "','P1 varios')", conexion)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label54.Text & "','" & CDec(Form1.TextBox99.Text) & "','" & Label3.Text & "','P1 varios')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            MsgBox("Listo. Información enviada a Cuentas por Cobrar.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")




        End If


        If TextBox103.Text = "Pastelería 2" And TextBox1.Text = "4747" And TextBox2.Text = "1144" Then

            Try
                Dim cmd15 As New OleDbCommand
                cmd15 = New OleDbCommand("delete from Reporte_Producción where Fecha='" & Label3.Text & "'", conexion1)
                conexion1.Open()
                cmd15.ExecuteNonQuery()
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label339.Text & "','" & CDec(Form1.TextBox243.Text) & "','" & Label3.Text & "','P2 1/4P')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label338.Text & "','" & CDec(Form1.TextBox239.Text) & "','" & Label3.Text & "','P2 1/4P')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label337.Text & "','" & CDec(Form1.TextBox214.Text) & "','" & Label3.Text & "','P2 1/4P')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label336.Text & "','" & CDec(Form1.TextBox211.Text) & "','" & Label3.Text & "','P2 1/4P')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try



            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label103.Text + " G" & "','" & CDec(Form1.TextBox197.Text) & "','" & Label3.Text & "','P2 25´s')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Coco coco G','" & CDec(Form1.TextBox194.Text) & "','" & Label3.Text & "','P2 25´s')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label101.Text + " G" & "','" & CDec(Form1.TextBox191.Text) & "','" & Label3.Text & "','P2 25´s')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label100.Text + " G" & "','" & CDec(Form1.TextBox188.Text) & "','" & Label3.Text & "','P2 25´s')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label99.Text + " G" & "','" & CDec(Form1.TextBox185.Text) & "','" & Label3.Text & "','P2 25´s')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label98.Text + " G" & "','" & CDec(Form1.TextBox182.Text) & "','" & Label3.Text & "','P2 25´s')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label97.Text + " G" & "','" & CDec(Form1.TextBox179.Text) & "','" & Label3.Text & "','P2 25´s')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            '25´s
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label103.Text + " M" & "','" & CDec(Form1.TextBox196.Text) & "','" & Label3.Text & "','P2 18´s')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Coco-coco M','" & CDec(Form1.TextBox193.Text) & "','" & Label3.Text & "','P2 18´s')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label101.Text + " M" & "','" & CDec(Form1.TextBox190.Text) & "','" & Label3.Text & "','P2 18´s')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label100.Text + " M" & "','" & CDec(Form1.TextBox187.Text) & "','" & Label3.Text & "','P2 18´s')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label99.Text + " M" & "','" & CDec(Form1.TextBox184.Text) & "','" & Label3.Text & "','P2 18´s')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label98.Text + " M" & "','" & CDec(Form1.TextBox181.Text) & "','" & Label3.Text & "','P2 18´s')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label97.Text + " M" & "','" & CDec(Form1.TextBox178.Text) & "','" & Label3.Text & "','P2 18´s')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            '1/4 p
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label103.Text + " R" & "','" & CDec(Form1.TextBox195.Text) & "','" & Label3.Text & "','P2 1/4/P')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Coco-coco R','" & CDec(Form1.TextBox192.Text) & "','" & Label3.Text & "','P2 1/4/P')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label101.Text + " R" & "','" & CDec(Form1.TextBox189.Text) & "','" & Label3.Text & "','P2 1/4/P')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label100.Text + " R" & "','" & CDec(Form1.TextBox186.Text) & "','" & Label3.Text & "','P2 1/4/P')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label99.Text + " R" & "','" & CDec(Form1.TextBox183.Text) & "','" & Label3.Text & "','P2 1/4/P')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label98.Text + " R" & "','" & CDec(Form1.TextBox180.Text) & "','" & Label3.Text & "','P2 1/4/P')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label97.Text + " R" & "','" & CDec(Form1.TextBox177.Text) & "','" & Label3.Text & "','P2 1/4/P')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'clasicos
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label129.Text & "','" & CDec(Form1.TextBox142.Text) & "','" & Label3.Text & "','Clásicos')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label128.Text & "','" & CDec(Form1.TextBox139.Text) & "','" & Label3.Text & "','Clásicos')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label127.Text & "','" & CDec(Form1.TextBox136.Text) & "','" & Label3.Text & "','Clásicos')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label126.Text & "','" & CDec(Form1.TextBox133.Text) & "','" & Label3.Text & "','Clásicos')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label125.Text & "','" & CDec(Form1.TextBox131.Text) & "','" & Label3.Text & "','Clásicos')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label124.Text & "','" & CDec(Form1.TextBox130.Text) & "','" & Label3.Text & "','Clásicos')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label123.Text & "','" & CDec(Form1.TextBox128.Text) & "','" & Label3.Text & "','Clásicos')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            '¡minis
            'Se agrega Tricolor I - 24/10/2019
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label529.Text & "','" & CDec(Form1.TextBox1037.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label95.Text & "','" & CDec(Form1.TextBox173.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label94.Text & "','" & CDec(Form1.TextBox170.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label93.Text & "','" & CDec(Form1.TextBox167.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label92.Text & "','" & CDec(Form1.TextBox164.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label91.Text & "','" & CDec(Form1.TextBox161.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label90.Text & "','" & CDec(Form1.TextBox158.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label89.Text & "','" & CDec(Form1.TextBox155.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label88.Text & "','" & CDec(Form1.TextBox152.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label87.Text & "','" & CDec(Form1.TextBox149.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label86.Text & "','" & CDec(Form1.TextBox146.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label85.Text & "','" & CDec(Form1.TextBox143.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label84.Text & "','" & CDec(Form1.TextBox140.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label83.Text & "','" & CDec(Form1.TextBox137.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label82.Text & "','" & CDec(Form1.TextBox134.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label117.Text & "','" & CDec(Form1.TextBox174.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label116.Text & "','" & CDec(Form1.TextBox171.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label115.Text & "','" & CDec(Form1.TextBox168.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label114.Text & "','" & CDec(Form1.TextBox165.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label113.Text & "','" & CDec(Form1.TextBox162.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label112.Text & "','" & CDec(Form1.TextBox159.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label111.Text & "','" & CDec(Form1.TextBox156.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label110.Text & "','" & CDec(Form1.TextBox153.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label109.Text & "','" & CDec(Form1.TextBox150.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label108.Text & "','" & CDec(Form1.TextBox147.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'Nuevo mango
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label543.Text & "','" & CDec(Form1.TextBox1075.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'Fin
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label107.Text & "','" & CDec(Form1.TextBox144.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label106.Text & "','" & CDec(Form1.TextBox141.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label105.Text & "','" & CDec(Form1.TextBox138.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label81.Text & "','" & CDec(Form1.TextBox135.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label80.Text & "','" & CDec(Form1.TextBox132.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            '
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('3 L. Crema Irlan I','" & CDec(Form1.TextBox396.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Chocolate de leche I','" & CDec(Form1.TextBox206.Text) & "','" & Label3.Text & "','Minis')", conexion1)
                conexion1.Open()
                r1 = cmd.ExecuteNonQuery
                conexion1.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            '



            MsgBox("Listo. Información enviada a Cuentas por Cobrar.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
        End If


        If TextBox103.Text = "Batidos" And TextBox1.Text = "5858" And TextBox2.Text = "1122" Then
            Try
                Dim cmd15 As New OleDbCommand
                cmd15 = New OleDbCommand("delete from Reporte_Producción where Fecha='" & Label3.Text & "'", conexion2)
                conexion2.Open()
                cmd15.ExecuteNonQuery()
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.lblPanqueBlueberry.Text & "','" & CDec(Form1.txtPanqueBlueberry.Text) & "','" & Label3.Text & "','P1 varios')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label59.Text & "','" & CDec(Form1.TextBox108.Text) & "','" & Label3.Text & "','Brownie')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try


            'Nuevos panques individuales
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label75.Text & "','" & CDec(Form1.txtCocoIndividual.Text) & "','" & Label3.Text & "','Batidos')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'Temporalmente agregado aquí. panque de blueberry individual
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.lblPanqueBlueerryInd.Text & "','" & CDec(Form1.txtBlueberryInd.Text) & "','" & Label3.Text & "','Batidos')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try


            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label492.Text & "','" & CDec(Form1.TextBox985.Text) & "','" & Label3.Text & "','Batidos')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label555.Text & "','" & CDec(Form1.TextBox1087.Text) & "','" & Label3.Text & "','Batidos')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label547.Text & "','" & CDec(Form1.TextBox1090.Text) & "','" & Label3.Text & "','Batidos')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label546.Text & "','" & CDec(Form1.TextBox1093.Text) & "','" & Label3.Text & "','Batidos')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label545.Text & "','" & CDec(Form1.TextBox1096.Text) & "','" & Label3.Text & "','Batidos')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'prod nuevos garibaldi y garichoco y panque choco cirlular. limon y coc
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label495.Text & "','" & CDec(Form1.TextBox991.Text) & "','" & Label3.Text & "','Batidos')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label494.Text & "','" & CDec(Form1.TextBox988.Text) & "','" & Label3.Text & "','Batidos')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label544.Text & "','" & CDec(Form1.TextBox1078.Text) & "','" & Label3.Text & "','Batidos')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            '*******
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label163.Text & "','" & CDec(Form1.TextBox231.Text) & "','" & Label3.Text & "','Batidos')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label161.Text & "','" & CDec(Form1.TextBox225.Text) & "','" & Label3.Text & "','Batidos')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label160.Text & "','" & CDec(Form1.TextBox222.Text) & "','" & Label3.Text & "','Batidos')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label61.Text & "','" & CDec(Form1.TextBox109.Text) & "','" & Label3.Text & "','Batidos')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label66.Text & "','" & CDec(Form1.TextBox114.Text) & "','" & Label3.Text & "','Batidos')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label65.Text & "','" & CDec(Form1.TextBox113.Text) & "','" & Label3.Text & "','Batidos')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label411.Text & "','" & CDec(Form1.TextBox151.Text) & "','" & Label3.Text & "','Batidos')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label152.Text & "','" & CDec(Form1.TextBox148.Text) & "','" & Label3.Text & "','Batidos')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label64.Text & "','" & CDec(Form1.TextBox112.Text) & "','" & Label3.Text & "','Batidos')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label122.Text & "','" & CDec(Form1.TextBox120.Text) & "','" & Label3.Text & "','Batidos')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label137.Text & "','" & CDec(Form1.TextBox124.Text) & "','" & Label3.Text & "','Panqué Ind.')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label134.Text & "','" & CDec(Form1.TextBox123.Text) & "','" & Label3.Text & "','Panqué Ind.')", conexion2)
                conexion2.Open()
                r1 = cmd.ExecuteNonQuery
                conexion2.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            MsgBox("Listo. Información enviada a Cuentas por Cobrar.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
        End If


        If TextBox103.Text = "Cremosos" And TextBox1.Text = "6969" And TextBox2.Text = "87103" Then
            Try
                Dim cmd15 As New OleDbCommand
                cmd15 = New OleDbCommand("DELETE FROM Reporte_Producción WHERE Producto = 'Pay limon G.' AND Fecha = '" & Label3.Text & "'", conexion)
                conexion.Open()
                cmd15.ExecuteNonQuery()
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message & "Error al borrar de pasteleria")
                conexion.Close()

            End Try
            Try
                Dim cmd15 As New OleDbCommand
                cmd15 = New OleDbCommand("DELETE FROM Reporte_Producción where Fecha='" & Label3.Text & "'", conexion4)
                conexion4.Open()
                cmd15.ExecuteNonQuery()
                conexion4.Close()
            Catch ex As Exception
                MsgBox(ex.Message & "Error al borrar de flanes")
                conexion4.Close()
            End Try

            Try
                Dim cmd15 As New OleDbCommand
                cmd15 = New OleDbCommand("DELETE FROM Reporte_Producción WHERE Fecha='" & Label3.Text & "' AND NOT Producto = 'Chessecake Blueberry G'", conexion3)
                conexion3.Open()
                cmd15.ExecuteNonQuery()
                conexion3.Close()
            Catch ex As Exception
                MsgBox(ex.Message & "Error al borrar de cremosos")
                conexion3.Close()

            End Try
            'Fin

            '25 de guayaba
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label185.Text + " G" & "','" & CDec(Form1.TextBox217.Text) & "','" & Label3.Text & "','Cre. Gde.')", conexion3)
                conexion3.Open()
                r1 = cmd.ExecuteNonQuery
                conexion3.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try






            '18 de guayaba
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label185.Text + " M" & "','" & CDec(Form1.TextBox163.Text) & "','" & Label3.Text & "','Cre. Med.')", conexion3)
                conexion3.Open()
                r1 = cmd.ExecuteNonQuery
                conexion3.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try



            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label182.Text + " M" & "','" & CDec(Form1.TextBox154.Text) & "','" & Label3.Text & "','Cre. Med.')", conexion3)
                conexion3.Open()
                r1 = cmd.ExecuteNonQuery
                conexion3.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            ''****nuevo zanahoria grande
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer
                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label182.Text + " G" & "','" & CDec(Form1.TextBox1051.Text) & "','" & Label3.Text & "','Cre. Gde.')", conexion3)
                conexion3.Open()
                r1 = cmd.ExecuteNonQuery
                conexion3.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            ''****


            'Mini de guayaba
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label185.Text + " I" & "','" & CDec(Form1.TextBox175.Text) & "','" & Label3.Text & "','Cre. Ind.')", conexion3)
                conexion3.Open()
                r1 = cmd.ExecuteNonQuery
                conexion3.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try






            '1/4 de guayaba
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label185.Text + " R" & "','" & CDec(Form1.TextBox218.Text) & "','" & Label3.Text & "','Cre. 1/4P.')", conexion3)
                conexion3.Open()
                r1 = cmd.ExecuteNonQuery
                conexion3.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            'Aqui pongo lo de flanes
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.lblFlanIndividual.Text & "','" & CDec(Form1.txtFlanIndividual.Text) & "','" & Label3.Text & "','Flan y arroz')", conexion4)
                conexion4.Open()
                r1 = cmd.ExecuteNonQuery
                conexion4.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.lblArrozConLeche.Text & "','" & CDec(Form1.txtArrozConLeche.Text) & "','" & Label3.Text & "','Flan y arroz')", conexion4)
                conexion4.Open()
                r1 = cmd.ExecuteNonQuery
                conexion4.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.lblBunuelos.Text & "','" & CDec(Form1.txtBunuelos.Text) & "','" & Label3.Text & "','Flan y arroz')", conexion4)
                conexion4.Open()
                r1 = cmd.ExecuteNonQuery
                conexion4.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try



            'empanadas
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label150.Text & "','" & CDec(Form1.TextBox209.Text) & "','" & Label3.Text & "','Empanadas')", conexion3)
                conexion3.Open()
                r1 = cmd.ExecuteNonQuery
                conexion3.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label148.Text & "','" & CDec(Form1.TextBox207.Text) & "','" & Label3.Text & "','Empanadas')", conexion3)
                conexion3.Open()
                r1 = cmd.ExecuteNonQuery
                conexion3.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label154.Text & "','" & CDec(Form1.TextBox200.Text) & "','" & Label3.Text & "','Empanadas')", conexion3)
                conexion3.Open()
                r1 = cmd.ExecuteNonQuery
                conexion3.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label143.Text & "','" & CDec(Form1.TextBox198.Text) & "','" & Label3.Text & "','Empanadas')", conexion3)
                conexion3.Open()
                r1 = cmd.ExecuteNonQuery
                conexion3.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try


            'Pay de limon grande
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Pay limon G.','" & CDec(Form1.TextBox117.Text) & "','" & Label3.Text & "','Pay gde.')", conexion)
                conexion.Open()
                r1 = cmd.ExecuteNonQuery
                conexion.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            MsgBox("Listo. Información enviada a Cuentas por Cobrar.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
        End If


        If TextBox103.Text = "Gourmet" And TextBox1.Text = "6363" And TextBox2.Text = "6699" Then

            MsgBox("En el departamento gourmet todos reportan de forma individual")
        End If


        If TextBox103.Text = "Gelatinas" And TextBox1.Text = "5252" And TextBox2.Text = "9977" Then


            Try
                Dim cmd15 As New OleDbCommand
                cmd15 = New OleDbCommand("delete from Reporte_Producción where Fecha='" & Label3.Text & "'", conexion5)
                conexion5.Open()
                cmd15.ExecuteNonQuery()
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel Gde D.E Piña','" & CDec(Form1.TextBox230.Text) & "','" & Label3.Text & "','Gel. Gde.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel Med D.E Piña','" & CDec(Form1.TextBox220.Text) & "','" & Label3.Text & "','Gel. Med.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel Gde D.E Durazno','" & CDec(Form1.TextBox393.Text) & "','" & Label3.Text & "','Gel. Gde.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel Gde D.E Fresa','" & CDec(Form1.TextBox392.Text) & "','" & Label3.Text & "','Gel. Gde.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel Gde D.E Mango','" & CDec(Form1.TextBox391.Text) & "','" & Label3.Text & "','Gel. Gde.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel Gde D.E Manzana','" & CDec(Form1.TextBox390.Text) & "','" & Label3.Text & "','Gel. Gde.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel Gde D.E Naranja','" & CDec(Form1.TextBox389.Text) & "','" & Label3.Text & "','Gel. Gde.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel Gde D.E Uva','" & CDec(Form1.TextBox388.Text) & "','" & Label3.Text & "','Gel. Gde.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel Med D.E Durazno','" & CDec(Form1.TextBox210.Text) & "','" & Label3.Text & "','Gel. Med.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel Med D.E Fresa','" & CDec(Form1.TextBox284.Text) & "','" & Label3.Text & "','Gel. Med.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel Med D.E Mango','" & CDec(Form1.TextBox382.Text) & "','" & Label3.Text & "','Gel. Med.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel Med D.E Manzana','" & CDec(Form1.TextBox385.Text) & "','" & Label3.Text & "','Gel. Med.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel Med D.E Naranja','" & CDec(Form1.TextBox386.Text) & "','" & Label3.Text & "','Gel. Med.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel Med D.E Uva','" & CDec(Form1.TextBox387.Text) & "','" & Label3.Text & "','Gel. Med.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label187.Text & "','" & CDec(Form1.TextBox250.Text) & "','" & Label3.Text & "','Gel. Ind.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Frambuesa','" & CDec(Form1.TextBox249.Text) & "','" & Label3.Text & "','Gel. Ind.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label179.Text & "','" & CDec(Form1.TextBox248.Text) & "','" & Label3.Text & "','Gel. Ind.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label166.Text & "','" & CDec(Form1.TextBox237.Text) & "','" & Label3.Text & "','Gel. Ind.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label165.Text & "','" & CDec(Form1.TextBox236.Text) & "','" & Label3.Text & "','Gel. Ind.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label164.Text & "','" & CDec(Form1.TextBox235.Text) & "','" & Label3.Text & "','Gel. Ind.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label158.Text & "','" & CDec(Form1.TextBox234.Text) & "','" & Label3.Text & "','Gel. Ind.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label170.Text & "','" & CDec(Form1.TextBox261.Text) & "','" & Label3.Text & "','Gel. Ind.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label169.Text & "','" & CDec(Form1.TextBox260.Text) & "','" & Label3.Text & "','Gel. Ind.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label168.Text & "','" & CDec(Form1.TextBox259.Text) & "','" & Label3.Text & "','Gel. Ind.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label167.Text & "','" & CDec(Form1.TextBox258.Text) & "','" & Label3.Text & "','Gel. Ind.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label188.Text & "','" & CDec(Form1.TextBox273.Text) & "','" & Label3.Text & "','Gel. Ind.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label173.Text & "','" & CDec(Form1.TextBox272.Text) & "','" & Label3.Text & "','Gel. Ind.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Panna cotta','" & CDec(Form1.TextBox464.Text) & "','" & Label3.Text & "','Gel. Ind.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Panna cotta ciruela','" & CDec(Form1.TextBox786.Text) & "','" & Label3.Text & "','Gel. Ind.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Rompope liquido','" & CDec(Form1.TextBox792.Text) & "','" & Label3.Text & "','Gel. Ind.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'gel med

            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Med. Agua fruta','" & CDec(Form1.TextBox246.Text) & "','" & Label3.Text & "','Gel. Med.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Med. Frambuesa','" & CDec(Form1.TextBox245.Text) & "','" & Label3.Text & "','Gel. Med.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Med. Bombón','" & CDec(Form1.TextBox244.Text) & "','" & Label3.Text & "','Gel. Med.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Med. Cajeta','" & CDec(Form1.TextBox233.Text) & "','" & Label3.Text & "','Gel. Med.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Med. Dominó','" & CDec(Form1.TextBox232.Text) & "','" & Label3.Text & "','Gel. Med.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'Try
            '    Dim cmd As New OleDbCommand
            '    Dim r1 As Integer

            '    cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Med. Dominó esp.','" & CDec(Form1.TextBox230.Text) & "','" & Label3.Text & "','Gel. Med.')", conexion5)
            '    conexion5.Open()
            '    r1 = cmd.ExecuteNonQuery
            '    conexion5.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Exit Sub
            'End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Med. Jugos','" & CDec(Form1.TextBox229.Text) & "','" & Label3.Text & "','Gel. Med.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Med. Queso uva','" & CDec(Form1.TextBox257.Text) & "','" & Label3.Text & "','Gel. Med.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Med. Rompope','" & CDec(Form1.TextBox256.Text) & "','" & Label3.Text & "','Gel. Med.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Med. Tuti fruti','" & CDec(Form1.TextBox255.Text) & "','" & Label3.Text & "','Gel. Med.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Med. 3 chocolates','" & CDec(Form1.TextBox254.Text) & "','" & Label3.Text & "','Gel. Med.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Med. 3 leches','" & CDec(Form1.TextBox269.Text) & "','" & Label3.Text & "','Gel. Med.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Med. Zanahoria','" & CDec(Form1.TextBox268.Text) & "','" & Label3.Text & "','Gel. Med.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'gel gde

            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Gde. Agua fruta','" & CDec(Form1.TextBox242.Text) & "','" & Label3.Text & "','Gel. Gde.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Gde. Frambuesa','" & CDec(Form1.TextBox241.Text) & "','" & Label3.Text & "','Gel. Gde.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Gde. Bombón','" & CDec(Form1.TextBox240.Text) & "','" & Label3.Text & "','Gel. Gde.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Gde. Cajeta','" & CDec(Form1.TextBox227.Text) & "','" & Label3.Text & "','Gel. Gde.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Gde. Dominó','" & CDec(Form1.TextBox226.Text) & "','" & Label3.Text & "','Gel. Gde.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'Try
            '    Dim cmd As New OleDbCommand
            '    Dim r1 As Integer

            '    cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Gde. Dominó esp.','" & CDec(Form1.TextBox220.Text) & "','" & Label3.Text & "','Gel. Gde.')", conexion5)
            '    conexion5.Open()
            '    r1 = cmd.ExecuteNonQuery
            '    conexion5.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Exit Sub
            'End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Gde. Jugos','" & CDec(Form1.TextBox219.Text) & "','" & Label3.Text & "','Gel. Gde.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Gde. Queso uva','" & CDec(Form1.TextBox253.Text) & "','" & Label3.Text & "','Gel. Gde.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Gde. Rompope','" & CDec(Form1.TextBox252.Text) & "','" & Label3.Text & "','Gel. Gde.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Gde. Tuti fruti','" & CDec(Form1.TextBox251.Text) & "','" & Label3.Text & "','Gel. Gde.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Gde. 3 chocolates','" & CDec(Form1.TextBox238.Text) & "','" & Label3.Text & "','Gel. Gde.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Gde. 3 leches','" & CDec(Form1.TextBox265.Text) & "','" & Label3.Text & "','Gel. Gde.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Gel. Gde. Zanahoria','" & CDec(Form1.TextBox264.Text) & "','" & Label3.Text & "','Gel. Gde.')", conexion5)
                conexion5.Open()
                r1 = cmd.ExecuteNonQuery
                conexion5.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            MsgBox("Listo. Información enviada a Cuentas por Cobrar.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
        End If


        If TextBox103.Text = "Panadería" And TextBox1.Text = "6767" And TextBox2.Text = "1199" Then

            Try
                Dim cmd15 As New OleDbCommand
                cmd15 = New OleDbCommand("delete from Reporte_Producción where Fecha='" & Label3.Text & "'", conexion6)
                conexion6.Open()
                cmd15.ExecuteNonQuery()
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'Hojaldras
            'Try
            '    Dim cmd As New OleDbCommand
            '    Dim r1 As Integer

            '    cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label503.Text & "','" & CDec(Form1.TextBox997.Text) & "','" & Label3.Text & "','Hojaldras')", conexion6)
            '    conexion6.Open()
            '    r1 = cmd.ExecuteNonQuery
            '    conexion6.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Exit Sub
            'End Try
            'Try
            '    Dim cmd As New OleDbCommand
            '    Dim r1 As Integer

            '    cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label502.Text & "','" & CDec(Form1.TextBox802.Text) & "','" & Label3.Text & "','Hojaldras')", conexion6)
            '    conexion6.Open()
            '    r1 = cmd.ExecuteNonQuery
            '    conexion6.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Exit Sub
            'End Try
            'Try
            '    Dim cmd As New OleDbCommand
            '    Dim r1 As Integer

            '    cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label501.Text & "','" & CDec(Form1.TextBox801.Text) & "','" & Label3.Text & "','Hojaldras')", conexion6)
            '    conexion6.Open()
            '    r1 = cmd.ExecuteNonQuery
            '    conexion6.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Exit Sub
            'End Try
            'Try
            '    Dim cmd As New OleDbCommand
            '    Dim r1 As Integer

            '    cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label506.Text & "','" & CDec(Form1.TextBox1000.Text) & "','" & Label3.Text & "','Hojaldras')", conexion6)
            '    conexion6.Open()
            '    r1 = cmd.ExecuteNonQuery
            '    conexion6.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Exit Sub
            'End Try
            'Try
            '    Dim cmd As New OleDbCommand
            '    Dim r1 As Integer

            '    cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label505.Text & "','" & CDec(Form1.TextBox999.Text) & "','" & Label3.Text & "','Hojaldras')", conexion6)
            '    conexion6.Open()
            '    r1 = cmd.ExecuteNonQuery
            '    conexion6.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Exit Sub
            'End Try
            'Try
            '    Dim cmd As New OleDbCommand
            '    Dim r1 As Integer

            '    cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label504.Text & "','" & CDec(Form1.TextBox998.Text) & "','" & Label3.Text & "','Hojaldras')", conexion6)
            '    conexion6.Open()
            '    r1 = cmd.ExecuteNonQuery
            '    conexion6.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Exit Sub
            'End Try
            'Try
            '    Dim cmd As New OleDbCommand
            '    Dim r1 As Integer

            '    cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label509.Text & "','" & CDec(Form1.TextBox1003.Text) & "','" & Label3.Text & "','Hojaldras')", conexion6)
            '    conexion6.Open()
            '    r1 = cmd.ExecuteNonQuery
            '    conexion6.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Exit Sub
            'End Try
            'Try
            '    Dim cmd As New OleDbCommand
            '    Dim r1 As Integer

            '    cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label508.Text & "','" & CDec(Form1.TextBox1002.Text) & "','" & Label3.Text & "','Hojaldras')", conexion6)
            '    conexion6.Open()
            '    r1 = cmd.ExecuteNonQuery
            '    conexion6.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Exit Sub
            'End Try
            'Try
            '    Dim cmd As New OleDbCommand
            '    Dim r1 As Integer

            '    cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label507.Text & "','" & CDec(Form1.TextBox1001.Text) & "','" & Label3.Text & "','Hojaldras')", conexion6)
            '    conexion6.Open()
            '    r1 = cmd.ExecuteNonQuery
            '    conexion6.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Exit Sub
            'End Try
            'Fin de Hojaldras
            'Profiteroles
            'Cuernito de jamon y queso
            'mantecadas
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label404.Text & "','" & CDec(Form1.TextBox427.Text) & "','" & Label3.Text & "','Pan')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            'mantecadas
            '4 productos nuevos agregados por giuseppe el 28 de enero 2023 + 2 del 23 de marzo 2023
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label400.Text & "','" & CDec(Form1.TextBox425.Text) & "','" & Label3.Text & "','Pan')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label300.Text & "','" & CDec(Form1.TextBox415.Text) & "','" & Label3.Text & "','" & Form1.Label245.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label296.Text & "','" & CDec(Form1.TextBox414.Text) & "','" & Label3.Text & "','" & Form1.Label245.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label244.Text & "','" & CDec(Form1.TextBox413.Text) & "','" & Label3.Text & "','" & Form1.Label245.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label194.Text & "','" & CDec(Form1.TextBox412.Text) & "','" & Label3.Text & "','" & Form1.Label245.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label399.Text & "','" & CDec(Form1.TextBox424.Text) & "','" & Label3.Text & "','" & Form1.Label245.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label398.Text & "','" & CDec(Form1.TextBox423.Text) & "','" & Label3.Text & "','" & Form1.Label245.Text & "')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            'fin de esos productos 4 y esos 2
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Campechana','" & CDec(Form1.TextBox409.Text) & "','" & Label3.Text & "','FEITÉ')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Conde','" & CDec(Form1.TextBox365.Text) & "','" & Label3.Text & "','FEITÉ')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Bolita de queso','" & CDec(Form1.TextBox371.Text) & "','" & Label3.Text & "','DANÉS')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Cuernito jamon y queso','" & CDec(Form1.TextBox1048.Text) & "','" & Label3.Text & "','DANÉS')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label500.Text & "','" & CDec(Form1.TextBox996.Text) & "','" & Label3.Text & "','Galletas')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'prod 14 feb
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label323.Text & "','" & CDec(Form1.TextBox166.Text) & "','" & Label3.Text & "','" & Form1.Label216.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label321.Text & "','" & CDec(Form1.TextBox80.Text) & "','" & Label3.Text & "','" & Form1.Label216.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label222.Text & "','" & CDec(Form1.TextBox323.Text) & "','" & Label3.Text & "','" & Form1.Label218.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label221.Text & "','" & CDec(Form1.TextBox321.Text) & "','" & Label3.Text & "','" & Form1.Label218.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label213.Text & "','" & CDec(Form1.TextBox312.Text) & "','" & Label3.Text & "','" & Form1.Label218.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label212.Text & "','" & CDec(Form1.TextBox311.Text) & "','" & Label3.Text & "','" & Form1.Label218.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label211.Text & "','" & CDec(Form1.TextBox310.Text) & "','" & Label3.Text & "','" & Form1.Label218.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label210.Text & "','" & CDec(Form1.TextBox309.Text) & "','" & Label3.Text & "','" & Form1.Label218.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label209.Text & "','" & CDec(Form1.TextBox300.Text) & "','" & Label3.Text & "','" & Form1.Label196.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label208.Text & "','" & CDec(Form1.TextBox299.Text) & "','" & Label3.Text & "','" & Form1.Label196.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label207.Text & "','" & CDec(Form1.TextBox298.Text) & "','" & Label3.Text & "','" & Form1.Label196.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label206.Text & "','" & CDec(Form1.TextBox297.Text) & "','" & Label3.Text & "','" & Form1.Label196.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label205.Text & "','" & CDec(Form1.TextBox288.Text) & "','" & Label3.Text & "','" & Form1.Label196.Text & "')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try


            ''''hjkjk
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label204.Text & "','" & CDec(Form1.TextBox287.Text) & "','" & Label3.Text & "','" & Form1.Label196.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label198.Text & "','" & CDec(Form1.TextBox275.Text) & "','" & Label3.Text & "','" & Form1.Label196.Text & "')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'Dona nuez
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label189.Text & "','" & CDec(Form1.TextBox408.Text) & "','" & Label3.Text & "','" & Form1.Label196.Text & "')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'Dona oreo
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label184.Text & "','" & CDec(Form1.TextBox407.Text) & "','" & Label3.Text & "','" & Form1.Label196.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label230.Text & "','" & CDec(Form1.TextBox285.Text) & "','" & Label3.Text & "','" & Form1.Label216.Text & "')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'Try
            '    Dim cmd As New OleDbCommand
            '    Dim r1 As Integer

            '    cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label229.Text & "','" & CDec(Form1.TextBox283.Text) & "','" & Label3.Text & "','" & Form1.Label216.Text & "')", conexion6)
            '    conexion6.Open()
            '    r1 = cmd.ExecuteNonQuery
            '    conexion6.Close()
            'Catch ex As Exception
            '    MsgBox(ex.Message)
            '    Exit Sub
            'End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label228.Text & "','" & CDec(Form1.TextBox282.Text) & "','" & Label3.Text & "','" & Form1.Label216.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label227.Text & "','" & CDec(Form1.TextBox281.Text) & "','" & Label3.Text & "','" & Form1.Label216.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label226.Text & "','" & CDec(Form1.TextBox280.Text) & "','" & Label3.Text & "','" & Form1.Label216.Text & "')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'gfhgfhgfhgfhgfh
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label225.Text & "','" & CDec(Form1.TextBox279.Text) & "','" & Label3.Text & "','" & Form1.Label216.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label202.Text & "','" & CDec(Form1.TextBox278.Text) & "','" & Label3.Text & "','" & Form1.Label216.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label233.Text & "','" & CDec(Form1.TextBox291.Text) & "','" & Label3.Text & "','" & Form1.Label234.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label232.Text & "','" & CDec(Form1.TextBox290.Text) & "','" & Label3.Text & "','" & Form1.Label234.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label231.Text & "','" & CDec(Form1.TextBox289.Text) & "','" & Label3.Text & "','" & Form1.Label234.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label236.Text & "','" & CDec(Form1.TextBox292.Text) & "','" & Label3.Text & "','" & Form1.Label234.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label242.Text & "','" & CDec(Form1.TextBox296.Text) & "','" & Label3.Text & "','" & Form1.Label238.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label241.Text & "','" & CDec(Form1.TextBox295.Text) & "','" & Label3.Text & "','" & Form1.Label238.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label240.Text & "','" & CDec(Form1.TextBox294.Text) & "','" & Label3.Text & "','" & Form1.Label238.Text & "')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'dfhghgfhfgh
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label237.Text & "','" & CDec(Form1.TextBox293.Text) & "','" & Label3.Text & "','" & Form1.Label238.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label249.Text & "','" & CDec(Form1.TextBox305.Text) & "','" & Label3.Text & "','" & Form1.Label245.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label248.Text & "','" & CDec(Form1.TextBox304.Text) & "','" & Label3.Text & "','" & Form1.Label245.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label247.Text & "','" & CDec(Form1.TextBox303.Text) & "','" & Label3.Text & "','" & Form1.Label245.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label252.Text & "','" & CDec(Form1.TextBox308.Text) & "','" & Label3.Text & "','" & Form1.Label245.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label251.Text & "','" & CDec(Form1.TextBox307.Text) & "','" & Label3.Text & "','" & Form1.Label245.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label191.Text & "','" & CDec(Form1.TextBox410.Text) & "','" & Label3.Text & "','" & Form1.Label245.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label260.Text & "','" & CDec(Form1.TextBox318.Text) & "','" & Label3.Text & "','" & Form1.Label256.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label259.Text & "','" & CDec(Form1.TextBox317.Text) & "','" & Label3.Text & "','" & Form1.Label256.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label258.Text & "','" & CDec(Form1.TextBox316.Text) & "','" & Label3.Text & "','" & Form1.Label256.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label255.Text & "','" & CDec(Form1.TextBox315.Text) & "','" & Label3.Text & "','" & Form1.Label256.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label254.Text & "','" & CDec(Form1.TextBox314.Text) & "','" & Label3.Text & "','" & Form1.Label256.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label263.Text & "','" & CDec(Form1.TextBox319.Text) & "','" & Label3.Text & "','" & Form1.Label253.Text & "')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'abjo
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label262.Text & "','" & CDec(Form1.TextBox313.Text) & "','" & Label3.Text & "','" & Form1.Label253.Text & "')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox("1")
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label264.Text & "','" & CDec(Form1.TextBox320.Text) & "','" & Label3.Text & "','" & Form1.Label253.Text & "')", conexion6)
                conexion6.Open()

                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox("2")
                Exit Sub
            End Try
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label276.Text & "','" & CDec(Form1.TextBox335.Text) & "','" & Label3.Text & "','" & Form1.Label271.Text & "')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox("3")
                Exit Sub
            End Try
            ''arriba
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label275.Text & "','" & CDec(Form1.TextBox334.Text) & "','" & Label3.Text & "','" & Form1.Label271.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label274.Text & "','" & CDec(Form1.TextBox333.Text) & "','" & Label3.Text & "','" & Form1.Label271.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label273.Text & "','" & CDec(Form1.TextBox332.Text) & "','" & Label3.Text & "','" & Form1.Label271.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label270.Text & "','" & CDec(Form1.TextBox331.Text) & "','" & Label3.Text & "','" & Form1.Label271.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label269.Text & "','" & CDec(Form1.TextBox330.Text) & "','" & Label3.Text & "','" & Form1.Label271.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label268.Text & "','" & CDec(Form1.TextBox329.Text) & "','" & Label3.Text & "','" & Form1.Label271.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label267.Text & "','" & CDec(Form1.TextBox328.Text) & "','" & Label3.Text & "','" & Form1.Label271.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label277.Text & "','" & CDec(Form1.TextBox336.Text) & "','" & Label3.Text & "','" & Form1.Label271.Text & "')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            'Roles de canela
            Try
                Dim cmd As New OleDbCommand
                Dim r1 As Integer

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label133.Text & "','" & CDec(Form1.TextBox780.Text) & "','" & Label3.Text & "','" & Form1.Label271.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label284.Text & "','" & CDec(Form1.TextBox341.Text) & "','" & Label3.Text & "','" & Form1.Label279.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label283.Text & "','" & CDec(Form1.TextBox340.Text) & "','" & Label3.Text & "','" & Form1.Label279.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label288.Text & "','" & CDec(Form1.TextBox343.Text) & "','" & Label3.Text & "','" & Form1.Label285.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label287.Text & "','" & CDec(Form1.TextBox342.Text) & "','" & Label3.Text & "','" & Form1.Label285.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label281.Text & "','" & CDec(Form1.TextBox338.Text) & "','" & Label3.Text & "','" & Form1.Label285.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label291.Text & "','" & CDec(Form1.TextBox344.Text) & "','" & Label3.Text & "','" & Form1.Label203.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('" & Form1.Label290.Text & "','" & CDec(Form1.TextBox286.Text) & "','" & Label3.Text & "','" & Form1.Label203.Text & "')", conexion6)
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

                cmd = New OleDbCommand("INSERT INTO Reporte_Producción(Producto,Cantidad,Fecha,Categoría) VALUES('Panqué budín circular','" & CDec(Form1.TextBox348.Text) & "','" & Label3.Text & "','" & Form1.Label294.Text & "')", conexion6)
                conexion6.Open()
                r1 = cmd.ExecuteNonQuery
                conexion6.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try



            MsgBox("Listo. Información enviada a Cuentas por Cobrar.", MsgBoxStyle.Information, "Rosa de Sarón Pastelerías")
        End If


        PrintDocument1.Print()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        If TextBox103.Text = "Pastelería 1" Then

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
        End If

        If TextBox103.Text = "Pastelería 2" Then

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
                adaptador = New OleDbDataAdapter(buscar, conexion1)
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
        End If

        If TextBox103.Text = "Batidos" Then

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


            While i < DataGridView1.RowCount



                e.Graphics.DrawString(DataGridView1.Item(0, i).Value, prFont2, Brushes.Black, 0, i * 15 + 190)
                e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont2, Brushes.Black, 125, i * 15 + 190)
                e.Graphics.DrawString(DataGridView1.Item(3, i).Value, prFont2, Brushes.Black, 155, i * 15 + 190)





                i += 1
            End While
        End If

        If TextBox103.Text = "Cremosos" Then

            Dim dataTableComb As New DataTable()




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

            '  Label4.Text 
            Try
                Dim adaptadorCremosos As New OleDbDataAdapter
                Dim tablaCremosos As New DataTable
                Dim buscarCremosos As String
                buscarCremosos = ("select * from Reporte_Producción where Fecha='" & Label3.Text & "'")
                adaptadorCremosos = New OleDbDataAdapter(buscarCremosos, conexion3)
                tablaCremosos = New DataTable
                adaptadorCremosos.Fill(tablaCremosos)
                dataTableComb.Merge(tablaCremosos)

            Catch ex As Exception
                MsgBox(ex.Message & " No hay ningún reporte enviado aún.")
                conexion.Close()

                Exit Sub
            End Try


            Try
                Dim adapterFlanes As New OleDbDataAdapter
                Dim tablaflanes As New DataTable
                Dim findFlanes As String
                findFlanes = ("SELECT * FROM Reporte_Producción where Fecha='" & Label3.Text & "'")
                adapterFlanes = New OleDbDataAdapter(findFlanes, conexion4)
                tablaflanes = New DataTable
                adapterFlanes.Fill(tablaflanes)
                dataTableComb.Merge(tablaflanes)
                conexion4.Close()

            Catch ex As Exception
                MsgBox(ex.Message & " No hay ningún reporte enviado aún.")
                conexion4.Close()

                Exit Sub
            End Try


            Try
                Dim adapterpaste As New OleDbDataAdapter
                Dim tablapaste As New DataTable
                Dim findpaste As String

                findpaste = ("select *from Reporte_Producción where Producto ='Pay limon G.' AND Fecha='" & Label3.Text & "'")
                adapterpaste = New OleDbDataAdapter(findpaste, conexion)
                tablapaste = New DataTable
                adapterpaste.Fill(tablapaste)
                conexion.Close()

                dataTableComb.Merge(tablapaste)
            Catch ex As Exception
                MsgBox(ex.Message & " No hay ningún reporte enviado aún.")
                conexion.Close()

                Exit Sub
            End Try




            ' Mostrar en el DataGridView
            DataGridView1.DataSource = dataTableComb


            While i < DataGridView1.RowCount



                e.Graphics.DrawString(DataGridView1.Item(0, i).Value, prFont2, Brushes.Black, 0, i * 15 + 190)
                e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont2, Brushes.Black, 125, i * 15 + 190)
                e.Graphics.DrawString(DataGridView1.Item(3, i).Value, prFont2, Brushes.Black, 155, i * 15 + 190)





                i += 1
            End While
        End If

        If TextBox103.Text = "Flanes y arroz" Then

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
                Dim adapter As New OleDbDataAdapter
                Dim tablaflanes As New DataTable
                Dim find As String

                find = ("select *from Reporte_Producción where Fecha='" & Label3.Text & "'")
                adapter = New OleDbDataAdapter(find, conexion4)
                tablaflanes = New DataTable
                adapter.Fill(tablaflanes)
                DataGridView1.DataSource = tablaflanes
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
        End If

        If TextBox103.Text = "Gelatinas" Then

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
                adaptador = New OleDbDataAdapter(buscar, conexion5)
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

                'For Each Fila As DataGridViewRow In DataGridView1.Rows
                '    If Not Fila Is Nothing Then

                '        '//O puedes hacer una validación con el número de la columna
                '        If Fila.Cells(0).Value = "Gel. Gde. Dom esp. Durazno" Then
                '            DataGridView1.Item(0, 0).Value = "Gel Gde D.E Durazno"
                '        End If
                '        If Fila.Cells(0).Value = "Gel. Gde. Dom esp. Fresa" Then
                '            DataGridView1.Item(0, 1).Value = "Gel Gde D.E Fresa"
                '        End If
                '        If Fila.Cells(0).Value = "Gel. Gde. Dom esp. Mango" Then
                '            DataGridView1.Item(0, 2).Value = "Gel Gde D.E Mango"
                '        End If
                '        If Fila.Cells(0).Value = "Gel. Gde. Dom esp. Manzana" Then
                '            DataGridView1.Item(0, 3).Value = "Gel Gde D.E Manzana"
                '        End If
                '        If Fila.Cells(0).Value = "Gel. Gde. Dom esp. Naranja" Then
                '            DataGridView1.Item(0, 4).Value = "Gel Gde D.E Naranja"
                '        End If
                '        If Fila.Cells(0).Value = "Gel. Gde. Dom esp. Uva" Then
                '            DataGridView1.Item(0, 5).Value = "Gel Gde D.E Uva"
                '        End If

                '        If Fila.Cells(0).Value = "Gel. Med. Dom esp. Durazno" Then
                '            DataGridView1.Item(0, 6).Value = "Gel Med D.E Durazno"
                '        End If
                '        If Fila.Cells(0).Value = "Gel. Med. Dom esp. Fresa" Then
                '            DataGridView1.Item(0, 7).Value = "Gel Med D.E Fresa"
                '        End If
                '        If Fila.Cells(0).Value = "Gel. Med. Dom esp. Mango" Then
                '            DataGridView1.Item(0, 8).Value = "Gel Med D.E Mango"
                '        End If
                '        If Fila.Cells(0).Value = "Gel. Med. Dom esp. Manzana" Then
                '            DataGridView1.Item(0, 9).Value = "Gel Med D.E Manzana"
                '        End If
                '        If Fila.Cells(0).Value = "Gel. Med. Dom esp. Naranja" Then
                '            DataGridView1.Item(0, 10).Value = "Gel Med D.E Naranja"
                '        End If
                '        If Fila.Cells(0).Value = "Gel. Med. Dom esp. Uva" Then
                '            DataGridView1.Item(0, 11).Value = "Gel Med D.E Uva"
                '        End If

                '        '//O puedes almacenar el valor en una base de datos o mostrarlo en un textbox
                '        'TextBox1.Text = Fila.Cells("Telefono").Value
                '    End If
                'Next


                e.Graphics.DrawString(DataGridView1.Item(0, i).Value, prFont2, Brushes.Black, 0, i * 15 + 190)
                e.Graphics.DrawString(DataGridView1.Item(1, i).Value, prFont2, Brushes.Black, 125, i * 15 + 190)
                e.Graphics.DrawString(DataGridView1.Item(3, i).Value, prFont2, Brushes.Black, 155, i * 15 + 190)

                i += 1
            End While
        End If

        If TextBox103.Text = "Panadería" Then

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
                adaptador = New OleDbDataAdapter(buscar, conexion6)
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
        End If

    End Sub
End Class