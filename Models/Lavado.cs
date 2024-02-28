﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chichi_autolavado.Models
{
    internal class Lavado
    {

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }

        public override string ToString()
        {
            return $"{Marca} {Modelo} - Precio: {Precio:C}";
        }


    }
}
