using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using chichi_autolavado.Models;

namespace chichi_autolavado.Views
{
    public partial class Productos : Form
	{

		private List<RegistroDiarioProducto> registrosDiarios = new List<RegistroDiarioProducto>();
		private decimal totalDelDia = 0.0m;

		public Productos()
		{
			InitializeComponent();
		}


		private void GuardarEnDocumentoTexto()
		{
			try
			{
				using (StreamWriter sw = new StreamWriter("Productos.txt"))
				{
					foreach (RegistroDiarioProducto registroDiario in registrosDiarios)
					{
						sw.WriteLine($"Fecha: {registroDiario.Fecha.ToShortDateString()}");

						foreach (Producto producto in registroDiario.Productos)
						{
							sw.WriteLine($"Nombre: {producto.Nombre}, Precio: {producto.Precio}");
						}

						sw.WriteLine($"Total de gastos del día: {registroDiario.TotalDia:C}");
						sw.WriteLine();
						sw.WriteLine();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al guardar en el documento de texto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void CargarDesdeDocumentoTexto()
		{
			try
			{
				registrosDiarios.Clear(); // Limpiar la lista actual

				if (File.Exists("Productos.txt"))
				{
					using (StreamReader sr = new StreamReader("Productos.txt"))
					{
						string line;
						RegistroDiarioProducto registroDiario = null;

						while ((line = sr.ReadLine()) != null)
						{
							if (!string.IsNullOrWhiteSpace(line))
							{
								if (line.StartsWith("Fecha:"))
								{
									// Nuevo registro diario
									DateTime fecha = DateTime.Parse(line.Substring(line.IndexOf(":") + 1).Trim());
									registroDiario = new RegistroDiarioProducto(fecha);
									registrosDiarios.Add(registroDiario);
								}
								else if (line.StartsWith("Nombre:") && line.Contains("Precio:"))
								{
									// Producto
									if (registroDiario != null)
									{
										int indexNombre = line.IndexOf(":") + 1;
										int indexPrecio = line.IndexOf("Precio:");
										string nombre = line.Substring(indexNombre, indexPrecio - indexNombre).Trim();
										string precioStr = line.Substring(indexPrecio + 7).Trim();
										decimal precio = decimal.Parse(precioStr, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));

										Producto producto = new Producto { Nombre = nombre, Precio = precio };
										registroDiario.Productos.Add(producto);

										// Actualizar el total del día
										registroDiario.TotalDia += precio;
									}
								}
								else if (line.StartsWith("Total de gastos del día:"))
								{
									// Total del día
									if (registroDiario != null)
									{
										decimal totalDia = decimal.Parse(line.Substring(line.IndexOf(":") + 1).Trim(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
										registroDiario.TotalDia = totalDia;
									}
								}
								else
								{
									MessageBox.Show($"Campo no reconocido: {line}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
								}
							}
						}
					}

					// Mostrar los productos después de cargarlos desde el archivo de texto
					MostrarProductos();
					MostrarTotal();
				}
				else
				{
					// Si el archivo no existe, lo creamos vacío
					using (File.Create("Productos.txt")) { }

					MessageBox.Show("Archivo Productos.txt creado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al cargar desde el documento de texto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}




		private void MostrarProductos()
		{
			var productos = registrosDiarios
				.SelectMany(rd => rd.Productos.Select(p => new { rd.Fecha, Nombre = p.Nombre.Replace(",", ""), p.Precio }))
				.ToList();

			dataGridViewProductos.DataSource = null;
			dataGridViewProductos.DataSource = productos;
			dataGridViewProductos.Columns[0].Width = 170;
			dataGridViewProductos.Columns[1].Width = 237;
			dataGridViewProductos.Columns[2].Width = 120;
			dataGridViewProductos.Columns[2].DefaultCellStyle.Format = "C";
		}



		private void MostrarTotal()
		{
			decimal totalGastosAcumulado = registrosDiarios.Sum(r => r.TotalDia);
			total_gasto.Text = $"{totalGastosAcumulado:C}";
		}


		private void btnIngresarProducto_Click(object sender, EventArgs e)
		{


			// Obtener la fecha actual
			DateTime fechaActual = DateTime.Today;

			//DateTime fechaActual = new DateTime(2024, 01, 8);

			// Buscar el registro diario correspondiente o crear uno nuevo
			RegistroDiarioProducto registroDiario = registrosDiarios.FirstOrDefault(r => r.Fecha == fechaActual);
			if (registroDiario == null)
			{
				registroDiario = new RegistroDiarioProducto(fechaActual);
				registrosDiarios.Add(registroDiario);
			}

			Producto nuevoProducto = new Producto
			{
				Nombre = txtNombre.Text,
				Precio = Convert.ToDecimal(txtPrecio.Text)
			};

			// Añadir el lavado al registro diario
			registroDiario.Productos.Add(nuevoProducto);

			// Actualizar el total del día
			registroDiario.TotalDia += nuevoProducto.Precio;

			// Actualizar el contenido del label
			total_gasto.Text = $"{registroDiario.TotalDia:C}";

			// Limpiar los campos después de registrar el producto
			txtNombre.Clear();
			txtPrecio.Clear();

			MostrarProductos();
			GuardarEnDocumentoTexto();

		}

		private void Productos_Load(object sender, EventArgs e)
		{

			MostrarProductos();

			CargarDesdeDocumentoTexto();

			MostrarTotal();

		}

		private void Productos_FormClosing(object sender, FormClosingEventArgs e)
		{
			GuardarEnDocumentoTexto();
		}
	}
}
