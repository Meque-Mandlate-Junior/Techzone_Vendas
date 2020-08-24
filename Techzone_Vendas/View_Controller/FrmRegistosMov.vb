Public Class FrmRegistosMov

    Public Sub Filtrar()
        '
        Dim DAO As New MovimentoProdutoDAO
        Dim sql As String
        Dim dataInicio As Date
        Dim dataTermino As Date
        dataInicio = dpDataInicio.Value
        dataTermino = dpDataTermino.Value
        sql = "SELECT tipoMovimento.operacao, movimento.data,produto.nome,movimentoProduto.qtd,movimentoProduto.preco from ((( movimentoProduto " & _
         "inner join Produto on produto.codigo = movimentoProduto.produto )" & _
        "inner join movimento  on movimento.codigo = movimentoProduto.movimento )" & _
        "inner join tipoMovimento on tipoMovimento.nome =movimento.tipoMovimento) WHERE tipoMovimento.operacao='" & cbMovimento.Text & "'  and movimento.data BETWEEN #" & dpDataInicio.Value.Date & "# AND " & dpDataTermino.Value & ""

        DAO.join(sql, dgvMovP)

        
    End Sub

    Public Sub filtrar1()
        'Dim dataInicio, dataTermino As DateTime
        dgvMovP.Rows.Clear()
        Dim DAOMP As New MovimentoProdutoDAO
        Dim lista As New ArrayList
        lista = DAOMP.carregarDados()
        For Each movP As MovimentoProduto In lista
            Dim DAOP As New ProdutoDAO
            Dim produto As New Produto
            Dim DAOMov As New MovimentoDAO
            Dim mov As New Movimento
            mov = DAOMov.search_cod(movP.movimentoP)
            Dim DAOTM As New TipoMovimentoDAO
            Dim tpMov As New TipoMovimento
            tpMov = DAOTM.search_nome(mov.tipoMovMS)
            produto = DAOP.search_cod(movP.produtoP)
            If tpMov.operacaoTM = cbMovimento.Text Then
                If dpDataInicio.Value <= dpDataTermino.Value Then
                    If CDate(FormatDateTime(dpDataInicio.Value, vbShortDate)) <= CDate(FormatDateTime(mov.dateMS, vbShortDate)) Then
                        If CDate(FormatDateTime(mov.dateMS, vbShortDate)) <= CDate(FormatDateTime(dpDataTermino.Value, vbShortDate)) Then
                            dgvMovP.Rows.Add(tpMov.operacaoTM, mov.dateMS, produto.nomeProduto, movP.qtdP, movP.precoP)
                        End If
                    End If
                Else
                    MessageBox.Show("Erro a data de Termino nao pode ser menor que a data de inicio")
                End If

            End If
        Next
    End Sub
    Public Sub filtroMeses()
        If (cbPeriodo.SelectedIndex = 0) Then

        ElseIf (cbPeriodo.SelectedIndex = 1) Then
            dpDataInicio.Value = CDate("01/01/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("31/02/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 2) Then
            dpDataInicio.Value = CDate("01/02/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("28/02/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 3) Then
            dpDataInicio.Value = CDate("01/03/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("31/03/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 4) Then
            dpDataInicio.Value = CDate("01/04/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("30/04/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 5) Then
            dpDataInicio.Value = CDate("01/05/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("31/05/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 6) Then
            dpDataInicio.Value = CDate("01/06/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("30/06/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 7) Then
            dpDataInicio.Value = CDate("01/07/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("31/07/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 8) Then
            dpDataInicio.Value = CDate("01/08/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("31/08/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 9) Then
            dpDataInicio.Value = CDate("01/09/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("30/09/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 10) Then
            dpDataInicio.Value = CDate("01/10/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("31/10/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 11) Then
            dpDataInicio.Value = CDate("01/11/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("30/11/" & dpDataInicio.Value.Year)
        ElseIf (cbPeriodo.SelectedIndex = 12) Then
            dpDataInicio.Value = CDate("01/12/" & dpDataInicio.Value.Year)
            dpDataTermino.Value = CDate("31/12/" & dpDataInicio.Value.Year)
        End If
    End Sub

    Private Sub FormRegistosMov_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbMovimento.SelectedIndex = 0
        cbPeriodo.SelectedIndex = 0
        Filtrar()
    End Sub

    Private Sub cbMovimento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMovimento.SelectedIndexChanged

    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Filtrar()
    End Sub

    Private Sub cpPeriodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPeriodo.SelectedIndexChanged
        filtroMeses()
    End Sub

    Private Sub dpDataInicio_ValueChanged(sender As Object, e As EventArgs) Handles dpDataInicio.ValueChanged
        If (dpDataInicio.Value.Month <> cbPeriodo.SelectedIndex) Then
            filtroMeses()
        End If

    End Sub

    Private Sub dpDataTermino_ValueChanged(sender As Object, e As EventArgs) Handles dpDataTermino.ValueChanged
        If (dpDataTermino.Value.Month <> cbPeriodo.SelectedIndex) Then
            filtroMeses()
        End If
    End Sub




    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub

    Private Sub btnRelatorio_Click_1(sender As Object, e As EventArgs) Handles btnRelatorio.Click
        Dim frm As New FrmReportView
        frm.proOperacao = cbMovimento.Text
        frm.proDataInicio = CDate(FormatDateTime(dpDataInicio.Value, vbShortDate))
        frm.proDataTermino = CDate(FormatDateTime(dpDataTermino.Value, vbShortDate))
        frm.ShowDialog()
    End Sub
End Class