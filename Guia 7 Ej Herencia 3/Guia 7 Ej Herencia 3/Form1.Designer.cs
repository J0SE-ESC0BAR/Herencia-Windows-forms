
namespace Guia_7_Ej_Herencia_3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbNomProd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCaducaProd = new System.Windows.Forms.TextBox();
            this.lblCaducaProd = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCantidadProd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrecioProd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTipoProd = new System.Windows.Forms.TextBox();
            this.lblTipoProd = new System.Windows.Forms.Label();
            this.rbNoCaducidad = new System.Windows.Forms.RadioButton();
            this.rbSiCaducidad = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPagarLista = new System.Windows.Forms.TextBox();
            this.NomProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caducidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de ventas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLista);
            this.groupBox1.Location = new System.Drawing.Point(285, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 346);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de productos";
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomProd,
            this.Cantidad,
            this.Precio,
            this.Caducidad,
            this.Tipo});
            this.dgvLista.Location = new System.Drawing.Point(6, 19);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(364, 321);
            this.dgvLista.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbNomProd);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbCaducaProd);
            this.groupBox2.Controls.Add(this.lblCaducaProd);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbCantidadProd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbPrecioProd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbTipoProd);
            this.groupBox2.Controls.Add(this.lblTipoProd);
            this.groupBox2.Controls.Add(this.rbNoCaducidad);
            this.groupBox2.Controls.Add(this.rbSiCaducidad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 368);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingreso de productos";
            // 
            // tbNomProd
            // 
            this.tbNomProd.Location = new System.Drawing.Point(22, 50);
            this.tbNomProd.Name = "tbNomProd";
            this.tbNomProd.Size = new System.Drawing.Size(100, 20);
            this.tbNomProd.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Ingresa el nombre del producto";
            // 
            // tbCaducaProd
            // 
            this.tbCaducaProd.Location = new System.Drawing.Point(19, 154);
            this.tbCaducaProd.Name = "tbCaducaProd";
            this.tbCaducaProd.Size = new System.Drawing.Size(100, 20);
            this.tbCaducaProd.TabIndex = 13;
            this.tbCaducaProd.Visible = false;
            // 
            // lblCaducaProd
            // 
            this.lblCaducaProd.AutoSize = true;
            this.lblCaducaProd.Location = new System.Drawing.Point(16, 138);
            this.lblCaducaProd.Name = "lblCaducaProd";
            this.lblCaducaProd.Size = new System.Drawing.Size(171, 13);
            this.lblCaducaProd.TabIndex = 12;
            this.lblCaducaProd.Text = "Ingrese los dias en los que caduca";
            this.lblCaducaProd.Visible = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(95, 329);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Precione agregar para agregar a la lista";
            // 
            // tbCantidadProd
            // 
            this.tbCantidadProd.Location = new System.Drawing.Point(22, 264);
            this.tbCantidadProd.Name = "tbCantidadProd";
            this.tbCantidadProd.Size = new System.Drawing.Size(100, 20);
            this.tbCantidadProd.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ingrese la cantidad de productos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "$";
            // 
            // tbPrecioProd
            // 
            this.tbPrecioProd.Location = new System.Drawing.Point(19, 206);
            this.tbPrecioProd.Name = "tbPrecioProd";
            this.tbPrecioProd.Size = new System.Drawing.Size(100, 20);
            this.tbPrecioProd.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ingrese el precio del producto";
            // 
            // tbTipoProd
            // 
            this.tbTipoProd.Location = new System.Drawing.Point(19, 154);
            this.tbTipoProd.Name = "tbTipoProd";
            this.tbTipoProd.Size = new System.Drawing.Size(100, 20);
            this.tbTipoProd.TabIndex = 4;
            this.tbTipoProd.Visible = false;
            // 
            // lblTipoProd
            // 
            this.lblTipoProd.AutoSize = true;
            this.lblTipoProd.Location = new System.Drawing.Point(16, 138);
            this.lblTipoProd.Name = "lblTipoProd";
            this.lblTipoProd.Size = new System.Drawing.Size(133, 13);
            this.lblTipoProd.TabIndex = 3;
            this.lblTipoProd.Text = "Ingrese el tipo de producto";
            this.lblTipoProd.Visible = false;
            // 
            // rbNoCaducidad
            // 
            this.rbNoCaducidad.AutoSize = true;
            this.rbNoCaducidad.Location = new System.Drawing.Point(70, 106);
            this.rbNoCaducidad.Name = "rbNoCaducidad";
            this.rbNoCaducidad.Size = new System.Drawing.Size(39, 17);
            this.rbNoCaducidad.TabIndex = 2;
            this.rbNoCaducidad.TabStop = true;
            this.rbNoCaducidad.Text = "No";
            this.rbNoCaducidad.UseVisualStyleBackColor = true;
            this.rbNoCaducidad.CheckedChanged += new System.EventHandler(this.rbNoCaducidad_CheckedChanged);
            // 
            // rbSiCaducidad
            // 
            this.rbSiCaducidad.AutoSize = true;
            this.rbSiCaducidad.Location = new System.Drawing.Point(19, 106);
            this.rbSiCaducidad.Name = "rbSiCaducidad";
            this.rbSiCaducidad.Size = new System.Drawing.Size(34, 17);
            this.rbSiCaducidad.TabIndex = 1;
            this.rbSiCaducidad.TabStop = true;
            this.rbSiCaducidad.Text = "Si";
            this.rbSiCaducidad.UseVisualStyleBackColor = true;
            this.rbSiCaducidad.CheckedChanged += new System.EventHandler(this.rbSiCaducidad_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "¿El producto tiene fecha de caducidad?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total a pagar";
            // 
            // tbPagarLista
            // 
            this.tbPagarLista.Enabled = false;
            this.tbPagarLista.Location = new System.Drawing.Point(399, 407);
            this.tbPagarLista.Name = "tbPagarLista";
            this.tbPagarLista.Size = new System.Drawing.Size(100, 20);
            this.tbPagarLista.TabIndex = 6;
            this.tbPagarLista.Text = "0";
            // 
            // NomProd
            // 
            this.NomProd.HeaderText = "Nombre";
            this.NomProd.Name = "NomProd";
            this.NomProd.ReadOnly = true;
            this.NomProd.Width = 70;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Nº";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 40;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 70;
            // 
            // Caducidad
            // 
            this.Caducidad.HeaderText = "Fecha de Caducidad";
            this.Caducidad.Name = "Caducidad";
            this.Caducidad.ReadOnly = true;
            this.Caducidad.Width = 70;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 455);
            this.Controls.Add(this.tbPagarLista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPrecioProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTipoProd;
        private System.Windows.Forms.Label lblTipoProd;
        private System.Windows.Forms.RadioButton rbNoCaducidad;
        private System.Windows.Forms.RadioButton rbSiCaducidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCantidadProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCaducaProd;
        private System.Windows.Forms.Label lblCaducaProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPagarLista;
        private System.Windows.Forms.TextBox tbNomProd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caducidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}

