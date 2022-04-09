namespace Laboratorio3_WindowsForms_Valverde_A
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.txtmensaje = new System.Windows.Forms.TextBox();
            this.txtmensaje2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(393, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejercicio1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(416, 297);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizar.TabIndex = 1;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // txtmensaje
            // 
            this.txtmensaje.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtmensaje.ForeColor = System.Drawing.Color.Yellow;
            this.txtmensaje.Location = new System.Drawing.Point(263, 174);
            this.txtmensaje.Name = "txtmensaje";
            this.txtmensaje.Size = new System.Drawing.Size(386, 23);
            this.txtmensaje.TabIndex = 2;
            this.txtmensaje.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtmensaje2
            // 
            this.txtmensaje2.Location = new System.Drawing.Point(263, 233);
            this.txtmensaje2.Name = "txtmensaje2";
            this.txtmensaje2.Size = new System.Drawing.Size(386, 20);
            this.txtmensaje2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtmensaje2);
            this.Controls.Add(this.txtmensaje);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicio_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.TextBox txtmensaje;
        private System.Windows.Forms.TextBox txtmensaje2;
    }
}

