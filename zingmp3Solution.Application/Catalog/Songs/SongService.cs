using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zingmp3Solution.Data.EF;
using zingmp3Solution.Dtos.Catalog.Songs;

namespace zingmp3Solution.Application.Catalog.Songs
{
    public class SongService : ISongService
    {
        private readonly ZingMp3DbContext _context;
        public SongService(ZingMp3DbContext context)
        {
            _context = context;
        }
        public async Task AddListenCount(int songId)
        {
            var song = await _context.Songs.FindAsync(songId);
            song.ListenCount += 1;
            await _context.SaveChangesAsync();
        }

        public async Task AddLove(int songId)
        {
            var song = await _context.Songs.FindAsync(songId);
            song.ListenCount += 1;
            await _context.SaveChangesAsync();
        }

        public async Task<int> Create(SongDto request)
        {
            _context.Add(request);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int songId)
        {
            var song = await _context.Songs.FindAsync(songId);
            if (song == null) throw new Exception($"Can not find song with id: {songId}");
            _context.Remove(song);
            return await _context.SaveChangesAsync();
        }

        public async Task DeleteLove(int songId)
        {
            var song = await _context.Songs.FindAsync(songId);
            song.ListenCount -= 1;
            await _context.SaveChangesAsync();
        }

        public async Task<SongDto> GetSongById(int songId)
        {
            var song = await _context.Songs.FindAsync(songId);
            return new SongDto()
            {
                Id = song.Id,
                Name = song.Name,
                Lyrics = song.Lyrics,
                SongImage = song.SongImage,
                SongUrl = song.SongUrl,
                LoveCount = song.LoveCount,
                ListenCount = song.ListenCount,
                CreatedDate = song.CreatedDate,
                Musician = song.Musician,
                Duration = song.Duration,
                SingersString = song.SingersString
            };

        }

        public async Task<List<SongDto>> GetTop100ZingChart()
        {
            var query = _context.Songs.OrderByDescending(s => s.LoveCount).Skip(0).Take(100).Select(s => new SongDto()
            {
                Id = s.Id,
                Name = s.Name,
                Lyrics = s.Lyrics,
                SongImage = s.SongImage,
                SongUrl = s.SongUrl,
                LoveCount = s.LoveCount,
                ListenCount = s.ListenCount,
                CreatedDate = s.CreatedDate,
                Musician = s.Musician,
                Duration = s.Duration,
                SingersString = s.SingersString

            });
            return await query.ToListAsync();
        }

        public async Task<List<SongDto>> GetTop10ZingChart()
        {
            var query = _context.Songs.OrderByDescending(s => s.LoveCount).Skip(0).Take(10).Select(s=> new SongDto() { 
                Id = s.Id,
                Name =s.Name,
                Lyrics = s.Lyrics,
                SongImage = s.SongImage,
                SongUrl = s.SongUrl,
                LoveCount = s.LoveCount,
                ListenCount = s.ListenCount,
                CreatedDate = s.CreatedDate,
                Musician = s.Musician,
                Duration = s.Duration,
                SingersString = s.SingersString

            });
            return await query.ToListAsync();
        }

        public async Task<List<SongDto>> GetTop30OfCategory(int categoryId)
        {
            var query = _context.Songs.Where(s => s.CategoryId == categoryId)
                .OrderByDescending(s => s.ListenCount).Skip(0).Take(30).Select(s => new SongDto() {
                Id = s.Id,
                Name = s.Name,
                Lyrics = s.Lyrics,
                SongImage = s.SongImage,
                SongUrl = s.SongUrl,
                LoveCount = s.LoveCount,
                ListenCount = s.ListenCount,
                CreatedDate = s.CreatedDate,
                Musician = s.Musician,
                Duration = s.Duration,
                SingersString = s.SingersString
            });
            return await query.ToListAsync();
        }

        public Task<SongAndCountLove> GetTop3ToShowChart()
        {
            throw new NotImplementedException();
        }

        public async Task<List<SongDto>> GetTop5OfCategory(int categoryId)
        {
            var query = _context.Songs.Where(s => s.CategoryId == categoryId)
                .OrderByDescending(s => s.ListenCount).Skip(0).Take(5).Select(s => new SongDto()
                {
                    Id = s.Id,
                    Name = s.Name,
                    Lyrics = s.Lyrics,
                    SongImage = s.SongImage,
                    SongUrl = s.SongUrl,
                    LoveCount = s.LoveCount,
                    ListenCount = s.ListenCount,
                    CreatedDate = s.CreatedDate,
                    Musician = s.Musician,
                    Duration = s.Duration,
                    SingersString = s.SingersString
                });
            return await query.ToListAsync();
        }

        public async Task<int> Update(int songId,SongDto request)
        {
            var song = await _context.Songs.FindAsync(songId);
            if (song == null) throw new Exception($"Can not find song with id: {songId}");
            song.Name = request.Name;
            song.Lyrics = request.Lyrics;
            song.SongImage = request.SongImage;
            song.SongUrl = request.SongUrl;
            song.LoveCount = request.LoveCount;
            song.ListenCount = request.ListenCount;
            song.CreatedDate = request.CreatedDate;
            song.Musician = request.Musician;
            song.Duration = request.Duration;
            song.SingersString = request.SingersString;
            return await _context.SaveChangesAsync();
        }
    }
}
