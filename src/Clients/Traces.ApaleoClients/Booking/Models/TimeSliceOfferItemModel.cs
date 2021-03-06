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

    public partial class TimeSliceOfferItemModel
    {
        /// <summary>
        /// Initializes a new instance of the TimeSliceOfferItemModel class.
        /// </summary>
        public TimeSliceOfferItemModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TimeSliceOfferItemModel class.
        /// </summary>
        /// <param name="available">The number of available units for the
        /// offer</param>
        /// <param name="unitGroup">The unit group for which the offer
        /// applies</param>
        /// <param name="maxAdvance">The maximum advance booking period</param>
        /// <param name="minAdvance">The minimum advance booking period</param>
        /// <param name="minGuaranteeType">The minimum guarantee type for the
        /// offer. Possible values include: 'PM6Hold', 'CreditCard',
        /// 'Prepayment', 'Company', 'Ota'</param>
        /// <param name="prices">The prices for this offer</param>
        /// <param name="restrictions">The restrictions set for this
        /// offer</param>
        public TimeSliceOfferItemModel(int available, EmbeddedUnitGroupModel unitGroup, PeriodModel maxAdvance = default(PeriodModel), PeriodModel minAdvance = default(PeriodModel), string minGuaranteeType = default(string), IList<PerOccupancyPriceItemModel> prices = default(IList<PerOccupancyPriceItemModel>), RateRestrictionsModel restrictions = default(RateRestrictionsModel))
        {
            Available = available;
            MaxAdvance = maxAdvance;
            MinAdvance = minAdvance;
            MinGuaranteeType = minGuaranteeType;
            Prices = prices;
            Restrictions = restrictions;
            UnitGroup = unitGroup;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of available units for the offer
        /// </summary>
        [JsonProperty(PropertyName = "available")]
        public int Available { get; set; }

        /// <summary>
        /// Gets or sets the maximum advance booking period
        /// </summary>
        [JsonProperty(PropertyName = "maxAdvance")]
        public PeriodModel MaxAdvance { get; set; }

        /// <summary>
        /// Gets or sets the minimum advance booking period
        /// </summary>
        [JsonProperty(PropertyName = "minAdvance")]
        public PeriodModel MinAdvance { get; set; }

        /// <summary>
        /// Gets or sets the minimum guarantee type for the offer. Possible
        /// values include: 'PM6Hold', 'CreditCard', 'Prepayment', 'Company',
        /// 'Ota'
        /// </summary>
        [JsonProperty(PropertyName = "minGuaranteeType")]
        public string MinGuaranteeType { get; set; }

        /// <summary>
        /// Gets or sets the prices for this offer
        /// </summary>
        [JsonProperty(PropertyName = "prices")]
        public IList<PerOccupancyPriceItemModel> Prices { get; set; }

        /// <summary>
        /// Gets or sets the restrictions set for this offer
        /// </summary>
        [JsonProperty(PropertyName = "restrictions")]
        public RateRestrictionsModel Restrictions { get; set; }

        /// <summary>
        /// Gets or sets the unit group for which the offer applies
        /// </summary>
        [JsonProperty(PropertyName = "unitGroup")]
        public EmbeddedUnitGroupModel UnitGroup { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UnitGroup == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UnitGroup");
            }
            if (Prices != null)
            {
                foreach (var element in Prices)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Restrictions != null)
            {
                Restrictions.Validate();
            }
            if (UnitGroup != null)
            {
                UnitGroup.Validate();
            }
        }
    }
}
