''Option Statements
Option Strict On
Option Explicit On
Option Infer Off


''CLASS
Public Class Covid19
    Inherits Disease

    'Attributes
    Private _isDeathReduced As Boolean

    ''Constructor
    Public Sub New(period As Integer, Cost As Double)
        MyBase.New(period)
        VaccineCost = Cost
    End Sub

    Public Property DeathReduced As Boolean
        Get
            Return _isDeathReduced
        End Get
        Set(value As Boolean)
            _isDeathReduced = value
        End Set
    End Property

    ''Methods
    Public Overrides Function isDeathReduced() As Boolean


        Dim boolReduced As Boolean = True
        Dim counter As Integer = 0
        Dim Infections As Integer = InfectionTrend(1)

        For y As Integer = 2 To MyBase.ArrayLength()
            'Increase in infections
            If InfectionTrend(y) < Infections Then
                counter += 1
                Infections = InfectionTrend(y)
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

    Public Overrides Function isInfectionReduced() As Boolean

        Dim boolReduced As Boolean = True
        Dim counter As Integer = 0
        Dim Infections As Integer = InfectionTrend(1)

        For y As Integer = 2 To MyBase.ArrayLength()
            'Increase in infections
            If InfectionTrend(y) < Infections Then
                counter += 1
                Infections = InfectionTrend(y)
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
    Public Function getVaccinesNeeded(yr As Integer) As Integer
        Return getTreatmentNeeded(yr)
    End Function
End Class
