<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisease
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCovidCapture = New System.Windows.Forms.Button()
        Me.btnHIVCapture = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumC19 = New System.Windows.Forms.TextBox()
        Me.txtCostC19 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumHIV = New System.Windows.Forms.TextBox()
        Me.txtCostHIV = New System.Windows.Forms.TextBox()
        Me.btnInitialise = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtdeathred = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnReduced = New System.Windows.Forms.Button()
        Me.CmbDisease = New System.Windows.Forms.ComboBox()
        Me.lblselect = New System.Windows.Forms.Label()
        Me.grdDisplay = New UJGrid.UJGrid()
        Me.txtinfectreduced = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btnInitialise)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(50, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(844, 269)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.btnCovidCapture)
        Me.Panel3.Controls.Add(Me.btnHIVCapture)
        Me.Panel3.Location = New System.Drawing.Point(78, 135)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(597, 100)
        Me.Panel3.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Capture Information"
        '
        'btnCovidCapture
        '
        Me.btnCovidCapture.Location = New System.Drawing.Point(300, 16)
        Me.btnCovidCapture.Name = "btnCovidCapture"
        Me.btnCovidCapture.Size = New System.Drawing.Size(287, 70)
        Me.btnCovidCapture.TabIndex = 19
        Me.btnCovidCapture.Text = "Enter Covid-19 Information." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnCovidCapture.UseVisualStyleBackColor = True
        '
        'btnHIVCapture
        '
        Me.btnHIVCapture.Location = New System.Drawing.Point(7, 16)
        Me.btnHIVCapture.Name = "btnHIVCapture"
        Me.btnHIVCapture.Size = New System.Drawing.Size(287, 70)
        Me.btnHIVCapture.TabIndex = 3
        Me.btnHIVCapture.Text = "Enter HIV/AIDS Information."
        Me.btnHIVCapture.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtNumC19)
        Me.GroupBox2.Controls.Add(Me.txtCostC19)
        Me.GroupBox2.Location = New System.Drawing.Point(357, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 113)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Covid 19"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Cost of Treatment/Person:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Number of years monitored :"
        '
        'txtNumC19
        '
        Me.txtNumC19.Location = New System.Drawing.Point(177, 30)
        Me.txtNumC19.Name = "txtNumC19"
        Me.txtNumC19.Size = New System.Drawing.Size(100, 20)
        Me.txtNumC19.TabIndex = 11
        '
        'txtCostC19
        '
        Me.txtCostC19.Location = New System.Drawing.Point(186, 60)
        Me.txtCostC19.Name = "txtCostC19"
        Me.txtCostC19.Size = New System.Drawing.Size(100, 20)
        Me.txtCostC19.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNumHIV)
        Me.GroupBox1.Controls.Add(Me.txtCostHIV)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 113)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HIV / AIDS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Cost of Treatment/Person:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Number of years monitored :"
        '
        'txtNumHIV
        '
        Me.txtNumHIV.Location = New System.Drawing.Point(169, 30)
        Me.txtNumHIV.Name = "txtNumHIV"
        Me.txtNumHIV.Size = New System.Drawing.Size(100, 20)
        Me.txtNumHIV.TabIndex = 10
        '
        'txtCostHIV
        '
        Me.txtCostHIV.Location = New System.Drawing.Point(176, 56)
        Me.txtCostHIV.Name = "txtCostHIV"
        Me.txtCostHIV.Size = New System.Drawing.Size(100, 20)
        Me.txtCostHIV.TabIndex = 15
        '
        'btnInitialise
        '
        Me.btnInitialise.Location = New System.Drawing.Point(706, 16)
        Me.btnInitialise.Name = "btnInitialise"
        Me.btnInitialise.Size = New System.Drawing.Size(131, 113)
        Me.btnInitialise.TabIndex = 12
        Me.btnInitialise.Text = "Initialise"
        Me.btnInitialise.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Initialise"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtdeathred)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.btnReduced)
        Me.Panel2.Controls.Add(Me.CmbDisease)
        Me.Panel2.Controls.Add(Me.lblselect)
        Me.Panel2.Controls.Add(Me.grdDisplay)
        Me.Panel2.Controls.Add(Me.txtinfectreduced)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblDisplay)
        Me.Panel2.Location = New System.Drawing.Point(33, 300)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(919, 338)
        Me.Panel2.TabIndex = 1
        '
        'txtdeathred
        '
        Me.txtdeathred.Location = New System.Drawing.Point(132, 301)
        Me.txtdeathred.Name = "txtdeathred"
        Me.txtdeathred.ReadOnly = True
        Me.txtdeathred.Size = New System.Drawing.Size(100, 20)
        Me.txtdeathred.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Is Death Reduced?"
        '
        'btnReduced
        '
        Me.btnReduced.Location = New System.Drawing.Point(249, 281)
        Me.btnReduced.Name = "btnReduced"
        Me.btnReduced.Size = New System.Drawing.Size(156, 36)
        Me.btnReduced.TabIndex = 21
        Me.btnReduced.Text = "Is Infection and Death rate Reduced?"
        Me.btnReduced.UseVisualStyleBackColor = True
        '
        'CmbDisease
        '
        Me.CmbDisease.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbDisease.FormattingEnabled = True
        Me.CmbDisease.Location = New System.Drawing.Point(16, 27)
        Me.CmbDisease.Name = "CmbDisease"
        Me.CmbDisease.Size = New System.Drawing.Size(121, 21)
        Me.CmbDisease.TabIndex = 20
        '
        'lblselect
        '
        Me.lblselect.AutoSize = True
        Me.lblselect.Location = New System.Drawing.Point(19, 11)
        Me.lblselect.Name = "lblselect"
        Me.lblselect.Size = New System.Drawing.Size(81, 13)
        Me.lblselect.TabIndex = 19
        Me.lblselect.Text = "Select Disease:"
        '
        'grdDisplay
        '
        Me.grdDisplay.FixedCols = 1
        Me.grdDisplay.FixedRows = 1
        Me.grdDisplay.Location = New System.Drawing.Point(16, 54)
        Me.grdDisplay.Name = "grdDisplay"
        Me.grdDisplay.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdDisplay.Size = New System.Drawing.Size(888, 218)
        Me.grdDisplay.TabIndex = 18
        '
        'txtinfectreduced
        '
        Me.txtinfectreduced.Location = New System.Drawing.Point(132, 278)
        Me.txtinfectreduced.Name = "txtinfectreduced"
        Me.txtinfectreduced.ReadOnly = True
        Me.txtinfectreduced.Size = New System.Drawing.Size(100, 20)
        Me.txtinfectreduced.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Is Infection Reduced?"
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(13, 11)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(0, 13)
        Me.lblDisplay.TabIndex = 1
        '
        'frmDisease
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(964, 638)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDisease"
        Me.Text = "Millennium Development Goal 6 "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblDisplay As Label
    Friend WithEvents grdDisease As UJGrid.UJGrid
    Friend WithEvents btnInitialise As Button
    Friend WithEvents txtNumC19 As TextBox
    Friend WithEvents txtNumHIV As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnHIVCapture As Button
    Friend WithEvents txtCostC19 As TextBox
    Friend WithEvents txtCostHIV As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtinfectreduced As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grdDisplay As UJGrid.UJGrid
    Friend WithEvents CmbDisease As ComboBox
    Friend WithEvents lblselect As Label
    Friend WithEvents btnCovidCapture As Button
    Friend WithEvents btnReduced As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtdeathred As TextBox
    Friend WithEvents Label8 As Label
End Class
