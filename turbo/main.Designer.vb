<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.lblDesiredURL = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.wbSteam = New System.Windows.Forms.WebBrowser()
        Me.tmTurbo = New System.Windows.Forms.Timer(Me.components)
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.tmFix = New System.Windows.Forms.Timer(Me.components)
        Me.cbBrowser = New System.Windows.Forms.CheckBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.cbDebug = New System.Windows.Forms.CheckBox()
        Me.txtAttempts = New System.Windows.Forms.TextBox()
        Me.tmDebug = New System.Windows.Forms.Timer(Me.components)
        Me.lblAttempts = New System.Windows.Forms.Label()
        Me.pbTornado = New System.Windows.Forms.PictureBox()
        CType(Me.pbTornado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(12, 25)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(390, 20)
        Me.txtURL.TabIndex = 0
        '
        'lblDesiredURL
        '
        Me.lblDesiredURL.AutoSize = True
        Me.lblDesiredURL.Location = New System.Drawing.Point(9, 9)
        Me.lblDesiredURL.Name = "lblDesiredURL"
        Me.lblDesiredURL.Size = New System.Drawing.Size(63, 13)
        Me.lblDesiredURL.TabIndex = 1
        Me.lblDesiredURL.Text = "Target URL"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 51)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(53, 23)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'wbSteam
        '
        Me.wbSteam.Location = New System.Drawing.Point(12, 80)
        Me.wbSteam.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbSteam.Name = "wbSteam"
        Me.wbSteam.Size = New System.Drawing.Size(390, 259)
        Me.wbSteam.TabIndex = 5
        Me.wbSteam.Url = New System.Uri("http://steamcommunity.com/my/edit/?l=english", System.UriKind.Absolute)
        '
        'tmTurbo
        '
        Me.tmTurbo.Interval = 260
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(324, 9)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblStatus.Size = New System.Drawing.Size(35, 13)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "[ idle ]"
        '
        'btnSignIn
        '
        Me.btnSignIn.Location = New System.Drawing.Point(12, 173)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(53, 23)
        Me.btnSignIn.TabIndex = 7
        Me.btnSignIn.Text = "Sign In"
        Me.btnSignIn.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(12, 108)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(158, 20)
        Me.txtUsername.TabIndex = 8
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(12, 92)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 9
        Me.lblUsername.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(12, 147)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(158, 20)
        Me.txtPassword.TabIndex = 10
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 131)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 11
        Me.lblPassword.Text = "Password"
        '
        'tmFix
        '
        Me.tmFix.Interval = 2000
        '
        'cbBrowser
        '
        Me.cbBrowser.AutoSize = True
        Me.cbBrowser.Location = New System.Drawing.Point(71, 177)
        Me.cbBrowser.Name = "cbBrowser"
        Me.cbBrowser.Size = New System.Drawing.Size(86, 17)
        Me.cbBrowser.TabIndex = 14
        Me.cbBrowser.Text = "Use Browser"
        Me.cbBrowser.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(71, 51)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(53, 23)
        Me.btnStop.TabIndex = 15
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'cbDebug
        '
        Me.cbDebug.AutoSize = True
        Me.cbDebug.Location = New System.Drawing.Point(130, 55)
        Me.cbDebug.Name = "cbDebug"
        Me.cbDebug.Size = New System.Drawing.Size(58, 17)
        Me.cbDebug.TabIndex = 16
        Me.cbDebug.Text = "Debug"
        Me.cbDebug.UseVisualStyleBackColor = True
        '
        'txtAttempts
        '
        Me.txtAttempts.Enabled = False
        Me.txtAttempts.Location = New System.Drawing.Point(334, 53)
        Me.txtAttempts.Name = "txtAttempts"
        Me.txtAttempts.Size = New System.Drawing.Size(68, 20)
        Me.txtAttempts.TabIndex = 17
        Me.txtAttempts.Text = "0"
        '
        'tmDebug
        '
        '
        'lblAttempts
        '
        Me.lblAttempts.AutoSize = True
        Me.lblAttempts.Location = New System.Drawing.Point(282, 56)
        Me.lblAttempts.Name = "lblAttempts"
        Me.lblAttempts.Size = New System.Drawing.Size(48, 13)
        Me.lblAttempts.TabIndex = 18
        Me.lblAttempts.Text = "Attempts"
        '
        'pbTornado
        '
        Me.pbTornado.Image = Global.turbo.My.Resources.Resources.tornado
        Me.pbTornado.Location = New System.Drawing.Point(176, 92)
        Me.pbTornado.Name = "pbTornado"
        Me.pbTornado.Size = New System.Drawing.Size(226, 104)
        Me.pbTornado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbTornado.TabIndex = 19
        Me.pbTornado.TabStop = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 205)
        Me.Controls.Add(Me.pbTornado)
        Me.Controls.Add(Me.lblAttempts)
        Me.Controls.Add(Me.txtAttempts)
        Me.Controls.Add(Me.cbDebug)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.cbBrowser)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.wbSteam)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblDesiredURL)
        Me.Controls.Add(Me.txtURL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.Text = "b1g sH1n3Zz Turb0"
        CType(Me.pbTornado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtURL As TextBox
    Friend WithEvents lblDesiredURL As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents wbSteam As WebBrowser
    Friend WithEvents tmTurbo As Timer
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnSignIn As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents tmFix As Timer
    Friend WithEvents cbBrowser As CheckBox
    Friend WithEvents btnStop As Button
    Friend WithEvents cbDebug As CheckBox
    Friend WithEvents txtAttempts As TextBox
    Friend WithEvents tmDebug As Timer
    Friend WithEvents lblAttempts As Label
    Friend WithEvents pbTornado As PictureBox
End Class
