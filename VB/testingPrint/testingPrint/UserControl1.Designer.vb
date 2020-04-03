<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class data
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.titleLBL = New System.Windows.Forms.Label()
        Me.invoiceControl = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cashierNMLBL = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cashLBL = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.totalPrice = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.invoiceControl.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'titleLBL
        '
        Me.titleLBL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.titleLBL.AutoSize = True
        Me.titleLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLBL.Location = New System.Drawing.Point(3, 15)
        Me.titleLBL.Margin = New System.Windows.Forms.Padding(3, 15, 3, 20)
        Me.titleLBL.Name = "titleLBL"
        Me.titleLBL.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.titleLBL.Size = New System.Drawing.Size(122, 23)
        Me.titleLBL.TabIndex = 0
        Me.titleLBL.Text = "SEASONAL WAFFLE"
        Me.titleLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'invoiceControl
        '
        Me.invoiceControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.invoiceControl.Controls.Add(Me.titleLBL)
        Me.invoiceControl.Controls.Add(Me.Label1)
        Me.invoiceControl.Controls.Add(Me.cashierNMLBL)
        Me.invoiceControl.Controls.Add(Me.Panel1)
        Me.invoiceControl.Location = New System.Drawing.Point(0, 0)
        Me.invoiceControl.Name = "invoiceControl"
        Me.invoiceControl.Size = New System.Drawing.Size(150, 384)
        Me.invoiceControl.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CASHIER:"
        '
        'cashierNMLBL
        '
        Me.cashierNMLBL.AutoSize = True
        Me.cashierNMLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.cashierNMLBL.Location = New System.Drawing.Point(68, 58)
        Me.cashierNMLBL.Margin = New System.Windows.Forms.Padding(3, 0, 3, 15)
        Me.cashierNMLBL.Name = "cashierNMLBL"
        Me.cashierNMLBL.Size = New System.Drawing.Size(39, 13)
        Me.cashierNMLBL.TabIndex = 1
        Me.cashierNMLBL.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.cashLBL)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.totalPrice)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(3, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(144, 41)
        Me.Panel1.TabIndex = 4
        '
        'cashLBL
        '
        Me.cashLBL.AutoSize = True
        Me.cashLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.cashLBL.Location = New System.Drawing.Point(49, 17)
        Me.cashLBL.Margin = New System.Windows.Forms.Padding(3, 0, 3, 15)
        Me.cashLBL.Name = "cashLBL"
        Me.cashLBL.Size = New System.Drawing.Size(39, 13)
        Me.cashLBL.TabIndex = 6
        Me.cashLBL.Text = "Label1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 1, 3, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "CASH:"
        '
        'totalPrice
        '
        Me.totalPrice.AutoSize = True
        Me.totalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.totalPrice.Location = New System.Drawing.Point(51, 1)
        Me.totalPrice.Margin = New System.Windows.Forms.Padding(3, 0, 3, 15)
        Me.totalPrice.Name = "totalPrice"
        Me.totalPrice.Size = New System.Drawing.Size(39, 13)
        Me.totalPrice.TabIndex = 4
        Me.totalPrice.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 1)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 1, 3, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "TOTAL:"
        '
        'data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.invoiceControl)
        Me.Name = "data"
        Me.Size = New System.Drawing.Size(150, 384)
        Me.invoiceControl.ResumeLayout(False)
        Me.invoiceControl.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents titleLBL As Label
    Friend WithEvents invoiceControl As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents cashierNMLBL As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents totalPrice As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cashLBL As Label
    Friend WithEvents Label3 As Label
End Class
