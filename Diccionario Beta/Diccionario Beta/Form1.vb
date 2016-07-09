Imports System.Data.SqlClient
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DiccionarioDataSet1.Computacion' Puede moverla o quitarla según sea necesario.
        Me.ComputacionTableAdapter1.Fill(Me.DiccionarioDataSet1.Computacion)
        'TODO: esta línea de código carga datos en la tabla 'DiccionarioDataSet.Computacion' Puede moverla o quitarla según sea necesario.
        'Me.ComputacionTableAdapter.Fill(Me.DiccionarioDataSet.Computacion)
        Dim conexion As String
        conexion = "Data Source=CRISTOFER;Database=Diccionario;Integrated Security=True"
        Dim seleccion As String = "SELECT * FROM Computacion"
        Dim adaptadordedatos As SqlDataAdapter
        Dim tabladedatos As New DataTable

        Try
            adaptadordedatos = New SqlDataAdapter(seleccion, conexion)
            adaptadordedatos.Fill(tabladedatos)
            ListBox1.DataSource = tabladedatos


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.ComputacionTableAdapter.FillBy(Me.DiccionarioDataSet.Computacion)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class