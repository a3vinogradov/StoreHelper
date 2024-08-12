using System.ComponentModel.DataAnnotations;

namespace StoreHelherAttempt2.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string IncomNumber { get; set; }
        
        [Required]
        public required string Name { get; set; }
        
        public string? Description { get; set; }
        
        [Required]
        public DateTimeOffset DateCreate { get; set; }
        
        public DateTimeOffset? DateUpdate { get; set; }
        
        [Required]
        public required Store Store { get; set; }
    }
}
