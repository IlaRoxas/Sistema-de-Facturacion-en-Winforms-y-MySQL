namespace Presentacion
{
    partial class Factura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCheck = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDProducto = new System.Windows.Forms.TextBox();
            this.txtIDcliente = new System.Windows.Forms.TextBox();
            this.panelInf = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dgvFactura = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadMedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnIDCliente = new System.Windows.Forms.Button();
            this.btnIDprodCant = new System.Windows.Forms.Button();
            this.btnFinCompra = new System.Windows.Forms.Button();
            this.btnCheck.SuspendLayout();
            this.panelInf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Controls.Add(this.btnBuscarCliente);
            this.btnCheck.Controls.Add(this.btnBuscarProducto);
            this.btnCheck.Controls.Add(this.btnIDCliente);
            this.btnCheck.Controls.Add(this.btnIDprodCant);
            this.btnCheck.Controls.Add(this.label15);
            this.btnCheck.Controls.Add(this.txtCantidad);
            this.btnCheck.Controls.Add(this.label12);
            this.btnCheck.Controls.Add(this.label11);
            this.btnCheck.Controls.Add(this.txtNroFactura);
            this.btnCheck.Controls.Add(this.dtpFechaFactura);
            this.btnCheck.Controls.Add(this.lblCliente);
            this.btnCheck.Controls.Add(this.label13);
            this.btnCheck.Controls.Add(this.btnFinCompra);
            this.btnCheck.Controls.Add(this.label2);
            this.btnCheck.Controls.Add(this.label1);
            this.btnCheck.Controls.Add(this.txtIDProducto);
            this.btnCheck.Controls.Add(this.txtIDcliente);
            this.btnCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheck.Location = new System.Drawing.Point(0, 0);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(809, 131);
            this.btnCheck.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID de Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID de cliente";
            // 
            // txtIDProducto
            // 
            this.txtIDProducto.Location = new System.Drawing.Point(5, 88);
            this.txtIDProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDProducto.Name = "txtIDProducto";
            this.txtIDProducto.Size = new System.Drawing.Size(131, 28);
            this.txtIDProducto.TabIndex = 3;
            // 
            // txtIDcliente
            // 
            this.txtIDcliente.Location = new System.Drawing.Point(4, 25);
            this.txtIDcliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDcliente.Name = "txtIDcliente";
            this.txtIDcliente.Size = new System.Drawing.Size(132, 28);
            this.txtIDcliente.TabIndex = 0;
            // 
            // panelInf
            // 
            this.panelInf.Controls.Add(this.label10);
            this.panelInf.Controls.Add(this.label9);
            this.panelInf.Controls.Add(this.label8);
            this.panelInf.Controls.Add(this.textBox6);
            this.panelInf.Controls.Add(this.textBox5);
            this.panelInf.Controls.Add(this.label7);
            this.panelInf.Controls.Add(this.label6);
            this.panelInf.Controls.Add(this.label5);
            this.panelInf.Controls.Add(this.label4);
            this.panelInf.Controls.Add(this.label3);
            this.panelInf.Controls.Add(this.textBox3);
            this.panelInf.Controls.Add(this.textBox4);
            this.panelInf.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInf.Location = new System.Drawing.Point(0, 457);
            this.panelInf.Margin = new System.Windows.Forms.Padding(4);
            this.panelInf.Name = "panelInf";
            this.panelInf.Size = new System.Drawing.Size(809, 131);
            this.panelInf.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(725, 100);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "ARS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(725, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "ARS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(725, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "ARS";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(593, 93);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(132, 28);
            this.textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(593, 65);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(132, 28);
            this.textBox5.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(725, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "%";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "IVA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Monto del IVA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Subtotal";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(593, 9);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(132, 28);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(593, 37);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(132, 28);
            this.textBox4.TabIndex = 3;
            // 
            // dgvFactura
            // 
            this.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Cantidad,
            this.UnidadMedida,
            this.ValorUnitario,
            this.Total});
            this.dgvFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFactura.Location = new System.Drawing.Point(0, 131);
            this.dgvFactura.Name = "dgvFactura";
            this.dgvFactura.Size = new System.Drawing.Size(809, 326);
            this.dgvFactura.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(371, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Finalizar compra";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Yu Gothic", 18F);
            this.lblCliente.Location = new System.Drawing.Point(354, 9);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(151, 31);
            this.lblCliente.TabIndex = 15;
            this.lblCliente.Text = "Anónima srl.";
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Font = new System.Drawing.Font("Yu Gothic", 10F);
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFactura.Location = new System.Drawing.Point(601, 94);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(200, 29);
            this.dtpFechaFactura.TabIndex = 16;
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(601, 25);
            this.txtNroFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.ReadOnly = true;
            this.txtNroFactura.Size = new System.Drawing.Size(200, 28);
            this.txtNroFactura.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(598, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Nro. de Factura";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(598, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Fecha de emisión";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 70;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 300;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // UnidadMedida
            // 
            this.UnidadMedida.HeaderText = "Unidad de medida";
            this.UnidadMedida.Name = "UnidadMedida";
            this.UnidadMedida.ReadOnly = true;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.HeaderText = "Precio por unidad";
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(143, 67);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 17);
            this.label15.TabIndex = 23;
            this.label15.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(144, 88);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(62, 28);
            this.txtCantidad.TabIndex = 4;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscarCliente.BackgroundImage = global::Presentacion.Properties.Resources.icons8_búsqueda_32;
            this.btnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Location = new System.Drawing.Point(175, 30);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(26, 23);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscarProducto.BackgroundImage = global::Presentacion.Properties.Resources.icons8_búsqueda_32;
            this.btnBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarProducto.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Location = new System.Drawing.Point(245, 90);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(26, 23);
            this.btnBuscarProducto.TabIndex = 6;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // btnIDCliente
            // 
            this.btnIDCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIDCliente.BackgroundImage = global::Presentacion.Properties.Resources.icons8_marca_de_verificación_sí_32;
            this.btnIDCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIDCliente.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIDCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIDCliente.Location = new System.Drawing.Point(143, 30);
            this.btnIDCliente.Name = "btnIDCliente";
            this.btnIDCliente.Size = new System.Drawing.Size(26, 23);
            this.btnIDCliente.TabIndex = 1;
            this.btnIDCliente.UseVisualStyleBackColor = false;
            // 
            // btnIDprodCant
            // 
            this.btnIDprodCant.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIDprodCant.BackgroundImage = global::Presentacion.Properties.Resources.icons8_marca_de_verificación_sí_32;
            this.btnIDprodCant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIDprodCant.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIDprodCant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIDprodCant.Location = new System.Drawing.Point(213, 90);
            this.btnIDprodCant.Name = "btnIDprodCant";
            this.btnIDprodCant.Size = new System.Drawing.Size(26, 23);
            this.btnIDprodCant.TabIndex = 5;
            this.btnIDprodCant.UseVisualStyleBackColor = false;
            // 
            // btnFinCompra
            // 
            this.btnFinCompra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFinCompra.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFinCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinCompra.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinCompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFinCompra.Image = global::Presentacion.Properties.Resources.icons8_carro_favorito_321;
            this.btnFinCompra.Location = new System.Drawing.Point(374, 87);
            this.btnFinCompra.Name = "btnFinCompra";
            this.btnFinCompra.Size = new System.Drawing.Size(104, 38);
            this.btnFinCompra.TabIndex = 6;
            this.btnFinCompra.UseVisualStyleBackColor = false;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 588);
            this.Controls.Add(this.dgvFactura);
            this.Controls.Add(this.panelInf);
            this.Controls.Add(this.btnCheck);
            this.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Factura";
            this.Text = "Factura";
            this.btnCheck.ResumeLayout(false);
            this.btnCheck.PerformLayout();
            this.panelInf.ResumeLayout(false);
            this.panelInf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btnCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtIDProducto;
        private System.Windows.Forms.TextBox txtIDcliente;
        private System.Windows.Forms.Panel panelInf;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvFactura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFinCompra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadMedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnIDprodCant;
        private System.Windows.Forms.Button btnIDCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnBuscarProducto;
    }
}