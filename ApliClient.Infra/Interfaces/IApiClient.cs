using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ApliClient.Infra.Impl;

namespace ApliClient.Infra.Interfaces
{
    public interface IApiClient
    {
        Task<RespostaServico<T>> PostAsync<T>(object item, string url, List<KeyValuePair<string, string>> headers);
        Task<RespostaServico<T>> GetAsync<T>(string url, List<KeyValuePair<string, string>> headers);
        Task<RespostaServico<T>> PutAsync<T>(object item, string url, List<KeyValuePair<string, string>> headers);
        Task<RespostaServico<T>> DeleteAsync<T>(object item, string url, List<KeyValuePair<string, string>> headers);
    }
}