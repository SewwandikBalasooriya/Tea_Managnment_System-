<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmemployee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdate = New System.Windows.Forms.DateTimePicker()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.txttel = New System.Windows.Forms.TextBox()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtmsg = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtsalary = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnpreviews = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btncal = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnreport = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnback = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdate)
        Me.GroupBox1.Controls.Add(Me.txtnum)
        Me.GroupBox1.Controls.Add(Me.txttel)
        Me.GroupBox1.Controls.Add(Me.txtaddress)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtno)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(591, 492)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Details"
        '
        'txtdate
        '
        Me.txtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate.Location = New System.Drawing.Point(231, 318)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.Size = New System.Drawing.Size(321, 28)
        Me.txtdate.TabIndex = 16
        '
        'txtnum
        '
        Me.txtnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnum.Location = New System.Drawing.Point(230, 382)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(322, 28)
        Me.txtnum.TabIndex = 13
        '
        'txttel
        '
        Me.txttel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttel.Location = New System.Drawing.Point(231, 258)
        Me.txttel.Name = "txttel"
        Me.txttel.Size = New System.Drawing.Size(322, 28)
        Me.txttel.TabIndex = 11
        '
        'txtaddress
        '
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.Location = New System.Drawing.Point(231, 201)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(322, 28)
        Me.txtaddress.TabIndex = 10
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(231, 148)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(322, 28)
        Me.txtid.TabIndex = 9
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(231, 91)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(322, 28)
        Me.txtname.TabIndex = 8
        '
        'txtno
        '
        Me.txtno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtno.Location = New System.Drawing.Point(231, 29)
        Me.txtno.Name = "txtno"
        Me.txtno.Size = New System.Drawing.Size(322, 28)
        Me.txtno.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 386)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Number Of Tea:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Employee Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(30, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Employee Id:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 262)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Telephone num:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee No"
        '
        'txtmsg
        '
        Me.txtmsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmsg.Location = New System.Drawing.Point(653, 620)
        Me.txtmsg.Name = "txtmsg"
        Me.txtmsg.Size = New System.Drawing.Size(480, 28)
        Me.txtmsg.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(154, 24)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Employee salary:"
        '
        'txtsalary
        '
        Me.txtsalary.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtsalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsalary.Location = New System.Drawing.Point(231, 68)
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.Size = New System.Drawing.Size(322, 28)
        Me.txtsalary.TabIndex = 12
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnadd.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnadd.Location = New System.Drawing.Point(713, 28)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(147, 53)
        Me.btnadd.TabIndex = 17
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btncancel.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btncancel.Location = New System.Drawing.Point(915, 213)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(147, 53)
        Me.btncancel.TabIndex = 18
        Me.btncancel.Text = "CANCEL"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnsave.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsave.Location = New System.Drawing.Point(713, 119)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(147, 53)
        Me.btnsave.TabIndex = 19
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnedit.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnedit.Location = New System.Drawing.Point(713, 213)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(147, 53)
        Me.btnedit.TabIndex = 20
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnpreviews
        '
        Me.btnpreviews.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnpreviews.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpreviews.Location = New System.Drawing.Point(793, 484)
        Me.btnpreviews.Name = "btnpreviews"
        Me.btnpreviews.Size = New System.Drawing.Size(97, 62)
        Me.btnpreviews.TabIndex = 21
        Me.btnpreviews.Text = "<"
        Me.btnpreviews.UseVisualStyleBackColor = False
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnnext.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.Location = New System.Drawing.Point(896, 484)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(97, 62)
        Me.btnnext.TabIndex = 22
        Me.btnnext.Text = ">"
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btndelete.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btndelete.Location = New System.Drawing.Point(713, 305)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(147, 53)
        Me.btndelete.TabIndex = 25
        Me.btndelete.Text = "DELETE"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnexit.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnexit.Location = New System.Drawing.Point(915, 305)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(147, 53)
        Me.btnexit.TabIndex = 26
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btncal
        '
        Me.btncal.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btncal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncal.Location = New System.Drawing.Point(713, 398)
        Me.btncal.Name = "btncal"
        Me.btncal.Size = New System.Drawing.Size(147, 53)
        Me.btncal.TabIndex = 27
        Me.btncal.Text = "SALARY"
        Me.btncal.UseVisualStyleBackColor = False
        '
        'btnsearch
        '
        Me.btnsearch.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnsearch.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsearch.Location = New System.Drawing.Point(915, 28)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(147, 53)
        Me.btnsearch.TabIndex = 28
        Me.btnsearch.Text = "SEARCH"
        Me.btnsearch.UseVisualStyleBackColor = False
        '
        'btnreport
        '
        Me.btnreport.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnreport.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnreport.Location = New System.Drawing.Point(915, 119)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(147, 53)
        Me.btnreport.TabIndex = 29
        Me.btnreport.Text = "REPORT"
        Me.btnreport.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtsalary)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 510)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(591, 158)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employee Salary"
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnback.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnback.Location = New System.Drawing.Point(915, 394)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(147, 53)
        Me.btnback.TabIndex = 30
        Me.btnback.Text = "BACK"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'frmemployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(1157, 680)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.txtmsg)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btncal)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnpreviews)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmemployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "employee"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtdate As DateTimePicker
    Friend WithEvents txtmsg As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtnum As TextBox
    Friend WithEvents txtsalary As TextBox
    Friend WithEvents txttel As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents txtno As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnpreviews As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents btncal As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents btnreport As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnback As Button
End Class
