using System.ComponentModel.DataAnnotations;

namespace wepapisassiment.DTOs
{
    public class CatigoryDto
    {
        [Required]
        public string Name { get; set; }
    }
}
