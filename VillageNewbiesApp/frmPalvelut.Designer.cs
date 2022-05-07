namespace VillageNewbiesApp
{
    partial class frmPalvelut
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
            this.lblAlue = new System.Windows.Forms.Label();
            this.lblAlueID = new System.Windows.Forms.Label();
            this.lblMokki = new System.Windows.Forms.Label();
            this.mbtnPoista = new MaterialSkin.Controls.MaterialButton();
            this.mclPalvelut = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PALVELUT";
            // 
            // lblAlue
            // 
            this.lblAlue.AutoSize = true;
            this.lblAlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlue.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAlue.Location = new System.Drawing.Point(22, 96);
            this.lblAlue.Name = "lblAlue";
            this.lblAlue.Size = new System.Drawing.Size(86, 20);
            this.lblAlue.TabIndex = 4;
            this.lblAlue.Text = "ValittuAlue";
            this.lblAlue.TextChanged += new System.EventHandler(this.lblAlue_TextChanged);
            this.lblAlue.VisibleChanged += new System.EventHandler(this.lblAlue_VisibleChanged);
            // 
            // lblAlueID
            // 
            this.lblAlueID.AutoSize = true;
            this.lblAlueID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAlueID.Location = new System.Drawing.Point(143, 9);
            this.lblAlueID.Name = "lblAlueID";
            this.lblAlueID.Size = new System.Drawing.Size(39, 13);
            this.lblAlueID.TabIndex = 5;
            this.lblAlueID.Text = "AlueID";
            // 
            // lblMokki
            // 
            this.lblMokki.AutoSize = true;
            this.lblMokki.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMokki.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMokki.Location = new System.Drawing.Point(246, 53);
            this.lblMokki.Name = "lblMokki";
            this.lblMokki.Size = new System.Drawing.Size(164, 31);
            this.lblMokki.TabIndex = 6;
            this.lblMokki.Text = "valittu mokki";
            this.lblMokki.VisibleChanged += new System.EventHandler(this.lblMokki_VisibleChanged);
            // 
            // mbtnPoista
            // 
            this.mbtnPoista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbtnPoista.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbtnPoista.Depth = 0;
            this.mbtnPoista.HighEmphasis = true;
            this.mbtnPoista.Icon = null;
            this.mbtnPoista.Location = new System.Drawing.Point(41, 337);
            this.mbtnPoista.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbtnPoista.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbtnPoista.Name = "mbtnPoista";
            this.mbtnPoista.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mbtnPoista.Size = new System.Drawing.Size(97, 36);
            this.mbtnPoista.TabIndex = 8;
            this.mbtnPoista.Text = "Tyhjennä";
            this.mbtnPoista.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbtnPoista.UseAccentColor = false;
            this.mbtnPoista.UseVisualStyleBackColor = true;
            this.mbtnPoista.Click += new System.EventHandler(this.mbtnPoista_Click);
            // 
            // mclPalvelut
            // 
            this.mclPalvelut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mclPalvelut.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mclPalvelut.FormattingEnabled = true;
            this.mclPalvelut.Location = new System.Drawing.Point(252, 129);
            this.mclPalvelut.Name = "mclPalvelut";
            this.mclPalvelut.Size = new System.Drawing.Size(415, 244);
            this.mclPalvelut.TabIndex = 9;
            // 
            // frmPalvelut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 477);
            this.Controls.Add(this.mclPalvelut);
            this.Controls.Add(this.mbtnPoista);
            this.Controls.Add(this.lblMokki);
            this.Controls.Add(this.lblAlueID);
            this.Controls.Add(this.lblAlue);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPalvelut";
            this.Text = "frmPalvelut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlue;
        private System.Windows.Forms.Label lblAlueID;
        private System.Windows.Forms.Label lblMokki;
        private MaterialSkin.Controls.MaterialButton mbtnPoista;
        private System.Windows.Forms.CheckedListBox mclPalvelut;
    }
}