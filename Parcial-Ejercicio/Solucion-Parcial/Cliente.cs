using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion_Parcial
{
    internal class Cliente
    {
        private string nombre;
        private string direccion;

        public Cliente(string nom,string dir) 
        {
            this.nombre = nom;
            this.direccion = dir;
        }
        public override string ToString()
        {
            return $"Nombre:{nombre} y Direccion:{direccion}";
        }  
        

        
    }
}
