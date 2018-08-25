using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wheels.Controllers.Resources;
using Wheels.Models;
using Wheels.Persistence;

namespace Wheels.Controllers
{
	[Route("/api/vehicles")]
    public class VehicleController : Controller
    {
		private readonly IMapper mapper;
		private readonly WheelsDbContext context;

		public VehicleController(IMapper mapper, WheelsDbContext context)
		{
			this.mapper = mapper;
			this.context = context;
		}

		[HttpPost]
		public async Task<IActionResult> CreateVehicle([FromBody]VehicleResource vehicleResource)
		{
			if (!ModelState.IsValid)
				return BadRequest(ModelState);

			var vehicle = mapper.Map<VehicleResource, Vehicle>(vehicleResource);
			vehicle.LastUpdate = DateTime.Now;

			context.Vehicles.Add(vehicle);
			await context.SaveChangesAsync();

			var result = mapper.Map<Vehicle, VehicleResource>(vehicle);
			return Ok(result);
		}
    }
}
