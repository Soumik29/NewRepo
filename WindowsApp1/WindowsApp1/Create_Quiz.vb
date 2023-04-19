Imports System.Drawing.Text
Imports System.IO
Imports Microsoft.Office.Interop
Public Class Create_Quiz
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public quizNameTxtBox As String

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        Dim xlApp As Excel.Application = New Microsoft.Office.Interop.Excel.Application()
        If xlApp Is Nothing Then
            MessageBox.Show("Excel is not properly installed!")
            Return
        End If
        quizNameTxtBox = txtQuizName.Text
        Dim createQuizQuestion As New CreateQuestion
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        If File.Exists(quizNameTxtBox + ".xls") Then
            File.Delete(quizNameTxtBox + ".xls")
            createQuizQuestion.ShowDialog()
        Else
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = CType(xlWorkBook.Sheets("sheet1"), Excel.Worksheet)
            xlWorkSheet.Cells(1, 1) = ""
            xlWorkBook.SaveAs("" & quizNameTxtBox & ".xls",
                              Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
                              Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue,
                              misValue, misValue)
            xlWorkBook.Close(True, misValue, misValue)
            xlApp.Quit()

            releaseObject(xlWorkSheet)
            releaseObject(xlWorkBook)
            releaseObject(xlApp)

            MessageBox.Show("Excel file created, you can find the file under This PC\Documents\" & quizNameTxtBox & ".xls")
        End If
        Me.Hide()
        createQuizQuestion.ShowDialog()
        Me.Show()
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtQuizName.TextChanged

    End Sub
End Class