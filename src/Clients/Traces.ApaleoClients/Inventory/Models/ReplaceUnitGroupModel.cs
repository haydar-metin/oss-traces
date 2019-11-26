// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Traces.ApaleoClients.Inventory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ReplaceUnitGroupModel
    {
        /// <summary>
        /// Initializes a new instance of the ReplaceUnitGroupModel class.
        /// </summary>
        public ReplaceUnitGroupModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReplaceUnitGroupModel class.
        /// </summary>
        /// <param name="description">The description for the unit
        /// group</param>
        /// <param name="name">The name for the unit group</param>
        /// <param name="maxPersons">Maximum number of persons for the unit
        /// group.
        /// If this value is increased, the surcharges for the related rate
        /// plans must be specified in order for the rate plans to be sellable
        /// for the new possible occupancies.</param>
        /// <param name="rank">The unit group rank
        /// Restrictions:
        /// - Should be greater or equal to one</param>
        public ReplaceUnitGroupModel(IDictionary<string, string> description, IDictionary<string, string> name, int? maxPersons = default(int?), int? rank = default(int?))
        {
            Description = description;
            MaxPersons = maxPersons;
            Name = name;
            Rank = rank;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the description for the unit group
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public IDictionary<string, string> Description { get; set; }

        /// <summary>
        /// Gets or sets maximum number of persons for the unit group.
        /// If this value is increased, the surcharges for the related rate
        /// plans must be specified in order for the rate plans to be sellable
        /// for the new possible occupancies.
        /// </summary>
        [JsonProperty(PropertyName = "maxPersons")]
        public int? MaxPersons { get; set; }

        /// <summary>
        /// Gets or sets the name for the unit group
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public IDictionary<string, string> Name { get; set; }

        /// <summary>
        /// Gets or sets the unit group rank
        /// Restrictions:
        /// - Should be greater or equal to one
        /// </summary>
        [JsonProperty(PropertyName = "rank")]
        public int? Rank { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Description == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Description");
            }
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Rank > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Rank", 2147483647);
            }
            if (Rank < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Rank", 1);
            }
        }
    }
}
