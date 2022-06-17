using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final.Veritabani;

namespace Final.Bl
{
    public static class BLogic
    {
        public static bool MusteriEkle(Musteri musteri)
        {
            try
            {
                int sonuc = Veritabani.Veritabanibaglanti.MusteriEkle(musteri);
                return (sonuc > 0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu" + hata.Message);
                return false;

            }

        }

        internal static DataSet MusterileriGetir(string v)
        {
            try
            {
                DataSet dataSet = Veritabanibaglanti.MusteriGetir(v);

                return dataSet;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu" + hata.Message);
                return null;

            }
        }

        internal static bool MusteriGuncelle(Musteri musteri)
        {
            try
            {
                int sonuc = Veritabanibaglanti.MusteriGuncelle(musteri);
                return (sonuc > 0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu" + hata.Message);
                return false;

            }
        }

        internal static bool MusteriSil(string id)
        {
            try
            {
                int sonuc = Veritabanibaglanti.MusteriSil(id);
                return (sonuc > 0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu" + hata.Message);
                return false;

            }
        }

        internal static bool SatisEkle(Satis satis)
        {

            try
            {
                int sonuc = Veritabani.Veritabanibaglanti.SatisEkle(satis);
                return (sonuc > 0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu" + hata.Message);
                return false;

            }
        }

        internal static DataSet SatisDetay(string v)
        {

            try
            {
                DataSet dataSet = Veritabanibaglanti.SatisDetay();

                return dataSet;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu" + hata.Message);
                return null;

            }
        }

        internal static bool ArabaEkle(Arabalar arabalar)
        {
            try
            {
                int sonuc = Veritabani.Veritabanibaglanti.ArabaEkle(arabalar);
                return (sonuc > 0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu" + hata.Message);
                return false;

            }
        }

        internal static bool SatisGuncelle(Satis satis)
        {
            try
            {
                int sonuc = Veritabanibaglanti.SatisGuncelle(satis);
                return (sonuc > 0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu" + hata.Message);
                return false;

            }
        }

        internal static DataSet ArabalariGetir(string arabalar)
        {

            try
            {
                DataSet dataSet = Veritabanibaglanti.ArabaGetir(arabalar);

                return dataSet;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu" + hata.Message);
                return null;

            }
        }

        internal static bool ArabaGuncelle(Arabalar arabalar)
        {
            try
            {
                int sonuc = Veritabanibaglanti.ArabaGuncelle(arabalar);
                return (sonuc > 0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu" + hata.Message);
                return false;

            }
        }

        internal static bool SatisSil(string ıD)
        {
            try
            {
                int sonuc = Veritabanibaglanti.SatisSil(ıD);
                return (sonuc > 0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu" + hata.Message);
                return false;

            }
        }

        internal static bool ArabaSil(string ıD)
        {
            try
            {
                int sonuc = Veritabanibaglanti.ArabaSil(ıD);
                return (sonuc > 0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu" + hata.Message);
                return false;

            }
        }

        internal static bool OdemeEkle(Odeme odeme)
        {
            try
            {
                int sonuc = Veritabani.Veritabanibaglanti.OdemeEkle(odeme);
                return (sonuc > 0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu" + hata.Message);
                return false;

            }
        }

        internal static DataSet OdemeDetay(string v)
        {
            try
            {
                DataSet dataSet = Veritabanibaglanti.OdemeDetay();

                return dataSet;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu" + hata.Message);
                return null;

            }
        }

        internal static bool OdemeGuncelle(Odeme odeme)
        {
            try
            {
                int sonuc = Veritabanibaglanti.OdemeGuncelle(odeme);
                return (sonuc > 0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu" + hata.Message);
                return false;

            }
        }

        internal static bool OdemeSil(string ıD)
        {
            try
            {
                int sonuc = Veritabanibaglanti.OdemeSil(ıD);
                return (sonuc > 0);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata Oluştu" + hata.Message);
                return false;

            }
        }
    }

}