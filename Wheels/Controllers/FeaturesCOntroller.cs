using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wheels.Controllers.Resources;
using Wheels.Models;
using Wheels.Persistence;

namespace vega.Controllers
{
	public class FeaturesController : Controller
	{
		private readonly WheelsDBContext context;
		private readonly IMapper mapper;
		public FeaturesController(WheelsDBContext context, IMapper mapper)
		{
			this.mapper = mapper;
			this.context = context;
		}

		[HttpGet("/api/features")]
		public async Task<IEnumerable<FeatureResource>> GetFeatures()
		{
			var features = await context.Features.ToListAsync();

			return mapper.Map<List<Feature>, List<FeatureResource>>(features);
		}
	}
}