using Microsoft.EntityFrameworkCore;
using wepapisassiment.Data;
using wepapisassiment.DTOs;
using wepapisassiment.Models;

namespace wepapisassiment.Repo
{
    public class MoviesRepo : IMoviesRepo
    {
        private readonly ApplicationDbContext _context;

        public MoviesRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void add(MoviesDto moviesDto)
        {
            var movies = new Movies
            {
                Title = moviesDto.Title,
                Publishyear = moviesDto.Publishyear,
                Directors = moviesDto.Directors.Select(s => new Directors
                {
                    Name = s.Name,
                    EmailAddress = s.EmailAddress,
                    Phone = s.Phone,
                    Nationalty = new Nationalty
                    {
                        Name = s.Nationalty.Name,
                    }
                }).ToList(),
                Catigory = new Catigory
                {
                    Name = moviesDto.Catigory.Name,
                }

            };
            _context.Movies.Add(movies);
            _context.SaveChanges();
            
        }

        public List<MoviesDto> getMovies()
        {
            var res = _context.Movies.Include(x=>x.Catigory)
                .Include(x=>x.Directors).ThenInclude(x=>x.Nationalty)
                .Select(x=>new MoviesDto
            {
                Title = x.Title,
                Publishyear = x.Publishyear,

                Directors = x.Directors.Select(s => new DirectorMovieDto
                {
                    EmailAddress = s.EmailAddress,
                    Name = s.Name,
                    Phone = s.Phone,
                    Nationalty = new NationaltyDto
                    {
                        Name = s.Name,
                    },
                }).ToList(),
                Catigory = new CatigoryDto { 
                Name = x.Catigory.Name,
                }

            
             }).ToList();
            return res;
        }

        public MoviesDto getMoviesbyId(int id)
        {
            var res = _context.Movies.Include(x => x.Catigory).Include(x => x.Directors).ThenInclude(x => x.Nationalty).FirstOrDefault(x => x.Id == id);
                if (res == null) {
                return null;
            }
            return new MoviesDto {

                Title = res.Title,
                Publishyear = res.Publishyear,
                Directors = res.Directors.Select(x => new DirectorMovieDto
                {
                    EmailAddress = x.EmailAddress,
                    Name = x.Name,
                    Phone = x.Phone,
                    Nationalty = new NationaltyDto
                    {
                        Name = x.Nationalty.Name,
                    },
                }).ToList(),
                Catigory = new CatigoryDto
                {
                    Name = res.Catigory.Name,
                }


            };
          
        }
    }
}
