using ARobinsonMC3Two2Four_EndPnt.services;
using Microsoft.AspNetCore.Mvc;

namespace ARobinsonMC3Two2Four_EndPnt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WakeUpController : ControllerBase
    {
        private readonly WakeUpServices _wakeUpServices;

        public WakeUpController(WakeUpServices wakeUpServices)
        {
            _wakeUpServices = wakeUpServices;
        }

        [HttpPost]
        [Route("InputName/{name}/{time}")]
        public List<string> InputName(string name, string time)
        {
            return _wakeUpServices.InputName(name,time);
        }
    }
}