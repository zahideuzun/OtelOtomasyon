using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelOtomasyon.UI.Common;

namespace OtelOtomasyon.UI
{
	public partial class FrmRapor : Form
	{
		List<OdaRezervasyon> _odemeAlinanMusteriListesi;
		public FrmRapor()
		{
			InitializeComponent();
		}
		public FrmRapor(List<OdaRezervasyon> odemeAlinanMusteriListesi) : this()
		{
			_odemeAlinanMusteriListesi = odemeAlinanMusteriListesi;
		}
		private void FrmRapor_Load(object sender, EventArgs e)
		{
			ListViewOlustur();
		}

		/// <summary>
		/// müsteri ismi girilerek ödemesi alinan müsteri listesinde filtreleme yapiyoruz
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAra_Click(object sender, EventArgs e)
		{
			if (KontrolYapısıExtensionMethod())
			{
				// odeme alinan musteri listesinden, textboxa girilen musteri adiyla ayni olanlari list halinde getiren sorgu.
				List<OdaRezervasyon> sorgu = _odemeAlinanMusteriListesi.Where(x => x.Musteri.AdSoyad == tbMusteriAra.Text).ToList();
				ListViewOlustur(sorgu);
			}
		}

		/// <summary>
		/// tarih araligi secerek ödemesi yapilan müsteri listesinde filtreleme yapiyoruz.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnTarihAra_Click(object sender, EventArgs e)
		{
			List<OdaRezervasyon> sorgu = _odemeAlinanMusteriListesi.Where(x =>
				x.GirisTarihi <= numTarih1.Value && numTarih1.Value >= x.CikisTarihi).ToList();

			ListViewOlustur(sorgu);

		}

		/// <summary>
		/// kontrol yapilari validasyonlarini yapan method. true donerse islem yapar.
		/// </summary>
		/// <returns></returns>
		public bool KontrolYapısıExtensionMethod()
		{
			return ExtensionMethod.GirdilerBosMu(tbMusteriAra.Text) && ExtensionMethod.SayiVarMi(tbMusteriAra.Text);
		}

		/// <summary>
		/// raporlama listesini olusturan method
		/// </summary>
		public void ListViewOlustur()
		{
			int sayac = 1;
			foreach (OdaRezervasyon item in _odemeAlinanMusteriListesi)
			{
				ListViewItem lv = new ListViewItem(item.Musteri.AdSoyad, 0);
				lv.Text = (sayac++).ToString();
				lv.SubItems.Add(item.Musteri.AdSoyad);
				lv.SubItems.Add(item.Musteri.TcKimlik);
				lv.SubItems.Add(item.GirisTarihi.ToShortDateString());
				lv.SubItems.Add(item.CikisTarihi.ToShortDateString());
				lv.SubItems.Add(item.Oda.Numarasi.ToString());
				lv.SubItems.Add(item.Oda.Fiyati.ToString());
				lstRapor.Items.Add(lv);

			}
		}

		/// <summary>
		/// raporlama listesini filtreleme sorgusuna uygun sekilde yapan method overload.
		/// </summary>
		/// <param name="sorgu"></param>
		void ListViewOlustur(List<OdaRezervasyon> sorgu)
		{
			foreach (OdaRezervasyon item in sorgu)
			{
				int sayac = 1;
				ListViewItem lv = new ListViewItem(item.Musteri.AdSoyad, 0);
				lv.Text = (sayac++).ToString();
				lv.SubItems.Add(item.Musteri.AdSoyad);
				lv.SubItems.Add(item.Musteri.TcKimlik);
				lv.SubItems.Add(item.GirisTarihi.ToShortDateString());
				lv.SubItems.Add(item.CikisTarihi.ToShortDateString());
				lv.SubItems.Add(item.Oda.Numarasi.ToString());
				lv.SubItems.Add(item.Oda.Fiyati.ToString());
				lstRapor.Items.Add(lv);
			}
		}
	}
}
