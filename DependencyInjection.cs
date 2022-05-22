using ServiceInjection.Interfaces;
using ServiceInjection.Repositories;
using ServiceInjection.Services;

namespace ServiceInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddProjectService(this
        IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IUserRepository, UserRepository>();
            return services;
        }
    }
}
