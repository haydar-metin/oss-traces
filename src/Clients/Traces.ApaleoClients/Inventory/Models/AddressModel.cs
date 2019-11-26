// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Traces.ApaleoClients.Inventory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class AddressModel
    {
        /// <summary>
        /// Initializes a new instance of the AddressModel class.
        /// </summary>
        public AddressModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AddressModel class.
        /// </summary>
        public AddressModel(string addressLine1, string city, string countryCode, string postalCode, string addressLine2 = default(string))
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            CountryCode = countryCode;
            PostalCode = postalCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addressLine1")]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "addressLine2")]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (AddressLine1 == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AddressLine1");
            }
            if (City == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "City");
            }
            if (CountryCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CountryCode");
            }
            if (PostalCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PostalCode");
            }
        }
    }
}
