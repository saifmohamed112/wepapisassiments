using System.ComponentModel.DataAnnotations;
using wepapisassiment.Models;

namespace wepapisassiment.DTOs
{
    public class MoviesDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime Publishyear { get; set; }
        public IList<DirectorMovieDto> Directors { get; set; }

        public CatigoryDto Catigory { get; set; }
    }
}
