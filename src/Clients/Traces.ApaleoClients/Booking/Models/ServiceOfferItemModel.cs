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

    public partial class ServiceOfferItemModel
    {
        /// <summary>
        /// Initializes a new instance of the ServiceOfferItemModel class.
        /// </summary>
        public ServiceOfferItemModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceOfferItemModel class.
        /// </summary>
        /// <param name="amount">The total price (for all persons on the
        /// offer)</param>
        /// <param name="isDefaultDate">Depending on the postNextDay setting of
        /// the service it will by default be posted before or after midnight.
        /// Breakfast is usually delivered on the next morning, so all the
        /// dates from the day after arrival to the departure day
        /// are default dates and will have this flag set to true. Those are
        /// also the dates the service will be booked for if
        /// you do not specify dates in the book-service call. Still, you can
        /// override this and also book the dates set to IsDefaultDate =
        /// false.</param>
        /// <param name="serviceDate">The date this service is
        /// delivered</param>
        public ServiceOfferItemModel(AmountModel amount, bool isDefaultDate, System.DateTime serviceDate)
        {
            Amount = amount;
            IsDefaultDate = isDefaultDate;
            ServiceDate = serviceDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the total price (for all persons on the offer)
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public AmountModel Amount { get; set; }

        /// <summary>
        /// Gets or sets depending on the postNextDay setting of the service it
        /// will by default be posted before or after midnight.
        /// Breakfast is usually delivered on the next morning, so all the
        /// dates from the day after arrival to the departure day
        /// are default dates and will have this flag set to true. Those are
        /// also the dates the service will be booked for if
        /// you do not specify dates in the book-service call. Still, you can
        /// override this and also book the dates set to IsDefaultDate = false.
        /// </summary>
        [JsonProperty(PropertyName = "isDefaultDate")]
        public bool IsDefaultDate { get; set; }

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
            if (Amount != null)
            {
                Amount.Validate();
            }
        }
    }
}
