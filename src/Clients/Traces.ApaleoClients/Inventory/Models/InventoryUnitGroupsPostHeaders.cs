// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Traces.ApaleoClients.Inventory.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for InventoryUnit-groupsPost operation.
    /// </summary>
    public partial class InventoryUnitGroupsPostHeaders
    {
        /// <summary>
        /// Initializes a new instance of the InventoryUnitGroupsPostHeaders
        /// class.
        /// </summary>
        public InventoryUnitGroupsPostHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InventoryUnitGroupsPostHeaders
        /// class.
        /// </summary>
        /// <param name="location">The location of the created
        /// resource.</param>
        public InventoryUnitGroupsPostHeaders(string location = default(string))
        {
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the location of the created resource.
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}
