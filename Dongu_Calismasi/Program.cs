using System;

namespace Dongu_Calismasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "laptop";
            urun1.UrunFiyat = 7800;
            urun1.UrunMiktar = 2500;

            Urun urun2 = new Urun();
            urun2.UrunAdi = "buzdolabı";
            urun2.UrunFiyat = 75200;
            urun2.UrunMiktar = 25;

            Urun urun3 = new Urun();
            urun3.UrunAdi = "TV";
            urun3.UrunFiyat = 2500;
            urun3.UrunMiktar = 1000;

            Urun urun4 = new Urun();
            urun4.UrunAdi = "Çamaşır Makinesi";
            urun4.UrunFiyat = 4500;
            urun4.UrunMiktar = 320;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3, urun4 };

            // 1) foreach döngüsü ile ürünleri listeledik
            /* foreach (Urun urun in urunler) 
            {
                Console.WriteLine(urun.UrunAdi + " : " + urun.UrunFiyat);
            } */
            // ------------------------------------------------------------------
            // 2) for döngüsü ile ürünleri listeledik
            /* for (int i = 0; i < urunler.Length; i++)
             {
                 Console.WriteLine(urunler[i].UrunAdi + " : " + urunler[i].UrunMiktar);
             }
             */
            //-------------------------------------------------------------------------------
            // 3) while döngüsü ile ürünleri listeledik
            int a = 0;
            while (a < urunler.Length)
            {
                Console.WriteLine(urunler[a].UrunAdi + " : " + urunler[a].UrunFiyat);
                a++;
            }

        }
    }
}

