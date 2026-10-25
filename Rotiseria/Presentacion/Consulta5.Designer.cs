namespace Rotiseria.Presentacion
{
    partial class Consulta5
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvRepartidor = new System.Windows.Forms.DataGridView();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblRepartidor = new System.Windows.Forms.Label();
            this.cboRepartidor = new System.Windows.Forms.ComboBox();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepartidor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(15, 385);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(328, 67);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(359, 385);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvRepartidor
            // 
            this.dgvRepartidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepartidor.Location = new System.Drawing.Point(12, 125);
            this.dgvRepartidor.Name = "dgvRepartidor";
            this.dgvRepartidor.Size = new System.Drawing.Size(422, 219);
            this.dgvRepartidor.TabIndex = 5;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Location = new System.Drawing.Point(12, 36);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(43, 13);
            this.lblPeriodo.TabIndex = 4;
            this.lblPeriodo.Text = "Periodo";
            // 
            // lblRepartidor
            // 
            this.lblRepartidor.AutoSize = true;
            this.lblRepartidor.Location = new System.Drawing.Point(171, 36);
            this.lblRepartidor.Name = "lblRepartidor";
            this.lblRepartidor.Size = new System.Drawing.Size(56, 13);
            this.lblRepartidor.TabIndex = 5;
            this.lblRepartidor.Text = "Repartidor";
            // 
            // cboRepartidor
            // 
            this.cboRepartidor.FormattingEnabled = true;
            this.cboRepartidor.Location = new System.Drawing.Point(174, 67);
            this.cboRepartidor.Name = "cboRepartidor";
            this.cboRepartidor.Size = new System.Drawing.Size(121, 21);
            this.cboRepartidor.TabIndex = 1;
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Items.AddRange(new object[] {
            "Hoy",
            "1 mes",
            "3 meses",
            "6 meses"});
            this.cboPeriodo.Location = new System.Drawing.Point(12, 67);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(121, 21);
            this.cboPeriodo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Maschio-Steffen Valentina 430304";
            // 
            // Consulta5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPeriodo);
            this.Controls.Add(this.cboRepartidor);
            this.Controls.Add(this.lblRepartidor);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.dgvRepartidor);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnLimpiar);
            this.Name = "Consulta5";
            this.Text = "Consulta5";
            this.Load += new System.EventHandler(this.Consulta5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepartidor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvRepartidor;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblRepartidor;
        private System.Windows.Forms.ComboBox cboRepartidor;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Label label1;
    }
}