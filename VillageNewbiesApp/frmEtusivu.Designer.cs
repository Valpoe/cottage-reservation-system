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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.materialDrawer1 = new MaterialSkin.Controls.MaterialDrawer();
            this.lblAika = new System.Windows.Forms.Label();
            this.lblPaivays = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
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
            this.flpChart = new System.Windows.Forms.FlowLayoutPanel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelAsiakkaat.SuspendLayout();
            this.panelVaraukset.SuspendLayout();
            this.panelPalvelut.SuspendLayout();
            this.panelMokit.SuspendLayout();
            this.flpChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            // lblAika
            // 
            this.lblAika.AutoSize = true;
            this.lblAika.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAika.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lblAika.Location = new System.Drawing.Point(58, 9);
            this.lblAika.Name = "lblAika";
            this.lblAika.Size = new System.Drawing.Size(51, 22);
            this.lblAika.TabIndex = 8;
            this.lblAika.Text = "Aika";
            // 
            // lblPaivays
            // 
            this.lblPaivays.AutoSize = true;
            this.lblPaivays.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaivays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.lblPaivays.Location = new System.Drawing.Point(58, 38);
            this.lblPaivays.Name = "lblPaivays";
            this.lblPaivays.Size = new System.Drawing.Size(81, 22);
            this.lblPaivays.TabIndex = 9;
            this.lblPaivays.Text = "Päiväys";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VillageNewbiesApp.Properties.Resources.clock;
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.materialLabel1.Location = new System.Drawing.Point(14, 79);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(176, 29);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "Kokonaismäärät";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.materialLabel1.UseAccent = true;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 120);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 76);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // panelAsiakkaat
            // 
            this.panelAsiakkaat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
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
            this.lblAsiakasTotal.Location = new System.Drawing.Point(0, 20);
            this.lblAsiakasTotal.Name = "lblAsiakasTotal";
            this.lblAsiakasTotal.Size = new System.Drawing.Size(76, 40);
            this.lblAsiakasTotal.TabIndex = 4;
            this.lblAsiakasTotal.Text = "23";
            this.lblAsiakasTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAsiakkaat
            // 
            this.lblAsiakkaat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsiakkaat.Location = new System.Drawing.Point(0, 0);
            this.lblAsiakkaat.Name = "lblAsiakkaat";
            this.lblAsiakkaat.Size = new System.Drawing.Size(76, 22);
            this.lblAsiakkaat.TabIndex = 3;
            this.lblAsiakkaat.Text = "Asiakkaat";
            this.lblAsiakkaat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelVaraukset
            // 
            this.panelVaraukset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
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
            this.lblVarausTotal.Location = new System.Drawing.Point(0, 20);
            this.lblVarausTotal.Name = "lblVarausTotal";
            this.lblVarausTotal.Size = new System.Drawing.Size(79, 40);
            this.lblVarausTotal.TabIndex = 1;
            this.lblVarausTotal.Text = "23";
            this.lblVarausTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVaraukset
            // 
            this.lblVaraukset.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaraukset.Location = new System.Drawing.Point(0, 0);
            this.lblVaraukset.Name = "lblVaraukset";
            this.lblVaraukset.Size = new System.Drawing.Size(79, 22);
            this.lblVaraukset.TabIndex = 0;
            this.lblVaraukset.Text = "Varaukset";
            this.lblVaraukset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelPalvelut
            // 
            this.panelPalvelut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
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
            this.lblPalvelutTotal.Location = new System.Drawing.Point(0, 20);
            this.lblPalvelutTotal.Name = "lblPalvelutTotal";
            this.lblPalvelutTotal.Size = new System.Drawing.Size(76, 40);
            this.lblPalvelutTotal.TabIndex = 3;
            this.lblPalvelutTotal.Text = "23";
            this.lblPalvelutTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPalvelut
            // 
            this.lblPalvelut.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalvelut.Location = new System.Drawing.Point(0, 0);
            this.lblPalvelut.Name = "lblPalvelut";
            this.lblPalvelut.Size = new System.Drawing.Size(76, 22);
            this.lblPalvelut.TabIndex = 2;
            this.lblPalvelut.Text = "Palvelut";
            this.lblPalvelut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMokit
            // 
            this.panelMokit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
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
            this.lblMokkiTotal.Location = new System.Drawing.Point(0, 20);
            this.lblMokkiTotal.Name = "lblMokkiTotal";
            this.lblMokkiTotal.Size = new System.Drawing.Size(76, 40);
            this.lblMokkiTotal.TabIndex = 2;
            this.lblMokkiTotal.Text = "23";
            this.lblMokkiTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMokit
            // 
            this.lblMokit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnRefresh.Location = new System.Drawing.Point(594, 15);
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
            // flpChart
            // 
            this.flpChart.Controls.Add(this.chart1);
            this.flpChart.Location = new System.Drawing.Point(12, 219);
            this.flpChart.Name = "flpChart";
            this.flpChart.Size = new System.Drawing.Size(740, 236);
            this.flpChart.TabIndex = 14;
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(0);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Hinta";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(740, 236);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // frmEtusivu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 477);
            this.Controls.Add(this.flpChart);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPaivays);
            this.Controls.Add(this.lblAika);
            this.Controls.Add(this.materialDrawer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEtusivu";
            this.Text = "frmKoti";
            this.Load += new System.EventHandler(this.frmEtusivu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelAsiakkaat.ResumeLayout(false);
            this.panelVaraukset.ResumeLayout(false);
            this.panelPalvelut.ResumeLayout(false);
            this.panelMokit.ResumeLayout(false);
            this.flpChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialDrawer materialDrawer1;
        private System.Windows.Forms.Label lblAika;
        private System.Windows.Forms.Label lblPaivays;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
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
        private System.Windows.Forms.FlowLayoutPanel flpChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}