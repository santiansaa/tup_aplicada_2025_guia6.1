using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Parcial
{
    public abstract class Producto: IComparable<Producto>
    {
        protected double preciobase;
        protected double largo;
        private int codigo;
        public int Codigo 
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public Producto(double precio, double largo) 
        {
            this.preciobase = precio;
            this.largo = largo;
        }
        abstract public double Peso();
        abstract public double Precio();

        public abstract int CompareTo();

    }
}
