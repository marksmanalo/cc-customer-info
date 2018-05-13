using Classes;
using System.Data.Entity;

namespace DataModel
{
    public class CustomerInfoContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}
