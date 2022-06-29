Imports System.IO
Imports MaterialSkin
Imports System.Net
Public Class Form1
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Software_Package_Installer.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists("C:\IN") Then

            On Error Resume Next
            For Each d In Directory.GetDirectories("C:\IN")
                Directory.Delete(d, True)


            Next

            For Each f In Directory.GetFiles("C:\IN")
                File.Delete(f)
            Next
            Directory.Delete("C:\IN")
        End If
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


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Purple") Then
            Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance



            SkinManager.AddFormToManage(Me)



            SkinManager.ColorScheme = New ColorScheme(Primary.Purple900, Primary.Purple900, Primary.Purple900, Accent.LightBlue200, TextShade.WHITE)
        End If


        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Conf") Then


        Else

            Conf.Show()

        End If




        If My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\Up") Then
            download.DownloadFileAsync(New Uri("ftp://SC@192.168.1.22/Soft%20Launcher%201.01.2/Ver.txt"), Application.StartupPath & "\Updater.txt")

            Timer2.Start()
            Timer3.Start()
            Timer4.Start()
        End If




    End Sub

    Public WithEvents download As New webclient

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Soft_Optimizer.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Soft_Usb_Passwords.Show()
    End Sub

    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs) Handles MaterialButton3.Click
        Sezione_News.Show()
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) 
        Informazioni.Show()
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        Impostazioni.Show()
    End Sub

    Private Sub MaterialLabel1_Click(sender As Object, e As EventArgs) Handles MaterialLabel1.Click
        Soft_Optimizer.Show()
    End Sub

    Private Sub MaterialLabel2_Click(sender As Object, e As EventArgs) Handles MaterialLabel2.Click
        Software_Package_Installer.Show()
    End Sub

    Private Sub MaterialLabel3_Click(sender As Object, e As EventArgs) Handles MaterialLabel3.Click
        Soft_Usb_Passwords.Show()
    End Sub

    Private Sub download_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged
        MaterialProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        On Error Resume Next

        Dim apri As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Updater.txt")
        b.Text = apri
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If a.Text < b.Text Then
            Process.Start("https://grammaticosamuele4.wixsite.com/ilmiosito/updater-sl")
        Else


        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer3.Stop()
    End Sub
End Class
