using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options) { }
        public DbSet<ProductItem> Products { get; set; }
        public static ServiceCollection AddDbContextServiceFromConnString(ServiceCollection serviceCollection, string connectionString)
        {
            serviceCollection.AddDbContext<ServiceContext>(options => options.UseSqlServer(connectionString));
            return serviceCollection;
        }
    }
}
