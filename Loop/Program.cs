using System;

namespace Loops_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            string KullaniciAdi, Sifre;
            bool donsunMu = true;
            int tekrarSayisi = 3, Sayac = 0;

            do
            {
                Console.WriteLine("Kullanıcı Adını Giriniz= ");
                KullaniciAdi = Console.ReadLine();
                Console.WriteLine("\n");

                Console.WriteLine("Şifrenizi Giriniz= ");
                Sifre = Console.ReadLine();
                Console.WriteLine("\n");
                Sayac++;

                if (KullaniciAdi == "admin" && Sifre == "1900")
                {
                    Console.WriteLine("HoşGeldin Admin\n");
                    Sayac = 0;
                    break;
                }
                else
                {
                    Console.WriteLine($"{Sayac}. Hatalı girişin Admin. Kalan Giriş Hakkın {3-Sayac}\n");
                }


            } while (tekrarSayisi > Sayac);


            if (Sayac>=3)
            {
                Console.WriteLine("Otomatik giriş yapmaya çalışan Virüs olabilirsiniz");
            }
            Console.WriteLine("Çıkmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}
