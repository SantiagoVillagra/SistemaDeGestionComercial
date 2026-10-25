namespace Rotiseria.Presentacion
{
    partial class Consulta4
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
            this.dgvDemoras = new System.Windows.Forms.DataGridView();
            this.idPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minutosTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.consulta6Btn = new System.Windows.Forms.Button();
            this.salirBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.limpiarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemoras)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDemoras
            // 
            this.dgvDemoras.AllowUserToAddRows = false;
            this.dgvDemoras.AllowUserToDeleteRows = false;
            this.dgvDemoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedido,
            this.nomCliente,
            this.apeCliente,
            this.horaPedido,
            this.horaEntrega,
            this.tiempoEntrega});
            this.dgvDemoras.Location = new System.Drawing.Point(15, 136);
            this.dgvDemoras.Name = "dgvDemoras";
            this.dgvDemoras.ReadOnly = true;
            this.dgvDemoras.Size = new System.Drawing.Size(643, 150);
            this.dgvDemoras.TabIndex = 5;
            // 
            // idPedido
            // 
            this.idPedido.DataPropertyName = "idPedido";
            this.idPedido.HeaderText = "ID Pedido";
            this.idPedido.Name = "idPedido";
            this.idPedido.ReadOnly = true;
            // 
            // nomCliente
            // 
            this.nomCliente.DataPropertyName = "nomCliente";
            this.nomCliente.HeaderText = "Nombre Cliente";
            this.nomCliente.Name = "nomCliente";
            this.nomCliente.ReadOnly = true;
            // 
            // apeCliente
            // 
            this.apeCliente.DataPropertyName = "apeCliente";
            this.apeCliente.HeaderText = "Apellido";
            this.apeCliente.Name = "apeCliente";
            this.apeCliente.ReadOnly = true;
            // 
            // horaPedido
            // 
            this.horaPedido.DataPropertyName = "horaPedido";
            this.horaPedido.HeaderText = "Hora Pedido";
            this.horaPedido.Name = "horaPedido";
            this.horaPedido.ReadOnly = true;
            // 
            // horaEntrega
            // 
            this.horaEntrega.DataPropertyName = "horaEntrega";
            this.horaEntrega.HeaderText = "Hora Entrega";
            this.horaEntrega.Name = "horaEntrega";
            this.horaEntrega.ReadOnly = true;
            // 
            // tiempoEntrega
            // 
            this.tiempoEntrega.DataPropertyName = "tiempoEntrega";
            this.tiempoEntrega.HeaderText = "Tiempo de Entrega";
            this.tiempoEntrega.Name = "tiempoEntrega";
            this.tiempoEntrega.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Demora en minutos mayor a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Pedidos con demora";
            // 
            // minutosTxt
            // 
            this.minutosTxt.Location = new System.Drawing.Point(309, 87);
            this.minutosTxt.Name = "minutosTxt";
            this.minutosTxt.Size = new System.Drawing.Size(138, 20);
            this.minutosTxt.TabIndex = 2;
            this.minutosTxt.TextChanged += new System.EventHandler(this.minutosTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Desde:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(156, 87);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(101, 20);
            this.dtpHasta.TabIndex = 1;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(15, 87);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(101, 20);
            this.dtpDesde.TabIndex = 0;
            // 
            // consulta6Btn
            // 
            this.consulta6Btn.Location = new System.Drawing.Point(469, 84);
            this.consulta6Btn.Name = "consulta6Btn";
            this.consulta6Btn.Size = new System.Drawing.Size(70, 23);
            this.consulta6Btn.TabIndex = 3;
            this.consulta6Btn.Text = "Consultar";
            this.consulta6Btn.UseVisualStyleBackColor = true;
            this.consulta6Btn.Click += new System.EventHandler(this.consulta6Btn_Click);
            // 
            // salirBtn
            // 
            this.salirBtn.Location = new System.Drawing.Point(583, 314);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(75, 23);
            this.salirBtn.TabIndex = 4;
            this.salirBtn.Text = "Salir";
            this.salirBtn.UseVisualStyleBackColor = true;
            this.salirBtn.Click += new System.EventHandler(this.salirBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Villagra Santiago 430087";
            // 
            // limpiarBtn
            // 
            this.limpiarBtn.Location = new System.Drawing.Point(15, 314);
            this.limpiarBtn.Name = "limpiarBtn";
            this.limpiarBtn.Size = new System.Drawing.Size(75, 23);
            this.limpiarBtn.TabIndex = 32;
            this.limpiarBtn.Text = "Limpiar";
            this.limpiarBtn.UseVisualStyleBackColor = true;
            this.limpiarBtn.Click += new System.EventHandler(this.limpiarBtn_Click);
            // 
            // Consulta4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 349);
            this.Controls.Add(this.limpiarBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDemoras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minutosTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.consulta6Btn);
            this.Controls.Add(this.salirBtn);
            this.Name = "Consulta4";
            this.Text = "Consulta4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDemoras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox minutosTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Button consulta6Btn;
        private System.Windows.Forms.Button salirBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn apeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoEntrega;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button limpiarBtn;
    }
}