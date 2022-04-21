namespace VillageNewbiesApp
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "VARAUKSET";
            // 
            // mlvVaraukset
            // 
            this.mlvVaraukset.AutoSizeTable = false;
            this.mlvVaraukset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlvVaraukset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvVaraukset.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.mlvVaraukset.Depth = 0;
            this.mlvVaraukset.FullRowSelect = true;
            this.mlvVaraukset.HideSelection = false;
            this.mlvVaraukset.Location = new System.Drawing.Point(475, 46);
            this.mlvVaraukset.Margin = new System.Windows.Forms.Padding(2);
            this.mlvVaraukset.MinimumSize = new System.Drawing.Size(150, 81);
            this.mlvVaraukset.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvVaraukset.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvVaraukset.Name = "mlvVaraukset";
            this.mlvVaraukset.OwnerDraw = true;
            this.mlvVaraukset.Size = new System.Drawing.Size(251, 358);
            this.mlvVaraukset.TabIndex = 1;
            this.mlvVaraukset.UseCompatibleStateImageBehavior = false;
            this.mlvVaraukset.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Asiakas";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Varaus";
            this.columnHeader2.Width = 100;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 29);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // frmVaraukset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 477);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.mlvVaraukset);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVaraukset";
            this.Text = "frmVaraukset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialListView mlvVaraukset;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}