using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class PuassonDist : Generator
    {
        public int Lambda;
        private Random rand;
        public PuassonDist(int l)
            : base("Пуассона")
        {
            Lambda = l;
            rand = new Random();
        }

        public override double NextDouble()
        {
            double r = rand.NextDouble();
            double x = 0;
            double p = Math.Exp(-Lambda);
            while (r > 0)
            {
                p = p * Lambda / (x + 1);
                x++;
                r -= p;
            }
            return (x);
        }
    }
}
