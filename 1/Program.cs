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
            Ses ses = new Ses();
            KanalListesi Kanal = new KanalListesi();
            while(true)
            {
                Console.WriteLine("Program");
                string deger = Console.ReadLine();
                
                if (deger == "8")
                {
                    if (Kanal.Uydu.Count() > Kanal.mevcutDeger)
                    {
                        Kanal.mevcutDeger += 1;
                        
                    }
                    else
                    {
                        Kanal.mevcutDeger = 1;
                    }
                }
                else if (deger == "2")
                {
                    if (Kanal.mevcutDeger!=1)
                    {
                        Kanal.mevcutDeger -= 1;
                    }
                    else
                    {
                        Kanal.mevcutDeger = Kanal.Uydu.Count();
                    }
                }
                else if (deger == "6")
                {
                    ses.SesArttır = 0;
                }
                else if (deger == "4")
                {
                    ses.SesAzalt = 0;
                }
                else if (deger == "9")
                {
                    ses.sesiMutele = true;
                }
                Console.WriteLine("Numara :: " + Kanal.Uydu.Where(p => p.numarasi == Kanal.mevcutDeger).FirstOrDefault().numarasi.ToString() + " :: \n  Isim: " + Kanal.Uydu.Where(p => p.numarasi == Kanal.mevcutDeger).FirstOrDefault().ismi.ToString() + " :: \n Ses Seviyesi " + ses.mevcutSes + " \n Muted : " + ses.kapaliMi);
            }
            Console.ReadKey();
        }
    }
}

