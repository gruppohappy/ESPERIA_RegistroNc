Imports System.Data.OleDb
Imports System.IO

Public Class frmAllegati

    Public tabAllegati As New DataTable
    Public percorsoFile As String = ""

    Private Sub btnSrcFile_Click(sender As System.Object, e As System.EventArgs) Handles btnSrcFile.Click
        OpenFileDialog1.ShowDialog()

        Dim tmppath As String = OpenFileDialog1.FileName

        If tmppath.Contains(".txt") Or tmppath.Contains(".pdf") Or tmppath.Contains(".jpg") Or tmppath.Contains(".png") Or tmppath.Contains(".xls") Or tmppath.Contains(".doc") Or tmppath.Contains(".docx") Then
            percorsoFile = tmppath
        Else
            MessageBox.Show("Formato file non supportato!", "Errore!")
        End If

        txtNomeFile.Enabled = True

    End Sub

    Private Sub btnAddFile_Click(sender As System.Object, e As System.EventArgs) Handles btnAddFile.Click

        If txtNomeFile.Text <> "" Then
            dgvFiles.Rows.Add(txtNomeFile.Text, percorsoFile, "Apri", "Elimina")

            If System.IO.File.Exists(pathCartella & "\" & txtNomeFile.Text & cmbFormatoFile.SelectedItem.ToString) Then
                System.IO.File.Delete(pathCartella & "\" & txtNomeFile.Text & cmbFormatoFile.SelectedItem.ToString)
            End If

            System.IO.File.Copy(percorsoFile, pathCartella & "\" & txtNomeFile.Text & cmbFormatoFile.SelectedItem.ToString)

            pathCartella = pathCartella.Replace("A'", "A''")

            query = "INSERT INTO ALLEGATI_NC (ID_NC,NOME_FILE,PERCORSO_FILE) VALUES(" & progressivoSelezionato & ",'" & txtNomeFile.Text & "','" & pathCartella & "\" & txtNomeFile.Text & cmbFormatoFile.SelectedItem.ToString & "')"

            myDA.InsertCommand = New OleDbCommand(query, cnDB)

            cnDB.Open()
            myDA.InsertCommand.ExecuteNonQuery()
            cnDB.Close()

            txtNomeFile.Enabled = False
            txtNomeFile.Text = ""

            pathCartella = pathCartella.Replace("A''", "A'")

            loadAllegati()
        Else
            MessageBox.Show("Inserisci un nome per il file da salvare!")
        End If

    End Sub

    Private Sub frmAllegati_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        loadAllegati()

        cmbFormatoFile.SelectedIndex = 0

    End Sub

    Private Sub loadAllegati()

        dgvFiles.Rows.Clear()

        query = "SELECT * FROM ALLEGATI_NC WHERE ID_NC =  " & progressivoSelezionato & ""

        myDA.SelectCommand = New OleDbCommand(query, cnDB)
        tabAllegati.Clear()
        cnDB.Open()
        myDA.Fill(tabAllegati)
        cnDB.Close()

        For Each row In tabAllegati.Rows
            dgvFiles.Rows.Add(row("ID"), row("NOME_FILE"), row("PERCORSO_FILE"), "Apri", "Elimina")
        Next
    End Sub

    Private Sub dgvFiles_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFiles.CellClick

        If e.RowIndex >= 0 Then

            If e.ColumnIndex = 3 Then
                Try
                    If File.Exists(dgvFiles.Rows(e.RowIndex).Cells(2).Value.ToString) Then
                        System.Diagnostics.Process.Start(dgvFiles.Rows(e.RowIndex).Cells(2).Value.ToString)
                    Else
                        MessageBox.Show("File non trovato.", "Attenzione")
                    End If
                Catch
                End Try
            ElseIf e.ColumnIndex = 4 Then

                System.IO.File.Delete(dgvFiles.Rows(e.RowIndex).Cells(2).Value.ToString)

                query = "DELETE FROM ALLEGATI_NC WHERE ID=" & dgvFiles.Rows(e.RowIndex).Cells(0).Value.ToString & ""

                myDA.DeleteCommand = New OleDbCommand(query, cnDB)
                cnDB.Open()
                myDA.DeleteCommand.ExecuteNonQuery()
                cnDB.Close()

                MessageBox.Show("File eliminato.", "Operazione completata")

                loadAllegati()
            End If

        End If

    End Sub
End Class