﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientsForm))
        Panel1 = New Panel()
        Button1 = New Button()
        Panel3 = New Panel()
        ButtonCLEAR_FIELDS = New Button()
        ButtonREMOVE = New Button()
        ButtonEDIT = New Button()
        ButtonADD = New Button()
        DataGridViewCLIENTS = New DataGridView()
        TextBoxADDRESS = New TextBox()
        Label7 = New Label()
        TextBoxMAIL = New TextBox()
        Label6 = New Label()
        TextBoxPHONE = New TextBox()
        Label5 = New Label()
        TextBoxlNAME = New TextBox()
        Label4 = New Label()
        TextBoxfNAME = New TextBox()
        Label3 = New Label()
        TextBoxID = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridViewCLIENTS, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PaleTurquoise
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(51, 25)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1230, 1021)
        Panel1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Castellar", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(1179, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(48, 44)
        Button1.TabIndex = 6
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.LemonChiffon
        Panel3.Controls.Add(ButtonCLEAR_FIELDS)
        Panel3.Controls.Add(ButtonREMOVE)
        Panel3.Controls.Add(ButtonEDIT)
        Panel3.Controls.Add(ButtonADD)
        Panel3.Controls.Add(DataGridViewCLIENTS)
        Panel3.Controls.Add(TextBoxADDRESS)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(TextBoxMAIL)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(TextBoxPHONE)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(TextBoxlNAME)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(TextBoxfNAME)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(TextBoxID)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(0, 132)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1214, 577)
        Panel3.TabIndex = 4
        ' 
        ' ButtonCLEAR_FIELDS
        ' 
        ButtonCLEAR_FIELDS.BackColor = Color.Gold
        ButtonCLEAR_FIELDS.ForeColor = Color.Black
        ButtonCLEAR_FIELDS.Location = New Point(21, 496)
        ButtonCLEAR_FIELDS.Name = "ButtonCLEAR_FIELDS"
        ButtonCLEAR_FIELDS.Size = New Size(438, 50)
        ButtonCLEAR_FIELDS.TabIndex = 16
        ButtonCLEAR_FIELDS.Text = "Clear Fields"
        ButtonCLEAR_FIELDS.UseVisualStyleBackColor = False
        ' 
        ' ButtonREMOVE
        ' 
        ButtonREMOVE.BackColor = Color.Red
        ButtonREMOVE.ForeColor = Color.White
        ButtonREMOVE.Location = New Point(308, 440)
        ButtonREMOVE.Name = "ButtonREMOVE"
        ButtonREMOVE.Size = New Size(151, 50)
        ButtonREMOVE.TabIndex = 15
        ButtonREMOVE.Text = "REMOVE"
        ButtonREMOVE.UseVisualStyleBackColor = False
        ' 
        ' ButtonEDIT
        ' 
        ButtonEDIT.BackColor = Color.DeepSkyBlue
        ButtonEDIT.ForeColor = Color.White
        ButtonEDIT.Location = New Point(163, 440)
        ButtonEDIT.Name = "ButtonEDIT"
        ButtonEDIT.Size = New Size(142, 50)
        ButtonEDIT.TabIndex = 14
        ButtonEDIT.Text = "EDIT"
        ButtonEDIT.UseVisualStyleBackColor = False
        ' 
        ' ButtonADD
        ' 
        ButtonADD.BackColor = Color.YellowGreen
        ButtonADD.ForeColor = Color.White
        ButtonADD.Location = New Point(21, 440)
        ButtonADD.Name = "ButtonADD"
        ButtonADD.Size = New Size(136, 50)
        ButtonADD.TabIndex = 13
        ButtonADD.Text = "ADD"
        ButtonADD.UseVisualStyleBackColor = False
        ' 
        ' DataGridViewCLIENTS
        ' 
        DataGridViewCLIENTS.AllowUserToAddRows = False
        DataGridViewCLIENTS.BackgroundColor = SystemColors.ControlLight
        DataGridViewCLIENTS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCLIENTS.Location = New Point(507, 23)
        DataGridViewCLIENTS.Name = "DataGridViewCLIENTS"
        DataGridViewCLIENTS.RowHeadersWidth = 62
        DataGridViewCLIENTS.Size = New Size(692, 393)
        DataGridViewCLIENTS.TabIndex = 12
        ' 
        ' TextBoxADDRESS
        ' 
        TextBoxADDRESS.Location = New Point(179, 289)
        TextBoxADDRESS.Multiline = True
        TextBoxADDRESS.Name = "TextBoxADDRESS"
        TextBoxADDRESS.Size = New Size(249, 127)
        TextBoxADDRESS.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(65, 292)
        Label7.Name = "Label7"
        Label7.Size = New Size(81, 25)
        Label7.TabIndex = 10
        Label7.Text = "Address:"
        ' 
        ' TextBoxMAIL
        ' 
        TextBoxMAIL.Location = New Point(179, 237)
        TextBoxMAIL.Name = "TextBoxMAIL"
        TextBoxMAIL.Size = New Size(249, 31)
        TextBoxMAIL.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(65, 240)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 25)
        Label6.TabIndex = 8
        Label6.Text = "Email:"
        ' 
        ' TextBoxPHONE
        ' 
        TextBoxPHONE.Location = New Point(179, 185)
        TextBoxPHONE.Name = "TextBoxPHONE"
        TextBoxPHONE.Size = New Size(249, 31)
        TextBoxPHONE.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(65, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(66, 25)
        Label5.TabIndex = 6
        Label5.Text = "Phone:"
        ' 
        ' TextBoxlNAME
        ' 
        TextBoxlNAME.Location = New Point(179, 129)
        TextBoxlNAME.Name = "TextBoxlNAME"
        TextBoxlNAME.Size = New Size(249, 31)
        TextBoxlNAME.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(65, 132)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 25)
        Label4.TabIndex = 4
        Label4.Text = "Last Name:"
        ' 
        ' TextBoxfNAME
        ' 
        TextBoxfNAME.Location = New Point(179, 78)
        TextBoxfNAME.Name = "TextBoxfNAME"
        TextBoxfNAME.Size = New Size(249, 31)
        TextBoxfNAME.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(65, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 25)
        Label3.TabIndex = 2
        Label3.Text = "First Name:"
        ' 
        ' TextBoxID
        ' 
        TextBoxID.Location = New Point(105, 23)
        TextBoxID.Name = "TextBoxID"
        TextBoxID.Size = New Size(249, 31)
        TextBoxID.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(65, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 25)
        Label2.TabIndex = 0
        Label2.Text = "ID:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(12, 106)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1585, 10)
        Panel2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Gill Sans Ultra Bold", 26.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(121, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(293, 76)
        Label1.TabIndex = 1
        Label1.Text = "CLIENTS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(115, 97)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ClientsForm
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleTurquoise
        ClientSize = New Size(1293, 979)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "ClientsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridViewCLIENTS, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ButtonCLEAR_FIELDS As Button
    Friend WithEvents ButtonREMOVE As Button
    Friend WithEvents ButtonEDIT As Button
    Friend WithEvents ButtonADD As Button
    Friend WithEvents DataGridViewCLIENTS As DataGridView
    Friend WithEvents TextBoxADDRESS As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxMAIL As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxPHONE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxlNAME As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxfNAME As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Label2 As Label
End Class