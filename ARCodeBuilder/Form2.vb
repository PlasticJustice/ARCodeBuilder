Public Class Form2
    Public Sub New(ByVal vl As Integer)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        TextBox2.MaxLength = vl
        Button1.Enabled = False
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

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
    Private Sub TB1_ch(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            Button1.Enabled = True
        End If
    End Sub
    Private Sub TB2_ch(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox1.Text <> "" And TextBox2.Text <> "" Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form1.F2A.Text = TextBox1.Text.ToUpper
        Form1.F2V.Text = TextBox2.Text.ToUpper
        Close()
    End Sub
End Class