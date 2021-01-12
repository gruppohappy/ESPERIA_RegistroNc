Imports System.Data.OleDb
Imports System.IO

Public Class frmFornitori

    Public tabAnagTipologia, tabAnagQuestionario, tabAnagDocumentazione, tabAnagRivalidazione As New DataTable

    Public tabFornitoriValidati, tabNewFornitori, tabTipologiaAllegatoFornitore, tabAllegati, tabCategoriaFornitori As New DataTable
    Public found As Boolean = False
    Public whereXNuovi As String = ""
    Public rigaSel As Integer = 0
    Public pathBase As String = "\\Srv-galileoesp\esperia\ISO9001_2008-CERTIFICAZIONE ESPERIA\03 PROCEDURE DELLA QUALITA'\3.10 GESTIONE NON CONFORMITA'\ALLEGATI_FORNITORI"
    Public pathSelezionato As String = ""
    Public fileSelezionato As String = ""
    Public estensioneFileSelezionato As String = ""

    Private Sub frmFornitori_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        frmListaFornitori.Height = 771
        frmListaFornitori.Width = 695

        cnDB.Open()

        query = "SELECT * FROM TIPOLOGIE_FORNITORE"

        tabAnagTipologia.Clear()
        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabAnagTipologia)

        For Each row In tabAnagTipologia.Rows
            cmbTipologiaFornitore.Items.Add(row("DESCRIZIONE"))
            cmbIdTipologia.Items.Add(row("ID"))
        Next

        query = "SELECT * FROM ESITI_QUESTIONARIO"

        tabAnagQuestionario.Clear()
        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabAnagQuestionario)

        For Each row In tabAnagQuestionario.Rows
            cmbQuestionario.Items.Add(row("DESCRIZIONE"))
            cmbIdQuestionario.Items.Add(row("ID"))
        Next

        query = "SELECT * FROM ESITI_DOCUMENTAZIONE"

        tabAnagDocumentazione.Clear()
        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabAnagDocumentazione)

        For Each row In tabAnagDocumentazione.Rows
            cmbDocumentazione.Items.Add(row("DESCRIZIONE"))
            cmbIdDocumentazione.Items.Add(row("ID"))
        Next

        query = "SELECT * FROM ESITI_VALIDAZIONE"

        tabAnagRivalidazione.Clear()
        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabAnagRivalidazione)

        For Each row In tabAnagRivalidazione.Rows
            cmbRivalidato.Items.Add(row("DESCRIZIONE"))
            cmbIdRivalidazione.Items.Add(row("ID"))
        Next

        query = "SELECT * FROM TIPI_ALLEGATO_FORNITORE ORDER BY ID ASC"

        tabTipologiaAllegatoFornitore.Clear()
        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabTipologiaAllegatoFornitore)

        For Each row In tabTipologiaAllegatoFornitore.Rows
            cmbTipoFile.Items.Add(row("DESCRIZIONE"))
            cmbIdTipoFile.Items.Add(row("ID"))
            cmbPathTipoFile.Items.Add(row("RADICE"))
        Next

        '*******************************************
        ' Aggiunta menu categoria fornitori su richiesta di Norma 01/07/20
        query = "SELECT * FROM CATEGORIE_FORNITORI"

        tabCategoriaFornitori.Clear()
        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabCategoriaFornitori)

        For Each row In tabCategoriaFornitori.Rows
            cmbCategoriaFornitore.Items.Add(row("DESCRIZIONE"))
            cmbIdCategoriaFornitore.Items.Add(row("ID"))
        Next

        '*******************************************

        cnDB.Close()

        Dim addYear As Integer = CInt(Today.Year)

        For ii As Integer = 0 To 4
            cmbAnno.Items.Add(addYear.ToString)
            addYear += 1
        Next

    End Sub

    Private Sub cmbAnno_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbAnno.SelectedIndexChanged

        Cursor = Cursors.WaitCursor

        frmListaFornitori.Height = 771
        frmListaFornitori.Width = 695


        loadFornitoriValidati("")

        If Not lblNewFornitori.Visible Then
            lblNewFornitori.Visible = True
        End If

        Cursor = Cursors.Default

    End Sub

    Private Sub dgvFornitori_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFornitori.CellDoubleClick

        If e.RowIndex >= 0 Then
            If dgvFornitori.Rows(e.RowIndex).Cells("colNonVisibile").Value.ToString = "" Then
                dgvFornitori.Rows(e.RowIndex).Cells("colNonVisibile").Value = "X"
            Else
                dgvFornitori.Rows(e.RowIndex).Cells("colNonVisibile").Value = ""
            End If

            If btnCheckNuovi.Tag = "CHECK NUOVI" Then

                Dim nonVisibile As Integer = 0

                If dgvFornitori.Rows(e.RowIndex).Cells("colNonVisibile").Value.ToString = "" Then
                    nonVisibile = 1
                End If

                query = "UPDATE FORNITORI_VALIDATI SET " &
                        "VISIBILE=" & nonVisibile.ToString & " " &
                        "WHERE CODICE_FORNITORE ='" & dgvFornitori.Rows(e.RowIndex).Cells("colFornitore").Value.ToString & "'"

                cnDB.Open()

                myDA.UpdateCommand = New OleDbCommand(query, cnDB)
                myDA.UpdateCommand.ExecuteNonQuery()

                cnDB.Close()
            End If
        End If
    End Sub

    Private Sub btnCheckNuovi_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckNuovi.Click

        If btnCheckNuovi.Tag = "CHECK NUOVI" Then

            dgvFornitori.Rows.Clear()

            For Each row In tabNewFornitori.Rows
                dgvFornitori.Rows.Add(row("CodFornitore"), row("RagSociale"), "", "+", "", "", "", "")
            Next

            checkFiltro.Enabled = False
            checkFiltro.Checked = False
            cmbAnno.Enabled = False
            btnCheckNuovi.BackgroundImage = My.Resources.completed_x48
            btnCheckNuovi.Tag = "SALVA"

        Else

            Dim msgResult As Integer = 0

            msgResult = MessageBox.Show("Salvare?", "ATTENZIONE", MessageBoxButtons.YesNo)

            If msgResult = DialogResult.Yes Then

                Cursor = Cursors.WaitCursor

                For ii As Integer = 0 To dgvFornitori.Rows.Count - 1

                    Dim AnnoValidazione As String = cmbAnno.Text
                    Dim C_Fornitore As String = dgvFornitori.Rows(ii).Cells("colFornitore").Value.ToString
                    Dim R_Fornitore As String = dgvFornitori.Rows(ii).Cells("colRagsociale").Value.ToString.Replace("'", "")
                    Dim Visibile As Integer = 0

                    If dgvFornitori.Rows(ii).Cells("colNonVisibile").Value = "" Then
                        Visibile = 1
                    End If

                    query = "INSERT INTO FORNITORI_VALIDATI " &
                            " (ANNO_VALIDAZIONE,CODICE_FORNITORE,RAGIONE_SOCIALE,ID_CATEGORIA_FORNITORE,ID_TIPOLOGIA,ID_QUESTIONARIO,ID_DOCUMENTAZIONE,ID_VALIDAZIONE,NOTE_VARIE,VISIBILE,DATA_INSERIMENTO) " &
                            " VALUES('" & AnnoValidazione & "','" & C_Fornitore & "'," &
                            "'" & R_Fornitore & "',1,1,1,1,1,''," & Visibile & ",'" & Today.Date.Day & "/" & Today.Date.Month & "/" & Today.Date.Day & "')"

                    cnDB.Open()

                    myDA.UpdateCommand = New OleDbCommand(query, cnDB)
                    myDA.UpdateCommand.ExecuteNonQuery()

                    cnDB.Close()

                    Dim pathBase As String = "\\Srv-galileoesp\esperia\ISO9001_2008-CERTIFICAZIONE ESPERIA\03 PROCEDURE DELLA QUALITA'\3.10 GESTIONE NON CONFORMITA'\ALLEGATI_FORNITORI"

                    If Not (System.IO.Directory.Exists(pathBase & "\" & C_Fornitore & "\" & cmbAnno.Text)) Then
                        System.IO.Directory.CreateDirectory(pathBase & "\" & C_Fornitore & "\" & cmbAnno.Text)

                        For Each row In tabTipologiaAllegatoFornitore.Rows
                            If Not (System.IO.Directory.Exists(pathBase & "\" & C_Fornitore & "\" & cmbAnno.Text & "\" & row("RADICE"))) Then
                                System.IO.Directory.CreateDirectory(pathBase & "\" & C_Fornitore & "\" & cmbAnno.Text & "\" & row("RADICE"))
                            End If
                        Next

                    End If
                Next

                Cursor = Cursors.Default

                loadFornitoriValidati("")

                checkFiltro.Enabled = True
                cmbAnno.Enabled = True
                btnCheckNuovi.BackgroundImage = My.Resources.Synchronize_icon
                btnCheckNuovi.Tag = "CHECK NUOVI"
            End If

        End If
    End Sub

    Private Sub loadFornitoriValidati(ByVal _filtroData As String)

        If _filtroData = "" Then
            whereXNuovi = ""
        End If

        dgvFornitori.Rows.Clear()

        cnDB.Open()

        query = "SELECT * FROM FORNITORI_VALIDATI_QUERY WHERE ANNO_VALIDAZIONE=" & cmbAnno.Text & ""

        If _filtroData <> "" Then
            query = query & " AND DATA_INSERIMENTO = '" & _filtroData & "'"
        End If

        tabFornitoriValidati.Clear()
        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabFornitoriValidati)

        cnDB.Close()

        For Each row In tabFornitoriValidati.Rows

            Dim visibile As String = ""

            If row("VISIBILE") = True Then
                visibile = ""
            Else
                visibile = "X"
            End If

            dgvFornitori.Rows.Add(row("CODICE_FORNITORE"), row("RAGIONE_SOCIALE"), row("DESCRIZIONE_CATEGORIA"), visibile, "+",
                                  row("ID_TIPOLOGIA"), row("DESCRIZIONE_TIPOLOGIA"),
                                  row("ID_QUESTIONARIO"), row("DESCRIZIONE_QUESTIONARIO"),
                                  row("ID_DOCUMENTAZIONE"), row("DESCRIZIONE_DOCUMENTAZIONE"),
                                  row("ID_VALIDAZIONE"), row("DESCRIZIONE_VALIDAZIONE"), row("ID_CATEGORIA_FORNITORE"),
                                  row("NOTE_VARIE"))

            If _filtroData = "" Then
                If whereXNuovi.Length = 0 Then
                    whereXNuovi = "('" & row("CODICE_FORNITORE") & "'"
                Else
                    whereXNuovi = whereXNuovi & ",'" & row("CODICE_FORNITORE") & "'"
                End If

                whereXNuovi = whereXNuovi & ",'" & row("CODICE_FORNITORE") & "'"
            End If

        Next

        If _filtroData = "" Then
            If whereXNuovi <> "" Then
                whereXNuovi = whereXNuovi & ")"
            End If
        End If

        checkNewFornitori()

    End Sub

    Public Sub checkNewFornitori()
        tabNewFornitori.Clear()

        query = "SELECT * FROM Anag_F_Esp"

        If whereXNuovi <> "" Then
            query = query & " WHERE CodFornitore not in " & whereXNuovi
        End If

        tabNewFornitori.Clear()

        cnDB.Open()

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        Dim ii As Integer = myDA.Fill(tabNewFornitori)
        cnDB.Close()

        If ii > 0 Then
            lblNewFornitori.Text = "Sono presenti nuovi " & ii & " fornitori per l'anno " & cmbAnno.Text & "."
            lblNewFornitori.ForeColor = Color.Red
            btnCheckNuovi.Enabled = True
        Else
            lblNewFornitori.Text = "Non sono presenti nuovi fornitori per l'anno " & cmbAnno.Text & "!"
            lblNewFornitori.ForeColor = Color.Green
            btnCheckNuovi.Enabled = False
        End If
    End Sub

    Private Sub btnSalva_Click(sender As System.Object, e As System.EventArgs) Handles btnSalva.Click

        query = "UPDATE FORNITORI_VALIDATI SET " &
                "ID_TIPOLOGIA=" & cmbIdTipologia.Text & "," &
                "ID_QUESTIONARIO=" & cmbIdQuestionario.Text & ", " &
                "ID_DOCUMENTAZIONE=" & cmbIdDocumentazione.Text & ", " &
                "ID_CATEGORIA_FORNITORE=" & cmbIdCategoriaFornitore.Text & ", " &
                "ID_VALIDAZIONE=" & cmbIdRivalidazione.Text & ", " &
                "NOTE_VARIE='" & txtNote.Text & "' " &
                "WHERE CODICE_FORNITORE ='" & lblCodiceFornitoreSel.Text & "'"

        cnDB.Open()

        myDA.UpdateCommand = New OleDbCommand(query, cnDB)
        myDA.UpdateCommand.ExecuteNonQuery()

        cnDB.Close()

        dgvFornitori.Rows(rigaSel).Cells("colIdTipologia").Value = cmbIdTipologia.Text
        dgvFornitori.Rows(rigaSel).Cells("colTipologia").Value = cmbTipologiaFornitore.Text

        dgvFornitori.Rows(rigaSel).Cells("colQuestionario").Value = cmbQuestionario.Text
        dgvFornitori.Rows(rigaSel).Cells("colIdQuestionario").Value = cmbIdQuestionario.Text

        dgvFornitori.Rows(rigaSel).Cells("colIdDocumentazione").Value = cmbIdDocumentazione.Text
        dgvFornitori.Rows(rigaSel).Cells("colDocumentazione").Value = cmbDocumentazione.Text

        dgvFornitori.Rows(rigaSel).Cells("colIdCategoriaFornitori").Value = cmbIdCategoriaFornitore.Text
        dgvFornitori.Rows(rigaSel).Cells("colCategoriaFornitori").Value = cmbCategoriaFornitore.Text

        dgvFornitori.Rows(rigaSel).Cells("colIdRivalidato").Value = cmbIdRivalidazione.Text
        dgvFornitori.Rows(rigaSel).Cells("colRivalidato").Value = cmbRivalidato.Text

        dgvFornitori.Rows(rigaSel).Cells("colNote").Value = txtNote.Text

        'rigaSel = -1

    End Sub

    Private Sub checkFiltro_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkFiltro.CheckedChanged
        dtpFiltro.Enabled = checkFiltro.Checked
        checkFiltroFornitore.Checked = False
        checkFiltroRags.Checked = False
    End Sub

    Private Sub dtpFiltro_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpFiltro.ValueChanged
        loadFornitoriValidati(dtpFiltro.Value.Day & "/" & dtpFiltro.Value.Month & "/" & dtpFiltro.Value.Year)
    End Sub

    Private Sub checkFiltroFornitore_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkFiltroFornitore.CheckedChanged
        txtCodiceFornitore.Enabled = checkFiltroFornitore.Checked
        txtCodiceFornitore.Text = ""
    End Sub

    Private Sub txtCodiceFornitore_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCodiceFornitore.TextChanged

        Grid_noFilter()

        For ii As Integer = 0 To dgvFornitori.Rows.Count - 1

            Dim controlloRagioneSociale As Boolean = dgvFornitori.Rows(ii).Cells("colRagsociale").Value.ToString.ToLower.Contains(txtRagSoc.Text.ToLower)

            Dim controlloCodiceFornitore As Boolean = dgvFornitori.Rows(ii).Cells("colFornitore").Value.ToString.ToLower.Contains(txtCodiceFornitore.Text.ToLower)

            Dim controlloVisibile As Boolean = dgvFornitori.Rows(ii).Cells("colNonVisibile").Value.ToString.Contains("")

            Dim controlloNascosti As Boolean = dgvFornitori.Rows(ii).Cells("colNonVisibile").Value.ToString.Contains("X")

            If checkFiltroRags.Checked And checkFiltroFornitore.Checked And checkFiltroVisibili.Checked And checkFiltroInvisibili.Checked Then
                If Not (controlloRagioneSociale And controlloCodiceFornitore And controlloVisibile And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            ElseIf checkFiltroRags.Checked And checkFiltroFornitore.Checked And checkFiltroVisibili.Checked Then

                If Not (controlloRagioneSociale And controlloCodiceFornitore And controlloVisibile) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If

            ElseIf checkFiltroRags.Checked And checkFiltroFornitore.Checked And checkFiltroInvisibili.Checked Then

                If Not (controlloRagioneSociale And controlloCodiceFornitore And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If

            ElseIf checkFiltroRags.Checked And checkFiltroVisibili.Checked And checkFiltroInvisibili.Checked Then

                If Not (controlloRagioneSociale And controlloVisibile And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If

            ElseIf checkFiltroRags.Checked And checkFiltroFornitore.Checked Then

                If Not (controlloRagioneSociale And controlloCodiceFornitore) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If

            ElseIf checkFiltroRags.Checked And checkFiltroVisibili.Checked Then

                If Not (controlloRagioneSociale And controlloVisibile) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If

            ElseIf checkFiltroRags.Checked And checkFiltroInvisibili.Checked Then
                If Not (controlloRagioneSociale And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            ElseIf checkFiltroFornitore.Checked And checkFiltroVisibili.Checked And checkFiltroInvisibili.Checked Then
                If Not (controlloCodiceFornitore And controlloVisibile And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            ElseIf checkFiltroFornitore.Checked And checkFiltroVisibili.Checked Then
                If Not (controlloCodiceFornitore And controlloVisibile) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            ElseIf checkFiltroFornitore.Checked And checkFiltroInvisibili.Checked Then
                If Not (controlloCodiceFornitore And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            ElseIf checkFiltroFornitore.Checked And checkFiltroRags.Checked Then
                If Not (controlloCodiceFornitore And controlloRagioneSociale) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            ElseIf checkFiltroVisibili.Checked And checkFiltroInvisibili.Checked Then
                If Not (controlloVisibile And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            Else
                If Not (controlloCodiceFornitore) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            End If
        Next

    End Sub

    Private Sub checkFiltroRags_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkFiltroRags.CheckedChanged
        txtRagSoc.Enabled = checkFiltroRags.Checked
        txtRagSoc.Text = ""
    End Sub

    Private Sub txtRagSoc_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtRagSoc.TextChanged

        Grid_noFilter()

        For ii As Integer = 0 To dgvFornitori.Rows.Count - 1

            Dim controlloRagioneSociale As Boolean = dgvFornitori.Rows(ii).Cells("colRagsociale").Value.ToString.ToLower.Contains(txtRagSoc.Text.ToLower)

            Dim controlloCodiceFornitore As Boolean = dgvFornitori.Rows(ii).Cells("colFornitore").Value.ToString.ToLower.Contains(txtCodiceFornitore.Text.ToLower)

            Dim controlloVisibile As Boolean = dgvFornitori.Rows(ii).Cells("colNonVisibile").Value.ToString.Contains("")

            Dim controlloNascosti As Boolean = dgvFornitori.Rows(ii).Cells("colNonVisibile").Value.ToString.Contains("X")

            If checkFiltroRags.Checked And checkFiltroFornitore.Checked And checkFiltroVisibili.Checked And checkFiltroInvisibili.Checked Then
                If Not (controlloRagioneSociale And controlloCodiceFornitore And controlloVisibile And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            ElseIf checkFiltroRags.Checked And checkFiltroFornitore.Checked And checkFiltroVisibili.Checked Then

                If Not (controlloRagioneSociale And controlloCodiceFornitore And controlloVisibile) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If

            ElseIf checkFiltroRags.Checked And checkFiltroFornitore.Checked And checkFiltroInvisibili.Checked Then

                If Not (controlloRagioneSociale And controlloCodiceFornitore And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If

            ElseIf checkFiltroRags.Checked And checkFiltroVisibili.Checked And checkFiltroInvisibili.Checked Then

                If Not (controlloRagioneSociale And controlloVisibile And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If

            ElseIf checkFiltroRags.Checked And checkFiltroFornitore.Checked Then

                If Not (controlloRagioneSociale And controlloCodiceFornitore) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If

            ElseIf checkFiltroRags.Checked And checkFiltroVisibili.Checked Then

                If Not (controlloRagioneSociale And controlloVisibile) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If

            ElseIf checkFiltroRags.Checked And checkFiltroInvisibili.Checked Then
                If Not (controlloRagioneSociale And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            ElseIf checkFiltroFornitore.Checked And checkFiltroVisibili.Checked And checkFiltroInvisibili.Checked Then
                If Not (controlloCodiceFornitore And controlloVisibile And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            ElseIf checkFiltroFornitore.Checked And checkFiltroVisibili.Checked Then
                If Not (controlloCodiceFornitore And controlloVisibile) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            ElseIf checkFiltroFornitore.Checked And checkFiltroInvisibili.Checked Then
                If Not (controlloCodiceFornitore And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            ElseIf checkFiltroFornitore.Checked And checkFiltroRags.Checked Then
                If Not (controlloCodiceFornitore And controlloRagioneSociale) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            ElseIf checkFiltroVisibili.Checked And checkFiltroInvisibili.Checked Then
                If Not (controlloVisibile And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            Else
                If Not (controlloRagioneSociale) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            End If
        Next

    End Sub

    Private Sub Grid_noFilter()
        For ii As Integer = 0 To dgvFornitori.Rows.Count - 1
            dgvFornitori.Rows(ii).Visible = True
        Next
    End Sub

    Private Sub checkFiltroVisibili_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkFiltroVisibili.CheckedChanged

        Grid_noFilter()

        For ii As Integer = 0 To dgvFornitori.Rows.Count - 1

            Dim controlloRagioneSociale As Boolean = dgvFornitori.Rows(ii).Cells("colRagsociale").Value.ToString.ToLower.Contains(txtRagSoc.Text.ToLower)

            Dim controlloCodiceFornitore As Boolean = dgvFornitori.Rows(ii).Cells("colFornitore").Value.ToString.ToLower.Contains(txtCodiceFornitore.Text.ToLower)

            Dim controlloVisibile As Boolean = dgvFornitori.Rows(ii).Cells("colNonVisibile").Value.ToString.Contains("")

            Dim controlloNascosti As Boolean = dgvFornitori.Rows(ii).Cells("colNonVisibile").Value.ToString.Contains("X")

            If checkFiltroRags.Checked And checkFiltroFornitore.Checked And checkFiltroVisibili.Checked And checkFiltroInvisibili.Checked Then
                If Not (controlloRagioneSociale And controlloCodiceFornitore And controlloVisibile And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            ElseIf checkFiltroRags.Checked And checkFiltroFornitore.Checked And checkFiltroVisibili.Checked Then

                If Not (controlloRagioneSociale And controlloCodiceFornitore And controlloVisibile) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If

            ElseIf checkFiltroRags.Checked And checkFiltroFornitore.Checked And checkFiltroInvisibili.Checked Then

                If Not (controlloRagioneSociale And controlloCodiceFornitore And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If

            ElseIf checkFiltroRags.Checked And checkFiltroVisibili.Checked And checkFiltroInvisibili.Checked Then

                If Not (controlloRagioneSociale And controlloVisibile And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If

            ElseIf checkFiltroRags.Checked And checkFiltroFornitore.Checked Then

                If Not (controlloRagioneSociale And controlloCodiceFornitore) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If

            ElseIf checkFiltroRags.Checked And checkFiltroVisibili.Checked Then

                If Not (controlloRagioneSociale And controlloVisibile) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If

            ElseIf checkFiltroRags.Checked And checkFiltroInvisibili.Checked Then
                If Not (controlloRagioneSociale And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            ElseIf checkFiltroFornitore.Checked And checkFiltroVisibili.Checked And checkFiltroInvisibili.Checked Then
                If Not (controlloCodiceFornitore And controlloVisibile And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            ElseIf checkFiltroFornitore.Checked And checkFiltroVisibili.Checked Then
                If Not (controlloCodiceFornitore And controlloVisibile) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            ElseIf checkFiltroFornitore.Checked And checkFiltroInvisibili.Checked Then
                If Not (controlloCodiceFornitore And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            ElseIf checkFiltroFornitore.Checked And checkFiltroRags.Checked Then
                If Not (controlloCodiceFornitore And controlloRagioneSociale) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            ElseIf checkFiltroVisibili.Checked And checkFiltroInvisibili.Checked Then
                If Not (controlloVisibile And controlloNascosti) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            Else
                If Not (controlloVisibile) Then
                    dgvFornitori.Rows(ii).Visible = False
                End If
            End If
        Next

    End Sub

    Private Sub checkFiltroInvisibili_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles checkFiltroInvisibili.CheckedChanged

        Grid_noFilter()

        If checkFiltroRags.Checked Or checkFiltroFornitore.Checked Or checkFiltroVisibili.Checked Or checkFiltroInvisibili.Checked Then

            For ii As Integer = 0 To dgvFornitori.Rows.Count - 1

                Dim controlloRagioneSociale As Boolean = dgvFornitori.Rows(ii).Cells("colRagsociale").Value.ToString.ToLower.Contains(txtRagSoc.Text.ToLower)

                Dim controlloCodiceFornitore As Boolean = dgvFornitori.Rows(ii).Cells("colFornitore").Value.ToString.ToLower.Contains(txtCodiceFornitore.Text.ToLower)

                Dim controlloVisibile As Boolean = dgvFornitori.Rows(ii).Cells("colNonVisibile").Value.ToString.Contains("")

                Dim controlloNascosti As Boolean = dgvFornitori.Rows(ii).Cells("colNonVisibile").Value.ToString.Contains("X")

                If checkFiltroRags.Checked And checkFiltroFornitore.Checked And checkFiltroVisibili.Checked And checkFiltroInvisibili.Checked Then
                    If Not (controlloRagioneSociale And controlloCodiceFornitore And controlloVisibile And controlloNascosti) Then
                        dgvFornitori.Rows(ii).Visible = False
                    End If
                ElseIf checkFiltroRags.Checked And checkFiltroFornitore.Checked And checkFiltroVisibili.Checked Then

                    If Not (controlloRagioneSociale And controlloCodiceFornitore And controlloVisibile) Then
                        dgvFornitori.Rows(ii).Visible = False
                    End If

                ElseIf checkFiltroRags.Checked And checkFiltroFornitore.Checked And checkFiltroInvisibili.Checked Then

                    If Not (controlloRagioneSociale And controlloCodiceFornitore And controlloNascosti) Then
                        dgvFornitori.Rows(ii).Visible = False
                    End If

                ElseIf checkFiltroRags.Checked And checkFiltroVisibili.Checked And checkFiltroInvisibili.Checked Then

                    If Not (controlloRagioneSociale And controlloVisibile And controlloNascosti) Then
                        dgvFornitori.Rows(ii).Visible = False
                    End If

                ElseIf checkFiltroRags.Checked And checkFiltroFornitore.Checked Then

                    If Not (controlloRagioneSociale And controlloCodiceFornitore) Then
                        dgvFornitori.Rows(ii).Visible = False
                    End If

                ElseIf checkFiltroRags.Checked And checkFiltroVisibili.Checked Then

                    If Not (controlloRagioneSociale And controlloVisibile) Then
                        dgvFornitori.Rows(ii).Visible = False
                    End If

                ElseIf checkFiltroRags.Checked And checkFiltroInvisibili.Checked Then
                    If Not (controlloRagioneSociale And controlloNascosti) Then
                        dgvFornitori.Rows(ii).Visible = False
                    End If
                ElseIf checkFiltroFornitore.Checked And checkFiltroVisibili.Checked And checkFiltroInvisibili.Checked Then
                    If Not (controlloCodiceFornitore And controlloVisibile And controlloNascosti) Then
                        dgvFornitori.Rows(ii).Visible = False
                    End If
                ElseIf checkFiltroFornitore.Checked And checkFiltroVisibili.Checked Then
                    If Not (controlloCodiceFornitore And controlloVisibile) Then
                        dgvFornitori.Rows(ii).Visible = False
                    End If
                ElseIf checkFiltroFornitore.Checked And checkFiltroInvisibili.Checked Then
                    If Not (controlloCodiceFornitore And controlloNascosti) Then
                        dgvFornitori.Rows(ii).Visible = False
                    End If
                ElseIf checkFiltroFornitore.Checked And checkFiltroRags.Checked Then
                    If Not (controlloCodiceFornitore And controlloRagioneSociale) Then
                        dgvFornitori.Rows(ii).Visible = False
                    End If
                ElseIf checkFiltroVisibili.Checked And checkFiltroInvisibili.Checked Then
                    If Not (controlloVisibile And controlloNascosti) Then
                        dgvFornitori.Rows(ii).Visible = False
                    End If
                Else
                    If Not (controlloNascosti) Then
                        dgvFornitori.Rows(ii).Visible = False
                    End If
                End If
            Next
        Else
            Grid_noFilter()
        End If


    End Sub

    Private Sub cmbTipologiaFornitore_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbTipologiaFornitore.SelectedIndexChanged
        cmbIdTipologia.SelectedIndex = cmbTipologiaFornitore.SelectedIndex
    End Sub

    Private Sub cmbEsito_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbQuestionario.SelectedIndexChanged
        cmbIdQuestionario.SelectedIndex = cmbQuestionario.SelectedIndex
    End Sub

    Private Sub dgvFornitori_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFornitori.CellClick
        If e.ColumnIndex = 4 And e.RowIndex >= 0 Then

            If btnCheckNuovi.Tag = "CHECK NUOVI" Then
                frmListaFornitori.Height = 771
                frmListaFornitori.Width = 1237

                rigaSel = e.RowIndex

                ' Integro controllo valore campo ed eventuale pulizia

                If dgvFornitori.Rows(e.RowIndex).Cells("colFornitore").Value.ToString <> "" Then
                    lblCodiceFornitoreSel.Text = dgvFornitori.Rows(e.RowIndex).Cells("colFornitore").Value.ToString
                Else
                    lblCodiceFornitoreSel.Text = ""
                End If
                If dgvFornitori.Rows(e.RowIndex).Cells("colRagsociale").Value.ToString <> "" Then
                    lblFornitore.Text = dgvFornitori.Rows(e.RowIndex).Cells("colRagsociale").Value.ToString
                Else
                    lblFornitore.Text = ""
                End If
                If dgvFornitori.Rows(e.RowIndex).Cells("colQuestionario").Value.ToString <> "" Then
                    cmbQuestionario.Text = dgvFornitori.Rows(e.RowIndex).Cells("colQuestionario").Value.ToString
                Else
                    cmbQuestionario.Text = ""
                End If
                If dgvFornitori.Rows(e.RowIndex).Cells("colDocumentazione").Value.ToString <> "" Then
                    cmbDocumentazione.Text = dgvFornitori.Rows(e.RowIndex).Cells("colDocumentazione").Value.ToString
                Else
                    cmbDocumentazione.Text = ""
                End If
                If dgvFornitori.Rows(e.RowIndex).Cells("colCategoriaFornitori").Value.ToString <> "" Then
                    cmbCategoriaFornitore.Text = dgvFornitori.Rows(e.RowIndex).Cells("colCategoriaFornitori").Value.ToString
                Else
                    cmbCategoriaFornitore.Text = "N/D" ' Imposto la prima categoria selezionabile dato che l'uso di questa colonna è stato implementato successivamente
                End If
                If True Then
                    cmbRivalidato.Text = dgvFornitori.Rows(e.RowIndex).Cells("colRivalidato").Value.ToString
                Else
                    cmbRivalidato.Text = ""
                End If
                If dgvFornitori.Rows(e.RowIndex).Cells("colTipologia").Value.ToString <> "" Then
                    cmbTipologiaFornitore.Text = dgvFornitori.Rows(e.RowIndex).Cells("colTipologia").Value.ToString
                Else
                    cmbTipologiaFornitore.Text = ""
                End If
                If dgvFornitori.Rows(e.RowIndex).Cells("colNote").Value.ToString <> "" Then
                    txtNote.Text = dgvFornitori.Rows(e.RowIndex).Cells("colNote").Value.ToString
                Else
                    txtNote.Text = ""
                End If

                loadAllegatiFornitore()
            Else
                MessageBox.Show("Funzione disabilitata in fase di importazione dei nuovi fornitori.", "Attenzione")
            End If
        End If
    End Sub

    Private Sub cmbCategoriaFornitore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoriaFornitore.SelectedIndexChanged
        cmbIdCategoriaFornitore.SelectedIndex = cmbCategoriaFornitore.SelectedIndex
    End Sub

    Private Sub cmbDocumentazione_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbDocumentazione.SelectedIndexChanged
        cmbIdDocumentazione.SelectedIndex = cmbDocumentazione.SelectedIndex
    End Sub

    Private Sub cmbRivalidato_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbRivalidato.SelectedIndexChanged
        cmbIdRivalidazione.SelectedIndex = cmbRivalidato.SelectedIndex
    End Sub

    Private Sub btnSrcFile_Click(sender As System.Object, e As System.EventArgs) Handles btnSrcFile.Click
        OpenFileDialog1.ShowDialog()

        fileSelezionato = OpenFileDialog1.FileName
        estensioneFileSelezionato = Path.GetExtension(fileSelezionato)

        txtNomeFile.Text = Path.GetFileNameWithoutExtension(fileSelezionato)
        txtNomeFile.Enabled = True

    End Sub

    Private Sub btnAddFile_Click(sender As System.Object, e As System.EventArgs) Handles btnAddFile.Click

        If txtNomeFile.Text <> "" Then
            If cmbTipoFile.Text <> "" Then
                Dim pathDaInserire As String = pathBase & "/" & lblCodiceFornitoreSel.Text & "/" & cmbAnno.Text & "/" & cmbPathTipoFile.Text & "/" & txtNomeFile.Text & estensioneFileSelezionato

                If Not (System.IO.File.Exists(pathDaInserire)) Then

                    System.IO.File.Copy(fileSelezionato, pathDaInserire)

                    query = " INSERT INTO ALLEGATI_FORNITORE (ANNO_FORNITORE,CODICE_FORNITORE,TIPO_FILE,NOME_FILE,ESTENSIONE_FILE) " &
                            " VALUES(" & cmbAnno.Text & ",'" & lblCodiceFornitoreSel.Text & "'," & cmbIdTipoFile.Text & ",'" & txtNomeFile.Text & "','" & Path.GetExtension(fileSelezionato) & "')"

                    myDA.InsertCommand = New OleDbCommand(query, cnDB)

                    cnDB.Open()
                    myDA.InsertCommand.ExecuteNonQuery()

                    Dim getIdCommand As OleDbCommand = New OleDbCommand("SELECT @@IDENTITY", cnDB)
                    Dim lastID As String = CStr(getIdCommand.ExecuteScalar())

                    cnDB.Close()

                    dgvFiles.Rows.Add(lastID, txtNomeFile.Text, cmbTipoFile.Text, pathDaInserire, "Apri", "Elimina")

                    fileSelezionato = ""
                    estensioneFileSelezionato = ""

                    txtNomeFile.Enabled = False
                    txtNomeFile.Text = ""

                    loadAllegatiFornitore()
                Else
                    MessageBox.Show("File già presente! Eliminare prima quello con nome uguale!")
                End If
            Else
                MessageBox.Show("Inserisci una tipologia per il file da salvare!")
            End If
        Else
            MessageBox.Show("Inserisci un nome per il file da salvare!")
        End If

    End Sub

    Private Sub cmbTipoFile_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbTipoFile.SelectedIndexChanged
        cmbIdTipoFile.SelectedIndex = cmbTipoFile.SelectedIndex
        cmbPathTipoFile.SelectedIndex = cmbTipoFile.SelectedIndex
    End Sub

    Private Sub loadAllegatiFornitore()

        dgvFiles.Rows.Clear()

        query = "SELECT * FROM GET_FILES_FORNITORI WHERE CODICE_FORNITORE = '" & lblCodiceFornitoreSel.Text & "' and ANNO_FORNITORE = " & cmbAnno.Text & ""

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        tabAllegati.Clear()
        cnDB.Open()
        myDA.Fill(tabAllegati)
        cnDB.Close()

        For Each row In tabAllegati.Rows
            dgvFiles.Rows.Add(row("ID_ALLEGATO"), row("NOME_FILE"), row("DESCRIZIONE_FILE"), row("PATH_COMPLETO"), "Apri", "Elimina")
        Next

    End Sub

    Private Sub dgvFiles_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFiles.CellClick

        If e.RowIndex >= 0 Then

            If e.ColumnIndex = 4 Then
                Try
                    If File.Exists(pathBase & "\" & dgvFiles.Rows(e.RowIndex).Cells("colPath").Value.ToString) Then
                        System.Diagnostics.Process.Start(pathBase & "\" & dgvFiles.Rows(e.RowIndex).Cells("colPath").Value.ToString)
                    Else
                        MessageBox.Show("File non trovato.", "Attenzione")
                    End If
                Catch ex As Exception
                    MessageBox.Show($"{ex.Message}")
                End Try
            ElseIf e.ColumnIndex = 5 Then

                System.IO.File.Delete(pathBase & "\" & dgvFiles.Rows(e.RowIndex).Cells("colPath").Value.ToString)

                query = "DELETE FROM ALLEGATI_FORNITORE WHERE ID=" & dgvFiles.Rows(e.RowIndex).Cells("colID").Value.ToString & ""

                myDA.DeleteCommand = New OleDbCommand(query, cnDB)
                cnDB.Open()
                myDA.DeleteCommand.ExecuteNonQuery()
                cnDB.Close()

                MessageBox.Show("File eliminato.", "Operazione completata")

                loadAllegatiFornitore()
            End If
        End If
    End Sub
End Class