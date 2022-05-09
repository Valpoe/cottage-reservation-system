namespace VillageNewbiesApp
{
    partial class frmLaskutus
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
            this.btnLahetaLasku = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbVastaanottaja = new MaterialSkin.Controls.MaterialTextBox();
            this.tbCC = new MaterialSkin.Controls.MaterialTextBox();
            this.tbAihe = new MaterialSkin.Controls.MaterialTextBox();
            this.mmltbViesti = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.SuspendLayout();
            // 
            // btnLahetaLasku
            // 
            this.btnLahetaLasku.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLahetaLasku.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLahetaLasku.Depth = 0;
            this.btnLahetaLasku.HighEmphasis = true;
            this.btnLahetaLasku.Icon = null;
            this.btnLahetaLasku.Location = new System.Drawing.Point(516, 425);
            this.btnLahetaLasku.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLahetaLasku.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLahetaLasku.Name = "btnLahetaLasku";
            this.btnLahetaLasku.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLahetaLasku.Size = new System.Drawing.Size(126, 36);
            this.btnLahetaLasku.TabIndex = 5;
            this.btnLahetaLasku.Text = "Lähetä lasku";
            this.btnLahetaLasku.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLahetaLasku.UseAccentColor = false;
            this.btnLahetaLasku.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vastaanottaja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "CC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Aihe:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Viesti:";
            // 
            // tbVastaanottaja
            // 
            this.tbVastaanottaja.AnimateReadOnly = false;
            this.tbVastaanottaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbVastaanottaja.Depth = 0;
            this.tbVastaanottaja.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbVastaanottaja.LeadingIcon = null;
            this.tbVastaanottaja.Location = new System.Drawing.Point(107, 2);
            this.tbVastaanottaja.MaxLength = 50;
            this.tbVastaanottaja.MouseState = MaterialSkin.MouseState.OUT;
            this.tbVastaanottaja.Multiline = false;
            this.tbVastaanottaja.Name = "tbVastaanottaja";
            this.tbVastaanottaja.Size = new System.Drawing.Size(391, 36);
            this.tbVastaanottaja.TabIndex = 10;
            this.tbVastaanottaja.Text = "";
            this.tbVastaanottaja.TrailingIcon = null;
            this.tbVastaanottaja.UseTallSize = false;
            // 
            // tbCC
            // 
            this.tbCC.AnimateReadOnly = false;
            this.tbCC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCC.Depth = 0;
            this.tbCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbCC.LeadingIcon = null;
            this.tbCC.Location = new System.Drawing.Point(107, 44);
            this.tbCC.MaxLength = 50;
            this.tbCC.MouseState = MaterialSkin.MouseState.OUT;
            this.tbCC.Multiline = false;
            this.tbCC.Name = "tbCC";
            this.tbCC.Size = new System.Drawing.Size(391, 36);
            this.tbCC.TabIndex = 11;
            this.tbCC.Text = "";
            this.tbCC.TrailingIcon = null;
            this.tbCC.UseTallSize = false;
            // 
            // tbAihe
            // 
            this.tbAihe.AnimateReadOnly = false;
            this.tbAihe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAihe.Depth = 0;
            this.tbAihe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAihe.LeadingIcon = null;
            this.tbAihe.Location = new System.Drawing.Point(107, 86);
            this.tbAihe.MaxLength = 50;
            this.tbAihe.MouseState = MaterialSkin.MouseState.OUT;
            this.tbAihe.Multiline = false;
            this.tbAihe.Name = "tbAihe";
            this.tbAihe.Size = new System.Drawing.Size(391, 36);
            this.tbAihe.TabIndex = 12;
            this.tbAihe.Text = "";
            this.tbAihe.TrailingIcon = null;
            this.tbAihe.UseTallSize = false;
            // 
            // mmltbViesti
            // 
            this.mmltbViesti.AnimateReadOnly = false;
            this.mmltbViesti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmltbViesti.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mmltbViesti.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mmltbViesti.Depth = 0;
            this.mmltbViesti.HideSelection = true;
            this.mmltbViesti.Location = new System.Drawing.Point(107, 128);
            this.mmltbViesti.MaxLength = 32767;
            this.mmltbViesti.MouseState = MaterialSkin.MouseState.OUT;
            this.mmltbViesti.Name = "mmltbViesti";
            this.mmltbViesti.PasswordChar = '\0';
            this.mmltbViesti.ReadOnly = false;
            this.mmltbViesti.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mmltbViesti.SelectedText = "";
            this.mmltbViesti.SelectionLength = 0;
            this.mmltbViesti.SelectionStart = 0;
            this.mmltbViesti.ShortcutsEnabled = true;
            this.mmltbViesti.Size = new System.Drawing.Size(391, 184);
            this.mmltbViesti.TabIndex = 14;
            this.mmltbViesti.TabStop = false;
            this.mmltbViesti.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmltbViesti.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label5.Location = new System.Drawing.Point(104, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Asetukset";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label6.Location = new System.Drawing.Point(104, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Käyttäjätunnus:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label7.Location = new System.Drawing.Point(104, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Salasana:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label8.Location = new System.Drawing.Point(105, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Portti:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.label9.Location = new System.Drawing.Point(267, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Smtp:";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(205, 341);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(293, 36);
            this.materialTextBox1.TabIndex = 20;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            this.materialTextBox1.UseTallSize = false;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(205, 383);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(293, 36);
            this.materialTextBox2.TabIndex = 21;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            this.materialTextBox2.UseTallSize = false;
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.AnimateReadOnly = false;
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox3.LeadingIcon = null;
            this.materialTextBox3.Location = new System.Drawing.Point(205, 426);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(59, 36);
            this.materialTextBox3.TabIndex = 22;
            this.materialTextBox3.Text = "";
            this.materialTextBox3.TrailingIcon = null;
            this.materialTextBox3.UseTallSize = false;
            // 
            // materialTextBox4
            // 
            this.materialTextBox4.AnimateReadOnly = false;
            this.materialTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox4.Depth = 0;
            this.materialTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox4.LeadingIcon = null;
            this.materialTextBox4.Location = new System.Drawing.Point(312, 425);
            this.materialTextBox4.MaxLength = 50;
            this.materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox4.Multiline = false;
            this.materialTextBox4.Name = "materialTextBox4";
            this.materialTextBox4.Size = new System.Drawing.Size(186, 36);
            this.materialTextBox4.TabIndex = 23;
            this.materialTextBox4.Text = "";
            this.materialTextBox4.TrailingIcon = null;
            this.materialTextBox4.UseTallSize = false;
            // 
            // frmLaskutus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(765, 477);
            this.Controls.Add(this.materialTextBox4);
            this.Controls.Add(this.materialTextBox3);
            this.Controls.Add(this.materialTextBox2);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mmltbViesti);
            this.Controls.Add(this.tbAihe);
            this.Controls.Add(this.tbCC);
            this.Controls.Add(this.tbVastaanottaja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLahetaLasku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLaskutus";
            this.Text = "frmLaskutus";
            this.Load += new System.EventHandler(this.frmLaskutus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnLahetaLasku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialTextBox tbVastaanottaja;
        private MaterialSkin.Controls.MaterialTextBox tbCC;
        private MaterialSkin.Controls.MaterialTextBox tbAihe;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 mmltbViesti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
    }
}