// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Traces.ApaleoClients.Booking.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ReservationStayOfferModel
    {
        /// <summary>
        /// Initializes a new instance of the ReservationStayOfferModel class.
        /// </summary>
        public ReservationStayOfferModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReservationStayOfferModel class.
        /// </summary>
        /// <param name="arrival">The earliest arrival date and time for this
        /// offer&lt;br /&gt;Specify a date and time (without fractional second
        /// part) in UTC or with UTC offset as defined in &lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO8601:2004&lt;/a&gt;</param>
        /// <param name="availableUnits">The number of available units for that
        /// offer</param>
        /// <param name="cancellationFee">Details about the cancellation fee
        /// for this offer</param>
        /// <param name="departure">The latest departure date and time for this
        /// offer&lt;br /&gt;Specify a date and time (without fractional second
        /// part) in UTC or with UTC offset as defined in &lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO8601:2004&lt;/a&gt;</param>
        /// <param name="minGuaranteeType">The minimum guarantee type for this
        /// offer. Possible values include: 'PM6Hold', 'CreditCard',
        /// 'Prepayment', 'Company'</param>
        /// <param name="noShowFee">Details about the no-show fee for this
        /// offer</param>
        /// <param name="taxDetails">Tax breakdown, displaying net and tax
        /// amount for each VAT type</param>
        /// <param name="timeSlices">The breakdown for each time slice for this
        /// offer</param>
        /// <param name="totalGrossAmount">The price for the whole stay</param>
        /// <param name="cityTax">The amount of city tax that can be charged
        /// for this offer</param>
        /// <param name="companyId">ID of the company the offer is created
        /// for</param>
        /// <param name="corporateCode">The corporate rate code the offer is
        /// created for</param>
        /// <param name="services">The breakdown for extra services reserved
        /// for this offer</param>
        /// <param name="validationMessages">Validation rules that were applied
        /// to the offer and show the reason why the offer is not
        /// bookable</param>
        public ReservationStayOfferModel(System.DateTime arrival, int availableUnits, OfferCancellationFeeModel cancellationFee, System.DateTime departure, MinGuaranteeType minGuaranteeType, OfferNoShowFeeModel noShowFee, IList<TaxDetailModel> taxDetails, IList<ReservationStayOfferTimeSliceModel> timeSlices, MonetaryValueModel totalGrossAmount, AmountModel cityTax = default(AmountModel), string companyId = default(string), string corporateCode = default(string), IList<ServiceOfferModel> services = default(IList<ServiceOfferModel>), IList<OfferValidationMessageModel> validationMessages = default(IList<OfferValidationMessageModel>))
        {
            Arrival = arrival;
            AvailableUnits = availableUnits;
            CancellationFee = cancellationFee;
            CityTax = cityTax;
            CompanyId = companyId;
            CorporateCode = corporateCode;
            Departure = departure;
            MinGuaranteeType = minGuaranteeType;
            NoShowFee = noShowFee;
            Services = services;
            TaxDetails = taxDetails;
            TimeSlices = timeSlices;
            TotalGrossAmount = totalGrossAmount;
            ValidationMessages = validationMessages;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the earliest arrival date and time for this
        /// offer&amp;lt;br /&amp;gt;Specify a date and time (without
        /// fractional second part) in UTC or with UTC offset as defined in
        /// &amp;lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&amp;gt;ISO8601:2004&amp;lt;/a&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "arrival")]
        public System.DateTime Arrival { get; set; }

        /// <summary>
        /// Gets or sets the number of available units for that offer
        /// </summary>
        [JsonProperty(PropertyName = "availableUnits")]
        public int AvailableUnits { get; set; }

        /// <summary>
        /// Gets or sets details about the cancellation fee for this offer
        /// </summary>
        [JsonProperty(PropertyName = "cancellationFee")]
        public OfferCancellationFeeModel CancellationFee { get; set; }

        /// <summary>
        /// Gets or sets the amount of city tax that can be charged for this
        /// offer
        /// </summary>
        [JsonProperty(PropertyName = "cityTax")]
        public AmountModel CityTax { get; set; }

        /// <summary>
        /// Gets or sets ID of the company the offer is created for
        /// </summary>
        [JsonProperty(PropertyName = "companyId")]
        public string CompanyId { get; set; }

        /// <summary>
        /// Gets or sets the corporate rate code the offer is created for
        /// </summary>
        [JsonProperty(PropertyName = "corporateCode")]
        public string CorporateCode { get; set; }

        /// <summary>
        /// Gets or sets the latest departure date and time for this
        /// offer&amp;lt;br /&amp;gt;Specify a date and time (without
        /// fractional second part) in UTC or with UTC offset as defined in
        /// &amp;lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&amp;gt;ISO8601:2004&amp;lt;/a&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "departure")]
        public System.DateTime Departure { get; set; }

        /// <summary>
        /// Gets or sets the minimum guarantee type for this offer. Possible
        /// values include: 'PM6Hold', 'CreditCard', 'Prepayment', 'Company'
        /// </summary>
        [JsonProperty(PropertyName = "minGuaranteeType")]
        public MinGuaranteeType MinGuaranteeType { get; set; }

        /// <summary>
        /// Gets or sets details about the no-show fee for this offer
        /// </summary>
        [JsonProperty(PropertyName = "noShowFee")]
        public OfferNoShowFeeModel NoShowFee { get; set; }

        /// <summary>
        /// Gets or sets the breakdown for extra services reserved for this
        /// offer
        /// </summary>
        [JsonProperty(PropertyName = "services")]
        public IList<ServiceOfferModel> Services { get; set; }

        /// <summary>
        /// Gets or sets tax breakdown, displaying net and tax amount for each
        /// VAT type
        /// </summary>
        [JsonProperty(PropertyName = "taxDetails")]
        public IList<TaxDetailModel> TaxDetails { get; set; }

        /// <summary>
        /// Gets or sets the breakdown for each time slice for this offer
        /// </summary>
        [JsonProperty(PropertyName = "timeSlices")]
        public IList<ReservationStayOfferTimeSliceModel> TimeSlices { get; set; }

        /// <summary>
        /// Gets or sets the price for the whole stay
        /// </summary>
        [JsonProperty(PropertyName = "totalGrossAmount")]
        public MonetaryValueModel TotalGrossAmount { get; set; }

        /// <summary>
        /// Gets or sets validation rules that were applied to the offer and
        /// show the reason why the offer is not bookable
        /// </summary>
        [JsonProperty(PropertyName = "validationMessages")]
        public IList<OfferValidationMessageModel> ValidationMessages { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CancellationFee == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CancellationFee");
            }
            if (NoShowFee == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NoShowFee");
            }
            if (TaxDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TaxDetails");
            }
            if (TimeSlices == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TimeSlices");
            }
            if (TotalGrossAmount == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TotalGrossAmount");
            }
            if (CancellationFee != null)
            {
                CancellationFee.Validate();
            }
            if (CityTax != null)
            {
                CityTax.Validate();
            }
            if (NoShowFee != null)
            {
                NoShowFee.Validate();
            }
            if (Services != null)
            {
                foreach (var element in Services)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (TaxDetails != null)
            {
                foreach (var element1 in TaxDetails)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (TimeSlices != null)
            {
                foreach (var element2 in TimeSlices)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (TotalGrossAmount != null)
            {
                TotalGrossAmount.Validate();
            }
            if (ValidationMessages != null)
            {
                foreach (var element3 in ValidationMessages)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
        }
    }
}
