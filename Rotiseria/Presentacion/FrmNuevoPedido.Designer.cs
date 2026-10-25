namespace Rotiseria.Presentacion
{
    partial class FrmNuevoPedido
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
            this.labelHoraEntrega = new System.Windows.Forms.Label();
            this.labelHoraPedido = new System.Windows.Forms.Label();
            this.dtpEntrega = new System.Windows.Forms.DateTimePicker();
            this.dtpPedido = new System.Windows.Forms.DateTimePicker();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.comboBoxFormaPago = new System.Windows.Forms.ComboBox();
            this.labelFormaPago = new System.Windows.Forms.Label();
            this.comboBoxRepartidor = new System.Windows.Forms.ComboBox();
            this.labelRepartidor = new System.Windows.Forms.Label();
            this.textBoxDirCliente = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonQuitar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.ColumnIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxTelCliente = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxNomCliente = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.lebelIdCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHoraEntrega
            // 
            this.labelHoraEntrega.AutoSize = true;
            this.labelHoraEntrega.Location = new System.Drawing.Point(176, 243);
            this.labelHoraEntrega.Name = "labelHoraEntrega";
            this.labelHoraEntrega.Size = new System.Drawing.Size(76, 13);
            this.labelHoraEntrega.TabIndex = 47;
            this.labelHoraEntrega.Text = "Hora Entrega :";
            // 
            // labelHoraPedido
            // 
            this.labelHoraPedido.AutoSize = true;
            this.labelHoraPedido.Location = new System.Drawing.Point(18, 243);
            this.labelHoraPedido.Name = "labelHoraPedido";
            this.labelHoraPedido.Size = new System.Drawing.Size(72, 13);
            this.labelHoraPedido.TabIndex = 46;
            this.labelHoraPedido.Text = "Hora Pedido :";
            // 
            // dtpEntrega
            // 
            this.dtpEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEntrega.Location = new System.Drawing.Point(256, 239);
            this.dtpEntrega.Name = "dtpEntrega";
            this.dtpEntrega.ShowUpDown = true;
            this.dtpEntrega.Size = new System.Drawing.Size(70, 20);
            this.dtpEntrega.TabIndex = 8;
            this.dtpEntrega.ValueChanged += new System.EventHandler(this.dtpEntrega_ValueChanged);
            // 
            // dtpPedido
            // 
            this.dtpPedido.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpPedido.Location = new System.Drawing.Point(96, 239);
            this.dtpPedido.Name = "dtpPedido";
            this.dtpPedido.ShowUpDown = true;
            this.dtpPedido.Size = new System.Drawing.Size(73, 20);
            this.dtpPedido.TabIndex = 7;
            this.dtpPedido.ValueChanged += new System.EventHandler(this.dtpPedido_ValueChanged);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(417, 239);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(68, 20);
            this.textBoxTotal.TabIndex = 43;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(364, 243);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(57, 13);
            this.labelTotal.TabIndex = 42;
            this.labelTotal.Text = "TOTAL:  $";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(389, 267);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 12;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // comboBoxFormaPago
            // 
            this.comboBoxFormaPago.FormattingEnabled = true;
            this.comboBoxFormaPago.Location = new System.Drawing.Point(346, 66);
            this.comboBoxFormaPago.Name = "comboBoxFormaPago";
            this.comboBoxFormaPago.Size = new System.Drawing.Size(142, 21);
            this.comboBoxFormaPago.TabIndex = 6;
            this.comboBoxFormaPago.SelectedIndexChanged += new System.EventHandler(this.comboBoxFormaPago_SelectedIndexChanged);
            // 
            // labelFormaPago
            // 
            this.labelFormaPago.AutoSize = true;
            this.labelFormaPago.Location = new System.Drawing.Point(258, 70);
            this.labelFormaPago.Name = "labelFormaPago";
            this.labelFormaPago.Size = new System.Drawing.Size(82, 13);
            this.labelFormaPago.TabIndex = 39;
            this.labelFormaPago.Text = "Forma de Pago:";
            // 
            // comboBoxRepartidor
            // 
            this.comboBoxRepartidor.FormattingEnabled = true;
            this.comboBoxRepartidor.Location = new System.Drawing.Point(81, 66);
            this.comboBoxRepartidor.Name = "comboBoxRepartidor";
            this.comboBoxRepartidor.Size = new System.Drawing.Size(171, 21);
            this.comboBoxRepartidor.TabIndex = 5;
            this.comboBoxRepartidor.SelectedIndexChanged += new System.EventHandler(this.comboBoxRepartidor_SelectedIndexChanged);
            // 
            // labelRepartidor
            // 
            this.labelRepartidor.AutoSize = true;
            this.labelRepartidor.Location = new System.Drawing.Point(19, 70);
            this.labelRepartidor.Name = "labelRepartidor";
            this.labelRepartidor.Size = new System.Drawing.Size(59, 13);
            this.labelRepartidor.TabIndex = 37;
            this.labelRepartidor.Text = "Repartidor:";
            // 
            // textBoxDirCliente
            // 
            this.textBoxDirCliente.Location = new System.Drawing.Point(227, 40);
            this.textBoxDirCliente.Name = "textBoxDirCliente";
            this.textBoxDirCliente.Size = new System.Drawing.Size(260, 20);
            this.textBoxDirCliente.TabIndex = 4;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(195, 44);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(26, 13);
            this.labelDireccion.TabIndex = 35;
            this.labelDireccion.Text = "Dir.:";
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(246, 267);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(119, 23);
            this.buttonCargar.TabIndex = 11;
            this.buttonCargar.Text = "Cargar Pedido";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click_1);
            // 
            // buttonQuitar
            // 
            this.buttonQuitar.Location = new System.Drawing.Point(146, 267);
            this.buttonQuitar.Name = "buttonQuitar";
            this.buttonQuitar.Size = new System.Drawing.Size(75, 23);
            this.buttonQuitar.TabIndex = 10;
            this.buttonQuitar.Text = "Quitar";
            this.buttonQuitar.UseVisualStyleBackColor = true;
            this.buttonQuitar.Click += new System.EventHandler(this.buttonQuitar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(38, 267);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 9;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdProducto,
            this.ColumnProducto,
            this.ColumnCantidad,
            this.ColumnPrecio,
            this.ColumnSubtotal});
            this.dgvDetalles.Location = new System.Drawing.Point(18, 101);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(469, 133);
            this.dgvDetalles.TabIndex = 31;
            // 
            // ColumnIdProducto
            // 
            this.ColumnIdProducto.HeaderText = "IdProducto";
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
            this.ColumnCantidad.HeaderText = "Cantidad";
            this.ColumnCantidad.Name = "ColumnCantidad";
            this.ColumnCantidad.ReadOnly = true;
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "Precio";
            this.ColumnPrecio.Name = "ColumnPrecio";
            this.ColumnPrecio.ReadOnly = true;
            // 
            // ColumnSubtotal
            // 
            this.ColumnSubtotal.HeaderText = "Subtotal";
            this.ColumnSubtotal.Name = "ColumnSubtotal";
            this.ColumnSubtotal.ReadOnly = true;
            // 
            // textBoxTelCliente
            // 
            this.textBoxTelCliente.Location = new System.Drawing.Point(49, 40);
            this.textBoxTelCliente.Name = "textBoxTelCliente";
            this.textBoxTelCliente.Size = new System.Drawing.Size(123, 20);
            this.textBoxTelCliente.TabIndex = 3;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(15, 44);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(28, 13);
            this.labelTelefono.TabIndex = 29;
            this.labelTelefono.Text = "Tel.:";
            // 
            // textBoxNomCliente
            // 
            this.textBoxNomCliente.Location = new System.Drawing.Point(307, 12);
            this.textBoxNomCliente.Name = "textBoxNomCliente";
            this.textBoxNomCliente.Size = new System.Drawing.Size(177, 20);
            this.textBoxNomCliente.TabIndex = 2;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(256, 16);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 27;
            this.labelNombre.Text = "Nombre:";
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Location = new System.Drawing.Point(177, 11);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccionar.TabIndex = 1;
            this.buttonSeleccionar.Text = "Seleccionar";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(73, 12);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdCliente.TabIndex = 0;
            // 
            // lebelIdCliente
            // 
            this.lebelIdCliente.AutoSize = true;
            this.lebelIdCliente.Location = new System.Drawing.Point(15, 16);
            this.lebelIdCliente.Name = "lebelIdCliente";
            this.lebelIdCliente.Size = new System.Drawing.Size(54, 13);
            this.lebelIdCliente.TabIndex = 24;
            this.lebelIdCliente.Text = "Id Cliente:";
            // 
            // FrmNuevoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 307);
            this.Controls.Add(this.labelHoraEntrega);
            this.Controls.Add(this.labelHoraPedido);
            this.Controls.Add(this.dtpEntrega);
            this.Controls.Add(this.dtpPedido);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.comboBoxFormaPago);
            this.Controls.Add(this.labelFormaPago);
            this.Controls.Add(this.comboBoxRepartidor);
            this.Controls.Add(this.labelRepartidor);
            this.Controls.Add(this.textBoxDirCliente);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.buttonQuitar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.textBoxTelCliente);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.textBoxNomCliente);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.textBoxIdCliente);
            this.Controls.Add(this.lebelIdCliente);
            this.Name = "FrmNuevoPedido";
            this.Text = "NuevoPedido";
            this.Load += new System.EventHandler(this.FrmNuevoPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHoraEntrega;
        private System.Windows.Forms.Label labelHoraPedido;
        private System.Windows.Forms.DateTimePicker dtpEntrega;
        private System.Windows.Forms.DateTimePicker dtpPedido;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.ComboBox comboBoxFormaPago;
        private System.Windows.Forms.Label labelFormaPago;
        private System.Windows.Forms.ComboBox comboBoxRepartidor;
        private System.Windows.Forms.Label labelRepartidor;
        private System.Windows.Forms.TextBox textBoxDirCliente;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonQuitar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubtotal;
        private System.Windows.Forms.TextBox textBoxTelCliente;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxNomCliente;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.Label lebelIdCliente;
    }
}