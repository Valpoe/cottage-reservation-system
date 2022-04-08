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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btnRaportit = new System.Windows.Forms.Button();
            this.btnLaskut = new System.Windows.Forms.Button();
            this.btnAsiakkaat = new System.Windows.Forms.Button();
            this.btnVaraukset = new System.Windows.Forms.Button();
            this.btnPalvelut = new System.Windows.Forms.Button();
            this.btnAlueet = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbVillageNewbies = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelOtsikko = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.panelNavigation);
            this.panel1.Controls.Add(this.btnRaportit);
            this.panel1.Controls.Add(this.btnLaskut);
            this.panel1.Controls.Add(this.btnAsiakkaat);
            this.panel1.Controls.Add(this.btnVaraukset);
            this.panel1.Controls.Add(this.btnPalvelut);
            this.panel1.Controls.Add(this.btnAlueet);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 888);
            this.panel1.TabIndex = 0;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.panelNavigation.Location = new System.Drawing.Point(0, 297);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(4, 154);
            this.panelNavigation.TabIndex = 1;
            this.panelNavigation.Visible = false;
            // 
            // btnRaportit
            // 
            this.btnRaportit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRaportit.FlatAppearance.BorderSize = 0;
            this.btnRaportit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaportit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaportit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.btnRaportit.Image = global::VillageNewbiesApp.Properties.Resources.Raportit35x35;
            this.btnRaportit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRaportit.Location = new System.Drawing.Point(0, 567);
            this.btnRaportit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRaportit.Name = "btnRaportit";
            this.btnRaportit.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnRaportit.Size = new System.Drawing.Size(279, 69);
            this.btnRaportit.TabIndex = 2;
            this.btnRaportit.Text = "Raportit";
            this.btnRaportit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRaportit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRaportit.UseVisualStyleBackColor = true;
            this.btnRaportit.Click += new System.EventHandler(this.btnAlueet_Click);
            this.btnRaportit.Leave += new System.EventHandler(this.btnAlueet_Leave);
            // 
            // btnLaskut
            // 
            this.btnLaskut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLaskut.FlatAppearance.BorderSize = 0;
            this.btnLaskut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLaskut.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaskut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.btnLaskut.Image = global::VillageNewbiesApp.Properties.Resources.Laskut35x35;
            this.btnLaskut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLaskut.Location = new System.Drawing.Point(0, 498);
            this.btnLaskut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLaskut.Name = "btnLaskut";
            this.btnLaskut.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnLaskut.Size = new System.Drawing.Size(279, 69);
            this.btnLaskut.TabIndex = 2;
            this.btnLaskut.Text = "Laskut";
            this.btnLaskut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaskut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLaskut.UseVisualStyleBackColor = true;
            this.btnLaskut.Click += new System.EventHandler(this.btnAlueet_Click);
            this.btnLaskut.Leave += new System.EventHandler(this.btnAlueet_Leave);
            // 
            // btnAsiakkaat
            // 
            this.btnAsiakkaat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAsiakkaat.FlatAppearance.BorderSize = 0;
            this.btnAsiakkaat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsiakkaat.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsiakkaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.btnAsiakkaat.Image = global::VillageNewbiesApp.Properties.Resources.Asiakkaat35x35;
            this.btnAsiakkaat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsiakkaat.Location = new System.Drawing.Point(0, 429);
            this.btnAsiakkaat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAsiakkaat.Name = "btnAsiakkaat";
            this.btnAsiakkaat.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnAsiakkaat.Size = new System.Drawing.Size(279, 69);
            this.btnAsiakkaat.TabIndex = 2;
            this.btnAsiakkaat.Text = "Asiakkaat";
            this.btnAsiakkaat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsiakkaat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAsiakkaat.UseVisualStyleBackColor = true;
            this.btnAsiakkaat.Click += new System.EventHandler(this.btnAlueet_Click);
            this.btnAsiakkaat.Leave += new System.EventHandler(this.btnAlueet_Leave);
            // 
            // btnVaraukset
            // 
            this.btnVaraukset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVaraukset.FlatAppearance.BorderSize = 0;
            this.btnVaraukset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaraukset.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaraukset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.btnVaraukset.Image = global::VillageNewbiesApp.Properties.Resources.Varaukset35x35;
            this.btnVaraukset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVaraukset.Location = new System.Drawing.Point(0, 360);
            this.btnVaraukset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVaraukset.Name = "btnVaraukset";
            this.btnVaraukset.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnVaraukset.Size = new System.Drawing.Size(279, 69);
            this.btnVaraukset.TabIndex = 2;
            this.btnVaraukset.Text = "Varaukset";
            this.btnVaraukset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVaraukset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVaraukset.UseVisualStyleBackColor = true;
            this.btnVaraukset.Click += new System.EventHandler(this.btnAlueet_Click);
            this.btnVaraukset.Leave += new System.EventHandler(this.btnAlueet_Leave);
            // 
            // btnPalvelut
            // 
            this.btnPalvelut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPalvelut.FlatAppearance.BorderSize = 0;
            this.btnPalvelut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPalvelut.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPalvelut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.btnPalvelut.Image = global::VillageNewbiesApp.Properties.Resources.Palvelut35x35;
            this.btnPalvelut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPalvelut.Location = new System.Drawing.Point(0, 291);
            this.btnPalvelut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPalvelut.Name = "btnPalvelut";
            this.btnPalvelut.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnPalvelut.Size = new System.Drawing.Size(279, 69);
            this.btnPalvelut.TabIndex = 2;
            this.btnPalvelut.Text = "Palvelut";
            this.btnPalvelut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPalvelut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPalvelut.UseVisualStyleBackColor = true;
            this.btnPalvelut.Click += new System.EventHandler(this.btnAlueet_Click);
            this.btnPalvelut.Leave += new System.EventHandler(this.btnAlueet_Leave);
            // 
            // btnAlueet
            // 
            this.btnAlueet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlueet.FlatAppearance.BorderSize = 0;
            this.btnAlueet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlueet.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlueet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.btnAlueet.Image = global::VillageNewbiesApp.Properties.Resources.Loc35x35;
            this.btnAlueet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlueet.Location = new System.Drawing.Point(0, 222);
            this.btnAlueet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlueet.Name = "btnAlueet";
            this.btnAlueet.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnAlueet.Size = new System.Drawing.Size(279, 69);
            this.btnAlueet.TabIndex = 2;
            this.btnAlueet.Text = "Toiminta-alueet";
            this.btnAlueet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlueet.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAlueet.UseVisualStyleBackColor = true;
            this.btnAlueet.Click += new System.EventHandler(this.btnAlueet_Click);
            this.btnAlueet.Leave += new System.EventHandler(this.btnAlueet_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbVillageNewbies);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 222);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::VillageNewbiesApp.Properties.Resources.Home;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(16, 122);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbVillageNewbies
            // 
            this.lbVillageNewbies.AutoSize = true;
            this.lbVillageNewbies.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVillageNewbies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lbVillageNewbies.Location = new System.Drawing.Point(54, 14);
            this.lbVillageNewbies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVillageNewbies.Name = "lbVillageNewbies";
            this.lbVillageNewbies.Size = new System.Drawing.Size(162, 80);
            this.lbVillageNewbies.TabIndex = 0;
            this.lbVillageNewbies.Text = "Village\r\nNewbies";
            this.lbVillageNewbies.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.DimGray;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(279, 68);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1147, 820);
            this.mainPanel.TabIndex = 1;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMinimize.Location = new System.Drawing.Point(711, 14);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "x";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMaximize.Location = new System.Drawing.Point(855, 14);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.Text = "x";
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(953, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelOtsikko
            // 
            this.labelOtsikko.AutoSize = true;
            this.labelOtsikko.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOtsikko.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.labelOtsikko.Location = new System.Drawing.Point(8, 9);
            this.labelOtsikko.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOtsikko.Name = "labelOtsikko";
            this.labelOtsikko.Size = new System.Drawing.Size(320, 54);
            this.labelOtsikko.TabIndex = 0;
            this.labelOtsikko.Text = "Toiminta-alueet";
            this.labelOtsikko.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.btnMinimize);
            this.panel3.Controls.Add(this.labelOtsikko);
            this.panel3.Controls.Add(this.btnMaximize);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Location = new System.Drawing.Point(279, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1147, 68);
            this.panel3.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1426, 888);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(20, 17);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbVillageNewbies;
        private System.Windows.Forms.Button btnAlueet;
        private System.Windows.Forms.Button btnRaportit;
        private System.Windows.Forms.Button btnLaskut;
        private System.Windows.Forms.Button btnAsiakkaat;
        private System.Windows.Forms.Button btnVaraukset;
        private System.Windows.Forms.Button btnPalvelut;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label labelOtsikko;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
    }
}

