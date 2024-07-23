using Microsoft.EntityFrameworkCore;

namespace StoreHelper.Model
{
	public class ApplicationContext : DbContext
	{
		public DbSet<Store> Stores { get; set; } = null!;
		public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)	{}
		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb2;Username=postgres;Password=1");
		//}
	}
}
