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
    public partial class SatisFormu : Form
    {
        public SatisFormu()
        {
            InitializeComponent();
        }


        public Satis Satis = new Satis()

        {
            ID = Guid.NewGuid()
        };
        public bool Guncelleme { get; set; } = false;    

        private void Tamambutonu_Click(object sender, EventArgs e)
        {
            if(nmpfiyat.Value == 0)
            {
                errorProvider1.SetError(nmpfiyat, "Lütfen Fiyatı Belirleyiniz");
                nmpfiyat.Focus();
                return;
            }
            else
            {
                errorProvider1.SetError(nmpfiyat, "");

            }
            Satis.Tarih = dtptarih.Value;
            Satis.Fiyat = (double)nmpfiyat.Value;
            Satis.ArabaID = (txtID.Text);
            Satis.MusteriID = Guid.Parse(txtMusteri.Text);



            DialogResult = DialogResult.OK;
        }

        private void İptalButonu_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        private void SatisFormu_Load(object sender, EventArgs e)
        {
            txtID.Text = Satis.ID.ToString();
            if (Guncelleme)
            {
                txtMusteri.Text = Satis.MusteriID.ToString();
                txtaraba.Text = Satis.ArabaID.ToString();
                nmpfiyat.Value = (decimal)Satis.Fiyat;
                dtptarih.Value = Satis.Tarih;
            }
          
           
        }

        private void musterisec_Click(object sender, EventArgs e)
        {
            Musteriler musteri = new Musteriler();
            if(musteri.ShowDialog() == DialogResult.OK)
            {              
                txtMusteri.Text = musteri.Musteri.ToString();
            }
        }

        private void arabasec_Click(object sender, EventArgs e)
        {

           arabalarrr araba  = new arabalarrr();
            if (araba.ShowDialog() == DialogResult.OK)
            {
                txtaraba.Text = araba.Arabalar.ToString();
            }
        }
    }
}



