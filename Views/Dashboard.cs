using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using chichi_autolavado.Views;

namespace softwareContable.Views
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();
		}

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		public extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


		private void btnSlide_Click(object sender, EventArgs e)
		{
			if (panelMenuVertical.Width == 250)
			{
				panelMenuVertical.Width = 87;
			}
			else
			{
				panelMenuVertical.Width = 250;
			}
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnMinimizar_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void abrirFormPanel(object Formhijo)
		{
			if (this.panelContenedor.Controls.Count > 0)
				this.panelContenedor.Controls.RemoveAt(0);
			Form fh = Formhijo as Form;
			fh.TopLevel = false;
			fh.Dock = DockStyle.Fill;
			this.panelContenedor.Controls.Add(fh);
			this.panelContenedor.Tag = fh;
			fh.Show();

		}
		private void btnFormEmpresa_Click(object sender, EventArgs e)
		{
			abrirFormPanel(new Lavadas());
		}

		private void button1_Click(object sender, EventArgs e)
		{
			abrirFormPanel(new Productos());
		}

		private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
		{

		}



		private void button4_Click(object sender, EventArgs e)
		{
			abrirFormPanel(new reporte());
		}



		private void panelContenedor_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panelContenedor_Paint_1(object sender, PaintEventArgs e)
		{

		}

		private void lbl_hora_Click(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			// Obtener la fecha y la hora actuales
			DateTime ahora = DateTime.Now;

			// Actualizar el texto de los Labels con los formatos deseados
			//lbl_fecha.Text = ahora.ToString("dd/MM/yyyy");
			//lbl_hora.Text = ahora.ToString("HH:mm:ss");
		}

		private void Dashboard_Load(object sender, EventArgs e)
		{
			timer1.Start();

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void panelMenuVertical_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnPlanilla_Click(object sender, EventArgs e)
		{
			abrirFormPanel(new Pagos());

		}
	}
}
