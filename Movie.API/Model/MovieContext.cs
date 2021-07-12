using Microsoft.EntityFrameworkCore;

namespace Movie.API.Model {
    public class MovieContext : DbContext {
        public MovieContext(DbContextOptions options) : base(options) {
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
