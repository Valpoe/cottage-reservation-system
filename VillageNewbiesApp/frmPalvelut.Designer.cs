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
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.mcbPalvelut = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.lblAlue = new System.Windows.Forms.Label();
            this.lblAlueID = new System.Windows.Forms.Label();
            this.lblMokki = new System.Windows.Forms.Label();
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
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "Alue",
            "Nimi",
            "Henkilömäärä"});
            this.materialComboBox1.Location = new System.Drawing.Point(11, 243);
            this.materialComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(92, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 1;
            // 
            // mcbPalvelut
            // 
            this.mcbPalvelut.AutoResize = false;
            this.mcbPalvelut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mcbPalvelut.Depth = 0;
            this.mcbPalvelut.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mcbPalvelut.DropDownHeight = 174;
            this.mcbPalvelut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcbPalvelut.DropDownWidth = 121;
            this.mcbPalvelut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mcbPalvelut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mcbPalvelut.FormattingEnabled = true;
            this.mcbPalvelut.IntegralHeight = false;
            this.mcbPalvelut.ItemHeight = 43;
            this.mcbPalvelut.Location = new System.Drawing.Point(176, 80);
            this.mcbPalvelut.Margin = new System.Windows.Forms.Padding(2);
            this.mcbPalvelut.MaxDropDownItems = 4;
            this.mcbPalvelut.MouseState = MaterialSkin.MouseState.OUT;
            this.mcbPalvelut.Name = "mcbPalvelut";
            this.mcbPalvelut.Size = new System.Drawing.Size(208, 49);
            this.mcbPalvelut.StartIndex = 0;
            this.mcbPalvelut.TabIndex = 2;
            this.mcbPalvelut.VisibleChanged += new System.EventHandler(this.mcbPalvelut_VisibleChanged);
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(15, 313);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(64, 37);
            this.materialCheckbox1.TabIndex = 3;
            this.materialCheckbox1.Text = "ALV";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
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
            this.lblMokki.Location = new System.Drawing.Point(491, 20);
            this.lblMokki.Name = "lblMokki";
            this.lblMokki.Size = new System.Drawing.Size(164, 31);
            this.lblMokki.TabIndex = 6;
            this.lblMokki.Text = "valittu mokki";
            this.lblMokki.VisibleChanged += new System.EventHandler(this.lblMokki_VisibleChanged);
            // 
            // frmPalvelut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 477);
            this.Controls.Add(this.lblMokki);
            this.Controls.Add(this.lblAlueID);
            this.Controls.Add(this.lblAlue);
            this.Controls.Add(this.materialCheckbox1);
            this.Controls.Add(this.mcbPalvelut);
            this.Controls.Add(this.materialComboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPalvelut";
            this.Text = "frmPalvelut";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialComboBox mcbPalvelut;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private System.Windows.Forms.Label lblAlue;
        private System.Windows.Forms.Label lblAlueID;
        private System.Windows.Forms.Label lblMokki;
    }
}