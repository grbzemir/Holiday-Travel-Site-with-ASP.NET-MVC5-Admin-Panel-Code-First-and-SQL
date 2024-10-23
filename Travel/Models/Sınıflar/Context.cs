using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Travel.Models.Sınıflar
{
	public class Context : DbContext
	{
		public DbSet<Admin> Admins { get; set; }
		public DbSet<AdresBlog> AdresBlogs { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Anasayfa> Anasayfas { get; set; }
		public DbSet<Hakkımızda> Hakkimizdas { get; set; }
		public DbSet<İletişim> İletişims { get; set; }
		public DbSet<Yorumlar> Yorumlars { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// Uygulamanın çalışma dizinindeki appsettings.json dosyasından bağlantı dizesini çekme
			var configuration = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json")
				.Build();

			// Bağlantı dizesini appsettings.json'dan alıyoruz
			var connectionString = configuration.GetConnectionString("DefaultConnection");

			// SqlServer bağlantısını ayarlıyoruz
			optionsBuilder.UseSqlServer(connectionString);
		}
	}
}
