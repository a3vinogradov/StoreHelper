using Microsoft.EntityFrameworkCore;

namespace StoreHelherAttempt2.Models
{
	public class ApplicationContext : DbContext
	{
        public DbSet<Store> Stores { get; set; } = null!;
        public DbSet<Good> Goods { get; set; } = null!;
        public DbSet<Purchase> Purchases { get; set; } = null!;
        public DbSet<PurchaseItem> PurchaseItems { get; set; } = null!;

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
		: base(options)
		{
			//Database.EnsureCreated();   // создаем базу данных при первом обращении
		}
		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=usersdb2;Username=postgres;Password=1");
		//}
	}
}
