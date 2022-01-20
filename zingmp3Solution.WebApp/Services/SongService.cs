using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using zingmp3Solution.Dtos.Catalog.Songs;

namespace zingmp3Solution.WebApp.Services
{
    public class SongService : ISongService
    {
        private readonly HttpClient _client;
        public SongService(HttpClient client)
        {
            _client = client;
        }

        public async Task<SongDto> Get(int songId)
        {
            string url = "https://localhost:44364/api/Songs/" + songId;
            var httpResponse = await _client.GetAsync(url);

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve tasks");
            }

            var content = await httpResponse.Content.ReadAsStringAsync();
            var item = JsonConvert.DeserializeObject<SongDto>(content);

            return item;
        }
    }
}
