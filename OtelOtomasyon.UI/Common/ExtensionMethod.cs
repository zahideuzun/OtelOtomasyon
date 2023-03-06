using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OtelOtomasyon.UI.Common
{
	public class ExtensionMethod
	{

		
		/// <summary>
		/// textboxlarin bos birakilip birakilmadiginin kontrolünü yapar.bos degilse true doner.
		/// </summary>
		/// <param name="texts"></param>
		/// <returns></returns>
		public static bool GirdilerBosMu(params string[] texts)
		{
			foreach (var item in texts)
			{
				//boş ise girer
				if (string.IsNullOrWhiteSpace(item) || item.Length < 2)
				{
					return false;
				}
			}
			//boş değil
			return true;
		}

		/// <summary>
		/// textboxlara girilen değerlerde sayi var mi kontrolünü yapar. sayi yoksa true doner.
		/// </summary>
		/// <param name="texts"></param>
		/// <returns></returns>
		public static bool SayiVarMi(params string[] texts)
		{
			foreach (var item in texts)
			{
				//sayi varsa girer
				if (item.Any(char.IsDigit))
				{
					return false;
				}
			}
			//sayi yok
			return true;
		}

		/// <summary>
		/// tc kimlik numarasinin dogru formatta olup olmadigininin kontrolünü yapar. dogru formattaysa true doner.
		/// </summary>
		/// <param name="tc"></param>
		/// <returns></returns>
		public static bool TcKimlikKontrol(string tc)
		{
			//return (tc.Length != 11 && tc.Substring(0, 1) != "0" && tc.Substring(10, 1) != "1" && tc.Substring(10, 1) != "1" && tc.Substring(10, 1) != "3" && tc.Substring(10, 1) != "5" && tc.Substring(10, 1) != "7" && tc.Substring(10, 1) != "9")
			//	? true
			//	: false;
			#region uzun if

			if (tc.Length == 11 && tc.Substring(0, 1) != "0" && tc.Substring(10, 1) != "1" && tc.Substring(10, 1) != "1" && tc.Substring(10, 1) != "3" && tc.Substring(10, 1) != "5" && tc.Substring(10, 1) != "7" && tc.Substring(10, 1) != "9")
			{
				return true;
			}
			return false;
			#endregion

		}


	}
}
