namespace VillageNewbiesApp
{
    partial class frmEtusivu
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
            this.components = new System.ComponentModel.Container();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelAsiakkaat = new System.Windows.Forms.Panel();
            this.lblAsiakasTotal = new System.Windows.Forms.Label();
            this.lblAsiakkaat = new System.Windows.Forms.Label();
            this.panelVaraukset = new System.Windows.Forms.Panel();
            this.lblVarausTotal = new System.Windows.Forms.Label();
            this.lblVaraukset = new System.Windows.Forms.Label();
            this.panelPalvelut = new System.Windows.Forms.Panel();
            this.lblPalvelutTotal = new System.Windows.Forms.Label();
            this.lblPalvelut = new System.Windows.Forms.Label();
            this.panelMokit = new System.Windows.Forms.Panel();
            this.lblMokkiTotal = new System.Windows.Forms.Label();
            this.lblMokit = new System.Windows.Forms.Label();
            this.btnRefresh = new MaterialSkin.Controls.MaterialButton();
            this.btnOhjeet = new MaterialSkin.Controls.MaterialButton();
            this.lblKokonaisMaarat = new System.Windows.Forms.Label();
            this.cpbVarausaste = new CircularProgressBar.CircularProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelAsiakkaat.SuspendLayout();
            this.panelVaraukset.SuspendLayout();
            this.panelPalvelut.SuspendLayout();
            this.panelMokit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialDrawer1
            // 
            this.materialDrawer1.AutoHide = false;
            this.materialDrawer1.AutoShow = false;
            this.materialDrawer1.BackgroundWithAccent = false;
            this.materialDrawer1.BaseTabControl = null;
            this.materialDrawer1.Depth = 0;
            this.materialDrawer1.HighlightWithAccent = true;
            this.materialDrawer1.IndicatorWidth = 0;
            this.materialDrawer1.IsOpen = false;
            this.materialDrawer1.Location = new System.Drawing.Point(-8, 148);
            this.materialDrawer1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDrawer1.Name = "materialDrawer1";
            this.materialDrawer1.ShowIconsWhenHidden = false;
            this.materialDrawer1.Size = new System.Drawing.Size(8, 8);
            this.materialDrawer1.TabIndex = 7;
            this.materialDrawer1.Text = "materialDrawer1";
            this.materialDrawer1.UseColors = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panelAsiakkaat, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelVaraukset, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelPalvelut, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelMokit, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(411, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 76);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // panelAsiakkaat
            // 
            this.panelAsiakkaat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelAsiakkaat.Controls.Add(this.lblAsiakasTotal);
            this.panelAsiakkaat.Controls.Add(this.lblAsiakkaat);
            this.panelAsiakkaat.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAsiakkaat.Location = new System.Drawing.Point(246, 0);
            this.panelAsiakkaat.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.panelAsiakkaat.Name = "panelAsiakkaat";
            this.panelAsiakkaat.Size = new System.Drawing.Size(76, 71);
            this.panelAsiakkaat.TabIndex = 1;
            // 
            // lblAsiakasTotal
            // 
            this.lblAsiakasTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiakasTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lblAsiakasTotal.Location = new System.Drawing.Point(0, 20);
            this.lblAsiakasTotal.Name = "lblAsiakasTotal";
            this.lblAsiakasTotal.Size = new System.Drawing.Size(76, 40);
            this.lblAsiakasTotal.TabIndex = 4;
            this.lblAsiakasTotal.Text = "23";
            this.lblAsiakasTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAsiakkaat
            // 
            this.lblAsiakkaat.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiakkaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lblAsiakkaat.Location = new System.Drawing.Point(0, 0);
            this.lblAsiakkaat.Name = "lblAsiakkaat";
            this.lblAsiakkaat.Size = new System.Drawing.Size(76, 22);
            this.lblAsiakkaat.TabIndex = 3;
            this.lblAsiakkaat.Text = "Asiakkaat";
            this.lblAsiakkaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelVaraukset
            // 
            this.panelVaraukset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelVaraukset.Controls.Add(this.lblVarausTotal);
            this.panelVaraukset.Controls.Add(this.lblVaraukset);
            this.panelVaraukset.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelVaraukset.Location = new System.Drawing.Point(0, 0);
            this.panelVaraukset.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.panelVaraukset.Name = "panelVaraukset";
            this.panelVaraukset.Size = new System.Drawing.Size(77, 71);
            this.panelVaraukset.TabIndex = 0;
            // 
            // lblVarausTotal
            // 
            this.lblVarausTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarausTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lblVarausTotal.Location = new System.Drawing.Point(0, 20);
            this.lblVarausTotal.Name = "lblVarausTotal";
            this.lblVarausTotal.Size = new System.Drawing.Size(79, 40);
            this.lblVarausTotal.TabIndex = 1;
            this.lblVarausTotal.Text = "23";
            this.lblVarausTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVaraukset
            // 
            this.lblVaraukset.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaraukset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lblVaraukset.Location = new System.Drawing.Point(0, 0);
            this.lblVaraukset.Name = "lblVaraukset";
            this.lblVaraukset.Size = new System.Drawing.Size(79, 22);
            this.lblVaraukset.TabIndex = 0;
            this.lblVaraukset.Text = "Varaukset";
            this.lblVaraukset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPalvelut
            // 
            this.panelPalvelut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelPalvelut.Controls.Add(this.lblPalvelutTotal);
            this.panelPalvelut.Controls.Add(this.lblPalvelut);
            this.panelPalvelut.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPalvelut.Location = new System.Drawing.Point(164, 0);
            this.panelPalvelut.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.panelPalvelut.Name = "panelPalvelut";
            this.panelPalvelut.Size = new System.Drawing.Size(76, 71);
            this.panelPalvelut.TabIndex = 1;
            // 
            // lblPalvelutTotal
            // 
            this.lblPalvelutTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalvelutTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lblPalvelutTotal.Location = new System.Drawing.Point(0, 20);
            this.lblPalvelutTotal.Name = "lblPalvelutTotal";
            this.lblPalvelutTotal.Size = new System.Drawing.Size(76, 40);
            this.lblPalvelutTotal.TabIndex = 3;
            this.lblPalvelutTotal.Text = "23";
            this.lblPalvelutTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPalvelut
            // 
            this.lblPalvelut.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalvelut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lblPalvelut.Location = new System.Drawing.Point(0, 0);
            this.lblPalvelut.Name = "lblPalvelut";
            this.lblPalvelut.Size = new System.Drawing.Size(76, 22);
            this.lblPalvelut.TabIndex = 2;
            this.lblPalvelut.Text = "Palvelut";
            this.lblPalvelut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMokit
            // 
            this.panelMokit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelMokit.Controls.Add(this.lblMokkiTotal);
            this.panelMokit.Controls.Add(this.lblMokit);
            this.panelMokit.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMokit.Location = new System.Drawing.Point(82, 0);
            this.panelMokit.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.panelMokit.Name = "panelMokit";
            this.panelMokit.Size = new System.Drawing.Size(76, 71);
            this.panelMokit.TabIndex = 1;
            // 
            // lblMokkiTotal
            // 
            this.lblMokkiTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMokkiTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lblMokkiTotal.Location = new System.Drawing.Point(0, 20);
            this.lblMokkiTotal.Name = "lblMokkiTotal";
            this.lblMokkiTotal.Size = new System.Drawing.Size(76, 40);
            this.lblMokkiTotal.TabIndex = 2;
            this.lblMokkiTotal.Text = "23";
            this.lblMokkiTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMokit
            // 
            this.lblMokit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMokit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lblMokit.Location = new System.Drawing.Point(-1, 0);
            this.lblMokit.Name = "lblMokit";
            this.lblMokit.Size = new System.Drawing.Size(77, 22);
            this.lblMokit.TabIndex = 1;
            this.lblMokit.Text = "Mökit";
            this.lblMokit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoSize = false;
            this.btnRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRefresh.Depth = 0;
            this.btnRefresh.HighEmphasis = true;
            this.btnRefresh.Icon = null;
            this.btnRefresh.Location = new System.Drawing.Point(13, 80);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRefresh.Size = new System.Drawing.Size(158, 36);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Päivitä";
            this.btnRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRefresh.UseAccentColor = false;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOhjeet
            // 
            this.btnOhjeet.AutoSize = false;
            this.btnOhjeet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOhjeet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnOhjeet.Depth = 0;
            this.btnOhjeet.HighEmphasis = true;
            this.btnOhjeet.Icon = null;
            this.btnOhjeet.Location = new System.Drawing.Point(215, 80);
            this.btnOhjeet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOhjeet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOhjeet.Name = "btnOhjeet";
            this.btnOhjeet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnOhjeet.Size = new System.Drawing.Size(158, 36);
            this.btnOhjeet.TabIndex = 15;
            this.btnOhjeet.Text = "Ohjeet";
            this.btnOhjeet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnOhjeet.UseAccentColor = false;
            this.btnOhjeet.UseVisualStyleBackColor = true;
            this.btnOhjeet.Click += new System.EventHandler(this.btnOhjeet_Click);
            // 
            // lblKokonaisMaarat
            // 
            this.lblKokonaisMaarat.AutoSize = true;
            this.lblKokonaisMaarat.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKokonaisMaarat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lblKokonaisMaarat.Location = new System.Drawing.Point(499, 69);
            this.lblKokonaisMaarat.Name = "lblKokonaisMaarat";
            this.lblKokonaisMaarat.Size = new System.Drawing.Size(147, 25);
            this.lblKokonaisMaarat.TabIndex = 16;
            this.lblKokonaisMaarat.Text = "Kokonaismäärät";
            // 
            // cpbVarausaste
            // 
            this.cpbVarausaste.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.cpbVarausaste.AnimationSpeed = 500;
            this.cpbVarausaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cpbVarausaste.Font = new System.Drawing.Font("Nirmala UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpbVarausaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.cpbVarausaste.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.cpbVarausaste.InnerMargin = 0;
            this.cpbVarausaste.InnerWidth = -1;
            this.cpbVarausaste.Location = new System.Drawing.Point(462, 237);
            this.cpbVarausaste.MarqueeAnimationSpeed = 2000;
            this.cpbVarausaste.Name = "cpbVarausaste";
            this.cpbVarausaste.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.cpbVarausaste.OuterMargin = -26;
            this.cpbVarausaste.OuterWidth = 26;
            this.cpbVarausaste.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.cpbVarausaste.ProgressWidth = 25;
            this.cpbVarausaste.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.cpbVarausaste.Size = new System.Drawing.Size(220, 220);
            this.cpbVarausaste.StartAngle = 270;
            this.cpbVarausaste.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.cpbVarausaste.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbVarausaste.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbVarausaste.SubscriptText = "";
            this.cpbVarausaste.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbVarausaste.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbVarausaste.SuperscriptText = "";
            this.cpbVarausaste.TabIndex = 18;
            this.cpbVarausaste.Text = "78%";
            this.cpbVarausaste.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbVarausaste.Value = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(499, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "30pv varausaste";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.label2.Location = new System.Drawing.Point(30, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(612, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tervetuloa Village Newbies Oy:n varaus- ja asiakashallintajärjestelmään";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VillageNewbiesApp.Properties.Resources.pngfind_com_house_outline_png_849481;
            this.pictureBox1.Location = new System.Drawing.Point(17, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(362, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(46, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 45);
            this.panel1.TabIndex = 23;
            // 
            // frmEtusivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 477);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblKokonaisMaarat);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cpbVarausaste);
            this.Controls.Add(this.btnOhjeet);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.materialDrawer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEtusivu";
            this.Text = "frmKoti";
            this.Load += new System.EventHandler(this.frmEtusivu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelAsiakkaat.ResumeLayout(false);
            this.panelVaraukset.ResumeLayout(false);
            this.panelPalvelut.ResumeLayout(false);
            this.panelMokit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelVaraukset;
        private System.Windows.Forms.Panel panelAsiakkaat;
        private System.Windows.Forms.Panel panelPalvelut;
        private System.Windows.Forms.Panel panelMokit;
        private System.Windows.Forms.Label lblAsiakasTotal;
        private System.Windows.Forms.Label lblAsiakkaat;
        private System.Windows.Forms.Label lblVarausTotal;
        private System.Windows.Forms.Label lblVaraukset;
        private System.Windows.Forms.Label lblPalvelutTotal;
        private System.Windows.Forms.Label lblPalvelut;
        private System.Windows.Forms.Label lblMokkiTotal;
        private System.Windows.Forms.Label lblMokit;
        private MaterialSkin.Controls.MaterialButton btnRefresh;
        private MaterialSkin.Controls.MaterialButton btnOhjeet;
        private System.Windows.Forms.Label lblKokonaisMaarat;
        private CircularProgressBar.CircularProgressBar cpbVarausaste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}