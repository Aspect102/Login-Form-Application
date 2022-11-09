<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTN_Login = New System.Windows.Forms.Button()
        Me.LBL_Username = New System.Windows.Forms.Label()
        Me.LBL_Password = New System.Windows.Forms.Label()
        Me.TXT_Username = New System.Windows.Forms.TextBox()
        Me.TXT_Password = New System.Windows.Forms.TextBox()
        Me.BTN_NewAccount = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTN_Login
        '
        Me.BTN_Login.Location = New System.Drawing.Point(56, 279)
        Me.BTN_Login.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Login.Name = "BTN_Login"
        Me.BTN_Login.Size = New System.Drawing.Size(112, 35)
        Me.BTN_Login.TabIndex = 0
        Me.BTN_Login.Text = "Login"
        Me.BTN_Login.UseVisualStyleBackColor = True
        '
        'LBL_Username
        '
        Me.LBL_Username.AutoSize = True
        Me.LBL_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Username.Location = New System.Drawing.Point(28, 58)
        Me.LBL_Username.Name = "LBL_Username"
        Me.LBL_Username.Size = New System.Drawing.Size(102, 25)
        Me.LBL_Username.TabIndex = 1
        Me.LBL_Username.Text = "Username"
        '
        'LBL_Password
        '
        Me.LBL_Password.AutoSize = True
        Me.LBL_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Password.Location = New System.Drawing.Point(32, 173)
        Me.LBL_Password.Name = "LBL_Password"
        Me.LBL_Password.Size = New System.Drawing.Size(98, 25)
        Me.LBL_Password.TabIndex = 2
        Me.LBL_Password.Text = "Password"
        '
        'TXT_Username
        '
        Me.TXT_Username.Location = New System.Drawing.Point(30, 105)
        Me.TXT_Username.Name = "TXT_Username"
        Me.TXT_Username.Size = New System.Drawing.Size(151, 26)
        Me.TXT_Username.TabIndex = 3
        '
        'TXT_Password
        '
        Me.TXT_Password.Location = New System.Drawing.Point(33, 219)
        Me.TXT_Password.Name = "TXT_Password"
        Me.TXT_Password.Size = New System.Drawing.Size(151, 26)
        Me.TXT_Password.TabIndex = 4
        '
        'BTN_NewAccount
        '
        Me.BTN_NewAccount.Location = New System.Drawing.Point(37, 333)
        Me.BTN_NewAccount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_NewAccount.Name = "BTN_NewAccount"
        Me.BTN_NewAccount.Size = New System.Drawing.Size(151, 35)
        Me.BTN_NewAccount.TabIndex = 5
        Me.BTN_NewAccount.Text = "Create Account"
        Me.BTN_NewAccount.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 382)
        Me.Controls.Add(Me.BTN_NewAccount)
        Me.Controls.Add(Me.TXT_Password)
        Me.Controls.Add(Me.TXT_Username)
        Me.Controls.Add(Me.LBL_Password)
        Me.Controls.Add(Me.LBL_Username)
        Me.Controls.Add(Me.BTN_Login)
        Me.Name = "Form1"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_Login As Button
    Friend WithEvents LBL_Username As Label
    Friend WithEvents LBL_Password As Label
    Friend WithEvents TXT_Username As TextBox
    Friend WithEvents TXT_Password As TextBox
    Friend WithEvents BTN_NewAccount As Button
End Class
