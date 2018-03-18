using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Animals
{
    class Sheep : HoofAnimal, IMeatAnimal, IMilkAnimal, IClothingMaterialAnimal
    {
        // Implict implementation of properties from interface IMeatAnimal

        decimal meatDensity;

        public decimal MeatDensity
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

        decimal meetToWeightRatio;

        public decimal MeetToWeightRatio
        {
            get
            {
                return meetToWeightRatio;
            }
            set
            {
                if (value > 0 && value < 1)
                {
                    meetToWeightRatio = value;
                }
            }
        }

        decimal lardToAllWeightRatio;

        public decimal LardToWeightRatio
        {
            get
            {
                return lardToAllWeightRatio;
            }
            set
            {
                if (value > 0 && value < 1)
                {
                    lardToAllWeightRatio = value;
                }
            }
        }

        decimal bonesToWeightRatio;

        public decimal BonesToWeightRatio
        {
            get
            {
                return bonesToWeightRatio;
            }
            set
            {
                if (value > 0 && value < 1)
                {
                    bonesToWeightRatio = value;
                }
            }
        }

        bool meatSmell;

        public bool MeatSmell
        {
            get
            {
                return meatSmell;
            }
            set
            {
                meatSmell = value;
            }
        }

        decimal meatPrice;

        public decimal MeatPrice
        {
            get
            {
                return meatPrice;
            }
            set
            {
                if (value > 0)
                {
                    meatPrice = value;
                }
            }
        }

        decimal milkDayVolume;

        public decimal MilkDayVolume
        {
            get
            {
                return milkDayVolume;
            }
            set
            {
                if (value >= 0)
                {
                    milkDayVolume = value;
                }
            }
        }

        bool milkSmell;

        public bool MilkSmell
        {
            get
            {
                return meatSmell;
            }
            set
            {
                meatSmell = value;
            }
        }

        decimal fatToMilkWeightRatio;

        public decimal FatToMilkWeightRatio
        {
            get
            {
                return fatToMilkWeightRatio;
            }
            set
            {
                if (value > 0)
                {
                    fatToMilkWeightRatio = value;
                }
            }
        }

        decimal milkDensity;

        public decimal MilkDensity
        {
            get
            {
                return milkDensity;
            }
            set
            {
                if (value > 0)
                {
                    milkDensity = value;
                }
            }
        }

        decimal givingForemilkTime;

        public decimal GivingForemilkTime
        {
            get
            {
                return givingForemilkTime;
            }
            set
            {
                if (value >= 0)
                {
                    givingForemilkTime = value;
                }
            }
        }

        decimal milkPrice;

        public decimal MilkPrice
        {
            get
            {
                return milkPrice;
            }
            set
            {
                if (value > 0)
                {
                    milkPrice = value;
                }
            }
        }

        // Implict implementation of properties from interface IClothingMaterialAnimal

        bool materialWithoutKilling;

        public bool MaterialWithoutKilling
        {
            get
            {
                return materialWithoutKilling;
            }
            set
            {
                materialWithoutKilling = value;
            }
        }

        decimal materialPrice;

        public decimal MaterialPrice
        {
            get
            {
                return materialPrice;
            }
            set
            {
                if (value >= 0)
                {
                    materialPrice = value;
                }
            }
        }

        bool hasSkin;

        public bool HasSkin
        {
            get
            {
                return hasSkin;
            }
            set
            {
                hasSkin = value;
            }
        }

        bool hasPlumage;

        public bool HasPlumage
        {
            get
            {
                return hasPlumage;
            }
            set
            {
                hasPlumage = value;
            }
        }

        bool hasWool;

        public bool HasWool
        {
            get
            {
                return hasWool;
            }
            set
            {
                hasWool = value;
            }
        }

        decimal skinArea;

        public decimal SkinArea
        {
            get;
            set;
        }

        decimal plumageWeight;

        public decimal PlumageWeight
        {
            get;
            set;
        }

        decimal woolWeight;

        public decimal WoolWeight
        {
            get;
            set;
        }

        // Constructor
        public Sheep()
        {
            // Interfaces properties
            Age = 0m;
            Height = 0.2m;
            Length = 0.3m;
            Width = 0.1m;
            Weight = 0.7m;
            Gender = Gender.Another;
            Lifespan = 14;
            BearingCubsTime = 9;
            LifeStatus = LifeStatus.Alive;

            MeatDensity = 1700m;
            MeetToWeightRatio = 0.5m;
            LardToWeightRatio = 0.2m;
            BonesToWeightRatio = 0.3m;
            MeatSmell = true;
            MeatPrice = 200;

            MilkDayVolume = 5;
            MilkSmell = true;
            FatToMilkWeightRatio = 0.03m;
            MilkDensity = 1020;
            GivingForemilkTime = 2;
            MilkPrice = 25;

            MaterialPrice = 1000;
            HasSkin = true;
            HasPlumage = false;
            HasWool = true;

            //Abstract class properties
            DigestionType = DigestionType.Ruminant;
            HoovesQuantity = 2;
        }

    }
}
