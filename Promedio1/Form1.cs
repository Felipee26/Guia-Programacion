using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedio1
{
    public partial class Form1 : Form
    {
        double c1;
        double resultado;
        string operacion;
        public Form1()
        {
            InitializeComponent();
        }
        double parcial = 0, guia = 0, controlLectura = 0, promedio = 0;

        private void cbControlLec_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbControlLec.Items.Add("20%");
            cbControlLec.Items.Add("0%");
        }

        private void cbGuia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbGuia.Items.Add("40%");
            cbGuia.Items.Add("20%");
        }


        private void btConsulta_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtParcial.Text, out parcial) || parcial < 0 || parcial > 10)
            {
                MessageBox.Show("Por favor, ingrese un valor válido para el parcial.");
                return;
            }

            if (!double.TryParse(txtGuia.Text, out guia) || guia < 0 || guia > 10)
            {
                MessageBox.Show("Por favor, ingrese un valor válido para la guía.");
                return;
            }

            if (!double.TryParse(txtControlLec.Text, out controlLectura) || controlLectura < 0 || controlLectura > 10)
            {
                MessageBox.Show("Por favor, ingrese un valor válido para el control de lectura.");
                return;
            }
            double porcentajeGuia = (cbGuia.SelectedIndex == 1) ? 0.40 : 0.20;
            double porcentajeControlLectura = (cbControlLec.SelectedIndex == 1) ? 0.20 : 0.00;

            // Cálculo del promedio
            promedio = (parcial * 0.60) + (guia * porcentajeGuia) + (controlLectura * porcentajeControlLectura);

            // Mostrar si aprueba o reprueba
            if (promedio >= 6)
            {
                MessageBox.Show($"El estudiante {txtAlumno.Text} ha aprobado con un promedio de {promedio:F2}.");
            }
            else
            {
                MessageBox.Show($"El estudiante {txtAlumno.Text} ha reprobado con un promedio de {promedio:F2}.");
            }
        }


        private void btContacto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Felipe Vega" + "\n25-1294-2023" + "\n7865 8202");
        }

        
    }
}
