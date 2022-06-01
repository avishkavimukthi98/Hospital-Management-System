Imports System.Data.SqlClient

Public Class Patientdetails
    Dim con As New SqlConnection("Data Source=DESKTOP-3R9DAQA;Initial Catalog=HospitalManagementSystemDB;Integrated Security=True")

    Private Sub AddBTN_Click(sender As Object, e As EventArgs) Handles AddBTN.Click

        con.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand("insert into Patientdetails values('" & PatientIDTb.Text & "','" & PatientNameTB.Text & "','" & AddressTB.Text & "','" & AgeTB.Text & "','" & GenderCB.Text & "','" & DobDTPicker.Text & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("Successfully Added")
        con.Close()
        GridObj()
        clr()

    End Sub

    Public Sub GridObj()
        con.Open()
        Dim mysql = "select * from Patientdetails"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(mysql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim DataSet As DataSet
        DataSet = New DataSet
        adapter.Fill(DataSet)
        PatientdetailsDataGridView.DataSource = DataSet.Tables(0)
        con.Close()
    End Sub

    Private Sub Patientdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridObj()
    End Sub

    Private Sub DeleteBTN_Click(sender As Object, e As EventArgs) Handles DeleteBTN.Click
        con.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand("Delete from Patientdetails where Patient_ID='" & PatientIDTb.Text & "'", con)
        cmd.ExecuteNonQuery()
        MsgBox("Successfully Deleted")
        con.Close()
        GridObj()
        clr()
    End Sub

    Private Sub UpdateBTN_Click(sender As Object, e As EventArgs) Handles UpdateBTN.Click
        con.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand("update Patientdetails set Patient_ID='" & PatientIDTb.Text & "',Patient_Name='" & PatientNameTB.Text & "',Address='" & AddressTB.Text & "',Age='" & AgeTB.Text & "', Gender='" & GenderCB.Text & "', DOB='" & DobDTPicker.Text & "' where Patient_ID='" & SearchTB.Text & "'", con)
        cmd.ExecuteNonQuery()
        MsgBox("Successfully Updated")
        con.Close()
        GridObj()
        clr()
    End Sub

    Private Sub SearchBTN_Click(sender As Object, e As EventArgs) Handles SearchBTN.Click
        con.Open()
        Dim cmd As SqlCommand
        cmd = New SqlCommand("select * from Patientdetails where Patient_ID='" & SearchTB.Text & "'", con)
        Dim myDataReader As SqlDataReader
        myDataReader = cmd.ExecuteReader
        myDataReader.Read()
        PatientIDTb.Text = myDataReader("Patient_ID")
        PatientNameTB.Text = myDataReader("Patient_Name")
        AddressTB.Text = myDataReader("Address")
        AgeTB.Text = myDataReader("Age")
        GenderCB.Text = myDataReader("Gender")
        DobDTPicker.Text = myDataReader("DOB")

        myDataReader.Close()
        MsgBox("Successfully Read")
        con.Close()

        con.Open()
        Dim mysql = "select * from Patientdetails where Patient_ID='" & SearchTB.Text & "'"
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(mysql, con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim DataSet As DataSet
        DataSet = New DataSet
        adapter.Fill(DataSet)
        PatientdetailsDataGridView.DataSource = DataSet.Tables(0)
        con.Close()




    End Sub

    Private Sub ClearBTN_Click(sender As Object, e As EventArgs) Handles ClearBTN.Click
        clr()
    End Sub

    Public Sub clr()
        SearchTB.ResetText()
        PatientIDTb.ResetText()
        PatientNameTB.ResetText()
        AddressTB.ResetText()
        AgeTB.ResetText()
        GenderCB.ResetText()
        DobDTPicker.ResetText()
        GridObj()
    End Sub

    Private Sub AgeTB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles AgeTB.KeyPress
        integerOnly(e)
    End Sub

    Public Sub integerOnly(ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Or Asc(e.KeyChar) = 8) Then

        Else
            e.Handled = True
            MsgBox("Integer Only")
        End If
    End Sub

End Class
