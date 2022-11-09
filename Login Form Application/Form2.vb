
Public Class Form2
    Public UserDatabaseList As New List(Of User)
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LBL_ConfirmPassword.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ClearFields()
        TXT_ConfirmPassword.Clear()
        TXT_CreatePassword.Clear()
        TXT_CreateUsername.Clear()
    End Sub

    Private Sub BTN_CreateAccountConfirm_Click(sender As Object, e As EventArgs) Handles BTN_CreateAccountConfirm.Click
        Dim ConfirmPasswordEntered, PasswordEntered, UsernameEntered, line As String

        ConfirmPasswordEntered = TXT_ConfirmPassword.Text
        PasswordEntered = TXT_CreatePassword.Text
        UsernameEntered = TXT_CreateUsername.Text

        If ConfirmPasswordEntered = PasswordEntered Then
            ClearFields()
            Me.Visible = False
            Form1.Visible = True
            UserDatabaseList.Add(New User(UsernameEntered, PasswordEntered))
            MsgBox("Account Created")
        Else
            MsgBox("Passwords Do Not Match")
            ClearFields()
        End If
    End Sub
End Class