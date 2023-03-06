namespace OtelOtomasyon.UI
{
	partial class FrmMusteriKayit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMusteriKayit));
			this.flpKatlar = new System.Windows.Forms.FlowLayoutPanel();
			this.grpMusteri = new System.Windows.Forms.GroupBox();
			this.numKisiSayisi = new System.Windows.Forms.NumericUpDown();
			this.dtpCikisTarih = new System.Windows.Forms.DateTimePicker();
			this.dtpGirisTarih = new System.Windows.Forms.DateTimePicker();
			this.mtbDogumTarih = new System.Windows.Forms.MaskedTextBox();
			this.mtbTcKimlik = new System.Windows.Forms.MaskedTextBox();
			this.lblFiyat = new System.Windows.Forms.Label();
			this.btnEkle = new System.Windows.Forms.Button();
			this.tbAdres = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbAdSoyad = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.flpKral = new System.Windows.Forms.FlowLayoutPanel();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblTemizlik = new System.Windows.Forms.Label();
			this.grpMusteri.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numKisiSayisi)).BeginInit();
			this.SuspendLayout();
			// 
			// flpKatlar
			// 
			this.flpKatlar.Location = new System.Drawing.Point(24, 48);
			this.flpKatlar.Name = "flpKatlar";
			this.flpKatlar.Size = new System.Drawing.Size(311, 525);
			this.flpKatlar.TabIndex = 0;
			// 
			// grpMusteri
			// 
			this.grpMusteri.Controls.Add(this.numKisiSayisi);
			this.grpMusteri.Controls.Add(this.dtpCikisTarih);
			this.grpMusteri.Controls.Add(this.dtpGirisTarih);
			this.grpMusteri.Controls.Add(this.mtbDogumTarih);
			this.grpMusteri.Controls.Add(this.mtbTcKimlik);
			this.grpMusteri.Controls.Add(this.lblFiyat);
			this.grpMusteri.Controls.Add(this.btnEkle);
			this.grpMusteri.Controls.Add(this.tbAdres);
			this.grpMusteri.Controls.Add(this.label6);
			this.grpMusteri.Controls.Add(this.label5);
			this.grpMusteri.Controls.Add(this.label10);
			this.grpMusteri.Controls.Add(this.label4);
			this.grpMusteri.Controls.Add(this.label3);
			this.grpMusteri.Controls.Add(this.label2);
			this.grpMusteri.Controls.Add(this.tbAdSoyad);
			this.grpMusteri.Controls.Add(this.label1);
			this.grpMusteri.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.grpMusteri.Location = new System.Drawing.Point(382, 24);
			this.grpMusteri.Name = "grpMusteri";
			this.grpMusteri.Size = new System.Drawing.Size(280, 549);
			this.grpMusteri.TabIndex = 1;
			this.grpMusteri.TabStop = false;
			this.grpMusteri.Text = "Müşteri Rezervasyon Bilgileri";
			// 
			// numKisiSayisi
			// 
			this.numKisiSayisi.Location = new System.Drawing.Point(129, 211);
			this.numKisiSayisi.Name = "numKisiSayisi";
			this.numKisiSayisi.Size = new System.Drawing.Size(110, 25);
			this.numKisiSayisi.TabIndex = 9;
			// 
			// dtpCikisTarih
			// 
			this.dtpCikisTarih.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dtpCikisTarih.Location = new System.Drawing.Point(62, 377);
			this.dtpCikisTarih.Name = "dtpCikisTarih";
			this.dtpCikisTarih.Size = new System.Drawing.Size(200, 22);
			this.dtpCikisTarih.TabIndex = 8;
			// 
			// dtpGirisTarih
			// 
			this.dtpGirisTarih.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dtpGirisTarih.Location = new System.Drawing.Point(62, 306);
			this.dtpGirisTarih.Name = "dtpGirisTarih";
			this.dtpGirisTarih.Size = new System.Drawing.Size(200, 22);
			this.dtpGirisTarih.TabIndex = 8;
			// 
			// mtbDogumTarih
			// 
			this.mtbDogumTarih.Location = new System.Drawing.Point(152, 139);
			this.mtbDogumTarih.Mask = "00/00/0000";
			this.mtbDogumTarih.Name = "mtbDogumTarih";
			this.mtbDogumTarih.Size = new System.Drawing.Size(110, 25);
			this.mtbDogumTarih.TabIndex = 7;
			this.mtbDogumTarih.ValidatingType = typeof(System.DateTime);
			// 
			// mtbTcKimlik
			// 
			this.mtbTcKimlik.Location = new System.Drawing.Point(152, 113);
			this.mtbTcKimlik.Mask = "00000000000";
			this.mtbTcKimlik.Name = "mtbTcKimlik";
			this.mtbTcKimlik.Size = new System.Drawing.Size(110, 25);
			this.mtbTcKimlik.TabIndex = 6;
			this.mtbTcKimlik.ValidatingType = typeof(int);
			// 
			// lblFiyat
			// 
			this.lblFiyat.AutoSize = true;
			this.lblFiyat.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblFiyat.ForeColor = System.Drawing.Color.Indigo;
			this.lblFiyat.Location = new System.Drawing.Point(6, 492);
			this.lblFiyat.Name = "lblFiyat";
			this.lblFiyat.Size = new System.Drawing.Size(50, 19);
			this.lblFiyat.TabIndex = 5;
			this.lblFiyat.Text = "label7";
			// 
			// btnEkle
			// 
			this.btnEkle.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnEkle.Location = new System.Drawing.Point(154, 440);
			this.btnEkle.Name = "btnEkle";
			this.btnEkle.Size = new System.Drawing.Size(85, 43);
			this.btnEkle.TabIndex = 2;
			this.btnEkle.Text = "Ekle";
			this.btnEkle.UseVisualStyleBackColor = true;
			this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
			// 
			// tbAdres
			// 
			this.tbAdres.Location = new System.Drawing.Point(152, 165);
			this.tbAdres.Name = "tbAdres";
			this.tbAdres.Size = new System.Drawing.Size(110, 25);
			this.tbAdres.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(31, 346);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 16);
			this.label6.TabIndex = 0;
			this.label6.Text = "Çıkış Tarihi";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(33, 276);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "Giriş Tarihi";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(59, 213);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(73, 19);
			this.label10.TabIndex = 0;
			this.label10.Text = "Kişi Sayısı";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(82, 166);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "Adresi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(48, 140);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "Doğum Tarihi";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(22, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tc Kimilk Numarası";
			// 
			// tbAdSoyad
			// 
			this.tbAdSoyad.Location = new System.Drawing.Point(152, 87);
			this.tbAdSoyad.Name = "tbAdSoyad";
			this.tbAdSoyad.Size = new System.Drawing.Size(110, 25);
			this.tbAdSoyad.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(22, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Müşteri Adı Soyadı: ";
			// 
			// flpKral
			// 
			this.flpKral.Location = new System.Drawing.Point(173, 12);
			this.flpKral.Name = "flpKral";
			this.flpKral.Size = new System.Drawing.Size(162, 50);
			this.flpKral.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(32, 590);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 17);
			this.label7.TabIndex = 3;
			this.label7.Text = "DOLU";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.ForeColor = System.Drawing.Color.Lime;
			this.label8.Location = new System.Drawing.Point(82, 590);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(33, 17);
			this.label8.TabIndex = 3;
			this.label8.Text = "BOŞ";
			// 
			// lblTemizlik
			// 
			this.lblTemizlik.AutoSize = true;
			this.lblTemizlik.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTemizlik.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTemizlik.Location = new System.Drawing.Point(121, 590);
			this.lblTemizlik.Name = "lblTemizlik";
			this.lblTemizlik.Size = new System.Drawing.Size(66, 17);
			this.lblTemizlik.TabIndex = 3;
			this.lblTemizlik.Text = "TEMİZLİK";
			this.lblTemizlik.Click += new System.EventHandler(this.lblTemizlik_Click);
			// 
			// FrmMusteriKayit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(709, 650);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.flpKral);
			this.Controls.Add(this.lblTemizlik);
			this.Controls.Add(this.grpMusteri);
			this.Controls.Add(this.flpKatlar);
			this.Name = "FrmMusteriKayit";
			this.Text = "FrmMusteriKayit";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.grpMusteri.ResumeLayout(false);
			this.grpMusteri.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numKisiSayisi)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.FlowLayoutPanel flpKatlar;
		private System.Windows.Forms.GroupBox grpMusteri;
		private System.Windows.Forms.Button btnEkle;
		private System.Windows.Forms.TextBox tbAdres;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbAdSoyad;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel flpKral;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblFiyat;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblTemizlik;
		private System.Windows.Forms.MaskedTextBox mtbDogumTarih;
		private System.Windows.Forms.MaskedTextBox mtbTcKimlik;
		private System.Windows.Forms.DateTimePicker dtpCikisTarih;
		private System.Windows.Forms.DateTimePicker dtpGirisTarih;
		private System.Windows.Forms.NumericUpDown numKisiSayisi;
		private System.Windows.Forms.Label label10;
	}
}

