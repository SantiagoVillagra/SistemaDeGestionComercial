namespace Rotiseria.Presentacion
{
    partial class FrmCliente
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
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.nomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.barrioCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscarbtn = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nuevoBtn = new System.Windows.Forms.Button();
            this.modificarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.limpiarBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomCliente,
            this.apeCliente,
            this.telCliente,
            this.direCliente,
            this.barrioCliente,
            this.idCliente});
            this.dgvCliente.Location = new System.Drawing.Point(43, 94);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersWidth = 51;
            this.dgvCliente.RowTemplate.Height = 24;
            this.dgvCliente.Size = new System.Drawing.Size(917, 182);
            this.dgvCliente.TabIndex = 8;
            this.dgvCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCliente_CellDoubleClick);
            // 
            // nomCliente
            // 
            this.nomCliente.HeaderText = "Nombre";
            this.nomCliente.MinimumWidth = 6;
            this.nomCliente.Name = "nomCliente";
            this.nomCliente.ReadOnly = true;
            this.nomCliente.Width = 125;
            // 
            // apeCliente
            // 
            this.apeCliente.HeaderText = "Apellido";
            this.apeCliente.MinimumWidth = 6;
            this.apeCliente.Name = "apeCliente";
            this.apeCliente.ReadOnly = true;
            this.apeCliente.Width = 125;
            // 
            // telCliente
            // 
            this.telCliente.HeaderText = "Telefono";
            this.telCliente.MinimumWidth = 6;
            this.telCliente.Name = "telCliente";
            this.telCliente.ReadOnly = true;
            this.telCliente.Width = 125;
            // 
            // direCliente
            // 
            this.direCliente.HeaderText = "Direccion";
            this.direCliente.MinimumWidth = 6;
            this.direCliente.Name = "direCliente";
            this.direCliente.ReadOnly = true;
            this.direCliente.Width = 155;
            // 
            // barrioCliente
            // 
            this.barrioCliente.HeaderText = "Barrio";
            this.barrioCliente.MinimumWidth = 6;
            this.barrioCliente.Name = "barrioCliente";
            this.barrioCliente.ReadOnly = true;
            this.barrioCliente.Width = 125;
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "ID";
            this.idCliente.MinimumWidth = 6;
            this.idCliente.Name = "idCliente";
            this.idCliente.ReadOnly = true;
            this.idCliente.Visible = false;
            this.idCliente.Width = 125;
            // 
            // buscarbtn
            // 
            this.buscarbtn.Location = new System.Drawing.Point(477, 38);
            this.buscarbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buscarbtn.Name = "buscarbtn";
            this.buscarbtn.Size = new System.Drawing.Size(75, 23);
            this.buscarbtn.TabIndex = 2;
            this.buscarbtn.Text = "Buscar";
            this.buscarbtn.UseVisualStyleBackColor = true;
            this.buscarbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(131, 39);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(313, 22);
            this.txtFiltro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Telefono:";
            // 
            // nuevoBtn
            // 
            this.nuevoBtn.Location = new System.Drawing.Point(43, 297);
            this.nuevoBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nuevoBtn.Name = "nuevoBtn";
            this.nuevoBtn.Size = new System.Drawing.Size(75, 23);
            this.nuevoBtn.TabIndex = 4;
            this.nuevoBtn.Text = "Nuevo";
            this.nuevoBtn.UseVisualStyleBackColor = true;
            this.nuevoBtn.Click += new System.EventHandler(this.nuevoBtn_Click);
            // 
            // modificarBtn
            // 
            this.modificarBtn.Location = new System.Drawing.Point(269, 297);
            this.modificarBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modificarBtn.Name = "modificarBtn";
            this.modificarBtn.Size = new System.Drawing.Size(88, 23);
            this.modificarBtn.TabIndex = 5;
            this.modificarBtn.Text = "Modificar";
            this.modificarBtn.UseVisualStyleBackColor = true;
            this.modificarBtn.Click += new System.EventHandler(this.modificarBtn_Click);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(536, 297);
            this.eliminarBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarBtn.TabIndex = 6;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(837, 297);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(627, 39);
            this.limpiarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(100, 28);
            this.limpiarBtn.TabIndex = 3;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Busqueda por telefono:";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 348);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.modificarBtn);
            this.Controls.Add(this.nuevoBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.buscarbtn);
            this.Controls.Add(this.dgvCliente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCliente";
            this.Text = "Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCliente_FormClosing);
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button buscarbtn;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nuevoBtn;
        private System.Windows.Forms.Button modificarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn direCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn barrioCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.Button limpiarBtn;
        private System.Windows.Forms.Label label2;
    }
}