using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wepapisassiment.Models
{
    public class Directors
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Phone]
        [Required]
        public string Phone { get; set; }

        public List<Movies> Movies { get; set; }
        [ForeignKey("NationalityId")]
        public Nationalty Nationalty { get; set; }

        public int NationalityId { get; set; }

    }
}
