using Microsoft.AspNetCore.Mvc;
using MovieApi.Core.Entities;
using Microsoft.AspNetCore.Http;
using MovieApi.Persistance;
using MovieApi.Core.Interfaces;

namespace MovieApi.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        

        private readonly IGenericRepositoryAsync<MovieModel> _movieRepository;

        public MovieController(IGenericRepositoryAsync<MovieModel> movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet]

        public async Task<IActionResult> Get()
        {
            var movies = await _movieRepository.GetAsync();
            return Ok(movies);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

            var movie = await _movieRepository.GetByIdAsync(id);
            return Ok(movie);

        }

        [HttpPost]
        public async Task<IActionResult> AddMovie([FromBody]MovieModel newMovie)
        {


            var movie = await _movieRepository.CreateAsync(newMovie);
            return Ok(movie);

        }

        [HttpPut]

        public async Task<IActionResult> UpdateMovie([FromBody] MovieModel updateMovie)
        {
            var movie = await _movieRepository.UpdateAsync(updateMovie);
            return Ok(movie);
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteMovie(int id)
        {
            await _movieRepository.DeleteByIdAsync(id);
            return NoContent();
        }

    }

}
