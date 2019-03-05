Public Class FormHome

    Private Sub ButtonHelp_Click(sender As System.Object, e As System.EventArgs) Handles ButtonHelp.Click

        My.Computer.Audio.Play(My.Resources.Ding, AudioPlayMode.Background)
        MsgBox("Please click the [NEXT] button to continue.", MsgBoxStyle.Information, "Assistance")

    End Sub

    Private Sub ButtonQuit_Click(sender As System.Object, e As System.EventArgs) Handles ButtonQuit.Click
        My.Computer.Audio.Play(My.Resources.Ding, AudioPlayMode.Background)
        Dim response = MsgBox("Are you sure?", MsgBoxStyle.YesNo, "Exit?")

        If response = MsgBoxResult.Yes Then
            My.Computer.Audio.Play(My.Resources.ErrorSound, AudioPlayMode.WaitToComplete)
            End
        End If
    End Sub

    Private Sub ButtonNext_Click(sender As System.Object, e As System.EventArgs) Handles ButtonNext.Click
        Me.Hide()
        FormTopics.Show()
    End Sub
End Class