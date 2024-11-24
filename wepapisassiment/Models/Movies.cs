using System.ComponentModel.DataAnnotations;

namespace wepapisassiment.Models
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime Publishyear { get; set; }
        public List<Directors> Directors { get; set; }

        public Catigory Catigory { get; set; }
    }
}
