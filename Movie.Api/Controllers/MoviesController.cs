using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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



    }

}
