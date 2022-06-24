<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChamadosEditar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChamadosEditar))
        Me.tlpLayoutRoot = New System.Windows.Forms.TableLayoutPanel()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblAssunto = New System.Windows.Forms.Label()
        Me.lblSolicitante = New System.Windows.Forms.Label()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.lblDataAbertura = New System.Windows.Forms.Label()
        Me.txtAssunto = New System.Windows.Forms.TextBox()
        Me.txtSolicitante = New System.Windows.Forms.TextBox()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsDepartamentos = New WinForms_Desafio_Desenvolvimento.dsDepartamentos()
        Me.dtpDataAbertura = New System.Windows.Forms.DateTimePicker()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.tlpLayoutRoot.SuspendLayout()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpLayoutRoot
        '
        Me.tlpLayoutRoot.ColumnCount = 3
        Me.tlpLayoutRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpLayoutRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayoutRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpLayoutRoot.Controls.Add(Me.lblID, 0, 0)
        Me.tlpLayoutRoot.Controls.Add(Me.txtID, 1, 0)
        Me.tlpLayoutRoot.Controls.Add(Me.lblAssunto, 0, 1)
        Me.tlpLayoutRoot.Controls.Add(Me.lblSolicitante, 0, 2)
        Me.tlpLayoutRoot.Controls.Add(Me.lblDepartamento, 0, 3)
        Me.tlpLayoutRoot.Controls.Add(Me.lblDataAbertura, 0, 4)
        Me.tlpLayoutRoot.Controls.Add(Me.txtAssunto, 1, 1)
        Me.tlpLayoutRoot.Controls.Add(Me.txtSolicitante, 1, 2)
        Me.tlpLayoutRoot.Controls.Add(Me.cmbDepartamento, 1, 3)
        Me.tlpLayoutRoot.Controls.Add(Me.dtpDataAbertura, 1, 4)
        Me.tlpLayoutRoot.Controls.Add(Me.btnSalvar, 2, 6)
        Me.tlpLayoutRoot.Controls.Add(Me.btnFechar, 1, 6)
        Me.tlpLayoutRoot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLayoutRoot.Location = New System.Drawing.Point(0, 0)
        Me.tlpLayoutRoot.Name = "tlpLayoutRoot"
        Me.tlpLayoutRoot.RowCount = 7
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLayoutRoot.Size = New System.Drawing.Size(624, 441)
        Me.tlpLayoutRoot.TabIndex = 0
        '
        'lblID
        '
        Me.lblID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblID.Location = New System.Drawing.Point(3, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(114, 40)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID:"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(123, 10)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        '
        'lblAssunto
        '
        Me.lblAssunto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAssunto.Location = New System.Drawing.Point(3, 40)
        Me.lblAssunto.Name = "lblAssunto"
        Me.lblAssunto.Size = New System.Drawing.Size(114, 40)
        Me.lblAssunto.TabIndex = 2
        Me.lblAssunto.Text = "Assunto:"
        Me.lblAssunto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSolicitante
        '
        Me.lblSolicitante.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSolicitante.Location = New System.Drawing.Point(3, 80)
        Me.lblSolicitante.Name = "lblSolicitante"
        Me.lblSolicitante.Size = New System.Drawing.Size(114, 40)
        Me.lblSolicitante.TabIndex = 4
        Me.lblSolicitante.Text = "Solicitante:"
        Me.lblSolicitante.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDepartamento
        '
        Me.lblDepartamento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDepartamento.Location = New System.Drawing.Point(3, 120)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(114, 40)
        Me.lblDepartamento.TabIndex = 6
        Me.lblDepartamento.Text = "Departamento:"
        Me.lblDepartamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDataAbertura
        '
        Me.lblDataAbertura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDataAbertura.Location = New System.Drawing.Point(3, 160)
        Me.lblDataAbertura.Name = "lblDataAbertura"
        Me.lblDataAbertura.Size = New System.Drawing.Size(114, 40)
        Me.lblDataAbertura.TabIndex = 8
        Me.lblDataAbertura.Text = "Data Abertura:"
        Me.lblDataAbertura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAssunto
        '
        Me.txtAssunto.Location = New System.Drawing.Point(123, 50)
        Me.txtAssunto.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.txtAssunto.Name = "txtAssunto"
        Me.txtAssunto.Size = New System.Drawing.Size(378, 20)
        Me.txtAssunto.TabIndex = 3
        '
        'txtSolicitante
        '
        Me.txtSolicitante.Location = New System.Drawing.Point(123, 90)
        Me.txtSolicitante.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.Size = New System.Drawing.Size(378, 20)
        Me.txtSolicitante.TabIndex = 5
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TableBindingSource, "ID", True))
        Me.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Location = New System.Drawing.Point(123, 130)
        Me.cmbDepartamento.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(200, 21)
        Me.cmbDepartamento.TabIndex = 7
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.DsDepartamentos
        '
        'DsDepartamentos
        '
        Me.DsDepartamentos.DataSetName = "dsDepartamentos"
        Me.DsDepartamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpDataAbertura
        '
        Me.dtpDataAbertura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDataAbertura.Location = New System.Drawing.Point(123, 170)
        Me.dtpDataAbertura.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.dtpDataAbertura.Name = "dtpDataAbertura"
        Me.dtpDataAbertura.Size = New System.Drawing.Size(110, 20)
        Me.dtpDataAbertura.TabIndex = 9
        '
        'btnSalvar
        '
        Me.btnSalvar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalvar.Image = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.disk
        Me.btnSalvar.Location = New System.Drawing.Point(507, 404)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(114, 34)
        Me.btnSalvar.TabIndex = 10
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFechar.Image = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.door_open_in
        Me.btnFechar.Location = New System.Drawing.Point(374, 404)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(127, 34)
        Me.btnFechar.TabIndex = 10
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'frmChamadosEditar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.tlpLayoutRoot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChamadosEditar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Netspeed - Desafio Desenvolvimento"
        Me.tlpLayoutRoot.ResumeLayout(False)
        Me.tlpLayoutRoot.PerformLayout()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpLayoutRoot As TableLayoutPanel
    Friend WithEvents lblID As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblAssunto As Label
    Friend WithEvents lblSolicitante As Label
    Friend WithEvents lblDepartamento As Label
    Friend WithEvents lblDataAbertura As Label
    Friend WithEvents txtAssunto As TextBox
    Friend WithEvents txtSolicitante As TextBox
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents dtpDataAbertura As DateTimePicker
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents DsDepartamentos As dsDepartamentos
End Class
