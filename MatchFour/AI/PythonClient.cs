using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace MatchFour.AI
{
    public class PythonReply
    {
        public string reply {  get; set; }
    }

    public class PythonReplyAction
    {
        public int action { get; set; }
    }

    internal class PythonClient
    {
        private readonly HttpClient client = new();

        public async Task<string> SendTextAsync(string text)
        {
            var data = new {text = text};

            string json = JsonSerializer.Serialize(data);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("http://127.0.0.1:8000/echo", content);
            string responseJson = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<PythonReply>(responseJson);
            return result.reply;
        }

        public async Task<int> SendStateAndActions(string field, List<int> actions,int player, bool isProduction)
        {
            var data = new {player = player, field = field, actions = actions, isProduction = isProduction };
            string json = JsonSerializer.Serialize(data);

            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("http://127.0.0.1:8000/getAction", content);
            string responseJson = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(responseJson);
            
            var result = JsonSerializer.Deserialize<PythonReplyAction>(responseJson);
            return result.action;
        }

        public async Task SendReward(string field, int reward, int player)
        {
            var data = new {player = player, field = field, reward = reward };
            string json = JsonSerializer.Serialize(data);

            await SendWithoutResponse("updateHistory", json);
        }

        public async Task SendGameover() => await SendWithoutResponse("gameOver", "");
        
        public async Task SendLoadAi(string file1, string file2)
        {
            var data = new { pathP1 = file1, pathP2 = file2 };
            string json = JsonSerializer.Serialize(data);

            await SendWithoutResponse("load", json);
        }

        public async Task SendSaveAi(string file1, string file2)
        {
            var data = new { pathP1 = file1, pathP2 = file2 };
            string json = JsonSerializer.Serialize(data);

            await SendWithoutResponse("save", json);
        }

        private async Task SendWithoutResponse(string destination, string json)
        {
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            await client.PostAsync($"http://127.0.0.1:8000/{destination}", content);
        }
    }
}
