using System.ComponentModel.DataAnnotations;

namespace wepapisassiment.Models
{
    public class Catigory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public List<Movies> Movies { get; set; }

    }
}
