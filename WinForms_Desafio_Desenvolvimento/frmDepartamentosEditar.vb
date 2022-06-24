Public Class frmDepartamentosEditar
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        Dim ID As Integer

        Try
            ID = CInt(Me.txtId.Text)
        Catch
            ID = -1
        End Try

        Dim Descricao As String = Me.txtNomeDepartamento.Text


        Dim sucesso As Boolean = Dados.GravarDepartamento(ID, Descricao)

        If Not sucesso Then

            MessageBox.Show(Me, "Falha ao gravar o chamado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Cancel

        Else
            Me.DialogResult = DialogResult.OK
            Me.Close()

        End If

    End Sub

    Public Sub AbrirDepartamento(ByVal idDepartamento As Integer)

        Dim drChamado As DataRow = Dados.ObterDepartamentos(idDepartamento)

        Me.txtId.Text = CInt(drChamado("ID")).ToString()
        Me.txtNomeDepartamento.Text = CStr(drChamado("Descricao"))

    End Sub

    Private Sub frmDepartamentosEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblID_Click(sender As Object, e As EventArgs) Handles lblID.Click

    End Sub
End Class