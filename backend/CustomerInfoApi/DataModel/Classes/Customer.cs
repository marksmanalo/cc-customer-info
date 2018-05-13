using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Classes
{
    public class Customer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string WebsiteUrl { get; set; }
        public Industry Industry { get; set; }
        public bool EnterpriseClient { get; set; }
        public int? PrimaryContactId { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
