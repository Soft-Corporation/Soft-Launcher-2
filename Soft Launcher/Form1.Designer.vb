<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialButton3 = New MaterialSkin.Controls.MaterialButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.MaterialProgressBar1 = New MaterialSkin.Controls.MaterialProgressBar()
        Me.a = New System.Windows.Forms.TextBox()
        Me.b = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(24, 243)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(107, 19)
        Me.MaterialLabel1.TabIndex = 1
        Me.MaterialLabel1.Text = "Soft Optimizer "
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.Location = New System.Drawing.Point(170, 243)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(190, 19)
        Me.MaterialLabel2.TabIndex = 3
        Me.MaterialLabel2.Text = "Software Package Installer"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.Location = New System.Drawing.Point(399, 243)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(144, 19)
        Me.MaterialLabel3.TabIndex = 5
        Me.MaterialLabel3.Text = "Soft Usb Passwords"
        '
        'Timer1
        '
        '
        'MaterialButton2
        '
        Me.MaterialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton2.Depth = 0
        Me.MaterialButton2.HighEmphasis = True
        Me.MaterialButton2.Icon = Nothing
        Me.MaterialButton2.Location = New System.Drawing.Point(425, 70)
        Me.MaterialButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton2.Name = "MaterialButton2"
        Me.MaterialButton2.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton2.Size = New System.Drawing.Size(123, 36)
        Me.MaterialButton2.TabIndex = 7
        Me.MaterialButton2.Text = "Impostazioni"
        Me.MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton2.UseAccentColor = False
        Me.MaterialButton2.UseVisualStyleBackColor = True
        '
        'MaterialButton3
        '
        Me.MaterialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton3.Depth = 0
        Me.MaterialButton3.HighEmphasis = True
        Me.MaterialButton3.Icon = Nothing
        Me.MaterialButton3.Location = New System.Drawing.Point(353, 70)
        Me.MaterialButton3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton3.Name = "MaterialButton3"
        Me.MaterialButton3.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton3.Size = New System.Drawing.Size(64, 36)
        Me.MaterialButton3.TabIndex = 8
        Me.MaterialButton3.Text = "News"
        Me.MaterialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton3.UseAccentColor = False
        Me.MaterialButton3.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Soft_Launcher.My.Resources.Resources.Senza_titolo2
        Me.PictureBox3.Location = New System.Drawing.Point(408, 135)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(121, 105)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Soft_Launcher.My.Resources.Resources.Senza_titolo1
        Me.PictureBox2.Location = New System.Drawing.Point(205, 135)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(121, 105)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Soft_Launcher.My.Resources.Resources.Senza_titolo
        Me.PictureBox1.Location = New System.Drawing.Point(17, 135)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'Timer3
        '
        Me.Timer3.Interval = 4000
        '
        'Timer4
        '
        Me.Timer4.Interval = 4200
        '
        'MaterialProgressBar1
        '
        Me.MaterialProgressBar1.Depth = 0
        Me.MaterialProgressBar1.Location = New System.Drawing.Point(17, 3)
        Me.MaterialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialProgressBar1.Name = "MaterialProgressBar1"
        Me.MaterialProgressBar1.Size = New System.Drawing.Size(100, 5)
        Me.MaterialProgressBar1.TabIndex = 9
        Me.MaterialProgressBar1.Visible = False
        '
        'a
        '
        Me.a.Location = New System.Drawing.Point(147, 3)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(100, 20)
        Me.a.TabIndex = 10
        Me.a.Text = "2"
        Me.a.Visible = False
        '
        'b
        '
        Me.b.Location = New System.Drawing.Point(192, 24)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(100, 20)
        Me.b.TabIndex = 11
        Me.b.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 289)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.MaterialProgressBar1)
        Me.Controls.Add(Me.MaterialButton3)
        Me.Controls.Add(Me.MaterialButton2)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Soft Launcher"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton3 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents MaterialProgressBar1 As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents a As TextBox
    Friend WithEvents b As TextBox
End Class
