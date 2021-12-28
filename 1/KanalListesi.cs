using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class KanalListesi
    {
        public List<kanal> Uydu = new List<kanal>();
        int mevcut = 1;
        public int mevcutDeger { get { return mevcut; } set { mevcut = value; } }
        public KanalListesi()
        {
            Uydu.Add(new kanal() { numarasi = 1, ismi = "Show", frekans = 12333 });
            Uydu.Add(new kanal() { numarasi = 2, ismi = "ATV", frekans = 134412 });
            Uydu.Add(new kanal() { numarasi = 3, ismi = "Kanal D", frekans = 41115 });
            Uydu.Add(new kanal() { numarasi = 4, ismi = "TRT 1", frekans = 13444 });
            Uydu.Add(new kanal() { numarasi = 5, ismi = "TRT Spor", frekans = 14556 });
            Uydu.Add(new kanal() { numarasi = 6, ismi = "TRT Çocuk", frekans = 36666 });
            Uydu.Add(new kanal() { numarasi = 7, ismi = "Fox TV", frekans = 12444 });
            Uydu.Add(new kanal() { numarasi = 8, ismi = "Beyaz TV", frekans = 16888 });
        }
            
    }
}
