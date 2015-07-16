Public Class clsPasajero
    Private m_DNI As String
    Private m_nombres As String
    Private m_apellidoPat As String
    Private m_apellidoMat As String
    Private m_telefono As String

    Sub New(ByVal dni As String, ByVal nombres As String, ByVal apellidoPat As String, ByVal apellidoMat As String, ByVal telefono As String)
        m_DNI = dni
        m_nombres = nombres
        m_apellidoPat = apellidoPat
        m_apellidoMat = apellidoMat
        m_telefono = telefono

    End Sub

    Public ReadOnly Property DNI As String
        Get
            Return m_DNI
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

End Class
