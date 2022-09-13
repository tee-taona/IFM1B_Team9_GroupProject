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


    ''Methods
    Public Function getVaccinesNeeded(yr As Integer) As Integer
        Return getTreatmentNeeded(yr)
    End Function
End Class
