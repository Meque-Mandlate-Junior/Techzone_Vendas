<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.btnRelaMovimentos = New System.Windows.Forms.Button()
        Me.btnRegistoMov = New System.Windows.Forms.Button()
        Me.btnTipoMovimento = New System.Windows.Forms.Button()
        Me.btnFornecedor = New System.Windows.Forms.Button()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.btnProdutos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCodigoProduto = New System.Windows.Forms.TextBox()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.txtQtd = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.txtNomeProduto = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listvAD = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnRemoverTudo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnProcurarProd = New System.Windows.Forms.Button()
        Me.rbProduto = New System.Windows.Forms.RadioButton()
        Me.txtProcuraProd = New System.Windows.Forms.TextBox()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.btnProcessarSaida = New System.Windows.Forms.Button()
        Me.btnConfiguraçãoBD = New System.Windows.Forms.Button()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.SystemColors.Control
        Me.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnClientes.FlatAppearance.BorderSize = 2
        Me.btnClientes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClientes.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnClientes.ForeColor = System.Drawing.Color.Black
        Me.btnClientes.Location = New System.Drawing.Point(15, 57)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(163, 42)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Guna2GroupBox1.BorderThickness = 2
        Me.Guna2GroupBox1.Controls.Add(Me.btnConfiguraçãoBD)
        Me.Guna2GroupBox1.Controls.Add(Me.btnRelaMovimentos)
        Me.Guna2GroupBox1.Controls.Add(Me.btnRegistoMov)
        Me.Guna2GroupBox1.Controls.Add(Me.btnTipoMovimento)
        Me.Guna2GroupBox1.Controls.Add(Me.btnFornecedor)
        Me.Guna2GroupBox1.Controls.Add(Me.btnStock)
        Me.Guna2GroupBox1.Controls.Add(Me.btnProdutos)
        Me.Guna2GroupBox1.Controls.Add(Me.btnClientes)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(855, 12)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(207, 561)
        Me.Guna2GroupBox1.TabIndex = 1
        Me.Guna2GroupBox1.Text = "OPERAÇÕES"
        Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRelaMovimentos
        '
        Me.btnRelaMovimentos.BackColor = System.Drawing.SystemColors.Control
        Me.btnRelaMovimentos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnRelaMovimentos.FlatAppearance.BorderSize = 2
        Me.btnRelaMovimentos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRelaMovimentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnRelaMovimentos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRelaMovimentos.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnRelaMovimentos.ForeColor = System.Drawing.Color.Black
        Me.btnRelaMovimentos.Location = New System.Drawing.Point(15, 345)
        Me.btnRelaMovimentos.Name = "btnRelaMovimentos"
        Me.btnRelaMovimentos.Size = New System.Drawing.Size(163, 42)
        Me.btnRelaMovimentos.TabIndex = 6
        Me.btnRelaMovimentos.Text = "Relatorios"
        Me.btnRelaMovimentos.UseVisualStyleBackColor = False
        '
        'btnRegistoMov
        '
        Me.btnRegistoMov.BackColor = System.Drawing.SystemColors.Control
        Me.btnRegistoMov.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnRegistoMov.FlatAppearance.BorderSize = 2
        Me.btnRegistoMov.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRegistoMov.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnRegistoMov.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRegistoMov.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnRegistoMov.ForeColor = System.Drawing.Color.Black
        Me.btnRegistoMov.Location = New System.Drawing.Point(15, 297)
        Me.btnRegistoMov.Name = "btnRegistoMov"
        Me.btnRegistoMov.Size = New System.Drawing.Size(163, 42)
        Me.btnRegistoMov.TabIndex = 5
        Me.btnRegistoMov.Text = "Registos de Movimento"
        Me.btnRegistoMov.UseVisualStyleBackColor = False
        '
        'btnTipoMovimento
        '
        Me.btnTipoMovimento.BackColor = System.Drawing.SystemColors.Control
        Me.btnTipoMovimento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnTipoMovimento.FlatAppearance.BorderSize = 2
        Me.btnTipoMovimento.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnTipoMovimento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnTipoMovimento.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnTipoMovimento.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnTipoMovimento.ForeColor = System.Drawing.Color.Black
        Me.btnTipoMovimento.Location = New System.Drawing.Point(15, 249)
        Me.btnTipoMovimento.Name = "btnTipoMovimento"
        Me.btnTipoMovimento.Size = New System.Drawing.Size(163, 42)
        Me.btnTipoMovimento.TabIndex = 4
        Me.btnTipoMovimento.Text = "Tipo Movimento"
        Me.btnTipoMovimento.UseVisualStyleBackColor = False
        '
        'btnFornecedor
        '
        Me.btnFornecedor.BackColor = System.Drawing.SystemColors.Control
        Me.btnFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnFornecedor.FlatAppearance.BorderSize = 2
        Me.btnFornecedor.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnFornecedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnFornecedor.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnFornecedor.ForeColor = System.Drawing.Color.Black
        Me.btnFornecedor.Location = New System.Drawing.Point(15, 201)
        Me.btnFornecedor.Name = "btnFornecedor"
        Me.btnFornecedor.Size = New System.Drawing.Size(163, 42)
        Me.btnFornecedor.TabIndex = 3
        Me.btnFornecedor.Text = "Fornecedor"
        Me.btnFornecedor.UseVisualStyleBackColor = False
        '
        'btnStock
        '
        Me.btnStock.BackColor = System.Drawing.SystemColors.Control
        Me.btnStock.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnStock.FlatAppearance.BorderSize = 2
        Me.btnStock.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnStock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnStock.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnStock.ForeColor = System.Drawing.Color.Black
        Me.btnStock.Location = New System.Drawing.Point(15, 153)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(163, 42)
        Me.btnStock.TabIndex = 2
        Me.btnStock.Text = "Stock"
        Me.btnStock.UseVisualStyleBackColor = False
        '
        'btnProdutos
        '
        Me.btnProdutos.BackColor = System.Drawing.SystemColors.Control
        Me.btnProdutos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnProdutos.FlatAppearance.BorderSize = 2
        Me.btnProdutos.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnProdutos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnProdutos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnProdutos.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnProdutos.ForeColor = System.Drawing.Color.Black
        Me.btnProdutos.Location = New System.Drawing.Point(15, 105)
        Me.btnProdutos.Name = "btnProdutos"
        Me.btnProdutos.Size = New System.Drawing.Size(163, 42)
        Me.btnProdutos.TabIndex = 1
        Me.btnProdutos.Text = "Produtos"
        Me.btnProdutos.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(837, 489)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Movimento de Produtos"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.dgvProdutos)
        Me.Panel3.Controls.Add(Me.txtCodigoProduto)
        Me.Panel3.Controls.Add(Me.btnProcurarProduto)
        Me.Panel3.Controls.Add(Me.txtQtd)
        Me.Panel3.Controls.Add(Me.btnAdd)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.txtSubTotal)
        Me.Panel3.Controls.Add(Me.txtNomeProduto)
        Me.Panel3.Location = New System.Drawing.Point(36, 96)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(415, 393)
        Me.Panel3.TabIndex = 51
        '
        'dgvProdutos
        '
        Me.dgvProdutos.AllowUserToAddRows = False
        Me.dgvProdutos.AllowUserToDeleteRows = False
        Me.dgvProdutos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProdutos.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvProdutos.Location = New System.Drawing.Point(6, 9)
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.ReadOnly = True
        Me.dgvProdutos.Size = New System.Drawing.Size(400, 186)
        Me.dgvProdutos.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nome"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Preço de Venda"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'txtCodigoProduto
        '
        Me.txtCodigoProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigoProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProduto.Location = New System.Drawing.Point(55, 225)
        Me.txtCodigoProduto.Name = "txtCodigoProduto"
        Me.txtCodigoProduto.Size = New System.Drawing.Size(73, 22)
        Me.txtCodigoProduto.TabIndex = 40
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarProduto.Location = New System.Drawing.Point(134, 225)
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.Size = New System.Drawing.Size(75, 23)
        Me.btnProcurarProduto.TabIndex = 48
        Me.btnProcurarProduto.Text = "Procurar"
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'txtQtd
        '
        Me.txtQtd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQtd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtd.Location = New System.Drawing.Point(218, 255)
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Size = New System.Drawing.Size(188, 24)
        Me.txtQtd.TabIndex = 41
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btnAdd.FlatAppearance.BorderSize = 2
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(218, 326)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(188, 27)
        Me.btnAdd.TabIndex = 47
        Me.btnAdd.Text = "OK"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = " Produto:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(141, 287)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "SubTotal"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(131, 262)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Quantidade :"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSubTotal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(218, 283)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(188, 24)
        Me.txtSubTotal.TabIndex = 45
        '
        'txtNomeProduto
        '
        Me.txtNomeProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNomeProduto.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtNomeProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeProduto.Location = New System.Drawing.Point(218, 223)
        Me.txtNomeProduto.Name = "txtNomeProduto"
        Me.txtNomeProduto.ReadOnly = True
        Me.txtNomeProduto.Size = New System.Drawing.Size(188, 24)
        Me.txtNomeProduto.TabIndex = 44
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Location = New System.Drawing.Point(463, 35)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(368, 448)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Produtos Adquiridos"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.listvAD)
        Me.Panel2.Controls.Add(Me.txtTotal)
        Me.Panel2.Controls.Add(Me.btnRemoverTudo)
        Me.Panel2.Location = New System.Drawing.Point(6, 19)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(356, 423)
        Me.Panel2.TabIndex = 51
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Valor Total :"
        '
        'listvAD
        '
        Me.listvAD.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.listvAD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.listvAD.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.listvAD.FullRowSelect = True
        Me.listvAD.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listvAD.HideSelection = False
        Me.listvAD.HoverSelection = True
        Me.listvAD.Location = New System.Drawing.Point(3, 10)
        Me.listvAD.Name = "listvAD"
        Me.listvAD.Size = New System.Drawing.Size(346, 202)
        Me.listvAD.TabIndex = 0
        Me.listvAD.UseCompatibleStateImageBehavior = False
        Me.listvAD.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Código"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nome Produto"
        Me.ColumnHeader2.Width = 117
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Quantidade"
        Me.ColumnHeader3.Width = 78
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Preço"
        Me.ColumnHeader4.Width = 67
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(150, 238)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(199, 26)
        Me.txtTotal.TabIndex = 3
        '
        'btnRemoverTudo
        '
        Me.btnRemoverTudo.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnRemoverTudo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRemoverTudo.Location = New System.Drawing.Point(232, 284)
        Me.btnRemoverTudo.Name = "btnRemoverTudo"
        Me.btnRemoverTudo.Size = New System.Drawing.Size(117, 23)
        Me.btnRemoverTudo.TabIndex = 2
        Me.btnRemoverTudo.Text = "Limpar"
        Me.btnRemoverTudo.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 35)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(434, 454)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Produtos"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnProcurarProd)
        Me.Panel1.Controls.Add(Me.rbProduto)
        Me.Panel1.Controls.Add(Me.txtProcuraProd)
        Me.Panel1.Controls.Add(Me.rbCodigo)
        Me.Panel1.Location = New System.Drawing.Point(13, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(415, 35)
        Me.Panel1.TabIndex = 4
        '
        'btnProcurarProd
        '
        Me.btnProcurarProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarProd.Location = New System.Drawing.Point(333, 3)
        Me.btnProcurarProd.Name = "btnProcurarProd"
        Me.btnProcurarProd.Size = New System.Drawing.Size(75, 23)
        Me.btnProcurarProd.TabIndex = 0
        Me.btnProcurarProd.Text = "Procurar"
        Me.btnProcurarProd.UseVisualStyleBackColor = True
        '
        'rbProduto
        '
        Me.rbProduto.AutoSize = True
        Me.rbProduto.Checked = True
        Me.rbProduto.Location = New System.Drawing.Point(73, 6)
        Me.rbProduto.Name = "rbProduto"
        Me.rbProduto.Size = New System.Drawing.Size(61, 17)
        Me.rbProduto.TabIndex = 3
        Me.rbProduto.TabStop = True
        Me.rbProduto.Text = "produto"
        Me.rbProduto.UseVisualStyleBackColor = True
        '
        'txtProcuraProd
        '
        Me.txtProcuraProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProcuraProd.Location = New System.Drawing.Point(140, 5)
        Me.txtProcuraProd.Name = "txtProcuraProd"
        Me.txtProcuraProd.Size = New System.Drawing.Size(187, 20)
        Me.txtProcuraProd.TabIndex = 1
        '
        'rbCodigo
        '
        Me.rbCodigo.AutoSize = True
        Me.rbCodigo.Location = New System.Drawing.Point(10, 5)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(57, 17)
        Me.rbCodigo.TabIndex = 2
        Me.rbCodigo.Text = "codigo"
        Me.rbCodigo.UseVisualStyleBackColor = True
        '
        'btnProcessarSaida
        '
        Me.btnProcessarSaida.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcessarSaida.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnProcessarSaida.FlatAppearance.BorderSize = 2
        Me.btnProcessarSaida.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnProcessarSaida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnProcessarSaida.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnProcessarSaida.ForeColor = System.Drawing.Color.Transparent
        Me.btnProcessarSaida.Location = New System.Drawing.Point(669, 531)
        Me.btnProcessarSaida.Name = "btnProcessarSaida"
        Me.btnProcessarSaida.Size = New System.Drawing.Size(163, 42)
        Me.btnProcessarSaida.TabIndex = 50
        Me.btnProcessarSaida.Text = "Processar Saida"
        Me.btnProcessarSaida.UseVisualStyleBackColor = False
        '
        'btnConfiguraçãoBD
        '
        Me.btnConfiguraçãoBD.BackColor = System.Drawing.SystemColors.Control
        Me.btnConfiguraçãoBD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.btnConfiguraçãoBD.FlatAppearance.BorderSize = 2
        Me.btnConfiguraçãoBD.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnConfiguraçãoBD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnConfiguraçãoBD.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnConfiguraçãoBD.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnConfiguraçãoBD.ForeColor = System.Drawing.Color.Black
        Me.btnConfiguraçãoBD.Location = New System.Drawing.Point(15, 393)
        Me.btnConfiguraçãoBD.Name = "btnConfiguraçãoBD"
        Me.btnConfiguraçãoBD.Size = New System.Drawing.Size(163, 42)
        Me.btnConfiguraçãoBD.TabIndex = 7
        Me.btnConfiguraçãoBD.Text = "Configuração de BD"
        Me.btnConfiguraçãoBD.UseVisualStyleBackColor = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1074, 585)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnProcessarSaida)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.Name = "FrmPrincipal"
        Me.Text = "Home"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClientes As System.Windows.Forms.Button
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnFornecedor As System.Windows.Forms.Button
    Friend WithEvents btnStock As System.Windows.Forms.Button
    Friend WithEvents btnProdutos As System.Windows.Forms.Button
    Friend WithEvents btnTipoMovimento As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvProdutos As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbProduto As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtProcuraProd As System.Windows.Forms.TextBox
    Friend WithEvents btnProcurarProd As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnRemoverTudo As System.Windows.Forms.Button
    Friend WithEvents listvAD As System.Windows.Forms.ListView
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeProduto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtQtd As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoProduto As System.Windows.Forms.TextBox
    Friend WithEvents btnProcessarSaida As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRegistoMov As System.Windows.Forms.Button
    Friend WithEvents btnRelaMovimentos As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnConfiguraçãoBD As System.Windows.Forms.Button
End Class
