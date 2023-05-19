using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace testdocker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        MyDbContext context;
        public WeatherForecastController(MyDbContext context)
        {
            this.context = context;
        }

        public IActionResult Get()
        {
            var users = context.Users;
            return Ok(users);
        }

    }
}

