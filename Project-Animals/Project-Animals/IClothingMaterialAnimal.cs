﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    interface IClothingMaterialAnimal : IDomesticAnimal // Interface IClothingMaterialAnimal, heritor of interface IDomesticAnimal
    {
        bool NeedOfKillingToGetMaterial
        {
            get;
            set;
        }

        double PriceForOneKillogramOfMaterial
        {
            get;
            set;
        }
    }
}
