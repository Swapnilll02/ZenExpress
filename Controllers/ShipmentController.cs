using Microsoft.AspNetCore.Mvc;
using CourierService.Models;

namespace CourierService.Controllers
{
    public class ShipmentController : Controller
    {
        // Display the form
        [HttpGet("/ship")]
        public IActionResult Ship()
        {
            return View();
        }

        // Handle form submission
        [HttpPost("/ship")]
        public IActionResult Ship(Shipment model)
        {
            if (ModelState.IsValid)
            {
                // Calculate the base amount based on PackageWeight
                if (model.PackageWeight > 0 && model.PackageWeight <= 2)
                {
                    model.TotalAmount = 100;
                }
                else if (model.PackageWeight > 2 && model.PackageWeight <= 5)
                {
                    model.TotalAmount = 299;
                }
                else if (model.PackageWeight > 5 && model.PackageWeight <= 10)
                {
                    model.TotalAmount = 499;
                }
                else if (model.PackageWeight > 10 && model.PackageWeight <= 25)
                {
                    model.TotalAmount = 799;
                }
                else if (model.PackageWeight > 25)
                {
                    model.TotalAmount = 999;
                }

                // Add ₹100 if the user chose "One Day Delivery"
                if (model.DeliveryOption == "One Day Delivery")
                {
                    model.TotalAmount += 100;
                }

                // Pass the model to the Summary view with calculated TotalAmount
                return View("Summary", model);
            }

            // Return to the form if the model state is invalid
            return View(model);
        }
    }
}
