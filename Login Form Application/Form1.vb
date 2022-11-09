Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1
    Dim pathname As String
    Dim UserDatabaseFile As System.IO.StreamReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserDatabaseFile = My.Computer.FileSystem.OpenTextFileReader(pathname & "UserDatabaseFile.txt")
        pathname = Application.StartupPath
        Form2.Visible = False
    End Sub

    Private Sub BTN_Login_Click(sender As Object, e As EventArgs) Handles BTN_Login.Click

    End Sub

    Private Sub BTN_NewAccount_Click(sender As Object, e As EventArgs) Handles BTN_NewAccount.Click
        Me.Visible = False
        Form2.Visible = True
    End Sub

End Class

Public Class User
    Public Property usernameEntered As String
    Public Property passwordEntered As String
    Public Property uniqueIdentifier As String

    Public Sub New(usernameEntered As String, passwordEntered As String)
        Me.usernameEntered = usernameEntered
        Me.passwordEntered = passwordEntered
        Dim uniqueIdentifier As String
        Randomize() 'randomise seed based on system time
        uniqueIdentifier = Int((99999999 - 0 + 1) * Rnd() + 0) 'Int((upperbound - lowerbound + 1) * Rnd + lowerbound)
        Me.uniqueIdentifier = uniqueIdentifier
    End Sub

End Class




