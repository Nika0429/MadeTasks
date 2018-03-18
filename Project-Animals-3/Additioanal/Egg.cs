using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Animals
{
    public class Egg // Additional class Egg
    {
        decimal weight;

        decimal Weight // In killograms
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

        // Constructor

        public Egg(decimal w, bool a)
        {
            Weight = w;
            ApplyingInRawForm = a;
        }
        
    }
}
