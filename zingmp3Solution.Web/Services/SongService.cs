using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using zingmp3Solution.Dtos.Catalog.Songs;

namespace zingmp3Solution.Web.Services
{
    public class SongService : ISongService
    {
        private readonly IHttpClientFactory _clientFactory;
        public SongService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<SongDto> Get(int songId)
        {
            string url = "https://localhost:44364/api/Songs/" + songId;
            var client = _clientFactory.CreateClient();
            HttpResponseMessage response = await client.GetAsync(url);
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<SongDto>(jsonString);
            }
            return null;
        }

        public async Task<List<SongDto>> GetTop10ZingChart()
        {
            var url = "https://localhost:44364/api/Songs/top10zingchart";
            HttpClient client = _clientFactory.CreateClient();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<SongDto>>(jsonString);
            }
            return null;
        }

        public async Task<List<SongDto>> GetTop5Cat(int categoryId)
        {
            var url = "https://localhost:44364/api/Songs/categories/top5/" + categoryId;
            HttpClient client = _clientFactory.CreateClient();
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<SongDto>>(jsonString);
            }
            return null;
        }
    }
}
