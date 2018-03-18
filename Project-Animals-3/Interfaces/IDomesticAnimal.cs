using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Animals
{
    interface IDomesticAnimal // First parental interface
    {
        decimal Age // Property age in years
        {
            get;
            set;
        }

        decimal Height // In meters
        {
            get;
            set;
        }

        decimal Length // In meters
        {
            get;
            set;
        }

        decimal Width // In meters
        {
            get;
            set;
        }

        decimal Weight // In killograms
        {
            get;
            set;
        }

        Gender Gender
        {
            get;
            set;
        }

        decimal Lifespan // In years
        {
            get;
            set;
        }

        decimal BearingCubsTime // In months
        {
            get;
            set;
        }

        string Species 
        {
            get;
            set;
        }

        DateTime BirthDate
        {
            get;
            set;
        }

        DateTime DeathDate
        {
            get;
            set;
        }

        DateTime LatestPrevMedProcedureDate
        {
            get;
            set;
        }

        DateTime LatestVetInspectionDate
        {
            get;
            set;
        }

        LifeStatus LifeStatus
        {
            get;
            set;
        }
    }
}
