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
        Me.txtCostC19 = New System.Windows.Forms.TextBox()
        Me.txtCostHIV = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnInitialise = New System.Windows.Forms.Button()
        Me.txtNumC19 = New System.Windows.Forms.TextBox()
        Me.txtNumHIV = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.grdDisease = New UJGrid.UJGrid()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtCostC19)
        Me.Panel1.Controls.Add(Me.txtCostHIV)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btnInitialise)
        Me.Panel1.Controls.Add(Me.txtNumC19)
        Me.Panel1.Controls.Add(Me.txtNumHIV)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(23, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 182)
        Me.Panel1.TabIndex = 0
        '
        'txtCostC19
        '
        Me.txtCostC19.Location = New System.Drawing.Point(685, 73)
        Me.txtCostC19.Name = "txtCostC19"
        Me.txtCostC19.Size = New System.Drawing.Size(100, 20)
        Me.txtCostC19.TabIndex = 16
        '
        'txtCostHIV
        '
        Me.txtCostHIV.Location = New System.Drawing.Point(685, 40)
        Me.txtCostHIV.Name = "txtCostHIV"
        Me.txtCostHIV.Size = New System.Drawing.Size(100, 20)
        Me.txtCostHIV.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(522, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Cost of Covid 19 Treatment :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(522, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Cost of HIV/AIDS Treatment :"
        '
        'btnInitialise
        '
        Me.btnInitialise.Location = New System.Drawing.Point(363, 128)
        Me.btnInitialise.Name = "btnInitialise"
        Me.btnInitialise.Size = New System.Drawing.Size(145, 38)
        Me.btnInitialise.TabIndex = 12
        Me.btnInitialise.Text = "Initialise"
        Me.btnInitialise.UseVisualStyleBackColor = True
        '
        'txtNumC19
        '
        Me.txtNumC19.Location = New System.Drawing.Point(237, 73)
        Me.txtNumC19.Name = "txtNumC19"
        Me.txtNumC19.Size = New System.Drawing.Size(100, 20)
        Me.txtNumC19.TabIndex = 11
        '
        'txtNumHIV
        '
        Me.txtNumHIV.Location = New System.Drawing.Point(237, 40)
        Me.txtNumHIV.Name = "txtNumHIV"
        Me.txtNumHIV.Size = New System.Drawing.Size(100, 20)
        Me.txtNumHIV.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Number of years monitoring Covid 19 :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Number of years monitoring HIV/AIDS :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Initialise"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.btnCapture)
        Me.Panel2.Controls.Add(Me.lblDisplay)
        Me.Panel2.Controls.Add(Me.grdDisease)
        Me.Panel2.Location = New System.Drawing.Point(23, 215)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(919, 306)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "More deadly disease :"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(757, 191)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(145, 38)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(757, 109)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 38)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Display Information"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnCapture
        '
        Me.btnCapture.Location = New System.Drawing.Point(757, 27)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(145, 38)
        Me.btnCapture.TabIndex = 3
        Me.btnCapture.Text = "Capture information"
        Me.btnCapture.UseVisualStyleBackColor = True
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
        'grdDisease
        '
        Me.grdDisease.FixedCols = 1
        Me.grdDisease.FixedRows = 1
        Me.grdDisease.Location = New System.Drawing.Point(16, 27)
        Me.grdDisease.Name = "grdDisease"
        Me.grdDisease.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdDisease.Size = New System.Drawing.Size(720, 202)
        Me.grdDisease.TabIndex = 0
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(132, 242)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 17
        '
        'frmDisease
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 526)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDisease"
        Me.Text = "Millennium Development Goal 6 "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnCapture As Button
    Friend WithEvents txtCostC19 As TextBox
    Friend WithEvents txtCostHIV As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
