using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Animals
{
    interface IMeatAnimal : IDomesticAnimal // Interface IMeatAnimal, heritor of interface IDomesticAnimal
    {
        decimal MeatDensity // In killograms per cubic meter
        {
            get;
            set;
        }

        decimal MeetToWeightRatio
        {
            get;
            set;
        }

        decimal LardToWeightRatio
        {
            get;
            set;
        }

        decimal BonesToWeightRatio
        {
            get;
            set;
        }

        bool MeatSmell
        {
            get;
            set;
        }

        decimal MeatPrice // In hryvnas per killogram
        {
            get;
            set;
        }
    
    }
}
