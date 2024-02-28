namespace chichi_autolavado.Views
{
	partial class reporte
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
			DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
			dataGridViewLavadasTot = new DataGridView();
			label2 = new Label();
			label1 = new Label();
			dataGridViewRegistrosMensuales = new DataGridView();
			btnLavadasPrevia = new Button();
			label3 = new Label();
			btnProductosPrevia = new Button();
			dateTimePickerFiltro = new DateTimePicker();
			label4 = new Label();
			dataGridViewRegistrosMensualesGastos = new DataGridView();
			label5 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridViewLavadasTot).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewRegistrosMensuales).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewRegistrosMensualesGastos).BeginInit();
			SuspendLayout();
			// 
			// dataGridViewLavadasTot
			// 
			dataGridViewLavadasTot.BackgroundColor = Color.WhiteSmoke;
			dataGridViewLavadasTot.BorderStyle = BorderStyle.Fixed3D;
			dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle19.BackColor = SystemColors.Control;
			dataGridViewCellStyle19.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle19.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle19.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
			dataGridViewLavadasTot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
			dataGridViewLavadasTot.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle20.BackColor = SystemColors.Window;
			dataGridViewCellStyle20.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle20.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle20.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
			dataGridViewLavadasTot.DefaultCellStyle = dataGridViewCellStyle20;
			dataGridViewLavadasTot.Location = new Point(78, 109);
			dataGridViewLavadasTot.Margin = new Padding(4, 3, 4, 3);
			dataGridViewLavadasTot.Name = "dataGridViewLavadasTot";
			dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle21.BackColor = SystemColors.Control;
			dataGridViewCellStyle21.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle21.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle21.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
			dataGridViewLavadasTot.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
			dataGridViewLavadasTot.RowHeadersWidth = 120;
			dataGridViewLavadasTot.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewLavadasTot.Size = new Size(809, 208);
			dataGridViewLavadasTot.TabIndex = 97;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = Color.Green;
			label2.Location = new Point(97, 343);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(242, 24);
			label2.TabIndex = 98;
			label2.Text = "Ganancias mensuales:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(0, 122, 204);
			label1.Location = new Point(398, 12);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(200, 30);
			label1.TabIndex = 99;
			label1.Text = "Lavados totales";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			label1.Click += label1_Click;
			// 
			// dataGridViewRegistrosMensuales
			// 
			dataGridViewRegistrosMensuales.BackgroundColor = Color.WhiteSmoke;
			dataGridViewRegistrosMensuales.BorderStyle = BorderStyle.Fixed3D;
			dataGridViewCellStyle22.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle22.BackColor = SystemColors.Control;
			dataGridViewCellStyle22.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle22.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle22.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle22.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle22.WrapMode = DataGridViewTriState.True;
			dataGridViewRegistrosMensuales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
			dataGridViewRegistrosMensuales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle23.BackColor = SystemColors.Window;
			dataGridViewCellStyle23.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle23.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle23.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle23.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle23.WrapMode = DataGridViewTriState.False;
			dataGridViewRegistrosMensuales.DefaultCellStyle = dataGridViewCellStyle23;
			dataGridViewRegistrosMensuales.Location = new Point(38, 378);
			dataGridViewRegistrosMensuales.Margin = new Padding(4, 3, 4, 3);
			dataGridViewRegistrosMensuales.Name = "dataGridViewRegistrosMensuales";
			dataGridViewCellStyle24.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle24.BackColor = SystemColors.Control;
			dataGridViewCellStyle24.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle24.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle24.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle24.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle24.WrapMode = DataGridViewTriState.True;
			dataGridViewRegistrosMensuales.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
			dataGridViewRegistrosMensuales.RowHeadersWidth = 120;
			dataGridViewRegistrosMensuales.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewRegistrosMensuales.Size = new Size(356, 175);
			dataGridViewRegistrosMensuales.TabIndex = 100;
			// 
			// btnLavadasPrevia
			// 
			btnLavadasPrevia.BackColor = Color.FromArgb(0, 122, 204);
			btnLavadasPrevia.Cursor = Cursors.Hand;
			btnLavadasPrevia.FlatAppearance.BorderSize = 0;
			btnLavadasPrevia.FlatAppearance.MouseDownBackColor = Color.White;
			btnLavadasPrevia.FlatAppearance.MouseOverBackColor = SystemColors.GrayText;
			btnLavadasPrevia.FlatStyle = FlatStyle.Flat;
			btnLavadasPrevia.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnLavadasPrevia.ForeColor = Color.White;
			btnLavadasPrevia.Location = new Point(428, 466);
			btnLavadasPrevia.Margin = new Padding(4, 3, 4, 3);
			btnLavadasPrevia.Name = "btnLavadasPrevia";
			btnLavadasPrevia.Size = new Size(105, 33);
			btnLavadasPrevia.TabIndex = 101;
			btnLavadasPrevia.Text = "Lavados";
			btnLavadasPrevia.UseVisualStyleBackColor = false;
			btnLavadasPrevia.Click += btnLavadasPrevia_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.WindowText;
			label3.Location = new Point(416, 383);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(120, 66);
			label3.TabIndex = 102;
			label3.Text = "Vista previa\r\n   de los \r\nregistros: \r\n";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnProductosPrevia
			// 
			btnProductosPrevia.BackColor = Color.FromArgb(0, 122, 204);
			btnProductosPrevia.Cursor = Cursors.Hand;
			btnProductosPrevia.FlatAppearance.BorderSize = 0;
			btnProductosPrevia.FlatAppearance.MouseDownBackColor = Color.White;
			btnProductosPrevia.FlatAppearance.MouseOverBackColor = SystemColors.GrayText;
			btnProductosPrevia.FlatStyle = FlatStyle.Flat;
			btnProductosPrevia.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnProductosPrevia.ForeColor = Color.White;
			btnProductosPrevia.Location = new Point(428, 513);
			btnProductosPrevia.Margin = new Padding(4, 3, 4, 3);
			btnProductosPrevia.Name = "btnProductosPrevia";
			btnProductosPrevia.Size = new Size(105, 33);
			btnProductosPrevia.TabIndex = 103;
			btnProductosPrevia.Text = "Productos";
			btnProductosPrevia.UseVisualStyleBackColor = false;
			btnProductosPrevia.Click += btnProductosPrevia_Click;
			// 
			// dateTimePickerFiltro
			// 
			dateTimePickerFiltro.CalendarFont = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dateTimePickerFiltro.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dateTimePickerFiltro.Location = new Point(235, 68);
			dateTimePickerFiltro.Name = "dateTimePickerFiltro";
			dateTimePickerFiltro.Size = new Size(334, 27);
			dateTimePickerFiltro.TabIndex = 104;
			dateTimePickerFiltro.ValueChanged += dateTimePickerFiltro_ValueChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label4.ForeColor = SystemColors.GrayText;
			label4.Location = new Point(78, 72);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(156, 19);
			label4.TabIndex = 105;
			label4.Text = "Escoge una fecha: ";
			// 
			// dataGridViewRegistrosMensualesGastos
			// 
			dataGridViewRegistrosMensualesGastos.BackgroundColor = Color.WhiteSmoke;
			dataGridViewRegistrosMensualesGastos.BorderStyle = BorderStyle.Fixed3D;
			dataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle25.BackColor = SystemColors.Control;
			dataGridViewCellStyle25.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle25.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle25.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle25.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle25.WrapMode = DataGridViewTriState.True;
			dataGridViewRegistrosMensualesGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
			dataGridViewRegistrosMensualesGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle26.BackColor = SystemColors.Window;
			dataGridViewCellStyle26.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle26.ForeColor = SystemColors.ControlText;
			dataGridViewCellStyle26.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle26.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle26.WrapMode = DataGridViewTriState.False;
			dataGridViewRegistrosMensualesGastos.DefaultCellStyle = dataGridViewCellStyle26;
			dataGridViewRegistrosMensualesGastos.Location = new Point(565, 377);
			dataGridViewRegistrosMensualesGastos.Margin = new Padding(4, 3, 4, 3);
			dataGridViewRegistrosMensualesGastos.Name = "dataGridViewRegistrosMensualesGastos";
			dataGridViewCellStyle27.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle27.BackColor = SystemColors.Control;
			dataGridViewCellStyle27.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle27.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle27.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle27.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle27.WrapMode = DataGridViewTriState.True;
			dataGridViewRegistrosMensualesGastos.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
			dataGridViewRegistrosMensualesGastos.RowHeadersWidth = 120;
			dataGridViewRegistrosMensualesGastos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewRegistrosMensualesGastos.Size = new Size(356, 175);
			dataGridViewRegistrosMensualesGastos.TabIndex = 107;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = Color.Red;
			label5.Location = new Point(651, 342);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(200, 24);
			label5.TabIndex = 106;
			label5.Text = "Gastos mensuales:";
			// 
			// reporte
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(960, 588);
			Controls.Add(dataGridViewRegistrosMensualesGastos);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(dateTimePickerFiltro);
			Controls.Add(btnProductosPrevia);
			Controls.Add(label3);
			Controls.Add(btnLavadasPrevia);
			Controls.Add(dataGridViewRegistrosMensuales);
			Controls.Add(label1);
			Controls.Add(label2);
			Controls.Add(dataGridViewLavadasTot);
			FormBorderStyle = FormBorderStyle.None;
			Name = "reporte";
			Text = "reporte";
			Load += reporte_Load;
			((System.ComponentModel.ISupportInitialize)dataGridViewLavadasTot).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewRegistrosMensuales).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridViewRegistrosMensualesGastos).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridViewLavadasTot;
		private Label label2;
		private Label label1;
		private DataGridView dataGridViewRegistrosMensuales;
		private Button btnLavadasPrevia;
		private Label label3;
		private Button btnProductosPrevia;
		private DateTimePicker dateTimePickerFiltro;
		private Label label4;
		private DataGridView dataGridViewRegistrosMensualesGastos;
		private Label label5;
	}
}