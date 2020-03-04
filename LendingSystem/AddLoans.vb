Imports System.Data.SqlClient
Public Class AddLoans
    Private Sub AddLoans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LendingSystemDataSet.tblRegistration' table. You can move, or remove it, as needed.
        Me.TblRegistrationTableAdapter.Fill(Me.LendingSystemDataSet.tblRegistration)
    End Sub
    Private Sub cmbBorrowerNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbBorrowerNo.KeyPress
        e.Handled = True
    End Sub

    Private Sub cmbBorrowerNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBorrowerNo.SelectedIndexChanged
        GetBorrowerInfo()
    End Sub

    Private Sub cmbBorrowerNo_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbBorrowerNo.KeyDown
        e.Handled = True
    End Sub

    Private Sub GetBorrowerInfo()
        Try
            sqL = "Select Firstname, Lastname, MobileNo, Address from tblRegistration Where ID = @ID"
            ConnDB()
            cmd = New SqlCommand(sqL, conn)
            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = cmbBorrowerNo.Text
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                txtFirstname.Text = dr(0).ToString
                txtLastname.Text = dr(1).ToString
                txtContactNo.Text = dr(2).ToString
                txtAddress.Text = dr(3).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
End Class