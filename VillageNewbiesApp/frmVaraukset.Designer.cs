﻿namespace VillageNewbiesApp
{
    partial class frmVaraukset
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
            this.mlvVaraukset = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnTeeVaraus = new MaterialSkin.Controls.MaterialButton();
            this.btnPoistaVaraus = new MaterialSkin.Controls.MaterialButton();
            this.btnVahvistaVaraus = new MaterialSkin.Controls.MaterialButton();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "VARAUKSET";
            this.label1.VisibleChanged += new System.EventHandler(this.label1_VisibleChanged);
            // 
            // mlvVaraukset
            // 
            this.mlvVaraukset.AutoSizeTable = false;
            this.mlvVaraukset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlvVaraukset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvVaraukset.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.mlvVaraukset.Depth = 0;
            this.mlvVaraukset.FullRowSelect = true;
            this.mlvVaraukset.HideSelection = false;
            this.mlvVaraukset.Location = new System.Drawing.Point(12, 45);
            this.mlvVaraukset.MinimumSize = new System.Drawing.Size(225, 125);
            this.mlvVaraukset.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvVaraukset.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvVaraukset.Name = "mlvVaraukset";
            this.mlvVaraukset.OwnerDraw = true;
            this.mlvVaraukset.Size = new System.Drawing.Size(1095, 394);
            this.mlvVaraukset.TabIndex = 1;
            this.mlvVaraukset.UseCompatibleStateImageBehavior = false;
            this.mlvVaraukset.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Varaus id";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Asiakas";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Varaus";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Alku";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Loppu";
            this.columnHeader5.Width = 120;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 461);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // btnTeeVaraus
            // 
            this.btnTeeVaraus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTeeVaraus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTeeVaraus.Depth = 0;
            this.btnTeeVaraus.HighEmphasis = true;
            this.btnTeeVaraus.Icon = null;
            this.btnTeeVaraus.Location = new System.Drawing.Point(282, 461);
            this.btnTeeVaraus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTeeVaraus.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTeeVaraus.Name = "btnTeeVaraus";
            this.btnTeeVaraus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTeeVaraus.Size = new System.Drawing.Size(107, 36);
            this.btnTeeVaraus.TabIndex = 3;
            this.btnTeeVaraus.Text = "Tee Varaus";
            this.btnTeeVaraus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTeeVaraus.UseAccentColor = false;
            this.btnTeeVaraus.UseVisualStyleBackColor = true;
            this.btnTeeVaraus.Click += new System.EventHandler(this.btnTeeVaraus_Click);
            // 
            // btnPoistaVaraus
            // 
            this.btnPoistaVaraus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPoistaVaraus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPoistaVaraus.Depth = 0;
            this.btnPoistaVaraus.HighEmphasis = true;
            this.btnPoistaVaraus.Icon = null;
            this.btnPoistaVaraus.Location = new System.Drawing.Point(894, 461);
            this.btnPoistaVaraus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPoistaVaraus.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPoistaVaraus.Name = "btnPoistaVaraus";
            this.btnPoistaVaraus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPoistaVaraus.Size = new System.Drawing.Size(132, 36);
            this.btnPoistaVaraus.TabIndex = 4;
            this.btnPoistaVaraus.Text = "Poista Varaus";
            this.btnPoistaVaraus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPoistaVaraus.UseAccentColor = false;
            this.btnPoistaVaraus.UseVisualStyleBackColor = true;
            this.btnPoistaVaraus.Click += new System.EventHandler(this.btnPoistaVaraus_Click);
            // 
            // btnVahvistaVaraus
            // 
            this.btnVahvistaVaraus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVahvistaVaraus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVahvistaVaraus.Depth = 0;
            this.btnVahvistaVaraus.HighEmphasis = true;
            this.btnVahvistaVaraus.Icon = null;
            this.btnVahvistaVaraus.Location = new System.Drawing.Point(554, 461);
            this.btnVahvistaVaraus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVahvistaVaraus.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVahvistaVaraus.Name = "btnVahvistaVaraus";
            this.btnVahvistaVaraus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnVahvistaVaraus.Size = new System.Drawing.Size(152, 36);
            this.btnVahvistaVaraus.TabIndex = 5;
            this.btnVahvistaVaraus.Text = "Vahvista varaus";
            this.btnVahvistaVaraus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVahvistaVaraus.UseAccentColor = false;
            this.btnVahvistaVaraus.UseVisualStyleBackColor = true;
            this.btnVahvistaVaraus.Click += new System.EventHandler(this.btnVahvistaVaraus_Click);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Vahvistettu";
            this.columnHeader6.Width = 120;
            // 
            // frmVaraukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1148, 734);
            this.Controls.Add(this.btnVahvistaVaraus);
            this.Controls.Add(this.btnPoistaVaraus);
            this.Controls.Add(this.btnTeeVaraus);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.mlvVaraukset);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVaraukset";
            this.Text = "frmVaraukset";
            this.Activated += new System.EventHandler(this.frmVaraukset_Activated);
            this.VisibleChanged += new System.EventHandler(this.frmVaraukset_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialListView mlvVaraukset;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MaterialSkin.Controls.MaterialButton btnTeeVaraus;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MaterialSkin.Controls.MaterialButton btnPoistaVaraus;
        private MaterialSkin.Controls.MaterialButton btnVahvistaVaraus;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}