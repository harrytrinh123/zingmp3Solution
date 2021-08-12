using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zingmp3Solution.Application.Catalog.Songs;
using zingmp3Solution.Dtos.Catalog.Songs;

namespace zingmp3Solution.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private readonly ISongService _songService;
        public SongsController(ISongService songService)
        {
            _songService = songService;
        }
        [HttpGet("top10zingchart")]
        public async Task<IActionResult> GetTop10ZingChart()
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var songs = await _songService.GetTop10ZingChart();
            return Ok(songs);
        }

        [HttpGet("top100zingchart")]
        public async Task<IActionResult> GetTop100ZingChart()
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var songs = await _songService.GetTop100ZingChart();
            return Ok(songs);
        }

        [HttpGet("categories/top5/{categoryId}")]
        public async Task<IActionResult> GetTop5OfCategory(int categoryId)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var songs = await _songService.GetTop5OfCategory(categoryId);
            return Ok(songs);
        }

        [HttpGet("categories/top30/{categoryId}")]
        public async Task<IActionResult> GetTop3OfCategory(int categoryId)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var songs = await _songService.GetTop5OfCategory(categoryId);
            return Ok(songs);
        }

        [HttpGet("{songId}")]
        public async Task<IActionResult> Get(int songId)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var song = await _songService.GetSongById(songId);
            return Ok(song);
        }

        [HttpPost()]
        public async Task<IActionResult> Create([FromForm] SongCreateDto request)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var songId = await _songService.Create(request);
            var song = await _songService.GetSongById(songId);
            return Ok(song);
        }

        [HttpPost("{songId}")]
        public async Task<IActionResult> Update(int songId, [FromForm] SongUpdateDto request)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var result = await _songService.Update(songId, request);
            if (result == 0)
                return BadRequest();
            return Ok();
        }

        [HttpDelete("{songId}")]
        public async Task<IActionResult> Delete(int songId)
        {
            var result = await _songService.Delete(songId);
            if (result == 0)
                return BadRequest();
            return Ok();
        }

        [HttpPatch("{songId}/addlove")]
        public async Task<IActionResult> AddLove(int songId)
        {
            await _songService.AddLove(songId);
            return Ok();
        }

        [HttpPatch("{songId}/deletelove")]
        public async Task<IActionResult> DeleteLove(int songId)
        {
            await _songService.DeleteLove(songId);
            return Ok();
        }

        [HttpPatch("{songId}/addlistencount")]
        public async Task<IActionResult> AddListenCount(int songId)
        {
            await _songService.AddListenCount(songId);
            return Ok();
        }
    }
}
