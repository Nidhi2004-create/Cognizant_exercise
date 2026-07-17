using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuthenticationDemo8.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles="Admin,POC")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(new string[]
            {
                "John",
                "Alice",
                "David"
            });
        }
    }
}