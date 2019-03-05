Public Class FormTopic1

    Private Sub LabelRocks_Click(sender As System.Object, e As System.EventArgs) Handles LabelRocks.Click

    End Sub

    Private Sub PictureIg_Click(sender As System.Object, e As System.EventArgs) Handles PictureIg.Click

    End Sub

    Private Sub PictureMet_Click(sender As System.Object, e As System.EventArgs) Handles PictureMet.Click

    End Sub

    Private Sub ButtonInfo_Click(sender As System.Object, e As System.EventArgs) Handles ButtonInfo.Click
        My.Computer.Audio.Play(My.Resources.Ding, AudioPlayMode.WaitToComplete)
        MsgBox("For extra information about this topic, please visit:http://www.learner.org/interactives/rockcycle/types.html", MsgBoxStyle.Information, "More Information")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        FormTopics.Show()
    End Sub

    Private Sub ButtonQuiz_Click(sender As System.Object, e As System.EventArgs) Handles ButtonQuiz.Click
        Me.Hide()
        FormTopic1Quiz.Show()
    End Sub
End Class