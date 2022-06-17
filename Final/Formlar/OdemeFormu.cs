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
    public partial class OdemeFormu : Form
    {
        public OdemeFormu()
        {
            InitializeComponent();
        }


        public Odeme Odeme { get; set; }


        public bool Guncelleme { get; set; } = false;
        private void İptalButonu_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Tamambutonu_Click(object sender, EventArgs e)
        {
            if (nmpfiyat.Value == 0)
            {
                errorProvider1.SetError(nmpfiyat, "Lütfen Fiyatı Belirleyiniz");
                nmpfiyat.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmpfiyat, "");

            }

            if (cbtur.SelectedItem == "")
            {
                errorProvider1.SetError(cbtur, "Lütfen Ödeyeceğiniz Türü Seçiniz");
                cbtur.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(cbtur, "");
            }

            if (txtaciklama.Text == "")
            {
                errorProvider1.SetError(txtaciklama, "Lütfen Açıklamayı Boş Bırakmayın");
                txtaciklama.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(txtaciklama, "");
            }
           
            Odeme.MusteriID = (txtMusteri.Text);
            Odeme.OdemeTuru = (string)cbtur.SelectedItem;
            Odeme.Fiyat = (double)nmpfiyat.Value;
            Odeme.Tarih = dtptarih.Value;
            Odeme.Aciklama = txtaciklama.Text;

            DialogResult =DialogResult.OK;
        }

        private void OdemeFormu_Load(object sender, EventArgs e)
        {
            txtID.Text = Odeme.ID.ToString();
            if (Guncelleme)
            {
                txtMusteri.Text = Odeme.MusteriID.ToString();
                nmpfiyat.Value = (decimal) Odeme.Fiyat;
                dtptarih.Value = Odeme.Tarih;
                cbtur.SelectedItem = Odeme.OdemeTuru;
                txtaciklama.Text = Odeme.Aciklama.ToString();
                
            }
        }

        private void musterisec_Click(object sender, EventArgs e)
        {
            Musteriler musteri = new Musteriler();
            if (musteri.ShowDialog() == DialogResult.OK)
            {
                txtMusteri.Text = musteri.Musteri.ToString();
            }
        }
       
        }
    }

