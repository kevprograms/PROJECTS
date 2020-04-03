Public Class loadBTN
    Public orderID As String
    Public Event usercontrolAction()
    Public WithEvents loadBTN As Button
    Private Sub loadBTN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RaiseEvent usercontrolAction()
    End Sub
    Public Sub loadBTN_Click(sender As Object, e As EventArgs) Handles Label1.Click
        RaiseEvent usercontrolAction()
        Form1.loadData(orderID)
        MsgBox(orderID)
    End Sub

End Class
