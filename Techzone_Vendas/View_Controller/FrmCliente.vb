Imports System.Data.OleDb
Public Class FrmCliente
    Public Sub ProcuraPorNuit(ByVal nuit As String)
        Dim DAO As New ClienteDAO
        Dim cl As New Cliente
        cl = DAO.search_nuitAccess(nuit)
        txtNuit.Text = cl.NuitCliente
        txtNome.Text = cl.NomeCliente
        txtMorada.Text = cl.MoradaCliente
    End Sub

    Public Sub preencheDGV()
        Dim lista As New ArrayList()
        Dim rpCliente As New ReposityCliente
        lista = rpCliente.returnDados()
        dgvClientes.Rows.Clear()
        For Each cl As Cliente In lista
            dgvClientes.Rows.Add(cl.NomeCliente, cl.NuitCliente, cl.MoradaCliente)
        Next
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim cliente As New Cliente
        cliente.NomeCliente = txtNome.Text
        cliente.NuitCliente = Convert.ToInt64((txtNuit.Text).Trim)
        cliente.MoradaCliente = txtMorada.Text
        Dim rpCliente As New ReposityCliente
        Dim item As String = dgvClientes.CurrentRow.Cells(1).Value.ToString()
        If (item.Length < 1) Then
            item = InputBox("Informe o Nuit do Registo que pretende Alterar")
            rpCliente.update(cliente, Convert.ToInt64(item))
        Else
            rpCliente.update(cliente, Convert.ToInt64(item))
        End If
        preencheDGV()
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        Dim cliente As New Cliente
        cliente.NomeCliente = txtNome.Text
        cliente.NuitCliente = Convert.ToInt64((txtNuit.Text).Trim)
        cliente.MoradaCliente = txtMorada.Text
        Dim rpCliente As New ReposityCliente
        rpCliente.Insert(cliente)
        preencheDGV()
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        Dim cliente As New Cliente
        Dim DAO As New ClienteDAO
        Dim rpCliente As New ReposityCliente
        Dim nuit As String = InputBox("Informe o Nuit do Registro que Pretende Remover")
        cliente = DAO.search_nuitAccess(nuit)
        If String.IsNullOrEmpty(cliente.NomeCliente) Then
            MessageBox.Show("Falha Registo com o Nuit _" + nuit + " _não Encontrado!")
        Else
            rpCliente.delete(cliente)
        End If
        preencheDGV()
    End Sub

    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        preencheDGV()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProcuraPorNuit(txtNuit.Text)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub

    Private Sub dgvClientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellDoubleClick
        txtNome.Text = dgvClientes.CurrentRow.Cells(0).Value.ToString
        txtNuit.Text = dgvClientes.CurrentRow.Cells(1).Value.ToString
        txtMorada.Text = dgvClientes.CurrentRow.Cells(2).Value.ToString
    End Sub
End Class