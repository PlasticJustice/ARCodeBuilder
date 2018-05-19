Public Class Form1
    Dim address As String
    Dim value As String
    Dim vl As Integer
    Dim ct As String

    Dim addr As String
    Dim valu As String
    Dim W32 As String


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
    Private Sub RichTextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RichTextBox1.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                If Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 70 Then
                    If Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 102 Then
                        e.Handled = True
                    End If
                End If
            End If
        End If
    End Sub




    Private Function ac(ByVal adr As String, ByVal val As String)
1:
        If adr.Length < 7 Then
            adr = "0" & adr
            GoTo 1
        End If
        If val.Length < 8 Then
            val = "0" & val
            GoTo 1
        End If
        Dim output As String = ct & adr & " " & val & "
"
        Return output
    End Function
#Region "Buttons"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        vl = 8
        ct = "0"
        Dim F2 As New Form2(vl)
        Dim result = F2.ShowDialog
        Dim code As String = ac(address, value)
        RichTextBox1.Text = RichTextBox1.Text & code
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        vl = 4
        ct = "1"
        Dim F2 As New Form2(vl)
        Dim result = F2.ShowDialog
        Dim code As String = ac(address, value)
        RichTextBox1.Text = RichTextBox1.Text & code
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        vl = 2
        ct = "2"
        Dim F2 As New Form2(vl)
        Dim result = F2.ShowDialog
        Dim code As String = ac(address, value)
        RichTextBox1.Text = RichTextBox1.Text & code
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        vl = 8
        ct = "3"
        Dim F2 As New Form2(vl)
        Dim result = F2.ShowDialog
        Dim code As String = ac(address, value)
        RichTextBox1.Text = RichTextBox1.Text & code
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        vl = 8
        ct = "4"
        Dim F2 As New Form2(vl)
        Dim result = F2.ShowDialog
        Dim code As String = ac(address, value)
        RichTextBox1.Text = RichTextBox1.Text & code
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        vl = 8
        ct = "5"
        Dim F2 As New Form2(vl)
        Dim result = F2.ShowDialog
        Dim code As String = ac(address, value)
        RichTextBox1.Text = RichTextBox1.Text & code
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        vl = 8
        ct = "6"
        Dim F2 As New Form2(vl)
        Dim result = F2.ShowDialog
        Dim code As String = ac(address, value)
        RichTextBox1.Text = RichTextBox1.Text & code
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        vl = 4
        ct = "7"
        Dim F2 As New Form2(vl)
        Dim result = F2.ShowDialog
        Dim code As String = ac(address, value)
        RichTextBox1.Text = RichTextBox1.Text & code
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        vl = 4
        ct = "8"
        Dim F2 As New Form2(vl)
        Dim result = F2.ShowDialog
        Dim code As String = ac(address, value)
        RichTextBox1.Text = RichTextBox1.Text & code
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        vl = 4
        ct = "9"
        Dim F2 As New Form2(vl)
        Dim result = F2.ShowDialog
        Dim code As String = ac(address, value)
        RichTextBox1.Text = RichTextBox1.Text & code
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        vl = 4
        ct = "A"
        Dim F2 As New Form2(vl)
        Dim result = F2.ShowDialog
        Dim code As String = ac(address, value)
        RichTextBox1.Text = RichTextBox1.Text & code
    End Sub

    '    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
    '        Dim w As String
    '        Dim w2 As String()
    '        Dim arc As String() = RichTextBox1.Text.Split("
    '")
    '        For i = 0 To UBound(arc) Step 1
    '            If arc(i).Length < 17 Then
    '            ElseIf arc(i).Length = 17 Then
    '                RichTextBox1.Text = RichTextBox1.Text & "
    '"
    '                If arc(i).StartsWith("0") Then
    '                    w = arc(i).Replace("0", "")
    '                    w2 = w.Split(" ")
    '                    addr = w2(LBound(w2))
    '                    valu = w2(UBound(w2))
    '                    valu = valu.Remove(valu.Length - 1, 1)
    '                    W32 = "Write 32bit value of " & valu & " to " & addr & "
    '"
    '                    RichTextBox2.Text = RichTextBox2.Text & W32
    '                ElseIf arc(i).StartsWith("1") Then
    '                    w = arc(i).Replace("0", "")
    '                    w = w.Replace("1", "")
    '                    w2 = w.Split(" ")
    '                    addr = w2(LBound(w2))
    '                    valu = w2(UBound(w2))
    '                    'valu = valu.Remove(valu.Length - 1, 1)
    '                    W32 = "Write 32bit value of " & valu & " to " & addr & "
    '"
    '                    RichTextBox2.Text = RichTextBox2.Text & W32
    '                End If
    '            Else
    '            End If
    '        Next i
    '    End Sub



#End Region
End Class
