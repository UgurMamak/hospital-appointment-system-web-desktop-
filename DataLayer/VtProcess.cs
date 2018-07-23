using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
namespace DataLayer
{
   public class VtProcess
    {
        //Uğur
        public const string Baglanti = "Data Source=10.10.10.211;Initial Catalog=StajyerV3;User ID=sa;Password=AMAZ10;";
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter da;
        public   SqlCommand CreateCommand()//sql ile bağlantıyı sağlaayan fonksiyon
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = Baglanti;
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            return command;
        }

      public  void Connection(string prc)//prosedüre bağlanma işlemi
        {            
            cmd = CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = prc;
            if(cmd.Connection.State==ConnectionState.Closed)cmd.Connection.Open();           
        }
        
        public void HataYakala(string HataDetayi,string Konum )
        {
            Connection("prc_tblLog_insert");
            cmd.Parameters.AddWithValue("@IslemDetayi",HataDetayi);
            cmd.Parameters.AddWithValue("@HataYeri",Konum);
            cmd.ExecuteNonQuery();
            if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
        }
                 
        public void prc_TblHastane_Delete(int HastaneId)
        {
            try
            {
                Connection("prc_TblHastane_delete");
                cmd.Parameters.AddWithValue("@HastaneId", HastaneId);//Yazdığımız ıdyi silmeye yarar. 
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }      
            catch(Exception Hata)
            {
                HataYakala(Hata.ToString(),"TblHastane_Delete");
            }
        }

        public SqlDataReader prc_TblHastane_select()
        {
            try
            {
                Connection("prc_TblHastane_select");
                reader = cmd.ExecuteReader();                
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblHastane_select");
            }
            return reader;
        }


        public SqlDataReader prc_TblHastane_selectById(string il,string ilce)//Idsi girilen hastanenin bilgilerini listeler.
        {
            try
            {
                Connection("prc_TblHastane_selectById");
                cmd.Parameters.AddWithValue("@ilce", ilce);
                cmd.Parameters.AddWithValue("@il", il);
                reader = cmd.ExecuteReader();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblHastane_selectById");
            }
            return reader;           
        }

        public void prc_TblHastane_insert(string il,string ilce,string HastaneAdi,string HastaneAdres)
        {
            try
            {
                Connection("prc_TblHastane_insert");
                cmd.Parameters.AddWithValue("@il", il);//seçtiğimiz ilin adına bakıp iller tablosunda ilId yi çekmek için
                cmd.Parameters.AddWithValue("@ilce", ilce);//Seçilen ilçenin adına bakarak ilçenin ilceIdsini çekicek ve ilçe Idyi kaydedicek.
                cmd.Parameters.AddWithValue("@HastaneAdi", HastaneAdi);
                cmd.Parameters.AddWithValue("@HastaneAdres", HastaneAdres);
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblHastane_insert");
            }
        }

        public void prc_TblHastane_update(int HastaneId,string il, string ilce, string HastaneAdi, string HastaneAdres)
        {
            try
            {
                Connection("prc_TblHastane_update");
                cmd.Parameters.AddWithValue("@HastaneId", HastaneId);
                cmd.Parameters.AddWithValue("@HastaneIl", il);
                cmd.Parameters.AddWithValue("@HastaneIlce", ilce);
                cmd.Parameters.AddWithValue("@HastaneAdi", HastaneAdi);
                cmd.Parameters.AddWithValue("@HastaneAdres", HastaneAdres);
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblHastane_update");
            }
        }
//______________________________________________________________________________________________________________
        public void prc_TblPoliklinik_delete(int PolId)
        {
            try
            {
                Connection("prc_TblPoliklinik_delete");
                cmd.Parameters.AddWithValue("@PolId", PolId);//Yazdığımız ıdyi silmeye yarar. 
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblPoliklinik_delete");
            }
        }

        public SqlDataReader prc_TblPoliklinik_Select()
        {
            try
            {
                Connection("prc_TblPoliklinik_Select");
                reader = cmd.ExecuteReader();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblPoliklinik_Select");
            }
            return reader;                  
        }
        public SqlDataReader prc_TblPoliklinik_SelectById(int PolId)
        {
            try
            {
                Connection("prc_TblPoliklinik_SelectById");
                cmd.Parameters.AddWithValue("@Id", PolId);
                reader = cmd.ExecuteReader();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblPoliklinik_SelectById");
            }
            return reader;       
        }


