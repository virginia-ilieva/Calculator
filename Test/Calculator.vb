Public Class Calculator

    Dim FirstNumber As Single
    Dim SecondNumber As Single
    Dim AnswerNumber As Single
    Dim ArithmeticProcess As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        removeZero()
        TextBox1.Text = TextBox1.Text & 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        removeZero()
        TextBox1.Text = TextBox1.Text & 2
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        removeZero()
        TextBox1.Text = TextBox1.Text & 3
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        removeZero()
        TextBox1.Text = TextBox1.Text & 4
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        removeZero()
        TextBox1.Text = TextBox1.Text & 5
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        removeZero()
        TextBox1.Text = TextBox1.Text & 6
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        removeZero()
        TextBox1.Text = TextBox1.Text & 7
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        removeZero()
        TextBox1.Text = TextBox1.Text & 8
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        removeZero()
        TextBox1.Text = TextBox1.Text & 9
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        removeZero()
        TextBox1.Text = TextBox1.Text & 0
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text & "."
    End Sub

    Private Sub Button12_Click(ByVal Sender As Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox1.Text = "0"
        FirstNumber = 0
        SecondNumber = 0
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        FirstNumber = Val(TextBox1.Text)
        TextBox1.Text = "0"
        ArithmeticProcess = "+"
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click


        FirstNumber = Val(TextBox1.Text)
        TextBox1.Text = "0"
        ArithmeticProcess = "-"
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        FirstNumber = Val(TextBox1.Text)
        TextBox1.Text = "0"
        ArithmeticProcess = "X"
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        FirstNumber = Val(TextBox1.Text)
        TextBox1.Text = "0"
        ArithmeticProcess = "/"
    End Sub

    Private Sub Button17_Click(ByVal Sender As Object, ByVal e As System.EventArgs) Handles Button17.Click
        If TextBox1.Text.Length = 1 Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        SecondNumber = Val(TextBox1.Text)
        Select Case ArithmeticProcess
            Case "+"
                AnswerNumber = FirstNumber + SecondNumber
            Case "-"
                AnswerNumber = FirstNumber - SecondNumber
            Case "X"
                AnswerNumber = FirstNumber * SecondNumber
            Case "/"
                AnswerNumber = FirstNumber / SecondNumber
        End Select
        TextBox1.Text = AnswerNumber
    End Sub

    Private Sub removeZero()
        If TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
    End Sub

End Class