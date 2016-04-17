<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderSearch
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
        Me.dtpOrderDateEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpOrderDateStart = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Start = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpShipDateEnd = New System.Windows.Forms.DateTimePicker()
        Me.dtpShipDateStart = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOrderNumber = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpOrderDateEnd)
        Me.GroupBox1.Controls.Add(Me.dtpOrderDateStart)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Start)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(281, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Date"
        '
        'dtpOrderDateEnd
        '
        Me.dtpOrderDateEnd.Location = New System.Drawing.Point(71, 53)
        Me.dtpOrderDateEnd.Name = "dtpOrderDateEnd"
        Me.dtpOrderDateEnd.Size = New System.Drawing.Size(200, 20)
        Me.dtpOrderDateEnd.TabIndex = 3
        '
        'dtpOrderDateStart
        '
        Me.dtpOrderDateStart.Location = New System.Drawing.Point(71, 20)
        Me.dtpOrderDateStart.Name = "dtpOrderDateStart"
        Me.dtpOrderDateStart.Size = New System.Drawing.Size(200, 20)
        Me.dtpOrderDateStart.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "End"
        '
        'Start
        '
        Me.Start.AutoSize = True
        Me.Start.Location = New System.Drawing.Point(10, 20)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(29, 13)
        Me.Start.TabIndex = 0
        Me.Start.Text = "Start"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpShipDateEnd)
        Me.GroupBox2.Controls.Add(Me.dtpShipDateStart)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(43, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(281, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ship Date"
        '
        'dtpShipDateEnd
        '
        Me.dtpShipDateEnd.Location = New System.Drawing.Point(71, 49)
        Me.dtpShipDateEnd.Name = "dtpShipDateEnd"
        Me.dtpShipDateEnd.Size = New System.Drawing.Size(200, 20)
        Me.dtpShipDateEnd.TabIndex = 3
        '
        'dtpShipDateStart
        '
        Me.dtpShipDateStart.Location = New System.Drawing.Point(71, 20)
        Me.dtpShipDateStart.Name = "dtpShipDateStart"
        Me.dtpShipDateStart.Size = New System.Drawing.Size(200, 20)
        Me.dtpShipDateStart.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "End"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Start"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Order Number"
        '
        'txtOrderNumber
        '
        Me.txtOrderNumber.Location = New System.Drawing.Point(148, 12)
        Me.txtOrderNumber.Name = "txtOrderNumber"
        Me.txtOrderNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtOrderNumber.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnSearch.Location = New System.Drawing.Point(249, 250)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frmOrderSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 281)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtOrderNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmOrderSearch"
        Me.Text = "frmOrderSearch"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtOrderNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpShipDateStart As DateTimePicker
    Friend WithEvents dtpShipDateEnd As DateTimePicker
    Friend WithEvents Start As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpOrderDateStart As DateTimePicker
    Friend WithEvents dtpOrderDateEnd As DateTimePicker
End Class
