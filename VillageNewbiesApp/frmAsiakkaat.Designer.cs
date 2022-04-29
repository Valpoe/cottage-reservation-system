namespace VillageNewbiesApp
{
    partial class frmAsiakkaat
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
            this.btnLisaa = new MaterialSkin.Controls.MaterialButton();
            this.btnTyhjenna = new MaterialSkin.Controls.MaterialButton();
            this.tbSukunimi = new MaterialSkin.Controls.MaterialTextBox();
            this.tbEtunimi = new MaterialSkin.Controls.MaterialTextBox();
            this.tbOsoite = new MaterialSkin.Controls.MaterialTextBox();
            this.tbSahkoPosti = new MaterialSkin.Controls.MaterialTextBox();
            this.tbPuhelinNumero = new MaterialSkin.Controls.MaterialTextBox();
            this.labelAsiakkaanTiedot = new MaterialSkin.Controls.MaterialLabel();
            this.mlvAsiakkaat = new MaterialSkin.Controls.MaterialListView();
            this.ColumnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKokonimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPuhnro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbSearchBox = new MaterialSkin.Controls.MaterialTextBox();
            this.tbPostiNumero = new MaterialSkin.Controls.MaterialTextBox();
            this.tbPostitoimipaikka = new MaterialSkin.Controls.MaterialTextBox();
            this.btnLataaAsiakkaat = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // btnLisaa
            // 
            this.btnLisaa.AutoSize = false;
            this.btnLisaa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLisaa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLisaa.Depth = 0;
            this.btnLisaa.HighEmphasis = true;
            this.btnLisaa.Icon = null;
            this.btnLisaa.Location = new System.Drawing.Point(116, 351);
            this.btnLisaa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLisaa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLisaa.Size = new System.Drawing.Size(97, 36);
            this.btnLisaa.TabIndex = 9;
            this.btnLisaa.Text = "Lisää";
            this.btnLisaa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLisaa.UseAccentColor = false;
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // btnTyhjenna
            // 
            this.btnTyhjenna.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTyhjenna.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTyhjenna.Depth = 0;
            this.btnTyhjenna.HighEmphasis = true;
            this.btnTyhjenna.Icon = null;
            this.btnTyhjenna.Location = new System.Drawing.Point(12, 350);
            this.btnTyhjenna.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnTyhjenna.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTyhjenna.Name = "btnTyhjenna";
            this.btnTyhjenna.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTyhjenna.Size = new System.Drawing.Size(97, 36);
            this.btnTyhjenna.TabIndex = 8;
            this.btnTyhjenna.Text = "Tyhjennä";
            this.btnTyhjenna.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTyhjenna.UseAccentColor = true;
            this.btnTyhjenna.UseVisualStyleBackColor = true;
            this.btnTyhjenna.Click += new System.EventHandler(this.btnTyhjenna_Click);
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.AnimateReadOnly = false;
            this.tbSukunimi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSukunimi.Depth = 0;
            this.tbSukunimi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSukunimi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.tbSukunimi.Hint = "Sukunimi";
            this.tbSukunimi.LeadingIcon = null;
            this.tbSukunimi.Location = new System.Drawing.Point(13, 96);
            this.tbSukunimi.MaxLength = 50;
            this.tbSukunimi.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSukunimi.Multiline = false;
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(200, 36);
            this.tbSukunimi.TabIndex = 2;
            this.tbSukunimi.Text = "";
            this.tbSukunimi.TrailingIcon = null;
            this.tbSukunimi.UseTallSize = false;
            this.tbSukunimi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbEtunimi_MouseClick);
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.AnimateReadOnly = false;
            this.tbEtunimi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbEtunimi.Depth = 0;
            this.tbEtunimi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbEtunimi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.tbEtunimi.Hint = "Etunimi";
            this.tbEtunimi.LeadingIcon = null;
            this.tbEtunimi.Location = new System.Drawing.Point(13, 54);
            this.tbEtunimi.MaxLength = 50;
            this.tbEtunimi.MouseState = MaterialSkin.MouseState.OUT;
            this.tbEtunimi.Multiline = false;
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(200, 36);
            this.tbEtunimi.TabIndex = 1;
            this.tbEtunimi.Text = "";
            this.tbEtunimi.TrailingIcon = null;
            this.tbEtunimi.UseTallSize = false;
            this.tbEtunimi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbEtunimi_MouseClick);
            // 
            // tbOsoite
            // 
            this.tbOsoite.AnimateReadOnly = false;
            this.tbOsoite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOsoite.Depth = 0;
            this.tbOsoite.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbOsoite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbOsoite.Hint = "Osoite";
            this.tbOsoite.LeadingIcon = null;
            this.tbOsoite.Location = new System.Drawing.Point(13, 138);
            this.tbOsoite.MaxLength = 50;
            this.tbOsoite.MouseState = MaterialSkin.MouseState.OUT;
            this.tbOsoite.Multiline = false;
            this.tbOsoite.Name = "tbOsoite";
            this.tbOsoite.Size = new System.Drawing.Size(200, 36);
            this.tbOsoite.TabIndex = 3;
            this.tbOsoite.Text = "";
            this.tbOsoite.TrailingIcon = null;
            this.tbOsoite.UseTallSize = false;
            this.tbOsoite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbEtunimi_MouseClick);
            // 
            // tbSahkoPosti
            // 
            this.tbSahkoPosti.AnimateReadOnly = false;
            this.tbSahkoPosti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSahkoPosti.Depth = 0;
            this.tbSahkoPosti.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSahkoPosti.ForeColor = System.Drawing.Color.Aqua;
            this.tbSahkoPosti.Hint = "Sähköposti";
            this.tbSahkoPosti.LeadingIcon = null;
            this.tbSahkoPosti.Location = new System.Drawing.Point(13, 264);
            this.tbSahkoPosti.MaxLength = 50;
            this.tbSahkoPosti.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSahkoPosti.Multiline = false;
            this.tbSahkoPosti.Name = "tbSahkoPosti";
            this.tbSahkoPosti.Size = new System.Drawing.Size(200, 36);
            this.tbSahkoPosti.TabIndex = 6;
            this.tbSahkoPosti.Text = "";
            this.tbSahkoPosti.TrailingIcon = null;
            this.tbSahkoPosti.UseTallSize = false;
            this.tbSahkoPosti.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbEtunimi_MouseClick);
            // 
            // tbPuhelinNumero
            // 
            this.tbPuhelinNumero.AnimateReadOnly = false;
            this.tbPuhelinNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPuhelinNumero.Depth = 0;
            this.tbPuhelinNumero.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPuhelinNumero.ForeColor = System.Drawing.Color.Aqua;
            this.tbPuhelinNumero.Hint = "Puhelinnumero";
            this.tbPuhelinNumero.LeadingIcon = null;
            this.tbPuhelinNumero.Location = new System.Drawing.Point(12, 306);
            this.tbPuhelinNumero.MaxLength = 50;
            this.tbPuhelinNumero.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPuhelinNumero.Multiline = false;
            this.tbPuhelinNumero.Name = "tbPuhelinNumero";
            this.tbPuhelinNumero.Size = new System.Drawing.Size(200, 36);
            this.tbPuhelinNumero.TabIndex = 7;
            this.tbPuhelinNumero.Text = "";
            this.tbPuhelinNumero.TrailingIcon = null;
            this.tbPuhelinNumero.UseTallSize = false;
            this.tbPuhelinNumero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbEtunimi_MouseClick);
            // 
            // labelAsiakkaanTiedot
            // 
            this.labelAsiakkaanTiedot.AutoSize = true;
            this.labelAsiakkaanTiedot.Depth = 0;
            this.labelAsiakkaanTiedot.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsiakkaanTiedot.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.labelAsiakkaanTiedot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.labelAsiakkaanTiedot.Location = new System.Drawing.Point(15, 32);
            this.labelAsiakkaanTiedot.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsiakkaanTiedot.Name = "labelAsiakkaanTiedot";
            this.labelAsiakkaanTiedot.Size = new System.Drawing.Size(143, 17);
            this.labelAsiakkaanTiedot.TabIndex = 0;
            this.labelAsiakkaanTiedot.Text = "Syötä asiakkaan tiedot";
            // 
            // mlvAsiakkaat
            // 
            this.mlvAsiakkaat.AutoSizeTable = false;
            this.mlvAsiakkaat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlvAsiakkaat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvAsiakkaat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnID,
            this.columnKokonimi,
            this.columnEmail,
            this.columnPuhnro});
            this.mlvAsiakkaat.Depth = 0;
            this.mlvAsiakkaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlvAsiakkaat.FullRowSelect = true;
            this.mlvAsiakkaat.HideSelection = false;
            this.mlvAsiakkaat.Location = new System.Drawing.Point(230, 54);
            this.mlvAsiakkaat.MinimumSize = new System.Drawing.Size(200, 100);
            this.mlvAsiakkaat.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvAsiakkaat.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvAsiakkaat.Name = "mlvAsiakkaat";
            this.mlvAsiakkaat.OwnerDraw = true;
            this.mlvAsiakkaat.Size = new System.Drawing.Size(520, 288);
            this.mlvAsiakkaat.TabIndex = 11;
            this.mlvAsiakkaat.UseCompatibleStateImageBehavior = false;
            this.mlvAsiakkaat.View = System.Windows.Forms.View.Details;
            this.mlvAsiakkaat.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.mlvAsiakkaat_ColumnWidthChanging);
            // 
            // ColumnID
            // 
            this.ColumnID.Text = "ID";
            this.ColumnID.Width = 45;
            // 
            // columnKokonimi
            // 
            this.columnKokonimi.Text = "Nimi";
            this.columnKokonimi.Width = 135;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "Email";
            this.columnEmail.Width = 215;
            // 
            // columnPuhnro
            // 
            this.columnPuhnro.Text = "Puhelin";
            this.columnPuhnro.Width = 125;
            // 
            // tbSearchBox
            // 
            this.tbSearchBox.AnimateReadOnly = false;
            this.tbSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearchBox.Depth = 0;
            this.tbSearchBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSearchBox.Hint = "Etsi asiakkaita";
            this.tbSearchBox.LeadingIcon = null;
            this.tbSearchBox.Location = new System.Drawing.Point(550, 13);
            this.tbSearchBox.MaxLength = 50;
            this.tbSearchBox.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSearchBox.Multiline = false;
            this.tbSearchBox.Name = "tbSearchBox";
            this.tbSearchBox.Size = new System.Drawing.Size(200, 36);
            this.tbSearchBox.TabIndex = 10;
            this.tbSearchBox.Text = "";
            this.tbSearchBox.TrailingIcon = null;
            this.tbSearchBox.UseTallSize = false;
            this.tbSearchBox.TextChanged += new System.EventHandler(this.tbSearchBox_TextChanged);
            // 
            // tbPostiNumero
            // 
            this.tbPostiNumero.AnimateReadOnly = false;
            this.tbPostiNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPostiNumero.Depth = 0;
            this.tbPostiNumero.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPostiNumero.ForeColor = System.Drawing.Color.Aqua;
            this.tbPostiNumero.Hint = "Postinumero";
            this.tbPostiNumero.LeadingIcon = null;
            this.tbPostiNumero.Location = new System.Drawing.Point(12, 180);
            this.tbPostiNumero.MaxLength = 50;
            this.tbPostiNumero.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPostiNumero.Multiline = false;
            this.tbPostiNumero.Name = "tbPostiNumero";
            this.tbPostiNumero.Size = new System.Drawing.Size(200, 36);
            this.tbPostiNumero.TabIndex = 4;
            this.tbPostiNumero.Text = "";
            this.tbPostiNumero.TrailingIcon = null;
            this.tbPostiNumero.UseTallSize = false;
            this.tbPostiNumero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbEtunimi_MouseClick);
            // 
            // tbPostitoimipaikka
            // 
            this.tbPostitoimipaikka.AnimateReadOnly = false;
            this.tbPostitoimipaikka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPostitoimipaikka.Depth = 0;
            this.tbPostitoimipaikka.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPostitoimipaikka.ForeColor = System.Drawing.Color.Aqua;
            this.tbPostitoimipaikka.Hint = "Postitoimipaikka";
            this.tbPostitoimipaikka.LeadingIcon = null;
            this.tbPostitoimipaikka.Location = new System.Drawing.Point(13, 222);
            this.tbPostitoimipaikka.MaxLength = 50;
            this.tbPostitoimipaikka.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPostitoimipaikka.Multiline = false;
            this.tbPostitoimipaikka.Name = "tbPostitoimipaikka";
            this.tbPostitoimipaikka.Size = new System.Drawing.Size(200, 36);
            this.tbPostitoimipaikka.TabIndex = 5;
            this.tbPostitoimipaikka.Text = "";
            this.tbPostitoimipaikka.TrailingIcon = null;
            this.tbPostitoimipaikka.UseTallSize = false;
            this.tbPostitoimipaikka.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbEtunimi_MouseClick);
            // 
            // btnLataaAsiakkaat
            // 
            this.btnLataaAsiakkaat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLataaAsiakkaat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLataaAsiakkaat.Depth = 0;
            this.btnLataaAsiakkaat.HighEmphasis = true;
            this.btnLataaAsiakkaat.Icon = null;
            this.btnLataaAsiakkaat.Location = new System.Drawing.Point(600, 351);
            this.btnLataaAsiakkaat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLataaAsiakkaat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLataaAsiakkaat.Name = "btnLataaAsiakkaat";
            this.btnLataaAsiakkaat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLataaAsiakkaat.Size = new System.Drawing.Size(150, 36);
            this.btnLataaAsiakkaat.TabIndex = 12;
            this.btnLataaAsiakkaat.Text = "Lataa asiakkaat";
            this.btnLataaAsiakkaat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLataaAsiakkaat.UseAccentColor = false;
            this.btnLataaAsiakkaat.UseVisualStyleBackColor = true;
            this.btnLataaAsiakkaat.Click += new System.EventHandler(this.btnLataaAsiakkaat_Click);
            // 
            // frmAsiakkaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 477);
            this.Controls.Add(this.btnLataaAsiakkaat);
            this.Controls.Add(this.tbPostitoimipaikka);
            this.Controls.Add(this.tbPostiNumero);
            this.Controls.Add(this.tbSearchBox);
            this.Controls.Add(this.mlvAsiakkaat);
            this.Controls.Add(this.labelAsiakkaanTiedot);
            this.Controls.Add(this.tbPuhelinNumero);
            this.Controls.Add(this.tbSahkoPosti);
            this.Controls.Add(this.tbOsoite);
            this.Controls.Add(this.tbEtunimi);
            this.Controls.Add(this.tbSukunimi);
            this.Controls.Add(this.btnTyhjenna);
            this.Controls.Add(this.btnLisaa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAsiakkaat";
            this.Text = "frmAsiakkaat";
            this.Load += new System.EventHandler(this.frmAsiakkaat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnLisaa;
        private MaterialSkin.Controls.MaterialButton btnTyhjenna;
        private MaterialSkin.Controls.MaterialTextBox tbSukunimi;
        private MaterialSkin.Controls.MaterialTextBox tbEtunimi;
        private MaterialSkin.Controls.MaterialTextBox tbOsoite;
        private MaterialSkin.Controls.MaterialTextBox tbSahkoPosti;
        private MaterialSkin.Controls.MaterialTextBox tbPuhelinNumero;
        private MaterialSkin.Controls.MaterialLabel labelAsiakkaanTiedot;
        private MaterialSkin.Controls.MaterialTextBox tbSearchBox;
        private MaterialSkin.Controls.MaterialTextBox tbPostiNumero;
        private MaterialSkin.Controls.MaterialTextBox tbPostitoimipaikka;
        private MaterialSkin.Controls.MaterialButton btnLataaAsiakkaat;
        public MaterialSkin.Controls.MaterialListView mlvAsiakkaat;
        private System.Windows.Forms.ColumnHeader ColumnID;
        private System.Windows.Forms.ColumnHeader columnKokonimi;
        private System.Windows.Forms.ColumnHeader columnEmail;
        private System.Windows.Forms.ColumnHeader columnPuhnro;
    }
}