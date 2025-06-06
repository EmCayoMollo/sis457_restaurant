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
			this.c1Ribbon1 = new C1.Win.C1Ribbon.C1Ribbon();
			this.ribbonApplicationMenu1 = new C1.Win.C1Ribbon.RibbonApplicationMenu();
			this.ribbonBottomToolBar1 = new C1.Win.C1Ribbon.RibbonBottomToolBar();
			this.ribbonConfigToolBar1 = new C1.Win.C1Ribbon.RibbonConfigToolBar();
			this.ribbonQat1 = new C1.Win.C1Ribbon.RibbonQat();
			this.ribbonTab1 = new C1.Win.C1Ribbon.RibbonTab();
			this.ribbonGroup1 = new C1.Win.C1Ribbon.RibbonGroup();
			this.btnEmpleado = new C1.Win.C1Ribbon.RibbonButton();
			this.ribbonButton2 = new C1.Win.C1Ribbon.RibbonButton();
			this.btnClientes = new C1.Win.C1Ribbon.RibbonButton();
			this.ribbonTab2 = new C1.Win.C1Ribbon.RibbonTab();
			this.ribbonGroup2 = new C1.Win.C1Ribbon.RibbonGroup();
			this.btnPlatillos = new C1.Win.C1Ribbon.RibbonButton();
			this.ribbonButton4 = new C1.Win.C1Ribbon.RibbonButton();
			this.ribbonTab3 = new C1.Win.C1Ribbon.RibbonTab();
			this.ribbonGroup3 = new C1.Win.C1Ribbon.RibbonGroup();
			this.btnVenta = new C1.Win.C1Ribbon.RibbonButton();
			this.ribbonTopToolBar1 = new C1.Win.C1Ribbon.RibbonTopToolBar();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// c1Ribbon1
			// 
			this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
			this.c1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
			this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
			this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
			this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
			this.c1Ribbon1.Name = "c1Ribbon1";
			this.c1Ribbon1.QatHolder = this.ribbonQat1;
			this.c1Ribbon1.Size = new System.Drawing.Size(800, 156);
			this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
			this.c1Ribbon1.Tabs.Add(this.ribbonTab2);
			this.c1Ribbon1.Tabs.Add(this.ribbonTab3);
			this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
			// 
			// ribbonApplicationMenu1
			// 
			this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
			// 
			// ribbonBottomToolBar1
			// 
			this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
			// 
			// ribbonConfigToolBar1
			// 
			this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
			// 
			// ribbonQat1
			// 
			this.ribbonQat1.Name = "ribbonQat1";
			// 
			// ribbonTab1
			// 
			this.ribbonTab1.Groups.Add(this.ribbonGroup1);
			this.ribbonTab1.Name = "ribbonTab1";
			this.ribbonTab1.Text = "Personal";
			// 
			// ribbonGroup1
			// 
			this.ribbonGroup1.Items.Add(this.btnEmpleado);
			this.ribbonGroup1.Items.Add(this.ribbonButton2);
			this.ribbonGroup1.Items.Add(this.btnClientes);
			this.ribbonGroup1.Name = "ribbonGroup1";
			this.ribbonGroup1.Text = "Equipo";
			// 
			// btnEmpleado
			// 
			this.btnEmpleado.LargeImage = global::CpRestaurant.Properties.Resources.person_50dp_000000_FILL1_wght400_GRAD0_opsz48;
			this.btnEmpleado.Name = "btnEmpleado";
			this.btnEmpleado.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnEmpleado.SmallImage")));
			this.btnEmpleado.Text = "Empleados";
			this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
			// 
			// ribbonButton2
			// 
			this.ribbonButton2.LargeImage = global::CpRestaurant.Properties.Resources.person_50dp_000000_FILL1_wght400_GRAD0_opsz48;
			this.ribbonButton2.Name = "ribbonButton2";
			this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
			this.ribbonButton2.Text = "Usuario";
			// 
			// btnClientes
			// 
			this.btnClientes.LargeImage = global::CpRestaurant.Properties.Resources.person_50dp_000000_FILL1_wght400_GRAD0_opsz48;
			this.btnClientes.Name = "btnClientes";
			this.btnClientes.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.SmallImage")));
			this.btnClientes.Text = "Clientes";
			this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
			// 
			// ribbonTab2
			// 
			this.ribbonTab2.Groups.Add(this.ribbonGroup2);
			this.ribbonTab2.Name = "ribbonTab2";
			this.ribbonTab2.Text = "Inventario";
			// 
			// ribbonGroup2
			// 
			this.ribbonGroup2.Items.Add(this.btnPlatillos);
			this.ribbonGroup2.Items.Add(this.ribbonButton4);
			this.ribbonGroup2.Name = "ribbonGroup2";
			this.ribbonGroup2.Text = "Group";
			// 
			// btnPlatillos
			// 
			this.btnPlatillos.LargeImage = global::CpRestaurant.Properties.Resources.dining_50dp_000000_FILL1_wght400_GRAD0_opsz48;
			this.btnPlatillos.Name = "btnPlatillos";
			this.btnPlatillos.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnPlatillos.SmallImage")));
			this.btnPlatillos.Text = "Platillos";
			this.btnPlatillos.Click += new System.EventHandler(this.btnPlatillos_Click);
			// 
			// ribbonButton4
			// 
			this.ribbonButton4.LargeImage = global::CpRestaurant.Properties.Resources.nutrition_40dp_000000_FILL1_wght400_GRAD0_opsz40;
			this.ribbonButton4.Name = "ribbonButton4";
			this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
			this.ribbonButton4.Text = "Insumo";
			// 
			// ribbonTab3
			// 
			this.ribbonTab3.Groups.Add(this.ribbonGroup3);
			this.ribbonTab3.Name = "ribbonTab3";
			this.ribbonTab3.Text = "Compra/Venta";
			// 
			// ribbonGroup3
			// 
			this.ribbonGroup3.Items.Add(this.btnVenta);
			this.ribbonGroup3.Name = "ribbonGroup3";
			this.ribbonGroup3.Text = "Compra/Venta";
			// 
			// btnVenta
			// 
			this.btnVenta.LargeImage = global::CpRestaurant.Properties.Resources.point_of_sale_40dp_000000_FILL1_wght400_GRAD0_opsz40;
			this.btnVenta.Name = "btnVenta";
			this.btnVenta.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnVenta.SmallImage")));
			this.btnVenta.Text = "Venta";
			this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
			// 
			// ribbonTopToolBar1
			// 
			this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = global::CpRestaurant.Properties.Resources.plana_laicos_pollo_al_horno_y_rodajas_de_naranja_en_un_plato_con_cubiertos_y_bloc_de_notas_en_blanco;
			this.pictureBox1.Location = new System.Drawing.Point(0, 156);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(800, 294);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// FrmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.c1Ribbon1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrmPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Principal";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private C1.Win.C1Ribbon.C1Ribbon c1Ribbon1;
		private C1.Win.C1Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
		private C1.Win.C1Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
		private C1.Win.C1Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
		private C1.Win.C1Ribbon.RibbonQat ribbonQat1;
		private C1.Win.C1Ribbon.RibbonTab ribbonTab1;
		private C1.Win.C1Ribbon.RibbonGroup ribbonGroup1;
		private C1.Win.C1Ribbon.RibbonButton btnEmpleado;
		private C1.Win.C1Ribbon.RibbonTab ribbonTab2;
		private C1.Win.C1Ribbon.RibbonGroup ribbonGroup2;
		private C1.Win.C1Ribbon.RibbonTab ribbonTab3;
		private C1.Win.C1Ribbon.RibbonGroup ribbonGroup3;
		private C1.Win.C1Ribbon.RibbonTopToolBar ribbonTopToolBar1;
		private C1.Win.C1Ribbon.RibbonButton ribbonButton2;
		private C1.Win.C1Ribbon.RibbonButton btnPlatillos;
		private C1.Win.C1Ribbon.RibbonButton ribbonButton4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private C1.Win.C1Ribbon.RibbonButton btnVenta;
		private C1.Win.C1Ribbon.RibbonButton btnClientes;
	}
}