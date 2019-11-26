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
    /// Defines values for MinGuaranteeType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MinGuaranteeType
    {
        [EnumMember(Value = "PM6Hold")]
        PM6Hold,
        [EnumMember(Value = "CreditCard")]
        CreditCard,
        [EnumMember(Value = "Prepayment")]
        Prepayment,
        [EnumMember(Value = "Company")]
        Company
    }
    internal static class MinGuaranteeTypeEnumExtension
    {
        internal static string ToSerializedValue(this MinGuaranteeType? value)
        {
            return value == null ? null : ((MinGuaranteeType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this MinGuaranteeType value)
        {
            switch( value )
            {
                case MinGuaranteeType.PM6Hold:
                    return "PM6Hold";
                case MinGuaranteeType.CreditCard:
                    return "CreditCard";
                case MinGuaranteeType.Prepayment:
                    return "Prepayment";
                case MinGuaranteeType.Company:
                    return "Company";
            }
            return null;
        }

        internal static MinGuaranteeType? ParseMinGuaranteeType(this string value)
        {
            switch( value )
            {
                case "PM6Hold":
                    return MinGuaranteeType.PM6Hold;
                case "CreditCard":
                    return MinGuaranteeType.CreditCard;
                case "Prepayment":
                    return MinGuaranteeType.Prepayment;
                case "Company":
                    return MinGuaranteeType.Company;
            }
            return null;
        }
    }
}