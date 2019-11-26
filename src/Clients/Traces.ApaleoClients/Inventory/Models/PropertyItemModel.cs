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

    public partial class PropertyItemModel
    {
        /// <summary>
        /// Initializes a new instance of the PropertyItemModel class.
        /// </summary>
        public PropertyItemModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PropertyItemModel class.
        /// </summary>
        /// <param name="code">The code for the property that can be shown in
        /// reports and table views</param>
        /// <param name="created">Date of creation&lt;br /&gt;Specify a date
        /// and time (without fractional second part) in UTC or with UTC offset
        /// as defined in &lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO8601:2004&lt;/a&gt;</param>
        /// <param name="currencyCode">The currency a property works
        /// with.</param>
        /// <param name="id">The property id</param>
        /// <param name="isTemplate">Whether the property can be used as a
        /// template for other properties</param>
        /// <param name="location">The location of the property</param>
        /// <param name="name">The name for the property</param>
        /// <param name="timeZone">The time zone name of the property from the
        /// IANA Time Zone Database.
        /// (see:
        /// https://en.wikipedia.org/wiki/List_of_tz_database_time_zones)</param>
        /// <param name="description">The description for the property</param>
        /// <param name="propertyTemplateId">The id of the property used as a
        /// template while creating the property</param>
        public PropertyItemModel(string code, System.DateTime created, string currencyCode, string id, bool isTemplate, AddressModel location, string name, string timeZone, string description = default(string), string propertyTemplateId = default(string))
        {
            Code = code;
            Created = created;
            CurrencyCode = currencyCode;
            Description = description;
            Id = id;
            IsTemplate = isTemplate;
            Location = location;
            Name = name;
            PropertyTemplateId = propertyTemplateId;
            TimeZone = timeZone;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the code for the property that can be shown in reports
        /// and table views
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets date of creation&amp;lt;br /&amp;gt;Specify a date and
        /// time (without fractional second part) in UTC or with UTC offset as
        /// defined in &amp;lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&amp;gt;ISO8601:2004&amp;lt;/a&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public System.DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets the currency a property works with.
        /// </summary>
        [JsonProperty(PropertyName = "currencyCode")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or sets the description for the property
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the property id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets whether the property can be used as a template for
        /// other properties
        /// </summary>
        [JsonProperty(PropertyName = "isTemplate")]
        public bool IsTemplate { get; set; }

        /// <summary>
        /// Gets or sets the location of the property
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public AddressModel Location { get; set; }

        /// <summary>
        /// Gets or sets the name for the property
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the id of the property used as a template while
        /// creating the property
        /// </summary>
        [JsonProperty(PropertyName = "propertyTemplateId")]
        public string PropertyTemplateId { get; set; }

        /// <summary>
        /// Gets or sets the time zone name of the property from the IANA Time
        /// Zone Database.
        /// (see: https://en.wikipedia.org/wiki/List_of_tz_database_time_zones)
        /// </summary>
        [JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Code == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Code");
            }
            if (CurrencyCode == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CurrencyCode");
            }
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (TimeZone == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TimeZone");
            }
            if (Location != null)
            {
                Location.Validate();
            }
        }
    }
}
