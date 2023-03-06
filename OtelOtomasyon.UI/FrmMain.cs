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
	public partial class FrmMain : Form
	{
		private List<OdaRezervasyon> form1denGelenList = new List<OdaRezervasyon>(); //musteri kayit 
		private List<OdaRezervasyon> odemeAlinanMusteri = new List<OdaRezervasyon>(); //ödeme alinan musteri

		private FrmMusteriKayit frm1;
		private FrmOdeme frmOdeme;
		private FrmRapor frmRapor;
		private FrmTcRapor frmTcRapor;

		public FrmMain()
		{
			InitializeComponent();
		}

		private void vizyonMisyonToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void acToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm1 = new FrmMusteriKayit();
			frm1.MdiParent = this;
			frm1.Show();
		}

		private void ıslemlerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
		}

		private void tumRaporlarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm1.WindowState = FormWindowState.Minimized;
			frmOdeme.WindowState = FormWindowState.Minimized;
			odemeAlinanMusteri = frmOdeme.Tag as List<OdaRezervasyon>;
			frmRapor = new FrmRapor(odemeAlinanMusteri);
			frmRapor.MdiParent = this;
			frmRapor.Show();
			frmRapor.WindowState = FormWindowState.Maximized;

		}

		private void odemeCikisToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm1.WindowState = FormWindowState.Minimized;
			form1denGelenList = frm1.Tag as List<OdaRezervasyon>;
			frmOdeme = new FrmOdeme(form1denGelenList);
			frmOdeme.MdiParent = this;
			frmOdeme.Show();
			frmOdeme.WindowState = FormWindowState.Maximized;
		}

		private void FrmMain_Load(object sender, EventArgs e)
		{

		}

		private void tcRaporToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frm1.WindowState = FormWindowState.Minimized;
			frmOdeme.WindowState = FormWindowState.Minimized;
			frmRapor.WindowState = FormWindowState.Minimized;
			form1denGelenList = frm1.Tag as List<OdaRezervasyon>;
			frmTcRapor = new FrmTcRapor(form1denGelenList);
			frmTcRapor.MdiParent = this;
			frmTcRapor.Show();
			frmTcRapor.WindowState = FormWindowState.Maximized;

		}
	}
}
