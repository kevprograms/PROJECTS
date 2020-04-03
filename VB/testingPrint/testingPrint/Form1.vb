Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class Form1
    Private con As New MySqlConnection("server=127.0.0.1;database=waffledb;user=root;password=")
    Private cmd As New MySqlCommand
    Private read As MySqlDataReader

    Private Sub testPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles testPrint.Click
        testFlowPanel.VerticalScroll.Value = 0
        'invoicePrint.DefaultPageSettings.PaperSize = New PaperSize("Custom", 390, 643)
        invoicePrint.Print()
    End Sub
    'Functions that add Order details to DB
    Public Function addEntry()
        Try
            con.Open()
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = ("INSERT INTO tblcashier (orderCashier, orderItem) values('Christine', 'Winter Waffle')")
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            Console.WriteLine("Add Data on Load: " + ex.ToString())
        End Try
    End Function

    'MAIN LOAD
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loadBTNs As loadBTN = New loadBTN
        Dim items As itemsControl = New itemsControl
        Dim datas As data = New data
        datas.load_Invoice()
        testFlowPanel.Controls.Add(loadBTNs)
        testFlowPanel.Controls.Add(datas)
        testFlowPanel.Controls.Add(items)
    End Sub

    'adds handler for load label click on loadbtn user control
    Dim data As loadBTN = New loadBTN
    Public Sub item_Clicked(Sender As Object, e As EventArgs)
        AddHandler data.loadBTN.Click, AddressOf data.loadBTN_Click
    End Sub

    'PRINT DOCUMENT
    'DETECTS WHAT THE CONTROL CONTENT IS AND PRINT IT WITH ALIGNMENT( IF STATEMENTS )
    Private Sub invoicePrint_PrintPage(ByVal sender As Object, ByVal e As PrintPageEventArgs) Handles invoicePrint.PrintPage
        Dim bm As New Bitmap(Me.testFlowPanel.Width, Me.testFlowPanel.Height)
        testFlowPanel.DrawToBitmap(bm, New Rectangle(0, 0, Me.testFlowPanel.Width, Me.testFlowPanel.Height))
        e.Graphics.DrawImage(bm, 0, 0)
        Static maxPages As Integer = 0
        Static page As Integer = 1
        Try
            If page = 1 Then
                For Each ctrl As Control In testFlowPanel.Controls
                    If TypeOf ctrl Is TextBox Or TypeOf ctrl Is Label Or TypeOf ctrl Is PictureBox Or TypeOf ctrl Is Panel Then
                        ctrl.Tag = Int((ctrl.Top + ctrl.Height) / invoicePrint.DefaultPageSettings.Bounds.Height) + 1
                        If CInt(ctrl.Tag) > maxPages Then maxPages = CInt(ctrl.Tag)
                    End If
                Next
            End If

            For Each ctrl As Control In testFlowPanel.Controls
                If CInt(ctrl.Tag) = page Then
                    If TypeOf ctrl Is TextBox Or TypeOf ctrl Is Label Then
                        Dim sf As New System.Drawing.StringFormat
                        If TypeOf ctrl Is TextBox Then
                            If DirectCast(ctrl, TextBox).TextAlign = HorizontalAlignment.Right Then
                                sf.Alignment = StringAlignment.Far
                            Else
                                sf.Alignment = StringAlignment.Near
                            End If
                        ElseIf TypeOf ctrl Is Label Then
                            If DirectCast(ctrl, Label).TextAlign = ContentAlignment.MiddleCenter Then
                                sf.Alignment = StringAlignment.Near
                            ElseIf DirectCast(ctrl, Label).TextAlign = ContentAlignment.MiddleCenter Then
                                sf.Alignment = StringAlignment.Far
                            End If
                        End If
                        sf.FormatFlags = StringFormatFlags.NoClip
                        e.Graphics.DrawString(ctrl.Text, ctrl.Font, New SolidBrush(ctrl.ForeColor), New RectangleF(ctrl.Left + 5, ctrl.Top - StartPosition, ctrl.Width, ctrl.Height), sf)
                    ElseIf TypeOf ctrl Is PictureBox Then
                        'pag may picturebox sa loob nung control ipiprint din yon

                        'naka flow layout sa panel
                        e.Graphics.DrawImage(DirectCast(ctrl, PictureBox).Image, New PointF(ctrl.Left, ctrl.Top - StartPosition))
                    ElseIf TypeOf ctrl Is DataGridView Then
                    End If
                End If
            Next
            page += 1
            If page > maxPages Then
                e.HasMorePages = False
                page = 1
                maxPages = 0
            Else
                e.HasMorePages = True
            End If
        Catch ex As Exception
            Console.WriteLine("Print Document: " + ex.ToString())
        End Try
    End Sub

    'load gridview in usercontrol1 (data)
    Public Function loadDGV()
        If ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            cmd = New MySqlCommand("SELECT * FROM tblcashier WHERE orderStatus = '0'", con)
            read = cmd.ExecuteReader()
            While (read.Read)
                Dim items As itemsControl = New itemsControl
                Dim datas As data = New data()
                Dim loadBTNUC As loadBTN = New loadBTN()
                loadBTNUC.AutoSize = True
                datas.AutoSize = True
                loadBTNUC.orderID = read("orderID")
                datas.identifier = read("orderID")
                testFlowPanel.Controls.Add(datas)
                testFlowPanel.Controls.Add(items)
            End While
            con.Close()
        Catch ex As Exception
            Console.WriteLine("LOAD CASHIER CLICK: " + ex.ToString())
        End Try
    End Function

    'function to load cashier name and set identifier to orderID in usercontrol1(data)
    Public Function loadData(ByVal orderID As String)
        If ConnectionState.Open Then
            con.Close()
        End If
        Try
            con.Open()
            cmd = New MySqlCommand("SELECT * FROM tblcashier WHERE orderStatus = '0' and orderID='" + orderID + "' ", con)
            read = cmd.ExecuteReader()
            While (read.Read)
                Dim data As data = New data()
                data.identifier = read("orderID")

                testFlowPanel.AutoSize = True
                testFlowPanel.Controls.Add(data)
            End While
            con.Close()
        Catch ex As Exception
            Console.WriteLine("Load Data: " + ex.ToString())
        End Try
    End Function

    Private Sub testFlowPanel_Paint(sender As Object, e As PaintEventArgs) Handles testFlowPanel.Paint

    End Sub
End Class

