using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    interface IMeatAnimal : IDomesticAnimal // Interface IMeatAnimal, heritor of interface IDomesticAnimal
    {
        double MeatDensity // In killograms per cubic meter
        {
            get;
            set;
        }

        double ProportionOfMeatToAllWeight
        {
            get;
            set;
        }

        double ProportionOfLardToAllWeight
        {
            get;
            set;
        }

        double ProportionOfBonesToAllWeight
        {
            get;
            set;
        }

        bool SmellOfMeat
        {
            get;
            set;
        }

        double PriceForOneKillogramOfMeat // In hryvnas
        {
            get;
            set;
        }

        double WeightOfPlumageOfAdult // In killograms
        {
            get;
            set;
        }

        double AreaOfSkinOfAdult
        {
            get;
            set;
        }
    }
}
