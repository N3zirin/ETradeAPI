using Microsoft.EntityFrameworkCore;
using ETradeAPI.Application.Abstractions;
using ETradeAPI.Persistence.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETradeAPI.Persistence.Contexts;

namespace ETradeAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services )
        {
            services.AddDbContext<ETradeAPIDbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
        }
    }
}
