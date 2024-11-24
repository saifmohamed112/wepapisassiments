using wepapisassiment.DTOs;

namespace wepapisassiment.Repo
{
    public interface INationaltyRepo
    {
        public void add(NationaltyDto nationaltyDto);
        public void remove(int Id);
    }
}
