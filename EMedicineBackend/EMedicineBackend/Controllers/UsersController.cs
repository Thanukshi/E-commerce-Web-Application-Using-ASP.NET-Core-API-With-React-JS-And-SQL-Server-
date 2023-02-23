using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EMedicineBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public UsersController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
