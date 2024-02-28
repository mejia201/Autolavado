using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chichi_autolavado.Models
{
    internal class RegistroDiarioProducto: RegistroDiarioBase
	{

        public DateTime Fecha { get; set; }
        public List<Producto> Productos
        {
            get; set;
        }

        public decimal TotalDia { get; set; }

        public string Mes => Fecha.ToString("MM-yyyy");

        public RegistroDiarioProducto(DateTime fecha)
        {
            Fecha = fecha;
            Productos = new List<Producto>();
            TotalDia = 0;


        }
    }
}
