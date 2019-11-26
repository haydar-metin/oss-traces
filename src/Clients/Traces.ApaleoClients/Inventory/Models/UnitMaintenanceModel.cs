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

    public partial class UnitMaintenanceModel
    {
        /// <summary>
        /// Initializes a new instance of the UnitMaintenanceModel class.
        /// </summary>
        public UnitMaintenanceModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UnitMaintenanceModel class.
        /// </summary>
        /// <param name="fromProperty">Date and time the scheduled maintenance
        /// window starts&lt;br /&gt;Specify a date and time (without
        /// fractional second part) in UTC or with UTC offset as defined in
        /// &lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO8601:2004&lt;/a&gt;</param>
        /// <param name="id">The id for the scheduled maintenance</param>
        /// <param name="to">Date and time the scheduled maintenance window
        /// ends&lt;br /&gt;Specify a date and time (without fractional second
        /// part) in UTC or with UTC offset as defined in &lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO8601:2004&lt;/a&gt;</param>
        /// <param name="type">The type of maintenance that is planned for the
        /// unit. A small repair (OutOfService),
        /// a bigger disfunction that does not allow to sell the unit
        /// (OutOfOrder) or is it
        /// even under construction and should reduce the house count
        /// (OutOfInventory). Possible values include: 'OutOfService',
        /// 'OutOfOrder', 'OutOfInventory'</param>
        /// <param name="description">The description text for the
        /// maintenance</param>
        public UnitMaintenanceModel(System.DateTime fromProperty, string id, System.DateTime to, MaintenanceType type, string description = default(string))
        {
            Description = description;
            FromProperty = fromProperty;
            Id = id;
            To = to;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the description text for the maintenance
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets date and time the scheduled maintenance window
        /// starts&amp;lt;br /&amp;gt;Specify a date and time (without
        /// fractional second part) in UTC or with UTC offset as defined in
        /// &amp;lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&amp;gt;ISO8601:2004&amp;lt;/a&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public System.DateTime FromProperty { get; set; }

        /// <summary>
        /// Gets or sets the id for the scheduled maintenance
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets date and time the scheduled maintenance window
        /// ends&amp;lt;br /&amp;gt;Specify a date and time (without fractional
        /// second part) in UTC or with UTC offset as defined in &amp;lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&amp;gt;ISO8601:2004&amp;lt;/a&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "to")]
        public System.DateTime To { get; set; }

        /// <summary>
        /// Gets or sets the type of maintenance that is planned for the unit.
        /// A small repair (OutOfService),
        /// a bigger disfunction that does not allow to sell the unit
        /// (OutOfOrder) or is it
        /// even under construction and should reduce the house count
        /// (OutOfInventory). Possible values include: 'OutOfService',
        /// 'OutOfOrder', 'OutOfInventory'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public MaintenanceType Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
        }
    }
}