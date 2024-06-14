﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3.Negocio
{
    public class Provincia
    {
		private int codigo;

		public int Codigo
		{
			get { return codigo; }
			set { codigo = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public Provincia()
		{
			this.codigo = 0;
			this.nombre = string.Empty;
			
		}

        public override string ToString()
        {
            return this.nombre;
        }

    }
}
