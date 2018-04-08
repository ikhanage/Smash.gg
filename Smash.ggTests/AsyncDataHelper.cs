using System.Net.Http;
using Newtonsoft.Json;

namespace Smash.ggTests
{
    public class AsyncDataHelper
    {
        readonly HttpClient _client;
        public AsyncDataHelper()
        {
            _client = new HttpClient();
        }

        public T Deserialize<T>(string matchApiUrl)
        {
            var data = GetData(matchApiUrl);

            if (data == null) return default(T);

            return JsonConvert.DeserializeObject<T>(data);
        }

        private string GetData(string url)
        {
            var data = string.Empty;

            var apiTask = _client.GetAsync(url)
                .ContinueWith((task) => {
                    var response = task.Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        data = "Error";
                        return;
                    }

                    var readTask = response.Content.ReadAsStringAsync();
                    readTask.Wait();

                    data = readTask.Result;
                });

            apiTask.Wait();

            if (data.Equals("Error")) return null;

            return data;
        }
    }
}
