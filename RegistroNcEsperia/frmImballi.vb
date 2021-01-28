Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class frmImballi

    Private Sub txtBobNcPresentiaMag_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBobNcPresentiaMag.TextChanged
        If IsNumeric(txtBobNcPresentiaMag.Text) Then
            If txtTotBobNC.Text <> "" Then
                txtTotBobNC.Text = (Convert.ToInt32(txtBobNcPresentiaMag.Text) + Convert.ToInt32(txtKgBobNcRese.Text)).ToString
            Else
                txtTotBobNC.Text = (Convert.ToInt32(txtBobNcPresentiaMag.Text)).ToString
            End If
        ElseIf IsNumeric(txtKgBobNcRese.Text) Then
            txtTotBobNC.Text = (Convert.ToInt32(txtKgBobNcRese.Text)).ToString
        Else
            txtTotBobNC.Text = ""
        End If
    End Sub

    Private Sub txtKgBobNcRese_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtKgBobNcRese.TextChanged
        If IsNumeric(txtKgBobNcRese.Text) Then
            If IsNumeric(txtBobNcPresentiaMag.Text) Then
                txtTotBobNC.Text = (Convert.ToInt32(txtBobNcPresentiaMag.Text) + Convert.ToInt32(txtKgBobNcRese.Text)).ToString
            Else
                txtTotBobNC.Text = (Convert.ToInt32(txtKgBobNcRese.Text)).ToString
            End If
        ElseIf IsNumeric(txtBobNcPresentiaMag.Text) Then
            txtTotBobNC.Text = (Convert.ToInt32(txtBobNcPresentiaMag.Text)).ToString
        Else
            txtTotBobNC.Text = ""
        End If
    End Sub

    Private Sub frmImballi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        cmbNumeroProgressivo.Items.Clear()
        cmbNumeroProgressivo.Items.Add(progressivoSelezionato)
        cmbNumeroProgressivo.SelectedIndex = 0

        txtimbNCaMAG.Text = "0"
        txtimbresi.Text = "0"
        txtimbMacinati.Text = "0"
        txtimbrimessiaMag.Text = "0"
        txtBobNcAMag.Text = "0"
        txtBobNcPresentiaMag.Text = "0"
        txtBobNcRese.Text = "0"
        txtKgBobNcRese.Text = "0"
        txtKgBobMacinate.Text = "0"
        txtKgBobRimesseaMag.Text = "0"
        txtNumImbContestati.Text = "0"

        granuli_kgPresenti.Text = "0"
        granuli_kgPresenti.Text = "0" ' da controllare

        granuli_kgRimessi.Text = "0"

        film_bobineNc.Text = "0"
        film_BobineNcMag.Text = "0"
        film_bobineNcRese.Text = "0"

        pad_bobineNc.Text = "0"
        pad_m2Presenti.Text = "0"
        pad_m2NcResi.Text = "0"

        If Not tipoOperazione = "INSERIMENTO" Then

            For Each row In tabNC.Rows
                If row("NUMERO_PROGRESSIVO") = cmbNumeroProgressivo.SelectedItem Then

                    loadingData = True

                    If Not IsDBNull(row("NUM_IMBALLI_CONTESTATI")) Then
                        txtNumImbContestati.Text = row("NUM_IMBALLI_CONTESTATI").ToString
                    Else

                        txtNumImbContestati.Text = "0"
                    End If

                    If Not IsDBNull(row("NUM_IMBALLI_NC_A_MAGAZZINO")) Then
                        txtimbNCaMAG.Text = row("NUM_IMBALLI_NC_A_MAGAZZINO").ToString
                    Else
                        txtimbNCaMAG.Text = "0"
                    End If

                    If Not IsDBNull(row("NUM_IMBALLI_RESI")) Then
                        txtimbresi.Text = row("NUM_IMBALLI_RESI")
                    Else
                        txtimbresi.Text = "0"
                    End If

                    If Not IsDBNull(row("NUM_IMBALLI_MACINATI")) Then

                        txtimbMacinati.Text = row("NUM_IMBALLI_MACINATI")
                    Else
                        txtimbMacinati.Text = "0"
                    End If

                    If Not IsDBNull(row("NUM_IMBALLI_RIMESSI_MAGAZZINO")) Then
                        txtimbrimessiaMag.Text = row("NUM_IMBALLI_RIMESSI_MAGAZZINO")
                    Else
                        txtimbrimessiaMag.Text = "0"
                    End If

                    If Not IsDBNull(row("NUM_BOB_NC_A_MAGAZZINO")) Then
                        txtBobNcAMag.Text = row("NUM_BOB_NC_A_MAGAZZINO")
                    Else
                        txtBobNcAMag.Text = "0"
                    End If

                    If Not IsDBNull(row("KG_BOBINE_NC_A_MAGAZZINO")) Then

                        txtBobNcPresentiaMag.Text = row("KG_BOBINE_NC_A_MAGAZZINO")
                    Else
                        txtBobNcPresentiaMag.Text = "0"
                    End If

                    If Not IsDBNull(row("NUM_BOBINE_NC_RESE")) Then

                        txtBobNcRese.Text = row("NUM_BOBINE_NC_RESE")
                    Else
                        txtBobNcRese.Text = "0"
                    End If

                    If Not IsDBNull(row("KG_BOBINE_NC_RESE")) Then

                        txtKgBobNcRese.Text = row("KG_BOBINE_NC_RESE")
                    Else
                        txtKgBobNcRese.Text = "0"
                    End If

                    If Not IsDBNull(row("KG_BOB_MACINATE")) Then

                        txtKgBobMacinate.Text = row("KG_BOB_MACINATE")
                    Else
                        txtKgBobMacinate.Text = "0"
                    End If

                    If Not IsDBNull(row("KG_BOB_RIMESSE_MAGAZZINO")) Then
                        txtKgBobRimesseaMag.Text = row("KG_BOB_RIMESSE_MAGAZZINO")
                    Else

                        txtKgBobRimesseaMag.Text = "0"
                    End If

                    If Not IsDBNull(row("GRANULI_KGPRESENTI")) Then
                        granuli_kgPresenti.Text = row("GRANULI_KGPRESENTI")
                    Else

                        granuli_kgPresenti.Text = "0"
                    End If

                    If Not IsDBNull(row("GRANULI_KGRESI")) Then
                        granuli_kgResi.Text = row("GRANULI_KGRESI")
                    Else

                        granuli_kgResi.Text = "0"
                    End If

                    If Not IsDBNull(row("GRANULI_KGELIMINATI")) Then
                        granuli_materialeEliminato.Text = row("GRANULI_KGELIMINATI")
                    Else

                        granuli_materialeEliminato.Text = "0"
                    End If

                    If Not IsDBNull(row("GRANULI_KGVENDUTI")) Then
                        granuli_materialeVenduto.Text = row("GRANULI_KGVENDUTI")
                    Else
                        granuli_materialeVenduto.Text = "0"
                    End If

                    If Not IsDBNull(row("GRANULI_KGRIMESSI")) Then
                        granuli_kgRimessi.Text = row("GRANULI_KGRIMESSI")
                    Else
                        granuli_kgRimessi.Text = "0"
                    End If

                    If Not IsDBNull(row("FILM_BOBNC")) Then
                        film_bobineNc.Text = row("FILM_BOBNC")
                    Else
                        film_bobineNc.Text = "0"
                    End If

                    If Not IsDBNull(row("FILM_BOBMAG")) Then
                        film_BobineNcMag.Text = row("FILM_BOBMAG")
                    Else

                        film_BobineNcMag.Text = "0"
                    End If

                    If Not IsDBNull(row("FILM_BOBRESE")) Then
                        film_bobineNcRese.Text = row("FILM_BOBRESE")
                    Else

                        film_bobineNcRese.Text = "0"
                    End If

                    If Not IsDBNull(row("FILM_BOBELIMINATE")) Then
                        film_bobineEliminate.Text = row("FILM_BOBELIMINATE")
                    Else

                        film_bobineEliminate.Text = "0"
                    End If

                    If Not IsDBNull(row("PAD_BOBMAG")) Then
                        pad_bobineNc.Text = row("PAD_BOBMAG")
                    Else

                        pad_bobineNc.Text = "0"
                    End If


                    If Not IsDBNull(row("PAD_M2NC")) Then
                        pad_m2Presenti.Text = row("PAD_M2NC")
                    Else

                        pad_m2Presenti.Text = "0"
                    End If


                    If Not IsDBNull(row("PAD_M2RESI")) Then
                        pad_m2NcResi.Text = row("PAD_M2RESI")
                    Else

                        pad_m2NcResi.Text = "0"
                    End If

                    If Not IsDBNull(row("PAD_M2ELIMINATI")) Then
                        pad_m2Eliminati.Text = row("PAD_M2ELIMINATI")
                    Else
                        pad_m2Eliminati.Text = "0"
                    End If

                    loadingData = False

                End If
            Next

        End If
    End Sub

    Private Sub btnProcedi_Click(sender As System.Object, e As System.EventArgs) Handles btnProcedi.Click

        If (txtNumImbContestati.Text) = "" Or Not (IsNumeric(txtNumImbContestati.Text)) Then txtNumImbContestati.Text = "0"
        If (txtimbNCaMAG.Text) = "" Or Not (IsNumeric(txtimbNCaMAG.Text)) Then txtimbNCaMAG.Text = "0"
        If (txtimbresi.Text) = "" Or Not (IsNumeric(txtimbresi.Text)) Then txtimbresi.Text = "0"
        If (txtimbMacinati.Text) = "" Or Not (IsNumeric(txtimbMacinati.Text)) Then txtimbMacinati.Text = "0"
        If (txtimbrimessiaMag.Text) = "" Or Not (IsNumeric(txtimbrimessiaMag.Text)) Then txtimbrimessiaMag.Text = "0"
        If (txtBobNcAMag.Text) = "" Or Not (IsNumeric(txtBobNcAMag.Text)) Then txtBobNcAMag.Text = "0"
        If (txtBobNcPresentiaMag.Text) = "" Or Not (IsNumeric(txtBobNcPresentiaMag.Text)) Then txtBobNcPresentiaMag.Text = "0"
        If (txtBobNcRese.Text) = "" Or Not (IsNumeric(txtBobNcRese.Text)) Then txtBobNcRese.Text = "0"
        If (txtKgBobNcRese.Text) = "" Or Not (IsNumeric(txtKgBobNcRese.Text)) Then txtKgBobNcRese.Text = "0"
        If (txtKgBobMacinate.Text) = "" Or Not (IsNumeric(txtKgBobMacinate.Text)) Then txtKgBobMacinate.Text = "0"
        If (txtKgBobRimesseaMag.Text) = "" Or Not (IsNumeric(txtKgBobRimesseaMag.Text)) Then txtKgBobRimesseaMag.Text = "0"


        If (granuli_kgPresenti.Text) = "" Or Not (IsNumeric(granuli_kgPresenti.Text)) Then granuli_kgPresenti.Text = "0"
        If (granuli_kgResi.Text) = "" Or Not (IsNumeric(granuli_kgResi.Text)) Then granuli_kgResi.Text = "0"
        If (granuli_materialeVenduto.Text) = "" Or Not (IsNumeric(granuli_materialeVenduto.Text)) Then granuli_materialeVenduto.Text = "0"
        If (granuli_materialeEliminato.Text) = "" Or Not (IsNumeric(granuli_materialeEliminato.Text)) Then granuli_materialeEliminato.Text = "0"
        If (granuli_kgRimessi.Text) = "" Or Not (IsNumeric(granuli_kgRimessi.Text)) Then granuli_kgRimessi.Text = "0"

        If (film_bobineNc.Text) = "" Or Not (IsNumeric(film_bobineNc.Text)) Then film_bobineNc.Text = "0"
        If (film_BobineNcMag.Text) = "" Or Not (IsNumeric(film_BobineNcMag.Text)) Then film_BobineNcMag.Text = "0"
        If (film_bobineNcRese.Text) = "" Or Not (IsNumeric(film_bobineNcRese.Text)) Then film_bobineNcRese.Text = "0"
        If (film_bobineEliminate.Text) = "" Or Not (IsNumeric(film_bobineEliminate.Text)) Then film_bobineEliminate.Text = "0"

        If (pad_bobineNc.Text) = "" Or Not (IsNumeric(pad_bobineNc.Text)) Then pad_bobineNc.Text = "0"
        If (pad_m2NcResi.Text) = "" Or Not (IsNumeric(pad_m2NcResi.Text)) Then pad_m2NcResi.Text = "0"
        If (pad_m2Presenti.Text) = "" Or Not (IsNumeric(pad_m2Presenti.Text)) Then pad_m2Presenti.Text = "0"
        If (pad_m2Eliminati.Text) = "" Or Not (IsNumeric(pad_m2Eliminati.Text)) Then pad_m2Eliminati.Text = "0"

        If IsNumeric(txtimbNCaMAG.Text) And IsNumeric(txtimbresi.Text) And IsNumeric(txtimbMacinati.Text) And IsNumeric(txtimbrimessiaMag.Text) And IsNumeric(txtBobNcAMag.Text) And IsNumeric(txtBobNcPresentiaMag.Text) And IsNumeric(txtBobNcRese.Text) And IsNumeric(txtKgBobNcRese.Text) And IsNumeric(txtKgBobMacinate.Text) And IsNumeric(txtKgBobRimesseaMag.Text) And IsNumeric(txtNumImbContestati.Text) Then
            Try
                query = "UPDATE Registro_NC SET " &
                        "NUM_IMBALLI_CONTESTATI =" & txtNumImbContestati.Text.Replace(",", ".") & ", " &
                        "NUM_IMBALLI_NC_A_MAGAZZINO=" & txtimbNCaMAG.Text.Replace(",", ".") & ", " &
                        "NUM_IMBALLI_RESI=" & txtimbresi.Text.Replace(",", ".") & ", " &
                        "NUM_IMBALLI_MACINATI=" & txtimbMacinati.Text.Replace(",", ".") & ", " &
                        "NUM_IMBALLI_RIMESSI_MAGAZZINO=" & txtimbrimessiaMag.Text.Replace(",", ".") & ", " &
                        "NUM_BOB_NC_A_MAGAZZINO=" & txtBobNcAMag.Text.Replace(",", ".") & ", " &
                        "KG_BOBINE_NC_A_MAGAZZINO=" & txtBobNcPresentiaMag.Text.Replace(",", ".") & ", " &
                        "NUM_BOBINE_NC_RESE=" & txtBobNcRese.Text.Replace(",", ".") & ", " &
                        "KG_BOBINE_NC_RESE=" & txtKgBobNcRese.Text.Replace(",", ".") & ", " &
                        "KG_BOB_MACINATE=" & txtKgBobMacinate.Text.Replace(",", ".") & ", " &
                        "KG_BOB_RIMESSE_MAGAZZINO=" & txtKgBobRimesseaMag.Text.Replace(",", ".") & ", " &
                        "GRANULI_KGPRESENTI=" & granuli_kgPresenti.Text.Replace(",", ".") & ", " &
                        "GRANULI_KGRESI=" & granuli_kgResi.Text.Replace(",", ".") & ", " &
                        "GRANULI_KGVENDUTI=" & granuli_materialeVenduto.Text.Replace(",", ".") & ", " &
                        "GRANULI_KGELIMINATI=" & granuli_materialeEliminato.Text.Replace(",", ".") & ", " &
                        "GRANULI_KGRIMESSI=" & granuli_kgRimessi.Text.Replace(",", ".") & ", " &
                        "FILM_BOBNC=" & film_bobineNc.Text.Replace(",", ".") & ", " &
                        "FILM_BOBMAG=" & film_BobineNcMag.Text.Replace(",", ".") & ", " &
                        "FILM_BOBRESE=" & film_bobineNcRese.Text.Replace(",", ".") & ", " &
                        "FILM_BOBELIMINATE=" & film_bobineEliminate.Text.Replace(",", ".") & ", " &
                        "PAD_BOBMAG=" & pad_bobineNc.Text.Replace(",", ".") & ", " &
                        "PAD_M2NC=" & pad_m2Presenti.Text.Replace(",", ".") & ", " &
                        "PAD_M2RESI=" & pad_m2NcResi.Text.Replace(",", ".") & ", " &
                        "PAD_M2ELIMINATI=" & pad_m2Eliminati.Text.Replace(",", ".") & " " &
                        "where ID = " & idNC & ""
                cnDB.Open()

                myDA.UpdateCommand = New OleDbCommand(query, cnDB)
                myDA.UpdateCommand.ExecuteNonQuery()
                cnDB.Close()

            Catch
                MessageBox.Show("Errore nell'inserimento, controllare i dati.", "Attenzione")
                If cnDB.State = ConnectionState.Open Then cnDB.Close()
            End Try

            frmChiusura = New frmDatiChiusura
            frmChiusura.Show()
        Else
            MessageBox.Show("Errore, i dati non sono compatibili alla destinazione.", "Attenzione")
        End If
    End Sub

    Private Sub txtimbMacinati_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtimbMacinati.TextChanged

        If txtimbMacinati.Text <> "" AndAlso IsNumeric(txtimbMacinati.Text) AndAlso CDbl(txtimbMacinati.Text) > 0 Then
            txtNrPzMacinati.Text = CDbl(txtimbMacinati.Text) * tmpPezzatura
        Else
            txtimbMacinati.Text = "0"
            txtNrPzMacinati.Text = "0"
        End If

    End Sub

    Private Sub txtNumImbContestati_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumImbContestati.TextChanged

        If txtNumImbContestati.Text <> "" AndAlso IsNumeric(txtNumImbContestati.Text) AndAlso CDbl(txtNumImbContestati.Text) >= 0 Then
            txtPezziContestati.Text = CDbl(txtNumImbContestati.Text) * tmpPezzatura

            txtTotImbContestati.Text = (CDbl(txtimbNCaMAG.Text) + CDbl(txtNumImbContestati.Text)).ToString
            txtTotPezziContestati.Text = (CDbl(txtNrPzMacinati.Text) + CDbl(txtPezziContestati.Text)).ToString
        End If
    End Sub

    Private Sub txtimbNCaMAG_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtimbNCaMAG.TextChanged

        If txtimbNCaMAG.Text <> "" Then
            txtNcAMag.Text = CDbl(txtimbNCaMAG.Text) * tmpPezzatura

            txtTotPezziContestati.Text = (CDbl(txtNcAMag.Text) + CDbl(txtPezziContestati.Text)).ToString

            If txtNumImbContestati.Text <> "" Then
                txtTotImbContestati.Text = (CDbl(txtimbNCaMAG.Text) + CDbl(txtNumImbContestati.Text)).ToString
            Else
                txtTotImbContestati.Text = txtimbNCaMAG.Text
            End If
        End If

    End Sub

    Private Sub txtimbresi_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtimbresi.TextChanged
        If txtimbresi.Text <> "" Then
            txtNrPzResi.Text = CDbl(txtimbresi.Text) * tmpPezzatura

        End If
    End Sub

    Private Sub txtimbrimessiaMag_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtimbrimessiaMag.TextChanged
        If txtimbrimessiaMag.Text <> "" AndAlso IsNumeric(txtimbrimessiaMag.Text) AndAlso CDbl(txtimbrimessiaMag.Text) >= 0 Then
            txtPzRimessiAMag.Text = CDbl(txtimbrimessiaMag.Text) * tmpPezzatura

        End If
    End Sub

    Private Sub txtNumImbContestati_Leave(sender As System.Object, e As System.EventArgs) Handles txtNumImbContestati.Leave
        If txtNumImbContestati.Text = "" Then
            txtNumImbContestati.Text = "0"
            txtPezziContestati.Text = "0"
        Else
            txtNumImbContestati.Text = txtNumImbContestati.Text.Replace(".", ",")
        End If
    End Sub

    Private Sub txtimbNCaMAG_Leave(sender As System.Object, e As System.EventArgs) Handles txtimbNCaMAG.Leave
        If txtimbNCaMAG.Text = "" Then
            txtimbNCaMAG.Text = "0"
            txtNcAMag.Text = "0"
        Else
            txtimbNCaMAG.Text = txtimbNCaMAG.Text.Replace(".", ",")
        End If
    End Sub

    Private Sub txtimbresi_Leave(sender As System.Object, e As System.EventArgs) Handles txtimbresi.Leave
        If txtimbresi.Text = "" Then
            txtimbresi.Text = "0"
            txtNrPzResi.Text = "0"
        Else
            txtimbresi.Text = txtimbresi.Text.Replace(".", ",")
        End If
    End Sub

    Private Sub txtimbMacinati_Leave(sender As System.Object, e As System.EventArgs) Handles txtimbMacinati.Leave
        If txtimbMacinati.Text = "" Then
            txtimbMacinati.Text = "0"
            txtNrPzMacinati.Text = "0"
        Else
            txtimbMacinati.Text = txtimbMacinati.Text.Replace(".", ",")
        End If
    End Sub

    Private Sub txtimbrimessiaMag_Leave(sender As System.Object, e As System.EventArgs) Handles txtimbrimessiaMag.Leave
        If txtimbrimessiaMag.Text = "" Then
            txtimbrimessiaMag.Text = "0"
            txtPzRimessiAMag.Text = "0"
        Else
            txtimbrimessiaMag.Text = txtimbrimessiaMag.Text.Replace(".", ",")
        End If
    End Sub

    Private Sub txtNumImbContestati_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumImbContestati.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[0-9\,.]").IsMatch(e.KeyChar)
    End Sub

    Private Sub txtimbNCaMAG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtimbNCaMAG.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[0-9\,.]").IsMatch(e.KeyChar)
    End Sub

    Private Sub txtimbresi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtimbresi.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[0-9\,.]").IsMatch(e.KeyChar)
    End Sub

    Private Sub txtimbMacinati_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtimbMacinati.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[0-9\,.]").IsMatch(e.KeyChar)
    End Sub

    Private Sub txtimbrimessiaMag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtimbrimessiaMag.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[0-9\,.]").IsMatch(e.KeyChar)
    End Sub

    Private Sub txtBobNcAMag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBobNcAMag.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[  ^ 0-9]").IsMatch(e.KeyChar)
    End Sub

    Private Sub txtBobNcAMag_Leave(sender As Object, e As EventArgs) Handles txtBobNcAMag.Leave
        If txtBobNcAMag.Text = "" Then
            txtBobNcAMag.Text = "0"

        End If
    End Sub

    Private Sub txtBobNcRese_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBobNcRese.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[  ^ 0-9]").IsMatch(e.KeyChar)
    End Sub

    Private Sub txtBobNcRese_Leave(sender As Object, e As EventArgs) Handles txtBobNcRese.Leave
        If txtBobNcRese.Text = "" Then
            txtBobNcRese.Text = "0"

        End If
    End Sub

    Private Sub txtKgBobNcRese_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKgBobNcRese.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[  ^ 0-9]").IsMatch(e.KeyChar)
    End Sub

    Private Sub txtKgBobNcRese_Leave(sender As Object, e As EventArgs) Handles txtKgBobNcRese.Leave
        If txtKgBobNcRese.Text = "" Then
            txtKgBobNcRese.Text = "0"

        End If
    End Sub

    Private Sub txtTotBobNC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotBobNC.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[  ^ 0-9]").IsMatch(e.KeyChar)
    End Sub

    Private Sub txtTotBobNC_Leave(sender As Object, e As EventArgs) Handles txtTotBobNC.Leave
        If txtTotBobNC.Text = "" Then
            txtTotBobNC.Text = "0"

        End If
    End Sub

    Private Sub txtKgBobMacinate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKgBobMacinate.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[  ^ 0-9]").IsMatch(e.KeyChar)
    End Sub

    Private Sub txtKgBobMacinate_Leave(sender As Object, e As EventArgs) Handles txtKgBobMacinate.Leave
        If txtKgBobMacinate.Text = "" Then
            txtKgBobMacinate.Text = "0"

        End If
    End Sub

    Private Sub txtKgBobRimesseaMag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKgBobRimesseaMag.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[  ^ 0-9]").IsMatch(e.KeyChar)
    End Sub

    Private Sub txtKgBobRimesseaMag_Leave(sender As Object, e As EventArgs) Handles txtKgBobRimesseaMag.Leave
        If txtKgBobRimesseaMag.Text = "" Then
            txtKgBobRimesseaMag.Text = "0"

        End If
    End Sub

    Private Sub granuli_kgPresenti_KeyPress(sender As Object, e As KeyPressEventArgs) Handles granuli_kgPresenti.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[  ^ 0-9]").IsMatch(e.KeyChar)
    End Sub

    Private Sub granuli_kgPresenti_Leave(sender As Object, e As EventArgs) Handles granuli_kgPresenti.Leave
        If granuli_kgPresenti.Text = "" Then
            granuli_kgPresenti.Text = "0"

        End If
    End Sub

    Private Sub granuli_kgResi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles granuli_kgResi.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[  ^ 0-9]").IsMatch(e.KeyChar)
    End Sub

    Private Sub granuli_kgResi_Leave(sender As Object, e As EventArgs) Handles granuli_kgResi.Leave
        If granuli_kgResi.Text = "" Then
            granuli_kgResi.Text = "0"
        End If
    End Sub

    Private Sub granuli_materialeEliminato_KeyPress(sender As Object, e As KeyPressEventArgs) Handles granuli_materialeEliminato.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[  ^ 0-9]").IsMatch(e.KeyChar)
    End Sub

    Private Sub granuli_materialeEliminato_Leave(sender As Object, e As EventArgs) Handles granuli_materialeEliminato.Leave
        If granuli_materialeEliminato.Text = "" Then
            granuli_materialeEliminato.Text = "0"
        End If
    End Sub

    Private Sub granuli_materialeVenduto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles granuli_materialeVenduto.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[  ^ 0-9]").IsMatch(e.KeyChar)
    End Sub

    Private Sub granuli_materialeVenduto_Leave(sender As Object, e As EventArgs) Handles granuli_materialeVenduto.Leave
        If granuli_materialeVenduto.Text = "" Then
            granuli_materialeVenduto.Text = "0"
        End If
    End Sub

    Private Sub granuli_kgRimessi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles granuli_kgRimessi.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[  ^ 0-9]").IsMatch(e.KeyChar)
    End Sub

    Private Sub granuli_kgRimessi_Leave(sender As Object, e As EventArgs) Handles granuli_kgRimessi.Leave
        If granuli_kgRimessi.Text = "" Then
            granuli_kgRimessi.Text = "0"
        End If
    End Sub

    Private Sub film_bobineNc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles film_bobineNc.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[  ^ 0-9]").IsMatch(e.KeyChar)
    End Sub

    Private Sub film_bobineNc_Leave(sender As Object, e As EventArgs) Handles film_bobineNc.Leave
        If film_bobineNc.Text = "" Then
            film_bobineNc.Text = "0"
        End If
    End Sub

    Private Sub film_BobineNcMag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles film_BobineNcMag.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[  ^ 0-9]").IsMatch(e.KeyChar)
    End Sub

    Private Sub film_BobineNcMag_Leave(sender As Object, e As EventArgs) Handles film_BobineNcMag.Leave
        If film_BobineNcMag.Text = "" Then
            film_BobineNcMag.Text = "0"
        End If
    End Sub

    Private Sub film_bobineNcRese_KeyPress(sender As Object, e As KeyPressEventArgs) Handles film_bobineNcRese.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[  ^ 0-9]").IsMatch(e.KeyChar)
    End Sub

    Private Sub film_bobineNcRese_Leave(sender As Object, e As EventArgs) Handles film_bobineNcRese.Leave
        If film_bobineNcRese.Text = "" Then
            film_bobineNcRese.Text = "0"
        End If
    End Sub

    Private Sub film_bobineEliminate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles film_bobineEliminate.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[  ^ 0-9]").IsMatch(e.KeyChar)
    End Sub

    Private Sub film_bobineEliminate_Leave(sender As Object, e As EventArgs) Handles film_bobineEliminate.Leave
        If film_bobineEliminate.Text = "" Then
            film_bobineEliminate.Text = "0"
        End If
    End Sub

    Private Sub pad_bobineNc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pad_bobineNc.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[  ^ 0-9]").IsMatch(e.KeyChar)
    End Sub

    Private Sub pad_bobineNc_Leave(sender As Object, e As EventArgs) Handles pad_bobineNc.Leave
        If pad_bobineNc.Text = "" Then
            pad_bobineNc.Text = "0"
        End If
    End Sub

    Private Sub pad_m2Presenti_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pad_m2Presenti.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[  ^ 0-9]").IsMatch(e.KeyChar)
    End Sub

    Private Sub pad_m2Presenti_Leave(sender As Object, e As EventArgs) Handles pad_m2Presenti.Leave
        If pad_m2Presenti.Text = "" Then
            pad_m2Presenti.Text = "0"
        End If
    End Sub

    Private Sub pad_m2NcResi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pad_m2NcResi.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[  ^ 0-9]").IsMatch(e.KeyChar)
    End Sub

    Private Sub pad_m2NcResi_Leave(sender As Object, e As EventArgs) Handles pad_m2NcResi.Leave
        If pad_m2NcResi.Text = "" Then
            pad_m2NcResi.Text = "0"
        End If
    End Sub

    Private Sub pad_m2Eliminati_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pad_m2Eliminati.KeyPress
        e.Handled = Not Char.IsControl(e.KeyChar) And Not New Regex("[  ^ 0-9]").IsMatch(e.KeyChar)
    End Sub

    Private Sub pad_m2Eliminati_Leave(sender As Object, e As EventArgs) Handles pad_m2Eliminati.Leave
        If pad_m2Eliminati.Text = "" Then
            pad_m2Eliminati.Text = "0"
        End If
    End Sub
End Class