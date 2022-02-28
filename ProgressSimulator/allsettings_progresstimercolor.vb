Public Class allsettings_progresstimercolor
    Dim timerintervalok As Integer
    Dim progressmaxok As Integer
    Dim progressminok As Integer
    Private Sub allsettings_progresstimercolor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        timerInterval.Text = Form1.Timer1.Interval
        maxval.Text = Form1.ProgressBar1.Maximum
        minval.Text = Form1.ProgressBar1.Minimum
        startbuttonresets.Checked = buttonadditionalactions.startbuttonresets.Checked
        stopresets.Checked = buttonadditionalactions.stopresets.Checked
        resetstops.Checked = buttonadditionalactions.resetstops.Checked
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        With timerInterval
            If IsNumeric(.Text) Then
                timerintervalok = 1
            Else
                timerintervalok = 0
            End If
        End With
        With maxval
            If IsNumeric(.Text) Then
                progressmaxok = 1
            Else
                progressmaxok = 0
            End If
        End With
        With minval
            If IsNumeric(.Text) Then
                progressminok = 1
            Else
                progressminok = 0
            End If
        End With
        If progressmaxok = 1 And progressminok = 1 And timerintervalok = 1 Then
            Form1.Timer1.Interval = timerInterval.Text
            Form1.ProgressBar1.Maximum = maxval.Text
            Form1.ProgressBar1.Minimum = minval.Text
            Me.Hide()
            Me.Close()
        Else
            MsgBox("To nie cyfra.", vbOKOnly + vbCritical, "Błąd")
        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Me.Close()
    End Sub
End Class