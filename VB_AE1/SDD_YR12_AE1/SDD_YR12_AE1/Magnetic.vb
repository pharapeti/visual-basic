Public Class Magnetic

    Dim Ans1 As Boolean
    Dim Ans2 As Boolean
    Dim Ans3 As Boolean


    Private Sub ButtonClose_Click(sender As System.Object, e As System.EventArgs) Handles ButtonClose.Click
        Me.Hide()
    End Sub

    Private Sub Magnetic_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Labelq1.Visible = False
        Labelq2.Visible = False
        Labelq3.Visible = False
    End Sub

    Private Sub Buttonq1a_Click(sender As System.Object, e As System.EventArgs) Handles Buttonq1a.Click
        My.Computer.Audio.Play(My.Resources.ErrorSound, AudioPlayMode.WaitToComplete)
        Labelq1.Visible = True
        Labelq1.Text = "Incorrect"
        Labelq1.BackColor = Color.OrangeRed
        Ans1 = False
    End Sub

    Private Sub Buttonq1b_Click(sender As System.Object, e As System.EventArgs) Handles Buttonq1b.Click
        Labelq1.Visible = True
        Labelq1.Text = "Correct"
        Labelq1.BackColor = Color.Lime
        Ans1 = True
    End Sub

    Private Sub Buttonq2a_Click(sender As System.Object, e As System.EventArgs) Handles Buttonq2a.Click
        Labelq2.Visible = True
        Labelq2.Text = "Correct"
        Labelq2.BackColor = Color.Lime
        Ans2 = True
    End Sub

    Private Sub Buttonq2b_Click(sender As System.Object, e As System.EventArgs) Handles Buttonq2b.Click
        My.Computer.Audio.Play(My.Resources.ErrorSound, AudioPlayMode.WaitToComplete)
        Labelq2.Visible = True
        Labelq2.Text = "Incorrect"
        Labelq2.BackColor = Color.OrangeRed
        Ans2 = False
    End Sub

    Private Sub Buttonq3a_Click(sender As System.Object, e As System.EventArgs) Handles Buttonq3a.Click
        My.Computer.Audio.Play(My.Resources.ErrorSound, AudioPlayMode.WaitToComplete)
        Labelq3.Visible = True
        Labelq3.Text = "Incorrect"
        Labelq3.BackColor = Color.OrangeRed
        Ans3 = False
    End Sub

    Private Sub Buttonq3b_Click(sender As System.Object, e As System.EventArgs) Handles Buttonq3b.Click
        Labelq3.Visible = True
        Labelq3.Text = "Correct"
        Labelq3.BackColor = Color.Lime
        Ans3 = True
    End Sub

    Private Sub ButtonSubmit_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSubmit.Click
        If Ans1 = True And Ans2 = True And Ans3 = True Then
            MsgBox("You passed the quiz! Congratulations " & FormTopics.username & "!", MsgBoxStyle.ApplicationModal, "Congratulations!")
            Me.Hide()
        Else
            My.Computer.Audio.Play(My.Resources.ErrorSound, AudioPlayMode.WaitToComplete)
            MsgBox("Please finish answering the questions correctly.")
        End If

    End Sub
End Class