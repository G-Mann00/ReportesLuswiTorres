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
        Dim fila As DataRow

        tbl.Columns.Add("job_title")
        tbl.Columns.Add("first_name")
        tbl.Columns.Add("last_name")
        tbl.Columns.Add("email")
        tbl.Columns.Add("phone_number")
        tbl.Columns.Add("hire_date")
        tbl.Columns.Add("salary")

        For Each emp In query
            fila = tbl.NewRow()
            fila("job_title") = emp.job_title
            fila("first_name") = emp.first_name
            fila("last_name") = emp.last_name
            fila("email") = emp.email
            fila("phone_number") = emp.phone_number
            fila("hire_date") = emp.hire_date
            fila("salary") = emp.salary
            tbl.Rows.Add(fila)
        Next
        Return tbl
    End Function

    Private Sub buscarRegistro()
        Dim dato As String = TxtBuscar.Text & ""

        Dim campo As String = "emp.job_title"
        Dim query = From emp In tblEmp
                    Select emp.job_title, emp.first_name, emp.last_name, emp.email, emp.phone_number, emp.hire_date, emp.salary

        Select Case CbxCampo.SelectedIndex
            Case -1
                query = From emp In tblEmp Where emp.job_title Like dato
                        Select emp.job_title, emp.first_name, emp.last_name, emp.email, emp.phone_number, emp.hire_date, emp.salary

            Case 0
                query = From emp In tblEmp Where emp.job_title Like dato
                        Select emp.job_title, emp.first_name, emp.last_name, emp.email, emp.phone_number, emp.hire_date, emp.salary

            Case 1
                query = From emp In tblEmp Where emp.first_name Like dato
                        Select emp.job_title, emp.first_name, emp.last_name, emp.email, emp.phone_number, emp.hire_date, emp.salary

            Case 2
                query = From emp In tblEmp Where emp.last_name Like dato
                        Select emp.job_title, emp.first_name, emp.last_name, emp.email, emp.phone_number, emp.hire_date, emp.salary
        End Select

        tbl = crearTabla(query)

        DgvRegistrosEmpleado.DataSource = tbl
        DgvRegistrosEmpleado.Refresh()
        GbxRegistros.Text = "Registros encontrados: " & DgvRegistrosEmpleado.Rows.Count
    End Sub

    Sub verReporte(ByVal t As DataTable, ByVal nombreDS As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(nombreDS, t)
            With FrmVistaPrevia
                .ReportViewer1.LocalReport.DataSources.Clear()
                .ReportViewer1.LocalReport.DataSources.Add(rpt)
                .ReportViewer1.LocalReport.ReportPath = nombreRpt
                .ReportViewer1.Refresh()
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        buscarRegistro()
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        verReporte(tbl, "DsReporte", "reportes\RptEmpleadoTrabajo.rdlc")
    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        If TxtBuscar.Text = "" Then
            llenarRegistros()
        End If
    End Sub
End Class
