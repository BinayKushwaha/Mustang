using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mustang.Database.Context;
using Mustang.Database.Entity;
using Mustang.Database.Repository;
using Mustang.Service.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mustang.IoC
{
    public static class IServiceCollectionExtension
    {
        public static void AddCustomServices(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["ConnectionStrings:ConnectionDbString"];
            services.AddDbContext<ApplicationContext>(opt=>opt.UseSqlServer(connectionString));

            services.Configure<IdentityOptions>(opt =>
            {
                opt.Password.RequireDigit = true;
                opt.Password.RequiredLength = 6;
                opt.Password.RequireNonAlphanumeric = true;
               
            });
            services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUserService, UserService>();
            services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true).AddRoles<IdentityRole>()
           .AddEntityFrameworkStores<ApplicationContext>();
        }
    }
}
