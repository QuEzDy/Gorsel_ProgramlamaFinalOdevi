using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Veritabani
{
    public static class Veritabanibaglanti
    {

        static MySqlConnection baglanti = new MySqlConnection(
             new MySqlConnectionStringBuilder()
             {
                 Server = "localhost",
                 Database = "car_db",
                 Port = 3306,
                 UserID = "root",
                 Password = "root",
             }.ConnectionString
             );
        public static int MusteriEkle(Musteri musteri)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand cmd = new MySqlCommand("addCustomer", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", musteri.ID);
                cmd.Parameters.AddWithValue("@adi", musteri.Adi);
                cmd.Parameters.AddWithValue("@soyadi", musteri.Soyadi);
                cmd.Parameters.AddWithValue("@telefon", musteri.Telefon);
                cmd.Parameters.AddWithValue("@mail", musteri.Mail);
                cmd.Parameters.AddWithValue("@adres", musteri.Adres);

                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;

            }
            catch (Exception hata)
            {
                throw hata;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }





        }

        internal static int MusteriSil(string id)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("deleteCustomer", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;
            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();

            }
        }

        internal static DataSet SatisDetay()
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("SaleDetail", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ds);

                return ds;

            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }

        }

        internal static int SatisGuncelle(Satis satis)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("UpdatePayment", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", satis.ID);
                cmd.Parameters.AddWithValue("@customer_id", satis.MusteriID);
                cmd.Parameters.AddWithValue("@sale_id", satis.ArabaID);
                cmd.Parameters.AddWithValue("@date_time", satis.Tarih);
                cmd.Parameters.AddWithValue("@price", satis.Fiyat);            

                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;
            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();

            }
        }

        internal static int SatisEkle(Satis satis)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand cmd = new MySqlCommand("addSale", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", satis.ID);
                cmd.Parameters.AddWithValue("@customer_id", satis.MusteriID);
                cmd.Parameters.AddWithValue("@car_id", satis.ArabaID);
                cmd.Parameters.AddWithValue("@date_time", satis.Tarih);
                cmd.Parameters.AddWithValue("@price", satis.Fiyat);
                

                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;

            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }


        }

        internal static int ArabaSil(string ıD)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("DeleteCar", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ıD);
                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;
            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();

            }
        }

        internal static DataSet OdemeDetay()
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("Galeri_OdemeDetay", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;


                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ds);

                return ds;

            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        internal static int OdemeSil(string ıD)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("deletePayment", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ıD);
                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;
            }
            catch (Exception hata)
            {
                throw hata;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        internal static int OdemeGuncelle(Odeme odeme)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand cmd = new MySqlCommand("updatePayment", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@saleid", odeme.ID);
                cmd.Parameters.AddWithValue("@id", odeme.MusteriID);
                cmd.Parameters.AddWithValue("@datetime", odeme.Tarih);
                cmd.Parameters.AddWithValue("@price", odeme.Fiyat);
                cmd.Parameters.AddWithValue("@payment_type", odeme.OdemeTuru);
                cmd.Parameters.AddWithValue("@descriptions", odeme.Aciklama);


                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;

            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        internal static int OdemeEkle(Odeme odeme)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand cmd = new MySqlCommand("addPayment", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@saleid", odeme.ID);
                cmd.Parameters.AddWithValue("@id", odeme.MusteriID);
                cmd.Parameters.AddWithValue("@datetime", odeme.Tarih);
                cmd.Parameters.AddWithValue("@price", odeme.Fiyat);
                cmd.Parameters.AddWithValue("@payment_type", odeme.OdemeTuru);
                cmd.Parameters.AddWithValue("@descriptions", odeme.Aciklama);


                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;

            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        internal static int ArabaEkle(Arabalar arabalar)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();

                MySqlCommand komut = new MySqlCommand("addCar", baglanti);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", arabalar.ID);
                komut.Parameters.AddWithValue("@marka", arabalar.Marka);
                komut.Parameters.AddWithValue("@model", arabalar.Model);
                komut.Parameters.AddWithValue("@fiyat", arabalar.Fiyat);
                komut.Parameters.AddWithValue("@yil", arabalar.Yil);
                komut.Parameters.AddWithValue("@sehir", arabalar.Sehir);
                komut.Parameters.AddWithValue("@aciklama", arabalar.Aciklama);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }
        }

        internal static int SatisSil(string ıD)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("deletePayment", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", ıD);
                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;
            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();

            }
        }

        internal static int ArabaGuncelle(Arabalar arabalar)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("updateCar", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", arabalar.ID);
                cmd.Parameters.AddWithValue("@aarka", arabalar.Marka);
                cmd.Parameters.AddWithValue("@model", arabalar.Model);
                cmd.Parameters.AddWithValue("@fiyat", arabalar.Fiyat);
                cmd.Parameters.AddWithValue("@yil", arabalar.Yil);
                cmd.Parameters.AddWithValue("@sehir", arabalar.Sehir);
                cmd.Parameters.AddWithValue("@aciklama", arabalar.Aciklama);

                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;
            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();

            }

        }

        internal static int MusteriGuncelle(Musteri musteri)
        {
            try
            {

                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd = new MySqlCommand("updateCustomer", baglanti);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", musteri.ID);
                cmd.Parameters.AddWithValue("@adi", musteri.Adi);
                cmd.Parameters.AddWithValue("@soyadi", musteri.Soyadi);
                cmd.Parameters.AddWithValue("@telefon", musteri.Telefon);
                cmd.Parameters.AddWithValue("@mail", musteri.Mail);
                cmd.Parameters.AddWithValue("@adres", musteri.Adres);

                int sonuc = cmd.ExecuteNonQuery();
                return sonuc;
            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();

            }



        }

        public static DataSet MusteriGetir(string v)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd;
                if (string.IsNullOrEmpty(v))
                {
                    cmd = new MySqlCommand("getAllCustomer", baglanti);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    cmd = new MySqlCommand("getCustomer", baglanti);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", v);
                }
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ds);

                return ds;

            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }


        }
        internal static DataSet ArabaGetir(string v)
        {
            try
            {
                if (baglanti.State != System.Data.ConnectionState.Open)
                    baglanti.Open();
                MySqlCommand cmd;
                if (string.IsNullOrEmpty(v))
                {
                    cmd = new MySqlCommand("getAllCar", baglanti);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                }
                else
                {
                    cmd = new MySqlCommand("getCar", baglanti);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", v);
                }
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ds);

                return ds;

            }
            catch (Exception hata)
            {
                throw hata;

            }
            finally
            {
                if (baglanti.State != System.Data.ConnectionState.Closed)
                    baglanti.Close();
            }


        }
    }
}


    

