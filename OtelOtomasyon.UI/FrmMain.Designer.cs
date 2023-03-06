namespace OtelOtomasyon.UI
{
	partial class FrmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.otelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vizyonMisyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.misyonumuzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.vizyonumuzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ıslemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.odemeCikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.raporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tumRaporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tcRaporToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.otelToolStripMenuItem,
            this.vizyonMisyonToolStripMenuItem,
            this.ıslemlerToolStripMenuItem,
            this.raporToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(674, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// dosyaToolStripMenuItem
			// 
			this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
			this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
			this.dosyaToolStripMenuItem.Text = "Dosya";
			// 
			// otelToolStripMenuItem
			// 
			this.otelToolStripMenuItem.Name = "otelToolStripMenuItem";
			this.otelToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
			this.otelToolStripMenuItem.Text = "Otel";
			// 
			// vizyonMisyonToolStripMenuItem
			// 
			this.vizyonMisyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.misyonumuzToolStripMenuItem,
            this.vizyonumuzToolStripMenuItem});
			this.vizyonMisyonToolStripMenuItem.Name = "vizyonMisyonToolStripMenuItem";
			this.vizyonMisyonToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
			this.vizyonMisyonToolStripMenuItem.Text = "Vizyon-Misyon";
			// 
			// misyonumuzToolStripMenuItem
			// 
			this.misyonumuzToolStripMenuItem.Name = "misyonumuzToolStripMenuItem";
			this.misyonumuzToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.misyonumuzToolStripMenuItem.Text = "Misyonumuz";
			// 
			// vizyonumuzToolStripMenuItem
			// 
			this.vizyonumuzToolStripMenuItem.Name = "vizyonumuzToolStripMenuItem";
			this.vizyonumuzToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
			this.vizyonumuzToolStripMenuItem.Text = "Vizyonumuz";
			// 
			// ıslemlerToolStripMenuItem
			// 
			this.ıslemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acToolStripMenuItem,
            this.odemeCikisToolStripMenuItem});
			this.ıslemlerToolStripMenuItem.Name = "ıslemlerToolStripMenuItem";
			this.ıslemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.ıslemlerToolStripMenuItem.Text = "İşlemler";
			this.ıslemlerToolStripMenuItem.Click += new System.EventHandler(this.ıslemlerToolStripMenuItem_Click);
			// 
			// acToolStripMenuItem
			// 
			this.acToolStripMenuItem.Name = "acToolStripMenuItem";
			this.acToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.acToolStripMenuItem.Text = "Rezervasyon Oluştur";
			this.acToolStripMenuItem.Click += new System.EventHandler(this.acToolStripMenuItem_Click);
			// 
			// odemeCikisToolStripMenuItem
			// 
			this.odemeCikisToolStripMenuItem.Name = "odemeCikisToolStripMenuItem";
			this.odemeCikisToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
			this.odemeCikisToolStripMenuItem.Text = "Ödeme-Çıkış";
			this.odemeCikisToolStripMenuItem.Click += new System.EventHandler(this.odemeCikisToolStripMenuItem_Click);
			// 
			// raporToolStripMenuItem
			// 
			this.raporToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tumRaporlarToolStripMenuItem,
            this.tcRaporToolStripMenuItem});
			this.raporToolStripMenuItem.Name = "raporToolStripMenuItem";
			this.raporToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
			this.raporToolStripMenuItem.Text = "Rapor";
			// 
			// tumRaporlarToolStripMenuItem
			// 
			this.tumRaporlarToolStripMenuItem.Name = "tumRaporlarToolStripMenuItem";
			this.tumRaporlarToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.tumRaporlarToolStripMenuItem.Text = "Çıkış Yapan Müşteriler";
			this.tumRaporlarToolStripMenuItem.Click += new System.EventHandler(this.tumRaporlarToolStripMenuItem_Click);
			// 
			// tcRaporToolStripMenuItem
			// 
			this.tcRaporToolStripMenuItem.Name = "tcRaporToolStripMenuItem";
			this.tcRaporToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
			this.tcRaporToolStripMenuItem.Text = "T.C. Kimlik No Liste";
			this.tcRaporToolStripMenuItem.Click += new System.EventHandler(this.tcRaporToolStripMenuItem_Click);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(674, 426);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FrmMain";
			this.Text = "FrmMain";
			this.Load += new System.EventHandler(this.FrmMain_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem otelToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vizyonMisyonToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ıslemlerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem raporToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tumRaporlarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem misyonumuzToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem vizyonumuzToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem odemeCikisToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tcRaporToolStripMenuItem;
	}
}