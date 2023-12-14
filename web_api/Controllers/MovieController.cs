using System.Linq;
using Microsoft.AspNetCore.Mvc;

using web_api.Models;
using web_api.Data;
using AutoMapper;
using System;

namespace web_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private MovieContext _context;
        private IMapper _mapper;

        public MovieController(MovieContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper; 
        }

        [HttpPost]
        public IActionResult PostMovie([FromBody] CreateMovieDto movieDto)
        {  
            Movie movie = _mapper.Map<Movie>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            Response.Headers.Add("Date", $"{DateTime.Now}");
            return CreatedAtAction(nameof(GetMovieById), new { Id = movie.Id }, movie);
        }

        [HttpGet]
        public IActionResult GetMovie()
        {
            Response.Headers.Add("Date", $"{DateTime.Now}");
            return Ok(_context.Movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {   
            Movie selectedMovie = _context.Movies.FirstOrDefault(i => i.Id == id);
            Response.Headers.Add("Date", $"{DateTime.Now}");
            if(selectedMovie == null) return NotFound();

            GetMovieDto selectedMovieDto = _mapper.Map<GetMovieDto>(selectedMovie);

            return Ok(selectedMovieDto);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMovieById(int id, [FromBody] UpdateMovieDto movieDto)
        {
            Movie movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
            Response.Headers.Add("Date", $"{DateTime.Now}");
            if(movie == null) return NotFound();

            _mapper.Map(movieDto, movie);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMovieById(int id)
        {
            Movie movie = _context.Movies.FirstOrDefault(movie => movie.Id == id);
            Response.Headers.Add("Date", $"{DateTime.Now}");
            if(movie == null) return NotFound();

            _context.Remove(movie);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
