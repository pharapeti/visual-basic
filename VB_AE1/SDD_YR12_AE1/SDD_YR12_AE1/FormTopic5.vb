Public Class FormTypes

    Private Sub ButtonBack_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBack.Click
        Me.Hide()
        FormTopics.Show()
    End Sub

    Private Sub ButtonMagQuiz_Click(sender As System.Object, e As System.EventArgs) Handles ButtonMagQuiz.Click
        Magnetic.Show()
    End Sub
End Class