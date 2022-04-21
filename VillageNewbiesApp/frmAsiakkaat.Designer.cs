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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.tbSukunimi = new MaterialSkin.Controls.MaterialTextBox();
            this.tbEtunimi = new MaterialSkin.Controls.MaterialTextBox();
            this.tbOsoite = new MaterialSkin.Controls.MaterialTextBox();
            this.tbSahkoPosti = new MaterialSkin.Controls.MaterialTextBox();
            this.tbPuhelinNumero = new MaterialSkin.Controls.MaterialTextBox();
            this.labelAsiakkaanTiedot = new MaterialSkin.Controls.MaterialLabel();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnEtunimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSukunimi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnOsoite = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSahkoposti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPuhNro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(148, 261);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(64, 36);
            this.materialButton1.TabIndex = 3;
            this.materialButton1.Text = "Lisää";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(12, 260);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(97, 36);
            this.materialButton2.TabIndex = 4;
            this.materialButton2.Text = "Tyhjennä";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
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
            this.tbSukunimi.Location = new System.Drawing.Point(12, 90);
            this.tbSukunimi.MaxLength = 50;
            this.tbSukunimi.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSukunimi.Multiline = false;
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(200, 36);
            this.tbSukunimi.TabIndex = 12;
            this.tbSukunimi.Text = "";
            this.tbSukunimi.TrailingIcon = null;
            this.tbSukunimi.UseTallSize = false;
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
            this.tbEtunimi.Location = new System.Drawing.Point(12, 48);
            this.tbEtunimi.MaxLength = 50;
            this.tbEtunimi.MouseState = MaterialSkin.MouseState.OUT;
            this.tbEtunimi.Multiline = false;
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(200, 36);
            this.tbEtunimi.TabIndex = 13;
            this.tbEtunimi.Text = "";
            this.tbEtunimi.TrailingIcon = null;
            this.tbEtunimi.UseTallSize = false;
            // 
            // tbOsoite
            // 
            this.tbOsoite.AnimateReadOnly = false;
            this.tbOsoite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOsoite.Depth = 0;
            this.tbOsoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbOsoite.ForeColor = System.Drawing.Color.Aqua;
            this.tbOsoite.Hint = "Osoite";
            this.tbOsoite.LeadingIcon = null;
            this.tbOsoite.Location = new System.Drawing.Point(12, 132);
            this.tbOsoite.MaxLength = 50;
            this.tbOsoite.MouseState = MaterialSkin.MouseState.OUT;
            this.tbOsoite.Multiline = false;
            this.tbOsoite.Name = "tbOsoite";
            this.tbOsoite.Size = new System.Drawing.Size(200, 36);
            this.tbOsoite.TabIndex = 14;
            this.tbOsoite.Text = "";
            this.tbOsoite.TrailingIcon = null;
            this.tbOsoite.UseTallSize = false;
            // 
            // tbSahkoPosti
            // 
            this.tbSahkoPosti.AnimateReadOnly = false;
            this.tbSahkoPosti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSahkoPosti.Depth = 0;
            this.tbSahkoPosti.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbSahkoPosti.ForeColor = System.Drawing.Color.Aqua;
            this.tbSahkoPosti.Hint = "Sähköposti";
            this.tbSahkoPosti.LeadingIcon = null;
            this.tbSahkoPosti.Location = new System.Drawing.Point(12, 174);
            this.tbSahkoPosti.MaxLength = 50;
            this.tbSahkoPosti.MouseState = MaterialSkin.MouseState.OUT;
            this.tbSahkoPosti.Multiline = false;
            this.tbSahkoPosti.Name = "tbSahkoPosti";
            this.tbSahkoPosti.Size = new System.Drawing.Size(200, 36);
            this.tbSahkoPosti.TabIndex = 15;
            this.tbSahkoPosti.Text = "";
            this.tbSahkoPosti.TrailingIcon = null;
            this.tbSahkoPosti.UseTallSize = false;
            // 
            // tbPuhelinNumero
            // 
            this.tbPuhelinNumero.AnimateReadOnly = false;
            this.tbPuhelinNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPuhelinNumero.Depth = 0;
            this.tbPuhelinNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPuhelinNumero.ForeColor = System.Drawing.Color.Aqua;
            this.tbPuhelinNumero.Hint = "Puhelinnumero";
            this.tbPuhelinNumero.LeadingIcon = null;
            this.tbPuhelinNumero.Location = new System.Drawing.Point(12, 216);
            this.tbPuhelinNumero.MaxLength = 50;
            this.tbPuhelinNumero.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPuhelinNumero.Multiline = false;
            this.tbPuhelinNumero.Name = "tbPuhelinNumero";
            this.tbPuhelinNumero.Size = new System.Drawing.Size(200, 36);
            this.tbPuhelinNumero.TabIndex = 16;
            this.tbPuhelinNumero.Text = "";
            this.tbPuhelinNumero.TrailingIcon = null;
            this.tbPuhelinNumero.UseTallSize = false;
            // 
            // labelAsiakkaanTiedot
            // 
            this.labelAsiakkaanTiedot.AutoSize = true;
            this.labelAsiakkaanTiedot.Depth = 0;
            this.labelAsiakkaanTiedot.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.labelAsiakkaanTiedot.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.labelAsiakkaanTiedot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.labelAsiakkaanTiedot.Location = new System.Drawing.Point(8, 9);
            this.labelAsiakkaanTiedot.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelAsiakkaanTiedot.Name = "labelAsiakkaanTiedot";
            this.labelAsiakkaanTiedot.Size = new System.Drawing.Size(150, 24);
            this.labelAsiakkaanTiedot.TabIndex = 17;
            this.labelAsiakkaanTiedot.Text = "Asiakkaan tiedot";
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnEtunimi,
            this.columnSukunimi,
            this.columnOsoite,
            this.columnSahkoposti,
            this.columnPuhNro});
            this.materialListView1.Depth = 0;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.materialListView1.Location = new System.Drawing.Point(257, 48);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(485, 226);
            this.materialListView1.TabIndex = 18;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // columnEtunimi
            // 
            this.columnEtunimi.Text = "Etunimi";
            this.columnEtunimi.Width = 81;
            // 
            // columnSukunimi
            // 
            this.columnSukunimi.Text = "Sukunimi";
            this.columnSukunimi.Width = 91;
            // 
            // columnOsoite
            // 
            this.columnOsoite.Text = "Osoite";
            this.columnOsoite.Width = 76;
            // 
            // columnSahkoposti
            // 
            this.columnSahkoposti.Text = "Sähköposti";
            this.columnSahkoposti.Width = 106;
            // 
            // columnPuhNro
            // 
            this.columnPuhNro.Text = "Puhelinnumero";
            this.columnPuhNro.Width = 131;
            // 
            // frmAsiakkaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 477);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.labelAsiakkaanTiedot);
            this.Controls.Add(this.tbPuhelinNumero);
            this.Controls.Add(this.tbSahkoPosti);
            this.Controls.Add(this.tbOsoite);
            this.Controls.Add(this.tbEtunimi);
            this.Controls.Add(this.tbSukunimi);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAsiakkaat";
            this.Text = "frmAsiakkaat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox tbSukunimi;
        private MaterialSkin.Controls.MaterialTextBox tbEtunimi;
        private MaterialSkin.Controls.MaterialTextBox tbOsoite;
        private MaterialSkin.Controls.MaterialTextBox tbSahkoPosti;
        private MaterialSkin.Controls.MaterialTextBox tbPuhelinNumero;
        private MaterialSkin.Controls.MaterialLabel labelAsiakkaanTiedot;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnEtunimi;
        private System.Windows.Forms.ColumnHeader columnSukunimi;
        private System.Windows.Forms.ColumnHeader columnOsoite;
        private System.Windows.Forms.ColumnHeader columnSahkoposti;
        private System.Windows.Forms.ColumnHeader columnPuhNro;
    }
}