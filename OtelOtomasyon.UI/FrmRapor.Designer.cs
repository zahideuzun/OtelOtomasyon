namespace OtelOtomasyon.UI
{
	partial class FrmRapor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRapor));
			this.lstRapor = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.tbMusteriAra = new System.Windows.Forms.TextBox();
			this.btnAra = new System.Windows.Forms.Button();
			this.numTarih1 = new System.Windows.Forms.DateTimePicker();
			this.numTarih2 = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnTarihAra = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstRapor
			// 
			this.lstRapor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
			this.lstRapor.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lstRapor.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lstRapor.HideSelection = false;
			this.lstRapor.Location = new System.Drawing.Point(0, 175);
			this.lstRapor.Name = "lstRapor";
			this.lstRapor.Size = new System.Drawing.Size(691, 335);
			this.lstRapor.TabIndex = 0;
			this.lstRapor.UseCompatibleStateImageBehavior = false;
			this.lstRapor.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "No";
			this.columnHeader1.Width = 46;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Müşteri Adı Soyadı";
			this.columnHeader2.Width = 122;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Tc Kimlik No";
			this.columnHeader3.Width = 96;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Giriş Tarihi";
			this.columnHeader4.Width = 118;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Çıkış Tarihi";
			this.columnHeader5.Width = 128;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Odası";
			this.columnHeader6.Width = 100;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Ödeme";
			this.columnHeader7.Width = 88;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(132, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Müşteri Ara";
			// 
			// tbMusteriAra
			// 
			this.tbMusteriAra.Location = new System.Drawing.Point(226, 37);
			this.tbMusteriAra.Multiline = true;
			this.tbMusteriAra.Name = "tbMusteriAra";
			this.tbMusteriAra.Size = new System.Drawing.Size(216, 37);
			this.tbMusteriAra.TabIndex = 3;
			// 
			// btnAra
			// 
			this.btnAra.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAra.Location = new System.Drawing.Point(448, 45);
			this.btnAra.Name = "btnAra";
			this.btnAra.Size = new System.Drawing.Size(60, 23);
			this.btnAra.TabIndex = 6;
			this.btnAra.Text = "Ara";
			this.btnAra.UseVisualStyleBackColor = true;
			this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
			// 
			// numTarih1
			// 
			this.numTarih1.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.numTarih1.Location = new System.Drawing.Point(84, 118);
			this.numTarih1.Name = "numTarih1";
			this.numTarih1.Size = new System.Drawing.Size(216, 20);
			this.numTarih1.TabIndex = 7;
			// 
			// numTarih2
			// 
			this.numTarih2.CalendarFont = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.numTarih2.Location = new System.Drawing.Point(337, 118);
			this.numTarih2.Name = "numTarih2";
			this.numTarih2.Size = new System.Drawing.Size(216, 20);
			this.numTarih2.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(109, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Tarih Aralığı Seç";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(306, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "----";
			// 
			// btnTarihAra
			// 
			this.btnTarihAra.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnTarihAra.Location = new System.Drawing.Point(574, 115);
			this.btnTarihAra.Name = "btnTarihAra";
			this.btnTarihAra.Size = new System.Drawing.Size(75, 23);
			this.btnTarihAra.TabIndex = 9;
			this.btnTarihAra.Text = "Ara";
			this.btnTarihAra.UseVisualStyleBackColor = true;
			this.btnTarihAra.Click += new System.EventHandler(this.btnTarihAra_Click);
			// 
			// FrmRapor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(691, 510);
			this.Controls.Add(this.btnTarihAra);
			this.Controls.Add(this.numTarih2);
			this.Controls.Add(this.numTarih1);
			this.Controls.Add(this.btnAra);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbMusteriAra);
			this.Controls.Add(this.lstRapor);
			this.Name = "FrmRapor";
			this.Text = "FrmRapor";
			this.Load += new System.EventHandler(this.FrmRapor_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lstRapor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbMusteriAra;
		private System.Windows.Forms.Button btnAra;
		private System.Windows.Forms.DateTimePicker numTarih1;
		private System.Windows.Forms.DateTimePicker numTarih2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.Button btnTarihAra;
	}
}