Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms

Public Class frmDepartamentosRelatorio
    Private Sub frmDepartamentosRelatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dtDepartamentos As DataTable = Dados.ListarDepartamentos()

        Dim rds As New ReportDataSource("dsDepartamentos", dtDepartamentos)
        Me.ReportViewer1.LocalReport.DataSources.Add(rds)

        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.PageWidth

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class