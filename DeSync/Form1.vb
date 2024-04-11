Public Class Form1
    Private Function GetFloatValue(TB As TextBox) As Double
        Return If(TB.Text.Length > 0, CDbl(TB.Text), 0.0)
    End Function

    Private Sub UI_TextChanged(sender As Object, e As EventArgs) Handles UI.TextChanged, M.TextChanged, AT1.TextChanged, AT2.TextChanged, AT3.TextChanged, AT4.TextChanged, K1.TextChanged, K2.TextChanged, K3.TextChanged, K4.TextChanged
        Dim UIv As Single = If(UI.Text.Length > 0, CDbl(UI.Text), 0.0)
        Dim At = {AT1, AT2, AT3, AT4}.Select(AddressOf GetFloatValue)
        Dim K = {K1, K2, K3, K4}.Select(AddressOf GetFloatValue)
        Dim Misc = {UI, M}.Select(AddressOf GetFloatValue)
        D.Text = (Misc(0) * (At.Sum) / (K.Sum) * Misc(1) * 100.0).ToString("F4")
    End Sub
End Class
