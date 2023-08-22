using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtelOtomasyonu
{
    public partial class FormMUSTERI : Form
    {
        public FormMUSTERI()
        {
            InitializeComponent();
            GridDoldur("select * from Musteri");
        }

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        string sqlyolu = "Data Source = LocalHost; Initial Catalog = Otel_Database; Integrated Security = True";
        void GridDoldur(string sorgu)
        {
            baglanti = new SqlConnection(sqlyolu);
            baglanti.Open();
            da = new SqlDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridViewMusterKayit.DataSource = tablo;
            baglanti.Close();
        }

        #region  click
        private void RezervasyonToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void OdaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void iSTATİSTİKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void AnasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }
        private void PersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }
        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
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
            else if (clickedMenuItem == AnasayfaToolStripMenuItem)
            {
                formadi = "FormAnasayfa";
            }
            else if (clickedMenuItem == OdaToolStripMenuItem)
            {
                formadi = "FormOda";
            }
            else if (clickedMenuItem == PersonelToolStripMenuItem)
            {
                formadi = "frmPersonel";
            }

            if (!string.IsNullOrEmpty(formadi))
            {
                Form YeniForm = (Form)Activator.CreateInstance(Type.GetType("OtelOtomasyonu." + formadi));
                YeniForm.Name = formadi;
                YeniForm.Show();
                this.Hide();
            }
        }
        #endregion



        #region buttons
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewMusterKayit.SelectedCells.Count > 0)
            {
                int sıra = dataGridViewMusterKayit.SelectedCells[0].RowIndex;
                int nokaydı = Convert.ToInt32(dataGridViewMusterKayit.Rows[sıra].Cells["Kimlik No"].Value); // Örnek ID sütunu adı
                DialogResult result = MessageBox.Show("Seçili kaydı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(sqlyolu))
                        {
                            string query = "DELETE FROM Musteri WHERE [Kimlik No] = @no";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@no", nokaydı);
                                connection.Open();
                                command.ExecuteNonQuery();
                            }
                        }
                        dataGridViewMusterKayit.Rows.RemoveAt(sıra);
                        GridDoldur("select * from Musteri");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int yas = DateTime.Now.Year - dateTimeDogumTarihi.Value.Year;

            try
            {
                string sorgu = "Insert into Musteri ([Ad], [Soyad], [Cinsiyet],[Kimlik No], [Yas],[Tel],[Email],[Adres]) values (@Ad,@Soyad,@Cins,@Kimlikno,@Yas,@Tel,@Email,@Adres)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@Ad", txtAd.Text);
                komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@Cins", comboCinsiyet.Text);
                komut.Parameters.AddWithValue("@Kimlikno", txtTcKimlik.Text);
                komut.Parameters.AddWithValue("@Yas", yas);
                komut.Parameters.AddWithValue("@Tel", txtTel.Text);
                komut.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                komut.Parameters.AddWithValue("@Adres", txtAdres.Text);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt başarıyla eklendi");
                GridDoldur("select * from Musteri");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int yas = DateTime.Now.Year - dateTimeDogumTarihi.Value.Year;

            try
            {
                if (dataGridViewMusterKayit.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dataGridViewMusterKayit.SelectedCells[0].RowIndex;
                    int id = Convert.ToInt32(dataGridViewMusterKayit.Rows[selectedRowIndex].Cells["ID"].Value);

                    using (SqlConnection connection = new SqlConnection(sqlyolu))
                    {
                        string sorgu = "UPDATE Musteri SET [Ad] = @Ad, [Soyad] = @Soyad, [Cinsiyet] = @Cins,[Kimlik No] = @Kimlikno, [Yas] = @Yas, [Tel] = @Tel, [Email] = @Email, [Adres] = @Adres WHERE [ID] = @ID";
                        using (SqlCommand komut = new SqlCommand(sorgu, connection))
                        {
                            komut.Parameters.AddWithValue("@Ad", txtAd.Text);
                            komut.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
                            komut.Parameters.AddWithValue("@Cins", comboCinsiyet.Text);
                            komut.Parameters.AddWithValue("@Kimlikno", txtTcKimlik.Text);
                            komut.Parameters.AddWithValue("@Yas", yas);
                            komut.Parameters.AddWithValue("@Tel", txtTel.Text);
                            komut.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                            komut.Parameters.AddWithValue("@Adres", txtAdres.Text);
                            komut.Parameters.AddWithValue("@ID", id);

                            connection.Open();
                            komut.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Kayıt başarıyla güncellendi");
                    GridDoldur("select * from Musteri");
                }
                else
                {
                    MessageBox.Show("Güncellenecek kaydı seçin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtAd.Clear(); txtSoyad.Clear(); comboCinsiyet.SelectedIndex = 0; txtTcKimlik.Clear();
            txtTel.Clear(); textBoxEmail.Clear(); txtAdres.Clear(); dateTimeDogumTarihi.Value = DateTime.Now;
        }
        #endregion

        private void dataGridViewMusterKayit_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewMusterKayit.Rows.Count)
            {
                DataGridViewRow satır = dataGridViewMusterKayit.Rows[e.RowIndex];

                txtAd.Text = satır.Cells["Ad"].Value.ToString(); // Ad sütunu adı
                txtSoyad.Text = satır.Cells["Soyad"].Value.ToString(); // Soyad sütunu adı
                comboCinsiyet.Text = satır.Cells["Cinsiyet"].Value.ToString();
                txtTcKimlik.Text = satır.Cells["Kimlik No"].Value.ToString();
                txtTel.Text = satır.Cells["Tel"].Value.ToString();
                textBoxEmail.Text = satır.Cells["Email"].Value.ToString();
                txtAdres.Text = satır.Cells["Adres"].Value.ToString();
            }
        }

    }
}