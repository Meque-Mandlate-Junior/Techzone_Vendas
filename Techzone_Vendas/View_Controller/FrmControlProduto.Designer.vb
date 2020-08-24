<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmControlProduto
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rbProduto = New System.Windows.Forms.RadioButton()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.txtProcuraProd = New System.Windows.Forms.TextBox()
        Me.btnProcurarProd = New System.Windows.Forms.Button()
        Me.dgvProdutos_lc = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvLucroProduto = New System.Windows.Forms.DataGridView()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLucro = New System.Windows.Forms.TextBox()
        Me.txtNomeProduto = New System.Windows.Forms.TextBox()
        Me.txtCodProduto = New System.Windows.Forms.TextBox()
        Me.txtQtdEntradas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQtdSaidas = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValorEntradas = New System.Windows.Forms.TextBox()
        Me.txtValorSaidas = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAplicarFiltro = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dpDataInicio = New System.Windows.Forms.DateTimePicker()
        Me.cbPeriodo = New System.Windows.Forms.ComboBox()
        Me.dpDataTermino = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnGrafico = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvProdutos_lc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvLucroProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Location = New System.Drawing.Point(873, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(366, 67)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Produtos"
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.rbProduto)
        Me.Panel4.Controls.Add(Me.rbCodigo)
        Me.Panel4.Controls.Add(Me.txtProcuraProd)
        Me.Panel4.Controls.Add(Me.btnProcurarProd)
        Me.Panel4.Location = New System.Drawing.Point(7, 15)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(353, 41)
        Me.Panel4.TabIndex = 0
        '
        'rbProduto
        '
        Me.rbProduto.AutoSize = True
        Me.rbProduto.Checked = True
        Me.rbProduto.Location = New System.Drawing.Point(81, 10)
        Me.rbProduto.Name = "rbProduto"
        Me.rbProduto.Size = New System.Drawing.Size(61, 17)
        Me.rbProduto.TabIndex = 7
        Me.rbProduto.TabStop = True
        Me.rbProduto.Text = "produto"
        Me.rbProduto.UseVisualStyleBackColor = True
        '
        'rbCodigo
        '
        Me.rbCodigo.AutoSize = True
        Me.rbCodigo.Location = New System.Drawing.Point(3, 10)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(57, 17)
        Me.rbCodigo.TabIndex = 6
        Me.rbCodigo.Text = "codigo"
        Me.rbCodigo.UseVisualStyleBackColor = True
        '
        'txtProcuraProd
        '
        Me.txtProcuraProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProcuraProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcuraProd.Location = New System.Drawing.Point(148, 8)
        Me.txtProcuraProd.Name = "txtProcuraProd"
        Me.txtProcuraProd.Size = New System.Drawing.Size(119, 22)
        Me.txtProcuraProd.TabIndex = 5
        '
        'btnProcurarProd
        '
        Me.btnProcurarProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProcurarProd.Location = New System.Drawing.Point(273, 7)
        Me.btnProcurarProd.Name = "btnProcurarProd"
        Me.btnProcurarProd.Size = New System.Drawing.Size(75, 23)
        Me.btnProcurarProd.TabIndex = 4
        Me.btnProcurarProd.Text = "Procurar"
        Me.btnProcurarProd.UseVisualStyleBackColor = True
        '
        'dgvProdutos_lc
        '
        Me.dgvProdutos_lc.AllowUserToAddRows = False
        Me.dgvProdutos_lc.AllowUserToDeleteRows = False
        Me.dgvProdutos_lc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProdutos_lc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProdutos_lc.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvProdutos_lc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvProdutos_lc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdutos_lc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvProdutos_lc.Location = New System.Drawing.Point(873, 89)
        Me.dgvProdutos_lc.Name = "dgvProdutos_lc"
        Me.dgvProdutos_lc.ReadOnly = True
        Me.dgvProdutos_lc.Size = New System.Drawing.Size(366, 548)
        Me.dgvProdutos_lc.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Produto"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Lucro"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.dgvLucroProduto)
        Me.Panel1.Location = New System.Drawing.Point(21, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(846, 382)
        Me.Panel1.TabIndex = 3
        '
        'dgvLucroProduto
        '
        Me.dgvLucroProduto.AllowUserToAddRows = False
        Me.dgvLucroProduto.AllowUserToDeleteRows = False
        Me.dgvLucroProduto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLucroProduto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvLucroProduto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLucroProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLucroProduto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column4, Me.Column6, Me.Column10, Me.Column7, Me.Column8, Me.Column9})
        Me.dgvLucroProduto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLucroProduto.Location = New System.Drawing.Point(0, 0)
        Me.dgvLucroProduto.Name = "dgvLucroProduto"
        Me.dgvLucroProduto.ReadOnly = True
        Me.dgvLucroProduto.Size = New System.Drawing.Size(842, 378)
        Me.dgvLucroProduto.TabIndex = 0
        '
        'Column4
        '
        Me.Column4.FillWeight = 93.33334!
        Me.Column4.HeaderText = "Operação"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.FillWeight = 98.48543!
        Me.Column6.HeaderText = "Data"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.FillWeight = 105.2618!
        Me.Column10.HeaderText = "P. Unitario"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.FillWeight = 100.5585!
        Me.Column7.HeaderText = "Qtd"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.FillWeight = 102.3552!
        Me.Column8.HeaderText = "Valor"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Lucro"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Produto :"
        '
        'txtLucro
        '
        Me.txtLucro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtLucro.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtLucro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLucro.Location = New System.Drawing.Point(657, 48)
        Me.txtLucro.Name = "txtLucro"
        Me.txtLucro.ReadOnly = True
        Me.txtLucro.Size = New System.Drawing.Size(176, 22)
        Me.txtLucro.TabIndex = 3
        '
        'txtNomeProduto
        '
        Me.txtNomeProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNomeProduto.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtNomeProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeProduto.Location = New System.Drawing.Point(309, 20)
        Me.txtNomeProduto.Name = "txtNomeProduto"
        Me.txtNomeProduto.ReadOnly = True
        Me.txtNomeProduto.Size = New System.Drawing.Size(524, 22)
        Me.txtNomeProduto.TabIndex = 1
        '
        'txtCodProduto
        '
        Me.txtCodProduto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCodProduto.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtCodProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodProduto.Location = New System.Drawing.Point(127, 20)
        Me.txtCodProduto.Name = "txtCodProduto"
        Me.txtCodProduto.ReadOnly = True
        Me.txtCodProduto.Size = New System.Drawing.Size(156, 22)
        Me.txtCodProduto.TabIndex = 0
        '
        'txtQtdEntradas
        '
        Me.txtQtdEntradas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtQtdEntradas.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtQtdEntradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdEntradas.Location = New System.Drawing.Point(127, 76)
        Me.txtQtdEntradas.Name = "txtQtdEntradas"
        Me.txtQtdEntradas.ReadOnly = True
        Me.txtQtdEntradas.Size = New System.Drawing.Size(156, 22)
        Me.txtQtdEntradas.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "QTD. Entradas :"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(309, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "QTD. Saidas :"
        '
        'txtQtdSaidas
        '
        Me.txtQtdSaidas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtQtdSaidas.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtQtdSaidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtdSaidas.Location = New System.Drawing.Point(414, 76)
        Me.txtQtdSaidas.Name = "txtQtdSaidas"
        Me.txtQtdSaidas.ReadOnly = True
        Me.txtQtdSaidas.Size = New System.Drawing.Size(157, 22)
        Me.txtQtdSaidas.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(597, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Stock :"
        '
        'txtStock
        '
        Me.txtStock.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(657, 76)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.ReadOnly = True
        Me.txtStock.Size = New System.Drawing.Size(176, 22)
        Me.txtStock.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(598, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Lucro :"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnGrafico)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtValorEntradas)
        Me.Panel2.Controls.Add(Me.txtValorSaidas)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtStock)
        Me.Panel2.Controls.Add(Me.txtCodProduto)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtNomeProduto)
        Me.Panel2.Controls.Add(Me.txtQtdSaidas)
        Me.Panel2.Controls.Add(Me.txtLucro)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtQtdEntradas)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(21, 489)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(844, 148)
        Me.Panel2.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(306, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Valor em Saidas :"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Valor em Entradas :"
        '
        'txtValorEntradas
        '
        Me.txtValorEntradas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtValorEntradas.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtValorEntradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorEntradas.Location = New System.Drawing.Point(127, 48)
        Me.txtValorEntradas.Name = "txtValorEntradas"
        Me.txtValorEntradas.ReadOnly = True
        Me.txtValorEntradas.Size = New System.Drawing.Size(156, 22)
        Me.txtValorEntradas.TabIndex = 14
        '
        'txtValorSaidas
        '
        Me.txtValorSaidas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtValorSaidas.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtValorSaidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorSaidas.Location = New System.Drawing.Point(413, 48)
        Me.txtValorSaidas.Name = "txtValorSaidas"
        Me.txtValorSaidas.ReadOnly = True
        Me.txtValorSaidas.Size = New System.Drawing.Size(158, 22)
        Me.txtValorSaidas.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(844, 67)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Filtros "
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.btnAplicarFiltro)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.dpDataInicio)
        Me.Panel3.Controls.Add(Me.cbPeriodo)
        Me.Panel3.Controls.Add(Me.dpDataTermino)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(6, 15)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(832, 41)
        Me.Panel3.TabIndex = 0
        '
        'btnAplicarFiltro
        '
        Me.btnAplicarFiltro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAplicarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAplicarFiltro.Location = New System.Drawing.Point(750, 7)
        Me.btnAplicarFiltro.Name = "btnAplicarFiltro"
        Me.btnAplicarFiltro.Size = New System.Drawing.Size(75, 23)
        Me.btnAplicarFiltro.TabIndex = 18
        Me.btnAplicarFiltro.Text = "Aplicar"
        Me.btnAplicarFiltro.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Período :"
        '
        'dpDataInicio
        '
        Me.dpDataInicio.CalendarFont = New System.Drawing.Font("Matura MT Script Capitals", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDataInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpDataInicio.Location = New System.Drawing.Point(393, 8)
        Me.dpDataInicio.Name = "dpDataInicio"
        Me.dpDataInicio.Size = New System.Drawing.Size(157, 23)
        Me.dpDataInicio.TabIndex = 12
        Me.dpDataInicio.Value = New Date(2020, 8, 13, 0, 0, 0, 0)
        '
        'cbPeriodo
        '
        Me.cbPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPeriodo.FormattingEnabled = True
        Me.cbPeriodo.Items.AddRange(New Object() {"Geral", "Janeiro" & Global.Microsoft.VisualBasic.ChrW(9), "Fevereiro" & Global.Microsoft.VisualBasic.ChrW(9), "Março" & Global.Microsoft.VisualBasic.ChrW(9), "Abril" & Global.Microsoft.VisualBasic.ChrW(9), "Maio" & Global.Microsoft.VisualBasic.ChrW(9), "Junho" & Global.Microsoft.VisualBasic.ChrW(9), "Julho", "Agosto", "Setembro" & Global.Microsoft.VisualBasic.ChrW(9), "Outubro" & Global.Microsoft.VisualBasic.ChrW(9), "Novembro" & Global.Microsoft.VisualBasic.ChrW(9), "Dezembro" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.cbPeriodo.Location = New System.Drawing.Point(75, 7)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Size = New System.Drawing.Size(259, 23)
        Me.cbPeriodo.TabIndex = 16
        '
        'dpDataTermino
        '
        Me.dpDataTermino.CalendarFont = New System.Drawing.Font("Matura MT Script Capitals", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDataTermino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDataTermino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpDataTermino.Location = New System.Drawing.Point(593, 7)
        Me.dpDataTermino.Name = "dpDataTermino"
        Me.dpDataTermino.Size = New System.Drawing.Size(135, 23)
        Me.dpDataTermino.TabIndex = 13
        Me.dpDataTermino.Value = New Date(2020, 8, 13, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(564, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Até"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(351, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Data :"
        '
        'btnGrafico
        '
        Me.btnGrafico.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGrafico.BackColor = System.Drawing.SystemColors.Control
        Me.btnGrafico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.btnGrafico.FlatAppearance.BorderSize = 2
        Me.btnGrafico.Location = New System.Drawing.Point(657, 105)
        Me.btnGrafico.Name = "btnGrafico"
        Me.btnGrafico.Size = New System.Drawing.Size(173, 30)
        Me.btnGrafico.TabIndex = 19
        Me.btnGrafico.Text = "Gerar Grafico"
        Me.btnGrafico.UseVisualStyleBackColor = False
        '
        'FrmControlProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1251, 662)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvProdutos_lc)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmControlProduto"
        Me.ShowInTaskbar = False
        Me.Text = "Control de Produtos"
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgvProdutos_lc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvLucroProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvProdutos_lc As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvLucroProduto As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLucro As System.Windows.Forms.TextBox
    Friend WithEvents txtNomeProduto As System.Windows.Forms.TextBox
    Friend WithEvents txtCodProduto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtQtdEntradas As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtQtdSaidas As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtValorEntradas As System.Windows.Forms.TextBox
    Friend WithEvents txtValorSaidas As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents rbProduto As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtProcuraProd As System.Windows.Forms.TextBox
    Friend WithEvents btnProcurarProd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dpDataInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents dpDataTermino As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnAplicarFiltro As System.Windows.Forms.Button
    Friend WithEvents btnGrafico As System.Windows.Forms.Button
End Class
