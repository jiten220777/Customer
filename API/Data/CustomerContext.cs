using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Customer>Customers{get;set;}
    }
}