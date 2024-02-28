using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chichi_autolavado.Models
{
	internal class ResumenMensual
	{
		public string Mes { get; set; }
		public decimal Ganancias { get; set; }
		public decimal Gastos { get; set; }
		public decimal DineroDisponible { get; set; }

		public decimal DineroParaUtilidad { get; set; }

		public decimal Salario1 { get; set; }
		public decimal Salario2 { get; set; }

	}
}
