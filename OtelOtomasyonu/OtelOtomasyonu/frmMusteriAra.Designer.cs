namespace OtelOtomasyonu
{
    partial class frmMusteriAra
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.AnasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RezervasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IstatistikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxKriter = new System.Windows.Forms.ComboBox();
            this.textBoxKelime = new System.Windows.Forms.TextBox();
            this.lblKriter = new System.Windows.Forms.Label();
            this.lblKelime = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.dataGridViewArama = new System.Windows.Forms.DataGridView();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArama)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.LightSeaGreen;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AnasayfaToolStripMenuItem,
            this.RezervasyonToolStripMenuItem,
            this.OdaToolStripMenuItem,
            this.PersonelToolStripMenuItem,
            this.IstatistikToolStripMenuItem,
            this.CikisToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(536, 29);
            this.menuStrip.TabIndex = 2;
            // 
            // AnasayfaToolStripMenuItem
            // 
            this.AnasayfaToolStripMenuItem.Checked = true;
            this.AnasayfaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AnasayfaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnasayfaToolStripMenuItem.Name = "AnasayfaToolStripMenuItem";
            this.AnasayfaToolStripMenuItem.Size = new System.Drawing.Size(98, 25);
            this.AnasayfaToolStripMenuItem.Text = "ANASAYFA";
            this.AnasayfaToolStripMenuItem.Click += new System.EventHandler(this.ANASAYFAToolStripMenuItem_Click);
            // 
            // RezervasyonToolStripMenuItem
            // 
            this.RezervasyonToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RezervasyonToolStripMenuItem.Name = "RezervasyonToolStripMenuItem";
            this.RezervasyonToolStripMenuItem.Size = new System.Drawing.Size(127, 25);
            this.RezervasyonToolStripMenuItem.Text = "REZERVASYON";
            this.RezervasyonToolStripMenuItem.Click += new System.EventHandler(this.REZERVASYONToolStripMenuItem_Click_1);
            // 
            // OdaToolStripMenuItem
            // 
            this.OdaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OdaToolStripMenuItem.Name = "OdaToolStripMenuItem";
            this.OdaToolStripMenuItem.Size = new System.Drawing.Size(55, 25);
            this.OdaToolStripMenuItem.Text = "ODA";
            this.OdaToolStripMenuItem.Click += new System.EventHandler(this.ODAToolStripMenuItem_Click_1);
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
            this.CikisToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click_1);
            // 
            // comboBoxKriter
            // 
            this.comboBoxKriter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKriter.FormattingEnabled = true;
            this.comboBoxKriter.Location = new System.Drawing.Point(198, 43);
            this.comboBoxKriter.Name = "comboBoxKriter";
            this.comboBoxKriter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKriter.TabIndex = 3;
            // 
            // textBoxKelime
            // 
            this.textBoxKelime.Location = new System.Drawing.Point(208, 70);
            this.textBoxKelime.Name = "textBoxKelime";
            this.textBoxKelime.Size = new System.Drawing.Size(100, 20);
            this.textBoxKelime.TabIndex = 4;
            // 
            // lblKriter
            // 
            this.lblKriter.AutoSize = true;
            this.lblKriter.Location = new System.Drawing.Point(109, 46);
            this.lblKriter.Name = "lblKriter";
            this.lblKriter.Size = new System.Drawing.Size(83, 13);
            this.lblKriter.TabIndex = 6;
            this.lblKriter.Text = "Aranacak Kriter:";
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Location = new System.Drawing.Point(113, 73);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(90, 13);
            this.lblKelime.TabIndex = 7;
            this.lblKelime.Text = "Aranacak Kelime:";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.LightGray;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Location = new System.Drawing.Point(379, 56);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 30);
            this.btnAra.TabIndex = 8;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // dataGridViewArama
            // 
            this.dataGridViewArama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArama.Location = new System.Drawing.Point(12, 127);
            this.dataGridViewArama.Name = "dataGridViewArama";
            this.dataGridViewArama.Size = new System.Drawing.Size(506, 318);
            this.dataGridViewArama.TabIndex = 9;
            // 
            // frmMusteriAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(536, 453);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewArama);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.lblKriter);
            this.Controls.Add(this.textBoxKelime);
            this.Controls.Add(this.comboBoxKriter);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMusteriAra";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Arama";
            this.Load += new System.EventHandler(this.MusteriArama_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem AnasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RezervasyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IstatistikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CikisToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxKriter;
        private System.Windows.Forms.TextBox textBoxKelime;
        private System.Windows.Forms.Label lblKriter;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dataGridViewArama;
        private System.Windows.Forms.ToolStripMenuItem PersonelToolStripMenuItem;
    }
}