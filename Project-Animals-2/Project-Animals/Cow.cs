using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    class Cow:HoofAnimal, IMeatAnimal, IMilkAnimal, IClothingMaterialAnimal
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

        // Implementation of properties from interface IMilkAnimal

        double partOfYearWhenGivesMilk;

        double IMilkAnimal.PartOfYearWhenGivesMilk
        {
            get
            {
                return partOfYearWhenGivesMilk;
            }
            set
            {
                if (value > 0 && value < 1)
                {
                    partOfYearWhenGivesMilk = value;
                }
            }
        }

        double volumeOfMilkPerDay;
        
        double IMilkAnimal.VolumeOfMilkPerDay
        {
            get
            {
                return volumeOfMilkPerDay;
            }
            set
            {
                if (value >= 0)
                {
                    volumeOfMilkPerDay = value;
                }
            }
        }

        bool smellOfMilk;

        bool IMilkAnimal.SmellOfMilk
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

        double weightOfFatPerOneLiterOfMilk;

        double IMilkAnimal.WeightOfFatPerOneLiterOfMilk
        {
            get
            {
                return weightOfFatPerOneLiterOfMilk;
            }
            set
            {
                if (value > 0)
                {
                    weightOfFatPerOneLiterOfMilk = value;
                }
            }
        }

        double densityOfMilk;

        double IMilkAnimal.DensityOfMilk
        {
            get
            {
                return densityOfMilk;
            }
            set
            {
                if (value > 0)
                {
                    densityOfMilk = value;
                }
            }
        }

        double timeOfGivingForemilk;

        double IMilkAnimal.TimeOfGivingForemilk
        {
            get
            {
                return timeOfGivingForemilk;
            }
            set
            {
                if (value >= 0)
                {
                    timeOfGivingForemilk = value;
                }
            }
        }

        double priceForOneLiterOfMilk;

        double IMilkAnimal.PriceForOneLiterOfMilk
        {
            get
            {
                return priceForOneLiterOfMilk;
            }
            set
            {
                if (value > 0)
                {
                    priceForOneLiterOfMilk = value;
                }
            }
        }

        // Implementation of properties from interface IClothingMaterialAnimal

        bool needOfKillingToGetMaterial;

        bool IClothingMaterialAnimal.NeedOfKillingToGetMaterial
        {
            get
            {
                return needOfKillingToGetMaterial;
            }
            set
            {
                needOfKillingToGetMaterial = value;
            }
        }

        double priceForOneKillogramOfMaterial;

        double IClothingMaterialAnimal.PriceForOneKillogramOfMaterial
        {
            get
            {
                return priceForOneKillogramOfMaterial;
            }
            set
            {
                if (value >= 0)
                {
                    priceForOneKillogramOfMaterial = value;
                }
            }
        }

        bool existenceOfSkin;

        bool IClothingMaterialAnimal.ExistenceOfSkin
        {
            get
            {
                return existenceOfSkin;
            }
            set
            {
                existenceOfSkin = value;
            }
        }

        bool existenceOfPlumage;

        bool IClothingMaterialAnimal.ExistenceOfPlumage
        {
            get
            {
                return existenceOfPlumage;
            }
            set
            {
                existenceOfPlumage = value;
            }
        }

        bool existenceOfWool;

        bool IClothingMaterialAnimal.ExistenceOfWool
        {
            get
            {
                return existenceOfWool;
            }
            set
            {
                existenceOfWool = value;
            }
        }

        // Constructor

        public Cow()
        {
            IDomesticAnimal.Age = 0.0; // On this string it is swearing

            meatDensity = 1700;
            proportionOfMeatToAllWeight = 0.5;
            proportionOfLardToAllWeight = 0.2;
            proportionOfBonesToAllWeight = 0.3;
            smellOfMeat = false;
            priceForOneKillogramOfMeat = 200;

            weightOfPlumageOfAdult = 0;
            areaOfSkinOfAdult = 2;

            partOfYearWhenGivesMilk = 0.8;
            volumeOfMilkPerDay = 25;
            smellOfMilk = false;
            weightOfFatPerOneLiterOfMilk = 0.03;
            densityOfMilk = 1020;
            timeOfGivingForemilk = 2;
            priceForOneLiterOfMilk = 20;

            needOfKillingToGetMaterial = true; // It is not right
            priceForOneKillogramOfMaterial = 1000;
            existenceOfSkin = true;
            existenceOfPlumage = false;
            existenceOfWool = false;
        }

    }
}
