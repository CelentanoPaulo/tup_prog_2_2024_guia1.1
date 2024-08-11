namespace Ejercicio_2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbModeloAño = new System.Windows.Forms.TextBox();
            this.tbAñoCalcular = new System.Windows.Forms.TextBox();
            this.tbValorFabricacion = new System.Windows.Forms.TextBox();
            this.tbTasaDepreciacion = new System.Windows.Forms.TextBox();
            this.tbVidaUtil = new System.Windows.Forms.TextBox();
            this.btnCalcularCosto = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo (Año)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Año a Calcular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valos de Fabricacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tasa de Depreciacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vida util (años)";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(210, 53);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(100, 22);
            this.tbMarca.TabIndex = 6;
            // 
            // tbModeloAño
            // 
            this.tbModeloAño.Location = new System.Drawing.Point(210, 103);
            this.tbModeloAño.Name = "tbModeloAño";
            this.tbModeloAño.Size = new System.Drawing.Size(100, 22);
            this.tbModeloAño.TabIndex = 7;
            // 
            // tbAñoCalcular
            // 
            this.tbAñoCalcular.Location = new System.Drawing.Point(210, 151);
            this.tbAñoCalcular.Name = "tbAñoCalcular";
            this.tbAñoCalcular.Size = new System.Drawing.Size(100, 22);
            this.tbAñoCalcular.TabIndex = 8;
           
            // 
            // tbValorFabricacion
            // 
            this.tbValorFabricacion.Location = new System.Drawing.Point(210, 203);
            this.tbValorFabricacion.Name = "tbValorFabricacion";
            this.tbValorFabricacion.Size = new System.Drawing.Size(100, 22);
            this.tbValorFabricacion.TabIndex = 9;
            // 
            // tbTasaDepreciacion
            // 
            this.tbTasaDepreciacion.Location = new System.Drawing.Point(618, 64);
            this.tbTasaDepreciacion.Name = "tbTasaDepreciacion";
            this.tbTasaDepreciacion.Size = new System.Drawing.Size(100, 22);
            this.tbTasaDepreciacion.TabIndex = 10;
            // 
            // tbVidaUtil
            // 
            this.tbVidaUtil.Location = new System.Drawing.Point(618, 106);
            this.tbVidaUtil.Name = "tbVidaUtil";
            this.tbVidaUtil.Size = new System.Drawing.Size(100, 22);
            this.tbVidaUtil.TabIndex = 11;
            // 
            // btnCalcularCosto
            // 
            this.btnCalcularCosto.Location = new System.Drawing.Point(62, 264);
            this.btnCalcularCosto.Name = "btnCalcularCosto";
            this.btnCalcularCosto.Size = new System.Drawing.Size(116, 45);
            this.btnCalcularCosto.TabIndex = 12;
            this.btnCalcularCosto.Text = "Calcular Costo";
            this.btnCalcularCosto.UseVisualStyleBackColor = true;
            this.btnCalcularCosto.Click += new System.EventHandler(this.btnCalcularCosto_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(210, 264);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 45);
            this.btnCerrar.TabIndex = 13;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 320);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCalcularCosto);
            this.Controls.Add(this.tbVidaUtil);
            this.Controls.Add(this.tbTasaDepreciacion);
            this.Controls.Add(this.tbValorFabricacion);
            this.Controls.Add(this.tbAñoCalcular);
            this.Controls.Add(this.tbModeloAño);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbModeloAño;
        private System.Windows.Forms.TextBox tbAñoCalcular;
        private System.Windows.Forms.TextBox tbValorFabricacion;
        private System.Windows.Forms.TextBox tbTasaDepreciacion;
        private System.Windows.Forms.TextBox tbVidaUtil;
        private System.Windows.Forms.Button btnCalcularCosto;
        private System.Windows.Forms.Button btnCerrar;
    }
}

