using wepapisassiment.Data;
using wepapisassiment.DTOs;
using wepapisassiment.Models;

namespace wepapisassiment.Repo
{
    public class CatigoryRepo : ICatigoryRepo
    {
        private readonly ApplicationDbContext _context;

        public CatigoryRepo(ApplicationDbContext context)
        {
            _context = context;
        }

        public void add(CatigoryDto catigory)
        {
            var cat = new Catigory
            {
                Name = catigory.Name,
            };
            _context.Catigories.Add(cat);
            _context.SaveChanges();
        }

        public void update(CatigoryDto catigory, int Id)
        {
          var res = _context.Catigories.FirstOrDefault(x=>x.Id == Id);
           
            res.Name= catigory.Name;

            _context.Catigories.Update(res);
            _context.SaveChanges() ;
        
        }
    }
}
