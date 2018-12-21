Public Class Form1
    Public tx As String
    Private Sub add(txt As String)
        tx = tx + txt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        NumericUpDown1.Enabled = False
        CheckBox1.Enabled = False

        Dim i As Integer = 0
        Dim ix As Integer = 0
        Dim totalLines As Integer = TextBox1.Lines.Count
        Dim accountsInIndex As Integer
        If CheckBox1.Checked Then
            accountsInIndex = TextBox1.Lines.Count + 1
        Else
            accountsInIndex = NumericUpDown1.Value
        End If


        tx = Nothing

        add("{'indexes':[" + vbNewLine)
        For Each s As String In TextBox1.Lines
            Dim data As String() = s.Split(New Char() {":"c})

            If i = 0 Then add("    {'accounts': [" + vbNewLine)

            i += 1
            ix += 1

            add("        {'username': '" + data(0) + "','password': '" + data(1) + "'}")

            If Not ix = TextBox1.Lines.Count And Not i = accountsInIndex Then add(",")
            If i = accountsInIndex Then
                add(vbNewLine + "    ]},")
                i = 0
            End If
            If ix = TextBox1.Lines.Count And i = accountsInIndex Then add(",")

            add(vbNewLine)

        Next
        If i = accountsInIndex Then add("]")
        add("    ]}" + vbNewLine)
        add("]}")
        TextBox2.Text = tx

        TextBox1.Enabled = True
        TextBox2.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        NumericUpDown1.Enabled = True
        CheckBox1.Enabled = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            NumericUpDown1.Enabled = False
        Else
            NumericUpDown1.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clipboard.SetText(TextBox2.Text)
    End Sub
End Class
