using Microsoft.Extensions.DependencyInjection;
using OnionCompany.Application.CqrsAndMediatr.Mediator.Handlers.Read;

namespace OnionCompany.Application.DependencyResolvers
{
    public static class HandlerResolver
    {
        public static void AddHandlerService(this IServiceCollection services)
        {
            services.AddMediatR(x => x.RegisterServicesFromAssembly(typeof(GetDepartmentQueryHandler).Assembly));
        }
    }
}
