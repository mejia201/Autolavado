namespace softwareContable.Views
{
	partial class Dashboard
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
			panelMenuVertical = new Panel();
			btnPlanilla = new Button();
			btnReportes = new Button();
			btnRegistroProductos = new Button();
			btnFormLavadas = new Button();
			label2 = new Label();
			label1 = new Label();
			pictureBox1 = new PictureBox();
			panelBarraTitulo = new Panel();
			panelContenedor = new Panel();
			label3 = new Label();
			timer1 = new System.Windows.Forms.Timer(components);
			panelMenuVertical.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panelContenedor.SuspendLayout();
			SuspendLayout();
			// 
			// panelMenuVertical
			// 
			panelMenuVertical.BackColor = Color.CadetBlue;
			panelMenuVertical.Controls.Add(btnPlanilla);
			panelMenuVertical.Controls.Add(btnReportes);
			panelMenuVertical.Controls.Add(btnRegistroProductos);
			panelMenuVertical.Controls.Add(btnFormLavadas);
			panelMenuVertical.Controls.Add(label2);
			panelMenuVertical.Controls.Add(label1);
			panelMenuVertical.Controls.Add(pictureBox1);
			panelMenuVertical.Dock = DockStyle.Left;
			panelMenuVertical.Location = new Point(0, 0);
			panelMenuVertical.Margin = new Padding(4, 3, 4, 3);
			panelMenuVertical.Name = "panelMenuVertical";
			panelMenuVertical.Size = new Size(292, 641);
			panelMenuVertical.TabIndex = 0;
			panelMenuVertical.Paint += panelMenuVertical_Paint;
			// 
			// btnPlanilla
			// 
			btnPlanilla.FlatAppearance.BorderSize = 0;
			btnPlanilla.FlatAppearance.MouseOverBackColor = SystemColors.GrayText;
			btnPlanilla.FlatStyle = FlatStyle.Flat;
			btnPlanilla.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnPlanilla.ForeColor = Color.White;
			btnPlanilla.ImageAlign = ContentAlignment.MiddleLeft;
			btnPlanilla.Location = new Point(0, 390);
			btnPlanilla.Margin = new Padding(4, 3, 4, 3);
			btnPlanilla.Name = "btnPlanilla";
			btnPlanilla.Size = new Size(292, 46);
			btnPlanilla.TabIndex = 7;
			btnPlanilla.Text = "Pago de salario";
			btnPlanilla.UseVisualStyleBackColor = true;
			btnPlanilla.Click += btnPlanilla_Click;
			// 
			// btnReportes
			// 
			btnReportes.FlatAppearance.BorderSize = 0;
			btnReportes.FlatAppearance.MouseOverBackColor = SystemColors.GrayText;
			btnReportes.FlatStyle = FlatStyle.Flat;
			btnReportes.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnReportes.ForeColor = Color.White;
			btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
			btnReportes.Location = new Point(4, 327);
			btnReportes.Margin = new Padding(4, 3, 4, 3);
			btnReportes.Name = "btnReportes";
			btnReportes.Size = new Size(292, 46);
			btnReportes.TabIndex = 6;
			btnReportes.Text = "Resumen de actividad";
			btnReportes.UseVisualStyleBackColor = true;
			btnReportes.Click += button4_Click;
			// 
			// btnRegistroProductos
			// 
			btnRegistroProductos.FlatAppearance.BorderSize = 0;
			btnRegistroProductos.FlatAppearance.MouseOverBackColor = SystemColors.GrayText;
			btnRegistroProductos.FlatStyle = FlatStyle.Flat;
			btnRegistroProductos.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnRegistroProductos.ForeColor = Color.White;
			btnRegistroProductos.ImageAlign = ContentAlignment.MiddleLeft;
			btnRegistroProductos.Location = new Point(4, 258);
			btnRegistroProductos.Margin = new Padding(4, 3, 4, 3);
			btnRegistroProductos.Name = "btnRegistroProductos";
			btnRegistroProductos.Size = new Size(292, 46);
			btnRegistroProductos.TabIndex = 3;
			btnRegistroProductos.Text = "Registro de productos";
			btnRegistroProductos.UseVisualStyleBackColor = true;
			btnRegistroProductos.Click += button1_Click;
			// 
			// btnFormLavadas
			// 
			btnFormLavadas.FlatAppearance.BorderSize = 0;
			btnFormLavadas.FlatAppearance.MouseOverBackColor = SystemColors.GrayText;
			btnFormLavadas.FlatStyle = FlatStyle.Flat;
			btnFormLavadas.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			btnFormLavadas.ForeColor = Color.White;
			btnFormLavadas.ImageAlign = ContentAlignment.MiddleLeft;
			btnFormLavadas.Location = new Point(0, 188);
			btnFormLavadas.Margin = new Padding(4, 3, 4, 3);
			btnFormLavadas.Name = "btnFormLavadas";
			btnFormLavadas.Size = new Size(292, 46);
			btnFormLavadas.TabIndex = 0;
			btnFormLavadas.Text = "Registro de lavados";
			btnFormLavadas.UseVisualStyleBackColor = true;
			btnFormLavadas.Click += btnFormEmpresa_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.ButtonHighlight;
			label2.Location = new Point(144, 47);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(85, 27);
			label2.TabIndex = 2;
			label2.Text = "Chichi";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.ButtonHighlight;
			label1.Location = new Point(105, 13);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(144, 27);
			label1.TabIndex = 1;
			label1.Text = "Autolavado";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = chichi_autolavado.Properties.Resources.logo;
			pictureBox1.Location = new Point(2, 0);
			pictureBox1.Margin = new Padding(4, 3, 4, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(127, 98);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// panelBarraTitulo
			// 
			panelBarraTitulo.BackColor = Color.WhiteSmoke;
			panelBarraTitulo.Dock = DockStyle.Top;
			panelBarraTitulo.Location = new Point(292, 0);
			panelBarraTitulo.Margin = new Padding(4, 3, 4, 3);
			panelBarraTitulo.Name = "panelBarraTitulo";
			panelBarraTitulo.Size = new Size(961, 52);
			panelBarraTitulo.TabIndex = 1;
			panelBarraTitulo.Paint += panelBarraTitulo_Paint;
			panelBarraTitulo.MouseDown += panelBarraTitulo_MouseDown;
			// 
			// panelContenedor
			// 
			panelContenedor.BackColor = SystemColors.ControlLightLight;
			panelContenedor.Controls.Add(label3);
			panelContenedor.Dock = DockStyle.Fill;
			panelContenedor.Location = new Point(292, 52);
			panelContenedor.Margin = new Padding(4, 3, 4, 3);
			panelContenedor.Name = "panelContenedor";
			panelContenedor.Size = new Size(961, 589);
			panelContenedor.TabIndex = 2;
			panelContenedor.Paint += panelContenedor_Paint_1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 50.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.GrayText;
			label3.Location = new Point(301, 213);
			label3.Name = "label3";
			label3.Size = new Size(397, 82);
			label3.TabIndex = 0;
			label3.Text = "Bienvenido";
			label3.Click += label3_Click;
			// 
			// timer1
			// 
			timer1.Tick += timer1_Tick;
			// 
			// Dashboard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1253, 641);
			Controls.Add(panelContenedor);
			Controls.Add(panelBarraTitulo);
			Controls.Add(panelMenuVertical);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			Name = "Dashboard";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Dashboard";
			Load += Dashboard_Load;
			panelMenuVertical.ResumeLayout(false);
			panelMenuVertical.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panelContenedor.ResumeLayout(false);
			panelContenedor.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelMenuVertical;
		private Panel panelBarraTitulo;
		private Panel panelContenedor;
		private Label label2;
		private Label label1;
		private PictureBox pictureBox1;
		private Button btnFormLavadas;
		private Button btnRegistroProductos;
		private Button btnReportes;
		private System.Windows.Forms.Timer timer1;
		private Button btnPlanilla;
		private Label label3;
	}
}