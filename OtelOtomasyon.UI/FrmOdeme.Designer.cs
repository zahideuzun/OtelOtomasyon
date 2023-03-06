namespace OtelOtomasyon.UI
{
	partial class FrmOdeme
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdeme));
			this.cmbMusteriler = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSec = new System.Windows.Forms.Button();
			this.grpMusteri = new System.Windows.Forms.GroupBox();
			this.lblAdSoyad = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.grpOdeme = new System.Windows.Forms.GroupBox();
			this.btnOdemeAl = new System.Windows.Forms.Button();
			this.lblAraToplam = new System.Windows.Forms.Label();
			this.lblToplam = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.flEkHizmetler = new System.Windows.Forms.FlowLayoutPanel();
			this.label7 = new System.Windows.Forms.Label();
			this.numHizmet = new System.Windows.Forms.NumericUpDown();
			this.btnHizmetEkle = new System.Windows.Forms.Button();
			this.dtpSonCikisTarih = new System.Windows.Forms.DateTimePicker();
			this.btnHesapla = new System.Windows.Forms.Button();
			this.grpMusteri.SuspendLayout();
			this.grpOdeme.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numHizmet)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbMusteriler
			// 
			this.cmbMusteriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMusteriler.FormattingEnabled = true;
			this.cmbMusteriler.Location = new System.Drawing.Point(146, 40);
			this.cmbMusteriler.Name = "cmbMusteriler";
			this.cmbMusteriler.Size = new System.Drawing.Size(216, 21);
			this.cmbMusteriler.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(52, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Müşteri Seç";
			// 
			// btnSec
			// 
			this.btnSec.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSec.Location = new System.Drawing.Point(381, 34);
			this.btnSec.Name = "btnSec";
			this.btnSec.Size = new System.Drawing.Size(75, 31);
			this.btnSec.TabIndex = 3;
			this.btnSec.Text = "SEÇ";
			this.btnSec.UseVisualStyleBackColor = true;
			this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
			// 
			// grpMusteri
			// 
			this.grpMusteri.BackColor = System.Drawing.SystemColors.Control;
			this.grpMusteri.Controls.Add(this.lblAdSoyad);
			this.grpMusteri.Controls.Add(this.label3);
			this.grpMusteri.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.grpMusteri.Location = new System.Drawing.Point(15, 85);
			this.grpMusteri.Name = "grpMusteri";
			this.grpMusteri.Size = new System.Drawing.Size(275, 84);
			this.grpMusteri.TabIndex = 4;
			this.grpMusteri.TabStop = false;
			this.grpMusteri.Text = "Müşteri";
			// 
			// lblAdSoyad
			// 
			this.lblAdSoyad.AutoSize = true;
			this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAdSoyad.Location = new System.Drawing.Point(126, 38);
			this.lblAdSoyad.Name = "lblAdSoyad";
			this.lblAdSoyad.Size = new System.Drawing.Size(74, 19);
			this.lblAdSoyad.TabIndex = 0;
			this.lblAdSoyad.Text = "Adı Soyadı";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(20, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 19);
			this.label3.TabIndex = 0;
			this.label3.Text = "Adı Soyadı";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(308, 117);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Çıkış Tarihi";
			// 
			// grpOdeme
			// 
			this.grpOdeme.Controls.Add(this.btnOdemeAl);
			this.grpOdeme.Controls.Add(this.lblAraToplam);
			this.grpOdeme.Controls.Add(this.lblToplam);
			this.grpOdeme.Controls.Add(this.label8);
			this.grpOdeme.Controls.Add(this.label6);
			this.grpOdeme.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.grpOdeme.Location = new System.Drawing.Point(196, 217);
			this.grpOdeme.Name = "grpOdeme";
			this.grpOdeme.Size = new System.Drawing.Size(315, 320);
			this.grpOdeme.TabIndex = 6;
			this.grpOdeme.TabStop = false;
			this.grpOdeme.Text = "ÖDENECEK TUTAR";
			// 
			// btnOdemeAl
			// 
			this.btnOdemeAl.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnOdemeAl.Location = new System.Drawing.Point(75, 244);
			this.btnOdemeAl.Name = "btnOdemeAl";
			this.btnOdemeAl.Size = new System.Drawing.Size(162, 40);
			this.btnOdemeAl.TabIndex = 1;
			this.btnOdemeAl.Text = "ÖDEME AL";
			this.btnOdemeAl.UseVisualStyleBackColor = true;
			this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
			// 
			// lblAraToplam
			// 
			this.lblAraToplam.AutoSize = true;
			this.lblAraToplam.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAraToplam.Location = new System.Drawing.Point(6, 69);
			this.lblAraToplam.Name = "lblAraToplam";
			this.lblAraToplam.Size = new System.Drawing.Size(80, 17);
			this.lblAraToplam.TabIndex = 0;
			this.lblAraToplam.Text = "Ara Toplam";
			// 
			// lblToplam
			// 
			this.lblToplam.AutoSize = true;
			this.lblToplam.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblToplam.Location = new System.Drawing.Point(72, 188);
			this.lblToplam.Name = "lblToplam";
			this.lblToplam.Size = new System.Drawing.Size(62, 17);
			this.lblToplam.TabIndex = 0;
			this.lblToplam.Text = "TOPLAM";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.Location = new System.Drawing.Point(86, 152);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(62, 17);
			this.label8.TabIndex = 0;
			this.label8.Text = "TOPLAM";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(86, 49);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "Ara Toplam";
			// 
			// flEkHizmetler
			// 
			this.flEkHizmetler.Location = new System.Drawing.Point(27, 224);
			this.flEkHizmetler.Name = "flEkHizmetler";
			this.flEkHizmetler.Size = new System.Drawing.Size(110, 298);
			this.flEkHizmetler.TabIndex = 9;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(12, 205);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(117, 16);
			this.label7.TabIndex = 10;
			this.label7.Text = "Ek Ücretli Hizmetler";
			// 
			// numHizmet
			// 
			this.numHizmet.Location = new System.Drawing.Point(54, 528);
			this.numHizmet.Name = "numHizmet";
			this.numHizmet.Size = new System.Drawing.Size(44, 20);
			this.numHizmet.TabIndex = 11;
			// 
			// btnHizmetEkle
			// 
			this.btnHizmetEkle.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnHizmetEkle.Location = new System.Drawing.Point(37, 554);
			this.btnHizmetEkle.Name = "btnHizmetEkle";
			this.btnHizmetEkle.Size = new System.Drawing.Size(84, 30);
			this.btnHizmetEkle.TabIndex = 12;
			this.btnHizmetEkle.Text = "EKLE";
			this.btnHizmetEkle.UseVisualStyleBackColor = true;
			this.btnHizmetEkle.Click += new System.EventHandler(this.btnHizmetEkle_Click);
			// 
			// dtpSonCikisTarih
			// 
			this.dtpSonCikisTarih.Location = new System.Drawing.Point(311, 137);
			this.dtpSonCikisTarih.Name = "dtpSonCikisTarih";
			this.dtpSonCikisTarih.Size = new System.Drawing.Size(200, 20);
			this.dtpSonCikisTarih.TabIndex = 15;
			// 
			// btnHesapla
			// 
			this.btnHesapla.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnHesapla.Location = new System.Drawing.Point(402, 165);
			this.btnHesapla.Name = "btnHesapla";
			this.btnHesapla.Size = new System.Drawing.Size(75, 32);
			this.btnHesapla.TabIndex = 16;
			this.btnHesapla.Text = "Hesapla";
			this.btnHesapla.UseVisualStyleBackColor = true;
			this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
			// 
			// FrmOdeme
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(538, 595);
			this.Controls.Add(this.btnHesapla);
			this.Controls.Add(this.dtpSonCikisTarih);
			this.Controls.Add(this.btnHizmetEkle);
			this.Controls.Add(this.numHizmet);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.flEkHizmetler);
			this.Controls.Add(this.grpOdeme);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.grpMusteri);
			this.Controls.Add(this.btnSec);
			this.Controls.Add(this.cmbMusteriler);
			this.Controls.Add(this.label2);
			this.Name = "FrmOdeme";
			this.Text = "FrmOdeme";
			this.Load += new System.EventHandler(this.FrmOdeme_Load);
			this.grpMusteri.ResumeLayout(false);
			this.grpMusteri.PerformLayout();
			this.grpOdeme.ResumeLayout(false);
			this.grpOdeme.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numHizmet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox cmbMusteriler;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSec;
		private System.Windows.Forms.GroupBox grpMusteri;
		private System.Windows.Forms.Label lblAdSoyad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox grpOdeme;
		private System.Windows.Forms.Button btnOdemeAl;
		private System.Windows.Forms.Label lblAraToplam;
		private System.Windows.Forms.Label lblToplam;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.FlowLayoutPanel flEkHizmetler;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown numHizmet;
		private System.Windows.Forms.Button btnHizmetEkle;
		private System.Windows.Forms.DateTimePicker dtpSonCikisTarih;
		private System.Windows.Forms.Button btnHesapla;
	}
}