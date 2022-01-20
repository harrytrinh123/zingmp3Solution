using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zingmp3Solution.Dtos.Catalog.Songs;

namespace zingmp3Solution.WebApp.Services
{
    public interface ISongService
    {
        public Task<SongDto> Get(int songId);
    }
}
