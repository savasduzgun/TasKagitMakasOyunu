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

            if (tiklananResim.ResimTuru == ResimTuru.Kagit) //Oyuncu se�imi : ka��t
            {
                if (resimBilgisayar.ResimTuru == ResimTuru.Makas) //Bilgisayar se�imi : makas
                {
                    BilgisayarSkorArtir();
                }
                else if (resimBilgisayar.ResimTuru == ResimTuru.Tas) //Bilgisayar se�imi : ta�
                {
                    OyuncuSkorArtir();
                }
            }
            else if (tiklananResim.ResimTuru == ResimTuru.Makas) //Oyuncu se�imi : makas
            {
                if (resimBilgisayar.ResimTuru==ResimTuru.Kagit) //Bilgisayar se�imi : ka��t
                {
                    OyuncuSkorArtir();
                }
                else if (resimBilgisayar.ResimTuru== ResimTuru.Tas) //Bilgisayar se�imi : ta�
                {
                    BilgisayarSkorArtir();
                }
            }
            else // Oyunucu se�imi : ta�
            {
                if (resimBilgisayar.ResimTuru == ResimTuru.Kagit) //Bilgisayar se�imi : ka��t
                {
                    BilgisayarSkorArtir();
                }
                else if (resimBilgisayar.ResimTuru == ResimTuru.Makas) //Bilgisayar se�imi : makas
                {
                    OyuncuSkorArtir();
                }
            }
        }
    }
}
