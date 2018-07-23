using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DataLayerV2
{
    
    public class VtProcessV2
    {
        SqlDataReader oku;
        SqlConnection baglan = new SqlConnection("Data Source=10.10.10.211;Initial Catalog=StajyerV3;User ID=sa;Password=AMAZ10;");
        public void prc_tblLog_insert(string IslemDetayi,string HataYeri)
        {
            if (baglan.State == ConnectionState.Closed)
                baglan.Open();
            SqlCommand komut = new SqlCommand("prc_tblLog_insert",baglan);
            komut.CommandType = System.Data.CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@IslemDetayi",IslemDetayi);
            komut.Parameters.AddWithValue("@HataYeri", HataYeri);
            komut.ExecuteNonQuery();
            baglan.Close();

        }
        public SqlDataReader prc_TblHasta_select()
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                SqlCommand komut = new SqlCommand("prc_TblHasta_select", baglan);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                oku = komut.ExecuteReader();
            }
            catch (Exception hata) { prc_tblLog_insert(hata.ToString(), "TblHasta_select"); }
            return oku;
        }
        public SqlDataReader prc_TblHasta_selectById(int Id)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                SqlCommand komut = new SqlCommand("prc_TblHasta_selectById", baglan);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@Id", Id);
                oku = komut.ExecuteReader();
            }
            catch (Exception hata) { prc_tblLog_insert(hata.ToString(), "TblHasta_selectById"); }
            return oku;
        }
        public void prc_TblHasta_insert(string HastaAdi, string HastaSoyadi, string Tc, string Tel, String HastaDogumTarihi, String cinsiyet)
        {
            if (baglan.State == ConnectionState.Closed)
                baglan.Open();
            try
            {
                SqlCommand komut = new SqlCommand("prc_TblHasta_insert ", baglan);
                komut.Parameters.AddWithValue("@HastaAdi", HastaAdi);
                komut.Parameters.AddWithValue("@HastaSoyadi", HastaSoyadi);
                komut.Parameters.AddWithValue("@Tc", Tc);
                komut.Parameters.AddWithValue("@Tel", Tel);
                komut.Parameters.AddWithValue("@HastaDogumTarihi", HastaDogumTarihi);
                komut.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.ExecuteNonQuery();
                baglan.Close();
                Console.WriteLine("Kaydınız gerçekleşti.");
            }
            catch (Exception hata)
            {
                prc_tblLog_insert(hata.ToString(), "TblHasta_insert");
            }
        }
        public void prc_TblHasta_Delete(int hastaID)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                SqlCommand komutdelete = new SqlCommand("prc_TblHasta_Delete", baglan);
                komutdelete.Parameters.AddWithValue("@HastaId", hastaID);
                komutdelete.CommandType = System.Data.CommandType.StoredProcedure;
                komutdelete.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                prc_tblLog_insert(hata.ToString(), "TblHasta_Delete");
            }
        }
        public void prc_tblHasta_update(int hastaID, string HastaAdi, string HastaSoyadi, string Tc, string Tel, string HastaDogumTarihi, string Cinsiyet)
        {

            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                SqlCommand komutupdate = new SqlCommand("prc_tblHasta_update ", baglan);
                komutupdate.CommandType = System.Data.CommandType.StoredProcedure;
                komutupdate.Parameters.AddWithValue("@HastaId", hastaID);
                komutupdate.Parameters.AddWithValue("@HastaAdi", HastaAdi);
                komutupdate.Parameters.AddWithValue("@HastaSoyadi", HastaSoyadi);
                komutupdate.Parameters.AddWithValue("@Tc", Tc);
                komutupdate.Parameters.AddWithValue("@Tel", Tel);
                komutupdate.Parameters.AddWithValue("@HastaDogumTarihi", HastaDogumTarihi);
                komutupdate.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);
                komutupdate.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                prc_tblLog_insert(hata.ToString(), "TblHasta_update");
            }

        }
        public SqlDataReader prc_tblDoktor_select()
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                SqlCommand komut = new SqlCommand("prc_tblDoktor_select", baglan);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                oku = komut.ExecuteReader();
            }
            catch (Exception hata)
            {
                prc_tblLog_insert(hata.ToString(), "TblDoktor_select");
            }
            return oku;           
        }
        public SqlDataReader prc_tblDoktor_selectById(int doktorID)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                SqlCommand komut = new SqlCommand("prc_tblDoktor_selectById", baglan);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@DoktorId", doktorID);
                oku = komut.ExecuteReader();
            }
            catch (Exception hata)
            {
                prc_tblLog_insert(hata.ToString(), "TblDoktor_selectById");
            }
            return oku;

        }
        public void prc_tblDoktor_insert(string doktorAdi, string doktorSoyadi, string doktorTel, string poliklinikAdi, string hastaneAdi)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                SqlCommand komut = new SqlCommand("prc_tblDoktor_insert", baglan);
                komut.Parameters.AddWithValue("@DoktorAdi", doktorAdi);
                komut.Parameters.AddWithValue("@DoktorSoyadi", doktorSoyadi);
                komut.Parameters.AddWithValue("@DoktorTel", doktorTel);
                komut.Parameters.AddWithValue("@PolAdi", poliklinikAdi);
                komut.Parameters.AddWithValue("@hastaneAdi", hastaneAdi);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.ExecuteNonQuery();
                Console.WriteLine("Kaydınız gerçekleşti.");
            }
            catch (Exception hata)
            {
                prc_tblLog_insert(hata.ToString(), "TblDoktor_insert");
            }

        }
        public void prc_tblDoktor_delete(int doktorID)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                SqlCommand komutdelete = new SqlCommand("prc_tblDoktor_delete", baglan);
                komutdelete.Parameters.AddWithValue("@DoktorId", doktorID);
                komutdelete.CommandType = System.Data.CommandType.StoredProcedure;
                komutdelete.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                prc_tblLog_insert(hata.ToString(), "TblDoktor_delete");
            }

        }
        public void prc_tblDoktor_update(int doktorID,string doktorAdi, string doktorSoyadi, string doktorTel, string poliklinikAdi, string hastaneAdi)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                SqlCommand komut = new SqlCommand("prc_tblDoktor_update", baglan);
                komut.CommandType = System.Data.CommandType.StoredProcedure;

                komut.Parameters.AddWithValue("@DoktorId", doktorID);

                komut.Parameters.AddWithValue("@DoktorAdi", doktorAdi);
                komut.Parameters.AddWithValue("@DoktorSoyadi", doktorSoyadi);
                komut.Parameters.AddWithValue("@DoktorTel", doktorTel);
                komut.Parameters.AddWithValue("@PolAdi", poliklinikAdi);
                komut.Parameters.AddWithValue("@hastaneAdi", hastaneAdi);
                komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                prc_tblLog_insert(hata.ToString(), "TblDoktor_update");
            }



        }
        public SqlDataReader prc_tblRandevu_select()
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                SqlCommand komut = new SqlCommand("prc_TblRandevu_select", baglan);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                oku = komut.ExecuteReader();
            }
            catch (Exception hata)
            {
                prc_tblLog_insert(hata.ToString(), "TblRandevu_select");
            }

            return oku;
          
        }
        public SqlDataReader prc_tblRandevu_selectById(int RandevuID)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                SqlCommand komut = new SqlCommand("prc_tblRandevu_selectById", baglan);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@RandevuID", RandevuID);
                oku = komut.ExecuteReader();
            }
            catch (Exception hata)
            {
                prc_tblLog_insert(hata.ToString(), "TblRandevu_selectById");
            }

            return oku;
        }
        public void prc_tblRandevu_insert(string HastaneAdi, string PolAdi,string DoktorAdi, string DoktorSoyadi, string RandevuTarihi, string Saat, string RandevuAciklama)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                SqlCommand komut = new SqlCommand("prc_tblRandevu_insert", baglan);
                komut.Parameters.AddWithValue("@DoktorAdi", DoktorAdi);
                komut.Parameters.AddWithValue("@DoktorSoyadi", DoktorSoyadi);
                komut.Parameters.AddWithValue("@Saat", Saat);

                komut.Parameters.AddWithValue("@RandevuTarihi", RandevuTarihi);
                komut.Parameters.AddWithValue("@HastaneAdi", HastaneAdi);

                komut.Parameters.AddWithValue("@PolAdi", PolAdi);
                komut.Parameters.AddWithValue("@RandevuAciklama", RandevuAciklama);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                prc_tblLog_insert(hata.ToString(), "TblRandevu_insert");
            }


        }
        public void prc_tblRandevu_update(int id,string HastaneAdi, string PolAdi, string DoktorAdi, string DoktorSoyadi, string RandevuTarihi, string Saat, string RandevuAciklama)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                SqlCommand komut = new SqlCommand("prc_tblRandevu_update", baglan);
                komut.Parameters.AddWithValue("@RandevuID", id);

                komut.Parameters.AddWithValue("@DoktorAdi", DoktorAdi);
                komut.Parameters.AddWithValue("@DoktorSoyadi", DoktorSoyadi);
                komut.Parameters.AddWithValue("@Saat", Saat);

                komut.Parameters.AddWithValue("@RandevuTarihi", RandevuTarihi);
                komut.Parameters.AddWithValue("@HastaneAdi", HastaneAdi);

                komut.Parameters.AddWithValue("@PolAdi", PolAdi);
                komut.Parameters.AddWithValue("@RandevuAciklama", RandevuAciklama);
                komut.CommandType = System.Data.CommandType.StoredProcedure;

                komut.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                prc_tblLog_insert(hata.ToString(), "TblRandevu_update");
            }

        }
        public void prc_tblRandevu_delete(int id)
        {
            try
            {
                if (baglan.State == ConnectionState.Closed)
                    baglan.Open();
                SqlCommand komutdelete = new SqlCommand("prc_tblRandevu_delete", baglan);
                komutdelete.Parameters.AddWithValue("@RandevuID", id);
                komutdelete.CommandType = System.Data.CommandType.StoredProcedure;
                komutdelete.ExecuteNonQuery();
            }
            catch (Exception hata)
            {
                prc_tblLog_insert(hata.ToString(), "TblRandevu_delete");
            }



        }



    }
}
