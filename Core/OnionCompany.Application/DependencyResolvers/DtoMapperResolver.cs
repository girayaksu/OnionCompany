using Microsoft.Extensions.DependencyInjection;
using OnionCompany.Application.MappingProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OnionCompany.Application.DependencyResolvers
{
    public static class DtoMapperResolver
    {

        public static void AddDtoMapperService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(DtoMappingProfile));
        }
    }
}
