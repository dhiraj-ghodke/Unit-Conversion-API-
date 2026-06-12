using Microsoft.AspNetCore.Mvc;
using UnitConversionAPI.Models;
using UnitConversionAPI.Services;

namespace UnitConversionAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConversionController : ControllerBase
    {
        private readonly IConversionService _service;

        public ConversionController(IConversionService service)
        {
            _service = service;
        }

        [HttpPost]
        public IActionResult Convert([FromBody] ConversionRequest request)
        {
            try
            {
                var result = _service.Convert(request);

                return Ok(new
                {
                    Input = request.Value,
                    From = request.FromUnit,
                    To = request.ToUnit,
                    Result = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
