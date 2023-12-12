using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace web_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Movie> movies = new();

        public void AddMovie(Movie movie)
        {
            
        }
    }
}
