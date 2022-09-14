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
        Me.btnCovidCapture = New System.Windows.Forms.Button()
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
        Me.btnHIVCapture = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CmbDisease = New System.Windows.Forms.ComboBox()
        Me.lblselect = New System.Windows.Forms.Label()
        Me.grdDisplay = New UJGrid.UJGrid()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnCovidCapture)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btnInitialise)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnHIVCapture)
        Me.Panel1.Location = New System.Drawing.Point(157, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(639, 282)
        Me.Panel1.TabIndex = 0
        '
        'btnCovidCapture
        '
        Me.btnCovidCapture.Location = New System.Drawing.Point(376, 160)
        Me.btnCovidCapture.Name = "btnCovidCapture"
        Me.btnCovidCapture.Size = New System.Drawing.Size(236, 70)
        Me.btnCovidCapture.TabIndex = 19
        Me.btnCovidCapture.Text = "Capture Covid 19 Information"
        Me.btnCovidCapture.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtNumC19)
        Me.GroupBox2.Controls.Add(Me.txtCostC19)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 130)
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
        Me.btnInitialise.Location = New System.Drawing.Point(8, 248)
        Me.btnInitialise.Name = "btnInitialise"
        Me.btnInitialise.Size = New System.Drawing.Size(343, 27)
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
        'btnHIVCapture
        '
        Me.btnHIVCapture.Location = New System.Drawing.Point(376, 31)
        Me.btnHIVCapture.Name = "btnHIVCapture"
        Me.btnHIVCapture.Size = New System.Drawing.Size(236, 70)
        Me.btnHIVCapture.TabIndex = 3
        Me.btnHIVCapture.Text = "Capture HIV/AIDS Information"
        Me.btnHIVCapture.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.CmbDisease)
        Me.Panel2.Controls.Add(Me.lblselect)
        Me.Panel2.Controls.Add(Me.grdDisplay)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.lblDisplay)
        Me.Panel2.Location = New System.Drawing.Point(33, 300)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(919, 326)
        Me.Panel2.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(757, 211)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 61)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Is Infection Reduced?"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CmbDisease
        '
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
        Me.grdDisplay.Size = New System.Drawing.Size(735, 218)
        Me.grdDisplay.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(132, 278)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 17
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
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(757, 129)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(145, 76)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Calculations"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(757, 63)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 60)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Display Information"
        Me.Button3.UseVisualStyleBackColor = True
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
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnHIVCapture As Button
    Friend WithEvents txtCostC19 As TextBox
    Friend WithEvents txtCostHIV As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grdDisplay As UJGrid.UJGrid
    Friend WithEvents CmbDisease As ComboBox
    Friend WithEvents lblselect As Label
    Friend WithEvents btnCovidCapture As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
End Class
