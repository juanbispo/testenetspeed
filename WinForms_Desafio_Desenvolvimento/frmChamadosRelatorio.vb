Imports System.Windows.Forms
Imports Microsoft.Reporting.WinForms

Public Class frmChamadosRelatorio
    Private Sub frmChamadosRelatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dtChamados As DataTable = Dados.ListarChamados()

        Dim rds As New ReportDataSource("dsChamados", dtChamados)
        Me.ReportViewer1.LocalReport.DataSources.Add(rds)

        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        Me.ReportViewer1.ZoomMode = ZoomMode.PageWidth

        Me.ReportViewer1.RefreshReport()

    End Sub
End Class