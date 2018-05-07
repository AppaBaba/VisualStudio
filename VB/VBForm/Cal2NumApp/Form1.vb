Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        Dim FN, SN, Ans As Double
        FN = FNum.Text
        SN = SNum.Text
        Ans = FN + SN
        ANum.Text = Ans
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubButton.Click
        Dim FN, SN, Ans As Double
        FN = FNum.Text
        SN = SNum.Text
        Ans = FN - SN
        ANum.Text = Ans
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MulButton.Click
        Dim FN, SN, Ans As Double
        FN = FNum.Text
        SN = SNum.Text
        Ans = FN * SN
        ANum.Text = Ans
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DivButton.Click
        Dim FN, SN, Ans As Double
        FN = FNum.Text
        SN = SNum.Text
        Ans = FN / SN
        ANum.Text = Ans
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
