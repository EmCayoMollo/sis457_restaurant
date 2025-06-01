namespace CpRestaurant
{
	partial class FrmPrincipal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
			this.c1Button1 = new C1.Win.C1Input.C1Button();
			((System.ComponentModel.ISupportInitialize)(this.c1Button1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Button1
			// 
			this.c1Button1.Location = new System.Drawing.Point(368, 189);
			this.c1Button1.Name = "c1Button1";
			this.c1Button1.Size = new System.Drawing.Size(75, 23);
			this.c1Button1.TabIndex = 0;
			this.c1Button1.Text = "Platillos";
			this.c1Button1.UseVisualStyleBackColor = true;
			this.c1Button1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
			this.c1Button1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Black;
			this.c1Button1.Click += new System.EventHandler(this.c1Button1_Click);
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.c1Button1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Principal";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.c1Button1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private C1.Win.C1Input.C1Button c1Button1;
	}
}