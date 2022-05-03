namespace VillageNewbiesApp
{
    partial class frmKirjauduSisaan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKirjauduSisaan));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKirjaudu = new MaterialSkin.Controls.MaterialButton();
            this.btnExit = new MaterialSkin.Controls.MaterialButton();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbUsername = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.tbPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.panel2.Location = new System.Drawing.Point(32, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.panel1.Location = new System.Drawing.Point(32, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 23;
            // 
            // btnKirjaudu
            // 
            this.btnKirjaudu.AutoSize = false;
            this.btnKirjaudu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKirjaudu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKirjaudu.Depth = 0;
            this.btnKirjaudu.HighEmphasis = true;
            this.btnKirjaudu.Icon = null;
            this.btnKirjaudu.Location = new System.Drawing.Point(85, 262);
            this.btnKirjaudu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKirjaudu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKirjaudu.Name = "btnKirjaudu";
            this.btnKirjaudu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKirjaudu.Size = new System.Drawing.Size(166, 36);
            this.btnKirjaudu.TabIndex = 2;
            this.btnKirjaudu.Text = "Kirjaudu sisään";
            this.btnKirjaudu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKirjaudu.UseAccentColor = false;
            this.btnKirjaudu.UseVisualStyleBackColor = true;
            this.btnKirjaudu.Click += new System.EventHandler(this.btnKirjaudu_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = false;
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExit.Depth = 0;
            this.btnExit.HighEmphasis = true;
            this.btnExit.Icon = null;
            this.btnExit.Location = new System.Drawing.Point(128, 310);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExit.Size = new System.Drawing.Size(75, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "exit";
            this.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnExit.UseAccentColor = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Image = global::VillageNewbiesApp.Properties.Resources.show1;
            this.btnShowPassword.Location = new System.Drawing.Point(277, 214);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(26, 26);
            this.btnShowPassword.TabIndex = 28;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VillageNewbiesApp.Properties.Resources.VillageNewbiesLogo;
            this.pictureBox3.Location = new System.Drawing.Point(85, 27);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(166, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(32, 144);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // tbUsername
            // 
            this.tbUsername.AllowPromptAsInput = true;
            this.tbUsername.AnimateReadOnly = false;
            this.tbUsername.AsciiOnly = false;
            this.tbUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbUsername.BeepOnError = false;
            this.tbUsername.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tbUsername.Depth = 0;
            this.tbUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbUsername.HidePromptOnLeave = false;
            this.tbUsername.HideSelection = true;
            this.tbUsername.Hint = "Käyttäjätunnus";
            this.tbUsername.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.tbUsername.LeadingIcon = null;
            this.tbUsername.Location = new System.Drawing.Point(68, 138);
            this.tbUsername.Mask = "";
            this.tbUsername.MaxLength = 32767;
            this.tbUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PrefixSuffixText = null;
            this.tbUsername.PromptChar = '_';
            this.tbUsername.ReadOnly = false;
            this.tbUsername.RejectInputOnFirstFailure = false;
            this.tbUsername.ResetOnPrompt = true;
            this.tbUsername.ResetOnSpace = true;
            this.tbUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbUsername.SelectedText = "";
            this.tbUsername.SelectionLength = 0;
            this.tbUsername.SelectionStart = 0;
            this.tbUsername.ShortcutsEnabled = true;
            this.tbUsername.Size = new System.Drawing.Size(200, 36);
            this.tbUsername.SkipLiterals = true;
            this.tbUsername.TabIndex = 0;
            this.tbUsername.TabStop = false;
            this.tbUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbUsername.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tbUsername.TrailingIcon = null;
            this.tbUsername.UseSystemPasswordChar = false;
            this.tbUsername.UseTallSize = false;
            this.tbUsername.ValidatingType = null;
            // 
            // tbPassword
            // 
            this.tbPassword.AllowPromptAsInput = true;
            this.tbPassword.AnimateReadOnly = false;
            this.tbPassword.AsciiOnly = false;
            this.tbPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbPassword.BeepOnError = false;
            this.tbPassword.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tbPassword.Depth = 0;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbPassword.HidePromptOnLeave = false;
            this.tbPassword.HideSelection = true;
            this.tbPassword.Hint = "Salasana";
            this.tbPassword.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.tbPassword.LeadingIcon = null;
            this.tbPassword.Location = new System.Drawing.Point(68, 207);
            this.tbPassword.Mask = "";
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.PrefixSuffixText = null;
            this.tbPassword.PromptChar = '_';
            this.tbPassword.ReadOnly = false;
            this.tbPassword.RejectInputOnFirstFailure = false;
            this.tbPassword.ResetOnPrompt = true;
            this.tbPassword.ResetOnSpace = true;
            this.tbPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(200, 36);
            this.tbPassword.SkipLiterals = true;
            this.tbPassword.TabIndex = 1;
            this.tbPassword.TabStop = false;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbPassword.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.tbPassword.TrailingIcon = null;
            this.tbPassword.UseSystemPasswordChar = false;
            this.tbPassword.UseTallSize = false;
            this.tbPassword.ValidatingType = null;
            // 
            // frmKirjauduSisaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(335, 370);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnKirjaudu);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKirjauduSisaan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKirjauduSisaan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btnKirjaudu;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private System.Windows.Forms.Button btnShowPassword;
        private MaterialSkin.Controls.MaterialMaskedTextBox tbUsername;
        private MaterialSkin.Controls.MaterialMaskedTextBox tbPassword;
    }
}