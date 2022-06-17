using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final.Formlar;
using Final.Bl;

namespace Final
{
    public partial class AnaForm : Form
    {
        public Musteri Musteri { get; private set; }
        public Arabalar Arabalar { get; private set; }
        public Satis Satis { get; private set; }
        public Odeme Odeme { get; private set; }

        public AnaForm()
        {
            InitializeComponent();
        }


        Musteriler musteri = new Musteriler();
        arabalarrr arabalar1 = new arabalarrr();

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            musteri.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            arabalar1.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SatisFormu satisFormu = new SatisFormu();
            {
                Text = "Satış Yap";
                Satis = new Satis()
                {
                    ID = Guid.NewGuid(),
                };
            };
            if (satisFormu.ShowDialog() == DialogResult.OK)
            {
            dönmesatırı:
                var sonuc = satisFormu.ShowDialog();
                if (sonuc != DialogResult.OK)
                {
                    bool b = BLogic.SatisEkle(satisFormu.Satis);
                    if (b)
                    {
                        DataSet ds = BLogic.SatisDetay("");
                        if (ds != null)
                            dataGridView1.DataSource = ds.Tables[0];
                        else
                            goto dönmesatırı;
                    }
                }
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

            DataSet ds = BLogic.SatisDetay("");
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];

            DataSet ds2 = BLogic.OdemeDetay("");
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];
        }

    private void Satisduzenlebuton_Click(object sender, EventArgs e)
        {
            DataGridViewRow sutun = dataGridView1.SelectedRows[0];
            SatisFormu satisFormu = new SatisFormu();
            {
                Text = "Satis Düzenle";
                //MusteriGuncelleme = true;
                Satis = new Satis()
                {
                    ID = Guid.Parse(sutun.Cells[0].Value.ToString()),
                    MusteriID = Guid.Parse(sutun.Cells[1].Value.ToString()),
                    ArabaID =(sutun.Cells[2].Value.ToString()),
                    Fiyat = double.Parse(sutun.Cells[4].Value.ToString()),
                    Tarih = DateTime.Parse(sutun.Cells[5].Value.ToString()),
                };
            };
            var sonuc = satisFormu.ShowDialog();
            if (sonuc != DialogResult.OK)
            {
                bool b = BLogic.SatisGuncelle(satisFormu.Satis);
                if (b)
                {
                    sutun.Cells[1].Value = satisFormu.Satis.MusteriID;
                    sutun.Cells[2].Value = satisFormu.Satis.ArabaID;
                    sutun.Cells[3].Value = satisFormu.Satis.Fiyat;
                    sutun.Cells[4].Value = satisFormu.Satis.Tarih;

                };
            }
        }

        private void satisisilbuton_Click(object sender, EventArgs e)
        {
            DataGridViewRow sutun = dataGridView1.SelectedRows[0];
            var ID = (sutun.Cells[0].Value.ToString());


            var sonuc = MessageBox.Show("Seçili Kayıt Silinsin mi", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc != DialogResult.OK)
            {
                bool b = BLogic.SatisSil(ID);
                if (b)
                {

                    DataSet komutlar = BLogic.SatisDetay("");
                    if (komutlar != null)
                        dataGridView1.DataSource = komutlar.Tables[0];
                }
            };
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator41_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator51_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator43_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator52_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator53_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator54_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator55_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator56_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator57_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void musteribultext_Click(object sender, EventArgs e)
        {

        }

        private void musteribulbuton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void odemebutonu_Click(object sender, EventArgs e)
        {

            OdemeFormu odeme = new OdemeFormu();
            {
                Text = "Satış Yap";
                Odeme = new Odeme();            
            };
            if (odeme.ShowDialog() == DialogResult.OK)
            {
            dönmesatırı:
                var sonuc = odeme.ShowDialog();
                if (sonuc != DialogResult.OK)
                {
                    bool b = BLogic.OdemeEkle(odeme.Odeme);
                    if (b)
                    {
                        DataSet ds2 = BLogic.OdemeDetay("");
                        if (ds2 != null)
                            dataGridView2.DataSource = ds2.Tables[0];
                        else
                            goto dönmesatırı;
                    }
                }
            }
        }


        private void odemeduzenleme_Click(object sender, EventArgs e)
        {

            DataGridViewRow sutun = dataGridView2.SelectedRows[0];
            OdemeFormu odemeFormu = new OdemeFormu();
            {
                Text = "Odeme Düzenle";
                //Guncelleme = true;
                Odeme = new Odeme()
                {
                    ID = (sutun.Cells[0].Value.ToString()),
                    MusteriID = (sutun.Cells[1].Value.ToString()),
                    Tarih = DateTime.Parse(sutun.Cells[3].Value.ToString()),
                    Fiyat = double.Parse(sutun.Cells[4].Value.ToString()),
                    OdemeTuru = (sutun.Cells[5].Value.ToString()),
                    Aciklama = (sutun.Cells[6].Value.ToString()),


                };
            };
            var sonuc = odemeFormu.ShowDialog();
            if (sonuc != DialogResult.OK)
            {
                bool b = BLogic.OdemeGuncelle(odemeFormu.Odeme);
                if (b)
                {
                    sutun.Cells[1].Value = odemeFormu.Odeme.MusteriID;
                    sutun.Cells[3].Value = odemeFormu.Odeme.Tarih;
                    sutun.Cells[4].Value = odemeFormu.Odeme.Fiyat;
                    sutun.Cells[5].Value = odemeFormu.Odeme.OdemeTuru;
                    sutun.Cells[6].Value = odemeFormu.Odeme.Aciklama;


                };
            }
        }

        private void odemesil_Click(object sender, EventArgs e)
        {
            DataGridViewRow sutun = dataGridView2.SelectedRows[0];
            var ID = (sutun.Cells[0].Value.ToString());


            var sonuc = MessageBox.Show("Seçili Kayıt Silinsin mi", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc != DialogResult.OK)
            {
                bool b = BLogic.OdemeSil(ID);
                if (b)
                {

                    DataSet komutlar = BLogic.OdemeDetay("");
                    if (komutlar != null)
                        dataGridView2.DataSource = komutlar.Tables[0];
                }
            };
        }

        private void Tamambutonu_Click(object sender, EventArgs e)
        {

        }
    }
}
    
    




    

