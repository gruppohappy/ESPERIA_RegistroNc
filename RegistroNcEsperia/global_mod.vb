Imports System.Data.OleDb

Module global_mod

    Public frm1 As Form1
    Public frmImb As frmImballi
    Public frmChiusura As frmDatiChiusura
    Public frmShowAllegati As frmAllegati
    Public frmValFornitori As frmValidazioneFornitori
    Public frmListaFornitori As frmFornitori

    Public myConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\Srv-galileoesp.esperiadom.locale\esperia\ISO9001_2008-CERTIFICAZIONE ESPERIA\03 PROCEDURE DELLA QUALITA'\3.10 GESTIONE NON CONFORMITA'\3.10.05 20160830 Registro_NC_AC.mdb;"  ' real
    'Public myConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\3.10.05 20160830 Registro_NC_AC.mdb"   ' debug

    Public cnDB As New OleDbConnection
    Public myDA As New OleDbDataAdapter
    Public myCommand As New OleDbCommand
    Public query As String = ""
    Public tipoOperazione As String = ""
    Public idNC As String = ""
    Public progressivoSelezionato As String = ""
    Public tabNewNC, tabAnomalie, tabOriginiAnomalie, tabDatiAggiuntivi, tabMacroCat, tabDifettiCritici, tabCategorie, tabGravita, tabFrequenza As New DataTable
    Public tabCapiturno, tabRespTermo, tabRespEstr, tabArtEsperia, tabMateriali, tabAC, tabNC, tmpTab As New DataTable
    Public closing_form As Boolean = False

    Public tmpOrigineAnomalia As String = ""
    Public pathCartella As String = ""
    Public reloadRequest As Boolean = False
    Public tmpPezzatura As Integer = 0
    Public loadingData As Boolean = False

    Public Sub loadNC()
        query = "SELECT * FROM Registro_NC order by NUMERO_PROGRESSIVO asc"

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        cnDB.Open()
        myDA.Fill(tabNC)
        cnDB.Close()
    End Sub

    Public Sub loadAC(ByVal _idNC As String)
        query = "SELECT * FROM AZIONI_CORRETTIVE left join Registro_NC ON Registro_NC.ID = AZIONI_CORRETTIVE.ID_NC WHERE ID_NC=" & _idNC & " ORDER BY PROGRESSIVO_AC asc"

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        tabAC.Clear()
        cnDB.Open()
        myDA.Fill(tabAC)
        cnDB.Close()
    End Sub

End Module
