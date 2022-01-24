using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zingmp3Solution.Dtos.Catalog.Songs;

namespace zingmp3Solution.Web.Services
{
    public interface ISongService
    {
        public Task<SongDto> Get(int songId);
        public Task<List<SongDto>> GetTop10ZingChart();
        public Task<List<SongDto>> GetTop5Cat(int categoryId);
    }
}
