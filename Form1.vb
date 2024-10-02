Public Class Calculadora

    Dim op As String
    Dim num1 As Double
    Dim num2 As Double
    Dim res As Double

    Private Sub colocarNum(numero As Integer)
        If (Resultado.Text = "0") Then
            Resultado.Text = numero
        Else
            Resultado.Text = Resultado.Text & numero
        End If
    End Sub

    Private Sub Bot0_Click(sender As Object, e As EventArgs) Handles Bot0.Click
        colocarNum(0)
    End Sub

    Private Sub Bot1_Click(sender As Object, e As EventArgs) Handles Bot1.Click
        colocarNum(1)
    End Sub

    Private Sub Bot2_Click(sender As Object, e As EventArgs) Handles Bot2.Click
        colocarNum(2)
    End Sub

    Private Sub Bot3_Click(sender As Object, e As EventArgs) Handles Bot3.Click
        colocarNum(3)
    End Sub

    Private Sub Bot4_Click(sender As Object, e As EventArgs) Handles Bot4.Click
        colocarNum(4)
    End Sub

    Private Sub Bot5_Click(sender As Object, e As EventArgs) Handles Bot5.Click
        colocarNum(5)
    End Sub

    Private Sub Bot6_Click(sender As Object, e As EventArgs) Handles Bot6.Click
        colocarNum(6)
    End Sub

    Private Sub Bot7_Click(sender As Object, e As EventArgs) Handles Bot7.Click
        colocarNum(7)
    End Sub

    Private Sub Bot8_Click(sender As Object, e As EventArgs) Handles Bot8.Click
        colocarNum(8)
    End Sub

    Private Sub Bot9_Click(sender As Object, e As EventArgs) Handles Bot9.Click
        colocarNum(9)
    End Sub

    Private Sub BotSomar_Click(sender As Object, e As EventArgs) Handles BotSomar.Click
        TxtOp.Text = "+"
        op = "+"
        TxtNum1.Text = Resultado.Text
        Resultado.Text = 0
    End Sub

    Private Sub BotSubtrair_Click(sender As Object, e As EventArgs) Handles BotSubtrair.Click
        TxtOp.Text = "-"
        op = "-"
        TxtNum1.Text = Resultado.Text
        Resultado.Text = 0
    End Sub

    Private Sub BotDividir_Click(sender As Object, e As EventArgs) Handles BotDividir.Click
        TxtOp.Text = "÷"
        op = "÷"
        TxtNum1.Text = Resultado.Text
        Resultado.Text = 0
    End Sub

    Private Sub BotMultiplicar_Click(sender As Object, e As EventArgs) Handles BotMultiplicar.Click
        TxtOp.Text = "x"
        op = "x"
        TxtNum1.Text = Resultado.Text
        Resultado.Text = 0
    End Sub

    Private Sub BotCalcular_Click(sender As Object, e As EventArgs) Handles BotCalcular.Click
        num1 = TxtNum1.Text
        num2 = Resultado.Text

        If op = "+" Then
            res = num1 + num2
        ElseIf op = "-" Then
            res = num1 - num2
        ElseIf op = "÷" Then
            res = num1 / num2
        ElseIf op = "x" Then
            res = num1 * num2
        End If

        Resultado.Text = res
        TxtNum1.Text = ""
        op = ""
        TxtOp.Text = op
    End Sub

    Private Sub BotBackspace_Click(sender As Object, e As EventArgs) Handles BotBackspace.Click
        Resultado.Text = Resultado.Text.Remove(Resultado.Text.Length - 1)
        If Resultado.Text = "" Then
            Resultado.Text = "0"
        End If
    End Sub

    Private Sub botPonto_Click(sender As Object, e As EventArgs) Handles botPonto.Click
        If InStr(Resultado.Text, ".") = 0 Then
            Resultado.Text = Resultado.Text & ","
        End If
    End Sub

    Private Sub BotClean_Click(sender As Object, e As EventArgs) Handles BotClean.Click
        Resultado.Text = "0"
        TxtOp.Text = ""
        TxtNum1.Text = ""
    End Sub

    Private Sub botInverter_Click(sender As Object, e As EventArgs) Handles botInverter.Click
        Dim multiresultado As Double
        Dim multinum1 As Double
        multinum1 = TxtNum1.Text * 2
        multiresultado = Resultado.Text * 2
        If Resultado.Text = "0" Then
            TxtNum1.Text = TxtNum1.Text - multinum1
        Else
            Resultado.Text = Resultado.Text - multiresultado
        End If
    End Sub
End Class
