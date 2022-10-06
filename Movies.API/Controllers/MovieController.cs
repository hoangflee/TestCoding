using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Interface;
using Movies.Service;

namespace Movies.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public IActionResult GetAll(int pageIndex = 1, int pageSize = 20)
        {
            int skip = (pageIndex - 1) * pageSize;
            var movies = _movieService.GetAll(skip, pageSize);
            return Ok(movies);
        }

        [HttpPut("changed-like/{id}")]
        public IActionResult Update(int id)
        {
            _movieService.ChangedLiked(id);
            return Ok(new { message = "Changed like successfully" });
        }
    }
}
