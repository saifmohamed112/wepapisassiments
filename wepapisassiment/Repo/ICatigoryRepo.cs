using wepapisassiment.DTOs;

namespace wepapisassiment.Repo
{
    public interface ICatigoryRepo 
    {
        public void add(CatigoryDto catigory);
        public void update(CatigoryDto catigory,int Id);

    }
}
