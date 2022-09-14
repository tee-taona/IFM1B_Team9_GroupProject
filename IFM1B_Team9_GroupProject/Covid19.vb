''Option Statements
Option Strict On
Option Explicit On
Option Infer Off


''CLASS
Public Class Covid19
    Inherits Disease


    ''Attributes
    'Private _Type As String
    'Private _VaccineCost As Double

    ''Constructor
    Public Sub New(period As Integer, Cost As Double)
        MyBase.New(period)
        VaccineCost = Cost
    End Sub
    'Public Sub New(period As Integer, name As String, Cost As Double)
    '    MyBase.New(period, name)
    '    _VaccineCost = Cost
    'End Sub

    ''Property Methods


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

    ''Methods
    Public Function getVaccinesNeeded(yr As Integer) As Integer
        Return getTreatmentNeeded(yr)
    End Function
End Class
