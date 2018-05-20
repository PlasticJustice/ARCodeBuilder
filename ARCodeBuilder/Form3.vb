Public Class Form3
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t As String = RichTextBox1.Text
        Dim t2 = t.Replace(" ", "")
        For i = 8 To t2.Length Step 8
            t2 = t2.Insert(i, " ")
            i = i + 1
        Next i
        RichTextBox1.Text = t2

    End Sub
End Class