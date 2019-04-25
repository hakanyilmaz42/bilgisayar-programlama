using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ogrenci ahmet = new Ogrenci();
            Ogrenci canan = new Ogrenci();
            Ogrenci veli = new Ogrenci();

            ahmet.numara = 10;
            ahmet.vizeNotu = 50;
            canan.vizeNotu = 80;
            veli.vizeNotu = 23;
            double ortalama = 0;
            ortalama = (ahmet.vizeNotu + canan.vizeNotu + veli.vizeNotu)/3;
            Console.WriteLine(ortalama);
            */
            /*
            Stok bilgisayar = new Stok();
            Stok tv = new Stok();
            Stok telefon = new Stok();

            bilgisayar.urunAdi = "Asus";
            bilgisayar.urunSayisi = 26;
            tv.urunAdi = "LG";
            tv.urunSayisi = 34;
            telefon.urunAdi = "Samsung";
            telefon.urunSayisi = 30;
            Console.WriteLine("{0} isimli üründen {1} tane var",bilgisayar.urunAdi, bilgisayar.urunSayisi);
            Console.WriteLine("{0} isimli üründen {1} tane var", tv.urunAdi, tv.urunSayisi);
            Console.WriteLine("{0} isimli üründen {1} tane var", telefon.urunAdi, telefon.urunSayisi);
            if (bilgisayar.urunSayisi<30)
            {
                Console.WriteLine("{0} üründe stok az", bilgisayar.urunAdi);
            }else
            {
                Console.WriteLine("{0} üründe stok yeterli", bilgisayar.urunAdi);
            }
            if (tv.urunSayisi < 30)
            {
                Console.WriteLine("{0} üründe stok az", tv.urunAdi);
            }
            else
            {
                Console.WriteLine("{0} üründe stok yeterli", tv.urunAdi);
            }
            if (telefon.urunSayisi < 30)
            {
                Console.WriteLine("{0} üründe stok az", telefon.urunAdi);
            }
            else
            {
                Console.WriteLine("{0} üründe stok yeterli", telefon.urunAdi);
            }
            */
            /*
            Console.WriteLine("Sırasıyla sayıları giriniz");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            sonucYaz("toplama sonucu: ", topla(sayi1, sayi2));
            sonucYaz("cikarma sonucu: ", cikar(sayi1, sayi2));
            sonucYaz("carpma sonucu: ", carpma(sayi1, sayi2));
            sonucYaz("bolme sonucu: ", bolme(sayi1, sayi2));
            dortIslem.sonucYaz("toplama sonucu: ", dortIslem.topla(sayi1, sayi2));
            */
            Console.WriteLine("Tam sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 0;
            while (sayi>1)
            {
                if (sayi%2==0)
                {
                    sayi = sayi / 2;
                }else
                {
                    sayi = sayi * 3 + 1;
                }
                sayac++;
                Console.WriteLine("{0}. adım sonucu sayı:{1}",sayac,sayi);
            }
        }

        public static double topla(double x,double y)
        {
            double sonuc = x + y;
            return sonuc;
        }

        public static double cikar(double x, double y)
        {
            double sonuc = x - y;
            return sonuc;
        }
        public static double carpma(double x, double y)
        {
            double sonuc = x * y;
            return sonuc;
        }

        public static double bolme(double x, double y)
        {
            double sonuc = x / y;
            return sonuc;
        }

        public static void sonucYaz(string mesaj,double sonuc)
        {
            Console.WriteLine(mesaj + sonuc);
        }
    }

    class Ogrenci
    {
        protected internal int numara;
        public string adSoyad;
        public int vizeNotu;
    }

    class Stok {
        public string urunAdi;
        public string urunTuru;
        public int urunSayisi;
    }

    class dortIslem
    {
        public static double topla(double x, double y)
        {
            double sonuc = x + y;
            return sonuc;
        }

        public static double cikar(double x, double y)
        {
            double sonuc = x - y;
            return sonuc;
        }
        public static double carpma(double x, double y)
        {
            double sonuc = x * y;
            return sonuc;
        }

        public static double bolme(double x, double y)
        {
            double sonuc = x / y;
            return sonuc;
        }

        public static void sonucYaz(string mesaj, double sonuc)
        {
            Console.WriteLine(mesaj + sonuc);
        }

    }
}
