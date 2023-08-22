using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class frmPersonel : Form
    {
        public frmPersonel()
        {
            InitializeComponent();
            GridDoldur("select * from Personel");

        }

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        void GridDoldur(string sorgu)
        {
            baglanti = new SqlConnection("Data Source = LocalHost; Initial Catalog = Otel_Database; Integrated Security = True");
            baglanti.Open();
            da = new SqlDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridViewPersonel.DataSource = tablo;
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "SELECT 1 FROM Personel WHERE [Kullanıcı Adı] = @KAdi";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@KAdi", textBoxKullaniciAdi.Text);
            bool exists = Convert.ToBoolean(komut.ExecuteScalar());

            if (exists)
            {
                MessageBox.Show("Kullanıcı Adı mevcut başka Kullanıcı Adı yazın!");
            }
            else
            {
                if (textBoxSifre.Text == textBoxSifreYeniden.Text)
                {
                    try
                    {
                        string sorgu2 = "Insert into Personel ([Ad], [Soyad], [Cinsiyet],[Yas], [Kullanıcı Adı],[Şifre]) values (@Ad,@Soyad,@Cins,@Yas,@KAdi,@Sifre)";
                        komut = new SqlCommand(sorgu2, baglanti);
                        int yas = DateTime.Now.Year - dateTimePickerDTarih.Value.Year;
                        komut.Parameters.AddWithValue("@Ad", textBoxAd.Text);
                        komut.Parameters.AddWithValue("@Soyad", textBoxSoyad.Text);
                        komut.Parameters.AddWithValue("@Cins", comboBoxCins.Text);
                        komut.Parameters.AddWithValue("@Yas", yas);
                        komut.Parameters.AddWithValue("@KAdi", textBoxKullaniciAdi.Text);
                        komut.Parameters.AddWithValue("@Sifre", textBoxSifre.Text);

                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kayıt başarıyla eklendi");
                        GridDoldur("select * from Personel");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message);
                    }
                }
                else
                    MessageBox.Show("Şifreler uyuşmuyor!");
            }
            baglanti.Close();

        }
        Random rnd = new Random();
        private void btnKullaniciOner_Click(object sender, EventArgs e)
        {
            string ad = "";
            int sayilar;

            for (int i = 0; i < 4; i++)
            {
                sayilar = rnd.Next(0, 10);

                ad += sayilar.ToString();

            }
            textBoxKullaniciAdi.Text = textBoxAd.Text + ad;

        }

        private void btnSifreOner_Click(object sender, EventArgs e)
        {
            string sifre = "";
            int sayi;
            string kharf = "";
            string bharf = "";
            int krktr;

            for (int i = 1; i < 9; i++)
            {
                krktr = rnd.Next(3);
                if (krktr == 0)
                {
                    sayi = rnd.Next(0, 10);
                    sifre += sayi.ToString();
                }
                else if (krktr == 1)
                {
                    bharf = Convert.ToChar(rnd.Next(65, 90)).ToString();
                    sifre += bharf;
                }
                else if (krktr == 2)
                {
                    kharf = Convert.ToChar(rnd.Next(97, 123)).ToString();
                    sifre += kharf;
                }
            }

            textBoxSifre.Text = sifre;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBoxSifre.PasswordChar = '*';
            textBoxSifreYeniden.PasswordChar = '*';
            timerSifre.Stop();
        }

        private void textBoxSifre_TextChanged(object sender, EventArgs e)
        {
            timerSifre.Stop();
            timerSifre.Start();
            textBoxSifre.PasswordChar = '\0';

        }

        private void textBoxSifreYeniden_TextChanged(object sender, EventArgs e)
        {
            timerSifre.Stop();
            timerSifre.Start();
            textBoxSifreYeniden.PasswordChar = '\0';
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewPersonel.SelectedCells.Count > 0)
            {
                int sıra = dataGridViewPersonel.SelectedCells[0].RowIndex;
                int nokaydı = Convert.ToInt32(dataGridViewPersonel.Rows[sıra].Cells["Kullanıcı adı"].Value); // Örnek ID sütunu adı
                DialogResult result = MessageBox.Show("Seçili kaydı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection("Data Source = LocalHost; Initial Catalog = Otel_Database; Integrated Security = True"))
                        {
                            string query = "DELETE FROM Personel WHERE [Kullanıcı Adı] = @kadı";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@kadı", nokaydı);
                                connection.Open();
                                command.ExecuteNonQuery();
                            }
                        }
                        dataGridViewPersonel.Rows.RemoveAt(sıra);
                        GridDoldur("select * from Personel");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AnasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void RezervasyonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void OdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void MusteriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void MusteriAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void IstatistikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void CikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedMenuItem = sender as ToolStripMenuItem; // Hangi düğmeye tıklandığını alın
            string formadi = null;
            if (clickedMenuItem == RezervasyonToolStripMenuItem)
            {
                formadi = "FormRezervasyon";
            }
            else if (clickedMenuItem == IstatistikToolStripMenuItem)
            {
                formadi = "FormIstatıstık";
            }
            else if (clickedMenuItem == MusteriAraToolStripMenuItem)
            {
                formadi = "frmMusteriAra";
            }
            else if (clickedMenuItem == MusteriEklemeToolStripMenuItem)
            {
                formadi = "FormMUSTERI";
            }
            else if (clickedMenuItem == AnasayfaToolStripMenuItem)
            {
                formadi = "FormAnasayfa";
            }
            else if (clickedMenuItem == OdaToolStripMenuItem)
            {
                formadi = "FormOda";
            }

            if (!string.IsNullOrEmpty(formadi))
            {
                Form YeniForm = (Form)Activator.CreateInstance(Type.GetType("OtelOtomasyonu." + formadi));
                YeniForm.Name = formadi;
                YeniForm.Show();
                this.Hide();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textBoxAd.Clear(); textBoxSoyad.Clear(); dateTimePickerDTarih.Value = DateTime.Now; comboBoxCins.SelectedIndex = 0; textBoxKullaniciAdi.Clear(); textBoxSifre.Clear(); textBoxSifreYeniden.Clear();
        }
    }
}
