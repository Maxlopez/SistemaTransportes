﻿Imports Entidades
Imports Acceso_Datos
Imports System.Data
Imports System.Data.SqlClient

Public Class clsUsuarioADO
    Public Sub agregar(ByVal obj As clsUsuario)
        Dim conexion As clsConexion
        Dim cmd As SqlCommand
        Dim sql As String
        Try
            sql = "Insert into Usuario " &
                "Values ('" & obj.usuario & "', '" & obj.nombre &
                "', '" & obj.clave & "', '" & obj.rol & "', " & obj.estado & ")"

            conexion = New clsConexion
            conexion.Conectar()
            'Creando el comando con la sentencia sql
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
        Dim obj As clsUsuario
        Dim conexion As New clsConexion
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim sql As String
        Try
            sql = "Select * from Usuario"
            conexion.Conectar()
            cmd = New SqlCommand(sql, conexion.get_Conexion)
            dr = cmd.ExecuteReader
            While dr.Read
                obj = New clsUsuario(dr("usuario").ToString, dr("nombre").ToString, dr("clave").ToString, dr("rol").ToString,
                                         CInt(dr("estado")))
                lista.Add(obj)
            End While
            conexion.Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return lista
    End Function
End Class
