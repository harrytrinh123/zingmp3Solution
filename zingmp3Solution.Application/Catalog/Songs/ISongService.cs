using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using zingmp3Solution.Dtos.Catalog.Songs;

namespace zingmp3Solution.Application.Catalog.Songs
{
    public interface ISongService
    {
        Task<List<SongDto>> GetTop10ZingChart();
        Task<List<SongDto>> GetTop100ZingChart();
        Task<List<SongDto>> GetTop5OfCategory(int categoryId);
        Task<List<SongDto>> GetTop30OfCategory(int categoryId);
        Task<SongAndCountLove> GetTop3ToShowChart();
        // CRUD
        Task<SongDto> GetSongById(int songId);
        Task<int> Create(SongCreateDto request);
        Task<int> Update(int songId, SongUpdateDto request);
        Task<int> Delete(int songId);
        Task AddLove(int songId);
        Task DeleteLove(int songId);
        Task AddListenCount(int songId);
    }
}
