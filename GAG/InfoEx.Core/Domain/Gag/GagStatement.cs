namespace GAG.Core.Domain.Gag
{
    public class GagStatement
    {
        public string Ukprn { get; set; }

        public string Name { get; set; }

        public int FundingYearFrom { get; set; }

        public int FundingYearTo { get; set; }

        public Funding SchoolFunding { get; set; }
    }
}
