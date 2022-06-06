using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_7_Ej_Herencia_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int a;
            double b;
            if (rbSiCaducidad.Checked == true || rbNoCaducidad.Checked == true && double.TryParse(tbPrecioProd.Text, out b) && int.TryParse(tbCantidadProd.Text, out a) && tbNomProd.Text != "")
            {
                if (rbSiCaducidad.Checked == true)
                {
                    ProdCaduca prodCadusidad = new ProdCaduca();
                    prodCadusidad.DiasCaducidad1 = int.Parse(tbCaducaProd.Text);
                    tbPagarLista.Text = (double.Parse(tbPagarLista.Text) + prodCadusidad.Calcular(double.Parse(tbPrecioProd.Text), int.Parse(tbCantidadProd.Text))).ToString();
                    int n = dgvLista.Rows.Add();
                    dgvLista.Rows[n].Cells[0].Value = tbNomProd.Text;
                    dgvLista.Rows[n].Cells[1].Value = tbCantidadProd.Text;
                    dgvLista.Rows[n].Cells[2].Value = "$" + tbPrecioProd.Text;
                    dgvLista.Rows[n].Cells[3].Value = "Vence " + tbCaducaProd.Text + " dias";
                    lblTipoProd.Visible = false;
                    tbTipoProd.Visible = false;
                    tbNomProd.Clear();
                    tbCaducaProd.Clear();
                    tbTipoProd.Clear();
                    tbPrecioProd.Clear();
                    tbCantidadProd.Clear();
                }
                if (rbNoCaducidad.Checked == true)
                {
                    ProdTipo prodTipo = new ProdTipo();
                    tbPagarLista.Text = (int.Parse(tbPagarLista.Text) + prodTipo.Calcular(double.Parse(tbPrecioProd.Text), int.Parse(tbCantidadProd.Text))).ToString();
                    int n = dgvLista.Rows.Add();
                    dgvLista.Rows[n].Cells[0].Value = tbNomProd.Text;
                    dgvLista.Rows[n].Cells[1].Value = tbCantidadProd.Text;
                    dgvLista.Rows[n].Cells[2].Value = "$" + tbPrecioProd.Text;
                    dgvLista.Rows[n].Cells[4].Value = tbTipoProd.Text; 
                    lblCaducaProd.Visible = false;
                    tbCaducaProd.Visible = false;
                    tbNomProd.Clear();
                    tbCaducaProd.Clear();
                    tbTipoProd.Clear();
                    tbPrecioProd.Clear();
                    tbCantidadProd.Clear();
                }
            }
            else
            {
                MessageBox.Show("No deje nada vacio\r\nPosibles problemas\r\n\nLos dias de caducidad debe ser un numero entero\r\nEl precio de ser un numero\r\nLa cantidad de productos debe ser un numero entero", "Error de datos");
            }
        }

        private void rbSiCaducidad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSiCaducidad.Checked==true)
            {
                lblTipoProd.Visible = false;
                tbTipoProd.Visible = false; 
                lblCaducaProd.Visible = true;
                tbCaducaProd.Visible = true;
            }
        }
        private void rbNoCaducidad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNoCaducidad.Checked == true)
            {
                lblTipoProd.Visible = true;
                tbTipoProd.Visible = true;
                lblCaducaProd.Visible = false;
                tbCaducaProd.Visible = false;
            }
        }
    }
}