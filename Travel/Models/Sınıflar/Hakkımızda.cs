using System.ComponentModel.DataAnnotations;

namespace Travel.Models.Sınıflar
{
	public class Hakkımızda
	{
		[Key]
		public int ID { get; set; }
		public string FotoUrl { get; set; }
		public string Aciklama { get; set; }
	}
}
