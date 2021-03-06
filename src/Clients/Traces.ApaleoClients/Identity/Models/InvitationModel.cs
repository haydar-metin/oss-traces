// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Traces.ApaleoClients.Identity.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class InvitationModel
    {
        /// <summary>
        /// Initializes a new instance of the InvitationModel class.
        /// </summary>
        public InvitationModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InvitationModel class.
        /// </summary>
        /// <param name="created">Date the invitation was made</param>
        /// <param name="email">Email address, used as the login</param>
        /// <param name="invitedBy">Email of the user making the
        /// invitation</param>
        /// <param name="isAccountAdmin">If set to {true}, user has full access
        /// to all properties.</param>
        /// <param name="properties">Properties that user has access to</param>
        /// <param name="role">Role this user is invited to. If more than one,
        /// returns the first. Possible values include: 'AccountAdmin',
        /// 'PropertyAdmin', 'FinanceManager', 'RevenueManager',
        /// 'ReservationOffice', 'FrontOffice', 'Housekeeping'</param>
        /// <param name="roles">Roles that user has access to</param>
        public InvitationModel(System.DateTime created, string email, string invitedBy, bool isAccountAdmin, IList<string> properties = default(IList<string>), string role = default(string), IList<string> roles = default(IList<string>))
        {
            Created = created;
            Email = email;
            InvitedBy = invitedBy;
            IsAccountAdmin = isAccountAdmin;
            Properties = properties;
            Role = role;
            Roles = roles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets date the invitation was made
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public System.DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets email address, used as the login
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets email of the user making the invitation
        /// </summary>
        [JsonProperty(PropertyName = "invitedBy")]
        public string InvitedBy { get; set; }

        /// <summary>
        /// Gets or sets if set to {true}, user has full access to all
        /// properties.
        /// </summary>
        [JsonProperty(PropertyName = "isAccountAdmin")]
        public bool IsAccountAdmin { get; set; }

        /// <summary>
        /// Gets or sets properties that user has access to
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public IList<string> Properties { get; set; }

        /// <summary>
        /// Gets or sets role this user is invited to. If more than one,
        /// returns the first. Possible values include: 'AccountAdmin',
        /// 'PropertyAdmin', 'FinanceManager', 'RevenueManager',
        /// 'ReservationOffice', 'FrontOffice', 'Housekeeping'
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        /// <summary>
        /// Gets or sets roles that user has access to
        /// </summary>
        [JsonProperty(PropertyName = "roles")]
        public IList<string> Roles { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Email == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Email");
            }
            if (InvitedBy == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InvitedBy");
            }
        }
    }
}