        public void prc_TblPoliklinik_insert(string PolAdi)
        {
            try
            {
                Connection("prc_TblPoliklinik_insert");
                cmd.Parameters.AddWithValue("@PolAdi", PolAdi);//seçtiğimiz ilin adına bakıp iller tablosunda ilId yi çekmek için         
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblPoliklinik_insert");
            }
        }
        public void prc_TblPoliklinik_Update(int PolId,string PolAdi)
        {
            try
            {
                Connection("prc_TblPoliklinik_Update");
                cmd.Parameters.AddWithValue("@polId", PolId);
                cmd.Parameters.AddWithValue("@PolAdi", PolAdi);
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblPoliklinik_Update");
            }
        }

        //__________________________________________________________________________________________________________
        public void prc_TblSaatler_delete(int SaatId)
        {
            try
            {
                Connection("prc_TblSaatler_delete");
                cmd.Parameters.AddWithValue("@SaatId", SaatId);//Yazdığımız ıdyi silmeye yarar. 
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblSaatler_delete");
            }
        }

        public SqlDataReader prc_TblSaatler_Select()
        {
            try
            {
                Connection("prc_TblSaatler_Select");
                reader = cmd.ExecuteReader();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblSaatler_Select");
            }
            return reader;
          
        }

        public SqlDataReader prc_TblSaatler_SelectById(int SaatId)
        {
            try
            {
                Connection("prc_TblSaatler_SelectById");
                cmd.Parameters.AddWithValue("@Id", SaatId);
                reader = cmd.ExecuteReader();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblSaatler_SelectById");
            }
            return reader;
        }


        public void prc_TblSaatler_insert(string Saat,string Gun)
        {
            try
            {
                Connection("prc_TblSaatler_insert");
                cmd.Parameters.AddWithValue("@Saat", Saat);
                cmd.Parameters.AddWithValue("@Gun", Gun);
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblSaatler_insert");
            }
        }

        public void prc_TblSaatler_Update(int SaatId,string Saat, string Gun)
        {
            try
            {
                Connection("prc_TblSaatler_Update");
                cmd.Parameters.AddWithValue("@SaatId", SaatId);
                cmd.Parameters.AddWithValue("@Saat", Saat);
                cmd.Parameters.AddWithValue("@Gun", Gun);
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblSaatler_Update");
            }
        }
        //__________________________________________________________________________________________________________

        public void prc_TblCalismaSaatleri_delete(int doktorId,string gun ,string saat)
        {
            try
            {
                Connection("prc_TblCalismaSaatleri_delete");
                cmd.Parameters.AddWithValue("@doktorId", doktorId);
                cmd.Parameters.AddWithValue("@gun", gun);
                cmd.Parameters.AddWithValue("@saat", saat);
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblCalismaSaatleri_delete");
            }
        }

        public SqlDataReader prc_TblCalismaSaatleri_Select()
        {
            try
            {
                Connection("prc_TblCalismaSaatleri_Select");
                reader = cmd.ExecuteReader();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblCalismaSaatleri_Select");
            }
            return reader;
          
        }

        public SqlDataReader prc_TblCalismaSaatleri_SelectById(int CalismaId)
        {
            try
            {
                Connection("prc_TblCalismaSaatleri_SelectById");
                cmd.Parameters.AddWithValue("@Id", CalismaId);
                reader = cmd.ExecuteReader();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblCalismaSaatleri_SelectById");
            }
        
            return reader;
        }

        public void prc_TblCalismaSaatleri_insert(int doktorId,string Gun, string Saat)
        {
            try
            {
                Connection("prc_TblCalismaSaatleri_insert");
                cmd.Parameters.AddWithValue("@DoktorId",doktorId);
                cmd.Parameters.AddWithValue("@Saat", Saat);
                cmd.Parameters.AddWithValue("@Gun", Gun);
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblCalismaSaatleri_insert");
            }
        }

        public void prc_TblCalismaSaatleri_Update(int CalismaId,string DoktorAdi, string DoktorSoyadi, string Gun, string Saat)
        {
            try
            {
                Connection("prc_TblCalismaSaatleri_Update");
                cmd.Parameters.AddWithValue("@CalismaId", CalismaId);
                cmd.Parameters.AddWithValue("@DoktorAdi", DoktorAdi);
                cmd.Parameters.AddWithValue("@DoktorSoyadi", DoktorSoyadi);
                cmd.Parameters.AddWithValue("@Saat", Saat);
                cmd.Parameters.AddWithValue("@Gun", Gun);
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblCalismaSaatleri_Update");
            }
        }
        //__________________________________________________________________________________________________________

