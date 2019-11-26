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

    public partial class UnitGroupAvailabilityTimeSliceItemModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// UnitGroupAvailabilityTimeSliceItemModel class.
        /// </summary>
        public UnitGroupAvailabilityTimeSliceItemModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// UnitGroupAvailabilityTimeSliceItemModel class.
        /// </summary>
        /// <param name="fromProperty">Date and time the time slice
        /// begins&lt;br /&gt;Specify a date and time (without fractional
        /// second part) in UTC or with UTC offset as defined in &lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO8601:2004&lt;/a&gt;</param>
        /// <param name="property">Property availability for this time
        /// slice</param>
        /// <param name="to">Date and time the time slice ends&lt;br
        /// /&gt;Specify a date and time (without fractional second part) in
        /// UTC or with UTC offset as defined in &lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO8601:2004&lt;/a&gt;</param>
        /// <param name="unitGroups">List of unit group availabilities for this
        /// time slice</param>
        public UnitGroupAvailabilityTimeSliceItemModel(System.DateTime fromProperty, PropertyAvailabilityModel property, System.DateTime to, IList<UnitGroupAvailabilityItemModel> unitGroups)
        {
            FromProperty = fromProperty;
            Property = property;
            To = to;
            UnitGroups = unitGroups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets date and time the time slice begins&amp;lt;br
        /// /&amp;gt;Specify a date and time (without fractional second part)
        /// in UTC or with UTC offset as defined in &amp;lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&amp;gt;ISO8601:2004&amp;lt;/a&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public System.DateTime FromProperty { get; set; }

        /// <summary>
        /// Gets or sets property availability for this time slice
        /// </summary>
        [JsonProperty(PropertyName = "property")]
        public PropertyAvailabilityModel Property { get; set; }

        /// <summary>
        /// Gets or sets date and time the time slice ends&amp;lt;br
        /// /&amp;gt;Specify a date and time (without fractional second part)
        /// in UTC or with UTC offset as defined in &amp;lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&amp;gt;ISO8601:2004&amp;lt;/a&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "to")]
        public System.DateTime To { get; set; }

        /// <summary>
        /// Gets or sets list of unit group availabilities for this time slice
        /// </summary>
        [JsonProperty(PropertyName = "unitGroups")]
        public IList<UnitGroupAvailabilityItemModel> UnitGroups { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Property == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Property");
            }
            if (UnitGroups == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UnitGroups");
            }
            if (Property != null)
            {
                Property.Validate();
            }
            if (UnitGroups != null)
            {
                foreach (var element in UnitGroups)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}