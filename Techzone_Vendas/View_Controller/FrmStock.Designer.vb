<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStock
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
        Me.dgvStock = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnProcessarEntrada = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvStock
        '
        Me.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvStock.Location = New System.Drawing.Point(12, 31)
        Me.dgvStock.Name = "dgvStock"
        Me.dgvStock.Size = New System.Drawing.Size(671, 424)
        Me.dgvStock.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Produto"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Quantidade"
        Me.Column2.Name = "Column2"
        '
        'btnProcessarEntrada
        '
        Me.btnProcessarEntrada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcessarEntrada.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnProcessarEntrada.FlatAppearance.BorderSize = 2
        Me.btnProcessarEntrada.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnProcessarEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnProcessarEntrada.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.btnProcessarEntrada.ForeColor = System.Drawing.Color.Transparent
        Me.btnProcessarEntrada.Location = New System.Drawing.Point(520, 461)
        Me.btnProcessarEntrada.Name = "btnProcessarEntrada"
        Me.btnProcessarEntrada.Size = New System.Drawing.Size(163, 42)
        Me.btnProcessarEntrada.TabIndex = 50
        Me.btnProcessarEntrada.Text = "Entrada de Produtos"
        Me.btnProcessarEntrada.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(565, 2)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(118, 23)
        Me.btnActualizar.TabIndex = 51
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'FrmStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(695, 533)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnProcessarEntrada)
        Me.Controls.Add(Me.dgvStock)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmStock"
        Me.Text = "Stock"
        CType(Me.dgvStock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvStock As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnProcessarEntrada As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
End Class
