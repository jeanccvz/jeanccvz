namespace Laboratorio4_Windowsforms_Valverde_A
{
    partial class FrmEjercicio4
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
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.txtinicio = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblinicial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfin = new System.Windows.Forms.TextBox();
            this.lblfinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(544, 169);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 13;
            this.btnlimpiar.Text = "limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(544, 219);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 12;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // txtTabla
            // 
            this.txtTabla.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTabla.Location = new System.Drawing.Point(259, 198);
            this.txtTabla.Multiline = true;
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(259, 408);
            this.txtTabla.TabIndex = 11;
            // 
            // txtinicio
            // 
            this.txtinicio.BackColor = System.Drawing.SystemColors.Info;
            this.txtinicio.Location = new System.Drawing.Point(336, 114);
            this.txtinicio.Name = "txtinicio";
            this.txtinicio.Size = new System.Drawing.Size(100, 20);
            this.txtinicio.TabIndex = 10;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(544, 114);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblinicial
            // 
            this.lblinicial.AutoSize = true;
            this.lblinicial.Location = new System.Drawing.Point(227, 117);
            this.lblinicial.Name = "lblinicial";
            this.lblinicial.Size = new System.Drawing.Size(73, 13);
            this.lblinicial.TabIndex = 8;
            this.lblinicial.Text = "Numero inicial";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(307, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numeros pares e impares";
            // 
            // txtfin
            // 
            this.txtfin.BackColor = System.Drawing.SystemColors.Info;
            this.txtfin.Location = new System.Drawing.Point(336, 158);
            this.txtfin.Name = "txtfin";
            this.txtfin.Size = new System.Drawing.Size(100, 20);
            this.txtfin.TabIndex = 14;
            // 
            // lblfinal
            // 
            this.lblfinal.AutoSize = true;
            this.lblfinal.Location = new System.Drawing.Point(227, 158);
            this.lblfinal.Name = "lblfinal";
            this.lblfinal.Size = new System.Drawing.Size(69, 13);
            this.lblfinal.TabIndex = 15;
            this.lblfinal.Text = "Numero Final";
            this.lblfinal.Click += new System.EventHandler(this.label3_Click);
            // 
            // FrmEjercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 618);
            this.Controls.Add(this.lblfinal);
            this.Controls.Add(this.txtfin);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtTabla);
            this.Controls.Add(this.txtinicio);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblinicial);
            this.Controls.Add(this.label1);
            this.Name = "FrmEjercicio4";
            this.Text = "FrmEjercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txtTabla;
        private System.Windows.Forms.TextBox txtinicio;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label lblinicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfin;
        private System.Windows.Forms.Label lblfinal;
    }
}