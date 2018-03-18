using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Animals
{
    class HealthStatus // Additional class HealthStatus
    {
        int healthState;

        public int HealthState
        {
            get
            {
                return healthState;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    healthState = value;
                }
            }
        }

        int infectionRisk;

        public int InfectionRisk
        {
            get
            {
                return infectionRisk;
            }
            set
            {
                if(value >= 0 && value <= 100)
                {
                    infectionRisk = value;
                }
            }
        }
    }
}
