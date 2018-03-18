using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Animals
{
    class Pig : HoofAnimal, IMeatAnimal
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

        // Constructor
        public Pig()
        {
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
            MeatSmell = false;
            MeatPrice = 200;


            //Abstract class properties
            DigestionType = DigestionType.NonRuminant;
            HoovesQuantity = 2;
        }
    }
}
