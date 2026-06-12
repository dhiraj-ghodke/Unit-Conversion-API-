using UnitConversionAPI.Models;

namespace UnitConversionAPI.Services
{
    public interface IConversionService
    {
        double Convert(ConversionRequest request);
    }
}
