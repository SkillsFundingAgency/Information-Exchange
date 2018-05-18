using System.Collections.Generic;

namespace GAG.Core.Domain.Gag
{
    public class ProviderResultSummary
    {
        public Period Period { get; set; }

        public Provider Provider { get; set; }

        public List<FundingStreamResults> FundingStreamResults { get; set; }
    }
}
