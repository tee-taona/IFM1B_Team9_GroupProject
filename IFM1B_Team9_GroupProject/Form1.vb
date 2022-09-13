''Option Statements
Option Strict On
Option Explicit On
Option Infer Off

Public Class frmDisease
    ''METHODS

    Private Sub FillGrid(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        'A subroutine that displays the information into the grid
        grdDisease.Row = r
        grdDisease.Col = c
        grdDisease.Text = t
    End Sub

    Private Sub CaptureHIV()
        'A method for capturing the data of HIV

        Dim objHiv As HIVAIDS

        For y As Integer = 1 To NumHIV 'Number of years for HIV
            objHiv = New HIVAIDS(NumHIV, "HIV / AIDS", ARVCost)
            objHiv.Year(y).Year = InputBox("Enter the year " & objHiv.Name & " is being monitored")
            objHiv.Year(y).Infections = CInt(InputBox("Enter the number of infections for " & objHiv.Name & " in " & objHiv.Year(y).Year))
            objHiv.Year(y).Treatment = CInt(InputBox("Enter the number of Treatments given for " & objHiv.Name & " in " & objHiv.Year(y).Year))

            'Calculations
            'Determining whether there is a need for fundraising
        Next
    End Sub

    Private Sub CaptureC19()
        'A method for capturing the data of Covid 19
        Dim objC19 As Covid19

        For y As Integer = 1 To NumHIV 'Number of years for Covid 19
            objC19 = New Covid19(NumC19, "Covid", VaccineCost)
            objC19.Year(y).Year = InputBox("Enter the year " & objC19.Name & " is being monitored")
            objC19.Year(y).Infections = CInt(InputBox("Enter the number of infections for " & objC19.Name & " in " & objC19.Year(y).Year))
            objC19.Year(y).Treatment = CInt(InputBox("Enter the number of Treatments given for " & objC19.Name & " in " & objC19.Year(y).Year))

            'Calculations
            'Determining whether there is a need for fundraising
        Next
    End Sub

    Private Sub DisplayHIV()
        'A subroutine for display the information of HIV
        lblDisplay.Text = "HIV / AIDS information"
        Dim objHiv As HIVAIDS

        'Initialising the grid
        FillGrid(0, 0, "Year")
        FillGrid(0, 1, "Number of Infections")
        FillGrid(0, 2, "People Treated")
        FillGrid(0, 3, "Death Count")
        FillGrid(0, 4, "Fundraise Amount")


        'Filling the information into the grid
        For r As Integer = 1 To NumHIV

        Next

    End Sub

    Private Sub DisplayC19()
        'A subroutine to display the information of the C19
        lblDisplay.Text = "Covid 19 information"
        Dim objC19 As Covid19

        'Initialising the grid



        'Filling the information into the grid
    End Sub

    Private Sub DisplayGeneral()
        'A subroutine for displaying the general information regarding the diseases
        lblDisplay.Text = "General Information"
    End Sub


    ''VARIABLES
    Private NumHIV, NumC19, ARVCost, VaccineCost, choice As Integer
    Private objDisease(2) As Disease


    '********************************************************************************************************************************
    ''CODE
    Private Sub btnInitialise_Click(sender As Object, e As EventArgs) Handles btnInitialise.Click
        'Capturing the sizes of each class and array
        NumHIV = CInt(txtNumHIV.Text)
        NumC19 = CInt(txtNumC19.Text)
        ARVCost = CInt(txtCostHIV.Text)
        VaccineCost = CInt(txtCostC19.Text)
        'resizing and initialising the grid and array

        Panel1.Enabled = False
        Panel2.Visible = True



    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        'Capturing information for each disease


    End Sub


    Private Sub frmDisease_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Visible = False
    End Sub

End Class
