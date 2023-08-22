using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtelOtomasyonu
{
    public partial class frmMusteriAra : Form
    {
        public frmMusteriAra()
        {
            InitializeComponent();
            GridDoldur("select * from Musteri");
        }
        SqlConnection baglanti;
        SqlDataAdapter da;
        void GridDoldur(string sorgu)
        {
            baglanti = new SqlConnection("Data Source=LocalHost;Initial Catalog=Otel_Database;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter(sorgu, baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridViewArama.DataSource = tablo;
            baglanti.Close();
        }
        private void MusteriArama_Load(object sender, EventArgs e)
        {
            comboBoxKriter.Items.Clear();
            comboBoxKriter.Items.AddRange(new object[] { "Ad", "Soyad", "Cinsiyet", "TC Kimlik No"});

        }

        #region menu
        private void ANASAYFAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void REZERVASYONToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void ODAToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void iSTATİSTİKToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }
        private void PersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }
        private void çIKIŞToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        string sql = "SELECT * FROM Musteri";
        private void btnAra_Click(object sender, EventArgs e)
        {
            if(comboBoxKriter.SelectedIndex == 0)
            {
                sql= "select * from Musteri where [Ad]='" + textBoxKelime.Text + "'";
            }
            else if(comboBoxKriter.SelectedIndex == 1)
            {
                sql = "select * from Musteri where [Soyad]='" + textBoxKelime.Text + "'";
            }
            else if (comboBoxKriter.SelectedIndex == 2)
            {
                sql = "select * from Musteri where [Cinsiyet] ='" + textBoxKelime.Text + "'";
            }
            else if (comboBoxKriter.SelectedIndex == 3)
            {
                sql = "select * from Musteri where [Kimlik No]='" + textBoxKelime.Text + "'";
            }
            GridDoldur(sql);
        }


    }
}
