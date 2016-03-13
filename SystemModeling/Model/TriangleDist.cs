using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class TriangleDist : Generator
    {
        public int Max;
        public int Min;
        public int Moda;
        private Random rand;
        public TriangleDist(int max, int min, int moda)
            : base("Треугольное")
        {
            Max = max;
            Min = min;
            Moda = moda;
            rand = new Random();
        }
        public override double NextDouble()
        {
            double r = rand.NextDouble();
            if (r < ((Moda - Min) / (Max - Min)))
                return (Min + Math.Sqrt((Moda - Min) * (Max - Min) * r));
            else return( Max - Math.Sqrt((Max - Moda) * (Max - Min) * (1 - r)));
        }
    }
}
