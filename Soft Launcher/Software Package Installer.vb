Imports System.IO
Imports System.Net
Imports MaterialSkin

Public Class Software_Package_Installer
    Private Sub Software_Package_Installer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer2.Start()
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer2.Stop()
        Me.Show()

        If My.Computer.FileSystem.DirectoryExists("C:\Spi") Then
            MaterialButton4.Enabled = True
        Else
            MaterialButton4.Enabled = False
        End If

        MaterialButton3.Enabled = False


        If My.Computer.FileSystem.DirectoryExists("C:\Spi") Then
            MaterialButton2.Enabled = False
        Else
            MaterialButton2.Enabled = True

        End If

        If My.Computer.FileSystem.DirectoryExists("C:\Spi") Then
            MaterialButton1.Enabled = True
        Else
            MaterialButton1.Enabled = False
        End If

        If My.Computer.FileSystem.DirectoryExists("C:\IN\Spi") Then
            MaterialButton3.Enabled = True
        Else
            MaterialButton3.Enabled = False
        End If



        If My.Computer.FileSystem.DirectoryExists("C:\Spi") Then
            MaterialButton5.Enabled = True
        Else
            MaterialButton5.Enabled = False
        End If
    End Sub

    Private Sub MaterialButton4_Click(sender As Object, e As EventArgs) Handles MaterialButton4.Click
        On Error Resume Next

        Directory.Delete("C:\Spi\Blue")
        Directory.Delete("C:\Spi\Orange")
        Directory.Delete("C:\Spi\Conf")
        Directory.Delete("C:\Spi\Dark")
        Directory.Delete("C:\Spi\Red")
        Directory.Delete("C:\Spi\Green")
        Directory.Delete("C:\Spi\Light")
        Directory.Delete("C:\Spi\Up")
        Process.Start("C:\Spi\Uninstal.exe")
    End Sub

    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs) Handles MaterialButton3.Click

        Process.Start("C:\IN\Spi Build 1414 Sl.zip")
    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        MaterialLabel3.Show()
        MaterialProgressBar1.Show()
        Directory.CreateDirectory("C:\IN")
        Directory.CreateDirectory("C:\IN\Spi")
        download.DownloadFileAsync(New Uri("https://612092f6-6003-49d0-8fe5-2e737d705081.usrfiles.com/archives/612092_d4a4d81bb9f84a21b8439d21dbc62e6b.zip"), TextBox1.Text)


    End Sub

    Public WithEvents download As New WebClient

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Process.Start("C:\Spi\Software Package Installer.exe")

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


        MaterialLabel3.Hide()
        MaterialProgressBar1.Hide()
    End Sub

    Private Sub download_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged
        MaterialProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Hide()
    End Sub

    Private Sub MaterialButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialButton5_Click_1(sender As Object, e As EventArgs) Handles MaterialButton5.Click
        download.DownloadFileAsync(New Uri("ftp://SC@192.168.1.22/Software%20Sl/Software%20Package%20Installer%202.01.6/Ver.txt"), Application.StartupPath & "\Updater.txt")

        Timer3.Start()
        Timer4.Start()
        Timer5.Start()

    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Timer4.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        On Error Resume Next

        Dim apri As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Updater.txt")
        b.Text = apri
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If a.Text < b.Text Then
            Process.Start("https://grammaticosamuele4.wixsite.com/ilmiosito/updater-spi-sl")
        Else
            MsgBox("Aggiornato")
        End If
    End Sub
End Class