using System.ComponentModel.DataAnnotations;

namespace StoreHelherAttempt2.Models
{
    public class Good
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}
