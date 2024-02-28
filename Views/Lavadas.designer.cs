namespace softwareContable.Views
{
	partial class Lavadas
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
			label2 = new Label();
			label3 = new Label();
			groupBox1 = new GroupBox();
			label5 = new Label();
			label4 = new Label();
			label1 = new Label();
			cmbPrecio = new ComboBox();
			comboBoxModelos = new ComboBox();
			comboBoxMarcas = new ComboBox();
			dtpFechaActual = new DateTimePicker();
			dataGridViewLavados = new DataGridView();
			btnIngresar = new Button();
			label6 = new Label();
			total_dia = new Label();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewLavados).BeginInit();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = Color.FromArgb(0, 122, 204);
			label2.Location = new Point(371, 29);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(253, 30);
			label2.TabIndex = 1;
			label2.Text = "Registro de Lavados";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = Color.FromArgb(202, 48, 61);
			label3.Location = new Point(219, 45);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(118, 20);
			label3.TabIndex = 13;
			label3.Text = "Fecha de hoy: ";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(cmbPrecio);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(comboBoxModelos);
			groupBox1.Controls.Add(comboBoxMarcas);
			groupBox1.Controls.Add(dtpFechaActual);
			groupBox1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			groupBox1.Location = new Point(69, 79);
			groupBox1.Margin = new Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new Padding(4, 3, 4, 3);
			groupBox1.Size = new Size(825, 179);
			groupBox1.TabIndex = 90;
			groupBox1.TabStop = false;
			groupBox1.Text = "Datos Requeridos";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label5.Location = new Point(32, 115);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(71, 23);
			label5.TabIndex = 101;
			label5.Text = "Marca";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label4.Location = new Point(338, 115);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(81, 23);
			label4.TabIndex = 100;
			label4.Text = "Modelo";
			label4.Click += label4_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(635, 115);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(68, 23);
			label1.TabIndex = 99;
			label1.Text = "Precio";
			// 
			// cmbPrecio
			// 
			cmbPrecio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			cmbPrecio.FormattingEnabled = true;
			cmbPrecio.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
			cmbPrecio.Location = new Point(705, 113);
			cmbPrecio.Name = "cmbPrecio";
			cmbPrecio.Size = new Size(81, 29);
			cmbPrecio.TabIndex = 98;
			cmbPrecio.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
			// 
			// comboBoxModelos
			// 
			comboBoxModelos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			comboBoxModelos.FormattingEnabled = true;
			comboBoxModelos.Location = new Point(419, 114);
			comboBoxModelos.Name = "comboBoxModelos";
			comboBoxModelos.Size = new Size(181, 29);
			comboBoxModelos.TabIndex = 97;
			// 
			// comboBoxMarcas
			// 
			comboBoxMarcas.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			comboBoxMarcas.FormattingEnabled = true;
			comboBoxMarcas.Location = new Point(103, 114);
			comboBoxMarcas.Name = "comboBoxMarcas";
			comboBoxMarcas.Size = new Size(181, 29);
			comboBoxMarcas.TabIndex = 96;
			comboBoxMarcas.SelectedIndexChanged += comboBoxMarcas_SelectedIndexChanged;
			// 
			// dtpFechaActual
			// 
			dtpFechaActual.CalendarFont = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			dtpFechaActual.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			dtpFechaActual.Location = new Point(338, 42);
			dtpFechaActual.Margin = new Padding(0);
			dtpFechaActual.Name = "dtpFechaActual";
			dtpFechaActual.Size = new Size(289, 26);
			dtpFechaActual.TabIndex = 95;
			// 
			// dataGridViewLavados
			// 
			dataGridViewLavados.BackgroundColor = Color.WhiteSmoke;
			dataGridViewLavados.BorderStyle = BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridViewLavados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewLavados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			dataGridViewLavados.DefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewLavados.Location = new Point(162, 348);
			dataGridViewLavados.Margin = new Padding(4, 3, 4, 3);
			dataGridViewLavados.Name = "dataGridViewLavados";
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			dataGridViewLavados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			dataGridViewLavados.RowHeadersWidth = 120;
			dataGridViewLavados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewLavados.Size = new Size(649, 186);
			dataGridViewLavados.TabIndex = 2;
			// 
			// btnIngresar
			// 
			btnIngresar.BackColor = Color.FromArgb(0, 122, 204);
			btnIngresar.Cursor = Cursors.Hand;
			btnIngresar.FlatAppearance.BorderSize = 0;
			btnIngresar.FlatAppearance.MouseDownBackColor = Color.White;
			btnIngresar.FlatAppearance.MouseOverBackColor = SystemColors.GrayText;
			btnIngresar.FlatStyle = FlatStyle.Flat;
			btnIngresar.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnIngresar.ForeColor = Color.White;
			btnIngresar.Location = new Point(409, 280);
			btnIngresar.Margin = new Padding(4, 3, 4, 3);
			btnIngresar.Name = "btnIngresar";
			btnIngresar.Size = new Size(169, 44);
			btnIngresar.TabIndex = 92;
			btnIngresar.Text = "Guardar";
			btnIngresar.UseVisualStyleBackColor = false;
			btnIngresar.Click += btnIngresar_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label6.ForeColor = Color.Green;
			label6.Location = new Point(608, 547);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(143, 19);
			label6.TabIndex = 93;
			label6.Text = "Ganancia diaria:";
			// 
			// total_dia
			// 
			total_dia.AutoSize = true;
			total_dia.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			total_dia.ForeColor = SystemColors.ActiveCaptionText;
			total_dia.Location = new Point(751, 547);
			total_dia.Margin = new Padding(4, 0, 4, 0);
			total_dia.Name = "total_dia";
			total_dia.Size = new Size(53, 19);
			total_dia.TabIndex = 94;
			total_dia.Text = "$ 0.00";
			// 
			// Lavadas
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(960, 588);
			Controls.Add(total_dia);
			Controls.Add(label6);
			Controls.Add(btnIngresar);
			Controls.Add(dataGridViewLavados);
			Controls.Add(groupBox1);
			Controls.Add(label2);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(4, 3, 4, 3);
			Name = "Lavadas";
			StartPosition = FormStartPosition.WindowsDefaultBounds;
			Text = "Lavadas";
			FormClosing += Lavadas_FormClosing;
			Load += Empresa_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridViewLavados).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label2;
		private Label label3;
		private GroupBox groupBox1;
		private DataGridView dataGridViewLavados;
		private Button btnIngresar;
		private DateTimePicker dtpFechaActual;
		private Label label5;
		private Label label4;
		private Label label1;
		private ComboBox cmbPrecio;
		private ComboBox comboBoxModelos;
		private ComboBox comboBoxMarcas;
		private Label label6;
		private Label total_dia;
	}
}