using Microsoft.AspNetCore.Mvc;

namespace ARobinsonMC3Two2Four_EndPnt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Add2NumController : ControllerBase
    {
         public List<int> NumberList = new();
       public List<string> ResultList = new();

       [HttpPost]
       [Route("AddNums/{Num1}/{Num2}")] 
        public List<string> AddToNumList(int Num1,int Num2)
        {
            int sum = Num1 + Num2;
            ResultList.Add("The sum of " + Num1 + " and " + Num2 + " is " + sum + ".");
            return ResultList;
        }
    }
}