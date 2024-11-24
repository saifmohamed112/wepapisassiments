using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using wepapisassiment.Models;

namespace wepapisassiment.DTOs
{
    public class DirectorsUpdateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Phone]
        [Required]
        public string Phone { get; set; }

        public List<MoviesDtowithoutdirector> Movies { get; set; }
       
        public NationaltyDto Nationalty { get; set; }
    }
}
