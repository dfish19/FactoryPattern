using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Greece : IVacations
    {
        public string climate { get; set; }
        public int TimeOfYear { get; set; }

        public void Relaxing()
        {
            Console.WriteLine($"I try to avoid this destination in the Winter");
        }
    }
}
