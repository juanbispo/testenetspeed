Public Class frmPrincipal

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Dados.ListarChamados()
        Dados.ListarDepartamentos()

    End Sub

    Private Sub btnChamados_Click(sender As Object, e As EventArgs) Handles btnChamados.Click

        Dim frm As New frmChamadosListar()
        frm.Show(Me)

    End Sub

    Private Sub btnDepartamentos_Click(sender As Object, e As EventArgs) Handles btnDepartamentos.Click

        Dim frm As New frmDepartamentosListar()
        frm.Show(Me)

    End Sub
End Class