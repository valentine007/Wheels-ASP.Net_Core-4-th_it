using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wheels.Controllers.Resources;
using Wheels.Models;

namespace Wheels.Mapping
{
    public class MappingProfile : Profile
    {
		public MappingProfile()
		{
			// Domain to API Resource
			CreateMap<Make, MakeResource>();
			CreateMap<Model, ModelResource>();
			CreateMap<Feature, FeatureResource>();

			// API Resoure to Domain
			CreateMap<VehicleResource, Vehicle>()
				.ForMember(v => v.ContactName, opt => opt.MapFrom(vr => vr.Contact.Name))
				.ForMember(v => v.ContactEmail, opt => opt.MapFrom(vr => vr.Contact.Email))
				.ForMember(v => v.ContactPhone, opt => opt.MapFrom(vr => vr.Contact.Phone))
				.ForMember(v => v.Features, opt => opt.MapFrom(vr => vr.Features.Select(id => new VehicleFeature { FeatureId = id })));
		}
	}
}
