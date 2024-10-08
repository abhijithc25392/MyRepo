using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using HotelChainManagement.Commands;

namespace HotelChainManagement.Controllers
{
    /// <summary>
    /// Controller for managing hotel operations.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class HotelController : ControllerBase
    {
        private readonly ICreateHotelCommandHandler _createHotelCommandHandler;

        public HotelController(ICreateHotelCommandHandler createHotelCommandHandler)
        {
            _createHotelCommandHandler = createHotelCommandHandler;
        }

        /// <summary>
        /// Creates a new hotel.
        /// </summary>
        /// <param name="command">The create hotel command.</param>
        /// <returns>An <see cref="IActionResult"/> representing the result of the operation.</returns>
        [HttpPost]
        public async Task<IActionResult> CreateHotel([FromBody] CreateHotelCommand command)
        {
            if (command == null)
            {
                return BadRequest();
            }

            var result = await _createHotelCommandHandler.HandleAsync(command);
            if (result)
            {
                return Ok();
            }

            return StatusCode(500, "A problem happened while handling your request.");
        }
    }
}
