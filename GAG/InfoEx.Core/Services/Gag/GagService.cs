using System;
using System.Linq;
using GAG.Core.Domain.Gag;
using GAG.Core.Services.Api;

namespace GAG.Core.Services.Gag
{
    public class GagService : IGagService
    {
        private IApiService _apiService;

        public GagService(IApiService apiService)
        {
            _apiService = apiService;
        }

        public ProviderResultSummary GenerateGagStatement(string ukPrn, DateTime dateTime)
        {
            var period = GetPeriod(DateTime.Now);
            return GetGagStatementSummary(ukPrn, period);
        }

        private ProviderResultSummary GetGagStatementSummary(string ukPrn, Period period)
        {
            string urlParams = $"providers/{ukPrn}/periods/{period.PeriodId}/summary";

            return  _apiService.GetRequestSingle<ProviderResultSummary>(urlParams);
        }

        public Period GetPeriod(DateTime dateTime)
        {
            var period = _apiService.GetRequest<Period>("periods");

            return period.SingleOrDefault(x => DateTime.Parse(x.StartDate) <= dateTime  && DateTime.Parse(x.EndDate) >= dateTime);
        }

        public ProviderFundingStreamResult GetCalculations(string ukPrn, Period period, string fundingStream)
        {
            string urlParams = $"providers/{ukPrn}/periods/{period.PeriodId}/funding-streams/{fundingStream}/calculations";

            return _apiService.GetRequestSingle<ProviderFundingStreamResult>(urlParams);
        }
    }
}
