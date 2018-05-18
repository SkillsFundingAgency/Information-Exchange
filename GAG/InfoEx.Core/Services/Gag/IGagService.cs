using System;
using GAG.Core.Domain.Gag;

namespace GAG.Core.Services.Gag
{
    public interface IGagService
    {
        /// <summary>
        /// Returns a summary of the Gag Totals
        /// </summary>
        /// <returns></returns>
        ProviderResultSummary GenerateGagStatement(string ukPrn, DateTime dateTime);

        /// <summary>
        /// Returns the period for a given date
        /// </summary>
        /// <param name="dateTime">Date time value</param>
        /// <returns>A single period</returns>
        Period GetPeriod(DateTime dateTime);

        /// <summary>
        /// Returns the calculations
        /// </summary>
        /// <param name="ukPrn"></param>
        /// <param name="period"></param>
        /// <param name="fundingStream"></param>
        /// <returns></returns>
        ProviderFundingStreamResult GetCalculations(string ukPrn, Period period, string fundingStream);
    }
}
