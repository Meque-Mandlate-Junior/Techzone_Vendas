Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FrmReportView
    Dim dataInicio As Date
    Dim dataTermino As Date
    Private operacao As String
    Public WriteOnly Property proDataInicio() As Date
        Set(value As Date)
            dataInicio = value
        End Set
    End Property
    Public WriteOnly Property proDataTermino() As Date
        Set(value As Date)
            dataTermino = value
        End Set
    End Property

  
    Public WriteOnly Property proOperacao() As String
        Set(value As String)
            operacao = value
        End Set
    End Property
    Public Sub getReport()
        Dim rpt As New ReportMovimentos
        rpt.Load(Application.StartupPath & "\ReportMovimentos.rpt")
        Dim pField As New ParameterField
        Dim pFields As New ParameterFields
        Dim pDiscrete As New ParameterDiscreteValue

        Dim pField1 As New ParameterField
        Dim pDiscrete1 As New ParameterDiscreteValue
        Dim pField2 As New ParameterField
        Dim pDiscrete2 As New ParameterDiscreteValue

        pField.Name = "pDataInicio"
        pDiscrete.Value = dataInicio
        pField.CurrentValues.Add(pDiscrete)
        pFields.Add(pField)

        pField1.Name = "pDataTermino"
        pDiscrete1.Value = dataTermino
        pField1.CurrentValues.Add(pDiscrete1)
        pFields.Add(pField1)

        pField2.Name = "pOperacao"
        pDiscrete2.Value = operacao
        pField1.CurrentValues.Add(pDiscrete2)
        pFields.Add(pField2)
      

        CrystalReportViewer1.ReportSource = rpt
        CrystalReportViewer1.ParameterFieldInfo = pFields

    End Sub
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        '' getReport()
    End Sub

    Private Sub FrmReportView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reportLucroEstimando()

    End Sub

    Public Sub reportLucroEstimando()

        If Not operacao = String.Empty Then


            ' carrega o relatorio desejado

            ''Dim strReportName As String = "CrystalReport1.rpt"

            '

            'define o caminho e nome do relatorio
            Dim strReportPath As String = "C:\Sistema VB\Techzone_Vendas\Techzone_Vendas\View_Controller\ReportLucros.rpt"
            'Dim strReportPath As String = "D:\Documents and Settings\Meus documentos\Visual Studio 2005\Projects\CrystalReports1\ _"
            '    CrystalReports1" & "\" & strReportName & ".rpt"

            '

            'verifiqa se o arquivo existe

            If Not IO.File.Exists(strReportPath) Then

                Throw (New Exception("Relatorio não localizado :" & vbCrLf & strReportPath))

            End If

            '

            'instancia o relaorio e carrega

            Dim CR As New ReportDocument

            CR.Load(strReportPath)

            '

            ' atribui os parametros declarados aos objetos relacionados

            Dim crParameterFieldDefinitions As ParameterFieldDefinitions


            Dim crParameterDiscreteValue As ParameterDiscreteValue

            Dim crParameterFieldLocation As ParameterFieldDefinition

            Dim crParameterValues As ParameterValues


            Dim crParameterDiscreteValue1 As ParameterDiscreteValue

            Dim crParameterFieldLocation1 As ParameterFieldDefinition

            Dim crParameterValues1 As ParameterValues


            '

            ' Pega a coleção de parametros do relatorio

            crParameterFieldDefinitions = CR.DataDefinition.ParameterFields

            '

            ' define o primeiro parametro

            ' - pega o parametro e diz a ela para usar os valores atuais

            ' - define o valor do parametro

            ' - inclui e aplica o valor

            ' - repete para cada parametro se for o caso (não é o caso deste exemplo)

            ' Vamos usar o parametro 'cidade'


            crParameterFieldLocation = crParameterFieldDefinitions.Item("pDataInicio")

            crParameterValues = crParameterFieldLocation.CurrentValues

            crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue


            crParameterFieldLocation1 = crParameterFieldDefinitions.Item("pDataTermino")

            crParameterValues1 = crParameterFieldLocation1.CurrentValues

            crParameterDiscreteValue1 = New CrystalDecisions.Shared.ParameterDiscreteValue





            'obtem o valor da caixa de texto
            crParameterDiscreteValue1.Value = dataInicio
            crParameterValues1.Add(crParameterDiscreteValue1)
            crParameterFieldLocation1.ApplyCurrentValues(crParameterValues1)


            crParameterDiscreteValue1.Value = dataTermino
            crParameterValues1.Add(crParameterDiscreteValue1)
            crParameterFieldLocation1.ApplyCurrentValues(crParameterValues1)

            '

            ' Define a fonte do controle Crystal Report Viewer como sendo o relatorio definido acima

            CrystalReportViewer1.ReportSource = CR

        Else

            MsgBox("Informe o tipo de mvimento e periodo.", MsgBoxStyle.Information, "Techzon_Vendas")
        End If

    End Sub


    Public Sub reportMovimentos()
        If Not operacao = String.Empty Then


            ' carrega o relatorio desejado

            ''Dim strReportName As String = "CrystalReport1.rpt"

            '

            'define o caminho e nome do relatorio
            Dim strReportPath As String = "C:\Sistema VB\Techzone_Vendas\Techzone_Vendas\View_Controller\ReportMovimentos.rpt"
            'Dim strReportPath As String = "D:\Documents and Settings\Meus documentos\Visual Studio 2005\Projects\CrystalReports1\ _"
            '    CrystalReports1" & "\" & strReportName & ".rpt"

            '

            'verifiqa se o arquivo existe

            If Not IO.File.Exists(strReportPath) Then

                Throw (New Exception("Relatorio não localizado :" & vbCrLf & strReportPath))

            End If

            '

            'instancia o relaorio e carrega

            Dim CR As New ReportDocument

            CR.Load(strReportPath)

            '

            ' atribui os parametros declarados aos objetos relacionados

            Dim crParameterFieldDefinitions As ParameterFieldDefinitions


            Dim crParameterDiscreteValue As ParameterDiscreteValue

            Dim crParameterFieldLocation As ParameterFieldDefinition

            Dim crParameterValues As ParameterValues


            Dim crParameterDiscreteValue1 As ParameterDiscreteValue

            Dim crParameterFieldLocation1 As ParameterFieldDefinition

            Dim crParameterValues1 As ParameterValues


            Dim crParameterDiscreteValue2 As ParameterDiscreteValue

            Dim crParameterFieldLocation2 As ParameterFieldDefinition

            Dim crParameterValues2 As ParameterValues
            '

            ' Pega a coleção de parametros do relatorio

            crParameterFieldDefinitions = CR.DataDefinition.ParameterFields

            '

            ' define o primeiro parametro

            ' - pega o parametro e diz a ela para usar os valores atuais

            ' - define o valor do parametro

            ' - inclui e aplica o valor

            ' - repete para cada parametro se for o caso (não é o caso deste exemplo)

            ' Vamos usar o parametro 'cidade'

            crParameterFieldLocation = crParameterFieldDefinitions.Item("pOperacao")

            crParameterValues = crParameterFieldLocation.CurrentValues

            crParameterDiscreteValue = New CrystalDecisions.Shared.ParameterDiscreteValue

            crParameterFieldLocation1 = crParameterFieldDefinitions.Item("pDataInicio")

            crParameterValues1 = crParameterFieldLocation.CurrentValues

            crParameterDiscreteValue1 = New CrystalDecisions.Shared.ParameterDiscreteValue

            crParameterFieldLocation2 = crParameterFieldDefinitions.Item("pDataTermino")

            crParameterValues2 = crParameterFieldLocation.CurrentValues

            crParameterDiscreteValue2 = New CrystalDecisions.Shared.ParameterDiscreteValue





            'obtem o valor da caixa de texto

            crParameterDiscreteValue.Value = operacao

            crParameterValues.Add(crParameterDiscreteValue)

            crParameterFieldLocation.ApplyCurrentValues(crParameterValues)


            crParameterDiscreteValue1.Value = dataInicio

            crParameterValues1.Add(crParameterDiscreteValue1)

            crParameterFieldLocation1.ApplyCurrentValues(crParameterValues1)


            crParameterDiscreteValue2.Value = dataTermino

            crParameterValues2.Add(crParameterDiscreteValue2)

            crParameterFieldLocation2.ApplyCurrentValues(crParameterValues2)

            '

            ' Define a fonte do controle Crystal Report Viewer como sendo o relatorio definido acima

            CrystalReportViewer1.ReportSource = CR

        Else

            MsgBox("Informe o tipo de mvimento e periodo.", MsgBoxStyle.Information, "Techzon_Vendas")
        End If

    End Sub
End Class