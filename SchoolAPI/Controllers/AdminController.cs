using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SchoolAPI.DataAccess;
using SchoolAPI.Interface;

namespace SchoolAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("AllowAllOrigins")]
    public class AdminController : Controller
    {
        private readonly DB_SchoolMgmtContext _context;
        private readonly IBllAboutUsOperations _IbllAboutUs;
        public AdminController(DB_SchoolMgmtContext context, IBllAboutUsOperations IbllAboutUsOperations)
        {
            _context = context;
            _IbllAboutUs = IbllAboutUsOperations;

        }
        [HttpGet("GetAboutUslistDetails")]
        public IActionResult GetAboutUslistDetails()
        {
            var aboutuslistdetails = _IbllAboutUs.GetAboutUsDetails();

            if (aboutuslistdetails.Any())
            {
                return Ok(new { aboutuslistdetails, msg = "about list" });
            }
            else
            {
                return BadRequest("No About Us Data");
            }
        }
    }
}
