using wepapisassiment.DTOs;

namespace wepapisassiment.Repo
{
    public interface IMoviesRepo
    {
        public void add(MoviesDto moviesDto);

        public List<MoviesDto> getMovies();

        public MoviesDto getMoviesbyId(int id);
    }
}
