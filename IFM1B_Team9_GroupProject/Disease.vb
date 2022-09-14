'Options
Option Strict On
Option Explicit On
Option Infer On

Public MustInherit Class Disease
    'Implements IFunction

    'Attributes
    Private _Name As String     'Used to extract the name and insert into the grid
    Private _isVirus As Boolean
    Private _Year() As Year     'Composition
    Private Const _ARVCost As Double = 30
    Private _VaccineCost As Double

    'Constructor
    Public Sub New(period As Integer)

        ReDim _Year(period)
        For y As Integer = 1 To period
            _Year(y) = New Year()
        Next y
    End Sub

    'Property Methods
    Public Property Name() As String
        Set(value As String)
            _Name = value
        End Set
        Get
            Return _Name
        End Get
    End Property

    Public Property isVirus() As Boolean
        Get
            Return _isVirus
        End Get
        Set(value As Boolean)
            _isVirus = value
        End Set
    End Property

    Public Property Year(index As Integer) As Year
        Get
            Return _Year(index)
        End Get
        Set(value As Year)
            _Year(index) = value
        End Set
    End Property

    Public Property VaccineCost As Double
        Set(value As Double)
            _VaccineCost = value
        End Set
        Get
            Return _VaccineCost
        End Get
    End Property

    'General methods
    Public Function ArrayLength() As Integer
        Return _Year.Length() - 1
    End Function

    Public Function getFundraise(yr As Integer) As Double

        Return getTreatmentNeeded(yr) * _ARVCost

    End Function

    Public Function getFundraise(yr As Integer, cost As Integer) As Double
        Return getTreatmentNeeded(yr) * cost
    End Function

    Public Function getTreatmentNeeded(yr As Integer) As Integer
        Return ((Year(yr).Infections) - Year(yr).TreatmentReceived)
    End Function

    Public Function DeathTrend(yr As Integer) As Integer
        If yr = 1 Then
            Return 0
        Else
            Dim Increase As Integer = (_Year(yr).DeathCount) - (_Year(yr - 1).DeathCount)
            Return CInt(Increase / _Year(yr - 1).DeathCount * 100)
        End If
    End Function

    Public Function InfectionTrend(yr As Integer) As Integer
        If yr = 1 Then
            Return 0
        Else
            Dim Increase As Integer = (_Year(yr).Infections) - (_Year(yr - 1).Infections)
            Return CInt(Increase / _Year(yr - 1).Infections * 100)
        End If
    End Function

    Public Overridable Function isInfectionReduced() As Boolean

        Dim boolReduced As Boolean = True
        Return boolReduced
    End Function

    Public Overridable Function isDeathReduced() As Boolean

        Dim boolReduced As Boolean = True
        Return boolReduced
    End Function

    'Public MustOverride Function getFundraiser() As Boolean

    'Public MustOverride Function getFundraiser(num As Integer) As Boolean

    'Public Function InfectionIncDec() As Integer Implements IFunction.InfectionIncDec
    'End Function

    'Private Function IFunction_getFundraiser() As Boolean Implements IFunction.getFundraiser
    '    Return True
    'End Function
End Class
