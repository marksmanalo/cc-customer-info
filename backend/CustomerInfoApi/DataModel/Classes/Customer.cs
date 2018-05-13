using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Classes
{
    public class Customer
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("websiteUrl")]
        public string WebsiteUrl { get; set; }

        [JsonProperty("industry")]
        public int Industry { get; set; }

        [JsonProperty("enterpriseClient")]
        public bool EnterpriseClient { get; set; }

        [JsonProperty("primaryContactId")]
        public int? PrimaryContactId { get; set; }

        [JsonProperty("contacts")]
        public List<Contact> Contacts { get; set; }
    }
}
