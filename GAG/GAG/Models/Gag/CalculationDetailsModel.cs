using System.Collections.Generic;
using GAG.Core.Domain.Gag;

namespace GAG.Models.Gag
{
    public class CalculationDetailsModel
    {
        public Period Period { get; set; }

        public Provider Provider { get; set; }

        public FundingStream FundingStream { get; set; }

        public List<PolicyResult> PolicyResults { get; set; }
    }
}