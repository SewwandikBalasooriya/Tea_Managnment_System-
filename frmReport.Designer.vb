<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tblemployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tea1DataSet1 = New project.tea1DataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tblemployeeTableAdapter = New project.tea1DataSet1TableAdapters.tblemployeeTableAdapter()
        CType(Me.tblemployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tea1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblemployeeBindingSource
        '
        Me.tblemployeeBindingSource.DataMember = "tblemployee"
        Me.tblemployeeBindingSource.DataSource = Me.tea1DataSet1
        '
        'tea1DataSet1
        '
        Me.tea1DataSet1.DataSetName = "tea1DataSet1"
        Me.tea1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BackColor = System.Drawing.Color.LightCyan
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tblemployeeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "project.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(2)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(919, 559)
        Me.ReportViewer1.TabIndex = 0
        '
        'tblemployeeTableAdapter
        '
        Me.tblemployeeTableAdapter.ClearBeforeFill = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 559)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        CType(Me.tblemployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tea1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tblemployeeBindingSource As BindingSource
    Friend WithEvents tea1DataSet1 As tea1DataSet1
    Friend WithEvents tblemployeeTableAdapter As tea1DataSet1TableAdapters.tblemployeeTableAdapter
End Class
