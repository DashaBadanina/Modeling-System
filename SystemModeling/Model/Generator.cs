using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public abstract class Generator
    {
        public string Name;
        public Generator(string name)
         {
             Name = name;
        }
        public abstract double NextDouble();
    }
}
