using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public  class UniformDist : Generator
    {
        public int A;
        public int B;
        private Random rand;
        public UniformDist(int a, int b): base("Равномерное")
         {
            A=a;
            B=b;
            rand = new Random();
         }
        public override double NextDouble()
        {
            return (rand.NextDouble() * (B - A) + A);
        }
    }
}
