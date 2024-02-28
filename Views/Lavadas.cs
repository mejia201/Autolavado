using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using chichi_autolavado.Models;

namespace softwareContable.Views
{
	public partial class Lavadas : Form
	{
		List<Marca> listaMarcas;
		private List<RegistroDiario> registrosDiarios = new List<RegistroDiario>();
		private decimal totalDelDia = 0.0m;


		public Lavadas()
		{
			InitializeComponent();

			comboBoxMarcas.SelectedIndexChanged += comboBoxMarcas_SelectedIndexChanged;


		}


		private void MostrarTotalDelDia()
		{
			// Obtener la fecha actual
			DateTime fechaActual = DateTime.Today;

			// Buscar el registro diario correspondiente
			RegistroDiario registroDiario = registrosDiarios.FirstOrDefault(r => r.Fecha == fechaActual);

			// Mostrar el total del día en el label
			if (registroDiario != null)
			{
				totalDelDia = registroDiario.TotalDia;
			}
			else
			{
				totalDelDia = 0.0m;
			}
		}




		private void Empresa_Load(object sender, EventArgs e)
		{

			listaMarcas = new List<Marca>
		{
			new Marca { Nombre = "Toyota", Modelos = new List<string> { "Land Cruiser", "Yaris", "Hilux", "Corolla", "Rav4", "Tacoma", "Tundra", "Selica", "Prado", "Camry" } },
			new Marca { Nombre = "Honda", Modelos = new List<string> { "Civic", "Accord", "CR-V", "Fit", "H-RV", "Acura", "CRX" } },
			new Marca { Nombre = "Nissan", Modelos = new List<string> { "Altima","Navara", "Sentra", "X-Trail", "Frontier", "Murano", "Rogue", "Titan", "Juke", "Urban","Versa", "NP-300", "NP-200", "Patrol" } },
			new Marca { Nombre = "Hyundai", Modelos = new List<string> { "Elantra", "Tucson", "Santa Fe", "Accent", "Tiburon", "Kona", "H-100" } },
			new Marca { Nombre = "Chevrolet", Modelos = new List<string> { "Cruze", "Monza","Malibu", "Equinox", "Traverse","Colorado", "Suburban", "qq", "Cavallier", "Silverado", "Aveo", "Camaro", "Spark", "N-300" } },
			new Marca { Nombre = "Ford", Modelos = new List<string> { "Focus", "Fusion", "Escape", "Explorer", "F-150", "Ranger", "F-250", "F-350" } },
			new Marca { Nombre = "Mazda", Modelos = new List<string> { "Mazda3", "Mazda5", "Mazda6", "CX-5", "MX-5", "CX-9", "B-2200", "BT-50", "L-200", "B-50" } },
			new Marca { Nombre = "Kia", Modelos = new List<string> { "Optima", "Sorento", "Sportage", "Forte", "Rio", "Soul", "Spectra" } },
			new Marca { Nombre = "Isuzu", Modelos = new List<string> { "Pup", "Trooper", "Rodeo", "D-Max"} },
			new Marca { Nombre = "Mitsubishi", Modelos = new List<string> { "Lancer", "Eclipse", "Mirage", "Montero", "Outlander", "L-200", "H-300" } },
			new Marca { Nombre = "Scion", Modelos = new List<string> { "TC", "XB", "XA", "IA", "XD", "Kona", "H-100" } },
			new Marca { Nombre = "Jeep", Modelos = new List<string> { "Wrangler", "Grand Cherokee", "Cherokee", "Compass", "Renegade", "Gladiator" } },
			new Marca { Nombre = "BMW", Modelos = new List<string> { "3 Series", "5 Series", "7 Series", "X3", "X5", "X7", "M3", "M5", "i3", "i8" } },
			new Marca { Nombre = "Volkswagen", Modelos = new List<string> { "Golf", "Jetta", "Passat", "Tiguan", "Atlas", "Beetle", "Polo", "Arteon", "Touareg", "ID.4", "TWAN" } },
			new Marca { Nombre = "Mercedes-Benz", Modelos = new List<string> { "C-Class", "E-Class", "S-Class", "GLC", "GLE", "GLA", "A-Class", "CLA", "CLS", "G-Class" } },
			new Marca { Nombre = "Subaru", Modelos = new List<string> { "Outback", "Forester", "Impreza", "Legacy", "Crosstrek", "WRX", "BRZ", "Ascent" } },
			new Marca { Nombre = "Volvo", Modelos = new List<string> { "XC90", "XC60", "S60", "V60", "XC40", "S90", "V90", "V40", "CX-7" } },
			new Marca { Nombre = "RAM", Modelos = new List<string> { "1500", "2500", "3500", "Rebel", "Power Wagon" } },
			new Marca { Nombre = "Suzuki", Modelos = new List<string> { "Swift", "Vitara", "Jimny", "S-Cross", "Baleno", "Ignis" } },
			new Marca { Nombre = "Dodge", Modelos = new List<string> { "Charger", "Challenger", "Durango", "Journey", "Grand Caravan" } },

			new Marca { Nombre = "Moto", Modelos = new List<string> { "Modelo Estadar"} },

		};

			comboBoxMarcas.DataSource = listaMarcas;
			comboBoxMarcas.DisplayMember = "Nombre";


			MostrarLavadosDelDia();

			CargarDesdeDocumentoTexto();

			// Mostrar el total del día después de cargar desde el documento de texto
			MostrarTotalDelDia();
			total_dia.Text = $"{totalDelDia:C}";





		}




