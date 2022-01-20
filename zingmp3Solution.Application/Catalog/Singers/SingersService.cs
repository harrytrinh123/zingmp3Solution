using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zingmp3Solution.Data.EF;
using zingmp3Solution.Data.Entities;
using zingmp3Solution.Dtos.Catalog.Singers;

namespace zingmp3Solution.Application.Catalog.Singers
{
    public class SingersService : ISingersService
    {
        private ZingMp3DbContext _context;
        public SingersService(ZingMp3DbContext context)
        {
            _context = context;
        }

        public async Task AddSingers(SingerDto singer)
        {
            var singerCurrent = new Singer()
            {
                Id = singer.id,
                Dob = singer.Dob,
                Sex = singer.Sex,
                Avatar = singer.Avatar,
                FullName = singer.FullName,
                StageName = singer.StageName,
                Introduction = singer.Introduction,
            };
            _context.Singers.Add(singerCurrent);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteSinger(SingerDto singer)
        {
            var singerCurrent = await _context.Singers.FindAsync(singer.id);
            if(singerCurrent != null)
            {
                _context.Remove(singerCurrent);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<SingerDto> EditSinger(int id, SingerEdit singer)
        {
            var singerCurrent = await _context.Singers.FindAsync(id);
            if(singerCurrent != null)
            {
                singerCurrent.Dob = singer.Dob;
                singerCurrent.Sex = singer.Sex;
                singerCurrent.Avatar = singer.Avatar;
                singerCurrent.FullName = singer.FullName;
                singerCurrent.StageName = singer.StageName;
                singerCurrent.Introduction = singer.Introduction;
                _context.Update(singerCurrent);
                await _context.SaveChangesAsync();
            }
            return new SingerDto() { 
                id = singerCurrent.Id,
                Dob = singerCurrent.Dob,
                Sex = singerCurrent.Sex,
                Avatar = singerCurrent.Avatar,
                FullName = singerCurrent.FullName,
                StageName = singerCurrent.StageName,
                Introduction = singerCurrent.Introduction,
            };
        }

        public async Task<List<Singer>> GetSinger()
        {

            return await _context.Singers.ToListAsync();
        }

        public async Task<Singer> GetSingerByID(int IDSinger)
        {
            var singer = await _context.Singers.FindAsync(IDSinger);
            return singer;
        }
    }
}
