using Microsoft.AspNetCore.Mvc;

namespace WebAPIIoT.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IoTController : Controller
    {
        IoTWebDataContext _context;
        public IoTController(IoTWebDataContext context) { 
            _context = context;
       
        }
        [HttpGet("GetDevices")]
        public IActionResult GetDevices()
        {
            var data = _context.Devices.ToList();
            return Ok(data);
        }
    }
    public class Device
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
