namespace chichi_autolavado.Views
{
	partial class FormVistaPrevia
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVistaPrevia));
			richTextBoxContenido = new RichTextBox();
			SuspendLayout();
			// 
			// richTextBoxContenido
			// 
			richTextBoxContenido.BackColor = SystemColors.ControlLightLight;
			richTextBoxContenido.BorderStyle = BorderStyle.None;
			richTextBoxContenido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
			richTextBoxContenido.Location = new Point(12, 12);
			richTextBoxContenido.Name = "richTextBoxContenido";
			richTextBoxContenido.Size = new Size(875, 499);
			richTextBoxContenido.TabIndex = 0;
			richTextBoxContenido.Text = "";
			// 
			// FormVistaPrevia
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(901, 523);
			Controls.Add(richTextBoxContenido);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "FormVistaPrevia";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Vista previa";
			Load += FormVistaPrevia_Load;
			ResumeLayout(false);
		}

		#endregion

		private RichTextBox richTextBoxContenido;
	}
}