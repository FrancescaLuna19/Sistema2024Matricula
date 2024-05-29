Imports System.Data.OleDb
Public Class frmBuscar
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0; Data Source=D:\Programación\II PARCIAL - I SEMESTRE\Conexionconbasededatos\basededatos\matriculaINUED(2002-2003)mdb")
        Try

            con.Open()
            MsgBox("Registro Encontrado", , "Buscar")

            Dim query = "Select * from maestro Where DNIMAESTRO Like'" & txtBuscar.Text & "'%"
            Dim adap As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adap.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox("No se conectó por: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmGraficas.Show()
    End Sub
End Class