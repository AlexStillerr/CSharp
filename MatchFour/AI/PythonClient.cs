using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MatchFour.AI
{
    public class PythonReply
    {
        public string reply {  get; set; }
    }

    internal class PythonClient
    {
        private readonly HttpClient client = new();

        public async Task<string> SendTextAsync(string text)
        {
            var data = new {text = text};

            string json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("http://127.0.0.1:8000/echo", content);
            string responseJson = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<PythonReply>(responseJson);
            return result.reply;
        }

    }
}
