<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.dragPanel = New System.Windows.Forms.Panel()
        Me.varLBL = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dialog1 = New System.Windows.Forms.PrintDialog()
        Me.testPrint = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.invoicePrint = New System.Drawing.Printing.PrintDocument()
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.testFlowPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.dragPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.dragPanel
        Me.BunifuDragControl1.Vertical = True
        '
        'dragPanel
        '
        Me.dragPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.dragPanel.Controls.Add(Me.varLBL)
        Me.dragPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dragPanel.Location = New System.Drawing.Point(0, 428)
        Me.dragPanel.Name = "dragPanel"
        Me.dragPanel.Size = New System.Drawing.Size(154, 46)
        Me.dragPanel.TabIndex = 43
        '
        'varLBL
        '
        Me.varLBL.AutoSize = True
        Me.varLBL.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.varLBL.Location = New System.Drawing.Point(56, 15)
        Me.varLBL.Name = "varLBL"
        Me.varLBL.Size = New System.Drawing.Size(90, 22)
        Me.varLBL.TabIndex = 3
        Me.varLBL.Text = "Drag Me"
        '
        'dialog1
        '
        Me.dialog1.AllowCurrentPage = True
        Me.dialog1.AllowSomePages = True
        Me.dialog1.PrintToFile = True
        Me.dialog1.UseEXDialog = True
        '
        'testPrint
        '
        Me.testPrint.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.testPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.testPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.testPrint.BorderRadius = 0
        Me.testPrint.ButtonText = "PRINT"
        Me.testPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.testPrint.DisabledColor = System.Drawing.Color.Gray
        Me.testPrint.Dock = System.Windows.Forms.DockStyle.Top
        Me.testPrint.Iconcolor = System.Drawing.Color.Transparent
        Me.testPrint.Iconimage = Nothing
        Me.testPrint.Iconimage_right = Nothing
        Me.testPrint.Iconimage_right_Selected = Nothing
        Me.testPrint.Iconimage_Selected = Nothing
        Me.testPrint.IconMarginLeft = 0
        Me.testPrint.IconMarginRight = 0
        Me.testPrint.IconRightVisible = True
        Me.testPrint.IconRightZoom = 0R
        Me.testPrint.IconVisible = True
        Me.testPrint.IconZoom = 90.0R
        Me.testPrint.IsTab = False
        Me.testPrint.Location = New System.Drawing.Point(0, 0)
        Me.testPrint.Name = "testPrint"
        Me.testPrint.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.testPrint.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.testPrint.OnHoverTextColor = System.Drawing.Color.White
        Me.testPrint.selected = False
        Me.testPrint.Size = New System.Drawing.Size(154, 52)
        Me.testPrint.TabIndex = 41
        Me.testPrint.Text = "PRINT"
        Me.testPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.testPrint.Textcolor = System.Drawing.Color.White
        Me.testPrint.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'invoicePrint
        '
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me
        '
        'testFlowPanel
        '
        Me.testFlowPanel.Location = New System.Drawing.Point(0, 58)
        Me.testFlowPanel.Name = "testFlowPanel"
        Me.testFlowPanel.Size = New System.Drawing.Size(154, 364)
        Me.testFlowPanel.TabIndex = 40
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(154, 474)
        Me.Controls.Add(Me.testPrint)
        Me.Controls.Add(Me.dragPanel)
        Me.Controls.Add(Me.testFlowPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.dragPanel.ResumeLayout(False)
        Me.dragPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents dragPanel As Panel
    Friend WithEvents varLBL As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents testPrint As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents testFlowPanel As FlowLayoutPanel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents dialog1 As PrintDialog
    Friend WithEvents invoicePrint As Printing.PrintDocument
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
End Class
