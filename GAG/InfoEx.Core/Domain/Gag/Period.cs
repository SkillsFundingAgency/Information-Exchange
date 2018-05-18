using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace GAG.Core.Domain.Gag
{
    public class Period
    {
        [JsonProperty("periodType")]
        public string PeriodType { get; set; }

        [JsonProperty("periodId")]
        public string PeriodId { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }
    }
}
