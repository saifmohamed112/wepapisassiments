using Microsoft.EntityFrameworkCore;
using wepapisassiment.Data;
using wepapisassiment.DTOs;
using wepapisassiment.Models;

namespace wepapisassiment.Repo
{
    public class DirectorsRepo : IDirectorRepo
    {
        private readonly ApplicationDbContext _context;

        public DirectorsRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void addDirector(DirectorMovieDto directorMovieDto)
        {
            var DIR = new Directors
            {
                Name = directorMovieDto.Name,
                EmailAddress = directorMovieDto.EmailAddress,
                Phone = directorMovieDto.Phone,
                Nationalty = new Nationalty
                {
                    Name = directorMovieDto.Nationalty.Name,
                }
            };
            _context.Directors.Add(DIR);
            _context.SaveChanges();
        }

        public void deleteDirector(int Id)
        {
            var dir = _context.Directors.Include(x => x.Nationalty).Include(x => x.Movies).ThenInclude(x => x.Catigory).FirstOrDefault(x => x.ID == Id);
            _context.Directors.Remove(dir);
            _context.SaveChanges();
        }

        public void Update(int Id, DirectorsUpdateDto directorMovieDto)
        {
           var dir = _context.Directors.Include(x=>x.Nationalty).Include(x=>x.Movies).ThenInclude(x=>x.Catigory).FirstOrDefault(x=>x.ID == Id);
            dir.Name = directorMovieDto.Name;
            dir.EmailAddress = directorMovieDto.EmailAddress;
            dir.Phone = directorMovieDto.Phone;
            dir.Nationalty = new Models.Nationalty
            {
                Name = directorMovieDto.Nationalty.Name,
            };
            dir.Movies = dir.Movies.Select(x=>new Movies
            {
                Title = x.Title,
                Publishyear = x.Publishyear,
                Catigory = new Catigory
                {
                    Name= x.Catigory.Name,
                }
            }).ToList();
            _context.Directors.Update(dir);
            _context.SaveChanges();
        }
    }
}
