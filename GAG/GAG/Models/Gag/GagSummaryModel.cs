using GAG.Core.Domain.Gag;

namespace GAG.Models.Gag
{
    public class GagSummaryModel : BaseModel
    {
        public ProviderResultSummary GagStatementSummary { get; set; }

        public SchoolFundingModel SchoolFundingModel { get; set; }
    }
}