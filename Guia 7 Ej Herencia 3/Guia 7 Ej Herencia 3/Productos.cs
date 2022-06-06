using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7_Ej_Herencia_3
{
    abstract class Productos
    {
        public Productos() 
        {
        }
        public abstract double Calcular(double precio, int cantidad);
    }
}
