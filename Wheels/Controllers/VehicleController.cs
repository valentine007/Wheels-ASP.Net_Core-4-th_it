using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wheels.Controllers
{
	[Route("api/vehicles")]

    public class VehicleController : Controller
    {
		[HttpPost]
		public IActionResult CreateVehicle(VehicleController vehicle)
		{
			return Ok(vehicle);
		}
    }
}
