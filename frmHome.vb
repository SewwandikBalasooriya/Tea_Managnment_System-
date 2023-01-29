Public Class frmHome
    Private Sub btndetails_Click(sender As Object, e As EventArgs) Handles btndetails.Click
        frmemployee.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmtea.ShowDialog()
    End Sub
End Class