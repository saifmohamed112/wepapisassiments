using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using wepapisassiment.DTOs;
using wepapisassiment.Repo;

namespace wepapisassiment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NationaltyRepo : ControllerBase
    {
        private readonly INationaltyRepo _repo;

        public NationaltyRepo(INationaltyRepo repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public IActionResult Post(NationaltyDto nationaltyDto) {
        _repo.add(nationaltyDto);
            return Accepted();
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _repo.remove(id);
            return Accepted();
        }
    }
}
