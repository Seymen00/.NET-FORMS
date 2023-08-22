namespace OtelOtomasyonu
{
    partial class FormRezervasyon
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
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.textAdSoyad = new System.Windows.Forms.TextBox();
            this.dateTimePCheckin = new System.Windows.Forms.DateTimePicker();
            this.dateTimeCheckout = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboOdaNumara = new System.Windows.Forms.ComboBox();
            this.lblOdaTipi = new System.Windows.Forms.Label();
            this.radioTek = new System.Windows.Forms.RadioButton();
            this.radioCift = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AnasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MÜŞTERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MusteriEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MusteriAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IstatistikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonkayit = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dataGridViewRezervasyon = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.rezervasyonkayit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervasyon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.Black;
            this.lblAdSoyad.Location = new System.Drawing.Point(5, 16);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(70, 16);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // textAdSoyad
            // 
            this.textAdSoyad.Location = new System.Drawing.Point(79, 15);
            this.textAdSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.textAdSoyad.Name = "textAdSoyad";
            this.textAdSoyad.Size = new System.Drawing.Size(92, 20);
            this.textAdSoyad.TabIndex = 1;
            // 
            // dateTimePCheckin
            // 
            this.dateTimePCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePCheckin.Location = new System.Drawing.Point(79, 39);
            this.dateTimePCheckin.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePCheckin.Name = "dateTimePCheckin";
            this.dateTimePCheckin.Size = new System.Drawing.Size(92, 20);
            this.dateTimePCheckin.TabIndex = 2;
            // 
            // dateTimeCheckout
            // 
            this.dateTimeCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeCheckout.Location = new System.Drawing.Point(79, 63);
            this.dateTimeCheckout.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeCheckout.Name = "dateTimeCheckout";
            this.dateTimeCheckout.Size = new System.Drawing.Size(92, 20);
            this.dateTimeCheckout.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Check in:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(4, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Check out:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Oda No:";
            // 
            // comboOdaNumara
            // 
            this.comboOdaNumara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOdaNumara.FormattingEnabled = true;
            this.comboOdaNumara.Location = new System.Drawing.Point(79, 121);
            this.comboOdaNumara.Margin = new System.Windows.Forms.Padding(2);
            this.comboOdaNumara.Name = "comboOdaNumara";
            this.comboOdaNumara.Size = new System.Drawing.Size(92, 21);
            this.comboOdaNumara.TabIndex = 10;
            // 
            // lblOdaTipi
            // 
            this.lblOdaTipi.AutoSize = true;
            this.lblOdaTipi.BackColor = System.Drawing.Color.Transparent;
            this.lblOdaTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaTipi.ForeColor = System.Drawing.Color.Black;
            this.lblOdaTipi.Location = new System.Drawing.Point(13, 97);
            this.lblOdaTipi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOdaTipi.Name = "lblOdaTipi";
            this.lblOdaTipi.Size = new System.Drawing.Size(62, 16);
            this.lblOdaTipi.TabIndex = 12;
            this.lblOdaTipi.Text = "Oda Tipi:";
            // 
            // radioTek
            // 
            this.radioTek.AutoSize = true;
            this.radioTek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioTek.Location = new System.Drawing.Point(79, 95);
            this.radioTek.Margin = new System.Windows.Forms.Padding(2);
            this.radioTek.Name = "radioTek";
            this.radioTek.Size = new System.Drawing.Size(49, 20);
            this.radioTek.TabIndex = 13;
            this.radioTek.TabStop = true;
            this.radioTek.Text = "Tek";
            this.radioTek.UseVisualStyleBackColor = true;
            this.radioTek.CheckedChanged += new System.EventHandler(this.radioTek_CheckedChanged);
            // 
            // radioCift
            // 
            this.radioCift.AutoSize = true;
            this.radioCift.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioCift.Location = new System.Drawing.Point(132, 95);
            this.radioCift.Margin = new System.Windows.Forms.Padding(2);
            this.radioCift.Name = "radioCift";
            this.radioCift.Size = new System.Drawing.Size(43, 20);
            this.radioCift.TabIndex = 14;
            this.radioCift.TabStop = true;
            this.radioCift.Text = "Çift";
            this.radioCift.UseVisualStyleBackColor = true;
            this.radioCift.CheckedChanged += new System.EventHandler(this.radioCift_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AnasayfaToolStripMenuItem,
            this.OdaToolStripMenuItem,
            this.MÜŞTERİToolStripMenuItem,
            this.PersonelToolStripMenuItem,
            this.IstatistikToolStripMenuItem,
            this.CikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(530, 29);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AnasayfaToolStripMenuItem
            // 
            this.AnasayfaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.AnasayfaToolStripMenuItem.Name = "AnasayfaToolStripMenuItem";
            this.AnasayfaToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.AnasayfaToolStripMenuItem.Text = "ANASAYFA";
            this.AnasayfaToolStripMenuItem.Click += new System.EventHandler(this.aNASAYFAToolStripMenuItem_Click);
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
            // rezervasyonkayit
            // 
            this.rezervasyonkayit.BackColor = System.Drawing.Color.MediumAquamarine;
            this.rezervasyonkayit.Controls.Add(this.lblAdSoyad);
            this.rezervasyonkayit.Controls.Add(this.label2);
            this.rezervasyonkayit.Controls.Add(this.textAdSoyad);
            this.rezervasyonkayit.Controls.Add(this.radioCift);
            this.rezervasyonkayit.Controls.Add(this.dateTimePCheckin);
            this.rezervasyonkayit.Controls.Add(this.radioTek);
            this.rezervasyonkayit.Controls.Add(this.comboOdaNumara);
            this.rezervasyonkayit.Controls.Add(this.dateTimeCheckout);
            this.rezervasyonkayit.Controls.Add(this.lblOdaTipi);
            this.rezervasyonkayit.Controls.Add(this.label3);
            this.rezervasyonkayit.Controls.Add(this.label5);
            this.rezervasyonkayit.Location = new System.Drawing.Point(12, 36);
            this.rezervasyonkayit.Name = "rezervasyonkayit";
            this.rezervasyonkayit.Size = new System.Drawing.Size(190, 158);
            this.rezervasyonkayit.TabIndex = 17;
            this.rezervasyonkayit.TabStop = false;
            this.rezervasyonkayit.Text = "Kayıt Ekleme";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(225, 119);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 30);
            this.btnSil.TabIndex = 16;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Lime;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.Location = new System.Drawing.Point(225, 71);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 30);
            this.btnEkle.TabIndex = 15;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dataGridViewRezervasyon
            // 
            this.dataGridViewRezervasyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRezervasyon.Location = new System.Drawing.Point(7, 200);
            this.dataGridViewRezervasyon.Name = "dataGridViewRezervasyon";
            this.dataGridViewRezervasyon.Size = new System.Drawing.Size(515, 245);
            this.dataGridViewRezervasyon.TabIndex = 18;
            // 
            // FormRezervasyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(530, 457);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewRezervasyon);
            this.Controls.Add(this.rezervasyonkayit);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormRezervasyon";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon İşlemleri";
            this.Load += new System.EventHandler(this.FormRezervasyon_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.rezervasyonkayit.ResumeLayout(false);
            this.rezervasyonkayit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRezervasyon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox textAdSoyad;
        private System.Windows.Forms.DateTimePicker dateTimePCheckin;
        private System.Windows.Forms.DateTimePicker dateTimeCheckout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboOdaNumara;
        private System.Windows.Forms.Label lblOdaTipi;
        private System.Windows.Forms.RadioButton radioTek;
        private System.Windows.Forms.RadioButton radioCift;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MÜŞTERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MusteriEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MusteriAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IstatistikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AnasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CikisToolStripMenuItem;
        private System.Windows.Forms.GroupBox rezervasyonkayit;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dataGridViewRezervasyon;
        private System.Windows.Forms.ToolStripMenuItem PersonelToolStripMenuItem;
    }
}