Imports System.Data
Imports System.Data.SqlClient

Public Class clsConexion
    Private m_conexion As SqlConnection

    Sub New()
        Dim cadConexion As String
        cadConexion = "Data Source = COREI5\SQLSERVER2012; Initial Catalog = bd_transporte; Integrated Security = True"
        m_conexion = New SqlConnection
        m_conexion.ConnectionString = cadConexion
    End Sub

    Public Sub Conectar()
        Try
            If m_conexion.State <> ConnectionState.Open Then
                m_conexion.Open()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub Desconectar()
        Try
            If m_conexion.State <> ConnectionState.Open Then
                m_conexion.Close()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public ReadOnly Property get_Conexion As SqlConnection
        Get
            Return m_conexion
        End Get
    End Property
End Class
