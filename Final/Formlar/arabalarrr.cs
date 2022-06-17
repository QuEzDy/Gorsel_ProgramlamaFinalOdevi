using Final.Bl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final.Formlar
{
    public partial class arabalarrr : Form
    {
        public arabalarrr()
        {
            InitializeComponent();
        }

        public bool ArabaGuncelleme { get; private set; }
        public Arabalar Arabalar { get; private set; }

        public Arabalar arabalar = new Arabalar();

        //{
        //    ID = Guid.NewGuid()
        //};




        private void arabaeklebuton_Click(object sender, EventArgs e)
        {
            ArabaFormu arabaFormu = new ArabaFormu();
            {
                Text = "Araba Ekle";
                Arabalar = new Arabalar() { ID = Guid.NewGuid().ToString() };
            };
        dönmesatırı:
            var sonuc = arabaFormu.ShowDialog();
            if (sonuc != DialogResult.OK)
            {
                bool b = BLogic.ArabaEkle(arabaFormu.Arabalar);
                if (b)
                {
                    DataSet komutlar = BLogic.ArabalariGetir("");
                    if (komutlar != null)
                        dataGridView2.DataSource = komutlar.Tables[0];
                    else
                        goto dönmesatırı;
                }

            }

        }

        private void arababulbuton_Click(object sender, EventArgs e)
        {

        }

        private void arabaduzenlebuton_Click(object sender, EventArgs e)
        {

            DataGridViewRow sutun = dataGridView2.SelectedRows[0];
            ArabaFormu arabaFormu = new ArabaFormu();
            {
                Text = "Araba Düzenle";
                ArabaGuncelleme = true;
                Arabalar = new Arabalar()
                {
                    ID = (sutun.Cells[0].Value.ToString()),
                    Marka = sutun.Cells[1].Value.ToString(),
                    Model = sutun.Cells[2].Value.ToString(),
                    Fiyat = double.Parse(sutun.Cells[3].Value.ToString()),
                    // Yil = (sutun.Cells[4].Value.ToString()),
                    Yil = DateTime.Parse(sutun.Cells[4].Value.ToString()),                   
                    Sehir = sutun.Cells[5].Value.ToString(),
                };
            };
            var sonuc = arabaFormu.ShowDialog();
            if (sonuc != DialogResult.OK)
            {
                bool b = BLogic.ArabaGuncelle(arabaFormu.Arabalar);
                if (b)
                {
                    sutun.Cells[1].Value = arabaFormu.Arabalar.Marka;
                    sutun.Cells[2].Value = arabaFormu.Arabalar.Model;
                    sutun.Cells[3].Value = arabaFormu.Arabalar.Fiyat;
                    sutun.Cells[4].Value = arabaFormu.Arabalar.Yil;
                    sutun.Cells[5].Value = arabaFormu.Arabalar.Sehir;
                    sutun.Cells[6].Value = arabaFormu.Arabalar.Aciklama;
                };
            }
        }

        private void arabasilbuton_Click(object sender, EventArgs e)
        {
            DataGridViewRow sutun = dataGridView2.SelectedRows[0];
            var ID = (sutun.Cells[0].Value.ToString());


            var sonuc = MessageBox.Show("Seçili Kayıt Silinsin mi", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc != DialogResult.OK)
            {
                bool b = BLogic.ArabaSil(ID);
                if (b)
                {

                    DataSet komutlar = BLogic.ArabalariGetir("");
                    if (komutlar != null)
                        dataGridView2.DataSource = komutlar.Tables[0];
                }
            };
        }

        private void arabalarrr_Load(object sender, EventArgs e)
        {
            DataSet dss = BLogic.ArabalariGetir("");
            if (dss != null)
                dataGridView2.DataSource = dss.Tables[0];
        }
        //public Arabalar arabalar { get; set; }
        private void Tamambutonu_Click(object sender, EventArgs e)
        {

            DataGridViewRow sutun = dataGridView2.SelectedRows[0];

            Arabalar = new Arabalar()
            {
                ID = (sutun.Cells[0].Value.ToString()),
                Marka = sutun.Cells[1].Value.ToString(),
                Model = sutun.Cells[2].Value.ToString(),
                Fiyat = double.Parse(sutun.Cells[3].Value.ToString()),
               // Yil = sutun.Cells[4].Value.ToString(),
                Yil = DateTime.Parse(sutun.Cells[4].Value.ToString()),
                Sehir = sutun.Cells[5].Value.ToString(),
            };
            DialogResult = DialogResult.OK;


        }

        private void İptalButonu_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}

