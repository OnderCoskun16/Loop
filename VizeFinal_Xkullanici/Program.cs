using System;

namespace VizeFinalNotları_OgrenciSayisiKadar
{
    class Program
    {
        static void Main(string[] args)
        {
            uint OgrenciSayisi,Sayac=0;
            Double NotVize, NotFinal;
            bool islemBitti = true;
            string OgrenciAdi="me",OrtalamaYuksekOgrenciAdi="you", OrtalamaDusukOgrenciAdi="she";
            double OrtalamaEnYuksek=0, OrtalamaEnDusuk=100, GenelOrtalama=0,TempOrtalama;

            do
            {        
                try
                {
                    Console.WriteLine("Öğrenci Sayısını Giriniz");
                    OgrenciSayisi = uint.Parse(Console.ReadLine());

                    Console.WriteLine($"{Sayac+1}.Öğrenci Adını Giriniz=\n");
                    OgrenciAdi = Console.ReadLine();

                    do
                    {
                        try
                        {
                            Console.WriteLine("Vize Notunu 0-100 arasında Giriniz\n");
                            NotVize = Convert.ToDouble(Console.ReadLine()) * 0.4;
                            if (NotVize >= 0 && NotVize <= 100)
                            {
                                Console.WriteLine("Final Notunu 0-100 arasında Giriniz\n");
                                NotFinal = Convert.ToDouble(Console.ReadLine()) * 0.6;
                                if (NotFinal >= 0 && NotFinal <= 100) 
                                    Sayac++;
                                else 
                                    continue;
                            }
                            else
                                continue;

                            TempOrtalama = NotFinal + NotVize;
                            GenelOrtalama += TempOrtalama;

                            if (TempOrtalama > OrtalamaEnYuksek)
                            {
                                OrtalamaEnYuksek = TempOrtalama;
                                OrtalamaYuksekOgrenciAdi = OgrenciAdi;
                            }
                            if (TempOrtalama < OrtalamaEnDusuk)
                            {
                                OrtalamaEnDusuk = TempOrtalama;
                                OrtalamaDusukOgrenciAdi = OgrenciAdi;
                            }
                            if (Sayac < OgrenciSayisi)
                            {
                                Console.WriteLine($"{Sayac + 1}.Öğrenci Adını Giriniz=\n");
                                OgrenciAdi = Console.ReadLine();
                            }
                            else   islemBitti = false;

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Hatalı Format");                            
                            continue;
                            //throw;
                        }                        

                    } while (islemBitti);

                    Console.WriteLine($"{OrtalamaEnYuksek} Puan ile En Yüksek Ortalama Not {OrtalamaYuksekOgrenciAdi} tarafından alınmıştır\n\n");
                    Console.WriteLine($"{OrtalamaEnDusuk}  Puan ile En Düşük  Ortalama Not {OrtalamaDusukOgrenciAdi} tarafından alınmıştır\n\n");
                    Console.WriteLine($"Genel Ortalama = {GenelOrtalama /= OgrenciSayisi}");
                    break;      // Program Sonlandır
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hatalı Format\n");
                    
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Değer Aralığı değişkenin dışında\n");
                    //throw;
                    continue;
                }


            } while (true);




            Console.WriteLine("Çıkmak için bir tuşa basınız");
            Console.ReadKey();
        }
    }
}
