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
	public partial class FrmTcRapor : Form
	{
		List<OdaRezervasyon> _rezMusteriler;
		public FrmTcRapor()
		{
			InitializeComponent();
		}
		public FrmTcRapor(List<OdaRezervasyon> rezMusteriler) : this()
		{
			_rezMusteriler = rezMusteriler;
		}

		private void FrmTcRapor_Load(object sender, EventArgs e)
		{
			int sayac = 1;
			foreach (OdaRezervasyon item in _rezMusteriler)
			{
				ListViewItem lv = new ListViewItem(item.Musteri.AdSoyad, 0);
				lv.Text = (sayac++).ToString();
				lv.SubItems.Add(item.Musteri.AdSoyad);
				lv.SubItems.Add(item.Musteri.TcKimlik);
				lstRapor.Items.Add(lv);
			}
		}
	}
}
