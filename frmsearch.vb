Public Class frmsearch
    Public strstNo As String

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        strstNo = txtsearch.Text
        Me.Close()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        txtsearch.Clear()
    End Sub
End Class