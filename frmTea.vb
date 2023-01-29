Imports System.Data.OleDb
Public Class frmtea
    Dim ademployee As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim n As Integer
    Dim chrDBCommand As Char
    Private Sub frmtea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Open()
        Dim cmemployee As New OleDbCommand
        cmemployee.Connection = con
        cmemployee.CommandText = "SELECT * from tbltea"
        ademployee.SelectCommand = cmemployee
        ademployee.Fill(ds, "tbltea")
        n = ds.Tables("tbltea").Rows.Count - 1
        con.Close()
        showRecords()
    End Sub
    Sub showRecords()
        Dim dremployee As DataRow
        If n >= 0 Then
            dremployee = ds.Tables("tbltea").Rows(n)
            With dremployee
                txtno.Text = .Item("EmpNo")
                txtname.Text = .Item("EmpName")
                txtdate.Text = .Item("Date1")
                txtnum.Text = .Item("NumOfTea")
                txtsalar.Text = .Item("Salary")
                txtT_num.Text = .Item("T_Total")
                txtT_salary.Text = .Item("S_Total")
            End With
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
        ds.Tables("tbltea").Rows(n).Delete()
        ademployee.DeleteCommand = cmBuilder.GetDeleteCommand
        n = n - 1
        txtMsg.Text = "Data Delete succesfully...!"
        txtMsg.ForeColor = Color.Red
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim cmBuilder As New OleDbCommandBuilder
        cmBuilder.DataAdapter = ademployee
        If chrDBCommand = "A" Then
            If txtno.Text = "" Then
                MessageBox.Show("please enter data before saving..!")
            Else
                Dim drtea As DataRow
                drtea = ds.Tables("tbltea").NewRow
                With drtea
                    .Item("EmpNo") = txtno.Text
                    .Item("EmpName") = txtname.Text
                    .Item("Date1") = txtdate.Text
                    .Item("NumOfTea") = txtnum.Text
                    .Item("Salary") = txtsalar.Text
                    .Item("T_Total") = txtT_num.Text
                    .Item("S_Total") = txtT_salary.Text
                End With
                ds.Tables("tbltea").Rows.Add(drtea)
                ademployee.InsertCommand = cmBuilder.GetInsertCommand
                n = n + 1
                txtMsg.Text = "Data saving succesfully...!"
                txtMsg.ForeColor = Color.Blue
            End If
        ElseIf chrDBCommand = "E" Then
            Dim tbemployee As DataTable
            Dim dcprimary(0) As DataColumn
            tbemployee = ds.Tables("tbltea")
            dcprimary(0) = tbemployee.Columns("EmpNo")
            tbemployee.PrimaryKey = dcprimary
            Dim dremp As DataRow = tbemployee.Rows.Find(txtno.Text)
            With dremp
                .Item("EmpNo") = txtno.Text
                .Item("EmpName") = txtname.Text
                .Item("Date1") = txtdate.Text
                .Item("NumOfTea") = txtnum.Text
                .Item("Salary") = txtsalar.Text
                .Item("T_Total") = txtT_num.Text
                .Item("S_Total") = txtT_salary.Text
            End With
            ademployee.UpdateCommand = cmBuilder.GetUpdateCommand
            txtMsg.Text = "Data update  succesfully...!"
            txtMsg.ForeColor = Color.Blue
        End If
        con.Open()
        Try
            ademployee.Update(ds, "tbltea")
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
        txtnum.Clear()
        txtsalar.Clear()
    End Sub

    Private Sub btncal_Click(sender As Object, e As EventArgs) Handles btncal.Click
        Dim x, y, ans As Integer
        Dim z, p, ans1 As Integer

        x = Val(txtT_num.Text)
            y = Val(txtnum.Text)
            ans = x + y
        txtT_num.Text = ans
        z = Val(txtsalar.Text)
        p = Val(txtT_salary.Text)
        ans1 = z + p
        txtT_salary.Text = ans1


    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnsalary_Click(sender As Object, e As EventArgs) Handles btnsalary.Click
        Dim q, w, ans2 As Integer
        q = txtnum.Text
        w = 40
        ans2 = q * w
        txtsalar.Text = ans2
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        txtno.Clear()
        txtname.Clear()
        'txtdate.Clear()
        txtnum.Clear()
        txtsalar.Clear()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        frmHome.ShowDialog()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        If n < ds.Tables("tbltea").Rows.Count - 1 Then
            n = n + 1
            showRecords()
        End If
    End Sub

    Private Sub btnpreviews_Click(sender As Object, e As EventArgs) Handles btnpreviews.Click
        If n > 0 Then
            n = n - 1
            showRecords()
        End If
    End Sub
End Class