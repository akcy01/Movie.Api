using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Formatter;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using MovieApi.Core.Entities;
using MovieApi.Core.Interfaces;

namespace Movie.Api.Controllers
{
    
    
    public class MoviesController : ODataController
    {

        private readonly IGenericRepositoryAsync<MovieModel> _movieRepository;

        public MoviesController(IGenericRepositoryAsync<MovieModel> movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [EnableQuery] //Get de çalışıyor bu 
        
        public async Task<IActionResult> Get()
        {
            var movies = await _movieRepository.GetAsync();   
            return Ok(movies);
        }

        [HttpPost]

        public async Task<IActionResult> Post([FromBody]MovieModel movie)
        {

            movie.Id = (await _movieRepository.CreateAsync(movie)).Id;
            return Ok(movie);

        }

        [HttpPut]

        public async Task<IActionResult> Put([FromODataUri] int key,[FromBody]MovieModel movie)
        {

            await _movieRepository.UpdateAsync(movie);
            return Updated(movie);

        }

        [HttpDelete]

        public async Task<IActionResult> Delete([FromODataUri] int key)
        {

            await _movieRepository.DeleteByIdAsync(key);
            return Ok();

        }



    }

}
