Public Class Form3
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t As String = RichTextBox1.Text.Replace("
", "")
        Dim t2 = t.Replace(" ", "")
        Dim le As Integer = t2.Length
        Dim l As Boolean = False
        Debug.Print(t2.Length)
        For i = 8 To le + (le / 6) Step 8
            If l = False Then
                t2 = t2.Insert(i, " ")
                i = i + 1
                'le = le + 1
                l = True
            ElseIf l = True Then
                t2 = t2.Insert(i, "
")
                i = i + 2
                'le = le + 1
                l = False
            End If
        Next i
        RichTextBox1.Text = t2

    End Sub
End Class