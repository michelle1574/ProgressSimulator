Public Class timersettings
    Dim timerok As Integer

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        With TextBox1
            If IsNumeric(.Text) Then
                timerok = 1
            Else
                timerok = 0
            End If
        End With
        If timerok = 1 Then
            Form1.Timer1.Interval = TextBox1.Text
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

    Private Sub timersettings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = Form1.Timer1.Interval
    End Sub
End Class