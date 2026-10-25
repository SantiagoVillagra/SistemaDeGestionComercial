namespace Rotiseria.Presentacion
{
    partial class FrmNuevoCliente
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
            this.aceptarBtn = new System.Windows.Forms.Button();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.apeTxt = new System.Windows.Forms.TextBox();
            this.telTxt = new System.Windows.Forms.TextBox();
            this.dirTxt = new System.Windows.Forms.TextBox();
            this.nomLbl = new System.Windows.Forms.Label();
            this.apeLbl = new System.Windows.Forms.Label();
            this.telLbl = new System.Windows.Forms.Label();
            this.dirLbl = new System.Windows.Forms.Label();
            this.cboBarrios = new System.Windows.Forms.ComboBox();
            this.nuevoBarrioBtn = new System.Windows.Forms.Button();
            this.barriolbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aceptarBtn
            // 
            this.aceptarBtn.Location = new System.Drawing.Point(35, 363);
            this.aceptarBtn.Name = "aceptarBtn";
            this.aceptarBtn.Size = new System.Drawing.Size(75, 23);
            this.aceptarBtn.TabIndex = 11;
            this.aceptarBtn.Text = "Aceptar";
            this.aceptarBtn.UseVisualStyleBackColor = true;
            this.aceptarBtn.Click += new System.EventHandler(this.aceptarBtn_Click);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(283, 363);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelarBtn.TabIndex = 12;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(152, 26);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(206, 20);
            this.nombreTxt.TabIndex = 1;
            // 
            // apeTxt
            // 
            this.apeTxt.Location = new System.Drawing.Point(152, 76);
            this.apeTxt.Name = "apeTxt";
            this.apeTxt.Size = new System.Drawing.Size(206, 20);
            this.apeTxt.TabIndex = 3;
            // 
            // telTxt
            // 
            this.telTxt.Location = new System.Drawing.Point(152, 124);
            this.telTxt.Name = "telTxt";
            this.telTxt.Size = new System.Drawing.Size(206, 20);
            this.telTxt.TabIndex = 5;
            // 
            // dirTxt
            // 
            this.dirTxt.Location = new System.Drawing.Point(152, 176);
            this.dirTxt.Name = "dirTxt";
            this.dirTxt.Size = new System.Drawing.Size(206, 20);
            this.dirTxt.TabIndex = 7;
            // 
            // nomLbl
            // 
            this.nomLbl.AutoSize = true;
            this.nomLbl.Location = new System.Drawing.Point(32, 32);
            this.nomLbl.Name = "nomLbl";
            this.nomLbl.Size = new System.Drawing.Size(44, 13);
            this.nomLbl.TabIndex = 0;
            this.nomLbl.Text = "Nombre";
            // 
            // apeLbl
            // 
            this.apeLbl.AutoSize = true;
            this.apeLbl.Location = new System.Drawing.Point(32, 83);
            this.apeLbl.Name = "apeLbl";
            this.apeLbl.Size = new System.Drawing.Size(44, 13);
            this.apeLbl.TabIndex = 2;
            this.apeLbl.Text = "Apellido";
            // 
            // telLbl
            // 
            this.telLbl.AutoSize = true;
            this.telLbl.Location = new System.Drawing.Point(32, 127);
            this.telLbl.Name = "telLbl";
            this.telLbl.Size = new System.Drawing.Size(49, 13);
            this.telLbl.TabIndex = 4;
            this.telLbl.Text = "Telefono";
            this.telLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // dirLbl
            // 
            this.dirLbl.AutoSize = true;
            this.dirLbl.Location = new System.Drawing.Point(32, 179);
            this.dirLbl.Name = "dirLbl";
            this.dirLbl.Size = new System.Drawing.Size(52, 13);
            this.dirLbl.TabIndex = 6;
            this.dirLbl.Text = "Direccion";
            // 
            // cboBarrios
            // 
            this.cboBarrios.FormattingEnabled = true;
            this.cboBarrios.Location = new System.Drawing.Point(152, 223);
            this.cboBarrios.Name = "cboBarrios";
            this.cboBarrios.Size = new System.Drawing.Size(206, 21);
            this.cboBarrios.TabIndex = 9;
            // 
            // nuevoBarrioBtn
            // 
            this.nuevoBarrioBtn.Location = new System.Drawing.Point(152, 266);
            this.nuevoBarrioBtn.Name = "nuevoBarrioBtn";
            this.nuevoBarrioBtn.Size = new System.Drawing.Size(206, 23);
            this.nuevoBarrioBtn.TabIndex = 10;
            this.nuevoBarrioBtn.Text = "Nuevo Barrio";
            this.nuevoBarrioBtn.UseVisualStyleBackColor = true;
            this.nuevoBarrioBtn.Click += new System.EventHandler(this.nuevoBarrioBtn_Click);
            // 
            // barriolbl
            // 
            this.barriolbl.AutoSize = true;
            this.barriolbl.Location = new System.Drawing.Point(32, 231);
            this.barriolbl.Name = "barriolbl";
            this.barriolbl.Size = new System.Drawing.Size(34, 13);
            this.barriolbl.TabIndex = 8;
            this.barriolbl.Text = "Barrio";
            // 
            // FrmNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 416);
            this.Controls.Add(this.barriolbl);
            this.Controls.Add(this.nuevoBarrioBtn);
            this.Controls.Add(this.cboBarrios);
            this.Controls.Add(this.dirLbl);
            this.Controls.Add(this.telLbl);
            this.Controls.Add(this.apeLbl);
            this.Controls.Add(this.nomLbl);
            this.Controls.Add(this.dirTxt);
            this.Controls.Add(this.telTxt);
            this.Controls.Add(this.apeTxt);
            this.Controls.Add(this.nombreTxt);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.aceptarBtn);
            this.Name = "FrmNuevoCliente";
            this.Text = "Nuevo Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNuevoCliente_FormClosing);
            this.Load += new System.EventHandler(this.FrmNuevoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptarBtn;
        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox apeTxt;
        private System.Windows.Forms.TextBox telTxt;
        private System.Windows.Forms.TextBox dirTxt;
        private System.Windows.Forms.Label nomLbl;
        private System.Windows.Forms.Label apeLbl;
        private System.Windows.Forms.Label telLbl;
        private System.Windows.Forms.Label dirLbl;
        private System.Windows.Forms.ComboBox cboBarrios;
        private System.Windows.Forms.Button nuevoBarrioBtn;
        private System.Windows.Forms.Label barriolbl;
    }
}