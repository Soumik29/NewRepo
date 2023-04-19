Public Class MainForm
    Private Sub btnCreateQuiz_Click(sender As Object, e As EventArgs) Handles btnCreateQuiz.Click
        Dim frmCreateQuiz As New Create_Quiz
        Me.Hide()
        frmCreateQuiz.ShowDialog()
        Me.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnTryQuiz_Click(sender As Object, e As EventArgs) Handles btnTryQuiz.Click

    End Sub
End Class
