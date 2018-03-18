using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Animals
{
    class Dog:CatAnimal, IDutyAnimal
    {
        string purpose;

        public string Purpose
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
        
        public Dog()
        {
            Purpose = "Guarding";
        }
    }
}
