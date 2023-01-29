Imports System.Data.OleDb
Public Class frmemployee
    Dim ademployee As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim n As Integer
    Dim chrDBCommand As Char
    Private Sub frmemployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim cmemployee As New OleDbCommand
        cmemployee.Connection = con
        cmemployee.CommandText = "SELECT * from tblemployee"
        ademployee.SelectCommand = cmemployee
        ademployee.Fill(ds, "tblemployee")
        n = ds.Tables("tblemployee").Rows.Count - 1
        con.Close()
        showRecords()
    End Sub
    Sub showRecords()
        Dim dremployee As DataRow
        If n >= 0 Then
            dremployee = ds.Tables("tblemployee").Rows(n)
            With dremployee
                txtno.Text = .Item("EmpNo")
                txtname.Text = .Item("EmpName")
                txtid.Text = .Item("EmpId")
                txtaddress.Text = .Item("Address")
                txttel.Text = .Item("TelNo")
                txtdate.Text = .Item("Date1")
                txtnum.Text = .Item("NumOfTea")
                txtsalary.Text = .Item("Salary")
            End With
        End If
    End Sub
    Private Sub btnpreviews_Click(sender As Object, e As EventArgs) Handles btnpreviews.Click
        If n > 0 Then
            n = n - 1
            showRecords()
        End If
    End Sub
    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        If n < ds.Tables("tblemployee").Rows.Count - 1 Then
            n = n + 1
            showRecords()
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        chrDBCommand = "A"
        txtno.Focus()
        Call clearcontrols()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If n >= 0 Then
            chrDBCommand = "E"
            txtno.Focus()
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Dim cmBuilder As New OleDbCommandBuilder
        cmBuilder.DataAdapter = ademployee
        ds.Tables("tblemployee").Rows(n).Delete()
        ademployee.DeleteCommand = cmBuilder.GetDeleteCommand
        n = n - 1
        txtmsg.Text = "Data Delete succesfully...!"
        txtmsg.ForeColor = Color.Red
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim cmBuilder As New OleDbCommandBuilder
        cmBuilder.DataAdapter = ademployee
        If chrDBCommand = "A" Then
            If txtno.Text = "" Then
                MessageBox.Show("please enter data before saving..!")
            Else
                Dim dremployee As DataRow
                dremployee = ds.Tables("tblemployee").NewRow
                With dremployee
                    .Item("EmpNo") = txtno.Text
                    .Item("EmpName") = txtname.Text
                    .Item("EmpId") = txtid.Text
                    .Item("Address") = txtaddress.Text
                    .Item("TelNo") = txttel.Text
                    .Item("Date1") = txtdate.Text
                    .Item("NumOfTea") = txtnum.Text
                    .Item("Salary") = txtsalary.Text
                End With
                ds.Tables("tblemployee").Rows.Add(dremployee)
                ademployee.InsertCommand = cmBuilder.GetInsertCommand
                n = n + 1
                txtmsg.Text = "Data saving succesfully...!"
                txtmsg.ForeColor = Color.Blue
            End If
        ElseIf chrDBCommand = "E" Then
            Dim tbemployee As DataTable
            Dim dcprimary(0) As DataColumn
            tbemployee = ds.Tables("tblemployee")
            dcprimary(0) = tbemployee.Columns("EmpNo")
            tbemployee.PrimaryKey = dcprimary
            Dim dremp As DataRow = tbemployee.Rows.Find(txtno.Text)
            With dremp
                .Item("EmpNo") = txtno.Text
                .Item("EmpName") = txtname.Text
                .Item("EmpId") = txtid.Text
                .Item("Address") = txtaddress.Text
                .Item("TelNo") = txttel.Text
                .Item("Date1") = txtdate.Text
                .Item("NumOfTea") = txtnum.Text
                .Item("Salary") = txtsalary.Text
            End With
            ademployee.UpdateCommand = cmBuilder.GetUpdateCommand
            txtmsg.Text = "Data update  succesfully...!"
            txtmsg.ForeColor = Color.Blue
        End If
        con.Open()
            Try
                ademployee.Update(ds, "tblemployee")
                clearcontrols()
            Catch ex As Exception
                MessageBox.Show("you are tying to save data...!" & ex.Message)
            End Try
            con.Close()
        'End If
    End Sub
    Sub clearcontrols()
        txtno.Clear()
        txtname.Clear()
        txtid.Clear()
        txtaddress.Clear()
        txttel.Clear()
        'txtdate.Clear()
        txtnum.Clear()
        txtsalary.Clear()
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        txtno.Clear()
        txtname.Clear()
        txtid.Clear()
        txtaddress.Clear()
        txttel.Clear()
        'txtdate.Clear()
        txtnum.Clear()
        txtsalary.Clear()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btncal_Click(sender As Object, e As EventArgs) Handles btncal.Click
        Dim x, y, ans As Integer
        x = Val(txtnum.Text)
        y = 40
        ans = x * y
        txtsalary.Text = ans

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim tbemployee As DataTable
        Dim dcprimarykey(0) As DataColumn
        tbemployee = ds.Tables("tblemployee")
        dcprimarykey(0) = tbemployee.Columns("EmpNo")
        tbemployee.PrimaryKey = dcprimarykey

        Dim frmFind As New frmsearch
        Dim streNo As String

        frmFind.ShowDialog()

        streNo = frmFind.strstNo

        If Not streNo Is Nothing Then
            Dim dremployee As DataRow = tbemployee.Rows.Find(streNo)
            If Not dremployee Is Nothing Then
                With dremployee
                    txtno.Text = .Item("EmpNo")
                    txtname.Text = .Item("EmpName")
                    txtid.Text = .Item("EmpId")
                    txtaddress.Text = .Item("Address")
                    txttel.Text = .Item("TelNo")
                    txtdate.Text = .Item("Date1")
                    txtnum.Text = .Item("NumOfTea")
                    txtsalary.Text = .Item("Salary")
                End With
            Else
                MessageBox.Show("student not found....", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        frmReport.ShowDialog()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        frmHome.ShowDialog()
    End Sub
End Class
