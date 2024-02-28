using softwareContable.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chichi_autolavado.Models
{
    internal class RegistroDiario: RegistroDiarioBase
	{

        public DateTime Fecha { get; set; }
        public List<Lavado> Lavados
        {
            get; set;
        }

        public decimal TotalDia { get; set; }

        public string Mes => Fecha.ToString("MM-yyyy");



        public RegistroDiario(DateTime fecha)
        {
            Fecha = fecha;
            Lavados = new List<Lavado>();
            TotalDia = 0;

        }

    }


}
