using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class ExponentialDist : Generator
    {
        public int M;
        private Random rand;
        public ExponentialDist(int m)
            : base("Экспоненциальное")
        {
          M=m;
          rand = new Random();
        }
        public override double NextDouble()
        {
            return (-1 * Math.Log10(rand.NextDouble()) * M);
        }
    }
}
