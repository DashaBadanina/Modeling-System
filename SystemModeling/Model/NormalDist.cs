using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   class NormalDist : Generator
    {
        public int M;
        public int D;
        private Random rand;
        public NormalDist(int m, int q)
            : base("Нормальное")
        {
          M=m;
          D = q;
          rand = new Random();
        }
        public override double NextDouble()
        {
            return (Math.Sin(2 * Math.PI * rand.NextDouble()) * Math.Sqrt(-2 * Math.Log(rand.NextDouble())) * D + M);
        }
    }
}
