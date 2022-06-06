using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4_Guia7
{
    public partial class Form1 : Form
    {
        private DataTable tabla1;
        private DataTable tabla2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {

            Vectores magnitud = new Vectores();
            string tam = nudMagnitud.Text;
            int indice;
            indice = int.Parse(tam);
            magnitud.TamVec1 = indice;

            if (magnitud.TamVec1 <= 0)
            {
                epError.SetError(nudMagnitud, "Debe digitar una cantidad mayor a cero");
            }
            else if (magnitud.TamVec1 > 0)
            {
                epError.Clear();
                tabla1 = new DataTable();
                DataRow row = tabla1.NewRow();
                tabla2 = new DataTable();
                DataRow row1 = tabla2.NewRow();
                int[] vector1 = new int[magnitud.TamVec1];
                int[] vector2 = new int[magnitud.TamVec1];
                int posicion = 0;
                string nombrePosiccion;

                for (int c=1; c <= magnitud.TamVec1; c++)
                {
                    posicion = c - 1;
                    magnitud.Vec11 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox(("Digite el valor de la posicion " + (posicion) + " del vector 1"), "Valores del vector 1"));
                    vector1[posicion] = magnitud.Vec11;
                    nombrePosiccion = posicion.ToString();
                    tabla1.Columns.Add(nombrePosiccion);
                    dgvVector1.DataSource = tabla1;
                    row[nombrePosiccion] = magnitud.Vec11;
                }
                tabla1.Rows.Add(row);
                for (int c=1; c <= magnitud.TamVec1; c++)
                {
                    posicion = c - 1;
                    magnitud.Vec11 = int.Parse(Microsoft.VisualBasic.Interaction.InputBox(("Digite el valor de la posicion " + (posicion) + " del vector 2"), "Valores del vector 2"));
                    vector2[posicion] = magnitud.Vec11;
                    nombrePosiccion = posicion.ToString();
                    tabla2.Columns.Add(nombrePosiccion);
                    dgvVector2.DataSource = tabla2;
                    row1[nombrePosiccion] = magnitud.Vec11;
                    
                }
                tabla2.Rows.Add(row1);
                for (int c=0; c < vector1.LongLength; c++)
                {
                    if (vector1[c] == vector2[c])
                    {
                        lbResultado.Text = "Los vectores son iguales";
                    }
                    else if (vector1[c] != vector2[c])
                    {
                        lbResultado.Text = "Los vectores son diferentes";
                        break;
                    }
                }
            }
            nudMagnitud.Text = "0";
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
