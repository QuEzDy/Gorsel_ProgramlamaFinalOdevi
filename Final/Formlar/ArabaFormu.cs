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
    public partial class ArabaFormu : Form
    {
        public ArabaFormu()
        {
            InitializeComponent();
        }

        public Arabalar Arabalar { get; set; }
        public bool ArabaGuncelleme { get; set; } = false;

        public Arabalar arabalar = new Arabalar();



        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            if (Hata_Kontrolu(txtarabamarka)) return;
            if (Hata_Kontrolu(txtarabamodel)) return;
            if (Hata_Kontrolu(nmparabafiyat)) return;
            if (Hata_Kontrolu(dateTimePicker1)) return;
            if (Hata_Kontrolu(cbsehir)) return;
            if (Hata_Kontrolu(txtaciklama)) return;

            Arabalar.Marka = txtarabamarka.Text;
            Arabalar.Model = txtarabamodel.Text;
            Arabalar.Fiyat = (double)nmparabafiyat.Value;
       //   Arabalar.Yil = dateTimePicker1.Value.ToString();
            Arabalar.Yil = dateTimePicker1.Value;
            Arabalar.Sehir = cbsehir.Text;
            Arabalar.Aciklama = txtaciklama.Text;

           
        }


        private bool Hata_Kontrolu(Control kontrol)
        {
            if (kontrol is TextBox|| kontrol is ComboBox)
            {


                if (kontrol.Text == "")
                {
                    errorProvider1.SetError(kontrol, "Eksik Veya Hatalı Bilgi");
                    kontrol.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(kontrol, "");
                }
                return true;
            }

            if (kontrol is NumericUpDown)
            {


                if (((NumericUpDown)kontrol).Value==0)
                {
                    errorProvider1.SetError(kontrol, "Eksik Veya Hatalı Bilgi");
                    kontrol.Focus();
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

        

  


        private void İptalButonu_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        //private void Tamambutonu_Click(object sender, EventArgs e)
        //{
        //    if (Hata_Kontrolu(txtarabamarka)) return;
        //    if (Hata_Kontrolu(txtarabamodel)) return;
        //    if (Hata_Kontrolu(nmparabafiyat)) return;
        //    if (Hata_Kontrolu(dateTimePicker1)) return;
        //    if (Hata_Kontrolu(cbsehir)) return;
        //    if (Hata_Kontrolu(txtaciklama)) return;

        //    Arabalar.Marka = txtarabamarka.Text;
        //    Arabalar.Model = txtarabamodel.Text;
        //    Arabalar.Fiyat = (double)nmparabafiyat.Value;
        //    Arabalar.Yil = (dateTimePicker1.Value.ToString());
        //    Arabalar.Sehir = cbsehir.Text;
        //    Arabalar.Aciklama = txtaciklama.Text;

        //    DialogResult = DialogResult.OK;
        //}

        private void ArabaFormu_Load(object sender, EventArgs e)
        {
            if (ArabaGuncelleme)
            {
                txtarabaID.Text = Arabalar.ID.ToString();
                if (ArabaGuncelleme)
                {
                    txtarabamarka.Text = Arabalar.Marka;
                    txtarabamodel.Text = Arabalar.Model;
                    nmparabafiyat.Value = (decimal)Arabalar.Fiyat;
                   // Arabalar.Yil = (String)dateTimePicker1.Value.ToLongDateString();
                    dateTimePicker1.Value = Arabalar.Yil;
                    cbsehir.Text = Arabalar.Sehir;
                    txtaciklama.Text = Arabalar.Aciklama;
                }
            }
        }

       
    }
}

