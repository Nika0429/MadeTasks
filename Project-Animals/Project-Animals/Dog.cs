using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    class Dog:CatAnimal, IDutyAnimal
    {
        string purpose;

        string IDutyAnimal.Purpose
        {
            get
            {
                return purpose;
            }
            set
            {
                purpose = value;
            }
        }
    }
}
