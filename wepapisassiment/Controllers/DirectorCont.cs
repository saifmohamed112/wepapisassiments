using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using wepapisassiment.DTOs;
using wepapisassiment.Repo;

namespace wepapisassiment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorCont : ControllerBase
    {
        private readonly IDirectorRepo _repo;

        public DirectorCont(IDirectorRepo repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult add(DirectorMovieDto directorMovieDto)
        {
            _repo.addDirector(directorMovieDto);
            return Created();
        }
        [HttpDelete]
        public IActionResult delete(int id)
        {
            _repo.deleteDirector(id);
            return Accepted();
        }
        [HttpPut]
        public IActionResult update(int Id,DirectorsUpdateDto directorsUpdate)
            { 
            _repo.Update(Id,directorsUpdate);
            return Accepted();
            }
    }
}
