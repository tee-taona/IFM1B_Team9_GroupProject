'Options
Option Strict On
Option Explicit On
Option Infer On

Public MustInherit Class Disease
    Implements IFunction

    'Attributes
    Private _Name As String     'Used to extract the name and insert into the grid
    Private _isVirus As Boolean
    Private _Year() As Year     'Composition

    'Constructor
    Public Sub New(period As Integer, name As String)
        _Name = name
        ReDim _Year(period)
        For y As Integer = 1 To period
            _Year(y) = New Year()
        Next y
    End Sub

    'Property Methods
    Public ReadOnly Property Name() As String
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

    'General methods
    Public MustOverride Function getFundraiser() As Boolean

    Public MustOverride Function getFundraiser(num As Integer) As Boolean

    Public Function InfectionIncDec() As Integer Implements IFunction.InfectionIncDec


    End Function

    Private Function IFunction_getFundraiser() As Boolean Implements IFunction.getFundraiser
        Return True
    End Function
End Class
