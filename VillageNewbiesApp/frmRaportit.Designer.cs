namespace VillageNewbiesApp
{
    partial class frmRaportit
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
            this.alueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new VillageNewbiesApp.DataSet1();
            this.mokkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.palveluBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.varausBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.laskuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asiakasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alueTableAdapter1 = new VillageNewbiesApp.DataSet1TableAdapters.alueTableAdapter();
            this.mokkiTableAdapter1 = new VillageNewbiesApp.DataSet1TableAdapters.mokkiTableAdapter();
            this.palveluTableAdapter1 = new VillageNewbiesApp.DataSet1TableAdapters.palveluTableAdapter();
            this.varausTableAdapter1 = new VillageNewbiesApp.DataSet1TableAdapters.varausTableAdapter();
            this.laskuTableAdapter1 = new VillageNewbiesApp.DataSet1TableAdapters.laskuTableAdapter();
            this.asiakasTableAdapter1 = new VillageNewbiesApp.DataSet1TableAdapters.asiakasTableAdapter();
            this.dtpAlkupvm = new System.Windows.Forms.DateTimePicker();
            this.dtpLoppupvm = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEtsi = new MaterialSkin.Controls.MaterialButton();
            this.label3 = new System.Windows.Forms.Label();
            this.mlvMokkiData = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mlvPalveluData = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.btnAvaaRaportti = new MaterialSkin.Controls.MaterialButton();
            this.lbAlueet = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // alueBindingSource
            // 
            this.alueBindingSource.DataMember = "alue";
            this.alueBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mokkiBindingSource
            // 
            this.mokkiBindingSource.DataMember = "mokki";
            this.mokkiBindingSource.DataSource = this.dataSet1;
            // 
            // palveluBindingSource
            // 
            this.palveluBindingSource.DataMember = "palvelu";
            this.palveluBindingSource.DataSource = this.dataSet1;
            // 
            // varausBindingSource
            // 
            this.varausBindingSource.DataMember = "varaus";
            this.varausBindingSource.DataSource = this.dataSet1;
            // 
            // laskuBindingSource
            // 
            this.laskuBindingSource.DataMember = "lasku";
            this.laskuBindingSource.DataSource = this.dataSet1;
            // 
            // asiakasBindingSource
            // 
            this.asiakasBindingSource.DataMember = "asiakas";
            this.asiakasBindingSource.DataSource = this.dataSet1;
            // 
            // alueTableAdapter1
            // 
            this.alueTableAdapter1.ClearBeforeFill = true;
            // 
            // mokkiTableAdapter1
            // 
            this.mokkiTableAdapter1.ClearBeforeFill = true;
            // 
            // palveluTableAdapter1
            // 
            this.palveluTableAdapter1.ClearBeforeFill = true;
            // 
            // varausTableAdapter1
            // 
            this.varausTableAdapter1.ClearBeforeFill = true;
            // 
            // laskuTableAdapter1
            // 
            this.laskuTableAdapter1.ClearBeforeFill = true;
            // 
            // asiakasTableAdapter1
            // 
            this.asiakasTableAdapter1.ClearBeforeFill = true;
            // 
            // dtpAlkupvm
            // 
            this.dtpAlkupvm.CustomFormat = "dd/MM/yyy";
            this.dtpAlkupvm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAlkupvm.Location = new System.Drawing.Point(568, 12);
            this.dtpAlkupvm.Name = "dtpAlkupvm";
            this.dtpAlkupvm.Size = new System.Drawing.Size(166, 20);
            this.dtpAlkupvm.TabIndex = 2;
            // 
            // dtpLoppupvm
            // 
            this.dtpLoppupvm.CustomFormat = "dd/MM/yyyy";
            this.dtpLoppupvm.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLoppupvm.Location = new System.Drawing.Point(568, 59);
            this.dtpLoppupvm.Name = "dtpLoppupvm";
            this.dtpLoppupvm.Size = new System.Drawing.Size(166, 20);
            this.dtpLoppupvm.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(469, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alkupvm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(469, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loppupvm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEtsi
            // 
            this.btnEtsi.AutoSize = false;
            this.btnEtsi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEtsi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEtsi.Depth = 0;
            this.btnEtsi.HighEmphasis = true;
            this.btnEtsi.Icon = null;
            this.btnEtsi.Location = new System.Drawing.Point(568, 301);
            this.btnEtsi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEtsi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEtsi.Name = "btnEtsi";
            this.btnEtsi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnEtsi.Size = new System.Drawing.Size(166, 36);
            this.btnEtsi.TabIndex = 6;
            this.btnEtsi.Text = "Etsi";
            this.btnEtsi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEtsi.UseAccentColor = false;
            this.btnEtsi.UseVisualStyleBackColor = true;
            this.btnEtsi.Click += new System.EventHandler(this.btnEtsi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label3.Location = new System.Drawing.Point(640, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "-";
            // 
            // mlvMokkiData
            // 
            this.mlvMokkiData.AutoSizeTable = false;
            this.mlvMokkiData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlvMokkiData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvMokkiData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader7});
            this.mlvMokkiData.Depth = 0;
            this.mlvMokkiData.FullRowSelect = true;
            this.mlvMokkiData.HideSelection = false;
            this.mlvMokkiData.Location = new System.Drawing.Point(13, 12);
            this.mlvMokkiData.MinimumSize = new System.Drawing.Size(200, 100);
            this.mlvMokkiData.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvMokkiData.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvMokkiData.Name = "mlvMokkiData";
            this.mlvMokkiData.OwnerDraw = true;
            this.mlvMokkiData.Size = new System.Drawing.Size(450, 220);
            this.mlvMokkiData.TabIndex = 8;
            this.mlvMokkiData.UseCompatibleStateImageBehavior = false;
            this.mlvMokkiData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mokki";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Osoite";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Postinro";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Pvm";
            this.columnHeader7.Width = 120;
            // 
            // mlvPalveluData
            // 
            this.mlvPalveluData.AutoSizeTable = false;
            this.mlvPalveluData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlvPalveluData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvPalveluData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8});
            this.mlvPalveluData.Depth = 0;
            this.mlvPalveluData.FullRowSelect = true;
            this.mlvPalveluData.HideSelection = false;
            this.mlvPalveluData.Location = new System.Drawing.Point(13, 245);
            this.mlvPalveluData.MinimumSize = new System.Drawing.Size(200, 100);
            this.mlvPalveluData.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvPalveluData.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvPalveluData.Name = "mlvPalveluData";
            this.mlvPalveluData.OwnerDraw = true;
            this.mlvPalveluData.Size = new System.Drawing.Size(450, 220);
            this.mlvPalveluData.TabIndex = 9;
            this.mlvPalveluData.UseCompatibleStateImageBehavior = false;
            this.mlvPalveluData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Palvelu";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tyyppi";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kuvaus";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Pvm";
            this.columnHeader8.Width = 120;
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox1.TabIndex = 0;
            this.materialCheckbox1.Text = "materialCheckbox1";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.ReadOnly = false;
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox2.TabIndex = 0;
            this.materialCheckbox2.Text = "materialCheckbox2";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox3
            // 
            this.materialCheckbox3.Depth = 0;
            this.materialCheckbox3.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox3.Name = "materialCheckbox3";
            this.materialCheckbox3.ReadOnly = false;
            this.materialCheckbox3.Ripple = true;
            this.materialCheckbox3.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox3.TabIndex = 0;
            this.materialCheckbox3.Text = "materialCheckbox3";
            this.materialCheckbox3.UseVisualStyleBackColor = true;
            // 
            // btnAvaaRaportti
            // 
            this.btnAvaaRaportti.AutoSize = false;
            this.btnAvaaRaportti.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAvaaRaportti.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAvaaRaportti.Depth = 0;
            this.btnAvaaRaportti.HighEmphasis = true;
            this.btnAvaaRaportti.Icon = null;
            this.btnAvaaRaportti.Location = new System.Drawing.Point(518, 426);
            this.btnAvaaRaportti.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAvaaRaportti.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAvaaRaportti.Name = "btnAvaaRaportti";
            this.btnAvaaRaportti.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAvaaRaportti.Size = new System.Drawing.Size(190, 36);
            this.btnAvaaRaportti.TabIndex = 11;
            this.btnAvaaRaportti.Text = "Avaa kokonaisraportti";
            this.btnAvaaRaportti.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAvaaRaportti.UseAccentColor = false;
            this.btnAvaaRaportti.UseVisualStyleBackColor = true;
            this.btnAvaaRaportti.Click += new System.EventHandler(this.btnAvaaRaportti_Click);
            // 
            // lbAlueet
            // 
            this.lbAlueet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbAlueet.FormattingEnabled = true;
            this.lbAlueet.Location = new System.Drawing.Point(568, 107);
            this.lbAlueet.Name = "lbAlueet";
            this.lbAlueet.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbAlueet.Size = new System.Drawing.Size(166, 182);
            this.lbAlueet.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(469, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Alueet";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmRaportit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 477);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbAlueet);
            this.Controls.Add(this.btnAvaaRaportti);
            this.Controls.Add(this.mlvPalveluData);
            this.Controls.Add(this.mlvMokkiData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEtsi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpLoppupvm);
            this.Controls.Add(this.dtpAlkupvm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRaportit";
            this.Text = "frmRaportit";
            ((System.ComponentModel.ISupportInitialize)(this.alueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mokkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palveluBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varausBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laskuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asiakasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource alueBindingSource;
        private DataSet1TableAdapters.alueTableAdapter alueTableAdapter1;
        private DataSet1TableAdapters.mokkiTableAdapter mokkiTableAdapter1;
        private System.Windows.Forms.BindingSource mokkiBindingSource;
        private DataSet1TableAdapters.palveluTableAdapter palveluTableAdapter1;
        private System.Windows.Forms.BindingSource palveluBindingSource;
        private DataSet1TableAdapters.varausTableAdapter varausTableAdapter1;
        private System.Windows.Forms.BindingSource varausBindingSource;
        private DataSet1TableAdapters.laskuTableAdapter laskuTableAdapter1;
        private System.Windows.Forms.BindingSource laskuBindingSource;
        private DataSet1TableAdapters.asiakasTableAdapter asiakasTableAdapter1;
        private System.Windows.Forms.BindingSource asiakasBindingSource;
        private System.Windows.Forms.DateTimePicker dtpAlkupvm;
        private System.Windows.Forms.DateTimePicker dtpLoppupvm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton btnEtsi;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialListView mlvMokkiData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MaterialSkin.Controls.MaterialListView mlvPalveluData;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox3;
        private MaterialSkin.Controls.MaterialButton btnAvaaRaportti;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListBox lbAlueet;
        private System.Windows.Forms.Label label4;
    }
}