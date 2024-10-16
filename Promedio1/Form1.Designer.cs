namespace Promedio1
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
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.txtParcial = new System.Windows.Forms.TextBox();
            this.txtGuia = new System.Windows.Forms.TextBox();
            this.txtControlLec = new System.Windows.Forms.TextBox();
            this.btConsulta = new System.Windows.Forms.Button();
            this.btContacto = new System.Windows.Forms.Button();
            this.cbGuia = new System.Windows.Forms.ComboBox();
            this.cbControlLec = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alumno: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parcial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Guia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Control de lectura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label5.Location = new System.Drawing.Point(453, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parcial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label6.Location = new System.Drawing.Point(453, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "60%";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(190, 45);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(140, 20);
            this.txtAlumno.TabIndex = 6;
            // 
            // txtParcial
            // 
            this.txtParcial.Location = new System.Drawing.Point(190, 119);
            this.txtParcial.Name = "txtParcial";
            this.txtParcial.Size = new System.Drawing.Size(140, 20);
            this.txtParcial.TabIndex = 7;
            // 
            // txtGuia
            // 
            this.txtGuia.Location = new System.Drawing.Point(190, 191);
            this.txtGuia.Name = "txtGuia";
            this.txtGuia.Size = new System.Drawing.Size(140, 20);
            this.txtGuia.TabIndex = 8;
            // 
            // txtControlLec
            // 
            this.txtControlLec.Location = new System.Drawing.Point(190, 248);
            this.txtControlLec.Name = "txtControlLec";
            this.txtControlLec.Size = new System.Drawing.Size(140, 20);
            this.txtControlLec.TabIndex = 9;
            // 
            // btConsulta
            // 
            this.btConsulta.Location = new System.Drawing.Point(23, 348);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(186, 50);
            this.btConsulta.TabIndex = 10;
            this.btConsulta.Text = "Consultar";
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // btContacto
            // 
            this.btContacto.Location = new System.Drawing.Point(442, 348);
            this.btContacto.Name = "btContacto";
            this.btContacto.Size = new System.Drawing.Size(156, 50);
            this.btContacto.TabIndex = 13;
            this.btContacto.Text = "Contacto";
            this.btContacto.UseVisualStyleBackColor = true;
            this.btContacto.Click += new System.EventHandler(this.btContacto_Click);
            // 
            // cbGuia
            // 
            this.cbGuia.FormattingEnabled = true;
            this.cbGuia.Items.AddRange(new object[] {
            "40%",
            "20%"});
            this.cbGuia.Location = new System.Drawing.Point(442, 190);
            this.cbGuia.Name = "cbGuia";
            this.cbGuia.Size = new System.Drawing.Size(172, 21);
            this.cbGuia.TabIndex = 14;
            this.cbGuia.SelectedIndexChanged += new System.EventHandler(this.cbGuia_SelectedIndexChanged);
            // 
            // cbControlLec
            // 
            this.cbControlLec.FormattingEnabled = true;
            this.cbControlLec.Items.AddRange(new object[] {
            "20%",
            "0%"});
            this.cbControlLec.Location = new System.Drawing.Point(442, 248);
            this.cbControlLec.Name = "cbControlLec";
            this.cbControlLec.Size = new System.Drawing.Size(172, 21);
            this.cbControlLec.TabIndex = 15;
            this.cbControlLec.SelectedIndexChanged += new System.EventHandler(this.cbControlLec_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.cbControlLec);
            this.Controls.Add(this.cbGuia);
            this.Controls.Add(this.btContacto);
            this.Controls.Add(this.btConsulta);
            this.Controls.Add(this.txtControlLec);
            this.Controls.Add(this.txtGuia);
            this.Controls.Add(this.txtParcial);
            this.Controls.Add(this.txtAlumno);
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
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.TextBox txtParcial;
        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.TextBox txtControlLec;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Button btContacto;
        private System.Windows.Forms.ComboBox cbGuia;
        private System.Windows.Forms.ComboBox cbControlLec;
    }
}

