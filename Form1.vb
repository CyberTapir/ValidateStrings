Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim validateText As String
        validateText = TextBox1.Text
        ListBox1.Items.Add(IsValidCode(validateText))
    End Sub
    Function IsValidCode(code As String) As Boolean
        If code.Length <> 5 Then
            Return False
        End If

        If Not Char.IsLetter(code(0)) OrElse Not Char.IsLetter(code(4)) Then
            Return False
        End If

        If Not Char.IsDigit(code(1)) OrElse Not Char.IsDigit(code(2)) OrElse Not Char.IsDigit(code(3)) Then
            Return False
        End If

        Dim firstLetter As Char = code(0)
        Dim lastLetter As Char = code(4)

        If firstLetter < "A"c OrElse firstLetter > "P"c OrElse firstLetter = "I"c OrElse firstLetter = "O"c Then
            Return False
        End If

        If lastLetter < "A"c OrElse lastLetter > "P"c OrElse lastLetter = "I"c OrElse lastLetter = "O"c Then
            Return False
        End If

        Return True
    End Function

End Class
