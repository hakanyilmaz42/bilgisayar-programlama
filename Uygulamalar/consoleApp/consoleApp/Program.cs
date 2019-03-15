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



        }
    }
}
