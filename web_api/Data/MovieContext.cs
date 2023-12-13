using Microsoft.EntityFrameworkCore;

using web_api.Models;

namespace web_api.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> opt) : base (opt)
        {

        }

        public DbSet<Movie> Movies { get; set; }
    }
}