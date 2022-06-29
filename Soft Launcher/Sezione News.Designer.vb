<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sezione_News
    Inherits MaterialSkin.Controls.MaterialForm

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        Me.MaterialButton2 = New MaterialSkin.Controls.MaterialButton()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Location = New System.Drawing.Point(0, 127)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(917, 442)
        Me.Panel1.TabIndex = 0
        '
        'MaterialButton1
        '
        Me.MaterialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton1.Depth = 0
        Me.MaterialButton1.HighEmphasis = True
        Me.MaterialButton1.Icon = Nothing
        Me.MaterialButton1.Location = New System.Drawing.Point(16, 82)
        Me.MaterialButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton1.Name = "MaterialButton1"
        Me.MaterialButton1.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton1.Size = New System.Drawing.Size(64, 36)
        Me.MaterialButton1.TabIndex = 1
        Me.MaterialButton1.Text = "<"
        Me.MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton1.UseAccentColor = False
        Me.MaterialButton1.UseVisualStyleBackColor = True
        '
        'MaterialButton2
        '
        Me.MaterialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.MaterialButton2.Depth = 0
        Me.MaterialButton2.HighEmphasis = True
        Me.MaterialButton2.Icon = Nothing
        Me.MaterialButton2.Location = New System.Drawing.Point(88, 82)
        Me.MaterialButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialButton2.Name = "MaterialButton2"
        Me.MaterialButton2.NoAccentTextColor = System.Drawing.Color.Empty
        Me.MaterialButton2.Size = New System.Drawing.Size(64, 36)
        Me.MaterialButton2.TabIndex = 2
        Me.MaterialButton2.Text = ">"
        Me.MaterialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.MaterialButton2.UseAccentColor = False
        Me.MaterialButton2.UseVisualStyleBackColor = True
        '
        'Sezione_News
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 565)
        Me.Controls.Add(Me.MaterialButton2)
        Me.Controls.Add(Me.MaterialButton1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Sezione_News"
        Me.ShowIcon = False
        Me.Text = "Sezione News"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton
    Friend WithEvents MaterialButton2 As MaterialSkin.Controls.MaterialButton
End Class
