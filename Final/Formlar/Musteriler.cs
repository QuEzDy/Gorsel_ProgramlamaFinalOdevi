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
    public partial class Musteriler : Form
    {

        public Musteri Musteri { get; private set; }

        public Musteriler()
        {
            InitializeComponent();
        }





        private void musterieklebuton1_Click(object sender, EventArgs e)
        {
            MusteriFormu frmMusteri = new MusteriFormu()
            {
                Text = "Müşteri Ekle",
                Musteri = new Musteri() { ID = Guid.NewGuid().ToString() },
            };

        tekrar:
            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MusteriEkle(frmMusteri.Musteri);

                if (b)
                {

                    DataSet ds = BLogic.MusterileriGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
                else
                    goto tekrar;

            }






        }

        private void musteribulbuton_Click(object sender, EventArgs e)
        {
            DataSet komutlar = BLogic.MusterileriGetir(musteribultext.Text);
            if (komutlar != null)
                dataGridView1.DataSource = komutlar.Tables[0];
        }

        private void musteriduzenlebuton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            MusteriFormu frmMusteri = new MusteriFormu()
            {
                Text = "Müşteri Güncelle",
                Guncelleme = true,
                Musteri = new Musteri()
                {
                    ID = row.Cells[0].Value.ToString(),
                    Adi = row.Cells[1].Value.ToString(),
                    Soyadi = row.Cells[2].Value.ToString(),
                    Telefon = row.Cells[3].Value.ToString(),
                    Mail = row.Cells[4].Value.ToString(),
                    Adres = row.Cells[5].Value.ToString(),

                },
            };

            var sonuc = frmMusteri.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.MusteriGuncelle(frmMusteri.Musteri);

                if (b)
                {
                    row.Cells[1].Value = frmMusteri.Musteri.Adi;
                    row.Cells[2].Value = frmMusteri.Musteri.Soyadi;
                    row.Cells[3].Value = frmMusteri.Musteri.Telefon;
                    row.Cells[4].Value = frmMusteri.Musteri.Mail;
                    row.Cells[5].Value = frmMusteri.Musteri.Adres;

                }

            }
        }


        private void musterisilbuton_Click(object sender, EventArgs e)
        {
            DataGridViewRow sutun = dataGridView1.SelectedRows[0];
            var ID = (sutun.Cells[0].Value.ToString());


            var sonuc = MessageBox.Show("Seçili Kayıt Silinsin mi", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc != DialogResult.OK)
            {
                bool b = BLogic.MusteriSil(ID);
                if (b)
                {

                    DataSet komutlar = BLogic.MusterileriGetir("");
                    if (komutlar != null)
                        dataGridView1.DataSource = komutlar.Tables[0];
                }
            };
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.MusterileriGetir("");
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }
        public Musteri musteri {  get; set; }
        private void Tamambutonu_Click(object sender, EventArgs e)
        {

            DataGridViewRow sutun = dataGridView1.SelectedRows[0];
          
                Musteri = new Musteri()
                {
                    ID = (sutun.Cells[0].Value.ToString()),
                    Adi = sutun.Cells[1].Value.ToString(),
                    Soyadi = sutun.Cells[2].Value.ToString(),
                    Telefon = sutun.Cells[3].Value.ToString(),
                    Mail = sutun.Cells[4].Value.ToString(),
                    Adres = sutun.Cells[5].Value.ToString(),
                  
                };


            DialogResult = DialogResult.OK;

            }

        private void İptalButonu_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
            }
        
    
