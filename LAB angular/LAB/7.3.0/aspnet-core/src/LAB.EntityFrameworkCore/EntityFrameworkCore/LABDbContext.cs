using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LAB.Authorization.Roles;
using LAB.Authorization.Users;
using LAB.MultiTenancy;

namespace LAB.EntityFrameworkCore
{
    public class LABDbContext : AbpZeroDbContext<Tenant, Role, User, LABDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LABDbContext(DbContextOptions<LABDbContext> options)
            : base(options)
        {
        }
    }
}
