using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataLayer;

namespace stajyerEgitimV2
{
    class Program
    {
     
        static void Main(string[] args)
        {
            //ugur
           /*
            string il, ilce, HastaneAdi, HastaneAdres,Islemsecim,HangiTablo,PolAdi,Saat,Gun;
            string doktoradi, doktorsoyadi,sifre;
            int HastaneId, PolId, SaatId, calismaId,HastaneBolumlerId;
            SqlDataReader reader;           
            VtProcess prc = new VtProcess();           
            Console.WriteLine("Listeleri gormek için 1: ");
            Console.WriteLine("Eklemek için 2:");
            Console.WriteLine("Silmek için 3:");
            Console.WriteLine("İstediğin Id gir listelemek için 4:");
            Console.WriteLine("Güncellemek için 5:");
            Console.WriteLine("Çıkış için 0 a basınız\n\n");

            Console.WriteLine("\nHastane Tablosu için 1:");
            Console.WriteLine("Poliklinik tablosu için 2:");
            Console.WriteLine("Saatler tablosu için 3:");
            Console.WriteLine("Çalışma Saatleri tablosu için 4:");
            Console.WriteLine("Hastanede bulunan  bölümler için 5");
            Console.WriteLine("Hasta için 6");
            Console.WriteLine("doktor için 7");
            Console.WriteLine("Rndevu için 8");
            HangiTablo=Console.ReadLine();
            if (HangiTablo == "1")
            {
                do
                {
                    Console.Write("Hangi işlemi yapmak istiyorusun");
                    Islemsecim = Console.ReadLine();
                    switch (Islemsecim)
                    {
                        case "1":
                            reader = prc.prc_TblHastane_select();
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + "____" + reader[1] + "____" + reader[2] + "____" + reader[3] + "____" + reader[4]);
                            }
                            Console.ReadLine();
                            break;

                        case "2":
                            Console.Write("İl Giriniz:");
                            il = Console.ReadLine();
                            Console.Write("ilçe giriniz");
                            ilce = Console.ReadLine();
                            Console.Write("HastaneAdi giriniz:");
                            HastaneAdi = Console.ReadLine();
                            Console.Write("HastaneAdres giriniz:");
                            HastaneAdres = Console.ReadLine();
                            prc.prc_TblHastane_insert(il, ilce, HastaneAdi, HastaneAdres);
                            break;

                        case "3":
                            Console.WriteLine("Silmek istediğiniz hastanenin HastaneId sini Giriniz:");
                            prc.prc_TblHastane_Delete(Convert.ToInt32(Console.ReadLine()));
                            break;

                        case "4":
                            Console.Write("İl Giriniz:");
                            il = Console.ReadLine();
                            Console.Write("ilçe giriniz");
                            ilce = Console.ReadLine();
                            Console.WriteLine
                                ("Bilgilerini görmek istediğiniz hastanenin Idsini giriniz:");
                           reader=prc.prc_TblHastane_selectById(il,ilce);
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + "____" + reader[1] + "____" + reader[2] + "____" + reader[3] + "____" + reader[4]);
                            }
                            Console.ReadLine();
                            break;
                        case "5":
                            Console.Write("Bilgilerini değiştirmek istediğiniz hastanenin Idsini giriniz:");
                            HastaneId =Convert.ToInt32(Console.ReadLine());
                            Console.Write("İl Giriniz:");
                            il = Console.ReadLine();
                            Console.Write("ilçe giriniz");
                            ilce = Console.ReadLine();
                            Console.Write("HastaneAdi giriniz:");
                            HastaneAdi = Console.ReadLine();
                            Console.Write("HastaneAdres giriniz:");
                            HastaneAdres = Console.ReadLine();
                            prc.prc_TblHastane_update(HastaneId, il, ilce, HastaneAdi, HastaneAdres);
                            break;
                        case "0":
                            Console.WriteLine();
                            break;

                        default:
                            Console.WriteLine("Yanlış Karakter girdiniz");
                            break;
                    }
                } while (Islemsecim != "0");
            }
            //_____________________________________________________________________________________________________________
            else if (HangiTablo == "2")
            {
                do
                {
                    Console.Write("Hangi işlemi yapmak istiyorusun");
                    Islemsecim = Console.ReadLine();
                    switch (Islemsecim)
                    {
                        case "1":
                            reader=prc.prc_TblPoliklinik_Select();
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + "____" + reader[1]);
                            }
                            Console.ReadLine();
                            break;

                        case "2":
                            Console.Write("Poliklinik Adını yazınız:");
                            PolAdi = Console.ReadLine();
                            prc.prc_TblPoliklinik_insert(PolAdi);
                            break;

                        case "3":
                            Console.WriteLine("Silmek istediğiniz polikliniğin PolIdId sini Giriniz:");
                            prc.prc_TblPoliklinik_delete(Convert.ToInt32(Console.ReadLine()));
                            break;

                        case "4":
                            Console.WriteLine
                                ("Bilgilerini görmek istediğiniz hastanenin Idsini giriniz:");
                            reader=prc.prc_TblPoliklinik_SelectById(Convert.ToInt32(Console.ReadLine()));
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + "____" + reader[1]);
                            }
                            Console.ReadLine();
                            break;
                        case "5":
                            Console.Write("Bilgilerini değiştirmek istediğiniz polikliniğin Idsini giriniz:");
                            PolId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Yeni Poliklinik ismi:");
                            PolAdi = Console.ReadLine();
                            prc.prc_TblPoliklinik_Update(PolId, PolAdi);

                            break;
                        case "0":
                            Console.WriteLine();
                            break;

                        default:
                            Console.WriteLine("Yanlış Karakter girdiniz");
                            break;
                    }
                } while (Islemsecim != "0");
            }
            //_____________________________________________________________________________________________________________
            else if (HangiTablo == "3")
            {
                do
                {
                    Console.Write("Hangi işlemi yapmak istiyorusun");
                    Islemsecim = Console.ReadLine();
                    switch (Islemsecim)
                    {
                        case "1":
                           reader=prc.prc_TblSaatler_Select();
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + "____" + reader[1] + "___" + reader[2]);
                            }
                            Console.ReadLine();
                            break;

                        case "2":
                            Console.Write("Saati  yazınız:");
                            Saat = Console.ReadLine();
                            Console.Write("Günü yazınız:");
                            Gun = Console.ReadLine();
                            prc.prc_TblSaatler_insert(Saat, Gun);
                            break;

                        case "3":
                            Console.WriteLine("Silmek istediğiniz Saatin SaatIdsini Giriniz:");
                            prc.prc_TblSaatler_delete(Convert.ToInt32(Console.ReadLine()));

                            break;

                        case "4":
                            Console.WriteLine
                                ("Bilgilerini görmek istediğiniz Saatin Idsini giriniz:");
                            reader=prc.prc_TblSaatler_SelectById(Convert.ToInt32(Console.ReadLine()));
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + "____" + reader[1] + "___" + reader[2]);
                            }
                            Console.ReadLine();
                            break;
                        case "5":
                            Console.Write("Bilgilerini değiştirmek istediğiniz Saatin Idsini giriniz:");
                            SaatId =Convert.ToInt32(Console.ReadLine());
                            Console.Write("Yeni Saat:");
                            Saat = Console.ReadLine();
                            Console.Write("Yeni Gun:");
                            Gun = Console.ReadLine();
                            prc.prc_TblSaatler_Update(SaatId, Saat, Gun);

                            break;
                        case "0":
                            Console.WriteLine();
                            break;

                        default:
                            Console.WriteLine("Yanlış Karakter girdiniz");
                            break;
                    }
                } while (Islemsecim != "0");
            }

            //_____________________________________________________________________________________________________________
            else if (HangiTablo=="4")
            {
                do
                {
                    Console.Write("Hangi işlemi yapmak istiyorusun");
                    Islemsecim = Console.ReadLine();
                    switch (Islemsecim)
                    {
                        case "1":
                            reader=prc.prc_TblCalismaSaatleri_Select();
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + "____" + reader[1] + "___" + reader[2] + "___" + reader[3] + "___" + reader[4]);
                            }
                            Console.ReadLine();
                            break;

                        case "2":
                            Console.Write("Doktorun Adı:");
                            doktoradi = Console.ReadLine();
                            Console.Write("Doktorun Soyadı:");
                            doktorsoyadi = Console.ReadLine();                     
                            Console.Write("Saati  yazınız:");
                            Saat = Console.ReadLine();
                            Console.Write("Günü yazınız:");
                            Gun = Console.ReadLine();
                            prc.prc_TblCalismaSaatleri_insert(doktoradi,doktorsoyadi,Gun,Saat);
                            break;

                        case "3":
                            Console.WriteLine("Silmek istediğiniz CalismaSaatinin CalismaIdsini  Giriniz:");
                            prc.prc_TblCalismaSaatleri_delete(Convert.ToInt32(Console.ReadLine()));

                            break;

                        case "4":
                            Console.WriteLine
                                ("Bilgilerini görmek istediğiniz Saatin Idsini giriniz:");
                            reader=prc.prc_TblCalismaSaatleri_SelectById(Convert.ToInt32(Console.ReadLine()));
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + "____" + reader[1] + "___" + reader[2] + "___" + reader[3] + "___" + reader[4]);
                            }
                            Console.ReadLine();
                            break;
                        case "5":
                            Console.Write("Bilgilerini değiştirmek istediğiniz Saatin Idsini giriniz:");
                            calismaId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Doktorun Adı:");
                            doktoradi = Console.ReadLine();
                            Console.Write("Doktorun Soyadı:");
                            doktorsoyadi = Console.ReadLine();
                            Console.Write("Saati  yazınız:");
                            Saat = Console.ReadLine();
                            Console.Write("Günü yazınız:");
                            Gun = Console.ReadLine();
                            prc.prc_TblCalismaSaatleri_Update(calismaId,doktoradi, doktorsoyadi, Gun, Saat);

                            break;
                        case "0":
                            Console.WriteLine();
                            break;

                        default:
                            Console.WriteLine("Yanlış Karakter girdiniz");
                            break;
                    }
                } while (Islemsecim != "0");
            }
            //_____________________________________________________________________________________________________________


            else if (HangiTablo=="5")
            {

                do
                {
                    Console.Write("Hangi işlemi yapmak istiyorusun");
                    Islemsecim = Console.ReadLine();
                    switch (Islemsecim)
                    {
                        case "1":
                            reader=prc.prc_TblHastanedekiBolumler_Select();
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + "____" + reader[1] + "___" + reader[2]);
                            }
                            Console.ReadLine();
                            break;

                        case "2":
                            Console.Write("Hastane Adını yazınız:");
                            HastaneAdi = Console.ReadLine();
                            Console.Write("Poliklinik Adını yazınız:");
                            PolAdi = Console.ReadLine();
                            prc.prc_TblHastanedekiBolumler_insert(HastaneAdi,PolAdi);
                            break;

                        case "3":
                            Console.WriteLine("Silmek istediğiniz alanın ıd sini giriniz:");
                           
                            prc.prc_TblHastanedekiBolumler_delete(Convert.ToInt32(Console.ReadLine()));
                            break;

                        case "4":
                            Console.WriteLine
                                ("Bilgilerini görmek istediğiniz hastanenin Idsini giriniz:");
                            reader=prc.prc_TblHastanedekiBolumler_SelectById(Convert.ToInt32(Console.ReadLine()));
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + "____" + reader[1] + "___" + reader[2]);
                            }
                            Console.ReadLine();
                            break;
                        case "5":
                            Console.Write("Bilgilerini değiştirmek istediğiniz alanın alalarını giriniz:");
                            HastaneBolumlerId = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Hastane Adını yazınız:");
                            HastaneAdi = Console.ReadLine();
                            Console.Write("Poliklinik Adını yazınız:");
                            PolAdi = Console.ReadLine();
                            prc.prc_TblHastanedekiBolumler_Update(HastaneBolumlerId,HastaneAdi,PolAdi);
                            break;
                        case "0":
                            Console.WriteLine();
                            break;

                        default:
                            Console.WriteLine("Yanlış Karakter girdiniz");
                            break;
                    }
                } while (Islemsecim != "0");
            }
            //_____________________________________________________________________________________________________________
            else if(HangiTablo=="6")
            {
                do
                {
                    Console.Write("Hangi işlemi yapmak istiyorusun");
                    Islemsecim = Console.ReadLine();
                    switch (Islemsecim)
                    {
                        case "1":
                            reader = prc.prc_TblHasta_select();
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + "____" + reader[1] + "___" + reader[2] + "___" + reader[3] + "___" + reader[4] + "___" + reader[5] + "___" + reader[6]);
                            }
                            Console.ReadLine();
                            break;

                        case "2":
                            string HastaAdi, HastaSoyadi, HastaDogumTarihi;
                            string Tc, Tel, cinsiyet;
                            Console.Write("Hasta Adı: ");
                            HastaAdi = Console.ReadLine();
                            Console.Write("Hasta Soyadı: ");
                            HastaSoyadi = Console.ReadLine();
                            Console.Write("Tc: ");
                            Tc = Console.ReadLine();
                            Console.Write("Telefon Numarası: ");
                            Tel = Console.ReadLine();
                            Console.Write("Hasta Doğum Tarihi: ");
                            HastaDogumTarihi = Console.ReadLine();
                            Console.Write("Cinsiyet: ");
                            cinsiyet = Console.ReadLine();
                            Console.Write("Sifre:");
                            sifre = Console.ReadLine();
                            prc.prc_TblHasta_insert(HastaAdi, HastaSoyadi, Tc, Tel, HastaDogumTarihi, cinsiyet,sifre);
                            break;

                        case "3": string hastaID;
                            Console.WriteLine("Silmek istediğiniz alanın ıd sini giriniz:");                          
                            hastaID = Console.ReadLine();
                           prc.prc_TblHasta_Delete(Convert.ToInt32(hastaID));
                            break;

                        case "4":
                            string Id;
                            Console.WriteLine("Bilgilerini görmek istediğiniz hastanenin Idsini giriniz:");
                            Id = Console.ReadLine();
                            reader = prc.prc_TblHasta_selectById(Convert.ToInt32(Id));
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + "____" + reader[1] + "___" + reader[2] + "___" + reader[3] + "___" + reader[4] + "___" + reader[5] + "___" + reader[6]);
                            }
                            Console.ReadLine();
                            break;
                        case "5":
                            string id;
                            Console.Write("Güncellemek istediğiniz hasta Id'sini giriniz.");                                                     
                            id = Console.ReadLine();
                            string HastaAdi2, HastaSoyadi2, HastaDogumTarihi2;
                            string Tc2, Tel2, cinsiyet2;
                            Console.Write("Hasta Adı: ");
                            HastaAdi2 = Console.ReadLine();
                            Console.Write("Hasta Soyadı: ");
                            HastaSoyadi2 = Console.ReadLine();
                            Console.Write("Tc: ");
                            Tc2 = Console.ReadLine();
                            Console.Write("Telefon Numarası: ");
                            Tel2 = Console.ReadLine();
                            Console.Write("Hasta Doğum Tarihi: ");
                            HastaDogumTarihi2 = Console.ReadLine();
                            Console.Write("Cinsiyet: ");
                            cinsiyet2 = Console.ReadLine();
                            prc.prc_tblHasta_update(Convert.ToInt32(id), HastaAdi2, HastaSoyadi2, Tc2, Tel2, HastaDogumTarihi2, cinsiyet2);
                            break;
                        case "0":
                            Console.WriteLine();
                            break;

                        default:
                            Console.WriteLine("Yanlış Karakter girdiniz");
                            break;
                    }
                } while (Islemsecim != "0");
            }
            //_____________________________________________________________________________________________________________
            else if (HangiTablo=="7")
            {
                do
                {
                    Console.Write("Hangi işlemi yapmak istiyorusun");
                    Islemsecim = Console.ReadLine();
                    switch (Islemsecim)
                    {
                        case "1":
                            reader = prc.prc_tblDoktor_select();
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + "____" + reader[1] + "___" + reader[2] + "___" + reader[3] + "___" + reader[4] + "___" + reader[5]);
                            }
                            Console.ReadLine();
                            break;

                        case "2":
                            Console.Write("Eklemek istediğiniz doktor bilgilerini giriniz.");
                            string DoktorAdi, DoktorSoyadi, DoktorTel;
                            Console.Write("Doktor Adı: ");
                            DoktorAdi = Console.ReadLine();
                            Console.Write("Doktor Soyadı: ");
                            DoktorSoyadi = Console.ReadLine();
                            Console.Write("Telefon Numarası: ");
                            DoktorTel = Console.ReadLine();
                            Console.Write("Poliklinik Adı: ");
                            PolAdi = Console.ReadLine();
                            Console.Write("Hastane Adı: ");
                            HastaneAdi = Console.ReadLine();
                            prc.prc_tblDoktor_insert(DoktorAdi, DoktorSoyadi, DoktorTel, PolAdi, HastaneAdi);
                            break;

                        case "3":
                            string doktorID;
                            Console.Write("Silmek istediğiniz id: ");
                            doktorID = Console.ReadLine();
                            prc.prc_tblDoktor_delete(Convert.ToInt32(doktorID));
                            Console.WriteLine("Silindi.");
                            break;

                        case "4":
                            string doktorId;

                            Console.WriteLine("Görüntülemek istediğiniz doktorun Idsini giriniz.");
                            doktorId = Console.ReadLine();
                            reader = prc.prc_tblDoktor_selectById(Convert.ToInt32(doktorId));
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + " " + reader[1] + " " + reader[2] + " " + reader[3] + " " + reader[4] + " " + reader[5]);
                            }

                            break;
                        case "5":
                            Console.Write("Güncellemek istediğiniz hasta Id'sini giriniz.");
                            string id;
                            Console.Write("id: ");
                            id = Console.ReadLine();
                            string DoktorAdi2, DoktorSoyadi2, DoktorTel2, PolAdi2, HastaneAdi2;
                            Console.Write("Doktor Adı: ");
                            DoktorAdi2 = Console.ReadLine();
                            Console.Write("Doktor Soyadı: ");
                            DoktorSoyadi2 = Console.ReadLine();
                            Console.Write("Telefon Numarası: ");
                            DoktorTel2 = Console.ReadLine();
                            Console.Write("Poliklinik Adı: ");
                            PolAdi2 = Console.ReadLine();
                            Console.Write("Hastane Adı: ");
                            HastaneAdi2 = Console.ReadLine();
                            prc.prc_tblDoktor_update(Convert.ToInt32(id), DoktorAdi2, DoktorSoyadi2, DoktorTel2, PolAdi2, HastaneAdi2);
                            break;
                        case "0":
                            Console.WriteLine();
                            break;

                        default:
                            Console.WriteLine("Yanlış Karakter girdiniz");
                            break;
                    }
                } while (Islemsecim != "0");

            }

            //_____________________________________________________________________________________________________________
            else if(HangiTablo=="8")
            {
                do
                {
                    Console.Write("Hangi işlemi yapmak istiyorusun");
                    Islemsecim = Console.ReadLine();
                    switch (Islemsecim)
                    {
                        case "1":
                           reader = prc.prc_tblRandevu_select();
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + "--" + reader[1] + "--" + reader[2] + "--" + reader[3] + "--" + reader[4] + "--" + reader[5] + "--" + reader[6] + "--" + reader[7] + "--" + reader[8] + "--" + reader[9] + "--" + reader[10]);
                            }
                            break;

                        case "2":
                            Console.Write("Eklemek istediğiniz randevu bilgilerini giriniz.");
                            string DoktorAdi, DoktorSoyadi,RandevuTarihi,RandevuAciklama;
                            Console.Write("Hastane Adı: ");
                            HastaneAdi = Console.ReadLine();
                            Console.Write("Poliklinik Adı: ");
                            PolAdi = Console.ReadLine();
                            Console.Write("Doktor Adı: ");
                            DoktorAdi = Console.ReadLine();
                            Console.Write("Doktor Soyadı: ");
                            DoktorSoyadi = Console.ReadLine();
                            Console.Write("Randevu Tarihi: ");
                            RandevuTarihi = Console.ReadLine();
                            Console.Write("Randevu Saati: ");
                            Saat = Console.ReadLine();
                            Console.Write("Randevu Açıklama: ");
                            RandevuAciklama = Console.ReadLine();
                            prc.prc_tblRandevu_insert(HastaneAdi, PolAdi, DoktorAdi, DoktorSoyadi, RandevuTarihi, Saat, RandevuAciklama);
                            Console.WriteLine("Kaydınız gerçekleşti.");
                            break;
                        case "3":
                            string randevuID;
                            Console.Write("Silmek istediğiniz id: ");
                            randevuID = Console.ReadLine();
                            prc.prc_tblRandevu_delete(Convert.ToInt32(randevuID));
                            Console.WriteLine("Silindi.");
                            break;

                        case "4":
                            string randevuId;

                            Console.WriteLine("Görüntülemek istediğiniz randevunun Idsini giriniz.");
                            randevuId = Console.ReadLine();
                            reader = prc.prc_tblRandevu_selectById(Convert.ToInt32(randevuId));
                            while (reader.Read())
                            {
                                Console.WriteLine(reader[0] + "--" + reader[1] + "--" + reader[2] + "--" + reader[3] + "--" + reader[4] + "--" + reader[5] + "--" + reader[6] + "--" + reader[7] + "--" + reader[8] + "--" + reader[9] + "--" + reader[10]);
                            }

                            break;
                        case "5":
                            string id;
                            Console.Write("Güncellemek istediğiniz id'yi giriniz.");
                            id = Console.ReadLine();
                            string DoktorAdi2, DoktorSoyadi2, PolAdi2, HastaneAdi2, RandevuTarihi2, Saat2, RandevuAciklama2;
                            Console.Write("Hastane Adı: ");
                            HastaneAdi2 = Console.ReadLine();
                            Console.Write("Poliklinik Adı: ");
                            PolAdi2 = Console.ReadLine();
                            Console.Write("Doktor Adı: ");
                            DoktorAdi2 = Console.ReadLine();
                            Console.Write("Doktor Soyadı: ");
                            DoktorSoyadi2 = Console.ReadLine();
                            Console.Write("Randevu Tarihi: ");
                            RandevuTarihi2 = Console.ReadLine();
                            Console.Write("Randevu Saati: ");
                            Saat2 = Console.ReadLine();
                            Console.Write("Randevu Açıklama: ");
                            RandevuAciklama2 = Console.ReadLine();
                            prc.prc_tblRandevu_update(Convert.ToInt32(id), HastaneAdi2, PolAdi2, DoktorAdi2, DoktorSoyadi2, RandevuTarihi2, Saat2, RandevuAciklama2);
                            Console.WriteLine("Güncelleme gerçekleşti.");
                            break;                       
                        default:
                            Console.WriteLine("Yanlış Karakter girdiniz");
                            break;
                    }
                } while (Islemsecim != "0");
            }
            */





        }
    }
}
