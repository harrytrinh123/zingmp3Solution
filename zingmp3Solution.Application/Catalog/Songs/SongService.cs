using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using zingmp3Solution.Dtos.Catalog.Songs;

namespace zingmp3Solution.Application.Catalog.Songs
{
    public class SongService : ISongService
    {
        public Task AddListenCount()
        {
            throw new NotImplementedException();
        }

        public Task AddLove()
        {
            throw new NotImplementedException();
        }

        public Task<int> Create(SongDto request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int songId)
        {
            throw new NotImplementedException();
        }

        public Task DeleteLove()
        {
            throw new NotImplementedException();
        }

        public Task<SongDto> GetSongById(int songId)
        {
            throw new NotImplementedException();
        }

        public Task<List<SongDto>> GetTop100ZingChart()
        {
            throw new NotImplementedException();
        }

        public Task<List<SongDto>> GetTop10ZingChart()
        {
            throw new NotImplementedException();
        }

        public Task<List<SongDto>> GetTop30OfCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<SongAndCountLove> GetTop3ToShowChart()
        {
            throw new NotImplementedException();
        }

        public Task<List<SongDto>> GetTop5OfCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(SongDto request)
        {
            throw new NotImplementedException();
        }
    }
}
