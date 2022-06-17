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
    public partial class MusteriFormu : Form
    {
        public MusteriFormu()
        {
            InitializeComponent();
        }

        private void MusteriFormu_Load(object sender, EventArgs e)
        {
            txtID.Text = Musteri.ID.ToString();
            if (MusteriGuncelleme)
            {
                txtadi.Text = Musteri.Adi;
                txtsoyadi.Text = Musteri.Soyadi;
                txttel.Text  = Musteri.Telefon;
                txtmail.Text = Musteri.Mail;
                txtadres.Text = Musteri.Adres;
            }
            
        }

        public Musteri Musteri = new Musteri()

        {
            ID = Guid.NewGuid().ToString()
        };
        public bool Guncelleme { get; set; } = false;

        public bool MusteriGuncelleme { get; set; } = false;

        private void Tamambutonu_Click(object sender, EventArgs e)
        {
            if (!Hata_Kontrolu(txtadi)) return;
            if (!Hata_Kontrolu(txtsoyadi)) return;
            if (!Hata_Kontrolu(txttel)) return;
            if (!Hata_Kontrolu(txtmail)) return;
            if (!Hata_Kontrolu(txtadres)) return;

            Musteri.Adi = txtadi.Text;
            Musteri.Soyadi = txtsoyadi.Text;
            Musteri.Telefon = txttel.Text;
            Musteri.Mail = txtmail.Text;
            Musteri.Adres = txtadres.Text;

            

            DialogResult = DialogResult.OK;
        }

        private void İptalButonu_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private bool Hata_Kontrolu(Control kontrol)
        {
            if (kontrol is TextBox)
            {


                if (kontrol.Text == "")
                {
                    errorProvider1.SetError(kontrol, "Eksik Veya Hatalı Bilgi");
                    txtadi.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(kontrol, "");
                }
                return true;
            }

            if (kontrol is MaskedTextBox)
            {


                if (!((MaskedTextBox)kontrol).MaskFull)
                {
                    errorProvider1.SetError(kontrol, "Eksik Veya Hatalı Bilgi");
                    txtadi.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(kontrol, "");
                }
                return true;
            }

            return true;
        }
    }




}
