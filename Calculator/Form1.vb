﻿Public Class Form1
    Dim y As String
    Dim x, z As Integer
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        y = Button17.Text
        x = Val(TextBox1.Text)
        TextBox1.Text = ""
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + Button2.Text
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + Button3.Text
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + Button4.Text
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        y = Button14.Text
        x = Val(TextBox1.Text)
        TextBox1.Text = ""
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + Button5.Text
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + Button6.Text
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + Button7.Text
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        y = Button15.Text
        x = Val(TextBox1.Text)
        TextBox1.Text = ""
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + Button8.Text
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + Button9.Text
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text + Button10.Text
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        y = Button16.Text
        x = Val(TextBox1.Text)
        TextBox1.Text = ""
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text + Button11.Text
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = TextBox1.Text + Button12.Text
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If y = "+" Then
            TextBox1.Text = Val(TextBox1.Text) + x
        ElseIf y = "-" Then
            TextBox1.Text = x - Val(TextBox1.Text)
        ElseIf y = "*" Then
            TextBox1.Text = Val(TextBox1.Text) * x
        ElseIf y = "/" Then
            TextBox1.Text = x / Val(TextBox1.Text)
        ElseIf y = "F" Then
            TextBox1.Text = (x * 9 / 5) + 32
        ElseIf y = "x^y" Then
            Dim i As Integer
            z = Val(TextBox1.Text)
            Dim w As Integer = x
            For i = 2 To z
                x = x * w
            Next i
            TextBox1.Text = x
        Else
            TextBox1.Text = ""
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        y = Button21.Text
        x = Val(TextBox1.Text)
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Text = Math.Sqrt(Val(TextBox1.Text))
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        TextBox1.Text = Val((TextBox1.Text * 3.14) / 180)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        y = Button20.Text
        x = TextBox1.Text
        TextBox1.Text = ""

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox1.Text = Math.Cos(Val(TextBox1.Text))
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        TextBox1.Text = TextBox1.Text + Button25.Text
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        TextBox1.Text = Math.Tan(Val(TextBox1.Text))
    End Sub
End Class
