Imports System.Data.OleDb
Public Class frmlogin
    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        con.Open()
        Dim cmuser As New OleDbCommand
        Dim aduser As New OleDbDataAdapter
        Dim ds As New DataSet
        Dim n As Integer = 0
        cmuser.Connection = con
        cmuser.CommandText =
            "SELECT*from tbluser where username like '%" _
            & txtusername.Text.ToString & "%' AND  password like '%" _
            & txtMsg.Text.ToString & "%'"
        aduser.SelectCommand = cmuser
        aduser.Fill(ds, "tbluser")
        n = ds.Tables("tbluser").Rows.Count
        con.Close()
        If n = 1 Then
            Dim frmHome As New frmHome
            frmHome.ShowDialog()
            Me.Close()
        Else
            MessageBox.Show("user name and password incorrect")
        End If
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        txtusername.Clear()
        txtpassword.Clear()
    End Sub
End Class