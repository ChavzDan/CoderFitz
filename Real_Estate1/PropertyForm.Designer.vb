<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertyForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PropertyForm))
        Panel1 = New Panel()
        Panel3 = New Panel()
        ButtonSEARCHOWNER = New Button()
        ButtonSEARCH = New Button()
        ComboBoxTYPE = New ComboBox()
        Button_ShowPropertyImage = New Button()
        Button_ShowAllProperty = New Button()
        GroupBox1 = New GroupBox()
        CheckBoxELEVATOR = New CheckBox()
        CheckBoxPOOL = New CheckBox()
        CheckBoxFIREPLACE = New CheckBox()
        CheckBoxGARAGE = New CheckBox()
        CheckBoxBACKYARD = New CheckBox()
        CheckBoxBALCONY = New CheckBox()
        NumericUpDownAGE = New NumericUpDown()
        NumericUpDownBATHS = New NumericUpDown()
        NumericUpDownBEDS = New NumericUpDown()
        TextBoxCOMMENTS = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        ButtonCLEARFIELDS = New Button()
        ButtonREMOVE = New Button()
        ButtonEDIT = New Button()
        ButtonADD = New Button()
        TextBoxADDRESS = New TextBox()
        Label7 = New Label()
        TextBoxOWNER_ID = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        TextBoxPRICE = New TextBox()
        Label4 = New Label()
        TextBoxSIZE = New TextBox()
        Label3 = New Label()
        TextBoxID = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(NumericUpDownAGE, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDownBATHS, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDownBEDS, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(12, -13)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1338, 860)
        Panel1.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(168), CByte(216), CByte(205))
        Panel3.Controls.Add(ButtonSEARCHOWNER)
        Panel3.Controls.Add(ButtonSEARCH)
        Panel3.Controls.Add(ComboBoxTYPE)
        Panel3.Controls.Add(Button_ShowPropertyImage)
        Panel3.Controls.Add(Button_ShowAllProperty)
        Panel3.Controls.Add(GroupBox1)
        Panel3.Controls.Add(NumericUpDownAGE)
        Panel3.Controls.Add(NumericUpDownBATHS)
        Panel3.Controls.Add(NumericUpDownBEDS)
        Panel3.Controls.Add(TextBoxCOMMENTS)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(ButtonCLEARFIELDS)
        Panel3.Controls.Add(ButtonREMOVE)
        Panel3.Controls.Add(ButtonEDIT)
        Panel3.Controls.Add(ButtonADD)
        Panel3.Controls.Add(TextBoxADDRESS)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(TextBoxOWNER_ID)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(TextBoxPRICE)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(TextBoxSIZE)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(TextBoxID)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(12, 122)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1326, 710)
        Panel3.TabIndex = 3
        ' 
        ' ButtonSEARCHOWNER
        ' 
        ButtonSEARCHOWNER.BackColor = Color.FromArgb(CByte(55), CByte(115), CByte(117))
        ButtonSEARCHOWNER.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        ButtonSEARCHOWNER.ForeColor = Color.White
        ButtonSEARCHOWNER.Location = New Point(1085, 68)
        ButtonSEARCHOWNER.Name = "ButtonSEARCHOWNER"
        ButtonSEARCHOWNER.Size = New Size(163, 57)
        ButtonSEARCHOWNER.TabIndex = 46
        ButtonSEARCHOWNER.Text = "Select Owner"
        ButtonSEARCHOWNER.UseVisualStyleBackColor = False
        ' 
        ' ButtonSEARCH
        ' 
        ButtonSEARCH.BackColor = Color.FromArgb(CByte(55), CByte(115), CByte(117))
        ButtonSEARCH.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        ButtonSEARCH.ForeColor = Color.White
        ButtonSEARCH.Location = New Point(423, 24)
        ButtonSEARCH.Name = "ButtonSEARCH"
        ButtonSEARCH.Size = New Size(136, 54)
        ButtonSEARCH.TabIndex = 45
        ButtonSEARCH.Text = "Search"
        ButtonSEARCH.UseVisualStyleBackColor = False
        ' 
        ' ComboBoxTYPE
        ' 
        ComboBoxTYPE.FormattingEnabled = True
        ComboBoxTYPE.Location = New Point(804, 24)
        ComboBoxTYPE.Name = "ComboBoxTYPE"
        ComboBoxTYPE.Size = New Size(273, 33)
        ComboBoxTYPE.TabIndex = 44
        ' 
        ' Button_ShowPropertyImage
        ' 
        Button_ShowPropertyImage.BackColor = Color.FromArgb(CByte(55), CByte(115), CByte(117))
        Button_ShowPropertyImage.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        Button_ShowPropertyImage.ForeColor = Color.White
        Button_ShowPropertyImage.Location = New Point(726, 614)
        Button_ShowPropertyImage.Name = "Button_ShowPropertyImage"
        Button_ShowPropertyImage.Size = New Size(383, 69)
        Button_ShowPropertyImage.TabIndex = 43
        Button_ShowPropertyImage.Text = "Show This Property Images"
        Button_ShowPropertyImage.UseVisualStyleBackColor = False
        ' 
        ' Button_ShowAllProperty
        ' 
        Button_ShowAllProperty.BackColor = Color.FromArgb(CByte(55), CByte(115), CByte(117))
        Button_ShowAllProperty.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        Button_ShowAllProperty.ForeColor = Color.White
        Button_ShowAllProperty.Location = New Point(221, 614)
        Button_ShowAllProperty.Name = "Button_ShowAllProperty"
        Button_ShowAllProperty.Size = New Size(490, 69)
        Button_ShowAllProperty.TabIndex = 42
        Button_ShowAllProperty.Text = "Show All Properties"
        Button_ShowAllProperty.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(CheckBoxELEVATOR)
        GroupBox1.Controls.Add(CheckBoxPOOL)
        GroupBox1.Controls.Add(CheckBoxFIREPLACE)
        GroupBox1.Controls.Add(CheckBoxGARAGE)
        GroupBox1.Controls.Add(CheckBoxBACKYARD)
        GroupBox1.Controls.Add(CheckBoxBALCONY)
        GroupBox1.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        GroupBox1.Location = New Point(139, 400)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1041, 108)
        GroupBox1.TabIndex = 41
        GroupBox1.TabStop = False
        GroupBox1.Text = "Features:"
        ' 
        ' CheckBoxELEVATOR
        ' 
        CheckBoxELEVATOR.AutoSize = True
        CheckBoxELEVATOR.FlatAppearance.BorderSize = 0
        CheckBoxELEVATOR.ForeColor = Color.RoyalBlue
        CheckBoxELEVATOR.Location = New Point(821, 49)
        CheckBoxELEVATOR.Name = "CheckBoxELEVATOR"
        CheckBoxELEVATOR.Size = New Size(123, 30)
        CheckBoxELEVATOR.TabIndex = 5
        CheckBoxELEVATOR.Text = "Elevator"
        CheckBoxELEVATOR.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxPOOL
        ' 
        CheckBoxPOOL.AutoSize = True
        CheckBoxPOOL.FlatAppearance.BorderSize = 0
        CheckBoxPOOL.ForeColor = Color.RoyalBlue
        CheckBoxPOOL.Location = New Point(673, 49)
        CheckBoxPOOL.Name = "CheckBoxPOOL"
        CheckBoxPOOL.Size = New Size(83, 30)
        CheckBoxPOOL.TabIndex = 4
        CheckBoxPOOL.Text = "Pool"
        CheckBoxPOOL.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxFIREPLACE
        ' 
        CheckBoxFIREPLACE.AutoSize = True
        CheckBoxFIREPLACE.FlatAppearance.BorderSize = 0
        CheckBoxFIREPLACE.ForeColor = Color.RoyalBlue
        CheckBoxFIREPLACE.Location = New Point(511, 49)
        CheckBoxFIREPLACE.Name = "CheckBoxFIREPLACE"
        CheckBoxFIREPLACE.Size = New Size(138, 30)
        CheckBoxFIREPLACE.TabIndex = 3
        CheckBoxFIREPLACE.Text = "Fireplace"
        CheckBoxFIREPLACE.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxGARAGE
        ' 
        CheckBoxGARAGE.AutoSize = True
        CheckBoxGARAGE.FlatAppearance.BorderSize = 0
        CheckBoxGARAGE.ForeColor = Color.RoyalBlue
        CheckBoxGARAGE.Location = New Point(352, 49)
        CheckBoxGARAGE.Name = "CheckBoxGARAGE"
        CheckBoxGARAGE.Size = New Size(122, 30)
        CheckBoxGARAGE.TabIndex = 2
        CheckBoxGARAGE.Text = "Garage"
        CheckBoxGARAGE.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxBACKYARD
        ' 
        CheckBoxBACKYARD.AutoSize = True
        CheckBoxBACKYARD.FlatAppearance.BorderSize = 0
        CheckBoxBACKYARD.ForeColor = Color.RoyalBlue
        CheckBoxBACKYARD.Location = New Point(191, 49)
        CheckBoxBACKYARD.Name = "CheckBoxBACKYARD"
        CheckBoxBACKYARD.Size = New Size(143, 30)
        CheckBoxBACKYARD.TabIndex = 1
        CheckBoxBACKYARD.Text = "Backyard"
        CheckBoxBACKYARD.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxBALCONY
        ' 
        CheckBoxBALCONY.AutoSize = True
        CheckBoxBALCONY.FlatAppearance.BorderSize = 0
        CheckBoxBALCONY.ForeColor = Color.RoyalBlue
        CheckBoxBALCONY.Location = New Point(43, 49)
        CheckBoxBALCONY.Name = "CheckBoxBALCONY"
        CheckBoxBALCONY.Size = New Size(125, 30)
        CheckBoxBALCONY.TabIndex = 0
        CheckBoxBALCONY.Text = "Balcony"
        CheckBoxBALCONY.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDownAGE
        ' 
        NumericUpDownAGE.Location = New Point(1154, 156)
        NumericUpDownAGE.Name = "NumericUpDownAGE"
        NumericUpDownAGE.Size = New Size(75, 31)
        NumericUpDownAGE.TabIndex = 40
        ' 
        ' NumericUpDownBATHS
        ' 
        NumericUpDownBATHS.Location = New Point(976, 154)
        NumericUpDownBATHS.Name = "NumericUpDownBATHS"
        NumericUpDownBATHS.Size = New Size(75, 31)
        NumericUpDownBATHS.TabIndex = 39
        ' 
        ' NumericUpDownBEDS
        ' 
        NumericUpDownBEDS.Location = New Point(804, 154)
        NumericUpDownBEDS.Name = "NumericUpDownBEDS"
        NumericUpDownBEDS.Size = New Size(75, 31)
        NumericUpDownBEDS.TabIndex = 38
        ' 
        ' TextBoxCOMMENTS
        ' 
        TextBoxCOMMENTS.Location = New Point(804, 219)
        TextBoxCOMMENTS.Multiline = True
        TextBoxCOMMENTS.Name = "TextBoxCOMMENTS"
        TextBoxCOMMENTS.Size = New Size(372, 162)
        TextBoxCOMMENTS.TabIndex = 37
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        Label11.Location = New Point(653, 224)
        Label11.Name = "Label11"
        Label11.Size = New Size(135, 26)
        Label11.TabIndex = 36
        Label11.Text = "Comments:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        Label10.Location = New Point(1085, 159)
        Label10.Name = "Label10"
        Label10.Size = New Size(63, 26)
        Label10.TabIndex = 35
        Label10.Text = "Age:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        Label9.Location = New Point(894, 156)
        Label9.Name = "Label9"
        Label9.Size = New Size(76, 26)
        Label9.TabIndex = 34
        Label9.Text = "Baths:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        Label8.Location = New Point(718, 157)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 26)
        Label8.TabIndex = 33
        Label8.Text = "Beds:"
        ' 
        ' ButtonCLEARFIELDS
        ' 
        ButtonCLEARFIELDS.BackColor = Color.FromArgb(CByte(55), CByte(115), CByte(117))
        ButtonCLEARFIELDS.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        ButtonCLEARFIELDS.ForeColor = Color.White
        ButtonCLEARFIELDS.Location = New Point(726, 539)
        ButtonCLEARFIELDS.Name = "ButtonCLEARFIELDS"
        ButtonCLEARFIELDS.Size = New Size(383, 69)
        ButtonCLEARFIELDS.TabIndex = 32
        ButtonCLEARFIELDS.Text = "Clear Fields"
        ButtonCLEARFIELDS.UseVisualStyleBackColor = False
        ' 
        ' ButtonREMOVE
        ' 
        ButtonREMOVE.BackColor = Color.DarkRed
        ButtonREMOVE.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        ButtonREMOVE.ForeColor = Color.White
        ButtonREMOVE.Location = New Point(545, 539)
        ButtonREMOVE.Name = "ButtonREMOVE"
        ButtonREMOVE.Size = New Size(166, 69)
        ButtonREMOVE.TabIndex = 31
        ButtonREMOVE.Text = "REMOVE"
        ButtonREMOVE.UseVisualStyleBackColor = False
        ' 
        ' ButtonEDIT
        ' 
        ButtonEDIT.BackColor = Color.FromArgb(CByte(55), CByte(115), CByte(117))
        ButtonEDIT.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        ButtonEDIT.ForeColor = Color.White
        ButtonEDIT.Location = New Point(378, 539)
        ButtonEDIT.Name = "ButtonEDIT"
        ButtonEDIT.Size = New Size(163, 69)
        ButtonEDIT.TabIndex = 30
        ButtonEDIT.Text = "EDIT"
        ButtonEDIT.UseVisualStyleBackColor = False
        ' 
        ' ButtonADD
        ' 
        ButtonADD.BackColor = Color.FromArgb(CByte(55), CByte(115), CByte(117))
        ButtonADD.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        ButtonADD.ForeColor = Color.White
        ButtonADD.Location = New Point(221, 539)
        ButtonADD.Name = "ButtonADD"
        ButtonADD.Size = New Size(151, 69)
        ButtonADD.TabIndex = 29
        ButtonADD.Text = "ADD"
        ButtonADD.UseVisualStyleBackColor = False
        ' 
        ' TextBoxADDRESS
        ' 
        TextBoxADDRESS.Location = New Point(210, 222)
        TextBoxADDRESS.Multiline = True
        TextBoxADDRESS.Name = "TextBoxADDRESS"
        TextBoxADDRESS.Size = New Size(349, 159)
        TextBoxADDRESS.TabIndex = 28
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        Label7.Location = New Point(84, 224)
        Label7.Name = "Label7"
        Label7.Size = New Size(105, 26)
        Label7.TabIndex = 27
        Label7.Text = "Address:"
        ' 
        ' TextBoxOWNER_ID
        ' 
        TextBoxOWNER_ID.Location = New Point(804, 68)
        TextBoxOWNER_ID.Multiline = True
        TextBoxOWNER_ID.Name = "TextBoxOWNER_ID"
        TextBoxOWNER_ID.Size = New Size(273, 55)
        TextBoxOWNER_ID.TabIndex = 26
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        Label6.Location = New Point(694, 84)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 26)
        Label6.TabIndex = 25
        Label6.Text = "Owner:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        Label5.Location = New Point(713, 26)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 26)
        Label5.TabIndex = 23
        Label5.Text = "Type:"
        ' 
        ' TextBoxPRICE
        ' 
        TextBoxPRICE.Location = New Point(206, 154)
        TextBoxPRICE.Multiline = True
        TextBoxPRICE.Name = "TextBoxPRICE"
        TextBoxPRICE.Size = New Size(353, 48)
        TextBoxPRICE.TabIndex = 22
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        Label4.Location = New Point(119, 165)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 26)
        Label4.TabIndex = 21
        Label4.Text = "Price:"
        ' 
        ' TextBoxSIZE
        ' 
        TextBoxSIZE.Location = New Point(206, 84)
        TextBoxSIZE.Multiline = True
        TextBoxSIZE.Name = "TextBoxSIZE"
        TextBoxSIZE.Size = New Size(353, 52)
        TextBoxSIZE.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        Label3.Location = New Point(131, 96)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 26)
        Label3.TabIndex = 19
        Label3.Text = "Size:"
        ' 
        ' TextBoxID
        ' 
        TextBoxID.Location = New Point(206, 24)
        TextBoxID.Multiline = True
        TextBoxID.Name = "TextBoxID"
        TextBoxID.Size = New Size(211, 49)
        TextBoxID.TabIndex = 18
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        Label2.Location = New Point(150, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 26)
        Label2.TabIndex = 17
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
        Label1.Font = New Font("Gill Sans Ultra Bold", 26F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(98, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(431, 76)
        Label1.TabIndex = 1
        Label1.Text = "PROPERTIES"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(89, 76)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PropertyForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        ClientSize = New Size(1362, 1035)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "PropertyForm"
        StartPosition = FormStartPosition.WindowsDefaultBounds
        Text = "PropertyForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(NumericUpDownAGE, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDownBATHS, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDownBEDS, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonCLEARFIELDS As Button
    Friend WithEvents ButtonREMOVE As Button
    Friend WithEvents ButtonEDIT As Button
    Friend WithEvents ButtonADD As Button
    Friend WithEvents TextBoxADDRESS As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxOWNER_ID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxPRICE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxSIZE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxCOMMENTS As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents NumericUpDownAGE As NumericUpDown
    Friend WithEvents NumericUpDownBATHS As NumericUpDown
    Friend WithEvents NumericUpDownBEDS As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBoxELEVATOR As CheckBox
    Friend WithEvents CheckBoxPOOL As CheckBox
    Friend WithEvents CheckBoxFIREPLACE As CheckBox
    Friend WithEvents CheckBoxGARAGE As CheckBox
    Friend WithEvents CheckBoxBACKYARD As CheckBox
    Friend WithEvents CheckBoxBALCONY As CheckBox
    Friend WithEvents Button_ShowPropertyImage As Button
    Friend WithEvents Button_ShowAllProperty As Button
    Friend WithEvents ComboBoxTYPE As ComboBox
    Friend WithEvents ButtonSEARCH As Button
    Friend WithEvents ButtonSEARCHOWNER As Button
End Class
