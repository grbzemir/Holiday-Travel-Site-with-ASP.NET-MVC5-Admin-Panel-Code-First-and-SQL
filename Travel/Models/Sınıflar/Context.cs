using System.Data.Common;
using System.Data.Entity;

namespace Travel.Models.Sınıflar
{
	public class Context:DbContext
	{
		public DbSet<Admin> Admins { get; set; }
		public DbSet<AdresBlog> AdresBlogs { get; set; }
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Anasayfa> Anasayfas { get; set; }
		public DbSet<Hakkımızda> Hakkimizdas { get; set; }
		public DbSet<İletişim> İletişims { get; set; }
		public DbSet<Yorumlar> Yorumlars { get; set; }

	}
}
