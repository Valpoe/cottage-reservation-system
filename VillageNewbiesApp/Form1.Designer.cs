namespace VillageNewbiesApp
{
    partial class Form1
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnKirjauduUlos = new System.Windows.Forms.Button();
            this.btnKirjauduSisaan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btnRaportit = new System.Windows.Forms.Button();
            this.btnLaskutus = new System.Windows.Forms.Button();
            this.btnAsiakkaat = new System.Windows.Forms.Button();
            this.btnVaraukset = new System.Windows.Forms.Button();
            this.btnMokitJaPalvelut = new System.Windows.Forms.Button();
            this.btnToimintaAlueet = new System.Windows.Forms.Button();
            this.btnEtusivu = new System.Windows.Forms.Button();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.lblOtsikko = new System.Windows.Forms.Label();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTopLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelLeft.Controls.Add(this.btnKirjauduSisaan);
            this.panelLeft.Controls.Add(this.btnKirjauduUlos);
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Controls.Add(this.panelNavigation);
            this.panelLeft.Controls.Add(this.btnRaportit);
            this.panelLeft.Controls.Add(this.btnLaskutus);
            this.panelLeft.Controls.Add(this.btnVaraukset);
            this.panelLeft.Controls.Add(this.btnMokitJaPalvelut);
            this.panelLeft.Controls.Add(this.btnToimintaAlueet);
            this.panelLeft.Controls.Add(this.btnAsiakkaat);
            this.panelLeft.Controls.Add(this.btnEtusivu);
            this.panelLeft.Controls.Add(this.panelTopLeft);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(186, 577);
            this.panelLeft.TabIndex = 0;
            // 
            // btnKirjauduUlos
            // 
            this.btnKirjauduUlos.FlatAppearance.BorderSize = 2;
            this.btnKirjauduUlos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKirjauduUlos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKirjauduUlos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.btnKirjauduUlos.Image = global::VillageNewbiesApp.Properties.Resources.Kirjaudu;
            this.btnKirjauduUlos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKirjauduUlos.Location = new System.Drawing.Point(15, 476);
            this.btnKirjauduUlos.Name = "btnKirjauduUlos";
            this.btnKirjauduUlos.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnKirjauduUlos.Size = new System.Drawing.Size(155, 45);
            this.btnKirjauduUlos.TabIndex = 6;
            this.btnKirjauduUlos.Text = "Kirjaudu ulos";
            this.btnKirjauduUlos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKirjauduUlos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnKirjauduUlos.UseVisualStyleBackColor = true;
            this.btnKirjauduUlos.Visible = false;
            this.btnKirjauduUlos.Click += new System.EventHandler(this.btnKirjauduUlos_Click);
            // 
            // btnKirjauduSisaan
            // 
            this.btnKirjauduSisaan.FlatAppearance.BorderSize = 2;
            this.btnKirjauduSisaan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKirjauduSisaan.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKirjauduSisaan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.btnKirjauduSisaan.Image = global::VillageNewbiesApp.Properties.Resources.Kirjaudu;
            this.btnKirjauduSisaan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKirjauduSisaan.Location = new System.Drawing.Point(15, 476);
            this.btnKirjauduSisaan.Name = "btnKirjauduSisaan";
            this.btnKirjauduSisaan.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnKirjauduSisaan.Size = new System.Drawing.Size(155, 45);
            this.btnKirjauduSisaan.TabIndex = 5;
            this.btnKirjauduSisaan.Text = "Kirjaudu";
            this.btnKirjauduSisaan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKirjauduSisaan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnKirjauduSisaan.UseVisualStyleBackColor = true;
            this.btnKirjauduSisaan.Click += new System.EventHandler(this.btnKirjauduSisaan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VillageNewbiesApp.Properties.Resources.NapsuSoftware;
            this.pictureBox1.Location = new System.Drawing.Point(5, 547);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelNavigation.Location = new System.Drawing.Point(0, 193);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(3, 100);
            this.panelNavigation.TabIndex = 1;
            // 
            // btnRaportit
            // 
            this.btnRaportit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRaportit.Enabled = false;
            this.btnRaportit.FlatAppearance.BorderSize = 0;
            this.btnRaportit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaportit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaportit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.btnRaportit.Image = global::VillageNewbiesApp.Properties.Resources.RaportitIcon;
            this.btnRaportit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRaportit.Location = new System.Drawing.Point(0, 414);
            this.btnRaportit.Name = "btnRaportit";
            this.btnRaportit.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnRaportit.Size = new System.Drawing.Size(186, 45);
            this.btnRaportit.TabIndex = 2;
            this.btnRaportit.Text = "Raportit";
            this.btnRaportit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRaportit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRaportit.UseVisualStyleBackColor = true;
            this.btnRaportit.Click += new System.EventHandler(this.btnAlueet_Click);
            // 
            // btnLaskutus
            // 
            this.btnLaskutus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLaskutus.Enabled = false;
            this.btnLaskutus.FlatAppearance.BorderSize = 0;
            this.btnLaskutus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaskutus.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaskutus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.btnLaskutus.Image = global::VillageNewbiesApp.Properties.Resources.LaskutusIcon;
            this.btnLaskutus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLaskutus.Location = new System.Drawing.Point(0, 369);
            this.btnLaskutus.Name = "btnLaskutus";
            this.btnLaskutus.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnLaskutus.Size = new System.Drawing.Size(186, 45);
            this.btnLaskutus.TabIndex = 2;
            this.btnLaskutus.Text = "Laskutus";
            this.btnLaskutus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaskutus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLaskutus.UseVisualStyleBackColor = true;
            this.btnLaskutus.Click += new System.EventHandler(this.btnAlueet_Click);
            // 
            // btnAsiakkaat
            // 
            this.btnAsiakkaat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsiakkaat.Enabled = false;
            this.btnAsiakkaat.FlatAppearance.BorderSize = 0;
            this.btnAsiakkaat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsiakkaat.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsiakkaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.btnAsiakkaat.Image = global::VillageNewbiesApp.Properties.Resources.AsiakkaatIcon;
            this.btnAsiakkaat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsiakkaat.Location = new System.Drawing.Point(0, 189);
            this.btnAsiakkaat.Name = "btnAsiakkaat";
            this.btnAsiakkaat.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAsiakkaat.Size = new System.Drawing.Size(186, 45);
            this.btnAsiakkaat.TabIndex = 2;
            this.btnAsiakkaat.Text = "Asiakkaat";
            this.btnAsiakkaat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsiakkaat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAsiakkaat.UseVisualStyleBackColor = true;
            this.btnAsiakkaat.Click += new System.EventHandler(this.btnAlueet_Click);
            // 
            // btnVaraukset
            // 
            this.btnVaraukset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVaraukset.Enabled = false;
            this.btnVaraukset.FlatAppearance.BorderSize = 0;
            this.btnVaraukset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaraukset.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaraukset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.btnVaraukset.Image = global::VillageNewbiesApp.Properties.Resources.VarauksetIcon;
            this.btnVaraukset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVaraukset.Location = new System.Drawing.Point(0, 324);
            this.btnVaraukset.Name = "btnVaraukset";
            this.btnVaraukset.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnVaraukset.Size = new System.Drawing.Size(186, 45);
            this.btnVaraukset.TabIndex = 2;
            this.btnVaraukset.Text = "Varaukset";
            this.btnVaraukset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVaraukset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVaraukset.UseVisualStyleBackColor = true;
            this.btnVaraukset.Click += new System.EventHandler(this.btnAlueet_Click);
            // 
            // btnMokitJaPalvelut
            // 
            this.btnMokitJaPalvelut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMokitJaPalvelut.Enabled = false;
            this.btnMokitJaPalvelut.FlatAppearance.BorderSize = 0;
            this.btnMokitJaPalvelut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMokitJaPalvelut.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMokitJaPalvelut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.btnMokitJaPalvelut.Image = global::VillageNewbiesApp.Properties.Resources.PalvelutIcon;
            this.btnMokitJaPalvelut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMokitJaPalvelut.Location = new System.Drawing.Point(0, 279);
            this.btnMokitJaPalvelut.Name = "btnMokitJaPalvelut";
            this.btnMokitJaPalvelut.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnMokitJaPalvelut.Size = new System.Drawing.Size(186, 45);
            this.btnMokitJaPalvelut.TabIndex = 2;
            this.btnMokitJaPalvelut.Text = "Mökit ja Palvelut";
            this.btnMokitJaPalvelut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMokitJaPalvelut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMokitJaPalvelut.UseVisualStyleBackColor = true;
            this.btnMokitJaPalvelut.Click += new System.EventHandler(this.btnAlueet_Click);
            // 
            // btnToimintaAlueet
            // 
            this.btnToimintaAlueet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnToimintaAlueet.Enabled = false;
            this.btnToimintaAlueet.FlatAppearance.BorderSize = 0;
            this.btnToimintaAlueet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToimintaAlueet.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToimintaAlueet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.btnToimintaAlueet.Image = global::VillageNewbiesApp.Properties.Resources.LocationIcon;
            this.btnToimintaAlueet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnToimintaAlueet.Location = new System.Drawing.Point(0, 234);
            this.btnToimintaAlueet.Name = "btnToimintaAlueet";
            this.btnToimintaAlueet.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnToimintaAlueet.Size = new System.Drawing.Size(186, 45);
            this.btnToimintaAlueet.TabIndex = 2;
            this.btnToimintaAlueet.Text = "Toiminta-alueet";
            this.btnToimintaAlueet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToimintaAlueet.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnToimintaAlueet.UseVisualStyleBackColor = true;
            this.btnToimintaAlueet.Click += new System.EventHandler(this.btnAlueet_Click);
            // 
            // btnEtusivu
            // 
            this.btnEtusivu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEtusivu.FlatAppearance.BorderSize = 0;
            this.btnEtusivu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEtusivu.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEtusivu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.btnEtusivu.Image = global::VillageNewbiesApp.Properties.Resources.EtusivuIcon;
            this.btnEtusivu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEtusivu.Location = new System.Drawing.Point(0, 144);
            this.btnEtusivu.Name = "btnEtusivu";
            this.btnEtusivu.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnEtusivu.Size = new System.Drawing.Size(186, 45);
            this.btnEtusivu.TabIndex = 3;
            this.btnEtusivu.Text = "Etusivu";
            this.btnEtusivu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEtusivu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEtusivu.UseVisualStyleBackColor = true;
            this.btnEtusivu.Click += new System.EventHandler(this.btnAlueet_Click);
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.Controls.Add(this.pictureBox2);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(186, 144);
            this.panelTopLeft.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VillageNewbiesApp.Properties.Resources.VillageNewbiesLogo;
            this.pictureBox2.Location = new System.Drawing.Point(10, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(166, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelFormLoader
            // 
            this.panelFormLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFormLoader.Location = new System.Drawing.Point(186, 100);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Size = new System.Drawing.Size(765, 477);
            this.panelFormLoader.TabIndex = 1;
            // 
            // lblOtsikko
            // 
            this.lblOtsikko.AutoSize = true;
            this.lblOtsikko.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtsikko.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lblOtsikko.Location = new System.Drawing.Point(222, 32);
            this.lblOtsikko.Name = "lblOtsikko";
            this.lblOtsikko.Size = new System.Drawing.Size(221, 37);
            this.lblOtsikko.TabIndex = 0;
            this.lblOtsikko.Text = "Toiminta-alueet";
            // 
            // pbExit
            // 
            this.pbExit.Image = global::VillageNewbiesApp.Properties.Resources.exit25x25;
            this.pbExit.Location = new System.Drawing.Point(914, 12);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(25, 25);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbExit.TabIndex = 5;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            this.pbExit.MouseEnter += new System.EventHandler(this.pbMinimize_MouseEnter);
            this.pbExit.MouseLeave += new System.EventHandler(this.pbMinimize_MouseLeave);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Image = global::VillageNewbiesApp.Properties.Resources.minimize25x251;
            this.pbMinimize.Location = new System.Drawing.Point(883, 12);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(25, 25);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMinimize.TabIndex = 0;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            this.pbMinimize.MouseEnter += new System.EventHandler(this.pbMinimize_MouseEnter);
            this.pbMinimize.MouseLeave += new System.EventHandler(this.pbMinimize_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.lblOtsikko);
            this.Controls.Add(this.panelFormLoader);
            this.Controls.Add(this.pbMinimize);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(20, 17);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTopLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnEtusivu;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panelFormLoader;
        public System.Windows.Forms.Panel panelNavigation;
        public System.Windows.Forms.Label lblOtsikko;
        public System.Windows.Forms.Button btnToimintaAlueet;
        public System.Windows.Forms.Button btnKirjauduSisaan;
        public System.Windows.Forms.Button btnRaportit;
        public System.Windows.Forms.Button btnLaskutus;
        public System.Windows.Forms.Button btnAsiakkaat;
        public System.Windows.Forms.Button btnVaraukset;
        public System.Windows.Forms.Button btnMokitJaPalvelut;
        public System.Windows.Forms.Button btnKirjauduUlos;
    }
}

