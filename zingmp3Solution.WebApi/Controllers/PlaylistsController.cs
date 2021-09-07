using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zingmp3Solution.Application.Catalog.Playlists;
using zingmp3Solution.Dtos.Catalog.Playlists;

namespace zingmp3Solution.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaylistsController : ControllerBase
    {
        private readonly IPlaylistService _playlistService;

        public PlaylistsController(IPlaylistService playlistService)
        {
            _playlistService = playlistService;
        }

        [HttpGet("{playlistId}")]
        public async Task<IActionResult> Get(int playlistId)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var playlist = await _playlistService.GetPlaylistByID(playlistId);
            return Ok(playlist);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] PlaylistCreateDto request)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var playlistId = await _playlistService.Create(request);
            var playlist = await _playlistService.GetPlaylistByID(playlistId);

            return Ok(playlist);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _playlistService.Delete(id);

            if (result == 0)
                return BadRequest();
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromForm] PlaylistUpdateDto request)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = await _playlistService.Update(id, request);
            if (result == 0)
                return BadRequest();
            return Ok();
        }
    }
}
