Public Class progressbarsettings
    Dim maxok As Integer
    Dim minok As Integer
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        With maxval
            If IsNumeric(.Text) Then
                maxok = 1
            Else
                maxok = 0
            End If
        End With
        With minval
            If IsNumeric(.Text) Then
                minok = 1
            Else
                minok = 0
            End If
        End With
        If minok = 1 And maxok = 1 Then
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

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub progressbarsettings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        minval.Text = Form1.ProgressBar1.Minimum
        maxval.Text = Form1.ProgressBar1.Maximum
        RectangleShape2.FillColor = Form1.ProgressBar1.BackColor
        RectangleShape1.FillColor = Form1.ProgressBar1.ForeColor
        progresscolor.Color = RectangleShape1.FillColor
        forecolor.Color = RectangleShape2.FillColor
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        progresscolor.ShowDialog()
        RectangleShape1.FillColor = progresscolor.Color
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        forecolor.ShowDialog()
        RectangleShape2.FillColor = forecolor.Color
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