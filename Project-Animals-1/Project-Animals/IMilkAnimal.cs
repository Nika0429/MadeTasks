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

        double VolumeOfMilkPerDay // In liters
        {
            get;
            set;
        }

        bool SmellOfMilk
        {
            get;
            set;
        }

        double WeightOfFatPerOneLiterOfMilk // In killograms
        {
            get;
            set;
        }

        double DensityOfMilk // In killograms per cubic meter
        {
            get;
            set;
        }

        double TimeOfGivingForemilk // In months
        {
            get;
            set;
        }

        double PriceForOneLiterOfMilk // In hryvnas
        {
            get;
            set;
        }

    }
}
