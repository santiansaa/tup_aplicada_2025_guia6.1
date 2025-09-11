﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Parcial
{
    abstract public class Producto : IComparable
    {
        protected double precioBase;
        protected double largo;
        private int codigo;

        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        public Producto(double precio, double largo)
        {
            this.precioBase = precio;
            this.largo = largo;
        }

        abstract public double Peso();
        abstract public double Precio();

        public override string ToString()
        {
            return codigo.ToString();
        }

        public int CompareTo(object obj)
        {
            Producto otro = obj as Producto;
            if (otro != null)
                return codigo.CompareTo(otro.codigo);
            return 1;
        }
    }




}
