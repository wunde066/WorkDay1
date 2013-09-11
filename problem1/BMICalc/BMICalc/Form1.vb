Option Strict On

Public Class Form1

    Private Sub btnCalcBMI_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcBMI.Click
        Dim hst As String
        Dim wst As String


        hst = txtHeight.Text
        wst = txtWeight.Text

        Dim h As Double
        Dim w As Double

        h = CDbl(hst)
        w = CDbl(wst)

        Dim bmi As Double
        bmi = (w * 703) / (h ^ 2)

        TextBox1.Text = CStr(bmi)




    End Sub
End Class
