using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wheels.Models;

namespace Wheels.Persistence
{
	public class WheelsDBContext : DbContext
	{
		public WheelsDBContext(DbContextOptions<WheelsDBContext> options) : base(options)
		{

		}

		public DbSet<Make> Makes { get; set; }
		public DbSet<Feature> Features { get; set; }
	}
}
