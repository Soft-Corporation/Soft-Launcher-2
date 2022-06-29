Imports System.IO
Imports System.Net
Imports MaterialSkin
Public Class Soft_Usb_Passwords
    Private Sub Soft_Usb_Passwords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        If My.Computer.FileSystem.DirectoryExists("C:\Sup") Then
            MaterialButton4.Enabled = True
        Else
            MaterialButton4.Enabled = False
        End If

        MaterialButton3.Enabled = False


        If My.Computer.FileSystem.DirectoryExists("C:\Sup") Then
            MaterialButton2.Enabled = False
        Else
            MaterialButton2.Enabled = True

        End If

        If My.Computer.FileSystem.DirectoryExists("C:\Sup") Then
            MaterialButton1.Enabled = True
        Else
            MaterialButton1.Enabled = False
        End If

        If My.Computer.FileSystem.DirectoryExists("C:\IN\Sup") Then
            MaterialButton3.Enabled = True
        Else
            MaterialButton3.Enabled = False
        End If

        If My.Computer.FileSystem.DirectoryExists("C:\Sup") Then
            MaterialButton5.Enabled = True
        Else
            MaterialButton5.Enabled = False
        End If
    End Sub

    Private Sub MaterialButton4_Click(sender As Object, e As EventArgs) Handles MaterialButton4.Click
        On Error Resume Next
        Directory.Delete("C:\Sup\3")
        Directory.Delete("C:\Sup\Blue")
        Directory.Delete("C:\Sup\Conf")
        Directory.Delete("C:\Sup\Dark")
        Directory.Delete("C:\Sup\Red")
        Directory.Delete("C:\Sup\Green")
        Directory.Delete("C:\Sup\Orange")
        Directory.Delete("C:\Sup\Light")
        Directory.Delete("C:\Sup\Up")
        Process.Start("C:\Sup\Uninstal.exe")


    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        MaterialLabel3.Show()
        MaterialProgressBar1.Show()
        Directory.CreateDirectory("C:\IN")
        download.DownloadFileAsync(New Uri("https://612092f6-6003-49d0-8fe5-2e737d705081.usrfiles.com/archives/612092_5f09f5e36c4249b1bdf51f866844be4e.zip"), TextBox1.Text)
        Directory.CreateDirectory("C:\IN\Sup")

    End Sub

    Private Sub download_DownloadProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs) Handles download.DownloadProgressChanged
        MaterialProgressBar1.Value = e.ProgressPercentage
    End Sub

    Public WithEvents download As New WebClient

    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs) Handles MaterialButton3.Click
        Process.Start("C:\IN\Sup B 1103 Sl.zip")
    End Sub

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        Process.Start("C:\Sup\Soft Usb Passwords.exe")

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

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Me.Hide()

    End Sub

    Private Sub MaterialButton5_Click(sender As Object, e As EventArgs) Handles MaterialButton5.Click
        download.DownloadFileAsync(New Uri("ftp://SC@192.168.1.22/Software%20Sl/Soft%20Usb%20Passwords%201.01.1/Ver.txt"), Application.StartupPath & "\Updater.txt")

        Timer3.Start()
        Timer4.Start()
        Timer5.Start()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        On Error Resume Next

        Dim apri As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\Updater.txt")
        b.Text = apri
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If a.Text < b.Text Then
            Process.Start("https://grammaticosamuele4.wixsite.com/ilmiosito/updater-sup-sl")
        Else
            MsgBox("Aggiornato")
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Timer4.Stop()

    End Sub
End Class