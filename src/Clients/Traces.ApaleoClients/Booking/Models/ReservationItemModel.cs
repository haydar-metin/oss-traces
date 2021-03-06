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

    public partial class ReservationItemModel
    {
        /// <summary>
        /// Initializes a new instance of the ReservationItemModel class.
        /// </summary>
        public ReservationItemModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReservationItemModel class.
        /// </summary>
        /// <param name="adults">Number of adults</param>
        /// <param name="arrival">Date of arrival&lt;br /&gt;Specify a date and
        /// time (without fractional second part) in UTC or with UTC offset as
        /// defined in &lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO8601:2004&lt;/a&gt;</param>
        /// <param name="balance">The balance of this reservation.</param>
        /// <param name="bookingId">Booking id</param>
        /// <param name="cancellationFee">Details about the cancellation fee
        /// for this reservation</param>
        /// <param name="channelCode">Channel code. Possible values include:
        /// 'Direct', 'BookingCom', 'Ibe', 'ChannelManager', 'Expedia'</param>
        /// <param name="created">Date of creation&lt;br /&gt;Specify a date
        /// and time (without fractional second part) in UTC or with UTC offset
        /// as defined in &lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO8601:2004&lt;/a&gt;</param>
        /// <param name="departure">Date of departure&lt;br /&gt;Specify a date
        /// and time (without fractional second part) in UTC or with UTC offset
        /// as defined in &lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO8601:2004&lt;/a&gt;</param>
        /// <param name="guaranteeType">The strongest guarantee for the rate
        /// plans booked in this reservation. Possible values include:
        /// 'PM6Hold', 'CreditCard', 'Prepayment', 'Company', 'Ota'</param>
        /// <param name="hasCityTax">Whether the city tax has already been
        /// added to the reservation. Set to false, if the property does not
        /// have city tax configured</param>
        /// <param name="id">Reservation id</param>
        /// <param name="modified">Date of last modification&lt;br /&gt;Specify
        /// a date and time (without fractional second part) in UTC or with UTC
        /// offset as defined in &lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO8601:2004&lt;/a&gt;</param>
        /// <param name="noShowFee">Details about the no-show fee for this
        /// reservation</param>
        /// <param name="primaryGuest">The primary guest of the
        /// reservation</param>
        /// <param name="property">The property</param>
        /// <param name="ratePlan">The rate plan</param>
        /// <param name="status">Status of the reservation. Possible values
        /// include: 'Confirmed', 'InHouse', 'CheckedOut', 'Canceled',
        /// 'NoShow'</param>
        /// <param name="totalGrossAmount">Total amount</param>
        /// <param name="unitGroup">The unit group</param>
        /// <param name="actions">The list of actions for this
        /// reservation</param>
        /// <param name="additionalGuests">Additional guests of the
        /// reservation.</param>
        /// <param name="allFoliosHaveInvoice">Whether all folios of a
        /// reservation have an invoice</param>
        /// <param name="assignedUnits">The list of units assigned to this
        /// reservation</param>
        /// <param name="blockId">Block id</param>
        /// <param name="booker">The person who made the booking</param>
        /// <param name="cancellationTime">Time of cancellation, if the
        /// reservation was canceled&lt;br /&gt;Specify a date and time
        /// (without fractional second part) in UTC or with UTC offset as
        /// defined in &lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO8601:2004&lt;/a&gt;</param>
        /// <param name="checkInTime">Time of check-in&lt;br /&gt;Specify a
        /// date and time (without fractional second part) in UTC or with UTC
        /// offset as defined in &lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO8601:2004&lt;/a&gt;</param>
        /// <param name="checkOutTime">Time of check-out&lt;br /&gt;Specify a
        /// date and time (without fractional second part) in UTC or with UTC
        /// offset as defined in &lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO8601:2004&lt;/a&gt;</param>
        /// <param name="childrenAges">The ages of the children</param>
        /// <param name="cityTax">The amount of city tax that can be charged
        /// for this reservation</param>
        /// <param name="comment">Additional information and comments</param>
        /// <param name="commission">The information about the OTA
        /// commission.</param>
        /// <param name="company">Company for this reservation.</param>
        /// <param name="corporateCode">Corporate code provided during
        /// creation. Used to find offers during amend.</param>
        /// <param name="externalCode">Code in external system</param>
        /// <param name="guestComment">Additional information and comment by
        /// the guest</param>
        /// <param name="noShowTime">Time of setting no-show reservation
        /// status&lt;br /&gt;Specify a date and time (without fractional
        /// second part) in UTC or with UTC offset as defined in &lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&gt;ISO8601:2004&lt;/a&gt;</param>
        /// <param name="paymentAccount">Payment information</param>
        /// <param name="services">The list of additional services (extras,
        /// add-ons) reserved for the stay</param>
        /// <param name="source">Source of the reservation (e.g Hotels.com,
        /// Orbitz, etc.)</param>
        /// <param name="timeSlices">The list of time slices with the reserved
        /// units / unit groups for the stay</param>
        /// <param name="travelPurpose">The purpose of the trip, leisure or
        /// business. Possible values include: 'Business', 'Leisure'</param>
        /// <param name="unit">The unit</param>
        /// <param name="validationMessages">Validation rules are applied to
        /// reservations during their lifetime.
        /// For example a reservation that was created while the house or unit
        /// group is already fully booked.
        /// Whenever a rule was or is currently violated, a validation message
        /// will be added to this list.
        /// They can be deleted whenever the hotel staff worked them
        /// off.</param>
        public ReservationItemModel(int adults, System.DateTime arrival, MonetaryValueModel balance, string bookingId, ReservationCancellationFeeModel cancellationFee, ChannelCode channelCode, System.DateTime created, System.DateTime departure, GuaranteeType guaranteeType, bool hasCityTax, string id, System.DateTime modified, ReservationNoShowFeeModel noShowFee, GuestModel primaryGuest, EmbeddedPropertyModel property, EmbeddedRatePlanModel ratePlan, ReservationStatus status, MonetaryValueModel totalGrossAmount, EmbeddedUnitGroupModel unitGroup, IList<ActionModelReservationActionNotAllowedReservationActionReason> actions = default(IList<ActionModelReservationActionNotAllowedReservationActionReason>), IList<GuestModel> additionalGuests = default(IList<GuestModel>), bool? allFoliosHaveInvoice = default(bool?), IList<ReservationAssignedUnitModel> assignedUnits = default(IList<ReservationAssignedUnitModel>), string blockId = default(string), BookerModel booker = default(BookerModel), System.DateTime? cancellationTime = default(System.DateTime?), System.DateTime? checkInTime = default(System.DateTime?), System.DateTime? checkOutTime = default(System.DateTime?), IList<int?> childrenAges = default(IList<int?>), AmountModel cityTax = default(AmountModel), string comment = default(string), CommissionModel commission = default(CommissionModel), EmbeddedCompanyModel company = default(EmbeddedCompanyModel), string corporateCode = default(string), string externalCode = default(string), string guestComment = default(string), System.DateTime? noShowTime = default(System.DateTime?), PaymentAccountModel paymentAccount = default(PaymentAccountModel), IList<ReservationServiceItemModel> services = default(IList<ReservationServiceItemModel>), string source = default(string), IList<TimeSliceModel> timeSlices = default(IList<TimeSliceModel>), string travelPurpose = default(string), EmbeddedUnitModel unit = default(EmbeddedUnitModel), IList<ReservationValidationMessageModel> validationMessages = default(IList<ReservationValidationMessageModel>))
        {
            Actions = actions;
            AdditionalGuests = additionalGuests;
            Adults = adults;
            AllFoliosHaveInvoice = allFoliosHaveInvoice;
            Arrival = arrival;
            AssignedUnits = assignedUnits;
            Balance = balance;
            BlockId = blockId;
            Booker = booker;
            BookingId = bookingId;
            CancellationFee = cancellationFee;
            CancellationTime = cancellationTime;
            ChannelCode = channelCode;
            CheckInTime = checkInTime;
            CheckOutTime = checkOutTime;
            ChildrenAges = childrenAges;
            CityTax = cityTax;
            Comment = comment;
            Commission = commission;
            Company = company;
            CorporateCode = corporateCode;
            Created = created;
            Departure = departure;
            ExternalCode = externalCode;
            GuaranteeType = guaranteeType;
            GuestComment = guestComment;
            HasCityTax = hasCityTax;
            Id = id;
            Modified = modified;
            NoShowFee = noShowFee;
            NoShowTime = noShowTime;
            PaymentAccount = paymentAccount;
            PrimaryGuest = primaryGuest;
            Property = property;
            RatePlan = ratePlan;
            Services = services;
            Source = source;
            Status = status;
            TimeSlices = timeSlices;
            TotalGrossAmount = totalGrossAmount;
            TravelPurpose = travelPurpose;
            Unit = unit;
            UnitGroup = unitGroup;
            ValidationMessages = validationMessages;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the list of actions for this reservation
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        public IList<ActionModelReservationActionNotAllowedReservationActionReason> Actions { get; set; }

        /// <summary>
        /// Gets or sets additional guests of the reservation.
        /// </summary>
        [JsonProperty(PropertyName = "additionalGuests")]
        public IList<GuestModel> AdditionalGuests { get; set; }

        /// <summary>
        /// Gets or sets number of adults
        /// </summary>
        [JsonProperty(PropertyName = "adults")]
        public int Adults { get; set; }

        /// <summary>
        /// Gets or sets whether all folios of a reservation have an invoice
        /// </summary>
        [JsonProperty(PropertyName = "allFoliosHaveInvoice")]
        public bool? AllFoliosHaveInvoice { get; set; }

        /// <summary>
        /// Gets or sets date of arrival&amp;lt;br /&amp;gt;Specify a date and
        /// time (without fractional second part) in UTC or with UTC offset as
        /// defined in &amp;lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&amp;gt;ISO8601:2004&amp;lt;/a&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "arrival")]
        public System.DateTime Arrival { get; set; }

        /// <summary>
        /// Gets or sets the list of units assigned to this reservation
        /// </summary>
        [JsonProperty(PropertyName = "assignedUnits")]
        public IList<ReservationAssignedUnitModel> AssignedUnits { get; set; }

        /// <summary>
        /// Gets or sets the balance of this reservation.
        /// </summary>
        [JsonProperty(PropertyName = "balance")]
        public MonetaryValueModel Balance { get; set; }

        /// <summary>
        /// Gets or sets block id
        /// </summary>
        [JsonProperty(PropertyName = "blockId")]
        public string BlockId { get; set; }

        /// <summary>
        /// Gets or sets the person who made the booking
        /// </summary>
        [JsonProperty(PropertyName = "booker")]
        public BookerModel Booker { get; set; }

        /// <summary>
        /// Gets or sets booking id
        /// </summary>
        [JsonProperty(PropertyName = "bookingId")]
        public string BookingId { get; set; }

        /// <summary>
        /// Gets or sets details about the cancellation fee for this
        /// reservation
        /// </summary>
        [JsonProperty(PropertyName = "cancellationFee")]
        public ReservationCancellationFeeModel CancellationFee { get; set; }

        /// <summary>
        /// Gets or sets time of cancellation, if the reservation was
        /// canceled&amp;lt;br /&amp;gt;Specify a date and time (without
        /// fractional second part) in UTC or with UTC offset as defined in
        /// &amp;lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&amp;gt;ISO8601:2004&amp;lt;/a&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "cancellationTime")]
        public System.DateTime? CancellationTime { get; set; }

        /// <summary>
        /// Gets or sets channel code. Possible values include: 'Direct',
        /// 'BookingCom', 'Ibe', 'ChannelManager', 'Expedia'
        /// </summary>
        [JsonProperty(PropertyName = "channelCode")]
        public ChannelCode ChannelCode { get; set; }

        /// <summary>
        /// Gets or sets time of check-in&amp;lt;br /&amp;gt;Specify a date and
        /// time (without fractional second part) in UTC or with UTC offset as
        /// defined in &amp;lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&amp;gt;ISO8601:2004&amp;lt;/a&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "checkInTime")]
        public System.DateTime? CheckInTime { get; set; }

        /// <summary>
        /// Gets or sets time of check-out&amp;lt;br /&amp;gt;Specify a date
        /// and time (without fractional second part) in UTC or with UTC offset
        /// as defined in &amp;lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&amp;gt;ISO8601:2004&amp;lt;/a&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "checkOutTime")]
        public System.DateTime? CheckOutTime { get; set; }

        /// <summary>
        /// Gets or sets the ages of the children
        /// </summary>
        [JsonProperty(PropertyName = "childrenAges")]
        public IList<int?> ChildrenAges { get; set; }

        /// <summary>
        /// Gets or sets the amount of city tax that can be charged for this
        /// reservation
        /// </summary>
        [JsonProperty(PropertyName = "cityTax")]
        public AmountModel CityTax { get; set; }

        /// <summary>
        /// Gets or sets additional information and comments
        /// </summary>
        [JsonProperty(PropertyName = "comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the information about the OTA commission.
        /// </summary>
        [JsonProperty(PropertyName = "commission")]
        public CommissionModel Commission { get; set; }

        /// <summary>
        /// Gets or sets company for this reservation.
        /// </summary>
        [JsonProperty(PropertyName = "company")]
        public EmbeddedCompanyModel Company { get; set; }

        /// <summary>
        /// Gets or sets corporate code provided during creation. Used to find
        /// offers during amend.
        /// </summary>
        [JsonProperty(PropertyName = "corporateCode")]
        public string CorporateCode { get; set; }

        /// <summary>
        /// Gets or sets date of creation&amp;lt;br /&amp;gt;Specify a date and
        /// time (without fractional second part) in UTC or with UTC offset as
        /// defined in &amp;lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&amp;gt;ISO8601:2004&amp;lt;/a&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public System.DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets date of departure&amp;lt;br /&amp;gt;Specify a date
        /// and time (without fractional second part) in UTC or with UTC offset
        /// as defined in &amp;lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&amp;gt;ISO8601:2004&amp;lt;/a&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "departure")]
        public System.DateTime Departure { get; set; }

        /// <summary>
        /// Gets or sets code in external system
        /// </summary>
        [JsonProperty(PropertyName = "externalCode")]
        public string ExternalCode { get; set; }

        /// <summary>
        /// Gets or sets the strongest guarantee for the rate plans booked in
        /// this reservation. Possible values include: 'PM6Hold', 'CreditCard',
        /// 'Prepayment', 'Company', 'Ota'
        /// </summary>
        [JsonProperty(PropertyName = "guaranteeType")]
        public GuaranteeType GuaranteeType { get; set; }

        /// <summary>
        /// Gets or sets additional information and comment by the guest
        /// </summary>
        [JsonProperty(PropertyName = "guestComment")]
        public string GuestComment { get; set; }

        /// <summary>
        /// Gets or sets whether the city tax has already been added to the
        /// reservation. Set to false, if the property does not have city tax
        /// configured
        /// </summary>
        [JsonProperty(PropertyName = "hasCityTax")]
        public bool HasCityTax { get; set; }

        /// <summary>
        /// Gets or sets reservation id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets date of last modification&amp;lt;br /&amp;gt;Specify a
        /// date and time (without fractional second part) in UTC or with UTC
        /// offset as defined in &amp;lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&amp;gt;ISO8601:2004&amp;lt;/a&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "modified")]
        public System.DateTime Modified { get; set; }

        /// <summary>
        /// Gets or sets details about the no-show fee for this reservation
        /// </summary>
        [JsonProperty(PropertyName = "noShowFee")]
        public ReservationNoShowFeeModel NoShowFee { get; set; }

        /// <summary>
        /// Gets or sets time of setting no-show reservation status&amp;lt;br
        /// /&amp;gt;Specify a date and time (without fractional second part)
        /// in UTC or with UTC offset as defined in &amp;lt;a
        /// href="https://en.wikipedia.org/wiki/ISO_8601"&amp;gt;ISO8601:2004&amp;lt;/a&amp;gt;
        /// </summary>
        [JsonProperty(PropertyName = "noShowTime")]
        public System.DateTime? NoShowTime { get; set; }

        /// <summary>
        /// Gets or sets payment information
        /// </summary>
        [JsonProperty(PropertyName = "paymentAccount")]
        public PaymentAccountModel PaymentAccount { get; set; }

        /// <summary>
        /// Gets or sets the primary guest of the reservation
        /// </summary>
        [JsonProperty(PropertyName = "primaryGuest")]
        public GuestModel PrimaryGuest { get; set; }

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
        /// Gets or sets the list of additional services (extras, add-ons)
        /// reserved for the stay
        /// </summary>
        [JsonProperty(PropertyName = "services")]
        public IList<ReservationServiceItemModel> Services { get; set; }

        /// <summary>
        /// Gets or sets source of the reservation (e.g Hotels.com, Orbitz,
        /// etc.)
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets status of the reservation. Possible values include:
        /// 'Confirmed', 'InHouse', 'CheckedOut', 'Canceled', 'NoShow'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public ReservationStatus Status { get; set; }

        /// <summary>
        /// Gets or sets the list of time slices with the reserved units / unit
        /// groups for the stay
        /// </summary>
        [JsonProperty(PropertyName = "timeSlices")]
        public IList<TimeSliceModel> TimeSlices { get; set; }

        /// <summary>
        /// Gets or sets total amount
        /// </summary>
        [JsonProperty(PropertyName = "totalGrossAmount")]
        public MonetaryValueModel TotalGrossAmount { get; set; }

        /// <summary>
        /// Gets or sets the purpose of the trip, leisure or business. Possible
        /// values include: 'Business', 'Leisure'
        /// </summary>
        [JsonProperty(PropertyName = "travelPurpose")]
        public string TravelPurpose { get; set; }

        /// <summary>
        /// Gets or sets the unit
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public EmbeddedUnitModel Unit { get; set; }

        /// <summary>
        /// Gets or sets the unit group
        /// </summary>
        [JsonProperty(PropertyName = "unitGroup")]
        public EmbeddedUnitGroupModel UnitGroup { get; set; }

        /// <summary>
        /// Gets or sets validation rules are applied to reservations during
        /// their lifetime.
        /// For example a reservation that was created while the house or unit
        /// group is already fully booked.
        /// Whenever a rule was or is currently violated, a validation message
        /// will be added to this list.
        /// They can be deleted whenever the hotel staff worked them off.
        /// </summary>
        [JsonProperty(PropertyName = "validationMessages")]
        public IList<ReservationValidationMessageModel> ValidationMessages { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Balance == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Balance");
            }
            if (BookingId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BookingId");
            }
            if (CancellationFee == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CancellationFee");
            }
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (NoShowFee == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NoShowFee");
            }
            if (PrimaryGuest == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PrimaryGuest");
            }
            if (Property == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Property");
            }
            if (RatePlan == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RatePlan");
            }
            if (TotalGrossAmount == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TotalGrossAmount");
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
            if (AdditionalGuests != null)
            {
                foreach (var element1 in AdditionalGuests)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (AssignedUnits != null)
            {
                foreach (var element2 in AssignedUnits)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (Balance != null)
            {
                Balance.Validate();
            }
            if (Booker != null)
            {
                Booker.Validate();
            }
            if (CancellationFee != null)
            {
                CancellationFee.Validate();
            }
            if (CityTax != null)
            {
                CityTax.Validate();
            }
            if (Commission != null)
            {
                Commission.Validate();
            }
            if (Company != null)
            {
                Company.Validate();
            }
            if (NoShowFee != null)
            {
                NoShowFee.Validate();
            }
            if (PaymentAccount != null)
            {
                PaymentAccount.Validate();
            }
            if (PrimaryGuest != null)
            {
                PrimaryGuest.Validate();
            }
            if (Property != null)
            {
                Property.Validate();
            }
            if (RatePlan != null)
            {
                RatePlan.Validate();
            }
            if (Services != null)
            {
                foreach (var element3 in Services)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
            if (TimeSlices != null)
            {
                foreach (var element4 in TimeSlices)
                {
                    if (element4 != null)
                    {
                        element4.Validate();
                    }
                }
            }
            if (TotalGrossAmount != null)
            {
                TotalGrossAmount.Validate();
            }
            if (Unit != null)
            {
                Unit.Validate();
            }
            if (UnitGroup != null)
            {
                UnitGroup.Validate();
            }
            if (ValidationMessages != null)
            {
                foreach (var element5 in ValidationMessages)
                {
                    if (element5 != null)
                    {
                        element5.Validate();
                    }
                }
            }
        }
    }
}
