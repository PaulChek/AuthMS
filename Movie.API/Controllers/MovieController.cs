using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie.API.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movie.API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase {
        private readonly MovieContext _movieContext;

        public MovieController(MovieContext movieContext) {
            _movieContext = movieContext;
        }


        [HttpGet]
        public async Task<ActionResult<List<Model.Movie>>> Get() {
            return Ok(await _movieContext.Movies.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Model.Movie>>> Get(int id) {
            return Ok(await _movieContext.Movies.FirstOrDefaultAsync(v=>v.Id == id));
        }


        [HttpPost]
        public async Task<ActionResult<Model.Movie>> PostMovie(Model.Movie movie) {
          _movieContext.Movies.Add(movie);
            await _movieContext.SaveChangesAsync();

            return CreatedAtAction("Get", new { id = movie.Id }, movie);
        }
    }
}