        public void prc_TblHastanedekiBolumler_delete(int @HastaneBolumlerId)
        {
            try
            {
                Connection("prc_TblHastanedekiBolumler_delete");
                cmd.Parameters.AddWithValue("@HastaneBolumlerId", @HastaneBolumlerId);//Yazdığımız ıdyi silmeye yarar. 
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblHastanedekiBolumler_delete");
            }
        }
        public SqlDataReader prc_TblHastanedekiBolumler_Select()
        {
            try
            {
                Connection("prc_TblHastanedekiBolumler_Select");
                reader = cmd.ExecuteReader();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblHastanedekiBolumler_Select");
            }
            return reader;         
        }

        public SqlDataReader prc_TblHastanedekiBolumler_SelectById(int HastaneBolumlerId)
        {
            try
            {
                Connection("prc_TblHastanedekiBolumler_SelectById");
                cmd.Parameters.AddWithValue("@Id", HastaneBolumlerId);
                reader = cmd.ExecuteReader();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblHastanedekiBolumler_SelectById");
            }
            return reader;
        }

        public void prc_TblHastanedekiBolumler_insert(string hastaneAdi,string poladi)
        {
            try
            {
                Connection("prc_TblHastanedekiBolumler_insert");
                cmd.Parameters.AddWithValue("@HastaneAdi", hastaneAdi);
                cmd.Parameters.AddWithValue("@PolAdi", poladi);
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblHastanedekiBolumler_insert");
            }
        }

        public void prc_TblHastanedekiBolumler_Update(int HastaneBolumlerId, string hastaneAdi, string poladi)
        {
            try
            {
                Connection("prc_TblHastanedekiBolumler_Update");
                cmd.Parameters.AddWithValue("@HastaneBolumlerId", HastaneBolumlerId);
                cmd.Parameters.AddWithValue("@HastaneAdi", hastaneAdi);
                cmd.Parameters.AddWithValue("@PolAdi", poladi);
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception Hata)
            {
                HataYakala(Hata.ToString(), "TblHastanedekiBolumler_Update");
            }
        }
        //__________________________________________________________________________________________________________       
        // /Zeynep
        

        public SqlDataReader prc_TblHasta_select()
        {
            try
            {
                Connection("prc_TblHasta_select");                
                reader =cmd.ExecuteReader();
            }
            catch (Exception hata) { HataYakala(hata.ToString(), "TblHasta_select"); }
            return reader;
        }
        public SqlDataReader prc_TblHasta_selectById(int Id)
        {
            try
            {
                Connection("prc_TblHasta_selectById");             
                cmd.Parameters.AddWithValue("@Id", Id);
                reader =cmd.ExecuteReader();
            }
            catch (Exception hata) { HataYakala(hata.ToString(),"TblHasta_selectById"); }
            return reader;
        }
        public void prc_TblHasta_insert(string HastaAdi, string HastaSoyadi, string Tc, string Tel, string HastaDogumTarihi, string cinsiyet,string sifre)
        {
            try
            {                                       
                Connection("prc_TblHasta_insert");
                cmd.Parameters.AddWithValue("@HastaAdi", HastaAdi);
                cmd.Parameters.AddWithValue("@HastaSoyadi", HastaSoyadi);
                cmd.Parameters.AddWithValue("@Tc", Tc);
                cmd.Parameters.AddWithValue("@Tel", Tel);
                cmd.Parameters.AddWithValue("@HastaDogumTarihi", HastaDogumTarihi);
                cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                cmd.Parameters.AddWithValue("@Sifre",sifre);
                cmd.ExecuteNonQuery();              
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception hata) { HataYakala(hata.ToString(), "TblHasta_insert"); }
           
        }


        public void prc_TblHasta_Delete(int hastaID)
        {
            try
            {
                Connection("prc_TblHasta_Delete");                
                cmd.Parameters.AddWithValue("@HastaId", hastaID);                
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception hata) { HataYakala(hata.ToString(), "TblHasta_Delete"); }
        }

        public void prc_tblHasta_update(int hastaID, string HastaAdi, string HastaSoyadi, string Tc, string Tel, string HastaDogumTarihi, string Cinsiyet)
        {
            try
            {
                Connection("prc_tblHasta_update");
                cmd.Parameters.AddWithValue("@HastaId", hastaID);
                cmd.Parameters.AddWithValue("@HastaAdi", HastaAdi);
                cmd.Parameters.AddWithValue("@HastaSoyadi", HastaSoyadi);
                cmd.Parameters.AddWithValue("@Tc", Tc);
                cmd.Parameters.AddWithValue("@Tel", Tel);
                cmd.Parameters.AddWithValue("@HastaDogumTarihi", HastaDogumTarihi);
                cmd.Parameters.AddWithValue("@Cinsiyet", Cinsiyet);
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception hata){ HataYakala(hata.ToString(), "TblHasta_update"); }
        }
//__________________________________________________________________________________________--
        public SqlDataReader prc_tblDoktor_select()
        {
            try
            {
                Connection("prc_tblDoktor_select");
                reader = cmd.ExecuteReader();
            }
            catch (Exception hata){ HataYakala(hata.ToString(), "TblDoktor_select"); }
            return reader;
        }

