Public Class Load
    Private Sub TimerLD_Tick(sender As Object, e As EventArgs) Handles TimerLD.Tick
        ProgressBarLD.Increment(1)
        LabelLD.Text = ProgressBarLD.Value & ("%")
        If ProgressBarLD.Value = 100 Then
            TimerLD.Enabled = False
            'MsgBox("IM Full")
            Me.Hide()
            Dim MyObj = New Login
            MyObj.Show()
        End If
    End Sub

    Private Sub Load_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerLD.Start()

    End Sub
End Class
