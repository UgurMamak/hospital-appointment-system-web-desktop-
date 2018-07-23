using System;
using DataLayerV2;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace stajyerEgitimV3
{
    class Program
    {
        static void Main(string[] args)
        {
            VtProcessV2 database = new VtProcessV2();
            SqlDataReader oku;
            
            while (1 == 1) {
                string secim2;
                Console.Write(" 1)Hasta bilgilerinde işlem yapmak için 1'e basınız. \n 2)Doktor bilgilerinde işlem yapmak için 2'ye basınız. \n 3)Randevu işlemleri için 3'e basınız. ");
                secim2 = Console.ReadLine();
                if ("1"== secim2)
            {
                while (1 == 1)
                {
                    string secim;
                    Console.Write(" 1)Hastaları görüntülemek için 1'e basınız. \n 2)Id'sine göre hasta seçmek için 2'ye basınız. \n 3)Hasta silmek için 3'e basınız. \n 4)Hasta eklemek için 4'e basınız. \n 5)Düzenleme yapmak için 5'e basınız \n Yapmak istediğniz işlemi seçiniz: ");
                    secim = Console.ReadLine();
                    switch (secim)
                    {
                        case "1":
                           oku=database.prc_TblHasta_select();
                                while (oku.Read())
                                {
                                    Console.WriteLine(oku[0] + "--" + oku[1] + "--" + oku[2] + "--" + oku[3] + "--" + oku[4] + "--" + oku[5]);
                                }

                                oku.Close();
                                break;
                            case "2":
                            string Id;

                            Console.Write("id: ");
                            Id = Console.ReadLine();
                            oku=database.prc_TblHasta_selectById(Convert.ToInt32(Id));
                                while (oku.Read())
                                {
                                    Console.WriteLine(oku[0] + "--" + oku[1] + "--" + oku[2] + "--" + oku[3] + "--" + oku[4] + "--" + oku[5]);
                                }

                                oku.Close();
                                break;
                        case "3":
                           oku= database.prc_TblHasta_select();
                                while (oku.Read())
                                {
                                    Console.WriteLine(oku[0] + "--" + oku[1] + "--" + oku[2] + "--" + oku[3] + "--" + oku[4] + "--" + oku[5]);
                                }

                                oku.Close();
                                string hastaID;
                            Console.Write("Silmek istediğiniz id: ");
                            hastaID = Console.ReadLine();
                            database.prc_TblHasta_Delete(Convert.ToInt32(hastaID));
                            oku=database.prc_TblHasta_select();
                                while (oku.Read())
                                {
                                    Console.WriteLine(oku[0] + "--" + oku[1] + "--" + oku[2] + "--" + oku[3] + "--" + oku[4] + "--" + oku[5]);
                                }

                                oku.Close();

                                break;
                        case "4":
                            Console.Write("Eklemek istediğiniz hasta bilgilerini hasta adı, soyadı tcsi, Telefon numarsı, doğum tarihi ve cinsiyetini bu sıralamayla giriniz.");
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
                            database.prc_TblHasta_insert(HastaAdi, HastaSoyadi, Tc, Tel, HastaDogumTarihi, cinsiyet);
                                
                                break;
                        case "5":
                            oku=database.prc_TblHasta_select();
                                while (oku.Read())
                                {
                                    Console.WriteLine(oku[0] + "--" + oku[1] + "--" + oku[2] + "--" + oku[3] + "--" + oku[4] + "--" + oku[5]);
                                }

                                oku.Close();

                                Console.Write("Güncellemek istediğiniz hasta Id'sini giriniz.");
                            string id;
                            Console.Write("id: ");
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
                            database.prc_tblHasta_update(Convert.ToInt32(id), HastaAdi2, HastaSoyadi2, Tc2, Tel2, HastaDogumTarihi2, cinsiyet2);

                            break;
                        default:
                            Console.WriteLine("Hatalı giriş.");
                            break;

                    }

                }


            }
            else if ("2" == secim2)
            {
                while (1 == 1)
                {

                    string doktorsecim;
                    Console.Write(" 1)Doktorları görüntülemek için 1'e basınız. \n 2)Id'sine göre doktor seçmek için 2'ye basınız. \n 3)Doktor silmek için 3'e basınız. \n 4)Doktor eklemek için 4'e basınız. \n 5)Düzenleme yapmak için 5'e basınız \n Yapmak istediğniz işlemi seçiniz: ");
                    doktorsecim = Console.ReadLine();
                    switch (doktorsecim)
                    {
                        case "1":
                            oku=database.prc_tblDoktor_select();
                            while (oku.Read())
                                {
                                    Console.WriteLine(oku[0] + " " + oku[1] + " " + oku[2] + " " + oku[3] + " " + oku[4] + " " + oku[5]);

                                }
                                oku.Close();
                            break;
                        case "2":
                            string doktorId;

                            Console.WriteLine("Görüntülemek istediğiniz doktorun Idsini giriniz.");
                            doktorId = Console.ReadLine();

                            oku=database.prc_tblDoktor_selectById(Convert.ToInt32(doktorId));
                                while (oku.Read())
                                {
                                    Console.WriteLine(oku[0] + " " + oku[1] + " " + oku[2] + " " + oku[3] + " " + oku[4] + " " + oku[5]);
                                }
                                oku.Close();


                                break;
                        case "3":
                           oku= database.prc_tblDoktor_select();
                                while (oku.Read())
                                {
                                    Console.WriteLine(oku[0] + " " + oku[1] + " " + oku[2] + " " + oku[3] + " " + oku[4] + " " + oku[5]);

                                }
                                oku.Close();
                                string doktorID;
                            Console.Write("Silmek istediğiniz id: ");
                            doktorID = Console.ReadLine();
                            database.prc_tblDoktor_delete(Convert.ToInt32(doktorID));
                            Console.WriteLine("Silindi.");
                            break;

                        case "4":
                            Console.Write("Eklemek istediğiniz doktor bilgilerini giriniz.");
                            string DoktorAdi, DoktorSoyadi, DoktorTel, PolAdi, HastaneAdi;

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
                            database.prc_tblDoktor_insert(DoktorAdi, DoktorSoyadi, DoktorTel, PolAdi, HastaneAdi);
                            Console.Read();
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

                            database.prc_tblDoktor_update(Convert.ToInt32(id), DoktorAdi2, DoktorSoyadi2, DoktorTel2, PolAdi2, HastaneAdi2);
                            break;
                        default:
                            Console.WriteLine("Hatalı giriş.");
                            break;
                    }

                }
            }
            else if ("3" == secim2)
            {
                while (1 == 1)
                {

                    string randevusecim;
                    Console.Write(" 1)Randevuları görüntülemek için 1'e basınız. \n 2)Id'sine göre randevu seçmek için 2'ye basınız. \n 3)Randevu silmek için 3'e basınız. \n 4)Randevu eklemek için 4'e basınız. \n 5)Düzenleme yapmak için 5'e basınız \n Yapmak istediğniz işlemi seçiniz: ");
                    randevusecim = Console.ReadLine();

                    switch (randevusecim)
                    {
                        case "1":
                            oku=database.prc_tblRandevu_select();
                                while (oku.Read())
                                {
                                    Console.WriteLine(oku[0] + "--" + oku[1] + "--" + oku[2] + "--" + oku[3] + "--" + oku[4] + "--" + oku[5] + "--" + oku[6] + "--" + oku[7] + "--" + oku[8] + "--" + oku[9] + "--" + oku[10]);

                                }
                                oku.Close();
                                break;
                        case "2":
                            string randevuId;

                            Console.WriteLine("Görüntülemek istediğiniz randevunun Idsini giriniz.");
                            randevuId = Console.ReadLine();
                            oku=database.prc_tblRandevu_selectById(Convert.ToInt32(randevuId));
                           while (oku.Read())
                                {
                                    Console.WriteLine(oku[0] + "--" + oku[1] + "--" + oku[2] + "--" + oku[3] + "--" + oku[4] + "--" + oku[5] + oku[6] + "--" + oku[7] + "--" + oku[8] + "--" + oku[9] + "--" + oku[10]);

                                }
                                oku.Close();
                           break;
                        case "3":
                            oku=database.prc_tblRandevu_select();
                                while (oku.Read())
                                {
                                    Console.WriteLine(oku[0] + "--" + oku[1] + "--" + oku[2] + "--" + oku[3] + "--" + oku[4] + "--" + oku[5] + "--" + oku[6] + "--" + oku[7] + "--" + oku[8] + "--" + oku[9] + "--" + oku[10]);
                                }
                                oku.Close();
                                string randevuID;
                            Console.Write("Silmek istediğiniz id: ");
                            randevuID = Console.ReadLine();
                            database.prc_tblRandevu_delete(Convert.ToInt32(randevuID));
                            Console.WriteLine("Silindi.");
                            break;
                        case "4":
                            Console.Write("Eklemek istediğiniz randevu bilgilerini giriniz.");
                            string DoktorAdi, DoktorSoyadi, PolAdi, HastaneAdi, RandevuTarihi, Saat, RandevuAciklama;
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
                            database.prc_tblRandevu_insert(HastaneAdi, PolAdi, DoktorAdi, DoktorSoyadi, RandevuTarihi, Saat, RandevuAciklama);
                            Console.WriteLine("Kaydınız gerçekleşti.");
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
                            database.prc_tblRandevu_update(Convert.ToInt32(id), HastaneAdi2, PolAdi2, DoktorAdi2, DoktorSoyadi2, RandevuTarihi2, Saat2, RandevuAciklama2);
                                Console.WriteLine("Güncelleme gerçekleşti.");
                                break;
                        default:
                            Console.WriteLine("Hatalı giriş.");
                            break;


                    }

                }

            }
            else
            {
                Console.WriteLine("Hatalı giriş.");
                    break;
            }
        }
        }
            
        }
    }

