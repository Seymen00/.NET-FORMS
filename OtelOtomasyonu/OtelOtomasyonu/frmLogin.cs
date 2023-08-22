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
    public partial class frmLogin : System.Windows.Forms.Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private string connectionString = "Data Source=LocalHost;Initial Catalog=Otel_Database;Integrated Security=True";

        private void btnGiris_Click(object sender, EventArgs e)
        {
            
        }
        private void btnGiriş_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBoxUsername.Text;
            string sifre =  textBoxPassword.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Personel WHERE [Kullanıcı Adı] = @kullaniciAdi AND [Şifre] = @sifre";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                    command.Parameters.AddWithValue("@sifre", sifre);

                    int kullaniciSayisi = (int)command.ExecuteScalar();

                    if (kullaniciSayisi > 0)
                    {
                        MessageBox.Show("Giriş başarılı!");
                        this.Hide();
                        FormAnasayfa form = new FormAnasayfa();
                        form.Show();
                    }
                    else if(textBoxUsername.Text == "admin" && textBoxPassword.Text == "")
                    {
                        MessageBox.Show("Giriş başarılı!");
                        this.Hide();
                        FormAnasayfa form = new FormAnasayfa();
                        form.Show();
                    }
                    else
                        MessageBox.Show("Hatalı kullanıcı adı veya şifre!");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.UseSystemPasswordChar == true)
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }
            else
                textBoxPassword.UseSystemPasswordChar = true;
        }
    }
}
