using System.ComponentModel.DataAnnotations;

namespace StoreHelherAttempt2.Models
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Входящий номер")]

        public required string IncomNumber { get; set; }
        
        [Required]
        [Display(Name = "Наименование")]

        public required string Name { get; set; }

        [Display(Name = "Описание")]

        public string? Description { get; set; }
        
        [Required]
        [Display(Name = "Дата создания")]

        public DateTimeOffset DateCreate { get; set; }

        [Display(Name = "Дата последнего изменения")]

        public DateTimeOffset? DateUpdate { get; set; }
        
        [Required]
        [Display(Name = "Склад")]

        public required Store Store { get; set; }
    }
}
