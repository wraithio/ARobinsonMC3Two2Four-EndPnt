using Microsoft.AspNetCore.Mvc;

namespace ARobinsonMC3Two2Four_EndPnt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WakeUpController : ControllerBase
    {
        public List<string> GreetingList = new();

        [HttpPost]
        [Route("InputName/{name}/{time}")]
        public List<string> InputName(string name, string time)
        {
            GreetingList.Add("Hello " + name + ", you woke up at " + time + " today!");
            return GreetingList;
        }
    }
}