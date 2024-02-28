namespace chichi_autolavado.Views
{
	partial class Productos
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			total_gasto = new Label();
			label6 = new Label();
			btnIngresarProducto = new Button();
			dataGridViewProductos = new DataGridView();
			groupBox1 = new GroupBox();
			txtPrecio = new TextBox();
			txtNombre = new TextBox();
			label5 = new Label();
			label1 = new Label();
			label3 = new Label();
			dtpFechaActual = new DateTimePicker();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// total_gasto
			// 
			total_gasto.AutoSize = true;
			total_gasto.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			total_gasto.ForeColor = SystemColors.ActiveCaptionText;
			total_gasto.Location = new Point(750, 545);
			total_gasto.Margin = new Padding(4, 0, 4, 0);
			total_gasto.Name = "total_gasto";
			total_gasto.Size = new Size(53, 19);
			total_gasto.TabIndex = 100;
			total_gasto.Text = "$ 0.00";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label6.ForeColor = Color.Red;
			label6.Location = new Point(656, 545);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(94, 19);
			label6.TabIndex = 99;
			label6.Text = "Gasto total:";
			// 
			// btnIngresarProducto
			// 
			btnIngresarProducto.BackColor = Color.FromArgb(0, 122, 204);
			btnIngresarProducto.Cursor = Cursors.Hand;
			btnIngresarProducto.FlatAppearance.BorderSize = 0;
			btnIngresarProducto.FlatAppearance.MouseDownBackColor = Color.White;
			btnIngresarProducto.FlatAppearance.MouseOverBackColor = SystemColors.GrayText;
			btnIngresarProducto.FlatStyle = FlatStyle.Flat;
			btnIngresarProducto.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnIngresarProducto.ForeColor = Color.White;
			btnIngresarProducto.Location = new Point(408, 280);
			btnIngresarProducto.Margin = new Padding(4, 3, 4, 3);
			btnIngresarProducto.Name = "btnIngresarProducto";
			btnIngresarProducto.Size = new Size(169, 44);
			btnIngresarProducto.TabIndex = 98;
			btnIngresarProducto.Text = "Guardar";
			btnIngresarProducto.UseVisualStyleBackColor = false;
			btnIngresarProducto.Click += btnIngresarProducto_Click;
			// 
			// dataGridViewProductos
			// 
			dataGridViewProductos.BackgroundColor = Color.WhiteSmoke;
			dataGridViewProductos.BorderStyle = BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			dataGridViewProductos.DefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewProductos.Location = new Point(161, 346);
			dataGridViewProductos.Margin = new Padding(4, 3, 4, 3);
			dataGridViewProductos.Name = "dataGridViewProductos";
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			dataGridViewProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			dataGridViewProductos.RowHeadersWidth = 120;
			dataGridViewProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewProductos.Size = new Size(649, 186);
			dataGridViewProductos.TabIndex = 96;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(txtPrecio);
			groupBox1.Controls.Add(txtNombre);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(dtpFechaActual);
			groupBox1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			groupBox1.Location = new Point(68, 80);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(825, 179);
			groupBox1.TabIndex = 97;
			groupBox1.TabStop = false;
			groupBox1.Text = "Datos Requeridos";
			// 
			// txtPrecio
			// 
			txtPrecio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtPrecio.Location = new Point(544, 113);
			txtPrecio.Name = "txtPrecio";
			txtPrecio.Size = new Size(181, 27);
			txtPrecio.TabIndex = 103;
			// 
			// txtNombre
			// 
			txtNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtNombre.Location = new Point(180, 113);
			txtNombre.Name = "txtNombre";
			txtNombre.Size = new Size(246, 27);
			txtNombre.TabIndex = 102;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(90, 115);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(95, 23);
			label5.TabIndex = 101;
			label5.Text = "Nombre: ";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(473, 115);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(73, 23);
			label1.TabIndex = 99;
			label1.Text = "Precio:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = Color.FromArgb(202, 48, 61);
			label3.Location = new Point(220, 45);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(118, 20);
			label3.TabIndex = 13;
			label3.Text = "Fecha de hoy: ";
			// 
			// dtpFechaActual
			// 
			dtpFechaActual.CalendarFont = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			dtpFechaActual.Enabled = false;
			dtpFechaActual.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			dtpFechaActual.Location = new Point(338, 42);
			dtpFechaActual.Margin = new Padding(0);
			dtpFechaActual.Name = "dtpFechaActual";
			dtpFechaActual.Size = new Size(289, 26);
			dtpFechaActual.TabIndex = 95;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = Color.FromArgb(0, 122, 204);
			label2.Location = new Point(370, 30);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(271, 30);
			label2.TabIndex = 95;
			label2.Text = "Registro de Productos";
			// 
			// Productos
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(960, 588);
			Controls.Add(total_gasto);
			Controls.Add(label6);
			Controls.Add(btnIngresarProducto);
			Controls.Add(dataGridViewProductos);
			Controls.Add(groupBox1);
			Controls.Add(label2);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Productos";
			Text = "Productos";
			FormClosing += Productos_FormClosing;
			Load += Productos_Load;
			((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label total_gasto;
		private Label label6;
		private Button btnIngresarProducto;
		private DataGridView dataGridViewProductos;
		private GroupBox groupBox1;
		private TextBox txtNombre;
		private Label label5;
		private Label label1;
		private Label label3;
		private DateTimePicker dtpFechaActual;
		private Label label2;
		private TextBox txtPrecio;
	}
}