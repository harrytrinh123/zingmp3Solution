using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zingmp3Solution.Application.Catalog.Singers;
using zingmp3Solution.Data.Entities;
using zingmp3Solution.Dtos.Catalog.Singers;

namespace zingmp3Solution.WebApi.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class SingersController : ControllerBase
    {
        private ISingersService _singer;
        public SingersController(ISingersService singers)
        {
            _singer = singers;
        }

        [HttpGet]
        public async Task<IActionResult> GetSinger()
        {
            return Ok(await _singer.GetSinger());
        }

        [HttpGet]
        [Route("/api/[controller]/{id}")]
        public async Task<IActionResult> GetSingerByID(int id)
        {
            var singer = _singer.GetSingerByID(id);
            if(singer != null)
            {
                return Ok(await singer);
            }
            return NotFound($"Id {id} not list");
        }

        [HttpPost]
        public async Task<IActionResult> AddSinger(SingerDto singer)
        {
            await _singer.AddSingers(singer);
            return Ok(singer);
        }

        [HttpDelete]
        [Route("/api/[controller]/{id}")]
        public async Task<IActionResult> DeleteSinger(SingerDto singer)
        {
            await _singer.DeleteSinger(singer);
            return Ok(singer);
        }

        [HttpPatch]
        [Route("/api/[controller]/{id}")]
        public async Task<IActionResult> EditSinger(int id, SingerEdit singer)
        {
            var singerCurrent = _singer.GetSingerByID(id);
            if(singerCurrent != null)
            {
                id = singerCurrent.Id;
                await _singer.EditSinger(id, singer);
            }

            return Ok(singer);
        }
    }
}
