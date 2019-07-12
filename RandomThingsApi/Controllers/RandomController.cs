using Microsoft.AspNetCore.Mvc;

namespace RandomThingsApi.Controllers
{
    [Route("/api/v1")]
    public class RandomController : Controller
    {
        /// <summary>
        /// Retrieve Lunch
        /// </summary>
        /// <remarks>Yummy lunch!</remarks>
        /// <response code="200">Lunch is served</response>
        [HttpGet("lunch")]
        [ProducesResponseType(typeof(string), 200)]
        public IActionResult GetLunch()
        {
            return Ok("Looking for the lunch lady...");
        }

        /// <summary>
        /// Gets some meth
        /// </summary>
        /// <remarks>“Say my name.”</remarks>
        /// <response code="200">"La familia es todo"</response>
        [HttpGet("meth")]
        [ProducesResponseType(typeof(string), 200)]
        public IActionResult GetMeth()
        {
            return Ok("Calling Walter White...");
        }

        /// <summary>
        /// Buy some guns
        /// </summary>
        /// <remarks>“Oh, the new MP-5. Would you like a silencer for that?”</remarks>
        /// <response code="200">"Guns Guns Guns!!!"</response>
        [HttpGet("guns")]
        [ProducesResponseType(typeof(string), 200)]
        public IActionResult GetGuns()
        {
            return Ok("Finding Yuri Orlov...");
        }
    }
}
