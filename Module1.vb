﻿Imports System.Data.OleDb
Module Module1
    Public con As New OleDbConnection
    Sub main()
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\sewwandika\tea1.mdb"
        Dim frmHome As New frmlogin
        frmHome.ShowDialog()
    End Sub

End Module
