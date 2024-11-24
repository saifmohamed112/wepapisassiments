using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using wepapisassiment.DTOs;
using wepapisassiment.Repo;

namespace wepapisassiment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesConr : ControllerBase
    {
        private readonly IMoviesRepo _moviesRepo;

        public MoviesConr(IMoviesRepo moviesRepo)
        {
            _moviesRepo = moviesRepo;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var x = _moviesRepo.getMovies;
            return Ok(x);
        }
        [HttpGet("getbyid")]
        public ActionResult Getbyid(int id) { 
        var x = _moviesRepo.getMoviesbyId(id);
            return Ok(x);
        }
        [HttpPost]
        public IActionResult add(MoviesDto moviesDto)
        {
            _moviesRepo.add(moviesDto);
            return Created();
        }
    }
}
