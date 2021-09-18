Public Class LoadingBes
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value += 5
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub LoadingBes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = (My.Computer.Screen.WorkingArea.Height / 4)
        Me.Left = (My.Computer.Screen.WorkingArea.Width / 4)
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        Timer1.Start()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar2.Value += 20
        If ProgressBar2.Value = 100 Then
            Timer2.Stop()
            Me.Close()
            Main.Show()

        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class