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
            this.Mökki = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hinta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Henkilomäärä = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox4 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox5 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox6 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox7 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox8 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox9 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox10 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox11 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox12 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox13 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox14 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox15 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox16 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox17 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox18 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox19 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox20 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox21 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox22 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox23 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox24 = new MaterialSkin.Controls.MaterialCheckbox();
            this.mäkkäri = new MaterialSkin.Controls.MaterialCheckbox();
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
            this.mcbToimintaAlue.BackColor = System.Drawing.Color.White;
            this.mcbToimintaAlue.Depth = 0;
            this.mcbToimintaAlue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.mcbToimintaAlue.DropDownHeight = 174;
            this.mcbToimintaAlue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcbToimintaAlue.DropDownWidth = 121;
            this.mcbToimintaAlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.mcbToimintaAlue.ForeColor = System.Drawing.Color.Black;
            this.mcbToimintaAlue.FormattingEnabled = true;
            this.mcbToimintaAlue.Hint = "Valitse alue";
            this.mcbToimintaAlue.IntegralHeight = false;
            this.mcbToimintaAlue.ItemHeight = 43;
            this.mcbToimintaAlue.Location = new System.Drawing.Point(35, 44);
            this.mcbToimintaAlue.MaxDropDownItems = 4;
            this.mcbToimintaAlue.MouseState = MaterialSkin.MouseState.OUT;
            this.mcbToimintaAlue.Name = "mcbToimintaAlue";
            this.mcbToimintaAlue.Size = new System.Drawing.Size(236, 49);
            this.mcbToimintaAlue.StartIndex = 0;
            this.mcbToimintaAlue.TabIndex = 1;
            this.mcbToimintaAlue.SelectedIndexChanged += new System.EventHandler(this.mcbToimintaAlue_SelectedIndexChanged);
            // 
            // mlvMokit
            // 
            this.mlvMokit.AutoSizeTable = false;
            this.mlvMokit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mlvMokit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mlvMokit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Mökki,
            this.Hinta,
            this.Henkilomäärä});
            this.mlvMokit.Depth = 0;
            this.mlvMokit.FullRowSelect = true;
            this.mlvMokit.HideSelection = false;
            this.mlvMokit.Location = new System.Drawing.Point(328, 44);
            this.mlvMokit.MinimumSize = new System.Drawing.Size(200, 100);
            this.mlvMokit.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mlvMokit.MouseState = MaterialSkin.MouseState.OUT;
            this.mlvMokit.Name = "mlvMokit";
            this.mlvMokit.OwnerDraw = true;
            this.mlvMokit.Size = new System.Drawing.Size(386, 263);
            this.mlvMokit.TabIndex = 2;
            this.mlvMokit.UseCompatibleStateImageBehavior = false;
            this.mlvMokit.View = System.Windows.Forms.View.Details;
            this.mlvMokit.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.mlvMokit_ItemSelectionChanged);
            this.mlvMokit.SelectedIndexChanged += new System.EventHandler(this.mlvMokit_SelectedIndexChanged);
            // 
            // Mökki
            // 
            this.Mökki.Text = "Mökki";
            this.Mökki.Width = 150;
            // 
            // Hinta
            // 
            this.Hinta.Text = "Hinta";
            this.Hinta.Width = 83;
            // 
            // Henkilomäärä
            // 
            this.Henkilomäärä.Text = "Henkilomäärä";
            this.Henkilomäärä.Width = 150;
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.ForeColor = System.Drawing.Color.Yellow;
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
            // materialCheckbox4
            // 
            this.materialCheckbox4.Depth = 0;
            this.materialCheckbox4.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox4.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox4.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox4.Name = "materialCheckbox4";
            this.materialCheckbox4.ReadOnly = false;
            this.materialCheckbox4.Ripple = true;
            this.materialCheckbox4.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox4.TabIndex = 0;
            this.materialCheckbox4.Text = "materialCheckbox4";
            this.materialCheckbox4.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox5
            // 
            this.materialCheckbox5.Depth = 0;
            this.materialCheckbox5.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox5.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox5.Name = "materialCheckbox5";
            this.materialCheckbox5.ReadOnly = false;
            this.materialCheckbox5.Ripple = true;
            this.materialCheckbox5.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox5.TabIndex = 0;
            this.materialCheckbox5.Text = "materialCheckbox5";
            this.materialCheckbox5.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox6
            // 
            this.materialCheckbox6.Depth = 0;
            this.materialCheckbox6.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox6.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox6.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox6.Name = "materialCheckbox6";
            this.materialCheckbox6.ReadOnly = false;
            this.materialCheckbox6.Ripple = true;
            this.materialCheckbox6.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox6.TabIndex = 0;
            this.materialCheckbox6.Text = "materialCheckbox6";
            this.materialCheckbox6.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox7
            // 
            this.materialCheckbox7.Depth = 0;
            this.materialCheckbox7.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox7.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox7.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox7.Name = "materialCheckbox7";
            this.materialCheckbox7.ReadOnly = false;
            this.materialCheckbox7.Ripple = true;
            this.materialCheckbox7.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox7.TabIndex = 0;
            this.materialCheckbox7.Text = "materialCheckbox7";
            this.materialCheckbox7.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox8
            // 
            this.materialCheckbox8.Depth = 0;
            this.materialCheckbox8.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox8.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox8.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox8.Name = "materialCheckbox8";
            this.materialCheckbox8.ReadOnly = false;
            this.materialCheckbox8.Ripple = true;
            this.materialCheckbox8.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox8.TabIndex = 0;
            this.materialCheckbox8.Text = "materialCheckbox8";
            this.materialCheckbox8.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox9
            // 
            this.materialCheckbox9.Depth = 0;
            this.materialCheckbox9.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox9.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox9.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox9.Name = "materialCheckbox9";
            this.materialCheckbox9.ReadOnly = false;
            this.materialCheckbox9.Ripple = true;
            this.materialCheckbox9.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox9.TabIndex = 0;
            this.materialCheckbox9.Text = "materialCheckbox9";
            this.materialCheckbox9.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox10
            // 
            this.materialCheckbox10.Depth = 0;
            this.materialCheckbox10.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox10.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox10.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox10.Name = "materialCheckbox10";
            this.materialCheckbox10.ReadOnly = false;
            this.materialCheckbox10.Ripple = true;
            this.materialCheckbox10.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox10.TabIndex = 0;
            this.materialCheckbox10.Text = "materialCheckbox10";
            this.materialCheckbox10.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox11
            // 
            this.materialCheckbox11.Depth = 0;
            this.materialCheckbox11.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox11.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox11.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox11.Name = "materialCheckbox11";
            this.materialCheckbox11.ReadOnly = false;
            this.materialCheckbox11.Ripple = true;
            this.materialCheckbox11.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox11.TabIndex = 0;
            this.materialCheckbox11.Text = "materialCheckbox11";
            this.materialCheckbox11.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox12
            // 
            this.materialCheckbox12.Depth = 0;
            this.materialCheckbox12.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox12.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox12.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox12.Name = "materialCheckbox12";
            this.materialCheckbox12.ReadOnly = false;
            this.materialCheckbox12.Ripple = true;
            this.materialCheckbox12.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox12.TabIndex = 0;
            this.materialCheckbox12.Text = "materialCheckbox12";
            this.materialCheckbox12.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox13
            // 
            this.materialCheckbox13.Depth = 0;
            this.materialCheckbox13.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox13.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox13.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox13.Name = "materialCheckbox13";
            this.materialCheckbox13.ReadOnly = false;
            this.materialCheckbox13.Ripple = true;
            this.materialCheckbox13.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox13.TabIndex = 0;
            this.materialCheckbox13.Text = "materialCheckbox13";
            this.materialCheckbox13.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox14
            // 
            this.materialCheckbox14.Depth = 0;
            this.materialCheckbox14.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox14.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox14.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox14.Name = "materialCheckbox14";
            this.materialCheckbox14.ReadOnly = false;
            this.materialCheckbox14.Ripple = true;
            this.materialCheckbox14.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox14.TabIndex = 0;
            this.materialCheckbox14.Text = "materialCheckbox14";
            this.materialCheckbox14.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox15
            // 
            this.materialCheckbox15.Depth = 0;
            this.materialCheckbox15.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox15.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox15.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox15.Name = "materialCheckbox15";
            this.materialCheckbox15.ReadOnly = false;
            this.materialCheckbox15.Ripple = true;
            this.materialCheckbox15.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox15.TabIndex = 0;
            this.materialCheckbox15.Text = "materialCheckbox15";
            this.materialCheckbox15.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox16
            // 
            this.materialCheckbox16.Depth = 0;
            this.materialCheckbox16.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox16.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox16.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox16.Name = "materialCheckbox16";
            this.materialCheckbox16.ReadOnly = false;
            this.materialCheckbox16.Ripple = true;
            this.materialCheckbox16.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox16.TabIndex = 0;
            this.materialCheckbox16.Text = "materialCheckbox16";
            this.materialCheckbox16.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox17
            // 
            this.materialCheckbox17.Depth = 0;
            this.materialCheckbox17.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox17.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox17.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox17.Name = "materialCheckbox17";
            this.materialCheckbox17.ReadOnly = false;
            this.materialCheckbox17.Ripple = true;
            this.materialCheckbox17.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox17.TabIndex = 0;
            this.materialCheckbox17.Text = "materialCheckbox17";
            this.materialCheckbox17.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox18
            // 
            this.materialCheckbox18.Depth = 0;
            this.materialCheckbox18.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox18.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox18.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox18.Name = "materialCheckbox18";
            this.materialCheckbox18.ReadOnly = false;
            this.materialCheckbox18.Ripple = true;
            this.materialCheckbox18.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox18.TabIndex = 0;
            this.materialCheckbox18.Text = "materialCheckbox18";
            this.materialCheckbox18.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox19
            // 
            this.materialCheckbox19.Depth = 0;
            this.materialCheckbox19.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox19.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox19.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox19.Name = "materialCheckbox19";
            this.materialCheckbox19.ReadOnly = false;
            this.materialCheckbox19.Ripple = true;
            this.materialCheckbox19.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox19.TabIndex = 0;
            this.materialCheckbox19.Text = "materialCheckbox19";
            this.materialCheckbox19.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox20
            // 
            this.materialCheckbox20.Depth = 0;
            this.materialCheckbox20.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox20.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox20.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox20.Name = "materialCheckbox20";
            this.materialCheckbox20.ReadOnly = false;
            this.materialCheckbox20.Ripple = true;
            this.materialCheckbox20.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox20.TabIndex = 0;
            this.materialCheckbox20.Text = "materialCheckbox20";
            this.materialCheckbox20.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox21
            // 
            this.materialCheckbox21.Depth = 0;
            this.materialCheckbox21.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox21.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox21.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox21.Name = "materialCheckbox21";
            this.materialCheckbox21.ReadOnly = false;
            this.materialCheckbox21.Ripple = true;
            this.materialCheckbox21.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox21.TabIndex = 0;
            this.materialCheckbox21.Text = "materialCheckbox21";
            this.materialCheckbox21.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox22
            // 
            this.materialCheckbox22.Depth = 0;
            this.materialCheckbox22.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox22.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox22.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox22.Name = "materialCheckbox22";
            this.materialCheckbox22.ReadOnly = false;
            this.materialCheckbox22.Ripple = true;
            this.materialCheckbox22.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox22.TabIndex = 0;
            this.materialCheckbox22.Text = "materialCheckbox22";
            this.materialCheckbox22.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox23
            // 
            this.materialCheckbox23.Depth = 0;
            this.materialCheckbox23.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox23.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox23.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox23.Name = "materialCheckbox23";
            this.materialCheckbox23.ReadOnly = false;
            this.materialCheckbox23.Ripple = true;
            this.materialCheckbox23.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox23.TabIndex = 0;
            this.materialCheckbox23.Text = "materialCheckbox23";
            this.materialCheckbox23.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox24
            // 
            this.materialCheckbox24.Checked = true;
            this.materialCheckbox24.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckbox24.Depth = 0;
            this.materialCheckbox24.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox24.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox24.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox24.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox24.Name = "materialCheckbox24";
            this.materialCheckbox24.ReadOnly = false;
            this.materialCheckbox24.Ripple = true;
            this.materialCheckbox24.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox24.TabIndex = 0;
            this.materialCheckbox24.Text = "materialCheckbox24";
            this.materialCheckbox24.UseVisualStyleBackColor = true;
            // 
            // mäkkäri
            // 
            this.mäkkäri.Depth = 0;
            this.mäkkäri.Location = new System.Drawing.Point(0, 0);
            this.mäkkäri.Margin = new System.Windows.Forms.Padding(0);
            this.mäkkäri.MouseLocation = new System.Drawing.Point(-1, -1);
            this.mäkkäri.MouseState = MaterialSkin.MouseState.HOVER;
            this.mäkkäri.Name = "mäkkäri";
            this.mäkkäri.ReadOnly = false;
            this.mäkkäri.Ripple = true;
            this.mäkkäri.Size = new System.Drawing.Size(104, 37);
            this.mäkkäri.TabIndex = 0;
            this.mäkkäri.Text = "materialCheckbox25";
            this.mäkkäri.UseVisualStyleBackColor = true;
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
            this.Load += new System.EventHandler(this.frmAlueet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox mcbToimintaAlue;
        private MaterialSkin.Controls.MaterialListView mlvMokit;
        private System.Windows.Forms.ColumnHeader Mökki;
        private System.Windows.Forms.ColumnHeader Hinta;
        private System.Windows.Forms.ColumnHeader Henkilomäärä;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox3;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox4;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox5;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox6;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox7;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox8;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox9;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox10;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox11;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox12;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox13;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox14;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox15;
        public MaterialSkin.Controls.MaterialCheckbox materialCheckbox16;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox17;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox18;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox19;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox20;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox21;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox22;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox23;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox24;
        private MaterialSkin.Controls.MaterialCheckbox mäkkäri;
    }
}