<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDataSegnalazione = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataApertura = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTipoAnomalia = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbOrigineAnomalia = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbClienteFinale = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbRespEstrusione = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbRespTermo = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbCapoturno = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtAddetto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbCodiceProduzione = New System.Windows.Forms.ComboBox()
        Me.cmbNumeroLotto = New System.Windows.Forms.ComboBox()
        Me.cmbMacrocategoria = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbDifettoCritico = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbGravitaProblema = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtGxF = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDescrizioneNC = New System.Windows.Forms.TextBox()
        Me.grpDatiGenerali = New System.Windows.Forms.GroupBox()
        Me.lblDescrFreq = New System.Windows.Forms.Label()
        Me.lblGravita = New System.Windows.Forms.Label()
        Me.cmbIdFrequenza = New System.Windows.Forms.ComboBox()
        Me.cmbFrequenzaProblema = New System.Windows.Forms.ComboBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.cmbIdGravProblema = New System.Windows.Forms.ComboBox()
        Me.cmbIdDifettoCritico = New System.Windows.Forms.ComboBox()
        Me.cmbIdCat = New System.Windows.Forms.ComboBox()
        Me.cmbIdMacroCat = New System.Windows.Forms.ComboBox()
        Me.cmbIdOrigineAnomalia = New System.Windows.Forms.ComboBox()
        Me.cmbIdAnomalia = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.GrpDatiProduzione = New System.Windows.Forms.GroupBox()
        Me.cmbPezzatura = New System.Windows.Forms.ComboBox()
        Me.cmbCodiceArticolo = New System.Windows.Forms.ComboBox()
        Me.btnProcedi = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.cmbNumeroProgressivo = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpDescrNC = New System.Windows.Forms.GroupBox()
        Me.cmbIdGestioneMateriali = New System.Windows.Forms.ComboBox()
        Me.cmbGestioneMateriale = New System.Windows.Forms.ComboBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.prgBar_loadingData = New System.Windows.Forms.ProgressBar()
        Me.pnlBottoni = New System.Windows.Forms.Panel()
        Me.logoEsp = New System.Windows.Forms.PictureBox()
        Me.logoEsp2 = New System.Windows.Forms.PictureBox()
        Me.menu1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaFornitoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpDatiGenerali.SuspendLayout()
        Me.GrpDatiProduzione.SuspendLayout()
        Me.grpDescrNC.SuspendLayout()
        Me.pnlBottoni.SuspendLayout()
        CType(Me.logoEsp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoEsp2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° progressivo"
        '
        'dtpDataSegnalazione
        '
        Me.dtpDataSegnalazione.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataSegnalazione.Location = New System.Drawing.Point(186, 51)
        Me.dtpDataSegnalazione.Name = "dtpDataSegnalazione"
        Me.dtpDataSegnalazione.Size = New System.Drawing.Size(270, 24)
        Me.dtpDataSegnalazione.TabIndex = 10
        '
        'dtpDataApertura
        '
        Me.dtpDataApertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDataApertura.Location = New System.Drawing.Point(186, 90)
        Me.dtpDataApertura.Name = "dtpDataApertura"
        Me.dtpDataApertura.Size = New System.Drawing.Size(270, 24)
        Me.dtpDataApertura.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Data segnalazione"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Data apertura"
        '
        'cmbTipoAnomalia
        '
        Me.cmbTipoAnomalia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoAnomalia.DropDownHeight = 105
        Me.cmbTipoAnomalia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoAnomalia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoAnomalia.FormattingEnabled = True
        Me.cmbTipoAnomalia.IntegralHeight = False
        Me.cmbTipoAnomalia.Location = New System.Drawing.Point(186, 128)
        Me.cmbTipoAnomalia.MaxDropDownItems = 15
        Me.cmbTipoAnomalia.Name = "cmbTipoAnomalia"
        Me.cmbTipoAnomalia.Size = New System.Drawing.Size(270, 28)
        Me.cmbTipoAnomalia.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 24)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tipo anomalia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 24)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Origine anomalia"
        '
        'cmbOrigineAnomalia
        '
        Me.cmbOrigineAnomalia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbOrigineAnomalia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbOrigineAnomalia.DropDownHeight = 105
        Me.cmbOrigineAnomalia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOrigineAnomalia.FormattingEnabled = True
        Me.cmbOrigineAnomalia.IntegralHeight = False
        Me.cmbOrigineAnomalia.Location = New System.Drawing.Point(186, 166)
        Me.cmbOrigineAnomalia.MaxDropDownItems = 15
        Me.cmbOrigineAnomalia.Name = "cmbOrigineAnomalia"
        Me.cmbOrigineAnomalia.Size = New System.Drawing.Size(270, 28)
        Me.cmbOrigineAnomalia.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 24)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Cliente finale"
        '
        'cmbClienteFinale
        '
        Me.cmbClienteFinale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbClienteFinale.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClienteFinale.FormattingEnabled = True
        Me.cmbClienteFinale.Items.AddRange(New Object() {"Non applicabile"})
        Me.cmbClienteFinale.Location = New System.Drawing.Point(186, 204)
        Me.cmbClienteFinale.Name = "cmbClienteFinale"
        Me.cmbClienteFinale.Size = New System.Drawing.Size(270, 32)
        Me.cmbClienteFinale.TabIndex = 50
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(10, 132)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(240, 24)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Responsabile estrusione"
        '
        'cmbRespEstrusione
        '
        Me.cmbRespEstrusione.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRespEstrusione.DropDownHeight = 105
        Me.cmbRespEstrusione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRespEstrusione.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRespEstrusione.FormattingEnabled = True
        Me.cmbRespEstrusione.IntegralHeight = False
        Me.cmbRespEstrusione.Location = New System.Drawing.Point(260, 127)
        Me.cmbRespEstrusione.MaxDropDownItems = 15
        Me.cmbRespEstrusione.Name = "cmbRespEstrusione"
        Me.cmbRespEstrusione.Size = New System.Drawing.Size(270, 32)
        Me.cmbRespEstrusione.TabIndex = 140
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(10, 94)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(196, 24)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Responsabile termo"
        '
        'cmbRespTermo
        '
        Me.cmbRespTermo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbRespTermo.DropDownHeight = 105
        Me.cmbRespTermo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRespTermo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRespTermo.FormattingEnabled = True
        Me.cmbRespTermo.IntegralHeight = False
        Me.cmbRespTermo.Location = New System.Drawing.Point(260, 89)
        Me.cmbRespTermo.MaxDropDownItems = 15
        Me.cmbRespTermo.Name = "cmbRespTermo"
        Me.cmbRespTermo.Size = New System.Drawing.Size(270, 32)
        Me.cmbRespTermo.TabIndex = 130
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(10, 52)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(107, 24)
        Me.Label20.TabIndex = 37
        Me.Label20.Text = "Capoturno"
        '
        'cmbCapoturno
        '
        Me.cmbCapoturno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCapoturno.DropDownHeight = 105
        Me.cmbCapoturno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCapoturno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCapoturno.FormattingEnabled = True
        Me.cmbCapoturno.IntegralHeight = False
        Me.cmbCapoturno.Location = New System.Drawing.Point(260, 51)
        Me.cmbCapoturno.MaxDropDownItems = 15
        Me.cmbCapoturno.Name = "cmbCapoturno"
        Me.cmbCapoturno.Size = New System.Drawing.Size(270, 32)
        Me.cmbCapoturno.TabIndex = 120
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(10, 173)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(82, 24)
        Me.Label21.TabIndex = 43
        Me.Label21.Text = "Addetto"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(10, 215)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(150, 24)
        Me.Label22.TabIndex = 44
        Me.Label22.Text = "Codice articolo"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(10, 291)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(130, 24)
        Me.Label23.TabIndex = 46
        Me.Label23.Text = "Numero lotto"
        '
        'txtAddetto
        '
        Me.txtAddetto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddetto.Location = New System.Drawing.Point(260, 168)
        Me.txtAddetto.Name = "txtAddetto"
        Me.txtAddetto.Size = New System.Drawing.Size(270, 29)
        Me.txtAddetto.TabIndex = 150
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(10, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(188, 24)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Codice produzione"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(10, 254)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 24)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Pezzatura"
        '
        'cmbCodiceProduzione
        '
        Me.cmbCodiceProduzione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbCodiceProduzione.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCodiceProduzione.FormattingEnabled = True
        Me.cmbCodiceProduzione.Items.AddRange(New Object() {"Non applicabile"})
        Me.cmbCodiceProduzione.Location = New System.Drawing.Point(260, 325)
        Me.cmbCodiceProduzione.Name = "cmbCodiceProduzione"
        Me.cmbCodiceProduzione.Size = New System.Drawing.Size(270, 32)
        Me.cmbCodiceProduzione.TabIndex = 180
        '
        'cmbNumeroLotto
        '
        Me.cmbNumeroLotto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbNumeroLotto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNumeroLotto.FormattingEnabled = True
        Me.cmbNumeroLotto.Items.AddRange(New Object() {"Non applicabile"})
        Me.cmbNumeroLotto.Location = New System.Drawing.Point(260, 287)
        Me.cmbNumeroLotto.Name = "cmbNumeroLotto"
        Me.cmbNumeroLotto.Size = New System.Drawing.Size(270, 32)
        Me.cmbNumeroLotto.TabIndex = 170
        '
        'cmbMacrocategoria
        '
        Me.cmbMacrocategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMacrocategoria.DropDownHeight = 105
        Me.cmbMacrocategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMacrocategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMacrocategoria.FormattingEnabled = True
        Me.cmbMacrocategoria.IntegralHeight = False
        Me.cmbMacrocategoria.Location = New System.Drawing.Point(186, 247)
        Me.cmbMacrocategoria.MaxDropDownItems = 15
        Me.cmbMacrocategoria.Name = "cmbMacrocategoria"
        Me.cmbMacrocategoria.Size = New System.Drawing.Size(270, 28)
        Me.cmbMacrocategoria.TabIndex = 60
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 253)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(154, 24)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Macrocategoria"
        '
        'cmbCategoria
        '
        Me.cmbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCategoria.DropDownHeight = 105
        Me.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.IntegralHeight = False
        Me.cmbCategoria.Location = New System.Drawing.Point(186, 286)
        Me.cmbCategoria.MaxDropDownItems = 15
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(270, 28)
        Me.cmbCategoria.TabIndex = 70
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(7, 330)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 24)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Categoria"
        '
        'cmbDifettoCritico
        '
        Me.cmbDifettoCritico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDifettoCritico.DropDownHeight = 105
        Me.cmbDifettoCritico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDifettoCritico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDifettoCritico.FormattingEnabled = True
        Me.cmbDifettoCritico.IntegralHeight = False
        Me.cmbDifettoCritico.Location = New System.Drawing.Point(186, 324)
        Me.cmbDifettoCritico.MaxDropDownItems = 15
        Me.cmbDifettoCritico.Name = "cmbDifettoCritico"
        Me.cmbDifettoCritico.Size = New System.Drawing.Size(270, 28)
        Me.cmbDifettoCritico.TabIndex = 80
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(7, 330)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 24)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "Difetto critico"
        '
        'cmbGravitaProblema
        '
        Me.cmbGravitaProblema.DropDownHeight = 105
        Me.cmbGravitaProblema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGravitaProblema.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGravitaProblema.FormattingEnabled = True
        Me.cmbGravitaProblema.IntegralHeight = False
        Me.cmbGravitaProblema.Location = New System.Drawing.Point(265, 365)
        Me.cmbGravitaProblema.MaxDropDownItems = 15
        Me.cmbGravitaProblema.Name = "cmbGravitaProblema"
        Me.cmbGravitaProblema.Size = New System.Drawing.Size(43, 28)
        Me.cmbGravitaProblema.TabIndex = 120
        Me.cmbGravitaProblema.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(2, 374)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(169, 24)
        Me.Label12.TabIndex = 62
        Me.Label12.Text = "Gravità Problema"
        '
        'txtGxF
        '
        Me.txtGxF.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGxF.Location = New System.Drawing.Point(166, 526)
        Me.txtGxF.Name = "txtGxF"
        Me.txtGxF.ReadOnly = True
        Me.txtGxF.Size = New System.Drawing.Size(270, 29)
        Me.txtGxF.TabIndex = 140
        Me.txtGxF.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(1, 529)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 24)
        Me.Label13.TabIndex = 64
        Me.Label13.Text = "Prodotto GxF"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(138, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(152, 24)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "Descrizione Nc"
        '
        'txtDescrizioneNC
        '
        Me.txtDescrizioneNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrizioneNC.Location = New System.Drawing.Point(49, 77)
        Me.txtDescrizioneNC.MaxLength = 255
        Me.txtDescrizioneNC.Multiline = True
        Me.txtDescrizioneNC.Name = "txtDescrizioneNC"
        Me.txtDescrizioneNC.Size = New System.Drawing.Size(481, 65)
        Me.txtDescrizioneNC.TabIndex = 190
        '
        'grpDatiGenerali
        '
        Me.grpDatiGenerali.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.grpDatiGenerali.Controls.Add(Me.lblDescrFreq)
        Me.grpDatiGenerali.Controls.Add(Me.lblGravita)
        Me.grpDatiGenerali.Controls.Add(Me.cmbIdFrequenza)
        Me.grpDatiGenerali.Controls.Add(Me.cmbFrequenzaProblema)
        Me.grpDatiGenerali.Controls.Add(Me.Label45)
        Me.grpDatiGenerali.Controls.Add(Me.cmbIdGravProblema)
        Me.grpDatiGenerali.Controls.Add(Me.cmbIdDifettoCritico)
        Me.grpDatiGenerali.Controls.Add(Me.cmbIdCat)
        Me.grpDatiGenerali.Controls.Add(Me.cmbIdMacroCat)
        Me.grpDatiGenerali.Controls.Add(Me.cmbIdOrigineAnomalia)
        Me.grpDatiGenerali.Controls.Add(Me.cmbIdAnomalia)
        Me.grpDatiGenerali.Controls.Add(Me.Label44)
        Me.grpDatiGenerali.Controls.Add(Me.dtpDataSegnalazione)
        Me.grpDatiGenerali.Controls.Add(Me.dtpDataApertura)
        Me.grpDatiGenerali.Controls.Add(Me.txtGxF)
        Me.grpDatiGenerali.Controls.Add(Me.Label2)
        Me.grpDatiGenerali.Controls.Add(Me.Label13)
        Me.grpDatiGenerali.Controls.Add(Me.Label3)
        Me.grpDatiGenerali.Controls.Add(Me.cmbGravitaProblema)
        Me.grpDatiGenerali.Controls.Add(Me.cmbTipoAnomalia)
        Me.grpDatiGenerali.Controls.Add(Me.Label12)
        Me.grpDatiGenerali.Controls.Add(Me.Label4)
        Me.grpDatiGenerali.Controls.Add(Me.cmbDifettoCritico)
        Me.grpDatiGenerali.Controls.Add(Me.cmbOrigineAnomalia)
        Me.grpDatiGenerali.Controls.Add(Me.Label11)
        Me.grpDatiGenerali.Controls.Add(Me.Label5)
        Me.grpDatiGenerali.Controls.Add(Me.cmbCategoria)
        Me.grpDatiGenerali.Controls.Add(Me.cmbClienteFinale)
        Me.grpDatiGenerali.Controls.Add(Me.Label10)
        Me.grpDatiGenerali.Controls.Add(Me.Label6)
        Me.grpDatiGenerali.Controls.Add(Me.cmbMacrocategoria)
        Me.grpDatiGenerali.Controls.Add(Me.Label9)
        Me.grpDatiGenerali.Enabled = False
        Me.grpDatiGenerali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpDatiGenerali.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDatiGenerali.ForeColor = System.Drawing.Color.Red
        Me.grpDatiGenerali.Location = New System.Drawing.Point(20, 117)
        Me.grpDatiGenerali.Name = "grpDatiGenerali"
        Me.grpDatiGenerali.Size = New System.Drawing.Size(471, 593)
        Me.grpDatiGenerali.TabIndex = 68
        Me.grpDatiGenerali.TabStop = False
        Me.grpDatiGenerali.Text = "Dati Generali"
        Me.grpDatiGenerali.Visible = False
        '
        'lblDescrFreq
        '
        Me.lblDescrFreq.AutoSize = True
        Me.lblDescrFreq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrFreq.ForeColor = System.Drawing.Color.Black
        Me.lblDescrFreq.Location = New System.Drawing.Point(3, 478)
        Me.lblDescrFreq.Name = "lblDescrFreq"
        Me.lblDescrFreq.Size = New System.Drawing.Size(133, 13)
        Me.lblDescrFreq.TabIndex = 80
        Me.lblDescrFreq.Text = "Descrizione frequenza"
        Me.lblDescrFreq.Visible = False
        '
        'lblGravita
        '
        Me.lblGravita.AutoSize = True
        Me.lblGravita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGravita.ForeColor = System.Drawing.Color.Black
        Me.lblGravita.Location = New System.Drawing.Point(7, 403)
        Me.lblGravita.Name = "lblGravita"
        Me.lblGravita.Size = New System.Drawing.Size(116, 13)
        Me.lblGravita.TabIndex = 79
        Me.lblGravita.Text = "Descrizione gravità"
        Me.lblGravita.Visible = False
        '
        'cmbIdFrequenza
        '
        Me.cmbIdFrequenza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdFrequenza.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdFrequenza.FormattingEnabled = True
        Me.cmbIdFrequenza.Location = New System.Drawing.Point(209, 445)
        Me.cmbIdFrequenza.Name = "cmbIdFrequenza"
        Me.cmbIdFrequenza.Size = New System.Drawing.Size(50, 32)
        Me.cmbIdFrequenza.TabIndex = 110
        '
        'cmbFrequenzaProblema
        '
        Me.cmbFrequenzaProblema.DropDownHeight = 105
        Me.cmbFrequenzaProblema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFrequenzaProblema.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFrequenzaProblema.FormattingEnabled = True
        Me.cmbFrequenzaProblema.IntegralHeight = False
        Me.cmbFrequenzaProblema.Location = New System.Drawing.Point(265, 445)
        Me.cmbFrequenzaProblema.MaxDropDownItems = 15
        Me.cmbFrequenzaProblema.Name = "cmbFrequenzaProblema"
        Me.cmbFrequenzaProblema.Size = New System.Drawing.Size(43, 28)
        Me.cmbFrequenzaProblema.TabIndex = 130
        Me.cmbFrequenzaProblema.Visible = False
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(1, 453)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(206, 24)
        Me.Label45.TabIndex = 76
        Me.Label45.Text = "Frequenza Problema"
        '
        'cmbIdGravProblema
        '
        Me.cmbIdGravProblema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdGravProblema.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdGravProblema.FormattingEnabled = True
        Me.cmbIdGravProblema.Location = New System.Drawing.Point(209, 366)
        Me.cmbIdGravProblema.Name = "cmbIdGravProblema"
        Me.cmbIdGravProblema.Size = New System.Drawing.Size(50, 32)
        Me.cmbIdGravProblema.TabIndex = 100
        '
        'cmbIdDifettoCritico
        '
        Me.cmbIdDifettoCritico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdDifettoCritico.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdDifettoCritico.FormattingEnabled = True
        Me.cmbIdDifettoCritico.Location = New System.Drawing.Point(120, 330)
        Me.cmbIdDifettoCritico.Name = "cmbIdDifettoCritico"
        Me.cmbIdDifettoCritico.Size = New System.Drawing.Size(55, 32)
        Me.cmbIdDifettoCritico.TabIndex = 74
        Me.cmbIdDifettoCritico.Visible = False
        '
        'cmbIdCat
        '
        Me.cmbIdCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdCat.FormattingEnabled = True
        Me.cmbIdCat.Location = New System.Drawing.Point(120, 291)
        Me.cmbIdCat.Name = "cmbIdCat"
        Me.cmbIdCat.Size = New System.Drawing.Size(55, 32)
        Me.cmbIdCat.TabIndex = 73
        Me.cmbIdCat.Visible = False
        '
        'cmbIdMacroCat
        '
        Me.cmbIdMacroCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdMacroCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdMacroCat.FormattingEnabled = True
        Me.cmbIdMacroCat.Location = New System.Drawing.Point(146, 250)
        Me.cmbIdMacroCat.Name = "cmbIdMacroCat"
        Me.cmbIdMacroCat.Size = New System.Drawing.Size(27, 32)
        Me.cmbIdMacroCat.TabIndex = 72
        Me.cmbIdMacroCat.Visible = False
        '
        'cmbIdOrigineAnomalia
        '
        Me.cmbIdOrigineAnomalia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdOrigineAnomalia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdOrigineAnomalia.FormattingEnabled = True
        Me.cmbIdOrigineAnomalia.Location = New System.Drawing.Point(146, 169)
        Me.cmbIdOrigineAnomalia.Name = "cmbIdOrigineAnomalia"
        Me.cmbIdOrigineAnomalia.Size = New System.Drawing.Size(27, 32)
        Me.cmbIdOrigineAnomalia.TabIndex = 70
        Me.cmbIdOrigineAnomalia.Visible = False
        '
        'cmbIdAnomalia
        '
        Me.cmbIdAnomalia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdAnomalia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdAnomalia.FormattingEnabled = True
        Me.cmbIdAnomalia.Location = New System.Drawing.Point(146, 131)
        Me.cmbIdAnomalia.Name = "cmbIdAnomalia"
        Me.cmbIdAnomalia.Size = New System.Drawing.Size(27, 32)
        Me.cmbIdAnomalia.TabIndex = 69
        Me.cmbIdAnomalia.Visible = False
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(8, 291)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(99, 24)
        Me.Label44.TabIndex = 68
        Me.Label44.Text = "Categoria"
        '
        'GrpDatiProduzione
        '
        Me.GrpDatiProduzione.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GrpDatiProduzione.Controls.Add(Me.cmbPezzatura)
        Me.GrpDatiProduzione.Controls.Add(Me.cmbCodiceArticolo)
        Me.GrpDatiProduzione.Controls.Add(Me.cmbCodiceProduzione)
        Me.GrpDatiProduzione.Controls.Add(Me.cmbNumeroLotto)
        Me.GrpDatiProduzione.Controls.Add(Me.Label8)
        Me.GrpDatiProduzione.Controls.Add(Me.Label7)
        Me.GrpDatiProduzione.Controls.Add(Me.txtAddetto)
        Me.GrpDatiProduzione.Controls.Add(Me.Label23)
        Me.GrpDatiProduzione.Controls.Add(Me.Label22)
        Me.GrpDatiProduzione.Controls.Add(Me.Label21)
        Me.GrpDatiProduzione.Controls.Add(Me.Label14)
        Me.GrpDatiProduzione.Controls.Add(Me.cmbRespEstrusione)
        Me.GrpDatiProduzione.Controls.Add(Me.Label15)
        Me.GrpDatiProduzione.Controls.Add(Me.cmbRespTermo)
        Me.GrpDatiProduzione.Controls.Add(Me.Label20)
        Me.GrpDatiProduzione.Controls.Add(Me.cmbCapoturno)
        Me.GrpDatiProduzione.Enabled = False
        Me.GrpDatiProduzione.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpDatiProduzione.ForeColor = System.Drawing.Color.Red
        Me.GrpDatiProduzione.Location = New System.Drawing.Point(613, 117)
        Me.GrpDatiProduzione.Name = "GrpDatiProduzione"
        Me.GrpDatiProduzione.Size = New System.Drawing.Size(551, 374)
        Me.GrpDatiProduzione.TabIndex = 69
        Me.GrpDatiProduzione.TabStop = False
        Me.GrpDatiProduzione.Text = "Dati Produzione"
        Me.GrpDatiProduzione.Visible = False
        '
        'cmbPezzatura
        '
        Me.cmbPezzatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbPezzatura.Enabled = False
        Me.cmbPezzatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPezzatura.FormattingEnabled = True
        Me.cmbPezzatura.Location = New System.Drawing.Point(260, 246)
        Me.cmbPezzatura.Name = "cmbPezzatura"
        Me.cmbPezzatura.Size = New System.Drawing.Size(270, 32)
        Me.cmbPezzatura.TabIndex = 0
        Me.cmbPezzatura.TabStop = False
        '
        'cmbCodiceArticolo
        '
        Me.cmbCodiceArticolo.DropDownHeight = 90
        Me.cmbCodiceArticolo.DropDownWidth = 270
        Me.cmbCodiceArticolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCodiceArticolo.FormattingEnabled = True
        Me.cmbCodiceArticolo.IntegralHeight = False
        Me.cmbCodiceArticolo.Location = New System.Drawing.Point(260, 210)
        Me.cmbCodiceArticolo.Name = "cmbCodiceArticolo"
        Me.cmbCodiceArticolo.Size = New System.Drawing.Size(270, 32)
        Me.cmbCodiceArticolo.TabIndex = 160
        '
        'btnProcedi
        '
        Me.btnProcedi.BackColor = System.Drawing.Color.Transparent
        Me.btnProcedi.BackgroundImage = Global.RegistroNcEsperia.My.Resources.Resources._next
        Me.btnProcedi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnProcedi.Enabled = False
        Me.btnProcedi.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcedi.Location = New System.Drawing.Point(552, 1)
        Me.btnProcedi.Name = "btnProcedi"
        Me.btnProcedi.Size = New System.Drawing.Size(87, 87)
        Me.btnProcedi.TabIndex = 30
        Me.btnProcedi.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnProcedi, "Avanti")
        Me.btnProcedi.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.Transparent
        Me.btnNew.BackgroundImage = CType(resources.GetObject("btnNew.BackgroundImage"), System.Drawing.Image)
        Me.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Location = New System.Drawing.Point(31, 6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(86, 85)
        Me.btnNew.TabIndex = 10
        Me.btnNew.TabStop = False
        Me.ToolTip1.SetToolTip(Me.btnNew, "Nuova non conformità")
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'cmbNumeroProgressivo
        '
        Me.cmbNumeroProgressivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbNumeroProgressivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbNumeroProgressivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNumeroProgressivo.FormattingEnabled = True
        Me.cmbNumeroProgressivo.Location = New System.Drawing.Point(276, 28)
        Me.cmbNumeroProgressivo.Name = "cmbNumeroProgressivo"
        Me.cmbNumeroProgressivo.Size = New System.Drawing.Size(270, 32)
        Me.cmbNumeroProgressivo.TabIndex = 1
        '
        'grpDescrNC
        '
        Me.grpDescrNC.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.grpDescrNC.Controls.Add(Me.cmbIdGestioneMateriali)
        Me.grpDescrNC.Controls.Add(Me.cmbGestioneMateriale)
        Me.grpDescrNC.Controls.Add(Me.Label51)
        Me.grpDescrNC.Controls.Add(Me.txtDescrizioneNC)
        Me.grpDescrNC.Controls.Add(Me.Label16)
        Me.grpDescrNC.Enabled = False
        Me.grpDescrNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDescrNC.ForeColor = System.Drawing.Color.Red
        Me.grpDescrNC.Location = New System.Drawing.Point(613, 497)
        Me.grpDescrNC.Name = "grpDescrNC"
        Me.grpDescrNC.Size = New System.Drawing.Size(551, 221)
        Me.grpDescrNC.TabIndex = 72
        Me.grpDescrNC.TabStop = False
        Me.grpDescrNC.Text = "Info rapide non conformità"
        Me.grpDescrNC.Visible = False
        '
        'cmbIdGestioneMateriali
        '
        Me.cmbIdGestioneMateriali.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdGestioneMateriali.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIdGestioneMateriali.FormattingEnabled = True
        Me.cmbIdGestioneMateriali.Location = New System.Drawing.Point(16, 181)
        Me.cmbIdGestioneMateriali.Name = "cmbIdGestioneMateriali"
        Me.cmbIdGestioneMateriali.Size = New System.Drawing.Size(27, 32)
        Me.cmbIdGestioneMateriali.TabIndex = 83
        Me.cmbIdGestioneMateriali.Visible = False
        '
        'cmbGestioneMateriale
        '
        Me.cmbGestioneMateriale.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbGestioneMateriale.DropDownHeight = 105
        Me.cmbGestioneMateriale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGestioneMateriale.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGestioneMateriale.FormattingEnabled = True
        Me.cmbGestioneMateriale.IntegralHeight = False
        Me.cmbGestioneMateriale.Location = New System.Drawing.Point(49, 181)
        Me.cmbGestioneMateriale.MaxDropDownItems = 15
        Me.cmbGestioneMateriale.Name = "cmbGestioneMateriale"
        Me.cmbGestioneMateriale.Size = New System.Drawing.Size(481, 32)
        Me.cmbGestioneMateriale.TabIndex = 200
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Black
        Me.Label51.Location = New System.Drawing.Point(123, 154)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(231, 24)
        Me.Label51.TabIndex = 82
        Me.Label51.Text = "Gestione materiale N.C."
        '
        'prgBar_loadingData
        '
        Me.prgBar_loadingData.Location = New System.Drawing.Point(3, 12)
        Me.prgBar_loadingData.Name = "prgBar_loadingData"
        Me.prgBar_loadingData.Size = New System.Drawing.Size(678, 49)
        Me.prgBar_loadingData.TabIndex = 73
        '
        'pnlBottoni
        '
        Me.pnlBottoni.Controls.Add(Me.cmbNumeroProgressivo)
        Me.pnlBottoni.Controls.Add(Me.btnNew)
        Me.pnlBottoni.Controls.Add(Me.btnProcedi)
        Me.pnlBottoni.Controls.Add(Me.Label1)
        Me.pnlBottoni.Location = New System.Drawing.Point(264, 23)
        Me.pnlBottoni.Name = "pnlBottoni"
        Me.pnlBottoni.Size = New System.Drawing.Size(665, 98)
        Me.pnlBottoni.TabIndex = 74
        Me.pnlBottoni.Visible = False
        '
        'logoEsp
        '
        Me.logoEsp.BackgroundImage = Global.RegistroNcEsperia.My.Resources.Resources.logoEsperia
        Me.logoEsp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logoEsp.InitialImage = Global.RegistroNcEsperia.My.Resources.Resources.logoEsperia
        Me.logoEsp.Location = New System.Drawing.Point(11, 22)
        Me.logoEsp.Name = "logoEsp"
        Me.logoEsp.Size = New System.Drawing.Size(268, 98)
        Me.logoEsp.TabIndex = 75
        Me.logoEsp.TabStop = False
        Me.logoEsp.Visible = False
        Me.logoEsp.WaitOnLoad = True
        '
        'logoEsp2
        '
        Me.logoEsp2.BackgroundImage = Global.RegistroNcEsperia.My.Resources.Resources.logoEsperia
        Me.logoEsp2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logoEsp2.InitialImage = Global.RegistroNcEsperia.My.Resources.Resources.logoEsperia
        Me.logoEsp2.Location = New System.Drawing.Point(918, 23)
        Me.logoEsp2.Name = "logoEsp2"
        Me.logoEsp2.Size = New System.Drawing.Size(268, 98)
        Me.logoEsp2.TabIndex = 76
        Me.logoEsp2.TabStop = False
        Me.logoEsp2.Visible = False
        Me.logoEsp2.WaitOnLoad = True
        '
        'menu1
        '
        Me.menu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.menu1.Location = New System.Drawing.Point(0, 0)
        Me.menu1.Name = "menu1"
        Me.menu1.Size = New System.Drawing.Size(1198, 24)
        Me.menu1.TabIndex = 77
        Me.menu1.Text = "MenuStrip1"
        Me.menu1.Visible = False
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaFornitoriToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ListaFornitoriToolStripMenuItem
        '
        Me.ListaFornitoriToolStripMenuItem.Name = "ListaFornitoriToolStripMenuItem"
        Me.ListaFornitoriToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListaFornitoriToolStripMenuItem.Text = "Lista Fornitori"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1198, 730)
        Me.Controls.Add(Me.logoEsp2)
        Me.Controls.Add(Me.prgBar_loadingData)
        Me.Controls.Add(Me.logoEsp)
        Me.Controls.Add(Me.pnlBottoni)
        Me.Controls.Add(Me.grpDescrNC)
        Me.Controls.Add(Me.GrpDatiProduzione)
        Me.Controls.Add(Me.grpDatiGenerali)
        Me.Controls.Add(Me.menu1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menu1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1214, 769)
        Me.MinimumSize = New System.Drawing.Size(120, 39)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione Non Conformità"
        Me.grpDatiGenerali.ResumeLayout(False)
        Me.grpDatiGenerali.PerformLayout()
        Me.GrpDatiProduzione.ResumeLayout(False)
        Me.GrpDatiProduzione.PerformLayout()
        Me.grpDescrNC.ResumeLayout(False)
        Me.grpDescrNC.PerformLayout()
        Me.pnlBottoni.ResumeLayout(False)
        Me.pnlBottoni.PerformLayout()
        CType(Me.logoEsp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoEsp2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menu1.ResumeLayout(False)
        Me.menu1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDataSegnalazione As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDataApertura As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoAnomalia As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbOrigineAnomalia As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbClienteFinale As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbRespEstrusione As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbRespTermo As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmbCapoturno As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtAddetto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbCodiceProduzione As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNumeroLotto As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMacrocategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbDifettoCritico As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbGravitaProblema As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtGxF As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDescrizioneNC As System.Windows.Forms.TextBox
    Friend WithEvents grpDatiGenerali As System.Windows.Forms.GroupBox
    Friend WithEvents GrpDatiProduzione As System.Windows.Forms.GroupBox
    Friend WithEvents btnProcedi As System.Windows.Forms.Button
    Friend WithEvents cmbCodiceArticolo As System.Windows.Forms.ComboBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents cmbIdAnomalia As System.Windows.Forms.ComboBox
    Friend WithEvents cmbIdOrigineAnomalia As System.Windows.Forms.ComboBox
    Friend WithEvents cmbIdMacroCat As System.Windows.Forms.ComboBox
    Friend WithEvents cmbIdCat As System.Windows.Forms.ComboBox
    Friend WithEvents cmbIdDifettoCritico As System.Windows.Forms.ComboBox
    Friend WithEvents cmbIdGravProblema As System.Windows.Forms.ComboBox
    Friend WithEvents cmbIdFrequenza As System.Windows.Forms.ComboBox
    Friend WithEvents cmbFrequenzaProblema As System.Windows.Forms.ComboBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents cmbPezzatura As System.Windows.Forms.ComboBox
    Friend WithEvents lblDescrFreq As System.Windows.Forms.Label
    Friend WithEvents lblGravita As System.Windows.Forms.Label
    Friend WithEvents cmbNumeroProgressivo As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents grpDescrNC As System.Windows.Forms.GroupBox
    Friend WithEvents cmbIdGestioneMateriali As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGestioneMateriale As System.Windows.Forms.ComboBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents prgBar_loadingData As System.Windows.Forms.ProgressBar
    Friend WithEvents pnlBottoni As System.Windows.Forms.Panel
    Friend WithEvents logoEsp As System.Windows.Forms.PictureBox
    Friend WithEvents logoEsp2 As System.Windows.Forms.PictureBox
    Friend WithEvents menu1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaFornitoriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
