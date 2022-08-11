
using AutoMapper;
using clMortgageBAL;
using clMortgageDAL.clMortgageRepository;
using clMortgageDAL.DataContext;
using clMortgageDAL.Repositories.IMortgageRepository;
using clMortgageUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace clMortgageIOC
{
    public static class DependencyInjection
    {
        public static void InjectDependencies(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlite(Configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddDbContext<ApplicationDbContext>();
            services.AddCors(options =>
            {
                options.AddPolicy(name: "AllowOrigin",
                        builder =>
                        {
                            builder.WithOrigins("*", "http://localhost:4200")
                                                .AllowAnyHeader()
                                                .AllowAnyMethod();
                        });
            });
           
            //services.AddAutoMapper(typeof(AutoMapperProfiles));
            services.AddScoped<IMortgageRepository, clMortgageRepository>();
            services.AddScoped<IMortgageService, clMortgageService>();
        }
    }
}