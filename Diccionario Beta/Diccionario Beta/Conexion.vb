Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Conexion

    ''Variables de clase'
    Public cn As SqlConnection
    Public cmd As SqlCommand
    Public dr As SqlDataReader




    'Constructor de la clase Conexion que crea la conexion'
    Sub New()
        Try
            cn = New SqlConnection("Data Source= STEVEN1\ SXC_PUROSNICA;Initial Catalog=costo;Integrated Security=True")
            cn.Open()
            '' MsgBox("CONECTADO")
        Catch ex As Exception
            MsgBox("Error al conectarse debido a: " + ex.ToString)
        End Try
    End Sub

    'Instruccion Insert que inserta los datos en la Tabla dulce'
    Function managua(ByVal Nombre As Integer, ByVal cantidad As Integer, ByVal ns As Integer) As String
        Dim salida As String = " Registrado"

        Try
            cmd = New SqlCommand("Insert into managua(Dulces,Bebidas,Conservas  ) values ('" & Nombre & "','" & cantidad & "','" & ns & "')", cn)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            salida = "No se inserto debido a: " + ex.ToString
        End Try
        Return salida



    End Function


End Class
