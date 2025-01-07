using Microsoft.AspNetCore.Mvc;

namespace ARobinsonMC3Two2Four_EndPnt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GtrThnLessThnController : ControllerBase
    {
    public List<string> ResultList = new();

    [HttpPost]
    [Route("GtrLssThn/{Num1}/{Num2}")] 
    public List<string> GtrLssThn(int Num1,int Num2)
        {
            if(Num1 < Num2)
            {
                 ResultList.Add(Num1 + " is less than " + Num2 + ".");
                 ResultList.Add(Num2 + " is greater than " + Num1 + ".");
            }
            if(Num1 > Num2)
            {
                 ResultList.Add(Num1 + " is greater than " + Num2 + ".");
                 ResultList.Add(Num2 + " is less than " + Num1 + ".");
            }
            if(Num1 == Num2)
            {
                ResultList.Add(Num1 + " is equal to " + Num2 + ".");
            }
            return ResultList;
        }
    }
}