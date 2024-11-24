using System.ComponentModel.DataAnnotations;

namespace wepapisassiment.Models
{
    public class Nationalty
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public Directors Directors { get; set; }
    }
}
