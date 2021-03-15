using API.Controllers;
using Application.Handlers.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Mega.Drive.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaleController : BaseController
    {

        [HttpGet, Route("GetActiveSales")]
        public IActionResult GetActiveSales(string culture = "")
        {
            return Ok(Mediator.Send(new GetActiveSalesQuery() { Culture = culture }));
        }
    }
}
