using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LAB.Authorization.Roles;
using LAB.Authorization.Users;
using LAB.MultiTenancy;
using LAB.Cars;
using LAB.Admin_bots_encje;
using LAB.Bots_encje;

namespace LAB.EntityFrameworkCore
{
    public class LABDbContext : AbpZeroDbContext<Tenant, Role, User, LABDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Car> Cars { get; set; }
        public DbSet<Admin_bot_en> Admin_bot_ens { get; set; }
        public DbSet<Bot_en> Bot_ens { get; set; }

        public LABDbContext(DbContextOptions<LABDbContext> options)
            : base(options)
        {
        }
    }
}
