Public Class buttonadditionalactions

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub buttonadditionalactions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        startbuttonresets.Checked = allsettings_progresstimercolor.startbuttonresets.Checked()
        stopresets.Checked = allsettings_progresstimercolor.stopresets.Checked
        resetstops.Checked = allsettings_progresstimercolor.resetstops.Checked
    End Sub
End Class