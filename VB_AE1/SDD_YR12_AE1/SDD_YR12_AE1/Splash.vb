Public Class Splash

    Private Sub TimerSlapsh_Tick(sender As System.Object, e As System.EventArgs) Handles TimerSplash.Tick

        Me.Hide()
        FormHome.Show()

        TimerSplash.Enabled = False
    End Sub

    Private Sub Splash_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        My.Computer.Audio.Play(My.Resources.Spring, AudioPlayMode.WaitToComplete)

    End Sub

    Private Sub ButtonNext_Click(sender As System.Object, e As System.EventArgs) Handles ButtonNext.Click
        TimerSplash.Enabled = False
        Me.Hide()
        FormHome.Show()
    End Sub
End Class
