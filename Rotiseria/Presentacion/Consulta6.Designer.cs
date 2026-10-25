namespace Rotiseria.Presentacion
{
    partial class Consulta6
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
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.labelUltimos = new System.Windows.Forms.Label();
            this.comboBoxMesAño = new System.Windows.Forms.ComboBox();
            this.labelMesAnio = new System.Windows.Forms.Label();
            this.comboBoxTipoProducto = new System.Windows.Forms.ComboBox();
            this.labelTipoProducto = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.ColumnIdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(309, 306);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(253, 75);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultar.TabIndex = 3;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(281, 36);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(47, 20);
            this.textBoxCantidad.TabIndex = 1;
            // 
            // labelUltimos
            // 
            this.labelUltimos.AutoSize = true;
            this.labelUltimos.Location = new System.Drawing.Point(226, 40);
            this.labelUltimos.Name = "labelUltimos";
            this.labelUltimos.Size = new System.Drawing.Size(52, 13);
            this.labelUltimos.TabIndex = 16;
            this.labelUltimos.Text = "Último/s: ";
            // 
            // comboBoxMesAño
            // 
            this.comboBoxMesAño.FormattingEnabled = true;
            this.comboBoxMesAño.Items.AddRange(new object[] {
            "MES",
            "AÑO"});
            this.comboBoxMesAño.Location = new System.Drawing.Point(81, 37);
            this.comboBoxMesAño.Name = "comboBoxMesAño";
            this.comboBoxMesAño.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMesAño.TabIndex = 0;
            // 
            // labelMesAnio
            // 
            this.labelMesAnio.AutoSize = true;
            this.labelMesAnio.Location = new System.Drawing.Point(25, 40);
            this.labelMesAnio.Name = "labelMesAnio";
            this.labelMesAnio.Size = new System.Drawing.Size(61, 13);
            this.labelMesAnio.TabIndex = 14;
            this.labelMesAnio.Text = "Fecha por: ";
            // 
            // comboBoxTipoProducto
            // 
            this.comboBoxTipoProducto.FormattingEnabled = true;
            this.comboBoxTipoProducto.Location = new System.Drawing.Point(81, 76);
            this.comboBoxTipoProducto.Name = "comboBoxTipoProducto";
            this.comboBoxTipoProducto.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoProducto.TabIndex = 2;
            // 
            // labelTipoProducto
            // 
            this.labelTipoProducto.AutoSize = true;
            this.labelTipoProducto.Location = new System.Drawing.Point(25, 80);
            this.labelTipoProducto.Name = "labelTipoProducto";
            this.labelTipoProducto.Size = new System.Drawing.Size(62, 13);
            this.labelTipoProducto.TabIndex = 12;
            this.labelTipoProducto.Text = "Tipo Prod.: ";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(168, 13);
            this.labelTitulo.TabIndex = 11;
            this.labelTitulo.Text = "Filtro por tipo de producto y fecha:";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIdPedido,
            this.ColumnFecha,
            this.ColumnPrecio});
            this.dgvConsulta.Location = new System.Drawing.Point(12, 103);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.Size = new System.Drawing.Size(399, 197);
            this.dgvConsulta.TabIndex = 5;
            // 
            // ColumnIdPedido
            // 
            this.ColumnIdPedido.HeaderText = "ID Pedido";
            this.ColumnIdPedido.Name = "ColumnIdPedido";
            this.ColumnIdPedido.ReadOnly = true;
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.HeaderText = "Fecha Pedido";
            this.ColumnFecha.Name = "ColumnFecha";
            this.ColumnFecha.ReadOnly = true;
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "Precio";
            this.ColumnPrecio.Name = "ColumnPrecio";
            this.ColumnPrecio.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Alvarez Daniel 430111";
            // 
            // Consulta6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 335);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.labelUltimos);
            this.Controls.Add(this.comboBoxMesAño);
            this.Controls.Add(this.labelMesAnio);
            this.Controls.Add(this.comboBoxTipoProducto);
            this.Controls.Add(this.labelTipoProducto);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.dgvConsulta);
            this.Name = "Consulta6";
            this.Text = "Consulta6";
            this.Load += new System.EventHandler(this.Consulta6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label labelUltimos;
        private System.Windows.Forms.ComboBox comboBoxMesAño;
        private System.Windows.Forms.Label labelMesAnio;
        private System.Windows.Forms.ComboBox comboBoxTipoProducto;
        private System.Windows.Forms.Label labelTipoProducto;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.Label label1;
    }
}