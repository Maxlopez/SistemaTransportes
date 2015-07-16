Imports Entidades
Imports Acceso_Datos
Imports System.Data
Imports System.Data.SqlClient

Public Class clsCiudadADO
    Public Sub agregar(ByVal obj As clsCiudad)
        Dim conexion As clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try
            sql = "Insert into Ciudad " &
                "Values ('" & obj.nombre & "', '" & obj.direccion & "')"

            conexion = New clsConexion

            conexion.Conectar()
            'Creando el cmdo con la sentencia SQL
            cmd = New SqlCommand(sql, conexion.get_Conexion)
            'Ejecutando la sentencia
            cmd.ExecuteNonQuery()
            conexion.Desconectar()
        Catch ex As Exception
            Throw ex 'Devolviendo el error hacia las ventanas
        End Try

    End Sub

    Public Function listado() As ArrayList
        Dim lista As New ArrayList
        Dim obj As clsCiudad
        Dim conexion As New clsConexion
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim sql As String
        Try
            sql = "Select * from Ciudad"
            conexion.Conectar()
            cmd = New SqlCommand(sql, conexion.get_Conexion())
            dr = cmd.ExecuteReader
            While dr.Read
                obj = New clsCiudad(CInt(dr("id").ToString), dr("nombre").ToString, dr("direccion").ToString)
                lista.Add(obj)
            End While
            conexion.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return lista
    End Function
End Class
