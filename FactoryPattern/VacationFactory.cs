using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VacationFactory
    {
        public static IVacations GetVacation(string choice)
        {
            switch (choice.ToLower())
            {
                case "1":
                     return new Columbia();
                case "2":
                    return new Germany();
                case "3":
                    return new Greece();
                default:
                    return new Columbia();
                    
            }
        }
    }
}
