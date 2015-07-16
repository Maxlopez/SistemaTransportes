Imports Entidades
Imports Acceso_Datos
Imports System.Data
Imports System.Data.SqlClient
Public Class clsPasajeroADO
    Public Sub agregar(ByVal obj As clsPasajero)
        Dim cn As clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try
            sql = "Insert into pasajero " &
                "Values ('" & obj.DNI & "', '" & obj.nombres &
                "', '" & obj.apellidoPat & "', '" & obj.apellidoMat & "', '" & obj.telefono & "')"

            cn = New clsConexion
            'Borrar esto
            cn.Conectar()
            'Creando el comando con la sentencia SQL
            cmd = New SqlCommand(sql, cn.get_Conexion)
            'Ejecutando la sentencia
            cmd.ExecuteNonQuery()
            cn.Desconectar()
        Catch ex As Exception
            Throw ex 'Devolviendo el error hacia las ventanas
        End Try

    End Sub

    Public Function listado() As ArrayList
        Dim lista As New ArrayList
        Dim obj As clsPasajero
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim sql As String
        Try
            sql = "Select * from Participante"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.get_Conexion)
            dr = cmd.ExecuteReader
            While dr.Read 'Leer los registros de la tabla Participante y pasarlos a objetos
                obj = New clsPasajero(dr("DNI").ToString, dr("nombres").ToString, dr("apellidoPat").ToString, dr("apellidoMat").ToString,
                                         dr("telefono").ToString)
                lista.Add(obj)
            End While
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return lista
    End Function
End Class
