// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Traces.ApaleoClients.Booking.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class OfferServiceModel
    {
        /// <summary>
        /// Initializes a new instance of the OfferServiceModel class.
        /// </summary>
        public OfferServiceModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OfferServiceModel class.
        /// </summary>
        /// <param name="amount">The total price</param>
        /// <param name="count">The default count of offered services. For
        /// services whose pricing unit is 'Person' it will be based on the
        /// adults and children specified, otherwise 1.</param>
        /// <param name="pricingMode">Whether the service price is included in
        /// or added to the base rate. Possible values include: 'Included',
        /// 'Additional'</param>
        /// <param name="service">The service</param>
        /// <param name="serviceDate">The date this service is
        /// delivered</param>
        public OfferServiceModel(AmountModel amount, int count, PricingMode pricingMode, EmbeddedServiceModel service, System.DateTime serviceDate)
        {
            Amount = amount;
            Count = count;
            PricingMode = pricingMode;
            Service = service;
            ServiceDate = serviceDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the total price
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public AmountModel Amount { get; set; }

        /// <summary>
        /// Gets or sets the default count of offered services. For services
        /// whose pricing unit is 'Person' it will be based on the adults and
        /// children specified, otherwise 1.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets whether the service price is included in or added to
        /// the base rate. Possible values include: 'Included', 'Additional'
        /// </summary>
        [JsonProperty(PropertyName = "pricingMode")]
        public PricingMode PricingMode { get; set; }

        /// <summary>
        /// Gets or sets the service
        /// </summary>
        [JsonProperty(PropertyName = "service")]
        public EmbeddedServiceModel Service { get; set; }

        /// <summary>
        /// Gets or sets the date this service is delivered
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "serviceDate")]
        public System.DateTime ServiceDate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Amount == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Amount");
            }
            if (Service == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Service");
            }
            if (Amount != null)
            {
                Amount.Validate();
            }
            if (Service != null)
            {
                Service.Validate();
            }
        }
    }
}
