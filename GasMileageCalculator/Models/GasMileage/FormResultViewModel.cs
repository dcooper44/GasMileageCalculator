using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GasMileageCalculator.Models.GasMileage
{
    public class FormResultViewModel
    {
        public int MPG { get; set; }

        public int Gallons { get; set; }

        public int FuelRange { get; set; }

        public int TripDistance { get; set; }

        public string SuccessfulTrip { get; set; }


    }
}
