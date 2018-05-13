using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Classes
{
    public class Contact
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("customerId")]
        public int CustomerId { get; set; }

        [JsonIgnore]
        [JsonProperty("customer")]
        public Customer Customer { get; set; }
    }
}
