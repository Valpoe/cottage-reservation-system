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
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.panelFormLoader = new System.Windows.Forms.Panel();
            this.labelOtsikko = new System.Windows.Forms.Label();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbMaximize = new System.Windows.Forms.PictureBox();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRaportit = new System.Windows.Forms.Button();
            this.btnLaskut = new System.Windows.Forms.Button();
            this.btnAsiakkaat = new System.Windows.Forms.Button();
            this.btnVaraukset = new System.Windows.Forms.Button();
            this.btnPalvelut = new System.Windows.Forms.Button();
            this.btnAlueet = new System.Windows.Forms.Button();
            this.btnEtusivu = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelLeft.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelLeft.Controls.Add(this.pictureBox1);
            this.panelLeft.Controls.Add(this.panelNavigation);
            this.panelLeft.Controls.Add(this.btnRaportit);
            this.panelLeft.Controls.Add(this.btnLaskut);
            this.panelLeft.Controls.Add(this.btnAsiakkaat);
            this.panelLeft.Controls.Add(this.btnVaraukset);
            this.panelLeft.Controls.Add(this.btnPalvelut);
            this.panelLeft.Controls.Add(this.btnAlueet);
            this.panelLeft.Controls.Add(this.btnEtusivu);
            this.panelLeft.Controls.Add(this.panelTopLeft);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(186, 577);
            this.panelLeft.TabIndex = 0;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panelNavigation.Location = new System.Drawing.Point(0, 193);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(3, 100);
            this.panelNavigation.TabIndex = 1;
            this.panelNavigation.Visible = false;
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
            // panelFormLoader
            // 
            this.panelFormLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFormLoader.Location = new System.Drawing.Point(186, 100);
            this.panelFormLoader.Name = "panelFormLoader";
            this.panelFormLoader.Size = new System.Drawing.Size(765, 477);
            this.panelFormLoader.TabIndex = 1;
            // 
            // labelOtsikko
            // 
            this.labelOtsikko.AutoSize = true;
            this.labelOtsikko.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtsikko.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.labelOtsikko.Location = new System.Drawing.Point(222, 32);
            this.labelOtsikko.Name = "labelOtsikko";
            this.labelOtsikko.Size = new System.Drawing.Size(221, 37);
            this.labelOtsikko.TabIndex = 0;
            this.labelOtsikko.Text = "Toiminta-alueet";
            this.labelOtsikko.Visible = false;
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
            // pbMaximize
            // 
            this.pbMaximize.Image = global::VillageNewbiesApp.Properties.Resources.maximize25x25;
            this.pbMaximize.Location = new System.Drawing.Point(883, 12);
            this.pbMaximize.Name = "pbMaximize";
            this.pbMaximize.Size = new System.Drawing.Size(25, 25);
            this.pbMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMaximize.TabIndex = 4;
            this.pbMaximize.TabStop = false;
            this.pbMaximize.Click += new System.EventHandler(this.pbMaximize_Click);
            this.pbMaximize.MouseEnter += new System.EventHandler(this.pbMinimize_MouseEnter);
            this.pbMaximize.MouseLeave += new System.EventHandler(this.pbMinimize_MouseLeave);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Image = global::VillageNewbiesApp.Properties.Resources.minimize25x251;
            this.pbMinimize.Location = new System.Drawing.Point(852, 12);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(25, 25);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbMinimize.TabIndex = 0;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            this.pbMinimize.MouseEnter += new System.EventHandler(this.pbMinimize_MouseEnter);
            this.pbMinimize.MouseLeave += new System.EventHandler(this.pbMinimize_MouseLeave);
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
            // btnRaportit
            // 
            this.btnRaportit.Dock = System.Windows.Forms.DockStyle.Top;
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
            // btnLaskut
            // 
            this.btnLaskut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLaskut.FlatAppearance.BorderSize = 0;
            this.btnLaskut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaskut.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaskut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.btnLaskut.Image = global::VillageNewbiesApp.Properties.Resources.LaskutusIcon;
            this.btnLaskut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLaskut.Location = new System.Drawing.Point(0, 369);
            this.btnLaskut.Name = "btnLaskut";
            this.btnLaskut.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnLaskut.Size = new System.Drawing.Size(186, 45);
            this.btnLaskut.TabIndex = 2;
            this.btnLaskut.Text = "Laskutus";
            this.btnLaskut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaskut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLaskut.UseVisualStyleBackColor = true;
            this.btnLaskut.Click += new System.EventHandler(this.btnAlueet_Click);
            // 
            // btnAsiakkaat
            // 
            this.btnAsiakkaat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsiakkaat.FlatAppearance.BorderSize = 0;
            this.btnAsiakkaat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsiakkaat.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsiakkaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.btnAsiakkaat.Image = global::VillageNewbiesApp.Properties.Resources.AsiakkaatIcon;
            this.btnAsiakkaat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsiakkaat.Location = new System.Drawing.Point(0, 324);
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
            this.btnVaraukset.FlatAppearance.BorderSize = 0;
            this.btnVaraukset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaraukset.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaraukset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.btnVaraukset.Image = global::VillageNewbiesApp.Properties.Resources.VarauksetIcon;
            this.btnVaraukset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVaraukset.Location = new System.Drawing.Point(0, 279);
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
            // btnPalvelut
            // 
            this.btnPalvelut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPalvelut.FlatAppearance.BorderSize = 0;
            this.btnPalvelut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPalvelut.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPalvelut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.btnPalvelut.Image = global::VillageNewbiesApp.Properties.Resources.PalvelutIcon;
            this.btnPalvelut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPalvelut.Location = new System.Drawing.Point(0, 234);
            this.btnPalvelut.Name = "btnPalvelut";
            this.btnPalvelut.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnPalvelut.Size = new System.Drawing.Size(186, 45);
            this.btnPalvelut.TabIndex = 2;
            this.btnPalvelut.Text = "Palvelut";
            this.btnPalvelut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPalvelut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPalvelut.UseVisualStyleBackColor = true;
            this.btnPalvelut.Click += new System.EventHandler(this.btnAlueet_Click);
            // 
            // btnAlueet
            // 
            this.btnAlueet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlueet.FlatAppearance.BorderSize = 0;
            this.btnAlueet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlueet.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlueet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.btnAlueet.Image = global::VillageNewbiesApp.Properties.Resources.LocationIcon;
            this.btnAlueet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlueet.Location = new System.Drawing.Point(0, 189);
            this.btnAlueet.Name = "btnAlueet";
            this.btnAlueet.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAlueet.Size = new System.Drawing.Size(186, 45);
            this.btnAlueet.TabIndex = 2;
            this.btnAlueet.Text = "Toiminta-alueet";
            this.btnAlueet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlueet.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlueet.UseVisualStyleBackColor = true;
            this.btnAlueet.Click += new System.EventHandler(this.btnAlueet_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.labelOtsikko);
            this.Controls.Add(this.pbMaximize);
            this.Controls.Add(this.panelFormLoader);
            this.Controls.Add(this.pbMinimize);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(20, 17);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panelLeft.ResumeLayout(false);
            this.panelTopLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.Button btnAlueet;
        private System.Windows.Forms.Button btnRaportit;
        private System.Windows.Forms.Button btnLaskut;
        private System.Windows.Forms.Button btnAsiakkaat;
        private System.Windows.Forms.Button btnVaraukset;
        private System.Windows.Forms.Button btnPalvelut;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelFormLoader;
        private System.Windows.Forms.Label labelOtsikko;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbMaximize;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnEtusivu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

