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
	public partial class FrmMusteriKayit : Form
	{
		List<OdaRezervasyon> rezervasyonuYapilanMusteriler = new List<OdaRezervasyon>();
		private OdaRezervasyon secilenOda;
		public FrmMusteriKayit()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			grpMusteri.Visible = false;
			lblFiyat.Visible = false;
			OdalariOlustur();
		}
		Button tiklanilanButton = null;

		/// <summary>
		/// olusturulan oda butonlarina eklenen event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Btn_Click(object sender, EventArgs e)
		{
			tiklanilanButton = sender as Button;
			grpMusteri.Visible = true;
			lblFiyat.Visible = true;
			OdaRezervasyon odaFiyat = tiklanilanButton.Tag as OdaRezervasyon;
			lblFiyat.Text = $"Seçilen odanın günlük ücreti {odaFiyat.Oda.Fiyati} TL'dir";
		}

		/// <summary>
		/// bilgileri alinan müsteriyi rezervasyon listesine ekledigimiz event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnEkle_Click(object sender, EventArgs e)
		{
			OdaRezervasyon odaRezervasyon = tiklanilanButton.Tag as OdaRezervasyon;
			if (odaRezervasyon.Oda.OdaDurum == OdaDurumu.Bos && KontrolYapısıExtensionMethod())
			{
				odaRezervasyon.Musteri = new Musteri()
				{
					AdSoyad = tbAdSoyad.Text,
					DogumTarihi = mtbDogumTarih.Text,
					TcKimlik = mtbTcKimlik.Text,
					Adres = tbAdres.Text
				};
				odaRezervasyon.GirisTarihi = dtpGirisTarih.Value;
				odaRezervasyon.CikisTarihi = dtpCikisTarih.Value;
				odaRezervasyon.Oda.OdaDurum = OdaDurumu.Dolu;
				rezervasyonuYapilanMusteriler.Add(odaRezervasyon);
				tiklanilanButton.BackColor = Color.Red;
				MessageBox.Show("Rezervasyon Kaydı Başarılı!");
				this.Tag = rezervasyonuYapilanMusteriler; //formlar arasindaki gecisi main üzerinden yaptigim icin olusturdugum musteri listesini formun tagine aliyorum.
				FormuTemizle();
			}
			else
			{
				MessageBox.Show("Lütfen doğru giriş yaptığınızdan emin olun!");
			}
		}

		/// <summary>
		/// buton olusturarak oteldeki odalari belirledigimiz void method
		/// </summary>
		void OdalariOlustur()
		{
			Button btnKral = new Button();
			btnKral.Text = "Kral Dairesi";
			btnKral.BackColor = Color.Lime;
			btnKral.Size = new Size(80, 50);
			btnKral.Tag = new OdaRezervasyon()
			{
				GirisTarihi = dtpGirisTarih.Value,
				CikisTarihi = dtpCikisTarih.Value,
				Oda = new Oda()
				{
					Fiyati = 1000,
					Numarasi = 400,
					OdaDurum = OdaDurumu.Bos,
					Kapasite = 5
				},
				Musteri = new Musteri()

			};
			btnKral.Click += Btn_Click;
			flpKral.Controls.Add(btnKral);

			for (int i = 1; i <= 3; i++)
			{
				Label label = new Label();
				label.Text = i + ". KAT";
				flpKatlar.Controls.Add(label);
				flpKatlar.SetFlowBreak(label, true);
				for (int j = 1; j <= 10; j++)
				{
					Button btn1 = new Button();
					btn1.Size = new Size(50, 50);
					btn1.Text = ((i * 100) + j).ToString();
					btn1.BackColor = Color.Lime;
					btn1.Tag = new OdaRezervasyon()
					{
						Oda = new Oda()
						{
							Fiyati = i * 50,
							Numarasi = ((i * 100) + j),
							OdaDurum = OdaDurumu.Bos,
							Kapasite = i
						},
					};
					btn1.Click += Btn_Click;
					flpKatlar.Controls.Add(btn1);
				}

			}

		}

		/// <summary>
		/// odanin temizlik durumuna cekilmesini sagladigimiz event. temizlik yazili labela tiklandiginda odayi temizlik durumuna ceker.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lblTemizlik_Click(object sender, EventArgs e)
		{
			secilenOda = tiklanilanButton.Tag as OdaRezervasyon;
			secilenOda.Oda.OdaDurum = OdaDurumu.Temizlik;
			tiklanilanButton.BackColor = Color.DarkBlue;
		}

		/// <summary>
		/// cagirdigin yerde formu temizler.
		/// </summary>
		void FormuTemizle()
		{
			tbAdSoyad.Text = tbAdres.Text = mtbTcKimlik.Text = mtbTcKimlik.Text = mtbDogumTarih.Text= null;
			dtpGirisTarih.Value = dtpCikisTarih.Value = DateTime.Today;
			numKisiSayisi.Value = 0;
			
		}

		/// <summary>
		/// musteri olusturan butonun kontrol yapisi. true donerse musteri olusur.
		/// </summary>
		/// <returns></returns>
		public bool KontrolYapısıExtensionMethod()
		{
			return ExtensionMethod.GirdilerBosMu(tbAdSoyad.Text, mtbDogumTarih.Text, mtbTcKimlik.Text, tbAdres.Text)
			       && ExtensionMethod.SayiVarMi(tbAdSoyad.Text, tbAdres.Text)
			       && ExtensionMethod.TcKimlikKontrol(mtbTcKimlik.Text)
			       && (numKisiSayisi.Value != 0);
		}

	}
}
