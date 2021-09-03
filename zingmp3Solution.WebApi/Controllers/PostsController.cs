using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zingmp3Solution.Application.Catalog.Posts;
using zingmp3Solution.Dtos.Catalog.Posts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zingmp3Solution.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;
        public PostsController(IPostService postService)
        {
            _postService = postService;
        }
        // GET: api/<PostsController>
        [HttpGet("GetPaged")]
        public async Task<IActionResult> GetPaged(int pageIndex, int pageSize)
        {
            var items = await _postService.GetPaged(pageIndex, pageSize);
            return Ok(items);
        }

        // GET api/<PostsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int postId)
        {
            var item = await _postService.GetPostById(postId);
            if (item == null)
                return BadRequest("Can not find item");
            return Ok(item);
        }

        // POST api/<PostsController>
        [HttpPost]
        public async Task<IActionResult> Post([FromForm]PostCreateDto request)
        {
            return Ok();
        }

        // PUT api/<PostsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int postId, [FromForm] PostUpdateDto request)
        {
            return Ok();
        }

        // DELETE api/<PostsController>/5
        [HttpDelete("{postId}")]
        public async Task<IActionResult> Delete(int postId)
        {
            var affedted = await _postService.Delete(postId);
            if (affedted == 0)
                return BadRequest();
            return Ok();
        }
    }
}
