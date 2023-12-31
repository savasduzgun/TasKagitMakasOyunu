namespace TasKagitMakasOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void BilgisayarSkorArtir()
        {
            int skor = Convert.ToInt32(lblBilgisayarSkor.Text);
            lblBilgisayarSkor.Text = (++skor).ToString();
        }
        public void OyuncuSkorArtir()
        {
            int skor = Convert.ToInt32(lblOyuncuSkor.Text);
            lblOyuncuSkor.Text = (++skor).ToString();
        }
        private void resimTas_Click(object sender, EventArgs e)
        {
            Resim tiklananResim = sender as Resim;
            int rastgeleSecim = new Random().Next(8, 10000) % 3;
            resimBilgisayar.ResimTuru = (ResimTuru)rastgeleSecim;
            resimOyuncu.ResimTuru = tiklananResim.ResimTuru;

            if (tiklananResim.ResimTuru == ResimTuru.Kagit) //Oyuncu seçimi : kaðýt
            {
                if (resimBilgisayar.ResimTuru == ResimTuru.Makas) //Bilgisayar seçimi : makas
                {
                    BilgisayarSkorArtir();
                }
                else if (resimBilgisayar.ResimTuru == ResimTuru.Tas) //Bilgisayar seçimi : taþ
                {
                    OyuncuSkorArtir();
                }
            }
            else if (tiklananResim.ResimTuru == ResimTuru.Makas) //Oyuncu seçimi : makas
            {
                if (resimBilgisayar.ResimTuru==ResimTuru.Kagit) //Bilgisayar seçimi : kaðýt
                {
                    OyuncuSkorArtir();
                }
                else if (resimBilgisayar.ResimTuru== ResimTuru.Tas) //Bilgisayar seçimi : taþ
                {
                    BilgisayarSkorArtir();
                }
            }
            else // Oyunucu seçimi : taþ
            {
                if (resimBilgisayar.ResimTuru == ResimTuru.Kagit) //Bilgisayar seçimi : kaðýt
                {
                    BilgisayarSkorArtir();
                }
                else if (resimBilgisayar.ResimTuru == ResimTuru.Makas) //Bilgisayar seçimi : makas
                {
                    OyuncuSkorArtir();
                }
            }
        }
    }
}
