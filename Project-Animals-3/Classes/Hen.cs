using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Animals
{
    class Hen : Bird, IMeatAnimal, IEggAnimal
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

        // Implict implementation of properties from interface IEggAnimal

        decimal givingEggsTime;

        public decimal GivingEggsTime
        {
            get
            {
                return givingEggsTime;
            }
            set
            {
                givingEggsTime = value;
            }
        }

        decimal eggsPrice;

        public decimal EggsPrice
        {
            get
            {
                return eggsPrice;
            }
            set
            {
                eggsPrice = value;
            }
        }

        // Constructor
        public Hen()
        {
            // Properties from interfaces
            Age = 0m;
            Height = 0m;
            Length = 0m;
            Width = 0m;
            Weight = 0.03m;
            Gender = Gender.Another;
            Lifespan = 5;
            BearingCubsTime = 1;
            LifeStatus = LifeStatus.Alive;

            MeatDensity = 1700;
            MeetToWeightRatio = 0.5m;
            LardToWeightRatio = 0.2m;
            BonesToWeightRatio = 0.3m;
            MeatSmell = false;
            MeatPrice = 200;

            GivingEggsTime = 9;
            EggsPrice = 50;

            // Properties from abstract class
            CanSwim = false;
            CanFly = false;
            EggWeight = 100;
            ApplyingEggInRawForm = true;
        }
    }
}
