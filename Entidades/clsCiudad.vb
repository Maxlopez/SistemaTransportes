Public Class clsCiudad
    Dim m_id As Integer
    Dim m_nombre As String
    Dim m_direccion As String

    Sub New(ByVal id As Integer, ByVal nombre As String, ByVal direccion As String)
        m_id = id
        m_nombre = nombre
        m_direccion = direccion
    End Sub

    Public ReadOnly Property id As String
        Get
            Return m_id
        End Get
    End Property

    Public ReadOnly Property nombre As String
        Get
            Return m_nombre
        End Get
    End Property

    Public ReadOnly Property direccion As String
        Get
            Return m_direccion
        End Get
    End Property



End Class
