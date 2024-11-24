using wepapisassiment.DTOs;

namespace wepapisassiment.Repo
{
    public interface IDirectorRepo
    {
        public void addDirector(DirectorMovieDto directorMovieDto);

        public void Update(int Id,DirectorsUpdateDto directorMovieDto);

        public void deleteDirector(int Id);
    }
}
