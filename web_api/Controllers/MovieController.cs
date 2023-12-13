using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

using web_api.Models;

namespace web_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private static List<Movie> movies = new();
        private static int id = 1;

        [HttpPost]
        public IActionResult PostMovie([FromBody] Movie movie)
        {
            movies.Add(movie);
            movie.Id = id++;
            
            return CreatedAtAction(nameof(GetMovieById), new { Id = movie.Id }, movie);
        }

        [HttpGet]
        public IActionResult GetMovie()
        {
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {   
            Movie selectedMovie = movies.FirstOrDefault(i => i.Id == id);
            if(selectedMovie != null) return Ok(selectedMovie);
            
            return NotFound();
        }
    }
}
