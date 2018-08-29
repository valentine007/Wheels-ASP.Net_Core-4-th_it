using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wheels.Models;

namespace Wheels.Persistence
{
    public interface IVehicleRepository
    {
		Task<Vehicle> GetVehicle(int id);

	}
}
