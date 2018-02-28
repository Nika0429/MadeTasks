using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    class Egg // Additional class Egg
    {
        double weight;

        double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                if (value > 0 )
                {
                    weight = value;
                }
            }
        }

        bool applyingInRawForm;

        bool ApplyingInRawForm
        {
            get
            {
                return applyingInRawForm;
            }
            set
            {
                applyingInRawForm = value;
            }
        }
        
    }
}
