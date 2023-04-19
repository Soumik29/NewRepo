Imports Microsoft.Office.Interop.Excel

Public Class CreateQuestion
    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'Create_Quiz.quizNameTxtBox
        Dim createAnotherQuestion As New CreateQuestion
        Me.Hide()
        Dim filePath As String = "C:\Users\SOUMIK\OneDrive\Documents\" + Create_Quiz.quizNameTxtBox + ".xls"
        Dim xlApp As New Application
        Dim xlWorkbook As Workbook = xlApp.Workbooks.Open(filePath)
        Dim worksheet As Worksheet = CType(xlWorkbook.Sheets(1), Worksheet)
        createAnotherQuestion.ShowDialog()
        Me.Show()

        xlWorkbook.Save()
        xlWorkbook.Close()

        xlApp.Quit()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtQuestionInput_TextChanged(sender As Object, e As EventArgs) Handles txtQuestionInput.TextChanged

    End Sub

    Private Sub txtAnswerInput_TextChanged(sender As Object, e As EventArgs) Handles txtAnswerInput.TextChanged

    End Sub

    Private Sub CreateQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class