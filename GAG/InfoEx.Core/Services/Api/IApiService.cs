using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace GAG.Core.Services.Api
{
    public interface IApiService
    {
        /// <summary>
        /// Get a list of results
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="urlParams"></param>
        /// <returns></returns>
        List<T> GetRequest<T>(string urlParams);

        /// <summary>
        /// Get a single result
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="urlParams"></param>
        /// <returns></returns>
        T GetRequestSingle<T>(string urlParams);
    }
}
