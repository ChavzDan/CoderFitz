<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertiesList_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PropertiesList_Form))
        Panel1 = New Panel()
        DataGridViewPROPERTIES = New DataGridView()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(DataGridViewPROPERTIES, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(168), CByte(216), CByte(205))
        Panel1.Controls.Add(DataGridViewPROPERTIES)
        Panel1.Location = New Point(26, 80)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1462, 516)
        Panel1.TabIndex = 7
        ' 
        ' DataGridViewPROPERTIES
        ' 
        DataGridViewPROPERTIES.AllowUserToAddRows = False
        DataGridViewPROPERTIES.BackgroundColor = Color.White
        DataGridViewPROPERTIES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewPROPERTIES.Location = New Point(23, 20)
        DataGridViewPROPERTIES.Name = "DataGridViewPROPERTIES"
        DataGridViewPROPERTIES.RowHeadersWidth = 62
        DataGridViewPROPERTIES.Size = New Size(1414, 479)
        DataGridViewPROPERTIES.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Gill Sans Ultra Bold", 26F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(107, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(581, 74)
        Label1.TabIndex = 6
        Label1.Text = "PROPERTIES LIST"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(98, 64)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' PropertiesList_Form
        ' 
        AutoScaleDimensions = New SizeF(11F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(42), CByte(72), CByte(78))
        ClientSize = New Size(1502, 683)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        Name = "PropertiesList_Form"
        StartPosition = FormStartPosition.WindowsDefaultBounds
        Text = "PropertiesList_Form"
        Panel1.ResumeLayout(False)
        CType(DataGridViewPROPERTIES, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewPROPERTIES As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
