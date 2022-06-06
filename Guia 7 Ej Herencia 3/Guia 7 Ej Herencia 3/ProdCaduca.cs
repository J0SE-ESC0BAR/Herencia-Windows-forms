using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7_Ej_Herencia_3
{
    class ProdCaduca:Productos
    {
        int DiasCaducidad;
        public int DiasCaducidad1 { get => DiasCaducidad; set => DiasCaducidad = value; }
        //variables locales
        double total;
        public override double Calcular(double precio, int cantidad)
        {
            if (DiasCaducidad>10)
            {
                total = (precio /2)*(cantidad);
            }
            else if (DiasCaducidad>5)
            {
                total = (precio /3) * (cantidad);
            }
            else if (DiasCaducidad>1)
            {
                total = (precio /4) * (cantidad);
            }
            return total;
        }
    }
}
