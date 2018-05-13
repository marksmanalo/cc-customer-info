namespace DataModel.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataModel.CustomerInfoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataModel.CustomerInfoContext context)
        {
            context.Customers.AddOrUpdate(x => x.Id,
                new Classes.Customer()
                {
                    Id = 1,
                    CompanyName = "CyberCoders",
                    WebsiteUrl = "cybercoders.com",
                    Industry = 1,
                    EnterpriseClient = false,
                    PrimaryContactId = null
                }
                );

            context.Contacts.AddOrUpdate(x => x.Id,
                new Classes.Contact()
                {
                    Id = 1,
                    FirstName = "Dieter",
                    LastName = "Weber",
                    Email = "dWeber@gmail.com",
                    PhoneNumber = "123-456-7899",
                    CustomerId = 1
                }
                );
        }
    }
}
