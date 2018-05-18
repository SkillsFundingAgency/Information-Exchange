using System.Collections.Generic;
using GAG.Core.Domain.Gag;

namespace GAG.Models.Gag
{
    public class SchoolFundingModel : BaseModel
    {
        public List<FundingStreamResults> Allocations { get; set; }
    }
}