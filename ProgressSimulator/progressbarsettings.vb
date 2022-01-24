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
    End Sub
End Class