using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    class HealthStatus // Additional class HealthStatus
    {
        int stateOfHealth;

        public int StateOfHealth
        {
            get
            {
                return stateOfHealth;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    stateOfHealth = value;
                }
            }
        }

        int riskOfInfection;

        public int RiskOfInfection
        {
            get
            {
                return riskOfInfection;
            }
            set
            {
                if(value >= 0 && value <= 100)
                {
                    riskOfInfection = value;
                }
            }
        }
    }
}
