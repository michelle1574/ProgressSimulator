Public Class buttonadditionalactions

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim answer As DialogResult
        answer = MsgBox("This will reset everything to defaults. Continue?", vbYesNo + vbExclamation, "Warning")
        If answer = vbYes Then
            startbuttonresets.Checked = False
            stopresets.Checked = False
            resetstops.Checked = False
            Me.Hide()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub buttonadditionalactions_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim answer2 As DialogResult
        answer2 = MsgBox("This will reset everything to defaults. Continue?", vbYesNo + vbExclamation, "Warning")
        If answer2 = vbYes Then
            startbuttonresets.Checked = False
            stopresets.Checked = False
            resetstops.Checked = False
            Me.Hide()
        Else
            e.Cancel = True
            Exit Sub
        End If
    End Sub
End Class