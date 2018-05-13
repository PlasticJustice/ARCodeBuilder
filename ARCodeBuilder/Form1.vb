Public Class Form1
    Dim address As String
    Dim value As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        F2A.Hide()
        F2V.Hide()
    End Sub
    Private Sub F2A_Change(sender As Object, e As EventArgs) Handles F2A.TextChanged
        address = F2A.Text
    End Sub
    Private Sub F2V_Change(sender As Object, e As EventArgs) Handles F2V.TextChanged
        value = F2V.Text
    End Sub





    Private Function W32(ByVal adr As String, ByVal val As String)
1:
        If adr.Length < 7 Then
            adr = "0" & adr
            GoTo 1
        End If
        If val.Length < 8 Then
            val = "0" & val
            GoTo 1
        End If
        Dim output As String = "0" & adr & " " & val & "
"
        Return output
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim address As String = InputBox("What is the address?")
        'Dim value As String = InputBox("What is the value?")
        Dim F2 As New Form2
        Dim result = F2.ShowDialog
        'Dim address As String = F2A.Text
        'Dim value As String = F2V.Text
        Dim code As String = W32(address, value)
        RichTextBox1.Text = RichTextBox1.Text & code
    End Sub
End Class
