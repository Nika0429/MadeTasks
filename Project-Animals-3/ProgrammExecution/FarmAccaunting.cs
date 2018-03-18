using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Animals
{
    class FarmAccaunting
    {
        static void Main()
        {
            Cow Cow1 = new Cow();
            Cow1.Species = "Golshtinskaya";
            Cow1.BirthDate = DateTime.Today;
            Cow1.LatestPrevMedProcedureDate = DateTime.Today;
            Cow1.LatestVetInspectionDate = DateTime.Today; // I do not know how to write the data.
        }
    }
}
