using System.Collections.Generic;

namespace Classes
{
    public class Customer
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string WebsiteUrl { get; set; }
        public Industry Industry { get; set; }
        public bool EnterPriseClient { get; set; }
        private Contact PrimaryContact { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}
