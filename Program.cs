using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace OgrenciYonetimUygulamasi
{
    internal class Program
        
    {
        static List<Ogrenci> ogrenciler = new List<Ogrenci>();
        static int DenemeS = 0;
        static int sayac = 1;
        static bool x = true;
        static void Main(string[] args)
        {
            Uygulama();

        }

        static void Uygulama()
        {
            SahteVeriEkle();
            Menu();
            
            while (x)
            {
                Console.Write("Seçiminiz :");
                string secim = Console.ReadLine().ToUpper();


                switch (secim)
                {
                    case "E":
                    case "1":
                        OgrenciEkle();
                        break;
                    case "L":
                    case "2":
                        OgrenciListele();
                        break;
                    case "S":
                    case "3":
                        OgrenciSil();
                        break;
                    case "4":
                    case "X":
                        Console.WriteLine();
                        Console.WriteLine("Çıkış yapılıyor.");
                        x = false;
                        break;


                    default:
                        if(DenemeS != 9)
                        {
                            Console.WriteLine("Hatalı giriş yapıldı.");
                        }
                        DenemeS++;

                        break;


                }
                SecimAl();


                Console.WriteLine();

            }

        static void OgrenciEkle()
        {
            Ogrenci o = new Ogrenci();
            
            Console.WriteLine("1- Öğrenci Ekle ----------");
            Console.WriteLine(sayac + ".Öğrencinin");
                sayac++;
            Console.Write("No: ");
            o.No = int.Parse(Console.ReadLine());
              
                foreach (Ogrenci item in ogrenciler)
                {
                    while(o.No == item.No)
                    {
                        Console.Write("Bu numarada başka bir öğrenci bulunuyor. Lütfen başka bir numara girin: ");
                        o.No = int.Parse(Console.ReadLine());
                    }
                }
                Console.Write("Adı: ");
                o.Ad = Console.ReadLine();
                o.Ad = o.Ad.Substring(0, 1).ToUpper() + o.Ad.Substring(1).ToLower();
                
                
            Console.Write("Soyadı: ");
            o.Soyad = Console.ReadLine();
                o.Soyad = o.Soyad.Substring(0, 1).ToUpper() + o.Soyad.Substring(1).ToLower();
                Console.Write("Şubesi: ");
            o.Sube = Console.ReadLine();
                
                Console.WriteLine();

            Console.Write("Öğrenciyi kaydetmek istediğinize emin misiniz? (E/H) ");
            string secim = Console.ReadLine().ToUpper();

            if (secim == "E")
            {
                ogrenciler.Add(o);
                Console.WriteLine("Öğrenci eklendi.");
            }
            else
            {
                Console.WriteLine("Öğrenci eklenmedi.");
            }
            Console.WriteLine();
                

        }

        static void OgrenciListele()
        {
            if (ogrenciler.Count == 0)
            {
                Console.WriteLine("Gösterilecek öğrenci yok.");
            }
            else
            {
            Console.WriteLine("2- Öğrenci Listele-----------");
            Console.WriteLine();
            Console.WriteLine("Şube    No    Ad Soyad");
            Console.WriteLine("---------------------------------- ");

            foreach (Ogrenci item in ogrenciler)
            {
                Console.WriteLine(item.Sube.PadRight(6) + Convert.ToString(item.No).PadRight(6) + item.Ad + " " + item.Soyad);
            }
            }
            


        }

        static void OgrenciSil()
        {
            if(ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede silinecek öğrenci yok.");
            }
            else {
            Console.WriteLine("3- Öğrenci Sil ----------");
            if(ogrenciler != null) {

            Console.WriteLine("Silmek istediğiniz öğrencinin");
            Console.Write("No: ");
            int no = int.Parse(Console.ReadLine());

            Ogrenci ogr = null;

            foreach (Ogrenci item in ogrenciler)
            {
                if (item.No == no)
                {
                    ogr = item;
                    break;
                }
            }

            if (ogr != null)
            {
                Console.WriteLine("Adı : " + ogr.Ad);
                Console.WriteLine("Soyadı : " + ogr.Soyad);
                Console.WriteLine("Şubesi : " + ogr.Sube);
                Console.WriteLine();
                Console.Write("Öğrenciyi silmek istediğinize emin misiniz? (E/H) ");
                string secim = Console.ReadLine();

                if (secim == "E")
                {
                    ogrenciler.Remove(ogr);
                    Console.WriteLine("Öğrenci silindi.");
                }
                else if(secim == "H")
                {
                    Console.WriteLine("Öğrenci silinmedi.");
                }
            }
            else if(ogr == null)
            {
                Console.WriteLine("Listede silinecek öğrenci yok.");
            }
            else
            {
                Console.WriteLine("Böyle bir öğrenci bulunamadı.");
            }
            }
            else
            {
                Console.WriteLine("Listede silinecek öğrenci yok.");
            }
            }
        }


        static void Menu()
        {
            Console.WriteLine("Öğrenci Yönetim Uygulaması ");
            Console.WriteLine("1 - Öğrenci Ekle(E)        ");
            Console.WriteLine("2 - Öğrenci Listele(L)     ");
            Console.WriteLine("3 - Öğrenci Sil(S)         ");
            Console.WriteLine("4 - Çıkış(X)               ");
            Console.WriteLine();
        }

        static void SahteVeriEkle()
        {
            Ogrenci o1 = new Ogrenci();
            o1.Ad = "veli";
            o1.Soyad = "küçük";
            o1.No = 1;
            o1.Sube = "A";
            ogrenciler.Add(o1);

            Ogrenci o2 = new Ogrenci();
            o2.Ad = "ali";
            o2.Soyad = "yılmaz";
            o2.Sube = "B";
            o2.No = 2;
            ogrenciler.Add(o2);

            Ogrenci o3 = new Ogrenci();
            o3.Ad = "Ayşe";
            o3.Soyad = "yıldız";
            o3.No = 3;
            o3.Sube = "C";
            ogrenciler.Add(o3);
        }

        static void SecimAl()
        {
            if(DenemeS == 10)
                {
                    Console.WriteLine("Üzgünüm sizi anlayamıyorum. Program sonlandırılıyor.");
                    x = false;
                }
                


          

            }
        }
    }
}
