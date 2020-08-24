<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistosMov
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
        Me.dgvMovP = New System.Windows.Forms.DataGridView()
        Me.dpDataInicio = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbPeriodo = New System.Windows.Forms.ComboBox()
        Me.cbMovimento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.dpDataTermino = New System.Windows.Forms.DateTimePicker()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRelatorio = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.dgvMovP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvMovP
        '
        Me.dgvMovP.AllowUserToOrderColumns = True
        Me.dgvMovP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMovP.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvMovP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column5, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvMovP.Location = New System.Drawing.Point(12, 221)
        Me.dgvMovP.Name = "dgvMovP"
        Me.dgvMovP.Size = New System.Drawing.Size(746, 348)
        Me.dgvMovP.TabIndex = 0
        '
        'dpDataInicio
        '
        Me.dpDataInicio.CalendarFont = New System.Drawing.Font("Matura MT Script Capitals", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDataInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpDataInicio.Location = New System.Drawing.Point(107, 88)
        Me.dpDataInicio.Name = "dpDataInicio"
        Me.dpDataInicio.Size = New System.Drawing.Size(128, 23)
        Me.dpDataInicio.TabIndex = 1
        Me.dpDataInicio.Value = New Date(2020, 8, 13, 0, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.btnCancelar)
        Me.GroupBox1.Controls.Add(Me.btnRelatorio)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbPeriodo)
        Me.GroupBox1.Controls.Add(Me.cbMovimento)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnFiltrar)
        Me.GroupBox1.Controls.Add(Me.dpDataTermino)
        Me.GroupBox1.Controls.Add(Me.dpDataInicio)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(746, 181)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Movimentos"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Periodo :"
        '
        'cbPeriodo
        '
        Me.cbPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPeriodo.FormattingEnabled = True
        Me.cbPeriodo.Items.AddRange(New Object() {"Geral", "Janeiro" & Global.Microsoft.VisualBasic.ChrW(9), "Fevereiro" & Global.Microsoft.VisualBasic.ChrW(9), "Março" & Global.Microsoft.VisualBasic.ChrW(9), "Abril" & Global.Microsoft.VisualBasic.ChrW(9), "Maio" & Global.Microsoft.VisualBasic.ChrW(9), "Junho" & Global.Microsoft.VisualBasic.ChrW(9), "Julho", "Agosto", "Setembro" & Global.Microsoft.VisualBasic.ChrW(9), "Outubro" & Global.Microsoft.VisualBasic.ChrW(9), "Novembro" & Global.Microsoft.VisualBasic.ChrW(9), "Dezembro" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.cbPeriodo.Location = New System.Drawing.Point(107, 58)
        Me.cbPeriodo.Name = "cbPeriodo"
        Me.cbPeriodo.Size = New System.Drawing.Size(284, 23)
        Me.cbPeriodo.TabIndex = 8
        '
        'cbMovimento
        '
        Me.cbMovimento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMovimento.FormattingEnabled = True
        Me.cbMovimento.Items.AddRange(New Object() {"Entrada", "Saida"})
        Me.cbMovimento.Location = New System.Drawing.Point(107, 29)
        Me.cbMovimento.Name = "cbMovimento"
        Me.cbMovimento.Size = New System.Drawing.Size(284, 23)
        Me.cbMovimento.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipo Movimento :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Até"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Datas :"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(497, 28)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(184, 36)
        Me.btnFiltrar.TabIndex = 3
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'dpDataTermino
        '
        Me.dpDataTermino.CalendarFont = New System.Drawing.Font("Matura MT Script Capitals", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDataTermino.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpDataTermino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpDataTermino.Location = New System.Drawing.Point(270, 88)
        Me.dpDataTermino.Name = "dpDataTermino"
        Me.dpDataTermino.Size = New System.Drawing.Size(121, 23)
        Me.dpDataTermino.TabIndex = 2
        Me.dpDataTermino.Value = New Date(2020, 8, 13, 0, 0, 0, 0)
        '
        'Column1
        '
        Me.Column1.HeaderText = "Operação"
        Me.Column1.Name = "Column1"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Data"
        Me.Column5.Name = "Column5"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Produto"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Quantidade"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Preço"
        Me.Column4.Name = "Column4"
        '
        'btnRelatorio
        '
        Me.btnRelatorio.Location = New System.Drawing.Point(497, 70)
        Me.btnRelatorio.Name = "btnRelatorio"
        Me.btnRelatorio.Size = New System.Drawing.Size(184, 36)
        Me.btnRelatorio.TabIndex = 10
        Me.btnRelatorio.Text = "Gerar Relatorio"
        Me.btnRelatorio.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(497, 112)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(184, 36)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FrmRegistosMov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(770, 611)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvMovP)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRegistosMov"
        Me.Text = "Registros Movimentos"
        CType(Me.dgvMovP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvMovP As System.Windows.Forms.DataGridView
    Friend WithEvents dpDataInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbMovimento As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents dpDataTermino As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnRelatorio As System.Windows.Forms.Button
End Class
