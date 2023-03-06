using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.UI.Common
{
	public class Musteri
	{
		public string AdSoyad { get; set; }
		public string Adres { get; set; }
		public string TcKimlik { get; set; }
		public string DogumTarihi { get; set; }
		public override string ToString()
		{
			return AdSoyad;
		}
	}
}
