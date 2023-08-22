namespace OtelOtomasyonu
{
    partial class FormAnasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnasayfa));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.RezervasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MÜŞTERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MusteriEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MusteriAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IstatistikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RezervasyonToolStripMenuItem,
            this.OdaToolStripMenuItem,
            this.MÜŞTERİToolStripMenuItem,
            this.PersonelToolStripMenuItem,
            this.IstatistikToolStripMenuItem,
            this.CikisToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(530, 29);
            this.menuStrip.TabIndex = 1;
            // 
            // RezervasyonToolStripMenuItem
            // 
            this.RezervasyonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RezervasyonToolStripMenuItem.Name = "RezervasyonToolStripMenuItem";
            this.RezervasyonToolStripMenuItem.Size = new System.Drawing.Size(127, 25);
            this.RezervasyonToolStripMenuItem.Text = "REZERVASYON";
            this.RezervasyonToolStripMenuItem.Click += new System.EventHandler(this.REZERVASYONToolStripMenuItem_Click);
            // 
            // OdaToolStripMenuItem
            // 
            this.OdaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OdaToolStripMenuItem.Name = "OdaToolStripMenuItem";
            this.OdaToolStripMenuItem.Size = new System.Drawing.Size(55, 25);
            this.OdaToolStripMenuItem.Text = "ODA";
            this.OdaToolStripMenuItem.Click += new System.EventHandler(this.ODAToolStripMenuItem_Click);
            // 
            // MÜŞTERİToolStripMenuItem
            // 
            this.MÜŞTERİToolStripMenuItem.Checked = true;
            this.MÜŞTERİToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MÜŞTERİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MusteriEklemeToolStripMenuItem,
            this.MusteriAraToolStripMenuItem});
            this.MÜŞTERİToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MÜŞTERİToolStripMenuItem.Name = "MÜŞTERİToolStripMenuItem";
            this.MÜŞTERİToolStripMenuItem.Size = new System.Drawing.Size(86, 25);
            this.MÜŞTERİToolStripMenuItem.Text = "MÜŞTERİ";
            // 
            // MusteriEklemeToolStripMenuItem
            // 
            this.MusteriEklemeToolStripMenuItem.Name = "MusteriEklemeToolStripMenuItem";
            this.MusteriEklemeToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.MusteriEklemeToolStripMenuItem.Text = "Müşteri Ekleme";
            this.MusteriEklemeToolStripMenuItem.Click += new System.EventHandler(this.müşteriEklemeToolStripMenuItem_Click);
            // 
            // MusteriAraToolStripMenuItem
            // 
            this.MusteriAraToolStripMenuItem.Name = "MusteriAraToolStripMenuItem";
            this.MusteriAraToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.MusteriAraToolStripMenuItem.Text = "Müşteri Ara";
            this.MusteriAraToolStripMenuItem.Click += new System.EventHandler(this.müşteriAraToolStripMenuItem_Click);
            // 
            // PersonelToolStripMenuItem
            // 
            this.PersonelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PersonelToolStripMenuItem.Name = "PersonelToolStripMenuItem";
            this.PersonelToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.PersonelToolStripMenuItem.Text = "PERSONEL";
            this.PersonelToolStripMenuItem.Click += new System.EventHandler(this.PersonelToolStripMenuItem_Click);
            // 
            // IstatistikToolStripMenuItem
            // 
            this.IstatistikToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IstatistikToolStripMenuItem.Name = "IstatistikToolStripMenuItem";
            this.IstatistikToolStripMenuItem.Size = new System.Drawing.Size(93, 25);
            this.IstatistikToolStripMenuItem.Text = "İSTATİSTİK";
            this.IstatistikToolStripMenuItem.Click += new System.EventHandler(this.iSTATİSTİKToolStripMenuItem_Click_1);
            // 
            // CikisToolStripMenuItem
            // 
            this.CikisToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CikisToolStripMenuItem.Name = "CikisToolStripMenuItem";
            this.CikisToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.CikisToolStripMenuItem.Text = "ÇIKIŞ";
            this.CikisToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.MediumAquamarine;
            this.statusStrip.Location = new System.Drawing.Point(0, 435);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(530, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(530, 457);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormAnasayfa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem RezervasyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MÜŞTERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MusteriEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MusteriAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IstatistikToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem CikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PersonelToolStripMenuItem;
    }
}