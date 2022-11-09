<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.BTN_CreateAccountConfirm = New System.Windows.Forms.Button()
        Me.TXT_CreatePassword = New System.Windows.Forms.TextBox()
        Me.TXT_CreateUsername = New System.Windows.Forms.TextBox()
        Me.LBL_CreatePassword = New System.Windows.Forms.Label()
        Me.LBL_CreateUsername = New System.Windows.Forms.Label()
        Me.TXT_ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.LBL_ConfirmPassword = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_CreateAccountConfirm
        '
        Me.BTN_CreateAccountConfirm.Location = New System.Drawing.Point(80, 362)
        Me.BTN_CreateAccountConfirm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_CreateAccountConfirm.Name = "BTN_CreateAccountConfirm"
        Me.BTN_CreateAccountConfirm.Size = New System.Drawing.Size(151, 35)
        Me.BTN_CreateAccountConfirm.TabIndex = 11
        Me.BTN_CreateAccountConfirm.Text = "Create Account"
        Me.BTN_CreateAccountConfirm.UseVisualStyleBackColor = True
        '
        'TXT_CreatePassword
        '
        Me.TXT_CreatePassword.Location = New System.Drawing.Point(52, 180)
        Me.TXT_CreatePassword.Name = "TXT_CreatePassword"
        Me.TXT_CreatePassword.Size = New System.Drawing.Size(179, 26)
        Me.TXT_CreatePassword.TabIndex = 10
        '
        'TXT_CreateUsername
        '
        Me.TXT_CreateUsername.Location = New System.Drawing.Point(52, 78)
        Me.TXT_CreateUsername.Name = "TXT_CreateUsername"
        Me.TXT_CreateUsername.Size = New System.Drawing.Size(179, 26)
        Me.TXT_CreateUsername.TabIndex = 9
        '
        'LBL_CreatePassword
        '
        Me.LBL_CreatePassword.AutoSize = True
        Me.LBL_CreatePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CreatePassword.Location = New System.Drawing.Point(51, 133)
        Me.LBL_CreatePassword.Name = "LBL_CreatePassword"
        Me.LBL_CreatePassword.Size = New System.Drawing.Size(98, 25)
        Me.LBL_CreatePassword.TabIndex = 8
        Me.LBL_CreatePassword.Text = "Password"
        '
        'LBL_CreateUsername
        '
        Me.LBL_CreateUsername.AutoSize = True
        Me.LBL_CreateUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CreateUsername.Location = New System.Drawing.Point(47, 35)
        Me.LBL_CreateUsername.Name = "LBL_CreateUsername"
        Me.LBL_CreateUsername.Size = New System.Drawing.Size(102, 25)
        Me.LBL_CreateUsername.TabIndex = 7
        Me.LBL_CreateUsername.Text = "Username"
        '
        'TXT_ConfirmPassword
        '
        Me.TXT_ConfirmPassword.Location = New System.Drawing.Point(52, 289)
        Me.TXT_ConfirmPassword.Name = "TXT_ConfirmPassword"
        Me.TXT_ConfirmPassword.Size = New System.Drawing.Size(179, 26)
        Me.TXT_ConfirmPassword.TabIndex = 13
        '
        'LBL_ConfirmPassword
        '
        Me.LBL_ConfirmPassword.AutoSize = True
        Me.LBL_ConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ConfirmPassword.Location = New System.Drawing.Point(47, 244)
        Me.LBL_ConfirmPassword.Name = "LBL_ConfirmPassword"
        Me.LBL_ConfirmPassword.Size = New System.Drawing.Size(171, 25)
        Me.LBL_ConfirmPassword.TabIndex = 12
        Me.LBL_ConfirmPassword.Text = "Confirm Password"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 442)
        Me.Controls.Add(Me.TXT_ConfirmPassword)
        Me.Controls.Add(Me.LBL_ConfirmPassword)
        Me.Controls.Add(Me.BTN_CreateAccountConfirm)
        Me.Controls.Add(Me.TXT_CreatePassword)
        Me.Controls.Add(Me.TXT_CreateUsername)
        Me.Controls.Add(Me.LBL_CreatePassword)
        Me.Controls.Add(Me.LBL_CreateUsername)
        Me.Name = "Form2"
        Me.Text = "Create Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_CreateAccountConfirm As Button
    Friend WithEvents TXT_CreatePassword As TextBox
    Friend WithEvents TXT_CreateUsername As TextBox
    Friend WithEvents LBL_CreatePassword As Label
    Friend WithEvents LBL_CreateUsername As Label
    Friend WithEvents TXT_ConfirmPassword As TextBox
    Friend WithEvents LBL_ConfirmPassword As Label
End Class
