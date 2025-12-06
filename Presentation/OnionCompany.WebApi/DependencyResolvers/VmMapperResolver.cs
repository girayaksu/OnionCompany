using OnionCompany.WebApi.MappingProfiles;

namespace OnionCompany.WebApi.DependencyResolvers
{
    public static class VmMapperResolver
    {
        public static void AddVmMapperService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(VmMappingProfile));
        }
    }
}
