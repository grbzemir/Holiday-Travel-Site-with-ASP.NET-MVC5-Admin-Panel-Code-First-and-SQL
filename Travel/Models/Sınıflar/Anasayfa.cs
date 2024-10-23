using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Travel.Models.Sınıflar
{
	public class Anasayfa
	{
		[Key]
		public int ID { get; set; }
        public string Baslik { get; set; }
		public String Aciklama { get; set; }
    }
}
