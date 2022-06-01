Public Class MenuMID

    Private Sub AboutToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Dim childFrm As New About
        childFrm.MdiParent = Me
        childFrm.Show()
    End Sub

    Private Sub DoctordetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoctordetailsToolStripMenuItem.Click
        Dim childFrm As New Doctordetails
        childFrm.MdiParent = Me
        childFrm.Show()
    End Sub

    Private Sub PatientdetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientdetailsToolStripMenuItem.Click
        Dim childFrm As New Patientdetails
        childFrm.MdiParent = Me
        childFrm.Show()
    End Sub


    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem1.Click
        Me.Hide()
        Dim obj = New Login
        obj.Show()
    End Sub

    Private Sub MenuMID_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class