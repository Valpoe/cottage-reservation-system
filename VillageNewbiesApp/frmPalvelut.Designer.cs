namespace VillageNewbiesApp
{
    partial class frmPalvelut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlue = new System.Windows.Forms.Label();
            this.lblAlueID = new System.Windows.Forms.Label();
            this.lblMokki = new System.Windows.Forms.Label();
            this.btnTyhjenna = new MaterialSkin.Controls.MaterialButton();
            this.btnLisaaMokki = new MaterialSkin.Controls.MaterialButton();
            this.pnlPalvelut = new System.Windows.Forms.Panel();
            this.pnlPalvelu = new System.Windows.Forms.Panel();
            this.btnPoistapalvelu = new MaterialSkin.Controls.MaterialButton();
            this.lblPalvelulisa = new MaterialSkin.Controls.MaterialLabel();
            this.btnLisaapalvelu = new MaterialSkin.Controls.MaterialButton();
            this.tbAlv = new MaterialSkin.Controls.MaterialTextBox();
            this.tbPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.tbKuvaus = new MaterialSkin.Controls.MaterialTextBox();
            this.tbTyyppi = new MaterialSkin.Controls.MaterialTextBox();
            this.tbNimi = new MaterialSkin.Controls.MaterialTextBox();
            this.mclbPalvelut = new MaterialSkin.Controls.MaterialCheckedListBox();
            this.pnlLisaaMokki = new System.Windows.Forms.Panel();
            this.tbToimipaikka = new MaterialSkin.Controls.MaterialTextBox();
            this.pnlPoistaMokki = new System.Windows.Forms.Panel();
            this.mlvPoistaMokki = new MaterialSkin.Controls.MaterialListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPoistaValitut = new MaterialSkin.Controls.MaterialButton();
            this.lblMokkiPoisto = new System.Windows.Forms.Label();
            this.lblKuvaus = new System.Windows.Forms.Label();
            this.lblVarustelu = new System.Windows.Forms.Label();
            this.msHenkilomaara = new MaterialSkin.Controls.MaterialSlider();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnMokinLisays = new MaterialSkin.Controls.MaterialButton();
            this.lblMokkitiedot = new System.Windows.Forms.Label();
            this.mcbToimintaAlue = new MaterialSkin.Controls.MaterialComboBox();
            this.mltbKuvaus = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.mltbVarustelu = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.tbPostinumero = new MaterialSkin.Controls.MaterialTextBox();
            this.tbHinta = new MaterialSkin.Controls.MaterialTextBox();
            this.tbOsoite = new MaterialSkin.Controls.MaterialTextBox();
            this.tbMokkinimi = new MaterialSkin.Controls.MaterialTextBox();
            this.tbHenkilomaara = new MaterialSkin.Controls.MaterialTextBox();
            this.btnPoistaMokki = new MaterialSkin.Controls.MaterialButton();
            this.btnPalvelut = new MaterialSkin.Controls.MaterialButton();
            this.mlvPalvelut = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlPalvelut.SuspendLayout();
            this.pnlPalvelu.SuspendLayout();
            this.pnlLisaaMokki.SuspendLayout();
            this.pnlPoistaMokki.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PALVELUT";
            // 
            // lblAlue
            // 
            this.lblAlue.AutoSize = true;
            this.lblAlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAlue.Location = new System.Drawing.Point(14, 7);
            this.lblAlue.Name = "lblAlue";
            this.lblAlue.Size = new System.Drawing.Size(86, 20);
            this.lblAlue.TabIndex = 4;
            this.lblAlue.Text = "ValittuAlue";
            this.lblAlue.TextChanged += new System.EventHandler(this.lblAlue_TextChanged);
            this.lblAlue.VisibleChanged += new System.EventHandler(this.lblAlue_VisibleChanged);
            // 
            // lblAlueID
            // 
            this.lblAlueID.AutoSize = true;
            this.lblAlueID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAlueID.Location = new System.Drawing.Point(106, 9);
            this.lblAlueID.Name = "lblAlueID";
            this.lblAlueID.Size = new System.Drawing.Size(39, 13);
            this.lblAlueID.TabIndex = 5;
            this.lblAlueID.Text = "AlueID";
            // 
            // lblMokki
            // 
            this.lblMokki.AutoSize = true;
            this.lblMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMokki.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMokki.Location = new System.Drawing.Point(180, 7);
            this.lblMokki.Name = "lblMokki";
            this.lblMokki.Size = new System.Drawing.Size(164, 31);
            this.lblMokki.TabIndex = 6;
            this.lblMokki.Text = "valittu mokki";
            this.lblMokki.VisibleChanged += new System.EventHandler(this.lblMokki_VisibleChanged);
            this.lblMokki.Click += new System.EventHandler(this.lblMokki_Click);
            // 
            // btnTyhjenna
            // 
            this.btnTyhjenna.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTyhjenna.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTyhjenna.Depth = 0;
            this.btnTyhjenna.HighEmphasis = true;
            this.btnTyhjenna.Icon = null;
            this.btnTyhjenna.Location = new System.Drawing.Point(15, 352);
            this.btnTyhjenna.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTyhjenna.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTyhjenna.Name = "btnTyhjenna";
            this.btnTyhjenna.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTyhjenna.Size = new System.Drawing.Size(172, 36);
            this.btnTyhjenna.TabIndex = 8;
            this.btnTyhjenna.Text = "Tyhjennä valinnat";
            this.btnTyhjenna.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTyhjenna.UseAccentColor = false;
            this.btnTyhjenna.UseVisualStyleBackColor = true;
            this.btnTyhjenna.Click += new System.EventHandler(this.btnTyhjenna_Click);
            // 
            // btnLisaaMokki
            // 
            this.btnLisaaMokki.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLisaaMokki.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLisaaMokki.Depth = 0;
            this.btnLisaaMokki.HighEmphasis = true;
            this.btnLisaaMokki.Icon = null;
            this.btnLisaaMokki.Location = new System.Drawing.Point(26, 40);
            this.btnLisaaMokki.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLisaaMokki.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLisaaMokki.Name = "btnLisaaMokki";
            this.btnLisaaMokki.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLisaaMokki.Size = new System.Drawing.Size(111, 36);
            this.btnLisaaMokki.TabIndex = 10;
            this.btnLisaaMokki.Text = "Lisää mökki";
            this.btnLisaaMokki.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLisaaMokki.UseAccentColor = false;
            this.btnLisaaMokki.UseVisualStyleBackColor = true;
            this.btnLisaaMokki.Click += new System.EventHandler(this.btnLisaaMokki_Click);
            // 
            // pnlPalvelut
            // 
            this.pnlPalvelut.Controls.Add(this.lblMokki);
            this.pnlPalvelut.Controls.Add(this.mclbPalvelut);
            this.pnlPalvelut.Controls.Add(this.lblAlue);
            this.pnlPalvelut.Controls.Add(this.lblAlueID);
            this.pnlPalvelut.Location = new System.Drawing.Point(282, 40);
            this.pnlPalvelut.Name = "pnlPalvelut";
            this.pnlPalvelut.Size = new System.Drawing.Size(713, 551);
            this.pnlPalvelut.TabIndex = 11;
            this.pnlPalvelut.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlPalvelu
            // 
            this.pnlPalvelu.Controls.Add(this.mlvPalvelut);
            this.pnlPalvelu.Controls.Add(this.btnPoistapalvelu);
            this.pnlPalvelu.Controls.Add(this.lblPalvelulisa);
            this.pnlPalvelu.Controls.Add(this.btnLisaapalvelu);
            this.pnlPalvelu.Controls.Add(this.tbAlv);
            this.pnlPalvelu.Controls.Add(this.tbPrice);
            this.pnlPalvelu.Controls.Add(this.tbKuvaus);
            this.pnlPalvelu.Controls.Add(this.tbTyyppi);
            this.pnlPalvelu.Controls.Add(this.tbNimi);
            this.pnlPalvelu.Location = new System.Drawing.Point(282, 40);
            this.pnlPalvelu.Name = "pnlPalvelu";
            this.pnlPalvelu.Size = new System.Drawing.Size(713, 551);
            this.pnlPalvelu.TabIndex = 16;
            // 
            // btnPoistapalvelu
            // 
            this.btnPoistapalvelu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPoistapalvelu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPoistapalvelu.Depth = 0;
            this.btnPoistapalvelu.HighEmphasis = true;
            this.btnPoistapalvelu.Icon = null;
            this.btnPoistapalvelu.Location = new System.Drawing.Point(144, 361);
            this.btnPoistapalvelu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPoistapalvelu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPoistapalvelu.Name = "btnPoistapalvelu";
            this.btnPoistapalvelu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPoistapalvelu.Size = new System.Drawing.Size(139, 36);
            this.btnPoistapalvelu.TabIndex = 8;
            this.btnPoistapalvelu.Text = "Poista palvelu";
            this.btnPoistapalvelu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPoistapalvelu.UseAccentColor = false;
            this.btnPoistapalvelu.UseVisualStyleBackColor = true;
            this.btnPoistapalvelu.Click += new System.EventHandler(this.btnPoistapalvelu_Click);
            // 
            // lblPalvelulisa
            // 
            this.lblPalvelulisa.AutoSize = true;
            this.lblPalvelulisa.Depth = 0;
            this.lblPalvelulisa.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPalvelulisa.Location = new System.Drawing.Point(23, 30);
            this.lblPalvelulisa.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPalvelulisa.Name = "lblPalvelulisa";
            this.lblPalvelulisa.Size = new System.Drawing.Size(95, 19);
            this.lblPalvelulisa.TabIndex = 6;
            this.lblPalvelulisa.Text = "Lisää palvelu";
            // 
            // btnLisaapalvelu
            // 
            this.btnLisaapalvelu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLisaapalvelu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLisaapalvelu.Depth = 0;
            this.btnLisaapalvelu.HighEmphasis = true;
            this.btnLisaapalvelu.Icon = null;
            this.btnLisaapalvelu.Location = new System.Drawing.Point(11, 361);
            this.btnLisaapalvelu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLisaapalvelu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLisaapalvelu.Name = "btnLisaapalvelu";
            this.btnLisaapalvelu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLisaapalvelu.Size = new System.Drawing.Size(128, 36);
            this.btnLisaapalvelu.TabIndex = 5;
            this.btnLisaapalvelu.Text = "Lisää palvelu";
            this.btnLisaapalvelu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLisaapalvelu.UseAccentColor = false;
            this.btnLisaapalvelu.UseVisualStyleBackColor = true;
            this.btnLisaapalvelu.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // tbAlv
            // 
            this.tbAlv.AnimateReadOnly = false;
            this.tbAlv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAlv.Depth = 0;
            this.tbAlv.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAlv.Hint = "Alv";
            this.tbAlv.LeadingIcon = null;
            this.tbAlv.Location = new System.Drawing.Point(13, 302);
            this.tbAlv.MaxLength = 50;
            this.tbAlv.MouseState = MaterialSkin.MouseState.OUT;
            this.tbAlv.Multiline = false;
            this.tbAlv.Name = "tbAlv";
            this.tbAlv.Size = new System.Drawing.Size(105, 50);
            this.tbAlv.TabIndex = 4;
            this.tbAlv.Text = "";
            this.tbAlv.TrailingIcon = null;
            // 
            // tbPrice
            // 
            this.tbPrice.AnimateReadOnly = false;
            this.tbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrice.Depth = 0;
            this.tbPrice.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPrice.Hint = "Hinta";
            this.tbPrice.LeadingIcon = null;
            this.tbPrice.Location = new System.Drawing.Point(13, 246);
            this.tbPrice.MaxLength = 50;
            this.tbPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPrice.Multiline = false;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(105, 50);
            this.tbPrice.TabIndex = 3;
            this.tbPrice.Text = "";
            this.tbPrice.TrailingIcon = null;
            // 
            // tbKuvaus
            // 
            this.tbKuvaus.AnimateReadOnly = false;
            this.tbKuvaus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKuvaus.Depth = 0;
            this.tbKuvaus.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbKuvaus.Hint = "Kuvaus";
            this.tbKuvaus.LeadingIcon = null;
            this.tbKuvaus.Location = new System.Drawing.Point(16, 190);
            this.tbKuvaus.MaxLength = 50;
            this.tbKuvaus.MouseState = MaterialSkin.MouseState.OUT;
            this.tbKuvaus.Multiline = false;
            this.tbKuvaus.Name = "tbKuvaus";
            this.tbKuvaus.Size = new System.Drawing.Size(102, 50);
            this.tbKuvaus.TabIndex = 2;
            this.tbKuvaus.Text = "";
            this.tbKuvaus.TrailingIcon = null;
            // 
            // tbTyyppi
            // 
            this.tbTyyppi.AnimateReadOnly = false;
            this.tbTyyppi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTyyppi.Depth = 0;
            this.tbTyyppi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbTyyppi.Hint = "Tyyppi";
            this.tbTyyppi.LeadingIcon = null;
            this.tbTyyppi.Location = new System.Drawing.Point(14, 134);
            this.tbTyyppi.MaxLength = 50;
            this.tbTyyppi.MouseState = MaterialSkin.MouseState.OUT;
            this.tbTyyppi.Multiline = false;
            this.tbTyyppi.Name = "tbTyyppi";
            this.tbTyyppi.Size = new System.Drawing.Size(104, 50);
            this.tbTyyppi.TabIndex = 1;
            this.tbTyyppi.Text = "";
            this.tbTyyppi.TrailingIcon = null;
            // 
            // tbNimi
            // 
            this.tbNimi.AnimateReadOnly = false;
            this.tbNimi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNimi.Depth = 0;
            this.tbNimi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbNimi.Hint = "Nimi";
            this.tbNimi.LeadingIcon = null;
            this.tbNimi.Location = new System.Drawing.Point(13, 84);
            this.tbNimi.MaxLength = 50;
            this.tbNimi.MouseState = MaterialSkin.MouseState.OUT;
            this.tbNimi.Multiline = false;
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(105, 50);
            this.tbNimi.TabIndex = 0;
            this.tbNimi.Text = "";
            this.tbNimi.TrailingIcon = null;
            // 
            // mclbPalvelut
            // 
            this.mclbPalvelut.AutoScroll = true;
            this.mclbPalvelut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.mclbPalvelut.Depth = 0;
            this.mclbPalvelut.Location = new System.Drawing.Point(29, 64);
            this.mclbPalvelut.MouseState = MaterialSkin.MouseState.HOVER;
            this.mclbPalvelut.Name = "mclbPalvelut";
            this.mclbPalvelut.Size = new System.Drawing.Size(459, 330);
            this.mclbPalvelut.Striped = false;
            this.mclbPalvelut.StripeDarkColor = System.Drawing.Color.Empty;
            this.mclbPalvelut.TabIndex = 7;
            // 
            // pnlLisaaMokki
            // 
            this.pnlLisaaMokki.Controls.Add(this.tbToimipaikka);
            this.pnlLisaaMokki.Controls.Add(this.lblKuvaus);
            this.pnlLisaaMokki.Controls.Add(this.lblVarustelu);
            this.pnlLisaaMokki.Controls.Add(this.msHenkilomaara);
            this.pnlLisaaMokki.Controls.Add(this.lblStatus);
            this.pnlLisaaMokki.Controls.Add(this.btnMokinLisays);
            this.pnlLisaaMokki.Controls.Add(this.lblMokkitiedot);
            this.pnlLisaaMokki.Controls.Add(this.mcbToimintaAlue);
            this.pnlLisaaMokki.Controls.Add(this.mltbKuvaus);
            this.pnlLisaaMokki.Controls.Add(this.mltbVarustelu);
            this.pnlLisaaMokki.Controls.Add(this.tbPostinumero);
            this.pnlLisaaMokki.Controls.Add(this.tbHinta);
            this.pnlLisaaMokki.Controls.Add(this.tbOsoite);
            this.pnlLisaaMokki.Controls.Add(this.tbMokkinimi);
            this.pnlLisaaMokki.Controls.Add(this.tbHenkilomaara);
            this.pnlLisaaMokki.Location = new System.Drawing.Point(282, 40);
            this.pnlLisaaMokki.Name = "pnlLisaaMokki";
            this.pnlLisaaMokki.Size = new System.Drawing.Size(713, 551);
            this.pnlLisaaMokki.TabIndex = 12;
            // 
            // tbToimipaikka
            // 
            this.tbToimipaikka.AnimateReadOnly = false;
            this.tbToimipaikka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbToimipaikka.Depth = 0;
            this.tbToimipaikka.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbToimipaikka.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.tbToimipaikka.Hint = "Toimipaikka";
            this.tbToimipaikka.LeadingIcon = null;
            this.tbToimipaikka.Location = new System.Drawing.Point(18, 259);
            this.tbToimipaikka.MaxLength = 5;
            this.tbToimipaikka.MouseState = MaterialSkin.MouseState.OUT;
            this.tbToimipaikka.Multiline = false;
            this.tbToimipaikka.Name = "tbToimipaikka";
            this.tbToimipaikka.Size = new System.Drawing.Size(180, 36);
            this.tbToimipaikka.TabIndex = 20;
            this.tbToimipaikka.Text = "";
            this.tbToimipaikka.TrailingIcon = null;
            this.tbToimipaikka.UseTallSize = false;
            // 
            // pnlPoistaMokki
            // 
            this.pnlPoistaMokki.Controls.Add(this.mlvPoistaMokki);
            this.pnlPoistaMokki.Controls.Add(this.btnPoistaValitut);
            this.pnlPoistaMokki.Controls.Add(this.lblMokkiPoisto);
            this.pnlPoistaMokki.Location = new System.Drawing.Point(282, 40);
            this.pnlPoistaMokki.Name = "pnlPoistaMokki";
            this.pnlPoistaMokki.Size = new System.Drawing.Size(713, 551);
            this.pnlPoistaMokki.TabIndex = 14;
            // 
            // mlvPoistaMokki
            // 
            this.mlvPoistaMokki.AutoSizeTable = false;
            this.mlvPoistaMokki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlvPoistaMokki.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvPoistaMokki.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.columnHeader2,
            this.columnHeader3});
            this.mlvPoistaMokki.Depth = 0;
            this.mlvPoistaMokki.FullRowSelect = true;
            this.mlvPoistaMokki.HideSelection = false;
            this.mlvPoistaMokki.Location = new System.Drawing.Point(12, 33);
            this.mlvPoistaMokki.MinimumSize = new System.Drawing.Size(200, 100);
            this.mlvPoistaMokki.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvPoistaMokki.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvPoistaMokki.Name = "mlvPoistaMokki";
            this.mlvPoistaMokki.OwnerDraw = true;
            this.mlvPoistaMokki.Size = new System.Drawing.Size(468, 295);
            this.mlvPoistaMokki.TabIndex = 16;
            this.mlvPoistaMokki.UseCompatibleStateImageBehavior = false;
            this.mlvPoistaMokki.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mokin nimi";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Osoite";
            this.columnHeader3.Width = 150;
            // 
            // btnPoistaValitut
            // 
            this.btnPoistaValitut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPoistaValitut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPoistaValitut.Depth = 0;
            this.btnPoistaValitut.HighEmphasis = true;
            this.btnPoistaValitut.Icon = null;
            this.btnPoistaValitut.Location = new System.Drawing.Point(18, 336);
            this.btnPoistaValitut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPoistaValitut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPoistaValitut.Name = "btnPoistaValitut";
            this.btnPoistaValitut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPoistaValitut.Size = new System.Drawing.Size(135, 36);
            this.btnPoistaValitut.TabIndex = 14;
            this.btnPoistaValitut.Text = "Poista valitut";
            this.btnPoistaValitut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPoistaValitut.UseAccentColor = false;
            this.btnPoistaValitut.UseVisualStyleBackColor = true;
            this.btnPoistaValitut.Click += new System.EventHandler(this.btnPoistaValitut_Click);
            // 
            // lblMokkiPoisto
            // 
            this.lblMokkiPoisto.AutoSize = true;
            this.lblMokkiPoisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMokkiPoisto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMokkiPoisto.Location = new System.Drawing.Point(8, 9);
            this.lblMokkiPoisto.Name = "lblMokkiPoisto";
            this.lblMokkiPoisto.Size = new System.Drawing.Size(98, 20);
            this.lblMokkiPoisto.TabIndex = 15;
            this.lblMokkiPoisto.Text = "Poista mökki";
            // 
            // lblKuvaus
            // 
            this.lblKuvaus.AutoSize = true;
            this.lblKuvaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKuvaus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKuvaus.Location = new System.Drawing.Point(240, 160);
            this.lblKuvaus.Name = "lblKuvaus";
            this.lblKuvaus.Size = new System.Drawing.Size(55, 16);
            this.lblKuvaus.TabIndex = 19;
            this.lblKuvaus.Text = "Kuvaus:";
            // 
            // lblVarustelu
            // 
            this.lblVarustelu.AutoSize = true;
            this.lblVarustelu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarustelu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblVarustelu.Location = new System.Drawing.Point(240, 52);
            this.lblVarustelu.Name = "lblVarustelu";
            this.lblVarustelu.Size = new System.Drawing.Size(67, 16);
            this.lblVarustelu.TabIndex = 18;
            this.lblVarustelu.Text = "Varustelu:";
            // 
            // msHenkilomaara
            // 
            this.msHenkilomaara.Depth = 0;
            this.msHenkilomaara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.msHenkilomaara.Location = new System.Drawing.Point(12, 301);
            this.msHenkilomaara.MouseState = MaterialSkin.MouseState.HOVER;
            this.msHenkilomaara.Name = "msHenkilomaara";
            this.msHenkilomaara.RangeMax = 25;
            this.msHenkilomaara.ShowValue = false;
            this.msHenkilomaara.Size = new System.Drawing.Size(180, 40);
            this.msHenkilomaara.TabIndex = 17;
            this.msHenkilomaara.Text = "";
            this.msHenkilomaara.Value = 0;
            this.msHenkilomaara.ValueMax = 25;
            this.msHenkilomaara.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.msHenkilomaara_onValueChanged);
            this.msHenkilomaara.Click += new System.EventHandler(this.msHenkilomaara_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Location = new System.Drawing.Point(315, 348);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 16;
            // 
            // btnMokinLisays
            // 
            this.btnMokinLisays.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMokinLisays.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMokinLisays.Depth = 0;
            this.btnMokinLisays.HighEmphasis = true;
            this.btnMokinLisays.Icon = null;
            this.btnMokinLisays.Location = new System.Drawing.Point(300, 306);
            this.btnMokinLisays.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMokinLisays.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMokinLisays.Name = "btnMokinLisays";
            this.btnMokinLisays.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMokinLisays.Size = new System.Drawing.Size(111, 36);
            this.btnMokinLisays.TabIndex = 15;
            this.btnMokinLisays.Text = "Lisää mökki";
            this.btnMokinLisays.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMokinLisays.UseAccentColor = false;
            this.btnMokinLisays.UseVisualStyleBackColor = true;
            this.btnMokinLisays.Click += new System.EventHandler(this.btnMokinLisays_Click);
            // 
            // lblMokkitiedot
            // 
            this.lblMokkitiedot.AutoSize = true;
            this.lblMokkitiedot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMokkitiedot.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMokkitiedot.Location = new System.Drawing.Point(14, 7);
            this.lblMokkitiedot.Name = "lblMokkitiedot";
            this.lblMokkitiedot.Size = new System.Drawing.Size(137, 20);
            this.lblMokkitiedot.TabIndex = 14;
            this.lblMokkitiedot.Text = "Lisää mökin tiedot";
            // 
            // mcbToimintaAlue
            // 
            this.mcbToimintaAlue.AutoResize = false;
            this.mcbToimintaAlue.BackColor = System.Drawing.Color.White;
            this.mcbToimintaAlue.Depth = 0;
            this.mcbToimintaAlue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mcbToimintaAlue.DropDownHeight = 174;
            this.mcbToimintaAlue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcbToimintaAlue.DropDownWidth = 121;
            this.mcbToimintaAlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mcbToimintaAlue.ForeColor = System.Drawing.Color.Black;
            this.mcbToimintaAlue.FormattingEnabled = true;
            this.mcbToimintaAlue.Hint = "Valitse alue";
            this.mcbToimintaAlue.IntegralHeight = false;
            this.mcbToimintaAlue.ItemHeight = 43;
            this.mcbToimintaAlue.Location = new System.Drawing.Point(12, 336);
            this.mcbToimintaAlue.MaxDropDownItems = 4;
            this.mcbToimintaAlue.MouseState = MaterialSkin.MouseState.OUT;
            this.mcbToimintaAlue.Name = "mcbToimintaAlue";
            this.mcbToimintaAlue.Size = new System.Drawing.Size(236, 49);
            this.mcbToimintaAlue.StartIndex = 0;
            this.mcbToimintaAlue.TabIndex = 13;
            this.mcbToimintaAlue.SelectedIndexChanged += new System.EventHandler(this.mcbToimintaAlue_SelectedIndexChanged);
            // 
            // mltbKuvaus
            // 
            this.mltbKuvaus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mltbKuvaus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mltbKuvaus.Depth = 0;
            this.mltbKuvaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mltbKuvaus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mltbKuvaus.Hint = "Varustelu";
            this.mltbKuvaus.Location = new System.Drawing.Point(243, 183);
            this.mltbKuvaus.MouseState = MaterialSkin.MouseState.HOVER;
            this.mltbKuvaus.Name = "mltbKuvaus";
            this.mltbKuvaus.Size = new System.Drawing.Size(227, 78);
            this.mltbKuvaus.TabIndex = 9;
            this.mltbKuvaus.Text = "";
            // 
            // mltbVarustelu
            // 
            this.mltbVarustelu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mltbVarustelu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mltbVarustelu.Depth = 0;
            this.mltbVarustelu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mltbVarustelu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mltbVarustelu.Hint = "Kuvaus";
            this.mltbVarustelu.Location = new System.Drawing.Point(243, 75);
            this.mltbVarustelu.MouseState = MaterialSkin.MouseState.HOVER;
            this.mltbVarustelu.Name = "mltbVarustelu";
            this.mltbVarustelu.Size = new System.Drawing.Size(227, 78);
            this.mltbVarustelu.TabIndex = 8;
            this.mltbVarustelu.Text = "";
            // 
            // tbPostinumero
            // 
            this.tbPostinumero.AnimateReadOnly = false;
            this.tbPostinumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPostinumero.Depth = 0;
            this.tbPostinumero.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPostinumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.tbPostinumero.Hint = "Postinumero";
            this.tbPostinumero.LeadingIcon = null;
            this.tbPostinumero.Location = new System.Drawing.Point(18, 175);
            this.tbPostinumero.MaxLength = 5;
            this.tbPostinumero.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPostinumero.Multiline = false;
            this.tbPostinumero.Name = "tbPostinumero";
            this.tbPostinumero.Size = new System.Drawing.Size(180, 36);
            this.tbPostinumero.TabIndex = 6;
            this.tbPostinumero.Text = "";
            this.tbPostinumero.TrailingIcon = null;
            this.tbPostinumero.UseTallSize = false;
            this.tbPostinumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPostinumero_KeyDown);
            this.tbPostinumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPostinumero_KeyPress);
            // 
            // tbHinta
            // 
            this.tbHinta.AnimateReadOnly = false;
            this.tbHinta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHinta.Depth = 0;
            this.tbHinta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbHinta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.tbHinta.Hint = "Hinta";
            this.tbHinta.LeadingIcon = null;
            this.tbHinta.Location = new System.Drawing.Point(18, 133);
            this.tbHinta.MaxLength = 50;
            this.tbHinta.MouseState = MaterialSkin.MouseState.OUT;
            this.tbHinta.Multiline = false;
            this.tbHinta.Name = "tbHinta";
            this.tbHinta.Size = new System.Drawing.Size(180, 36);
            this.tbHinta.TabIndex = 5;
            this.tbHinta.Text = "";
            this.tbHinta.TrailingIcon = null;
            this.tbHinta.UseTallSize = false;
            // 
            // tbOsoite
            // 
            this.tbOsoite.AnimateReadOnly = false;
            this.tbOsoite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOsoite.Depth = 0;
            this.tbOsoite.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbOsoite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.tbOsoite.Hint = "Osoite";
            this.tbOsoite.LeadingIcon = null;
            this.tbOsoite.Location = new System.Drawing.Point(18, 91);
            this.tbOsoite.MaxLength = 50;
            this.tbOsoite.MouseState = MaterialSkin.MouseState.OUT;
            this.tbOsoite.Multiline = false;
            this.tbOsoite.Name = "tbOsoite";
            this.tbOsoite.Size = new System.Drawing.Size(180, 36);
            this.tbOsoite.TabIndex = 4;
            this.tbOsoite.Text = "";
            this.tbOsoite.TrailingIcon = null;
            this.tbOsoite.UseTallSize = false;
            // 
            // tbMokkinimi
            // 
            this.tbMokkinimi.AnimateReadOnly = false;
            this.tbMokkinimi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMokkinimi.Depth = 0;
            this.tbMokkinimi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbMokkinimi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.tbMokkinimi.Hint = "Mökin nimi";
            this.tbMokkinimi.LeadingIcon = null;
            this.tbMokkinimi.Location = new System.Drawing.Point(18, 49);
            this.tbMokkinimi.MaxLength = 50;
            this.tbMokkinimi.MouseState = MaterialSkin.MouseState.OUT;
            this.tbMokkinimi.Multiline = false;
            this.tbMokkinimi.Name = "tbMokkinimi";
            this.tbMokkinimi.Size = new System.Drawing.Size(180, 36);
            this.tbMokkinimi.TabIndex = 3;
            this.tbMokkinimi.Text = "";
            this.tbMokkinimi.TrailingIcon = null;
            this.tbMokkinimi.UseTallSize = false;
            // 
            // tbHenkilomaara
            // 
            this.tbHenkilomaara.AnimateReadOnly = false;
            this.tbHenkilomaara.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHenkilomaara.Depth = 0;
            this.tbHenkilomaara.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbHenkilomaara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.tbHenkilomaara.Hint = "Henkilömäärä";
            this.tbHenkilomaara.LeadingIcon = null;
            this.tbHenkilomaara.Location = new System.Drawing.Point(18, 217);
            this.tbHenkilomaara.MaxLength = 50;
            this.tbHenkilomaara.MouseState = MaterialSkin.MouseState.OUT;
            this.tbHenkilomaara.Multiline = false;
            this.tbHenkilomaara.Name = "tbHenkilomaara";
            this.tbHenkilomaara.Size = new System.Drawing.Size(180, 36);
            this.tbHenkilomaara.TabIndex = 2;
            this.tbHenkilomaara.Text = "";
            this.tbHenkilomaara.TrailingIcon = null;
            this.tbHenkilomaara.UseTallSize = false;
            this.tbHenkilomaara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHenkilomaara_KeyPress);
            // 
            // btnPoistaMokki
            // 
            this.btnPoistaMokki.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPoistaMokki.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPoistaMokki.Depth = 0;
            this.btnPoistaMokki.HighEmphasis = true;
            this.btnPoistaMokki.Icon = null;
            this.btnPoistaMokki.Location = new System.Drawing.Point(26, 89);
            this.btnPoistaMokki.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPoistaMokki.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPoistaMokki.Name = "btnPoistaMokki";
            this.btnPoistaMokki.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPoistaMokki.Size = new System.Drawing.Size(122, 36);
            this.btnPoistaMokki.TabIndex = 13;
            this.btnPoistaMokki.Text = "Poista mökki";
            this.btnPoistaMokki.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPoistaMokki.UseAccentColor = false;
            this.btnPoistaMokki.UseVisualStyleBackColor = true;
            this.btnPoistaMokki.Click += new System.EventHandler(this.btnPoistaMokki_Click);
            // 
            // btnPalvelut
            // 
            this.btnPalvelut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPalvelut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPalvelut.Depth = 0;
            this.btnPalvelut.HighEmphasis = true;
            this.btnPalvelut.Icon = null;
            this.btnPalvelut.Location = new System.Drawing.Point(26, 137);
            this.btnPalvelut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPalvelut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPalvelut.Name = "btnPalvelut";
            this.btnPalvelut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPalvelut.Size = new System.Drawing.Size(209, 36);
            this.btnPalvelut.TabIndex = 15;
            this.btnPalvelut.Text = "Lisää tai poista palvelu";
            this.btnPalvelut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPalvelut.UseAccentColor = false;
            this.btnPalvelut.UseVisualStyleBackColor = true;
            this.btnPalvelut.Click += new System.EventHandler(this.btnPalvelut_Click);
            // 
            // mlvPalvelut
            // 
            this.mlvPalvelut.AutoSizeTable = false;
            this.mlvPalvelut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlvPalvelut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvPalvelut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader5});
            this.mlvPalvelut.Depth = 0;
            this.mlvPalvelut.FullRowSelect = true;
            this.mlvPalvelut.HideSelection = false;
            this.mlvPalvelut.Location = new System.Drawing.Point(124, 57);
            this.mlvPalvelut.MinimumSize = new System.Drawing.Size(200, 100);
            this.mlvPalvelut.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvPalvelut.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvPalvelut.Name = "mlvPalvelut";
            this.mlvPalvelut.OwnerDraw = true;
            this.mlvPalvelut.Size = new System.Drawing.Size(349, 294);
            this.mlvPalvelut.TabIndex = 9;
            this.mlvPalvelut.UseCompatibleStateImageBehavior = false;
            this.mlvPalvelut.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nimi";
            this.columnHeader4.Width = 130;
            // 
            // btnPoistaValitut
            // 
            this.btnPoistaValitut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPoistaValitut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPoistaValitut.Depth = 0;
            this.btnPoistaValitut.HighEmphasis = true;
            this.btnPoistaValitut.Icon = null;
            this.btnPoistaValitut.Location = new System.Drawing.Point(18, 336);
            this.btnPoistaValitut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPoistaValitut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPoistaValitut.Name = "btnPoistaValitut";
            this.btnPoistaValitut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPoistaValitut.Size = new System.Drawing.Size(135, 36);
            this.btnPoistaValitut.TabIndex = 14;
            this.btnPoistaValitut.Text = "Poista valitut";
            this.btnPoistaValitut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPoistaValitut.UseAccentColor = false;
            this.btnPoistaValitut.UseVisualStyleBackColor = true;
            this.btnPoistaValitut.Click += new System.EventHandler(this.btnPoistaValitut_Click);
            // 
            // lblMokkiPoisto
            // 
            this.lblMokkiPoisto.AutoSize = true;
            this.lblMokkiPoisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMokkiPoisto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMokkiPoisto.Location = new System.Drawing.Point(8, 9);
            this.lblMokkiPoisto.Name = "lblMokkiPoisto";
            this.lblMokkiPoisto.Size = new System.Drawing.Size(98, 20);
            this.lblMokkiPoisto.TabIndex = 15;
            this.lblMokkiPoisto.Text = "Poista mökki";
            // 
            // frmPalvelut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1045, 667);
            this.Controls.Add(this.pnlPalvelut);
            this.Controls.Add(this.pnlPalvelu);
            this.Controls.Add(this.pnlPoistaMokki);
            this.Controls.Add(this.btnPalvelut);
            this.Controls.Add(this.btnPoistaMokki);
            this.Controls.Add(this.pnlLisaaMokki);
            this.Controls.Add(this.btnLisaaMokki);
            this.Controls.Add(this.btnTyhjenna);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPalvelut";
            this.Text = "frmPalvelut";
            this.pnlPalvelut.ResumeLayout(false);
            this.pnlPalvelut.PerformLayout();
            this.pnlPalvelu.ResumeLayout(false);
            this.pnlPalvelu.PerformLayout();
            this.pnlLisaaMokki.ResumeLayout(false);
            this.pnlLisaaMokki.PerformLayout();
            this.pnlPoistaMokki.ResumeLayout(false);
            this.pnlPoistaMokki.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlue;
        private System.Windows.Forms.Label lblAlueID;
        private System.Windows.Forms.Label lblMokki;
        private MaterialSkin.Controls.MaterialButton btnTyhjenna;
        private MaterialSkin.Controls.MaterialButton btnLisaaMokki;
        private System.Windows.Forms.Panel pnlPalvelut;
        private System.Windows.Forms.Panel pnlLisaaMokki;
        private MaterialSkin.Controls.MaterialMultiLineTextBox mltbKuvaus;
        private MaterialSkin.Controls.MaterialMultiLineTextBox mltbVarustelu;
        private MaterialSkin.Controls.MaterialTextBox tbPostinumero;
        private MaterialSkin.Controls.MaterialTextBox tbHinta;
        private MaterialSkin.Controls.MaterialTextBox tbOsoite;
        private MaterialSkin.Controls.MaterialTextBox tbMokkinimi;
        private MaterialSkin.Controls.MaterialTextBox tbHenkilomaara;
        private MaterialSkin.Controls.MaterialComboBox mcbToimintaAlue;
        private MaterialSkin.Controls.MaterialButton btnMokinLisays;
        private System.Windows.Forms.Label lblMokkitiedot;
        private System.Windows.Forms.Label lblStatus;
        private MaterialSkin.Controls.MaterialSlider msHenkilomaara;
        private System.Windows.Forms.Label lblKuvaus;
        private System.Windows.Forms.Label lblVarustelu;
        private MaterialSkin.Controls.MaterialButton btnPoistaMokki;
        private System.Windows.Forms.Panel pnlPoistaMokki;
        private System.Windows.Forms.Label lblMokkiPoisto;
        private MaterialSkin.Controls.MaterialButton btnPoistaValitut;
        private MaterialSkin.Controls.MaterialTextBox tbToimipaikka;
        private MaterialSkin.Controls.MaterialCheckedListBox mclbPalvelut;
        private MaterialSkin.Controls.MaterialListView mlvPoistaMokki;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialButton btnPalvelut;
        private System.Windows.Forms.Panel pnlPalvelu;
        private MaterialSkin.Controls.MaterialTextBox tbNimi;
        private MaterialSkin.Controls.MaterialButton btnLisaapalvelu;
        private MaterialSkin.Controls.MaterialTextBox tbAlv;
        private MaterialSkin.Controls.MaterialTextBox tbPrice;
        private MaterialSkin.Controls.MaterialTextBox tbKuvaus;
        private MaterialSkin.Controls.MaterialTextBox tbTyyppi;
        private MaterialSkin.Controls.MaterialLabel lblPalvelulisa;
        private MaterialSkin.Controls.MaterialButton btnPoistapalvelu;
        private MaterialSkin.Controls.MaterialListView mlvPalvelut;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}