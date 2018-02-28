using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    interface IMilkAnimal : IDomesticAnimal // Interface IMilkAnimal, heritor of interface IDomesticAnimal
    {
        double PartOfYearWhenGivesMilk
        {
            get;
            set;
        }

        double VolumeOfMilkPerDay
        {
            get;
            set;
        }

        bool SmellOfMilk
        {
            get;
            set;
        }

        double WeightOfFatPerOneLiterOfMilk
        {
            get;
            set;
        }

        double DensityOfMilk
        {
            get;
            set;
        }

        double TimeOfGivingForemilk
        {
            get;
            set;
        }

        double PriceForOneLiterOfMilk
        {
            get;
            set;
        }

    }
}
