using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using zingmp3Solution.Data.EF;
using zingmp3Solution.Data.Entities;
using zingmp3Solution.Dtos.Catalog.Playlists;

namespace zingmp3Solution.Application.Catalog.Playlists
{
    public class PlaylistService : IPlaylistService
    {
        private readonly ZingMp3DbContext _context;

        public PlaylistService(ZingMp3DbContext context)
        {
            _context = context;
        }

        public async Task<int> Create(PlaylistCreateDto request)
        {
            var playlist = new Playlist()
            {
                Name = request.Name,
                IsPublic = request.IsPublic,
                IsRandom = request.IsRandom,
                Image = request.Image
            };

            _context.Playlists.Add(playlist);
            await _context.SaveChangesAsync();
            return playlist.Id;
        }

        public async Task<int> Delete(int playlistId)
        {
            var playlist = await _context.Playlists.FindAsync(playlistId);
            if (playlist == null) throw new Exception($"Can not find playlist with id: { playlistId}");

            _context.Playlists.Remove(playlist);
            return await _context.SaveChangesAsync();
        }

        public async Task<Playlist> GetPlaylistByID(int id)
        {
            return await _context.Playlists.FindAsync(id);
        }

        public async Task<int> Update(int id, PlaylistUpdateDto request)
        {
            var song = await _context.Playlists.FindAsync(id);

            song.Name = request.Name;
            song.IsPublic = request.IsPublic;
            song.IsRandom = request.IsRandom;
            song.Image = request.Image;

            return await _context.SaveChangesAsync();
        }
    }
}
