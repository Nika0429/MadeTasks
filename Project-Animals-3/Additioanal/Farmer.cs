using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Animals
{
    class Farmer // Additional class Farmer
    {
        /* It's method for checking and returning(in percents) 
        the state of health and risk of infection. */

        public HealthStatus CheckHealthStatus (IDomesticAnimal animal)
        {
            HealthStatus hs1 = new HealthStatus();

            /* By default the HealthState is 100, and InfectionRisk is 0 
            Then InfectionRisk depends from two properties - DateOfLatestVaterinaryInspection and LatestPrevMedProcedureDate 
            But I don't know yet, from what factors will HealthState depend, and don't know how to realize it*/
            
            hs1.HealthState = 100;
            hs1.InfectionRisk = 0;

            DateTime from = new DateTime();
            DateTime to = new DateTime();
            from = animal.LatestVetInspectionDate;
            to = DateTime.Today;
            TimeSpan diff = to - from;
            int days = diff.Days;         

            if (days > 365)
            {
                hs1.InfectionRisk += 50;
            }

            from = animal.LatestPrevMedProcedureDate;
            to = DateTime.Today;
            diff = to - from; // I don't know if it's neccesary string
            days = diff.Days; // I don't know if it's neccesary string

            if (days > 30)
            {
                hs1.InfectionRisk += 50;
            }

            return hs1;          
        }

        // It's method Slaughter, which kills an animal and returns the carcase

        public Carcase Slaughter(IMeatAnimal animal)
       {
            Carcase c1 = new Carcase(animal);
            
            animal.DeathDate = DateTime.Today;
            animal.LifeStatus = LifeStatus.Died;

            return c1;
       }
    }
}
