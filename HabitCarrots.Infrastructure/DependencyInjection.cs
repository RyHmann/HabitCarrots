using HabitCarrots.Application.Common.Interfaces.Authentication;
using HabitCarrots.Application.Common.Interfaces.Services;
using HabitCarrots.Application.Persistence;
using HabitCarrots.Infrastructure.Authentication;
using HabitCarrots.Infrastructure.Persistence;
using HabitCarrots.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HabitCarrots.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services, 
            ConfigurationManager configuration)
        {
            
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            services.AddSingleton<IJwtTokenGenerators, JwtTokenGenerator>();

            services.AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
