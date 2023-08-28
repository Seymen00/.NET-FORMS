using System.Data.SqlClient;
using System.Media;
using System.Security.Cryptography.X509Certificates;

namespace Mayın_Tarlası
{
    public partial class frmMT : Form
    {
        private System.Windows.Forms.Timer sure;
        private bool sureBasladi = false; // Sürenin başladığını gösteren flag
        string end1 = "Tebrikler kazandınız";
        string end2 = "Mayına bastınız oyun bitti";
        string end3 = "Maksimum süreyi aştınız oyun bitti";
        public static string zorlukdegeri = "";
        public static int kazanmasuresi;
        private Panel panel;
        int hedef, gecensure = 0, alansayisi, countsayisi, mayinsayisi;

        bool adminmod = false;

        public frmMT()
        {
            InitializeComponent();
            sure = new System.Windows.Forms.Timer();
            sure.Interval = 1000; // 1 saniye
            sure.Tick += SureTick;

        }
        private void MayinlariYerlestir(int count, int alan, int mayin)
        {
            Random random = new Random();
            List<Button> mayinliButonlar = new List<Button>();

            while (mayinliButonlar.Count < mayin)
            {
                int row = random.Next(0, count);
                int col = random.Next(0, count);

                Button selectedButton = panel.Controls.OfType<Button>().FirstOrDefault(b => b.Location.X / alan == col && b.Location.Y / alan == row);

                if (selectedButton != null && !mayinliButonlar.Contains(selectedButton))
                {
                    selectedButton.Text = "X";
                    mayinliButonlar.Add(selectedButton);
                }
            }

            foreach (Button mayinliButon in mayinliButonlar)
            {
                int row = mayinliButon.Location.Y / alan;
                int col = mayinliButon.Location.X / alan;

                for (int i = row - 1; i <= row + 1; i++)
                {
                    for (int j = col - 1; j <= col + 1; j++)
                    {
                        if (i >= 0 && i < count && j >= 0 && j < count)
                        {
                            Button neighborButton = panel.Controls.OfType<Button>().FirstOrDefault(b => b.Location.X / alan == j && b.Location.Y / alan == i);
                            if (neighborButton != null && neighborButton.Text != "X")
                            {
                                int currentNumber = 0;
                                if (!string.IsNullOrEmpty(neighborButton.Text) && int.TryParse(neighborButton.Text, out currentNumber))
                                {
                                    neighborButton.Text = (currentNumber + 1).ToString();
                                }
                                else
                                {
                                    neighborButton.Text = "1";
                                }
                            }
                        }
                    }
                }
            }
        }

        private void OyunBasla(int count, int alan, int mayin, string zorluk)
        {
            mayinsayisi = mayin; alansayisi = alan; zorlukdegeri = zorluk;
            lblBaslangic.Visible = false;
            lblSkor.Text = "";

            if (panel != null)
            {
                panel.Controls.Clear();
            }
            else
            {
                panel = new Panel();
                this.Controls.Add(panel);
            }
            panel.Width = count * (alan + 1);
            panel.Height = count * (alan + 1);

            panel.Anchor = AnchorStyles.None;
            panel.Location = new System.Drawing.Point((this.Width - panel.Width) / 2, (this.Height - panel.Height) / 2 + 10);

            for (int row = 0; row < count; row++)
            {
                for (int col = 0; col < count; col++)
                {
                    Button button = new Button();
                    button.Font = new Font("Calibri", alan / 2);
                    button.BackColor = Color.LightGray; button.FlatStyle = FlatStyle.Popup; button.ForeColor = Color.LightGray;
                    button.Height = alan; button.Width = alan;
                    button.Location = new System.Drawing.Point(row * alan, col * alan);
                    button.Click += ButonTıkla;
                    button.MouseUp += BayrakEkle;
                    panel.Controls.Add(button);
                }
            }
            MayinlariYerlestir(count, alan, mayin);
            hedef = (count * count) - mayin;
        }
        private void BayrakEkle(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                Button clickedButton = sender as Button;

                if (clickedButton != null)
                {
                    string text = "";
                    Color orjcolor = Color.White;

                    if (clickedButton.Text != "🚩" && clickedButton.BackColor != Color.Silver)
                    {
                        text = clickedButton.Text;
                        orjcolor = clickedButton.ForeColor;

                        clickedButton.Text = "🚩";
                        clickedButton.ForeColor = Color.Red;
                    }
                    else if (clickedButton.Text == "🚩")
                    {
                        clickedButton.Text = text;
                        clickedButton.ForeColor = orjcolor;
                    }

                }
            }
        }

