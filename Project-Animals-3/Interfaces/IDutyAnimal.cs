using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Animals
{
    interface IDutyAnimal : IDomesticAnimal // Interface IDutyAnimal, heritor of interface IDomesticAnimal
    {
        string Purpose
        {
            get;
            set;
        }
    }
}
