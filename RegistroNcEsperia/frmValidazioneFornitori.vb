Imports System.Data.OleDb

Public Class frmValidazioneFornitori

    Public tabFornitoriValidati As New DataTable
    Public tabAnagFornitori As New DataTable
    Public found As Boolean = False

    Private Sub frmValidazioneFornitori_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        cnDB.Open()

        query = "SELECT * FROM Anag_CF_Esp"

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabAnagFornitori)

        cnDB.Close()

        cmbCodiceFornitore.Items.Add("-1")
        cmbRagsFornitore.Items.Add("")

        For Each row In tabAnagFornitori.Rows
            cmbCodiceFornitore.Items.Add(row("CodFornitore").ToString())
            cmbRagsFornitore.Items.Add(row("RagSociale"))
        Next

        Dim addYear As Integer = CInt(Today.Year)

        For ii As Integer = 0 To 4
            cmbAnno.Items.Add(addYear.ToString)
            addYear += 1
        Next

        loadValidati()

    End Sub

    Private Sub loadValidati()
        cnDB.Open()

        query = "SELECT * FROM FORNITORI_VALIDATI"

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        myDA.Fill(tabFornitoriValidati)

        cnDB.Close()
    End Sub

    Private Sub cmbRagsFornitore_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbRagsFornitore.SelectedIndexChanged

        cmbCodiceFornitore.SelectedIndex = cmbRagsFornitore.SelectedIndex

    End Sub

    Private Sub cmbCodiceFornitore_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbCodiceFornitore.SelectedIndexChanged

        found = False

        If cmbCodiceFornitore.Text <> "-1" Then

            For Each row In tabFornitoriValidati.Rows

                If cmbCodiceFornitore.Text = row("CODICE_FORNITORE") And cmbAnno.Text = row("ANNO_VALIDAZIONE") Then

                    If Not IsDBNull(row("ESITO_QUESTIONARIO")) Then
                        cmbEsito.Text = row("ESITO_QUESTIONARIO")
                    Else
                        cmbEsito.SelectedIndex = 0
                    End If

                    If Not IsDBNull(row("INVIO_DOCUMENTAZIONE")) Then
                        cmbDocumentazione.Text = row("INVIO_DOCUMENTAZIONE")
                    Else
                        cmbDocumentazione.SelectedIndex = 0
                    End If

                    If Not IsDBNull(row("VALIDATO")) Then
                        cmbRivalidato.Text = row("VALIDATO")
                    Else
                        cmbRivalidato.SelectedIndex = 0
                    End If

                    If Not IsDBNull(row("NOTE_VARIE")) Then
                        txtNote.Text = ""
                    Else
                        txtNote.Text = ""
                    End If

                    found = True

                End If

            Next

            If found Then
                imgFound.BackgroundImage = My.Resources.green_ok_icon
            Else
                imgFound.BackgroundImage = My.Resources.red_cross_icon
            End If

            pnlDati.Enabled = True

        Else

            pnlDati.Enabled = False

        End If

    End Sub

    Private Sub btnSalva_Click(sender As System.Object, e As System.EventArgs) Handles btnSalva.Click

        If found Then

            query = "UPDATE FORNITORI_VALIDATI SET " & _
                   "ESITO_QUESTIONARIO=" & cmbEsito.Text & ", " & _
                   "INVIO_DOCUMENTAZIONE=" & cmbDocumentazione.Text & ", " & _
                   "VALIDATO=" & cmbRivalidato.Text & ", " & _
                   "NOTE_VARIE=" & txtNote.Text & " " & _
                   "WHERE CODICE_FORNITORE =" & cmbCodiceFornitore.Text & ""

            cnDB.Open()

            myDA.UpdateCommand = New OleDbCommand(query, cnDB)
            myDA.UpdateCommand.ExecuteNonQuery()

            cnDB.Close()

        Else

            query = "INSERT INTO FORNITORI_VALIDATI (CODICE_FORNITORE,ESITO_QUESTIONARIO,INVIO_DOCUMENTAZIONE,VALIDATO,NOTE_VARIE) " & _
                     " VALUES(" & cmbCodiceFornitore.Text & ",'" & cmbEsito.Text & "','" & cmbDocumentazione.Text & "'," & _
                     "'" & cmbRivalidato.Text & "', " & _
                     "'" & txtNote.Text & "')"

            cnDB.Open()

            myDA.InsertCommand = New OleDbCommand(query, cnDB)
            myDA.InsertCommand.ExecuteNonQuery()

            cnDB.Close()

        End If

        loadValidati()

    End Sub

    Private Sub btnCheckFornitori_Click(sender As System.Object, e As System.EventArgs) Handles btnCheckFornitori.Click





    End Sub
End Class