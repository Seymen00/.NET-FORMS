using System;
using System.Drawing;
using System.Windows.Forms;

namespace OtelOtomasyonu
{

    public partial class FormAnasayfa : System.Windows.Forms.Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();
            TarihSaat();
        }


        private void TarihSaat()
        {
            ToolStripStatusLabel lblSaatTarih = new ToolStripStatusLabel();
            lblSaatTarih.Spring = true;  // Bu özellik Label'ı en sağa itecektir
            lblSaatTarih.TextAlign = ContentAlignment.MiddleRight;  // Sağa hizalama

            statusStrip.Items.Add(lblSaatTarih);

            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) =>
            {
                DateTime currentTime = DateTime.Now;
                lblSaatTarih.Text = currentTime.ToString(" HH:mm dd.MM.yyyy");
            };
            timer.Start();
        }
        #region menu

        private void REZERVASYONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void ODAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void iSTATİSTİKToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void müşteriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void müşteriAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }
        private void PersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }
        private void çIKIŞToolStripMenuItem1_Click(object sender, EventArgs e)
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
            else if (clickedMenuItem == OdaToolStripMenuItem)
            {
                formadi = "FormOda";
            }
            else if(clickedMenuItem== PersonelToolStripMenuItem)
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
