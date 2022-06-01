Imports System.Data.SqlClient


Public Class Login

    Dim con As New SqlConnection("Data Source=DESKTOP-3R9DAQA;Initial Catalog=HospitalManagementSystemDB;Integrated Security=True")
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim Username, Password As String
    Dim sql As String

    Private Sub LoginBTN_Click(sender As Object, e As EventArgs) Handles LoginBTN.Click
        Username = UserNameTB.Text
        Password = PasswordTB.Text

        If (Username = "" And Password = "") Then
            MessageBox.Show("Enter the Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            con.Open()
            sql = "select * from login where Username = '" & Username & "' and Password= '" & Password & "'"
            cmd = New SqlCommand(sql, con)
            dr = cmd.ExecuteReader


            If (dr.Read = True) Then
                Dim f2 As MenuMID = New MenuMID
                f2.Show()
                Me.Hide()

            Else
                MessageBox.Show("Login Fail !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()
        End If
    End Sub

    Private Sub ClearBTN_Click(sender As Object, e As EventArgs) Handles ClearBTN.Click
        UserNameTB.ResetText()
        PasswordTB.ResetText()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class