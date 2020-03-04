Public Class FormLendingSystem







    Sub switchPanel(panel As Form)
        Panel5Dashboard.Controls.Clear()
        panel.TopLevel = False
        Panel5Dashboard.Controls.Add(panel)
        panel.Show()


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ContextMenuStrip2_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip2.Opening

    End Sub

    Private Sub AddBorrowerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddBorrowerToolStripMenuItem.Click

    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BorrowersBtn.Click
        switchPanel(BorrowersForm)



    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        switchPanel(Dashboard)




    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        switchPanel(LoanForm)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        switchPanel(PaymentForm)
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        switchPanel(ReportsForm)
    End Sub

    Private Sub FormLendingSystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class