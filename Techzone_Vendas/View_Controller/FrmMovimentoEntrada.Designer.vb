<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMovimentoEntrada
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lb = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.MaskedTextBox()
        Me.txtQtd = New System.Windows.Forms.MaskedTextBox()
        Me.txtPrecoU = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNomeProduto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCodigoProduto = New System.Windows.Forms.TextBox()
        Me.dgvProdutos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbProduto = New System.Windows.Forms.RadioButton()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.txtProcuraProd = New System.Windows.Forms.TextBox()
        Me.btnProcurarProd = New System.Windows.Forms.Button()
        Me.dgvFornecedor = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnProcurarProduto = New System.Windows.Forms.Button()
        Me.txtNomeFornecedor = New System.Windows.Forms.TextBox()
        Me.txtCodigoFornecedor = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btFinalizar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dpData = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTipoMovimento = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvFornecedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lb)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.txtQtd)
        Me.GroupBox1.Controls.Add(Me.txtPrecoU)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txtNomeProduto)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtCodigoProduto)
        Me.GroupBox1.Controls.Add(Me.dgvProdutos)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.dgvFornecedor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.btnProcurarProduto)
        Me.GroupBox1.Controls.Add(Me.txtNomeFornecedor)
        Me.GroupBox1.Controls.Add(Me.txtCodigoFornecedor)
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btFinalizar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dpData)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbTipoMovimento)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(723, 624)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Movimento"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(406, 495)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = " Preço Total:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(406, 472)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Qantidade:"
        '
        'lb
        '
        Me.lb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lb.AutoSize = True
        Me.lb.Location = New System.Drawing.Point(397, 443)
        Me.lb.Name = "lb"
        Me.lb.Size = New System.Drawing.Size(86, 13)
        Me.lb.TabIndex = 65
        Me.lb.Text = " Preço/Unidade:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(501, 495)
        Me.txtTotal.Mask = "00000"
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(194, 20)
        Me.txtTotal.TabIndex = 64
        Me.txtTotal.ValidatingType = GetType(Integer)
        '
        'txtQtd
        '
        Me.txtQtd.Location = New System.Drawing.Point(501, 469)
        Me.txtQtd.Mask = "00000"
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Size = New System.Drawing.Size(194, 20)
        Me.txtQtd.TabIndex = 63
        Me.txtQtd.ValidatingType = GetType(Integer)
        '
        'txtPrecoU
        '
        Me.txtPrecoU.Location = New System.Drawing.Point(501, 443)
        Me.txtPrecoU.Mask = "00000"
        Me.txtPrecoU.Name = "txtPrecoU"
        Me.txtPrecoU.Size = New System.Drawing.Size(195, 20)
        Me.txtPrecoU.TabIndex = 62
        Me.txtPrecoU.ValidatingType = GetType(Integer)
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(400, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 23)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Procurar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtNomeProduto
        '
        Me.txtNomeProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNomeProduto.Location = New System.Drawing.Point(501, 416)
        Me.txtNomeProduto.Name = "txtNomeProduto"
        Me.txtNomeProduto.ReadOnly = True
        Me.txtNomeProduto.Size = New System.Drawing.Size(195, 20)
        Me.txtNomeProduto.TabIndex = 60
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(260, 419)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = " Produto:"
        '
        'txtCodigoProduto
        '
        Me.txtCodigoProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigoProduto.Location = New System.Drawing.Point(321, 416)
        Me.txtCodigoProduto.Name = "txtCodigoProduto"
        Me.txtCodigoProduto.Size = New System.Drawing.Size(73, 20)
        Me.txtCodigoProduto.TabIndex = 58
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
        Me.dgvProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgvProdutos.Location = New System.Drawing.Point(28, 314)
        Me.dgvProdutos.Name = "dgvProdutos"
        Me.dgvProdutos.ReadOnly = True
        Me.dgvProdutos.Size = New System.Drawing.Size(667, 94)
        Me.dgvProdutos.TabIndex = 57
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Preço de Venda"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.rbProduto)
        Me.GroupBox2.Controls.Add(Me.rbCodigo)
        Me.GroupBox2.Controls.Add(Me.txtProcuraProd)
        Me.GroupBox2.Controls.Add(Me.btnProcurarProd)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 267)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(667, 41)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Produtos"
        '
        'rbProduto
        '
        Me.rbProduto.AutoSize = True
        Me.rbProduto.Checked = True
        Me.rbProduto.Location = New System.Drawing.Point(86, 15)
        Me.rbProduto.Name = "rbProduto"
        Me.rbProduto.Size = New System.Drawing.Size(61, 17)
        Me.rbProduto.TabIndex = 3
        Me.rbProduto.TabStop = True
        Me.rbProduto.Text = "produto"
        Me.rbProduto.UseVisualStyleBackColor = True
        '
        'rbCodigo
        '
        Me.rbCodigo.AutoSize = True
        Me.rbCodigo.Location = New System.Drawing.Point(23, 14)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(57, 17)
        Me.rbCodigo.TabIndex = 2
        Me.rbCodigo.Text = "codigo"
        Me.rbCodigo.UseVisualStyleBackColor = True
        '
        'txtProcuraProd
        '
        Me.txtProcuraProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProcuraProd.Location = New System.Drawing.Point(153, 14)
        Me.txtProcuraProd.Name = "txtProcuraProd"
        Me.txtProcuraProd.Size = New System.Drawing.Size(420, 20)
        Me.txtProcuraProd.TabIndex = 1
        '
        'btnProcurarProd
        '
        Me.btnProcurarProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarProd.Location = New System.Drawing.Point(579, 12)
        Me.btnProcurarProd.Name = "btnProcurarProd"
        Me.btnProcurarProd.Size = New System.Drawing.Size(75, 23)
        Me.btnProcurarProd.TabIndex = 0
        Me.btnProcurarProd.Text = "Procurar"
        Me.btnProcurarProd.UseVisualStyleBackColor = True
        '
        'dgvFornecedor
        '
        Me.dgvFornecedor.AllowUserToAddRows = False
        Me.dgvFornecedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFornecedor.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFornecedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvFornecedor.Location = New System.Drawing.Point(19, 78)
        Me.dgvFornecedor.Name = "dgvFornecedor"
        Me.dgvFornecedor.Size = New System.Drawing.Size(667, 93)
        Me.dgvFornecedor.TabIndex = 55
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
        Me.Column3.HeaderText = "Endereço"
        Me.Column3.Name = "Column3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Codigo :"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(111, 20)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 53
        '
        'btnProcurarProduto
        '
        Me.btnProcurarProduto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcurarProduto.Location = New System.Drawing.Point(390, 181)
        Me.btnProcurarProduto.Name = "btnProcurarProduto"
        Me.btnProcurarProduto.Size = New System.Drawing.Size(75, 23)
        Me.btnProcurarProduto.TabIndex = 51
        Me.btnProcurarProduto.Text = "Procurar"
        Me.btnProcurarProduto.UseVisualStyleBackColor = True
        '
        'txtNomeFornecedor
        '
        Me.txtNomeFornecedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNomeFornecedor.Location = New System.Drawing.Point(471, 184)
        Me.txtNomeFornecedor.Name = "txtNomeFornecedor"
        Me.txtNomeFornecedor.ReadOnly = True
        Me.txtNomeFornecedor.Size = New System.Drawing.Size(212, 20)
        Me.txtNomeFornecedor.TabIndex = 50
        '
        'txtCodigoFornecedor
        '
        Me.txtCodigoFornecedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCodigoFornecedor.Location = New System.Drawing.Point(311, 183)
        Me.txtCodigoFornecedor.Name = "txtCodigoFornecedor"
        Me.txtCodigoFornecedor.Size = New System.Drawing.Size(73, 20)
        Me.txtCodigoFornecedor.TabIndex = 49
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(372, 564)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(167, 28)
        Me.btnCancelar.TabIndex = 36
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btFinalizar
        '
        Me.btFinalizar.Location = New System.Drawing.Point(545, 564)
        Me.btFinalizar.Name = "btFinalizar"
        Me.btFinalizar.Size = New System.Drawing.Size(167, 28)
        Me.btFinalizar.TabIndex = 35
        Me.btFinalizar.Text = "Finalizar"
        Me.btFinalizar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(239, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Fornecedor :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Data :"
        '
        'dpData
        '
        Me.dpData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dpData.Location = New System.Drawing.Point(77, 224)
        Me.dpData.Name = "dpData"
        Me.dpData.Size = New System.Drawing.Size(609, 20)
        Me.dpData.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo Movimento :"
        '
        'cbTipoMovimento
        '
        Me.cbTipoMovimento.FormattingEnabled = True
        Me.cbTipoMovimento.Location = New System.Drawing.Point(111, 51)
        Me.cbTipoMovimento.Name = "cbTipoMovimento"
        Me.cbTipoMovimento.Size = New System.Drawing.Size(173, 21)
        Me.cbTipoMovimento.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(290, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(396, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Entrada"
        '
        'FrmMovimentoEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(747, 648)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmMovimentoEntrada"
        Me.Text = "FrmMovimentoEntrada"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvFornecedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnProcurarProduto As System.Windows.Forms.Button
    Friend WithEvents txtNomeFornecedor As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoFornecedor As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btFinalizar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dpData As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbTipoMovimento As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents dgvFornecedor As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvProdutos As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbProduto As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtProcuraProd As System.Windows.Forms.TextBox
    Friend WithEvents btnProcurarProd As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lb As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtQtd As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPrecoU As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtNomeProduto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProduto As System.Windows.Forms.TextBox
End Class
