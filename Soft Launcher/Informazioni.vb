Imports MaterialSkin
Imports System.Net
Imports System.IO

Public Class Informazioni
    Private Sub Informazioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Dark") Then
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance



            SkinManager.AddFormToManage(Me)

            SkinManager.Theme = MaterialSkinManager.Themes.DARK



        End If


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Light") Then
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance



            SkinManager.AddFormToManage(Me)

            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Blue") Then
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance



            SkinManager.AddFormToManage(Me)



            SkinManager.ColorScheme = New ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.WHITE)
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Red") Then
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance



            SkinManager.AddFormToManage(Me)



            SkinManager.ColorScheme = New ColorScheme(Primary.Red900, Primary.Red900, Primary.Red900, Accent.LightBlue200, TextShade.WHITE)
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Green") Then
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance



            SkinManager.AddFormToManage(Me)



            SkinManager.ColorScheme = New ColorScheme(Primary.Green900, Primary.Green900, Primary.Green900, Accent.LightBlue200, TextShade.WHITE)
        End If

        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Orange") Then
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance



            SkinManager.AddFormToManage(Me)



            SkinManager.ColorScheme = New ColorScheme(Primary.Orange900, Primary.Orange900, Primary.Orange900, Accent.LightBlue200, TextShade.WHITE)
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub MaterialLabel5_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub MaterialLabel6_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialLabel7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub MaterialLabel4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialButton4_Click(sender As Object, e As EventArgs)
        Process.Start("https://grammaticosamuele4.wixsite.com/ilmiosito/updater-sup-buils-1101")
    End Sub

    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs)
        Process.Start("https://grammaticosamuele4.wixsite.com/ilmiosito/updater-spi-build-1410")
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs)
        download.DownloadFileAsync(New Uri("ftp://SC@192.168.1.22/Software%20Sl/Soft%20Optimizer%202.02.1/Ver.txt"), Application.StartupPath & "\Updater.txt")

        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        download.DownloadFileAsync(New Uri("ftp://SC@192.168.1.22/Soft%20Launcher%201.01.2/Ver.txt"), Application.StartupPath & "\Updater.txt")

        Timer1.Start()
        Timer2.Start()
        Timer3.start
    End Sub


    Public WithEvents download As New WebClient


    Private Sub MaterialButton5_Click(sender As Object, e As EventArgs) Handles MaterialButton5.Click
        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Up") Then
            Directory.Delete(Application.StartupPath & "\Up")
            MsgBox("Aggiornamento automatico all'avvio disattivato")
        Else
            Directory.CreateDirectory(Application.StartupPath & "\Up")
            MsgBox("Aggiornamento automatico all'avvio attivato")
        End If
    End Sub

    Private Sub download_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        On Error Resume Next

        Dim apri As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Updater.txt")
        b.Text = apri

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If a.Text < b.Text Then
            Process.Start("https://grammaticosamuele4.wixsite.com/ilmiosito/updater-sl")
        Else
            MsgBox("Aggiornato")

        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer2.Stop()

    End Sub
End Class