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
		public DbSet<Make> Makes { get; set; }
		public DbSet<Feature> Features { get; set; }

		public WheelsDBContext(DbContextOptions<WheelsDBContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<VehicleFeature>().HasKey(vf => new { vf.VehicleId, vf.FeatureId });
		}
	}
}
