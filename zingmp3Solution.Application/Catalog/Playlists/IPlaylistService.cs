using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using zingmp3Solution.Data.Entities;
using zingmp3Solution.Dtos.Catalog.Playlists;

namespace zingmp3Solution.Application.Catalog.Playlists
{
    public interface IPlaylistService
    {

        Task<Playlist> GetPlaylistByID(int id);

        // CRUD
        Task<int> Create(PlaylistCreateDto request);
        Task<int> Delete(int id);
        Task<int> Update(int id, PlaylistUpdateDto request);
    }
}
