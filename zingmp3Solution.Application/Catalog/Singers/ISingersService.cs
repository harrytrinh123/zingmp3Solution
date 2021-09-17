using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using zingmp3Solution.Data.Entities;
using zingmp3Solution.Dtos.Catalog.Singers;

namespace zingmp3Solution.Application.Catalog.Singers
{
    public interface ISingersService
    {
        Task<List<Singer>> GetSinger();
        Task<Singer> GetSingerByID(int IDSinger);
        Task DeleteSinger(SingerDto singer);
        Task AddSingers(SingerDto singer);
        Task<SingerDto> EditSinger(int id, SingerEdit singer);
    }
}
