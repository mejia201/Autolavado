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
	public partial class reporte : Form
	{
		private List<RegistroDiario> registrosDiarios = new List<RegistroDiario>();
		private List<RegistroDiarioProducto> registrosDiariosProd = new List<RegistroDiarioProducto>();



		public reporte()
		{
			InitializeComponent();
		}


		private void CargarDesdeDocumentoTexto()
		{
			try
			{
				registrosDiarios.Clear(); // Limpiar la lista actual

				if (File.Exists("Lavados.txt"))
				{
					using (StreamReader sr = new StreamReader("Lavados.txt"))
					{
						string line;
						RegistroDiario registroDiario = null;

						while ((line = sr.ReadLine()) != null)
						{
							if (line.StartsWith("Fecha:"))
							{
								// Obtener la fecha del registro diario
								DateTime fecha = DateTime.Parse(line.Substring(7).Trim());

								// Crear un nuevo registro diario
								registroDiario = new RegistroDiario(fecha);
								registrosDiarios.Add(registroDiario);
							}
							else if (!string.IsNullOrWhiteSpace(line))
							{
								// Verificar si la línea contiene el texto "Total del Día"
								if (line.StartsWith("Total del Día:"))
								{
									decimal totalDia;

									if (decimal.TryParse(line.Substring(14).Trim(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"), out totalDia))
									{
										registroDiario.TotalDia = totalDia;
									}
									else
									{
										MessageBox.Show($"Error al convertir el total del día en la línea: {line}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
									}
								}
								else
								{
									// Separar los campos de lavado
									string[] campos = line.Split(',');

									// Verificar si hay suficientes campos
									if (campos.Length >= 3)
									{
										string marca = campos[0].Substring(campos[0].IndexOf(":") + 1).Trim();
										string modelo = campos[1].Substring(campos[1].IndexOf(":") + 1).Trim();

										// Intentar convertir el precio a decimal
										if (decimal.TryParse(campos[2].Substring(campos[2].IndexOf(":") + 1).Trim(), out decimal precio))
										{
											Lavado lavado = new Lavado
											{
												Marca = marca,
												Modelo = modelo,
												Precio = precio
											};

											registroDiario.Lavados.Add(lavado);
										}
										else
										{
											MessageBox.Show($"Error al convertir el precio en la línea: {line}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
										}
									}
									else
									{
										MessageBox.Show($"La línea no contiene la cantidad esperada de campos: {line}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
									}
								}
							}
						}
					}
				}
				else
				{
					// Si el archivo no existe, mostrar un mensaje
					MessageBox.Show("El archivo Lavados.txt no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				// Mostrar los registros mensuales
				MostrarRegistrosMensuales();
				// Mostrar todas las lavadas
				MostrarTodasLasLavadas();


			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al cargar desde el documento de texto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void CargarProductosDesdeDocumentoTextoProductos()
		{
			try
			{
				registrosDiariosProd.Clear(); // Limpiar la lista actual

				if (File.Exists("Productos.txt"))
				{
					using (StreamReader sr = new StreamReader("Productos.txt"))
					{
						string line;
						RegistroDiarioProducto registroProducto = null;

						while ((line = sr.ReadLine()) != null)
						{
							if (line.StartsWith("Fecha:"))
							{
								// Obtener la fecha del registro diario
								DateTime fecha = DateTime.Parse(line.Substring(7).Trim());

								// Crear un nuevo registro diario de productos
								registroProducto = new RegistroDiarioProducto(fecha);
								registrosDiariosProd.Add(registroProducto);
							}
							else if (!string.IsNullOrWhiteSpace(line))
							{
								// Verificar si la línea contiene el texto "Total de gastos del día"
								if (line.StartsWith("Total de gastos del día:"))
								{
									decimal totalDia;

									if (decimal.TryParse(line.Substring(26).Trim(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"), out totalDia))
									{
										registroProducto.TotalDia = totalDia;
									}
									else
									{
										MessageBox.Show($"Error al convertir el total de gastos del día en la línea: {line}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
									}
								}
								else
								{
									// Separar los campos de producto
									string[] campos = line.Split(',');

									// Verificar si hay suficientes campos
									if (campos.Length >= 2)
									{
										string nombreProducto = campos[0].Substring(campos[0].IndexOf(":") + 1).Trim();
										// Intentar convertir el precio a decimal
										if (decimal.TryParse(campos[1].Substring(campos[1].IndexOf(":") + 1).Trim(), out decimal precio))
										{
											Producto producto = new Producto
											{
												Nombre = nombreProducto,
												Precio = precio
											};

											registroProducto.Productos.Add(producto);
										}
										else
										{
											MessageBox.Show($"Error al convertir el precio en la línea: {line}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
										}
									}
									else
									{
										MessageBox.Show($"La línea no contiene la cantidad esperada de campos: {line}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
									}
								}
							}
						}
					}
				}
				else
				{
					// Si el archivo no existe, mostrar un mensaje
					MessageBox.Show("El archivo Productos.txt no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				// Mostrar los registros mensuales de productos
				MostrarRegistrosMensualesProductos();

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al cargar desde el documento de texto de productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



	




		private void MostrarTodasLasLavadas(DateTime? fechaFiltro = null)
		{
			var lavadasFiltradas = registrosDiarios
				.SelectMany(rd => rd.Lavados.Select(l => new { rd.Fecha, l.Marca, l.Modelo, l.Precio }))
				.ToList();

			if (fechaFiltro.HasValue)
			{
				lavadasFiltradas = lavadasFiltradas.Where(l => l.Fecha.Date == fechaFiltro.Value.Date).ToList();
			}

			if (lavadasFiltradas.Any())
			{
				dataGridViewLavadasTot.DataSource = null;
				dataGridViewLavadasTot.DataSource = lavadasFiltradas;
				dataGridViewLavadasTot.Columns["Fecha"].DefaultCellStyle.Format = "d";
				dataGridViewLavadasTot.Columns["Precio"].DefaultCellStyle.Format = "C";

				dataGridViewLavadasTot.Columns[0].Width = 120;
				dataGridViewLavadasTot.Columns[1].Width = 220;
				dataGridViewLavadasTot.Columns[2].Width = 220;
				dataGridViewLavadasTot.Columns[3].Width = 127;
			}
			else
			{
				MessageBox.Show("No hay datos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}



		private void MostrarRegistrosMensuales()
		{
			var registrosMensuales = registrosDiarios
				.GroupBy(registro => registro.Mes)
				.Select(grupo => new
				{
					Mes = grupo.Key,
					Ganancia = grupo.Sum(registro => registro.TotalDia)
				})
				.ToList();

			if (registrosMensuales.Any())  // Verificar si hay datos antes de mostrar en la DataGridView
			{
				dataGridViewRegistrosMensuales.DataSource = null;
				dataGridViewRegistrosMensuales.DataSource = registrosMensuales;
				dataGridViewRegistrosMensuales.Columns["Mes"].DefaultCellStyle.Format = "MMMM yyyy";
				dataGridViewRegistrosMensuales.Columns["Ganancia"].DefaultCellStyle.Format = "C";

				dataGridViewRegistrosMensuales.Columns[0].Width = 114;
				dataGridViewRegistrosMensuales.Columns[1].Width = 120;




			}
			else
			{
				MessageBox.Show("No hay datos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}



		private void GuardarGanancias(string nombreArchivo, DataGridView dataGridView)
		{
			try
			{
				StringBuilder contenido = new StringBuilder();

				// Agregar encabezados de columnas al contenido
				foreach (DataGridViewColumn columna in dataGridView.Columns)
				{
					contenido.Append(columna.HeaderText.PadRight(20) + "   ");
				}
				contenido.AppendLine();

				// Agregar datos de filas al contenido
				foreach (DataGridViewRow fila in dataGridView.Rows)
				{
					foreach (DataGridViewCell celda in fila.Cells)
					{
						contenido.Append(celda.Value.ToString().PadRight(20) + "   ");
					}
					contenido.AppendLine();
				}

				// Escribir el contenido en el archivo
				File.WriteAllText(nombreArchivo, contenido.ToString());

				MessageBox.Show($"El contenido de las ganancias se ha guardado correctamente en {nombreArchivo}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al guardar en el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		private void MostrarRegistrosMensualesProductos()
		{
			var registrosMensuales = registrosDiariosProd
				.GroupBy(registro => registro.Mes)
				.Select(grupo => new
				{
					Mes = grupo.Key,
					Gasto = grupo.Sum(registro => registro.TotalDia)
				})
				.ToList();

			if (registrosMensuales.Any())
			{
				dataGridViewRegistrosMensualesGastos.DataSource = null;
				dataGridViewRegistrosMensualesGastos.DataSource = registrosMensuales;
				dataGridViewRegistrosMensualesGastos.Columns["Mes"].DefaultCellStyle.Format = "MM-yyyy";
				dataGridViewRegistrosMensualesGastos.Columns["Gasto"].DefaultCellStyle.Format = "C";

				dataGridViewRegistrosMensualesGastos.Columns[0].Width = 114;
				dataGridViewRegistrosMensualesGastos.Columns[1].Width = 120;


			}
			else
			{
				MessageBox.Show("No hay datos para mostrar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}


		private void GuardarGastos(string nombreArchivo, DataGridView dataGridView)
		{
			try
			{
				StringBuilder contenido = new StringBuilder();

				// Agregar encabezados de columnas al contenido
				foreach (DataGridViewColumn columna in dataGridView.Columns)
				{
					contenido.Append(columna.HeaderText.PadRight(20) + "   ");
				}
				contenido.AppendLine();

				// Agregar datos de filas al contenido
				foreach (DataGridViewRow fila in dataGridView.Rows)
				{
					foreach (DataGridViewCell celda in fila.Cells)
					{
						contenido.Append(celda.Value.ToString().PadRight(20) + "   ");
					}
					contenido.AppendLine();
				}

				// Escribir el contenido en el archivo
				File.WriteAllText(nombreArchivo, contenido.ToString());

				MessageBox.Show($"El contenido de los gastos se ha guardado correctamente en {nombreArchivo}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al guardar en el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}





		private void reporte_Load(object sender, EventArgs e)
		{
			CargarDesdeDocumentoTexto();
			CargarProductosDesdeDocumentoTextoProductos();
			MostrarTodasLasLavadas();

			GuardarGanancias("GananciasMensuales.txt", dataGridViewRegistrosMensuales);
			GuardarGastos("GastosMensuales.txt", dataGridViewRegistrosMensualesGastos);



		}




		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnProductosPrevia_Click(object sender, EventArgs e)
		{
			string contenido = ObtenerContenidoDocumentoTexto("Productos.txt");

			// Verificar si el contenido indica que el archivo no existe
			if (contenido == "El archivo no existe.")
			{
				MessageBox.Show(contenido, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				// Abrir la vista previa
				FormVistaPrevia formVistaPrevia = new FormVistaPrevia(contenido);
				formVistaPrevia.ShowDialog();
			}
		}



		private string ObtenerContenidoDocumentoTexto(string nombreArchivo)
		{
			try
			{
				if (File.Exists(nombreArchivo))
				{
					using (StreamReader sr = new StreamReader(nombreArchivo))
					{
						return sr.ReadToEnd();
					}
				}
				else
				{
					return "El archivo no existe.";
				}
			}
			catch (Exception ex)
			{
				return $"Error al leer el archivo: {ex.Message}";
			}
		}

		private void btnLavadasPrevia_Click(object sender, EventArgs e)
		{
			string contenido = ObtenerContenidoDocumentoTexto("Lavados.txt");

			// Verificar si el contenido indica que el archivo no existe
			if (contenido == "El archivo no existe.")
			{
				MessageBox.Show(contenido, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				// Abrir la vista previa
				FormVistaPrevia formVistaPrevia = new FormVistaPrevia(contenido);
				formVistaPrevia.ShowDialog();
			}
		}

		private void dateTimePickerFiltro_ValueChanged(object sender, EventArgs e)
		{

			MostrarTodasLasLavadas(dateTimePickerFiltro.Value);

		}
	}
}
