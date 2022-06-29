Imports System.IO
Imports MaterialSkin
Public Class Impostazioni
    Private Sub Impostazioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        On Error Resume Next

        Directory.CreateDirectory(Application.StartupPath & "\Dark")
        Directory.Delete(Application.StartupPath & "\Light")






        MsgBox("Per Applicare le modifiche è richiesto il riavvio del Software")

        Process.Start(Application.StartupPath & "\Soft Launcher.exe")
        Form1.Close()


    End Sub

    Private Sub MaterialButton2_Click(sender As Object, e As EventArgs) Handles MaterialButton2.Click
        On Error Resume Next
        Directory.CreateDirectory(Application.StartupPath & "\Light")
        Directory.Delete(Application.StartupPath & "\Dark")

        MsgBox("Per applicare le modifiche è richiesto il riavvio del Software")

        Process.Start(Application.StartupPath & "\Soft Launcher.exe")
        Form1.Close()
    End Sub

    Private Sub MaterialButton3_Click(sender As Object, e As EventArgs) Handles MaterialButton3.Click
        On Error Resume Next
        Directory.CreateDirectory(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\Red")
        Directory.Delete(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\Orange")
        Directory.Delete(Application.StartupPath & "\Purple")

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance


        MsgBox("Per applicare le modifiche è richiesto il riavvio del software")

        Process.Start(Application.StartupPath & "\Soft Launcher.exe")

        Form1.Close()
    End Sub

    Private Sub MaterialButton4_Click(sender As Object, e As EventArgs) Handles MaterialButton4.Click
        On Error Resume Next
        Directory.CreateDirectory(Application.StartupPath & "\Red")
        Directory.Delete(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\Orange")
        Directory.Delete(Application.StartupPath & "\Purple")


        MsgBox("Per applicare le modifiche è richiesto il riavvio del software")

        Process.Start(Application.StartupPath & "\Soft Launcher.exe")

        Form1.Close()
    End Sub

    Private Sub MaterialButton5_Click(sender As Object, e As EventArgs) Handles MaterialButton5.Click
        On Error Resume Next
        Directory.CreateDirectory(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\Red")
        Directory.Delete(Application.StartupPath & "\Orange")
        Directory.Delete(Application.StartupPath & "\Purple")

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance



        MsgBox("Per applicare le modifiche è richiesto il riavvio del software")

        Process.Start(Application.StartupPath & "\Soft Launcher.exe")

        Form1.Close()
    End Sub

    Private Sub MaterialButton6_Click(sender As Object, e As EventArgs) Handles MaterialButton6.Click
        On Error Resume Next
        Directory.Delete(Application.StartupPath & "\Green")
        Directory.CreateDirectory(Application.StartupPath & "\Orange")
        Directory.Delete(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\Red")
        Directory.Delete(Application.StartupPath & "\Purple")

        MsgBox("Per applicare le modifiche è richiesto il riavvio del software")

        Process.Start(Application.StartupPath & "\Soft Launcher.exe")

        Form1.Close()
    End Sub

    Private Sub MaterialButton7_Click(sender As Object, e As EventArgs) Handles MaterialButton7.Click
        Informazioni.Show()
    End Sub

    Private Sub MaterialButton8_Click(sender As Object, e As EventArgs) Handles MaterialButton8.Click
        On Error Resume Next
        Directory.Delete(Application.StartupPath & "\Green")
        Directory.Delete(Application.StartupPath & "\Orange")
        Directory.Delete(Application.StartupPath & "\Blue")
        Directory.Delete(Application.StartupPath & "\Red")
        Directory.CreateDirectory(Application.StartupPath & "\Purple")


        MsgBox("Per applicare le modifiche è richiesto il riavvio del software")

        Process.Start(Application.StartupPath & "\Soft Launcher.exe")

        Form1.Close()
    End Sub
End Class