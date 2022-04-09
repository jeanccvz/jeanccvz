namespace Laboratorio4_Windowsforms_Valverde_A
{
    partial class Frmejercicio2
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
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lblnumero2 = new System.Windows.Forms.Label();
            this.lblnumero1 = new System.Windows.Forms.Label();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(285, 344);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(35, 13);
            this.lblmensaje.TabIndex = 60;
            this.lblmensaje.Text = "label2";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(406, 249);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 59;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.Beige;
            this.txtResultado.Location = new System.Drawing.Point(285, 293);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(214, 20);
            this.txtResultado.TabIndex = 58;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(201, 299);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 57;
            this.lblresultado.Text = "Resultado";
            // 
            // lblnumero2
            // 
            this.lblnumero2.AutoSize = true;
            this.lblnumero2.Location = new System.Drawing.Point(203, 215);
            this.lblnumero2.Name = "lblnumero2";
            this.lblnumero2.Size = new System.Drawing.Size(50, 13);
            this.lblnumero2.TabIndex = 56;
            this.lblnumero2.Text = "Numero2";
            // 
            // lblnumero1
            // 
            this.lblnumero1.AutoSize = true;
            this.lblnumero1.Location = new System.Drawing.Point(203, 168);
            this.lblnumero1.Name = "lblnumero1";
            this.lblnumero1.Size = new System.Drawing.Size(50, 13);
            this.lblnumero1.TabIndex = 55;
            this.lblnumero1.Text = "Numero1";
            // 
            // txtNumero2
            // 
            this.txtNumero2.BackColor = System.Drawing.Color.Bisque;
            this.txtNumero2.Location = new System.Drawing.Point(285, 212);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(214, 20);
            this.txtNumero2.TabIndex = 54;
            this.txtNumero2.TextChanged += new System.EventHandler(this.txtnumero2_TextChanged);
            // 
            // txtNumero1
            // 
            this.txtNumero1.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtNumero1.ForeColor = System.Drawing.Color.Yellow;
            this.txtNumero1.Location = new System.Drawing.Point(285, 163);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(214, 23);
            this.txtNumero1.TabIndex = 53;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(301, 249);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 52;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(267, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 31);
            this.label1.TabIndex = 51;
            this.label1.Text = "Operaciones Aritmeticas";
            // 
            // Frmejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblnumero2);
            this.Controls.Add(this.lblnumero1);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Name = "Frmejercicio2";
            this.Text = "Frmejercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lblnumero2;
        private System.Windows.Forms.Label lblnumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
    }
}