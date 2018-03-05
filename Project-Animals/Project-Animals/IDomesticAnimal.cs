using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    interface IDomesticAnimal // First parental interface
    {
        double Age // Property age in years
        {
            get;
            set;
        }

        double Height // In meters
        {
            get;
            set;
        }

        double Length // In meters
        {
            get;
            set;
        }

        double Width // In meters
        {
            get;
            set;
        }

        double Weight // In killograms
        {
            get;
            set;
        }

        gender Gender
        {
            get;
            set;
        }        

        double Lifespan // In years
        {
            get;
            set;
        }

        double TimeOfBearingOrIncubationCubs // In months
        {
            get;
            set;
        }

        string Species 
        {
            get;
            set;
        }

        DateTime DateOfBirth
        {
            get;
            set;
        }

        DateTime DateOfDeath
        {
            get;
            set;
        }

        DateTime DateOfLatestPreventiveMedProcedure
        {
            get;
            set;
        }

        DateTime DateOfLatestVeterinaryInspection
        {
            get;
            set;
        }

        statusoflife StatusOfLife
        {
            get;
            set;
        }
    }
}
