''Option Statements
Option Strict On
Option Explicit On
Option Infer Off


''CLASS
Public Class Covid19
    Inherits Disease


    ''Attributes
    'Private _Type As String
    Private _VaccineCost As Double

    ''Constructor
    Public Sub New(period As Integer, name As String, Cost As Double)
        MyBase.New(period, name)
        _VaccineCost = Cost
    End Sub

    ''Property Methods
    Public ReadOnly Property VaccineCost() As Double
        Get
            Return _VaccineCost
        End Get
    End Property


    ''Methods
    Public Overrides Function getFundraiser() As Boolean
        Throw New NotImplementedException()
    End Function

    Public Overrides Function getFundraiser(num As Integer) As Boolean
        Throw New NotImplementedException()
    End Function
End Class
