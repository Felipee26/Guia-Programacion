namespace Calculadora
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.RbSuma = new System.Windows.Forms.RadioButton();
            this.RbResta = new System.Windows.Forms.RadioButton();
            this.RbDivision = new System.Windows.Forms.RadioButton();
            this.RbMultiplicacion = new System.Windows.Forms.RadioButton();
            this.RbRaiz = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(460, 290);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(103, 42);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(105, 290);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 4;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(88, 107);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(122, 20);
            this.txtNum1.TabIndex = 5;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(88, 208);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(122, 20);
            this.txtNum2.TabIndex = 6;
            // 
            // RbSuma
            // 
            this.RbSuma.AutoSize = true;
            this.RbSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbSuma.Location = new System.Drawing.Point(398, 103);
            this.RbSuma.Name = "RbSuma";
            this.RbSuma.Size = new System.Drawing.Size(36, 24);
            this.RbSuma.TabIndex = 7;
            this.RbSuma.TabStop = true;
            this.RbSuma.Text = "+";
            this.RbSuma.UseVisualStyleBackColor = true;
            // 
            // RbResta
            // 
            this.RbResta.AutoSize = true;
            this.RbResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbResta.Location = new System.Drawing.Point(584, 103);
            this.RbResta.Name = "RbResta";
            this.RbResta.Size = new System.Drawing.Size(32, 24);
            this.RbResta.TabIndex = 8;
            this.RbResta.TabStop = true;
            this.RbResta.Text = "-";
            this.RbResta.UseVisualStyleBackColor = true;
            // 
            // RbDivision
            // 
            this.RbDivision.AutoSize = true;
            this.RbDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbDivision.Location = new System.Drawing.Point(403, 225);
            this.RbDivision.Name = "RbDivision";
            this.RbDivision.Size = new System.Drawing.Size(31, 24);
            this.RbDivision.TabIndex = 9;
            this.RbDivision.TabStop = true;
            this.RbDivision.Text = "/";
            this.RbDivision.UseVisualStyleBackColor = true;
            // 
            // RbMultiplicacion
            // 
            this.RbMultiplicacion.AutoSize = true;
            this.RbMultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbMultiplicacion.Location = new System.Drawing.Point(582, 225);
            this.RbMultiplicacion.Name = "RbMultiplicacion";
            this.RbMultiplicacion.Size = new System.Drawing.Size(34, 24);
            this.RbMultiplicacion.TabIndex = 10;
            this.RbMultiplicacion.TabStop = true;
            this.RbMultiplicacion.Text = "x";
            this.RbMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // RbRaiz
            // 
            this.RbRaiz.AutoSize = true;
            this.RbRaiz.Location = new System.Drawing.Point(460, 168);
            this.RbRaiz.Name = "RbRaiz";
            this.RbRaiz.Size = new System.Drawing.Size(95, 17);
            this.RbRaiz.TabIndex = 11;
            this.RbRaiz.TabStop = true;
            this.RbRaiz.Text = "Raiz Cuadrada";
            this.RbRaiz.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 390);
            this.Controls.Add(this.RbRaiz);
            this.Controls.Add(this.RbMultiplicacion);
            this.Controls.Add(this.RbDivision);
            this.Controls.Add(this.RbResta);
            this.Controls.Add(this.RbSuma);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.RadioButton RbSuma;
        private System.Windows.Forms.RadioButton RbResta;
        private System.Windows.Forms.RadioButton RbDivision;
        private System.Windows.Forms.RadioButton RbMultiplicacion;
        private System.Windows.Forms.RadioButton RbRaiz;
    }
}

