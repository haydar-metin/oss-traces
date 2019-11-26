// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Traces.ApaleoClients.Booking.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ActionReasonModelNotAllowedReservationTimeSliceActionReason
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ActionReasonModelNotAllowedReservationTimeSliceActionReason class.
        /// </summary>
        public ActionReasonModelNotAllowedReservationTimeSliceActionReason()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ActionReasonModelNotAllowedReservationTimeSliceActionReason class.
        /// </summary>
        /// <param name="code">Possible values include:
        /// 'AmendNotAllowedWhenTimeSliceIsInThePast',
        /// 'AmendNotAllowedWhenTimeSliceIsAlreadyPosted',
        /// 'AmendNotAllowedForReservationInFinalStatus'</param>
        public ActionReasonModelNotAllowedReservationTimeSliceActionReason(NotAllowedReservationTimeSliceActionReason code, string message)
        {
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include:
        /// 'AmendNotAllowedWhenTimeSliceIsInThePast',
        /// 'AmendNotAllowedWhenTimeSliceIsAlreadyPosted',
        /// 'AmendNotAllowedForReservationInFinalStatus'
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public NotAllowedReservationTimeSliceActionReason Code { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Message == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Message");
            }
        }
    }
}