namespace OtelOtomasyon.UI
{
	partial class FrmTcRapor
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
			this.lstRapor = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lstRapor
			// 
			this.lstRapor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lstRapor.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lstRapor.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lstRapor.HideSelection = false;
			this.lstRapor.Location = new System.Drawing.Point(0, 63);
			this.lstRapor.Name = "lstRapor";
			this.lstRapor.Size = new System.Drawing.Size(385, 387);
			this.lstRapor.TabIndex = 0;
			this.lstRapor.UseCompatibleStateImageBehavior = false;
			this.lstRapor.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "No";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Müşteri Adı Soyadı";
			this.columnHeader2.Width = 165;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "T.C. Kimlik Numarası";
			this.columnHeader3.Width = 151;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(47, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(282, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Müşteri T.C Kimlik Numaraları Sıralı Liste";
			// 
			// FrmTcRapor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(385, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstRapor);
			this.Name = "FrmTcRapor";
			this.Text = "FrmTcRapor";
			this.Load += new System.EventHandler(this.FrmTcRapor_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lstRapor;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Label label1;
	}
}