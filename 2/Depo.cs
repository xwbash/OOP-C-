using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Depo
    {
        public DateTime ImalatTarihi { get; set; }

        public int Kapasitesi { get; set; } // c^3

        public Depo()
        {
            Kapasitesi = 50000;
            ImalatTarihi = new DateTime(2020, 1, 1);
        }
    }
}