        public SqlDataReader prc_tblDoktor_selectById(int doktorID)
        {
            try
            {
                Connection("prc_tblDoktor_selectById");               
                cmd.Parameters.AddWithValue("@DoktorId", doktorID);
                reader = cmd.ExecuteReader();
            }
            catch (Exception hata) {HataYakala(hata.ToString(), "TblDoktor_selectById");}
            return reader;
        }
        public void prc_tblDoktor_insert(string doktorAdi, string doktorSoyadi, string doktorTel, string poliklinikAdi, string hastaneAdi)
        {
            try
            {
                Connection("prc_tblDoktor_insert");          
                cmd.Parameters.AddWithValue("@DoktorAdi", doktorAdi);
                cmd.Parameters.AddWithValue("@DoktorSoyadi", doktorSoyadi);
                cmd.Parameters.AddWithValue("@DoktorTel", doktorTel);
                cmd.Parameters.AddWithValue("@PolAdi", poliklinikAdi);
                cmd.Parameters.AddWithValue("@hastaneAdi", hastaneAdi);               
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception hata){ HataYakala(hata.ToString(), "TblDoktor_insert"); }
        }

        public void prc_tblDoktor_delete(int doktorID)
        {
            try
            {
                Connection("prc_tblDoktor_delete");
               cmd.Parameters.AddWithValue("@DoktorId", doktorID);               
               cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception hata)
            {
                HataYakala(hata.ToString(), "TblDoktor_delete");
            }
        }

        public void prc_tblDoktor_update(int doktorID, string doktorAdi, string doktorSoyadi, string doktorTel, string poliklinikAdi, string hastaneAdi)
        {
            try
            {
                Connection("prc_tblDoktor_update");       
                cmd.Parameters.AddWithValue("@DoktorId", doktorID);
                cmd.Parameters.AddWithValue("@DoktorAdi", doktorAdi);
                cmd.Parameters.AddWithValue("@DoktorSoyadi", doktorSoyadi);
                cmd.Parameters.AddWithValue("@DoktorTel", doktorTel);
                cmd.Parameters.AddWithValue("@PolAdi", poliklinikAdi);
                cmd.Parameters.AddWithValue("@hastaneAdi", hastaneAdi);
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception hata){ HataYakala(hata.ToString(), "TblDoktor_update");}
        }

        //__________________________________________________________________________________________
        public SqlDataReader prc_tblRandevu_select()
        {
            try
            {
                Connection("prc_tblRandevu_select");               
                reader=cmd.ExecuteReader();
            }
            catch (Exception hata){ HataYakala(hata.ToString(), "TblRandevu_select"); }
            return reader;
        }


        public SqlDataReader prc_tblRandevu_selectById(int RandevuID)
        {
            try
            {
                Connection("prc_tblRandevu_selectById");          
                cmd.Parameters.AddWithValue("@RandevuID", RandevuID);
                reader = cmd.ExecuteReader();
            }
            catch (Exception hata)  { HataYakala(hata.ToString(), "TblRandevu_selectById"); }
            return reader;
        }


        public void prc_tblRandevu_insert(int hastaneId,int polId,int doktorId,string RandevuTarihi, string Saat, string RandevuAciklama,int hastaId)
        {
            try
            {
                Connection("prc_tblRandevu_insert");                
                cmd.Parameters.AddWithValue("@doktorId", doktorId);
                cmd.Parameters.AddWithValue("@HastaId", hastaId);
                cmd.Parameters.AddWithValue("@Saat", Saat);
                cmd.Parameters.AddWithValue("@RandevuTarihi", RandevuTarihi);
                cmd.Parameters.AddWithValue("@hastaneId", hastaneId);
                cmd.Parameters.AddWithValue("@polId", polId);
                cmd.Parameters.AddWithValue("@RandevuAciklama", RandevuAciklama);              
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception hata){HataYakala(hata.ToString(), "TblRandevu_insert"); }
        }

