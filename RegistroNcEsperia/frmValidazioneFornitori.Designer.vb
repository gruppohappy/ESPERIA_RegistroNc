<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmValidazioneFornitori
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbCodiceFornitore = New System.Windows.Forms.ComboBox()
        Me.cmbRagsFornitore = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbEsito = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbDocumentazione = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbRivalidato = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.pnlDati = New System.Windows.Forms.Panel()
        Me.btnSalva = New System.Windows.Forms.Button()
        Me.imgFound = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbAnno = New System.Windows.Forms.ComboBox()
        Me.btnCheckFornitori = New System.Windows.Forms.Button()
        Me.pnlDati.SuspendLayout()
        CType(Me.imgFound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCodiceFornitore
        '
        Me.cmbCodiceFornitore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCodiceFornitore.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCodiceFornitore.FormattingEnabled = True
        Me.cmbCodiceFornitore.Location = New System.Drawing.Point(310, 106)
        Me.cmbCodiceFornitore.Name = "cmbCodiceFornitore"
        Me.cmbCodiceFornitore.Size = New System.Drawing.Size(166, 32)
        Me.cmbCodiceFornitore.TabIndex = 72
        '
        'cmbRagsFornitore
        '
        Me.cmbRagsFornitore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbRagsFornitore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRagsFornitore.DropDownHeight = 105
        Me.cmbRagsFornitore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRagsFornitore.FormattingEnabled = True
        Me.cmbRagsFornitore.IntegralHeight = False
        Me.cmbRagsFornitore.Location = New System.Drawing.Point(19, 110)
        Me.cmbRagsFornitore.MaxDropDownItems = 15
        Me.cmbRagsFornitore.Name = "cmbRagsFornitore"
        Me.cmbRagsFornitore.Size = New System.Drawing.Size(270, 28)
        Me.cmbRagsFornitore.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(116, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 24)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Fornitore"
        '
        'cmbEsito
        '
        Me.cmbEsito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEsito.DropDownHeight = 105
        Me.cmbEsito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEsito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEsito.FormattingEnabled = True
        Me.cmbEsito.IntegralHeight = False
        Me.cmbEsito.Items.AddRange(New Object() {"Ok", "No", "Na"})
        Me.cmbEsito.Location = New System.Drawing.Point(19, 36)
        Me.cmbEsito.MaxDropDownItems = 15
        Me.cmbEsito.Name = "cmbEsito"
        Me.cmbEsito.Size = New System.Drawing.Size(270, 28)
        Me.cmbEsito.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(15, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 24)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Esito questionario"
        '
        'cmbDocumentazione
        '
        Me.cmbDocumentazione.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDocumentazione.DropDownHeight = 105
        Me.cmbDocumentazione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDocumentazione.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDocumentazione.FormattingEnabled = True
        Me.cmbDocumentazione.IntegralHeight = False
        Me.cmbDocumentazione.Items.AddRange(New Object() {"Ok", "No", "Na"})
        Me.cmbDocumentazione.Location = New System.Drawing.Point(19, 109)
        Me.cmbDocumentazione.MaxDropDownItems = 15
        Me.cmbDocumentazione.Name = "cmbDocumentazione"
        Me.cmbDocumentazione.Size = New System.Drawing.Size(270, 28)
        Me.cmbDocumentazione.TabIndex = 78
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(15, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 24)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Invio documentazione tecnica"
        '
        'cmbRivalidato
        '
        Me.cmbRivalidato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRivalidato.DropDownHeight = 105
        Me.cmbRivalidato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRivalidato.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRivalidato.FormattingEnabled = True
        Me.cmbRivalidato.IntegralHeight = False
        Me.cmbRivalidato.Items.AddRange(New Object() {"Si", "No", "In deroga"})
        Me.cmbRivalidato.Location = New System.Drawing.Point(19, 183)
        Me.cmbRivalidato.MaxDropDownItems = 15
        Me.cmbRivalidato.Name = "cmbRivalidato"
        Me.cmbRivalidato.Size = New System.Drawing.Size(270, 28)
        Me.cmbRivalidato.TabIndex = 80
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(14, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 24)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Fornitore rivalidato"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(14, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 24)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Nota"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(19, 263)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(259, 68)
        Me.txtNote.TabIndex = 82
        '
        'pnlDati
        '
        Me.pnlDati.Controls.Add(Me.txtNote)
        Me.pnlDati.Controls.Add(Me.btnSalva)
        Me.pnlDati.Controls.Add(Me.Label6)
        Me.pnlDati.Controls.Add(Me.cmbRivalidato)
        Me.pnlDati.Controls.Add(Me.Label2)
        Me.pnlDati.Controls.Add(Me.Label3)
        Me.pnlDati.Controls.Add(Me.cmbDocumentazione)
        Me.pnlDati.Controls.Add(Me.cmbEsito)
        Me.pnlDati.Controls.Add(Me.Label4)
        Me.pnlDati.Enabled = False
        Me.pnlDati.Location = New System.Drawing.Point(19, 153)
        Me.pnlDati.Name = "pnlDati"
        Me.pnlDati.Size = New System.Drawing.Size(317, 444)
        Me.pnlDati.TabIndex = 83
        '
        'btnSalva
        '
        Me.btnSalva.Location = New System.Drawing.Point(83, 357)
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(125, 59)
        Me.btnSalva.TabIndex = 84
        Me.btnSalva.Text = "Salva"
        Me.btnSalva.UseVisualStyleBackColor = True
        '
        'imgFound
        '
        Me.imgFound.Location = New System.Drawing.Point(295, 99)
        Me.imgFound.Name = "imgFound"
        Me.imgFound.Size = New System.Drawing.Size(61, 48)
        Me.imgFound.TabIndex = 85
        Me.imgFound.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(141, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 24)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Anno"
        '
        'cmbAnno
        '
        Me.cmbAnno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbAnno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAnno.DropDownHeight = 105
        Me.cmbAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAnno.FormattingEnabled = True
        Me.cmbAnno.IntegralHeight = False
        Me.cmbAnno.Location = New System.Drawing.Point(102, 37)
        Me.cmbAnno.MaxDropDownItems = 15
        Me.cmbAnno.Name = "cmbAnno"
        Me.cmbAnno.Size = New System.Drawing.Size(136, 28)
        Me.cmbAnno.TabIndex = 86
        '
        'btnCheckFornitori
        '
        Me.btnCheckFornitori.Location = New System.Drawing.Point(256, 24)
        Me.btnCheckFornitori.Name = "btnCheckFornitori"
        Me.btnCheckFornitori.Size = New System.Drawing.Size(128, 55)
        Me.btnCheckFornitori.TabIndex = 88
        Me.btnCheckFornitori.Text = "Check Nuovi Fornitori"
        Me.btnCheckFornitori.UseVisualStyleBackColor = True
        '
        'frmValidazioneFornitori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 616)
        Me.Controls.Add(Me.btnCheckFornitori)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbAnno)
        Me.Controls.Add(Me.imgFound)
        Me.Controls.Add(Me.pnlDati)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbCodiceFornitore)
        Me.Controls.Add(Me.cmbRagsFornitore)
        Me.Name = "frmValidazioneFornitori"
        Me.Text = "Validazione Fornitori"
        Me.pnlDati.ResumeLayout(False)
        Me.pnlDati.PerformLayout()
        CType(Me.imgFound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbCodiceFornitore As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRagsFornitore As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbEsito As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbDocumentazione As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbRivalidato As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents pnlDati As System.Windows.Forms.Panel
    Friend WithEvents btnSalva As System.Windows.Forms.Button
    Friend WithEvents imgFound As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbAnno As System.Windows.Forms.ComboBox
    Friend WithEvents btnCheckFornitori As System.Windows.Forms.Button
End Class
