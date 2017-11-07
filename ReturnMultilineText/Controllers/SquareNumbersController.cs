using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web;

namespace ReturnMultilineText.Controllers
{
    public class SquareNumbersController : ApiController
    {

        [HttpPost]
        public List<int> SquareNums(string txtString)
        {
            List<string> caseList = txtString.Split().ToList();
            List<int> intList = caseList.ConvertAll(int.Parse);
            List<int> ans = new List<int>();

            for (var i = 0; i < intList.Count; i++)
            {
                ans.Add((intList[i] * intList[i]));
            }
            return ans;
        }
    }
}
