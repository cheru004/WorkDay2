﻿Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largerNum As Double

        Dim st1 As String = txtFirstNum.Text
        Dim st2 As String = txtSecondNum.Text

        num1 = CDbl(st1)
        num2 = CDbl(st2)

        ' Your code here

        txtResult.Text = "Wish I had more time"
    End Sub

    Private Sub txtFirstNum_TextChanged(sender As Object, e As EventArgs) Handles txtFirstNum.TextChanged

    End Sub
End Class
