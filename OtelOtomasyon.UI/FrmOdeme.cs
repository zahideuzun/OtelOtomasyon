using OtelOtomasyon.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelOtomasyon.UI
{
	public partial class FrmOdeme : Form
	{
		List<OdaRezervasyon> odemeAlinanMusteriListesi = new List<OdaRezervasyon>();
		OdaRezervasyon odemeRezervasyon = new OdaRezervasyon();
		private List<OdaRezervasyon> _rezervasyonuYapilanMusteriler;
		double araToplam = 0;
		double genelToplam = 0;
		public FrmOdeme()
		{
			InitializeComponent();
		}

		public FrmOdeme(List<OdaRezervasyon> rezervasyonuYapilanMusteriler) : this()
		{
			_rezervasyonuYapilanMusteriler = rezervasyonuYapilanMusteriler;
		}

		private void btnSec_Click(object sender, EventArgs e)
		{
			lblAdSoyad.Visible = true;
			lblAdSoyad.Text = cmbMusteriler.Text;
		}

		/// <summary>
		/// cikis yapan musterinin tüm bilgilerini aldiktan sonra ödeme alinan event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnOdemeAl_Click(object sender, EventArgs e)
		{
			DialogResult dg = MessageBox.Show("Toplam Hizmet Bedeli: " + genelToplam + " TL\nÖdeme alınsın mı? ", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

			foreach (OdaRezervasyon item in _rezervasyonuYapilanMusteriler)
			{
				if (dg == DialogResult.Yes && (cmbMusteriler.Text == item.Musteri.AdSoyad))
				{
					odemeRezervasyon.Musteri = new Musteri()
					{
						AdSoyad = item.Musteri.AdSoyad,
						DogumTarihi = item.Musteri.DogumTarihi,
						TcKimlik = item.Musteri.TcKimlik,
						Adres = item.Musteri.Adres,
					};
					odemeRezervasyon.Oda = new Oda()
					{
						OdaDurum = OdaDurumu.Bos,
						Fiyati = item.Oda.Fiyati,
					};
					odemeRezervasyon.GirisTarihi = item.GirisTarihi;
					odemeRezervasyon.CikisTarihi = item.CikisTarihi;
					odemeAlinanMusteriListesi.Add(odemeRezervasyon);
					this.Tag = odemeAlinanMusteriListesi;
					cmbMusteriler.Items.RemoveAt(cmbMusteriler.SelectedIndex);
				}
			}

			MessageBox.Show($"{genelToplam} TL tutarında ödeme alındı.");
			FormuTemizle();
		}

		/// <summary>
		/// otelde kullanilan ek ücretli olan hizmetleri formdaki flpanele ekledigimiz void method
		/// </summary>
		void EkHizmetleriEkle()
		{
			flEkHizmetler.Controls.Add(new CheckBox() { Text = "Kola", Tag = new Hizmet() { HizmetAdi = "Kola", HizmetFiyati = 10 } });
			flEkHizmetler.Controls.Add(new CheckBox() { Text = "Maden Suyu", Tag = new Hizmet() { HizmetAdi = "Maden Suyu", HizmetFiyati = 10 } });
			flEkHizmetler.Controls.Add(new CheckBox() { Text = "Su", Tag = new Hizmet() { HizmetAdi = "Su", HizmetFiyati = 5 } });
			flEkHizmetler.Controls.Add(new CheckBox() { Text = "Bira", Tag = new Hizmet() { HizmetAdi = "Bira", HizmetFiyati = 30 } });
			flEkHizmetler.Controls.Add(new CheckBox() { Text = "Şarap", Tag = new Hizmet() { HizmetAdi = "Şarap", HizmetFiyati = 50 } });
			flEkHizmetler.Controls.Add(new CheckBox() { Text = "Enerji İçeceği", Tag = new Hizmet() { HizmetAdi = "Enerji İçeceği", HizmetFiyati = 15 } });
			flEkHizmetler.Controls.Add(new CheckBox() { Text = "Ütü", Tag = new Hizmet() { HizmetAdi = "Ütü", HizmetFiyati = 20 } });
			flEkHizmetler.Controls.Add(new CheckBox() { Text = "Masaj", Tag = new Hizmet() { HizmetAdi = "Masaj", HizmetFiyati = 100 } });
			flEkHizmetler.Controls.Add(new CheckBox() { Text = "Sauna", Tag = new Hizmet() { HizmetAdi = "Sauna", HizmetFiyati = 50 } });
		}

		private void FrmOdeme_Load(object sender, EventArgs e)
		{
			lblAdSoyad.Visible = false;
			lblToplam.Visible = false;
			lblToplam.Visible = false;
			EkHizmetleriEkle();

			// musteri kayit ekraninda kaydedilen musterileri ödeme ekranindaki musteri bulma comboboxina tasir.
			foreach (OdaRezervasyon item in _rezervasyonuYapilanMusteriler) 
			{
				cmbMusteriler.Items.Add(item);
			}
		}

		/// <summary>
		/// musteri otelde kac gun kaldigini hesapladigimiz method
		/// </summary>
		/// <param name="GirisTarihi"></param>
		/// <param name="CikisTarihi"></param>
		/// <returns></returns>
		public int KalinacakGunSayisi(DateTime GirisTarihi, DateTime CikisTarihi)
		{
			return (CikisTarihi - GirisTarihi).Days;
		}

		/// <summary>
		/// musterinin kullandigi ek hizmetleri sectigimiz event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnHizmetEkle_Click(object sender, EventArgs e)
		{
			foreach (CheckBox item in flEkHizmetler.Controls)
			{
				if (item.Checked)
				{
					araToplam += Convert.ToDouble(numHizmet.Value) * Convert.ToDouble(item.Tag.ToString());
					genelToplam = araToplam;
					lblToplam.Visible = true;
					lblToplam.Text = $"Toplam tutar {genelToplam} TL'ye ulaşmıştır.";
				}
			}
		}
		/// <summary>
		/// musterinin ek hizmet kullanmadan yapacagi ödemeyi hesaplayan event. sadece kalinan gun sayisina göre hesaplanir.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnHesapla_Click(object sender, EventArgs e)
		{
			foreach (OdaRezervasyon item in _rezervasyonuYapilanMusteriler)
			{
				if (cmbMusteriler.SelectedItem == item)
				{
					araToplam += item.Oda.Fiyati * KalinacakGunSayisi(item.GirisTarihi, dtpSonCikisTarih.Value);
					lblToplam.Visible = true;
					lblToplam.Text = $"Toplam tutar {araToplam} TL'ye ulaşmıştır.";
					lblAraToplam.Text = $"Yalnızca oda kullanımı için ödenecek tutar {araToplam} TL'dir.";
					break;
				}
			}
		}

		void FormuTemizle()
		{
			cmbMusteriler.Text = lblToplam.Text = lblAdSoyad.Text = null;
			numHizmet.Value = 0;
			CheckBoxTemizle();

		}
		void CheckBoxTemizle()
		{
			foreach (CheckBox item in flEkHizmetler.Controls)
			{
				if (item.Checked)
				{
					item.Checked = false;
				}
			}
		}


	}
}
