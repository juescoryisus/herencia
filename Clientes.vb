Public Class Clientes
    Inherits Personas

    Private _categorias As String
    Private _codigo As String

    Public Property Categorias As String
        Get
            Return _categorias
        End Get
        Set(value As String)
            _categorias = value
        End Set
    End Property

    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Sub generarCodigo()
        Me.Codigo = "c" & Me.Apellidos.Substring(0, 3) & "16"
    End Sub

End Class
