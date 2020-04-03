Imports MySql.Data.MySqlClient
Public Class data
    Dim con As New MySqlConnection("server=127.0.0.1;database=waffledb;user=root;password=")
    Dim cmd As New MySqlCommand
    Dim read As MySqlDataReader
    Public identifier As String
    Public Event usercontrolAction()
    Public itemsData As itemsControl = New itemsControl

    Private Sub data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RaiseEvent usercontrolAction()
        invoiceControl.Controls.Add(itemsData)

    End Sub

    Public Function load_Invoice()
        Try
            con.Open()
            cmd = New MySqlCommand("Select * FROM tblcashier WHERE orderStatus = '0' AND orderID ='1'", con)

            read = cmd.ExecuteReader()

            While read.Read()
                cashierNMLBL.Text = read("orderCashier")
                totalPrice.Text = read("orderTL").ToString()
                cashLBL.Text = read("orderPYTL").ToString()

            End While
            con.Close()

        Catch ex As Exception
            Console.WriteLine("Load Items: " + ex.ToString())
        End Try

    End Function

    Private Sub cashierNMLBL_Click(sender As Object, e As EventArgs) Handles cashierNMLBL.Click

    End Sub

    Private Sub invoiceControl_Paint(sender As Object, e As PaintEventArgs) Handles invoiceControl.Paint

    End Sub
End Class
