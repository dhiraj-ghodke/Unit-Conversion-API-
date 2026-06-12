using UnitConversionAPI.Enums;
using UnitConversionAPI.Models;

namespace UnitConversionAPI.Services
{
    public class ConversionService : IConversionService
    {
        public double Convert(ConversionRequest request)
        {
            return request.Type switch
            {
                ConversionType.Length => ConvertLength(request),
                ConversionType.Temperature => ConvertTemperature(request),
                ConversionType.Weight => ConvertWeight(request),
                _ => throw new Exception("Invalid conversion type")
            };
        }

        private double ConvertLength(ConversionRequest req)
        {
            var meters = req.FromUnit.ToLower() switch
            {
                "meter" => req.Value,
                "feet" => req.Value * 0.3048,
                _ => throw new Exception("Invalid length unit")
            };

            return req.ToUnit.ToLower() switch
            {
                "meter" => meters,
                "feet" => meters / 0.3048,
                _ => throw new Exception("Invalid length unit")
            };
        }

        private double ConvertTemperature(ConversionRequest req)
        {
            if (req.FromUnit == "celsius" && req.ToUnit == "fahrenheit")
                return (req.Value * 9 / 5) + 32;

            if (req.FromUnit == "fahrenheit" && req.ToUnit == "celsius")
                return (req.Value - 32) * 5 / 9;

            throw new Exception("Invalid temperature conversion");
        }

        private double ConvertWeight(ConversionRequest req)
        {
            var kg = req.FromUnit.ToLower() switch
            {
                "kg" => req.Value,
                "pound" => req.Value * 0.453592,
                _ => throw new Exception("Invalid weight unit")
            };

            return req.ToUnit.ToLower() switch
            {
                "kg" => kg,
                "pound" => kg / 0.453592,
                _ => throw new Exception("Invalid weight unit")
            };
        }
    }
}