        public void prc_tblRandevu_update(int id, string HastaneAdi, string PolAdi, string DoktorAdi, string DoktorSoyadi, string RandevuTarihi, string Saat, string RandevuAciklama)
        {
            try
            {
                Connection("prc_tblRandevu_update");               
                cmd.Parameters.AddWithValue("@RandevuID", id);
                cmd.Parameters.AddWithValue("@DoktorAdi", DoktorAdi);
                cmd.Parameters.AddWithValue("@DoktorSoyadi", DoktorSoyadi);
                cmd.Parameters.AddWithValue("@Saat", Saat);
                cmd.Parameters.AddWithValue("@RandevuTarihi", RandevuTarihi);
                cmd.Parameters.AddWithValue("@HastaneAdi", HastaneAdi);
                cmd.Parameters.AddWithValue("@PolAdi", PolAdi);
                cmd.Parameters.AddWithValue("@RandevuAciklama", RandevuAciklama);                
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception hata){ HataYakala(hata.ToString(), "TblRandevu_update");}
        }

        public void prc_tblRandevu_delete(int id)
        {
            try
            {
                Connection("prc_tblRandevu_delete");               
                cmd.Parameters.AddWithValue("@RandevuID", id);              
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception hata) { HataYakala(hata.ToString(), "TblRandevu_delete");}
        }

        public SqlDataReader procRandevuTarih(string tarih,int doktorId)
        {
            try
            {
                Connection("procRandevuTarih");
                cmd.Parameters.AddWithValue("@Tarih",tarih);
                cmd.Parameters.AddWithValue("@DoktorId", doktorId);     
                reader = cmd.ExecuteReader();
            }
            catch(Exception hata) { HataYakala(hata.ToString(), "procRandevuTarih"); }
            return reader;
        }
        public SqlDataReader prc_Iller_Select()
        {
            try
            {
                Connection("prc_Iller_Select");
                reader = cmd.ExecuteReader();
            }
            catch (Exception hata) { HataYakala(hata.ToString(), "prc_Iller_Select"); }
            return reader;


        }

        public SqlDataReader proc_Ilceler_Select(string ilAdi)
        {
            try
            {
                Connection("proc_Ilceler_Select");
                cmd.Parameters.AddWithValue("@IlAdi",ilAdi);
                reader = cmd.ExecuteReader();
            }
            catch (Exception hata) { HataYakala(hata.ToString(), "proc_Ilceler_Select"); }
            return reader;
        }

        public SqlDataAdapter prc_DoktorCalismaPlaniSelect(int doktorId)
        {
            try
            {
                Connection("prc_DoktorCalismaPlaniSelect");
                cmd.Parameters.AddWithValue("@DoktorId", doktorId);
                da = new SqlDataAdapter(cmd);
            }
            catch (Exception hata) { HataYakala(hata.ToString(), "prc_DoktorCalismaPlaniSelect"); }
            
            return da;
        }

        public SqlDataReader prc_TblYonetici_Select()
        {
            try
            {
                Connection("prc_TblYonetici_Select");
                reader = cmd.ExecuteReader();

            }
            catch (Exception hata) { HataYakala(hata.ToString(), "prc_TblYonetici_Select"); }
            return reader;
        }

        public void prc_TblYonetici_insert(string yonad, string yonsoyad, string tc, string sifre)
        {
            try
            {
                Connection("prc_TblYonetici_insert");
                cmd.Parameters.AddWithValue("@adi", yonad);
                cmd.Parameters.AddWithValue("@soyadi", yonsoyad);
                cmd.Parameters.AddWithValue("@Tc", tc);
                cmd.Parameters.AddWithValue("@sifre", sifre);              
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception hata) { HataYakala(hata.ToString(), "prc_TblYonetici_insert"); }
        }


        public void prc_TblYonetici_delete(string tc)
        {
            try
            {
                Connection("prc_TblYonetici_delete");
                cmd.Parameters.AddWithValue("@tc", tc);
                cmd.ExecuteNonQuery();
                if (cmd.Connection.State == ConnectionState.Open) cmd.Connection.Close();
            }
            catch (Exception hata) { HataYakala(hata.ToString(), "prc_TblYonetici_delete"); }
        }




        public SqlDataAdapter prc_tblRandevuBilgi_Select(int hastaId)
        {
            try
            {
                Connection("prc_tblRandevuBilgi_Select");
                cmd.Parameters.AddWithValue("@num", hastaId);
                da = new SqlDataAdapter(cmd);
            }
            catch (Exception hata) { HataYakala(hata.ToString(), "prc_tblRandevuBilgi_Select"); }

            return da;
        }







    }
}
