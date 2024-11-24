using System.ComponentModel.DataAnnotations;
using wepapisassiment.Models;

namespace wepapisassiment.DTOs
{
    public class DirectorMovieDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Phone]
        [Required]
        public string Phone { get; set; }

        public NationaltyDto Nationalty { get; set; }
    }
}