        private void ButonTıkla(object sender, EventArgs e)
        {

            if (!sureBasladi)
            {
                sure.Start();
                sureBasladi = true;
            }

            Button tıklananbuton = (Button)sender;

            if (tıklananbuton.Tag == null && tıklananbuton.Text != "🚩")
            {
                tıklananbuton.Tag = "Tıklanmış";
                hedef--;

                lblkalantiklama.Text = "Kalan tıklanacak buton sayısı: " + hedef.ToString(); lblmayinsayisi.Text = "Kalan mayın sayısı: " + mayinsayisi.ToString();
                tıklananbuton.BackColor = Color.Silver;

                if (tıklananbuton.Text != "X")
                {
                    if (tıklananbuton.Text == "1")
                        tıklananbuton.ForeColor = Color.Blue;
                    else if (tıklananbuton.Text == "2")
                        tıklananbuton.ForeColor = Color.Green;
                    else if (tıklananbuton.Text == "3")
                        tıklananbuton.ForeColor = Color.Red;
                    else if (tıklananbuton.Text == "4")
                        tıklananbuton.ForeColor = Color.Purple;
                    else if (tıklananbuton.Text == "5")
                        tıklananbuton.ForeColor = Color.Brown;

                    if (hedef == 0)
                    {
                        kazanmasuresi = gecensure;
                        OyunBitti(end1);
                        frmKazanma frmKazanma = new frmKazanma();
                        frmKazanma.ShowDialog();
                    }
                }
                else
                {
                    tıklananbuton.ForeColor = Color.Black;
                    OyunBitti(end2);
                }
            }
        }
        private void SureTick(object sender, EventArgs e)
        {
            gecensure++;
            toolStripTextBoxSure.Text = gecensure.ToString();

            if (gecensure >= 999)
            {
                OyunBitti(end3);
            }
        }

        private void OyunBitti(string sebep)
        {
            if (sebep != end1)
            {
                SoundPlayer gameoversound = new SoundPlayer(@"C:\Users\sungu\OneDrive\Masaüstü\Effects\gameover.wav");
                gameoversound.Play();
            }
            OyunReset();
            MessageBox.Show(sebep);
        }

        #region zorluk
        private void kolaytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            kolaytoolStripMenuItem.Checked = true;
            ortaToolStripMenuItem.Checked = false;
            zorToolStripMenuItem.Checked = false;
            OyunBasla(9, 45, 10, "KOLAY");
        }

        private void ortaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kolaytoolStripMenuItem.Checked = false;
            ortaToolStripMenuItem.Checked = true;
            zorToolStripMenuItem.Checked = false;
            OyunBasla(12, 35, 25, "ORTA");
        }

        private void zorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kolaytoolStripMenuItem.Checked = false;
            ortaToolStripMenuItem.Checked = false;
            zorToolStripMenuItem.Checked = true;
            OyunBasla(15, 30, 41, "ZOR");
        }
        #endregion

        private void OyunReset()
        {
            sure.Stop();
            sureBasladi = false;
            gecensure = 0;
            toolStripTextBoxSure.Text = "";
            panel.Controls.Clear();
            lblBaslangic.Visible = true;

            FillScoreTable(lblSkor);
        }

        private void gosterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel != null)
                foreach (Button button in panel.Controls)
                {
                    if (button.ForeColor == Color.LightGray)
                    {
                        button.ForeColor = Color.Black;
                    }
                    else
                        button.ForeColor = Color.LightGray;
                }
        }

        private void FillScoreTable(Label label)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\sungu\OneDrive\Masaüstü\Projeler\Mayın Tarlası\Mayın Tarlası\MT.mdf"";Integrated Security=True;Connect Timeout=30");
            string scoreText = "";
            baglanti.Open();
            string selectQuery = "SELECT TOP 10 Ad, Zorluk, Sure FROM SkorTablosu ORDER BY Zorluk DESC, Sure";
            using (SqlCommand selectCommand = new SqlCommand(selectQuery, baglanti))
            {
                using (SqlDataReader reader = selectCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string ad = reader.GetString(0);
                        string zorluk = reader.GetString(1);
                        int sure = reader.GetInt32(2);

                        // Skorları bir metin olarak oluştur
                        scoreText += $"{ad} {zorluk} {sure} saniye\n";
                    }
                }
            }
            label.Text = scoreText;
        }
        private void frmMT_Load(object sender, EventArgs e)
        {
            FillScoreTable(lblSkor);
        }

        private void frmMT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.KeyCode == Keys.A)
            {
                adminmod = !adminmod;

                if (adminmod)
                {
                    MessageBox.Show("Admin Modu Açıldı");
                    lblkalantiklama.Visible = true;
                    lblmayinsayisi.Visible = true;
                    gosterToolStripMenuItem.Visible = true;
                }
                else
                {
                    MessageBox.Show("Admin Modu Kapatıldı");
                    lblkalantiklama.Visible = false;
                    lblmayinsayisi.Visible = false;
                    gosterToolStripMenuItem.Visible = false;
                }

                e.Handled = true;
            }
        }
    }
}