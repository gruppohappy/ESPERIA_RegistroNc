Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word

Public Class frmDatiChiusura

    Public checkingAC As Boolean = False

    Private Sub frmDatiChiusura_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        frmImb.Close()
        frmImb = Nothing

        cmbNumeroProgressivo.Items.Clear()
        cmbNumeroProgressivo.Items.Add(progressivoSelezionato)
        cmbNumeroProgressivo.SelectedIndex = 0

        For Each row In tabNC.Rows
            If row("NUMERO_PROGRESSIVO") = cmbNumeroProgressivo.Text.ToString Then
                If Not IsDBNull(row("INTERVENTO_IMMEDIATO")) Then
                    txtInterventoImmediato.Text = row("INTERVENTO_IMMEDIATO")
                Else
                    txtInterventoImmediato.Text = ""
                End If

                If Not IsDBNull(row("RISULTATI_INTERVENTO_IMMEDIATO")) Then
                    txtRisultatoInterventoImmediato.Text = row("RISULTATI_INTERVENTO_IMMEDIATO")
                Else
                    txtRisultatoInterventoImmediato.Text = ""
                End If

                If Not IsDBNull(row("OGGETTO_REPORT")) Then
                    txtOggettoReport.Text = row("OGGETTO_REPORT")
                Else
                    txtOggettoReport.Text = ""
                End If

                If Not IsDBNull(row("RISPOSTA_CLIENTE")) Then
                    txtRispostaCliente.Text = row("RISPOSTA_CLIENTE")
                Else
                    txtRispostaCliente.Text = ""
                End If

                If Not IsDBNull(row("COSTO_NC")) Then
                    txtCostoNc.Text = row("COSTO_NC")
                Else
                    txtCostoNc.Text = ""
                End If

                If Not IsDBNull(row("NOTE")) Then
                    txtNote.Text = row("NOTE")
                Else
                    txtNote.Text = ""
                End If

                If Not IsDBNull(row("ANOMALIA_CHIUSA")) Then
                    txtAnomaliaChiusa.Text = row("ANOMALIA_CHIUSA")
                Else
                    txtAnomaliaChiusa.Text = ""
                End If

                If Not IsDBNull(row("DATA_CHIUSURA")) AndAlso row("DATA_CHIUSURA") <> "1/1/1900" Then
                    checkDataChiusura.Checked = True
                    dtpDataChiusura.Value = CDate(row("DATA_CHIUSURA"))
                Else
                    checkDataChiusura.Checked = False
                    dtpDataChiusura.Value = Today
                End If

                If Not IsDBNull(row("NOTE")) Then
                    txtNote.Text = row("NOTE")
                Else
                    txtNote.Text = ""
                End If

                If Not IsDBNull(row("ANOMALIA_CHIUSA")) Then
                    txtAnomaliaChiusa.Text = row("ANOMALIA_CHIUSA")
                Else
                    txtAnomaliaChiusa.Text = ""
                End If

                If Not IsDBNull(row("OGGETTO_REPORT")) Then
                    txtOggettoReport.Text = row("OGGETTO_REPORT")
                Else
                    txtOggettoReport.Text = ""
                End If

                If Not IsDBNull(row("COSTO_NC")) Then
                    txtCostoNc.Text = row("COSTO_NC")
                Else
                    txtCostoNc.Text = ""
                End If

                If Not IsDBNull(row("RISPOSTA_CLIENTE")) Then
                    txtRispostaCliente.Text = row("RISPOSTA_CLIENTE")
                Else
                    txtRispostaCliente.Text = ""
                End If


                cmbNumAzioneCorrettiva.Items.Clear()

                loadAC(idNC)

                If tabAC.Rows.Count > 0 Then
                    For Each rowAC In tabAC.Rows
                        cmbNumAzioneCorrettiva.Items.Add(rowAC("PROGRESSIVO_AC"))
                        cmbAperturaAC.SelectedItem = rowAC("APERTURA")
                        txtResponsabileAttuazione.Text = rowAC("Responsabile_Attuazione")
                        txtRespVerEfficacia.Text = rowAC("Responsabile_Verifica_Efficacia")

                        If rowAC("Data_Prevista_Attuazione") <> "1/1/1900" Then
                            dtpAttuazione.Value = CDate(rowAC("Data_Prevista_Attuazione"))
                            dtpAttuazione.Enabled = True
                            checkDataAtt.Checked = True
                        Else
                            dtpAttuazione.Value = CDate("01/01/1900")
                            dtpAttuazione.Enabled = False
                            checkDataAtt.Checked = False
                        End If

                        If rowAC("Data_Verifica_Efficacia") <> "1/1/1900" Then
                            dtpEfficacia.Value = CDate(rowAC("Data_Verifica_Efficacia"))
                            dtpEfficacia.Enabled = True
                            checkVerEfficacia.Checked = True
                        Else
                            dtpEfficacia.Value = CDate("01/01/1900")
                            dtpEfficacia.Enabled = False
                            checkVerEfficacia.Checked = False
                        End If

                        txtModVerEfficacia.Text = rowAC("Modalita_Verifica_Efficacia")
                        txtCausaIndividuata.Text = rowAC("Causa_individuata")
                        txtDescrAC.Text = rowAC("Descrizione")
                        txtEsitoAC.Text = rowAC("Esito")
                        cmbEfficacia.Text = rowAC("EFFICACIA_ROOT_CAUSE")
                    Next
                Else
                    cmbAperturaAC.SelectedItem = ""
                    txtResponsabileAttuazione.Text = ""
                    txtRespVerEfficacia.Text = ""

                    checkDataAtt.Checked = False
                    dtpAttuazione.Enabled = False

                    checkVerEfficacia.Checked = False
                    dtpEfficacia.Enabled = False

                    txtModVerEfficacia.Text = ""
                    txtCausaIndividuata.Text = ""
                    txtDescrAC.Text = ""
                    txtEsitoAC.Text = ""
                    cmbEfficacia.Text = ""
                End If

            End If
        Next

        If tabAC.Rows.Count > 0 Then
            cmbNumAzioneCorrettiva.SelectedIndex = cmbNumAzioneCorrettiva.Items.Count - 1
        End If

    End Sub

    Private Sub btnStampa_Click(sender As System.Object, e As System.EventArgs) Handles btnStampa.Click

        Dim tmpragsoc As String = ""
        Dim tmpvia As String = ""
        Dim tmpcap As String = ""
        Dim tmpcitta As String = ""

        For Each row In tabOriginiAnomalie.Rows
            If row("ID") = tmpOrigineAnomalia Then
                If Not IsDBNull(row("ZONA")) Then tmpragsoc = row("ZONA")
                If Not IsDBNull(row("VIA")) Then tmpvia = row("VIA")
                If Not IsDBNull(row("CAP")) Then tmpcap = row("CAP")
                If Not IsDBNull(row("CITTA")) Then tmpcitta = row("CITTA")
            End If
        Next


        My.Computer.FileSystem.CopyFile(
            "\\Srv-galileoesp\esperia\APPLICAZIONI\RegistroNc\report\report.docx",
                "\\Srv-galileoesp\esperia\APPLICAZIONI\RegistroNc\report\tmp_report.docx",
                Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
                Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)


        Dim oWord As Word.Application
        Dim oDoc As Word.Document

        'Start Word and open the document template.
        oWord = New Word.Application
        oDoc = oWord.Documents.Open("\\Srv-galileoesp\esperia\APPLICAZIONI\RegistroNc\report\tmp_report.docx")
        oWord.Visible = False

        oDoc.Bookmarks.Item("DATA_SEGNALAZIONE").Select()
        oDoc.Bookmarks.Item("DATA_SEGNALAZIONE").Range().Text = Today.ToString.Replace("00:00:00", "")

        oDoc.Bookmarks.Item("RAGS_CLIENTE").Select()
        oDoc.Bookmarks.Item("RAGS_CLIENTE").Range().Text = tmpragsoc

        oDoc.Bookmarks.Item("VIA").Select()
        oDoc.Bookmarks.Item("VIA").Range().Text = tmpvia

        oDoc.Bookmarks.Item("CAP").Select()
        oDoc.Bookmarks.Item("CAP").Range().Text = tmpcap

        oDoc.Bookmarks.Item("CITTA").Select()
        oDoc.Bookmarks.Item("CITTA").Range().Text = tmpcitta

        oDoc.Bookmarks.Item("OGGETTO").Select()
        oDoc.Bookmarks.Item("OGGETTO").Range().Text = txtOggettoReport.Text

        oDoc.Bookmarks.Item("TESTO").Select()
        oDoc.Bookmarks.Item("TESTO").Range().Text = txtRispostaCliente.Text.ToString

        oWord.PrintOut()
        oDoc.Close()

        My.Computer.FileSystem.DeleteFile("\\Srv-galileoesp\esperia\APPLICAZIONI\RegistroNc\report\tmp_report.docx")

        oDoc = Nothing
        oWord.Quit()
        oWord = Nothing
    End Sub

    Private Sub btnProcedi_Click(sender As System.Object, e As System.EventArgs) Handles btnProcedi.Click

        updateAC()

        Dim tmpDataChiusura As String = ""
        Dim costoNC As String = ""

        If checkDataChiusura.Checked Then
            tmpDataChiusura = dtpDataChiusura.Value.ToString
        Else
            tmpDataChiusura = "1/1/1900"
        End If

        ' Cambio il punto in virgola
        costoNC = Replace(txtCostoNc.Text, ".", ",")

        query = "UPDATE Registro_NC SET " &
                   "INTERVENTO_IMMEDIATO = '" & txtInterventoImmediato.Text.Replace("'", "") & "'," &
                   " RISULTATI_INTERVENTO_IMMEDIATO = '" & txtRisultatoInterventoImmediato.Text.Replace("'", "") & "'," &
                   " OGGETTO_REPORT = '" & txtOggettoReport.Text.Replace("'", "") & "'," &
                   " COSTO_NC = '" & costoNC & "'," &
                   " Registro_NC.NOTE = '" & txtNote.Text.Replace("'", "") & "'," &
                   " ANOMALIA_CHIUSA = '" & txtAnomaliaChiusa.Text.Replace("'", "") & "', " &
                  " RISPOSTA_CLIENTE = '" & txtRispostaCliente.Text.Replace("'", "") & "'"  'no sav. richiesto da Marco il (13/10/??) --> Richiesta integrazione nell'update - Davide Masini 25/01/21
        query = query & ", DATA_CHIUSURA = '" & tmpDataChiusura & "' "

        query = query & " where ID = " & idNC & ""

        cnDB.Open()

        myDA.UpdateCommand = New OleDbCommand(query, cnDB)
        myDA.UpdateCommand.ExecuteNonQuery()
        cnDB.Close()

        frm1.Show()
        closing_form = True
        tipoOperazione = "MODIFICA"
        frmChiusura.Close()
        closing_form = False
    End Sub

    Private Sub cmbNumAzioneCorrettiva_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbNumAzioneCorrettiva.SelectedIndexChanged

        For Each rowAC In tabAC.Rows

            If cmbNumAzioneCorrettiva.SelectedItem = rowAC("PROGRESSIVO_AC") Then
                cmbAperturaAC.SelectedItem = rowAC("APERTURA")
                txtResponsabileAttuazione.Text = rowAC("Responsabile_Attuazione")
                txtRespVerEfficacia.Text = rowAC("Responsabile_Verifica_Efficacia")


                If rowAC("Data_Prevista_Attuazione") <> "1/1/1900" Then
                    dtpAttuazione.Value = CDate(rowAC("Data_Prevista_Attuazione"))
                    dtpAttuazione.Enabled = True
                    checkDataAtt.Checked = True
                Else
                    dtpAttuazione.Value = CDate("1/1/1900")
                    dtpAttuazione.Enabled = False
                    checkDataAtt.Checked = False
                End If

                If rowAC("Data_Verifica_Efficacia") <> "1/1/1900" Then
                    dtpEfficacia.Value = CDate(rowAC("Data_Verifica_Efficacia"))
                    dtpEfficacia.Enabled = True
                    checkVerEfficacia.Checked = True
                Else
                    dtpEfficacia.Value = CDate("1/1/1900")
                    dtpEfficacia.Enabled = False
                    checkVerEfficacia.Checked = False
                End If

                txtModVerEfficacia.Text = rowAC("Modalita_Verifica_Efficacia")
                txtCausaIndividuata.Text = rowAC("Causa_individuata")
                txtDescrAC.Text = rowAC("Descrizione")
                txtEsitoAC.Text = rowAC("Esito")
                cmbEfficacia.Text = rowAC("EFFICACIA_ROOT_CAUSE")
            End If
        Next

    End Sub

    Private Sub cmbNumAzioneCorrettiva_MouseEnter(sender As System.Object, e As System.EventArgs) Handles cmbNumAzioneCorrettiva.MouseEnter
        updateAC()
    End Sub

    Private Sub btnNewAC_Click(sender As System.Object, e As System.EventArgs) Handles btnNewAC.Click

        Dim newAcProgr As String = ""

        query = "SELECT top 1 * FROM AZIONI_CORRETTIVE left join Registro_NC ON Registro_NC.ID = AZIONI_CORRETTIVE.ID_NC WHERE ID_NC=" & idNC & " ORDER BY PROGRESSIVO_AC desc"

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        tmpTab.Clear()
        cnDB.Open()
        myDA.Fill(tmpTab)
        cnDB.Close()

        For Each row In tmpTab.Rows
            newAcProgr = row("PROGRESSIVO_AC")
        Next

        If newAcProgr = "" Then
            newAcProgr = "1"
        Else
            newAcProgr = (CInt(newAcProgr) + 1).ToString
        End If

        ' Aggiunta campo efficacia nell'insert
        query = "INSERT INTO AZIONI_CORRETTIVE(ID_NC,PROGRESSIVO_AC,APERTURA,CAUSA_INDIVIDUATA,DESCRIZIONE,RESPONSABILE_ATTUAZIONE,RESPONSABILE_VERIFICA_EFFICACIA,DATA_PREVISTA_ATTUAZIONE,DATA_VERIFICA_EFFICACIA,MODALITA_VERIFICA_EFFICACIA,ESITO, EFFICACIA_ROOT_CAUSE)" &
                " VALUES (" & idNC & ", " & newAcProgr & ",'Non applicabile','','','','','01/01/1900','01/01/1900','','','')"
        cnDB.Open()

        myDA.UpdateCommand = New OleDbCommand(query, cnDB)
        myDA.UpdateCommand.ExecuteNonQuery()

        cnDB.Close()

        loadAC(idNC)

        cmbNumAzioneCorrettiva.Items.Clear()

        For Each rowac In tabAC.Rows
            cmbNumAzioneCorrettiva.Items.Add(rowac("PROGRESSIVO_AC"))
        Next

        cmbNumAzioneCorrettiva.SelectedItem = newAcProgr
    End Sub

    Private Sub checkDataAtt_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkDataAtt.CheckedChanged
        If checkDataAtt.Checked Then
            dtpAttuazione.Enabled = True
        Else
            dtpAttuazione.Enabled = False
        End If
    End Sub

    Private Sub checkVerEfficacia_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkVerEfficacia.CheckedChanged
        If checkVerEfficacia.Checked Then
            dtpEfficacia.Enabled = True
        Else
            dtpEfficacia.Enabled = False
        End If
    End Sub

    Private Sub updateAC()

        If cmbNumAzioneCorrettiva.SelectedItem <> Nothing Then
            If cmbNumAzioneCorrettiva.Items.Count > 0 Then

                If cmbAperturaAC.SelectedItem = Nothing Then
                    cmbAperturaAC.SelectedIndex = 3
                End If

                ' Aggiunta campo efficacia nell'update della query
                query = "UPDATE AZIONI_CORRETTIVE SET " &
                               "CAUSA_INDIVIDUATA='" & txtCausaIndividuata.Text & "', " &
                               "APERTURA='" & cmbAperturaAC.SelectedItem.ToString & "', " &
                               "DESCRIZIONE='" & txtDescrAC.Text.Replace("'", "") & "', " &
                               "RESPONSABILE_ATTUAZIONE='" & txtResponsabileAttuazione.Text.Replace("'", "") & "', " &
                               "RESPONSABILE_VERIFICA_EFFICACIA='" & txtRespVerEfficacia.Text.Replace("'", "") & "', " &
                               "MODALITA_VERIFICA_EFFICACIA='" & txtModVerEfficacia.Text.Replace("'", "") & "', " &
                               "ESITO='" & txtEsitoAC.Text.Replace("'", "") & "', " &
                               "EFFICACIA_ROOT_CAUSE='" & cmbEfficacia.Text & "' "

                If checkVerEfficacia.Checked Then
                    query = query & ", DATA_VERIFICA_EFFICACIA='" & dtpEfficacia.Value.ToString.Replace(" 00:00:00", "") & "', "
                Else
                    query = query & ", DATA_VERIFICA_EFFICACIA='01/01/1900', "
                End If

                If checkDataAtt.Checked Then
                    query = query & " DATA_PREVISTA_ATTUAZIONE='" & dtpAttuazione.Value.ToString.Replace(" 00:00:00", "") & "' "
                Else
                    query = query & " DATA_PREVISTA_ATTUAZIONE='01/01/1900' "
                End If



                query = query & "where ID_NC = " & idNC & " and PROGRESSIVO_AC=" & cmbNumAzioneCorrettiva.SelectedItem.ToString & ""
                cnDB.Open()

                myDA.UpdateCommand = New OleDbCommand(query, cnDB)
                myDA.UpdateCommand.ExecuteNonQuery()

                cnDB.Close()

                Dim tmpSelAC As String = cmbNumAzioneCorrettiva.SelectedItem.ToString

                loadAC(idNC)
            End If
        End If
    End Sub

    Private Sub btnAllegati_Click(sender As System.Object, e As System.EventArgs) Handles btnAllegati.Click
        If Not System.IO.Directory.Exists("\\Srv-galileoesp\esperia\ISO9001_2008-CERTIFICAZIONE ESPERIA\03 PROCEDURE DELLA QUALITA'\3.10 GESTIONE NON CONFORMITA'\FILES_NC\" & cmbNumeroProgressivo.Text & "_" & tmpOrigineAnomalia) Then
            System.IO.Directory.CreateDirectory("\\Srv-galileoesp\esperia\ISO9001_2008-CERTIFICAZIONE ESPERIA\03 PROCEDURE DELLA QUALITA'\3.10 GESTIONE NON CONFORMITA'\FILES_NC\" & cmbNumeroProgressivo.Text & "_" & tmpOrigineAnomalia)
        End If

        pathCartella = "\\Srv-galileoesp\esperia\ISO9001_2008-CERTIFICAZIONE ESPERIA\03 PROCEDURE DELLA QUALITA'\3.10 GESTIONE NON CONFORMITA'\FILES_NC\" & cmbNumeroProgressivo.Text & "_" & tmpOrigineAnomalia

        frmShowAllegati = New frmAllegati
        frmShowAllegati.ShowDialog()
    End Sub

    Private Sub frmDatiChiusura_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If Not closing_form Then
            frm1.Close()
        End If
    End Sub

    Private Sub checkDataChiusura_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkDataChiusura.CheckedChanged
        If checkDataChiusura.Checked Then
            dtpDataChiusura.Enabled = True
        Else
            dtpDataChiusura.Enabled = False
        End If
    End Sub

    Private Sub txtCostoNc_TextChanged(sender As Object, e As EventArgs) Handles txtCostoNc.TextChanged
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtCostoNc.Text, "[  ^ 0-9]") Then
            txtCostoNc.Text = 0.00
        End If
    End Sub

    Private Sub txtCostoNc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostoNc.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                     AndAlso (Not Char.IsDigit(e.KeyChar) _
                     AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)) _
                     AndAlso (Not e.KeyChar = ","))) Then
            e.Handled = True
        End If
    End Sub
End Class