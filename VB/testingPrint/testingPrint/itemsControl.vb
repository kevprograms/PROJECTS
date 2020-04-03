Imports MySql.Data.MySqlClient

Public Class itemsControl
    Dim con As New MySqlConnection("server=127.0.0.1;database=waffledb;user=root;password=")
    Dim cmd As New MySqlCommand
    Dim reader As MySqlDataReader
    Private Sub itemsControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            con.Open()
            cmd = New MySqlCommand("Select * FROM tblcashier WHERE orderStatus = '0' AND transactionID ='1'", con)
            reader = cmd.ExecuteReader()
            While reader.Read()
                itemLBL.Text = reader("orderItem")
                priceLBL.Text = reader("orderTL").ToString()
            End While
            con.Close()
        Catch ex As Exception
            Console.WriteLine("Load Items2: " + ex.ToString())
        End Try
    End Sub

End Class
