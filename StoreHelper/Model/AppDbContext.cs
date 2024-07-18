using Microsoft.EntityFrameworkCore;

namespace StoreHelper.Model
{
	public class AppDbContext : DbContext
	{
		public DbSet<Store> Stores { get; set; } = null!;

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb2;Username=postgres;Password=1");
		}
	}
}
