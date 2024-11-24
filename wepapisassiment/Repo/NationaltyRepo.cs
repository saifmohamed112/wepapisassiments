using wepapisassiment.Data;
using wepapisassiment.DTOs;
using wepapisassiment.Models;

namespace wepapisassiment.Repo
{
    public class NationaltyRepo : INationaltyRepo
    {
        private readonly ApplicationDbContext _context;

        public NationaltyRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void add(NationaltyDto nationaltyDto)
        {
            var nationalty = new Nationalty
            {
                Name = nationaltyDto.Name,
            };
            _context.Nationalties.Add(nationalty);
            _context.SaveChanges();
        }

        public void remove(int Id)
        {
            var rem = _context.Nationalties.FirstOrDefault(n => n.Id == Id);
            _context.Nationalties.Remove(rem);
            _context.SaveChanges();
        }
    }
}
