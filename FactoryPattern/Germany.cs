using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Germany : IVacations
    {
        public string climate { get; set; }
        public int TimeOfYear { get; set; }

        public void Relaxing()
        {
            Console.WriteLine($"GERMANY: This is the preferred destination in the Fall");
        }
    }
}
