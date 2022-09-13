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
    Public Sub New(period As Integer, Cost As Double)
        MyBase.New(period)
        VaccineCost = Cost
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

    Public Function isReduced() As Boolean

        Dim boolReduced As Boolean = True
        Dim counter As Integer = 0
        Dim Infections As Integer = MyBase.InfectionTrend(1)

        For y As Integer = 2 To ArrayLength()
            'Increase in infections
            If MyBase.InfectionTrend(y) < Infections Then
                counter += 1
                Infections = MyBase.InfectionTrend(y)
                'Decrease in infections
            Else
                'Increase trend
                counter -= 1
            End If

            '
            If counter > 0 Then 'If counter > 0 then decreasing. If < 0 then increases.
                boolReduced = True
            Else
                boolReduced = False
            End If
        Next y
        Return boolReduced
    End Function

    'Public Overrides Function getFundraiser() As Boolean

    'End Function

    'Public Overrides Function getFundraiser(num As Integer) As Boolean

    'End Function


End Class
