using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtelOtomasyonu
{

    public partial class FormRezervasyon : Form
    {
        public FormRezervasyon()
        {
            InitializeComponent();
            GridDoldur("select * from Rezervasyon");
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
            dataGridViewRezervasyon.DataSource= tablo;
            baglanti.Close();
        }

        #region menu
        private void müşteriAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void ODAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void aNASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void iSTATİSTİKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }
        private void PersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }


        private void müşteriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
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
            if (clickedMenuItem == PersonelToolStripMenuItem)
            {
                formadi = "frmPersonel";
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

        #endregion

        #region buttons
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewRezervasyon.SelectedCells.Count > 0)
            {
                int sıra = dataGridViewRezervasyon.SelectedCells[0].RowIndex;
                int nokaydı = Convert.ToInt32(dataGridViewRezervasyon.Rows[sıra].Cells["Oda No"].Value); // Örnek ID sütunu adı
                DialogResult result = MessageBox.Show("Seçili rezervasyonu silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(sqlyolu))
                        {
                            string query = "DELETE FROM Rezervasyon WHERE [Oda No] = @no";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@no", nokaydı);
                                connection.Open();
                                command.ExecuteNonQuery();
                            }
                        }
                        dataGridViewRezervasyon.Rows.RemoveAt(sıra);
                        GridDoldur("select * from Rezervasyon");
                    }
                    catch (Exception ex )
                    {
                        MessageBox.Show("Hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "Insert into Rezervasyon ([Ad Soyad], [Check In], [Check Out],[Oda No], [Oda Tipi]) values (@AdSoyad,@CheckIn,@CheckOut,@OdaNo,@OdaTipi)";
                komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@AdSoyad", textAdSoyad.Text);
                komut.Parameters.AddWithValue("@CheckIn", DateTime.Parse(dateTimePCheckin.Text));
                komut.Parameters.AddWithValue("@CheckOut", DateTime.Parse(dateTimeCheckout.Text));
                komut.Parameters.AddWithValue("@OdaNo", (comboOdaNumara.Text));
                if (radioTek.Checked)
                {
                    komut.Parameters.AddWithValue("@OdaTipi", radioTek.Text);
                }
                else if (radioCift.Checked)
                {
                    komut.Parameters.AddWithValue("@OdaTipi", radioCift.Text);
                }
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt başarıyla eklendi");
                GridDoldur("select * from Rezervasyon");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
        #endregion
        
        #region RadioBtnChck
        private void radioTek_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTek.Checked)
            {
                comboOdaNumara.Items.Clear();
                comboOdaNumara.Items.AddRange(new object[] { "101", "102", "103", "104", "105", "201", "202", "203", "204", "205" });
            }
        }

        private void radioCift_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCift.Checked)
            {
                comboOdaNumara.Items.Clear();
                comboOdaNumara.Items.AddRange(new object[] { "301", "302", "303", "304", "305", "401", "402", "403", "404", "405" });
            }
        }
        #endregion

      
        private void FormRezervasyon_Load(object sender, EventArgs e)
        {

        }

    }
}