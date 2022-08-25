using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Columbia : IVacations
    {
        public string climate { get; set; }
        public int TimeOfYear { get; set; }

        public void Relaxing()
        {
            Console.WriteLine($"I am always a fan of this destination in the Summer");
        }
    }
}
