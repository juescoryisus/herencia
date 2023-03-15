Public Class Empleado
    Inherits Personas

    Private _tipoContrato As String
    Private _sueldo As String

    Public Property TipoContrato As String
        Get
            Return _tipoContrato
        End Get
        Set(value As String)
            _tipoContrato = value
        End Set
    End Property

    Public Property Sueldo As Double
        Get
            Return _sueldo
        End Get
        Set(value As Double)
            _sueldo = value
        End Set
    End Property

    Public Sub calcularsueldo(sueldobase As Double)
        If (Me.TipoContrato = "c") Then
            Me.Sueldo = sueldobase + 350
        ElseIf (Me.TipoContrato = "n") Then
            Me.Sueldo = sueldobase + 750
        Else
            Me.Sueldo = 0
        End If
    End Sub

End Class
