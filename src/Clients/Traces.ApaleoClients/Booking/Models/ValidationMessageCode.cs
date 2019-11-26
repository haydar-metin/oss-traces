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
    /// Defines values for ValidationMessageCode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ValidationMessageCode
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
        [EnumMember(Value = "UnitMoved")]
        UnitMoved,
        [EnumMember(Value = "IncludedServicesAmountExceededRateAmount")]
        IncludedServicesAmountExceededRateAmount,
        [EnumMember(Value = "RatePlanCompanyRestrictionsViolated")]
        RatePlanCompanyRestrictionsViolated
    }
    internal static class ValidationMessageCodeEnumExtension
    {
        internal static string ToSerializedValue(this ValidationMessageCode? value)
        {
            return value == null ? null : ((ValidationMessageCode)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ValidationMessageCode value)
        {
            switch( value )
            {
                case ValidationMessageCode.UnitGroupFullyBooked:
                    return "UnitGroupFullyBooked";
                case ValidationMessageCode.UnitGroupCapacityExceeded:
                    return "UnitGroupCapacityExceeded";
                case ValidationMessageCode.RatePlanRestrictionsViolated:
                    return "RatePlanRestrictionsViolated";
                case ValidationMessageCode.RatePlanSurchargesNotSet:
                    return "RatePlanSurchargesNotSet";
                case ValidationMessageCode.RateRestrictionsViolated:
                    return "RateRestrictionsViolated";
                case ValidationMessageCode.RatePlanChannelNotSet:
                    return "RatePlanChannelNotSet";
                case ValidationMessageCode.RatesNotSet:
                    return "RatesNotSet";
                case ValidationMessageCode.BlockFullyBooked:
                    return "BlockFullyBooked";
                case ValidationMessageCode.UnitMoved:
                    return "UnitMoved";
                case ValidationMessageCode.IncludedServicesAmountExceededRateAmount:
                    return "IncludedServicesAmountExceededRateAmount";
                case ValidationMessageCode.RatePlanCompanyRestrictionsViolated:
                    return "RatePlanCompanyRestrictionsViolated";
            }
            return null;
        }

        internal static ValidationMessageCode? ParseValidationMessageCode(this string value)
        {
            switch( value )
            {
                case "UnitGroupFullyBooked":
                    return ValidationMessageCode.UnitGroupFullyBooked;
                case "UnitGroupCapacityExceeded":
                    return ValidationMessageCode.UnitGroupCapacityExceeded;
                case "RatePlanRestrictionsViolated":
                    return ValidationMessageCode.RatePlanRestrictionsViolated;
                case "RatePlanSurchargesNotSet":
                    return ValidationMessageCode.RatePlanSurchargesNotSet;
                case "RateRestrictionsViolated":
                    return ValidationMessageCode.RateRestrictionsViolated;
                case "RatePlanChannelNotSet":
                    return ValidationMessageCode.RatePlanChannelNotSet;
                case "RatesNotSet":
                    return ValidationMessageCode.RatesNotSet;
                case "BlockFullyBooked":
                    return ValidationMessageCode.BlockFullyBooked;
                case "UnitMoved":
                    return ValidationMessageCode.UnitMoved;
                case "IncludedServicesAmountExceededRateAmount":
                    return ValidationMessageCode.IncludedServicesAmountExceededRateAmount;
                case "RatePlanCompanyRestrictionsViolated":
                    return ValidationMessageCode.RatePlanCompanyRestrictionsViolated;
            }
            return null;
        }
    }
}
