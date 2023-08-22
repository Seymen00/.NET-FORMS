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

namespace OtelOtomasyonu
{
    public partial class FormOda : Form
    {
        public FormOda()
        {
            InitializeComponent();
            Button();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        int doluOda = 0; int bosOda = 0;

        private void Button()
        {
            int buttonCount = 5;
            int oda = 0;
            int mesafe = 0;
            int x = -30;
            for (int i = 1; i < 5; i++)
            {
                oda = oda + 100;
                mesafe = mesafe + 65;
                for (int j = 1; j <= buttonCount; j++)
                {
                    Button button = new Button();
                    button.Text = (oda + j).ToString();
                    button.Location = new System.Drawing.Point(j * 65 + x, mesafe);
                    button.Height = 55;
                    button.Width = 55;
                    button.ForeColor = Color.White;
                    button.FlatStyle = FlatStyle.Flat;
                    using (SqlConnection baglanti = new SqlConnection("Data Source = LocalHost; Initial Catalog = Otel_Database; Integrated Security = True"))
                    {
                        baglanti.Open();
                        string sorgu = "SELECT 1 FROM Rezervasyon WHERE [Oda no] = @Deger";
                        using (SqlCommand command = new SqlCommand(sorgu, baglanti))
                        {
                            command.Parameters.AddWithValue("@Deger", oda+j);
                            bool exists = Convert.ToBoolean(command.ExecuteScalar());

                            if (exists)
                            {
                                button.BackColor = Color.Red;
                                doluOda++;
                            }
                            else
                            {
                                button.BackColor = Color.RoyalBlue;
                                bosOda++;
                            }
                        }
                    }

                    button.Click += new System.EventHandler(this.btnClick);
                    this.Controls.Add(button);
                }
            }
            btnBoda.Text = bosOda.ToString(); btnDoda.Text = doluOda.ToString();
        }
      

        private void btnClick(object sender, EventArgs e)
        {
            Button button;
            if (sender is Button)
            {
                button = sender as Button;
                if (button.BackColor == Color.RoyalBlue)
                {
                    button.BackColor = Color.Red;
                    doluOda++; bosOda--;

                }
                else
                {
                    button.BackColor = Color.RoyalBlue;
                    bosOda++; doluOda--;
                }
                btnBoda.Text = bosOda.ToString(); btnDoda.Text = doluOda.ToString();
            }
        }
        #region menu
        private void AnasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }
        private void REZERVASYONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }
        private void iSTATİSTİKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }
        private void müşteriAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }
        private void MusteriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
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


    }
}
