using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Animals
{
    interface IDomesticAnimal // First parental interface
    {
        double Age // Property age
        {
            get;
            set;
        }

        double Height
        {
            get;
            set;
        }

        double Length
        {
            get;
            set;
        }

        double Width
        {
            get;
            set;
        }

        double Weight
        {
            get;
            set;
        }

        gender Gender
        {
            get;
            set;
        }        

        double Lifespan 
        {
            get;
            set;
        }

        double TimeOfBearingOrIncubationCubs 
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
