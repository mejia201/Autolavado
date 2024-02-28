namespace chichi_autolavado.Views
{
	partial class Pagos
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
			label1 = new Label();
			label6 = new Label();
			label2 = new Label();
			txtEfectivoTotal = new TextBox();
			txtEfectivoDisponible = new TextBox();
			label3 = new Label();
			label4 = new Label();
			dtpFechaActual = new DateTimePicker();
			label5 = new Label();
			dataGridViewResumenMensual = new DataGridView();
			txtPagoMes = new TextBox();
			label7 = new Label();
			label8 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridViewResumenMensual).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(0, 122, 204);
			label1.Location = new Point(450, 18);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(85, 30);
			label1.TabIndex = 100;
			label1.Text = "Pagos";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			label6.ForeColor = SystemColors.InfoText;
			label6.Location = new Point(332, 58);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(325, 19);
			label6.TabIndex = 101;
			label6.Text = "Pagos de salarios y efectivo para utilidad";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = SystemColors.InfoText;
			label2.Location = new Point(28, 197);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(348, 21);
			label2.TabIndex = 102;
			label2.Text = "Efectivo acumulado disponible para gastos";
			// 
			// txtEfectivoTotal
			// 
			txtEfectivoTotal.Enabled = false;
			txtEfectivoTotal.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			txtEfectivoTotal.Location = new Point(126, 225);
			txtEfectivoTotal.Name = "txtEfectivoTotal";
			txtEfectivoTotal.Size = new Size(141, 27);
			txtEfectivoTotal.TabIndex = 104;
			txtEfectivoTotal.TextAlign = HorizontalAlignment.Center;
			txtEfectivoTotal.TextChanged += txtEfectivoTotal_TextChanged;
			// 
			// txtEfectivoDisponible
			// 
			txtEfectivoDisponible.Enabled = false;
			txtEfectivoDisponible.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			txtEfectivoDisponible.Location = new Point(485, 225);
			txtEfectivoDisponible.Name = "txtEfectivoDisponible";
			txtEfectivoDisponible.Size = new Size(141, 27);
			txtEfectivoDisponible.TabIndex = 106;
			txtEfectivoDisponible.TextAlign = HorizontalAlignment.Center;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = SystemColors.InfoText;
			label3.Location = new Point(411, 197);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(292, 21);
			label3.TabIndex = 105;
			label3.Text = "Efectivo disponible del presente mes";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = Color.FromArgb(202, 48, 61);
			label4.Location = new Point(284, 97);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(118, 20);
			label4.TabIndex = 107;
			label4.Text = "Fecha de hoy: ";
			// 
			// dtpFechaActual
			// 
			dtpFechaActual.CalendarFont = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			dtpFechaActual.Enabled = false;
			dtpFechaActual.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			dtpFechaActual.Location = new Point(403, 94);
			dtpFechaActual.Margin = new Padding(0);
			dtpFechaActual.Name = "dtpFechaActual";
			dtpFechaActual.Size = new Size(289, 26);
			dtpFechaActual.TabIndex = 108;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = Color.FromArgb(0, 122, 204);
			label5.Location = new Point(23, 310);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(266, 24);
			label5.TabIndex = 110;
			label5.Text = "Detalle de los resultados:";
			// 
			// dataGridViewResumenMensual
			// 
			dataGridViewResumenMensual.BackgroundColor = Color.WhiteSmoke;
			dataGridViewResumenMensual.BorderStyle = BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = SystemColors.Control;
			dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
			dataGridViewResumenMensual.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewResumenMensual.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = SystemColors.Window;
			dataGridViewCellStyle2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
			dataGridViewResumenMensual.DefaultCellStyle = dataGridViewCellStyle2;
			dataGridViewResumenMensual.Location = new Point(23, 338);
			dataGridViewResumenMensual.Margin = new Padding(4, 3, 4, 3);
			dataGridViewResumenMensual.Name = "dataGridViewResumenMensual";
			dataGridViewResumenMensual.ReadOnly = true;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = SystemColors.Control;
			dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
			dataGridViewResumenMensual.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			dataGridViewResumenMensual.RowHeadersWidth = 120;
			dataGridViewResumenMensual.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridViewResumenMensual.Size = new Size(916, 199);
			dataGridViewResumenMensual.TabIndex = 116;
			// 
			// txtPagoMes
			// 
			txtPagoMes.Enabled = false;
			txtPagoMes.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
			txtPagoMes.Location = new Point(752, 225);
			txtPagoMes.Name = "txtPagoMes";
			txtPagoMes.Size = new Size(141, 27);
			txtPagoMes.TabIndex = 118;
			txtPagoMes.TextAlign = HorizontalAlignment.Center;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label7.ForeColor = SystemColors.InfoText;
			label7.Location = new Point(764, 197);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(114, 21);
			label7.TabIndex = 117;
			label7.Text = "Pago del mes";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			label8.ForeColor = Color.Crimson;
			label8.Location = new Point(684, 24);
			label8.Margin = new Padding(4, 0, 4, 0);
			label8.Name = "label8";
			label8.Size = new Size(252, 18);
			label8.TabIndex = 119;
			label8.Text = "Efectivo del año anterior: $126.05 ";
			// 
			// Pagos
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlLightLight;
			ClientSize = new Size(944, 549);
			Controls.Add(label8);
			Controls.Add(txtPagoMes);
			Controls.Add(label7);
			Controls.Add(dataGridViewResumenMensual);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(dtpFechaActual);
			Controls.Add(txtEfectivoDisponible);
			Controls.Add(label3);
			Controls.Add(txtEfectivoTotal);
			Controls.Add(label2);
			Controls.Add(label6);
			Controls.Add(label1);
			ForeColor = SystemColors.ButtonHighlight;
			FormBorderStyle = FormBorderStyle.None;
			Name = "Pagos";
			Text = "Pagos";
			Load += Pagos_Load;
			((System.ComponentModel.ISupportInitialize)dataGridViewResumenMensual).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label6;
		private Label label2;
		private TextBox txtEfectivoTotal;
		private TextBox txtEfectivoDisponible;
		private Label label3;
		private Label label4;
		private DateTimePicker dtpFechaActual;
		private Label label5;
		private DataGridView dataGridViewResumenMensual;
		private TextBox txtPagoMes;
		private Label label7;
		private Label label8;
	}
}