using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    class Carcase // Additional class Carcase
    {
        //Properties

        double weightOfMeat;

        public double WeightOfMeat // In killograms
        {
            get
            {
                return weightOfMeat;
            }
            set
            {
                if (value > 0)
                {
                    weightOfMeat = value;
                }
            }
        }

        double weightOfFat; // In killograms

        public double WeightOfFat
        {
            get
            {
                return weightOfFat;
            }
            set
            {
                if (value > 0)
                {
                    weightOfFat = value;
                }
            }
        }

        double weightOfBones; // In killograms

        public double WeightOfBones
        {
            get
            {
                return weightOfBones;
            }
            set
            {
                if (value > 0)
                {
                    weightOfBones = value;
                }
            }
        }

        bool existenceOfSkin;

        public bool ExistenceOfSkin
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

        public bool ExistenceOfPlumage
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

        double areaOfSkin;

        public double AreaOfSkin // In square meters
        {
            get
            {
                return areaOfSkin;
            }
            set
            {
                if(value >= 0)
                {
                    areaOfSkin = value;
                }
            }
        }

        double weightOfPlumage;

        public double WeightOfPlumage // In killograms
        {
            get
            {
                return weightOfMeat;
            }
            set
            {
                if (value >= 0)
                {
                    weightOfMeat = value;
                }
            }
        }
    }
}
