// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Traces.ApaleoClients.Booking.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MessageItemCollection
    {
        /// <summary>
        /// Initializes a new instance of the MessageItemCollection class.
        /// </summary>
        public MessageItemCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MessageItemCollection class.
        /// </summary>
        public MessageItemCollection(IList<string> messages = default(IList<string>))
        {
            Messages = messages;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages")]
        public IList<string> Messages { get; private set; }

    }
}
