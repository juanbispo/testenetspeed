<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDepartamentosListar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDepartamentosListar))
        Me.dgvDepartamentos = New System.Windows.Forms.DataGridView()
        Me.tlpLayoutRoot = New System.Windows.Forms.TableLayoutPanel()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnAbrir = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        Me.DsDepartamentos = New WinForms_Desafio_Desenvolvimento.dsDepartamentos()
        Me.DsDepartamentosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpLayoutRoot.SuspendLayout()
        CType(Me.DsDepartamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDepartamentosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDepartamentos
        '
        Me.dgvDepartamentos.AllowUserToAddRows = False
        Me.dgvDepartamentos.AllowUserToDeleteRows = False
        Me.dgvDepartamentos.AllowUserToResizeColumns = False
        Me.dgvDepartamentos.AllowUserToResizeRows = False
        Me.dgvDepartamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tlpLayoutRoot.SetColumnSpan(Me.dgvDepartamentos, 4)
        Me.dgvDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDepartamentos.Location = New System.Drawing.Point(3, 43)
        Me.dgvDepartamentos.Name = "dgvDepartamentos"
        Me.dgvDepartamentos.RowHeadersVisible = False
        Me.dgvDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDepartamentos.Size = New System.Drawing.Size(778, 415)
        Me.dgvDepartamentos.TabIndex = 0
        '
        'tlpLayoutRoot
        '
        Me.tlpLayoutRoot.ColumnCount = 4
        Me.tlpLayoutRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpLayoutRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147.0!))
        Me.tlpLayoutRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135.0!))
        Me.tlpLayoutRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayoutRoot.Controls.Add(Me.dgvDepartamentos, 0, 1)
        Me.tlpLayoutRoot.Controls.Add(Me.btnNovo, 0, 0)
        Me.tlpLayoutRoot.Controls.Add(Me.btnAbrir, 1, 0)
        Me.tlpLayoutRoot.Controls.Add(Me.btnExcluir, 2, 0)
        Me.tlpLayoutRoot.Controls.Add(Me.btnRelatorio, 3, 0)
        Me.tlpLayoutRoot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLayoutRoot.Location = New System.Drawing.Point(0, 0)
        Me.tlpLayoutRoot.Name = "tlpLayoutRoot"
        Me.tlpLayoutRoot.RowCount = 2
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayoutRoot.Size = New System.Drawing.Size(784, 461)
        Me.tlpLayoutRoot.TabIndex = 1
        '
        'btnNovo
        '
        Me.btnNovo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNovo.Image = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.document
        Me.btnNovo.Location = New System.Drawing.Point(3, 3)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(144, 34)
        Me.btnNovo.TabIndex = 1
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnAbrir
        '
        Me.btnAbrir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAbrir.Image = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.folder_horizontal_open
        Me.btnAbrir.Location = New System.Drawing.Point(153, 3)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(141, 34)
        Me.btnAbrir.TabIndex = 1
        Me.btnAbrir.Text = "Abrir Departamento"
        Me.btnAbrir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAbrir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnExcluir.Image = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.cross
        Me.btnExcluir.Location = New System.Drawing.Point(300, 3)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(129, 34)
        Me.btnExcluir.TabIndex = 1
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnRelatorio
        '
        Me.btnRelatorio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRelatorio.Image = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.printer
        Me.btnRelatorio.Location = New System.Drawing.Point(637, 3)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(144, 34)
        Me.btnRelatorio.TabIndex = 1
        Me.btnRelatorio.Text = "Relatório"
        Me.btnRelatorio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRelatorio.UseVisualStyleBackColor = True
        '
        'DsDepartamentos
        '
        Me.DsDepartamentos.DataSetName = "dsDepartamentos"
        Me.DsDepartamentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DsDepartamentosBindingSource
        '
        Me.DsDepartamentosBindingSource.DataSource = Me.DsDepartamentos
        Me.DsDepartamentosBindingSource.Position = 0
        '
        'frmDepartamentosListar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.tlpLayoutRoot)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmDepartamentosListar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Netspeed - Desafio Desenvolvimento"
        CType(Me.dgvDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpLayoutRoot.ResumeLayout(False)
        CType(Me.DsDepartamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDepartamentosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvDepartamentos As DataGridView
    Friend WithEvents tlpLayoutRoot As TableLayoutPanel
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnAbrir As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnRelatorio As Button
    Friend WithEvents DsDepartamentos As dsDepartamentos
    Friend WithEvents DsDepartamentosBindingSource As BindingSource
End Class
