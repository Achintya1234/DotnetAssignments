using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIUsingEFCodeFirst.Entities;
using HandsOnAPIUsingEFCodeFirst.Services;
namespace HandsOnAPIUsingEFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly MovieService service;
        public ProductController()
        {
            this.service = new MovieService();
        }
        [Route("GetAllProducts")]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Movie> movies = service.GetAllMovies();
            return StatusCode(200,movies);
        }
        [HttpGet]
        [Route("Get/{id}")]
        public IActionResult Get(int id)
        {
            Movie movie = service.GetMovieByID(id);
            return StatusCode(200,movie);
        }
        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Movie movie)
        {
            service.AddMovie(movie);
            return StatusCode(200,movie);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            service.DeleteMovie(id);
            return StatusCode(200,"Movie with "+id+" Deleted");
        }
        [HttpPut]
        [Route("Edit")]
        public IActionResult Edit(Movie movie)
        {
            service.EditMovie(movie);
            return StatusCode(200, movie);
        }

        [HttpGet]
        [Route("Get/{actor}")]
        public IActionResult GetByActor(string actor)
        {
            Movie movie = service.GetMoviesByActor(actor);
            return StatusCode(200, movie);
        }

        [HttpGet]
        [Route("Get/{director}")]
        public IActionResult GetByDirector(string director)
        {
            Movie movie = service.GetMoviesByDirector(director);
            return StatusCode(200, movie);
        }

        [HttpGet]
        [Route("Get/{lang}")]
        public IActionResult GetByLang(string lang)
        {
            Movie movie = service.GetMoviesByLang(lang);
            return StatusCode(200, movie);
        }

    }
}
