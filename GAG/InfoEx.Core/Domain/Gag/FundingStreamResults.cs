using System.Collections.Generic;

namespace GAG.Core.Domain.Gag
{
    public class FundingStreamResults
    {
        // public List<FundingStreamResultSummary> FundingStreamResultSummary { get; set; }

        public FundingStream FundingStream { get; set; }

        public double TotalAmount { get; set; }

        public List<AllocationResult> Allocations { get; set; }
    }
}
