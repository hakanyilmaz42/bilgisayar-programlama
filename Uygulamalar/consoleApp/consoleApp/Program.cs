using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//1. örnek:3 operandlı operatör kullanımı
            Console.WriteLine("Operatörler konusunu öğrendin mi?");
            string cevap = Console.ReadLine();
            Console.WriteLine(cevap == "e" ? "Tebrikler" : "daha iyi çalış");*/

            /*//2. örnek:Vize ve finalden ortalama hesaplayan program
            Console.WriteLine("Vize notunu giriniz?");
            int vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notunu giriniz?");
            int final = Convert.ToInt32(Console.ReadLine());
            double ortalama=vize*0.4+final*0.6;
            Console.WriteLine("Vize:{0}, Final:{1}, Ortalama:{2}",vize,final,ortalama);
            Console.WriteLine(ortalama < 49.5 ? "Kaldınız" : "Geçtiniz");*/

            /*//3. örnek: Girilen sayının karesini ve küpünü hesaplayan program
            Console.WriteLine("karesi ve küpü bulunacak sayıyı giriniz?");
            int sayi =Convert.ToInt32(Console.ReadLine());
            int kare = sayi * sayi;
            int kup = sayi * sayi * sayi;
            Console.WriteLine("{0} sayısının karesi:{1}, küpü:{2}", sayi, kare, kup);*/

            /*//4. örnek: r değerine göre çevre alan hacim hesabı
            Console.WriteLine("yarı çapı giriniz?");
            int r = Convert.ToInt32(Console.ReadLine());
            double piSayisi = 3.14;
            double cevre = 2 * piSayisi * r;
            double alan = piSayisi * r * r;
            double hacim = (4 / 3) * piSayisi * r * r * r;
            Console.WriteLine("Çevre:{0}, Alan:{1}: Hacim:{2}", cevre, alan, hacim);*/

            /*//5. örnek: Girilen sayının çift tek olduğuna bakan program
            Console.WriteLine("sayıyı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sayi % 2 == 0 ? "Sayı çifttir" : "sayı tektir");*/

            /*//6. örnek: Girilen sayıyı negatif veya pozitif olarak veren program
            Console.WriteLine("sayıyı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi<0)
            {
                Console.WriteLine("sayı negatif");
            }else if (sayi>0)
            {
                Console.WriteLine("sayı pozitif");
            }else
            {
                Console.WriteLine("sıfır girdiniz");
            }*/

            /*//7. örnek: Girilen saate göre gün zaman dilimini (iş=08:17, ev=18:24, dinlenme=0:8) bulan program
            Console.WriteLine("saati giriniz");
            int saat = Convert.ToInt32(Console.ReadLine());
            if (saat>=8 && saat<=17)
            {
                Console.WriteLine("iş saati");
            }else if(saat >=18 && saat<=24)
            {
                Console.WriteLine("ev saati");
            }else if (saat>=0 && saat<=7)
            {
                Console.WriteLine("dinlenme saati");
            }else
            {
                Console.WriteLine("0-24 arası bir değer giriniz");
            }*/

            /*//8. örnek: Girilen sayının ikinci girilen sayıya tam bölünüp bölünmediğini bulan program
            Console.WriteLine("Sırasıyla sayıları giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1%sayi2==0)
            {
                Console.WriteLine("{0} sayısı {1} sayısına tam bölünür", sayi1, sayi2);
            }else
            {
                Console.WriteLine("{0} sayısı {1} sayısına tam bölünemez!!", sayi1, sayi2);
            }*/

            /*//9. örnek: Girilen güne ve aya göre gün/ay adını veren program
            Console.WriteLine("Gün değerini giriniz");
            int gun = Convert.ToInt32(Console.ReadLine());

            switch (gun)
            {
                case 1:
                    Console.WriteLine("pazartesi");
                break;
                case 2:
                    Console.WriteLine("salı");
                    break;
                case 3:
                    Console.WriteLine("çarşamba");
                    break;
                case 4:
                    Console.WriteLine("perşembe");
                    break;
                case 5:
                    Console.WriteLine("cuma");
                    break;
                case 6:
                    Console.WriteLine("cumartesi");
                    break;
                case 7:
                    Console.WriteLine("pazar");
                    break;
                default:
                    Console.WriteLine("geçerli bir gün girmediniz");
                    break;
            }*/

            /*//10. örnek: Girilen sayının faktöriyelini bulan program
            Console.WriteLine("sayıyı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            double f = 1;
            for (int i=1;i<=sayi;i++)
            {
                f = f * i;
            }
            Console.WriteLine(f);*/

            /*//11. örnek: 1 den girilen sayıya kadar girilen 2. sayı kadar artan program
            Console.WriteLine("sırasıyla sayıları giriniz");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            for (int i= 1; i <= sayi1; i = i + sayi2)
            {
                Console.WriteLine(i);
            }*/

            /*//12. örnek:Klavyeden eksi sayı girilene kadar girilen sayıların toplamını veren program
            bool durum = true;
            int toplam = 0;
            do
            {
                Console.WriteLine("sayi giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi<0)
                {
                    durum = false;
                }else
                {
                    toplam = toplam + sayi;
                    Console.WriteLine("toplam:{0}", toplam);
                }
            } while (durum == true);*/

            /*//13. örnek: Girilen sayının tam bölenlerini listeleyen program
            Console.WriteLine("sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=sayi;i++)
            {
                if (sayi%i==0)
                {
                    Console.WriteLine(i);
                }
            }*/

            /*//14. örnek: Girilen karakterden girilen sayı kadar satır ile dik üçgen oluşturmak
            Console.WriteLine("karakter giriniz");
            string karakter = Console.ReadLine();
            Console.WriteLine("sayi giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=sayi;i++)
            {
                for (int j=1;j<=i;j++)
                {
                    Console.Write(karakter);
                }
                Console.WriteLine();
            }
            */

            /*//15.Girilen sayı kadar sayının ortalamasını bulan program
            Console.WriteLine("Kaç tane sayı gireceksiniz?");
            int n = Convert.ToInt32(Console.ReadLine());
            double toplam = 0;

            for (int i=1;i<=n;i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz",i);
                int sayi= Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayi;
            }

            double ortalama = toplam / n;
            Console.WriteLine("{0} tane sayının ortalaması: {1}", n, ortalama);*/

            /*// 16. 3 veya 5'in katları
            double toplam = 0;
            for (int i=1;i<1000;i++)
            {
                if (i%3==0 || i%5==0)
                {
                    toplam = toplam + i;
                }
            }

            Console.WriteLine(toplam);*/

            /*//17. 1’den 100’e kadar olan sayılardan tek olanların karesini çift olanların küpünü yazdıran program
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0} nin küpü:{1}",i,i * i * i);
                }
                else
                {
                    Console.WriteLine("{0} nin karesi:{1}",i,i * i);
                }
            }
            */
            /*//18. 1’den 9’a kadar olan sayılarla çarpım tablosu oluşturunuz

            for (int i=1;i<=9;i++)
            {
                for (int j=1;j<=9;j++)
                {
                    Console.WriteLine("{0}X{1}={2}", i, j, i * j);
                }
                Console.WriteLine("########################");
            }*/

            //##########################################################
            //              Array
            /*
            string[] isimler = new string[5];

            for (int i=0;i<isimler.Length;i++)
            {
                Console.WriteLine("{0}. ismi giriniz", i+1);
                isimler[i] = Console.ReadLine();
            }

            foreach(string isim in isimler)
            {
                Console.WriteLine(isim);
            }

            Array.Reverse(isimler);

            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }

            Array.Sort(isimler);

            foreach (string isim in isimler)
            {
                Console.WriteLine(isim);
            }
            */
            /*
            //10 elemanlı bir tam sayı dizisi oluşturun ve kullanıcıdan 10 sayı alın. Bu sayılardan tek sayı olanları ekrana yazdırın
            int[] sayilar = new int[10];

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz", i + 1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            foreach(int sayi in sayilar)
            {
                if (sayi%2==1)
                {
                    Console.WriteLine(sayi);
                }
            }
            */
            /*
            //Kenarı girilen karenin alanını ve küpünü hesaplayın.
            Console.WriteLine("Kenar girinizi");
            int kenar = int.Parse(Console.ReadLine());

            double kare = Math.Pow(kenar, 2);
            double kup = Math.Pow(kenar, 3);
            Console.WriteLine("karesi:{0}, küpü:{1}", kare, kup);
            */

            /*//Girilen yarıçap değerine göre çevre, alan ve hacim hesaplayın
            Console.WriteLine("Yarıçap girinizi");
            int yariCap = int.Parse(Console.ReadLine());

            double cevre =Math.Round((Math.PI * 2 * yariCap),2);
            double alan = Math.PI * Math.Pow(yariCap, 2);
            double hacim = 4 / 3 * Math.PI * Math.Pow(yariCap, 3);
            Console.WriteLine("çevre:{0}, alan:{1}, hacim:{2}", cevre, Math.Round(alan,2), Math.Round(hacim,2));
            */
            /*
            //Klavyeden alınan n elemanlı bir A dizisinin en büyük ve en küçük elemanını bulan program.
            Console.WriteLine("n yi girinizi");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            for (int i =0;i<n;i++)
            {
                Console.WriteLine("{0}. sayıyı giriniz", i + 1);
                a[i]= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("max:{0}, min:{1}", a.Max(), a.Min());*/
            /*
            //N kişilik bir sınıfın herhangi bir dersinden yılsonu notları girilmektedir. Buna göre sınıf ortalamasının altında kalanlara ‘Kaldı’, diğerlerine de ‘geçti’ yazan program
            Console.WriteLine("öğrenci sayısını girinizi");
            int ogrenciSayi = int.Parse(Console.ReadLine());

            int[] a = new int[ogrenciSayi];
            double toplam = 0;
            for (int i = 0; i < ogrenciSayi; i++)
            {
                Console.WriteLine("{0}. notu giriniz", i + 1);
                a[i] = int.Parse(Console.ReadLine());
                toplam += a[i];
            }

            double ortalama = toplam / ogrenciSayi;
            foreach(int not in a)
            {
                if (not < ortalama)
                {
                    Console.WriteLine("{0} kaldı {1}", not, ortalama);
                }
                else {
                    Console.WriteLine("{0} geçti {1}", not, ortalama);
                }
            }

            */
            /*//Klavyeden girilen -9 ile   9 arasındaki tek basamaklı bir sayıyı, kelime olarak yazdıran program.
            string[] sayilar = { "sıfır", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
            Console.WriteLine("-9 +9 arası sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            string onek = "";
            if (sayi < 0) {
                onek = "eksi ";
            }

            Console.WriteLine(onek + sayilar[Math.Abs(sayi)]);*/

            /*//8 haneli rasgele şifre oluşturun (33,126).

            Random rasgele = new Random();
            string sifre = "";
            for (int i=1;i<=8;i++)
            {
                int karakter = rasgele.Next(33, 127);
                sifre += Convert.ToChar(karakter);
            }

            Console.WriteLine(sifre);
            */
            /*
            //Sayısal loto programı yazın (sayıları sıralı yazdırın).
            Random rasgele = new Random();
            int[] sayilar = new int[6];
            sayilar[0] = rasgele.Next(1, 50);
            int sayac = 1;

            while(sayac<6)
            {
                int deger = rasgele.Next(1, 50);
                if (Array.IndexOf(sayilar,deger)<0)
                {
                    sayilar[sayac] = deger;
                    sayac++;
                }
            }

            Array.Sort(sayilar);
            foreach(int sayi in sayilar)
            {
                Console.WriteLine(sayi);
            }
            */

            //Girilen sayının asal sayı olup olmadığını bulan programı yazın.
            Console.WriteLine("sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            bool durum = true;
            for (int i=2;i<sayi;i++)
            {
                if (sayi%i==0)
                {
                    durum = false;
                }
            }

            if (durum==true)
            {
                Console.WriteLine("{0} sayısı asaldır", sayi);
            }else
            {
                Console.WriteLine("{0} sayısı asal değildir", sayi);
            }
        }
    }
}
