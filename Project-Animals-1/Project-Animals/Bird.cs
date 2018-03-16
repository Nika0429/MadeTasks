using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    abstract class Bird : IDomesticAnimal // Abstract class Bird, implementor of interface IDomesticAnimal
    {
        // Implementation of properties from interface IDomasticAnimal

        double age;

        double IDomesticAnimal.Age 
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

        double height;

        double IDomesticAnimal.Height 
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

        double length;

        double IDomesticAnimal.Length 
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

        double width;

        double IDomesticAnimal.Width 
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

        double weight;

        double IDomesticAnimal.Weight
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

        gender gender;

        gender IDomesticAnimal.Gender 
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

        double lifespan;

        double IDomesticAnimal.Lifespan
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

        double timeOfBearingOrIncubationCubs;

        double IDomesticAnimal.TimeOfBearingOrIncubationCubs
        {
            get
            {
                return timeOfBearingOrIncubationCubs;
            }
            set
            {
                if (value > 0)
                {
                    timeOfBearingOrIncubationCubs = value;
                }
            }
        }

        string species;

        string IDomesticAnimal.Species
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

        DateTime dateOfBirth;

        DateTime IDomesticAnimal.DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
            }
        }

        DateTime dateOfDeath;

        DateTime IDomesticAnimal.DateOfDeath
        {
            get
            {
                return dateOfDeath;
            }
            set
            {
                dateOfDeath = value;
            }
        }

        DateTime dateOfLatestPreventiveMedProcedure;

        DateTime IDomesticAnimal.DateOfLatestPreventiveMedProcedure
        {
            get
            {
                return dateOfLatestPreventiveMedProcedure;
            }
            set
            {
                dateOfLatestPreventiveMedProcedure = value;
            }
        }

        DateTime dateOfLatestVeterinaryInspection;

        DateTime IDomesticAnimal.DateOfLatestVeterinaryInspection
        {
            get
            {
                return dateOfLatestVeterinaryInspection;
            }
            set
            {
                dateOfLatestVeterinaryInspection = value;
            }
        }

        statusoflife statusOfLife;

        statusoflife IDomesticAnimal.StatusOfLife
        {
            get
            {
                return statusOfLife;
            }
            set
            {
                statusOfLife = value;
            }
        }

        // Own properties of abstract class Bird

        bool abilityToFly;

        public bool AbilityToFly
        {
            get
            {
                return abilityToFly;
            }
            set
            {
                abilityToFly = value;
            }
        }

        bool abilityToSwim;

        public bool AbilityToSwim
        {
            get
            {
                return abilityToSwim;
            }
            set
            {
                abilityToSwim = value;
            }
        }

        double weightOfEgg;

        public double WeightOfEgg
        {
            get
            {
                return weightOfEgg;
            }
            set
            {
                if (weightOfEgg > 0)
                {
                    weightOfEgg = value;
                }
            }
        }

        bool applyingEggInRawForm;

        public bool ApplyingEggInRawForm
        {
            get
            {
                return applyingEggInRawForm;
            }
            set
            {          
                applyingEggInRawForm = value;
            }
        }

        // Method LayEgg

        public Egg LayEgg()
        {
            Egg e1 = new Egg(WeightOfEgg, ApplyingEggInRawForm);

            return e1;
        }

    }
}
