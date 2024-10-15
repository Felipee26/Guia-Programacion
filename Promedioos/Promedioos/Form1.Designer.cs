namespace Promedioos
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
            this.cmbGuia = new System.Windows.Forms.ComboBox();
            this.cmbControlLectura = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGuia = new System.Windows.Forms.TextBox();
            this.txtControlLectura = new System.Windows.Forms.TextBox();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.btnCalcularPromedio = new System.Windows.Forms.Button();
            this.btnContacto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbGuia
            // 
            this.cmbGuia.FormattingEnabled = true;
            this.cmbGuia.Items.AddRange(new object[] {
            "40%",
            "20%"});
            this.cmbGuia.Location = new System.Drawing.Point(596, 253);
            this.cmbGuia.Name = "cmbGuia";
            this.cmbGuia.Size = new System.Drawing.Size(121, 21);
            this.cmbGuia.TabIndex = 0;
            // 
            // cmbControlLectura
            // 
            this.cmbControlLectura.FormattingEnabled = true;
            this.cmbControlLectura.Items.AddRange(new object[] {
            "20%",
            "0%"});
            this.cmbControlLectura.Location = new System.Drawing.Point(596, 324);
            this.cmbControlLectura.Name = "cmbControlLectura";
            this.cmbControlLectura.Size = new System.Drawing.Size(121, 21);
            this.cmbControlLectura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOMBRE ALUMNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PARCIAL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "GUIA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CONTROL DE LECTURA";
            // 
            // txtGuia
            // 
            this.txtGuia.Location = new System.Drawing.Point(246, 246);
            this.txtGuia.Name = "txtGuia";
            this.txtGuia.Size = new System.Drawing.Size(149, 20);
            this.txtGuia.TabIndex = 6;
            // 
            // txtControlLectura
            // 
            this.txtControlLectura.Location = new System.Drawing.Point(246, 325);
            this.txtControlLectura.Name = "txtControlLectura";
            this.txtControlLectura.Size = new System.Drawing.Size(149, 20);
            this.txtControlLectura.TabIndex = 7;
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(246, 58);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(149, 20);
            this.txtNombreAlumno.TabIndex = 8;
            // 
            // txtParcial
            // 
            this.txtParcial.Location = new System.Drawing.Point(246, 157);
            this.txtParcial.Name = "txtParcial";
            this.txtParcial.Size = new System.Drawing.Size(149, 20);
            this.txtParcial.TabIndex = 9;
            // 
            // btnCalcularPromedio
            // 
            this.btnCalcularPromedio.Location = new System.Drawing.Point(246, 399);
            this.btnCalcularPromedio.Name = "btnCalcularPromedio";
            this.btnCalcularPromedio.Size = new System.Drawing.Size(136, 27);
            this.btnCalcularPromedio.TabIndex = 10;
            this.btnCalcularPromedio.Text = "CALCULAR PROMEDIO";
            this.btnCalcularPromedio.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCalcularPromedio.UseVisualStyleBackColor = true;
            // 
            // btnContacto
            // 
            this.btnContacto.Location = new System.Drawing.Point(615, 398);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Size = new System.Drawing.Size(75, 23);
            this.btnContacto.TabIndex = 11;
            this.btnContacto.Text = "CONTACTO";
            this.btnContacto.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContacto);
            this.Controls.Add(this.btnCalcularPromedio);
            this.Controls.Add(this.txtParcial);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.txtControlLectura);
            this.Controls.Add(this.txtGuia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbControlLectura);
            this.Controls.Add(this.cmbGuia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbGuia;
        private System.Windows.Forms.ComboBox cmbControlLectura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.TextBox txtControlLectura;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.TextBox txtParcial;
        private System.Windows.Forms.Button btnCalcularPromedio;
        private System.Windows.Forms.Button btnContacto;
    }
}

