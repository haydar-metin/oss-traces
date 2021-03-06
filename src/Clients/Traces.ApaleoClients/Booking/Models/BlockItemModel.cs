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

    public partial class BlockItemModel
    {
        /// <summary>
        /// Initializes a new instance of the BlockItemModel class.
        /// </summary>
        public BlockItemModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlockItemModel class.
        /// </summary>
        /// <param name="blockedUnits">Number of units blocked</param>
        /// <param name="fromProperty">Start date and time from which the
        /// inventory will be blocked&lt;br /&gt;Specify a date and time
        /// (without fractional second part) in UTC or with UTC offset as
        /// defined in &lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO8601:2004&lt;/a&gt;</param>
        /// <param name="grossDailyRate">Gross daily rate including VAT and
        /// included service fees for single occupancy. Per person
        /// surcharges will be added to this price based on the configured
        /// surcharges of the rate plan</param>
        /// <param name="group">The group this block is attached to</param>
        /// <param name="id">Block id</param>
        /// <param name="pickedReservations">Number of reservations already
        /// picked from this block</param>
        /// <param name="property">The property</param>
        /// <param name="ratePlan">The rate plan</param>
        /// <param name="status">Status of the block. Possible values include:
        /// 'Tentative', 'Definite', 'Canceled'</param>
        /// <param name="to">End date and time until which the inventory will
        /// be blocked&lt;br /&gt;Specify a date and time (without fractional
        /// second part) in UTC or with UTC offset as defined in &lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO8601:2004&lt;/a&gt;</param>
        /// <param name="unitGroup">The unit group</param>
        /// <param name="actions">The list of actions for this block</param>
        public BlockItemModel(int blockedUnits, System.DateTime fromProperty, MonetaryValueModel grossDailyRate, EmbeddedGroupModel group, string id, int pickedReservations, EmbeddedPropertyModel property, EmbeddedRatePlanModel ratePlan, BlockStatus status, System.DateTime to, EmbeddedUnitGroupModel unitGroup, IList<ActionModelBlockActionNotAllowedBlockActionReason> actions = default(IList<ActionModelBlockActionNotAllowedBlockActionReason>))
        {
            Actions = actions;
            BlockedUnits = blockedUnits;
            FromProperty = fromProperty;
            GrossDailyRate = grossDailyRate;
            Group = group;
            Id = id;
            PickedReservations = pickedReservations;
            Property = property;
            RatePlan = ratePlan;
            Status = status;
            To = to;
            UnitGroup = unitGroup;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of actions for this block
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        public IList<ActionModelBlockActionNotAllowedBlockActionReason> Actions { get; set; }

        /// <summary>
        /// Gets or sets number of units blocked
        /// </summary>
        [JsonProperty(PropertyName = "blockedUnits")]
        public int BlockedUnits { get; set; }

        /// <summary>
        /// Gets or sets start date and time from which the inventory will be
        /// blocked&amp;lt;br /&amp;gt;Specify a date and time (without
        /// fractional second part) in UTC or with UTC offset as defined in
        /// &amp;lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&amp;gt;ISO8601:2004&amp;lt;/a&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public System.DateTime FromProperty { get; set; }

        /// <summary>
        /// Gets or sets gross daily rate including VAT and included service
        /// fees for single occupancy. Per person
        /// surcharges will be added to this price based on the configured
        /// surcharges of the rate plan
        /// </summary>
        [JsonProperty(PropertyName = "grossDailyRate")]
        public MonetaryValueModel GrossDailyRate { get; set; }

        /// <summary>
        /// Gets or sets the group this block is attached to
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public EmbeddedGroupModel Group { get; set; }

        /// <summary>
        /// Gets or sets block id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets number of reservations already picked from this block
        /// </summary>
        [JsonProperty(PropertyName = "pickedReservations")]
        public int PickedReservations { get; set; }

        /// <summary>
        /// Gets or sets the property
        /// </summary>
        [JsonProperty(PropertyName = "property")]
        public EmbeddedPropertyModel Property { get; set; }

        /// <summary>
        /// Gets or sets the rate plan
        /// </summary>
        [JsonProperty(PropertyName = "ratePlan")]
        public EmbeddedRatePlanModel RatePlan { get; set; }

        /// <summary>
        /// Gets or sets status of the block. Possible values include:
        /// 'Tentative', 'Definite', 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public BlockStatus Status { get; set; }

        /// <summary>
        /// Gets or sets end date and time until which the inventory will be
        /// blocked&amp;lt;br /&amp;gt;Specify a date and time (without
        /// fractional second part) in UTC or with UTC offset as defined in
        /// &amp;lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&amp;gt;ISO8601:2004&amp;lt;/a&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "to")]
        public System.DateTime To { get; set; }

        /// <summary>
        /// Gets or sets the unit group
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
            if (GrossDailyRate == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "GrossDailyRate");
            }
            if (Group == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Group");
            }
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Property == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Property");
            }
            if (RatePlan == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RatePlan");
            }
            if (UnitGroup == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UnitGroup");
            }
            if (Actions != null)
            {
                foreach (var element in Actions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (GrossDailyRate != null)
            {
                GrossDailyRate.Validate();
            }
            if (Group != null)
            {
                Group.Validate();
            }
            if (Property != null)
            {
                Property.Validate();
            }
            if (RatePlan != null)
            {
                RatePlan.Validate();
            }
            if (UnitGroup != null)
            {
                UnitGroup.Validate();
            }
        }
    }
}
