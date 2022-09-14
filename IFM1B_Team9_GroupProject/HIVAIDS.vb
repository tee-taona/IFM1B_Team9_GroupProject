''Option Statements
Option Strict On
Option Explicit On
Option Infer Off

Public Class HIVAIDS
    Inherits Disease


    ''Attributes
    'Private _ARVCost As Double
    Private _isInfectionReduced As Boolean

    ''Constructor
    Public Sub New(period As Integer)
        MyBase.New(period)
    End Sub

    ''Property Methods

    'Public ReadOnly Property ARVCost() As Double
    '    Get
    '        Return _ARVCost
    '    End Get
    'End Property

    Public Property isInfectionReduced As Boolean
        Get
            Return _isInfectionReduced
        End Get
        Set(value As Boolean)
            _isInfectionReduced = value
        End Set
    End Property


    ''Methods


    'Public Overrides Function getFundraiser() As Boolean

    'End Function

    'Public Overrides Function getFundraiser(num As Integer) As Boolean

    'End Function


End Class
