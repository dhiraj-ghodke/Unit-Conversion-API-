using UnitConversionAPI.Enums;

namespace UnitConversionAPI.Models
{
    public class ConversionRequest
    {
        public ConversionType Type { get; set; }
        public string FromUnit { get; set; }
        public string ToUnit { get; set; }
        public double Value { get; set; }
    }
}
