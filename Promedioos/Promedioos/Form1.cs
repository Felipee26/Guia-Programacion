using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedioos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void cmbGuia_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool habilitarControlLectura = cmbGuia.SelectedItem.ToString() == "20%";
            txtControlLectura.Enabled = habilitarControlLectura;
            cmbControlLectura.Enabled = habilitarControlLectura;
        }

        private void btnCalcularPromedio_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreAlumno.Text) ||
                    string.IsNullOrWhiteSpace(txtParcial.Text) ||
                    string.IsNullOrWhiteSpace(txtGuia.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos requeridos.", "Datos incompletos");
                    return;
                }

                double parcial = Convert.ToDouble(txtParcial.Text) * 0.6;
                double guia = Convert.ToDouble(txtGuia.Text) * (cmbGuia.SelectedItem.ToString() == "40%" ? 0.4 : 0.2);
                double controlLectura = 0;

                if (cmbGuia.SelectedItem.ToString() == "20%" && !string.IsNullOrWhiteSpace(txtControlLectura.Text))
                {
                    controlLectura = Convert.ToDouble(txtControlLectura.Text) * 0.2;
                }

                double promedio = parcial + guia + controlLectura;
                string resultado = $"Nombre: {txtNombreAlumno.Text}\nPromedio: {promedio:F2}\n{(promedio >= 60 ? "APROBÓ" : "REPROBÓ")}";

                MessageBox.Show(resultado, "Resultado");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese solo números válidos en los campos de notas.", "Error de formato");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular: " + ex.Message, "Error");
            }
        }

        private void buttonContacto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollador: [Tu Nombre]\nCarné: [Tu Número de Carné]", "Contacto");
        }
    }
}

