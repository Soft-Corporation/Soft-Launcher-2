<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Informazioni
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
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MaterialButton5 = New MaterialSkin.Controls.MaterialButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.MaterialProgressBar1 = New MaterialSkin.Controls.MaterialProgressBar()
        Me.a = New System.Windows.Forms.TextBox()
        Me.b = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel1.Location = New System.Drawing.Point(255, 115)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(92, 19)
        Me.MaterialLabel1.TabIndex = 1
        Me.MaterialLabel1.Text = "Soft Laucher"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel2.Location = New System.Drawing.Point(18, 193)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(110, 19)
        Me.MaterialLabel2.TabIndex = 2
        Me.MaterialLabel2.Text = "Versione 1.01.2"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.MaterialLabel3.Location = New System.Drawing.Point(18, 238)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(81, 19)
        Me.MaterialLabel3.TabIndex = 3
        Me.MaterialLabel3.Text = "Build: 1160"
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.HighEmphasis = True
        Me.MaterialButton1.Icon = Nothing
        Me.MaterialButton1.Location = New System.Drawing.Point(95, 284)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton1.Size = New System.Drawing.Size(312, 36)
        Me.MaterialButton1.TabIndex = 4
        Me.MaterialButton1.Text = "Verifica disponibilità aggiornamenti"
        Me.MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Soft_Launcher.My.Resources.Resources.Senza_titolo3
        Me.PictureBox1.Location = New System.Drawing.Point(149, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MaterialButton5
        '
        Me.MaterialButton5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton5.Depth = 0
        Me.MaterialButton5.HighEmphasis = True
        Me.MaterialButton5.Icon = Nothing
        Me.MaterialButton5.Location = New System.Drawing.Point(23, 332)
        Me.MaterialButton5.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton5.Name = "MaterialButton5"
        Me.MaterialButton5.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton5.Size = New System.Drawing.Size(467, 36)
        Me.MaterialButton5.TabIndex = 20
        Me.MaterialButton5.Text = "Abilita o disattiva aggiornamento automatico all'avvio"
        Me.MaterialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton5.UseAccentColor = False
        Me.MaterialButton5.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Timer2
        '
        Me.Timer2.Interval = 4000
        '
        'Timer3
        '
        Me.Timer3.Interval = 4200
        '
        'MaterialProgressBar1
        '
        Me.MaterialProgressBar1.Depth = 0
        Me.MaterialProgressBar1.Location = New System.Drawing.Point(301, 13)
        Me.MaterialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialProgressBar1.Name = "MaterialProgressBar1"
        Me.MaterialProgressBar1.Size = New System.Drawing.Size(100, 5)
        Me.MaterialProgressBar1.TabIndex = 21
        Me.MaterialProgressBar1.Visible = False
        '
        'a
        '
        Me.a.Location = New System.Drawing.Point(60, -2)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(100, 20)
        Me.a.TabIndex = 22
        Me.a.Text = "2"
        Me.a.Visible = False
        '
        'b
        '
        Me.b.Location = New System.Drawing.Point(190, 22)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(100, 20)
        Me.b.TabIndex = 23
        Me.b.Visible = False
        '
        'Informazioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 387)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.MaterialProgressBar1)
        Me.Controls.Add(Me.MaterialButton5)
        Me.Controls.Add(Me.MaterialButton1)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.Name = "Informazioni"
        Me.ShowIcon = False
        Me.Text = "Informazioni"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton5 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents MaterialProgressBar1 As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents a As TextBox
    Friend WithEvents b As TextBox
End Class
