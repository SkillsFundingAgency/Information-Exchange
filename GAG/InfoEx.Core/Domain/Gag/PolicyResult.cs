using System.Collections.Generic;

namespace GAG.Core.Domain.Gag
{
    public class PolicyResult
    {
        public Policy Policy { get; set; }

        public List<CalculationResult> Calculations { get; set; }

    }
}
