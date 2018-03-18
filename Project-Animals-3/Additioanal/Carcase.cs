using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Animals
{
    class Carcase // Additional class Carcase
    {
        public decimal CarcaseWeight
        {
            get;
            set;
        }

        public decimal MeetToWeightRatio
        {
            get;
            set;
        }

        public decimal LardToWeightRatio
        {
            get;
            set;
        }

        public decimal BonesToWeightRatio
        {
            get;
            set;
        }

        public Carcase(IMeatAnimal animal)
        {
            CarcaseWeight = animal.Weight;
            MeetToWeightRatio = animal.MeetToWeightRatio;
            LardToWeightRatio = animal.LardToWeightRatio;
            BonesToWeightRatio = animal.BonesToWeightRatio;
        }
    }
}
