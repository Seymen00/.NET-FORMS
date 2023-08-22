namespace OtelOtomasyonu
{
    partial class frmPersonel
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AnasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RezervasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MÜŞTERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MusteriEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MusteriAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IstatistikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAd = new System.Windows.Forms.Label();
            this.lbSoyad = new System.Windows.Forms.Label();
            this.dataGridViewPersonel = new System.Windows.Forms.DataGridView();
            this.lblDTarih = new System.Windows.Forms.Label();
            this.dateTimePickerDTarih = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPersonelB = new System.Windows.Forms.GroupBox();
            this.comboBoxCins = new System.Windows.Forms.ComboBox();
            this.lblCins = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.btnKullaniciOner = new System.Windows.Forms.Button();
            this.groupBoxGirisB = new System.Windows.Forms.GroupBox();
            this.lblSifreYeniden = new System.Windows.Forms.Label();
            this.textBoxSifreYeniden = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lbKullaniciAdi = new System.Windows.Forms.Label();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.btnSifreOner = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.timerSifre = new System.Windows.Forms.Timer(this.components);
            this.btnTemizle = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).BeginInit();
            this.groupBoxPersonelB.SuspendLayout();
            this.groupBoxGirisB.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AnasayfaToolStripMenuItem,
            this.RezervasyonToolStripMenuItem,
            this.OdaToolStripMenuItem,
            this.MÜŞTERİToolStripMenuItem,
            this.IstatistikToolStripMenuItem,
            this.CikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(576, 29);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AnasayfaToolStripMenuItem
            // 
            this.AnasayfaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
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
            this.RezervasyonToolStripMenuItem.Click += new System.EventHandler(this.RezervasyonToolStripMenuItem_Click);
            // 
            // OdaToolStripMenuItem
            // 
            this.OdaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OdaToolStripMenuItem.Name = "OdaToolStripMenuItem";
            this.OdaToolStripMenuItem.Size = new System.Drawing.Size(55, 25);
            this.OdaToolStripMenuItem.Text = "ODA";
            this.OdaToolStripMenuItem.Click += new System.EventHandler(this.OdaToolStripMenuItem_Click);
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
            this.MusteriAraToolStripMenuItem.Click += new System.EventHandler(this.MusteriAraToolStripMenuItem_Click);
            // 
            // IstatistikToolStripMenuItem
            // 
            this.IstatistikToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IstatistikToolStripMenuItem.Name = "IstatistikToolStripMenuItem";
            this.IstatistikToolStripMenuItem.Size = new System.Drawing.Size(93, 25);
            this.IstatistikToolStripMenuItem.Text = "İSTATİSTİK";
            this.IstatistikToolStripMenuItem.Click += new System.EventHandler(this.IstatistikToolStripMenuItem_Click);
            // 
            // CikisToolStripMenuItem
            // 
            this.CikisToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CikisToolStripMenuItem.Name = "CikisToolStripMenuItem";
            this.CikisToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.CikisToolStripMenuItem.Text = "ÇIKIŞ";
            this.CikisToolStripMenuItem.Click += new System.EventHandler(this.CikisToolStripMenuItem_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(55, 22);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(23, 13);
            this.lblAd.TabIndex = 18;
            this.lblAd.Text = "Ad:";
            // 
            // lbSoyad
            // 
            this.lbSoyad.AutoSize = true;
            this.lbSoyad.Location = new System.Drawing.Point(38, 48);
            this.lbSoyad.Name = "lbSoyad";
            this.lbSoyad.Size = new System.Drawing.Size(40, 13);
            this.lbSoyad.TabIndex = 19;
            this.lbSoyad.Text = "Soyad:";
            // 
            // dataGridViewPersonel
            // 
            this.dataGridViewPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonel.Location = new System.Drawing.Point(12, 226);
            this.dataGridViewPersonel.Name = "dataGridViewPersonel";
            this.dataGridViewPersonel.Size = new System.Drawing.Size(560, 219);
            this.dataGridViewPersonel.TabIndex = 20;
            // 
            // lblDTarih
            // 
            this.lblDTarih.AutoSize = true;
            this.lblDTarih.Location = new System.Drawing.Point(5, 77);
            this.lblDTarih.Name = "lblDTarih";
            this.lblDTarih.Size = new System.Drawing.Size(73, 13);
            this.lblDTarih.TabIndex = 21;
            this.lblDTarih.Text = "Doğum Tarihi:";
            // 
            // dateTimePickerDTarih
            // 
            this.dateTimePickerDTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDTarih.Location = new System.Drawing.Point(84, 71);
            this.dateTimePickerDTarih.Name = "dateTimePickerDTarih";
            this.dateTimePickerDTarih.Size = new System.Drawing.Size(99, 20);
            this.dateTimePickerDTarih.TabIndex = 22;
            // 
            // groupBoxPersonelB
            // 
            this.groupBoxPersonelB.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBoxPersonelB.Controls.Add(this.comboBoxCins);
            this.groupBoxPersonelB.Controls.Add(this.lblCins);
            this.groupBoxPersonelB.Controls.Add(this.textBoxSoyad);
            this.groupBoxPersonelB.Controls.Add(this.textBoxAd);
            this.groupBoxPersonelB.Controls.Add(this.dateTimePickerDTarih);
            this.groupBoxPersonelB.Controls.Add(this.lblAd);
            this.groupBoxPersonelB.Controls.Add(this.lblDTarih);
            this.groupBoxPersonelB.Controls.Add(this.lbSoyad);
            this.groupBoxPersonelB.Location = new System.Drawing.Point(28, 48);
            this.groupBoxPersonelB.Name = "groupBoxPersonelB";
            this.groupBoxPersonelB.Size = new System.Drawing.Size(200, 136);
            this.groupBoxPersonelB.TabIndex = 23;
            this.groupBoxPersonelB.TabStop = false;
            this.groupBoxPersonelB.Text = "Personel Bilgileri";
            // 
            // comboBoxCins
            // 
            this.comboBoxCins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCins.FormattingEnabled = true;
            this.comboBoxCins.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBoxCins.Location = new System.Drawing.Point(84, 97);
            this.comboBoxCins.Name = "comboBoxCins";
            this.comboBoxCins.Size = new System.Drawing.Size(99, 21);
            this.comboBoxCins.TabIndex = 25;
            // 
            // lblCins
            // 
            this.lblCins.AutoSize = true;
            this.lblCins.Location = new System.Drawing.Point(32, 101);
            this.lblCins.Name = "lblCins";
            this.lblCins.Size = new System.Drawing.Size(46, 13);
            this.lblCins.TabIndex = 24;
            this.lblCins.Text = "Cinsiyet:";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(84, 45);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(100, 20);
            this.textBoxSoyad.TabIndex = 23;
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(84, 19);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(100, 20);
            this.textBoxAd.TabIndex = 0;
            // 
            // btnKullaniciOner
            // 
            this.btnKullaniciOner.Location = new System.Drawing.Point(205, 25);
            this.btnKullaniciOner.Name = "btnKullaniciOner";
            this.btnKullaniciOner.Size = new System.Drawing.Size(98, 23);
            this.btnKullaniciOner.TabIndex = 24;
            this.btnKullaniciOner.Text = "Kullanıcı Adı Öner";
            this.btnKullaniciOner.UseVisualStyleBackColor = true;
            this.btnKullaniciOner.Click += new System.EventHandler(this.btnKullaniciOner_Click);
            // 
            // groupBoxGirisB
            // 
            this.groupBoxGirisB.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBoxGirisB.Controls.Add(this.lblSifreYeniden);
            this.groupBoxGirisB.Controls.Add(this.textBoxSifreYeniden);
            this.groupBoxGirisB.Controls.Add(this.lblSifre);
            this.groupBoxGirisB.Controls.Add(this.lbKullaniciAdi);
            this.groupBoxGirisB.Controls.Add(this.textBoxSifre);
            this.groupBoxGirisB.Controls.Add(this.textBoxKullaniciAdi);
            this.groupBoxGirisB.Controls.Add(this.btnSifreOner);
            this.groupBoxGirisB.Controls.Add(this.btnKullaniciOner);
            this.groupBoxGirisB.Location = new System.Drawing.Point(263, 48);
            this.groupBoxGirisB.Name = "groupBoxGirisB";
            this.groupBoxGirisB.Size = new System.Drawing.Size(309, 136);
            this.groupBoxGirisB.TabIndex = 25;
            this.groupBoxGirisB.TabStop = false;
            this.groupBoxGirisB.Text = "Giriş Bilgileri";
            // 
            // lblSifreYeniden
            // 
            this.lblSifreYeniden.AutoSize = true;
            this.lblSifreYeniden.Location = new System.Drawing.Point(11, 101);
            this.lblSifreYeniden.Name = "lblSifreYeniden";
            this.lblSifreYeniden.Size = new System.Drawing.Size(73, 13);
            this.lblSifreYeniden.TabIndex = 31;
            this.lblSifreYeniden.Text = "Şifre Yeniden:\r\n";
            // 
            // textBoxSifreYeniden
            // 
            this.textBoxSifreYeniden.Location = new System.Drawing.Point(90, 98);
            this.textBoxSifreYeniden.Name = "textBoxSifreYeniden";
            this.textBoxSifreYeniden.Size = new System.Drawing.Size(100, 20);
            this.textBoxSifreYeniden.TabIndex = 30;
            this.textBoxSifreYeniden.TextChanged += new System.EventHandler(this.textBoxSifreYeniden_TextChanged);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(53, 77);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(31, 13);
            this.lblSifre.TabIndex = 29;
            this.lblSifre.Text = "Şifre:\r\n";
            // 
            // lbKullaniciAdi
            // 
            this.lbKullaniciAdi.AutoSize = true;
            this.lbKullaniciAdi.Location = new System.Drawing.Point(17, 22);
            this.lbKullaniciAdi.Name = "lbKullaniciAdi";
            this.lbKullaniciAdi.Size = new System.Drawing.Size(67, 13);
            this.lbKullaniciAdi.TabIndex = 28;
            this.lbKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(90, 74);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(100, 20);
            this.textBoxSifre.TabIndex = 27;
            this.textBoxSifre.TextChanged += new System.EventHandler(this.textBoxSifre_TextChanged);
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(90, 19);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.textBoxKullaniciAdi.TabIndex = 26;
            // 
            // btnSifreOner
            // 
            this.btnSifreOner.Location = new System.Drawing.Point(205, 77);
            this.btnSifreOner.Name = "btnSifreOner";
            this.btnSifreOner.Size = new System.Drawing.Size(98, 23);
            this.btnSifreOner.TabIndex = 25;
            this.btnSifreOner.Text = "Şifre Öner";
            this.btnSifreOner.UseVisualStyleBackColor = true;
            this.btnSifreOner.Click += new System.EventHandler(this.btnSifreOner_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.Silver;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.ForeColor = System.Drawing.Color.Black;
            this.btnDuzenle.Location = new System.Drawing.Point(398, 190);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(80, 30);
            this.btnDuzenle.TabIndex = 38;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(484, 190);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 30);
            this.btnSil.TabIndex = 37;
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
            this.btnEkle.Location = new System.Drawing.Point(226, 190);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 30);
            this.btnEkle.TabIndex = 36;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerSifre
            // 
            this.timerSifre.Interval = 500;
            this.timerSifre.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Magenta;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.Black;
            this.btnTemizle.Location = new System.Drawing.Point(312, 190);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(80, 30);
            this.btnTemizle.TabIndex = 39;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // frmPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(576, 453);
            this.ControlBox = false;
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBoxGirisB);
            this.Controls.Add(this.groupBoxPersonelB);
            this.Controls.Add(this.dataGridViewPersonel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmPersonel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlemleri";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).EndInit();
            this.groupBoxPersonelB.ResumeLayout(false);
            this.groupBoxPersonelB.PerformLayout();
            this.groupBoxGirisB.ResumeLayout(false);
            this.groupBoxGirisB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AnasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MÜŞTERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MusteriEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MusteriAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IstatistikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RezervasyonToolStripMenuItem;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lbSoyad;
        private System.Windows.Forms.DataGridView dataGridViewPersonel;
        private System.Windows.Forms.Label lblDTarih;
        private System.Windows.Forms.DateTimePicker dateTimePickerDTarih;
        private System.Windows.Forms.GroupBox groupBoxPersonelB;
        private System.Windows.Forms.Label lblCins;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.ComboBox comboBoxCins;
        private System.Windows.Forms.Button btnKullaniciOner;
        private System.Windows.Forms.GroupBox groupBoxGirisB;
        private System.Windows.Forms.Label lbKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.Button btnSifreOner;
        private System.Windows.Forms.Label lblSifreYeniden;
        private System.Windows.Forms.TextBox textBoxSifreYeniden;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Timer timerSifre;
        private System.Windows.Forms.Button btnTemizle;
    }
}