<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAllegati
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAllegati))
        Me.btnSrcFile = New System.Windows.Forms.Button()
        Me.dgvFiles = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPath = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colApri = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colElimina = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtNomeFile = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddFile = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cmbFormatoFile = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSrcFile
        '
        Me.btnSrcFile.Location = New System.Drawing.Point(12, 175)
        Me.btnSrcFile.Name = "btnSrcFile"
        Me.btnSrcFile.Size = New System.Drawing.Size(75, 23)
        Me.btnSrcFile.TabIndex = 0
        Me.btnSrcFile.Text = "Cerca file"
        Me.btnSrcFile.UseVisualStyleBackColor = True
        '
        'dgvFiles
        '
        Me.dgvFiles.AllowUserToAddRows = False
        Me.dgvFiles.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFiles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFiles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colNome, Me.colPath, Me.colApri, Me.colElimina})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvFiles.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFiles.Location = New System.Drawing.Point(12, 12)
        Me.dgvFiles.Name = "dgvFiles"
        Me.dgvFiles.ReadOnly = True
        Me.dgvFiles.RowHeadersVisible = False
        Me.dgvFiles.Size = New System.Drawing.Size(459, 150)
        Me.dgvFiles.TabIndex = 1
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
        'colPath
        '
        Me.colPath.HeaderText = "Percorso"
        Me.colPath.Name = "colPath"
        Me.colPath.ReadOnly = True
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
        'txtNomeFile
        '
        Me.txtNomeFile.Enabled = False
        Me.txtNomeFile.Location = New System.Drawing.Point(153, 177)
        Me.txtNomeFile.Multiline = True
        Me.txtNomeFile.Name = "txtNomeFile"
        Me.txtNomeFile.Size = New System.Drawing.Size(179, 50)
        Me.txtNomeFile.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nome file:"
        '
        'btnAddFile
        '
        Me.btnAddFile.Location = New System.Drawing.Point(12, 204)
        Me.btnAddFile.Name = "btnAddFile"
        Me.btnAddFile.Size = New System.Drawing.Size(75, 23)
        Me.btnAddFile.TabIndex = 4
        Me.btnAddFile.Text = "Aggiungi"
        Me.btnAddFile.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cmbFormatoFile
        '
        Me.cmbFormatoFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFormatoFile.FormattingEnabled = True
        Me.cmbFormatoFile.Items.AddRange(New Object() {".jpg", ".pdf", ".xls", ".doc"})
        Me.cmbFormatoFile.Location = New System.Drawing.Point(350, 199)
        Me.cmbFormatoFile.Name = "cmbFormatoFile"
        Me.cmbFormatoFile.Size = New System.Drawing.Size(121, 21)
        Me.cmbFormatoFile.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(374, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Formato file:"
        '
        'frmAllegati
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 239)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbFormatoFile)
        Me.Controls.Add(Me.btnAddFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNomeFile)
        Me.Controls.Add(Me.dgvFiles)
        Me.Controls.Add(Me.btnSrcFile)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(550, 278)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 278)
        Me.Name = "frmAllegati"
        Me.Text = "Allegati"
        CType(Me.dgvFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSrcFile As System.Windows.Forms.Button
    Friend WithEvents dgvFiles As System.Windows.Forms.DataGridView
    Friend WithEvents txtNomeFile As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAddFile As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPath As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colApri As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colElimina As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents cmbFormatoFile As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
