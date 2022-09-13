'Option statements
Option Strict On
Option Explicit On
Option Infer Off
Public Class Year
    'Instance variables
    Private _Year As String
    Private _Infections As Integer
    Private _NewInfections As Integer
    Private _TreatmentReceived As Integer
    Private _DeathCount As Integer
    Private _NumYears As Integer


    'Utility Method
    Private Function Validate(value As Integer) As Integer
        Dim num As Integer
        If value < 0 Then
            num = 0
        Else
            num = value
        End If
        Return num
    End Function

    'Property Methods
    Public Property Year() As String
        Get
            Return _Year
        End Get
        Set(value As String)
            _Year = value
        End Set
    End Property
    Public Property Infections() As Integer
        Get
            Return _Infections
        End Get
        Set(value As Integer)

            _Infections = Validate(value)
        End Set
    End Property
    Public ReadOnly Property NewInfections() As Integer
        Get
            Return _NewInfections
        End Get
    End Property
    Public Property TreatmentReceived() As Integer
        Get
            Return _TreatmentReceived
        End Get
        Set(value As Integer)
            _TreatmentReceived = Validate(value)
        End Set
    End Property
    Public Property DeathCount() As Integer
        Get
            Return _DeathCount
        End Get
        Set(value As Integer)
            _DeathCount = Validate(value)
        End Set
    End Property

    Public Property NumYears() As Integer
        Get
            Return _NumYears
        End Get
        Set(value As Integer)
            _NumYears = Validate(value)
        End Set
    End Property
    'Trend Methods
    Public Function DeathTrend(Deaths As Integer) As Integer 'ie running through the deaths of year array in the form
        Dim Increasing As Boolean = True
        Dim Counter As Integer = 0
        Dim NumDeaths As Integer

        For y As Integer = 2 To _NumYears
            'Increase in deaths
            If NumDeaths < Deaths Then
                Counter += 1
                NumDeaths = Deaths
                'Decrease in deaths
            Else
                Counter -= 1
            End If

            'Increase trend
            If Counter > 0 Then 'If counter < 0 then decreasing. If 0 then stays the same.
                Increasing = True
            Else
                Increasing = False
            End If
        Next y
        Return CInt(Increasing)
    End Function
    Public Function InfectionTrend(Infections As Integer) As Integer 'ie running through the infections of year array in the form

        'Infection Increase / Decrease
        'If positive % then increase
        'If negative % then decrease









        Dim Increasing As Boolean = True
        Dim counter As Integer = 0
        Dim NumInfections As Integer

        For y As Integer = 2 To NumYears
            'Increase in infections
            If NumInfections < Infections Then
                counter += 1
                NumInfections = Infections
                'Decrease in infections
            Else
                counter -= 1
            End If

            'Increase trend
            If counter > 0 Then 'If counter < 0 then decreasing. If 0 then stays the same.
                Increasing = True
            Else
                Increasing = False
            End If
        Next y
        Return CInt(Increasing)
    End Function
End Class
