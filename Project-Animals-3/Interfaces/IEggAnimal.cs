using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Animals
{
    interface IEggAnimal : IDomesticAnimal // Interface IEggAnimal, heritor of interface IDomesticAnimal
    {
        decimal GivingEggsTime // In months
        {
            get;
            set;
        }

        decimal EggsPrice // In hryvnas
        {
            get;
            set;
        }
    }
}
