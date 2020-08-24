Imports System.Data.OleDb
Public Class FrmGraficoProduto
    Private valorJaneiro As Double = 0
    Private valorFevereiro As Double = 0
    Private valorMarço As Double = 0
    Private valorAbril As Double = 0
    Private valorMaio As Double = 0
    Private valorJunho As Double = 0
    Private valorJulho As Double = 0
    Private valorAgosto As Double = 0
    Private valorSetembro As Double = 0
    Private valorOutubro As Double = 0
    Private valorNovembro As Double = 0
    Private valorDezembro As Double = 0
    Private codigoProduto As String
    Private dataInicio As DateTime
    Private dataTermino As DateTime

    Public Property prtyCodigoProduto() As String
        Get
            Return codigoProduto
        End Get
        Set(value As String)
            codigoProduto = value
        End Set
    End Property

    Public Property prtyDataInicio() As DateTime
        Get
            Return dataInicio
        End Get
        Set(value As DateTime)
            dataInicio = value
        End Set
    End Property

    Public Property prtyDataTermino() As DateTime
        Get
            Return dataTermino
        End Get
        Set(value As DateTime)
            dataTermino = value
        End Set
    End Property


    Private Sub FrmGraficoProduto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chartLucro.ChartAreas(0).AxisX.Interval = 1
        Dim command As OleDbCommand
            Dim sql As String
            Dim dataReader As OleDbDataReader
            Dim valorEntradas As Double = 0
            Dim valorSaidas As Double = 0
            Dim precoUnitarioEntrada As Double = 0
            Dim precoUnitarioSaidas As Double = 0
        Dim data As DateTime
            Try

                ConnectionString.Connection()
                sql = "Select tipoMovimento.operacao,movimento.data,MovimentoProduto.qtd,MovimentoProduto.Preco From ((MovimentoProduto " & _
                   "inner join movimento on movimento.codigo = movimentoProduto.movimento ) " & _
                    "inner join tipoMovimento on tipoMovimento.nome = movimento.tipoMovimento) " & _
                     "Where (MovimentoProduto.produto =" & codigoProduto & ") AND (Movimento.data BETWEEN #" & dataInicio.Month & "/" & dataInicio.Day & "/" & _
                        "" & dataInicio.Year & "# AND #" & dataTermino.Month & "/" & dataTermino.Day & "/" & dataTermino.Year & "# )"
                command = New OleDbCommand(sql, conexao)
                dataReader = command.ExecuteReader()
                Do While dataReader.Read = True
                    If (dataReader(0) = "Saida") Then
                        precoUnitarioSaidas = dataReader(3) / dataReader(2)
                    data = dataReader(1)
                    If (data.Month = 1) Then
                        valorJaneiro = valorJaneiro + (precoUnitarioSaidas * dataReader(2) - (precoUnitarioEntrada * dataReader(2)))
                    ElseIf (data.Month = 2) Then
                        valorFevereiro = valorFevereiro + (precoUnitarioSaidas * dataReader(2) - (precoUnitarioEntrada * dataReader(2)))
                    ElseIf (data.Month = 3) Then
                        valorMarço = valorMarço + (precoUnitarioSaidas * dataReader(2) - (precoUnitarioEntrada * dataReader(2)))
                    ElseIf (data.Month = 4) Then
                        valorAbril = valorAbril + (precoUnitarioSaidas * dataReader(2) - (precoUnitarioEntrada * dataReader(2)))
                    ElseIf (data.Month = 5) Then
                        valorMaio = valorMaio + (precoUnitarioSaidas * dataReader(2) - (precoUnitarioEntrada * dataReader(2)))
                    ElseIf (data.Month = 6) Then
                        valorJunho = valorJunho + (precoUnitarioSaidas * dataReader(2) - (precoUnitarioEntrada * dataReader(2)))
                    ElseIf (data.Month = 7) Then
                        valorJulho = valorJulho + (precoUnitarioSaidas * dataReader(2) - (precoUnitarioEntrada * dataReader(2)))
                    ElseIf (data.Month = 8) Then
                        valorAgosto = valorAgosto + (precoUnitarioSaidas * dataReader(2) - (precoUnitarioEntrada * dataReader(2)))
                    ElseIf (data.Month = 9) Then
                        valorSetembro = valorSetembro + (precoUnitarioSaidas * dataReader(2) - (precoUnitarioEntrada * dataReader(2)))
                    ElseIf (data.Month = 10) Then
                        valorOutubro = valorOutubro + (precoUnitarioSaidas * dataReader(2) - (precoUnitarioEntrada * dataReader(2)))
                    ElseIf (data.Month = 11) Then
                        valorNovembro = valorNovembro + (precoUnitarioSaidas * dataReader(2) - (precoUnitarioEntrada * dataReader(2)))
                    ElseIf (data.Month = 12) Then
                        valorDezembro = valorDezembro + (precoUnitarioSaidas * dataReader(2) - (precoUnitarioEntrada * dataReader(2)))
                    End If
                Else
                    precoUnitarioEntrada = dataReader(3) / dataReader(2)

                End If
                Loop
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ConnectionString.conexao.Close()
        Dim count As Integer = dataInicio.Month

        For i As Integer = dataInicio.Month To dataTermino.Month Step 1
            If (i = 1) Then
                Me.chartLucro.Series("Lucro").Points.AddXY("janeiro", valorJaneiro)
            ElseIf (i = 2) Then
                Me.chartLucro.Series("Lucro").Points.AddXY("Fevereiro", valorFevereiro)
            ElseIf (i = 3) Then
                Me.chartLucro.Series("Lucro").Points.AddXY("Março", valorMarço)
            ElseIf (i = 4) Then
                Me.chartLucro.Series("Lucro").Points.AddXY("Abril", valorAbril)
            ElseIf (i = 5) Then
                Me.chartLucro.Series("Lucro").Points.AddXY("Maio", valorMaio)
            ElseIf (i = 6) Then
                Me.chartLucro.Series("Lucro").Points.AddXY("Junho", valorJunho)
            ElseIf (i = 7) Then
                Me.chartLucro.Series("Lucro").Points.AddXY("Julho", valorJulho)
            ElseIf (i = 8) Then
                Me.chartLucro.Series("Lucro").Points.AddXY("Agosto", valorAgosto)
            ElseIf (i = 9) Then
                Me.chartLucro.Series("Lucro").Points.AddXY("Setembro", valorSetembro)
            ElseIf (i = 10) Then
                Me.chartLucro.Series("Lucro").Points.AddXY("Outubro", valorOutubro)
            ElseIf (i = 11) Then
                Me.chartLucro.Series("Lucro").Points.AddXY("Novembro", valorNovembro)
            ElseIf (i = 12) Then
                Me.chartLucro.Series("Lucro").Points.AddXY("Dezembro", valorDezembro)
            End If
        Next
    End Sub


    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()

    End Sub
End Class