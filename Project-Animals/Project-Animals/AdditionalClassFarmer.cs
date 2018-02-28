using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    class Farmer // Additional class Farmer
    {
        /* It's method for checking and returning(in percents) 
        the state of health and risk of infection. */

        public HealthStatus CheckHealthStatus (IDomesticAnimal animal)
        {
            HealthStatus hs1 = new HealthStatus();

            /* By default the StateOfHealth is 100, and RiskOfInfection is 0 
            Then RiskOfInfection depends from two properties - DateOfLatestVaterinaryInspection and DateOfLatestPreventiveMedProcedure 
            But I don't know yet, from what factors will StateOfHealth depend, and don't know how to realize it*/
            
            hs1.StateOfHealth = 100;
            hs1.RiskOfInfection = 0;

            DateTime from = new DateTime();
            DateTime to = new DateTime();

            from = animal.DateOfLatestVeterinaryInspection;
            to = DateTime.Today;

            TimeSpan diff = to - from;
            int days = diff.Days;         

            if (days > 365)
            {
                hs1.RiskOfInfection += 50;
            }

            from = animal.DateOfLatestPreventiveMedProcedure;
            to = DateTime.Today;

            diff = to - from; // I don't know if it's neccesary string
            days = diff.Days; // I don't know if it's neccesary string

            if (days > 30)
            {
                hs1.RiskOfInfection += 50;
            }

            return hs1;          
        }

        // It's method Slaughter, which should return object of class Carcase and it's properties

        public Carcase Slaughter (IMeatAnimal animal)
        {
            Carcase c1 = new Carcase();

            c1.WeightOfMeat = animal.Weight * animal.ProportionOfMeatToAllWeight;
            c1.WeightOfFat = animal.Weight * animal.ProportionOfLardToAllWeight;
            c1.WeightOfBones = animal.Weight * animal.ProportionOfBonesToAllWeight;

            I

            return c1;
        }

        // It's method for checking and returning list of materials which MaterialAnimal can bring

    }
}
