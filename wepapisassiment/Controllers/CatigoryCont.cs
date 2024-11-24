using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using wepapisassiment.DTOs;
using wepapisassiment.Repo;

namespace wepapisassiment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatigoryCont : ControllerBase
    {
        private readonly ICatigoryRepo _catigoryRepo;

        public CatigoryCont(ICatigoryRepo catigoryRepo)
        {
            _catigoryRepo = catigoryRepo;
        }
        [HttpPost]
        public IActionResult add(CatigoryDto catigoryDto)
        {
            _catigoryRepo.add(catigoryDto);
            return Created();
        }
        [HttpPut]
        public IActionResult update(CatigoryDto catigoryDto, int id) {
        _catigoryRepo.update(catigoryDto, id);
            return Accepted();
        }
    }
}
