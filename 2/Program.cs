using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Depo depocu = new Depo();
            Call Cagir = new Call();
            int En, Boy, Yukseklik, MensalTr;
            
            //Console.Write(Cagir.Ürünlere.Where(p => p.MensalTurk = false).FirstOrDefault().BOY.ToString());
            Console.WriteLine(depocu.Kapasitesi);
            bool Mensal;
            
            while(true)
            {
                Console.WriteLine("1. Depoya Ürün Ekle \n 2.300'den fazla ürün listesi \n 3. Gıda Dışı Ürünler Listesi \n 4. Depoda Kalan Boş Hacim \n 5. Çıkış");
                string a = Console.ReadLine();
                if (a == "1")
                {
                    Console.WriteLine("Ürün Ekle Menü \n ");
                    Console.Write("En'i giriniz: ");
                    En = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Yüksekliği giriniz: ");
                    Boy = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Boyu giriniz: ");
                    Yukseklik = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Gıda dışı ise 1 değilse 0 yazınız: ");
                    MensalTr = Convert.ToInt32(Console.ReadLine());
                    if (MensalTr == 1)
                    {
                        Mensal = true;
                    }
                    else
                    {
                        Mensal = false;
                    }
                    if (depocu.Kapasitesi > Boy * En * Yukseklik)
                    {
                        Cagir.Ürünlere.Add(new Ürünler() { BOY = Boy, EN = En, yukseklik = Yukseklik, MensalTurk = Mensal });
                        depocu.Kapasitesi -= Boy * En * Yukseklik;
                    }
                    else
                    {
                        Console.WriteLine("Depoda Yer Yok");
                    }
                }

                //Console.Write(Cagir.Ürünlere.Where(p => p.MensalTurk = false).FirstOrDefault().ToString());
                else if (a == "2")
                {
                    Console.Write("Depo Hacmi 300 cm^3 fazla olanlar \n");
                    List<Ürünler> Yuksek = Cagir.Ürünlere.FindAll(p => p.EN * p.BOY * p.yukseklik > 300).ToList();
                    foreach (var tanim in Yuksek)
                    {
                        Console.WriteLine("Yükseklik // En // Boy");
                        Console.WriteLine(tanim.yukseklik + "  "+ tanim.EN + "  "+ tanim.BOY);

                    }
                }

                else if (a == "3")
                {
                    Console.Write("Gıda Dışı Ürün Listesi\n");
                    List<Ürünler> Urun = Cagir.Ürünlere.FindAll(p => p.MensalTurk == false).ToList();


                    Console.WriteLine("1");
                    foreach (var tanim2 in Urun)
                    {
                        Console.WriteLine("2");
                        Console.WriteLine("Yükseklik // En // Boy // Gıda Dışı");

                        Console.WriteLine(tanim2.yukseklik +"  "+ "  "+tanim2.EN + "  " + tanim2.BOY + "  " + tanim2.MensalTurk);

                    }
                }

                else if (a == "4")
                {
                    Console.WriteLine("Depocu KAPASİTE");
                    Console.WriteLine(depocu.Kapasitesi);

                }
                else
                {
                    break;
                }
            }
            
            Console.ReadKey();

        }

    }
}
