namespace VillageNewbiesApp
{
    partial class frmPaperilasku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaperilasku));
            this.mmltbLaskunTiedon = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnPrint = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // mmltbLaskunTiedon
            // 
            this.mmltbLaskunTiedon.AnimateReadOnly = false;
            this.mmltbLaskunTiedon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mmltbLaskunTiedon.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.mmltbLaskunTiedon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mmltbLaskunTiedon.Depth = 0;
            this.mmltbLaskunTiedon.HideSelection = true;
            this.mmltbLaskunTiedon.Location = new System.Drawing.Point(12, 12);
            this.mmltbLaskunTiedon.MaxLength = 32767;
            this.mmltbLaskunTiedon.MouseState = MaterialSkin.MouseState.OUT;
            this.mmltbLaskunTiedon.Name = "mmltbLaskunTiedon";
            this.mmltbLaskunTiedon.PasswordChar = '\0';
            this.mmltbLaskunTiedon.ReadOnly = false;
            this.mmltbLaskunTiedon.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mmltbLaskunTiedon.SelectedText = "";
            this.mmltbLaskunTiedon.SelectionLength = 0;
            this.mmltbLaskunTiedon.SelectionStart = 0;
            this.mmltbLaskunTiedon.ShortcutsEnabled = true;
            this.mmltbLaskunTiedon.Size = new System.Drawing.Size(411, 397);
            this.mmltbLaskunTiedon.TabIndex = 1;
            this.mmltbLaskunTiedon.TabStop = false;
            this.mmltbLaskunTiedon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mmltbLaskunTiedon.UseSystemPasswordChar = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.AutoSize = false;
            this.btnPrint.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPrint.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnPrint.Depth = 0;
            this.btnPrint.HighEmphasis = true;
            this.btnPrint.Icon = null;
            this.btnPrint.Location = new System.Drawing.Point(137, 420);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrint.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnPrint.Size = new System.Drawing.Size(158, 36);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnPrint.UseAccentColor = false;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmPaperilasku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(204)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(435, 469);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.mmltbLaskunTiedon);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmPaperilasku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmPaperilasku_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialMultiLineTextBox2 mmltbLaskunTiedon;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private MaterialSkin.Controls.MaterialButton btnPrint;
    }
}