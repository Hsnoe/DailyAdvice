using DailyAdvice.Dtos.MovieDtos;
using DailyAdvice.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DailyAdvice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovieList()
        {
            var values = await _movieService.GetMovieListAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(CreateMovieDto createMovieDto)
        {
            await _movieService.CreateMovieAsync(createMovieDto);
            return Ok("Film başarıyla eklendi.");
        }
    }
}
