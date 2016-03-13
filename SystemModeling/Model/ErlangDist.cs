using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class ErlangDist : Generator
    {
        public int Moda;
        public int KolNorm;
        private Random rand;
        public ErlangDist(int m, int k)
            : base("Эрланга")
        {
          Moda=m;
          KolNorm = k;
          rand = new Random();
        }
        public override double NextDouble()
        {
            double r=1;
            for (int x = 0; x < KolNorm; x++)
                r = r * rand.NextDouble();
            return(-Moda * Math.Log10(r));
        }
    }
}
