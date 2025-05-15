using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace StoreHelper.Model
{
	[Index("Name",IsUnique = true)]
	public class Store
	{
		[Key]
		public int Id { get; set; }
		public Store? ParentId { get; set; }
		[Required]
		public required string Name { get; set; }
		public string? Description { get; set; }
	}
}
