using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARobinsonMC3Two2Four_EndPnt.services
{
    public class WakeUpServices
    {
        public List<string> GreetingList = new();

        public string InputName(string name, string time)
        {
            return "Hello " + name + ", you woke up at " + time + " today!";
        }
    }
}