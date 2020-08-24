<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProduto
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnbtnControleProdutos = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCadastrar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnModificar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRemover = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancelar = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPreco = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNome = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnbtnControleProdutos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCodigo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPreco)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtNome)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvProdutos)
        Me.SplitContainer1.Size = New System.Drawing.Size(859, 494)
        Me.SplitContainer1.SplitterDistance = 219
        Me.SplitContainer1.TabIndex = 2
        '
        'btnbtnControleProdutos
        '
        Me.btnbtnControleProdutos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnbtnControleProdutos.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnbtnControleProdutos.FlatAppearance.BorderSize = 2
        Me.btnbtnControleProdutos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnbtnControleProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnbtnControleProdutos.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnbtnControleProdutos.ForeColor = System.Drawing.Color.Transparent
        Me.btnbtnControleProdutos.Location = New System.Drawing.Point(15, 421)
        Me.btnbtnControleProdutos.Name = "btnbtnControleProdutos"
        Me.btnbtnControleProdutos.Size = New System.Drawing.Size(191, 35)
        Me.btnbtnControleProdutos.TabIndex = 51
        Me.btnbtnControleProdutos.Text = "Controle"
        Me.btnbtnControleProdutos.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(149, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 25)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Procurar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(9, 41)
        Me.txtCodigo.Mask = "00000"
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(121, 22)
        Me.txtCodigo.TabIndex = 20
        Me.txtCodigo.ValidatingType = GetType(Integer)
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnCadastrar)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.btnRemover)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 172)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 160)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operações"
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCadastrar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnCadastrar.BorderThickness = 2
        Me.btnCadastrar.CheckedState.Parent = Me.btnCadastrar
        Me.btnCadastrar.CustomImages.Parent = Me.btnCadastrar
        Me.btnCadastrar.FillColor = System.Drawing.Color.Transparent
        Me.btnCadastrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCadastrar.ForeColor = System.Drawing.Color.Black
        Me.btnCadastrar.HoverState.Parent = Me.btnCadastrar
        Me.btnCadastrar.Location = New System.Drawing.Point(6, 19)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.ShadowDecoration.Parent = Me.btnCadastrar
        Me.btnCadastrar.Size = New System.Drawing.Size(177, 28)
        Me.btnCadastrar.TabIndex = 0
        Me.btnCadastrar.Text = "Cadastrar"
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnModificar.BorderThickness = 2
        Me.btnModificar.CheckedState.Parent = Me.btnModificar
        Me.btnModificar.CustomImages.Parent = Me.btnModificar
        Me.btnModificar.FillColor = System.Drawing.Color.Transparent
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.HoverState.Parent = Me.btnModificar
        Me.btnModificar.Location = New System.Drawing.Point(6, 53)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.ShadowDecoration.Parent = Me.btnModificar
        Me.btnModificar.Size = New System.Drawing.Size(177, 28)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "Modificar"
        '
        'btnRemover
        '
        Me.btnRemover.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemover.BorderColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnRemover.BorderThickness = 2
        Me.btnRemover.CheckedState.Parent = Me.btnRemover
        Me.btnRemover.CustomImages.Parent = Me.btnRemover
        Me.btnRemover.FillColor = System.Drawing.Color.Transparent
        Me.btnRemover.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRemover.ForeColor = System.Drawing.Color.Black
        Me.btnRemover.HoverState.Parent = Me.btnRemover
        Me.btnRemover.Location = New System.Drawing.Point(6, 87)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.ShadowDecoration.Parent = Me.btnRemover
        Me.btnRemover.Size = New System.Drawing.Size(177, 28)
        Me.btnRemover.TabIndex = 1
        Me.btnRemover.Text = "Remover"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnCancelar.BorderThickness = 2
        Me.btnCancelar.CheckedState.Parent = Me.btnCancelar
        Me.btnCancelar.CustomImages.Parent = Me.btnCancelar
        Me.btnCancelar.FillColor = System.Drawing.Color.Transparent
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.HoverState.Parent = Me.btnCancelar
        Me.btnCancelar.Location = New System.Drawing.Point(6, 121)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.ShadowDecoration.Parent = Me.btnCancelar
        Me.btnCancelar.Size = New System.Drawing.Size(177, 28)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Preço de venda"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nome :"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Código :"
        '
        'txtPreco
        '
        Me.txtPreco.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPreco.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPreco.DefaultText = ""
        Me.txtPreco.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPreco.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPreco.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPreco.DisabledState.Parent = Me.txtPreco
        Me.txtPreco.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPreco.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPreco.FocusedState.Parent = Me.txtPreco
        Me.txtPreco.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPreco.HoverState.Parent = Me.txtPreco
        Me.txtPreco.Location = New System.Drawing.Point(9, 139)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPreco.PlaceholderText = ""
        Me.txtPreco.SelectedText = ""
        Me.txtPreco.ShadowDecoration.Parent = Me.txtPreco
        Me.txtPreco.Size = New System.Drawing.Size(197, 23)
        Me.txtPreco.TabIndex = 6
        '
        'txtNome
        '
        Me.txtNome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNome.DefaultText = ""
        Me.txtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNome.DisabledState.Parent = Me.txtNome
        Me.txtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNome.FocusedState.Parent = Me.txtNome
        Me.txtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNome.HoverState.Parent = Me.txtNome
        Me.txtNome.Location = New System.Drawing.Point(9, 92)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNome.PlaceholderText = ""
        Me.txtNome.SelectedText = ""
        Me.txtNome.ShadowDecoration.Parent = Me.txtNome
        Me.txtNome.Size = New System.Drawing.Size(197, 23)
        Me.txtNome.TabIndex = 5
        '
        'dgvProdutos
        '
        Me.dgvProdutos.AllowUserToAddRows = False
        Me.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProdutos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvProdutos.Location = New System.Drawing.Point(16, 16)
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.Size = New System.Drawing.Size(593, 468)
        Me.dgvProdutos.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nome"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Preço de Venda"
        Me.Column3.Name = "Column3"
        '
        'FrmProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(883, 508)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProduto"
        Me.ShowInTaskbar = False
        Me.Text = "FrmProduto"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCadastrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnModificar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRemover As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancelar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPreco As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtNome As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgvProdutos As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtCodigo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnbtnControleProdutos As System.Windows.Forms.Button
End Class
