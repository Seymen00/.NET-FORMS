using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndPerimeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            radiobtnCircle.Checked = true;
            radiobtnArea.Checked = true;
            lblLongSide.Text = "Yarıçap:";
            lblShortSide.Text = "Pi:";
            txtShortSide.Text = Math.PI.ToString();
        }
        private void UpdateShapeUI()
        {
            if (radiobtnSquare.Checked)
            {
                lblLongSide.Visible = false;
                lblShortSide.Text = "Kenar:";
                txtShortSide.Visible = true;
            }
            else if (radiobtnCircle.Checked)
            {
                lblLongSide.Text = "Yarıçap:";
                lblShortSide.Text = "Pi:";
                txtShortSide.Visible = true;
            }
            else if(radiobtnRectangle.Checked)
            {
                return;
            }
        }
        private void radiobtnSquare_CheckedChanged(object sender, EventArgs e)
        {
            UpdateShapeUI();
        }

        private void radiobtnRectangle_CheckedChanged(object sender, EventArgs e)
        {
            UpdateShapeUI();
        }

        private void radiobtnCircle_CheckedChanged(object sender, EventArgs e)
        {
            UpdateShapeUI();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (radiobtnCircle.Checked)
            {
                double yaricap = Convert.ToDouble(txtLongSide.Text);
                double pi = Convert.ToDouble(txtShortSide.Text);
                double alan = pi * yaricap * yaricap;
                double cevre = 2 * pi * yaricap;

                txtResult.Text = radiobtnArea.Checked ? alan.ToString() : cevre.ToString();
            }

            else if (radiobtnSquare.Checked)
            {
                double ShortSide = Convert.ToDouble(txtShortSide.Text);
                double alan = ShortSide * ShortSide;
                double cevre = 4 * ShortSide;
                txtResult.Text = radiobtnArea.Checked ? alan.ToString() : cevre.ToString();
            }
            else if (radiobtnRectangle.Checked)
            {
                double LongSide = Convert.ToDouble(txtLongSide.Text);
                double ShortSide = Convert.ToDouble(txtShortSide.Text);
                double alan = ShortSide * LongSide;
                double cevre = 2 * (LongSide + ShortSide);

                txtResult.Text = radiobtnArea.Checked ? alan.ToString() : cevre.ToString();

            }
        }
    }
}   



