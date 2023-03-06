using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.UI.Common
{
	public class Oda
	{
		public int Numarasi { get; set; }
		public int Kapasite { get; set; }
		public OdaDurumu OdaDurum { get; set; }
		public double Fiyati { get; set; }
	}
}
