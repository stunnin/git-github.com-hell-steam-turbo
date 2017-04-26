'//         
'//       Copyright (c) shinez 2017 - 2018
'//       Originally made to steal of skeletons URLs, but he get idiot and then realese??!?!?
'//         

Public Class main
    Private Sub btnStartClick(sender As Object, e As EventArgs) Handles btnStart.Click
        attempts = 0
        tmTurbo.Start()
        lblStatus.Text = "[ running ]"
        txtURL.Enabled = False
    End Sub
    Dim attempts As Integer = 0
    Private Sub turboTick(sender As Object, e As EventArgs) Handles tmTurbo.Tick
        On Error GoTo 1
        If (wbSteam.Document.GetElementById("customURL").GetAttribute("value") = txtURL.Text) Then
            wbSteam.Document.Forms(0).InvokeMember("submit")
            txtAttempts.Text = attempts.ToString()
            attempts += 1
        Else
            wbSteam.Document.GetElementById("customURL").SetAttribute("value", txtURL.Text)
        End If
1:      Me.Show()
    End Sub
    Private Sub btnStopClick(sender As Object, e As EventArgs) Handles btnStop.Click
        tmTurbo.Stop()
        lblStatus.Text = "[ idle ]"
        txtURL.Enabled = True
    End Sub
    Private Sub mainLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        wbSteam.Visible = False
        tmFix.Start()
    End Sub
    Private Sub btnSignInClick(sender As Object, e As EventArgs) Handles btnSignIn.Click
        wbSteam.Document.GetElementById("steamAccountName").SetAttribute("value", txtUsername.Text)
        wbSteam.Document.GetElementById("steamPassword").SetAttribute("value", txtPassword.Text)
        wbSteam.Document.GetElementById("SteamLogin").InvokeMember("Click")
        If (cbBrowser.Checked = True) Then
            Me.Height = 510
            wbSteam.Top = 200
            wbSteam.Visible = True
        Else
            Me.Height = 244
            wbSteam.Top = 80
            wbSteam.Visible = False
        End If
    End Sub
    Private Sub wndwTransition(sender As Object, e As EventArgs) Handles tmFix.Tick
        If (wbSteam.Document.Title = "Steam Community :: Edit Profile") Then
            On Error GoTo 2
            btnSignIn.Visible = False
            txtUsername.Visible = False
            txtPassword.Visible = False
            lblUsername.Visible = False
            lblPassword.Visible = False
            pbTornado.Visible = False
            cbBrowser.Visible = False
            Me.Height = 120
            wbSteam.Top = 80
            wbSteam.Visible = False
            tmDebug.Start()
            Me.Text = "b1g sH1n3Zz Turb0 | Account: " + txtUsername.Text
            tmFix.Stop()
        End If
2:      Me.Show()
    End Sub
    Private Sub debug(sender As Object, e As EventArgs) Handles tmDebug.Tick
        On Error GoTo 3
        If (cbDebug.Checked = True) Then
            Me.Height = 390
            wbSteam.Visible = True
        Else
            Me.Height = 120
            wbSteam.Visible = False
        End If
3:      Me.Show()
    End Sub
End Class
