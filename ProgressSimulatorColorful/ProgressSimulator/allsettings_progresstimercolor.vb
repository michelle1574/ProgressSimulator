Public Class allsettings_progresstimercolor
    Dim timerintervalok As Integer
    Dim progressmaxok As Integer
    Dim progressminok As Integer
    Private Sub allsettings_progresstimercolor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        timerInterval.Text = Form1.Timer1.Interval
        maxval.Text = Form1.ProgressBar1.Maximum
        minval.Text = Form1.ProgressBar1.Minimum
        RectangleShape2.FillColor = Form1.ProgressBar1.BackColor
        RectangleShape1.FillColor = Form1.ProgressBar1.ForeColor
        progresscolor.Color = RectangleShape1.FillColor
        forecolor.Color = RectangleShape2.FillColor
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
            Form1.ProgressBar1.ForeColor = forecolor.Color
            Form1.ProgressBar1.BackColor = progresscolor.Color
            Me.Hide()
            Me.Close()
        Else
            MsgBox("Not a number.", vbOKOnly + vbCritical, "Error")
        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        forecolor.ShowDialog()
        RectangleShape1.FillColor = forecolor.Color
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        progresscolor.ShowDialog()
        RectangleShape2.FillColor = progresscolor.Color
    End Sub


    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim color1 As Color = progresscolor.Color
        Dim color2 As Color = forecolor.Color
        progresscolor.Color = color2
        forecolor.Color = color1
        RectangleShape2.FillColor = progresscolor.Color
        RectangleShape1.FillColor = forecolor.Color
    End Sub
End Class