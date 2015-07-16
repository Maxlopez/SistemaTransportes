Public Class clsChofer
    Private m_dniChofer As String
    Private m_nombres As String
    Private m_apellidoPat As String
    Private m_apellidoMat As String
    Private m_telefono As String
    Private m_estado As Integer

    Sub New(ByVal dniChofer As String, ByVal nombres As String, ByVal apellidoPat As String, ByVal apellidoMat As String, ByVal telefono As String, ByVal estado As Integer)
        m_dniChofer = dniChofer
        m_nombres = nombres
        m_apellidoPat = apellidoPat
        m_apellidoMat = apellidoMat
        m_telefono = telefono
        m_estado = estado

    End Sub

    Public ReadOnly Property dniChofer As String
        Get
            Return m_dniChofer
        End Get
    End Property

    Public ReadOnly Property nombres As String
        Get
            Return m_nombres
        End Get
    End Property

    Public ReadOnly Property apellidoPat As String
        Get
            Return m_apellidoPat
        End Get
    End Property

    Public ReadOnly Property apellidoMat As String
        Get
            Return m_apellidoMat
        End Get
    End Property

    Public ReadOnly Property telefono As String
        Get
            Return m_telefono
        End Get
    End Property

    Public ReadOnly Property estado As String
        Get
            Return m_estado
        End Get
    End Property

End Class
