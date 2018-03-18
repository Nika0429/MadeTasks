using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Animals
{
    interface IMilkAnimal : IDomesticAnimal // Interface IMilkAnimal, heritor of interface IDomesticAnimal
    {
        decimal MilkDayVolume // In liters
        {
            get;
            set;
        }

        bool MilkSmell
        {
            get;
            set;
        }

        decimal FatToMilkWeightRatio // In killograms
        {
            get;
            set;
        }

        decimal MilkDensity // In killograms per cubic meter
        {
            get;
            set;
        }

        decimal GivingForemilkTime // In months
        {
            get;
            set;
        }

        decimal MilkPrice // In hryvnas per liter
        {
            get;
            set;
        }

    }
}
