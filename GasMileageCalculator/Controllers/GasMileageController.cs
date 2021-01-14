using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GasMileageCalculator.Models.GasMileage;
using Microsoft.AspNetCore.Mvc;

namespace GasMileageCalculator.Controllers
{
    public class GasMileageController : Controller
    {
        public IActionResult Form()
        {
            return View();
        }

        public IActionResult FormResult(FormResultViewModel model)
        {
            // do some math and shit
            model.FuelRange = model.MPG * model.Gallons;

            if (model.TripDistance <= model.FuelRange)
            {
                model.SuccessfulTrip = "Yes";
            }
            else
            {
                model.SuccessfulTrip = "No Way Jose";
            }

            return View(model);
        }
    }
}