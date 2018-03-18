using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Animals
{
    abstract class CatAnimal : IDomesticAnimal // Abstract class CatAnimal, implementor of interface IDomesticAnimal
    {
        // Implict implementation of properties from interface IDomasticAnimal

        decimal age;

        public decimal Age // Property age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
            }
        }

        decimal height;

        public decimal Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value > 0)
                {
                    height = value;
                }
            }
        }

        decimal length;

        public decimal Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0)
                {
                    length = value;
                }
            }
        }

        decimal width;

        public decimal Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0)
                {
                    width = value;
                }
            }
        }

        decimal weight;

        public decimal Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }


        Gender gender;

        public Gender Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }

        decimal lifespan;

        public decimal Lifespan
        {
            get
            {
                return lifespan;
            }
            set
            {
                if (value > 0)
                {
                    lifespan = value;
                }
            }
        }

        decimal bearingCubsTime;

        public decimal BearingCubsTime
        {
            get
            {
                return bearingCubsTime;
            }
            set
            {
                if (value > 0)
                {
                    bearingCubsTime = value;
                }
            }
        }

        string species;

        public string Species
        {
            get
            {
                return species;
            }
            set
            {
                species = value;
            }
        }

        DateTime birthDate;

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }
        }

        DateTime deathDate;

        public DateTime DeathDate
        {
            get
            {
                return deathDate;
            }
            set
            {
                deathDate = value;
            }
        }

        DateTime latestPrevMedProcedureDate;

        public DateTime LatestPrevMedProcedureDate
        {
            get
            {
                return latestPrevMedProcedureDate;
            }
            set
            {
                latestPrevMedProcedureDate = value;
            }
        }

        DateTime latestVetInspectionDate;

        public DateTime LatestVetInspectionDate
        {
            get
            {
                return latestVetInspectionDate;
            }
            set
            {
                latestVetInspectionDate = value;
            }
        }

        LifeStatus lifeStatus;

        public LifeStatus LifeStatus
        {
            get
            {
                return lifeStatus;
            }
            set
            {
                lifeStatus = value;
            }
        }
    }
}
