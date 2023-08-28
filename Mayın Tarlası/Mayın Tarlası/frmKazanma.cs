using System.Data.SqlClient;

namespace Mayın_Tarlası
{
    public partial class frmKazanma : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\sungu\OneDrive\Masaüstü\Projeler\Mayın Tarlası\Mayın Tarlası\MT.mdf"";Integrated Security=True;Connect Timeout=30");
        SqlCommand komut = new SqlCommand();

        public frmKazanma()
        {
            InitializeComponent();
        }
        string zorluk = frmMT.zorlukdegeri;
        int sure = frmMT.kazanmasuresi;




        private void buttonisim_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO SkorTablosu (Ad, Zorluk, Sure) VALUES (@Ad, @Zorluk, @Sure)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Ad", textBoxisim.Text);
            komut.Parameters.AddWithValue("@Zorluk", zorluk);
            komut.Parameters.AddWithValue("@Sure", sure);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.Close();
        }
    }
}
