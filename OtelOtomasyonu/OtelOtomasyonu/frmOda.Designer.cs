namespace OtelOtomasyonu
{
    partial class FormOda
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AnasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RezervasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MÜŞTERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MusteriEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MusteriAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IstatistikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDoda = new System.Windows.Forms.Button();
            this.btnBoda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AnasayfaToolStripMenuItem,
            this.RezervasyonToolStripMenuItem,
            this.MÜŞTERİToolStripMenuItem,
            this.PersonelToolStripMenuItem,
            this.IstatistikToolStripMenuItem,
            this.CikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(564, 29);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AnasayfaToolStripMenuItem
            // 
            this.AnasayfaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnasayfaToolStripMenuItem.Name = "AnasayfaToolStripMenuItem";
            this.AnasayfaToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.AnasayfaToolStripMenuItem.Text = "ANASAYFA";
            this.AnasayfaToolStripMenuItem.Click += new System.EventHandler(this.AnasayfaToolStripMenuItem_Click);
            // 
            // RezervasyonToolStripMenuItem
            // 
            this.RezervasyonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RezervasyonToolStripMenuItem.Name = "RezervasyonToolStripMenuItem";
            this.RezervasyonToolStripMenuItem.Size = new System.Drawing.Size(127, 25);
            this.RezervasyonToolStripMenuItem.Text = "REZERVASYON";
            this.RezervasyonToolStripMenuItem.Click += new System.EventHandler(this.REZERVASYONToolStripMenuItem_Click);
            // 
            // MÜŞTERİToolStripMenuItem
            // 
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
            this.MusteriEklemeToolStripMenuItem.Click += new System.EventHandler(this.MusteriEklemeToolStripMenuItem_Click);
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
            this.IstatistikToolStripMenuItem.Click += new System.EventHandler(this.iSTATİSTİKToolStripMenuItem_Click);
            // 
            // CikisToolStripMenuItem
            // 
            this.CikisToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CikisToolStripMenuItem.Name = "CikisToolStripMenuItem";
            this.CikisToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.CikisToolStripMenuItem.Text = "ÇIKIŞ";
            this.CikisToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // btnDoda
            // 
            this.btnDoda.BackColor = System.Drawing.Color.Red;
            this.btnDoda.Enabled = false;
            this.btnDoda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoda.ForeColor = System.Drawing.Color.White;
            this.btnDoda.Location = new System.Drawing.Point(415, 100);
            this.btnDoda.Name = "btnDoda";
            this.btnDoda.Size = new System.Drawing.Size(45, 45);
            this.btnDoda.TabIndex = 21;
            this.btnDoda.Text = "20";
            this.btnDoda.UseVisualStyleBackColor = false;
            // 
            // btnBoda
            // 
            this.btnBoda.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBoda.Enabled = false;
            this.btnBoda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBoda.ForeColor = System.Drawing.Color.White;
            this.btnBoda.Location = new System.Drawing.Point(415, 235);
            this.btnBoda.Name = "btnBoda";
            this.btnBoda.Size = new System.Drawing.Size(45, 45);
            this.btnBoda.TabIndex = 22;
            this.btnBoda.Text = "20";
            this.btnBoda.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Dolu Oda Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Boş Oda Sayısı";
            // 
            // FormOda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(564, 441);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBoda);
            this.Controls.Add(this.btnDoda);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(400, 120);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormOda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ODA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RezervasyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AnasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MÜŞTERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MusteriEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MusteriAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IstatistikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CikisToolStripMenuItem;
        private System.Windows.Forms.Button btnDoda;
        private System.Windows.Forms.Button btnBoda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem PersonelToolStripMenuItem;
    }
}