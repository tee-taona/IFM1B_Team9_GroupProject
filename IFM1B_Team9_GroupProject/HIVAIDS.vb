''Option Statements
Option Strict On
Option Explicit On
Option Infer Off

Public Class HIVAIDS
    Inherits Disease

    ''Attributes
    Private _isInfectionReduced As Boolean

    ''Constructor
    Public Sub New(period As Integer)
        MyBase.New(period)
    End Sub

    Public Property InfectionReduced As Boolean
        Get
            Return _isInfectionReduced
        End Get
        Set(value As Boolean)
            _isInfectionReduced = value
        End Set
    End Property


    ''Methods
    Public Overrides Function isDeathReduced() As Boolean


        Dim boolReduced As Boolean = True
        Dim counter As Integer = 0
        Dim deaths As Integer = DeathTrend(1)

        For y As Integer = 2 To ArrayLength()
            'Increase in infections
            If DeathTrend(y) < deaths Then
                counter += 1
                deaths = DeathTrend(y)
                'Decrease in infections
            Else
                'Increase trend
                counter -= 1
            End If


            If counter >= 0 Then 'If counter > 0 then decreasing. If < 0 then increases.
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

        For y As Integer = 2 To ArrayLength()
            'Increase in infections
            If InfectionTrend(y) < InfectionTrend(y - 1) Then
                counter += 1
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
End Class
