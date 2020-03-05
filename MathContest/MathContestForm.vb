Public Class MathContestForm
    Private Sub AgeBox_TextChanged(sender As Object, e As EventArgs) Handles AgeBox.Leave
        Dim ageNumber As Integer

        Try
            ageNumber = CInt(AgeBox.Text)
            If ageNumber >= 7 And ageNumber <= 11 Then
                MsgBox("Welcome to the Math Contest")
            ElseIf ageNumber < 7 And ageNumber > 11 Then
                MsgBox("Student not eligible to complete")
            End If
        Catch ex As Exception
            MsgBox("Please enter valid age")


        End Try
    End Sub
End Class
