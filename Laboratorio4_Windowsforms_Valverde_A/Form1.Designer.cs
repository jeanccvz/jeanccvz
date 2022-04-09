namespace Laboratorio4_Windowsforms_Valverde_A
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lblnumero2 = new System.Windows.Forms.Label();
            this.lblnumero1 = new System.Windows.Forms.Label();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstOperacion = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(218, 344);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(35, 13);
            this.lblmensaje.TabIndex = 50;
            this.lblmensaje.Text = "label2";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(339, 249);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 49;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.Beige;
            this.txtResultado.Location = new System.Drawing.Point(218, 293);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(214, 20);
            this.txtResultado.TabIndex = 48;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(134, 299);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 47;
            this.lblresultado.Text = "Resultado";
            // 
            // lblnumero2
            // 
            this.lblnumero2.AutoSize = true;
            this.lblnumero2.Location = new System.Drawing.Point(136, 215);
            this.lblnumero2.Name = "lblnumero2";
            this.lblnumero2.Size = new System.Drawing.Size(53, 13);
            this.lblnumero2.TabIndex = 46;
            this.lblnumero2.Text = "Numero 2";
            // 
            // lblnumero1
            // 
            this.lblnumero1.AutoSize = true;
            this.lblnumero1.Location = new System.Drawing.Point(136, 168);
            this.lblnumero1.Name = "lblnumero1";
            this.lblnumero1.Size = new System.Drawing.Size(53, 13);
            this.lblnumero1.TabIndex = 45;
            this.lblnumero1.Text = "Numero 1";
            // 
            // txtnumero2
            // 
            this.txtnumero2.BackColor = System.Drawing.Color.Bisque;
            this.txtnumero2.Location = new System.Drawing.Point(218, 212);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(214, 20);
            this.txtnumero2.TabIndex = 44;
            // 
            // txtnumero1
            // 
            this.txtnumero1.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtnumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtnumero1.ForeColor = System.Drawing.Color.Yellow;
            this.txtnumero1.Location = new System.Drawing.Point(218, 163);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(214, 23);
            this.txtnumero1.TabIndex = 43;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(234, 249);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 42;
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
            this.label1.Location = new System.Drawing.Point(200, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 31);
            this.label1.TabIndex = 41;
            this.label1.Text = "Operaciones Aritmeticas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstOperacion
            // 
            this.lstOperacion.FormattingEnabled = true;
            this.lstOperacion.Location = new System.Drawing.Point(532, 163);
            this.lstOperacion.Name = "lstOperacion";
            this.lstOperacion.Size = new System.Drawing.Size(120, 95);
            this.lstOperacion.TabIndex = 52;
            this.lstOperacion.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstOperacion);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblnumero2);
            this.Controls.Add(this.lblnumero1);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstOperacion;
    }
}

