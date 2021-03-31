Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports System.Threading
'Imports System.Runtime.InteropServices
'Imports System.Security.Principal

Public Class Form1

    Public StepPrg As Integer = 0

    Private Sub cambiaVis() Handles MyBase.VisibleChanged
        loadNC()
    End Sub


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        frm1 = Me

        frm1.Width = 707
        frm1.Height = 114

        cnDB.ConnectionString = myConnectionString

        loadNC()

        Me.Show()
        Cursor = Cursors.WaitCursor
        ''''''''''''TIPI ANOMALIE'''''''''''''''''''''''
        query = "SELECT * FROM TIPI_ANOMALIE"

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabAnomalie)

        cmbIdAnomalia.Items.Add("-1")
        cmbTipoAnomalia.Items.Add("")

        For Each row In tabAnomalie.Rows
            cmbIdAnomalia.Items.Add(row("ID").ToString())
            cmbTipoAnomalia.Items.Add(row("Descrizione"))
        Next

        cnDB.Close()

        prgBar_loadingData.PerformStep()
        '''''''''''''''''''''''''''''''''''''''''''''''''''

        ''''''''''''ORIGINI ANOMALIE'''''''''''''''''''''''
        cnDB.Open()

        query = "SELECT * FROM ORIGINI_ANOMALIE"

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabOriginiAnomalie)

        cnDB.Close()

        cmbIdOrigineAnomalia.Items.Add("-1")
        cmbOrigineAnomalia.Items.Add("")

        For Each row In tabOriginiAnomalie.Rows
            cmbIdOrigineAnomalia.Items.Add(row("ID").ToString())
            cmbOrigineAnomalia.Items.Add(row("ZONA"))
        Next

        prgBar_loadingData.PerformStep()
        '''''''''''''''''''''''''''''''''''''''''''''''''''

        ''''''''''''DATI AGGIUNTIVI'''''''''''''''''''''''
        cnDB.Open()

        query = "SELECT * FROM DATI_AGGIUNTIVI"

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabDatiAggiuntivi)

        cnDB.Close()

        prgBar_loadingData.PerformStep()
        '''''''''''''''''''''''''''''''''''''''''''''''''''

        ''''''''''''MACROCATEGORIE'''''''''''''''''''''''
        cnDB.Open()

        query = "SELECT * FROM MACROCATEGORIE"

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabMacroCat)

        cnDB.Close()

        cmbIdMacroCat.Items.Add("-1")
        cmbMacrocategoria.Items.Add("")

        For Each row In tabMacroCat.Rows
            cmbIdMacroCat.Items.Add(row("ID").ToString())
            cmbMacrocategoria.Items.Add(row("DESCRIZIONE"))
        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''

        ''''''''''''CATEGORIE'''''''''''''''''''''''
        cnDB.Open()

        query = "SELECT * FROM CATEGORIE"

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabCategorie)

        cnDB.Close()

        cmbIdCat.Items.Add("-1")
        cmbCategoria.Items.Add("")

        For Each row In tabCategorie.Rows
            cmbIdCat.Items.Add(row("ID").ToString())
            cmbCategoria.Items.Add(row("DESCRIZIONE"))
        Next

        prgBar_loadingData.PerformStep()
        '''''''''''''''''''''''''''''''''''''''''''''''''''

        ''''''''''''DIFETTI_CRITICI'''''''''''''''''''''''
        cnDB.Open()

        query = "SELECT * FROM DIFETTI_CRITICI ORDER BY ID ASC"

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabDifettiCritici)

        cnDB.Close()

        cmbIdDifettoCritico.Items.Clear()
        cmbDifettoCritico.Items.Clear()

        cmbIdDifettoCritico.Items.Add("-1")
        cmbDifettoCritico.Items.Add("")

        cmbDifettoCritico.DataSource = tabDifettiCritici
        cmbDifettoCritico.DisplayMember = "DESCRIZIONE"
        cmbDifettoCritico.ValueMember = "ID"


        'For Each row In tabDifettiCritici.Rows
        '    cmbIdDifettoCritico.Items.Add(row("ID").ToString)
        '    cmbDifettoCritico.Items.Add(row("DESCRIZIONE"))
        'Next

        prgBar_loadingData.PerformStep()
        '''''''''''''''''''''''''''''''''''''''''''''''''''


        '''''''''''LISTA_GRAVITA''''''''''''''''''''''''''''''
        cnDB.Open()

        query = "SELECT * FROM LISTA_GRAVITA"

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabGravita)

        cnDB.Close()

        For Each row In tabGravita.Rows
            cmbIdGravProblema.Items.Add(row("ID").ToString)
            cmbGravitaProblema.Items.Add(row("DESCRIZIONE"))
        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''

        ''''''''''''LISTA_FREQUENZA'''''''''''''''''''''''''
        cnDB.Open()

        query = "SELECT * FROM LISTA_FREQUENZA"

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabFrequenza)

        cnDB.Close()

        For Each row In tabFrequenza.Rows
            cmbIdFrequenza.Items.Add(row("ID").ToString)
            cmbFrequenzaProblema.Items.Add(row("DESCRIZIONE"))
        Next
        prgBar_loadingData.PerformStep()
        '''''''''''''''''''''''''''''''''''''''''''''''''''

        ''''''''''''MATERIALI_NC'''''''''''''''''''''''''
        cnDB.Open()

        query = "SELECT * FROM MATERIALI_NC"

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabMateriali)

        cnDB.Close()


        cmbIdGestioneMateriali.Items.Add("-1")
        cmbGestioneMateriale.Items.Add("")

        For Each row In tabMateriali.Rows
            cmbIdGestioneMateriali.Items.Add(row("ID").ToString)
            cmbGestioneMateriale.Items.Add(row("DESCRIZIONE"))
        Next

        prgBar_loadingData.PerformStep()
        '''''''''''''''''''''''''''''''''''''''''''''''''''


        ''''' DATI PRODUZIONE

        ''''''''''''''CAPITURNO'''''''''''''''''''''''''
        cnDB.Open()

        cmbCapoturno.Items.Add("")

        query = "SELECT * FROM CAPITURNO_FULL WHERE CAPOTURNO NOT IN('POSITIVO','NEGATIVO')"

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabCapiturno)

        cnDB.Close()

        For Each row In tabCapiturno.Rows
            cmbCapoturno.Items.Add(row("CAPOTURNO"))
        Next
        prgBar_loadingData.PerformStep()
        '''''''''''''''''''''''''''''''''''''''''''''''''''

        ''''''''''''''RESP_TERMO''''''''''''''''''''''''''''
        cnDB.Open()

        query = "SELECT * FROM RESP_TERMO WHERE RESPONSABILE_CONFEZIONAMENTO NOT IN('POSITIVO','NEGATIVO')"

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabRespTermo)

        cnDB.Close()

        cmbRespTermo.Items.Add("")

        For Each row In tabRespTermo.Rows
            cmbRespTermo.Items.Add(row("RESPONSABILE_CONFEZIONAMENTO"))
        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''

        ''''''''''''''RESP_ESTR'''''''''''''''''''''''''''''
        cnDB.Open()

        query = "SELECT * FROM RESP_ESTR WHERE RESPONSABILE_ESTR NOT IN('POSITIVO','NEGATIVO')"

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabRespEstr)

        cnDB.Close()

        cmbRespEstrusione.Items.Add("")

        For Each row In tabRespEstr.Rows
            cmbRespEstrusione.Items.Add(row("RESPONSABILE_ESTR"))
        Next
        '''''''''''''''''''''''''''''''''''''''''''''''''''

        ''''''''''''''ANAG_ART_ESPERIA'''''''''''''''''''''''
        cnDB.Open()

        query = "SELECT * FROM ANAG_ART_ESPERIA where descrizione NOT IN('POSITIVO','NEGATIVO')"

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabArtEsperia)

        cnDB.Close()

        cmbCodiceArticolo.Items.Add("")
        cmbPezzatura.Items.Add("")

        For Each row In tabArtEsperia.Rows
            cmbCodiceArticolo.Items.Add(row("DESCRIZIONE"))
            cmbPezzatura.Items.Add(row("PEZZATURA"))
        Next
        prgBar_loadingData.PerformStep()
        '''''''''''''''''''''''''''''''''''''''''''''''''''

        For Each row In tabNC.Rows
            cmbNumeroProgressivo.Items.Add(row("NUMERO_PROGRESSIVO"))
        Next
        prgBar_loadingData.PerformStep()

        Thread.Sleep(1000)
        prgBar_loadingData.Visible = False


        frm1.Width = 1214
        frm1.Height = 769

        logoEsp.Visible = True
        logoEsp2.Visible = True
        pnlBottoni.Visible = True
        grpDatiGenerali.Visible = True
        GrpDatiProduzione.Visible = True
        grpDescrNC.Visible = True
        menu1.Visible = True

        Cursor = Cursors.Default
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click

        tipoOperazione = "INSERIMENTO"

        query = "SELECT MAX(NUMERO_PROGRESSIVO) AS MAXNUM FROM Registro_NC"

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        cnDB.Open()
        tabNewNC.Clear()
        myDA.Fill(tabNewNC)
        cnDB.Close()

        Dim newID As Integer = 0

        For Each row In tabNewNC.Rows
            If Not IsDBNull(row("MAXNUM")) Then
                newID = Convert.ToInt32(row("MAXNUM")) + 1
            Else
                newID = 1
            End If
            cmbNumeroProgressivo.Items.Add(newID.ToString)
        Next

        query = "INSERT INTO Registro_NC(NUMERO_PROGRESSIVO) VALUES(" & newID.ToString & ")"

        myDA.InsertCommand = New OleDbCommand(query, cnDB)
        cnDB.Open()
        myDA.InsertCommand.ExecuteNonQuery()
        cnDB.Close()

        progressivoSelezionato = newID

        newID = -1

        query = "SELECT MAX(ID) AS MAXID FROM Registro_NC"

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        cnDB.Open()
        tabNewNC.Clear()
        myDA.Fill(tabNewNC)
        cnDB.Close()

        For Each row In tabNewNC.Rows
            newID = Convert.ToInt32(row("MAXID"))
        Next

        idNC = newID

        cmbNumeroProgressivo.SelectedIndex = cmbNumeroProgressivo.Items.Count - 1

        'btnNew.Enabled = False

        dtpDataSegnalazione.Value = Today.Date
        dtpDataApertura.Value = Today.Date

        cmbOrigineAnomalia.SelectedIndex = 0
        cmbTipoAnomalia.SelectedIndex = 0
        cmbIdOrigineAnomalia.SelectedIndex = 0
        cmbClienteFinale.SelectedIndex = 0
        cmbMacrocategoria.SelectedIndex = 0
        cmbCategoria.SelectedIndex = 0
        cmbDifettoCritico.SelectedIndex = 0
        cmbDifettoCritico.SelectedIndex = 0
        cmbIdGravProblema.SelectedIndex = 0
        cmbIdFrequenza.SelectedIndex = 0
        cmbCapoturno.SelectedIndex = 0
        cmbRespTermo.SelectedIndex = 0
        cmbRespEstrusione.SelectedIndex = 0
        cmbCodiceArticolo.SelectedIndex = 0
        cmbNumeroLotto.SelectedIndex = 0
        cmbCodiceProduzione.SelectedIndex = 0
        cmbGestioneMateriale.SelectedIndex = 0

        'cmbTipoAnomalia.Text = ""
        'cmbIdOrigineAnomalia.Text = ""
        'cmbClienteFinale.Text = ""
        'cmbMacrocategoria.Text = ""
        'cmbCategoria.Text = ""
        'cmbDifettoCritico.Text = ""
        'cmbDifettoCritico.Text = ""
        'cmbIdGravProblema.Text = ""
        'cmbIdFrequenza.Text = ""
        'cmbCapoturno.Text = ""
        'cmbRespTermo.Text = ""
        'cmbRespEstrusione.Text = ""
        'cmbCodiceArticolo.Text = ""
        'cmbNumeroLotto.Text = ""
        'cmbCodiceProduzione.Text = ""
        'cmbGestioneMateriale.Text = ""

        txtDescrizioneNC.Text = ""
        txtAddetto.Text = ""

    End Sub

    Private Sub cmbNumeroProgressivo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbNumeroProgressivo.SelectedIndexChanged

        grpDatiGenerali.Enabled = True
        GrpDatiProduzione.Enabled = True
        grpDescrNC.Enabled = True
        btnProcedi.Enabled = True

        For Each row In tabNC.Rows
            If row("NUMERO_PROGRESSIVO") = cmbNumeroProgressivo.SelectedItem.ToString Then

                tipoOperazione = "MODIFICA"
                idNC = row("ID")

                progressivoSelezionato = cmbNumeroProgressivo.SelectedItem.ToString

                If Not IsDBNull(row("DATA_SEGNALAZIONE")) Then
                    dtpDataSegnalazione.Value = CDate(row("DATA_SEGNALAZIONE"))
                Else
                    dtpDataSegnalazione.Value = Today
                End If

                If Not IsDBNull(row("DATA_APERTURA")) Then
                    dtpDataApertura.Value = CDate(row("DATA_APERTURA"))
                Else
                    dtpDataApertura.Value = Today
                End If

                If Not IsDBNull(row("TIPO_DI_ANOMALIA")) Then
                    cmbIdAnomalia.SelectedItem = row("TIPO_DI_ANOMALIA").ToString
                    cmbTipoAnomalia.SelectedIndex = cmbIdAnomalia.SelectedIndex
                Else
                    cmbTipoAnomalia.SelectedIndex = 0
                End If

                If Not IsDBNull(row("ORIGINE_ANOMALIA")) Then
                    cmbIdOrigineAnomalia.SelectedItem = row("ORIGINE_ANOMALIA").ToString
                    cmbOrigineAnomalia.SelectedIndex = cmbIdOrigineAnomalia.SelectedIndex
                Else
                    cmbIdOrigineAnomalia.SelectedIndex = 0
                End If

                If Not IsDBNull(row("CLIENTE_FINALE")) Then
                    cmbClienteFinale.Text = row("CLIENTE_FINALE")
                Else
                    cmbClienteFinale.SelectedIndex = 0
                End If

                If Not IsDBNull(row("MACROCATEGORIA_NON_CONFORMITA")) Then
                    cmbIdMacroCat.SelectedItem = row("MACROCATEGORIA_NON_CONFORMITA").ToString
                    cmbMacrocategoria.SelectedIndex = cmbIdMacroCat.SelectedIndex
                Else
                    cmbMacrocategoria.SelectedIndex = 0
                End If

                If Not IsDBNull(row("CATEGORIA_NON_CONFORMITA")) Then
                    cmbIdCat.SelectedIndex = row("CATEGORIA_NON_CONFORMITA").ToString
                    cmbCategoria.SelectedIndex = cmbIdCat.SelectedIndex
                Else
                    cmbCategoria.SelectedIndex = 0
                End If

                Dim idDifettoIndex As Integer = 0


                If Not IsDBNull(row("DIFETTO_CRITICO")) Then
                    cmbIdDifettoCritico.SelectedItem = row("DIFETTO_CRITICO").ToString
                    cmbDifettoCritico.SelectedValue = row("DIFETTO_CRITICO").ToString
                Else
                    cmbDifettoCritico.SelectedIndex = 0
                End If

                If Not IsDBNull(row("GRAVITA_PROBLEMA")) Then
                    cmbIdGravProblema.SelectedItem = row("GRAVITA_PROBLEMA").ToString
                    cmbGravitaProblema.SelectedIndex = cmbIdGravProblema.SelectedIndex
                Else
                    cmbIdGravProblema.SelectedIndex = 0
                End If

                If Not IsDBNull(row("FREQUENZA_PROBLEMA")) Then
                    cmbIdFrequenza.SelectedItem = row("FREQUENZA_PROBLEMA").ToString
                    cmbFrequenzaProblema.SelectedIndex = cmbIdFrequenza.SelectedIndex
                Else
                    cmbIdFrequenza.SelectedIndex = 0
                End If

                If Not IsDBNull(row("DESCRIZIONE_NC")) Then
                    txtDescrizioneNC.Text = row("DESCRIZIONE_NC")
                Else
                    txtDescrizioneNC.Text = ""
                End If

                If Not IsDBNull(row("GESTIONE_MATERIALE_NC")) Then
                    cmbIdGestioneMateriali.SelectedItem = row("GESTIONE_MATERIALE_NC").ToString
                Else
                    cmbIdGestioneMateriali.SelectedIndex = 0
                End If

                If Not IsDBNull(row("CAPOTURNO")) Then
                    cmbCapoturno.SelectedItem = row("CAPOTURNO")
                Else
                    cmbCapoturno.SelectedIndex = 0
                End If

                If Not IsDBNull(row("RESPONSABILE_CONFEZIONAMENTO")) Then
                    cmbRespTermo.SelectedItem = row("RESPONSABILE_CONFEZIONAMENTO")
                Else
                    cmbRespTermo.SelectedIndex = 0
                End If

                If Not IsDBNull(row("RESPONSABILE_ESTRUSIONE")) Then
                    cmbRespEstrusione.SelectedItem = row("RESPONSABILE_ESTRUSIONE")
                Else
                    cmbRespEstrusione.SelectedIndex = 0
                End If

                If Not IsDBNull(row("ADDETTO")) Then
                    txtAddetto.Text = row("ADDETTO")
                Else
                    txtAddetto.Text = ""
                End If

                If Not IsDBNull(row("CODICE_ARTICOLO")) Then
                    cmbCodiceArticolo.SelectedItem = row("CODICE_ARTICOLO")
                    cmbPezzatura.SelectedIndex = cmbCodiceArticolo.SelectedIndex
                Else
                    cmbCodiceArticolo.SelectedIndex = 0
                End If

                If Not IsDBNull(row("NUMERO_LOTTO")) Then
                    cmbNumeroLotto.Text = row("NUMERO_LOTTO")
                Else
                    cmbNumeroLotto.SelectedIndex = 0
                End If

                If Not IsDBNull(row("CODICE_PRODUZIONE")) Then
                    cmbCodiceProduzione.Text = row("CODICE_PRODUZIONE")
                Else
                    cmbCodiceProduzione.SelectedIndex = 0
                End If
            End If
        Next

    End Sub

    Private Sub cmbTipoAnomalia_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbTipoAnomalia.SelectedIndexChanged
        cmbIdAnomalia.SelectedIndex = cmbTipoAnomalia.SelectedIndex
    End Sub

    Private Sub cmbOrigineAnomalia_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbOrigineAnomalia.SelectedIndexChanged
        cmbIdOrigineAnomalia.SelectedIndex = cmbOrigineAnomalia.SelectedIndex
    End Sub

    Private Sub cmbMacrocategoria_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbMacrocategoria.SelectedIndexChanged
        cmbIdMacroCat.SelectedIndex = cmbMacrocategoria.SelectedIndex
    End Sub

    Private Sub cmbCategoria_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbCategoria.SelectedIndexChanged
        cmbIdCat.SelectedIndex = cmbCategoria.SelectedIndex
    End Sub

    Private Sub cmbDifettoCritico_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbDifettoCritico.SelectedIndexChanged
        'cmbIdDifettoCritico.SelectedIndex = cmbDifettoCritico.SelectedIndex
    End Sub

    Private Sub cmbIdGravProblema_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbIdGravProblema.SelectedIndexChanged
        cmbGravitaProblema.SelectedIndex = cmbIdGravProblema.SelectedIndex

        If cmbGravitaProblema.SelectedItem.ToString.Length > 50 Then

            Dim posVuoto As Integer = 50
            Dim found As Boolean = False

            Do While found <> True
                If Mid(cmbGravitaProblema.SelectedItem.ToString, posVuoto, 1) = " " Or Mid(cmbGravitaProblema.SelectedItem.ToString, posVuoto, 1) = "-" Or Mid(cmbGravitaProblema.SelectedItem.ToString, posVuoto, 1) = "." Then
                    found = True
                Else
                    posVuoto += 1
                End If
            Loop


            lblGravita.Text = Mid(cmbGravitaProblema.SelectedItem.ToString, 1, posVuoto)
            lblGravita.Text = lblGravita.Text & vbCr & Mid(cmbGravitaProblema.SelectedItem.ToString, posVuoto + 1, cmbGravitaProblema.SelectedItem.ToString.Length - posVuoto)
        Else
            lblGravita.Text = cmbGravitaProblema.SelectedItem.ToString
        End If

        lblGravita.Visible = True

        If cmbIdFrequenza.SelectedItem <> Nothing Then
            txtGxF.Text = Convert.ToString(Convert.ToInt32(cmbIdGravProblema.SelectedItem) * Convert.ToInt32(cmbIdFrequenza.SelectedItem))
        End If

    End Sub

    Private Sub cmbIdFrequenza_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbIdFrequenza.SelectedIndexChanged

        cmbFrequenzaProblema.SelectedIndex = cmbIdFrequenza.SelectedIndex

        If cmbFrequenzaProblema.SelectedItem.ToString.Length > 50 Then

            Dim posVuoto As Integer = 50
            Dim found As Boolean = False

            Do While found <> True
                If Mid(cmbFrequenzaProblema.SelectedItem.ToString, posVuoto, 1) = " " Or Mid(cmbFrequenzaProblema.SelectedItem.ToString, posVuoto, 1) = "-" Or Mid(cmbFrequenzaProblema.SelectedItem.ToString, posVuoto, 1) = "." Then
                    found = True
                Else
                    posVuoto += 1
                End If
            Loop


            lblDescrFreq.Text = Mid(cmbFrequenzaProblema.SelectedItem.ToString, 1, posVuoto)
            lblDescrFreq.Text = lblGravita.Text & vbCr & Mid(cmbFrequenzaProblema.SelectedItem.ToString, posVuoto + 1, cmbFrequenzaProblema.SelectedItem.ToString.Length - posVuoto)
        Else
            lblDescrFreq.Text = cmbFrequenzaProblema.SelectedItem.ToString
        End If

        lblDescrFreq.Visible = True

        If cmbIdGravProblema.SelectedItem <> Nothing Then
            txtGxF.Text = Convert.ToString(Convert.ToInt32(cmbIdGravProblema.SelectedItem) * Convert.ToInt32(cmbIdFrequenza.SelectedItem))
        End If

    End Sub

    Private Sub cmbCodiceArticolo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbCodiceArticolo.SelectedIndexChanged
        cmbPezzatura.SelectedIndex = cmbCodiceArticolo.SelectedIndex
    End Sub

    Private Sub btnProcedi_Click(sender As System.Object, e As System.EventArgs) Handles btnProcedi.Click

        If cmbTipoAnomalia.Text <> "" And cmbOrigineAnomalia.Text <> "" And cmbMacrocategoria.Text <> "" And cmbCategoria.Text <> "" And cmbGestioneMateriale.Text <> "" And cmbCodiceArticolo.Text <> "" And cmbCapoturno.Text <> "" And cmbRespTermo.Text <> "" And cmbRespEstrusione.Text <> "" Then

            Try
                query = "UPDATE Registro_NC SET " &
                    "TIPO_DI_ANOMALIA=" & cmbIdAnomalia.SelectedItem & ", " &
                    "DATA_APERTURA='" & dtpDataApertura.Value.ToString & "'," &
                    "DATA_SEGNALAZIONE='" & dtpDataSegnalazione.Value.ToString & "'," &
                    "ORIGINE_ANOMALIA='" & cmbIdOrigineAnomalia.SelectedItem & "', " &
                    "CLIENTE_FINALE='" & cmbClienteFinale.Text.Replace("'", "") & "', " &
                    "DESCRIZIONE_NC='" & txtDescrizioneNC.Text.Replace("'", "") & "', " &
                    "GESTIONE_MATERIALE_NC =" & cmbIdGestioneMateriali.SelectedItem.ToString & ", " &
                    "MACROCATEGORIA_NON_CONFORMITA=" & cmbIdMacroCat.SelectedItem & ", " &
                    "CATEGORIA_NON_CONFORMITA=" & cmbIdCat.SelectedItem & ", " &
                    "DIFETTO_CRITICO=" & cmbDifettoCritico.SelectedValue & ", " &
                    "GRAVITA_PROBLEMA=" & cmbIdGravProblema.SelectedItem.ToString & ", " &
                    "FREQUENZA_PROBLEMA=" & cmbIdFrequenza.SelectedItem.ToString & ", " &
                    "CAPOTURNO='" & cmbCapoturno.SelectedItem & "', " &
                    "RESPONSABILE_CONFEZIONAMENTO='" & cmbRespTermo.SelectedItem & "', " &
                    "RESPONSABILE_ESTRUSIONE='" & cmbRespEstrusione.SelectedItem & "', " &
                    "ADDETTO='" & txtAddetto.Text & "', " &
                    "CODICE_ARTICOLO='" & cmbCodiceArticolo.SelectedItem & "', " &
                    "NUMERO_LOTTO='" & cmbNumeroLotto.Text & "', " &
                    "CODICE_PRODUZIONE='" & cmbCodiceProduzione.Text & "' " &
                    "where ID = " & idNC & ""

                cnDB.Open()

                myDA.UpdateCommand = New OleDbCommand(query, cnDB)
                myDA.UpdateCommand.ExecuteNonQuery()

                cnDB.Close()
            Catch ex As Exception
                MessageBox.Show("Errore nell'inserimento, controllare i dati.", "Attenzione")
                MessageBox.Show(ex.Message)
                If cnDB.State = ConnectionState.Open Then cnDB.Close()
            End Try

            tmpOrigineAnomalia = cmbIdOrigineAnomalia.SelectedItem.ToString

            If cmbPezzatura.Text.ToString <> "" AndAlso CInt(cmbPezzatura.Text.ToString) > 0 Then
                tmpPezzatura = CInt(cmbPezzatura.Text.ToString)
            Else
                tmpPezzatura = 0
            End If

            frm1.Hide()

            frmImb = New frmImballi
            frmImb.Show()
        Else
            MessageBox.Show("Attenzione, mancano alcuni dati fondamentali.", "Errore")
        End If

    End Sub

    Private Sub btnIndietro_Click(sender As System.Object, e As System.EventArgs)

        StepPrg -= 1

        If StepPrg = 1 Then
            grpDatiGenerali.Visible = True
            GrpDatiProduzione.Visible = True
            grpDescrNC.Visible = True


            btnNew.Enabled = True
            cmbNumeroProgressivo.Enabled = True

            btnProcedi.BackgroundImage = My.Resources._next
            ToolTip1.SetToolTip(btnProcedi, "Avanti")

            Me.Height = 855
        ElseIf StepPrg = 2 Then
            grpDatiGenerali.Visible = False
            GrpDatiProduzione.Visible = False
            grpDescrNC.Visible = False



            btnProcedi.BackgroundImage = My.Resources._next
            ToolTip1.SetToolTip(btnProcedi, "Avanti")
            Me.Height = 516
        Else
            grpDatiGenerali.Visible = False
            GrpDatiProduzione.Visible = False
            grpDescrNC.Visible = False
        End If

    End Sub

    Private Sub cmbGestioneMateriale_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbGestioneMateriale.SelectedIndexChanged
        cmbIdGestioneMateriali.SelectedIndex = cmbGestioneMateriale.SelectedIndex
    End Sub

    Private Sub cmbIdGestioneMateriali_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbIdGestioneMateriali.SelectedIndexChanged
        cmbGestioneMateriale.SelectedIndex = cmbIdGestioneMateriali.SelectedIndex
    End Sub

    Private Sub ListaFornitoriToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListaFornitoriToolStripMenuItem.Click
        frmListaFornitori = New frmFornitori
        frmListaFornitori.Show()
    End Sub
End Class
