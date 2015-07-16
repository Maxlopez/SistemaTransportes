Imports Entidades
Imports Acceso_Datos
Imports System.Data
Imports System.Data.SqlClient

Public Class clsChoferADO
    Public Sub agregar(ByVal obj As clsChofer)
        Dim cn As clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try
            sql = "Insert into Chofer " &
                "Values ('" & obj.dniChofer & "', '" & obj.nombres &
                "', '" & obj.apellidoPat & "', '" & obj.apellidoMat & "', '" & obj.telefono & "', " & obj.estado & ")"

            cn = New clsConexion

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
        Dim obj As clsChofer
        Dim cn As New clsConexion
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim sql As String
        Try
            sql = "Select * from Chofer"
            cn.Conectar()
            cmd = New SqlCommand(sql, cn.get_Conexion)
            dr = cmd.ExecuteReader
            While dr.Read 'Leer los registros de la tabla Participante y pasarlos a objetos
                obj = New clsChofer(dr("dniChofer").ToString, dr("nombres").ToString, dr("apellidoPat").ToString, dr("apellidoMat").ToString,
                                         dr("telefono").ToString, CInt(dr("estado")))
                lista.Add(obj)
            End While
            cn.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return lista
    End Function
End Class
