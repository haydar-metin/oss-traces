// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Traces.ApaleoClients.Inventory.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class EmbeddedPropertyModel
    {
        /// <summary>
        /// Initializes a new instance of the EmbeddedPropertyModel class.
        /// </summary>
        public EmbeddedPropertyModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EmbeddedPropertyModel class.
        /// </summary>
        /// <param name="id">The property id</param>
        /// <param name="code">The code for the property that can be shown in
        /// reports and table views</param>
        /// <param name="description">The description for the property</param>
        /// <param name="name">The name for the property</param>
        public EmbeddedPropertyModel(string id, string code = default(string), string description = default(string), string name = default(string))
        {
            Code = code;
            Description = description;
            Id = id;
            Name = name;
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
        /// Gets the description for the property
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets the property id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets the name for the property
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
