using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    interface IEggAnimal : IDomesticAnimal // Interface IEggAnimal, heritor of interface IDomesticAnimal
    {
        double TimeOfGivingEggs // In months
        {
            get;
            set;
        }

        double PriceForTenEggs // In hryvnas
        {
            get;
            set;
        }
    }
}
