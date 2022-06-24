<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepartamentosEditar
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartamentosEditar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.txtNomeDepartamento = New System.Windows.Forms.TextBox()
        Me.lblNomeDepartamento = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.lblID)
        Me.Panel1.Controls.Add(Me.btnSair)
        Me.Panel1.Controls.Add(Me.btnEnviar)
        Me.Panel1.Controls.Add(Me.txtNomeDepartamento)
        Me.Panel1.Controls.Add(Me.lblNomeDepartamento)
        Me.Panel1.Location = New System.Drawing.Point(-1, 62)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(528, 390)
        Me.Panel1.TabIndex = 0
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(191, 76)
        Me.txtId.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(134, 20)
        Me.txtId.TabIndex = 9
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(80, 79)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(18, 13)
        Me.lblID.TabIndex = 7
        Me.lblID.Text = "ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(106, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CADASTRAR DEPARTAMENTO"
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.Color.IndianRed
        Me.btnSair.Image = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.door_open_in
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(337, 289)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(80, 35)
        Me.btnSair.TabIndex = 5
        Me.btnSair.Text = "Fechar"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'btnEnviar
        '
        Me.btnEnviar.Image = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.disk
        Me.btnEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviar.Location = New System.Drawing.Point(110, 289)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(77, 35)
        Me.btnEnviar.TabIndex = 4
        Me.btnEnviar.Text = "Salvar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'txtNomeDepartamento
        '
        Me.txtNomeDepartamento.Location = New System.Drawing.Point(191, 109)
        Me.txtNomeDepartamento.Name = "txtNomeDepartamento"
        Me.txtNomeDepartamento.Size = New System.Drawing.Size(134, 20)
        Me.txtNomeDepartamento.TabIndex = 3
        '
        'lblNomeDepartamento
        '
        Me.lblNomeDepartamento.AutoSize = True
        Me.lblNomeDepartamento.Location = New System.Drawing.Point(80, 112)
        Me.lblNomeDepartamento.Name = "lblNomeDepartamento"
        Me.lblNomeDepartamento.Size = New System.Drawing.Size(105, 13)
        Me.lblNomeDepartamento.TabIndex = 1
        Me.lblNomeDepartamento.Text = "Nome Departamento"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.TitleBar
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-1, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(526, 55)
        Me.Panel2.TabIndex = 1
        '
        'frmDepartamentosEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDepartamentosEditar"
        Me.Text = "NetSpeed - Desafio"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblNomeDepartamento As Label
    Friend WithEvents txtNomeDepartamento As TextBox
    Friend WithEvents btnSair As Button
    Friend WithEvents btnEnviar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Panel2 As Panel
End Class
