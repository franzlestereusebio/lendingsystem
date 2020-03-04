Imports System.Data.SqlClient
Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Text = ""
        txtUsername.Text = ""
        txtUsername.Focus()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure you want to close?", MsgBoxStyle.YesNo, "Perfect Attendance") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If ValidateLoginField() = False Then
            Exit Sub
        End If
        Login()
    End Sub

    Private Sub Login()
        Try
            sqL = "SELECT * FROM TblUsers WHERE Username = '" & txtUsername.Text & "' AND Password = '" & txtPassword.Text & "'"
            ConnDB()
            cmd = New SqlCommand(sqL, conn)
            dr = cmd.ExecuteReader()

            If dr.Read = True Then
                MsgBox("Welcome to Loan Manna.", MsgBoxStyle.Information, "Loan Manna")
                Dashboard.Show()
                Me.Hide()
            Else
                MsgBox("Incorrect username or password.", MsgBoxStyle.Critical, "Loan Manna")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub LoginForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If
    End Sub

    Private Function ValidateLoginField()
        ValidateLoginField = False
        If txtUsername.Text = "" Then
            MsgBox("Please enter your username.", MsgBoxStyle.Exclamation, "Warning")
            txtUsername.Focus()
        ElseIf txtPassword.Text = "" Then
            MsgBox("Please enter your password.", MsgBoxStyle.Exclamation, "Warning")
            txtPassword.Focus()
        Else
            ValidateLoginField = True
        End If
    End Function
End Class
