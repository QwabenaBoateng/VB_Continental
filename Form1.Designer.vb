<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        picCanada = New PictureBox()
        picUsa = New PictureBox()
        picJamaica = New PictureBox()
        picBahamas = New PictureBox()
        picCosta = New PictureBox()
        GroupBox2 = New GroupBox()
        picPeru = New PictureBox()
        picBrazil = New PictureBox()
        picUruguay = New PictureBox()
        picChile = New PictureBox()
        picArgen = New PictureBox()
        btnExit = New Button()
        lblCont = New Label()
        GroupBox1.SuspendLayout()
        CType(picCanada, ComponentModel.ISupportInitialize).BeginInit()
        CType(picUsa, ComponentModel.ISupportInitialize).BeginInit()
        CType(picJamaica, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBahamas, ComponentModel.ISupportInitialize).BeginInit()
        CType(picCosta, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(picPeru, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBrazil, ComponentModel.ISupportInitialize).BeginInit()
        CType(picUruguay, ComponentModel.ISupportInitialize).BeginInit()
        CType(picChile, ComponentModel.ISupportInitialize).BeginInit()
        CType(picArgen, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.AliceBlue
        GroupBox1.Controls.Add(picCanada)
        GroupBox1.Controls.Add(picUsa)
        GroupBox1.Controls.Add(picJamaica)
        GroupBox1.Controls.Add(picBahamas)
        GroupBox1.Controls.Add(picCosta)
        GroupBox1.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(198, 75)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(622, 216)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "NORTH AMERICA"
        ' 
        ' picCanada
        ' 
        picCanada.Image = My.Resources.Resources.cana
        picCanada.Location = New Point(456, 129)
        picCanada.Margin = New Padding(4)
        picCanada.Name = "picCanada"
        picCanada.Size = New Size(129, 64)
        picCanada.SizeMode = PictureBoxSizeMode.Zoom
        picCanada.TabIndex = 4
        picCanada.TabStop = False
        ' 
        ' picUsa
        ' 
        picUsa.Image = My.Resources.Resources.usa
        picUsa.Location = New Point(456, 38)
        picUsa.Margin = New Padding(4)
        picUsa.Name = "picUsa"
        picUsa.Size = New Size(129, 64)
        picUsa.SizeMode = PictureBoxSizeMode.Zoom
        picUsa.TabIndex = 3
        picUsa.TabStop = False
        ' 
        ' picJamaica
        ' 
        picJamaica.Image = My.Resources.Resources.jamai
        picJamaica.Location = New Point(249, 93)
        picJamaica.Margin = New Padding(4)
        picJamaica.Name = "picJamaica"
        picJamaica.Size = New Size(129, 64)
        picJamaica.SizeMode = PictureBoxSizeMode.Zoom
        picJamaica.TabIndex = 2
        picJamaica.TabStop = False
        ' 
        ' picBahamas
        ' 
        picBahamas.Image = My.Resources.Resources.bahas
        picBahamas.Location = New Point(31, 129)
        picBahamas.Margin = New Padding(4)
        picBahamas.Name = "picBahamas"
        picBahamas.Size = New Size(129, 64)
        picBahamas.SizeMode = PictureBoxSizeMode.Zoom
        picBahamas.TabIndex = 1
        picBahamas.TabStop = False
        ' 
        ' picCosta
        ' 
        picCosta.Image = My.Resources.Resources.costa
        picCosta.Location = New Point(31, 38)
        picCosta.Margin = New Padding(4)
        picCosta.Name = "picCosta"
        picCosta.Size = New Size(129, 64)
        picCosta.SizeMode = PictureBoxSizeMode.Zoom
        picCosta.TabIndex = 0
        picCosta.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.AliceBlue
        GroupBox2.Controls.Add(picPeru)
        GroupBox2.Controls.Add(picBrazil)
        GroupBox2.Controls.Add(picUruguay)
        GroupBox2.Controls.Add(picChile)
        GroupBox2.Controls.Add(picArgen)
        GroupBox2.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox2.Location = New Point(198, 328)
        GroupBox2.Margin = New Padding(4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4)
        GroupBox2.Size = New Size(622, 221)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "SOUTH AMERICA"
        ' 
        ' picPeru
        ' 
        picPeru.Image = My.Resources.Resources.peru
        picPeru.Location = New Point(456, 121)
        picPeru.Margin = New Padding(4)
        picPeru.Name = "picPeru"
        picPeru.Size = New Size(129, 64)
        picPeru.SizeMode = PictureBoxSizeMode.Zoom
        picPeru.TabIndex = 4
        picPeru.TabStop = False
        ' 
        ' picBrazil
        ' 
        picBrazil.Image = My.Resources.Resources.brazil
        picBrazil.Location = New Point(31, 121)
        picBrazil.Margin = New Padding(4)
        picBrazil.Name = "picBrazil"
        picBrazil.Size = New Size(129, 64)
        picBrazil.SizeMode = PictureBoxSizeMode.Zoom
        picBrazil.TabIndex = 3
        picBrazil.TabStop = False
        ' 
        ' picUruguay
        ' 
        picUruguay.Image = My.Resources.Resources.urugyyuuuuu
        picUruguay.Location = New Point(456, 28)
        picUruguay.Margin = New Padding(4)
        picUruguay.Name = "picUruguay"
        picUruguay.Size = New Size(129, 64)
        picUruguay.SizeMode = PictureBoxSizeMode.Zoom
        picUruguay.TabIndex = 2
        picUruguay.TabStop = False
        ' 
        ' picChile
        ' 
        picChile.Image = My.Resources.Resources.download__1_
        picChile.Location = New Point(249, 80)
        picChile.Margin = New Padding(4)
        picChile.Name = "picChile"
        picChile.Size = New Size(129, 64)
        picChile.SizeMode = PictureBoxSizeMode.Zoom
        picChile.TabIndex = 1
        picChile.TabStop = False
        ' 
        ' picArgen
        ' 
        picArgen.Image = My.Resources.Resources.argen
        picArgen.Location = New Point(31, 28)
        picArgen.Margin = New Padding(4)
        picArgen.Name = "picArgen"
        picArgen.Size = New Size(129, 64)
        picArgen.SizeMode = PictureBoxSizeMode.Zoom
        picArgen.TabIndex = 0
        picArgen.TabStop = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.AliceBlue
        btnExit.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnExit.Location = New Point(431, 583)
        btnExit.Margin = New Padding(4)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(172, 50)
        btnExit.TabIndex = 2
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblCont
        ' 
        lblCont.BackColor = Color.AliceBlue
        lblCont.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblCont.Location = New Point(271, 9)
        lblCont.Name = "lblCont"
        lblCont.Size = New Size(482, 41)
        lblCont.TabIndex = 3
        lblCont.Text = "CLICK ON ANY OF THE FLAG "
        ' 
        ' frm1
        ' 
        AutoScaleDimensions = New SizeF(14F, 26F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background
        ClientSize = New Size(1119, 727)
        Controls.Add(lblCont)
        Controls.Add(btnExit)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "frm1"
        Text = "CONTINENTS"
        GroupBox1.ResumeLayout(False)
        CType(picCanada, ComponentModel.ISupportInitialize).EndInit()
        CType(picUsa, ComponentModel.ISupportInitialize).EndInit()
        CType(picJamaica, ComponentModel.ISupportInitialize).EndInit()
        CType(picBahamas, ComponentModel.ISupportInitialize).EndInit()
        CType(picCosta, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        CType(picPeru, ComponentModel.ISupportInitialize).EndInit()
        CType(picBrazil, ComponentModel.ISupportInitialize).EndInit()
        CType(picUruguay, ComponentModel.ISupportInitialize).EndInit()
        CType(picChile, ComponentModel.ISupportInitialize).EndInit()
        CType(picArgen, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents picCanada As PictureBox
    Friend WithEvents picUsa As PictureBox
    Friend WithEvents picJamaica As PictureBox
    Friend WithEvents picBahamas As PictureBox
    Friend WithEvents picCosta As PictureBox
    Friend WithEvents picPeru As PictureBox
    Friend WithEvents picBrazil As PictureBox
    Friend WithEvents picUruguay As PictureBox
    Friend WithEvents picChile As PictureBox
    Friend WithEvents picArgen As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents lblCont As Label
End Class
