using Microsoft.Extensions.DependencyInjection;
using solid_srp_rpg.Cenario_Bom.Application;
using solid_srp_rpg.Cenario_Bom.Application.Interfaces;
using solid_srp_rpg.Cenario_Bom.Infrastructure.Repository;
using solid_srp_rpg.Cenario_Bom.Infrastructure.Services;

namespace solid_srp_rpg.Cenario_Bom.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<PersonagemService>();
            services.AddScoped<IPersonagemRepository, PersonagemRepository>();
            services.AddScoped<INotificadorService, NotificadorService>();

            return services;
        }
    }
}
