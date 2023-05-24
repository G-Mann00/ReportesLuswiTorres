Imports Microsoft.Reporting.WinForms
Public Class FrmPrincipal

    Dim tblEmp As New DsDBHR.RptJobEmployeesDataTable
    Dim rptEmpleados As New DsDBHRTableAdapters.RptJobEmployeesTableAdapter
    Dim tbl As New DataTable

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarRegistros()
    End Sub

    Sub llenarRegistros()
        rptEmpleados.Fill(tblEmp)
        DgvRegistrosEmpleado.DataSource = tblEmp
        DgvRegistrosEmpleado.Refresh()
        GbxRegistros.Text = "Registros guardados: " & DgvRegistrosEmpleado.Rows.Count
    End Sub

    Private Function crearTabla(query) As DataTable
        Dim tbl As DataTable = New DataTable("tblEmp")

        tbl.Columns.Add("job_title")
        tbl.Columns.Add("first_name")
        tbl.Columns.Add("last_name")
        tbl.Columns.Add("email")
        tbl.Columns.Add("phone_number")
        tbl.Columns.Add("hire_date")
        tbl.Columns.Add("salary")
        Return tbl
    End Function
End Class
