Public Class FormTopic1Quiz

    Dim Ans1 As Boolean
    Dim Ans2 As Boolean
    Dim Ans3 As Boolean
    Dim attempts As Integer

    Private Sub ButtonIg1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonIg1.Click
        LabelIg.Text = "Try again."
        attempts = attempts + 1
        Ans1 = False
        LabelAttemptsDesc.Text = attempts
    End Sub

    Private Sub ButtonIg2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonIg2.Click
        LabelIg.Text = "Try again."
        attempts = attempts + 1
        Ans1 = False
        LabelAttemptsDesc.Text = attempts
    End Sub

    Private Sub ButtonIg3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonIg3.Click
        LabelIg.Text = "You are correct!"
        attempts = attempts + 1
        Ans1 = True
        ButtonIg3.BackColor = Color.Green
        LabelAttemptsDesc.Text = attempts
    End Sub

    Private Sub ButtonSed1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSed1.Click
        LabelSed.Text = "You are correct!"
        attempts = attempts + 1
        Ans2 = True
        ButtonSed1.BackColor = Color.Green
        LabelAttemptsDesc.Text = attempts
    End Sub

    Private Sub ButtonSed2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSed2.Click
        LabelSed.Text = "Try again."
        attempts = attempts + 1
        Ans2 = False
        LabelAttemptsDesc.Text = attempts
    End Sub

    Private Sub ButtonSed3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSed3.Click
        LabelSed.Text = "Try again."
        attempts = attempts + 1
        Ans2 = False
        LabelAttemptsDesc.Text = attempts
    End Sub

    Private Sub ButtonMet1_Click(sender As System.Object, e As System.EventArgs) Handles ButtonMet1.Click
        LabelMet.Text = "Try again."
        attempts = attempts + 1
        Ans3 = False
        LabelAttemptsDesc.Text = attempts
    End Sub

    Private Sub ButtonMet2_Click(sender As System.Object, e As System.EventArgs) Handles ButtonMet2.Click
        LabelMet.Text = "You are correct!"
        attempts = attempts + 1
        Ans3 = True
        ButtonMet2.BackColor = Color.Green
        LabelAttemptsDesc.Text = attempts
    End Sub

    Private Sub ButtonMet3_Click(sender As System.Object, e As System.EventArgs) Handles ButtonMet3.Click
        LabelMet.Text = "Try again."
        attempts = attempts + 1
        Ans3 = False
        LabelAttemptsDesc.Text = attempts
    End Sub

    Private Sub FormTopic1Quiz_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LabelIg.Text = "Click a button above..."
        LabelMet.Text = "Click a button above..."
        LabelSed.Text = "Click a button above..."
        Ans1 = False
        Ans2 = False
        Ans3 = False
        attempts = 0
    End Sub

    Private Sub ButtonBack_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBack.Click
        Me.Hide()
        FormTopic1.Show()
    End Sub

    Private Sub ButtonSubmit_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSubmit.Click

        If Ans1 = True And Ans2 = True And Ans3 = True Then
            MsgBox("You passed the quiz! Congratulations " & FormTopics.username & "! It only took you " & attempts & " attempts to complete the quiz.", MsgBoxStyle.ApplicationModal, "Congratulations!")
            Me.Hide()
            FormTopics.Show()
        Else
            My.Computer.Audio.Play(My.Resources.ErrorSound, AudioPlayMode.WaitToComplete)
            MsgBox("Please finish answering the questions correctly.")
        End If
    End Sub
End Class