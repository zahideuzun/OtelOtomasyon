﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelOtomasyon.UI.Common
{
	public class Hizmet
	{
		public string HizmetAdi { get; set; }
		public double HizmetFiyati { get; set; }
		public override string ToString()
		{
			return HizmetFiyati.ToString();
		}
	}
}
