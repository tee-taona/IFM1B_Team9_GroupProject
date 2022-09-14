''Option Statements
Option Strict On
Option Explicit On
Option Infer Off
'Edit Test
Public Class frmDisease

    Private yearHIV, yearCvd, VaccineCost As Integer
    Private objHIV As HIVAIDS
    Private objCovid As Covid19
    Private Disease(2) As Disease
    Private Const ARVcost As Double = 25

    'example comment


    '#Form Load
    Private Sub frmDisease_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCostHIV.Text = CStr(ARVcost)
        txtCostHIV.ReadOnly = True
        'Panel2.Visible = False

        grdDisplay.Rows = 2

        FillGrid(0, 0, "Year")
        FillGrid(1, 0, "200...")

        grdDisplay.Cols = 10
        FillGrid(0, 1, "Type")
        FillGrid(0, 2, "Virus?")
        FillGrid(0, 3, "Infections")
        FillGrid(0, 4, "New Infections")
        FillGrid(0, 5, "People Treated")
        FillGrid(0, 6, "Death Count")
        FillGrid(0, 7, "Infection % Change")
        FillGrid(0, 8, "Death % Change")
        FillGrid(0, 9, "Fundraise")


        'BtnCovidCalc.Enabled = False
        'BtnHIVCalc.Enabled = False
    End Sub


    '#Display Subroutine
    Private Sub FillGrid(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        'A subroutine that displays the information into the grid
        grdDisplay.Row = r
        grdDisplay.Col = c
        grdDisplay.Text = t
    End Sub



    '#Intialises the program
    Private Sub btnInitialise_Click(sender As Object, e As EventArgs) Handles btnInitialise.Click
        'Capturing the sizes of each class and array
        yearHIV = CInt(txtNumHIV.Text)
        yearCvd = CInt(txtNumC19.Text)
        VaccineCost = CInt(txtCostC19.Text)
        'resizing and initialising the grid and array

        'Panel1.Enabled = False
        ' Panel2.Visible = True

    End Sub

    'Capturing information for HIV
    Private Sub btnHIVCapture_Click(sender As Object, e As EventArgs) Handles btnHIVCapture.Click
        CmbDisease.Items.Remove(1)
        objHIV = New HIVAIDS(yearHIV)

        objHIV.Name = InputBox("What is the type of the HIV? " & vbNewLine & "HIV-1 or HIV-2")
        objHIV.isVirus = CheckBool(CInt(InputBox("Is it a virus?" & vbNewLine & "" & vbNewLine & "1 - Yes" & vbNewLine & "2 - No")))

        For yr As Integer = 1 To yearHIV
            objHIV.Year(yr) = New Year()
            objHIV.Year(yr).Year = InputBox("What is the year?" & vbNewLine & "e.g 2000")

            If yr = 1 Then
                objHIV.Year(yr).Infections = CInt(InputBox("How many infections for the year " & objHIV.Year(yr).Year))
                objHIV.Year(yr).TreatmentReceived = CInt(InputBox("How many have received treament for the year " & objHIV.Year(yr).Year))
                objHIV.Year(yr).DeathCount = CInt(InputBox("How many have died in the current year due to the disease"))
            End If

            If yr > 1 Then
                objHIV.Year(yr).NewInfections = CInt(InputBox("How many new infections for the year " & objHIV.Year(yr).Year))
                objHIV.Year(yr).Infections = objHIV.Year(yr - 1).Infections + objHIV.Year(yr).NewInfections
                objHIV.Year(yr).TreatmentReceived = objHIV.Year(yr - 1).TreatmentReceived + CInt(InputBox("How many have received treament for the year " & objHIV.Year(yr).Year))
                objHIV.Year(yr).DeathCount = objHIV.Year(yr - 1).DeathCount + CInt(InputBox("How many have died in the current year due to the disease"))
            End If

        Next yr

        Disease(1) = objHIV

        CmbDisease.Items.Add("HIV")


    End Sub


    'Capturing information for Covid
    Private Sub btnCovidCapture_Click(sender As Object, e As EventArgs) Handles btnCovidCapture.Click
        CmbDisease.Items.Remove(2)
        objCovid = New Covid19(yearCvd, VaccineCost)
        objCovid.Name = InputBox("What is the variant of this Covid? " & vbNewLine & "SARS-COV-2 or  Omicron")
        objCovid.isVirus = CheckBool(CInt(InputBox("Is it a virus?" & vbNewLine & "" & vbNewLine & "1 - Yes" & vbNewLine & "2 - No")))

        For yr As Integer = 1 To yearCvd
            objCovid.Year(yr) = New Year()
            objCovid.Year(yr).Year = InputBox("What is the year?" & vbNewLine & "e.g 2000")

            If yr = 1 Then
                objCovid.Year(yr).Infections = CInt(InputBox("How many infections for the year " & objCovid.Year(yr).Year))
                objCovid.Year(yr).TreatmentReceived = CInt(InputBox("How many have received treament for the year " & objCovid.Year(yr).Year))
                objCovid.Year(yr).DeathCount = CInt(InputBox("How many have died in the current year due to the disease"))
            End If

            If yr > 1 Then
                objCovid.Year(yr).NewInfections = CInt(InputBox("How many new infections for the year " & objCovid.Year(yr).Year))
                objCovid.Year(yr).Infections += objCovid.Year(yr).NewInfections
                objCovid.Year(yr).TreatmentReceived = objCovid.Year(yr - 1).TreatmentReceived + CInt(InputBox("How many have received treament for the year " & objCovid.Year(yr).Year))
                objCovid.Year(yr).DeathCount = objCovid.Year(yr - 1).DeathCount + CInt(InputBox("How many have died in the current year due to the disease"))
            End If
        Next yr

        Disease(2) = objCovid

        CmbDisease.Items.Add("Covid")
    End Sub

    Private Sub btnReduced_Click(sender As Object, e As EventArgs) Handles btnReduced.Click
        If CmbDisease.SelectedIndex + 1 = 1 Then
            If TypeOf Disease(1) Is HIVAIDS Then
                Dim objHIVAIDS As HIVAIDS = DirectCast(Disease(1), HIVAIDS)
                txtinfectreduced.Text = CStr(objHIVAIDS.isInfectionReduced)
                txtdeathred.Text = CStr(objHIVAIDS.isDeathReduced)
            End If
        Else
            If TypeOf Disease(1) Is HIVAIDS Then
                Dim objCovid19 As HIVAIDS = DirectCast(Disease(1), HIVAIDS)
                txtinfectreduced.Text = CStr(objCovid19.isInfectionReduced)
                txtdeathred.Text = CStr(objCovid19.isDeathReduced)
            End If
        End If

    End Sub




    '#Display infomation for selected disease
    Private Sub CmbDisease_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbDisease.SelectedIndexChanged
        Dim position As Integer = CmbDisease.SelectedIndex + 1

        grdDisplay.Rows = Disease(position).ArrayLength + 1

        For yr As Integer = 1 To objHIV.ArrayLength
            FillGrid(yr, 0, objHIV.Year(yr).Year)

            FillGrid(yr, 1, objHIV.Name)
            FillGrid(yr, 2, CStr(Disease(position).isVirus))
            FillGrid(yr, 3, CStr(Disease(position).Year(yr).Infections))
            FillGrid(yr, 4, CStr(Disease(position).Year(yr).NewInfections))
            FillGrid(yr, 5, CStr(Disease(position).Year(yr).TreatmentReceived))
            FillGrid(yr, 6, CStr(Disease(position).Year(yr).DeathCount))
            FillGrid(yr, 7, CStr(Disease(position).InfectionTrend(yr)) + "%")
            FillGrid(yr, 8, CStr(Disease(position).DeathTrend(yr)) + "%")
            FillGrid(yr, 9, "R" + CStr(Disease(position).getFundraise(yr)))

        Next yr
    End Sub

    '#Function
    Private Function CheckBool(value As Integer) As Boolean
        If value = 1 Then Return True Else Return False
    End Function
End Class
