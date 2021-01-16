using System;

namespace ödev
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "Xiaomi Redmi Note 8 4GB/64GB Mavi Akıllı Telefon";
            urun1.UrunKategori = "Cep Telefonu";
            urun1.UrunFiyat = 3199;
            urun1.Indirim = 5;
            urun1.Indirim_fiyat = urun1.UrunFiyat - (urun1.UrunFiyat * urun1.Indirim / 100);
            urun1.Taksit_Fiyatı = 3 * (urun1.Indirim_fiyat / 3);

            Urun urun2 = new Urun();
            urun2.UrunAdi = "Apple MacBook Pro 13 M1 8C CPU 512GB SSD Space Grey MYD92TU / A";
            urun2.UrunKategori = "Bilgisayar";
            urun2.UrunFiyat = 16499;
            urun2.Indirim = 5;
            urun2.Indirim_fiyat= urun2.UrunFiyat - (urun2.UrunFiyat * urun2.Indirim / 100);
            urun2.Taksit_Fiyatı = 3 * (urun2.Indirim_fiyat / 3);

            Urun urun3 = new Urun();
            urun3.UrunAdi = "Logitech G332 Oyuncu Kulaklığı - Leatherette - Analog";
            urun3.UrunKategori = "Oyun Konsolu";
            urun3.UrunFiyat = 549;
            urun3.Indirim = 18;
            urun3.Indirim_fiyat = urun3.UrunFiyat - (urun3.UrunFiyat * urun3.Indirim / 100);
            urun3.Taksit_Fiyatı = 3 * (urun3.Indirim_fiyat / 3);

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            Console.WriteLine("----------> Foreach <----------");

            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün Adı: " + urun.UrunAdi + "\n" + "Ürün Kategorisi:" + urun.UrunKategori + "\n" + "Ürün Fiyatı: " + urun.UrunFiyat + " TL"+ "\n" + "İndirim: %" + urun.Indirim+ "\n" + "İndirimli Fiyat :" + urun.Indirim_fiyat + " TL" + "\n" + "Taksit Seçeneği :" + "3 * " + urun.Indirim_fiyat / 3 + " = " + urun.Taksit_Fiyatı + " TL");
                Console.WriteLine("");

            }

            Console.WriteLine("----------> For <----------");

            for (int i = 0; i < urunler.Length; i++) //kurslar.Length - kurslarda kaç tane eleman varsa onu temsil eder eleman değeri gibi sayı girmene gerek kalmıyor
            {
                Console.WriteLine("Ürün Adı: " + urunler[i].UrunAdi + "\n" + "Ürün Kategorisi:" + urunler[i].UrunKategori + "\n" + "Ürün Fiyatı: " + urunler[i].UrunFiyat + " TL" + "\n" + "İndirim: %" + urunler[i].Indirim + "\n" + "İndirimli Fiyat :" + urunler[i].Indirim_fiyat + " TL" + "\n" + "Taksit Seçeneği :" + "3 * " + urunler[i].Indirim_fiyat / 3 + " = " + urunler[i].Taksit_Fiyatı + " TL");
                Console.WriteLine("");
            }

            Console.WriteLine("----------> While <-----------");

            int x = 0;
            while (x < urunler.Length )
            {
                Console.WriteLine("Ürün Adı: " + urunler[x].UrunAdi + "\n" + "Ürün Kategorisi:" + urunler[x].UrunKategori + "\n" + "Ürün Fiyatı: " + urunler[x].UrunFiyat + " TL" + "\n" + "İndirim: %" + urunler[x].Indirim + "\n" + "İndirimli Fiyat :" + urunler[x].Indirim_fiyat + " TL" + "\n" + "Taksit Seçeneği :" + "3 * " + urunler[x].Indirim_fiyat / 3 + " = " + urunler[x].Taksit_Fiyatı + " TL");
                Console.WriteLine("");
                x++;
               
            }

        }
    }
    class Urun
    {
        public string UrunAdi { get; set; }

        public string UrunKategori { get; set; }

        public float UrunFiyat { get; set; }

        public int Indirim { get; set; }

        public float Indirim_fiyat { get; set; }

        public float Taksit_Fiyatı { get; set; }


    }
}
