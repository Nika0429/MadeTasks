using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    interface IEggAnimal : IDomesticAnimal // Interface IEggAnimal, heritor of interface IDomesticAnimal
    {
        double TimeOfGivingEggs
        {
            get;
            set;
        }

        double PriceForTenEggs
        {
            get;
            set;
        }
    }
}
