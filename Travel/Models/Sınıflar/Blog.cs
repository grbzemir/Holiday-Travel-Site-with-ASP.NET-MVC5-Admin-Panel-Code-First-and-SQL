﻿using System.ComponentModel.DataAnnotations;

namespace Travel.Models.Sınıflar
{
	public class Blog
	{
		[Key]
		public int ID { get; set; }
		public string Baslik { get; set; }
		public string Aciklama { get; set; }
		public string BlogImage { get; set; }
		public DateTime Tarih { get; set; }
		public ICollection<Yorumlar> Yorumlars { get; set; }
	}
}
