using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wheels.Controllers.Resources;
using Wheels.Models;

namespace Wheels.Controllers
{
	[Route("api/vehicles")]

    public class VehicleController : Controller
    {
		private readonly IMapper mapper;

		public VehicleController(IMapper mapper)
		{
			this.mapper = mapper;
		}

		[HttpPost]
		public IActionResult CreateVehicle(VehicleResource vehicleResource)
		{
			var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);
			return Ok(vehicle);
		}
    }
}
