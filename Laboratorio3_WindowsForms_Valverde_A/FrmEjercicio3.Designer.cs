namespace Laboratorio3_WindowsForms_Valverde_A
{
    partial class FrmEjercicio3
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
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lblnumero2 = new System.Windows.Forms.Label();
            this.lblnumero1 = new System.Windows.Forms.Label();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnSuma = new System.Windows.Forms.RadioButton();
            this.rbtnResta = new System.Windows.Forms.RadioButton();
            this.rbtnMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rbtnDivision = new System.Windows.Forms.RadioButton();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(436, 271);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 20;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.BackColor = System.Drawing.Color.Beige;
            this.txtresultado.Location = new System.Drawing.Point(315, 315);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(214, 20);
            this.txtresultado.TabIndex = 19;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(231, 321);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 18;
            this.lblresultado.Text = "Resultado";
            // 
            // lblnumero2
            // 
            this.lblnumero2.AutoSize = true;
            this.lblnumero2.Location = new System.Drawing.Point(233, 237);
            this.lblnumero2.Name = "lblnumero2";
            this.lblnumero2.Size = new System.Drawing.Size(53, 13);
            this.lblnumero2.TabIndex = 17;
            this.lblnumero2.Text = "Numero 2";
            // 
            // lblnumero1
            // 
            this.lblnumero1.AutoSize = true;
            this.lblnumero1.Location = new System.Drawing.Point(233, 190);
            this.lblnumero1.Name = "lblnumero1";
            this.lblnumero1.Size = new System.Drawing.Size(53, 13);
            this.lblnumero1.TabIndex = 16;
            this.lblnumero1.Text = "Numero 1";
            // 
            // txtnumero2
            // 
            this.txtnumero2.BackColor = System.Drawing.Color.Bisque;
            this.txtnumero2.Location = new System.Drawing.Point(315, 234);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(214, 20);
            this.txtnumero2.TabIndex = 15;
            // 
            // txtnumero1
            // 
            this.txtnumero1.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtnumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtnumero1.ForeColor = System.Drawing.Color.Yellow;
            this.txtnumero1.Location = new System.Drawing.Point(315, 185);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(214, 23);
            this.txtnumero1.TabIndex = 14;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(331, 271);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 13;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(297, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Operaciones Aritmeticas";
            // 
            // rbtnSuma
            // 
            this.rbtnSuma.AutoSize = true;
            this.rbtnSuma.Location = new System.Drawing.Point(600, 185);
            this.rbtnSuma.Name = "rbtnSuma";
            this.rbtnSuma.Size = new System.Drawing.Size(52, 17);
            this.rbtnSuma.TabIndex = 21;
            this.rbtnSuma.TabStop = true;
            this.rbtnSuma.Text = "Suma";
            this.rbtnSuma.UseVisualStyleBackColor = true;
            // 
            // rbtnResta
            // 
            this.rbtnResta.AutoSize = true;
            this.rbtnResta.Location = new System.Drawing.Point(599, 208);
            this.rbtnResta.Name = "rbtnResta";
            this.rbtnResta.Size = new System.Drawing.Size(53, 17);
            this.rbtnResta.TabIndex = 22;
            this.rbtnResta.TabStop = true;
            this.rbtnResta.Text = "Resta";
            this.rbtnResta.UseVisualStyleBackColor = true;
            // 
            // rbtnMultiplicacion
            // 
            this.rbtnMultiplicacion.AutoSize = true;
            this.rbtnMultiplicacion.Location = new System.Drawing.Point(599, 237);
            this.rbtnMultiplicacion.Name = "rbtnMultiplicacion";
            this.rbtnMultiplicacion.Size = new System.Drawing.Size(89, 17);
            this.rbtnMultiplicacion.TabIndex = 23;
            this.rbtnMultiplicacion.TabStop = true;
            this.rbtnMultiplicacion.Text = "Multiplicacion";
            this.rbtnMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // rbtnDivision
            // 
            this.rbtnDivision.AutoSize = true;
            this.rbtnDivision.Location = new System.Drawing.Point(599, 260);
            this.rbtnDivision.Name = "rbtnDivision";
            this.rbtnDivision.Size = new System.Drawing.Size(62, 17);
            this.rbtnDivision.TabIndex = 24;
            this.rbtnDivision.TabStop = true;
            this.rbtnDivision.Text = "Division";
            this.rbtnDivision.UseVisualStyleBackColor = true;
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(315, 366);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(35, 13);
            this.lblmensaje.TabIndex = 25;
            this.lblmensaje.Text = "label2";
            this.lblmensaje.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmEjercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.rbtnDivision);
            this.Controls.Add(this.rbtnMultiplicacion);
            this.Controls.Add(this.rbtnResta);
            this.Controls.Add(this.rbtnSuma);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblnumero2);
            this.Controls.Add(this.lblnumero1);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label1);
            this.Name = "FrmEjercicio3";
            this.Text = "FrmEjercicio3";
            this.Load += new System.EventHandler(this.FrmEjercicio3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lblnumero2;
        private System.Windows.Forms.Label lblnumero1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnSuma;
        private System.Windows.Forms.RadioButton rbtnResta;
        private System.Windows.Forms.RadioButton rbtnMultiplicacion;
        private System.Windows.Forms.RadioButton rbtnDivision;
        private System.Windows.Forms.Label lblmensaje;
    }
}