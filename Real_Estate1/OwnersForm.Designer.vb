﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OwnersForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OwnersForm))
        Panel1 = New Panel()
        Panel3 = New Panel()
        ButtonSHOW_OWNER_PROPERTIES = New Button()
        ButtonCLEAR_FIELDS = New Button()
        ButtonREMOVE = New Button()
        ButtonEDIT = New Button()
        ButtonADD = New Button()
        DataGridViewOWNERS = New DataGridView()
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
        ButtonClose = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridViewOWNERS, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(18, -5)
        Panel1.Margin = New Padding(2, 2, 2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(932, 495)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.FromArgb(CByte(168), CByte(216), CByte(205))
        Panel3.Controls.Add(ButtonSHOW_OWNER_PROPERTIES)
        Panel3.Controls.Add(ButtonCLEAR_FIELDS)
        Panel3.Controls.Add(ButtonREMOVE)
        Panel3.Controls.Add(ButtonEDIT)
        Panel3.Controls.Add(ButtonADD)
        Panel3.Controls.Add(DataGridViewOWNERS)
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
        Panel3.Location = New Point(2, 79)
        Panel3.Margin = New Padding(2, 2, 2, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(923, 416)
        Panel3.TabIndex = 3
        ' 
        ' ButtonSHOW_OWNER_PROPERTIES
        ' 
        ButtonSHOW_OWNER_PROPERTIES.BackColor = Color.FromArgb(CByte(55), CByte(115), CByte(117))
        ButtonSHOW_OWNER_PROPERTIES.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        ButtonSHOW_OWNER_PROPERTIES.ForeColor = Color.White
        ButtonSHOW_OWNER_PROPERTIES.Location = New Point(393, 299)
        ButtonSHOW_OWNER_PROPERTIES.Margin = New Padding(2, 2, 2, 2)
        ButtonSHOW_OWNER_PROPERTIES.Name = "ButtonSHOW_OWNER_PROPERTIES"
        ButtonSHOW_OWNER_PROPERTIES.Size = New Size(457, 43)
        ButtonSHOW_OWNER_PROPERTIES.TabIndex = 17
        ButtonSHOW_OWNER_PROPERTIES.Text = "View Owner Properties"
        ButtonSHOW_OWNER_PROPERTIES.UseVisualStyleBackColor = False
        ' 
        ' ButtonCLEAR_FIELDS
        ' 
        ButtonCLEAR_FIELDS.BackColor = Color.FromArgb(CByte(55), CByte(115), CByte(117))
        ButtonCLEAR_FIELDS.Cursor = Cursors.Hand
        ButtonCLEAR_FIELDS.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        ButtonCLEAR_FIELDS.ForeColor = Color.White
        ButtonCLEAR_FIELDS.Location = New Point(20, 361)
        ButtonCLEAR_FIELDS.Margin = New Padding(2, 2, 2, 2)
        ButtonCLEAR_FIELDS.Name = "ButtonCLEAR_FIELDS"
        ButtonCLEAR_FIELDS.Size = New Size(307, 37)
        ButtonCLEAR_FIELDS.TabIndex = 16
        ButtonCLEAR_FIELDS.Text = "Clear Fields"
        ButtonCLEAR_FIELDS.UseVisualStyleBackColor = False
        ' 
        ' ButtonREMOVE
        ' 
        ButtonREMOVE.BackColor = Color.DarkRed
        ButtonREMOVE.Cursor = Cursors.Hand
        ButtonREMOVE.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        ButtonREMOVE.ForeColor = Color.White
        ButtonREMOVE.Location = New Point(220, 314)
        ButtonREMOVE.Margin = New Padding(2, 2, 2, 2)
        ButtonREMOVE.Name = "ButtonREMOVE"
        ButtonREMOVE.Size = New Size(106, 43)
        ButtonREMOVE.TabIndex = 15
        ButtonREMOVE.Text = "DELETE"
        ButtonREMOVE.UseVisualStyleBackColor = False
        ' 
        ' ButtonEDIT
        ' 
        ButtonEDIT.BackColor = Color.FromArgb(CByte(55), CByte(115), CByte(117))
        ButtonEDIT.Cursor = Cursors.Hand
        ButtonEDIT.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        ButtonEDIT.ForeColor = Color.White
        ButtonEDIT.Location = New Point(119, 314)
        ButtonEDIT.Margin = New Padding(2, 2, 2, 2)
        ButtonEDIT.Name = "ButtonEDIT"
        ButtonEDIT.Size = New Size(99, 43)
        ButtonEDIT.TabIndex = 14
        ButtonEDIT.Text = "EDIT"
        ButtonEDIT.UseVisualStyleBackColor = False
        ' 
        ' ButtonADD
        ' 
        ButtonADD.BackColor = Color.FromArgb(CByte(55), CByte(115), CByte(117))
        ButtonADD.Cursor = Cursors.Hand
        ButtonADD.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        ButtonADD.ForeColor = Color.White
        ButtonADD.Location = New Point(20, 314)
        ButtonADD.Margin = New Padding(2, 2, 2, 2)
        ButtonADD.Name = "ButtonADD"
        ButtonADD.Size = New Size(95, 43)
        ButtonADD.TabIndex = 13
        ButtonADD.Text = "ADD"
        ButtonADD.UseVisualStyleBackColor = False
        ' 
        ' DataGridViewOWNERS
        ' 
        DataGridViewOWNERS.AllowUserToAddRows = False
        DataGridViewOWNERS.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewOWNERS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewOWNERS.BackgroundColor = Color.WhiteSmoke
        DataGridViewOWNERS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewOWNERS.Location = New Point(326, 14)
        DataGridViewOWNERS.Margin = New Padding(2, 2, 2, 2)
        DataGridViewOWNERS.Name = "DataGridViewOWNERS"
        DataGridViewOWNERS.RowHeadersWidth = 62
        DataGridViewOWNERS.Size = New Size(595, 281)
        DataGridViewOWNERS.TabIndex = 12
        ' 
        ' TextBoxADDRESS
        ' 
        TextBoxADDRESS.Location = New Point(125, 220)
        TextBoxADDRESS.Margin = New Padding(2, 2, 2, 2)
        TextBoxADDRESS.Multiline = True
        TextBoxADDRESS.Name = "TextBoxADDRESS"
        TextBoxADDRESS.Size = New Size(176, 77)
        TextBoxADDRESS.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(36, 219)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(86, 22)
        Label7.TabIndex = 10
        Label7.Text = "Address:"
        ' 
        ' TextBoxMAIL
        ' 
        TextBoxMAIL.Location = New Point(125, 177)
        TextBoxMAIL.Margin = New Padding(2, 2, 2, 2)
        TextBoxMAIL.Multiline = True
        TextBoxMAIL.Name = "TextBoxMAIL"
        TextBoxMAIL.Size = New Size(176, 35)
        TextBoxMAIL.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(51, 185)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 22)
        Label6.TabIndex = 8
        Label6.Text = "Email:"
        ' 
        ' TextBoxPHONE
        ' 
        TextBoxPHONE.Location = New Point(125, 133)
        TextBoxPHONE.Margin = New Padding(2, 2, 2, 2)
        TextBoxPHONE.Multiline = True
        TextBoxPHONE.Name = "TextBoxPHONE"
        TextBoxPHONE.Size = New Size(176, 35)
        TextBoxPHONE.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(48, 143)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 22)
        Label5.TabIndex = 6
        Label5.Text = "Phone:"
        ' 
        ' TextBoxlNAME
        ' 
        TextBoxlNAME.Location = New Point(125, 88)
        TextBoxlNAME.Margin = New Padding(2, 2, 2, 2)
        TextBoxlNAME.Multiline = True
        TextBoxlNAME.Name = "TextBoxlNAME"
        TextBoxlNAME.Size = New Size(176, 35)
        TextBoxlNAME.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(14, 98)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 22)
        Label4.TabIndex = 4
        Label4.Text = "Last Name:"
        ' 
        ' TextBoxfNAME
        ' 
        TextBoxfNAME.Location = New Point(125, 47)
        TextBoxfNAME.Margin = New Padding(2, 2, 2, 2)
        TextBoxfNAME.Multiline = True
        TextBoxfNAME.Name = "TextBoxfNAME"
        TextBoxfNAME.Size = New Size(176, 34)
        TextBoxfNAME.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(14, 55)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 22)
        Label3.TabIndex = 2
        Label3.Text = "First Name:"
        ' 
        ' TextBoxID
        ' 
        TextBoxID.Location = New Point(125, 14)
        TextBoxID.Margin = New Padding(2, 2, 2, 2)
        TextBoxID.Multiline = True
        TextBoxID.Name = "TextBoxID"
        TextBoxID.Size = New Size(176, 26)
        TextBoxID.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 13F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(80, 20)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(33, 22)
        Label2.TabIndex = 0
        Label2.Text = "ID:"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(9, 64)
        Panel2.Margin = New Padding(2, 2, 2, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1134, 6)
        Panel2.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Microsoft Sans Serif", 26F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(62, 16)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 41)
        Label1.TabIndex = 1
        Label1.Text = "OWNERS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(9, 16)
        PictureBox1.Margin = New Padding(2, 2, 2, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(62, 46)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ButtonClose
        ' 
        ButtonClose.BackColor = Color.White
        ButtonClose.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ButtonClose.Location = New Point(1330, 12)
        ButtonClose.Margin = New Padding(2, 2, 2, 2)
        ButtonClose.Name = "ButtonClose"
        ButtonClose.Size = New Size(38, 26)
        ButtonClose.TabIndex = 5
        ButtonClose.Text = "X"
        ButtonClose.UseVisualStyleBackColor = False
        ' 
        ' OwnersForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        ClientSize = New Size(957, 652)
        Controls.Add(Panel1)
        Controls.Add(ButtonClose)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(2, 2, 2, 2)
        Name = "OwnersForm"
        Padding = New Padding(630, 540, 630, 0)
        RightToLeft = RightToLeft.No
        StartPosition = FormStartPosition.WindowsDefaultBounds
        Text = "OwnersForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridViewOWNERS, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ButtonClose As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBoxfNAME As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxADDRESS As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxMAIL As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxPHONE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxlNAME As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridViewOWNERS As DataGridView
    Friend WithEvents ButtonADD As Button
    Friend WithEvents ButtonCLEAR_FIELDS As Button
    Friend WithEvents ButtonREMOVE As Button
    Friend WithEvents ButtonEDIT As Button
    Friend WithEvents ButtonSHOW_OWNER_PROPERTIES As Button
End Class
