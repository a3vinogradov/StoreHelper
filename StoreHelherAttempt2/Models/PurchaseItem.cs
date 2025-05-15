using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
using System.Xml.Linq;

namespace StoreHelherAttempt2.Models
{
    //[Index(nameof(Purchase), nameof(Good), IsUnique = true, Name = "Document_Good_UX")]
    [Index("PurchaseId","GoodId", IsUnique = true, Name = "Document_Good_UX")]
    public class PurchaseItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required Purchase Purchase { get; set; }

        [Required]
        public required Good Good { get; set; }

        [Required]
        public required decimal Quantity {  get; set; } 
    }
}
