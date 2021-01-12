<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFornitori
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFornitori))
        Me.dgvFornitori = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbAnno = New System.Windows.Forms.ComboBox()
        Me.cmbPathTipoFile = New System.Windows.Forms.ComboBox()
        Me.cmbIdTipoFile = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbTipoFile = New System.Windows.Forms.ComboBox()
        Me.btnAddFile = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNomeFile = New System.Windows.Forms.TextBox()
        Me.btnSrcFile = New System.Windows.Forms.Button()
        Me.dgvFiles = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipoFile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApri = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colElimina = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.cmbIdRivalidazione = New System.Windows.Forms.ComboBox()
        Me.cmbIdDocumentazione = New System.Windows.Forms.ComboBox()
        Me.cmbIdQuestionario = New System.Windows.Forms.ComboBox()
        Me.cmbIdTipologia = New System.Windows.Forms.ComboBox()
        Me.cmbTipologiaFornitore = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCodiceFornitoreSel = New System.Windows.Forms.Label()
        Me.lblFornitore = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.btnSalva = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbRivalidato = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbDocumentazione = New System.Windows.Forms.ComboBox()
        Me.cmbQuestionario = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCheckNuovi = New System.Windows.Forms.Button()
        Me.dtpFiltro = New System.Windows.Forms.DateTimePicker()
        Me.checkFiltro = New System.Windows.Forms.CheckBox()
        Me.lblNewFornitori = New System.Windows.Forms.Label()
        Me.txtCodiceFornitore = New System.Windows.Forms.TextBox()
        Me.checkFiltroFornitore = New System.Windows.Forms.CheckBox()
        Me.checkFiltroRags = New System.Windows.Forms.CheckBox()
        Me.txtRagSoc = New System.Windows.Forms.TextBox()
        Me.checkFiltroVisibili = New System.Windows.Forms.CheckBox()
        Me.checkFiltroInvisibili = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbIdCategoriaFornitore = New System.Windows.Forms.ComboBox()
        Me.cmbCategoriaFornitore = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.colFornitore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRagsociale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCategoriaFornitori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNonVisibile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBtnVal = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colidTipologia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipologia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIdQuestionario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQuestionario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIdDocumentazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDocumentazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIdRivalidato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRivalidato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIdCategoriaFornitori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvFornitori, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvFornitori
        '
        Me.dgvFornitori.AllowUserToAddRows = False
        Me.dgvFornitori.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFornitori.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFornitori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFornitori.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFornitore, Me.colRagsociale, Me.colCategoriaFornitori, Me.colNonVisibile, Me.colBtnVal, Me.colidTipologia, Me.colTipologia, Me.colIdQuestionario, Me.colQuestionario, Me.colIdDocumentazione, Me.colDocumentazione, Me.colIdRivalidato, Me.colRivalidato, Me.colIdCategoriaFornitori, Me.colNote})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFornitori.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFornitori.Location = New System.Drawing.Point(12, 170)
        Me.dgvFornitori.Name = "dgvFornitori"
        Me.dgvFornitori.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFornitori.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFornitori.RowHeadersVisible = False
        Me.dgvFornitori.Size = New System.Drawing.Size(674, 550)
        Me.dgvFornitori.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 24)
        Me.Label1.TabIndex = 88
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
        Me.cmbAnno.Location = New System.Drawing.Point(79, 12)
        Me.cmbAnno.MaxDropDownItems = 15
        Me.cmbAnno.Name = "cmbAnno"
        Me.cmbAnno.Size = New System.Drawing.Size(136, 28)
        Me.cmbAnno.TabIndex = 89
        '
        'cmbPathTipoFile
        '
        Me.cmbPathTipoFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPathTipoFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPathTipoFile.FormattingEnabled = True
        Me.cmbPathTipoFile.Location = New System.Drawing.Point(175, 454)
        Me.cmbPathTipoFile.Name = "cmbPathTipoFile"
        Me.cmbPathTipoFile.Size = New System.Drawing.Size(16, 28)
        Me.cmbPathTipoFile.TabIndex = 103
        Me.cmbPathTipoFile.Visible = False
        '
        'cmbIdTipoFile
        '
        Me.cmbIdTipoFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdTipoFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdTipoFile.FormattingEnabled = True
        Me.cmbIdTipoFile.Location = New System.Drawing.Point(150, 454)
        Me.cmbIdTipoFile.Name = "cmbIdTipoFile"
        Me.cmbIdTipoFile.Size = New System.Drawing.Size(16, 28)
        Me.cmbIdTipoFile.TabIndex = 102
        Me.cmbIdTipoFile.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(127, 433)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 20)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Tipologia File"
        '
        'cmbTipoFile
        '
        Me.cmbTipoFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoFile.FormattingEnabled = True
        Me.cmbTipoFile.Location = New System.Drawing.Point(228, 430)
        Me.cmbTipoFile.Name = "cmbTipoFile"
        Me.cmbTipoFile.Size = New System.Drawing.Size(165, 28)
        Me.cmbTipoFile.TabIndex = 100
        '
        'btnAddFile
        '
        Me.btnAddFile.BackgroundImage = Global.RegistroNcEsperia.My.Resources.Resources.Download_icon
        Me.btnAddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnAddFile.Location = New System.Drawing.Point(424, 396)
        Me.btnAddFile.Name = "btnAddFile"
        Me.btnAddFile.Size = New System.Drawing.Size(71, 62)
        Me.btnAddFile.TabIndex = 97
        Me.ToolTip1.SetToolTip(Me.btnAddFile, "Aggiungi File")
        Me.btnAddFile.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(130, 401)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 20)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Nome file"
        '
        'txtNomeFile
        '
        Me.txtNomeFile.Enabled = False
        Me.txtNomeFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeFile.Location = New System.Drawing.Point(228, 398)
        Me.txtNomeFile.Multiline = True
        Me.txtNomeFile.Name = "txtNomeFile"
        Me.txtNomeFile.Size = New System.Drawing.Size(165, 28)
        Me.txtNomeFile.TabIndex = 95
        '
        'btnSrcFile
        '
        Me.btnSrcFile.BackgroundImage = Global.RegistroNcEsperia.My.Resources.Resources.Search_icon_48
        Me.btnSrcFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSrcFile.Location = New System.Drawing.Point(28, 396)
        Me.btnSrcFile.Name = "btnSrcFile"
        Me.btnSrcFile.Size = New System.Drawing.Size(71, 62)
        Me.btnSrcFile.TabIndex = 94
        Me.ToolTip1.SetToolTip(Me.btnSrcFile, "Ricerca file")
        Me.btnSrcFile.UseVisualStyleBackColor = True
        '
        'dgvFiles
        '
        Me.dgvFiles.AllowUserToAddRows = False
        Me.dgvFiles.AllowUserToDeleteRows = False
        Me.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colNome, Me.colTipoFile, Me.colPath, Me.colApri, Me.colElimina})
        Me.dgvFiles.Location = New System.Drawing.Point(28, 488)
        Me.dgvFiles.Name = "dgvFiles"
        Me.dgvFiles.ReadOnly = True
        Me.dgvFiles.RowHeadersVisible = False
        Me.dgvFiles.Size = New System.Drawing.Size(467, 142)
        Me.dgvFiles.TabIndex = 93
        '
        'colID
        '
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Visible = False
        '
        'colNome
        '
        Me.colNome.HeaderText = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.ReadOnly = True
        Me.colNome.Width = 105
        '
        'colTipoFile
        '
        Me.colTipoFile.HeaderText = "Tipo"
        Me.colTipoFile.Name = "colTipoFile"
        Me.colTipoFile.ReadOnly = True
        Me.colTipoFile.Width = 150
        '
        'colPath
        '
        Me.colPath.HeaderText = "Percorso"
        Me.colPath.Name = "colPath"
        Me.colPath.ReadOnly = True
        Me.colPath.Visible = False
        Me.colPath.Width = 150
        '
        'colApri
        '
        Me.colApri.HeaderText = "Apri"
        Me.colApri.Name = "colApri"
        Me.colApri.ReadOnly = True
        Me.colApri.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colApri.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colElimina
        '
        Me.colElimina.HeaderText = "Elimina"
        Me.colElimina.Name = "colElimina"
        Me.colElimina.ReadOnly = True
        Me.colElimina.Text = "Elimina"
        '
        'cmbIdRivalidazione
        '
        Me.cmbIdRivalidazione.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbIdRivalidazione.DropDownHeight = 105
        Me.cmbIdRivalidazione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdRivalidazione.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdRivalidazione.FormattingEnabled = True
        Me.cmbIdRivalidazione.IntegralHeight = False
        Me.cmbIdRivalidazione.Location = New System.Drawing.Point(247, 121)
        Me.cmbIdRivalidazione.MaxDropDownItems = 15
        Me.cmbIdRivalidazione.Name = "cmbIdRivalidazione"
        Me.cmbIdRivalidazione.Size = New System.Drawing.Size(27, 28)
        Me.cmbIdRivalidazione.TabIndex = 92
        Me.cmbIdRivalidazione.Visible = False
        '
        'cmbIdDocumentazione
        '
        Me.cmbIdDocumentazione.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbIdDocumentazione.DropDownHeight = 105
        Me.cmbIdDocumentazione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdDocumentazione.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdDocumentazione.FormattingEnabled = True
        Me.cmbIdDocumentazione.IntegralHeight = False
        Me.cmbIdDocumentazione.Location = New System.Drawing.Point(239, 121)
        Me.cmbIdDocumentazione.MaxDropDownItems = 15
        Me.cmbIdDocumentazione.Name = "cmbIdDocumentazione"
        Me.cmbIdDocumentazione.Size = New System.Drawing.Size(35, 28)
        Me.cmbIdDocumentazione.TabIndex = 91
        Me.cmbIdDocumentazione.Visible = False
        '
        'cmbIdQuestionario
        '
        Me.cmbIdQuestionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbIdQuestionario.DropDownHeight = 105
        Me.cmbIdQuestionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdQuestionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdQuestionario.FormattingEnabled = True
        Me.cmbIdQuestionario.IntegralHeight = False
        Me.cmbIdQuestionario.Location = New System.Drawing.Point(239, 180)
        Me.cmbIdQuestionario.MaxDropDownItems = 15
        Me.cmbIdQuestionario.Name = "cmbIdQuestionario"
        Me.cmbIdQuestionario.Size = New System.Drawing.Size(27, 28)
        Me.cmbIdQuestionario.TabIndex = 90
        Me.cmbIdQuestionario.Visible = False
        '
        'cmbIdTipologia
        '
        Me.cmbIdTipologia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbIdTipologia.DropDownHeight = 105
        Me.cmbIdTipologia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdTipologia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdTipologia.FormattingEnabled = True
        Me.cmbIdTipologia.IntegralHeight = False
        Me.cmbIdTipologia.Location = New System.Drawing.Point(36, 121)
        Me.cmbIdTipologia.MaxDropDownItems = 15
        Me.cmbIdTipologia.Name = "cmbIdTipologia"
        Me.cmbIdTipologia.Size = New System.Drawing.Size(27, 28)
        Me.cmbIdTipologia.TabIndex = 89
        Me.cmbIdTipologia.Visible = False
        '
        'cmbTipologiaFornitore
        '
        Me.cmbTipologiaFornitore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipologiaFornitore.DropDownHeight = 105
        Me.cmbTipologiaFornitore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipologiaFornitore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipologiaFornitore.FormattingEnabled = True
        Me.cmbTipologiaFornitore.IntegralHeight = False
        Me.cmbTipologiaFornitore.Location = New System.Drawing.Point(36, 121)
        Me.cmbTipologiaFornitore.MaxDropDownItems = 15
        Me.cmbTipologiaFornitore.Name = "cmbTipologiaFornitore"
        Me.cmbTipologiaFornitore.Size = New System.Drawing.Size(187, 28)
        Me.cmbTipologiaFornitore.TabIndex = 88
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(32, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 20)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "Tipologia Fornitore"
        '
        'lblCodiceFornitoreSel
        '
        Me.lblCodiceFornitoreSel.AutoSize = True
        Me.lblCodiceFornitoreSel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodiceFornitoreSel.ForeColor = System.Drawing.Color.Black
        Me.lblCodiceFornitoreSel.Location = New System.Drawing.Point(273, 50)
        Me.lblCodiceFornitoreSel.Name = "lblCodiceFornitoreSel"
        Me.lblCodiceFornitoreSel.Size = New System.Drawing.Size(161, 24)
        Me.lblCodiceFornitoreSel.TabIndex = 86
        Me.lblCodiceFornitoreSel.Text = "CodiceFornitore"
        Me.lblCodiceFornitoreSel.Visible = False
        '
        'lblFornitore
        '
        Me.lblFornitore.AutoSize = True
        Me.lblFornitore.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblFornitore.ForeColor = System.Drawing.Color.Black
        Me.lblFornitore.Location = New System.Drawing.Point(235, 25)
        Me.lblFornitore.Name = "lblFornitore"
        Me.lblFornitore.Size = New System.Drawing.Size(158, 22)
        Me.lblFornitore.TabIndex = 85
        Me.lblFornitore.Text = "RagsocFornitore"
        '
        'txtNote
        '
        Me.txtNote.Location = New System.Drawing.Point(36, 294)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(441, 68)
        Me.txtNote.TabIndex = 82
        '
        'btnSalva
        '
        Me.btnSalva.BackgroundImage = CType(resources.GetObject("btnSalva.BackgroundImage"), System.Drawing.Image)
        Me.btnSalva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSalva.Location = New System.Drawing.Point(3, 3)
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(121, 76)
        Me.btnSalva.TabIndex = 84
        Me.ToolTip1.SetToolTip(Me.btnSalva, "Salva dati")
        Me.btnSalva.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(32, 271)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 20)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Nota"
        '
        'cmbRivalidato
        '
        Me.cmbRivalidato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRivalidato.DropDownHeight = 105
        Me.cmbRivalidato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRivalidato.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRivalidato.FormattingEnabled = True
        Me.cmbRivalidato.IntegralHeight = False
        Me.cmbRivalidato.Location = New System.Drawing.Point(36, 180)
        Me.cmbRivalidato.MaxDropDownItems = 15
        Me.cmbRivalidato.Name = "cmbRivalidato"
        Me.cmbRivalidato.Size = New System.Drawing.Size(187, 28)
        Me.cmbRivalidato.TabIndex = 80
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(230, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 20)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Invio documentazione tecnica"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(33, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 20)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Fornitore rivalidato"
        '
        'cmbDocumentazione
        '
        Me.cmbDocumentazione.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDocumentazione.DropDownHeight = 105
        Me.cmbDocumentazione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDocumentazione.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDocumentazione.FormattingEnabled = True
        Me.cmbDocumentazione.IntegralHeight = False
        Me.cmbDocumentazione.Location = New System.Drawing.Point(239, 121)
        Me.cmbDocumentazione.MaxDropDownItems = 15
        Me.cmbDocumentazione.Name = "cmbDocumentazione"
        Me.cmbDocumentazione.Size = New System.Drawing.Size(265, 28)
        Me.cmbDocumentazione.TabIndex = 78
        '
        'cmbQuestionario
        '
        Me.cmbQuestionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbQuestionario.DropDownHeight = 105
        Me.cmbQuestionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQuestionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbQuestionario.FormattingEnabled = True
        Me.cmbQuestionario.IntegralHeight = False
        Me.cmbQuestionario.Location = New System.Drawing.Point(239, 180)
        Me.cmbQuestionario.MaxDropDownItems = 15
        Me.cmbQuestionario.Name = "cmbQuestionario"
        Me.cmbQuestionario.Size = New System.Drawing.Size(184, 28)
        Me.cmbQuestionario.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(235, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 20)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Esito questionario"
        '
        'btnCheckNuovi
        '
        Me.btnCheckNuovi.BackColor = System.Drawing.Color.Transparent
        Me.btnCheckNuovi.BackgroundImage = Global.RegistroNcEsperia.My.Resources.Resources.Synchronize_icon
        Me.btnCheckNuovi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCheckNuovi.Location = New System.Drawing.Point(462, 59)
        Me.btnCheckNuovi.Name = "btnCheckNuovi"
        Me.btnCheckNuovi.Size = New System.Drawing.Size(57, 57)
        Me.btnCheckNuovi.TabIndex = 91
        Me.btnCheckNuovi.Tag = "CHECK NUOVI"
        Me.btnCheckNuovi.UseVisualStyleBackColor = False
        '
        'dtpFiltro
        '
        Me.dtpFiltro.Enabled = False
        Me.dtpFiltro.Location = New System.Drawing.Point(176, 88)
        Me.dtpFiltro.Name = "dtpFiltro"
        Me.dtpFiltro.Size = New System.Drawing.Size(169, 20)
        Me.dtpFiltro.TabIndex = 92
        '
        'checkFiltro
        '
        Me.checkFiltro.AutoSize = True
        Me.checkFiltro.Location = New System.Drawing.Point(176, 69)
        Me.checkFiltro.Name = "checkFiltro"
        Me.checkFiltro.Size = New System.Drawing.Size(169, 17)
        Me.checkFiltro.TabIndex = 93
        Me.checkFiltro.Text = "Filtro data inserimento fornitore"
        Me.checkFiltro.UseVisualStyleBackColor = True
        '
        'lblNewFornitori
        '
        Me.lblNewFornitori.AutoSize = True
        Me.lblNewFornitori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblNewFornitori.ForeColor = System.Drawing.Color.Red
        Me.lblNewFornitori.Location = New System.Drawing.Point(403, 125)
        Me.lblNewFornitori.Name = "lblNewFornitori"
        Me.lblNewFornitori.Size = New System.Drawing.Size(87, 13)
        Me.lblNewFornitori.TabIndex = 94
        Me.lblNewFornitori.Text = "qtaNuoviFornitori"
        Me.lblNewFornitori.Visible = False
        '
        'txtCodiceFornitore
        '
        Me.txtCodiceFornitore.Enabled = False
        Me.txtCodiceFornitore.Location = New System.Drawing.Point(17, 140)
        Me.txtCodiceFornitore.Name = "txtCodiceFornitore"
        Me.txtCodiceFornitore.Size = New System.Drawing.Size(153, 20)
        Me.txtCodiceFornitore.TabIndex = 95
        '
        'checkFiltroFornitore
        '
        Me.checkFiltroFornitore.AutoSize = True
        Me.checkFiltroFornitore.Location = New System.Drawing.Point(17, 121)
        Me.checkFiltroFornitore.Name = "checkFiltroFornitore"
        Me.checkFiltroFornitore.Size = New System.Drawing.Size(124, 17)
        Me.checkFiltroFornitore.TabIndex = 96
        Me.checkFiltroFornitore.Text = "Filtro codice fornitore"
        Me.checkFiltroFornitore.UseVisualStyleBackColor = True
        '
        'checkFiltroRags
        '
        Me.checkFiltroRags.AutoSize = True
        Me.checkFiltroRags.Location = New System.Drawing.Point(12, 69)
        Me.checkFiltroRags.Name = "checkFiltroRags"
        Me.checkFiltroRags.Size = New System.Drawing.Size(163, 17)
        Me.checkFiltroRags.TabIndex = 98
        Me.checkFiltroRags.Text = "Filtro ragione sociale fornitore"
        Me.checkFiltroRags.UseVisualStyleBackColor = True
        '
        'txtRagSoc
        '
        Me.txtRagSoc.Enabled = False
        Me.txtRagSoc.Location = New System.Drawing.Point(12, 88)
        Me.txtRagSoc.Name = "txtRagSoc"
        Me.txtRagSoc.Size = New System.Drawing.Size(153, 20)
        Me.txtRagSoc.TabIndex = 97
        '
        'checkFiltroVisibili
        '
        Me.checkFiltroVisibili.AutoSize = True
        Me.checkFiltroVisibili.Location = New System.Drawing.Point(209, 121)
        Me.checkFiltroVisibili.Name = "checkFiltroVisibili"
        Me.checkFiltroVisibili.Size = New System.Drawing.Size(78, 17)
        Me.checkFiltroVisibili.TabIndex = 99
        Me.checkFiltroVisibili.Text = "Solo Visibili"
        Me.checkFiltroVisibili.UseVisualStyleBackColor = True
        '
        'checkFiltroInvisibili
        '
        Me.checkFiltroInvisibili.AutoSize = True
        Me.checkFiltroInvisibili.Location = New System.Drawing.Point(209, 143)
        Me.checkFiltroInvisibili.Name = "checkFiltroInvisibili"
        Me.checkFiltroInvisibili.Size = New System.Drawing.Size(91, 17)
        Me.checkFiltroInvisibili.TabIndex = 100
        Me.checkFiltroInvisibili.Text = "Solo Nascosti"
        Me.checkFiltroInvisibili.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmbIdCategoriaFornitore)
        Me.Panel1.Controls.Add(Me.cmbCategoriaFornitore)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.cmbIdTipologia)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnSalva)
        Me.Panel1.Controls.Add(Me.cmbPathTipoFile)
        Me.Panel1.Controls.Add(Me.cmbIdTipoFile)
        Me.Panel1.Controls.Add(Me.txtNote)
        Me.Panel1.Controls.Add(Me.cmbTipologiaFornitore)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmbIdQuestionario)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cmbIdDocumentazione)
        Me.Panel1.Controls.Add(Me.cmbQuestionario)
        Me.Panel1.Controls.Add(Me.lblCodiceFornitoreSel)
        Me.Panel1.Controls.Add(Me.cmbTipoFile)
        Me.Panel1.Controls.Add(Me.cmbIdRivalidazione)
        Me.Panel1.Controls.Add(Me.cmbDocumentazione)
        Me.Panel1.Controls.Add(Me.lblFornitore)
        Me.Panel1.Controls.Add(Me.btnAddFile)
        Me.Panel1.Controls.Add(Me.dgvFiles)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbRivalidato)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.btnSrcFile)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNomeFile)
        Me.Panel1.Location = New System.Drawing.Point(692, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(517, 644)
        Me.Panel1.TabIndex = 102
        '
        'cmbIdCategoriaFornitore
        '
        Me.cmbIdCategoriaFornitore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbIdCategoriaFornitore.DropDownHeight = 105
        Me.cmbIdCategoriaFornitore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdCategoriaFornitore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdCategoriaFornitore.FormattingEnabled = True
        Me.cmbIdCategoriaFornitore.IntegralHeight = False
        Me.cmbIdCategoriaFornitore.Location = New System.Drawing.Point(38, 243)
        Me.cmbIdCategoriaFornitore.MaxDropDownItems = 15
        Me.cmbIdCategoriaFornitore.Name = "cmbIdCategoriaFornitore"
        Me.cmbIdCategoriaFornitore.Size = New System.Drawing.Size(27, 28)
        Me.cmbIdCategoriaFornitore.TabIndex = 107
        Me.cmbIdCategoriaFornitore.Visible = False
        '
        'cmbCategoriaFornitore
        '
        Me.cmbCategoriaFornitore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCategoriaFornitore.DropDownHeight = 105
        Me.cmbCategoriaFornitore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoriaFornitore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategoriaFornitore.FormattingEnabled = True
        Me.cmbCategoriaFornitore.IntegralHeight = False
        Me.cmbCategoriaFornitore.Location = New System.Drawing.Point(38, 243)
        Me.cmbCategoriaFornitore.MaxDropDownItems = 15
        Me.cmbCategoriaFornitore.Name = "cmbCategoriaFornitore"
        Me.cmbCategoriaFornitore.Size = New System.Drawing.Size(187, 28)
        Me.cmbCategoriaFornitore.TabIndex = 106
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(34, 216)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 20)
        Me.Label10.TabIndex = 105
        Me.Label10.Text = "Categoria Fornitore"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(198, 363)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 29)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "Allegati"
        '
        'colFornitore
        '
        Me.colFornitore.HeaderText = "Codice Fornitore"
        Me.colFornitore.Name = "colFornitore"
        Me.colFornitore.ReadOnly = True
        Me.colFornitore.Width = 190
        '
        'colRagsociale
        '
        Me.colRagsociale.HeaderText = "Ragione Sociale"
        Me.colRagsociale.Name = "colRagsociale"
        Me.colRagsociale.ReadOnly = True
        Me.colRagsociale.Width = 250
        '
        'colCategoriaFornitori
        '
        Me.colCategoriaFornitori.HeaderText = "Categoria fornitori"
        Me.colCategoriaFornitori.Name = "colCategoriaFornitori"
        Me.colCategoriaFornitori.ReadOnly = True
        Me.colCategoriaFornitori.Visible = False
        '
        'colNonVisibile
        '
        Me.colNonVisibile.HeaderText = "Nascosto"
        Me.colNonVisibile.Name = "colNonVisibile"
        Me.colNonVisibile.ReadOnly = True
        '
        'colBtnVal
        '
        Me.colBtnVal.HeaderText = "Passa a validazione"
        Me.colBtnVal.Name = "colBtnVal"
        Me.colBtnVal.ReadOnly = True
        Me.colBtnVal.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colBtnVal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'colidTipologia
        '
        Me.colidTipologia.HeaderText = "Id Tipologia"
        Me.colidTipologia.Name = "colidTipologia"
        Me.colidTipologia.ReadOnly = True
        Me.colidTipologia.Visible = False
        '
        'colTipologia
        '
        Me.colTipologia.HeaderText = "Tipologia Fornitore"
        Me.colTipologia.Name = "colTipologia"
        Me.colTipologia.ReadOnly = True
        Me.colTipologia.Visible = False
        '
        'colIdQuestionario
        '
        Me.colIdQuestionario.HeaderText = "Id Questionario"
        Me.colIdQuestionario.Name = "colIdQuestionario"
        Me.colIdQuestionario.ReadOnly = True
        Me.colIdQuestionario.Visible = False
        '
        'colQuestionario
        '
        Me.colQuestionario.HeaderText = "Questionario"
        Me.colQuestionario.Name = "colQuestionario"
        Me.colQuestionario.ReadOnly = True
        Me.colQuestionario.Visible = False
        '
        'colIdDocumentazione
        '
        Me.colIdDocumentazione.HeaderText = "Id Documentazione"
        Me.colIdDocumentazione.Name = "colIdDocumentazione"
        Me.colIdDocumentazione.ReadOnly = True
        Me.colIdDocumentazione.Visible = False
        '
        'colDocumentazione
        '
        Me.colDocumentazione.HeaderText = "Documentazione"
        Me.colDocumentazione.Name = "colDocumentazione"
        Me.colDocumentazione.ReadOnly = True
        Me.colDocumentazione.Visible = False
        '
        'colIdRivalidato
        '
        Me.colIdRivalidato.HeaderText = "Id Rivalidato"
        Me.colIdRivalidato.Name = "colIdRivalidato"
        Me.colIdRivalidato.ReadOnly = True
        Me.colIdRivalidato.Visible = False
        '
        'colRivalidato
        '
        Me.colRivalidato.HeaderText = "Rivalidato"
        Me.colRivalidato.Name = "colRivalidato"
        Me.colRivalidato.ReadOnly = True
        Me.colRivalidato.Visible = False
        '
        'colIdCategoriaFornitori
        '
        Me.colIdCategoriaFornitori.HeaderText = "Id Categoria Fornitori"
        Me.colIdCategoriaFornitori.Name = "colIdCategoriaFornitori"
        Me.colIdCategoriaFornitori.ReadOnly = True
        Me.colIdCategoriaFornitori.Visible = False
        '
        'colNote
        '
        Me.colNote.HeaderText = "Note"
        Me.colNote.Name = "colNote"
        Me.colNote.ReadOnly = True
        Me.colNote.Visible = False
        '
        'frmFornitori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 732)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.checkFiltroInvisibili)
        Me.Controls.Add(Me.checkFiltroVisibili)
        Me.Controls.Add(Me.checkFiltroRags)
        Me.Controls.Add(Me.txtRagSoc)
        Me.Controls.Add(Me.checkFiltroFornitore)
        Me.Controls.Add(Me.txtCodiceFornitore)
        Me.Controls.Add(Me.lblNewFornitori)
        Me.Controls.Add(Me.checkFiltro)
        Me.Controls.Add(Me.dtpFiltro)
        Me.Controls.Add(Me.btnCheckNuovi)
        Me.Controls.Add(Me.cmbAnno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvFornitori)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFornitori"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione Fornitori"
        CType(Me.dgvFornitori, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvFornitori As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbAnno As System.Windows.Forms.ComboBox
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents btnSalva As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbRivalidato As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbDocumentazione As System.Windows.Forms.ComboBox
    Friend WithEvents cmbQuestionario As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblFornitore As System.Windows.Forms.Label
    Friend WithEvents btnCheckNuovi As System.Windows.Forms.Button
    Friend WithEvents lblCodiceFornitoreSel As System.Windows.Forms.Label
    Friend WithEvents dtpFiltro As System.Windows.Forms.DateTimePicker
    Friend WithEvents checkFiltro As System.Windows.Forms.CheckBox
    Friend WithEvents lblNewFornitori As System.Windows.Forms.Label
    Friend WithEvents txtCodiceFornitore As System.Windows.Forms.TextBox
    Friend WithEvents checkFiltroFornitore As System.Windows.Forms.CheckBox
    Friend WithEvents checkFiltroRags As System.Windows.Forms.CheckBox
    Friend WithEvents txtRagSoc As System.Windows.Forms.TextBox
    Friend WithEvents checkFiltroVisibili As System.Windows.Forms.CheckBox
    Friend WithEvents checkFiltroInvisibili As System.Windows.Forms.CheckBox
    Friend WithEvents cmbTipologiaFornitore As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbIdRivalidazione As System.Windows.Forms.ComboBox
    Friend WithEvents cmbIdDocumentazione As System.Windows.Forms.ComboBox
    Friend WithEvents cmbIdQuestionario As System.Windows.Forms.ComboBox
    Friend WithEvents cmbIdTipologia As System.Windows.Forms.ComboBox
    Friend WithEvents dgvFiles As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoFile As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddFile As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNomeFile As System.Windows.Forms.TextBox
    Friend WithEvents btnSrcFile As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmbIdTipoFile As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPathTipoFile As System.Windows.Forms.ComboBox
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipoFile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colApri As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colElimina As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents cmbCategoriaFornitore As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbIdCategoriaFornitore As ComboBox
    Friend WithEvents colFornitore As DataGridViewTextBoxColumn
    Friend WithEvents colRagsociale As DataGridViewTextBoxColumn
    Friend WithEvents colCategoriaFornitori As DataGridViewTextBoxColumn
    Friend WithEvents colNonVisibile As DataGridViewTextBoxColumn
    Friend WithEvents colBtnVal As DataGridViewButtonColumn
    Friend WithEvents colidTipologia As DataGridViewTextBoxColumn
    Friend WithEvents colTipologia As DataGridViewTextBoxColumn
    Friend WithEvents colIdQuestionario As DataGridViewTextBoxColumn
    Friend WithEvents colQuestionario As DataGridViewTextBoxColumn
    Friend WithEvents colIdDocumentazione As DataGridViewTextBoxColumn
    Friend WithEvents colDocumentazione As DataGridViewTextBoxColumn
    Friend WithEvents colIdRivalidato As DataGridViewTextBoxColumn
    Friend WithEvents colRivalidato As DataGridViewTextBoxColumn
    Friend WithEvents colIdCategoriaFornitori As DataGridViewTextBoxColumn
    Friend WithEvents colNote As DataGridViewTextBoxColumn
End Class
