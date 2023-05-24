Public Class FrmVistaPrevia
    Private Sub FrmVistaPrevia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsDBHR.RptJobEmployees' table. You can move, or remove it, as needed.
        Me.RptJobEmployeesTableAdapter.Fill(Me.DsDBHR.RptJobEmployees)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class