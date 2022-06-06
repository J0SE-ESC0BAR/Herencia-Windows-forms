using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7_Ej_Herencia_3
{
    class ProdTipo:Productos
    {
        //variables locales de la clase
        double total;
        public override double Calcular(double precio, int cantidad)
        {
            total = precio * cantidad;
            return total;
        }
    }
}
