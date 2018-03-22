<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginform
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
        Me.tbusername = New System.Windows.Forms.TextBox()
        Me.tbpassword = New System.Windows.Forms.TextBox()
        Me.butlogin = New System.Windows.Forms.Button()
        Me.butcancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbusername
        '
        Me.tbusername.Location = New System.Drawing.Point(204, 74)
        Me.tbusername.Name = "tbusername"
        Me.tbusername.Size = New System.Drawing.Size(156, 20)
        Me.tbusername.TabIndex = 0
        '
        'tbpassword
        '
        Me.tbpassword.Location = New System.Drawing.Point(204, 100)
        Me.tbpassword.Name = "tbpassword"
        Me.tbpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.tbpassword.Size = New System.Drawing.Size(156, 20)
        Me.tbpassword.TabIndex = 1
        '
        'butlogin
        '
        Me.butlogin.Location = New System.Drawing.Point(137, 181)
        Me.butlogin.Name = "butlogin"
        Me.butlogin.Size = New System.Drawing.Size(112, 23)
        Me.butlogin.TabIndex = 2
        Me.butlogin.Text = "Log In"
        Me.butlogin.UseVisualStyleBackColor = True
        '
        'butcancel
        '
        Me.butcancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butcancel.Location = New System.Drawing.Point(255, 181)
        Me.butcancel.Name = "butcancel"
        Me.butcancel.Size = New System.Drawing.Size(105, 23)
        Me.butcancel.TabIndex = 3
        Me.butcancel.Text = "Cancel"
        Me.butcancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'loginform
        '
        Me.AcceptButton = Me.butlogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.butcancel
        Me.ClientSize = New System.Drawing.Size(480, 250)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.butcancel)
        Me.Controls.Add(Me.butlogin)
        Me.Controls.Add(Me.tbpassword)
        Me.Controls.Add(Me.tbusername)
        Me.Name = "loginform"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbusername As System.Windows.Forms.TextBox
    Friend WithEvents tbpassword As System.Windows.Forms.TextBox
    Friend WithEvents butlogin As System.Windows.Forms.Button
    Friend WithEvents butcancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
