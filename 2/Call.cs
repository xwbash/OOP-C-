using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Call
    {

        public List<Ürünler> Ürünlere = new List<Ürünler>();

        public Call()
        {
            Ürünlere.Add(new Ürünler() { yukseklik = 100, BOY = 50, EN = 5, MensalTurk = false });
        }
    }
}
