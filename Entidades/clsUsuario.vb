Public Class clsUsuario
    Private m_usuario As String
    Private m_nombre As String
    Private m_clave As String
    Private m_rol As String
    Private m_estado As Integer

    Sub New(ByVal usuario As String, ByVal clave As String, ByVal nombre As String, ByVal rol As String, ByVal estado As Integer)
        m_usuario = usuario
        m_clave = clave
        m_nombre = nombre
        m_rol = rol
        m_estado = estado

    End Sub

    Public ReadOnly Property usuario As String
        Get
            Return m_usuario
        End Get
    End Property

    Public ReadOnly Property nombre As String
        Get
            Return m_nombre
        End Get
    End Property
    Public ReadOnly Property clave As String
        Get
            Return m_clave
        End Get
    End Property

    Public ReadOnly Property rol As String
        Get
            Return m_rol
        End Get
    End Property

    Public ReadOnly Property estado As String
        Get
            Return m_estado
        End Get
    End Property

End Class

