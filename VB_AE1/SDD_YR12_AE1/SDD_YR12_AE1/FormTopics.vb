Public Class FormTopics
    Dim Answer As Integer
    Public username As String

    Private Sub ButtonBack_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBack.Click
        Me.Hide()
        FormHome.Show()
    End Sub

    Private Sub ButtonHelp_Click(sender As System.Object, e As System.EventArgs) Handles ButtonHelp.Click
        My.Computer.Audio.Play(My.Resources.Ding, AudioPlayMode.WaitToComplete)
        MsgBox("You must first input a name, agree that the name you entered is correct, then choose a topic.", MsgBoxStyle.Information, "Assistance:")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonTopic1.Click
        If username = "" Then
            MsgBox("You must enter your name.", , "Error")
            My.Computer.Audio.Play(My.Resources.ErrorSound, AudioPlayMode.WaitToComplete)
        Else
            Me.Hide()
            FormTopic1.Show()
        End If
    End Sub

    Private Sub ButtonTopic2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonTopic2.Click
        Me.Hide()
        FormTopic2.Show()
    End Sub

    Private Sub ButtonTopic3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonTopic3.Click
        Me.Hide()
        FormTopic3.Show()
    End Sub

    Private Sub ButtonTopic4_Click(sender As System.Object, e As System.EventArgs) Handles ButtonTopic4.Click
        Me.Hide()
        FormTopic4.Show()
    End Sub

    Private Sub ButtonTopic5_Click(sender As System.Object, e As System.EventArgs) Handles ButtonTopic5.Click
        Me.Hide()
        FormTypes.Show()
    End Sub

    Private Sub ButtonTopic6_Click(sender As System.Object, e As System.EventArgs) Handles ButtonTopic6.Click
        Me.Hide()
        FormTopic6.Show()
    End Sub

    Public Sub ButtonInput_Click(sender As System.Object, e As System.EventArgs) Handles ButtonInput.Click
        username = TextBoxName.Text

        Answer = MsgBox("Is " & username & " correct?", vbYesNo, "Verification")

        If Answer = vbYes Then
            username = TextBoxName.Text
            LabelName.Text = username
            LabelName.BorderStyle = BorderStyle.FixedSingle
        Else
            MsgBox("Please enter the correct name.", MsgBoxStyle.ApplicationModal, "Try again.")
        End If
    End Sub
End Class