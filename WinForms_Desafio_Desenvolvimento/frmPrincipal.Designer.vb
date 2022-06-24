<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.tlpLayoutRoot = New System.Windows.Forms.TableLayoutPanel()
        Me.btnChamados = New System.Windows.Forms.Button()
        Me.btnDepartamentos = New System.Windows.Forms.Button()
        Me.tlpLayoutRoot.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo.Image = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.TitleBar
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Padding = New System.Windows.Forms.Padding(12)
        Me.lblTitulo.Size = New System.Drawing.Size(784, 48)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Netspeed - Sistema Chamados"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpLayoutRoot
        '
        Me.tlpLayoutRoot.ColumnCount = 2
        Me.tlpLayoutRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpLayoutRoot.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpLayoutRoot.Controls.Add(Me.btnChamados, 0, 0)
        Me.tlpLayoutRoot.Controls.Add(Me.btnDepartamentos, 1, 0)
        Me.tlpLayoutRoot.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpLayoutRoot.Location = New System.Drawing.Point(0, 48)
        Me.tlpLayoutRoot.Name = "tlpLayoutRoot"
        Me.tlpLayoutRoot.RowCount = 1
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpLayoutRoot.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpLayoutRoot.Size = New System.Drawing.Size(784, 413)
        Me.tlpLayoutRoot.TabIndex = 2
        '
        'btnChamados
        '
        Me.btnChamados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnChamados.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChamados.Image = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.chamados
        Me.btnChamados.Location = New System.Drawing.Point(121, 131)
        Me.btnChamados.Name = "btnChamados"
        Me.btnChamados.Size = New System.Drawing.Size(150, 150)
        Me.btnChamados.TabIndex = 0
        Me.btnChamados.Text = "Chamados"
        Me.btnChamados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnChamados.UseVisualStyleBackColor = True
        '
        'btnDepartamentos
        '
        Me.btnDepartamentos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnDepartamentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepartamentos.Image = Global.WinForms_Desafio_Desenvolvimento.My.Resources.Resources.departamentos
        Me.btnDepartamentos.Location = New System.Drawing.Point(513, 131)
        Me.btnDepartamentos.Name = "btnDepartamentos"
        Me.btnDepartamentos.Size = New System.Drawing.Size(150, 150)
        Me.btnDepartamentos.TabIndex = 0
        Me.btnDepartamentos.Text = "Departamentos"
        Me.btnDepartamentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnDepartamentos.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.tlpLayoutRoot)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Netspeed - Desafio Desenvolvimento"
        Me.tlpLayoutRoot.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lblTitulo As Label
    Friend WithEvents tlpLayoutRoot As TableLayoutPanel
    Friend WithEvents btnChamados As Button
    Friend WithEvents btnDepartamentos As Button
End Class
