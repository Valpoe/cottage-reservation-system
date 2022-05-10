namespace VillageNewbiesApp
{
    partial class frmLaskutus
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
            this.btnLahetaLasku = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVastaanottaja = new MaterialSkin.Controls.MaterialTextBox();
            this.tbCC = new MaterialSkin.Controls.MaterialTextBox();
            this.tbAihe = new MaterialSkin.Controls.MaterialTextBox();
            this.mmltbViesti = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbKayttajaTunnus = new MaterialSkin.Controls.MaterialTextBox();
            this.tbSalasana = new MaterialSkin.Controls.MaterialTextBox();
            this.tbPortti = new MaterialSkin.Controls.MaterialTextBox();
            this.tbSmtp = new MaterialSkin.Controls.MaterialTextBox();
            this.mcSSL = new MaterialSkin.Controls.MaterialCheckbox();
            this.label10 = new System.Windows.Forms.Label();
            this.mlvLaskut = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLataaLaskut = new MaterialSkin.Controls.MaterialButton();
            this.btnSahkopostiLasku = new MaterialSkin.Controls.MaterialButton();
            this.btnPaperilasku = new MaterialSkin.Controls.MaterialButton();
            this.mcbALV = new MaterialSkin.Controls.MaterialCheckbox();
            this.SuspendLayout();
            // 
            // btnLahetaLasku
            // 
            this.btnLahetaLasku.AutoSize = false;
            this.btnLahetaLasku.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLahetaLasku.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLahetaLasku.Depth = 0;
            this.btnLahetaLasku.HighEmphasis = true;
            this.btnLahetaLasku.Icon = null;
            this.btnLahetaLasku.Location = new System.Drawing.Point(617, 388);
            this.btnLahetaLasku.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLahetaLasku.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLahetaLasku.Name = "btnLahetaLasku";
            this.btnLahetaLasku.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLahetaLasku.Size = new System.Drawing.Size(126, 36);
            this.btnLahetaLasku.TabIndex = 5;
            this.btnLahetaLasku.Text = "Lähetä lasku";
            this.btnLahetaLasku.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLahetaLasku.UseAccentColor = false;
            this.btnLahetaLasku.UseVisualStyleBackColor = true;
            this.btnLahetaLasku.Click += new System.EventHandler(this.btnLahetaLasku_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(257, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vastaanottaja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(257, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "CC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label3.Location = new System.Drawing.Point(257, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aihe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(257, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Viesti:";
            // 
            // tbVastaanottaja
            // 
            this.tbVastaanottaja.AnimateReadOnly = false;
            this.tbVastaanottaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbVastaanottaja.Depth = 0;
            this.tbVastaanottaja.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbVastaanottaja.LeadingIcon = null;
            this.tbVastaanottaja.Location = new System.Drawing.Point(352, 9);
            this.tbVastaanottaja.MaxLength = 50;
            this.tbVastaanottaja.MouseState = MaterialSkin.MouseState.OUT;
            this.tbVastaanottaja.Multiline = false;
            this.tbVastaanottaja.Name = "tbVastaanottaja";
            this.tbVastaanottaja.Size = new System.Drawing.Size(391, 36);
            this.tbVastaanottaja.TabIndex = 10;
            this.tbVastaanottaja.Text = "";
            this.tbVastaanottaja.TrailingIcon = null;
            this.tbVastaanottaja.UseTallSize = false;
            // 
            // tbCC
            // 
            this.tbCC.AnimateReadOnly = false;
            this.tbCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCC.Depth = 0;
            this.tbCC.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCC.LeadingIcon = null;
            this.tbCC.Location = new System.Drawing.Point(352, 51);
            this.tbCC.MaxLength = 50;
            this.tbCC.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCC.Multiline = false;
            this.tbCC.Name = "tbCC";
            this.tbCC.Size = new System.Drawing.Size(391, 36);
            this.tbCC.TabIndex = 11;
            this.tbCC.Text = "";
            this.tbCC.TrailingIcon = null;
            this.tbCC.UseTallSize = false;
            // 
            // tbAihe
            // 
            this.tbAihe.AnimateReadOnly = false;
            this.tbAihe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAihe.Depth = 0;
            this.tbAihe.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAihe.LeadingIcon = null;
            this.tbAihe.Location = new System.Drawing.Point(352, 93);
            this.tbAihe.MaxLength = 50;
            this.tbAihe.MouseState = MaterialSkin.MouseState.OUT;
            this.tbAihe.Multiline = false;
            this.tbAihe.Name = "tbAihe";
            this.tbAihe.Size = new System.Drawing.Size(391, 36);
            this.tbAihe.TabIndex = 12;
            this.tbAihe.Text = "";
            this.tbAihe.TrailingIcon = null;
            this.tbAihe.UseTallSize = false;
            // 
            // mmltbViesti
            // 
            this.mmltbViesti.AnimateReadOnly = false;
            this.mmltbViesti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmltbViesti.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mmltbViesti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mmltbViesti.Depth = 0;
            this.mmltbViesti.HideSelection = true;
            this.mmltbViesti.Location = new System.Drawing.Point(352, 135);
            this.mmltbViesti.MaxLength = 32767;
            this.mmltbViesti.MouseState = MaterialSkin.MouseState.OUT;
            this.mmltbViesti.Name = "mmltbViesti";
            this.mmltbViesti.PasswordChar = '\0';
            this.mmltbViesti.ReadOnly = false;
            this.mmltbViesti.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mmltbViesti.SelectedText = "";
            this.mmltbViesti.SelectionLength = 0;
            this.mmltbViesti.SelectionStart = 0;
            this.mmltbViesti.ShortcutsEnabled = true;
            this.mmltbViesti.Size = new System.Drawing.Size(391, 184);
            this.mmltbViesti.TabIndex = 14;
            this.mmltbViesti.TabStop = false;
            this.mmltbViesti.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmltbViesti.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label5.Location = new System.Drawing.Point(349, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Asetukset";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label6.Location = new System.Drawing.Point(349, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Käyttäjätunnus:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label7.Location = new System.Drawing.Point(349, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Salasana:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label8.Location = new System.Drawing.Point(350, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Portti:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label9.Location = new System.Drawing.Point(512, 439);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Smtp:";
            // 
            // tbKayttajaTunnus
            // 
            this.tbKayttajaTunnus.AnimateReadOnly = false;
            this.tbKayttajaTunnus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKayttajaTunnus.Depth = 0;
            this.tbKayttajaTunnus.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbKayttajaTunnus.LeadingIcon = null;
            this.tbKayttajaTunnus.Location = new System.Drawing.Point(450, 348);
            this.tbKayttajaTunnus.MaxLength = 50;
            this.tbKayttajaTunnus.MouseState = MaterialSkin.MouseState.OUT;
            this.tbKayttajaTunnus.Multiline = false;
            this.tbKayttajaTunnus.Name = "tbKayttajaTunnus";
            this.tbKayttajaTunnus.Size = new System.Drawing.Size(161, 36);
            this.tbKayttajaTunnus.TabIndex = 20;
            this.tbKayttajaTunnus.Text = "";
            this.tbKayttajaTunnus.TrailingIcon = null;
            this.tbKayttajaTunnus.UseTallSize = false;
            // 
            // tbSalasana
            // 
            this.tbSalasana.AnimateReadOnly = false;
            this.tbSalasana.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSalasana.Depth = 0;
            this.tbSalasana.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSalasana.LeadingIcon = null;
            this.tbSalasana.Location = new System.Drawing.Point(450, 390);
            this.tbSalasana.MaxLength = 50;
            this.tbSalasana.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSalasana.Multiline = false;
            this.tbSalasana.Name = "tbSalasana";
            this.tbSalasana.Password = true;
            this.tbSalasana.Size = new System.Drawing.Size(161, 36);
            this.tbSalasana.TabIndex = 21;
            this.tbSalasana.Text = "";
            this.tbSalasana.TrailingIcon = null;
            this.tbSalasana.UseTallSize = false;
            // 
            // tbPortti
            // 
            this.tbPortti.AnimateReadOnly = false;
            this.tbPortti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPortti.Depth = 0;
            this.tbPortti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbPortti.LeadingIcon = null;
            this.tbPortti.Location = new System.Drawing.Point(450, 433);
            this.tbPortti.MaxLength = 50;
            this.tbPortti.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPortti.Multiline = false;
            this.tbPortti.Name = "tbPortti";
            this.tbPortti.Size = new System.Drawing.Size(59, 36);
            this.tbPortti.TabIndex = 22;
            this.tbPortti.Text = "587";
            this.tbPortti.TrailingIcon = null;
            this.tbPortti.UseTallSize = false;
            // 
            // tbSmtp
            // 
            this.tbSmtp.AnimateReadOnly = false;
            this.tbSmtp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSmtp.Depth = 0;
            this.tbSmtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tbSmtp.LeadingIcon = null;
            this.tbSmtp.Location = new System.Drawing.Point(557, 432);
            this.tbSmtp.MaxLength = 50;
            this.tbSmtp.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSmtp.Multiline = false;
            this.tbSmtp.Name = "tbSmtp";
            this.tbSmtp.Size = new System.Drawing.Size(186, 36);
            this.tbSmtp.TabIndex = 23;
            this.tbSmtp.Text = "smtp.gmail.com";
            this.tbSmtp.TrailingIcon = null;
            this.tbSmtp.UseTallSize = false;
            // 
            // mcSSL
            // 
            this.mcSSL.AutoSize = true;
            this.mcSSL.Depth = 0;
            this.mcSSL.Location = new System.Drawing.Point(617, 347);
            this.mcSSL.Margin = new System.Windows.Forms.Padding(0);
            this.mcSSL.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcSSL.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcSSL.Name = "mcSSL";
            this.mcSSL.ReadOnly = false;
            this.mcSSL.Ripple = true;
            this.mcSSL.Size = new System.Drawing.Size(64, 37);
            this.mcSSL.TabIndex = 24;
            this.mcSSL.Text = "SSL";
            this.mcSSL.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label10.Location = new System.Drawing.Point(12, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 21);
            this.label10.TabIndex = 26;
            this.label10.Text = "Valitse lasku";
            // 
            // mlvLaskut
            // 
            this.mlvLaskut.AutoSizeTable = false;
            this.mlvLaskut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlvLaskut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvLaskut.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.mlvLaskut.Depth = 0;
            this.mlvLaskut.FullRowSelect = true;
            this.mlvLaskut.HideSelection = false;
            this.mlvLaskut.Location = new System.Drawing.Point(12, 173);
            this.mlvLaskut.MinimumSize = new System.Drawing.Size(200, 100);
            this.mlvLaskut.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvLaskut.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvLaskut.Name = "mlvLaskut";
            this.mlvLaskut.OwnerDraw = true;
            this.mlvLaskut.Size = new System.Drawing.Size(325, 140);
            this.mlvLaskut.TabIndex = 27;
            this.mlvLaskut.UseCompatibleStateImageBehavior = false;
            this.mlvLaskut.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Lasku ID";
            this.columnHeader1.Width = 95;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Varaus ID";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Asiakas";
            this.columnHeader3.Width = 135;
            // 
            // btnLataaLaskut
            // 
            this.btnLataaLaskut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLataaLaskut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLataaLaskut.Depth = 0;
            this.btnLataaLaskut.HighEmphasis = true;
            this.btnLataaLaskut.Icon = null;
            this.btnLataaLaskut.Location = new System.Drawing.Point(16, 93);
            this.btnLataaLaskut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLataaLaskut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLataaLaskut.Name = "btnLataaLaskut";
            this.btnLataaLaskut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLataaLaskut.Size = new System.Drawing.Size(125, 36);
            this.btnLataaLaskut.TabIndex = 28;
            this.btnLataaLaskut.Text = "Lataa laskut";
            this.btnLataaLaskut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLataaLaskut.UseAccentColor = false;
            this.btnLataaLaskut.UseVisualStyleBackColor = true;
            this.btnLataaLaskut.Click += new System.EventHandler(this.btnLataaLaskut_Click);
            // 
            // btnSahkopostiLasku
            // 
            this.btnSahkopostiLasku.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSahkopostiLasku.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSahkopostiLasku.Depth = 0;
            this.btnSahkopostiLasku.HighEmphasis = true;
            this.btnSahkopostiLasku.Icon = null;
            this.btnSahkopostiLasku.Location = new System.Drawing.Point(12, 365);
            this.btnSahkopostiLasku.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSahkopostiLasku.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSahkopostiLasku.Name = "btnSahkopostiLasku";
            this.btnSahkopostiLasku.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSahkopostiLasku.Size = new System.Drawing.Size(157, 36);
            this.btnSahkopostiLasku.TabIndex = 29;
            this.btnSahkopostiLasku.Text = "Sähköpostilasku";
            this.btnSahkopostiLasku.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSahkopostiLasku.UseAccentColor = false;
            this.btnSahkopostiLasku.UseVisualStyleBackColor = true;
            this.btnSahkopostiLasku.Click += new System.EventHandler(this.btnSahkopostiLasku_Click);
            // 
            // btnPaperilasku
            // 
            this.btnPaperilasku.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPaperilasku.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPaperilasku.Depth = 0;
            this.btnPaperilasku.HighEmphasis = true;
            this.btnPaperilasku.Icon = null;
            this.btnPaperilasku.Location = new System.Drawing.Point(12, 413);
            this.btnPaperilasku.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPaperilasku.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPaperilasku.Name = "btnPaperilasku";
            this.btnPaperilasku.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPaperilasku.Size = new System.Drawing.Size(117, 36);
            this.btnPaperilasku.TabIndex = 30;
            this.btnPaperilasku.Text = "Paperilasku";
            this.btnPaperilasku.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPaperilasku.UseAccentColor = false;
            this.btnPaperilasku.UseVisualStyleBackColor = true;
            this.btnPaperilasku.Click += new System.EventHandler(this.btnPaperilasku_Click);
            // 
            // mcbALV
            // 
            this.mcbALV.AutoSize = true;
            this.mcbALV.Depth = 0;
            this.mcbALV.Location = new System.Drawing.Point(12, 322);
            this.mcbALV.Margin = new System.Windows.Forms.Padding(0);
            this.mcbALV.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mcbALV.MouseState = MaterialSkin.MouseState.HOVER;
            this.mcbALV.Name = "mcbALV";
            this.mcbALV.ReadOnly = false;
            this.mcbALV.Ripple = true;
            this.mcbALV.Size = new System.Drawing.Size(107, 37);
            this.mcbALV.TabIndex = 31;
            this.mcbALV.Text = "Lisää ALV";
            this.mcbALV.UseVisualStyleBackColor = true;
            // 
            // frmLaskutus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 477);
            this.Controls.Add(this.mcbALV);
            this.Controls.Add(this.btnPaperilasku);
            this.Controls.Add(this.btnSahkopostiLasku);
            this.Controls.Add(this.btnLataaLaskut);
            this.Controls.Add(this.mlvLaskut);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mcSSL);
            this.Controls.Add(this.tbSmtp);
            this.Controls.Add(this.tbPortti);
            this.Controls.Add(this.tbSalasana);
            this.Controls.Add(this.tbKayttajaTunnus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mmltbViesti);
            this.Controls.Add(this.tbAihe);
            this.Controls.Add(this.tbCC);
            this.Controls.Add(this.tbVastaanottaja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLahetaLasku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLaskutus";
            this.Text = "frmLaskutus";
            this.Load += new System.EventHandler(this.frmLaskutus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnLahetaLasku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialTextBox tbVastaanottaja;
        private MaterialSkin.Controls.MaterialTextBox tbCC;
        private MaterialSkin.Controls.MaterialTextBox tbAihe;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 mmltbViesti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialTextBox tbKayttajaTunnus;
        private MaterialSkin.Controls.MaterialTextBox tbSalasana;
        private MaterialSkin.Controls.MaterialTextBox tbPortti;
        private MaterialSkin.Controls.MaterialTextBox tbSmtp;
        private MaterialSkin.Controls.MaterialCheckbox mcSSL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialButton btnLataaLaskut;
        private MaterialSkin.Controls.MaterialButton btnSahkopostiLasku;
        private MaterialSkin.Controls.MaterialButton btnPaperilasku;
        private MaterialSkin.Controls.MaterialCheckbox mcbALV;
        public MaterialSkin.Controls.MaterialListView mlvLaskut;
    }
}