using System.Collections.Generic;

namespace GAG.Core.Domain.Gag
{
    public class ProviderFundingStreamResult
    {
        public Period Period { get;set;}

        public Provider Provider { get; set; }

        public FundingStream FundingStream { get; set; }

        public List<PolicyResult> PolicyResults { get; set; }
    }
}
