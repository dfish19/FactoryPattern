using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface IVacations
    {
        public string climate { get; set; }

        public int TimeOfYear { get; set; }

        public void Relaxing();
    }
}
