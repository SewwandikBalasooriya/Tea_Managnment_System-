Public Class frmReport
    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'tea1DataSet1.tblemployee' table. You can move, or remove it, as needed.
        Me.tblemployeeTableAdapter.Fill(Me.tea1DataSet1.tblemployee)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class