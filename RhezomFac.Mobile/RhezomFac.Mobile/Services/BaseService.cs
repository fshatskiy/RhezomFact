using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RhezomFac.Mobile.Services
{
    public class BaseService
    {
        public string BaseUrl => "http://10.0.2.2:54733/api/"; // ip car emul android :redirect vers mon adr locale


        /// <summary>
        /// Gets httpClient.
        /// </summary>
        /// <returns>The hhtpClient.</returns>
        private HttpClient GetClient()
        {
            return GetClient(this.BaseUrl);
        }

        /// <summary>
        /// Gets httpClient from URL.
        /// </summary>
        /// <param name="baseUrl">The url.</param>
        /// <returns>The httpClient.</returns>
        private HttpClient GetClient(string baseUrl)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            return client;
        }

        /// <summary>
        /// Gets reponse from url.
        /// </summary>
        /// <typeparam name="T">The reponse type.</typeparam>
        /// <param name="url">The service url.</param>
        /// <returns>The service's reponse.</returns>
        protected async Task<T> Get<T>(string url)
        {
            using (HttpClient client = GetClient())
            {
                try
                {
                    var response = await client.GetAsync(url);
                    if (!response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        // TODO log.
                        throw new HttpRequestException();
                    }
                    else
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<T>(result);
                    }
                }
                catch (HttpRequestException ex)
                {
                    // TODO log.
                    throw;
                }
            }
        }

        /// <summary>
        /// Posts the data.
        /// </summary>
        /// <typeparam name="T">The response Type</typeparam>
        /// <typeparam name="M">The model Type</typeparam>
        /// <param name="url">The service url.</param>
        /// <param name="model">The model object.</param>
        /// <returns>The response.</returns>
        /// task = thread
        protected async Task<T> Post<T, M>(string url, M model)
        {
            var content = JsonConvert.SerializeObject(model);
            HttpContent contentPost = new StringContent(content, Encoding.UTF8, "application/json");
            using (HttpClient client =GetClient())
            {
                try
                {
                    var response = await client.PostAsync(url, contentPost);

                    if (!response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        // TODO Log.
                        return default(T);
                    }
                    else
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<T>(result);
                    }
                }
                catch (Exception exp)
                {
                    // TODO log.
                    return default(T);
                }
            }
        }
    }
}
