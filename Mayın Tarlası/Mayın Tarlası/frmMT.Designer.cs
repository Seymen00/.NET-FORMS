namespace Mayın_Tarlası
{
    partial class frmMT
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMT));
            menuStripMT = new MenuStrip();
            toolStripTextBoxSure = new ToolStripMenuItem();
            zorlukToolStripMenuItem = new ToolStripMenuItem();
            kolaytoolStripMenuItem = new ToolStripMenuItem();
            ortaToolStripMenuItem = new ToolStripMenuItem();
            zorToolStripMenuItem = new ToolStripMenuItem();
            gosterToolStripMenuItem = new ToolStripMenuItem();
            lblBaslangic = new Label();
            lblkalantiklama = new Label();
            lblmayinsayisi = new Label();
            lblSkor = new Label();
            menuStripMT.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMT
            // 
            menuStripMT.AutoSize = false;
            menuStripMT.BackColor = Color.Teal;
            menuStripMT.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            menuStripMT.Items.AddRange(new ToolStripItem[] { toolStripTextBoxSure, zorlukToolStripMenuItem, gosterToolStripMenuItem });
            menuStripMT.Location = new Point(0, 0);
            menuStripMT.Name = "menuStripMT";
            menuStripMT.Size = new Size(584, 29);
            menuStripMT.TabIndex = 0;
            // 
            // toolStripTextBoxSure
            // 
            toolStripTextBoxSure.Alignment = ToolStripItemAlignment.Right;
            toolStripTextBoxSure.AutoSize = false;
            toolStripTextBoxSure.BackColor = Color.Black;
            toolStripTextBoxSure.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStripTextBoxSure.ForeColor = Color.Red;
            toolStripTextBoxSure.Margin = new Padding(1, 0, 20, 0);
            toolStripTextBoxSure.Name = "toolStripTextBoxSure";
            toolStripTextBoxSure.Size = new Size(75, 25);
            // 
            // zorlukToolStripMenuItem
            // 
            zorlukToolStripMenuItem.AutoSize = false;
            zorlukToolStripMenuItem.BackColor = Color.White;
            zorlukToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kolaytoolStripMenuItem, ortaToolStripMenuItem, zorToolStripMenuItem });
            zorlukToolStripMenuItem.ForeColor = Color.Black;
            zorlukToolStripMenuItem.Name = "zorlukToolStripMenuItem";
            zorlukToolStripMenuItem.Size = new Size(50, 25);
            zorlukToolStripMenuItem.Text = "Zorluk";
            // 
            // kolaytoolStripMenuItem
            // 
            kolaytoolStripMenuItem.Name = "kolaytoolStripMenuItem";
            kolaytoolStripMenuItem.Size = new Size(113, 24);
            kolaytoolStripMenuItem.Text = "Kolay";
            kolaytoolStripMenuItem.Click += kolaytoolStripMenuItem_Click;
            // 
            // ortaToolStripMenuItem
            // 
            ortaToolStripMenuItem.Name = "ortaToolStripMenuItem";
            ortaToolStripMenuItem.Size = new Size(113, 24);
            ortaToolStripMenuItem.Text = "Orta";
            ortaToolStripMenuItem.Click += ortaToolStripMenuItem_Click;
            // 
            // zorToolStripMenuItem
            // 
            zorToolStripMenuItem.Name = "zorToolStripMenuItem";
            zorToolStripMenuItem.Size = new Size(113, 24);
            zorToolStripMenuItem.Text = "Zor";
            zorToolStripMenuItem.Click += zorToolStripMenuItem_Click;
            // 
            // gosterToolStripMenuItem
            // 
            gosterToolStripMenuItem.AutoSize = false;
            gosterToolStripMenuItem.BackColor = Color.White;
            gosterToolStripMenuItem.Margin = new Padding(200, 0, 0, 0);
            gosterToolStripMenuItem.Name = "gosterToolStripMenuItem";
            gosterToolStripMenuItem.Size = new Size(64, 25);
            gosterToolStripMenuItem.Text = "Göster";
            gosterToolStripMenuItem.Visible = false;
            gosterToolStripMenuItem.Click += gosterToolStripMenuItem_Click;
            // 
            // lblBaslangic
            // 
            lblBaslangic.AutoSize = true;
            lblBaslangic.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblBaslangic.Location = new Point(31, 249);
            lblBaslangic.Name = "lblBaslangic";
            lblBaslangic.Size = new Size(501, 39);
            lblBaslangic.TabIndex = 1;
            lblBaslangic.Text = "Başlamak için bir zorluk seviyesi seçin";
            lblBaslangic.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblkalantiklama
            // 
            lblkalantiklama.AutoSize = true;
            lblkalantiklama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblkalantiklama.Location = new Point(12, 29);
            lblkalantiklama.Name = "lblkalantiklama";
            lblkalantiklama.Size = new Size(0, 21);
            lblkalantiklama.TabIndex = 2;
            lblkalantiklama.Visible = false;
            // 
            // lblmayinsayisi
            // 
            lblmayinsayisi.AutoSize = true;
            lblmayinsayisi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblmayinsayisi.Location = new Point(12, 50);
            lblmayinsayisi.Name = "lblmayinsayisi";
            lblmayinsayisi.Size = new Size(0, 21);
            lblmayinsayisi.TabIndex = 3;
            lblmayinsayisi.Visible = false;
            // 
            // lblSkor
            // 
            lblSkor.AutoSize = true;
            lblSkor.BackColor = Color.Black;
            lblSkor.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSkor.ForeColor = Color.Red;
            lblSkor.Location = new Point(171, 317);
            lblSkor.Name = "lblSkor";
            lblSkor.Size = new Size(0, 23);
            lblSkor.TabIndex = 4;
            // 
            // frmMT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(584, 561);
            Controls.Add(lblSkor);
            Controls.Add(lblmayinsayisi);
            Controls.Add(lblkalantiklama);
            Controls.Add(lblBaslangic);
            Controls.Add(menuStripMT);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStripMT;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMT";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmMT_Load;
            KeyDown += frmMT_KeyDown;
            menuStripMT.ResumeLayout(false);
            menuStripMT.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMT;
        private ToolStripMenuItem toolStripTextBoxSure;
        private ToolStripMenuItem zorlukToolStripMenuItem;
        private ToolStripMenuItem kolaytoolStripMenuItem;
        private ToolStripMenuItem ortaToolStripMenuItem;
        private ToolStripMenuItem zorToolStripMenuItem;
        private Label lblBaslangic;
        private ToolStripMenuItem gosterToolStripMenuItem;
        private Label lblkalantiklama;
        private Label lblmayinsayisi;
        private Label lblSkor;
    }
}