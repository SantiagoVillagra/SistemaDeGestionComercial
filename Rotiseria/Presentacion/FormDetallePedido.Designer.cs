namespace Rotiseria.Presentacion
{
    partial class FormDetallePedido
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
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelHoraEntrega = new System.Windows.Forms.Label();
            this.labelHoraPedido = new System.Windows.Forms.Label();
            this.labelFormaPago = new System.Windows.Forms.Label();
            this.labelRepartidor = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelNroPedido = new System.Windows.Forms.Label();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.ColumnIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Location = new System.Drawing.Point(271, 18);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(40, 13);
            this.labelFecha.TabIndex = 1;
            this.labelFecha.Text = "Fecha:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(12, 314);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(34, 13);
            this.labelTotal.TabIndex = 18;
            this.labelTotal.Text = "Total:";
            // 
            // labelHoraEntrega
            // 
            this.labelHoraEntrega.AutoSize = true;
            this.labelHoraEntrega.Location = new System.Drawing.Point(268, 78);
            this.labelHoraEntrega.Name = "labelHoraEntrega";
            this.labelHoraEntrega.Size = new System.Drawing.Size(73, 13);
            this.labelHoraEntrega.TabIndex = 5;
            this.labelHoraEntrega.Text = "Hora Entrega:";
            // 
            // labelHoraPedido
            // 
            this.labelHoraPedido.AutoSize = true;
            this.labelHoraPedido.Location = new System.Drawing.Point(268, 48);
            this.labelHoraPedido.Name = "labelHoraPedido";
            this.labelHoraPedido.Size = new System.Drawing.Size(69, 13);
            this.labelHoraPedido.TabIndex = 3;
            this.labelHoraPedido.Text = "Hora Pedido:";
            // 
            // labelFormaPago
            // 
            this.labelFormaPago.AutoSize = true;
            this.labelFormaPago.Location = new System.Drawing.Point(12, 108);
            this.labelFormaPago.Name = "labelFormaPago";
            this.labelFormaPago.Size = new System.Drawing.Size(82, 13);
            this.labelFormaPago.TabIndex = 6;
            this.labelFormaPago.Text = "Forma de Pago:";
            // 
            // labelRepartidor
            // 
            this.labelRepartidor.AutoSize = true;
            this.labelRepartidor.Location = new System.Drawing.Point(12, 78);
            this.labelRepartidor.Name = "labelRepartidor";
            this.labelRepartidor.Size = new System.Drawing.Size(59, 13);
            this.labelRepartidor.TabIndex = 4;
            this.labelRepartidor.Text = "Repartidor:";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(12, 48);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(42, 13);
            this.labelCliente.TabIndex = 2;
            this.labelCliente.Text = "Cliente:";
            // 
            // labelNroPedido
            // 
            this.labelNroPedido.AutoSize = true;
            this.labelNroPedido.Location = new System.Drawing.Point(12, 18);
            this.labelNroPedido.Name = "labelNroPedido";
            this.labelNroPedido.Size = new System.Drawing.Size(66, 13);
            this.labelNroPedido.TabIndex = 0;
            this.labelNroPedido.Text = "Nro. Pedido:";
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(174, 328);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCerrar.TabIndex = 7;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdProducto,
            this.ColumnProducto,
            this.ColumnCantidad,
            this.ColumnPrecio,
            this.ColumnSubTot});
            this.dgvDetalle.Location = new System.Drawing.Point(10, 144);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.Size = new System.Drawing.Size(417, 150);
            this.dgvDetalle.TabIndex = 8;
            // 
            // ColumnIdProducto
            // 
            this.ColumnIdProducto.HeaderText = "Id Producto";
            this.ColumnIdProducto.Name = "ColumnIdProducto";
            this.ColumnIdProducto.ReadOnly = true;
            this.ColumnIdProducto.Visible = false;
            // 
            // ColumnProducto
            // 
            this.ColumnProducto.HeaderText = "Producto";
            this.ColumnProducto.Name = "ColumnProducto";
            this.ColumnProducto.ReadOnly = true;
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "Cant.";
            this.ColumnCantidad.Name = "ColumnCantidad";
            this.ColumnCantidad.ReadOnly = true;
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "Precio";
            this.ColumnPrecio.Name = "ColumnPrecio";
            this.ColumnPrecio.ReadOnly = true;
            // 
            // ColumnSubTot
            // 
            this.ColumnSubTot.HeaderText = "Subtotal";
            this.ColumnSubTot.Name = "ColumnSubTot";
            this.ColumnSubTot.ReadOnly = true;
            // 
            // FormDetallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 361);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelHoraEntrega);
            this.Controls.Add(this.labelHoraPedido);
            this.Controls.Add(this.labelFormaPago);
            this.Controls.Add(this.labelRepartidor);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelNroPedido);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.dgvDetalle);
            this.Name = "FormDetallePedido";
            this.Text = "FormDetallePedido";
            this.Load += new System.EventHandler(this.DetallePedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelHoraEntrega;
        private System.Windows.Forms.Label labelHoraPedido;
        private System.Windows.Forms.Label labelFormaPago;
        private System.Windows.Forms.Label labelRepartidor;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelNroPedido;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubTot;
    }
}