namespace OtelOtomasyonu
{
    partial class FormMUSTERI
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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTcKimlik = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.dateTimeDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblDogumT = new System.Windows.Forms.Label();
            this.comboCinsiyet = new System.Windows.Forms.ComboBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtTcKimlik = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AnasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RezervasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IstatistikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewMusterKayit = new System.Windows.Forms.DataGridView();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.groupBoxKimlik = new System.Windows.Forms.GroupBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBoxIletisim = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusterKayit)).BeginInit();
            this.groupBoxKimlik.SuspendLayout();
            this.groupBoxIletisim.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.ForeColor = System.Drawing.Color.Black;
            this.lblAd.Location = new System.Drawing.Point(55, 15);
            this.lblAd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(26, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad :";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.ForeColor = System.Drawing.Color.Black;
            this.lblSoyad.Location = new System.Drawing.Point(41, 44);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(40, 13);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblTcKimlik
            // 
            this.lblTcKimlik.AutoSize = true;
            this.lblTcKimlik.Location = new System.Drawing.Point(8, 100);
            this.lblTcKimlik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTcKimlik.Name = "lblTcKimlik";
            this.lblTcKimlik.Size = new System.Drawing.Size(73, 13);
            this.lblTcKimlik.TabIndex = 2;
            this.lblTcKimlik.Text = "TC/Kimlik No:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(5, 15);
            this.lblTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(46, 13);
            this.lblTel.TabIndex = 3;
            this.lblTel.Text = "Telefon:";
            // 
            // dateTimeDogumTarihi
            // 
            this.dateTimeDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDogumTarihi.Location = new System.Drawing.Point(85, 124);
            this.dateTimeDogumTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeDogumTarihi.Name = "dateTimeDogumTarihi";
            this.dateTimeDogumTarihi.Size = new System.Drawing.Size(107, 20);
            this.dateTimeDogumTarihi.TabIndex = 4;
            // 
            // lblDogumT
            // 
            this.lblDogumT.AutoSize = true;
            this.lblDogumT.Location = new System.Drawing.Point(8, 130);
            this.lblDogumT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDogumT.Name = "lblDogumT";
            this.lblDogumT.Size = new System.Drawing.Size(73, 13);
            this.lblDogumT.TabIndex = 5;
            this.lblDogumT.Text = "Doğum Tarihi:";
            // 
            // comboCinsiyet
            // 
            this.comboCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCinsiyet.FormattingEnabled = true;
            this.comboCinsiyet.Items.AddRange(new object[] {
            "Erkek ",
            "Kadın"});
            this.comboCinsiyet.Location = new System.Drawing.Point(85, 68);
            this.comboCinsiyet.Margin = new System.Windows.Forms.Padding(2);
            this.comboCinsiyet.Name = "comboCinsiyet";
            this.comboCinsiyet.Size = new System.Drawing.Size(51, 21);
            this.comboCinsiyet.TabIndex = 6;
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(38, 71);
            this.lblCinsiyet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(43, 13);
            this.lblCinsiyet.TabIndex = 7;
            this.lblCinsiyet.Text = "Cinsiyet";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(85, 12);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(107, 20);
            this.txtAd.TabIndex = 10;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(85, 41);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(107, 20);
            this.txtSoyad.TabIndex = 11;
            // 
            // txtTcKimlik
            // 
            this.txtTcKimlik.Location = new System.Drawing.Point(85, 97);
            this.txtTcKimlik.Margin = new System.Windows.Forms.Padding(2);
            this.txtTcKimlik.MaxLength = 16;
            this.txtTcKimlik.Name = "txtTcKimlik";
            this.txtTcKimlik.Size = new System.Drawing.Size(107, 20);
            this.txtTcKimlik.TabIndex = 12;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(55, 12);
            this.txtTel.Margin = new System.Windows.Forms.Padding(2);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(92, 20);
            this.txtTel.TabIndex = 13;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(14, 71);
            this.lblAdres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(37, 13);
            this.lblAdres.TabIndex = 22;
            this.lblAdres.Text = "Adres:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(55, 71);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(92, 46);
            this.txtAdres.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AnasayfaToolStripMenuItem,
            this.RezervasyonToolStripMenuItem,
            this.OdaToolStripMenuItem,
            this.PersonelToolStripMenuItem,
            this.IstatistikToolStripMenuItem,
            this.CikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(536, 29);
            this.menuStrip1.TabIndex = 29;
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
            this.RezervasyonToolStripMenuItem.Click += new System.EventHandler(this.RezervasyonToolStripMenuItem_Click_1);
            // 
            // OdaToolStripMenuItem
            // 
            this.OdaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OdaToolStripMenuItem.Name = "OdaToolStripMenuItem";
            this.OdaToolStripMenuItem.Size = new System.Drawing.Size(55, 25);
            this.OdaToolStripMenuItem.Text = "ODA";
            this.OdaToolStripMenuItem.Click += new System.EventHandler(this.OdaToolStripMenuItem_Click_1);
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
            // 
            // CikisToolStripMenuItem
            // 
            this.CikisToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CikisToolStripMenuItem.Name = "CikisToolStripMenuItem";
            this.CikisToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
            this.CikisToolStripMenuItem.Text = "ÇIKIŞ";
            this.CikisToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // dataGridViewMusterKayit
            // 
            this.dataGridViewMusterKayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusterKayit.Location = new System.Drawing.Point(12, 209);
            this.dataGridViewMusterKayit.Name = "dataGridViewMusterKayit";
            this.dataGridViewMusterKayit.Size = new System.Drawing.Size(516, 236);
            this.dataGridViewMusterKayit.TabIndex = 30;
            this.dataGridViewMusterKayit.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMusterKayit_CellDoubleClick);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 44);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "E-mail:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(55, 41);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(92, 20);
            this.textBoxEmail.TabIndex = 31;
            // 
            // groupBoxKimlik
            // 
            this.groupBoxKimlik.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBoxKimlik.Controls.Add(this.txtTcKimlik);
            this.groupBoxKimlik.Controls.Add(this.txtSoyad);
            this.groupBoxKimlik.Controls.Add(this.txtAd);
            this.groupBoxKimlik.Controls.Add(this.lblCinsiyet);
            this.groupBoxKimlik.Controls.Add(this.comboCinsiyet);
            this.groupBoxKimlik.Controls.Add(this.lblDogumT);
            this.groupBoxKimlik.Controls.Add(this.dateTimeDogumTarihi);
            this.groupBoxKimlik.Controls.Add(this.lblTcKimlik);
            this.groupBoxKimlik.Controls.Add(this.lblSoyad);
            this.groupBoxKimlik.Controls.Add(this.lblAd);
            this.groupBoxKimlik.Location = new System.Drawing.Point(12, 39);
            this.groupBoxKimlik.Name = "groupBoxKimlik";
            this.groupBoxKimlik.Size = new System.Drawing.Size(215, 160);
            this.groupBoxKimlik.TabIndex = 32;
            this.groupBoxKimlik.TabStop = false;
            this.groupBoxKimlik.Text = "Kimlik Bilgileri";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.Silver;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.ForeColor = System.Drawing.Color.Black;
            this.btnDuzenle.Location = new System.Drawing.Point(429, 116);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(80, 30);
            this.btnDuzenle.TabIndex = 35;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(429, 152);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 30);
            this.btnSil.TabIndex = 34;
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
            this.btnEkle.Location = new System.Drawing.Point(429, 44);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 30);
            this.btnEkle.TabIndex = 33;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBoxIletisim
            // 
            this.groupBoxIletisim.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBoxIletisim.Controls.Add(this.textBoxEmail);
            this.groupBoxIletisim.Controls.Add(this.txtAdres);
            this.groupBoxIletisim.Controls.Add(this.lblAdres);
            this.groupBoxIletisim.Controls.Add(this.lblEmail);
            this.groupBoxIletisim.Controls.Add(this.txtTel);
            this.groupBoxIletisim.Controls.Add(this.lblTel);
            this.groupBoxIletisim.Location = new System.Drawing.Point(233, 39);
            this.groupBoxIletisim.Name = "groupBoxIletisim";
            this.groupBoxIletisim.Size = new System.Drawing.Size(172, 131);
            this.groupBoxIletisim.TabIndex = 36;
            this.groupBoxIletisim.TabStop = false;
            this.groupBoxIletisim.Text = "İletişim Bilgileri";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Magenta;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.Black;
            this.btnTemizle.Location = new System.Drawing.Point(429, 80);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(80, 30);
            this.btnTemizle.TabIndex = 37;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormMUSTERI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(536, 445);
            this.ControlBox = false;
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.groupBoxIletisim);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBoxKimlik);
            this.Controls.Add(this.dataGridViewMusterKayit);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMUSTERI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri İşlemleri";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusterKayit)).EndInit();
            this.groupBoxKimlik.ResumeLayout(false);
            this.groupBoxKimlik.PerformLayout();
            this.groupBoxIletisim.ResumeLayout(false);
            this.groupBoxIletisim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTcKimlik;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.DateTimePicker dateTimeDogumTarihi;
        private System.Windows.Forms.Label lblDogumT;
        private System.Windows.Forms.ComboBox comboCinsiyet;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTcKimlik;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RezervasyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AnasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IstatistikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CikisToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewMusterKayit;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.GroupBox groupBoxKimlik;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBoxIletisim;
        private System.Windows.Forms.ToolStripMenuItem PersonelToolStripMenuItem;
        private System.Windows.Forms.Button btnTemizle;
    }
}