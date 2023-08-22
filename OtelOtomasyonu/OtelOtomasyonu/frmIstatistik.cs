using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyonu
{
    public partial class FormIstatıstık : Form
    {
        public FormIstatıstık()
        {
            InitializeComponent();
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

        private void müşteriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void iSTATİSTİKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void müşteriAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }
        private void AnasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnOpenForm_Click(sender, e);
        }
        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedMenuItem = sender as ToolStripMenuItem; // Hangi düğmeye tıklandığını alın
            string formadi = null;
            if (clickedMenuItem == RezervasyonToolStripMenuItem)
            {
                formadi = "FormRezervasyon";
            }
            else if (clickedMenuItem == AnasayfaToolStripMenuItem)
            {
                formadi = "FormAnasayfa";
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


            if (!string.IsNullOrEmpty(formadi))
            {
                Form existingForm = Application.OpenForms[formadi]; // Mevcut formu al

                if (existingForm == null)
                {
                    // Mevcut form yoksa, yeni bir form oluştur ve göster
                    Form YeniForm = (Form)Activator.CreateInstance(Type.GetType("OtelOtomasyonu." + formadi));
                    YeniForm.Name = formadi; // Formun adını belirle (örneğin, "FormAdi")
                    YeniForm.Show();
                }
                else
                {
                    // Mevcut form varsa, onu öne getir
                    this.Hide();
                    existingForm.BringToFront();
                }
            }
            #endregion

        }

     
    }
}