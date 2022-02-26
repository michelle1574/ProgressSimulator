Public Class Form1
    Dim ResetProgressInStart As Boolean = False
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If allsettings_progresstimercolor.startbuttonresets.Checked = True Or buttonadditionalactions.startbuttonresets.Checked = True Then
            ProgressBar1.Value = ProgressBar1.Minimum
        End If
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            ProgressBar1.Value = ProgressBar1.Minimum
        End If
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If allsettings_progresstimercolor.stopresets.Checked = True Or buttonadditionalactions.stopresets.Checked = True Then
            ProgressBar1.Value = ProgressBar1.Minimum
        End If
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If allsettings_progresstimercolor.resetstops.Checked = True Or buttonadditionalactions.resetstops.Checked = True Then
            Timer1.Stop()
        End If
        ProgressBar1.Value = ProgressBar1.Minimum
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 1
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            If CheckBox1.Checked = True Then
                MsgBox("Progressbar ended.", vbInformation + vbOKOnly, "Info")
            End If
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        aboutwindow.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub ProgressbarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProgressbarToolStripMenuItem.Click
        progressbarsettings.ShowDialog()
    End Sub

    Private Sub TimerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TimerToolStripMenuItem.Click
        timersettings.ShowDialog()
    End Sub

    Private Sub AllSettingsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AllSettingsToolStripMenuItem.Click
        allsettings_progresstimercolor.ShowDialog()
    End Sub

    Private Sub ButtonActionsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ButtonActionsToolStripMenuItem.Click
        buttonadditionalactions.ShowDialog()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        Dim ResetAnswer As DialogResult
        ResetAnswer = MsgBox("This will reset everything. Continue?", vbYesNo + MsgBoxStyle.Exclamation, "Warning")
        If ResetAnswer = Windows.Forms.DialogResult.Yes Then
            Timer1.Interval = 1
            CheckBox1.Checked = False
            ProgressBar1.Maximum = 100
            ProgressBar1.Minimum = 0
            ProgressBar1.Value = 0
            allsettings_progresstimercolor.resetstops.Checked = False
            buttonadditionalactions.resetstops.Checked = False
            allsettings_progresstimercolor.startbuttonresets.Checked = False
            buttonadditionalactions.startbuttonresets.Checked = False
            allsettings_progresstimercolor.stopresets.Checked = False
            buttonadditionalactions.stopresets.Checked = False
        Else
            Exit Sub
        End If
    End Sub
End Class
