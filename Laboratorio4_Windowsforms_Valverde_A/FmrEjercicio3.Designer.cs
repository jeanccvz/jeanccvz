namespace Laboratorio4_Windowsforms_Valverde_A
{
    partial class FmrEjercicio3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(333, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabla de multiplicar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el numero";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(495, 106);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.SystemColors.Info;
            this.txtNumero.Location = new System.Drawing.Point(336, 106);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // txtTabla
            // 
            this.txtTabla.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTabla.Location = new System.Drawing.Point(321, 165);
            this.txtTabla.Multiline = true;
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(127, 239);
            this.txtTabla.TabIndex = 4;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(495, 211);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(495, 163);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 6;
            this.btnlimpiar.Text = "limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FmrEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtTabla);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FmrEjercicio3";
            this.Text = "FmrEjercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtTabla;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnlimpiar;
    }
}