using chichi_autolavado.Models;
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


	public partial class Pagos : Form
	{

		private List<RegistroDiario> registrosDiarios = new List<RegistroDiario>();
		private List<RegistroDiarioProducto> registrosDiariosProd = new List<RegistroDiarioProducto>();
		private List<ResumenMensual> resumenesMensuales = new List<ResumenMensual>();


		public Pagos()
		{
			InitializeComponent();
		}


		private List<ResumenMensual> ObtenerGananciasDesdeArchivo(string nombreArchivo)
		{
			try
			{
				List<ResumenMensual> ganancias = new List<ResumenMensual>();

				if (File.Exists(nombreArchivo))
				{
					using (StreamReader sr = new StreamReader(nombreArchivo))
					{
						// Leer la primera línea que contiene los encabezados de columna
						string[] encabezados = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

						// Crear un diccionario para mapear índices de columna por nombre de encabezado
						Dictionary<string, int> indiceColumnas = new Dictionary<string, int>();
						for (int i = 0; i < encabezados.Length; i++)
						{
							indiceColumnas.Add(encabezados[i], i);
						}

						// Leer las líneas restantes con datos
						while (!sr.EndOfStream)
						{
							string[] datos = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

							// Crear un objeto ResumenMensual y asignar los valores desde las columnas correspondientes
							ResumenMensual resumen = new ResumenMensual
							{
								Mes = datos[indiceColumnas["Mes"]],
								Ganancias = decimal.Parse(datos[indiceColumnas["Ganancia"]]),
							};

							ganancias.Add(resumen);
						}
					}
				}
				else
				{
					MessageBox.Show($"El archivo {nombreArchivo} no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				return ganancias;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}



		private List<ResumenMensual> ObtenerGastosDesdeArchivo(string nombreArchivo)
		{
			try
			{
				List<ResumenMensual> gastos = new List<ResumenMensual>();

				if (File.Exists(nombreArchivo))
				{
					using (StreamReader sr = new StreamReader(nombreArchivo))
					{
						// Leer la primera línea que contiene los encabezados de columna
						string[] encabezados = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

						// Crear un diccionario para mapear índices de columna por nombre de encabezado
						Dictionary<string, int> indiceColumnas = new Dictionary<string, int>();
						for (int i = 0; i < encabezados.Length; i++)
						{
							indiceColumnas.Add(encabezados[i], i);
						}

						// Leer las líneas restantes con datos
						while (!sr.EndOfStream)
						{
							string[] datos = sr.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

							// Crear un objeto ResumenMensual y asignar los valores desde las columnas correspondientes
							ResumenMensual resumen = new ResumenMensual
							{
								Mes = datos[indiceColumnas["Mes"]],
								Gastos = decimal.Parse(datos[indiceColumnas["Gasto"]]),
								// Agregar más propiedades según las columnas en tu archivo
							};

							gastos.Add(resumen);
						}
					}
				}
				else
				{
					MessageBox.Show($"El archivo {nombreArchivo} no existe.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

				return gastos;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}


		private void Pagos_Load(object sender, EventArgs e)
		{




			List<ResumenMensual> ganancias = ObtenerGananciasDesdeArchivo("GananciasMensuales.txt");
			List<ResumenMensual> gastos = ObtenerGastosDesdeArchivo("GastosMensuales.txt");

			if (ganancias != null && gastos != null)
			{
				var resumenMensual = ganancias.Join(gastos,
									g => g.Mes,
									h => h.Mes,
									(g, h) => new ResumenMensual
									{
										Mes = g.Mes,
										Ganancias = g.Ganancias,
										Gastos = h.Gastos,
										DineroDisponible = g.Ganancias - h.Gastos,
										DineroParaUtilidad = (g.Ganancias - h.Gastos) / 2,
										Salario1 = Math.Round((g.Ganancias - h.Gastos) / 4, 2),
										Salario2 = Math.Round((g.Ganancias - h.Gastos) / 4, 2),
									}, StringComparer.OrdinalIgnoreCase).ToList();


				decimal sumaDineroParaUtilidad = resumenMensual.Sum(item => item.DineroParaUtilidad);
				decimal sumaSalario = resumenMensual.Sum(item => item.Salario1);

				txtEfectivoDisponible.Text = "$ " + sumaDineroParaUtilidad;

				//txtEfectivoTotal.Text = "$ " + (decimal.Parse("126.05") + sumaDineroParaUtilidad).ToString();
				//txtEfectivoTotal.Text = "$ " + 126.05;

				decimal valorInicialEfectivoTotal = 126.05m;

				decimal nuevoValorEfectivoTotal = valorInicialEfectivoTotal + sumaDineroParaUtilidad;

				txtEfectivoTotal.Text = "$ " + nuevoValorEfectivoTotal.ToString();

				txtPagoMes.Text = "$ " + Math.Round(sumaSalario, 2);

				dataGridViewResumenMensual.DataSource = null;
				dataGridViewResumenMensual.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

				dataGridViewResumenMensual.DataSource = resumenMensual;

				dataGridViewResumenMensual.Columns["Mes"].DefaultCellStyle.Format = "MM-yyyy";
				dataGridViewResumenMensual.Columns["Ganancias"].DefaultCellStyle.Format = "C";
				dataGridViewResumenMensual.Columns["Gastos"].DefaultCellStyle.Format = "C";
				dataGridViewResumenMensual.Columns["DineroDisponible"].DefaultCellStyle.Format = "C";
				dataGridViewResumenMensual.Columns["DineroParaUtilidad"].DefaultCellStyle.Format = "C";

				dataGridViewResumenMensual.Columns["Salario1"].DefaultCellStyle.Format = "C";
				dataGridViewResumenMensual.Columns["Salario2"].DefaultCellStyle.Format = "C";

				dataGridViewResumenMensual.Columns[0].Width = 114;
				dataGridViewResumenMensual.Columns[1].Width = 120;
				dataGridViewResumenMensual.Columns[2].Width = 120;
				dataGridViewResumenMensual.Columns[3].Width = 150;
				dataGridViewResumenMensual.Columns[4].Width = 170;
				dataGridViewResumenMensual.Columns[5].Width = 114;
				dataGridViewResumenMensual.Columns[6].Width = 114;
			}

			GuardarDetalleMensual("ResumenMensual.txt", dataGridViewResumenMensual);

		}


		private void GuardarDetalleMensual(string nombreArchivo, DataGridView dataGridView)
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
						contenido.Append(celda.Value.ToString().PadRight(23) + "   ");
					}
					contenido.AppendLine();
				}

				// Escribir el contenido en el archivo
				File.WriteAllText(nombreArchivo, contenido.ToString());

				MessageBox.Show($"El contenido se ha guardado correctamente en {nombreArchivo}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error al guardar en el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void txtEfectivoTotal_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
