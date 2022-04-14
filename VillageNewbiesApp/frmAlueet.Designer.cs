namespace VillageNewbiesApp
{
    partial class frmAlueet
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
            this.mcbToimintaAlue = new MaterialSkin.Controls.MaterialComboBox();
            this.mlvMokit = new MaterialSkin.Controls.MaterialListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALUEET";
            // 
            // mcbToimintaAlue
            // 
            this.mcbToimintaAlue.AutoResize = false;
            this.mcbToimintaAlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcbToimintaAlue.Depth = 0;
            this.mcbToimintaAlue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mcbToimintaAlue.DropDownHeight = 174;
            this.mcbToimintaAlue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcbToimintaAlue.DropDownWidth = 121;
            this.mcbToimintaAlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mcbToimintaAlue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcbToimintaAlue.FormattingEnabled = true;
            this.mcbToimintaAlue.IntegralHeight = false;
            this.mcbToimintaAlue.ItemHeight = 43;
            this.mcbToimintaAlue.Location = new System.Drawing.Point(35, 44);
            this.mcbToimintaAlue.MaxDropDownItems = 4;
            this.mcbToimintaAlue.MouseState = MaterialSkin.MouseState.OUT;
            this.mcbToimintaAlue.Name = "mcbToimintaAlue";
            this.mcbToimintaAlue.Size = new System.Drawing.Size(121, 49);
            this.mcbToimintaAlue.StartIndex = 0;
            this.mcbToimintaAlue.TabIndex = 1;
            // 
            // mlvMokit
            // 
            this.mlvMokit.AutoSizeTable = false;
            this.mlvMokit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlvMokit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvMokit.Depth = 0;
            this.mlvMokit.FullRowSelect = true;
            this.mlvMokit.HideSelection = false;
            this.mlvMokit.Location = new System.Drawing.Point(436, 44);
            this.mlvMokit.MinimumSize = new System.Drawing.Size(200, 100);
            this.mlvMokit.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvMokit.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvMokit.Name = "mlvMokit";
            this.mlvMokit.OwnerDraw = true;
            this.mlvMokit.Size = new System.Drawing.Size(282, 288);
            this.mlvMokit.TabIndex = 2;
            this.mlvMokit.UseCompatibleStateImageBehavior = false;
            this.mlvMokit.View = System.Windows.Forms.View.Details;
            // 
            // frmAlueet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 477);
            this.Controls.Add(this.mlvMokit);
            this.Controls.Add(this.mcbToimintaAlue);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlueet";
            this.Text = "frmAlueet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox mcbToimintaAlue;
        private MaterialSkin.Controls.MaterialListView mlvMokit;
    }
}