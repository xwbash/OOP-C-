using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Ses
    {
        public int mevcutSes=10;
        bool Muted = false;
        public int maxSes = 30, minSes = 0;
        public int SesArttır{ set { if (mevcutSes < maxSes) mevcutSes += 1; kapaliMi = false;} }
        public int SesAzalt { set { if (mevcutSes > minSes) { mevcutSes -= 1; } else if (mevcutSes <= minSes) { kapaliMi = true; } } }
        public bool kapaliMi { get { return Muted; } set { Muted = value; } }

        public bool sesiMutele { set { if (Muted && mevcutSes == 0) { mevcutSes = 1; Muted = false; } else if (!Muted) { Muted = true; } else if (Muted) { Muted = false; } } }

    }
}
