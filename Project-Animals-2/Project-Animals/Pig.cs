﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    class Pig : HoofAnimal, IMeatAnimal
    {
        // Implementation of properties from interface IMeatAnimal

        double meatDensity;

        double IMeatAnimal.MeatDensity
        {
            get
            {
                return meatDensity;
            }
            set
            {
                if (value > 0)
                {
                    meatDensity = value;
                }
            }
        }

        double proportionOfMeatToAllWeight;

        double IMeatAnimal.ProportionOfMeatToAllWeight
        {
            get
            {
                return proportionOfMeatToAllWeight;
            }
            set
            {
                if (value > 0 && value < 1)
                {
                    proportionOfMeatToAllWeight = value;
                }
            }
        }

        double proportionOfLardToAllWeight;

        double IMeatAnimal.ProportionOfLardToAllWeight
        {
            get
            {
                return proportionOfLardToAllWeight;
            }
            set
            {
                if (value > 0 && value < 1)
                {
                    proportionOfLardToAllWeight = value;
                }
            }
        }

        double proportionOfBonesToAllWeight;

        double IMeatAnimal.ProportionOfBonesToAllWeight
        {
            get
            {
                return proportionOfBonesToAllWeight;
            }
            set
            {
                if (value > 0 && value < 1)
                {
                    proportionOfBonesToAllWeight = value;
                }
            }
        }

        bool smellOfMeat;

        bool IMeatAnimal.SmellOfMeat
        {
            get
            {
                return smellOfMeat;
            }
            set
            {
                smellOfMeat = value;
            }
        }

        double priceForOneKillogramOfMeat;

        double IMeatAnimal.PriceForOneKillogramOfMeat
        {
            get
            {
                return priceForOneKillogramOfMeat;
            }
            set
            {
                if (value > 0)
                {
                    priceForOneKillogramOfMeat = value;
                }
            }
        }

        double weightOfPlumageOfAdult;

        double IMeatAnimal.WeightOfPlumageOfAdult
        {
            get
            {
                return weightOfPlumageOfAdult;
            }
            set
            {
                if (value >= 0)
                {
                    weightOfPlumageOfAdult = value;
                }
            }
        }

        double areaOfSkinOfAdult;

        double IMeatAnimal.AreaOfSkinOfAdult
        {
            get
            {
                return areaOfSkinOfAdult;
            }
            set
            {
                if (value >= 0)
                {
                    areaOfSkinOfAdult = value;
                }
            }
        }

        public Pig()
        {
            meatDensity = 1500;
            proportionOfMeatToAllWeight = 0.5;
            proportionOfLardToAllWeight = 0.2;
            proportionOfBonesToAllWeight = 0.3;
            smellOfMeat = false;
            priceForOneKillogramOfMeat = 100;

            weightOfPlumageOfAdult = 0;
            areaOfSkinOfAdult = 0.8;
        }
    }
}
