using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chichi_autolavado.Views
{
	public partial class FormVistaPrevia : Form
	{
		public FormVistaPrevia(string contenido)
		{
			InitializeComponent();
			richTextBoxContenido.Text = contenido;
		}

		private void FormVistaPrevia_Load(object sender, EventArgs e)
		{

		}
	}
}
