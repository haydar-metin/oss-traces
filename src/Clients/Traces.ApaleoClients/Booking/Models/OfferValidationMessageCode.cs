// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Traces.ApaleoClients.Booking.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for OfferValidationMessageCode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OfferValidationMessageCode
    {
        [EnumMember(Value = "UnitGroupFullyBooked")]
        UnitGroupFullyBooked,
        [EnumMember(Value = "UnitGroupCapacityExceeded")]
        UnitGroupCapacityExceeded,
        [EnumMember(Value = "RatePlanRestrictionsViolated")]
        RatePlanRestrictionsViolated,
        [EnumMember(Value = "RatePlanSurchargesNotSet")]
        RatePlanSurchargesNotSet,
        [EnumMember(Value = "RateRestrictionsViolated")]
        RateRestrictionsViolated,
        [EnumMember(Value = "RatePlanChannelNotSet")]
        RatePlanChannelNotSet,
        [EnumMember(Value = "RatesNotSet")]
        RatesNotSet,
        [EnumMember(Value = "BlockFullyBooked")]
        BlockFullyBooked,
        [EnumMember(Value = "IncludedServicesAmountExceededRateAmount")]
        IncludedServicesAmountExceededRateAmount
    }
    internal static class OfferValidationMessageCodeEnumExtension
    {
        internal static string ToSerializedValue(this OfferValidationMessageCode? value)
        {
            return value == null ? null : ((OfferValidationMessageCode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this OfferValidationMessageCode value)
        {
            switch( value )
            {
                case OfferValidationMessageCode.UnitGroupFullyBooked:
                    return "UnitGroupFullyBooked";
                case OfferValidationMessageCode.UnitGroupCapacityExceeded:
                    return "UnitGroupCapacityExceeded";
                case OfferValidationMessageCode.RatePlanRestrictionsViolated:
                    return "RatePlanRestrictionsViolated";
                case OfferValidationMessageCode.RatePlanSurchargesNotSet:
                    return "RatePlanSurchargesNotSet";
                case OfferValidationMessageCode.RateRestrictionsViolated:
                    return "RateRestrictionsViolated";
                case OfferValidationMessageCode.RatePlanChannelNotSet:
                    return "RatePlanChannelNotSet";
                case OfferValidationMessageCode.RatesNotSet:
                    return "RatesNotSet";
                case OfferValidationMessageCode.BlockFullyBooked:
                    return "BlockFullyBooked";
                case OfferValidationMessageCode.IncludedServicesAmountExceededRateAmount:
                    return "IncludedServicesAmountExceededRateAmount";
            }
            return null;
        }

        internal static OfferValidationMessageCode? ParseOfferValidationMessageCode(this string value)
        {
            switch( value )
            {
                case "UnitGroupFullyBooked":
                    return OfferValidationMessageCode.UnitGroupFullyBooked;
                case "UnitGroupCapacityExceeded":
                    return OfferValidationMessageCode.UnitGroupCapacityExceeded;
                case "RatePlanRestrictionsViolated":
                    return OfferValidationMessageCode.RatePlanRestrictionsViolated;
                case "RatePlanSurchargesNotSet":
                    return OfferValidationMessageCode.RatePlanSurchargesNotSet;
                case "RateRestrictionsViolated":
                    return OfferValidationMessageCode.RateRestrictionsViolated;
                case "RatePlanChannelNotSet":
                    return OfferValidationMessageCode.RatePlanChannelNotSet;
                case "RatesNotSet":
                    return OfferValidationMessageCode.RatesNotSet;
                case "BlockFullyBooked":
                    return OfferValidationMessageCode.BlockFullyBooked;
                case "IncludedServicesAmountExceededRateAmount":
                    return OfferValidationMessageCode.IncludedServicesAmountExceededRateAmount;
            }
            return null;
        }
    }
}