using System.ComponentModel.DataAnnotations;

namespace StoreHelherAttempt2.Models
{
    public class Good
    {
        [Key]
        [Display(Name = "Идентификатор")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Наименование")]
        public required string Name { get; set; }
        [Display(Name = "Описание")]
        public string? Description { get; set; }
    }
}