		private void GuardarEnDocumentoTexto()
		{
			try
			{
				using (StreamWriter sw = new StreamWriter("Lavados.txt"))
				{
					foreach (RegistroDiario registroDiario in registrosDiarios)
					{
						sw.WriteLine($"Fecha: {registroDiario.Fecha.ToShortDateString()}");

						foreach (Lavado lavado in registroDiario.Lavados)
						{
							sw.WriteLine($"Marca: {lavado.Marca}, Modelo: {lavado.Modelo}, Precio: {lavado.Precio}");
						}

						sw.WriteLine($"Total del Día: {registroDiario.TotalDia:C}");
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

										// Actualizar el contenido del label con el total del día
										total_dia.Text = $"Total del día: {registroDiario.TotalDia:C}";
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

											// Actualizar el total del día
											registroDiario.TotalDia += precio;
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
					// Si el archivo no existe, lo creamos vacío
					using (File.Create("Lavados.txt")) { }

					MessageBox.Show("Archivo Lavados.txt creado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				// Mostrar los lavados del día actual después de cargarlos desde el archivo de texto
				MostrarLavadosDelDia();
				MostrarTotalDelDia();

			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al cargar desde el documento de texto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}





		private void btnIngresar_Click(object sender, EventArgs e)
		{


			// Obtener la fecha actual
			//DateTime fechaActual = DateTime.Today;

			//Estableciendo fecha manual
			//DateTime fechaActual = new DateTime(2024, 01, 16);

			DateTime fechaActual = dtpFechaActual.Value;


			// Buscar el registro diario correspondiente o crear uno nuevo
			RegistroDiario registroDiario = registrosDiarios.FirstOrDefault(r => r.Fecha == fechaActual);
			if (registroDiario == null)
			{
				registroDiario = new RegistroDiario(fechaActual);
				registrosDiarios.Add(registroDiario);
			}

			Lavado nuevoLavado = new Lavado
			{
				Marca = comboBoxMarcas.Text,
				Modelo = comboBoxModelos.Text,
				Precio = Convert.ToDecimal(cmbPrecio.Text)
			};

			// Añadir el lavado al registro diario
			registroDiario.Lavados.Add(nuevoLavado);

			// Actualizar el total del día
			registroDiario.TotalDia += nuevoLavado.Precio;

			// Actualizar el contenido del label
			total_dia.Text = $"{registroDiario.TotalDia:C}";

			// Limpiar los campos después de registrar el lavado
			comboBoxMarcas.SelectedIndex = -1;
			comboBoxModelos.SelectedIndex = -1;
			cmbPrecio.SelectedIndex = -1;

			MostrarLavadosDelDia();
			GuardarEnDocumentoTexto();




		}



		private void MostrarLavadosDelDia()
		{
			// Obtener la fecha actual
			//DateTime fechaActual = DateTime.Today;

			DateTime fechaActual = dtpFechaActual.Value;


			// Buscar el registro diario correspondiente
			RegistroDiario registroDiario = registrosDiarios.FirstOrDefault(r => r.Fecha == fechaActual);

			// Mostrar los lavados en el DataGridView
			if (registroDiario != null)
			{
				dataGridViewLavados.DataSource = null;
				dataGridViewLavados.DataSource = registroDiario.Lavados;
				dataGridViewLavados.Columns[0].Width = 200;
				dataGridViewLavados.Columns[1].Width = 200;
				dataGridViewLavados.Columns[2].Width = 127;
				dataGridViewLavados.Columns[2].DefaultCellStyle.Format = "C";




			}
		}







		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void comboBoxMarcas_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxMarcas.SelectedItem != null)
			{
				Marca marcaSeleccionada = (Marca)comboBoxMarcas.SelectedItem;

				comboBoxModelos.DataSource = marcaSeleccionada.Modelos;
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{

		}

		private void Lavadas_FormClosing(object sender, FormClosingEventArgs e)
		{
			GuardarEnDocumentoTexto();

		}
	}
}
