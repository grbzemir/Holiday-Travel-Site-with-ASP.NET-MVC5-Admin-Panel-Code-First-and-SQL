using System.ComponentModel.DataAnnotations;

namespace Travel.Models.Sınıflar
{
	public class Yorumlar
	{
		[Key]
		public int ID { get; set; }
		public string KullaniciAdi { get; set; }
		public string Mail { get; set; }
		public string Yorum { get; set; }
		public Blog Blog { get; set; }
	}
}
