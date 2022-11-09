
Public Class Form1
    Public userDatabaseFileLocation
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Form2.Visible = False
    End Sub

    Private Sub BTN_Login_Click(sender As Object, e As EventArgs) Handles BTN_Login.Click
        userDatabaseFileLocation = Application.StartupPath() & "\UserDatabaseFile.txt"
        Dim reader As System.IO.StreamReader
        reader = My.Computer.FileSystem.OpenTextFileReader(userDatabaseFileLocation)
        Dim PasswordSearch As String = TXT_Password.Text
        Dim UsernameSearch As String = TXT_Username.Text

        For Each entry As User In Form2.UserDatabaseList
            Dim lineoftext = reader.ReadLine()
            If PasswordSearch = entry.password And UsernameSearch = entry.username Then


            End If
        Next

    End Sub

    Private Sub BTN_NewAccount_Click(sender As Object, e As EventArgs) Handles BTN_NewAccount.Click
        Me.Visible = False
        Form2.Visible = True
    End Sub

End Class

Public Class User
    Public Property username As String
    Public Property password As String
    Public Property uniqueIdentifier As String

    Public Sub New(username As String, password As String)
        Me.username = username
        Me.password = password
        Dim uniqueIdentifier As String
        Randomize() 'randomise seed based on system time
        uniqueIdentifier = Int((99999999 - 0 + 1) * Rnd() + 0) 'Int((upperbound - lowerbound + 1) * Rnd + lowerbound)
        Me.uniqueIdentifier = uniqueIdentifier
    End Sub

End Class




