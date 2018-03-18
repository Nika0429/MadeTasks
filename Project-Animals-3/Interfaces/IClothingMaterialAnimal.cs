using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Animals
{
    interface IClothingMaterialAnimal : IDomesticAnimal // Interface IClothingMaterialAnimal, heritor of interface IDomesticAnimal
    {
        bool MaterialWithoutKilling
        {
            get;
            set;
        }

        decimal MaterialPrice // In hryvnas
        {
            get;
            set;
        }
       
        bool HasSkin
        {
            get;
            set;
        }

        bool HasWool
        {
            get;
            set;
        }

        bool HasPlumage
        {
            get;
            set;
        }

        decimal SkinArea
        {
            get;
            set;
        }

        decimal WoolWeight
        {
            get;
            set;
        }

        decimal PlumageWeight
        {
            get;
            set;
        }
    }
}
