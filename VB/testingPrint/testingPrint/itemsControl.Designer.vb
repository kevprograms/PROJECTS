<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class itemsControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.itemLBL = New System.Windows.Forms.Label()
        Me.priceLBL = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'itemLBL
        '
        Me.itemLBL.AutoSize = True
        Me.itemLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.itemLBL.Location = New System.Drawing.Point(3, 10)
        Me.itemLBL.Margin = New System.Windows.Forms.Padding(3, 0, 3, 15)
        Me.itemLBL.Name = "itemLBL"
        Me.itemLBL.Size = New System.Drawing.Size(45, 13)
        Me.itemLBL.TabIndex = 3
        Me.itemLBL.Text = "itemLBL"
        '
        'priceLBL
        '
        Me.priceLBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.priceLBL.AutoSize = True
        Me.priceLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
        Me.priceLBL.Location = New System.Drawing.Point(106, 10)
        Me.priceLBL.Margin = New System.Windows.Forms.Padding(3, 0, 3, 15)
        Me.priceLBL.Name = "priceLBL"
        Me.priceLBL.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.priceLBL.Size = New System.Drawing.Size(21, 13)
        Me.priceLBL.TabIndex = 4
        Me.priceLBL.Text = "prc"
        '
        'itemsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.priceLBL)
        Me.Controls.Add(Me.itemLBL)
        Me.Name = "itemsControl"
        Me.Size = New System.Drawing.Size(134, 30)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents itemLBL As Label
    Friend WithEvents priceLBL As Label
End Class
