using MockAPI.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace MockAPI.Controllers
{
    public class GagAPIController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<SummaryApiModel> Get()
        {
            SummaryApiModel[] summaryList = new SummaryApiModel[]
            {
                new SummaryApiModel() { HighNeedsFundTotal=333999888 }
            };

            return summaryList;
        }
    }
}