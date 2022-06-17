using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class Musteri
    {
        public  String  ID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }

        public override string ToString()
        {
            return $"{Adi} {Soyadi} ";
        }
    }
    public class Arabalar
    {
        public String ID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public double Fiyat { get; set; }
        public DateTime Yil { get; set; }
        public string Sehir { get; set; }
        public string Aciklama { get; set; }    

        public override string ToString()
        {
            return $"{Marka} {Model} ";
        }


    }
    public class Odeme
    {
        public String ID { get; set; }
        public String MusteriID { get; set; }
        public Arabalar Arabalar { get; set; }
        public DateTime Tarih { get; set; }
        public double Fiyat { get; set; }
        public string OdemeTuru { get; set; }
        public string Aciklama { get; set; }

    }

    public class Satis
    {
        public Guid ID { get; set; }
        public Guid MusteriID { get; set; }
        public DateTime Tarih { get; set; }

        public String ArabaID { get; set; }
        public double Fiyat { get; set; }
        public string Aciklama { get; set; }
        


    }










}
