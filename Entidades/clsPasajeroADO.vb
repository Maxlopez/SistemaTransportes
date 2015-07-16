Imports Entidades
Imports Acceso_Datos
Imports System.Data
Imports System.Data.SqlClient

Public Class clsPasajeroADO
    Public Sub agregar(ByVal obj As clsPasajero)
        Dim conexion As clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try
            sql = "Insert into Pasajero " &
                "Values ('" & obj.DNI & "', '" & obj.nombres &
                "', '" & obj.apellidoPat & "', '" & obj.apellidoMat & "', '" & obj.telefono & "')"

            conexion = New clsConexion

            conexion.Conectar()
            'Creando el comando con la sentencia SQL
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
        Dim obj As clsPasajero
        Dim conexion As New clsConexion
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim sql As String
        Try
            sql = "Select * from Pasajero"
            conexion.Conectar()
            cmd = New SqlCommand(sql, conexion.get_Conexion)
            dr = cmd.ExecuteReader
            While dr.Read
                obj = New clsPasajero(dr("DNI").ToString, dr("nombres").ToString, dr("apellidoPat").ToString, dr("apellidoMat").ToString,
                                         dr("telefono").ToString)
                lista.Add(obj)
            End While
            conexion.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return lista
    End Function
End Class
