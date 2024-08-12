namespace Ejercicio_1
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
            this.btnIniciarViaje = new System.Windows.Forms.Button();
            this.btnIngresarParada = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFinalizarVIaje = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMMfinalizacion = new System.Windows.Forms.TextBox();
            this.tbHHfinalizacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIniciarViaje
            // 
            this.btnIniciarViaje.Location = new System.Drawing.Point(21, 12);
            this.btnIniciarViaje.Name = "btnIniciarViaje";
            this.btnIniciarViaje.Size = new System.Drawing.Size(314, 33);
            this.btnIniciarViaje.TabIndex = 0;
            this.btnIniciarViaje.Text = "Iniciar Viaje";
            this.btnIniciarViaje.UseVisualStyleBackColor = true;
            this.btnIniciarViaje.Click += new System.EventHandler(this.btnIniciarViaje_Click);
            // 
            // btnIngresarParada
            // 
            this.btnIngresarParada.Location = new System.Drawing.Point(21, 41);
            this.btnIngresarParada.Name = "btnIngresarParada";
            this.btnIngresarParada.Size = new System.Drawing.Size(314, 32);
            this.btnIngresarParada.TabIndex = 1;
            this.btnIngresarParada.Text = "Ingresar Parada";
            this.btnIngresarParada.UseVisualStyleBackColor = true;
            this.btnIngresarParada.Click += new System.EventHandler(this.btnIngresarParada_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFinalizarVIaje);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbMMfinalizacion);
            this.groupBox1.Controls.Add(this.tbHHfinalizacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 102);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Finalizar Parada";
            // 
            // btnFinalizarVIaje
            // 
            this.btnFinalizarVIaje.Location = new System.Drawing.Point(187, 68);
            this.btnFinalizarVIaje.Name = "btnFinalizarVIaje";
            this.btnFinalizarVIaje.Size = new System.Drawing.Size(121, 28);
            this.btnFinalizarVIaje.TabIndex = 3;
            this.btnFinalizarVIaje.Text = "Finalizar Viaje";
            this.btnFinalizarVIaje.UseVisualStyleBackColor = true;
            this.btnFinalizarVIaje.Click += new System.EventHandler(this.btnFinalizarVIaje_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = ":";
            // 
            // tbMMfinalizacion
            // 
            this.tbMMfinalizacion.Location = new System.Drawing.Point(260, 31);
            this.tbMMfinalizacion.Name = "tbMMfinalizacion";
            this.tbMMfinalizacion.Size = new System.Drawing.Size(48, 22);
            this.tbMMfinalizacion.TabIndex = 2;
            // 
            // tbHHfinalizacion
            // 
            this.tbHHfinalizacion.Location = new System.Drawing.Point(190, 31);
            this.tbHHfinalizacion.Name = "tbHHfinalizacion";
            this.tbHHfinalizacion.Size = new System.Drawing.Size(48, 22);
            this.tbHHfinalizacion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora de Finalizacion (HH:MM) ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 195);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIngresarParada);
            this.Controls.Add(this.btnIniciarViaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarViaje;
        private System.Windows.Forms.Button btnIngresarParada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFinalizarVIaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMMfinalizacion;
        private System.Windows.Forms.TextBox tbHHfinalizacion;
        private System.Windows.Forms.Label label1;
    }
}

