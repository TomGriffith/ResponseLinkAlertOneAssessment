using Microsoft.AspNetCore.Mvc;
using ResponseLinkAlertOneAssessment.Authenticaton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResponseLinkAlertOneAssessment.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JwtController : Controller
    {
        [HttpGet]
        public IActionResult Jwt()
        {
            return new ObjectResult(new { token = JwtToken.GenerateJwtToken() });
        }
    }
}
