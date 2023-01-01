// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace RedWolf.API.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for IndicatorType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IndicatorType
    {
        [EnumMember(Value = "FileIndicator")]
        FileIndicator,
        [EnumMember(Value = "NetworkIndicator")]
        NetworkIndicator,
        [EnumMember(Value = "TargetIndicator")]
        TargetIndicator
    }
    internal static class IndicatorTypeEnumExtension
    {
        internal static string ToSerializedValue(this IndicatorType? value)
        {
            return value == null ? null : ((IndicatorType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this IndicatorType value)
        {
            switch( value )
            {
                case IndicatorType.FileIndicator:
                    return "FileIndicator";
                case IndicatorType.NetworkIndicator:
                    return "NetworkIndicator";
                case IndicatorType.TargetIndicator:
                    return "TargetIndicator";
            }
            return null;
        }

        internal static IndicatorType? ParseIndicatorType(this string value)
        {
            switch( value )
            {
                case "FileIndicator":
                    return IndicatorType.FileIndicator;
                case "NetworkIndicator":
                    return IndicatorType.NetworkIndicator;
                case "TargetIndicator":
                    return IndicatorType.TargetIndicator;
            }
            return null;
        }
    }
}