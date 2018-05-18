using System;
using System.Linq;
using System.Web.Mvc;
using GAG.Core.Domain.Gag;
using GAG.Core.Services.Gag;
using GAG.Models.Gag;

namespace GAG.Controllers
{
    public class GagController : Controller
    {
        private readonly IGagService _gagService;

        public GagController(IGagService gagService)
        {
            _gagService = gagService;
        }

        public ActionResult Summary()
        {
            string ukPrn = "10033799";

            var gagStatment = _gagService.GenerateGagStatement(ukPrn, new DateTime());
            
            var model = new GagSummaryModel
            {
                GagStatementSummary = gagStatment,
                SchoolFundingModel = new SchoolFundingModel
                {
                    Allocations = gagStatment.FundingStreamResults
                },
                ukPrnNo = ukPrn
            };

            model.GagStatementSummary.Period.StartDate =
                DateTime.Parse(model.GagStatementSummary.Period.StartDate).Year.ToString();
            model.GagStatementSummary.Period.EndDate =
                DateTime.Parse(model.GagStatementSummary.Period.EndDate).Year.ToString();

            return View(model);
        }

        // Replace fundingStreamCode with 
        public ActionResult Details(string ukPrn, Period period, string fundingStream)
        {
            ukPrn = "10033799";
            period.PeriodId = "2017181";
            fundingStream = "YPLRE";

            var detail = _gagService.GetCalculations(ukPrn, period, fundingStream);

            var model = new CalculationDetailsModel
            {
                Period = detail.Period,
                Provider = detail.Provider,
                FundingStream = detail.FundingStream
            };

            return View(model);
        }
    }
}